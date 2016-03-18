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
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Signup.Enabled = false;
            Signup.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var flag="no" ;
            SqlConnection con = new SqlConnection(@"Data Source=parmar\mysqlexpress;Initial Catalog=icrecreamparlor;Integrated Security=True");
            con.Open();
            if (checkBox1.Checked)
            {
                flag = "yes";
            }
            else
                flag = "no";

            SqlCommand cmd = new SqlCommand("select * from users where mobileNo='" + textBox1.Text + "' and password='" + textBox2.Text + "' and isManagar='"+flag+"';", con);
            

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                Form3 parlor = new Form3(flag);
                parlor.Show();
            }
            else
            {
                MessageBox.Show("No Such Employee Found. Please Signup First");
                Signup.Show();
                Signup.Enabled = true;
                
            }
            con.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var flag="no";
           if(radioButton1.Checked)
           {
               flag="yes";
           }

            SqlConnection con = new SqlConnection(@"Data Source=parmar\mysqlexpress;Initial Catalog=icrecreamparlor;Integrated Security=True");
            con.Open();
            SqlCommand signup = new SqlCommand("insert into users values('"+textBox3.Text+"','"+pass.Text+"','"+richTextBox1 .Text+"','"+flag+"');",con);
            int n = Convert.ToInt32(signup.ExecuteNonQuery());
            if (n == 1)
            {
                MessageBox.Show("SUCCESSFULLY SIGNEDUP, LOGIN PLEASE");
            }
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Signup.Enabled = true;
            Signup.Show();
        }
    }
}
