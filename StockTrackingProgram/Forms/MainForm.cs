using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace StockTrackingProgram.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        SqlConnection sqlConn = new SqlConnection(@"Data Source=DESKTOP-O2RP1Q0\SQLEXPRESS;Initial Catalog=StockTrackingProgram;Integrated Security=True");
        public int userId;
        public string? userPermissions;
        DataTable dt2 = new DataTable();
        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                string sqlQuery = "SELECT p.PermissionName FROM UserPermissions up JOIN Permissions p ON up.PermissionID = p.ID WHERE up.ID = '" + userId + "'";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlQuery, sqlConn);

                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    userPermissions = dt.Rows[0][0].ToString();
                }
                if (userPermissions != "Admin")
                {
                    createNewUserBtn.Enabled = false;
                    deleteProductBtn.Enabled = false;
                }
                string sqlQuery2 = "SELECT StockCount as 'Stok Sayısı',ProductName as 'Ürün Adı',ProductGram as 'Gramaj',CompanyName as 'Şirket Adı' FROM ProductStock";
                SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter(sqlQuery2, sqlConn);
                sqlDataAdapter2.Fill(dt2);

                dataGridView1.DataSource = dt2;
                sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateNewUser_Click(object sender, EventArgs e)
        {
            AddNewUserForm addNewUserForm = new AddNewUserForm();
            addNewUserForm.Show();
        }

        private void createNewProductBtn_Click(object sender, EventArgs e)
        {
            AddNewProductForm addNewProductForm = new AddNewProductForm();
            addNewProductForm.userId = userId;
            addNewProductForm.Show();
        }
    }
}
