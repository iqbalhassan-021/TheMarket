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

    public partial class Ptype : Form
            {
        public static Ptype instance;
        public TextBox tb1;
        public TextBox tb2;
        public TextBox tb3;
        public int count;
        public Ptype()
        {
            InitializeComponent();
            instance = this;
            tb1 = textBox1;
            tb2 = textBox2;
            tb3 = textBox3;
            count = 0;

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Ptype_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        public static int btnc = 0;

        public static int row;
        private void button1_Click(object sender, EventArgs e)
        {
            btnc = btnc + 1;
            if (btnc % 2 == 0)
            {

                btnc = 1;

            }
            if (textBox1.Text==""&&textBox2.Text==""&&textBox3.Text=="")
            {
                MessageBox.Show("To add product please fill the form", "Attention",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else {


                //KitchenWare

                if (radioButton1.Checked)
                    {

                        count = 1;
                    try
                    {
                    
                        SqlConnection newConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\CODS\\C#\\TheMarket\\TheMarket\\TheMarket.mdf;Integrated Security=True;Connect Timeout=30");
                        newConnection.Open();
                   

                        if (newConnection.State == ConnectionState.Open)
                        {
                    
                            SqlCommand check = new SqlCommand("select count(Totalproducts) from products", newConnection);
                      
                            row = (int)check.ExecuteScalar();

                            if (row > 0)
                            {


                                SqlCommand insertSQL = new SqlCommand("insert into KitchenWare(id,Product,Price) values('" + textBox1.Text + "','" + textBox3.Text + "','" + textBox2.Text + "' )", newConnection);

                                SqlCommand updateTotalProducts =new SqlCommand("update products set Totalproducts=Totalproducts+1", newConnection);
                                insertSQL.ExecuteNonQuery();
                                updateTotalProducts.ExecuteNonQuery();
                                MessageBox.Show("Product Added Successfully","Add",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            }
                            else
                            {
                                SqlCommand insertSQL = new SqlCommand("insert into KitchenWare(id,Product,Price) values('" + textBox1.Text + "','" + textBox3.Text + "','" + textBox2.Text + "' )", newConnection);

                                SqlCommand insertProductT = new SqlCommand("insert into products(Totalproducts) values(1)", newConnection);
                                insertSQL.ExecuteNonQuery();
                                insertProductT.ExecuteNonQuery();
                                MessageBox.Show("Product Added Successfully", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                       



                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Detected - Cannot Add products with same Product Code",ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";

                 
                    }
                //Bread
                else if (radioButton2.Checked)
                    {

                    count = 1;
                    try
                    {

                        SqlConnection newConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\CODS\\C#\\TheMarket\\TheMarket\\TheMarket.mdf;Integrated Security=True;Connect Timeout=30");
                        newConnection.Open();


                        if (newConnection.State == ConnectionState.Open)
                        {

                            SqlCommand check = new SqlCommand("select count(Totalproducts) from products", newConnection);

                            row = (int)check.ExecuteScalar();

                            if (row > 0)
                            {


                                SqlCommand insertSQL = new SqlCommand("insert into Bread(id,Product,Price) values('" + textBox1.Text + "','" + textBox3.Text + "','" + textBox2.Text + "' )", newConnection);

                                SqlCommand updateTotalProducts = new SqlCommand("update products set Totalproducts=Totalproducts+1", newConnection);
                                insertSQL.ExecuteNonQuery();
                                updateTotalProducts.ExecuteNonQuery();
                                MessageBox.Show("Product Added Successfully", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                SqlCommand insertSQL = new SqlCommand("insert into Bread(id,Product,Price) values('" + textBox1.Text + "','" + textBox3.Text + "','" + textBox2.Text + "' )", newConnection);

                                SqlCommand insertProductT = new SqlCommand("insert into products(Totalproducts) values(1)", newConnection);
                                insertSQL.ExecuteNonQuery();
                                insertProductT.ExecuteNonQuery();
                                MessageBox.Show("Product Added Successfully", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }




                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Detected - Cannot Add products with same Product Code", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";



                }
                //CoolDrinks
                else if (radioButton3.Checked)
                    {

                    count = 1;
                    try
                    {

                        SqlConnection newConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\CODS\\C#\\TheMarket\\TheMarket\\TheMarket.mdf;Integrated Security=True;Connect Timeout=30");
                        newConnection.Open();


                        if (newConnection.State == ConnectionState.Open)
                        {

                            SqlCommand check = new SqlCommand("select count(Totalproducts) from products", newConnection);

                            row = (int)check.ExecuteScalar();

                            if (row > 0)
                            {


                                SqlCommand insertSQL = new SqlCommand("insert into CoolDrinks(id,Product,Price) values('" + textBox1.Text + "','" + textBox3.Text + "','" + textBox2.Text + "' )", newConnection);

                                SqlCommand updateTotalProducts = new SqlCommand("update products set Totalproducts=Totalproducts+1", newConnection);
                                insertSQL.ExecuteNonQuery();
                                updateTotalProducts.ExecuteNonQuery();
                                MessageBox.Show("Product Added Successfully", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                SqlCommand insertSQL = new SqlCommand("insert into CoolDrinks(id,Product,Price) values('" + textBox1.Text + "','" + textBox3.Text + "','" + textBox2.Text + "' )", newConnection);

                                SqlCommand insertProductT = new SqlCommand("insert into products(Totalproducts) values(1)", newConnection);
                                insertSQL.ExecuteNonQuery();
                                insertProductT.ExecuteNonQuery();
                                MessageBox.Show("Product Added Successfully", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }




                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Detected - Cannot Add products with same Product Code", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";

                }
                //Snaks
                else if (radioButton4.Checked)
                {
                    count = 1;
                    try
                    {

                        SqlConnection newConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\CODS\\C#\\TheMarket\\TheMarket\\TheMarket.mdf;Integrated Security=True;Connect Timeout=30");
                        newConnection.Open();


                        if (newConnection.State == ConnectionState.Open)
                        {

                            SqlCommand check = new SqlCommand("select count(Totalproducts) from products", newConnection);

                            row = (int)check.ExecuteScalar();

                            if (row > 0)
                            {


                                SqlCommand insertSQL = new SqlCommand("insert into Snaks(id,Product,Price) values('" + textBox1.Text + "','" + textBox3.Text + "','" + textBox2.Text + "' )", newConnection);

                                SqlCommand updateTotalProducts = new SqlCommand("update products set Totalproducts=Totalproducts+1", newConnection);
                                insertSQL.ExecuteNonQuery();
                                updateTotalProducts.ExecuteNonQuery();
                                MessageBox.Show("Product Added Successfully", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                SqlCommand insertSQL = new SqlCommand("insert into Snaks(id,Product,Price) values('" + textBox1.Text + "','" + textBox3.Text + "','" + textBox2.Text + "' )", newConnection);

                                SqlCommand insertProductT = new SqlCommand("insert into products(Totalproducts) values(1)", newConnection);
                                insertSQL.ExecuteNonQuery();
                                insertProductT.ExecuteNonQuery();
                                MessageBox.Show("Product Added Successfully", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }




                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Detected - Cannot Add products with same Product Code", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";

                }
                //grocery
                else if (radioButton5.Checked)
                {
                    count = 1;
                    try
                    {

                        SqlConnection newConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\CODS\\C#\\TheMarket\\TheMarket\\TheMarket.mdf;Integrated Security=True;Connect Timeout=30");
                        newConnection.Open();


                        if (newConnection.State == ConnectionState.Open)
                        {

                            SqlCommand check = new SqlCommand("select count(Totalproducts) from products", newConnection);

                            row = (int)check.ExecuteScalar();

                            if (row > 0)
                            {


                                SqlCommand insertSQL = new SqlCommand("insert into grocery(id,Product,Price) values('" + textBox1.Text + "','" + textBox3.Text + "','" + textBox2.Text + "' )", newConnection);

                                SqlCommand updateTotalProducts = new SqlCommand("update products set Totalproducts=Totalproducts+1", newConnection);
                                insertSQL.ExecuteNonQuery();
                                updateTotalProducts.ExecuteNonQuery();
                                MessageBox.Show("Product Added Successfully", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                SqlCommand insertSQL = new SqlCommand("insert into grocery(id,Product,Price) values('" + textBox1.Text + "','" + textBox3.Text + "','" + textBox2.Text + "' )", newConnection);

                                SqlCommand insertProductT = new SqlCommand("insert into products(Totalproducts) values(1)", newConnection);
                                insertSQL.ExecuteNonQuery();
                                insertProductT.ExecuteNonQuery();
                                MessageBox.Show("Product Added Successfully", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }




                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Detected - Cannot Add products with same Product Code", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";

                }
                //Grains
                else if (radioButton6.Checked)
                {
                    count = 1;
                    try
                    {

                        SqlConnection newConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\CODS\\C#\\TheMarket\\TheMarket\\TheMarket.mdf;Integrated Security=True;Connect Timeout=30");
                        newConnection.Open();


                        if (newConnection.State == ConnectionState.Open)
                        {

                            SqlCommand check = new SqlCommand("select count(Totalproducts) from products", newConnection);

                            row = (int)check.ExecuteScalar();

                            if (row > 0)
                            {


                                SqlCommand insertSQL = new SqlCommand("insert into Grains(id,Product,Price) values('" + textBox1.Text + "','" + textBox3.Text + "','" + textBox2.Text + "' )", newConnection);

                                SqlCommand updateTotalProducts = new SqlCommand("update products set Totalproducts=Totalproducts+1", newConnection);
                                insertSQL.ExecuteNonQuery();
                                updateTotalProducts.ExecuteNonQuery();
                                MessageBox.Show("Product Added Successfully", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                SqlCommand insertSQL = new SqlCommand("insert into Grains(id,Product,Price) values('" + textBox1.Text + "','" + textBox3.Text + "','" + textBox2.Text + "' )", newConnection);

                                SqlCommand insertProductT = new SqlCommand("insert into products(Totalproducts) values(1)", newConnection);
                                insertSQL.ExecuteNonQuery();
                                insertProductT.ExecuteNonQuery();
                                MessageBox.Show("Product Added Successfully", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }




                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Detected - Cannot Add products with same Product Code", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";

                }

            }
            
            




        }
    }
}
