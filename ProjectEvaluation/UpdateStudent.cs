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
    public partial class UpdateStudent : Form
    {
        public UpdateStudent()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Check Available Student
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-6C0MD9JK\SQLEXPRESS;Initial Catalog=ProjectEvaluation;Integrated Security=True"))
                {
                    con.Open();
                    string query1 = @"SELECT [Student Number], [Student Password], [First Name], [Last Name] FROM StudentList";

                    SqlCommand cmd = new SqlCommand(query1, con);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Update Student Information
            string[] studentInfo = new string[4];

            DialogResult choice = MessageBox.Show("Do you want to update this row of the student?","Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (choice == DialogResult.Yes)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    studentInfo[0] = selectedRow.Cells["Student Number"].Value.ToString();
                    studentInfo[1] = selectedRow.Cells["Student Password"].Value.ToString();
                    studentInfo[2] = selectedRow.Cells["First Name"].Value.ToString();
                    studentInfo[3] = selectedRow.Cells["Last Name"].Value.ToString();

                    Thread.Sleep(1000);
                    UpdateStudent1 updateStudent1 = new UpdateStudent1(studentInfo);
                    this.Hide();
                    updateStudent1.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please select a row before proceeding.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                return;
            }
        }
    }
}
