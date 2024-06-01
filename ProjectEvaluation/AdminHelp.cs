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

namespace ProjectEvaluation
{
    public partial class AdminHelp : Form
    {
        public AdminHelp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Dashboard
            Thread.Sleep(1000);
            MessageBox.Show("This section likely provides a summary of key metrics and data visualizations about the student information system,such as the number of students, enrolled courses,and recent activities.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            //Switch Admin
            Thread.Sleep(1000);
            MessageBox.Show("This function might be used if there are multiple administrators with different user accounts. It allows them to switch between accounts without logging out.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            //Logout
            Thread.Sleep(1000);
            MessageBox.Show("Locate the logout button. It's typically found in the top navigation bar, user profile dropdown, or a dedicated logout section. Common logout button labels include \"Logout,\" \"Sign Out,\" or your username with a dropdown menu.Click the logout button.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            //View Student
            Thread.Sleep(1000);
            MessageBox.Show("This section allows administrators to view student information, including their profile, grades, and attendance records.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            //Update Student
            Thread.Sleep(1000);
            MessageBox.Show("This section allows administrators to update student information, such as their contact details or enrollment status.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            //Access Information of Student Evaluation
            Thread.Sleep(1000);
            MessageBox.Show("Details - Once you've selected the student, look for a section or button labeled \"Evaluation,\" \"Grades,\" \"Reports,\" or something similar. Clicking this will likely display the student's evaluation details, including their grades, performance feedback, or other relevant information.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        private void button7_Click(object sender, EventArgs e)
        {
            //Notification
            Thread.Sleep(1000);
            MessageBox.Show("This section might display important announcements or system notifications for administrators.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        private void button8_Click(object sender, EventArgs e)
        {
            //Messages
            Thread.Sleep(1000);
            MessageBox.Show("This section might be used for sending messages to students or staff.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
