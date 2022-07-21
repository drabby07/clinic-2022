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

namespace clinic_2022
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BindSource();
        }

        public DataTable BindSource()
        {
            string sqlCon = @"Data Source=DESKTOP-OSR3O6V\SQLEXPRESS;Initial Catalog=clinic;Integrated Security=True";
            string sqlSelect = @"select * from Followup";
            using (SqlConnection conn = new SqlConnection(sqlCon))
            {
                using (SqlCommand cmd = new SqlCommand(sqlSelect, conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        ds.Clear();
                        adapter.Fill(ds);

                        dt = ds.Tables[0];
                        conn.Close();
                    }
                }
            }
            return dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
