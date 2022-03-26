using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.OleDb;

namespace Library_management_system
{
    public partial class LoginForm : Form
    {
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database21.accdb;";

        private OleDbConnection myConnection;
        private object oAccess;

        public LoginForm()
        {
            InitializeComponent();
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            {
                string[] LoginList = {"Спинов Андрей", "Елена Леонидовна"};
                string[] PassList = { "Adams7645", "ImHatedByLife727" };

                //LoginCheck = LoginList.IndexOf(grid, searchedObject);

                if (LoginTextbox.Text == LoginList[0] && PasswordTextbox.Text == PassList[0])
                {
                    MainForm MainForm = new MainForm();
                    MainForm.Show();
                    this.Hide();
                }
                else
                {
                    LoginTextbox.Text = "";
                    PasswordTextbox.Text = "";
                }
            }
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
