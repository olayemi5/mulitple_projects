using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Marvel1
{
    public partial class Form1 : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"server=localhost;user id=Steve;persistsecurityinfo=False;database=studentinfo");
            con.Open();
            cmd = new SqlCommand("INSERT INTO info(StudentID,Lastname,Firstname,Address,RegNo,CVX_Code) VALUES(@StudentID, @Lastname,@Firstname,@Address,@RegNo,@CVX_Code)", con);
            cmd.Parameters.Add("@StudentID", textBox1.Text);
            cmd.Parameters.Add("@Lastname", textBox2.Text);
            cmd.Parameters.Add("@Firstname", textBox3.Text);
            cmd.Parameters.Add("@Address", comboBox1.SelectedItem.ToString());
            cmd.Parameters.Add("@RegNo", textBox4.Text);
            cmd.Parameters.Add("@CVX_Code", textBox5.Text);
            cmd.ExecuteNonQuery();

        }
    }
}
