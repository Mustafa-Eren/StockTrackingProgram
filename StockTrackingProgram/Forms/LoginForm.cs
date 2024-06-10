using StockTrackingProgram.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace StockTrackingProgram
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        SqlConnection sqlConn = new SqlConnection(@"Data Source=DESKTOP-O2RP1Q0\SQLEXPRESS;Initial Catalog=StockTrackingProgram;Integrated Security=True");
        public int userId;
        private void LoginForm_Load(object sender, EventArgs e)
        {

            Username.Text = "necmi";
            Password.Text = "12345";

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlQuery = "Select ID from Users Where Username = '" + Username.Text.Trim() + "' and Password = '" + Password.Text.Trim() + "'";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlQuery, sqlConn);

                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);
                userId = Convert.ToInt32(dt.Rows[0][0].ToString());

                if (Username.Text == "" || Password.Text == "")
                {
                    MessageBox.Show("Lütfen kullanýcý adý ve þifre giriniz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (dt.Rows.Count != 0) //Permission kontrolü eklenecek. || permission == admin veya üretim
                    {
                        MainForm mainForm = new MainForm();
                        mainForm.userId = userId;
                        mainForm.Show();
                        this.Hide();
                    }
                    //else if  permission == muhasebe ---> 3 buttonlu seçim ekraný   Ana Sayfa / Ödeme Takibi / Müþteri Takibi 
                    else
                    {
                        MessageBox.Show("Lütfen kullanýcý adý ve þifreyi kontrol ediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
