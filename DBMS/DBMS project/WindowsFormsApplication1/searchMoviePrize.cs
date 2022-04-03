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
    public partial class searchMoviePrize : Form
    {


        public searchMoviePrize()
        {
            InitializeComponent();
        }

        private void prizeSearchButton_Click(object sender, EventArgs e)
        {
            string connect_str = "User Id=scott; Password=tiger;Data Source=orcl";
            string select_str = "select movies.name,win_movie_prize.year from win_movie_prize, movies where win_movie_prize.movieid = movies.ID  and UPPER(win_movie_prize.prizename)  like :n order by win_movie_prize.year DESC";
            OracleDataAdapter adapter = new OracleDataAdapter(select_str, connect_str);
            adapter.SelectCommand.Parameters.Add("n", "%"+prizeEntered.Text.ToUpper()+"%");
            DataSet prize_name = new DataSet();
            adapter.Fill(prize_name);
            movieWinPrize.DataSource = prize_name.Tables[0];

            for (int i = 0; i < movieWinPrize.Columns.Count; i++)
            {
                movieWinPrize.Columns[i].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                movieWinPrize.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
                movieWinPrize.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void searchMoviePrize_Load(object sender, EventArgs e)
        {
            string connect_string = "Data Source=orcl; User Id=scott;Password=tiger;";
            OracleDataAdapter adapter = new OracleDataAdapter("select name from prize where type = 'collective'", connect_string); ;
            DataSet Movieset = new DataSet();
            adapter.Fill(Movieset);
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            for (int i = 0; i < Movieset.Tables[0].Rows.Count; i++)
            {
                collection.Add(Movieset.Tables[0].Rows[i][0].ToString());
            }
            this.prizeEntered.AutoCompleteCustomSource = collection;
        }
    }
}
