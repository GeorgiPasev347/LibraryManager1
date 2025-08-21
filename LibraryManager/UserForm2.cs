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
namespace LibraryManager
{
    public partial class UserForm2 : Form
    {
        public UserForm2()
        {
            InitializeComponent();
        }

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\Documents\LibraryManagement.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True";
        private void button1_Click(object sender, EventArgs e)
        {
            string avtor = comboBox1.Text.ToString();
            string book = comboBox2.Text.ToString();
            string names = textBox1.Text;
            string adress = textBox2.Text;
            int phone = int.Parse(textBox3.Text);
            SqlConnection conn = new SqlConnection(connectionString);
            string query = "INSERT INTO UserOrder (Name,Adress,Phone,Author,Book) VALUES (@name,@adress,@phone,@author,@book)";
            SqlCommand cmd = new SqlCommand(query, conn);
            {
                cmd.Parameters.AddWithValue("@name",names);
                cmd.Parameters.AddWithValue("@adress",adress);
                cmd.Parameters.AddWithValue("@phone",phone);
                cmd.Parameters.AddWithValue("@author",avtor);
                cmd.Parameters.AddWithValue("@book",book);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Успешно направена поръчка!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Грешка "+ex.Message);
                }
            }
        }
    }
}
