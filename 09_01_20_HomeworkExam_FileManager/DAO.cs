using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_01_20_HomeworkExam_FileManager
{
    class DAO
    {
        private SQLiteConnection _connection = new SQLiteConnection();
        private SQLiteCommand _command = new SQLiteCommand();
        public DAO()
        {
            _connection.ConnectionString = ConfigurationManager.ConnectionStrings["thisProjectDatabase"].ConnectionString.Replace(@"_database_location_directory", $"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName}");

            _command.CommandType = System.Data.CommandType.Text;
            _command.Connection = _connection;

            FlexibleMessageBox.MAX_WIDTH_FACTOR = Screen.PrimaryScreen.WorkingArea.Width;
            FlexibleMessageBox.MAX_HEIGHT_FACTOR = Screen.PrimaryScreen.WorkingArea.Height;
        }
        public Dictionary<string, object> ExecuteAlekStoredProsedure(string procedureQuery)
        {
            Dictionary<string, object> toReturn = new Dictionary<string, object>();
            try
            {
                _connection.Open();
                _command.CommandText = procedureQuery;
                using (SQLiteDataReader reader = _command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            toReturn.Add(reader.GetName(i), reader.GetValue(i));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                FlexibleMessageBox.Show($"{ex.GetType().Name}\n\n{ex.Message}\n\n{ex.StackTrace}");
            }
            finally
            {
                _connection.Close();
            }
            return toReturn;
        }
        public bool IsConnectionEstablished(out string connectionString)
        {
            if (_connection != null)
            {
                connectionString = _connection.ConnectionString;
                try
                {
                    _connection.Open();
                }
                catch(Exception ex)
                {
                    connectionString = $"{ex.Message}\nThe connection string is in wrong format.";
                    return false;
                }
                finally
                {
                    _connection.Close();
                }                
                return true;
            }
            connectionString = "the connection is null, so no connection string";
            return false;
        }
        public void AddGrade(Student student, Course course, int grade)
        {
            try
            {
                _connection.Open();
                _command.CommandText = $"INSERT INTO Grades (COURSE_ID, STUDENT_ID, GRADE, STUDENT_EXT_ID, COURSE_EXT_ID) VALUES ({course.ID}, {student.ID}, {grade}, '{student.EXTERNAL_ID}', '{course.EXTERNAL_ID}')";
                _command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _connection.Close();
            }
            

        }
        public Dictionary<string, int> ShowCourseStatistics(Course course)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            try
            {                
                _connection.Open();                
                _command.CommandText = $"SELECT AVG_GRADE as 'הציון הממוצע', NUM_OF_STUDENTS as 'מספר הסטודנטים', HIGHEST_GRADE as 'הציון הכי גבוה' FROM Courses WHERE EXTERNAL_ID = '{course.EXTERNAL_ID}'";
                using (SQLiteDataReader reader = _command.ExecuteReader())
                {                    
                    while(reader.Read())
                    {
                        for(int i = 0; i < reader.FieldCount; i++)
                        {
                            int readerValueInt = 0;
                            if (!(reader.GetValue(i) is DBNull)) readerValueInt = Convert.ToInt32(reader.GetValue(i));
                            dict.Add(reader.GetName(i), readerValueInt);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                FlexibleMessageBox.Show($"{ex.GetType().Name}\n\n{ex.Message}\n\n{ex.StackTrace}");
            }
            finally
            {
                _connection.Close();
            }
            return dict;
        }
        public void DeleteAllWithDBNull(params Type[] types)
        {
            try
            {
                _connection.Open();
                for (int i = 0; i < types.Length; i++)
                {
                    for (int j = 0; j < types[i].GetProperties().Length; j++)
                    {
                        _command.CommandText = $"DELETE FROM {types[i].Name}s WHERE {types[i].GetProperties()[j].Name} IS NULL";
                        _command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                FlexibleMessageBox.Show($"{ex.GetType().Name}\n\n{ex.Message}\n\n{ex.StackTrace}");
            }
            finally
            {
                _connection.Close();
            }
        }
        public void DeleteOne<T>(T something)
        {
            string tableName = typeof(T).Name + "s";
            try
            {
                _connection.Open();
                _command.CommandText = $"DELETE FROM {tableName} WHERE EXTERNAL_ID = '{typeof(T).GetProperty("EXTERNAL_ID").GetValue(something)}'";
                _command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                FlexibleMessageBox.Show($"{ex.GetType().Name}\n\n{ex.Message}\n\n{ex.StackTrace}");
            }
            finally
            {
                _connection.Close();
            }
        }

        public void InsertValueToTable<T>(T insertValueHoldingPoco)
        {
            string tableName = typeof(T).Name + "s";
            try
            {
                _connection.Open();

                _command.CommandText = $"INSERT INTO {tableName} ({insertValueHoldingPoco.GetType().GetProperties()[1].Name}) VALUES ('{insertValueHoldingPoco.GetType().GetProperties()[1].GetValue(insertValueHoldingPoco)}')";
                _command.ExecuteNonQuery();

                for (int i = 2; i < insertValueHoldingPoco.GetType().GetProperties().Length; i++)
                {
                    var val = insertValueHoldingPoco.GetType().GetProperties()[i].GetValue(insertValueHoldingPoco);
                    if (!Int32.TryParse(val.ToString(), out int numVal)) val = $"'{val}'";
                    _command.CommandText = $"UPDATE {tableName} SET {insertValueHoldingPoco.GetType().GetProperties()[i].Name} = {val} WHERE {insertValueHoldingPoco.GetType().GetProperties()[1].Name} = '{insertValueHoldingPoco.GetType().GetProperties()[1].GetValue(insertValueHoldingPoco)}'";
                    _command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                FlexibleMessageBox.Show($"{ex.GetType().Name}\n\n{ex.Message}\n\n{ex.StackTrace}");
            }
            finally
            {
                _connection.Close();
            }
        }
        public List<Course> GetAllCourses()
        {
            return GetAllInternal<Course>();
        }
        public List<Student> GetAllStudents()
        {
            return GetAllInternal<Student>();
        }
        private List<T> GetAllInternal<T>() where T : new()
        {
            List<T> toReturn = new List<T>();
            string tableName = typeof(T).Name + "s";
            try
            {
                _connection.Open();
                _command.CommandText = $"SELECT * FROM {tableName}";

                using (SQLiteDataReader reader = _command.ExecuteReader())
                {
                    while(reader.Read())                    
                    {
                        T something = new T();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            var readerValue = reader.GetValue(i);                            
                            if (readerValue is long) readerValue = Convert.ToInt32(readerValue);
                            if (readerValue is DBNull) readerValue = null;
                            typeof(T).GetProperties()[i].SetValue(something, readerValue); 
                        }
                        toReturn.Add(something);
                        
                    }
                }                
            }
            catch (Exception ex)
            {
                FlexibleMessageBox.Show($"{ex.GetType().Name}\n\n{ex.Message}\n\n{ex.StackTrace}");
            }
            finally
            {
                _connection.Close();
            }
            return toReturn;
        }




    }
}
