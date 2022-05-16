
namespace Library_management_system
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.MePanel = new System.Windows.Forms.Panel();
            this.TimeLbl = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.ProfilePic = new System.Windows.Forms.PictureBox();
            this.UserNameLbl = new System.Windows.Forms.Label();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.StorageBtn = new System.Windows.Forms.Button();
            this.ReadersBtn = new System.Windows.Forms.Button();
            this.TakeBookBtn = new System.Windows.Forms.Button();
            this.DashboardBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.DesktopPanel = new System.Windows.Forms.Panel();
            this.TopPanel.SuspendLayout();
            this.MePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePic)).BeginInit();
            this.MenuPanel.SuspendLayout();
            this.DesktopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(54)))), ((int)(((byte)(60)))));
            this.TopPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TopPanel.Controls.Add(this.MePanel);
            this.TopPanel.Controls.Add(this.TitleLbl);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1008, 86);
            this.TopPanel.TabIndex = 3;
            this.TopPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TopPanel_Paint);
            // 
            // MePanel
            // 
            this.MePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(54)))), ((int)(((byte)(60)))));
            this.MePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MePanel.Controls.Add(this.TimeLbl);
            this.MePanel.Controls.Add(this.button8);
            this.MePanel.Controls.Add(this.ProfilePic);
            this.MePanel.Controls.Add(this.UserNameLbl);
            this.MePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MePanel.Location = new System.Drawing.Point(0, 0);
            this.MePanel.Name = "MePanel";
            this.MePanel.Size = new System.Drawing.Size(200, 86);
            this.MePanel.TabIndex = 10;
            this.MePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MePanel_Paint);
            // 
            // TimeLbl
            // 
            this.TimeLbl.AutoSize = true;
            this.TimeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimeLbl.ForeColor = System.Drawing.Color.Gainsboro;
            this.TimeLbl.Location = new System.Drawing.Point(79, 56);
            this.TimeLbl.Name = "TimeLbl";
            this.TimeLbl.Size = new System.Drawing.Size(44, 18);
            this.TimeLbl.TabIndex = 2;
            this.TimeLbl.Text = "20:49";
            this.TimeLbl.TextChanged += new System.EventHandler(this.timer1_Tick);
            this.TimeLbl.Click += new System.EventHandler(this.TimeLbl_Click);
            // 
            // button8
            // 
            this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.button8.Location = new System.Drawing.Point(873, 13);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(19, 24);
            this.button8.TabIndex = 5;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // ProfilePic
            // 
            this.ProfilePic.Image = ((System.Drawing.Image)(resources.GetObject("ProfilePic.Image")));
            this.ProfilePic.Location = new System.Drawing.Point(0, 13);
            this.ProfilePic.Name = "ProfilePic";
            this.ProfilePic.Size = new System.Drawing.Size(74, 64);
            this.ProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProfilePic.TabIndex = 0;
            this.ProfilePic.TabStop = false;
            this.ProfilePic.Click += new System.EventHandler(this.ProfilePic_Click);
            // 
            // UserNameLbl
            // 
            this.UserNameLbl.AutoSize = true;
            this.UserNameLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserNameLbl.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserNameLbl.ForeColor = System.Drawing.Color.Gainsboro;
            this.UserNameLbl.Location = new System.Drawing.Point(79, 13);
            this.UserNameLbl.Name = "UserNameLbl";
            this.UserNameLbl.Size = new System.Drawing.Size(58, 28);
            this.UserNameLbl.TabIndex = 1;
            this.UserNameLbl.Text = "User";
            this.UserNameLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // TitleLbl
            // 
            this.TitleLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Sitka Text", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitleLbl.ForeColor = System.Drawing.Color.Gainsboro;
            this.TitleLbl.Location = new System.Drawing.Point(520, 27);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(111, 32);
            this.TitleLbl.TabIndex = 0;
            this.TitleLbl.Text = "Заметки";
            this.TitleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.MenuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuPanel.Controls.Add(this.StorageBtn);
            this.MenuPanel.Controls.Add(this.ReadersBtn);
            this.MenuPanel.Controls.Add(this.TakeBookBtn);
            this.MenuPanel.Controls.Add(this.DashboardBtn);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 86);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(200, 643);
            this.MenuPanel.TabIndex = 1;
            this.MenuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuPanel_Paint);
            // 
            // StorageBtn
            // 
            this.StorageBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.StorageBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.StorageBtn.FlatAppearance.BorderSize = 0;
            this.StorageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StorageBtn.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StorageBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.StorageBtn.Image = ((System.Drawing.Image)(resources.GetObject("StorageBtn.Image")));
            this.StorageBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StorageBtn.Location = new System.Drawing.Point(1, 194);
            this.StorageBtn.Name = "StorageBtn";
            this.StorageBtn.Padding = new System.Windows.Forms.Padding(1);
            this.StorageBtn.Size = new System.Drawing.Size(198, 65);
            this.StorageBtn.TabIndex = 10;
            this.StorageBtn.TabStop = false;
            this.StorageBtn.Text = "Хранилище";
            this.StorageBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StorageBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.StorageBtn.UseVisualStyleBackColor = true;
            this.StorageBtn.Click += new System.EventHandler(this.StorageBtn_Click);
            this.StorageBtn.Leave += new System.EventHandler(this.StorageBtn_Leave);
            // 
            // ReadersBtn
            // 
            this.ReadersBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ReadersBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ReadersBtn.FlatAppearance.BorderSize = 0;
            this.ReadersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReadersBtn.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ReadersBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.ReadersBtn.Image = ((System.Drawing.Image)(resources.GetObject("ReadersBtn.Image")));
            this.ReadersBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReadersBtn.Location = new System.Drawing.Point(1, 129);
            this.ReadersBtn.Name = "ReadersBtn";
            this.ReadersBtn.Padding = new System.Windows.Forms.Padding(1);
            this.ReadersBtn.Size = new System.Drawing.Size(198, 65);
            this.ReadersBtn.TabIndex = 1;
            this.ReadersBtn.TabStop = false;
            this.ReadersBtn.Text = "Читатели";
            this.ReadersBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReadersBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ReadersBtn.UseVisualStyleBackColor = true;
            this.ReadersBtn.Click += new System.EventHandler(this.ReadersBtn_Click);
            this.ReadersBtn.Leave += new System.EventHandler(this.ReadersBtn_Leave);
            // 
            // TakeBookBtn
            // 
            this.TakeBookBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.TakeBookBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TakeBookBtn.FlatAppearance.BorderSize = 0;
            this.TakeBookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TakeBookBtn.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TakeBookBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.TakeBookBtn.Image = ((System.Drawing.Image)(resources.GetObject("TakeBookBtn.Image")));
            this.TakeBookBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TakeBookBtn.Location = new System.Drawing.Point(1, 64);
            this.TakeBookBtn.Name = "TakeBookBtn";
            this.TakeBookBtn.Padding = new System.Windows.Forms.Padding(1);
            this.TakeBookBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TakeBookBtn.Size = new System.Drawing.Size(198, 65);
            this.TakeBookBtn.TabIndex = 1;
            this.TakeBookBtn.TabStop = false;
            this.TakeBookBtn.Text = "Выдача";
            this.TakeBookBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TakeBookBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TakeBookBtn.UseVisualStyleBackColor = true;
            this.TakeBookBtn.Click += new System.EventHandler(this.TakeBookBtn_Click);
            this.TakeBookBtn.Leave += new System.EventHandler(this.TakeBookBtn_Leave);
            // 
            // DashboardBtn
            // 
            this.DashboardBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.DashboardBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DashboardBtn.FlatAppearance.BorderSize = 0;
            this.DashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashboardBtn.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DashboardBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.DashboardBtn.Image = ((System.Drawing.Image)(resources.GetObject("DashboardBtn.Image")));
            this.DashboardBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashboardBtn.Location = new System.Drawing.Point(1, -1);
            this.DashboardBtn.Name = "DashboardBtn";
            this.DashboardBtn.Padding = new System.Windows.Forms.Padding(1);
            this.DashboardBtn.Size = new System.Drawing.Size(198, 65);
            this.DashboardBtn.TabIndex = 4;
            this.DashboardBtn.TabStop = false;
            this.DashboardBtn.Text = "Заметки";
            this.DashboardBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashboardBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DashboardBtn.UseVisualStyleBackColor = true;
            this.DashboardBtn.Click += new System.EventHandler(this.DashboardBtn_Click);
            this.DashboardBtn.Leave += new System.EventHandler(this.DashboardBtn_Leave);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DesktopPanel
            // 
            this.DesktopPanel.Controls.Add(this.MenuPanel);
            this.DesktopPanel.Controls.Add(this.TopPanel);
            this.DesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DesktopPanel.Location = new System.Drawing.Point(0, 0);
            this.DesktopPanel.Name = "DesktopPanel";
            this.DesktopPanel.Size = new System.Drawing.Size(1008, 729);
            this.DesktopPanel.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.DesktopPanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Система управления библиотекой";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.MePanel.ResumeLayout(false);
            this.MePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePic)).EndInit();
            this.MenuPanel.ResumeLayout(false);
            this.DesktopPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox ProfilePic;
        private System.Windows.Forms.Label UserNameLbl;
        private System.Windows.Forms.Label TimeLbl;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button ReadersBtn;
        private System.Windows.Forms.Button TakeBookBtn;
        private System.Windows.Forms.Button DashboardBtn;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Button StorageBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel MePanel;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.Panel DesktopPanel;
    }
}

