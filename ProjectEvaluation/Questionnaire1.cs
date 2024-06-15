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
        private string[] studentInfo;
        private string[] studentOptionInfo;
        public Questionnaire1()
        {
            InitializeComponent();          
        }

        public Questionnaire1(int userID, string[] studentInfo, string[] studentOptionInfo) : this()
        {
            studentID = userID;
            this.studentInfo = studentInfo;
            this.studentOptionInfo = studentOptionInfo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread.Sleep(1000);
            Demographics demo = new Demographics();
            this.Hide();
            demo.ShowDialog();
            this.Close();
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

            if (!AreAllAnswersSelected(answers))
            {
                Thread.Sleep(1000);
                MessageBox.Show("Please select an answer for all questions.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Thread.Sleep(1000);
            Questionnaire2 question2 = new Questionnaire2(studentID, studentInfo, studentOptionInfo, answers);
            this.Hide();
            question2.ShowDialog();
            this.Close();
        }

        private bool AreAllAnswersSelected(string[] answers)
        {
            foreach (var answer in answers)
            {
                if (answer == null)
                {
                    return false;
                }
            }
            return true;
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
            return null;
        }
    }
}
