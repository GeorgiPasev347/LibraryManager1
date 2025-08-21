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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace LibraryManager
{
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\Documents\LibraryManagement.mdf;Integrated Security=True;Connect Timeout=30";
        private void button1_Click(object sender, EventArgs e)
        {
            //admin forma
            ManagerForm2 mng2 = new ManagerForm2();
            mng2.ShowDialog();

            string adminname = textBox1.Text;
            int password = int.Parse(textBox2.Text);
            

            SqlConnection conn = new SqlConnection(connectionString);
            {
                string query = "INSERT INTO AdminLoginTable (AdminName,Password) VALUES (@adminName,@password)";
                SqlCommand cmd = new SqlCommand(query, conn);
                {
                    cmd.Parameters.AddWithValue("@adminName", adminname);
                    cmd.Parameters.AddWithValue("@password", password);
                    


                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Данните са записани!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Грешка " + ex.Message);

                    }

                }
            }
        }
    }
}
