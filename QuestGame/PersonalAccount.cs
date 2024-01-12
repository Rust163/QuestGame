using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestGame {
    public partial class PersonalAccount : Form {
        public static string connectionString = ConfigurationManager.ConnectionStrings["ConnStringQuest"].ConnectionString;
        public PersonalAccount() {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void PersonalAccount_Load(object sender, EventArgs e) {
            Users users = new Users();
            users.FirstName = userAccountFirstNameTextBox.Text;
            users.LastNname = userAccountLastNameTextBox.Text;
            users.MiddleName = userAccountMiddleNameTextBox.Text;
            users.Gender = userAccountGenderTextBox.Text;
            //users.Birthday = DateTime.Parse(userAccountAgeTextBox.Text.Trim());
            users.City = userAccountCityTextBox.Text;
            users.Phone = userAccountPhoneTextBox.Text;
            users.Email = userAccountEmailTextBox.Text;
            try {
                DBmanagement.ShowPersonalAccountInfo(users);
            } catch(Exception ex) {
                MessageBox.Show("Ошибка загрузки данных" + ex.Message);
            }
        }
    }
}
