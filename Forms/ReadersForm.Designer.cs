
namespace Library_management_system.Forms
{
    partial class ReadersForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Surname_textbox = new System.Windows.Forms.TextBox();
            this.SecondName_textbox = new System.Windows.Forms.TextBox();
            this.Name_textbox = new System.Windows.Forms.TextBox();
            this.ReadersList = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BirthdayLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.SecondNameLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.Address_textbox = new System.Windows.Forms.TextBox();
            this.id_textbox = new System.Windows.Forms.TextBox();
            this.Birthday_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Add_btn = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.mainFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ReadersList)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Surname_textbox
            // 
            this.Surname_textbox.Location = new System.Drawing.Point(15, 127);
            this.Surname_textbox.Name = "Surname_textbox";
            this.Surname_textbox.Size = new System.Drawing.Size(191, 23);
            this.Surname_textbox.TabIndex = 0;
            // 
            // SecondName_textbox
            // 
            this.SecondName_textbox.Location = new System.Drawing.Point(15, 171);
            this.SecondName_textbox.Name = "SecondName_textbox";
            this.SecondName_textbox.Size = new System.Drawing.Size(191, 23);
            this.SecondName_textbox.TabIndex = 1;
            // 
            // Name_textbox
            // 
            this.Name_textbox.Location = new System.Drawing.Point(15, 83);
            this.Name_textbox.Name = "Name_textbox";
            this.Name_textbox.Size = new System.Drawing.Size(191, 23);
            this.Name_textbox.TabIndex = 2;
            // 
            // ReadersList
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ReadersList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ReadersList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReadersList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ReadersList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ReadersList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ReadersList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ReadersList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ReadersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ReadersList.DefaultCellStyle = dataGridViewCellStyle3;
            this.ReadersList.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.ReadersList.Location = new System.Drawing.Point(14, 29);
            this.ReadersList.MinimumSize = new System.Drawing.Size(365, 534);
            this.ReadersList.Name = "ReadersList";
            this.ReadersList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ReadersList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ReadersList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ReadersList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.ReadersList.RowTemplate.DividerHeight = 5;
            this.ReadersList.RowTemplate.Height = 25;
            this.ReadersList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ReadersList.Size = new System.Drawing.Size(365, 534);
            this.ReadersList.TabIndex = 4;
            this.ReadersList.SelectionChanged += new System.EventHandler(this.ReadersList_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ReadersList);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 580);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.BirthdayLabel);
            this.panel2.Controls.Add(this.AddressLabel);
            this.panel2.Controls.Add(this.idLabel);
            this.panel2.Controls.Add(this.SecondNameLabel);
            this.panel2.Controls.Add(this.SurnameLabel);
            this.panel2.Controls.Add(this.NameLabel);
            this.panel2.Controls.Add(this.Address_textbox);
            this.panel2.Controls.Add(this.id_textbox);
            this.panel2.Controls.Add(this.Birthday_textbox);
            this.panel2.Controls.Add(this.Surname_textbox);
            this.panel2.Controls.Add(this.Name_textbox);
            this.panel2.Controls.Add(this.SecondName_textbox);
            this.panel2.Location = new System.Drawing.Point(401, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(222, 533);
            this.panel2.TabIndex = 11;
            // 
            // BirthdayLabel
            // 
            this.BirthdayLabel.AutoSize = true;
            this.BirthdayLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BirthdayLabel.Location = new System.Drawing.Point(15, 195);
            this.BirthdayLabel.Name = "BirthdayLabel";
            this.BirthdayLabel.Size = new System.Drawing.Size(93, 15);
            this.BirthdayLabel.TabIndex = 7;
            this.BirthdayLabel.Text = "Дата рождения";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddressLabel.Location = new System.Drawing.Point(15, 239);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(41, 15);
            this.AddressLabel.TabIndex = 6;
            this.AddressLabel.Text = "Адрес";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.idLabel.Location = new System.Drawing.Point(15, 18);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(85, 15);
            this.idLabel.TabIndex = 6;
            this.idLabel.Text = "ID посетителя";
            // 
            // SecondNameLabel
            // 
            this.SecondNameLabel.AutoSize = true;
            this.SecondNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SecondNameLabel.Location = new System.Drawing.Point(15, 153);
            this.SecondNameLabel.Name = "SecondNameLabel";
            this.SecondNameLabel.Size = new System.Drawing.Size(59, 15);
            this.SecondNameLabel.TabIndex = 5;
            this.SecondNameLabel.Text = "Отчество";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SurnameLabel.Location = new System.Drawing.Point(15, 109);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(58, 15);
            this.SurnameLabel.TabIndex = 4;
            this.SurnameLabel.Text = "Фамилия";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameLabel.Location = new System.Drawing.Point(15, 65);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(31, 15);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Имя";
            // 
            // Address_textbox
            // 
            this.Address_textbox.Location = new System.Drawing.Point(15, 257);
            this.Address_textbox.Name = "Address_textbox";
            this.Address_textbox.Size = new System.Drawing.Size(191, 23);
            this.Address_textbox.TabIndex = 0;
            // 
            // id_textbox
            // 
            this.id_textbox.Location = new System.Drawing.Point(15, 36);
            this.id_textbox.Name = "id_textbox";
            this.id_textbox.Size = new System.Drawing.Size(191, 23);
            this.id_textbox.TabIndex = 0;
            // 
            // Birthday_textbox
            // 
            this.Birthday_textbox.Location = new System.Drawing.Point(15, 213);
            this.Birthday_textbox.Name = "Birthday_textbox";
            this.Birthday_textbox.Size = new System.Drawing.Size(191, 23);
            this.Birthday_textbox.TabIndex = 0;
            this.Birthday_textbox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(448, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Вся информация";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(124, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Список посетителей";
            // 
            // Add_btn
            // 
            this.Add_btn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Add_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Add_btn.Location = new System.Drawing.Point(3, 29);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(116, 40);
            this.Add_btn.TabIndex = 6;
            this.Add_btn.Text = "Добавить";
            this.Add_btn.UseVisualStyleBackColor = false;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_edit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_edit.Location = new System.Drawing.Point(3, 119);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(116, 38);
            this.btn_edit.TabIndex = 7;
            this.btn_edit.Text = "Редактировать";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_delete.Location = new System.Drawing.Point(3, 75);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(116, 38);
            this.btn_delete.TabIndex = 8;
            this.btn_delete.Text = "Удалить ";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.btn_delete);
            this.panel3.Controls.Add(this.btn_edit);
            this.panel3.Controls.Add(this.Add_btn);
            this.panel3.Location = new System.Drawing.Point(658, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(122, 580);
            this.panel3.TabIndex = 9;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(22, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Действия";
            // 
            // mainFormBindingSource
            // 
            this.mainFormBindingSource.DataSource = typeof(Library_management_system.MainForm);
            // 
            // ReadersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 604);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "ReadersForm";
            this.Text = "Читатели";
            this.Load += new System.EventHandler(this.ReadersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReadersList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Surname_textbox;
        private System.Windows.Forms.TextBox SecondName_textbox;
        private System.Windows.Forms.TextBox Name_textbox;
        private System.Windows.Forms.DataGridView ReadersList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label BirthdayLabel;
        private System.Windows.Forms.Label SecondNameLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox Birthday_textbox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox Address_textbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox id_textbox;
        private System.Windows.Forms.BindingSource mainFormBindingSource;
    }
}