﻿using System;
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
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-6C0MD9JK\SQLEXPRESS;Initial Catalog=ProjectEvaluation;Integrated Security=True"))
                {
                    con.Open();
                    string query1 = @"SELECT [First Name], [Last Name] FROM StudentList";

                    bool data = false;

                    using (SqlCommand cmd = new SqlCommand(query1, con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            string displayFirstName1 = "";
                            string displayLastName2 = "";
                            string displayFullName3 = "";

                            while (reader.Read())
                            {
                                displayFirstName1 = reader["First Name"].ToString();
                                displayLastName2 = reader["Last Name"].ToString();
                                displayFullName3 = displayFirstName1 + " " + displayLastName2;

                                listBox1.Items.Add(displayFullName3);
                                data = true;
                            }
                        }
                    }

                    if (!data)
                    {
                        MessageBox.Show("No Input was Available in the Database","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured: {ex.Message}", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Search Student
            listBox1.Items.Clear();

            try
            {
                string firstName = textBoxFirstName.Text.Trim();
                string lastName = textBoxLastName.Text.Trim();

                if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
                {
                    MessageBox.Show("Please Input Both First and Last Name of the Student", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-6C0MD9JK\SQLEXPRESS;Initial Catalog=ProjectEvaluation;Integrated Security=True"))
                {
                    con.Open();
                    string query2 = @"SELECT * FROM StudentList WHERE [First Name] = @FirstName AND [Last Name] = @LastName";

                    using (SqlCommand cmd = new SqlCommand(query2, con))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            string displayFirstName1 = "";
                            string displayLastName2 = "";
                            string displayFullName3 = "";

                            while (reader.Read())
                            {
                                displayFirstName1 = reader["First Name"].ToString();
                                displayLastName2 = reader["Last Name"].ToString();
                                displayFullName3 = displayFirstName1 + " " + displayLastName2;

                                listBox1.Items.Add(displayFullName3);
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
