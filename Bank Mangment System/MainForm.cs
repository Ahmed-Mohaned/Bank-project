using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Bank_Mangment_System
{
    public partial class MainForm : Form
    {
        private string ClientFilePath = Path.Combine(Application.StartupPath, "ClienteData", "ClientData.txt");
        bool SideBarExpand;
        private string FullName;
        private string FullMotherName;
        private string PhoneNumber;
        private string Gender;
        private string Location;
        private string Email;
        private string Password;
        private string Age;
        private decimal Balance;
        private string CardNumber;
        private string NationalIDCardPath;
        private string PassportPath;
        private string ResidenceCardPath;


        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            SideBar.MinimumSize = new Size(44, 1050);
            


        }

        private void CloseMainFormBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinMainFormBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void SideBarTimer_Tick(object sender, EventArgs e)
        {
            // Set The minimize and maximize of sidebar;
            if(SideBarExpand)
            {
                // if side bar is expand then minimize;
                SideBar.Width -= 10;
                if(SideBar.Width == SideBar.MinimumSize.Width)
                {
                    SideBarExpand = false;
                    SideBarTimer.Stop();
                }
            }
            else
            {
                SideBar.Width += 10;
                if(SideBar.Width == SideBar.MaximumSize.Width)
                {
                    SideBarExpand = true;
                    SideBarTimer.Stop();
                }
            }
        }

        private void Menulabel_Click(object sender, EventArgs e)
        {

        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            SideBarTimer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void SetClientData(string[] userData)
        {
            FullName = userData[0] + " " + userData[1] + " " + userData[2] + " " + userData[3];
            FullMotherName = userData[4] + " " + userData[5];
            PhoneNumber = userData[6];
            Age = userData[7];
            Gender = userData[8];
            Location = "District: " + userData[9] + "/" + "Alley: " + userData[10] + "/" + "House: " + userData[11];
            Email = userData[12];
            Password = userData[13];
            NationalIDCardPath = userData[14];
            PassportPath = userData[15];
            ResidenceCardPath = userData[16];
            Balance = Convert.ToDecimal(userData[17]);
            CardNumber = userData[18];
        }
        private void Searchbtn_Click(object sender, EventArgs e)
        {
            //string searchQuery = Searchtxtbox.Text.Trim();
            //LoadClientData(searchQuery);
            try
            {
                if (NamesdataGridView.Columns.Count == 0)
                {
                    NamesdataGridView.Columns.Add("First name", "First name");
                    NamesdataGridView.Columns.Add("Last name", "Last name");
                }

                string searchName = Searchtxtbox.Text.Trim(); // استخدام Trim() لإزالة المسافات الزائدة
                using (StreamReader sr = new StreamReader(ClientFilePath))
                {
                    string line;
                    NamesdataGridView.Rows.Clear(); // تفريغ الصفوف السابقة
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] userData = line.Split(';');
                        string FirstName = userData[0];
                        string LastName = userData[1];

                        // البحث في الاسم الأول والأخير
                        if (FirstName.Contains(searchName) || LastName.Contains(searchName))
                        {
                            SetClientData(userData);

                            NamesdataGridView.Rows.Add(FirstName, LastName);
                        }
                    }
                }

                if (NamesdataGridView.Rows.Count == 0)
                {
                    MessageBox.Show("No matching records found.", "Search Results");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}", "Error");
            }
        }

      


        private void NamesdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string firstName = NamesdataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                string lastName = NamesdataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();

                // البحث عن المستخدم المختار لفتح تفاصيله
                using (StreamReader sr = new StreamReader(ClientFilePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] userData = line.Split(';');
                        if (userData[0] == firstName && userData[1] == lastName)
                        {
                            SetClientData(userData);

                            OpenClientDetailForm(FullName);
                            break;
                        }
                    }
                }
            }
        }

        private void OpenClientDetailForm(string fullName)
        {
            // البحث عن بيانات الشخص المحدد في الملف
            using (StreamReader sr = new StreamReader(ClientFilePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] userData = line.Split(';');
                    string currentFullName = userData[0] + " " + userData[1] + " " + userData[2] + " " + userData[3];

                    if (currentFullName == fullName)
                    {
                        // تمرير البيانات الصحيحة للشخص المحدد
                        var clientDetailForm = new ClientDetailForm(
                            currentFullName,                     // FullName
                            userData[4] + " " + userData[5],     // FullMotherName
                            userData[6],                         // PhoneNumber
                            userData[7],                         // Age
                            userData[8],                         // Gender
                            "District: " + userData[9] + "/" + "Alley: " + userData[10] + "/" + "House: " + userData[11], // Location
                            userData[12],                        // Email
                            userData[13],                        // Password
                            userData[14],                        // NationalIDCardPath
                            userData[15],                        // PassportPath
                            userData[16],                        // ResidenceCardPath
                            Convert.ToDecimal(userData[17]),     // Balance
                            userData[18],                        // CardNumber
                            ClientFilePath
                        );
                        clientDetailForm.Show();
                        return; // للخروج من الدالة بعد العثور على الشخص
                    }
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
