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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            this.Hide();
            a.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection on = new SqlConnection(@"Data Source=DESKTOP-IRV0O7T\SQLEXPRESS;Initial Catalog=carwash;Integrated Security=True");
            on.Open();

            SqlCommand sqlCommand = new SqlCommand("SELECT NIC_Number FROM Customer_detail",on);
            SqlDataReader dataReader;


            dataReader = sqlCommand.ExecuteReader();

            while (dataReader.Read())
            {
                comboBox1.Items.Add(dataReader[0]);
            }

            on.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Updated Successfully");

            SqlConnection on = new SqlConnection(@"Data Source=DESKTOP-IRV0O7T\SQLEXPRESS;Initial Catalog=carwash;Integrated Security=True");
            on.Open();

            SqlCommand cmd = new SqlCommand("UPDATE Customer_detail SET Name=@Name,Address=@Address,Phone_Number=@Phone_number WHERE NIC_Number=@NIC_Number",on);


            cmd.Parameters.AddWithValue("@Name", System.Data.SqlDbType.VarChar);
            cmd.Parameters["@Name"].Value = textBox1.Text;

            cmd.Parameters.AddWithValue("@Address", System.Data.SqlDbType.VarChar);
            cmd.Parameters["@Address"].Value = textBox2.Text;

            cmd.Parameters.AddWithValue("@Phone_number", System.Data.SqlDbType.VarChar);
            cmd.Parameters["@Phone_number"].Value = textBox3.Text;


            cmd.Parameters.AddWithValue("@NIC_Number", System.Data.SqlDbType.VarChar);
            cmd.Parameters["@NIC_Number"].Value = comboBox1.SelectedItem.ToString();
            

            cmd.ExecuteNonQuery();
            on.Close();
        }

   
        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Deleted Successfully");

            SqlConnection on = new SqlConnection(@"Data Source=DESKTOP-IRV0O7T\SQLEXPRESS;Initial Catalog=carwash;Integrated Security=True");
            on.Open();

            SqlCommand cm = new SqlCommand("DELETE FROM Customer_detail WHERE NIC_Number=@NIC_Number", on);


            cm.Parameters.AddWithValue("@NIC_Number", System.Data.SqlDbType.VarChar);
            cm.Parameters["@NIC_Number"].Value = comboBox1.SelectedItem.ToString();

            cm.ExecuteNonQuery();
            on.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}

