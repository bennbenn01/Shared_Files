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
            Thread.Sleep(1000);
            MessageBox.Show("Not available as of now. Please Try Again Later!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Getting started guides
            Thread.Sleep(1000);
            MessageBox.Show("Not available as of now. Please Try Again Later!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //ELMS Help Desk
            Thread.Sleep(1000);
            MessageBox.Show("Not available as of now. Please Try Again Later!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Product News
            Thread.Sleep(1000);
            MessageBox.Show("Not available as of now. Please Try Again Later!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
