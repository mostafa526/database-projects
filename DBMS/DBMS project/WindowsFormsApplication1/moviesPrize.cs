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
    public partial class moviesPrize : Form
    {
           string connectiondb = "Data source=orcl;User Id=scott; Password=tiger;";
           OracleConnection conn;
            
        public moviesPrize()
        {
            InitializeComponent();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(connectiondb);
            conn.Open();

           OracleCommand prizeDataConn = new OracleCommand();
            prizeDataConn.Connection = conn;
            prizeDataConn.CommandText = "select name,win_movie_prize.year from win_movie_prize,Movies where PrizeName=:N and movieID=Id";
            prizeDataConn.CommandType = CommandType.Text;
            prizeDataConn.Parameters.Add(":N", comboBox1.SelectedItem.ToString());
            OracleDataReader dr = prizeDataConn.ExecuteReader();
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
            this.moviesPrizeData.DataSource = dataTable;
            dr.Close();
            conn.Close();
            for (int i = 0; i < moviesPrizeData.Columns.Count; i++)
            {
                moviesPrizeData.Columns[i].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                moviesPrizeData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
                moviesPrizeData.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

        }

        private void moviesPrize_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(connectiondb);
            conn.Open();

            OracleCommand prizeDataConn = new OracleCommand();
            prizeDataConn.Connection = conn;
            prizeDataConn.CommandText = "select prizename from win_movie_prize";
            prizeDataConn.CommandType = CommandType.Text;
            OracleDataReader dr = prizeDataConn.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }
            comboBox1.SelectedIndex = 0;
            dr.Close();
            conn.Close();
        }
    }
}
