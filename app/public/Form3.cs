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

namespace final_One
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-IRV0O7T\SQLEXPRESS;Initial Catalog=carwash;Integrated Security=True");
           
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into vehicle_detail (vehicle_number,Vehicle_type,Vehicle_model,Vehicle_milage) values (@vnum,@vtype,@vmodel,@vmilage)" , con);
            cmd.Parameters.AddWithValue("@vnum" , textBox1.Text);
            cmd.Parameters.AddWithValue("@vtype" , textBox2.Text);
            cmd.Parameters.AddWithValue("@vmodel" , textBox3.Text);
            cmd.Parameters.AddWithValue("@vmilage" , textBox4.Text);

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Saved Successfully");


            Form4 a = new Form4();
            this.Hide();
            a.ShowDialog();


        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 a = new Form6();
            this.Hide();
            a.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            this.Hide();
            a.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 a = new Form4();
            this.Hide();
            a.ShowDialog();
        }
    }
}
