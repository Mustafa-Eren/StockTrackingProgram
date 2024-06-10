namespace StockTrackingProgram.Forms
{
    partial class MainForm
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
            dataGridView1 = new DataGridView();
            createNewProductBtn = new Button();
            updateStockBtn = new Button();
            deleteProductBtn = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            button4 = new Button();
            createNewUserBtn = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 99);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(836, 374);
            dataGridView1.TabIndex = 0;
            // 
            // createNewProductBtn
            // 
            createNewProductBtn.Location = new Point(737, 12);
            createNewProductBtn.Name = "createNewProductBtn";
            createNewProductBtn.Size = new Size(111, 23);
            createNewProductBtn.TabIndex = 1;
            createNewProductBtn.Text = "Yeni Ürün Ekle";
            createNewProductBtn.UseVisualStyleBackColor = true;
            createNewProductBtn.Click += createNewProductBtn_Click;
            // 
            // updateStockBtn
            // 
            updateStockBtn.Location = new Point(737, 41);
            updateStockBtn.Name = "updateStockBtn";
            updateStockBtn.Size = new Size(111, 23);
            updateStockBtn.TabIndex = 2;
            updateStockBtn.Text = "Stok Düzenleme";
            updateStockBtn.UseVisualStyleBackColor = true;
            // 
            // deleteProductBtn
            // 
            deleteProductBtn.Location = new Point(737, 70);
            deleteProductBtn.Name = "deleteProductBtn";
            deleteProductBtn.Size = new Size(111, 23);
            deleteProductBtn.TabIndex = 3;
            deleteProductBtn.Text = "Ürün Silme";
            deleteProductBtn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(66, 17);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(290, 23);
            textBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 5;
            label1.Text = "Arama :";
            // 
            // button4
            // 
            button4.Location = new Point(737, 479);
            button4.Name = "button4";
            button4.Size = new Size(111, 23);
            button4.TabIndex = 6;
            button4.Text = "Dışarı Aktar ...";
            button4.UseVisualStyleBackColor = true;
            // 
            // createNewUserBtn
            // 
            createNewUserBtn.Location = new Point(12, 482);
            createNewUserBtn.Name = "createNewUserBtn";
            createNewUserBtn.Size = new Size(153, 23);
            createNewUserBtn.TabIndex = 7;
            createNewUserBtn.Text = "Yeni Kullanıcı Oluştur";
            createNewUserBtn.UseVisualStyleBackColor = true;
            createNewUserBtn.Click += CreateNewUser_Click;
            // 
            // button1
            // 
            button1.Location = new Point(480, 20);
            button1.Name = "button1";
            button1.Size = new Size(85, 26);
            button1.TabIndex = 8;
            button1.Text = "DT YENİLE";
            button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 517);
            Controls.Add(button1);
            Controls.Add(createNewUserBtn);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(deleteProductBtn);
            Controls.Add(updateStockBtn);
            Controls.Add(createNewProductBtn);
            Controls.Add(dataGridView1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ana Sayfa";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button createNewProductBtn;
        private Button updateStockBtn;
        private Button deleteProductBtn;
        private TextBox textBox1;
        private Label label1;
        private Button button4;
        private Button createNewUserBtn;
        private Button button1;
    }
}