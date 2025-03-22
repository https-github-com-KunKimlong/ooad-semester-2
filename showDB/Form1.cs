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
using System.CodeDom;
namespace showDB
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

        private void Form1_Load(object sender, EventArgs e)
        {
            cnn.ConnectionString = "Data Source=DESKTOP-N11IHQI; " +
                                   "Initial catalog=hotel; " +
                                   "integrated security=true";
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandText = "Delete from tblroom where  rid='r001'";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "Select * from tblroom";
            ds = new DataSet();   
            da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            dv = ds.Tables[0].DefaultView;
            dataGridView1.DataSource = dv;
            textBox1.DataBindings.Add(new Binding("text", dv, "Rtypes"));

        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder cmb = new SqlCommandBuilder(da);
            da.Update(ds);
            MessageBox.Show("Update completed");
        }
    }
}
