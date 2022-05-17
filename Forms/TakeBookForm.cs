using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Library_management_system.Forms
{
    public partial class TakeBookForm : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public TakeBookForm()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + Path.GetFileName("Database21.accdb") + "'";
            //connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:/Program Files/Visual studio/Repos/LibraryMS/Library-management-system/Database21.accdb;";

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
            catch 
            {
                connection.Close();
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
            catch
            {
                //MessageBox.Show("Error is: " + ex);
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
            catch
            {

            }
        }
        private void ReaderBooks_SelectionChanged(object sender, EventArgs e)
        {
            try
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
            catch //(Exception ex)
            {
                //MessageBox.Show("Error is: " + ex);
            }
        }
        private void BooksData_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                DataGridViewCell Cell = null;
                foreach (DataGridViewCell SelectedCell in BooksData.SelectedCells)
                {
                    Cell = SelectedCell;
                    break;
                }
                if (Cell != null)
                {
                    DataGridViewRow row = Cell.OwningRow;
                    string BookID = row.Cells[0].Value.ToString();

                    PlaceDataTextBox.Text = BookID;
                    LocationTextbox.Text = row.Cells[5].Value.ToString();
                    BookPictureBox.Image = Image.FromFile(LocationTextbox.Text);
                }
            }
            catch
            {

            }
        }
        public void RefreshReadersData()
        {
            Query("select Имя, Фамилия, Отчество, ID from ReadersData", ReadersList);
        }
        public void RefreshBooksData()
        {
            Query("select ID, Название, Жанр, Автор, Издатель, Location from BooksData", BooksData);
        }
        private void ReaderBooksTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Query("select Сделка, Название, Выдано, Сдано from УчетКниг where ID_читателя=" + ReaderBooksTextBox.Text + "", ReaderBooks);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error is: " + ex);
            }
        }
        private void PlaceDataTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Query("select Название, Ряд, Стелаж, Полка from BooksData where ID=" + PlaceDataTextBox.Text + "", PlaceData);
                //LoadPicture();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error is: " + ex);
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
            Query("select Сделка, Название, Выдано, Сдано from УчетКниг where ID_читателя=" + ReaderBooksTextBox.Text + "", ReaderBooks);
        }
        private void ReturnBookBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MotionQuery("delete from УчетКниг where Сделка=" + DealNumberTextBox.Text + "");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error is: " + ex);
            }
            Query("select Сделка, Название, Выдано, Сдано from УчетКниг where ID_читателя=" + ReaderBooksTextBox.Text + "", ReaderBooks);
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
        private void TakeBookForm_Load_1(object sender, EventArgs e)
        {

        }

        private void PlaceData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BooksData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FindBookTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
