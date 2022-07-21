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
        private DataTable dt = new DataTable();
        private DataSet ds = new DataSet();
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OSR3O6V\SQLEXPRESS;Initial Catalog=clinic;Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        { try
            {

                using (SqlConnection con = new SqlConnection((@"Data Source=DESKTOP-OSR3O6V\SQLEXPRESS;Initial Catalog=clinic;Integrated Security=True")))
                {
                    con.Open();
                    SqlCommand com = new SqlCommand("SP_ID_Insert", con);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@ID", SqlDbType.Int).Value = Convert.ToInt32(textBox1.Text);
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
            catch (Exception ex)
            {
                MessageBox.Show("FIELDS SHOULD NOT BE EMPTY");
            }

                
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            {            
                dataGridView1.DataSource = BindSource();
            }

            DataTable BindSource()
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


        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection((@"Data Source=DESKTOP-OSR3O6V\SQLEXPRESS;Initial Catalog=clinic;Integrated Security=True")))
                {
                    con.Open();
                    SqlCommand com = new SqlCommand("SP_ID_UPDATE", con);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@ID", SqlDbType.Int).Value = Convert.ToInt32(textBox1.Text);
                    com.Parameters.AddWithValue("@Date", SqlDbType.DateTime).Value = DateTime.Parse(dateTimePicker1.Text);
                    com.Parameters.AddWithValue("@Name", SqlDbType.NVarChar).Value = textBox3.Text;
                    com.Parameters.AddWithValue("@Age", SqlDbType.Int).Value = Convert.ToInt32(textBox4.Text);
                    com.Parameters.AddWithValue("@Sex", SqlDbType.NVarChar).Value = textBox5.Text;
                    com.Parameters.AddWithValue("@Diagnosis", SqlDbType.NVarChar).Value = textBox6.Text;
                    com.Parameters.AddWithValue("@Treatment", SqlDbType.NVarChar).Value = textBox7.Text;
                    com.Parameters.AddWithValue("@Charges", SqlDbType.Decimal).Value = Convert.ToDecimal(textBox8.Text);
                    com.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("successfully updated");



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("empty field detected");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        { try
              {
                using (SqlConnection con = new SqlConnection((@"Data Source=DESKTOP-OSR3O6V\SQLEXPRESS;Initial Catalog=clinic;Integrated Security=True")))
                {

                    if (MessageBox.Show("Are you confirem to delete", "delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        con.Open();
                        SqlCommand com = new SqlCommand("SP_ID_DELETE", con);
                        com.CommandType = CommandType.StoredProcedure;
                        com.Parameters.AddWithValue("@ID", SqlDbType.Int).Value = Convert.ToInt32(textBox1.Text);
                        com.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("successfully deleted");
                    }



                }
             }
            catch (Exception ex)
            {
                MessageBox.Show(" select atleast one ID");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(); 
            form2.ShowDialog();
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox3.Text = String.Empty;
            textBox4.Text = String.Empty;
            textBox5.Text = String.Empty;
            textBox6.Text = String.Empty;
            textBox7.Text = String.Empty; 
            textBox8.Text = String.Empty;
            

        }
    }
}
