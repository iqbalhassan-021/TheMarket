using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TheMarket
{
    public partial class dashb : UserControl
    {
        public static dashb instance;


        public dashb()
        {
            InitializeComponent();
            instance = this;


        }
        public static int row;
        public static int row1;
        public static int row2;
        public static int row3;
        public static int row4;
        public static int row5;
        public static int row6;
        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") { MessageBox.Show("Please fill up the entry boxes!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                try
                {
                    SqlConnection newConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\CODS\\C#\\TheMarket\\TheMarket\\TheMarket.mdf;Integrated Security=True;Connect Timeout=30");
                    newConnection.Open();
                    if (newConnection.State == ConnectionState.Open)
                    {
                        SqlCommand check = new SqlCommand("select count(id) from Bread where id='" + textBox1.Text + "'", newConnection);
                        SqlCommand check1 = new SqlCommand("select count(id) from KitchenWare where id='" + textBox1.Text + "'", newConnection);
                        SqlCommand check2 = new SqlCommand("select count(id) from CoolDrinks where id='" + textBox1.Text + "'", newConnection);
                        SqlCommand check3 = new SqlCommand("select count(id) from Snaks where id='" + textBox1.Text + "'", newConnection);
                        SqlCommand check4 = new SqlCommand("select count(id) from grocery where id='" + textBox1.Text + "'", newConnection);
                        SqlCommand check5 = new SqlCommand("select count(id) from Grains where id='" + textBox1.Text + "'", newConnection);

                        row = (int)check.ExecuteScalar();
                        row1 = (int)check1.ExecuteScalar();
                        row2 = (int)check2.ExecuteScalar();
                        row3 = (int)check3.ExecuteScalar();
                        row4 = (int)check4.ExecuteScalar();
                        row5 = (int)check5.ExecuteScalar();


                        //Bread

                        if (row > 0)
                        {
                            string Query4 = "insert into billtempTab(Bill) select price from Bread where id='" + textBox1.Text + "';";

                            SqlConnection MyConn40 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\CODS\\C#\\TheMarket\\TheMarket\\TheMarket.mdf;Integrated Security=True;Connect Timeout=30");
                            SqlCommand MyCommand40 = new SqlCommand(Query4, MyConn40);
                            MyConn40.Open();
                            SqlDataAdapter MyAdapter10 = new SqlDataAdapter();
                            MyAdapter10.SelectCommand = MyCommand40;
                            DataTable dTable20 = new DataTable();
                            MyAdapter10.Fill(dTable20);

                            dataGridView4.DataSource = dTable20; // here i have assign dTable object to the dataGridView1 object to display data.               

                            MyConn40.Close();




                            string Query20 = "select * from billtempTab;";

                            SqlConnection MyConn30 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\CODS\\C#\\TheMarket\\TheMarket\\TheMarket.mdf;Integrated Security=True;Connect Timeout=30");
                            SqlCommand MyCommand30 = new SqlCommand(Query20, MyConn30);
                            MyConn30.Open();
                            SqlDataAdapter MyAdapter101 = new SqlDataAdapter();
                            MyAdapter101.SelectCommand = MyCommand30;
                            DataTable dTable201 = new DataTable();
                            MyAdapter101.Fill(dTable201);

                            dataGridView4.DataSource = dTable201; // here i have assign dTable object to the dataGridView1 object to display data.               
                            MyConn30.Close();





                            //SqlCommand add = new SqlCommand("select id*'"+textBox2.Text+ "' from Bread", newConnection);
                            // add.ExecuteNonQuery();


                        }
                        //KitchenWare
                        else if (row1 > 0)
                        {
                            string Query4 = "insert into billtempTab(Bill) select price from KitchenWare where id='" + textBox1.Text + "';";

                            SqlConnection MyConn40 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\CODS\\C#\\TheMarket\\TheMarket\\TheMarket.mdf;Integrated Security=True;Connect Timeout=30");
                            SqlCommand MyCommand40 = new SqlCommand(Query4, MyConn40);
                            MyConn40.Open();
                            SqlDataAdapter MyAdapter10 = new SqlDataAdapter();
                            MyAdapter10.SelectCommand = MyCommand40;
                            DataTable dTable20 = new DataTable();
                            MyAdapter10.Fill(dTable20);

                            dataGridView4.DataSource = dTable20; // here i have assign dTable object to the dataGridView1 object to display data.               

                            MyConn40.Close();




                            string Query20 = "select * from billtempTab;";

                            SqlConnection MyConn30 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\CODS\\C#\\TheMarket\\TheMarket\\TheMarket.mdf;Integrated Security=True;Connect Timeout=30");
                            SqlCommand MyCommand30 = new SqlCommand(Query20, MyConn30);
                            MyConn30.Open();
                            SqlDataAdapter MyAdapter101 = new SqlDataAdapter();
                            MyAdapter101.SelectCommand = MyCommand30;
                            DataTable dTable201 = new DataTable();
                            MyAdapter101.Fill(dTable201);

                            dataGridView4.DataSource = dTable201; // here i have assign dTable object to the dataGridView1 object to display data.               
                            MyConn30.Close();




                        }
                        //CoolDrinks
                        else if (row2 > 0)
                        {
                            string Query4 = "insert into billtempTab(Bill) select price from CoolDrinks where id='" + textBox1.Text + "';";

                            SqlConnection MyConn40 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\CODS\\C#\\TheMarket\\TheMarket\\TheMarket.mdf;Integrated Security=True;Connect Timeout=30");
                            SqlCommand MyCommand40 = new SqlCommand(Query4, MyConn40);
                            MyConn40.Open();
                            SqlDataAdapter MyAdapter10 = new SqlDataAdapter();
                            MyAdapter10.SelectCommand = MyCommand40;
                            DataTable dTable20 = new DataTable();
                            MyAdapter10.Fill(dTable20);

                            dataGridView4.DataSource = dTable20; // here i have assign dTable object to the dataGridView1 object to display data.               

                            MyConn40.Close();




                            string Query20 = "select * from billtempTab;";

                            SqlConnection MyConn30 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\CODS\\C#\\TheMarket\\TheMarket\\TheMarket.mdf;Integrated Security=True;Connect Timeout=30");
                            SqlCommand MyCommand30 = new SqlCommand(Query20, MyConn30);
                            MyConn30.Open();
                            SqlDataAdapter MyAdapter101 = new SqlDataAdapter();
                            MyAdapter101.SelectCommand = MyCommand30;
                            DataTable dTable201 = new DataTable();
                            MyAdapter101.Fill(dTable201);

                            dataGridView4.DataSource = dTable201; // here i have assign dTable object to the dataGridView1 object to display data.               
                            MyConn30.Close();





                        }
                        //Snaks
                        else if (row3 > 0)
                        {
                            string Query4 = "insert into billtempTab(Bill) select price from Snaks where id='" + textBox1.Text + "';";

                            SqlConnection MyConn40 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\CODS\\C#\\TheMarket\\TheMarket\\TheMarket.mdf;Integrated Security=True;Connect Timeout=30");
                            SqlCommand MyCommand40 = new SqlCommand(Query4, MyConn40);
                            MyConn40.Open();
                            SqlDataAdapter MyAdapter10 = new SqlDataAdapter();
                            MyAdapter10.SelectCommand = MyCommand40;
                            DataTable dTable20 = new DataTable();
                            MyAdapter10.Fill(dTable20);

                            dataGridView4.DataSource = dTable20; // here i have assign dTable object to the dataGridView1 object to display data.               

                            MyConn40.Close();




                            string Query20 = "select * from billtempTab;";

                            SqlConnection MyConn30 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\CODS\\C#\\TheMarket\\TheMarket\\TheMarket.mdf;Integrated Security=True;Connect Timeout=30");
                            SqlCommand MyCommand30 = new SqlCommand(Query20, MyConn30);
                            MyConn30.Open();
                            SqlDataAdapter MyAdapter101 = new SqlDataAdapter();
                            MyAdapter101.SelectCommand = MyCommand30;
                            DataTable dTable201 = new DataTable();
                            MyAdapter101.Fill(dTable201);

                            dataGridView4.DataSource = dTable201; // here i have assign dTable object to the dataGridView1 object to display data.               
                            MyConn30.Close();




                        }
                        //grocery
                        else if (row4 > 0)
                        {
                            string Query4 = "insert into billtempTab(Bill) select price from grocery where id='" + textBox1.Text + "';";

                            SqlConnection MyConn40 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\CODS\\C#\\TheMarket\\TheMarket\\TheMarket.mdf;Integrated Security=True;Connect Timeout=30");
                            SqlCommand MyCommand40 = new SqlCommand(Query4, MyConn40);
                            MyConn40.Open();
                            SqlDataAdapter MyAdapter10 = new SqlDataAdapter();
                            MyAdapter10.SelectCommand = MyCommand40;
                            DataTable dTable20 = new DataTable();
                            MyAdapter10.Fill(dTable20);

                            dataGridView4.DataSource = dTable20; // here i have assign dTable object to the dataGridView1 object to display data.               

                            MyConn40.Close();




                            string Query20 = "select * from billtempTab;";

                            SqlConnection MyConn30 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\CODS\\C#\\TheMarket\\TheMarket\\TheMarket.mdf;Integrated Security=True;Connect Timeout=30");
                            SqlCommand MyCommand30 = new SqlCommand(Query20, MyConn30);
                            MyConn30.Open();
                            SqlDataAdapter MyAdapter101 = new SqlDataAdapter();
                            MyAdapter101.SelectCommand = MyCommand30;
                            DataTable dTable201 = new DataTable();
                            MyAdapter101.Fill(dTable201);

                            dataGridView4.DataSource = dTable201; // here i have assign dTable object to the dataGridView1 object to display data.               
                            MyConn30.Close();




                        }
                        //Grains
                        else if (row5 > 0)
                        {
                            string Query4 = "insert into billtempTab(Bill) select price from Grains where id='" + textBox1.Text + "';";

                            SqlConnection MyConn40 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\CODS\\C#\\TheMarket\\TheMarket\\TheMarket.mdf;Integrated Security=True;Connect Timeout=30");
                            SqlCommand MyCommand40 = new SqlCommand(Query4, MyConn40);
                            MyConn40.Open();
                            SqlDataAdapter MyAdapter10 = new SqlDataAdapter();
                            MyAdapter10.SelectCommand = MyCommand40;
                            DataTable dTable20 = new DataTable();
                            MyAdapter10.Fill(dTable20);

                            dataGridView4.DataSource = dTable20; // here i have assign dTable object to the dataGridView1 object to display data.               

                            MyConn40.Close();




                            string Query20 = "select * from billtempTab;";

                            SqlConnection MyConn30 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\CODS\\C#\\TheMarket\\TheMarket\\TheMarket.mdf;Integrated Security=True;Connect Timeout=30");
                            SqlCommand MyCommand30 = new SqlCommand(Query20, MyConn30);
                            MyConn30.Open();
                            SqlDataAdapter MyAdapter101 = new SqlDataAdapter();
                            MyAdapter101.SelectCommand = MyCommand30;
                            DataTable dTable201 = new DataTable();
                            MyAdapter101.Fill(dTable201);

                            dataGridView4.DataSource = dTable201; // here i have assign dTable object to the dataGridView1 object to display data.               
                            MyConn30.Close();



                        }
                        else
                        {
                            MessageBox.Show("Product doesn't exist", "Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Detected", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                textBox1.Text = "";



            }


        }

        private void button11_Click(object sender, EventArgs e)
        {

            btnc = 0;



            try
            {

                SqlConnection newConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\CODS\\C#\\TheMarket\\TheMarket\\TheMarket.mdf;Integrated Security=True;Connect Timeout=30");
                newConnection.Open();


                if (newConnection.State == ConnectionState.Open)
                {

                    SqlCommand del1 = new SqlCommand("delete from billtempTab", newConnection);

                    SqlCommand del2 = new SqlCommand("delete from tempbill", newConnection);

                    del1.ExecuteNonQuery();
                    del2.ExecuteNonQuery();





                    string temp_Query20 = "select temp from tempbill;";

                    SqlConnection dis_MyConn30 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\CODS\\C#\\TheMarket\\TheMarket\\TheMarket.mdf;Integrated Security=True;Connect Timeout=30");
                    SqlCommand dis_MyCommand30 = new SqlCommand(temp_Query20, dis_MyConn30);
                    dis_MyConn30.Open();
                    SqlDataAdapter temp_MyAdapter101 = new SqlDataAdapter();
                    temp_MyAdapter101.SelectCommand = dis_MyCommand30;
                    DataTable dTable201 = new DataTable();
                    temp_MyAdapter101.Fill(dTable201);

                    dataGridView5.DataSource = dTable201; // here i have assign dTable object to the dataGridView1 object to display data.               
                    dis_MyConn30.Close();



                    string dis_Query20 = "select * from billtempTab;";

                    SqlConnection temp_MyConn30 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\CODS\\C#\\TheMarket\\TheMarket\\TheMarket.mdf;Integrated Security=True;Connect Timeout=30");
                    SqlCommand temp_MyCommand30 = new SqlCommand(dis_Query20, temp_MyConn30);
                    temp_MyConn30.Open();
                    SqlDataAdapter dis_MyAdapter10 = new SqlDataAdapter();
                    dis_MyAdapter10.SelectCommand = temp_MyCommand30;
                    DataTable dis_dTable20 = new DataTable();
                    dis_MyAdapter10.Fill(dis_dTable20);

                    dataGridView4.DataSource = dis_dTable20; // here i have assign dTable object to the dataGridView1 object to display data.               
                    temp_MyConn30.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Detected", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }





            string Query20 = "select * from billtempTab;";

            SqlConnection MyConn30 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\CODS\\C#\\TheMarket\\TheMarket\\TheMarket.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand MyCommand30 = new SqlCommand(Query20, MyConn30);
            MyConn30.Open();
            SqlDataAdapter MyAdapter10 = new SqlDataAdapter();
            MyAdapter10.SelectCommand = MyCommand30;
            DataTable dTable20 = new DataTable();
            MyAdapter10.Fill(dTable20);

            dataGridView4.DataSource = dTable20; // here i have assign dTable object to the dataGridView1 object to display data.               
            MyConn30.Close();






        }
        public static double fbill;
        public static double tbill;
        public static int btnc = 0;

        private void button13_Click(object sender, EventArgs e)
        {
            btnc = btnc + 1;
            fbill = 700;
            if (btnc % 2 == 0)
            {
                fbill = 700;
                btnc = 1;

            }
            else
            {
                // textBox5.Text = fbill.ToString();
                //tbill = tbill + fbill;


            }





        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\CODS\\C#\\TheMarket\\TheMarket\\TheMarket.mdf;Integrated Security=True;Connect Timeout=30");
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                   
                    SqlCommand insert = new SqlCommand("insert into tempbill(temp) select SUM(Bill) from billtempTab",connection);
                    insert.ExecuteNonQuery();


                    SqlCommand insert2 = new SqlCommand("insert into tsale(totalsale) select temp from tempbill", connection);
                    insert2.ExecuteNonQuery();



                    connection.Close();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "Error Detected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            string temp_Query20 = "select * from tempbill;";

            SqlConnection temp_MyConn30 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\CODS\\C#\\TheMarket\\TheMarket\\TheMarket.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand temp_MyCommand30 = new SqlCommand(temp_Query20, temp_MyConn30);
            temp_MyConn30.Open();
            SqlDataAdapter temp_MyAdapter101 = new SqlDataAdapter();
            temp_MyAdapter101.SelectCommand = temp_MyCommand30;
            DataTable dTable201 = new DataTable();
            temp_MyAdapter101.Fill(dTable201);

            dataGridView5.DataSource = dTable201; // here i have assign dTable object to the dataGridView1 object to display data.               
            temp_MyConn30.Close();




            string t_Query20 = "select * from tempbill;";

            SqlConnection t_MyConn30 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\CODS\\C#\\TheMarket\\TheMarket\\TheMarket.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand t_MyCommand30 = new SqlCommand(t_Query20, t_MyConn30);
            t_MyConn30.Open();
            SqlDataAdapter t_MyAdapter101 = new SqlDataAdapter();
            t_MyAdapter101.SelectCommand = t_MyCommand30;
            DataTable tdTable201 = new DataTable();
            t_MyAdapter101.Fill(tdTable201);

            dataGridView1.DataSource = tdTable201; // here i have assign dTable object to the dataGridView1 object to display data.               
            t_MyConn30.Close();
        }


                    

        private void dashb_Load(object sender, EventArgs e)
        {
            string temp_Query20 = "select * from tempbill;";

            SqlConnection temp_MyConn30 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\CODS\\C#\\TheMarket\\TheMarket\\TheMarket.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand temp_MyCommand30 = new SqlCommand(temp_Query20, temp_MyConn30);
            temp_MyConn30.Open();
            SqlDataAdapter temp_MyAdapter101 = new SqlDataAdapter();
            temp_MyAdapter101.SelectCommand = temp_MyCommand30;
            DataTable dTable201 = new DataTable();
            temp_MyAdapter101.Fill(dTable201);

            dataGridView5.DataSource = dTable201; // here i have assign dTable object to the dataGridView1 object to display data.               
            temp_MyConn30.Close();

            string Query20 = "select * from billtempTab;";

            SqlConnection MyConn30 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\CODS\\C#\\TheMarket\\TheMarket\\TheMarket.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand MyCommand30 = new SqlCommand(Query20, MyConn30);
            MyConn30.Open();
            SqlDataAdapter MyAdapter10 = new SqlDataAdapter();
            MyAdapter10.SelectCommand = MyCommand30;
            DataTable dTable20 = new DataTable();
            MyAdapter10.Fill(dTable20);

            dataGridView4.DataSource = dTable20; // here i have assign dTable object to the dataGridView1 object to display data.               
            MyConn30.Close();



            //for Total Products
            string Query3 = "select Totalproducts from products;";

            SqlConnection MyConn4 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\CODS\\C#\\TheMarket\\TheMarket\\TheMarket.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand MyCommand4 = new SqlCommand(Query3, MyConn4);
            MyConn4.Open();
            SqlDataAdapter MyAdapter2 = new SqlDataAdapter();
            MyAdapter2.SelectCommand = MyCommand4;
            DataTable dTable3 = new DataTable();
            MyAdapter2.Fill(dTable3);

            dataGridView3.DataSource = dTable3; // here i have assign dTable object to the dataGridView1 object to display data.               
            MyConn4.Close();



            //for Total Staff
            string Query2 = "select tstaff from totalstaff;";

            SqlConnection MyConn3 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\CODS\\C#\\TheMarket\\TheMarket\\TheMarket.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand MyCommand3 = new SqlCommand(Query2, MyConn3);
            MyConn3.Open();
            SqlDataAdapter MyAdapter1 = new SqlDataAdapter();
            MyAdapter1.SelectCommand = MyCommand3;
            DataTable dTable2 = new DataTable();
            MyAdapter1.Fill(dTable2);

            dataGridView2.DataSource = dTable2; // here i have assign dTable object to the dataGridView1 object to display data.               
            MyConn3.Close();

            //for total Sale
            string Query = "select totalsale from tsale;";

            SqlConnection MyConn2 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\CODS\\C#\\TheMarket\\TheMarket\\TheMarket.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand MyCommand2 = new SqlCommand(Query, MyConn2);
            MyConn2.Open();
            SqlDataAdapter MyAdapter = new SqlDataAdapter();
            MyAdapter.SelectCommand = MyCommand2;
            DataTable dTable = new DataTable();
            MyAdapter.Fill(dTable);

            dataGridView1.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
            MyConn2.Close();


            /*   string Query4 = "select * from billtempTab;";

               SqlConnection MyConn40 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\CODS\\C#\\TheMarket\\TheMarket\\TheMarket.mdf;Integrated Security=True;Connect Timeout=30");
               SqlCommand MyCommand40 = new SqlCommand(Query4, MyConn40);
               MyConn40.Open();
               SqlDataAdapter MyAdapter10 = new SqlDataAdapter();
               MyAdapter10.SelectCommand = MyCommand40;
               DataTable dTable20 = new DataTable();
               MyAdapter10.Fill(dTable20);

               dataGridView4.DataSource = dTable20; // here i have assign dTable object to the dataGridView1 object to display data.               
               MyConn40.Close();
               

            string Query4 = "select* from Bread where id = '" + textBox1.Text + "' OR select *from KitchenWare where id = '" + textBox1.Text + "' OR select *from CoolDrinks where id = '" + textBox1.Text + "' OR select *from Snaks where id = '" + textBox1.Text + "' OR select *from Grains where id = '" + textBox1.Text + "' OR select *from grocery where id = '" + textBox1.Text + "'; ";

            SqlConnection MyConn40 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\CODS\\C#\\TheMarket\\TheMarket\\TheMarket.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand MyCommand40 = new SqlCommand(Query4, MyConn40);
            MyConn40.Open();
            SqlDataAdapter MyAdapter10 = new SqlDataAdapter();
            MyAdapter10.SelectCommand = MyCommand40;
            DataTable dTable20 = new DataTable();
            MyAdapter10.Fill(dTable20);

            dataGridView4.DataSource = dTable20; // here i have assign dTable object to the dataGridView1 object to display data.               
            MyConn40.Close();*/

        }

        private void button2_Click(object sender, EventArgs e)
        {

            //for Total Products
            string Query3 = "select Totalproducts from products;";

            SqlConnection MyConn4 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\CODS\\C#\\TheMarket\\TheMarket\\TheMarket.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand MyCommand4 = new SqlCommand(Query3, MyConn4);
            MyConn4.Open();
            SqlDataAdapter MyAdapter2 = new SqlDataAdapter();
            MyAdapter2.SelectCommand = MyCommand4;
            DataTable dTable3 = new DataTable();
            MyAdapter2.Fill(dTable3);

            dataGridView3.DataSource = dTable3; // here i have assign dTable object to the dataGridView1 object to display data.               
            MyConn4.Close();







            //for Total Staff
            string Query2 = "select tstaff from totalstaff;";

            SqlConnection MyConn3 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\CODS\\C#\\TheMarket\\TheMarket\\TheMarket.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand MyCommand3 = new SqlCommand(Query2, MyConn3);
            MyConn3.Open();
            SqlDataAdapter MyAdapter1 = new SqlDataAdapter();
            MyAdapter1.SelectCommand = MyCommand3;
            DataTable dTable2 = new DataTable();
            MyAdapter1.Fill(dTable2);

            dataGridView2.DataSource = dTable2; // here i have assign dTable object to the dataGridView1 object to display data.               
            MyConn3.Close();

            //for total Sale
            string Query = "select totalsale from tsale;";

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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection newConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\CODS\\C#\\TheMarket\\TheMarket\\TheMarket.mdf;Integrated Security=True;Connect Timeout=30");
                newConnection.Open();


                if (newConnection.State == ConnectionState.Open)
                {

                    SqlCommand del1 = new SqlCommand("delete from tsale", newConnection);
                    SqlCommand del2 = new SqlCommand("delete from totalstaff", newConnection);
                    SqlCommand del3 = new SqlCommand("delete from products", newConnection);

                    del1.ExecuteNonQuery();
                    del2.ExecuteNonQuery();
                    del3.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Detected", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

                }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.label1.Text = dateTime.ToString();

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            




        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

