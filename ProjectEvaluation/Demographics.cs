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
using System.Reflection.Emit;

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
            comboBoxAge.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAge.Items.Add("Select your Age");
            for (int age = 1; age <= 100; age++)
            {
                comboBoxAge.Items.Add(age);
            }

            comboBoxYearLevel.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxYearLevel.Items.Add("Select Year Level");
            string[] yearLevel = { "1st Year Level", "2nd Year Level", "3rd Year Level", "4th Year Level" };
            foreach (string yL in yearLevel)
            {
                comboBoxYearLevel.Items.Add(yL);
            }

            cbOptionYearLevel1.DropDownStyle = ComboBoxStyle.DropDownList;
            cbOptionYearLevel1.Items.Add("Select Year Level");
            string[] optionYearLevel1 = { "1st Year Level", "2nd Year Level", "3rd Year Level", "4th Year Level" };
            foreach (string oYL1 in optionYearLevel1)
            {
                cbOptionYearLevel1.Items.Add(oYL1);
            }

            cbOptionYearLevel2.DropDownStyle = ComboBoxStyle.DropDownList;
            cbOptionYearLevel2.Items.Add("Select Year Level");
            string[] optionYearLevel2 = { "1st Year Level", "2nd Year Level", "3rd Year Level", "4th Year Level" };
            foreach (string oYL2 in optionYearLevel2)
            {
                cbOptionYearLevel2.Items.Add(oYL2);
            }

            cbOptionYearLevel3.DropDownStyle = ComboBoxStyle.DropDownList;
            cbOptionYearLevel3.Items.Add("Select Year Level");
            string[] optionYearLevel3 = { "1st Year Level", "2nd Year Level", "3rd Year Level", "4th Year Level" };
            foreach (string oYL3 in optionYearLevel3)
            {
                cbOptionYearLevel3.Items.Add(oYL3);
            }

            comboBoxWorkOption.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxWorkOption.Items.Add("Select Work Status");
            string[] workOption = { "Working", "Non-Working" };
            foreach (string wo in workOption)
            {
                comboBoxWorkOption.Items.Add(wo);
            }

            //Placeholder Index
            comboBoxAge.SelectedIndex = 0;
            comboBoxYearLevel.SelectedIndex = 0;
            cbOptionYearLevel1.SelectedIndex = 0;
            cbOptionYearLevel2.SelectedIndex = 0;
            cbOptionYearLevel3.SelectedIndex = 0;
            comboBoxWorkOption.SelectedIndex = 0;
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
                    if (studentInfo[2] == "Select your Age" && studentInfo[3] == "Select Year Level" && studentInfo[5] == "Select Work Status")
                    {
                        Thread.Sleep(1000);
                        MessageBox.Show("Please fill up the Information provided.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else 
                    {
                        if (!string.IsNullOrEmpty(studentInfo[0]) && !string.IsNullOrEmpty(studentInfo[1]) &&
                            studentInfo[2] != "Select your Age" && studentInfo[3] != "Select Year Level" &&
                            !string.IsNullOrEmpty(studentInfo[4]) && studentInfo[5] != "Select Work Status")
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
                else 
                {
                    if (studentInfo[2] == "Select your Age" && studentInfo[3] == "Select Year Level" && studentInfo[5] == "Select Work Status" &&
                        studentOptionInfo[0] == "Select Year Level" && studentOptionInfo[1] == "Select Year Level" && studentOptionInfo[2] == "Select Year Level")
                    {
                        Thread.Sleep(1000);
                        MessageBox.Show("Please fill up the Information provided.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else 
                    {
                        if (!string.IsNullOrEmpty(studentInfo[0]) && !string.IsNullOrEmpty(studentInfo[1]) && studentInfo[2] != "Select your Age" && studentInfo[3] != "Select Year Level" &&
                        !string.IsNullOrEmpty(studentInfo[4]) && studentInfo[5] != "Select Work Status" && studentOptionInfo[0] != "Select Year Level" && studentOptionInfo[1] != "Select Year Level" &&
                        studentOptionInfo[2] != "Select Year Level")
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

        private void comboBoxAge_DrawItem(object sender, DrawItemEventArgs e)
        {
            //Customizing the ComboBox/DropDown
            e.DrawBackground();

            ComboBox combo = (ComboBox)sender;
            string text = (e.Index >= 0) ? combo.Items[e.Index].ToString() : string.Empty;

            Brush brush = SystemBrushes.WindowText;
            if (e.Index == 0 && combo.SelectedIndex == -1)
            {
                brush = SystemBrushes.GrayText;
                text = "Select your Age";
            }

            e.Graphics.DrawString(text, e.Font, brush, e.Bounds);
            e.DrawFocusRectangle();
        }

        private void comboBoxYearLevel_DrawItem(object sender, DrawItemEventArgs e)
        {
            //Customizing the ComboBox/DropDown
            e.DrawBackground();

            ComboBox combo1 = (ComboBox)sender;
            string text1 = (e.Index >= 0) ? combo1.Items[e.Index].ToString() : string.Empty;

            Brush brush1 = SystemBrushes.WindowText;
            if (e.Index == 0 && combo1.SelectedIndex == -1)
            {
                brush1 = SystemBrushes.GrayText;
                text1 = "Select Year Level";
            }

            e.Graphics.DrawString(text1, e.Font, brush1, e.Bounds);
            e.DrawFocusRectangle();
        }

        private void cbOptionYearLevel1_DrawItem(object sender, DrawItemEventArgs e)
        {
            //Customizing the ComboBox/DropDown
            e.DrawBackground();

            ComboBox combo2 = (ComboBox)sender;
            string text2 = (e.Index >= 0) ? combo2.Items[e.Index].ToString() : string.Empty;

            Brush brush2 = SystemBrushes.WindowText;
            if (e.Index == 0 && combo2.SelectedIndex == -1)
            {
                brush2 = SystemBrushes.GrayText;
                text2 = "Select Year Level";
            }

            e.Graphics.DrawString(text2, e.Font, brush2, e.Bounds);
            e.DrawFocusRectangle();
        }

        private void cbOptionYearLevel2_DrawItem(object sender, DrawItemEventArgs e)
        {
            //Customizing the ComboBox/DropDown
            e.DrawBackground();

            ComboBox combo3 = (ComboBox)sender;
            string text3 = (e.Index >= 0) ? combo3.Items[e.Index].ToString() : string.Empty;

            Brush brush3 = SystemBrushes.WindowText;
            if (e.Index == 0 && combo3.SelectedIndex == -1)
            {
                brush3 = SystemBrushes.GrayText;
                text3 = "Select Year Level";
            }

            e.Graphics.DrawString(text3, e.Font, brush3, e.Bounds);
            e.DrawFocusRectangle();
        }

        private void cbOptionYearLevel3_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();

            ComboBox combo4 = (ComboBox)sender;
            string text4 = (e.Index >= 0) ? combo4.Items[e.Index].ToString() : string.Empty;

            Brush brush4 = SystemBrushes.WindowText;
            if (e.Index == 0 && combo4.SelectedIndex == -1)
            {
                brush4 = SystemBrushes.GrayText;
                text4 = "Select Year Level";
            }

            e.Graphics.DrawString(text4, e.Font, brush4, e.Bounds);
            e.DrawFocusRectangle();
        }

        private void comboBoxWorkOption_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();

            ComboBox combo5 = (ComboBox)sender;
            string text5 = (e.Index >= 0) ? combo5.Items[e.Index].ToString() : string.Empty;

            Brush brush5 = SystemBrushes.WindowText;
            if (e.Index == 0 && combo5.SelectedIndex == -1)
            {
                brush5 = SystemBrushes.GrayText;
                text5 = "Select Work Status";
            }

            e.Graphics.DrawString(text5, e.Font, brush5, e.Bounds);
            e.DrawFocusRectangle();
        }
    }
}
