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
    public partial class Demographics : Form
    {
        private int studentID;
        public Demographics()
        {
            InitializeComponent();
            comboBoxProperties();
            questionLabel1.Visible = false;
            questionLabel2.Visible = false;
            cbOptionYearLevel1.Visible = false;
            cbOptionYearLevel2.Visible = false;
            cbOptionYearLevel3.Visible = false;
            comboBoxWorkOption.Visible = false;
        }

        public Demographics(int userID) : this()
        {
            studentID = userID;
        }

        private void comboBoxProperties()
        {
            for (int age = 1; age <= 100; age++) 
            {
                comboBoxAge.Items.Add(age);
            }

            string[] yearLevel = {"1st Year Level", "2nd Year Level", "3rd Year Level", "4th Year Level"};
            foreach (string yL in yearLevel) 
            {
                comboBoxYearLevel.Items.Add(yL);
            }

            string[] optionYearLevel1 = { "1st Year Level", "2nd Year Level", "3rd Year Level", "4th Year Level" };
            foreach (string oYL1 in optionYearLevel1)
            {
                cbOptionYearLevel1.Items.Add(oYL1);
            }

            string[] optionYearLevel2 = { "1st Year Level", "2nd Year Level", "3rd Year Level", "4th Year Level" };
            foreach (string oYL2 in optionYearLevel2)
            {
                cbOptionYearLevel2.Items.Add(oYL2);
            }

            string[] optionYearLevel3 = { "1st Year Level", "2nd Year Level", "3rd Year Level", "4th Year Level" };
            foreach (string oYL3 in optionYearLevel3)
            {
                cbOptionYearLevel3.Items.Add(oYL3);
            }

            string[] workOption = { "Regular", "Irregular" };
            foreach (string wo in workOption)
            {
                comboBoxWorkOption.Items.Add(wo);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string[] studentInfo = new string[6];
                string[] studentOptionInfo = new string[3];

                studentInfo[0] = textBoxFirstName.Text;
                studentInfo[1] = textBoxLastName.Text;
                studentInfo[2] = comboBoxAge.Text;
                studentInfo[3] = comboBoxYearLevel.Text;
                studentInfo[4] = rbRegular.Checked ? "Regular" : rbIrregular.Checked ? "Irregular" : "N/A";
                studentInfo[5] = comboBoxWorkOption.Text;

                studentOptionInfo[0] = cbOptionYearLevel1.Text;
                studentOptionInfo[1] = cbOptionYearLevel2.Text;
                studentOptionInfo[2] = cbOptionYearLevel3.Text;

                if (rbRegular.Checked)
                {

                    if (!string.IsNullOrEmpty(studentInfo[0]) && !string.IsNullOrEmpty(studentInfo[1]) && !string.IsNullOrEmpty(studentInfo[2]) && !string.IsNullOrEmpty(studentInfo[3]) &&
                        !string.IsNullOrEmpty(studentInfo[4]) && !string.IsNullOrEmpty(studentInfo[5]))
                    {
                        DialogResult choice = MessageBox.Show("Would you proceed to the Questionnaire?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        Thread.Sleep(1000);
                        Questionnaire1 question = new Questionnaire1(studentID, studentInfo, studentOptionInfo);
                        this.Hide();
                        question.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        Thread.Sleep(1000);
                        MessageBox.Show("Please fill up the Information provided.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else 
                {
                    if (!string.IsNullOrEmpty(studentInfo[0]) && !string.IsNullOrEmpty(studentInfo[1]) && !string.IsNullOrEmpty(studentInfo[2]) && !string.IsNullOrEmpty(studentInfo[3]) &&
                        !string.IsNullOrEmpty(studentInfo[4]) && !string.IsNullOrEmpty(studentInfo[5]) && !string.IsNullOrEmpty(cbOptionYearLevel1.Text) && !string.IsNullOrEmpty(cbOptionYearLevel2.Text) &&
                        !string.IsNullOrEmpty(cbOptionYearLevel3.Text))
                    {
                        DialogResult choice = MessageBox.Show("Would you proceed to the Questionnaire?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        Thread.Sleep(1000);
                        Questionnaire1 question = new Questionnaire1(studentID, studentInfo, studentOptionInfo);
                        this.Hide();
                        question.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        Thread.Sleep(1000);
                        MessageBox.Show("Please fill up the Information provided.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                Thread.Sleep(1000);
                MessageBox.Show($"An error occured: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbRegular_CheckedChanged(object sender, EventArgs e)
        {
            questionLabel2.Visible = rbRegular.Checked;
            comboBoxWorkOption.Visible = rbRegular.Checked;
        }

        private void rbIrregular_CheckedChanged(object sender, EventArgs e)
        {
            questionLabel1.Visible = rbIrregular.Checked;
            questionLabel2.Visible = rbIrregular.Checked;
            cbOptionYearLevel1.Visible = rbIrregular.Checked;
            cbOptionYearLevel2.Visible = rbIrregular.Checked;
            cbOptionYearLevel3.Visible = rbIrregular.Checked;
            comboBoxWorkOption.Visible = rbIrregular.Checked;
        }
    }
}
