using POS_Jave2021.Class;
using POS_Jave2021.Model;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace POS_Jave2021.View.Cashier
{
    public partial class AdminCredential : Form
    {
        public OleDbConnection _conn;
        public AdminCredential(OleDbConnection conn)
        {
            InitializeComponent();
            _conn = conn;
        }

        private void btn_shiftOut_Click(object sender, EventArgs e)
        {
            try
            {
                var usermodel = new userModel();
                usermodel.username = txtUsername.Text;
                usermodel.password = txtPassword.Text;
                UserLogin userLogin = new UserLogin();
                DataTable userDetails = userLogin.login(usermodel, _conn);
                if (userDetails.Rows.Count > 0)
                {
                    string role = userDetails.Rows[0]["usertype"].ToString();
                    if(Int32.Parse(role) > 0)
                    {
                        CashierHome._isAdminVerified = true;
                        CashierHome._userAdminDetails = userDetails;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("User Credential is not an Admin!", "User is not an Admin!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        CashierHome._isAdminVerified = false;
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Login Failed. Please check your username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
