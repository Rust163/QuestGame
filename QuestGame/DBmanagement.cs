using System.Configuration;
using System.Data.SqlClient;
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
                SqlCommand insertUser = new SqlCommand(queryAddUser, conn);
                insertUser.ExecuteNonQuery();   
            }
        }

        public static void ShowPersonalAccountInfo(Users users) {
            using (SqlConnection conn = new SqlConnection(connectionString)) {
                conn.Open();
                string queryShowInfoUser = $"SELECT * FROM RegistrationTable " +
                    $"'{users.FirstName}' AND " +
                    $"'{users.LastNname}' AND " +
                    $"'{users.MiddleName}' AND " +
                    $"'{users.Gender}' AND " +
                    $"'{users.BirthdayToUnixTimeStamp()}' AND " +
                    $"'{users.City}' AND " +
                    $"'{users.Phone}' AND " +
                    $"'{users.Email}'";
                SqlCommand showInfoUser = new SqlCommand(queryShowInfoUser, conn);
                showInfoUser.ExecuteNonQuery();
            }
        }
    }
}
