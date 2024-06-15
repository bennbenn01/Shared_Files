using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;

namespace ProjectEvaluation
{
    public partial class ViewStudent : Form
    {
        public ViewStudent()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //View Student
            ClickViewStudent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //PictureBox View Student
            ClickViewStudent();
        }

        private void ClickViewStudent()
        {
            listBox1.Items.Clear();

            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-6C0MD9JK\SQLEXPRESS;Initial Catalog=ProjectEvaluation;Integrated Security=True"))
                {
                    con.Open();
                    string query1 = @"SELECT [Student User ID], [First Name], [Last Name] FROM StudentList";

                    bool data = false;

                    using (SqlCommand cmd = new SqlCommand(query1, con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            string displayStudentID = "";
                            string displayFirstName1 = "";
                            string displayLastName2 = "";
                            string displayFullInfo = "";

                            while (reader.Read())
                            {
                                displayStudentID = reader["Student User ID"].ToString();
                                displayFirstName1 = reader["First Name"].ToString();
                                displayLastName2 = reader["Last Name"].ToString();
                                displayFullInfo = "ID: " + displayStudentID + "\tFull Name: " + displayFirstName1 + " " + displayLastName2;

                                listBox1.Items.Add(displayFullInfo);
                                data = true;
                            }
                        }
                    }

                    if (!data)
                    {
                        MessageBox.Show("No Input was Available in the Database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Search Student
            ClickSearchStudent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //Picture Search Student
            ClickSearchStudent();
        }

        private void ClickSearchStudent()
        {
            listBox1.Items.Clear();

            try
            {
                string firstName = textBoxFirstName.Text.Trim();
                string lastName = textBoxLastName.Text.Trim();

                using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-6C0MD9JK\SQLEXPRESS;Initial Catalog=ProjectEvaluation;Integrated Security=True"))
                {
                    con.Open();
                    string query2 = @"SELECT * FROM StudentList WHERE [First Name] LIKE @FirstName AND [Last Name] LIKE @LastName";

                    using (SqlCommand cmd = new SqlCommand(query2, con))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", "%" + firstName + "%");
                        cmd.Parameters.AddWithValue("@LastName", "%" + lastName + "%");

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            string displayStudentID = "";
                            string displayFirstName1 = "";
                            string displayLastName2 = "";
                            string displayFullInfo = "";

                            while (reader.Read())
                            {
                                displayStudentID = reader["Student User ID"].ToString();
                                displayFirstName1 = reader["First Name"].ToString();
                                displayLastName2 = reader["Last Name"].ToString();
                                displayFullInfo = "ID: " + displayStudentID + "\tFull Name: " + displayFirstName1 + " " + displayLastName2;

                                listBox1.Items.Add(displayFullInfo);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
