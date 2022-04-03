using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class searchMovieForm : Form
    {
        int searchOption = 1;
        public searchMovieForm()
        {
            InitializeComponent();
        }

        private void searchMovieForm_Load(object sender, EventArgs e)
        {
            searchOptions.SelectedItem = "Movie's Name";
        }

        private void searchOptionSelected(object sender, EventArgs e)
        {
            if (searchOptions.SelectedItem.ToString() == "Movie's Name")
            {
                searchOption = 1;
            }
            else if (searchOptions.SelectedItem.ToString() == "Celebrity's Name")
            {
                searchOption = 2;
            }
            else if (searchOptions.SelectedItem.ToString() == "Year")
            {
                searchOption = 3;
            }
        }
        private void searchForMovie(object sender, EventArgs e)
        {
            
            if (searchOption == 1)
            {
                MessageBox.Show("search by movie name");
            }
            else if (searchOption == 2)
            {
                MessageBox.Show("search by Celebrity");
            }
            else if (searchOption == 3)
            {
                MessageBox.Show("search by movie year");
            }
            label1.Focus();
        }

        private void enterPressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                searchForMovie(new object(), new EventArgs());
            }
            else
            {
                if (searchOption == 3)
                {
                    if (!char.IsDigit(e.KeyChar)&& e.KeyChar!=8)
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
