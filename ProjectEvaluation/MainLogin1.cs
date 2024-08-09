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
    public partial class MainLogin1 : Form
    {
        private string studentInput;
        public MainLogin1(string studentInput)
        {
            InitializeComponent();
            this.studentInput = studentInput;
            currentTextBoxStudent.Text = studentInput;

            button3.Enabled = false;
            button3.Visible = false;
        }

        private bool isButton3Clicked = false;

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxPassword.Text))
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

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Password")
            {
                textBoxPassword.Text = "";
                textBoxPassword.PasswordChar = '*';
                textBoxPassword.ForeColor = Color.Black;
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxPassword.Text))
            {
                textBoxPassword.Text = "Password";
                textBoxPassword.PasswordChar = '\0';
                textBoxPassword.ForeColor = Color.Silver;
                button3.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string studentPassword = textBoxPassword.Text;

                if (string.IsNullOrEmpty(studentPassword))
                {
                    Thread.Sleep(1000);
                    MessageBox.Show("Please Input your Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-6C0MD9JK\SQLEXPRESS;Initial Catalog=ProjectEvaluation;Integrated Security=True"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM StudentList WHERE [Student Number] = @StudentNumber AND [Student Password] = @Password", con);
                    cmd.Parameters.AddWithValue("@StudentNumber", studentInput);
                    cmd.Parameters.AddWithValue("@Password", studentPassword);

                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                        cmd = new SqlCommand("SELECT [Student User ID], [First Name], [Last Name] FROM StudentList WHERE [Student Number] = @StudentNumber", con);
                        cmd.Parameters.AddWithValue("@StudentNumber", studentInput);
                        SqlDataReader reader = cmd.ExecuteReader();

                        int studentID = 0;
                        string firstName = "";
                        string lastName = "";

                        if (reader.Read())
                        {
                            studentID = Convert.ToInt32(reader["Student User ID"]);
                            firstName = reader["First Name"].ToString();
                            lastName = reader["Last Name"].ToString();
                        }
                        reader.Close();

                        Thread.Sleep(1000);
                        MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        StudentDashboard dashboardS = new StudentDashboard(studentID, firstName, lastName);
                        this.Hide();
                        dashboardS.ShowDialog();
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
            MainLogin mainL = new MainLogin();
            this.Hide();
            mainL.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            isButton3Clicked = !isButton3Clicked;
            textBoxPassword.PasswordChar = isButton3Clicked ? '\0' : '*';
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Thread.Sleep(1000);
            MessageBox.Show("Immediately Message/Contact your Administrator for Password Change!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
