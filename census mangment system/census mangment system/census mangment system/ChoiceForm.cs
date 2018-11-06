using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace census_mangment_system
{
    public partial class choiceForm : Form
    {
        public choiceForm()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            loginForm fm = new loginForm();

            fm.Show();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
                       
            this.Hide();

            entryForm fm = new entryForm();

            fm.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
           
            this.Hide();

            viewForm fm = new viewForm();

            fm.Show();        

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            updateForm fm = new updateForm();

            fm.Show();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            searchForm fm = new searchForm();

            fm.Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            deleteForm fm = new deleteForm();

            fm.Show();
        }

        private void queryButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            queryForm fm = new queryForm();

            fm.Show();
        }

        private void graphButton_Click(object sender, EventArgs e)
        {
             this.Hide();

            graphForm fm = new graphForm();

            fm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    
    }
}
