using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectEvaluation
{
    public partial class SignInOption : Form
    {
        public SignInOption()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainLogin studentL = new MainLogin();
            this.Hide();
            Thread.Sleep(1000);
            studentL.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread.Sleep(1000);
            MessageBox.Show("Not available as of now. Please Try Again Later!", "Message",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread.Sleep(1000);
            MessageBox.Show("Not available as of now. Please Try Again Later!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Thread.Sleep(1000);
            AdminLogin adminL = new AdminLogin();
            this.Hide();
            adminL.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Thread.Sleep(1000);
            MessageBox.Show(@"It's easier and safer to sign in with passkeys. You can sign in using your face,
fingerprint, PIN, or use another device like a phone or security key.
No passwords, apps, or codes needed.

To use this option, you must have previously set this up on your account.", "", MessageBoxButtons.OK);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Thread.Sleep(1000);
            MessageBox.Show(@"To use this option, you must have previously linked your personal Microsoft 
account to a GitHub account.
 
You can't use this option to access work or school resources.", "", MessageBoxButtons.OK);
        }
    }
}
