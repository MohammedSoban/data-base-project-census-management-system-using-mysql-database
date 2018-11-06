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
    public partial class searchForm : Form
    {
        public searchForm()
        {
            InitializeComponent();
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

        private void searchButton_Click(object sender, EventArgs e)
        {


            bool check = nicBox.MaskFull;

            if (check == false)
            {
                MessageBox.Show("Please enter the full CNIC number");
                return;
            }


           MySqlConnection connection = new MySqlConnection("Server=127.0.0.1;DataBase=CENSUS_DB;Uid=root;pwd=0345;port=3306;");
        MySqlCommand command;
        MySqlDataReader mdr;
                  connection.Open();
            string selectQuery = "SELECT * FROM dataEntry WHERE CNIC='" + nicBox.Text+"';";
            command = new MySqlCommand(selectQuery, connection);
            mdr = command.ExecuteReader();

            if(mdr.Read())
            {
                fullNameBox.Text = mdr.GetString("FullName");
                firstNameBox.Text = mdr.GetString("FirstName");
                lNameBox.Text = mdr.GetString("LastName");            
                yearBox.Text = mdr.GetString("DOByear");
                monthBox.Text = mdr.GetString("DOBmonth");
                dayBox.Text = mdr.GetString("DOBday");
                ageBox.Text = mdr.GetString("Age");
                addressBox.Text = mdr.GetString("Address");
                areaBox.Text = mdr.GetString("Area");
                districtBox.Text = mdr.GetString("District");
                cityBox.Text = mdr.GetString("city");
                zipBox.Text = mdr.GetString("ZipCode");
                provinceBox.Text = mdr.GetString("Province");
                genderBox.Text = mdr.GetString("Gender");
                fnameBox.Text=mdr.GetString("FatherName");
                mnameBox.Text=mdr.GetString("MotherName");
                fnicBox.Text=mdr.GetString("FatherNIC");
                siblingcountBox.Text=mdr.GetString("NumberOfSibling");
                qualificationBox.Text=mdr.GetString("Qualification");
                incomeBox.Text=mdr.GetString("Income");
                ocupationBox.Text=mdr.GetString("Ocupation");
                orgBox.Text=mdr.GetString("NameOfOrginization");
                childrenBox.Text=mdr.GetString("NumberOfChildren");
                mobileBox.Text = mdr.GetString("MobileNumber");

            }
            else
            {
                 firstNameBox.Text = "";
                lNameBox.Text = "";                
                ageBox.Text = "";
                MessageBox.Show("No Data For This Id");
            }
            connection.Close();
        }

        private MySqlConnection xconn;

        private void updateButton_Click(object sender, EventArgs e)
        {
             

            try
            {
                 
                xconn = new MySqlConnection("Server=127.0.0.1;DataBase=CENSUS_DB;Uid=root;pwd=0345;port=3306;");
                xconn.Open();
                MySqlCommand cmd = new MySqlCommand();

                string fullName;

                fullName = fullName = firstNameBox.Text + ' ' + lNameBox.Text;


                cmd.CommandText = "update dataEntry set CNIC='" + nicBox.Text + "',FirstName='" + firstNameBox.Text + "',LastName='" + lNameBox.Text + "',FullName='" + fullName + "' ,DOByear='" + yearBox.Text + "' ,DOBmonth='" + monthBox.Text + "' ,DOBday='" + dayBox.Text + "' ,Age='" + Convert.ToInt32(ageBox.Text) + "' ,Address='" + addressBox.Text + "' ,Area='" + areaBox.Text + "' ,District='" + districtBox.Text + "' ,city='" + cityBox.Text + "' ,ZipCode='" + zipBox.Text + "' ,Province='" + provinceBox.Text + "' , Gender='" + genderBox.Text + "',MobileNumber='" + mobileBox.Text + "' ,FatherName='" + fnameBox.Text + "' ,MotherName='" + mnameBox.Text + "' ,FatherNIC='" + fnicBox.Text + "' ,NumberOfSibling='" + Convert.ToInt32(siblingcountBox.Text) + "' ,qualification='" + qualificationBox.Text + "',income='" + Convert.ToInt32(incomeBox.Text) + "' ,Ocupation='" + ocupationBox.Text + "',NameOfOrginization='" + orgBox.Text + "',NumberOfChildren='" + Convert.ToInt32(childrenBox.Text) + "' where CNIC='" + nicBox.Text + "';";

                cmd.Connection = xconn;
                int a = cmd.ExecuteNonQuery();

                if (a == 1)
                {
                    MessageBox.Show("Data Successfully Updated");
                }
                else
                {
                    MessageBox.Show("Record Not Found");
                }


                nicBox.Text = null;
                fullNameBox.Text = null;
                firstNameBox.Text = null;
                lNameBox.Text = null;
                yearBox.Text = null;
                mobileBox.Text = null;
                dayBox.Text = null;
                ageBox.Text = null;
                monthBox.Text = null;
                qualificationBox.Text = null;
                ocupationBox.Text = null;
                addressBox.Text = null;
                areaBox.Text = null;
                districtBox.Text = null;
                cityBox.Text = null;
                zipBox.Text = null;
                provinceBox.Text = null;
                genderBox.Text = null;
                fnameBox.Text = null;
                mnameBox.Text = null;
                fnicBox.Text = null;
                siblingcountBox.Text = null;
                incomeBox.Text = null;
                orgBox.Text = null;
                childrenBox.Text = null;
                mobileBox.Text = null;


                xconn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    

      
    }
}
        

        
    

