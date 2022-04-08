using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Library_management_system.Forms
{
    public partial class ReadersForm : Form
    {
        public void RefreshData()
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select ID, Имя, Фамилия, Отчество, ДеньРождения, Адрес from ReadersData";
                command.CommandText = query;

                OleDbDataAdapter DataAdapter = new OleDbDataAdapter(command);
                DataTable DataTable = new DataTable();
                DataAdapter.Fill(DataTable);
                ReadersList.DataSource = DataTable;
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }
        public void ClearAllTextBox()
        {
            id_textbox.Text = "";
            Name_textbox.Text = "";
            Surname_textbox.Text = "";
            SecondName_textbox.Text = "";
            Birthday_textbox.Text = "";
            Address_textbox.Text = "";
        }
        private void ReadersForm_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private OleDbConnection connection = new OleDbConnection();
        public ReadersForm()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Program Files\Visual studio\Repos\Library-management-system\Database21.accdb;";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            connection.Open();

            try
            {
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "insert into ReadersData(Имя, Фамилия, Отчество, ДеньРождения, Адрес) values ('" + Name_textbox.Text + "','" + Surname_textbox.Text + "','" + SecondName_textbox.Text + "','" + Birthday_textbox.Text + "','" + Address_textbox.Text + "')";
                command.ExecuteNonQuery();
                MessageBox.Show("Данные сохранены.");

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
            connection.Close();
            ClearAllTextBox();
            RefreshData();
        }

        private void id_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            connection.Open();

            try
            {
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "update ReadersData set Имя='" + Name_textbox.Text + "' ,Фамилия='" + Surname_textbox.Text + "' ,Отчество='" + SecondName_textbox.Text + "' ,ДеньРождения='" + Birthday_textbox.Text + "' ,Адрес='" + Address_textbox.Text + "' where ID=" + id_textbox.Text + "";
                command.CommandText = query;
                //MessageBox.Show(query);

                command.ExecuteNonQuery();
                MessageBox.Show("Данные изменены.");

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
            connection.Close();
            ClearAllTextBox();
            RefreshData();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            connection.Open();

            try
            {
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "delete from ReadersData where ID=" + id_textbox.Text + "";
                command.CommandText = query;
                //MessageBox.Show(query);

                command.ExecuteNonQuery();
                MessageBox.Show("Данные удалены.");

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
            connection.Close();
            ClearAllTextBox();
            RefreshData();
        }
    }
}
