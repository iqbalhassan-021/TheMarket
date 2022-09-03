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
  
    public partial class removeProduct : Form
    {

        public int count;
        public removeProduct()
        {
            InitializeComponent();
            count = 0;
        }
        public static int btnc = 0;
        private void button1_Click(object sender, EventArgs e)
        {

            btnc = btnc + 1;
            if (btnc % 2 == 0)
            {

                btnc = 1;

            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please select a type and fill the textbox to continue", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {




                if (radioButton1.Checked)
                {

                    count = 1;
                    //    string[] row = { Ptype.instance.tb1.Text, Ptype.instance.tb2.Text, Ptype.instance.tb3.Text };
                    //  ListViewItem lv = new ListViewItem(row);
                    //  kitchenware.instance.lwP.Items.Add(lv);
                    try
                    {

                        SqlConnection newConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\CODS\\C#\\TheMarket\\TheMarket\\TheMarket.mdf;Integrated Security=True;Connect Timeout=30");
                        newConnection.Open();
                        if (newConnection.State == ConnectionState.Open)
                        {
                            //KitchenWare
                            SqlCommand insertSQL = new SqlCommand("delete from KitchenWare where id='" + textBox1.Text + "'", newConnection);
                            SqlCommand updateTotalProducts = new SqlCommand("update products set Totalproducts=Totalproducts-1", newConnection);

                            updateTotalProducts.ExecuteNonQuery();
                            insertSQL.ExecuteNonQuery();
                            MessageBox.Show("Product Removed", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Detected", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    textBox1.Text = "";



                }

                else if (radioButton2.Checked)
                {

                    count = 1;
                    // string[] row = { Ptype.instance.tb1.Text, Ptype.instance.tb2.Text, Ptype.instance.tb3.Text };
                    //ListViewItem lv = new ListViewItem(row);
                    //     Bread.instance.lwP.Items.Add(lv);
                    try
                    {

                        SqlConnection newConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\CODS\\C#\\TheMarket\\TheMarket\\TheMarket.mdf;Integrated Security=True;Connect Timeout=30");
                        newConnection.Open();
                        if (newConnection.State == ConnectionState.Open)
                        {
                            //Bread
                            SqlCommand insertSQL = new SqlCommand("delete from Bread where id='" + textBox1.Text + "'", newConnection);
                            SqlCommand updateTotalProducts = new SqlCommand("update products set Totalproducts=Totalproducts-1", newConnection);

                            updateTotalProducts.ExecuteNonQuery();
                            insertSQL.ExecuteNonQuery();
                            MessageBox.Show("Product Removed", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Detected", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    textBox1.Text = "";



                }

                else if (radioButton3.Checked)
                {



                    count = 1;
                    //   string[] row = { Ptype.instance.tb1.Text, Ptype.instance.tb2.Text, Ptype.instance.tb3.Text };
                    //  ListViewItem lv = new ListViewItem(row);
                    // CoolDrinks.instance.lwP.Items.Add(lv);
                    try
                    {

                        SqlConnection newConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\CODS\\C#\\TheMarket\\TheMarket\\TheMarket.mdf;Integrated Security=True;Connect Timeout=30");
                        newConnection.Open();
                        if (newConnection.State == ConnectionState.Open)
                        {
                            //CoolDrinks
                            SqlCommand insertSQL = new SqlCommand("delete from CoolDrinks where id='" + textBox1.Text + "'", newConnection);
                            SqlCommand updateTotalProducts = new SqlCommand("update products set Totalproducts=Totalproducts-1", newConnection);

                            updateTotalProducts.ExecuteNonQuery();
                            insertSQL.ExecuteNonQuery();

                            MessageBox.Show("Product Removed", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Detected", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    textBox1.Text = "";


                }

                else if (radioButton4.Checked)
                {

                    count = 1;
                    //   string[] row = { Ptype.instance.tb1.Text, Ptype.instance.tb2.Text, Ptype.instance.tb3.Text };
                    //  ListViewItem lv = new ListViewItem(row);
                    // Snacks.instance.lwP.Items.Add(lv);
                    try
                    {
                        SqlConnection newConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\CODS\\C#\\TheMarket\\TheMarket\\TheMarket.mdf;Integrated Security=True;Connect Timeout=30");
                        newConnection.Open();
                        if (newConnection.State == ConnectionState.Open)
                        {
                            //Snaks
                            SqlCommand insertSQL = new SqlCommand("delete from Snaks where id='" + textBox1.Text + "'", newConnection);
                            SqlCommand updateTotalProducts = new SqlCommand("update products set Totalproducts=Totalproducts-1", newConnection);

                            updateTotalProducts.ExecuteNonQuery();
                            insertSQL.ExecuteNonQuery();
                            MessageBox.Show("Product Removed", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Detected", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    textBox1.Text = "";


                }

                else if (radioButton5.Checked)
                {

                    count = 1;
                    // string[] row = { Ptype.instance.tb1.Text, Ptype.instance.tb2.Text, Ptype.instance.tb3.Text };
                    //ListViewItem lv = new ListViewItem(row);
                    //   Grocery.instance.lwP.Items.Add(lv);
                    try
                    {
                       
                        SqlConnection newConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\CODS\\C#\\TheMarket\\TheMarket\\TheMarket.mdf;Integrated Security=True;Connect Timeout=30");
                        newConnection.Open();
                        if (newConnection.State == ConnectionState.Open)
                        {
                            //grocery
                            SqlCommand insertSQL = new SqlCommand("delete from grocery where id='" + textBox1.Text + "'", newConnection);
                            SqlCommand updateTotalProducts = new SqlCommand("update products set Totalproducts=Totalproducts-1", newConnection);

                            updateTotalProducts.ExecuteNonQuery();
                            insertSQL.ExecuteNonQuery();

                            MessageBox.Show("Product Removed", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Detected", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    textBox1.Text = "";

                }

                else if (radioButton6.Checked)
                {

                    count = 1;
                    //  string[] row = { Ptype.instance.tb1.Text, Ptype.instance.tb2.Text, Ptype.instance.tb3.Text };
                    //  ListViewItem lv = new ListViewItem(row);
                    // Grains.instance.lwP.Items.Add(lv);
                    try
                    {
                        SqlConnection newConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\CODS\\C#\\TheMarket\\TheMarket\\TheMarket.mdf;Integrated Security=True;Connect Timeout=30");
                        newConnection.Open();
                        if (newConnection.State == ConnectionState.Open)
                        {
                            //Grains
                            SqlCommand insertSQL = new SqlCommand("delete from Grains where id='" + textBox1.Text + "'", newConnection);
                            SqlCommand updateTotalProducts = new SqlCommand("update products set Totalproducts=Totalproducts-1", newConnection);

                            updateTotalProducts.ExecuteNonQuery();
                            insertSQL.ExecuteNonQuery();

                            MessageBox.Show("Product Removed", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Detected", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    textBox1.Text = "";
                    }
                }
                }
            }
}
