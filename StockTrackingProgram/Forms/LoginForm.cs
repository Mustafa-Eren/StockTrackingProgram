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
                    MessageBox.Show("L�tfen kullan�c� ad� ve �ifre giriniz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (dt.Rows.Count != 0) //Permission kontrol� eklenecek. || permission == admin veya �retim
                    {
                        MainForm mainForm = new MainForm();
                        mainForm.userId = userId;
                        mainForm.Show();
                        this.Hide();
                    }
                    //else if  permission == muhasebe ---> 3 buttonlu se�im ekran�   Ana Sayfa / �deme Takibi / M��teri Takibi 
                    else
                    {
                        MessageBox.Show("L�tfen kullan�c� ad� ve �ifreyi kontrol ediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
