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
    public partial class displayMovies : Form
    {
        public displayMovies()
        {
            InitializeComponent();
        }

        private void displayMovies_Load(object sender, EventArgs e)
        {
            string connectiondb = "Data source=orcl;User Id=scott; Password=tiger;";
            OracleConnection conn = new OracleConnection(connectiondb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select name,year from Movies order by name asc";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            moviesData.DataSource = cmd.ExecuteReader();


            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Year");

            while (dr.Read())
            {
                DataRow row = dataTable.NewRow();
                row["name"] = dr["name"];
                row["year"] = dr["year"];
                dataTable.Rows.Add(row);
            }
            moviesData.DataSource = dataTable;
            //moviesData.DataBind();
            dr.Close();
            conn.Close();
            for (int i = 0; i < moviesData.Columns.Count; i++)
            {
                moviesData.Columns[i].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                moviesData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
                moviesData.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

        }
    }
}
