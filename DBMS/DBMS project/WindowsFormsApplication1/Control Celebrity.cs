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
    public partial class Control_Celebrity : Form
    {
        string connectiondb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;
        int newID;
        public Control_Celebrity()
        {
            InitializeComponent();
        }

        private void Control_Celebrity_Load(object sender, EventArgs e)
        {
           newID= CreateNewID();
            
        }

        private void insert_Btn_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(connectiondb);
            conn.Open();

            OracleCommand c = new OracleCommand();

            c.Connection = conn;
            c.CommandText = "Insert_celebrity";
            c.CommandType = CommandType.StoredProcedure;
            c.Parameters.Add("CID", newID);
            c.Parameters.Add("N", celeName_txt.Text);
            c.ExecuteNonQuery();
            MessageBox.Show("Added successfully");
            newID = CreateNewID();
            celeName_txt.Text = "";
        }
        private int CreateNewID()
        {
            conn = new OracleConnection(connectiondb);
            conn.Open();

            OracleCommand moviesNamescmd = new OracleCommand();
            moviesNamescmd.Connection = conn;
            moviesNamescmd.CommandText = "select id from celebrity";
            moviesNamescmd.CommandType = CommandType.Text;
            int id;
            while (true)
            {
                OracleDataReader dr = moviesNamescmd.ExecuteReader();
                Random random = new Random();
                bool uniqueID = true;
                id = random.Next(10000, 99999);

                while (dr.Read())
                {
                    if (dr["id"].ToString() == id.ToString())
                    {
                        uniqueID = false;
                        break;
                    }
                }
                if (uniqueID == true)
                {
                    break;
                }
                dr.Close();
            }

            
            conn.Close();
            return id;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn = new OracleConnection(connectiondb);
            conn.Open();

            OracleCommand moviesNamescmd = new OracleCommand();
            moviesNamescmd.Connection = conn;
            moviesNamescmd.CommandText = "select name from celebrity";
            moviesNamescmd.CommandType = CommandType.Text;
            OracleDataReader dr = moviesNamescmd.ExecuteReader();
            celebName.Items.Clear();
            while (dr.Read())
            {
                celebName.Items.Add(dr[0]);
                nameToDel.Items.Add(dr[0]);
            }
            celebName.SelectedIndex = 1;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(connectiondb);
            conn.Open();
            OracleCommand c = new OracleCommand();

            c.Connection = conn;
            c.CommandText = "update_Celeb";
            c.CommandType = CommandType.StoredProcedure;

            c.Parameters.Add("oldcelename", celebName.SelectedItem.ToString());
            c.Parameters.Add("newcelename", newName.Text);

            
             c.ExecuteNonQuery();
             conn.Close();
             MessageBox.Show("updated successfully");
            // celebName.SelectedItem= newName.Text;
             //celebName.SelectedIndex = celebName.FindString(newName.Text);
             tabControl1_SelectedIndexChanged(new object(), new EventArgs());
           //  celebName.SelectedIndex = 1;
            newName.Text = "";
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(connectiondb);
            conn.Open();
            OracleCommand c = new OracleCommand();

            c.Connection = conn;
            c.CommandText = "delete_celebrity";
            c.CommandType = CommandType.StoredProcedure;

            c.Parameters.Add("N", nameToDel.SelectedItem.ToString());
            c.ExecuteNonQuery();
            MessageBox.Show("deleted successfully");
            nameToDel.Items.RemoveAt(nameToDel.SelectedIndex);

        }
    }
}
