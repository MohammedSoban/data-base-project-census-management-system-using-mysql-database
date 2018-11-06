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
    public partial class viewForm : Form
    {

        
        public viewForm()
        {
            InitializeComponent();
           AutoCompleteText();
            
        }

        DataTable dTable;


        

        void AutoCompleteText()
        {
            //string choice = SearchByBox.Text;

            searchBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            searchBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll= new AutoCompleteStringCollection();

            string MyConnection2 = ("Server=127.0.0.1;DataBase=CENSUS_DB;Uid=root;pwd=0345;port=3306;");
            //Display query  
            string Query = "select * from dataEntry;";
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            MySqlDataReader myReader;

            try
            {
                MyConn2.Open();
                myReader = MyCommand2.ExecuteReader();

                while(myReader.Read())
                {
                    string fullName = myReader.GetString(SearchByBox.Text);
                    coll.Add(fullName);

                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            searchBox.AutoCompleteCustomSource = coll;
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            choiceForm fm = new choiceForm();

            fm.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
                 dTable = new DataTable();
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

       

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
                       
 
            DataView dv = new DataView(dTable);
           // dv.RowFilter = string.Format("FullName LIKE '%{0}%'",searchBox.Text);            
            dv.RowFilter = string.Format(SearchByBox.Text+" LIKE '%{0}%'", searchBox.Text);
            dataGridView.DataSource = dv;
            
            
        }
         

        private void SearchByBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
          //   string choice = SearchByBox.Text;  
               // AutoCompleteText();    
        }
         

       
    }
}
