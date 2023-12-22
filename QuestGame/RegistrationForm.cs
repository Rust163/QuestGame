using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestGame {
    public partial class RegistrationForm : Form {
        List<string> images;
        public RegistrationForm() {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            NewDir();
            images = new List<string>();
            LoadPhoto();
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

        //private void hidePassword() {
        //    passwordTextBox.PasswordChar = '●';
        //    showPassPictureBox.Visible = true;
        //}
        //
        //private void hideRepeatPassword() {
        //    repeatPasswordTextBox.PasswordChar = '●';
        //    showPassRepeatPictureBox.Visible = true;
        //}

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
            user.Photo = photoLoadTextBox.Text.Trim();
            user.Password = CryptPass.cryptPassword(passwordTextBox.Text.Trim());
            if (user.Password == CryptPass.cryptPassword(repeatPasswordTextBox.Text)) {
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

        private void hidePassPictureBox_Click(object sender, EventArgs e) {
            passwordTextBox.UseSystemPasswordChar = false;
            hidePassPictureBox.Visible = false;
            showPassPictureBox.Visible = true;
        }

        private void showPassPictureBox_Click(object sender, EventArgs e) {
            passwordTextBox.UseSystemPasswordChar = true;
            hidePassPictureBox.Visible = true;
            showPassPictureBox.Visible = false;
        }

        private void hidePassRepeatPictureBox_Click(object sender, EventArgs e) {
            repeatPasswordTextBox.UseSystemPasswordChar = false;
            hidePassRepeatPictureBox.Visible = false;
            showPassRepeatPictureBox.Visible = true;
        }

        private void showPassRepeatPictureBox_Click(object sender, EventArgs e) {
            repeatPasswordTextBox.UseSystemPasswordChar = true;
            hidePassRepeatPictureBox.Visible = true;
            showPassRepeatPictureBox.Visible = false;
        }

        private void LoadPhoto() {
            images.Clear();
            images = Directory.GetFiles("UserPhotos").ToList();
            //listBox1.DataSource = images;
        }

        private void NewDir() {
            if (!Directory.Exists(Directory.GetCurrentDirectory() + "UserPhotos")) {
                Directory.CreateDirectory("UserPhotos");
            }
        }

        private void openPhotoButton_Click(object sender, EventArgs e) {
            openFileDialog1.Filter = "Изображения|*.jpg;*.gif;*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                foreach (var fileName in openFileDialog1.FileNames) {
                    CopyPhotoToDir(fileName);
                }

            }
        }

        private void CopyPhotoToDir(string fileName) {
            var path = fileName.Split('\\');
            long currentTime = DateTimeOffset.Now.ToUnixTimeSeconds();
            File.Copy(fileName, "UserPhotos\\" + currentTime.ToString() + "_" + path[path.Length - 1]);
            LoadPhoto();
        }
    }
}
