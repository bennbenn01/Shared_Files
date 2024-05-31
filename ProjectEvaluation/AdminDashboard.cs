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
    public partial class AdminDashboard : Form
    {
        private string adminUsername;
        public AdminDashboard()
        {
            InitializeComponent();
        }

        public AdminDashboard(string adminUsername) : this()
        {
            this.adminUsername = adminUsername;
            currentTextBoxAdmin.Text = adminUsername;

            //Hide the controls
            DashboardControls(false);
        }

        private bool isButton5Click = false;

        private void button3_Click(object sender, EventArgs e)
        {
            //Messages
            Thread.Sleep(1000);
            MessageBox.Show("No message available!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Notification
            Thread.Sleep(1000);
            MessageBox.Show("No notification available!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Dashboard
            isButton5Click = !isButton5Click;
            DashboardControls(isButton5Click);
        }

        private void DashboardControls(bool visible)
        {
            panel3.Visible = visible;
            button11.Visible = visible;
            button12.Visible = visible;
            button13.Visible = visible;
            pictureBox3.Visible = visible;
            pictureBox4.Visible = visible;
            pictureBox5.Visible = visible;

            if (visible)
            {
                panel3.BringToFront();
                button11.BringToFront();
                button12.BringToFront();
                button13.BringToFront();
                pictureBox3.BringToFront();
                pictureBox4.BringToFront();
                pictureBox5.BringToFront();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Switch Admin
            
            DialogResult choice = MessageBox.Show("Do you want switch admin account?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (choice == DialogResult.Yes)
            {
                Thread.Sleep(1000);
                AdminLogin adminL = new AdminLogin();
                this.Hide();
                adminL.ShowDialog();
                this.Close();
            }
            else 
            {
                return;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Help
            AdminHelp help = new AdminHelp();
            help.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Logout
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

        private void button13_Click(object sender, EventArgs e)
        {
            //Access Information of the Student Evaluation
            Thread.Sleep(1000);
            InformationEval eval = new InformationEval();
            eval.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //View Student
            Thread.Sleep(1000);
            ViewStudent viewStudent = new ViewStudent();
            viewStudent.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //Update Student
            Thread.Sleep(1000);
            UpdateStudent updateStudent = new UpdateStudent();
            updateStudent.ShowDialog();
        }
    }
}
