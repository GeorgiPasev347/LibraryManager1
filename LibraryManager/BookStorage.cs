using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryManager
{
    public partial class BookStorage : Form
    {
        public BookStorage()
        {
            InitializeComponent();
        }
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\Documents\LibraryManagement.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";
        private void LoadData()
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM BookStorage", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            using SqlConnection conn = new SqlConnection(connectionString);
            {
                string query = "INSERT INTO BookStorage (Author,Book,Year,Price) VALUES (@author,@book,@year,@price)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@author", textBox1.Text);
                cmd.Parameters.AddWithValue("@book", textBox2.Text);
                cmd.Parameters.AddWithValue("@year", int.Parse(textBox3.Text));
                cmd.Parameters.AddWithValue("@price", decimal.Parse(textBox4.Text));
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            LoadData();
        }

        private void BookStorage_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {

                textBox1.Text = dataGridView1.SelectedRows[0].Cells["Author"].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells["Book"].Value.ToString();
                textBox3.Text = dataGridView1.SelectedRows[0].Cells["Year"].Value.ToString();
                textBox3.Text = dataGridView1.SelectedRows[0].Cells["Price"].Value.ToString();
            }
            else
            {
                MessageBox.Show(" Изберете ред за редактиране.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string newAuthor = textBox1.Text.Trim();
            string newBook = textBox2.Text.Trim();
            int newYear = int.Parse(textBox3.Text.Trim());
            decimal newPrice = decimal.Parse(textBox4.Text.Trim());

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE BookStorage SET Author=@newAuthor,Year=@newYear,Price=@newPrice WHERE Book=@newbook";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@newAuthor", newAuthor);
                    cmd.Parameters.AddWithValue("@newBook", newBook);
                    cmd.Parameters.AddWithValue("@newYear", newYear);
                    cmd.Parameters.AddWithValue("@newPrice", newPrice);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                            MessageBox.Show("Записът е обновен успешно.");
                        else
                            MessageBox.Show("Не е намерен запис за обновяване.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Грешка при обновяване: " + ex.Message);
                    }
                }
            }

            LoadData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string author = dataGridView1.SelectedRows[0].Cells["Author"].Value.ToString();
                string book = dataGridView1.SelectedRows[0].Cells["Book"].Value.ToString();
                int year = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Year"].Value.ToString());
                decimal price = decimal.Parse(dataGridView1.SelectedRows[0].Cells["Price"].Value.ToString());

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM BookStorage WHERE Author=@author AND Book=@book AND Year=@year AND Price=@price";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@author", author);
                    cmd.Parameters.AddWithValue("@book", book);
                    cmd.Parameters.AddWithValue("@year", year);
                    cmd.Parameters.AddWithValue("@price", price);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                LoadData();
            }
        }
    }
}
