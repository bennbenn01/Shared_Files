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
    public partial class StudentDashboard : Form
    {
        private int studentID;
        private string firstName;
        private string lastName;
        public StudentDashboard()
        {
            InitializeComponent();
        }

        public StudentDashboard(int userID, string firstName, string lastName) : this()
        {
            studentID = userID;
            this.firstName = firstName;
            this.lastName = lastName;
            currentTextBoxStudent.Text = firstName + " " + lastName;

            //Hide the controls
            DashboardControls(false);
        }

        private bool isButton1Click = false;

        private void button1_Click(object sender, EventArgs e)
        {
            //Dashboard
            ClickDashboard();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            //PictureBox Dashboard
            ClickDashboard();
        }

        private void ClickDashboard()
        {
            isButton1Click = !isButton1Click;
            DashboardControls(isButton1Click);
        }

        private void DashboardControls(bool visible)
        {
            label1.Visible = visible;
            label9.Visible = visible;
            label10.Visible = visible;
            linkLabel1.Visible = visible;
            linkLabel2.Visible = visible;
            linkLabel3.Visible = visible;
            pictureBox2.Visible = visible;
            pictureBox3.Visible = visible;
            pictureBox4.Visible = visible;
            pictureBox5.Visible = visible;
            pictureBox6.Visible = visible;
            panel3.Visible = visible;
            panel4.Visible = visible;
            panel5.Visible = visible;
            panel6.Visible = visible;
            panel7.Visible = visible;
            panel8.Visible = visible;
            panel9.Visible = visible;
            panel10.Visible = visible;
            label5.Visible = visible;
            label6.Visible = visible;
            label7.Visible = visible;
            label8.Visible = visible;

            if (visible)
            {
                label1.BringToFront();
                label9.BringToFront();
                label10.BringToFront();
                linkLabel1.BringToFront();
                linkLabel2.BringToFront();
                linkLabel3.BringToFront();
                pictureBox2.BringToFront();
                pictureBox3.BringToFront();
                pictureBox4.BringToFront();
                pictureBox5.BringToFront();
                pictureBox6.BringToFront();
                panel3.BringToFront();
                panel4.BringToFront();
                panel5.BringToFront();
                panel6.BringToFront();
                panel7.BringToFront();
                panel8.BringToFront();
                panel9.BringToFront();
                panel10.BringToFront();
                label5.BringToFront();
                label6.BringToFront();
                label7.BringToFront();
                label8.BringToFront();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Messages
            ClickMessages();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            //PictureBox Messages
            ClickMessages();
        }

        private void ClickMessages()
        {
            Thread.Sleep(1000);
            MessageBox.Show("No message available!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //About
            ClickAbout();
        }
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            //PictureBox About
            ClickAbout();
        }

        private void ClickAbout()
        {
            Thread.Sleep(1000);
            StudentAbout about = new StudentAbout(studentID, firstName, lastName); ;
            about.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Help
            ClickHelp();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            //PictureBox Help
            ClickHelp();
        }

        private void ClickHelp()
        {
            Thread.Sleep(1000);
            StudentHelp help = new StudentHelp();
            help.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Logout
            ClickLogout();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            //PictureBox Logout
            ClickLogout();
        }

        private void ClickLogout()
        {
            DialogResult choice = MessageBox.Show("Do you want to exit the Application?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (choice == DialogResult.Yes)
            {
                Thread.Sleep(1000);
                MessageBox.Show("Thank you for using the Application!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainLogin main = new MainLogin();
                this.Hide();
                main.ShowDialog();
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Assignment LinkLabel
            DialogResult choice = MessageBox.Show("Do you want to answer the Student Evaluation?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (choice == DialogResult.Yes)
            {
                Thread.Sleep(1000);
                Demographics demo = new Demographics(studentID);
                demo.ShowDialog();
            }
            else
            {
                return;
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Announcement LinkLabel
            Thread.Sleep(1000);
            MessageBox.Show("Not available as of now. Please Try Again Later!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //To-Do LinkLabel
            Thread.Sleep(1000);
            MessageBox.Show("No due was available as of now. Please Try Again Later!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Notification
            Thread.Sleep(1000);
            MessageBox.Show("No notification available!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
