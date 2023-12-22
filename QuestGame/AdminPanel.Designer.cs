namespace QuestGame {
    partial class AdminPanel {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            dataGridView1 = new DataGridView();
            searchUserButton = new Button();
            showAllUsersButton = new Button();
            deleteUserButton = new Button();
            searchUserTextBox = new TextBox();
            exitAdminPanel = new Button();
            label9 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cartEmailTextBox = new TextBox();
            cartMiddleNameTextBox = new TextBox();
            cartLastNameTextBox = new TextBox();
            cartFirstNameTextBox = new TextBox();
            cartGenderTextBox = new TextBox();
            cartAgeTextBox = new TextBox();
            cartPhoneTextBox = new TextBox();
            cartCityTextBox = new TextBox();
            label4 = new Label();
            label7 = new Label();
            cartUserPhotoPictureBox = new PictureBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cartUserPhotoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 155);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1034, 668);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // searchUserButton
            // 
            searchUserButton.Location = new Point(12, 52);
            searchUserButton.Name = "searchUserButton";
            searchUserButton.Size = new Size(200, 35);
            searchUserButton.TabIndex = 1;
            searchUserButton.Text = "Поиск пользователя";
            searchUserButton.UseVisualStyleBackColor = true;
            searchUserButton.Click += searchUserButton_Click;
            // 
            // showAllUsersButton
            // 
            showAllUsersButton.Location = new Point(12, 11);
            showAllUsersButton.Name = "showAllUsersButton";
            showAllUsersButton.Size = new Size(200, 35);
            showAllUsersButton.TabIndex = 2;
            showAllUsersButton.Text = "Показать список пользователей";
            showAllUsersButton.UseVisualStyleBackColor = true;
            showAllUsersButton.Click += showAllUsersButton_Click;
            // 
            // deleteUserButton
            // 
            deleteUserButton.Location = new Point(12, 96);
            deleteUserButton.Name = "deleteUserButton";
            deleteUserButton.Size = new Size(200, 35);
            deleteUserButton.TabIndex = 3;
            deleteUserButton.Text = "Удалить пользователя";
            deleteUserButton.UseVisualStyleBackColor = true;
            deleteUserButton.Click += deleteUserButton_Click;
            // 
            // searchUserTextBox
            // 
            searchUserTextBox.Location = new Point(218, 59);
            searchUserTextBox.Name = "searchUserTextBox";
            searchUserTextBox.Size = new Size(406, 23);
            searchUserTextBox.TabIndex = 5;
            searchUserTextBox.Text = "Введите ФИО либо Id пользователя";
            searchUserTextBox.Enter += searchUserTextBox_Enter;
            searchUserTextBox.Leave += searchUserTextBox_Leave;
            // 
            // exitAdminPanel
            // 
            exitAdminPanel.Location = new Point(1247, 11);
            exitAdminPanel.Name = "exitAdminPanel";
            exitAdminPanel.Size = new Size(107, 35);
            exitAdminPanel.TabIndex = 6;
            exitAdminPanel.Text = "Назад";
            exitAdminPanel.UseVisualStyleBackColor = true;
            exitAdminPanel.Enter += exitAdminPanelButton_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1040, 733);
            label9.Name = "label9";
            label9.Size = new Size(101, 15);
            label9.TabIndex = 42;
            label9.Text = "Номер телефона";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1040, 777);
            label6.Name = "label6";
            label6.Size = new Size(113, 15);
            label6.TabIndex = 38;
            label6.Text = "Электронная почта";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1040, 691);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 37;
            label5.Text = "Город";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1040, 534);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 35;
            label3.Text = "Отчество";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1040, 492);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 34;
            label2.Text = "Фамилия";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1040, 448);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 33;
            label1.Text = "Имя";
            // 
            // cartEmailTextBox
            // 
            cartEmailTextBox.Location = new Point(1040, 795);
            cartEmailTextBox.Name = "cartEmailTextBox";
            cartEmailTextBox.Size = new Size(314, 23);
            cartEmailTextBox.TabIndex = 30;
            // 
            // cartMiddleNameTextBox
            // 
            cartMiddleNameTextBox.Location = new Point(1040, 552);
            cartMiddleNameTextBox.Name = "cartMiddleNameTextBox";
            cartMiddleNameTextBox.Size = new Size(314, 23);
            cartMiddleNameTextBox.TabIndex = 25;
            // 
            // cartLastNameTextBox
            // 
            cartLastNameTextBox.Location = new Point(1040, 510);
            cartLastNameTextBox.Name = "cartLastNameTextBox";
            cartLastNameTextBox.Size = new Size(314, 23);
            cartLastNameTextBox.TabIndex = 24;
            // 
            // cartFirstNameTextBox
            // 
            cartFirstNameTextBox.Location = new Point(1040, 466);
            cartFirstNameTextBox.Name = "cartFirstNameTextBox";
            cartFirstNameTextBox.Size = new Size(314, 23);
            cartFirstNameTextBox.TabIndex = 23;
            // 
            // cartGenderTextBox
            // 
            cartGenderTextBox.Location = new Point(1040, 600);
            cartGenderTextBox.Name = "cartGenderTextBox";
            cartGenderTextBox.Size = new Size(314, 23);
            cartGenderTextBox.TabIndex = 43;
            // 
            // cartAgeTextBox
            // 
            cartAgeTextBox.Location = new Point(1040, 654);
            cartAgeTextBox.Name = "cartAgeTextBox";
            cartAgeTextBox.Size = new Size(314, 23);
            cartAgeTextBox.TabIndex = 44;
            // 
            // cartPhoneTextBox
            // 
            cartPhoneTextBox.Location = new Point(1040, 751);
            cartPhoneTextBox.Name = "cartPhoneTextBox";
            cartPhoneTextBox.Size = new Size(314, 23);
            cartPhoneTextBox.TabIndex = 45;
            // 
            // cartCityTextBox
            // 
            cartCityTextBox.Location = new Point(1040, 709);
            cartCityTextBox.Name = "cartCityTextBox";
            cartCityTextBox.Size = new Size(314, 23);
            cartCityTextBox.TabIndex = 46;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1040, 582);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 47;
            label4.Text = "Пол";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1040, 636);
            label7.Name = "label7";
            label7.Size = new Size(50, 15);
            label7.TabIndex = 48;
            label7.Text = "Возраст";
            // 
            // cartUserPhotoPictureBox
            // 
            cartUserPhotoPictureBox.BackColor = SystemColors.ButtonHighlight;
            cartUserPhotoPictureBox.BackgroundImage = (Image)resources.GetObject("cartUserPhotoPictureBox.BackgroundImage");
            cartUserPhotoPictureBox.BackgroundImageLayout = ImageLayout.Center;
            cartUserPhotoPictureBox.Location = new Point(1040, 155);
            cartUserPhotoPictureBox.Name = "cartUserPhotoPictureBox";
            cartUserPhotoPictureBox.Size = new Size(314, 281);
            cartUserPhotoPictureBox.TabIndex = 49;
            cartUserPhotoPictureBox.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1040, 137);
            label8.Name = "label8";
            label8.Size = new Size(35, 15);
            label8.TabIndex = 50;
            label8.Text = "Фото";
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1364, 823);
            Controls.Add(label8);
            Controls.Add(cartUserPhotoPictureBox);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(cartCityTextBox);
            Controls.Add(cartPhoneTextBox);
            Controls.Add(cartAgeTextBox);
            Controls.Add(cartGenderTextBox);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cartEmailTextBox);
            Controls.Add(cartMiddleNameTextBox);
            Controls.Add(cartLastNameTextBox);
            Controls.Add(cartFirstNameTextBox);
            Controls.Add(exitAdminPanel);
            Controls.Add(searchUserTextBox);
            Controls.Add(deleteUserButton);
            Controls.Add(showAllUsersButton);
            Controls.Add(searchUserButton);
            Controls.Add(dataGridView1);
            Name = "AdminPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminPanel";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cartUserPhotoPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button searchUserButton;
        private Button showAllUsersButton;
        private Button deleteUserButton;
        private TextBox searchUserTextBox;
        private Button exitAdminPanel;
        private Label label9;
        private MaskedTextBox phoneNumberMaskedTextBox;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox repeatPasswordTextBox;
        private TextBox passwordTextBox;
        private TextBox cartEmailTextBox;
        private ComboBox emailComboBox;
        private ComboBox cityComboBox;
        private TextBox cartMiddleNameTextBox;
        private TextBox cartLastNameTextBox;
        private TextBox cartFirstNameTextBox;
        private TextBox cartGenderTextBox;
        private TextBox cartAgeTextBox;
        private TextBox cartPhoneTextBox;
        private TextBox cartCityTextBox;
        private Label label4;
        private Label label7;
        private PictureBox cartUserPhotoPictureBox;
        private Label label8;
    }
}