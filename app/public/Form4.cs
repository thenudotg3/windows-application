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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox2.Text);
            double b = Convert.ToDouble(textBox3.Text);
            double c = Convert.ToDouble(textBox5.Text);
            double f = Convert.ToDouble(textBox8.Text);

            calservice c1 = new calservice();
            double service_fee = c1.tot(a, b, c);
            textBox7.Text = service_fee.ToString();

            double reminderfee = c1.remainder(f);
            textBox9.Text = reminderfee.ToString();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 a = new Form3();
            this.Hide();
            a.ShowDialog();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Close();
            DialogResult res;
            res = MessageBox.Show("Do you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection on = new SqlConnection(@"Data Source=DESKTOP-IRV0O7T\SQLEXPRESS;Initial Catalog=carwash;Integrated Security=True");

            on.Open();
            SqlCommand cmd = new SqlCommand("insert into calculations (Servicetype,Amount,Tprice,Ramount,Balance) values (@Servtype,@Samount,@totalp,@Ramount,@Balance)", on);
            cmd.Parameters.AddWithValue("@Servtype", textBox6.Text);
            cmd.Parameters.AddWithValue("@Servtype", textBox1.Text);
            cmd.Parameters.AddWithValue("@Servtype", textBox4.Text);  //Store services typeint.Parse(textBox2.Text)

            cmd.Parameters.AddWithValue("@samount", int.Parse(textBox2.Text));
            cmd.Parameters.AddWithValue("@samount", int.Parse(textBox3.Text));
            cmd.Parameters.AddWithValue("@samount", int.Parse(textBox5.Text));  //store service amounts

            cmd.Parameters.AddWithValue("@totalp", int.Parse(textBox7.Text));  //store total price
            cmd.Parameters.AddWithValue("@Ramount", int.Parse(textBox8.Text)); //store recieved amount
            cmd.Parameters.AddWithValue("@Balance", int.Parse(textBox9.Text)); //store balance amount

            cmd.ExecuteNonQuery();
            on.Close();

            MessageBox.Show("Successfully Stored ! ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
        }
    }
}
