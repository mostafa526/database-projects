using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection IMDB_Connection;

        

        public Form1()
        {
            InitializeComponent();
        }

        private void mainFormLoad(object sender,EventArgs e){

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            /*
            IMDB_Connection = new OracleConnection(ordb);
            IMDB_Connection.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = IMDB_Connection;
            //cmd.CommandText = "select ActorID from Actors";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                //cmb_ID.Items.Add(dr[0]);
            }
            dr.Close();
             * 
             **/
        }

        private void searchMovieButton_Click(object sender, EventArgs e)
        {
            searchMovieForm form = new searchMovieForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
