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
    public partial class CoolDrinks : Form
    {

        public static CoolDrinks instance;
    
        public CoolDrinks()
        {
            InitializeComponent();
            instance = this;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Ptype pt2 = new Ptype();
            
            pt2.ShowDialog();
        
        }

        private void CoolDrinks_Load(object sender, EventArgs e)
        {

            try
            {
                string Query = "select * from CoolDrinks;";

                SqlConnection MyConn2 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\CODS\\C#\\TheMarket\\TheMarket\\TheMarket.mdf;Integrated Security=True;Connect Timeout=30");
                SqlCommand MyCommand2 = new SqlCommand(Query, MyConn2);
                MyConn2.Open();
                SqlDataAdapter MyAdapter = new SqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);

                dataGridView1.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
                MyConn2.Close();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            removeProduct rm = new removeProduct();
            rm.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Query = "select * from CoolDrinks;";

            SqlConnection MyConn2 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\CODS\\C#\\TheMarket\\TheMarket\\TheMarket.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand MyCommand2 = new SqlCommand(Query, MyConn2);
            MyConn2.Open();
            SqlDataAdapter MyAdapter = new SqlDataAdapter();
            MyAdapter.SelectCommand = MyCommand2;
            DataTable dTable = new DataTable();
            MyAdapter.Fill(dTable);

            dataGridView1.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
            MyConn2.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {


            try
            {

                SqlConnection newConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\CODS\\C#\\TheMarket\\TheMarket\\TheMarket.mdf;Integrated Security=True;Connect Timeout=30");
                newConnection.Open();


                if (newConnection.State == ConnectionState.Open)
                {

                    SqlCommand del1 = new SqlCommand("delete from CoolDrinks", newConnection);

                    del1.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Detected", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
