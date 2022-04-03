using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Types;
using Oracle.DataAccess.Client;
namespace WindowsFormsApplication1
{
    public partial class MoviesGetYear : Form
    {
        string connectiondb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;
        public MoviesGetYear()
        {
            InitializeComponent();
        }

        private void MoviesGetYear_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(connectiondb);
            conn.Open();

            OracleCommand moviesNamescmd = new OracleCommand();
            moviesNamescmd.Connection = conn;
            moviesNamescmd.CommandText = "select name from movies";
            moviesNamescmd.CommandType = CommandType.Text;
            OracleDataReader dr = moviesNamescmd.ExecuteReader();
            
            while (dr.Read())
            {
                moviesData.Items.Add(dr[0]);
            }
            moviesData.SelectedIndex = 1;
            dr.Close();
            conn.Close();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(connectiondb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "getyearmovie";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("moviesName",moviesData.SelectedItem.ToString());
            cmd.Parameters.Add("year", OracleDbType.Int32, ParameterDirection.Output);
            cmd.ExecuteNonQuery();
            moviesYear.Text = cmd.Parameters["year"].Value.ToString();
        }
    }
}
