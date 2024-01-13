using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Kyrsach
{
    public class DBHelper
    {
        private string databaseFileName = "MyDB.sqlite";
        private string databasePath;

        public DBHelper()
        {
            databasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, databaseFileName);
        }

        public void InitializeDatabase()
        {
            if (!File.Exists(databasePath))
            {
                SQLiteConnection.CreateFile(databasePath);
            }
            string connectionString = $"Data Source={databasePath};Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Создание таблицы для хранения логинов и хэшированных паролей
                string createTableQuery = "CREATE TABLE IF NOT EXISTS UserCredentials (ID INTEGER PRIMARY KEY AUTOINCREMENT, Username TEXT, PasswordHash TEXT)";
                using (SQLiteCommand command = new SQLiteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
            
        }

        public bool RegisterUser(string username, string password)
        {
            // Проверка наличия пользователя с таким именем
            if (UserExists(username))
            {
                return false;
            }

            // Хэширование пароля перед сохранением в базе данных
            string hashedPassword = HashPassword(password);

            string insertDataQuery = "INSERT INTO UserCredentials (Username, PasswordHash) VALUES (@Username, @PasswordHash)";
            using (SQLiteConnection connection = new SQLiteConnection($"Data Source={databasePath};Version=3;"))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(insertDataQuery, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@PasswordHash", hashedPassword);
                    command.ExecuteNonQuery();
                }
            }
            return true;
        }

        public bool ValidateLogin(string username, string password)
        {
            string selectDataQuery = "SELECT PasswordHash FROM UserCredentials WHERE Username = @Username";
            using (SQLiteConnection connection = new SQLiteConnection($"Data Source={databasePath};Version=3;"))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(selectDataQuery, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Проверка введенного пароля с хэшированным паролем из базы данных
                            string storedPasswordHash = reader["PasswordHash"].ToString();
                            return VerifyPassword(password, storedPasswordHash);
                        }
                    }
                }
            }
            return false;
        }
        public bool DeleteUser(string username)
        {
            if (!UserExists(username))
            {
                // Если пользователя с таким логином не существует, возвращаем false
                return false;
            }

            string deleteDataQuery = "DELETE FROM UserCredentials WHERE Username = @Username";
            using (SQLiteConnection connection = new SQLiteConnection($"Data Source={databasePath};Version=3;"))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(deleteDataQuery, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.ExecuteNonQuery();
                }
            }
            return true;
        }

        private bool UserExists(string username)
        {
            string checkUserQuery = "SELECT COUNT(*) FROM UserCredentials WHERE Username = @Username";
            using (SQLiteConnection connection = new SQLiteConnection($"Data Source={databasePath};Version=3;"))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(checkUserQuery, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    long count = (long)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }

        private bool VerifyPassword(string enteredPassword, string storedPasswordHash)
        {
            return HashPassword(enteredPassword) == storedPasswordHash;
        }


    }
}
