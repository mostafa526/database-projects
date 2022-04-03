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
    public partial class CelebrityPrizes : Form
    {
        string connectiondb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;
        public CelebrityPrizes()
        {
            InitializeComponent();
        }

        private void CelebrityPrizes_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(connectiondb);
            conn.Open();

            OracleCommand prizeDatacmd = new OracleCommand();
            prizeDatacmd.Connection = conn;
            prizeDatacmd.CommandText = "select *from prize";
            prizeDatacmd.CommandType = CommandType.Text;
            OracleDataReader dr = prizeDatacmd.ExecuteReader();
            while (dr.Read())
            {
                prizeNames.Items.Add(dr[0]);
            }
            prizeNames.SelectedIndex = 1;
            dr.Close();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            ///
            //Oscars Best Actress
            //Golden Globes
            //
            conn = new OracleConnection(connectiondb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "celebrityPrize";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("prizeName", prizeNames.SelectedItem.ToString());
            cmd.Parameters.Add("prizeData ", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("movie name");
            dataTable.Columns.Add("celebrity name");
            dataTable.Columns.Add("year");
           // int count = 0;
            while (dr.Read())
            {
                DataRow row = dataTable.NewRow();
                row["movie name"] = dr[0];
                row["celebrity name"] = dr[1];
                row["year"] = dr[2];
                dataTable.Rows.Add(row);
               // count++;

            }
           // MessageBox.Show("count:"+count);
            celebPrizeData.DataSource = dataTable;
            dr.Close();
            conn.Close();
            for (int i = 0; i < celebPrizeData.Columns.Count; i++)
            {
                celebPrizeData.Columns[i].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                celebPrizeData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
                celebPrizeData.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

        }
    }
}
