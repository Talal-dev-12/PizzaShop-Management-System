using MySql.Data.MySqlClient;
using pizza.Database;
using pizza.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizza
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtpass.UseSystemPasswordChar = true;

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text.Trim();
            string password = txtpass.Text.Trim();

            try
            {
                Connection.Open();

                string query = "SELECT COUNT(*) FROM Users WHERE Username = @username AND Password = @password";
                MySqlCommand cmd = new MySqlCommand(query, Connection.GetConnection());
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                Connection.Close();

                if (count > 0)
                {
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtpass.UseSystemPasswordChar = false; // Show password
            }
            else
            {
                txtpass.UseSystemPasswordChar = true;  // Hide password
            }
        }
    }
}
