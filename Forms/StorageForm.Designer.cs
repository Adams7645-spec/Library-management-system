
namespace Library_management_system.Forms
{
    partial class StorageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StorageForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BooksData = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.MainInfoPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.IDTextbox = new System.Windows.Forms.TextBox();
            this.GenreTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PublisherTextbox = new System.Windows.Forms.TextBox();
            this.AuthorTextbox = new System.Windows.Forms.TextBox();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.PlacementPanel = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ShelfTextbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ShelvingTextbox = new System.Windows.Forms.TextBox();
            this.RowTextbox = new System.Windows.Forms.TextBox();
            this.BookImagePanel = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.LocationTextbox = new System.Windows.Forms.TextBox();
            this.FileNameTextbox = new System.Windows.Forms.TextBox();
            this.BookPictureBox = new System.Windows.Forms.PictureBox();
            this.LoadImageButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BooksData)).BeginInit();
            this.panel3.SuspendLayout();
            this.MainInfoPanel.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.PlacementPanel.SuspendLayout();
            this.BookImagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BooksData);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 215);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(374, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 21);
            this.label1.TabIndex = 40;
            this.label1.Text = "Список книг";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BooksData
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BooksData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.BooksData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BooksData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BooksData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BooksData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BooksData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BooksData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.BooksData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BooksData.DefaultCellStyle = dataGridViewCellStyle3;
            this.BooksData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.BooksData.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.BooksData.Location = new System.Drawing.Point(3, 24);
            this.BooksData.Name = "BooksData";
            this.BooksData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BooksData.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.BooksData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BooksData.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.BooksData.RowTemplate.DividerHeight = 5;
            this.BooksData.RowTemplate.Height = 25;
            this.BooksData.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BooksData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BooksData.Size = new System.Drawing.Size(762, 188);
            this.BooksData.TabIndex = 39;
            this.BooksData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BooksData_CellContentClick);
            this.BooksData.SelectionChanged += new System.EventHandler(this.BooksData_SelectionChanged);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.MainInfoPanel);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.PlacementPanel);
            this.panel3.Controls.Add(this.BookImagePanel);
            this.panel3.Location = new System.Drawing.Point(12, 233);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(768, 359);
            this.panel3.TabIndex = 1;
            // 
            // MainInfoPanel
            // 
            this.MainInfoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainInfoPanel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.MainInfoPanel.Controls.Add(this.label6);
            this.MainInfoPanel.Controls.Add(this.label7);
            this.MainInfoPanel.Controls.Add(this.label12);
            this.MainInfoPanel.Controls.Add(this.label5);
            this.MainInfoPanel.Controls.Add(this.label11);
            this.MainInfoPanel.Controls.Add(this.IDTextbox);
            this.MainInfoPanel.Controls.Add(this.GenreTextbox);
            this.MainInfoPanel.Controls.Add(this.label2);
            this.MainInfoPanel.Controls.Add(this.PublisherTextbox);
            this.MainInfoPanel.Controls.Add(this.AuthorTextbox);
            this.MainInfoPanel.Controls.Add(this.NameTextbox);
            this.MainInfoPanel.Location = new System.Drawing.Point(214, 3);
            this.MainInfoPanel.Name = "MainInfoPanel";
            this.MainInfoPanel.Size = new System.Drawing.Size(441, 195);
            this.MainInfoPanel.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(21, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 41;
            this.label6.Text = "Название";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(21, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 41;
            this.label7.Text = "Жанр";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(21, 124);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 17);
            this.label12.TabIndex = 41;
            this.label12.Text = "Автор";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(21, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 17);
            this.label5.TabIndex = 41;
            this.label5.Text = "ID";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(21, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 17);
            this.label11.TabIndex = 41;
            this.label11.Text = "Издатель";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // IDTextbox
            // 
            this.IDTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IDTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IDTextbox.Enabled = false;
            this.IDTextbox.Location = new System.Drawing.Point(160, 38);
            this.IDTextbox.Multiline = true;
            this.IDTextbox.Name = "IDTextbox";
            this.IDTextbox.Size = new System.Drawing.Size(264, 23);
            this.IDTextbox.TabIndex = 0;
            this.IDTextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // GenreTextbox
            // 
            this.GenreTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GenreTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GenreTextbox.Location = new System.Drawing.Point(160, 96);
            this.GenreTextbox.Name = "GenreTextbox";
            this.GenreTextbox.Size = new System.Drawing.Size(264, 23);
            this.GenreTextbox.TabIndex = 0;
            this.GenreTextbox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(130, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 21);
            this.label2.TabIndex = 40;
            this.label2.Text = "Основная информация";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // PublisherTextbox
            // 
            this.PublisherTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PublisherTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PublisherTextbox.Location = new System.Drawing.Point(160, 153);
            this.PublisherTextbox.Name = "PublisherTextbox";
            this.PublisherTextbox.Size = new System.Drawing.Size(264, 23);
            this.PublisherTextbox.TabIndex = 0;
            this.PublisherTextbox.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // AuthorTextbox
            // 
            this.AuthorTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AuthorTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AuthorTextbox.Location = new System.Drawing.Point(160, 124);
            this.AuthorTextbox.Name = "AuthorTextbox";
            this.AuthorTextbox.Size = new System.Drawing.Size(264, 23);
            this.AuthorTextbox.TabIndex = 0;
            this.AuthorTextbox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // NameTextbox
            // 
            this.NameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTextbox.Location = new System.Drawing.Point(160, 67);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(264, 23);
            this.NameTextbox.TabIndex = 0;
            this.NameTextbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel7.Controls.Add(this.pictureBox3);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.DeleteButton);
            this.panel7.Controls.Add(this.EditButton);
            this.panel7.Controls.Add(this.AddButton);
            this.panel7.Location = new System.Drawing.Point(661, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(104, 353);
            this.panel7.TabIndex = 43;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(14, 33);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(77, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "Действия";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteButton.Location = new System.Drawing.Point(3, 252);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(98, 46);
            this.DeleteButton.TabIndex = 16;
            this.DeleteButton.Text = "Удалить ";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EditButton.Location = new System.Drawing.Point(3, 304);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(98, 46);
            this.EditButton.TabIndex = 15;
            this.EditButton.Text = "Редактировать";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddButton.Location = new System.Drawing.Point(3, 200);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(98, 46);
            this.AddButton.TabIndex = 14;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // PlacementPanel
            // 
            this.PlacementPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlacementPanel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.PlacementPanel.Controls.Add(this.label10);
            this.PlacementPanel.Controls.Add(this.label4);
            this.PlacementPanel.Controls.Add(this.label8);
            this.PlacementPanel.Controls.Add(this.ShelfTextbox);
            this.PlacementPanel.Controls.Add(this.label9);
            this.PlacementPanel.Controls.Add(this.ShelvingTextbox);
            this.PlacementPanel.Controls.Add(this.RowTextbox);
            this.PlacementPanel.Location = new System.Drawing.Point(214, 204);
            this.PlacementPanel.Name = "PlacementPanel";
            this.PlacementPanel.Size = new System.Drawing.Size(441, 152);
            this.PlacementPanel.TabIndex = 43;
            this.PlacementPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(21, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 17);
            this.label10.TabIndex = 41;
            this.label10.Text = "Полка";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(160, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 21);
            this.label4.TabIndex = 40;
            this.label4.Text = "Расположение";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(21, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 17);
            this.label8.TabIndex = 41;
            this.label8.Text = "Ряд";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // ShelfTextbox
            // 
            this.ShelfTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShelfTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ShelfTextbox.Location = new System.Drawing.Point(160, 105);
            this.ShelfTextbox.Name = "ShelfTextbox";
            this.ShelfTextbox.Size = new System.Drawing.Size(264, 23);
            this.ShelfTextbox.TabIndex = 0;
            this.ShelfTextbox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(21, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 17);
            this.label9.TabIndex = 41;
            this.label9.Text = "Стелаж";
            this.label9.Click += new System.EventHandler(this.label9_Click_1);
            // 
            // ShelvingTextbox
            // 
            this.ShelvingTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShelvingTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ShelvingTextbox.Location = new System.Drawing.Point(160, 76);
            this.ShelvingTextbox.Name = "ShelvingTextbox";
            this.ShelvingTextbox.Size = new System.Drawing.Size(264, 23);
            this.ShelvingTextbox.TabIndex = 0;
            this.ShelvingTextbox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // RowTextbox
            // 
            this.RowTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RowTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RowTextbox.Location = new System.Drawing.Point(160, 47);
            this.RowTextbox.Name = "RowTextbox";
            this.RowTextbox.Size = new System.Drawing.Size(264, 23);
            this.RowTextbox.TabIndex = 0;
            this.RowTextbox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // BookImagePanel
            // 
            this.BookImagePanel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BookImagePanel.Controls.Add(this.label14);
            this.BookImagePanel.Controls.Add(this.label13);
            this.BookImagePanel.Controls.Add(this.LocationTextbox);
            this.BookImagePanel.Controls.Add(this.FileNameTextbox);
            this.BookImagePanel.Controls.Add(this.BookPictureBox);
            this.BookImagePanel.Controls.Add(this.LoadImageButton);
            this.BookImagePanel.Location = new System.Drawing.Point(3, 3);
            this.BookImagePanel.Name = "BookImagePanel";
            this.BookImagePanel.Size = new System.Drawing.Size(205, 353);
            this.BookImagePanel.TabIndex = 43;
            this.BookImagePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.BookImagePanel_Paint);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(20, 215);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 17);
            this.label14.TabIndex = 44;
            this.label14.Text = "Расположение";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(19, 165);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(135, 17);
            this.label13.TabIndex = 44;
            this.label13.Text = "Название файла";
            // 
            // LocationTextbox
            // 
            this.LocationTextbox.Location = new System.Drawing.Point(20, 233);
            this.LocationTextbox.Name = "LocationTextbox";
            this.LocationTextbox.Size = new System.Drawing.Size(161, 23);
            this.LocationTextbox.TabIndex = 43;
            // 
            // FileNameTextbox
            // 
            this.FileNameTextbox.Location = new System.Drawing.Point(20, 187);
            this.FileNameTextbox.Name = "FileNameTextbox";
            this.FileNameTextbox.Size = new System.Drawing.Size(161, 23);
            this.FileNameTextbox.TabIndex = 43;
            // 
            // BookPictureBox
            // 
            this.BookPictureBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BookPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BookPictureBox.Location = new System.Drawing.Point(20, 19);
            this.BookPictureBox.Name = "BookPictureBox";
            this.BookPictureBox.Size = new System.Drawing.Size(161, 138);
            this.BookPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BookPictureBox.TabIndex = 41;
            this.BookPictureBox.TabStop = false;
            this.BookPictureBox.Click += new System.EventHandler(this.BookPictureBox_Click);
            // 
            // LoadImageButton
            // 
            this.LoadImageButton.AutoEllipsis = true;
            this.LoadImageButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.LoadImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoadImageButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoadImageButton.Image = ((System.Drawing.Image)(resources.GetObject("LoadImageButton.Image")));
            this.LoadImageButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoadImageButton.Location = new System.Drawing.Point(20, 262);
            this.LoadImageButton.Name = "LoadImageButton";
            this.LoadImageButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LoadImageButton.Size = new System.Drawing.Size(161, 67);
            this.LoadImageButton.TabIndex = 42;
            this.LoadImageButton.Text = "Загрузить изображение";
            this.LoadImageButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LoadImageButton.UseVisualStyleBackColor = false;
            this.LoadImageButton.Click += new System.EventHandler(this.LoadImageButton_Click);
            // 
            // StorageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 604);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "StorageForm";
            this.Text = "Хранилище";
            this.Load += new System.EventHandler(this.StorageForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BooksData)).EndInit();
            this.panel3.ResumeLayout(false);
            this.MainInfoPanel.ResumeLayout(false);
            this.MainInfoPanel.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.PlacementPanel.ResumeLayout(false);
            this.PlacementPanel.PerformLayout();
            this.BookImagePanel.ResumeLayout(false);
            this.BookImagePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView BooksData;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox PublisherTextbox;
        private System.Windows.Forms.TextBox GenreTextbox;
        private System.Windows.Forms.TextBox AuthorTextbox;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.TextBox IDTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox BookPictureBox;
        private System.Windows.Forms.Panel BookImagePanel;
        private System.Windows.Forms.Button LoadImageButton;
        private System.Windows.Forms.Panel MainInfoPanel;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Panel PlacementPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ShelvingTextbox;
        private System.Windows.Forms.TextBox RowTextbox;
        private System.Windows.Forms.TextBox ShelfTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox LocationTextbox;
        private System.Windows.Forms.TextBox FileNameTextbox;
    }
}