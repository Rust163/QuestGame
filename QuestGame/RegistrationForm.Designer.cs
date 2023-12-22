namespace QuestGame {
    partial class RegistrationForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            middleNameTextBox = new TextBox();
            groupBox1 = new GroupBox();
            noGenderRadioButton = new RadioButton();
            womanRadioButton = new RadioButton();
            manRadioButton = new RadioButton();
            birthdayDateTimePicker = new DateTimePicker();
            cityComboBox = new ComboBox();
            emailComboBox = new ComboBox();
            emailTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            phoneNumberMaskedTextBox = new MaskedTextBox();
            label9 = new Label();
            menuStrip1 = new MenuStrip();
            действияToolStripMenuItem = new ToolStripMenuItem();
            createDataBaseToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            createTableToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            label10 = new Label();
            passwordTextBox = new TextBox();
            repeatPasswordTextBox = new TextBox();
            label7 = new Label();
            label8 = new Label();
            isNewsCheckBox = new CheckBox();
            RegButton = new Button();
            backFormRegButton = new Button();
            openPhotoButton = new Button();
            openFileDialog1 = new OpenFileDialog();
            photoLoadTextBox = new TextBox();
            showPassPictureBox = new PictureBox();
            showPassRepeatPictureBox = new PictureBox();
            hidePassPictureBox = new PictureBox();
            hidePassRepeatPictureBox = new PictureBox();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)showPassPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)showPassRepeatPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hidePassPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hidePassRepeatPictureBox).BeginInit();
            SuspendLayout();
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(38, 62);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(314, 23);
            firstNameTextBox.TabIndex = 0;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(38, 106);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(314, 23);
            lastNameTextBox.TabIndex = 1;
            // 
            // middleNameTextBox
            // 
            middleNameTextBox.Location = new Point(38, 148);
            middleNameTextBox.Name = "middleNameTextBox";
            middleNameTextBox.Size = new Size(314, 23);
            middleNameTextBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(noGenderRadioButton);
            groupBox1.Controls.Add(womanRadioButton);
            groupBox1.Controls.Add(manRadioButton);
            groupBox1.Location = new Point(38, 177);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(314, 63);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Укажите пол";
            // 
            // noGenderRadioButton
            // 
            noGenderRadioButton.AutoSize = true;
            noGenderRadioButton.Location = new Point(206, 22);
            noGenderRadioButton.Name = "noGenderRadioButton";
            noGenderRadioButton.Size = new Size(79, 19);
            noGenderRadioButton.TabIndex = 2;
            noGenderRadioButton.TabStop = true;
            noGenderRadioButton.Text = "Не указан";
            noGenderRadioButton.UseVisualStyleBackColor = true;
            // 
            // womanRadioButton
            // 
            womanRadioButton.AutoSize = true;
            womanRadioButton.Location = new Point(106, 22);
            womanRadioButton.Name = "womanRadioButton";
            womanRadioButton.Size = new Size(75, 19);
            womanRadioButton.TabIndex = 1;
            womanRadioButton.TabStop = true;
            womanRadioButton.Text = "Женский";
            womanRadioButton.UseVisualStyleBackColor = true;
            // 
            // manRadioButton
            // 
            manRadioButton.AutoSize = true;
            manRadioButton.Location = new Point(6, 22);
            manRadioButton.Name = "manRadioButton";
            manRadioButton.Size = new Size(77, 19);
            manRadioButton.TabIndex = 0;
            manRadioButton.TabStop = true;
            manRadioButton.Text = "Мужской";
            manRadioButton.UseVisualStyleBackColor = true;
            // 
            // birthdayDateTimePicker
            // 
            birthdayDateTimePicker.Location = new Point(38, 261);
            birthdayDateTimePicker.Name = "birthdayDateTimePicker";
            birthdayDateTimePicker.Size = new Size(314, 23);
            birthdayDateTimePicker.TabIndex = 4;
            // 
            // cityComboBox
            // 
            cityComboBox.FormattingEnabled = true;
            cityComboBox.Items.AddRange(new object[] { "Самара", "Москва", "Санкт-Петербург", "Томск", "Омск", "Екатеринбург", "Нижний-Новгород", "Саратов", "Ижевск", "Казань", "Уфа", "Оренбург", "Чебоксары" });
            cityComboBox.Location = new Point(38, 305);
            cityComboBox.Name = "cityComboBox";
            cityComboBox.Size = new Size(314, 23);
            cityComboBox.TabIndex = 5;
            // 
            // emailComboBox
            // 
            emailComboBox.FormattingEnabled = true;
            emailComboBox.Items.AddRange(new object[] { "@gmail.com", "@mail.ru", "@yandex.ru", "@rambler.com" });
            emailComboBox.Location = new Point(231, 391);
            emailComboBox.Name = "emailComboBox";
            emailComboBox.Size = new Size(121, 23);
            emailComboBox.TabIndex = 6;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(38, 391);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(187, 23);
            emailTextBox.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 44);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 10;
            label1.Text = "Введите имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 88);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 11;
            label2.Text = "Ведите фамилию";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 130);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 12;
            label3.Text = "Введите отчество";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 243);
            label4.Name = "label4";
            label4.Size = new Size(134, 15);
            label4.TabIndex = 13;
            label4.Text = "Введите дату рождения";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 287);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 14;
            label5.Text = "Введите город";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 373);
            label6.Name = "label6";
            label6.Size = new Size(156, 15);
            label6.TabIndex = 15;
            label6.Text = "Ведите электронную почту";
            // 
            // phoneNumberMaskedTextBox
            // 
            phoneNumberMaskedTextBox.Location = new Point(38, 347);
            phoneNumberMaskedTextBox.Mask = "+7(000) 000-0000";
            phoneNumberMaskedTextBox.Name = "phoneNumberMaskedTextBox";
            phoneNumberMaskedTextBox.Size = new Size(314, 23);
            phoneNumberMaskedTextBox.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(38, 329);
            label9.Name = "label9";
            label9.Size = new Size(145, 15);
            label9.TabIndex = 22;
            label9.Text = "Введите номер телефона";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { действияToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(394, 24);
            menuStrip1.TabIndex = 23;
            menuStrip1.Text = "menuStrip1";
            // 
            // действияToolStripMenuItem
            // 
            действияToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createDataBaseToolStripMenuItem, toolStripMenuItem1, createTableToolStripMenuItem });
            действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            действияToolStripMenuItem.Size = new Size(70, 20);
            действияToolStripMenuItem.Text = "Действия";
            // 
            // createDataBaseToolStripMenuItem
            // 
            createDataBaseToolStripMenuItem.Name = "createDataBaseToolStripMenuItem";
            createDataBaseToolStripMenuItem.Size = new Size(162, 22);
            createDataBaseToolStripMenuItem.Text = "Create Data Base";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(159, 6);
            // 
            // createTableToolStripMenuItem
            // 
            createTableToolStripMenuItem.Name = "createTableToolStripMenuItem";
            createTableToolStripMenuItem.Size = new Size(162, 22);
            createTableToolStripMenuItem.Text = "Create Table";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 653);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(394, 22);
            statusStrip1.TabIndex = 24;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(118, 17);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(38, 419);
            label10.Name = "label10";
            label10.Size = new Size(35, 15);
            label10.TabIndex = 26;
            label10.Text = "Фото";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(38, 489);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(314, 23);
            passwordTextBox.TabIndex = 8;
            // 
            // repeatPasswordTextBox
            // 
            repeatPasswordTextBox.Location = new Point(38, 533);
            repeatPasswordTextBox.Name = "repeatPasswordTextBox";
            repeatPasswordTextBox.Size = new Size(314, 23);
            repeatPasswordTextBox.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(38, 471);
            label7.Name = "label7";
            label7.Size = new Size(93, 15);
            label7.TabIndex = 16;
            label7.Text = "Введите пароль";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(38, 515);
            label8.Name = "label8";
            label8.Size = new Size(109, 15);
            label8.TabIndex = 17;
            label8.Text = "Повторите пароль";
            // 
            // isNewsCheckBox
            // 
            isNewsCheckBox.AutoSize = true;
            isNewsCheckBox.Location = new Point(38, 565);
            isNewsCheckBox.Name = "isNewsCheckBox";
            isNewsCheckBox.Size = new Size(127, 19);
            isNewsCheckBox.TabIndex = 18;
            isNewsCheckBox.Text = "Получать новости";
            isNewsCheckBox.UseVisualStyleBackColor = true;
            // 
            // RegButton
            // 
            RegButton.Location = new Point(38, 602);
            RegButton.Name = "RegButton";
            RegButton.Size = new Size(134, 33);
            RegButton.TabIndex = 19;
            RegButton.Text = "Зарегестрироваться";
            RegButton.UseVisualStyleBackColor = true;
            RegButton.Click += RegButton_Click;
            // 
            // backFormRegButton
            // 
            backFormRegButton.Location = new Point(218, 602);
            backFormRegButton.Name = "backFormRegButton";
            backFormRegButton.Size = new Size(134, 33);
            backFormRegButton.TabIndex = 20;
            backFormRegButton.Text = "Отмена";
            backFormRegButton.UseVisualStyleBackColor = true;
            backFormRegButton.Click += backFormRegButton_Click;
            // 
            // openPhotoButton
            // 
            openPhotoButton.Location = new Point(38, 437);
            openPhotoButton.Name = "openPhotoButton";
            openPhotoButton.Size = new Size(127, 23);
            openPhotoButton.TabIndex = 27;
            openPhotoButton.Text = "Выбрать фото";
            openPhotoButton.UseVisualStyleBackColor = true;
            openPhotoButton.Click += openPhotoButton_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // photoLoadTextBox
            // 
            photoLoadTextBox.Location = new Point(171, 437);
            photoLoadTextBox.Name = "photoLoadTextBox";
            photoLoadTextBox.Size = new Size(181, 23);
            photoLoadTextBox.TabIndex = 28;
            // 
            // showPassPictureBox
            // 
            showPassPictureBox.BackColor = Color.Transparent;
            showPassPictureBox.Image = (Image)resources.GetObject("showPassPictureBox.Image");
            showPassPictureBox.Location = new Point(354, 489);
            showPassPictureBox.Name = "showPassPictureBox";
            showPassPictureBox.Size = new Size(23, 23);
            showPassPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            showPassPictureBox.TabIndex = 29;
            showPassPictureBox.TabStop = false;
            showPassPictureBox.Click += showPassPictureBox_Click;
            // 
            // showPassRepeatPictureBox
            // 
            showPassRepeatPictureBox.BackColor = Color.Transparent;
            showPassRepeatPictureBox.Image = (Image)resources.GetObject("showPassRepeatPictureBox.Image");
            showPassRepeatPictureBox.Location = new Point(354, 533);
            showPassRepeatPictureBox.Name = "showPassRepeatPictureBox";
            showPassRepeatPictureBox.Size = new Size(23, 23);
            showPassRepeatPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            showPassRepeatPictureBox.TabIndex = 30;
            showPassRepeatPictureBox.TabStop = false;
            showPassRepeatPictureBox.Click += showPassRepeatPictureBox_Click;
            // 
            // hidePassPictureBox
            // 
            hidePassPictureBox.BackColor = Color.Transparent;
            hidePassPictureBox.Image = (Image)resources.GetObject("hidePassPictureBox.Image");
            hidePassPictureBox.Location = new Point(354, 489);
            hidePassPictureBox.Name = "hidePassPictureBox";
            hidePassPictureBox.Size = new Size(23, 23);
            hidePassPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            hidePassPictureBox.TabIndex = 31;
            hidePassPictureBox.TabStop = false;
            hidePassPictureBox.Click += hidePassPictureBox_Click;
            // 
            // hidePassRepeatPictureBox
            // 
            hidePassRepeatPictureBox.BackColor = Color.Transparent;
            hidePassRepeatPictureBox.Image = (Image)resources.GetObject("hidePassRepeatPictureBox.Image");
            hidePassRepeatPictureBox.Location = new Point(354, 533);
            hidePassRepeatPictureBox.Name = "hidePassRepeatPictureBox";
            hidePassRepeatPictureBox.Size = new Size(23, 23);
            hidePassRepeatPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            hidePassRepeatPictureBox.TabIndex = 32;
            hidePassRepeatPictureBox.TabStop = false;
            hidePassRepeatPictureBox.Click += hidePassRepeatPictureBox_Click;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(394, 675);
            Controls.Add(hidePassRepeatPictureBox);
            Controls.Add(hidePassPictureBox);
            Controls.Add(showPassRepeatPictureBox);
            Controls.Add(showPassPictureBox);
            Controls.Add(photoLoadTextBox);
            Controls.Add(openPhotoButton);
            Controls.Add(label10);
            Controls.Add(statusStrip1);
            Controls.Add(label9);
            Controls.Add(phoneNumberMaskedTextBox);
            Controls.Add(backFormRegButton);
            Controls.Add(RegButton);
            Controls.Add(isNewsCheckBox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(repeatPasswordTextBox);
            Controls.Add(passwordTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(emailComboBox);
            Controls.Add(cityComboBox);
            Controls.Add(birthdayDateTimePicker);
            Controls.Add(groupBox1);
            Controls.Add(middleNameTextBox);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(menuStrip1);
            Cursor = Cursors.Hand;
            MainMenuStrip = menuStrip1;
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)showPassPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)showPassRepeatPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)hidePassPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)hidePassRepeatPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private TextBox middleNameTextBox;
        private GroupBox groupBox1;
        private RadioButton noGenderRadioButton;
        private RadioButton womanRadioButton;
        private RadioButton manRadioButton;
        private DateTimePicker birthdayDateTimePicker;
        private ComboBox cityComboBox;
        private ComboBox emailComboBox;
        private TextBox emailTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private MaskedTextBox phoneNumberMaskedTextBox;
        private Label label9;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem действияToolStripMenuItem;
        private ToolStripMenuItem createDataBaseToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem createTableToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Label label10;
        private TextBox passwordTextBox;
        private TextBox repeatPasswordTextBox;
        private Label label7;
        private Label label8;
        private CheckBox isNewsCheckBox;
        private Button RegButton;
        private Button backFormRegButton;
        private Button openPhotoButton;
        private OpenFileDialog openFileDialog1;
        private TextBox photoLoadTextBox;
        private PictureBox showPassPictureBox;
        private PictureBox showPassRepeatPictureBox;
        private PictureBox hidePassPictureBox;
        private PictureBox hidePassRepeatPictureBox;
    }
}