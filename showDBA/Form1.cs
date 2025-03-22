using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace showDBA
{
    public partial class Form1 : Form
    {
        SqlConnection cnn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataView dv = new DataView();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int i;
            dataGridView1.Rows.Add();
            i = dataGridView1.Rows.Count-2;
            dataGridView1.Rows[i].Cells[0].Value= txtCid.Text;
            dataGridView1.Rows[i].Cells[1].Value= txtRid.Text;
            dataGridView1.Rows[i].Cells[2].Value= txtCname.Text;
            dataGridView1.Rows[i].Cells[3].Value= txtSname.Text;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            for (int i = 0; i<dataGridView1.Rows.Count-1; i++) {
                cmd.CommandText = "Insert into tblcheckin values('"+
                    dataGridView1.Rows[i].Cells[0].Value +"','"+
                    dataGridView1.Rows[i].Cells[1].Value + "','"+
                    dataGridView1.Rows[i].Cells[2].Value+"','"+
                    dataGridView1.Rows[i].Cells[3].Value +"','"+
                    DateTime.Now.ToShortDateString() +"')";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "Update tblroom set Rstatus='Busy' where rid='"+
                    dataGridView1.Rows[i].Cells[1].Value+"'";
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Data Save completed");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cnn.ConnectionString = "data source=DESKTOP-N11IHQI; initial catalog = hotel" +
                                    ";Integrated Security=true";
            cnn.Open();
            cmd.Connection = cnn;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if ( btnSearch.Text == "Search" ) {
                btnSearch.Text = "Unserach";
                cmd.CommandText = "Select * from tblcheckIn where cin='"+ txtCid.Text +"'";
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);
                dv = ds.Tables[0].DefaultView;

                dataGridView1.Columns.Clear();
                dataGridView1.DataSource=dv;
            }
            else {
                dataGridView1.DataSource = null;
                dataGridView1.Columns.Add("","Ch_ID");
                dataGridView1.Columns.Add("", "RID");
                dataGridView1.Columns.Add("", "Cust_Name");
                dataGridView1.Columns.Add("", "Staff_Name");

                btnSearch.Text = "Search";
            }
        }
    }
}
