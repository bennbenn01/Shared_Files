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
    public partial class StudentHelp : Form
    {
        public StudentHelp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Online Help
            ClickOnlineHelp();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //PictureBox Online help
            ClickOnlineHelp();
        }

        private void ClickOnlineHelp()
        {
            Thread.Sleep(1000);
            MessageBox.Show("Not available as of now. Please Try Again Later!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Getting started guides
            ClickGettingStartedGuides();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //PictureBox Getting started guides
            ClickGettingStartedGuides();
        }

        private void ClickGettingStartedGuides()
        {
            Thread.Sleep(1000);
            MessageBox.Show("Not available as of now. Please Try Again Later!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //ELMS Help Desk
            ClickELMSHelpDesk();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //PictureBox ELMS Help Desk
            ClickELMSHelpDesk();
        }

        private void ClickELMSHelpDesk()
        {
            Thread.Sleep(1000);
            MessageBox.Show("Not available as of now. Please Try Again Later!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Product News
            ClickProductNews();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //PictureBox Product News
            ClickProductNews();
        }

        private void ClickProductNews()
        {
            Thread.Sleep(1000);
            MessageBox.Show("Not available as of now. Please Try Again Later!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
