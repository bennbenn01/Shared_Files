using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectEvaluation
{
    public partial class AdminLogin1 : Form
    {
        private string adminUsername;
        public AdminLogin1(string adminUsername)
        {
            InitializeComponent();
            this.adminUsername = adminUsername;
            currentTextBoxAdmin.Text = adminUsername;

            button3.Enabled = false;
            button3.Visible = false;
        }

        private bool isButton3Clicked = false;

        private void textBoxAdminPassword_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxAdminPassword.Text))
            {
                button3.Enabled = true;
                button3.Visible = true;

            }
            else
            {
                button3.Enabled = false;
                button3.Visible = false;
            }
        }

        private void textBoxAdminPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxAdminPassword.Text == "Password")
            {
                textBoxAdminPassword.Text = "";
                textBoxAdminPassword.PasswordChar = '*';
                textBoxAdminPassword.ForeColor = Color.Black;
            }
        }

        private void textBoxAdminPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxAdminPassword.Text == "")
            {
                textBoxAdminPassword.Text = "Password";
                textBoxAdminPassword.PasswordChar = '\0';
                textBoxAdminPassword.ForeColor = Color.Silver;
                button3.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string adminPassword = textBoxAdminPassword.Text;

                if (string.IsNullOrEmpty(adminPassword))
                {
                    Thread.Sleep(1000);
                    MessageBox.Show("Please Input your Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-6C0MD9JK\SQLEXPRESS;Initial Catalog=ProjectEvaluation;Integrated Security=True"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM AdminList WHERE [Admin Username] = @AdminUsername AND [Admin Password] = @Password", con);
                    cmd.Parameters.AddWithValue("@AdminUsername",  adminUsername);
                    cmd.Parameters.AddWithValue("@Password", adminPassword);

                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                        Thread.Sleep(1000);
                        MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AdminDashboard dashboardA = new AdminDashboard(adminUsername);
                        this.Hide();
                        dashboardA.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        Thread.Sleep(1000);
                        MessageBox.Show("Invalid Password! Please Try Again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                Thread.Sleep(1000);
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread.Sleep(1000);
            AdminLogin adminL = new AdminLogin();
            this.Hide();
            adminL.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            isButton3Clicked = !isButton3Clicked;
            textBoxAdminPassword.PasswordChar = isButton3Clicked ? '\0' : '*';
        }  
    }
}
