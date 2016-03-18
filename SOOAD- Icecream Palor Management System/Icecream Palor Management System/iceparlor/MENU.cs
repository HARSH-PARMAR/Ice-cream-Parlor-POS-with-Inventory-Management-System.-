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
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void MENU_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'icrecreamparlorDataSet3.containers' table. You can move, or remove it, as needed.
            this.containersTableAdapter.Fill(this.icrecreamparlorDataSet3.containers);
            // TODO: This line of code loads data into the 'flavorDataSet3.flavors' table. You can move, or remove it, as needed.
            this.flavorsTableAdapter1.Fill(this.flavorDataSet3.flavors);
            // TODO: This line of code loads data into the 'flavoursDataSet.flavors' table. You can move, or remove it, as needed.
            this.flavorsTableAdapter.Fill(this.flavoursDataSet.flavors);
            // TODO: This line of code loads data into the 'icrecreamparlorDataSet2.menu' table. You can move, or remove it, as needed.
            this.menuTableAdapter.Fill(this.icrecreamparlorDataSet2.menu);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void c(object sender, EventArgs e)
        {

        }

        private void cv(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewSelectedRowCollection row = menuGridView1.SelectedRows;

            flavor_id.Text = row[0].Cells[0].Value.ToString();
            container_id.Text = row[0].Cells[1].Value.ToString();
            amount.Text = row[0].Cells[2].Value.ToString();
            price.Text = row[0].Cells[3].Value.ToString(); 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection row = menuGridView1.SelectedRows;
            var id = row[0].Cells[4].Value;
            SqlConnection con = new SqlConnection(@"Data Source=parmar\mysqlexpress;Initial Catalog=icrecreamparlor;Integrated Security=True");
            con.Open();
            SqlCommand menu_update = new SqlCommand("update  menu set flavour_id='" + flavor_id.Text + "' where menu_id='" + id + "';", con);
            int n1 = menu_update.ExecuteNonQuery();

            menu_update = new SqlCommand("update  menu set  container_id='" + container_id.Text + "' where menu_id='" + id + "';", con);
            int n2= menu_update.ExecuteNonQuery();
             
            menu_update = new SqlCommand("update  menu set amount='" + amount.Text + "' where menu_id='" + id + "';", con);
            int n3 = menu_update.ExecuteNonQuery();

            menu_update = new SqlCommand("update  menu set price='" + price.Text + "' where menu_id='" + id + "';", con);
            int n4 = menu_update.ExecuteNonQuery();

            if (n1 == 1 && n2 == 1 && n3==1 && n4==1)
            {
                SqlDataAdapter adp_update = new SqlDataAdapter("SELECT * FRom menu;", con);
                DataTable dt4 = new DataTable();
                adp_update.Fill(dt4);
                BindingSource updatebindingSource = new BindingSource();
                updatebindingSource.DataSource = dt4;
                menuBindingSource.DataSource = updatebindingSource;
                con.Close();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {



            int n = 0;
            SqlConnection con = new SqlConnection(@"Data Source=parmar\mysqlexpress;Initial Catalog=icrecreamparlor;Integrated Security=True");
            con.Open();
            //MessageBox.Show("123");
            try
            {
                SqlCommand addFlavor = new SqlCommand("insert into menu values('"+flavor_id.Text+"','"+container_id.Text+"','"+amount.Text+"','"+price.Text+"');", con);
                n = Convert.ToInt32(addFlavor.ExecuteNonQuery());
            }
            catch (Exception addFlavException)
            {
                MessageBox.Show(addFlavException.ToString());
            }


            if (n == 1)
            {
                SqlDataAdapter adp_update = new SqlDataAdapter("SELECT * FRom menu;", con);
                DataTable dt4 = new DataTable();
                adp_update.Fill(dt4);
                BindingSource updatebindingSource = new BindingSource();
                updatebindingSource.DataSource = dt4;
                menuBindingSource.DataSource = updatebindingSource;
                con.Close();
            }
            else
                MessageBox.Show("Enter proper data!");
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                flavor_id.Text = flavors.SelectedValue.ToString();
            }
            catch(Exception e3){}

        }

        private void containers_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                container_id.Text = containers.SelectedValue.ToString();
            }
            catch(Exception e4){}
        }
    }
}
