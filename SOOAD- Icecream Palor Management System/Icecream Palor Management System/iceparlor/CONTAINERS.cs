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
    public partial class CONTAINERS : Form
    {
        public CONTAINERS()
        {
            InitializeComponent();
        }

        private void CONTAINERS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'icrecreamparlorDataSet4.containers' table. You can move, or remove it, as needed.
            this.containersTableAdapter.Fill(this.CONTAINERDataSet4.containers);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewSelectedRowCollection row = updateContainerGridView1.SelectedRows;

                add_containerName.Text = row[0].Cells[0].Value.ToString();

                add_containerUnit.Text = row[0].Cells[1].Value.ToString();
            }
            catch(Exception ex)
            {}
        }
        
        private void addButton_Click(object sender, EventArgs e)
        {
            
            int n = 0;
            SqlConnection con = new SqlConnection(@"Data Source=parmar\mysqlexpress;Initial Catalog=icrecreamparlor;Integrated Security=True");
            con.Open();
            try
            {
                SqlCommand addcontainer = new SqlCommand("insert into containers values('" + add_containerName.Text + "','" + add_containerUnit + "');", con);
                n = Convert.ToInt32(addcontainer.ExecuteNonQuery());
            }
            catch (Exception addConException)
            {
                MessageBox.Show("Please enter unique Containers.");

            }


            if (n == 1)
            {
                SqlDataAdapter adp_update = new SqlDataAdapter("SELECT * FRom flavors;", con);
                DataTable dt4 = new DataTable();
                adp_update.Fill(dt4);
                BindingSource updatebindingSource = new BindingSource();
                updatebindingSource.DataSource = dt4;
                 containersBindingSource.DataSource = updatebindingSource;
                con.Close();
            }

        }

        private void updateButton_Click(object sender, EventArgs e)
        {

            DataGridViewSelectedRowCollection row = updateContainerGridView1.SelectedRows;
            var id = row[0].Cells[2].Value;
            SqlConnection con = new SqlConnection(@"Data Source=parmar\mysqlexpress;Initial Catalog=icrecreamparlor;Integrated Security=True");
            con.Open();
            SqlCommand adp_updateContainer = new SqlCommand("update  containers set container_name='" + add_containerName.Text + "' where container_id='" + id + "';", con);
            int n1 = adp_updateContainer.ExecuteNonQuery();

            SqlCommand adp_updateflavor2 = new SqlCommand("update   containers set amount='" + add_containerUnit.Text + "'where container_id='" + id + "';", con);
            int n2 = adp_updateflavor2.ExecuteNonQuery();

            if (n1 == 1 && n2 == 1)
            {
                SqlDataAdapter adp_update = new SqlDataAdapter("SELECT * FRom containers;", con);
                DataTable dt4 = new DataTable();
                adp_update.Fill(dt4);
                BindingSource updatebindingSource = new BindingSource();
                updatebindingSource.DataSource = dt4;
                containersBindingSource.DataSource = updatebindingSource;
                con.Close();

            }
        }

     
    }
}
