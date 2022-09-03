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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "tm102")
            {
                try
                {

                    SqlConnection newConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\CODS\\C#\\TheMarket\\TheMarket\\TheMarket.mdf;Integrated Security=True;Connect Timeout=30");
                    newConnection.Open();
                    if (newConnection.State == ConnectionState.Open)
                    {
                 
                        SqlCommand insertSQL = new SqlCommand("insert into users(id,username) values('" + textBox2.Text + "','" + textBox1.Text + "')", newConnection);
                 

                     
                        insertSQL.ExecuteNonQuery();
                        MessageBox.Show("User added successfully!", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Detected", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
             
            }
            else
            {
                MessageBox.Show("Uncorrect Pin", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
