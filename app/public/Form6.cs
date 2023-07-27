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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 a = new Form3();
            this.Hide();
            a.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deletd successffully");

            SqlConnection com = new SqlConnection(@"Data Source=DESKTOP-IRV0O7T\SQLEXPRESS;Initial Catalog=carwash;Integrated Security=True");
            com.Open();

            SqlCommand cmd = new SqlCommand("DELETE from vehicle_detail WHERE vehicle_number=@vnumber", com);

            cmd.Parameters.AddWithValue("@vnumber",System.Data.SqlDbType.VarChar);
            cmd.Parameters["@vnumber"].Value = comboBox1.SelectedItem.ToString();

            cmd.ExecuteNonQuery();
            com.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Updated Successfully");
            
            SqlConnection on = new SqlConnection(@"Data Source=DESKTOP-IRV0O7T\SQLEXPRESS;Initial Catalog=carwash;Integrated Security=True");
            on.Open();

            SqlCommand cmd = new SqlCommand("UPDATE vehicle_detail SET Vehicle_type=@Vtype,Vehicle_model=@Vmodel,Vehicle_milage=@Vmilage WHERE vehicle_number=@Vnumber", on);
            
            cmd.Parameters.AddWithValue("@Vtype", System.Data.SqlDbType.VarChar);
            cmd.Parameters["@Vtype"].Value = textBox2.Text;

            cmd.Parameters.AddWithValue("@Vmodel", System.Data.SqlDbType.VarChar);
            cmd.Parameters["@Vmodel"].Value = textBox3.Text;

            cmd.Parameters.AddWithValue("@Vmilage", System.Data.SqlDbType.VarChar);
            cmd.Parameters["@Vmilage"].Value = textBox4.Text;

            cmd.Parameters.AddWithValue("@Vnumber", System.Data.SqlDbType.VarChar);
            cmd.Parameters["@Vnumber"].Value = comboBox1.SelectedItem.ToString();


            cmd.ExecuteNonQuery();
            on.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conm = new SqlConnection(@"Data Source=DESKTOP-IRV0O7T\SQLEXPRESS;Initial Catalog=carwash;Integrated Security=True");
            conm.Open();

            SqlCommand sqlCommand = new SqlCommand("SELECT vehicle_number FROM vehicle_detail", conm);
            SqlDataReader dataReader;


            dataReader = sqlCommand.ExecuteReader();

            while (dataReader.Read())
            {
                comboBox1.Items.Add(dataReader[0]);
            }

            conm.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
          
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }
    }
}
