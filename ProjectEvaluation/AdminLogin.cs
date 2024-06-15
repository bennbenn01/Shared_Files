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
using System.Threading;

namespace ProjectEvaluation
{
    public partial class AdminLogin : Form
    {
        public string adminUsername { get; private set; }

        public AdminLogin()
        {
            InitializeComponent();
        }

        private void textBoxAdminUsername_Enter(object sender, EventArgs e)
        {
            if (textBoxAdminUsername.Text == "Admin Username")
            {
                textBoxAdminUsername.Text = "";
                textBoxAdminUsername.ForeColor = Color.Black;
            }
        }

        private void textBoxAdminUsername_Leave(object sender, EventArgs e)
        {
            if (textBoxAdminUsername.Text == "")
            {
                textBoxAdminUsername.Text = "Admin Username";
                textBoxAdminUsername.ForeColor = Color.Silver;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminUsername = textBoxAdminUsername.Text;        
            
            try
            {
                if (string.IsNullOrEmpty(adminUsername))
                {
                    Thread.Sleep(1000);
                    MessageBox.Show("Please Input your Username!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-6C0MD9JK\SQLEXPRESS;Initial Catalog=ProjectEvaluation;Integrated Security=True"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM AdminList WHERE [Admin Username] = @AdminUsername", con);
                    cmd.Parameters.AddWithValue("@AdminUsername", adminUsername);

                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                        Thread.Sleep(1000);
                        AdminLogin1 adminL1 = new AdminLogin1(adminUsername);
                        this.Hide();
                        adminL1.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        Thread.Sleep(1000);
                        MessageBox.Show("No Input or Not Available in the Database! Please Input your Admin Username!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(Exception ex)
            {
                Thread.Sleep(1000);
                MessageBox.Show($"An error occurred: {ex.Message}", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread.Sleep(1000);
            SignInOption signInOption = new SignInOption();
            this.Hide();
            signInOption.ShowDialog();
            this.Close();
        }
    }
}
