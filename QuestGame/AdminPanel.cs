

using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace QuestGame {
    enum RowState {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }

    public partial class AdminPanel : Form {
        public static string connectionString = ConfigurationManager.ConnectionStrings["ConnStringQuest"].ConnectionString;
        public AdminPanel() {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void AdminPanel_Load(object sender, EventArgs e) {
            renameColumns();
            ShowAllUsers(dataGridView1);
        }

        private void renameColumns() {
            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns.Add("FirstName", "Имя");
            dataGridView1.Columns.Add("LastName", "Фамилия");
            dataGridView1.Columns.Add("MiddleName", "Отчество");
            dataGridView1.Columns.Add("Gender", "Пол");
            dataGridView1.Columns.Add("Birthday", "Дата рождения");
            dataGridView1.Columns.Add("City", "Город");
            dataGridView1.Columns.Add("Phone", "Номер телефона");
            dataGridView1.Columns.Add("Email", "Адрес электронной почты");
            dataGridView1.Columns.Add("Photo", "Фотография");
            dataGridView1.Columns.Add("Password", "Пароль");
            dataGridView1.Columns.Add("isNew", String.Empty);
        }

        public void readSingleRow(DataGridView dgw, IDataRecord read) {
            dgw.Rows.Add(
                read.GetInt32(0),
                read.GetString(1),
                read.GetString(2),
                read.GetString(3),
                read.GetString(4),
                read.GetValue(5),
                read.GetString(6),
                read.GetString(7),
                read.GetString(8),
                read.GetString(9),
                read.GetString(10),
                RowState.ModifiedNew
                );
        }

        private void ShowAllUsers(DataGridView dgw) {
            using (SqlConnection conn = new SqlConnection(connectionString)) {
                conn.Open();
                string getUsers = "SELECT * FROM RegistrationTable";
                SqlCommand queryGetUsers = new SqlCommand(getUsers, conn);
                using (SqlDataReader reader = queryGetUsers.ExecuteReader()) {
                    while (reader.Read()) {
                        readSingleRow(dgw, reader);
                    }
                }
            }
        }

        private void FindUser(DataGridView dgw) {
            dgw.Rows.Clear();
            using (SqlConnection conn = new SqlConnection(connectionString)) {
                conn.Open();
                string querySearchUser = $"SELECT * FROM RegistrationTable WHERE CONCAT(Id, FirstName, LastName, MiddleName, Gender, City, Email) LIKE N'%" + searchUserTextBox.Text + "%'";
                SqlCommand querySearch = new SqlCommand(querySearchUser, conn);
                using (SqlDataReader reader = querySearch.ExecuteReader()) {
                    while (reader.Read()) {
                        readSingleRow(dgw, reader);
                    }
                }
            }
        }

        private void deleteUserRow() {
            if (MessageBox.Show("Вы уверены что хотите удалить пользователя?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                int index = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows[index].Visible = false;
                if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty) {
                    dataGridView1.Rows[index].Cells[11].Value = RowState.Deleted;
                }
                using (SqlConnection conn = new SqlConnection(connectionString)) {
                    conn.Open();
                    var rowState = dataGridView1.Rows[index].Cells[0].Value;
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    string queryDel = $"DELETE FROM RegistrationTable WHERE Id = {id}";

                    SqlCommand deleteUser = new SqlCommand(queryDel, conn);
                    deleteUser.ExecuteNonQuery();
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) {
            int selectedRow = e.RowIndex;
            if (e.RowIndex >= 0) {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                try {

                    cartUserPhotoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    string path = dataGridView1[9, e.RowIndex].Value.ToString();
                    Bitmap bmp = (Bitmap)Image.FromFile(path);
                    cartUserPhotoPictureBox.Image = bmp;
                    cartFirstNameTextBox.Text = row.Cells[1].Value.ToString();
                    cartLastNameTextBox.Text = row.Cells[2].Value.ToString();
                    cartMiddleNameTextBox.Text = row.Cells[3].Value.ToString();
                    cartGenderTextBox.Text = row.Cells[4].Value.ToString();
                    cartAgeTextBox.Text = row.Cells[5].Value.ToString();
                    cartCityTextBox.Text = row.Cells[6].Value.ToString();
                    cartPhoneTextBox.Text = row.Cells[7].Value.ToString();
                    cartEmailTextBox.Text = row.Cells[8].Value.ToString();
                }
                catch (Exception ex) {
                    MessageBox.Show("У этого пользователя не загруженно фото: " + ex.Message);
                }
            }
        }



        private void exitAdminPanelButton_Click(object sender, EventArgs e) {
            Close();
        }

        private void searchUserTextBox_TextChanged(object sender, EventArgs e) {
            FindUser(dataGridView1);
        }

        private void deleteUserButton_Click(object sender, EventArgs e) {
            deleteUserRow();
        }
    }
}
