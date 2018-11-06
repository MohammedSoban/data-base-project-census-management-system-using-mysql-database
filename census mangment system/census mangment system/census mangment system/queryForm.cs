using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace census_mangment_system
{
    public partial class queryForm : Form
    {
       

        public queryForm()
        {
            InitializeComponent();

        }

        private void runQuery_Click(object sender, EventArgs e)
        {
            

            try
            {
                MySqlConnection connection = new MySqlConnection("Server=127.0.0.1;DataBase=CENSUS_DB;Uid=root;pwd=0345;port=3306;");
                MySqlCommand command;
                MySqlDataReader mdr;
                connection.Open();
                string selectQuery = "SELECT COUNT(CNIC)  AS number_of_People FROM  dataEntry;";
                command = new MySqlCommand(selectQuery, connection);
                mdr = command.ExecuteReader();

                if (mdr.Read())
                {
                    peopleCount.Text = mdr.GetString("number_of_People");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            choiceForm fm = new choiceForm();

            fm.Show();
        }

        private void checkMorF_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server=127.0.0.1;DataBase=CENSUS_DB;Uid=root;pwd=0345;port=3306;");
                MySqlCommand command;
                MySqlDataReader mdr;
                connection.Open();
               
                string mORfCount = "SELECT COUNT(CNIC)  AS number_of_FEMALE FROM  dataEntry where gender='FEMALE';";
                command = new MySqlCommand(mORfCount, connection);

                mdr = command.ExecuteReader();

                if (mdr.Read())
                {
                    
                    femaleCount.Text = mdr.GetString("number_of_FEMALE");
                    
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



            try
            {
                MySqlConnection connection = new MySqlConnection("Server=127.0.0.1;DataBase=CENSUS_DB;Uid=root;pwd=0345;port=3306;");
                MySqlCommand command;
                MySqlDataReader mdr;
                connection.Open();
                string mORf = "SELECT COUNT(CNIC)  AS number_of_MALE FROM  dataEntry where gender='MALE';";
                command = new MySqlCommand(mORf, connection);
                                mdr = command.ExecuteReader();

                if (mdr.Read())
                {
                    maleCount.Text = mdr.GetString("number_of_MALE");
                    

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            peopleCount.Text = null;
            femaleCount.Text = null;
            maleCount.Text = null;
            averageAgeBox.Text = null;
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
            dataGridView3.DataSource = null;
            dataGridView4.DataSource = null;
            


        }

   

        private void averageAgeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server=127.0.0.1;DataBase=CENSUS_DB;Uid=root;pwd=0345;port=3306;");
                MySqlCommand command;
                MySqlDataReader mdr;
                connection.Open();
                string selectQuery = "select avg(age) as Avrage_of_age from dataentry;";
                command = new MySqlCommand(selectQuery, connection);
                mdr = command.ExecuteReader();

                if (mdr.Read())
                {
                    averageAgeBox.Text = mdr.GetString("Avrage_of_age");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        DataTable dTable;
        private void qualificationCountButton_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = ("Server=127.0.0.1;DataBase=CENSUS_DB;Uid=root;pwd=0345;port=3306;");
                //Display query  
                string Query = "select province,qualification,count(Qualification) as People_Count from dataEntry group by Qualification,province;";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MyConn2.Open();
                //For offline connection we weill use  MySqlDataAdapter class.  
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
                MyConn2.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ocupationCountButton_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = ("Server=127.0.0.1;DataBase=CENSUS_DB;Uid=root;pwd=0345;port=3306;");
                //Display query  
                string Query = "select province,Ocupation,count(Qualification) as People_Count from dataEntry group by Ocupation,province;";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MyConn2.Open();
                //For offline connection we weill use  MySqlDataAdapter class.  
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView2.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
                MyConn2.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void avgIncomeButton_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = ("Server=127.0.0.1;DataBase=CENSUS_DB;Uid=root;pwd=0345;port=3306;");
                //Display query  
                string Query = "select province,avg(income) as Average_Income from dataentry group by province;";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MyConn2.Open();
                //For offline connection we weill use  MySqlDataAdapter class.  
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView3.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
                MyConn2.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void youngButton_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = ("Server=127.0.0.1;DataBase=CENSUS_DB;Uid=root;pwd=0345;port=3306;");
                //Display query  
                string Query = "select PROVINCE,count(age) as PEOPLE_BETWEEN_20_AND_35 from dataentry Where age<=35 and age>=20 group by province;";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MyConn2.Open();
                //For offline connection we weill use  MySqlDataAdapter class.  
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView4.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
                MyConn2.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void rButton_Click(object sender, EventArgs e)
        {
            peopleCount.Text = null;
            femaleCount.Text = null;
            maleCount.Text = null;
            averageAgeBox.Text = null;
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
            dataGridView3.DataSource = null;
            dataGridView4.DataSource = null;
            
        }



       
    }
}
