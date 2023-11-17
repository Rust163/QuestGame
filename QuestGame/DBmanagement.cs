
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
                    "Password NVARCHAR(50) NOT NULL);";
                SqlCommand createTable = new SqlCommand(queryTable, conn);
                createTable.ExecuteNonQuery();
            }
        }

        public static int AddUser(Users user) {
            using(var conn = new SqlConnection(connectionString)) {
                conn.Open();
                string queryAddUser = $"INSERT INTO RegistrationTable VALUES ('{user.FirstName}', '{user.LastNname}', '{user.MiddleName}','{user.Gender}', '{user.BirthdayToUnixTimeStamp()}', '{user.City}', '{user.Phone}', '{user.Email}', '{user.Password}')";
                SqlCommand insertUser = new SqlCommand(queryAddUser, conn);
                return insertUser.ExecuteNonQuery();   
            }
        }
    }
}
