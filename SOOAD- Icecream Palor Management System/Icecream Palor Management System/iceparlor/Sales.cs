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
namespace iceparlor
{
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
        }

        private void updateMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'salesDataSet2.sales' table. You can move, or remove it, as needed.
            this.salesTableAdapter.Fill(this.salesDataSet2.sales);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=parmar\mysqlexpress;Initial Catalog=icrecreamparlor;Integrated Security=True");
            con.Open();
            
            try
            {
                SqlDataAdapter adp_update = new SqlDataAdapter("select * from sales where date='" + date.Text + "';", con);
                DataTable dt4 = new DataTable();
                adp_update.Fill(dt4);
                BindingSource updatebindingSource = new BindingSource();
                updatebindingSource.DataSource = dt4;
                salesBindingSource.DataSource = updatebindingSource;
                con.Close();
            }
            catch (Exception e2)
            {
                MessageBox.Show("Enter date in the format yyyy-mm-dd");
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=parmar\mysqlexpress;Initial Catalog=icrecreamparlor;Integrated Security=True");
            con.Open();

           
                SqlDataAdapter adp_update = new SqlDataAdapter("select * from sales where sales_id='" + salesId.Text + "';", con);
                DataTable dt4 = new DataTable();
                adp_update.Fill(dt4);
                BindingSource updatebindingSource = new BindingSource();
                updatebindingSource.DataSource = dt4;
                salesBindingSource.DataSource = updatebindingSource;
                con.Close();
            
            


        }
    }
}
