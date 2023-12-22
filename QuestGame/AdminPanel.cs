using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuestGame {
    public partial class AdminPanel : Form {
        public AdminPanel() {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
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



        private void FindUser() {
            for (int i = 0; i < dataGridView1.RowCount; i++) {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++) {
                    if (dataGridView1.Rows[i].Cells[j].Value != null) {
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(searchUserTextBox.Text)) {
                            dataGridView1.Rows[i].Selected = true;
                        }
                    }
                }
            }
        }

        public void UsersInfo() {
            dataGridView1.DataSource = DBmanagement.ShowAllUsers();
        }

        private void showAllUsersButton_Click(object sender, EventArgs e) {
            UsersInfo();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) {


            try {
                cartFirstNameTextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                cartLastNameTextBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                cartMiddleNameTextBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                cartGenderTextBox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                cartAgeTextBox.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                cartCityTextBox.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                cartPhoneTextBox.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                cartEmailTextBox.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                cartUserPhotoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                string path = dataGridView1[9, e.RowIndex].Value.ToString();
                Bitmap bmp = (Bitmap)Image.FromFile(path);
                cartUserPhotoPictureBox.Image = bmp;
            }
            catch (Exception ex) {
                MessageBox.Show("У этого пользователя не загруженно фото: " + ex.Message);
            }
        }

        private void searchUserButton_Click(object sender, EventArgs e) {
            FindUser();
        }

        private void exitAdminPanelButton_Click(object sender, EventArgs e) {
            Close();
        }

        private void deleteUserButton_Click(object sender, EventArgs e) {
            int indexString = dataGridView1.CurrentRow.Index;
            if (indexString >= 0) {
                DBmanagement.DeletDataUser();
            }
        }
    }
}
