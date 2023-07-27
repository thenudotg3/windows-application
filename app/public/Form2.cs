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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection on = new SqlConnection(@"Data Source=DESKTOP-IRV0O7T\SQLEXPRESS;Initial Catalog=carwash;Integrated Security=True");
            
            on.Open();
            SqlCommand cmd = new SqlCommand("insert into Customer_detail(Name,NIC_Number,Address,Phone_Number) values (@NAME,@NIC,@ADD,@PNO)", on);
            cmd.Parameters.AddWithValue("@NAME", textBox1.Text);
            cmd.Parameters.AddWithValue("@NIC", int.Parse(textBox2.Text));
            cmd.Parameters.AddWithValue("@PNO", textBox3.Text);
            cmd.Parameters.AddWithValue("@ADD", textBox4.Text);
           

            cmd.ExecuteNonQuery();
            on.Close();

            MessageBox.Show("Successfully Stored ! ");

            Form3 a = new Form3();
            this.Hide();  //close the tab
            a.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox4.Text = "";
            textBox3.Text = "";
            textBox2.Text = "";

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 a = new Form5();
            this.Hide();
            a.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form3 a = new Form3();
            this.Hide();
            a.ShowDialog();
        }
    }
}
