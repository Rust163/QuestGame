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
            searchUserLabel = new Label();
            saveButton = new Button();
            tabControl1 = new TabControl();
            usersTabPage = new TabPage();
            avatarsTabPage = new TabPage();
            button3 = new Button();
            deleteAvatarButton = new Button();
            addAvatarButton = new Button();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cartUserPhotoPictureBox).BeginInit();
            tabControl1.SuspendLayout();
            usersTabPage.SuspendLayout();
            avatarsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(8, 86);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1023, 663);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // deleteUserButton
            // 
            deleteUserButton.Location = new Point(420, 16);
            deleteUserButton.Name = "deleteUserButton";
            deleteUserButton.Size = new Size(200, 35);
            deleteUserButton.TabIndex = 3;
            deleteUserButton.Text = "Удалить пользователя";
            deleteUserButton.UseVisualStyleBackColor = true;
            deleteUserButton.Click += deleteUserButton_Click;
            // 
            // searchUserTextBox
            // 
            searchUserTextBox.Location = new Point(8, 23);
            searchUserTextBox.Name = "searchUserTextBox";
            searchUserTextBox.Size = new Size(406, 23);
            searchUserTextBox.TabIndex = 5;
            searchUserTextBox.TextChanged += searchUserTextBox_TextChanged;
            // 
            // exitAdminPanel
            // 
            exitAdminPanel.Location = new Point(1241, 16);
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
            label9.Location = new Point(1037, 664);
            label9.Name = "label9";
            label9.Size = new Size(101, 15);
            label9.TabIndex = 42;
            label9.Text = "Номер телефона";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1037, 708);
            label6.Name = "label6";
            label6.Size = new Size(113, 15);
            label6.TabIndex = 38;
            label6.Text = "Электронная почта";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1037, 622);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 37;
            label5.Text = "Город";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1037, 465);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 35;
            label3.Text = "Отчество";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1037, 423);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 34;
            label2.Text = "Фамилия";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1037, 379);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 33;
            label1.Text = "Имя";
            // 
            // cartEmailTextBox
            // 
            cartEmailTextBox.Location = new Point(1037, 726);
            cartEmailTextBox.Name = "cartEmailTextBox";
            cartEmailTextBox.Size = new Size(314, 23);
            cartEmailTextBox.TabIndex = 30;
            // 
            // cartMiddleNameTextBox
            // 
            cartMiddleNameTextBox.Location = new Point(1037, 483);
            cartMiddleNameTextBox.Name = "cartMiddleNameTextBox";
            cartMiddleNameTextBox.Size = new Size(314, 23);
            cartMiddleNameTextBox.TabIndex = 25;
            // 
            // cartLastNameTextBox
            // 
            cartLastNameTextBox.Location = new Point(1037, 441);
            cartLastNameTextBox.Name = "cartLastNameTextBox";
            cartLastNameTextBox.Size = new Size(314, 23);
            cartLastNameTextBox.TabIndex = 24;
            // 
            // cartFirstNameTextBox
            // 
            cartFirstNameTextBox.Location = new Point(1037, 397);
            cartFirstNameTextBox.Name = "cartFirstNameTextBox";
            cartFirstNameTextBox.Size = new Size(314, 23);
            cartFirstNameTextBox.TabIndex = 23;
            // 
            // cartGenderTextBox
            // 
            cartGenderTextBox.Location = new Point(1037, 531);
            cartGenderTextBox.Name = "cartGenderTextBox";
            cartGenderTextBox.Size = new Size(314, 23);
            cartGenderTextBox.TabIndex = 43;
            // 
            // cartAgeTextBox
            // 
            cartAgeTextBox.Location = new Point(1037, 585);
            cartAgeTextBox.Name = "cartAgeTextBox";
            cartAgeTextBox.Size = new Size(314, 23);
            cartAgeTextBox.TabIndex = 44;
            // 
            // cartPhoneTextBox
            // 
            cartPhoneTextBox.Location = new Point(1037, 682);
            cartPhoneTextBox.Name = "cartPhoneTextBox";
            cartPhoneTextBox.Size = new Size(314, 23);
            cartPhoneTextBox.TabIndex = 45;
            // 
            // cartCityTextBox
            // 
            cartCityTextBox.Location = new Point(1037, 640);
            cartCityTextBox.Name = "cartCityTextBox";
            cartCityTextBox.Size = new Size(314, 23);
            cartCityTextBox.TabIndex = 46;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1037, 513);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 47;
            label4.Text = "Пол";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1037, 567);
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
            cartUserPhotoPictureBox.Location = new Point(1037, 86);
            cartUserPhotoPictureBox.Name = "cartUserPhotoPictureBox";
            cartUserPhotoPictureBox.Size = new Size(314, 281);
            cartUserPhotoPictureBox.TabIndex = 49;
            cartUserPhotoPictureBox.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1037, 68);
            label8.Name = "label8";
            label8.Size = new Size(35, 15);
            label8.TabIndex = 50;
            label8.Text = "Фото";
            // 
            // searchUserLabel
            // 
            searchUserLabel.AutoSize = true;
            searchUserLabel.Location = new Point(8, 5);
            searchUserLabel.Name = "searchUserLabel";
            searchUserLabel.Size = new Size(120, 15);
            searchUserLabel.TabIndex = 51;
            searchUserLabel.Text = "Поиск пользователя";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(626, 16);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(200, 35);
            saveButton.TabIndex = 52;
            saveButton.Text = "Сохранить изменения";
            saveButton.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(usersTabPage);
            tabControl1.Controls.Add(avatarsTabPage);
            tabControl1.Location = new Point(0, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1365, 923);
            tabControl1.TabIndex = 53;
            // 
            // usersTabPage
            // 
            usersTabPage.Controls.Add(deleteUserButton);
            usersTabPage.Controls.Add(exitAdminPanel);
            usersTabPage.Controls.Add(label8);
            usersTabPage.Controls.Add(cartUserPhotoPictureBox);
            usersTabPage.Controls.Add(searchUserLabel);
            usersTabPage.Controls.Add(label7);
            usersTabPage.Controls.Add(saveButton);
            usersTabPage.Controls.Add(label4);
            usersTabPage.Controls.Add(searchUserTextBox);
            usersTabPage.Controls.Add(cartCityTextBox);
            usersTabPage.Controls.Add(dataGridView1);
            usersTabPage.Controls.Add(cartPhoneTextBox);
            usersTabPage.Controls.Add(cartFirstNameTextBox);
            usersTabPage.Controls.Add(cartAgeTextBox);
            usersTabPage.Controls.Add(cartLastNameTextBox);
            usersTabPage.Controls.Add(cartGenderTextBox);
            usersTabPage.Controls.Add(cartMiddleNameTextBox);
            usersTabPage.Controls.Add(label9);
            usersTabPage.Controls.Add(cartEmailTextBox);
            usersTabPage.Controls.Add(label6);
            usersTabPage.Controls.Add(label1);
            usersTabPage.Controls.Add(label5);
            usersTabPage.Controls.Add(label2);
            usersTabPage.Controls.Add(label3);
            usersTabPage.Location = new Point(4, 24);
            usersTabPage.Name = "usersTabPage";
            usersTabPage.Padding = new Padding(3);
            usersTabPage.Size = new Size(1357, 895);
            usersTabPage.TabIndex = 0;
            usersTabPage.Text = "Пользователи";
            usersTabPage.UseVisualStyleBackColor = true;
            // 
            // avatarsTabPage
            // 
            avatarsTabPage.Controls.Add(button3);
            avatarsTabPage.Controls.Add(deleteAvatarButton);
            avatarsTabPage.Controls.Add(addAvatarButton);
            avatarsTabPage.Controls.Add(dataGridView2);
            avatarsTabPage.Location = new Point(4, 24);
            avatarsTabPage.Name = "avatarsTabPage";
            avatarsTabPage.Padding = new Padding(3);
            avatarsTabPage.Size = new Size(1357, 895);
            avatarsTabPage.TabIndex = 1;
            avatarsTabPage.Text = "Персонажи";
            avatarsTabPage.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(505, 81);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // deleteAvatarButton
            // 
            deleteAvatarButton.Location = new Point(251, 81);
            deleteAvatarButton.Name = "deleteAvatarButton";
            deleteAvatarButton.Size = new Size(200, 35);
            deleteAvatarButton.TabIndex = 2;
            deleteAvatarButton.Text = "Удалить персонажа";
            deleteAvatarButton.UseVisualStyleBackColor = true;
            // 
            // addAvatarButton
            // 
            addAvatarButton.Location = new Point(26, 81);
            addAvatarButton.Name = "addAvatarButton";
            addAvatarButton.Size = new Size(200, 35);
            addAvatarButton.TabIndex = 1;
            addAvatarButton.Text = "Добавить персонажа";
            addAvatarButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(0, 128);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(996, 616);
            dataGridView2.TabIndex = 0;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1364, 793);
            Controls.Add(tabControl1);
            Name = "AdminPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminPanel";
            Load += AdminPanel_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cartUserPhotoPictureBox).EndInit();
            tabControl1.ResumeLayout(false);
            usersTabPage.ResumeLayout(false);
            usersTabPage.PerformLayout();
            avatarsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
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
        private Label searchUserLabel;
        private Button saveButton;
        private TabControl tabControl1;
        private TabPage usersTabPage;
        private TabPage avatarsTabPage;
        private Button button3;
        private Button deleteAvatarButton;
        private Button addAvatarButton;
        private DataGridView dataGridView2;
    }
}