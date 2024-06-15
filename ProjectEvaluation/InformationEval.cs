using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectEvaluation
{
    public partial class InformationEval : Form
    {
        public InformationEval()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Response 1
            using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-6C0MD9JK\SQLEXPRESS;Initial Catalog=ProjectEvaluation;Integrated Security=True"))
            {
                con.Open();
                string query1 = @"SELECT * FROM Response1";

                SqlCommand cmd = new SqlCommand(query1, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                DataTable verticalDt = new DataTable();
                verticalDt.Columns.Add("    Questionnaire");
                verticalDt.Columns.Add("    Answers");

                DataRow previousRow = dt.Rows[0];

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow row = dt.Rows[i];

                    if (!AreRowsEqual(row, previousRow))
                    {
                        foreach (DataColumn col in dt.Columns)
                        {
                            verticalDt.Rows.Add(col.ColumnName, row[col]);
                        }
                    }

                    previousRow = row;
                }

                dataGridView1.DataSource = verticalDt;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Response 2
            using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-6C0MD9JK\SQLEXPRESS;Initial Catalog=ProjectEvaluation;Integrated Security=True"))
            {
                con.Open();
                string query2 = @"SELECT * FROM Response2";

                SqlCommand cmd = new SqlCommand(query2, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                DataTable verticalDt = new DataTable();
                verticalDt.Columns.Add("    Questionnaire");
                verticalDt.Columns.Add("    Answers");

                DataRow previousRow = dt.Rows[0];

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow row = dt.Rows[i];

                    if (!AreRowsEqual(row, previousRow))
                    {
                        foreach (DataColumn col in dt.Columns)
                        {
                            verticalDt.Rows.Add(col.ColumnName, row[col]);
                        }
                    }

                    previousRow = row;
                }

                dataGridView1.DataSource = verticalDt;
            }
        }

        private bool AreRowsEqual(DataRow row1, DataRow row2)
        {
            for (int i = 0; i < row1.ItemArray.Length; i++)
            {
                if (!row1[i].Equals(row2[i]))
                {
                    return false;
                }
            }
            return true;
        }

    }
}
