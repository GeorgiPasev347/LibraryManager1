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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\Documents\LibraryManagement.mdf;Integrated Security=True;Connect Timeout=30";
        private void button1_Click(object sender, EventArgs e)
        {
            UserForm2 uf2= new UserForm2();
            uf2.Show();

            string username = textBox1.Text;
            int password = int.Parse(textBox2.Text);
            SqlConnection conn = new SqlConnection(connectionString);
            string query = "INSERT INTO UserLoginTable (Username,Password) VALUES (@username,@password)";
            SqlCommand cmd = new SqlCommand(query, conn);
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Потребителските данни бяха записани успешно!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Грешка:" + ex.Message);
                }
            }
        }
    }
}

