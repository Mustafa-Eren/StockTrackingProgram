namespace StockTrackingProgram
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            LoginBtn = new Button();
            Username = new TextBox();
            Password = new TextBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 147);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 178);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Şifre :";
            // 
            // LoginBtn
            // 
            LoginBtn.Location = new Point(196, 204);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(75, 23);
            LoginBtn.TabIndex = 2;
            LoginBtn.Text = "Giriş Yap";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // Username
            // 
            Username.Location = new Point(104, 144);
            Username.Name = "Username";
            Username.Size = new Size(167, 23);
            Username.TabIndex = 3;
            // 
            // Password
            // 
            Password.Location = new Point(104, 175);
            Password.Name = "Password";
            Password.Size = new Size(167, 23);
            Password.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(86, 9);
            label3.Name = "label3";
            label3.Size = new Size(185, 21);
            label3.TabIndex = 6;
            label3.Text = "STOK TAKİP PROGRAMI";
            // 
            // pictureBox1
            // 
            pictureBox1.ImageLocation = "C:\\Users\\eren\\source\\repos\\StockTrackingProgram\\StockTrackingProgram\\Image\\logo.png";
            pictureBox1.Location = new Point(95, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(167, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 266);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(Password);
            Controls.Add(Username);
            Controls.Add(LoginBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanıcı Giriş";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button LoginBtn;
        private TextBox Username;
        private TextBox Password;
        private Label label3;
        private PictureBox pictureBox1;
    }
}
