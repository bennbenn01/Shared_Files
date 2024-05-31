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

namespace ProjectEvaluation
{
    public partial class Questionnaire1 : Form
    {
        private int studentID;
        public Questionnaire1()
        {
            InitializeComponent();          
        }

        public Questionnaire1(int userID) : this()
        {
            studentID = userID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult choice = MessageBox.Show("Do you want to return to the Dashboard?", "Message",MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (choice == DialogResult.Yes)
            {
                Thread.Sleep(1000);
                StudentDashboard dashboardS = new StudentDashboard();
                this.Hide();
                dashboardS.ShowDialog();
                this.Close();
            }
            else 
            {
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] answers = new string[6];

            answers[0] = GetSelectedChoice(groupBox1);
            answers[1] = GetSelectedChoice(groupBox2);
            answers[2] = GetSelectedChoice(groupBox3);
            answers[3] = GetSelectedChoice(groupBox4);
            answers[4] = GetSelectedChoice(groupBox5);
            answers[5] = GetSelectedChoice(groupBox6);

            Thread.Sleep(1000);
            Questionnaire2 question2 = new Questionnaire2(studentID, answers);
            this.Hide();
            question2.ShowDialog();
            this.Close();
        }

        private string GetSelectedChoice(GroupBox gb)
        {
            foreach (var control in gb.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    return radioButton.Text;
                }
            }
            return "No Answer";
        }
    }
}
