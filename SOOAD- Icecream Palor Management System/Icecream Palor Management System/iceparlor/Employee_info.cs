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
    public partial class Employee_info : Form
    {
        public Employee_info()
        {
            InitializeComponent();
        }

        private void Employee_info_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'usersDataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.usersDataSet.users);


        }

                private void UPDATE_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection row = userGridView1.SelectedRows;
            var id = row[0].Cells[0].Value;

          
            SqlConnection con = new SqlConnection(@"Data Source=parmar\mysqlexpress;Initial Catalog=icrecreamparlor;Integrated Security=True");
            con.Open();
            SqlCommand adp_updateusers = new SqlCommand("update  users set mobileNo='" + mobileNobox.Text + "' where ManagerID='" +id + "';", con);
            int n1 = adp_updateusers.ExecuteNonQuery();

            adp_updateusers = new SqlCommand("update  users set password='" + passwordBox.Text + "' where ManagerID='" + id + "';", con);
            int n2 = adp_updateusers.ExecuteNonQuery();
             adp_updateusers = new SqlCommand("update  users set address='" + adddressBox.Text + "' where ManagerID='" + id + "';", con);
             int n3 = adp_updateusers.ExecuteNonQuery();
             adp_updateusers = new SqlCommand("update  users set isManagar='" + typeBox.Text + "' where ManagerID='" + id + "';", con);
             int n4 = adp_updateusers.ExecuteNonQuery();

            if (n1 == 1 && n2 == 1 && n3==1 && n4==1)
            {
                SqlDataAdapter adp_update = new SqlDataAdapter("SELECT * FRom users;", con);
                DataTable dt4 = new DataTable();
                adp_update.Fill(dt4);
                BindingSource updatebindingSource = new BindingSource();
                updatebindingSource.DataSource = dt4;
                usersBindingSource.DataSource = updatebindingSource;
                con.Close();

            }
        }

        

        private void userGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewSelectedRowCollection row = userGridView1.SelectedRows;

            mobileNobox.Text = row[0].Cells[1].Value.ToString();

            passwordBox.Text = row[0].Cells[2].Value.ToString();

            adddressBox.Text = row[0].Cells[3].Value.ToString();

            typeBox.Text = row[0].Cells[4].Value.ToString();
        }
    }
}
