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
    public partial class auth : Form
    {
        public auth()
        {
            InitializeComponent();
        }
      
   

        private void auth_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddUser newuser = new AddUser();
            newuser.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Enter(object sender, EventArgs e)
        {
         
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.ForeColor = Color.Black;
        }
        public static int checkrow;
        private void button1_Click_1(object sender, EventArgs e)
        {
       
            try
            {

                SqlConnection newConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\CODS\\C#\\TheMarket\\TheMarket\\TheMarket.mdf;Integrated Security=True;Connect Timeout=30");
                newConnection.Open();
                if (newConnection.State == ConnectionState.Open)
                {

                    SqlCommand checkuser = new SqlCommand("select count(*) from users where id='"+textBox2.Text+"';", newConnection);
                    checkrow = (int)checkuser.ExecuteScalar();
                    if (checkrow > 0)
                    {
                        this.Hide();
                        dashboard db = new dashboard();
                        db.ShowDialog();
                      
                    }
                    else
                    {
                        MessageBox.Show("Uncorrect ID "+checkrow.ToString(),"Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        newConnection.Close();
                    }



                
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Uncorrect ID", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            textBox1.Text = "";
            textBox2.Text = "";

        }
        }
    
}
