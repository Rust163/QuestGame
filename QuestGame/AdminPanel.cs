using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestGame {
    public partial class AdminPanel : Form {
        public AdminPanel() {
            InitializeComponent();
        }

        private void searchUserTextBox_TextChanged(object sender, EventArgs e) {

        }

        private void searchUserTextBox_Enter(object sender, EventArgs e) {
            if (searchUserTextBox.Text == "Введите ФИО либо Id пользователя") {
                searchUserTextBox.Text = "";
            }
        }

        private void searchUserTextBox_Leave(object sender, EventArgs e) {
            if (searchUserTextBox.Text == "") {
                searchUserTextBox.Text = "Введите ФИО либо Id пользователя";
            }
        }

        private void exitAdminPanelButton_Click(object sender, EventArgs e) {
            Close();
        }

        private void searchUserButton_Click(object sender, EventArgs e) {
            //string searchUserStr = searchUserTextBox.Text;
            //if (searchUserStr == )
            //SearchUser();
        }

        public void UsersInfo() {
            dataGridView1.DataSource = DBmanagement.ShowAllUsers();
        }

        private void showAllUsersButton_Click(object sender, EventArgs e) {
            UsersInfo();
        }

        private void searchUserTextBox_TextChanged_1(object sender, EventArgs e) {

        }
    }
}
