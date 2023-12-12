
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestGame {
    internal static class DBmanagement {
        public static string connectionString = ConfigurationManager.ConnectionStrings["ConnStringQuest"].ConnectionString;
        public static string pathToFile = @"C:\Users\rust\source\repos\QuestGame\QuestGame\UsersPhoto";
        public static void CreateDatabase() {
            using (SqlConnection conn = new SqlConnection(connectionString)) {
                conn.Open();
                string queryDB = "CREATE DATABASE QuestGame";
                SqlCommand createDB = new SqlCommand(queryDB, conn);
                createDB.ExecuteNonQuery();
            }
        }

        public static void CreateTable() {
            using (SqlConnection conn = new SqlConnection(connectionString)) {
                conn.Open();
                string queryTable = "CREATE TABLE RegistrationTable(" +
                    "Id INT PRIMARY KEY IDENTITY," +
                    "FirstName NVARCHAR(50) NOT NULL," +
                    "LastName NVARCHAR(50) NOT NULL," +
                    "MiddleName NVARCHAR(50) NOT NULL," +
                    "Gender NVARCHAR(50) NOT NULL," +
                    "Birthday INT NOT NULL," +
                    "City NVARCHAR(50) NOT NULL," +
                    "Phone NVARCHAR(50) NOT NULL," +
                    "Email NVARCHAR(50) NOT NULL," +
                    "Photo NVARCHAR(50) NOT NULL," +
                    "Password NVARCHAR(50) NOT NULL);";
                SqlCommand createTable = new SqlCommand(queryTable, conn);
                createTable.ExecuteNonQuery();
            }
        }

        public static void AddUser(Users user) {
            using(SqlConnection conn = new SqlConnection(connectionString)) {
                conn.Open();
                string queryAddUser = $"INSERT INTO RegistrationTable VALUES (N'{user.FirstName}', N'{user.LastNname}', N'{user.MiddleName}', N'{user.Gender}', N'{user.BirthdayToUnixTimeStamp()}', N'{user.City}', N'{user.Phone}', N'{user.Email}', N'{user.Photo}', N'{user.Password}')";
                //RegistrationForm registration = new RegistrationForm();
                SqlCommand insertUser = new SqlCommand(queryAddUser, conn);
                insertUser.ExecuteNonQuery();   
            }
        }

        public static void SearchUser() {
            using (SqlConnection conn = new SqlConnection(connectionString)) {
                conn.Open();
                string querySearchUser = "SELECT FirstName + LastName + MiddleName AS FullName FROM RegistrationTable";
                SqlCommand searchUser = new SqlCommand(querySearchUser, conn);
                searchUser.ExecuteNonQuery();
            }
        }

        public static List<Users> ShowAllUsers() {
            List<Users> users = new List<Users>();
            using(SqlConnection conn = new SqlConnection(connectionString)) {
                conn.Open();
                string getUsers = "SELECT * FROM RegistrationTable";
                SqlCommand queryGetUsers = new SqlCommand(getUsers, conn);
                using(SqlDataReader reader = queryGetUsers.ExecuteReader()) {
                    if(reader.HasRows) {
                        while(reader.Read()) {
                            Users user = new Users();
                            user.Id = reader.GetInt32(0);
                            user.FirstName = reader.GetString(1);
                            user.LastNname = reader.GetString(2);
                            user.MiddleName = reader.GetString(3);
                            user.Gender = reader.GetString(4);
                            user.SetBirthdayfromUTS(reader.GetInt32(5));
                            user.City = reader.GetString(6);
                            user.Phone = reader.GetString(7);
                            user.Email = reader.GetString(8);
                            user.Photo = reader.GetString(9);
                            user.Password = reader.GetString(10);
                            users.Add(user);
                        }
                    }
                }
            }
            return users;
        }
    }
}
