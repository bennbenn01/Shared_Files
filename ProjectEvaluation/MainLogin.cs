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
    public partial class MainLogin : Form
    {
        public string studentInput { get; private set; }

        public MainLogin()
        {
            InitializeComponent();
        }

        private void textBoxStudent_Enter(object sender, EventArgs e)
        {
            if (textBoxStudent.Text == "Email, phone, or Skype")
            {
                textBoxStudent.Text = "";
                textBoxStudent.ForeColor = Color.Black;
            }
        }

        private void textBoxStudent_Leave(object sender, EventArgs e)
        {
            if (textBoxStudent.Text == "")
            {
                textBoxStudent.Text = "Email, phone, or Skype";
                textBoxStudent.ForeColor = Color.Silver;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            studentInput = textBoxStudent.Text;

            try
            {
                if (string.IsNullOrEmpty(studentInput))
                {
                    MessageBox.Show("Please Input your Username!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-6C0MD9JK\SQLEXPRESS;Initial Catalog=ProjectEvaluation;Integrated Security=True"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM StudentList WHERE [Student Number] = @StudentNumber", con);
                    cmd.Parameters.AddWithValue("@StudentNumber", studentInput);

                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                        Thread.Sleep(1000);
                        MainLogin1 studentL1 = new MainLogin1(studentInput);
                        this.Hide();
                        studentL1.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        Thread.Sleep(1000);
                        MessageBox.Show("No Input or Not Available in the Database! Please Input your Student Number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            SignInOption signInOption = new SignInOption();
            this.Hide();
            signInOption.ShowDialog();
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Thread.Sleep(1000);
            MessageBox.Show("Not available as of now. Please Try Again Later!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Thread.Sleep(1000);
            MessageBox.Show("Immediately Message/Contact your Administrator to Access your Account!","Message",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
