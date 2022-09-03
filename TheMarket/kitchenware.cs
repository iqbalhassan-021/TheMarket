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
    public partial class kitchenware : Form
    {
        public static kitchenware instance;
      
        
        public kitchenware()
        {
            InitializeComponent();
            instance = this;
       
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
      
            Ptype pt6 = new Ptype();
            pt6.ShowDialog();
        }

        private void kitchenware_Load(object sender, EventArgs e)
        {


            try
            {
                string Query = "select * from KitchenWare;";

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
         


        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            removeProduct rm = new removeProduct();
            rm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Query = "select * from KitchenWare;";

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

                    SqlCommand del1 = new SqlCommand("delete from KitchenWare", newConnection);

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
