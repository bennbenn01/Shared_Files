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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Threading;

namespace ProjectEvaluation
{
    public partial class Questionnaire2 : Form
    {
        private int studentID;
        private string[] previousAnswers;
        public Questionnaire2(int userID, string[] answers)
        {
            InitializeComponent();
            studentID = userID;
            previousAnswers = answers;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult choice = MessageBox.Show("Are you finished answering the Evaluation?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (choice == DialogResult.Yes)
            {
                string[] answers = new string[3];

                answers[0] = GetSelectedChoice(groupBox1);
                answers[1] = GetSelectedChoice(groupBox2);
                answers[2] = GetSelectedChoice(groupBox3);

                StoreAnswersInDatabase(studentID, previousAnswers, answers);

                MessageBox.Show("Thank you for submitting the evaluation!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread.Sleep(1000);
            Questionnaire1 question1 = new Questionnaire1();
            this.Hide();
            question1.ShowDialog();
            this.Close();
        }

        private string GetSelectedChoice(System.Windows.Forms.GroupBox gb)
        {
            foreach (var control in gb.Controls)
            {
                if (control is System.Windows.Forms.RadioButton radioButton && radioButton.Checked)
                {
                    return radioButton.Text;
                }
            }
            return "No Answer";
        }

        private void StoreAnswersInDatabase(int userID,string[] answers1, string[] answers2)
        {            
            using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-6C0MD9JK\SQLEXPRESS;Initial Catalog=ProjectEvaluation;Integrated Security=True"))
            {
                con.Open();

                string query1 = "INSERT INTO Response1 ([Student User ID], Answer1, Answer2, Answer3, Answer4, Answer5, Answer6) VALUES(@UserID, @Answer1, @Answer2, @Answer3, @Answer4, @Answer5, @Answer6)";

                using (SqlCommand cmd1 = new SqlCommand(query1, con))
                {
                    cmd1.Parameters.AddWithValue("@UserID", userID);
                    cmd1.Parameters.AddWithValue("@Answer1", answers1[0]);
                    cmd1.Parameters.AddWithValue("@Answer2", answers1[1]);
                    cmd1.Parameters.AddWithValue("@Answer3", answers1[2]);
                    cmd1.Parameters.AddWithValue("@Answer4", answers1[3]);
                    cmd1.Parameters.AddWithValue("@Answer5", answers1[4]);
                    cmd1.Parameters.AddWithValue("@Answer6", answers1[5]);
                    cmd1.ExecuteNonQuery();
                }

                string query2 = "INSERT INTO Response2 ([Student User ID], Answer1, Answer2, Answer3) VALUES(@UserID, @Answer1, @Answer2, @Answer3)";

                using (SqlCommand cmd2 = new SqlCommand(query2, con))
                {
                    cmd2.Parameters.AddWithValue("@UserID", userID);
                    cmd2.Parameters.AddWithValue("@Answer1", answers2[0]);
                    cmd2.Parameters.AddWithValue("@Answer2", answers2[1]);
                    cmd2.Parameters.AddWithValue("@Answer3", answers2[2]);
                    cmd2.ExecuteNonQuery();
                }

            }
        }
    }
}
