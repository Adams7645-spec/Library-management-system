
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
            this.SettingsBtn = new System.Windows.Forms.Button();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.StatBtn = new System.Windows.Forms.Button();
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
            resources.ApplyResources(this.TopPanel, "TopPanel");
            this.TopPanel.Controls.Add(this.MePanel);
            this.TopPanel.Controls.Add(this.TitleLbl);
            this.TopPanel.Name = "TopPanel";
            // 
            // MePanel
            // 
            this.MePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(54)))), ((int)(((byte)(60)))));
            resources.ApplyResources(this.MePanel, "MePanel");
            this.MePanel.Controls.Add(this.TimeLbl);
            this.MePanel.Controls.Add(this.button8);
            this.MePanel.Controls.Add(this.ProfilePic);
            this.MePanel.Controls.Add(this.UserNameLbl);
            this.MePanel.Name = "MePanel";
            this.MePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MePanel_Paint);
            // 
            // TimeLbl
            // 
            resources.ApplyResources(this.TimeLbl, "TimeLbl");
            this.TimeLbl.ForeColor = System.Drawing.Color.Gainsboro;
            this.TimeLbl.Name = "TimeLbl";
            this.TimeLbl.TextChanged += new System.EventHandler(this.timer1_Tick);
            this.TimeLbl.Click += new System.EventHandler(this.TimeLbl_Click);
            // 
            // button8
            // 
            resources.ApplyResources(this.button8, "button8");
            this.button8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.button8.Name = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // ProfilePic
            // 
            resources.ApplyResources(this.ProfilePic, "ProfilePic");
            this.ProfilePic.Name = "ProfilePic";
            this.ProfilePic.TabStop = false;
            this.ProfilePic.Click += new System.EventHandler(this.ProfilePic_Click);
            // 
            // UserNameLbl
            // 
            resources.ApplyResources(this.UserNameLbl, "UserNameLbl");
            this.UserNameLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserNameLbl.ForeColor = System.Drawing.Color.Gainsboro;
            this.UserNameLbl.Name = "UserNameLbl";
            this.UserNameLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // TitleLbl
            // 
            resources.ApplyResources(this.TitleLbl, "TitleLbl");
            this.TitleLbl.ForeColor = System.Drawing.Color.Gainsboro;
            this.TitleLbl.Name = "TitleLbl";
            // 
            // SettingsBtn
            // 
            resources.ApplyResources(this.SettingsBtn, "SettingsBtn");
            this.SettingsBtn.FlatAppearance.BorderSize = 0;
            this.SettingsBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.UseVisualStyleBackColor = true;
            this.SettingsBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.MenuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuPanel.Controls.Add(this.SettingsBtn);
            this.MenuPanel.Controls.Add(this.StatBtn);
            this.MenuPanel.Controls.Add(this.StorageBtn);
            this.MenuPanel.Controls.Add(this.ReadersBtn);
            this.MenuPanel.Controls.Add(this.TakeBookBtn);
            this.MenuPanel.Controls.Add(this.DashboardBtn);
            resources.ApplyResources(this.MenuPanel, "MenuPanel");
            this.MenuPanel.Name = "MenuPanel";
            // 
            // StatBtn
            // 
            this.StatBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(this.StatBtn, "StatBtn");
            this.StatBtn.FlatAppearance.BorderSize = 0;
            this.StatBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.StatBtn.Name = "StatBtn";
            this.StatBtn.TabStop = false;
            this.StatBtn.UseVisualStyleBackColor = true;
            this.StatBtn.Click += new System.EventHandler(this.StatBtn_Click);
            this.StatBtn.Leave += new System.EventHandler(this.StatBtn_Leave);
            // 
            // StorageBtn
            // 
            this.StorageBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(this.StorageBtn, "StorageBtn");
            this.StorageBtn.FlatAppearance.BorderSize = 0;
            this.StorageBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.StorageBtn.Name = "StorageBtn";
            this.StorageBtn.TabStop = false;
            this.StorageBtn.UseVisualStyleBackColor = true;
            this.StorageBtn.Click += new System.EventHandler(this.StorageBtn_Click);
            this.StorageBtn.Leave += new System.EventHandler(this.StorageBtn_Leave);
            // 
            // ReadersBtn
            // 
            this.ReadersBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(this.ReadersBtn, "ReadersBtn");
            this.ReadersBtn.FlatAppearance.BorderSize = 0;
            this.ReadersBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.ReadersBtn.Name = "ReadersBtn";
            this.ReadersBtn.TabStop = false;
            this.ReadersBtn.UseVisualStyleBackColor = true;
            this.ReadersBtn.Click += new System.EventHandler(this.ReadersBtn_Click);
            this.ReadersBtn.Leave += new System.EventHandler(this.ReadersBtn_Leave);
            // 
            // TakeBookBtn
            // 
            this.TakeBookBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(this.TakeBookBtn, "TakeBookBtn");
            this.TakeBookBtn.FlatAppearance.BorderSize = 0;
            this.TakeBookBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.TakeBookBtn.Name = "TakeBookBtn";
            this.TakeBookBtn.TabStop = false;
            this.TakeBookBtn.UseVisualStyleBackColor = true;
            this.TakeBookBtn.Click += new System.EventHandler(this.TakeBookBtn_Click);
            this.TakeBookBtn.Leave += new System.EventHandler(this.TakeBookBtn_Leave);
            // 
            // DashboardBtn
            // 
            this.DashboardBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(this.DashboardBtn, "DashboardBtn");
            this.DashboardBtn.FlatAppearance.BorderSize = 0;
            this.DashboardBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.DashboardBtn.Name = "DashboardBtn";
            this.DashboardBtn.TabStop = false;
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
            resources.ApplyResources(this.DesktopPanel, "DesktopPanel");
            this.DesktopPanel.Name = "DesktopPanel";
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.Controls.Add(this.DesktopPanel);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.HelpButton = true;
            this.KeyPreview = true;
            this.Name = "MainForm";
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
        private System.Windows.Forms.Button SettingsBtn;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button ReadersBtn;
        private System.Windows.Forms.Button TakeBookBtn;
        private System.Windows.Forms.Button DashboardBtn;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Button StorageBtn;
        private System.Windows.Forms.Button StatBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel MePanel;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.Panel DesktopPanel;
    }
}

