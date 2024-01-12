namespace QuestGame {
    partial class AddAvatarForm {
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
            levelAvatarTextBox = new TextBox();
            nameAvatarTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            typeAvatarComboBox = new ComboBox();
            groupBox1 = new GroupBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            speciesAvatarComboBox = new ComboBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // levelAvatarTextBox
            // 
            levelAvatarTextBox.Location = new Point(12, 48);
            levelAvatarTextBox.Name = "levelAvatarTextBox";
            levelAvatarTextBox.Size = new Size(292, 23);
            levelAvatarTextBox.TabIndex = 0;
            // 
            // nameAvatarTextBox
            // 
            nameAvatarTextBox.Location = new Point(12, 100);
            nameAvatarTextBox.Name = "nameAvatarTextBox";
            nameAvatarTextBox.Size = new Size(292, 23);
            nameAvatarTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 5;
            label1.Text = "Уровень";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 82);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 6;
            label2.Text = "Имя";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 132);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 7;
            label3.Text = "Раса";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 235);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 9;
            label5.Text = "Тип";
            // 
            // typeAvatarComboBox
            // 
            typeAvatarComboBox.FormattingEnabled = true;
            typeAvatarComboBox.Items.AddRange(new object[] { "Варвар", "Вор", "Маг" });
            typeAvatarComboBox.Location = new Point(12, 253);
            typeAvatarComboBox.Name = "typeAvatarComboBox";
            typeAvatarComboBox.Size = new Size(292, 23);
            typeAvatarComboBox.TabIndex = 10;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(13, 179);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(291, 53);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Пол";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(28, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(77, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Мужской";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(187, 22);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(75, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Женский";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // speciesAvatarComboBox
            // 
            speciesAvatarComboBox.FormattingEnabled = true;
            speciesAvatarComboBox.Items.AddRange(new object[] { "Человек", "Орк", "Ящер" });
            speciesAvatarComboBox.Location = new Point(13, 150);
            speciesAvatarComboBox.Name = "speciesAvatarComboBox";
            speciesAvatarComboBox.Size = new Size(291, 23);
            speciesAvatarComboBox.TabIndex = 12;
            // 
            // AddAvatarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 651);
            Controls.Add(speciesAvatarComboBox);
            Controls.Add(groupBox1);
            Controls.Add(typeAvatarComboBox);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nameAvatarTextBox);
            Controls.Add(levelAvatarTextBox);
            Name = "AddAvatarForm";
            Text = "AddAvatarForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox levelAvatarTextBox;
        private TextBox nameAvatarTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private ComboBox typeAvatarComboBox;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private ComboBox speciesAvatarComboBox;
    }
}