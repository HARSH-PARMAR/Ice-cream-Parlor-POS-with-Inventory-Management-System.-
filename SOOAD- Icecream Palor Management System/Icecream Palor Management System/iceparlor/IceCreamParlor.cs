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
    public partial class Form3 : Form
    {
        int price;
        string type;
        public Form3(string flag)
        {
            type = flag;
            InitializeComponent();
        }      
        
        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'flavoranalyticsDataSet6.sales' table. You can move, or remove it, as needed.
            this.salesTableAdapter.Fill(this.flavoranalyticsDataSet6.sales);
            // TODO: This line of code loads data into the 'icrecreamparlorDataSet1.bills' table. You can move, or remove it, as needed.
            this.billsTableAdapter2.Fill(this.icrecreamparlorDataSet1.bills);
            // TODO: This line of code loads data into the 'billsDataSet.bills' table. You can move, or remove it, as needed.
            this.billsTableAdapter1.Fill(this.billsDataSet.bills);
            // TODO: This line of code loads data into the 'containerDataSet.containers' table. You can move, or remove it, as needed.
            this.containersTableAdapter.Fill(this.containerDataSet.containers);
            // TODO: This line of code loads data into the 'flavoursDataSet.flavors' table. You can move, or remove it, as needed.
            this.flavorsTableAdapter.Fill(this.flavoursDataSet.flavors);
            // TODO: This line of code loads data into the 'icrecreamparlorDataSet.bills' table. You can move, or remove it, as needed.
            this.billsTableAdapter.Fill(this.icrecreamparlorDataSet.bills);
            if (type == "no")
            {
                employeeData.Enabled = false;
                viewSales.Enabled = false;

            }
            else
            {
                viewSales.Enabled = true;
                employeeData.Enabled = true;
            }
        }       

        private void button1_Click(object sender, EventArgs e)
        {   //ADD Button
            var flavour_id= flavourBox.SelectedValue;
            var container_id = containerBox.SelectedValue;
            int qty = Convert.ToInt32(qtyBox.Value);
            
//            MessageBox.Show(flavour_id.ToString()+container_id.ToString()+qty.ToString());
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=parmar\mysqlexpress;Initial Catalog=icrecreamparlor;Integrated Security=True");

                con.Open();
                SqlDataAdapter adp_price = new SqlDataAdapter("select price from menu where flavour_id=" + flavour_id + " and container_id=" + container_id + ";", con);

                DataTable dt1 = new DataTable();
                adp_price.Fill(dt1);
                price = Convert.ToInt32(dt1.Rows[0][0]);

                SqlDataAdapter adp_flavourname = new SqlDataAdapter("select flavour_name from flavors where flavour_id=" + flavour_id + ";", con);
                DataTable dt2 = new DataTable();
                adp_flavourname.Fill(dt2);
                var flavour_name = dt2.Rows[0][0];


                SqlDataAdapter adp_containername = new SqlDataAdapter("select container_name from containers where container_id=" + container_id + ";", con);
                DataTable dt3 = new DataTable();
                adp_containername.Fill(dt3);
                var container_name = dt3.Rows[0][0];

                SqlCommand billupdate = new SqlCommand("INSERT INTO bills ([flavour] ,[type],[qty],[amount] ,[flavour_id] ,[container_id],[unit_rate]) VALUES('" + flavour_name + "','" + container_name + " ','" + qty + " ','" + price * qty + " ','" + flavour_id + " ','" + container_id + " ','" + price + "' );", con);
                int n = Convert.ToInt32(billupdate.ExecuteNonQuery());

                if (n == 1)
                {
                    SqlDataAdapter adp_update = new SqlDataAdapter("SELECT [sr],[flavour],[type],[qty],[unit_rate],[amount] FRom bills;", con);
                    DataTable dt4 = new DataTable();
                    adp_update.Fill(dt4);
                    BindingSource updatebindingSource = new BindingSource();
                    updatebindingSource.DataSource = dt4;
                    billView.DataSource = updatebindingSource;
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("NOT AVAILABLE");
            }

        }

        private void flavourBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            flavourBox.Refresh();       
        }     

        private void button2_Click(object sender, EventArgs e)
        {          
            //DELETE button
            DataGridViewSelectedRowCollection  row = billView.SelectedRows;
            var id = row[0].Cells[4].Value;            

            SqlConnection con = new SqlConnection(@"Data Source=parmar\mysqlexpress;Initial Catalog=icrecreamparlor;Integrated Security=True");
            con.Open();
            SqlCommand billupdate = new SqlCommand("delete from bills where sr='" + id + "';", con);
            int n = billupdate.ExecuteNonQuery();
            if (n == 1){
                SqlDataAdapter adp_update = new SqlDataAdapter("SELECT [sr],[flavour],[type],[qty],[unit_rate],[amount] FRom bills;", con);
                DataTable dt4 = new DataTable();
                adp_update.Fill(dt4);
                BindingSource updatebindingSource = new BindingSource();
                updatebindingSource.DataSource = dt4;
                billView.DataSource = updatebindingSource;
                con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //PRINT button
            int n;
            var date = System.DateTime.Now.ToShortDateString();
             SqlConnection con = new SqlConnection(@"Data Source=parmar\mysqlexpress;Initial Catalog=icrecreamparlor;Integrated Security=True");
            con.Open();
            SqlDataAdapter adp_fillsales = new SqlDataAdapter("select * from bills;",con);
            DataTable dtBills= new DataTable();
            adp_fillsales.Fill(dtBills);
           var user_id=1;
           con.Close();
            foreach (DataColumn col in dtBills.Columns)
            {
                con.Open();
                     foreach (DataRow row in dtBills.Rows)
                     {
                             var a=row.ItemArray;
                             
                             SqlCommand addToSales = new SqlCommand("INSERT INTO sales ([flavour_id],[container_id],[user_id],[quantity],[date],[total],[unit_rate]) VALUES(" + a[6] + "," + a[5] + " ," + user_id + " ," + a[2] + " ,'" + date + " '," + a[3] + " , " + a[7] + ");", con);
                    n = addToSales.ExecuteNonQuery();
                   
                     }
                     con.Close();
                }
            //convert to word baki hai
            con.Open();
            SqlCommand truncate_bills = new SqlCommand("truncate table bills;",con);
            n = truncate_bills.ExecuteNonQuery();
                SqlDataAdapter adp_update = new SqlDataAdapter("SELECT [sr],[flavour],[type],[qty],[unit_rate],[amount] FRom bills;", con);
                DataTable dt4 = new DataTable();
                adp_update.Fill(dt4);
                BindingSource updatebindingSource = new BindingSource();
                updatebindingSource.DataSource = dt4;
                billView.DataSource = updatebindingSource;
                
                con.Close();
                }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MENU menu = new MENU();
            menu.Show();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void addFlavors_Click(object sender, EventArgs e)
        {

            addFlavor add = new addFlavor();
            add.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            sales.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CONTAINERS con = new CONTAINERS();
            con.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Employee_info emp = new Employee_info();
            emp.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=parmar\mysqlexpress;Initial Catalog=icrecreamparlor;Integrated Security=True");

            con.Open();
            SqlDataAdapter adp_update = new SqlDataAdapter("select flavour_id,SUM(total) as Amount,SUM(quantity) as Units from sales where date between '"+textBox1.Text+"' and '"+textBox2.Text+"' group by flavour_id;", con);
            DataTable dt4 = new DataTable();
            adp_update.Fill(dt4);
            BindingSource updatebindingSource = new BindingSource();
            updatebindingSource.DataSource = dt4;
            dataGridView1.DataSource = updatebindingSource;
            con.Close();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=parmar\mysqlexpress;Initial Catalog=icrecreamparlor;Integrated Security=True");

            con.Open();
            SqlDataAdapter adp_update = new SqlDataAdapter("select flavour_id,SUM(total) as Amount,SUM(quantity) as Units from sales  where date between '" + textBox1.Text + "' and '" + textBox2.Text + "' group by flavour_id;", con);
            DataTable dt4 = new DataTable();
            adp_update.Fill(dt4);
            BindingSource updatebindingSource = new BindingSource();
            updatebindingSource.DataSource = dt4;
            dataGridView1.DataSource = updatebindingSource;
            con.Close();
        }

        private void billView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        } 
        }        
    }
