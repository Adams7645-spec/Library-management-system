using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace Library_management_system
{
    public partial class LoginForm : Form
    {
        public string UserName
        {
            get { return LoginTextbox.Text; }
        }
        private OleDbConnection connection = new OleDbConnection();
        public LoginForm(string UserName)
        {
            InitializeComponent();
            try
            {
                connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + Path.GetFileName("Database21.accdb") + "'";
                //connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:/Program Files/Visual studio/Repos/LibraryMS/Library-management-system/Database21.accdb;";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }

        }
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void LoginCheck()
        {
            connection.Open();

            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "select * from LoginData where Login='" + LoginTextbox.Text + "'and Password='" + PasswordTextbox.Text + "'";
            string LoginedUserName = LoginTextbox.Text;
            OleDbDataReader reader = command.ExecuteReader();

            int count = 0;

            while (reader.Read())
            {
                count++;
            }

            if (count == 1)
            {
                MainForm MainForm = new MainForm(LoginTextbox.Text);
                MainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!");
                LoginTextbox.Text = "";
                PasswordTextbox.Text = "";
            }

            connection.Close();
        }
        public static string LoginedUserName { get; set; }
        
        public void EnterBtn_Click(object sender, EventArgs e)
        {
            LoginCheck();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
