

namespace QuestGame {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            
        }

        private void RegistrationButton_Click(object sender, EventArgs e) {
            
            RegistrationForm reg = new RegistrationForm();
            reg.ShowDialog();

        }

        private void ExitButton_Click(object sender, EventArgs e) {
            Close();
        }
    }
}