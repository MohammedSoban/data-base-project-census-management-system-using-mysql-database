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
    public partial class graphForm : Form
    {
        public graphForm()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();

           choiceForm fm = new choiceForm();

            fm.Show();

        }

      

        private void loadGraphButton_Click_1(object sender, EventArgs e)
        {
            string MyConnection2 = ("Server=127.0.0.1;DataBase=CENSUS_DB;Uid=root;pwd=0345;port=3306;");
            //Display query  
            string Query = "select dobyear,count(dobyear) as People_count_in_year from dataentry group by dobyear;";
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            MySqlDataReader myReader;
            try
            {
                MyConn2.Open();
                myReader = MyCommand2.ExecuteReader();

                while(myReader.Read())
                {
                    this.birthRateChart.Series["birth rate"].Points.AddXY(myReader.GetString("DOByear"), myReader.GetInt32("People_count_in_year"));
                   
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

             

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void birthRateChart_Click(object sender, EventArgs e)
        {

        }

        private void loadPieButton_Click(object sender, EventArgs e)
        {
            string MyConnection2 = ("Server=127.0.0.1;DataBase=CENSUS_DB;Uid=root;pwd=0345;port=3306;");
            //Display query  
            string Query = "select qualification,count(Qualification) as Number_of_graduate from dataEntry group by Qualification;";
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            MySqlDataReader myReader;
            try
            {
                MyConn2.Open();
                myReader = MyCommand2.ExecuteReader();

                while (myReader.Read())
                {
                    this.pieChartLitreacy.Series["Series1"].Points.AddXY(myReader.GetString("qualification"), myReader.GetInt32("Number_of_graduate"));
                    
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadPie2Button_Click(object sender, EventArgs e)
        {
            string MyConnection2 = ("Server=127.0.0.1;DataBase=CENSUS_DB;Uid=root;pwd=0345;port=3306;");
            //Display query  
            string Query1 = "SELECT GENDER,COUNT(GENDER)  AS number_of_GENDER FROM  dataEntry group by gender ;  ";
           
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            MySqlCommand MyCommand2 = new MySqlCommand(Query1, MyConn2); 
            MySqlDataReader myReader;
            try
            {
                MyConn2.Open();
                myReader = MyCommand2.ExecuteReader();

                while (myReader.Read())
                {
                    this.piechart.Series["maleVsfemale"].Points.AddXY(myReader.GetString("gender"), myReader.GetInt32("number_of_GENDER"));
                }
                MyConn2.Close();
            }
               
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

          
            
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
           // birthRateChart.Series.Clear();
            //birthRateChart.ResetAutoValues();
            birthRateChart.Series["birth rate"].Points.Clear();
        }

        private void rButton_Click(object sender, EventArgs e)
        {
            pieChartLitreacy.Series["Series1"].Points.Clear();
        }

        private void RESET_Click(object sender, EventArgs e)
        {
            piechart.Series["maleVsfemale"].Points.Clear();
        }

        
    }
}
