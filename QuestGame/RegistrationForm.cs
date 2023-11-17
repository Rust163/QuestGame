using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class RegistrationForm : Form {
        public RegistrationForm() {
            InitializeComponent();
        }

        private void backFormRegButton_Click(object sender, EventArgs e) {
            Close();
        }

        private void createDataBaseToolStripMenuItem_Click(object sender, EventArgs e) {
            try {
                DBmanagement.CreateDatabase();
                MessageBox.Show("База данных создана!");
            }
            catch (Exception ex) {
                MessageBox.Show("Ошибка создания базы данных: " + ex.Message);
            }

        }

        private void createTableToolStripMenuItem_Click(object sender, EventArgs e) {
            try {
                DBmanagement.CreateTable();
                MessageBox.Show("Таблица пользователей создана!");
            }
            catch (Exception ex) {
                MessageBox.Show("Ошибка создания таблицы пользователей: " + ex.Message);
            }

        }

        private void RegButton_Click(object sender, EventArgs e) {
            Users user = new Users();
            //try {
                DBmanagement.AddUser(user);
                //MessageBox.Show("Вы успешно зарегестрировались!");
            //}
            //catch (Exception ex) {
                //MessageBox.Show("Ошибка при регистрации: " + ex.Message);
            //}

        }
    }
}
