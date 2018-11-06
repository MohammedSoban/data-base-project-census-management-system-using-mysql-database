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
    public partial class loginForm : Form
    {
       private MySqlConnection xconn;
        int i;
       
        
        public loginForm()
        {


            xconn = new MySqlConnection("Server=127.0.0.1;DataBase=CENSUS_DB;Uid=root;pwd=0345;port=3306;");

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

         
            this.AcceptButton = loginButton;
            i = 0;
            xconn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select * from login where USERNAME='" + unbox.Text + "'and PASS='" + passbox.Text + "'";
            cmd.Connection = xconn;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            unbox.Text = null;
            passbox.Text = null;

            if (i == 0)
            {
                MessageBox.Show("Invalid username or password");
            }
            else
            {
                this.Hide();
                choiceForm fm = new choiceForm();
                fm.Show();

            }

            xconn.Close();
            
        }

        private void passbox_TextChanged(object sender, EventArgs e)
        {
            

            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                Console.WriteLine("The Caps Lock key is ON.");
            }
            else
            {
                Console.WriteLine("The Caps Lock key is OFF.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void unbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void temp_Click(object sender, EventArgs e)
        {
            this.Hide();

            choiceForm fm = new choiceForm();

            fm.Show();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }


      

    }
}
