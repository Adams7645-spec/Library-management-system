using System;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Library_management_system
{
    public partial class LoginForm : Form
    {
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database21.accdb;";

        private OleDbConnection myConnection;

        OleDbCommand cmd;
        OleDbDataAdapter da;
        DataTable dt;
        string sql;
        public LoginForm()
        {
            InitializeComponent();
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }
        private int login(string sql)
        {
            int maxrow = 0;
            try
            {
                myConnection.Open();
                cmd = new OleDbCommand();
                da = new OleDbDataAdapter();
                dt = new DataTable();

                cmd.Connection = myConnection;
                cmd.CommandText = sql;

                da.SelectCommand = cmd;
                da.Fill(dt);

                maxrow = dt.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                da.Dispose();
                myConnection.Close();
            }
            return maxrow;
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void LoginCheck()
        {
            int maxrow = 0;
            sql = "Select * From tbluser WHERE Login= '" + LoginTextbox.Text + "' AND Password='" + PasswordTextbox.Text + "'";
            maxrow = login(sql);

            if (maxrow > 0)
            {
                LoginTextbox.Clear();
                PasswordTextbox.Clear();
            }
            else
            {
                MessageBox.Show("Your username and Password is incorrect.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoginStatusCheck()
        {
            string[] LoginList = { "Спинов Андрей", "Елена Леонидовна" };
            string[] PassList = { "Adams7645", "ImHatedByLife727" };

            if (LoginTextbox.Text == LoginList[0] && PasswordTextbox.Text == PassList[0])
            {
                MainForm MainForm = new MainForm();
                MainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!");
                LoginTextbox.Text = "";
                PasswordTextbox.Text = "";
            }
        }
        private void EnterBtn_Click(object sender, EventArgs e)
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
