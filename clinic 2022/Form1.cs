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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OSR3O6V\SQLEXPRESS;Initial Catalog=clinic;Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection((@"Data Source=DESKTOP-OSR3O6V\SQLEXPRESS;Initial Catalog=clinic;Integrated Security=True")))
            { 
                con.Open();
                SqlCommand com = new SqlCommand("SP_ID_Insert", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@ID", SqlDbType.NChar).Value = textBox1.Text;
                com.Parameters.AddWithValue("@Date", SqlDbType.DateTime).Value = DateTime.Parse(dateTimePicker1.Text);
                com.Parameters.AddWithValue("@Name", SqlDbType.NVarChar).Value = textBox3.Text;
                com.Parameters.AddWithValue("@Age", SqlDbType.Int).Value = Convert.ToInt32(textBox4.Text);
                com.Parameters.AddWithValue("@Sex", SqlDbType.NVarChar).Value = textBox5.Text;
                com.Parameters.AddWithValue("@Diagnosis", SqlDbType.NVarChar).Value = textBox6.Text;
                com.Parameters.AddWithValue("@Treatment", SqlDbType.NVarChar).Value = textBox7.Text;
                com.Parameters.AddWithValue("@Charges", SqlDbType.Decimal).Value = Convert.ToDecimal(textBox8.Text);
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("successfully saved");
                
                

            }
            


                
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            void loadalldata()
            {
                SqlCommand myCmd = new SqlCommand("SP_Patient_View", con);
                SqlDataAdapter da = new SqlDataAdapter(myCmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
                dataGridView1.DataSource = dt;
            }

            loadalldata();


        }
    }
}
