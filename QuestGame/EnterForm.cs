using System.Data;
using System.Data.SqlClient;

namespace QuestGame {
    public partial class EnterForm : Form {
        public EnterForm() {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void enterBtn_Click(object sender, EventArgs e) {
            var loginUser = enterEmailTextBox.Text;
            var passUser = CryptPass.cryptPassword(enterPasswordTextBox.Text);
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            if (enterEmailTextBox.Text == "") {
                MessageBox.Show("Вы не ввели логин!");
            }
            if (enterPasswordTextBox.Text == "") {
                MessageBox.Show("Вы не ввели пароль!");
            }
            try {
                using (SqlConnection conn = new SqlConnection(DBmanagement.connectionString)) {
                    conn.Open();
                    string logPassQuery = $"SELECT Email, Password FROM RegistrationTable WHERE Email = '{loginUser}' AND Password = '{passUser}'";
                    SqlCommand checkUserCommand = new SqlCommand(logPassQuery, conn);
                    adapter.SelectCommand = checkUserCommand;
                    adapter.Fill(table);
                    if (table.Rows.Count == 1) {
                        MessageBox.Show("Вы успешно авторизовались!");
                        PersonalAccount personalAccount = new PersonalAccount();
                        this.Hide();
                        personalAccount.ShowDialog();
                        this.Show();
                    }
                    else {
                        MessageBox.Show("Такого аккунта не существует!", "Вам необходимо зарегистрироваться!");
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Ошибка входа в аккаунт!" + ex.Message);
            }
        }



        private void cancelBtn_Click(object sender, EventArgs e) {
            Close();
        }

        private void registrationlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            RegistrationForm reg = new RegistrationForm();
            this.Hide();
            reg.ShowDialog();
            this.Show();
        }

        private void showEnterPassCheckBox_CheckedChanged(object sender, EventArgs e) {
            if (showEnterPassCheckBox.Checked == true) {
                enterPasswordTextBox.UseSystemPasswordChar = false;
            }
            else {
                enterPasswordTextBox.UseSystemPasswordChar = true;
            }
        }
    }
}
