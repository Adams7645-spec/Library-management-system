using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Library_management_system
{
    public partial class MainForm : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        private OleDbConnection connection = new OleDbConnection();

        //Constructor
        public MainForm(string UserName)
        {
            InitializeComponent();
            UserNameLbl.Text = UserName;

            random = new Random();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Program Files\Visual studio\Repos\Library-management-system\Database21.accdb;";
        }
        //Methods
        public void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm LoginForm = new LoginForm(null);
            LoginForm.Show();
            this.Hide();
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActiveButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                    TopPanel.BackColor = color;
                    MePanel.BackColor = ThemeColor.ChangeColorBrightness(color, -0.25);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.25);
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in MenuPanel.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(31, 40, 51);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActiveButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.DesktopPanel.Controls.Add(childForm);
            this.DesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            TitleLbl.Text = childForm.Text;
        }

        //Actions
        //MainMenuButtons
        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.DashboardForm(), sender);
        }
        private void StatBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.StatisticForm(), sender);
        }
        private void TakeBookBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.TakeBookForm(), sender);
        }
        private void ReadersBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.ReadersForm(), sender);
        }
        private void StorageBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.StorageForm(), sender);
        }

        //Other



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)   //DashboardBtn
        {
            DashboardBtn.BackColor = Color.FromArgb(0, 51, 73);
        }

        private void ReadersBtn_Leave(object sender, EventArgs e)
        {
            ReadersBtn.BackColor = Color.FromArgb(31, 40, 51);
        }

        private void TakeBookBtn_Leave(object sender, EventArgs e)
        {
            TakeBookBtn.BackColor = Color.FromArgb(31, 40, 51);
        }

        private void TextBox_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void StorageBtn_Leave(object sender, EventArgs e)
        {
            StorageBtn.BackColor = Color.FromArgb(31, 40, 51);
        }

        private void StatBtn_Leave(object sender, EventArgs e)
        {
            StatBtn.BackColor = Color.FromArgb(31, 40, 51);
        }
        private void DashboardBtn_Leave(object sender, EventArgs e)
        {
            DashboardBtn.BackColor = Color.FromArgb(31, 40, 51);
        }
        //Close
        public void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ExitBtn_Leave(object sender, EventArgs e)
        {

        }
        //Profile
        private void ProfilePic_Click(object sender, EventArgs e)
        {

        }

        private void TimeLbl_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeLbl.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void MePanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
