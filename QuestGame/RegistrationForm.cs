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
            if (firstNameTextBox.Text.Trim() == "") {
                MessageBox.Show("Не запольнено имя!");
            }
            if (lastNameTextBox.Text.Trim() == "") {
                MessageBox.Show("Не запольнена фамилия!");
            }
            if (middleNameTextBox.Text.Trim() == "") {
                MessageBox.Show("Не запольнено отчество!");
            }
            if (manRadioButton.Checked == false && womanRadioButton.Checked == false && noGenderRadioButton.Checked == false) {
                MessageBox.Show("Необходимо указать пол!");
            }
            if (cityComboBox.Text == "") {
                MessageBox.Show("Не запольнен город проживания!");
            }
            if (phoneNumberMaskedTextBox.Text == "") {
                MessageBox.Show("Необходимо указать номер телефона!");
            }
            if (emailTextBox.Text == "" || emailComboBox.Text == "") {
                MessageBox.Show("Необходимо указать почтовый адрес!");
            }
            if (passwordTextBox.Text == "") {
                MessageBox.Show("Вы не установили пароль!");
            }
            if (repeatPasswordTextBox.Text == "") {
                MessageBox.Show("Введите пароль повторно");
            }
            Users user = new Users();
            user.FirstName = firstNameTextBox.Text.Trim();
            user.LastNname = lastNameTextBox.Text.Trim();
            user.MiddleName = middleNameTextBox.Text.Trim();
            if (manRadioButton.Checked) {
                user.Gender = "Мужской";
            }
            else if (womanRadioButton.Checked) {
                user.Gender = "Женский";
            }
            else {
                user.Gender = "Не указан";
            }
            user.Birthday = DateTime.Parse(birthdayDateTimePicker.Text.Trim());
            user.City = cityComboBox.Text.Trim();
            user.Phone = phoneNumberMaskedTextBox.Text.Trim();
            user.Email = emailTextBox.Text.Trim() + emailComboBox.Text.Trim();
            user.Password = passwordTextBox.Text.Trim();
            if (passwordTextBox.Text == repeatPasswordTextBox.Text) {
                toolStripStatusLabel1.Text = "Пароль прошел проверку.";
            }
            else {
                MessageBox.Show("Пароли не совпадают.");
            }
            try {
                DBmanagement.AddUser(user);
                MessageBox.Show("Вы успешно зарегестрировались!");
            }
            catch (Exception ex) {
                MessageBox.Show("Ошибка при регистрации: " + ex.Message);
            }
            Close();
        }

        private void loadPhotoButton_Click(object sender, EventArgs e) {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
                openFileDialog.Filter = "image files (*.jpg, *.jpeg, *.png) | *.jpg, *.jpeg, *.png";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    registrationPictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }
    }
}
