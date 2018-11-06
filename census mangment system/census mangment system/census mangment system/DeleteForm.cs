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
    public partial class deleteForm : Form
    {
        private MySqlConnection xconn;

        public deleteForm()
        {
            InitializeComponent();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            bool check = dnicBox.MaskFull;

            if(check==false)
            {
                MessageBox.Show("Please enter the full CNIC number");
                return;
            }


            try
            {

                xconn = new MySqlConnection("Server=127.0.0.1;DataBase=CENSUS_DB;Uid=root;pwd=0345;port=3306;");

                xconn.Open();
                MySqlCommand cmd = new MySqlCommand();             

                     cmd.CommandText = "delete from dataEntry where CNIC='" + dnicBox.Text + "';";
                    cmd.Connection = xconn;
                  
                    

                    int a = cmd.ExecuteNonQuery();


                    if (a>0)
                    {
                        MessageBox.Show("Data Successfully Deleted");
                                          
                    }
                    else
                    {
                        MessageBox.Show("data not found");
                    }

                    dnicBox.Text = null;
                    xconn.Close();

                    

                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           


            /*
                try
                {
                    string MyConnection2 = ("Server=127.0.0.1;DataBase=CENSUS_DB;Uid=root;pwd=0345;port=3306;");
                    string Query = "delete from dataEntry where CNIC='" + dnicBox.Text + "';";
                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    MessageBox.Show("Data Successfully Deleted");
                    while (MyReader2.Read())
                    {
                    }
                    MyConn2.Close();
                  
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            */
      
        }

        

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            choiceForm fm = new choiceForm();

            fm.Show();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {

            try
            {
                string MyConnection2 = ("Server=127.0.0.1;DataBase=CENSUS_DB;Uid=root;pwd=0345;port=3306;");
                //Display query  
                string Query = "select * from dataEntry;";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MyConn2.Open();
                //For offline connection we weill use  MySqlDataAdapter class.  
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
                MyConn2.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      

       
    }
}
