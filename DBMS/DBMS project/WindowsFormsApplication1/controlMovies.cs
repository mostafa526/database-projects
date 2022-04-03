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
    public partial class controlMovies : Form
    {
        string connectiondb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;
        public controlMovies()
        {
            InitializeComponent();
        
        }

        private void controlMovies_Load(object sender, EventArgs e)
        {
            prizeType.Items.Add("collective");
            prizeType.Items.Add("individual");
            newType.Hide();
            label3.Hide();
            label4.Hide();
            newName.Hide();
            newType.SelectedIndex = 1;
            prizeType.SelectedIndex = 1;
            conn = new OracleConnection(connectiondb);
            conn.Open();

            OracleCommand prizeDatacmd = new OracleCommand();
            prizeDatacmd.Connection = conn;
            prizeDatacmd.CommandText = "select *from prize";
            prizeDatacmd.CommandType = CommandType.Text;
            OracleDataReader dr = prizeDatacmd.ExecuteReader();
            while (dr.Read())
            {
                prizeData.Items.Add(dr[0]);
                prize_data.Items.Add(dr[0]);
            }
            //prizeData.SelectedIndex = 1;
            dr.Close();
        }

        private void insertTab_Click(object sender, EventArgs e)
        {
            


        }

        private void editTab_Click(object sender, EventArgs e)
        {
          
        }

        private void deleteTab_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(connectiondb);
            conn.Open();

            OracleCommand insertcmd = new OracleCommand();
            insertcmd.Connection = conn;
            insertcmd.CommandText = "insert into Prize values (:Name,:Type)";
            insertcmd.Parameters.Add("name", prize_name_txt.Text);
            insertcmd.Parameters.Add("type", prizeType.SelectedItem.ToString());
            int r = insertcmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("New prize is added");
            }

        }

       

        private void loadPrizes_Click(object sender, EventArgs e)
        {
            
        }

        private void saveNewData_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(connectiondb);
            conn.Open();

            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "update prize set type=:type where name =:name";


            c.Parameters.Add("type", newType.SelectedItem.ToString());
            int r = c.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("prize updated");
            }
        }

        private void prizeData_SelectedIndexChanged(object sender, EventArgs e)
        {
            newName.Text = prizeData.SelectedItem.ToString();
            newType.Show();
            label3.Show();
            label4.Show();
            newName.Show();
        }

        private void prize_data_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "Delete from prize where name=:name";
            c.Parameters.Add("name", prize_data.SelectedItem.ToString());
            int r = c.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("Actor deleted");
                prize_data.Items.RemoveAt(prize_data.SelectedIndex);
              
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn = new OracleConnection(connectiondb);
            conn.Open();

            OracleCommand prizeDatacmd = new OracleCommand();
            prizeDatacmd.Connection = conn;
            prizeDatacmd.CommandText = "select *from prize";
            prizeDatacmd.CommandType = CommandType.Text;
            OracleDataReader dr = prizeDatacmd.ExecuteReader();
            prizeData.Items.Clear();
            prize_data.Items.Clear();
            while (dr.Read())
            {
                prizeData.Items.Add(dr[0]);
                prize_data.Items.Add(dr[0]);
            }
            dr.Close();
        }
        
        
    }
}
