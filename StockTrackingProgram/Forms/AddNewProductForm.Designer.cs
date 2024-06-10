namespace StockTrackingProgram.Forms
{
    partial class AddNewProductForm
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
            saveBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            productNameTxt = new TextBox();
            productGramTxt = new TextBox();
            barcodeNoTxt = new TextBox();
            companyNameTxt = new TextBox();
            stockNumberTxt = new TextBox();
            SuspendLayout();
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(205, 231);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(75, 23);
            saveBtn.TabIndex = 0;
            saveBtn.Text = "Kaydet";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 37);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 1;
            label1.Text = "Ürün Adı : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 76);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 2;
            label2.Text = "Gramaj : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 115);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 3;
            label3.Text = "Barkod No : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 154);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 4;
            label4.Text = "Şirket Adı : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 193);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 5;
            label5.Text = "Stok Sayısı : ";
            // 
            // productNameTxt
            // 
            productNameTxt.Location = new Point(115, 34);
            productNameTxt.Name = "productNameTxt";
            productNameTxt.Size = new Size(165, 23);
            productNameTxt.TabIndex = 6;
            // 
            // productGramTxt
            // 
            productGramTxt.Location = new Point(115, 73);
            productGramTxt.Name = "productGramTxt";
            productGramTxt.Size = new Size(165, 23);
            productGramTxt.TabIndex = 7;
            // 
            // barcodeNoTxt
            // 
            barcodeNoTxt.Location = new Point(115, 112);
            barcodeNoTxt.Name = "barcodeNoTxt";
            barcodeNoTxt.Size = new Size(165, 23);
            barcodeNoTxt.TabIndex = 8;
            barcodeNoTxt.TextChanged += barcodeNoTxt_TextChanged;
            // 
            // companyNameTxt
            // 
            companyNameTxt.Location = new Point(115, 151);
            companyNameTxt.Name = "companyNameTxt";
            companyNameTxt.Size = new Size(165, 23);
            companyNameTxt.TabIndex = 9;
            // 
            // stockNumberTxt
            // 
            stockNumberTxt.Location = new Point(115, 190);
            stockNumberTxt.Name = "stockNumberTxt";
            stockNumberTxt.Size = new Size(165, 23);
            stockNumberTxt.TabIndex = 10;
            // 
            // AddNewProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 293);
            Controls.Add(stockNumberTxt);
            Controls.Add(companyNameTxt);
            Controls.Add(barcodeNoTxt);
            Controls.Add(productGramTxt);
            Controls.Add(productNameTxt);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(saveBtn);
            Name = "AddNewProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yeni Ürün Ekle";
            Load += AddNewProductForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button saveBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox productNameTxt;
        private TextBox productGramTxt;
        private TextBox barcodeNoTxt;
        private TextBox companyNameTxt;
        private TextBox stockNumberTxt;
    }
}