namespace LibraryManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManagerForm mng1 = new ManagerForm();
            mng1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserForm uf1= new UserForm();
            uf1.Show();
        }
    }
}
