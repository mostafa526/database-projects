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

    public partial class editMovies : Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet Movieset;

        public editMovies()
        {
            InitializeComponent();
          
        }

        private void editMovies_Load(object sender, EventArgs e)
        {
            loadMoviesButton_Click(new object() ,new EventArgs());
        }

        private void loadMoviesButton_Click(object sender, EventArgs e)
        {
            string connect_string = "Data Source=orcl; User Id=scott;Password=tiger;";
            adapter = new OracleDataAdapter("select * from movies ORDER BY Name asc", connect_string);
            Movieset = new DataSet();
            adapter.Fill(Movieset);
            moviesGridView.DataSource = Movieset.Tables[0];

            for (int i = 0; i < moviesGridView.Columns.Count; i++)
            {
                moviesGridView.Columns[i].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                moviesGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
                moviesGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            this.moviesGridView.Columns["ID"].Visible = false;

        }

        private void saveMoviesButton_Click(object sender, EventArgs e)
        {
                            //***********ATTENTION************//
            //if you press Enter after adding a cell then there will be an error


            MessageBox.Show((moviesGridView.Rows.Count-1).ToString());
            for (int i = 0; i < moviesGridView.Rows.Count-1 ; i++)
            {
                if (moviesGridView.Rows[i].Cells[4].Value.ToString() == "")
                {
                    Random random = new Random();
                    int newID;
                    while (true)
                    {
                        bool uniqueID = true;
                        newID = random.Next(10000, 99999);
                        for (int j = 0; j < i; j++)
                        {
                            if (moviesGridView.Rows[j].Cells[4].Value.ToString().Equals(newID.ToString()))
                            {
                                uniqueID = false;
                                break;
                            }
                        }
                        if (uniqueID)
                        {
                            break;
                        }
                    }
                    moviesGridView.Rows[i].Cells[4].Value = newID;
                }
            }
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(Movieset.Tables[0]);
            MessageBox.Show("Data Updated!");
        }
    }
}
