using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Library_management_system.Forms
{
    public partial class TakeBookForm : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public TakeBookForm()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Program Files\Visual studio\Repos\Library-management-system\Database21.accdb;";

            RefreshReadersData();
            RefreshBooksData();
        }
    private void TakeBookForm_Load(object sender, EventArgs e)
        {

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
                    ReaderBooksTextBox.Text = row.Cells[3].Value.ToString();
                }
            }
            catch 
            {
                //MessageBox.Show("Все поля не могут быть выбраны!");
            }
        }
        public void RefreshReadersData()
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select Имя, Фамилия, Отчество, ID from ReadersData";
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
        private void ReaderBooksTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ReaderBooksTextBox.Text != null)
            {
                try
                {
                    connection.Close();
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    string query = "select Название, ДатаВыдачи from КнигиЧитателя where ID=" + ReaderBooksTextBox.Text + "";
                    command.CommandText = query;

                    OleDbDataAdapter DataAdapter = new OleDbDataAdapter(command);
                    DataTable DataTable = new DataTable();
                    DataAdapter.Fill(DataTable);
                    ReaderBooks.DataSource = DataTable;
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                }
            }
        }
        public void RefreshBooksData()
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select ID, Название, Жанр, Автор, Издатель, Расположение from BooksData";
                command.CommandText = query;

                OleDbDataAdapter DataAdapter = new OleDbDataAdapter(command);
                DataTable DataTable = new DataTable();
                DataAdapter.Fill(DataTable);
                BooksData.DataSource = DataTable;
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void ReaderBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
