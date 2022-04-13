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
                MessageBox.Show("Error is: " + ex);
            }
        }
        public void MotionQuery(string QueryText)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = QueryText;
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error is: " + ex);
            }
        }
        public void ReadersList_SelectionChanged(object sender, EventArgs e)
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
            catch (Exception ex)
            {
                MessageBox.Show("Error is: " + ex);
            }
        }
        private void ReaderBooks_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell Cell = null;
            foreach (DataGridViewCell SelectedCell in ReaderBooks.SelectedCells)
            {
                Cell = SelectedCell;
                break;
            }
            if (Cell != null)
            {
                DataGridViewRow row = Cell.OwningRow;
                string TitleCell = row.Cells[0].Value.ToString();

                DealNumberTextBox.Text = TitleCell;
            }
        }
        public void RefreshReadersData()
        {
            Query("select Имя, Фамилия, Отчество, ID from ReadersData", ReadersList);
        }
        public void RefreshBooksData()
        {
            Query("select ID, Название, Жанр, Автор, Издатель, Расположение from BooksData", BooksData);
        }
        private void ReaderBooksTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Query("select Сделка, Название, Выдано, Сдано from УчетКниг where ID_читателя=" + ReaderBooksTextBox.Text + "", ReaderBooks);
            }
            catch
            {

            }
        }
        private void TakeBookBtn_Click(object sender, EventArgs e)
        {
            //Переменные и т.д.
            DataGridViewCell Cell = null;
            DateTime Taked = DateOfBookTaked.Value.Date.Add(DateOfBookTaked.Value.TimeOfDay);
            DateTime Returned = DateOfBookReturned.Value.Date.Add(DateOfBookReturned.Value.TimeOfDay);

            TakedTextBox.Text = Taked.ToString();
            ReturnedTextBox.Text = Returned.ToString();

            //получаю данные ReadersList
            foreach (DataGridViewCell SelectedCell in ReadersList.SelectedCells)
            {
                Cell = SelectedCell;
                break;
            }
            if (Cell != null)
            {
                DataGridViewRow row = Cell.OwningRow;
                string IDCell = row.Cells[3].Value.ToString();
                string SurnameCell = row.Cells[1].Value.ToString();

                IDCellTextBox.Text = IDCell;
                SurnameCellTextBox.Text = SurnameCell;
            }
            //получаю данные BooksData
            foreach (DataGridViewCell SelectedCell in BooksData.SelectedCells)
            {
                Cell = SelectedCell;
                break;
            }
            if (Cell != null)
            {
                DataGridViewRow row = Cell.OwningRow;
                string TitleCell = row.Cells[1].Value.ToString();

                TitleCellTextBox.Text = TitleCell;
            }
            MotionQuery("insert into УчетКниг(ID_читателя, Название, Фамилия, Выдано, Сдано) values ('" + IDCellTextBox.Text + "','" + TitleCellTextBox.Text + "','" + SurnameCellTextBox.Text + "','" + TakedTextBox.Text + "', '" + ReturnedTextBox.Text + "')");
            Query("select Название, Выдано, Сдано from УчетКниг where ID_читателя=" + ReaderBooksTextBox.Text + "", ReaderBooks);
        }
        private void ReturnBookBtn_Click(object sender, EventArgs e)
        {
            MotionQuery("delete from УчетКниг where Сделка=" + DealNumberTextBox.Text + "");
            Query("select Название, Выдано, Сдано from УчетКниг where ID_читателя=" + ReaderBooksTextBox.Text + "", ReaderBooks);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void ReaderBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BookFindBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
