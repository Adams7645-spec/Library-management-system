using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace Library_management_system.Forms
{
    public partial class StorageForm : Form
    {
        public StorageForm()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + Path.GetFileName("Database21.accdb") + "'";
            //connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:/Program Files/Visual studio/Repos/LibraryMS/Library-management-system/Database21.accdb;";
        }
        private OleDbConnection connection = new OleDbConnection();

        public void ClearAllTextBox()
        {
            IDTextbox.Clear();
            NameTextbox.Clear();
            GenreTextbox.Clear();
            AuthorTextbox.Clear();
            PublisherTextbox.Clear();
            RowTextbox.Clear();
            ShelvingTextbox.Clear();
            ShelfTextbox.Clear();
            FileNameTextbox.Clear();
            LocationTextbox.Clear();
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
            catch (Exception ex)
            {
                MessageBox.Show("Error is: " + ex);
            }
            connection.Close();
            ClearAllTextBox();
        }
        private void LoadImageButton_Click(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Picture(*.jpg;*.png;*.gif;*.pdf) | *.jpg;*.png;*.gif;*.pdf";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    BookPictureBox.Image = Image.FromFile(ofd.FileName);
                    LocationTextbox.Text = ofd.FileName.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error is: " + ex);
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
                    IDTextbox.Text = row.Cells[0].Value.ToString();
                    NameTextbox.Text = row.Cells[1].Value.ToString();
                    GenreTextbox.Text = row.Cells[2].Value.ToString();
                    AuthorTextbox.Text = row.Cells[3].Value.ToString();
                    PublisherTextbox.Text = row.Cells[4].Value.ToString();
                    RowTextbox.Text = row.Cells[5].Value.ToString();
                    ShelvingTextbox.Text = row.Cells[6].Value.ToString();
                    ShelfTextbox.Text = row.Cells[7].Value.ToString();
                    LocationTextbox.Text = row.Cells[8].Value.ToString();
                    FileNameTextbox.Text = row.Cells[9].Value.ToString();

                    if (LocationTextbox.Text != null)
                    {
                        BookPictureBox.Image = Image.FromFile(LocationTextbox.Text);
                    }
                }
            }
            catch
            {
                //MessageBox.Show("Все поля не могут быть выбраны!");
            }
        }
        private void StorageForm_Load(object sender, EventArgs e)
        {
            Query("select ID, Название, Жанр, Автор, Издатель, Ряд, Стелаж, Полка, Location, Image_name from BooksData", BooksData);
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            MotionQuery("insert into BooksData (Название, Жанр, Автор, Издатель, Ряд, Стелаж, Полка, Location, Image_name) values ('" + NameTextbox.Text + "', '" + GenreTextbox.Text + "', '" + AuthorTextbox.Text + "','" + PublisherTextbox.Text + "','" + RowTextbox.Text + "','" + ShelvingTextbox.Text + "','" + ShelfTextbox.Text + "', '" + LocationTextbox.Text + "', '" + FileNameTextbox.Text + "')");
            Query("select ID, Название, Жанр, Автор, Издатель, Ряд, Стелаж, Полка, Location, Image_name from BooksData", BooksData);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            MotionQuery("delete from BooksData where ID=" + IDTextbox.Text + "");
            Query("select ID, Название, Жанр, Автор, Издатель, Ряд, Стелаж, Полка, Location, Image_name from BooksData", BooksData);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            MotionQuery("update BooksData set Название='" + NameTextbox.Text + "', Жанр='" + GenreTextbox.Text + "', Автор='" + AuthorTextbox.Text + "', Издатель='" + PublisherTextbox.Text + "', Ряд='" + RowTextbox.Text + "', Стелаж='" + ShelvingTextbox.Text + "', Полка='" + ShelfTextbox.Text + "', Location='" + LocationTextbox.Text + "', Image_name='" + FileNameTextbox.Text + "'  where ID=" + IDTextbox.Text + "");
            Query("select ID, Название, Жанр, Автор, Издатель, Ряд, Стелаж, Полка, Location, Image_name from BooksData", BooksData);
        }
        //-------------------------------------------

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BooksData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void BookImagePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BookPictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
