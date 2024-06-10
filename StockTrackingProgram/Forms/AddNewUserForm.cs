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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace StockTrackingProgram.Forms
{
    public partial class AddNewUserForm : Form
    {
        public AddNewUserForm()
        {
            InitializeComponent();
        }

        SqlConnection sqlConn = new SqlConnection(@"Data Source=DESKTOP-O2RP1Q0\SQLEXPRESS;Initial Catalog=StockTrackingProgram;Integrated Security=True");

        DataTable dt = new DataTable();
        int permissionSelected = 0;
        private void AddNewUserForm_Load(object sender, EventArgs e)
        {
            sqlConn.Open();
            string sqlQuery = "Select * from Permissions";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlQuery, sqlConn);

            sqlDataAdapter.Fill(dt);

            permissionCmbBox.Items.Add("Lütfen yetki seçiniz ...");
            permissionCmbBox.SelectedIndex = 0;
            foreach (DataRow item in dt.Rows)
            {
                permissionCmbBox.Items.Add(item.ItemArray[1]);
            }
        }

        private void permissionCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            permissionSelected = permissionCmbBox.SelectedIndex;
        }

        private void newUserSaveBtn_Click(object sender, EventArgs e)
        {

            if (usernameTxtBox.Text == "" || passwordTxtBox.Text == "" || emailTxtBox.Text == "" || permissionSelected == 0)
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string sqlQuery = "INSERT INTO Users (Username,Password,Email,CreatedAt) VALUES (@username, @password, @email,@createdAt) SELECT SCOPE_IDENTITY()";
                SqlCommand command = new SqlCommand(sqlQuery, sqlConn);
                command.Parameters.AddWithValue("@username", usernameTxtBox.Text);
                command.Parameters.AddWithValue("@password", passwordTxtBox.Text);
                command.Parameters.AddWithValue("@email", emailTxtBox.Text);
                command.Parameters.AddWithValue("@createdAt", DateTime.Now);

                int newUserId = Convert.ToInt32(command.ExecuteScalar());

                string sqlQuery2 = "INSERT INTO UserPermissions (UserID,PermissionID) VALUES (@userId, @permissionId)";
                SqlCommand command2 = new SqlCommand(sqlQuery2, sqlConn);
                command2.Parameters.AddWithValue("@userId", newUserId);
                command2.Parameters.AddWithValue("@permissionId", permissionSelected);

                command2.ExecuteNonQuery();

                MessageBox.Show("Kullanıcı başarıyla oluşturuldu.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            sqlConn.Close();
            this.Close();
        }
    }
}
