using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace iceparlor
{
    public partial class addFlavor : Form
    {
        public addFlavor()
        {
            InitializeComponent();
        }

        private void add_flavorform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'addFlavorsDataSet2.flavors' table. You can move, or remove it, as needed.
            this.flavorsTableAdapter.Fill(this.addFlavorsDataSet2.flavors);


        }

        private void addFlavour_Click(object sender, EventArgs e)
        {
            var flavour_name = addname.Text;
            var volume = addvolume.Text;



            int n = 0;
            SqlConnection con = new SqlConnection(@"Data Source=parmar\mysqlexpress;Initial Catalog=icrecreamparlor;Integrated Security=True");
            con.Open();
            try
            {
                SqlCommand addFlavor = new SqlCommand("insert into flavors values('" + flavour_name + "','" + volume + "');", con);
               n = Convert.ToInt32(addFlavor.ExecuteNonQuery());
            }
            catch (Exception addFlavException)
            {
                MessageBox.Show("Please enter unique flavours.");

            }
           

            if (n == 1)
            {
                SqlDataAdapter adp_update = new SqlDataAdapter("SELECT * FRom flavors;", con);
                DataTable dt4 = new DataTable();
                adp_update.Fill(dt4);
                BindingSource updatebindingSource = new BindingSource();
                updatebindingSource.DataSource = dt4;
                flavorsBindingSource.DataSource = updatebindingSource;
                con.Close();
            }
        }

        private void deleteFlavor_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection row = addGridVIew.SelectedRows;
            var id = row[0].Cells[2].Value;
            var flavour_name = row[0].Cells[0].Value;
            var volume = row[0].Cells[1].Value; 

            SqlConnection con = new SqlConnection(@"Data Source=parmar\mysqlexpress;Initial Catalog=icrecreamparlor;Integrated Security=True");
            con.Open();
            SqlCommand deleteflavor = new SqlCommand("delete from flavors where flavour_id='" + id + "';", con);
            int n = deleteflavor.ExecuteNonQuery();
            if (n == 1)
            {
                SqlDataAdapter adp_update = new SqlDataAdapter("SELECT * FRom flavors;", con);
                DataTable dt4 = new DataTable();
                adp_update.Fill(dt4);
                BindingSource updatebindingSource = new BindingSource();
                updatebindingSource.DataSource = dt4;
                flavorsBindingSource.DataSource = updatebindingSource;
                con.Close();
            }
        }

        private void updateflavor_Click(object sender, EventArgs e)
        {
           
            DataGridViewSelectedRowCollection row = addGridVIew.SelectedRows;
            var id = row[0].Cells[2].Value;
            SqlConnection con = new SqlConnection(@"Data Source=parmar\mysqlexpress;Initial Catalog=icrecreamparlor;Integrated Security=True");
            con.Open();
            SqlCommand adp_updateflavor1 = new SqlCommand("update  flavors set flavour_name='" + addname.Text + "' where flavour_id='"+id+"';", con);
            int n1 = adp_updateflavor1.ExecuteNonQuery();
            
            SqlCommand adp_updateflavor2 = new SqlCommand("update  flavors set  flavour_unit='" + addvolume.Text + "'where flavour_id='" + id + "';", con);
            int n2 = adp_updateflavor2.ExecuteNonQuery();

            if (n1 == 1 && n2 == 1)
            {
                SqlDataAdapter adp_update = new SqlDataAdapter("SELECT * FRom flavors;", con);
                DataTable dt4 = new DataTable();
                adp_update.Fill(dt4);
                BindingSource updatebindingSource = new BindingSource();
                updatebindingSource.DataSource = dt4;
                flavorsBindingSource.DataSource = updatebindingSource;
                con.Close();
            
            }

        }

       
        private void addGridVIew_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewSelectedRowCollection row = addGridVIew.SelectedRows;

                addname.Text = row[0].Cells[0].Value.ToString();
                addvolume.Text = row[0].Cells[1].Value.ToString();
            }
            catch(Exception ex)
            {}
        }

        private void addGridVIew_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewSelectedCellCollection cell = addGridVIew.SelectedCells;

           // addname.Text = cell[0].Value.ToString;
           // addvolume.Text = row[0].Cells["flavour_unit"].Value.ToString(); 

        }

    }
}
