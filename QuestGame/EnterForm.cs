using System.Data;
using System.Data.SqlClient;

namespace QuestGame {
    public partial class EnterForm : Form {
        public EnterForm() {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        

        private void enterBtn_Click(object sender, EventArgs e) {
            Users users = new Users();
            string loginUser = enterEmailTextBox.Text;
            string passUser = CryptPass.cryptPassword(enterPasswordTextBox.Text);
            
            //SqlDataAdapter adapter = new SqlDataAdapter();
            //DataTable table = new DataTable();
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
                    SqlDataReader reader = checkUserCommand.ExecuteReader();
                    if (reader.HasRows == true) {
                        MessageBox.Show("Вы успешно авторизовались!");
                        PersonalAccount personalAccount = new PersonalAccount();
                        this.Hide();
                        personalAccount.ShowDialog();
                        this.Show();
                    }
                    else if (MessageBox.Show("Зарегистрироваться?", "Такого аккунта не существует!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                        RegistrationForm reg = new RegistrationForm();
                        this.Hide();
                        reg.ShowDialog();
                        this.Show();
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
