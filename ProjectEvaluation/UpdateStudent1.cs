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
using System.Windows.Forms.DataVisualization.Charting;

namespace ProjectEvaluation
{
    public partial class UpdateStudent1 : Form
    {
        private string[] previousStudentInfo;
        public UpdateStudent1(string[] previousStudentInfo)
        {
            InitializeComponent();
            this.previousStudentInfo = previousStudentInfo;
            
            currentTextBoxStudentNumber.Text = previousStudentInfo[0];
            currentTextBoxStudentPassword.Text = previousStudentInfo[1];
            currentTextBoxFirstName.Text = previousStudentInfo[2];
            currentTextBoxLastName.Text = previousStudentInfo[3];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] studentInfo = new string[4];

            studentInfo[0] = currentTextBoxStudentNumber.Text;
            studentInfo[1] = currentTextBoxStudentPassword.Text;
            studentInfo[2] = currentTextBoxFirstName.Text;
            studentInfo[3] = currentTextBoxLastName.Text;

            try
            {
                if (string.IsNullOrEmpty(studentInfo[0]) || string.IsNullOrEmpty(studentInfo[1]) || string.IsNullOrEmpty(studentInfo[2]) || string.IsNullOrEmpty(studentInfo[3]))
                {
                    MessageBox.Show("Please fill up the Information of the Student", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-6C0MD9JK\SQLEXPRESS;Initial Catalog=ProjectEvaluation;Integrated Security=True"))
                {
                    con.Open();
                    string query = @"
                
                    UPDATE StudentList 
                    SET [Student Number] = @StudentNumber,
                    [Student Password] = @StudentPassword,
                    [First Name] = @FirstName,
                    [Last Name] = @LastName
                    WHERE[Student Number] = @PreviousStudentNumber";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@StudentNumber", studentInfo[0]);
                        cmd.Parameters.AddWithValue("@StudentPassword", studentInfo[1]);
                        cmd.Parameters.AddWithValue("@FirstName", studentInfo[2]);
                        cmd.Parameters.AddWithValue("@LastName", studentInfo[3]);
                        cmd.Parameters.AddWithValue("@PreviousStudentNumber", previousStudentInfo[0]);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Student Information was updated successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
