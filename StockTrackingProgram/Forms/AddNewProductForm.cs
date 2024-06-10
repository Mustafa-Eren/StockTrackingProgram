using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockTrackingProgram.Forms
{
    public partial class AddNewProductForm : Form
    {
        string[] ports = SerialPort.GetPortNames();

        public AddNewProductForm()
        {
            InitializeComponent();
        }
        public int userId;
        SqlConnection sqlConn = new SqlConnection(@"Data Source=DESKTOP-O2RP1Q0\SQLEXPRESS;Initial Catalog=StockTrackingProgram;Integrated Security=True");

        private void AddNewProductForm_Load(object sender, EventArgs e)
        {
            SerialPort serial = new SerialPort();
            var a = SerialPort.GetPortNames();
            Console.WriteLine("The following serial ports were found:");

            foreach (string port in ports)
            {
                Console.WriteLine(port);
            }

            //barcodeNoTxt.Enabled = false;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (productNameTxt.Text == "" || productGramTxt.Text == "" || barcodeNoTxt.Text == "" || companyNameTxt.Text == "" || stockNumberTxt.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                sqlConn.Open();
                string sqlQuery = "INSERT INTO ProductStock (UserID,ProductName,ProductGram,BarcodeNumber,CompanyName,StockCount) VALUES " +
                    "(@userıd, @productname, @productgram, @barcodeno, @company, @stock)";
                SqlCommand command = new SqlCommand(sqlQuery, sqlConn);
                command.Parameters.AddWithValue("@userıd", userId);
                command.Parameters.AddWithValue("@productname", productNameTxt.Text);
                command.Parameters.AddWithValue("@productgram", Convert.ToDouble(productGramTxt.Text));
                command.Parameters.AddWithValue("@barcodeno", barcodeNoTxt.Text);
                command.Parameters.AddWithValue("@company", companyNameTxt.Text);
                command.Parameters.AddWithValue("@stock", Convert.ToInt32(stockNumberTxt.Text));


                command.ExecuteNonQuery();

                MessageBox.Show("Yeni ürün başarıyla oluşturuldu.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            sqlConn.Close();
            this.Close();
        }

        private void barcodeNoTxt_TextChanged(object sender, EventArgs e)
        {
            if(barcodeNoTxt.Text.Length == 13)
            {
                barcodeNoTxt.Enabled = false;
            }
        }
    }
}
