namespace QuestGame {
    partial class EnterForm {
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
            enterBtn = new Button();
            cancelBtn = new Button();
            enterEmailTextBox = new TextBox();
            enterPasswordTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            registrationlinkLabel = new LinkLabel();
            showEnterPassCheckBox = new CheckBox();
            SuspendLayout();
            // 
            // enterBtn
            // 
            enterBtn.Location = new Point(94, 141);
            enterBtn.Name = "enterBtn";
            enterBtn.Size = new Size(124, 43);
            enterBtn.TabIndex = 0;
            enterBtn.Text = "Вход";
            enterBtn.UseVisualStyleBackColor = true;
            enterBtn.Click += enterBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(274, 141);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(124, 43);
            cancelBtn.TabIndex = 1;
            cancelBtn.Text = "Отмена";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // enterEmailTextBox
            // 
            enterEmailTextBox.Location = new Point(94, 56);
            enterEmailTextBox.Name = "enterEmailTextBox";
            enterEmailTextBox.Size = new Size(304, 23);
            enterEmailTextBox.TabIndex = 2;
            // 
            // enterPasswordTextBox
            // 
            enterPasswordTextBox.Location = new Point(94, 85);
            enterPasswordTextBox.Name = "enterPasswordTextBox";
            enterPasswordTextBox.Size = new Size(304, 23);
            enterPasswordTextBox.TabIndex = 3;
            enterPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 59);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 4;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 88);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // registrationlinkLabel
            // 
            registrationlinkLabel.AutoSize = true;
            registrationlinkLabel.Location = new Point(146, 189);
            registrationlinkLabel.Name = "registrationlinkLabel";
            registrationlinkLabel.Size = new Size(195, 15);
            registrationlinkLabel.TabIndex = 6;
            registrationlinkLabel.TabStop = true;
            registrationlinkLabel.Text = "Нет аккаунта? Зарегистрируйтесь!";
            registrationlinkLabel.LinkClicked += registrationlinkLabel_LinkClicked;
            // 
            // showEnterPassCheckBox
            // 
            showEnterPassCheckBox.AutoSize = true;
            showEnterPassCheckBox.Location = new Point(94, 116);
            showEnterPassCheckBox.Name = "showEnterPassCheckBox";
            showEnterPassCheckBox.Size = new Size(119, 19);
            showEnterPassCheckBox.TabIndex = 7;
            showEnterPassCheckBox.Text = "Показать пароль";
            showEnterPassCheckBox.UseVisualStyleBackColor = true;
            showEnterPassCheckBox.CheckedChanged += showEnterPassCheckBox_CheckedChanged;
            // 
            // EnterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 213);
            Controls.Add(showEnterPassCheckBox);
            Controls.Add(registrationlinkLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(enterPasswordTextBox);
            Controls.Add(enterEmailTextBox);
            Controls.Add(cancelBtn);
            Controls.Add(enterBtn);
            Name = "EnterForm";
            Text = "EnterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button enterBtn;
        private Button cancelBtn;
        private TextBox enterEmailTextBox;
        private TextBox enterPasswordTextBox;
        private Label label1;
        private Label label2;
        private LinkLabel registrationlinkLabel;
        private CheckBox showEnterPassCheckBox;
    }
}