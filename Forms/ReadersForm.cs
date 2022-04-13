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
        string EmptyFields = "Обнаружены незаполненные поля!";
        public void Query(string QueryText, DataGridView DatagridName)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = QueryText;
                command.CommandText = query;

                OleDbDataAdapter DataAdapter = new OleDbDataAdapter(command);
                DataTable DataTable = new DataTable();
                DataAdapter.Fill(DataTable);
                DatagridName.DataSource = DataTable;
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }
        public void MotionQuery(string QueryText)
        {
            connection.Open();

            try
            {
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = QueryText;
                command.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show(EmptyFields);
            }
            connection.Close();
            ClearAllTextBox();
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
            Query("select ID, Имя, Фамилия, Отчество, ДеньРождения, Адрес from ReadersData", ReadersList);
        }

        private OleDbConnection connection = new OleDbConnection();
        public ReadersForm()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Program Files\Visual studio\Repos\Library-management-system\Database21.accdb;";
        }
        private void Add_btn_Click(object sender, EventArgs e)
        {
            MotionQuery("insert into ReadersData(Имя, Фамилия, Отчество, ДеньРождения, Адрес) values ('" + Name_textbox.Text + "','" + Surname_textbox.Text + "','" + SecondName_textbox.Text + "','" + Birthday_textbox.Text + "','" + Address_textbox.Text + "')");
            Query("select ID, Имя, Фамилия, Отчество, ДеньРождения, Адрес from ReadersData", ReadersList);
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            MotionQuery("update ReadersData set Имя='" + Name_textbox.Text + "' ,Фамилия='" + Surname_textbox.Text + "' ,Отчество='" + SecondName_textbox.Text + "' ,ДеньРождения='" + Birthday_textbox.Text + "' ,Адрес='" + Address_textbox.Text + "' where ID=" + id_textbox.Text + "");
            Query("select ID, Имя, Фамилия, Отчество, ДеньРождения, Адрес from ReadersData", ReadersList);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            MotionQuery("delete from ReadersData where ID=" + id_textbox.Text + "");
            Query("select ID, Имя, Фамилия, Отчество, ДеньРождения, Адрес from ReadersData", ReadersList);
        }

        private void ReadersList_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                DataGridViewCell Cell = null;
                foreach (DataGridViewCell SelectedCell in ReadersList.SelectedCells)
                {
                    Cell = SelectedCell;
                    break;
                }
                if (Cell != null)
                {
                    DataGridViewRow row = Cell.OwningRow;
                    id_textbox.Text = row.Cells[0].Value.ToString();
                    Name_textbox.Text = row.Cells[1].Value.ToString();
                    Surname_textbox.Text = row.Cells[2].Value.ToString();
                    SecondName_textbox.Text = row.Cells[3].Value.ToString();
                    Birthday_textbox.Text = row.Cells[4].Value.ToString();
                    Address_textbox.Text = row.Cells[5].Value.ToString();
                }
            }
            catch 
            {
                //MessageBox.Show("Все поля не могут быть выбраны!");
            }
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
