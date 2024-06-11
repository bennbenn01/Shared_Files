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
    public partial class StudentAbout : Form
    {
        private int studentID;
        private string firstName;
        private string lastName;
        public StudentAbout(int studentID,string firstName, string lastName)
        {
            InitializeComponent();
            this.studentID = studentID;
            this.firstName = firstName;
            this.lastName = lastName;
            currentTextBoxStudentID.Text = studentID.ToString();
            currentTextBoxFirstName.Text = firstName;
            currentTextBoxLastName.Text = lastName;
        }
    }
}
