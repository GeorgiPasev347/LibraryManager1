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
    public partial class ManagerForm2 : Form
    {
        public ManagerForm2()
        {
            InitializeComponent();
        }
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\PC\\Documents\\LibraryManagement.mdf;Integrated Security=True;Connect Timeout=30";
        private void LoadData()
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Employees", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            {
                string query = "INSERT INTO Employees (FirstName,SecondName,EmployeeID) VALUES (@fsname,@secndname,@empId)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@fsname", textBox1.Text);
                cmd.Parameters.AddWithValue("@secndname", textBox2.Text);
                cmd.Parameters.AddWithValue("@empId", int.Parse(textBox3.Text));
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            LoadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                textBox1.Text = dataGridView1.SelectedRows[0].Cells["FirstName"].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells["SecondName"].Value.ToString();
                textBox3.Text = dataGridView1.SelectedRows[0].Cells["EmployeeID"].Value.ToString();
            }
            else
            {
                MessageBox.Show(" Изберете ред за редактиране.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string newFName = textBox1.Text.Trim();
            string newSecName = textBox2.Text.Trim();
            string empId = textBox3.Text.Trim();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Employees SET FirstName=@newFName, SecondName=@newSecName WHERE EmployeeID=@empId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@newFName", newFName);
                    cmd.Parameters.AddWithValue("@newSecName", newSecName);
                    cmd.Parameters.AddWithValue("@empId", empId);

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

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string fsname = dataGridView1.SelectedRows[0].Cells["FirstName"].Value.ToString();
                string secndname = dataGridView1.SelectedRows[0].Cells["SecondName"].Value.ToString();
                string empId = dataGridView1.SelectedRows[0].Cells["EmployeeID"].Value.ToString();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Employees WHERE FirstName=@fsname AND SecondName=@secndname AND EmployeeID=@empId";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@fsname", fsname);
                    cmd.Parameters.AddWithValue("@secndname", secndname);
                    cmd.Parameters.AddWithValue("@empId", empId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                LoadData();
            }
        }

        private void ManagerForm2_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BookStorage bs1 = new BookStorage();
            bs1.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

