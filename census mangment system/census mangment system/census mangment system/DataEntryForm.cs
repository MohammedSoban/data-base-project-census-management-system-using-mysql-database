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
    public partial class entryForm : Form
    {
        private MySqlConnection xconn;

        public entryForm()
        {
             
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            choiceForm fm = new choiceForm();

            fm.Show();
        }

        string fullName;

        string gender;

 
        private void enterButton_Click(object sender, EventArgs e)
        {
           bool check=nicBox.MaskFull;
            
            if (check==false)
            {
                MessageBox.Show("Please enter the full CNIC number");
                return;
            }

            if(firstNameBox.Text=="")
            {
                MessageBox.Show("Please enter the FirstName");
                return;
            }

            else if(lNameBox.Text=="")
            {
                MessageBox.Show("Please enter the LastName");
                return;
            }

            else if(addressBox.Text=="")
            {
                MessageBox.Show("Please enter the Address");
                return;
            }

            else if (areaBox.Text == "")
            {
                MessageBox.Show("Please enter the Area");
                return;
            }

            else if (cityBox.Text == "")
            {
                MessageBox.Show("Please enter the City");
                return;
            }

           bool check1=zipBox.MaskFull;

           if (check1 == false)
           {
               MessageBox.Show("Please enter the full ZIP CODE ");
               return;
           }

            else if (districtBox.Text== "")
            {
                MessageBox.Show("Please enter the DISTRICT");
                return;
            }
          
            else if (provinceBox.Text == "SELECT")
            {
                MessageBox.Show("Please select the Province");
                return;
            }

           bool check2 = mobileBox.MaskFull;
           if (check2 == false)
           {
               MessageBox.Show("Please enter the full MOBILE NUMBER ");
               return;
           }
      
            else if (fnameBox.Text == "")
            {
                MessageBox.Show("Please enter the Father Name");
                return;
            }

            else if (mnameBox.Text == "")
            {
                MessageBox.Show("Please enter the Mother Name");
                return;
            }

           bool check3 = fnicBox.MaskFull;
           if (check3 == false)
           {
               MessageBox.Show("Please enter FULL NIC OF FATHER ");
               return;
           }

            else if (qualificationBox.Text == "SELECT")         
            {
                MessageBox.Show("Please select the QULIFICATION");
                return;
            }

            else if (ocupationBox.Text == "SELECT")
            {
                MessageBox.Show("Please select the OCCUPATION");
                return;
            }

           else if(orgBox.Text=="(OPTIONAL) IF APPLY TO YOU")
           {
               orgBox.Text = "";
           }


            else if (provinceBox.Text == "SELECT")
            {
                MessageBox.Show("Please select the PROVINCE");
                return;
            }                
            
           
            
           
            this.AcceptButton = enterButton;

            fullName = firstNameBox.Text +' '+ lNameBox.Text;             

            try
            {
                xconn = new MySqlConnection("Server=127.0.0.1;DataBase=CENSUS_DB;Uid=root;pwd=0345;port=3306;");

                xconn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "insert into dataEntry(CNIC,FirstName,LastName,FullName ,DOByear ,DOBmonth ,DOBday ,Age ,Address ,Area ,District ,city ,ZipCode ,Province , Gender,MobileNumber,FatherName ,MotherName ,FatherNIC ,NumberOfSibling ,qualification,income,Ocupation,NameOfOrginization ,NumberOfChildren ) values('" + nicBox.Text + "','" + firstNameBox.Text + "','" + lNameBox.Text + "','" + fullName + "','" + yearBox.Text + "','" + monthBox.Text + "','" + dayBox.Text + "','" + Convert.ToInt32(ageBox.Text) + "','" + addressBox.Text + "','" + areaBox.Text + "','" + districtBox.Text + "','" + cityBox.Text + "','" + zipBox.Text + "','" + provinceBox.Text + "','" + gender + "','" + mobileBox.Text + "','" + fnameBox.Text + "','" + mnameBox.Text + "','" + fnicBox.Text + "','" + Convert.ToInt32(siblingcountBox.Text) + "','" + qualificationBox.Text + "','" + Convert.ToInt32(incomeBox.Text) + "','" + ocupationBox.Text + "','" + orgBox.Text + "','" + childrenBox.Text + "');";
               
                cmd.Connection = xconn;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Successfully Entered");

                nicBox.Text = null;
                firstNameBox.Text = null;
                lNameBox.Text = null;
                yearBox.Text = null;
                monthBox.Text = null;
                mobileBox.Text = null;
                dayBox.Text = null;
                ageBox.Text = null;
                addressBox.Text = null;
                areaBox.Text = null;
                districtBox.Text = null;
                cityBox.Text = null;
                zipBox.Text = null;
                mobileBox.Text = null;
                provinceBox.Text = null;
                maleButton.Refresh();
                femaleButton.Refresh();
                fnameBox.Text = null;
                mnameBox.Text = null;
                fnicBox.Text = null;
                siblingcountBox.Text = null;
                incomeBox.Text = null;
                orgBox.Text = null;
                childrenBox.Text = null;


                xconn.Close();
            }
                

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void femaleButton_CheckedChanged_1(object sender, EventArgs e)
        {
            gender = "FEMALE";
        }

        private void maleButton_CheckedChanged_1(object sender, EventArgs e)
        {
            gender = "MALE";
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

        private void ageBox_TextChanged(object sender, EventArgs e)
        {
  
        }

        private void nicBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

     }       
       
}

