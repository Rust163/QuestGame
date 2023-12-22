

namespace QuestGame {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void RegistrationButton_Click(object sender, EventArgs e) {

            RegistrationForm reg = new RegistrationForm();
            this.Hide();
            reg.ShowDialog();
            this.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e) {
            Close();
        }

        private void EnterButton_Click(object sender, EventArgs e) {
            //AdminPanel adminka = new AdminPanel();
            //adminka.ShowDialog();
            EnterForm enterForm = new EnterForm();
            this.Hide();
            enterForm.ShowDialog();
            this.Show();
        }
    }
}