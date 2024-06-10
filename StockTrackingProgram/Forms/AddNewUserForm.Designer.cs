namespace StockTrackingProgram.Forms
{
    partial class AddNewUserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            newUserSaveBtn = new Button();
            usernameTxtBox = new TextBox();
            emailTxtBox = new TextBox();
            passwordTxtBox = new TextBox();
            permissionCmbBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // newUserSaveBtn
            // 
            newUserSaveBtn.Location = new Point(183, 231);
            newUserSaveBtn.Name = "newUserSaveBtn";
            newUserSaveBtn.Size = new Size(75, 23);
            newUserSaveBtn.TabIndex = 0;
            newUserSaveBtn.Text = "Kaydet";
            newUserSaveBtn.UseVisualStyleBackColor = true;
            newUserSaveBtn.Click += newUserSaveBtn_Click;
            // 
            // usernameTxtBox
            // 
            usernameTxtBox.Location = new Point(100, 58);
            usernameTxtBox.Name = "usernameTxtBox";
            usernameTxtBox.Size = new Size(158, 23);
            usernameTxtBox.TabIndex = 1;
            // 
            // emailTxtBox
            // 
            emailTxtBox.Location = new Point(100, 102);
            emailTxtBox.Name = "emailTxtBox";
            emailTxtBox.Size = new Size(158, 23);
            emailTxtBox.TabIndex = 2;
            // 
            // passwordTxtBox
            // 
            passwordTxtBox.Location = new Point(100, 141);
            passwordTxtBox.Name = "passwordTxtBox";
            passwordTxtBox.Size = new Size(158, 23);
            passwordTxtBox.TabIndex = 3;
            // 
            // permissionCmbBox
            // 
            permissionCmbBox.FormattingEnabled = true;
            permissionCmbBox.Location = new Point(100, 190);
            permissionCmbBox.Name = "permissionCmbBox";
            permissionCmbBox.Size = new Size(158, 23);
            permissionCmbBox.TabIndex = 4;
            permissionCmbBox.SelectedIndexChanged += permissionCmbBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 61);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 5;
            label1.Text = "Kullanıcı Adı : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 105);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 6;
            label2.Text = "Email : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 149);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 7;
            label3.Text = "Şifre : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 193);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 8;
            label4.Text = "Yetki :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.MidnightBlue;
            label5.Location = new Point(12, 9);
            label5.Name = "label5";
            label5.Size = new Size(184, 21);
            label5.TabIndex = 9;
            label5.Text = "YENİ KULLANICI KAYDI";
            // 
            // AddNewUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(279, 282);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(permissionCmbBox);
            Controls.Add(passwordTxtBox);
            Controls.Add(emailTxtBox);
            Controls.Add(usernameTxtBox);
            Controls.Add(newUserSaveBtn);
            Name = "AddNewUserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yeni Kullanıcı Kayıt Formu";
            Load += AddNewUserForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button newUserSaveBtn;
        private TextBox usernameTxtBox;
        private TextBox emailTxtBox;
        private TextBox passwordTxtBox;
        private ComboBox permissionCmbBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}