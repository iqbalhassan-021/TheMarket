using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TheMarket
{
    public partial class StaffType : Form
    {
        public StaffType()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        public static int row;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "") {
                try
                {
                    SqlConnection newConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\CODS\\C#\\TheMarket\\TheMarket\\TheMarket.mdf;Integrated Security=True;Connect Timeout=30");
                    newConnection.Open();
                    if (newConnection.State == ConnectionState.Open)
                    { 
                        SqlCommand check = new SqlCommand("select count(tstaff) from totalstaff", newConnection);

                        row = (int)check.ExecuteScalar();

                        if (row > 0)
                        {

                                  SqlCommand insertSQL = new SqlCommand("insert into Staff(id,Name,Age,Qualification,Address) values('" + textBox3.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox5.Text + "','" + textBox4.Text + "' )", newConnection);
            
                            SqlCommand updateTotalProducts = new SqlCommand("update totalstaff set tstaff=tstaff+1", newConnection);
                         insertSQL.ExecuteNonQuery();
                            updateTotalProducts.ExecuteNonQuery();
                        MessageBox.Show("Staff Added", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  
                        }
                        else
                        {
                            SqlCommand insertProductT = new SqlCommand("insert into totalstaff(tstaff) values(1)", newConnection);
                            
                            SqlCommand insertSQL = new SqlCommand("insert into Staff(id,Name,Age,Qualification,Address) values('" + textBox3.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox5.Text + "','" + textBox4.Text + "' )", newConnection);
                         
                            insertSQL.ExecuteNonQuery();
                            insertProductT.ExecuteNonQuery();
                            MessageBox.Show("Staff Added", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                        }

    

                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Detected", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please fill the Form to add the Staff member", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
      
        }
    }
}
