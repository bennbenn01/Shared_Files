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
            LoadData("Response1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Response 2
            LoadData("Response2");
        }

        private void LoadData(string tableName)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-6C0MD9JK\SQLEXPRESS;Initial Catalog=ProjectEvaluation;Integrated Security=True"))
            {
                con.Open();
                string query = $"SELECT * FROM {tableName}";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    DataTable verticalDt = new DataTable();
                    verticalDt.Columns.Add("    Questionnaire");
                    verticalDt.Columns.Add("    Answers");

                    DataRow previousRow = null;

                    foreach (DataRow row in dt.Rows)
                    {
                        if (previousRow == null || !AreRowsEqual(row, previousRow))
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
                else
                {
                    MessageBox.Show($"No data found in {tableName}.");
                }
            }
        }

        private bool AreRowsEqual(DataRow row1, DataRow row2)
        {
            foreach (DataColumn col in row1.Table.Columns)
            {
                if (!row1[col].Equals(row2[col]))
                {
                    return false;
                }
            }
            return true;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == 0 && e.ColumnIndex >= 0)
            {
                if (!(e.CellStyle.Font != null && e.CellStyle.Font.Bold))
                {
                    e.CellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);
                }
            }
        }
    }
}
