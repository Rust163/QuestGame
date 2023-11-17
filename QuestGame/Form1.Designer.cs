namespace QuestGame {
    partial class Form1 : Form {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            RegistrationButton = new Button();
            EnterButton = new Button();
            ExitButton = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // RegistrationButton
            // 
            RegistrationButton.BackColor = Color.Transparent;
            RegistrationButton.BackgroundImageLayout = ImageLayout.Stretch;
            RegistrationButton.Cursor = Cursors.Hand;
            RegistrationButton.FlatAppearance.BorderSize = 0;
            RegistrationButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            RegistrationButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            RegistrationButton.FlatStyle = FlatStyle.Flat;
            RegistrationButton.ForeColor = Color.WhiteSmoke;
            RegistrationButton.Location = new Point(12, 250);
            RegistrationButton.Name = "RegistrationButton";
            RegistrationButton.Size = new Size(163, 46);
            RegistrationButton.TabIndex = 0;
            RegistrationButton.Text = "Регистрация";
            RegistrationButton.UseVisualStyleBackColor = false;
            RegistrationButton.Click += RegistrationButton_Click;
            // 
            // EnterButton
            // 
            EnterButton.BackColor = Color.Transparent;
            EnterButton.Cursor = Cursors.Hand;
            EnterButton.FlatAppearance.BorderSize = 0;
            EnterButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            EnterButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            EnterButton.FlatStyle = FlatStyle.Flat;
            EnterButton.ForeColor = Color.WhiteSmoke;
            EnterButton.Location = new Point(12, 302);
            EnterButton.Name = "EnterButton";
            EnterButton.Size = new Size(163, 46);
            EnterButton.TabIndex = 1;
            EnterButton.Text = "Вход";
            EnterButton.UseVisualStyleBackColor = false;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.Transparent;
            ExitButton.Cursor = Cursors.Hand;
            ExitButton.FlatAppearance.BorderSize = 0;
            ExitButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            ExitButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            ExitButton.FlatStyle = FlatStyle.Flat;
            ExitButton.ForeColor = Color.WhiteSmoke;
            ExitButton.Location = new Point(12, 354);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(163, 46);
            ExitButton.TabIndex = 2;
            ExitButton.Text = "Выход";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(118, 17);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(ExitButton);
            Controls.Add(EnterButton);
            Controls.Add(RegistrationButton);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "Form1";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RegistrationButton;
        private Button EnterButton;
        private Button ExitButton;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}