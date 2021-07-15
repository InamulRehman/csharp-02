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

namespace Project1_CollegeMgmtSystem
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
     
        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Inam UL rehman\Documents\Collegedb.mdf;Integrated Security=True;Connect Timeout=30");
        private void UserForm_Load_1(object sender, EventArgs e)
        {
            populate();
        }
        private void populate()
        {
            con.Open();
            string query = " select * from usertbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            gunaDataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
                try
            {
                if (UidTb.Text == "" || UnameTb.Text == "" || UpassTb.Text == "")
                {
                    MessageBox.Show("missing information");
                }
                else
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into usertbl values(" + UidTb.Text + ", '" + UnameTb.Text + "', '" + UpassTb.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("user added successfully");
                    con.Close();

                }
            }
            catch
            {
                MessageBox.Show("something went wrong");
            }
        }
    }
}
