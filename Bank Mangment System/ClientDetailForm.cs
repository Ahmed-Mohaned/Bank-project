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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Bank_Mangment_System
{
    public partial class ClientDetailForm : Form
    {
        bool SideBarExpand;
        private string FullName;
        private string FullMotherName;
        private string PhoneNumber;
        private string Gender;
        private string Location;
        private string Email;
        private string Password;
        private string Age;
        private long Balance;
        private string CardNumber;
        private string clientFilePath;
        private List<string> clientTransactions = new List<string>();
        public ClientDetailForm(string fullName, string fullMotherName, string phoneNumber
                          , string age, string gender, string location, string email, string password,long balance,string cardnumber)
        {
            InitializeComponent();
            FullName = fullName;
            FullMotherName = fullMotherName;
            PhoneNumber = phoneNumber;
            Gender = gender;
            Location = location;
            Email = email;
            Password = password;
            Age = age;
            Balance = balance;
            CardNumber = cardnumber;
            clientFilePath = Path.Combine(Application.StartupPath, "ClienteData", $"{FullName}_data.txt"); 
        }

        private void ClientDetailForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            SideBar.MinimumSize = new Size(44, 1050);
            FullNametxt.Text = FullName;
            MotherNametxt.Text = FullMotherName;
            PhoneNumbertxt.Text = PhoneNumber;
            Gendertxt.Text = Gender;
            Locationtxt.Text = Location;
            Emailtxt.Text = Email;
            Agetxt.Text = Age;
           Balancetxt.Text = Balance.ToString();
            CardNumbertxt.Text = CardNumber;



        }

        private void CloseMainFormBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void MinMainFormBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void MinSignupBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseSignupBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void Locationtxt_TextChanged(object sender, EventArgs e)
        {

        }
        private void SideBarTimer_Tick(object sender, EventArgs e)
        {
            // Set The minimize and maximize of sidebar;
            if (SideBarExpand)
            {
                // if side bar is expand then minimize;
                SideBar.Width -= 10;
                if (SideBar.Width == SideBar.MinimumSize.Width)
                {
                    SideBarExpand = false;
                    SideBarTimer.Stop();
                }
            }
            else
            {
                SideBar.Width += 10;
                if (SideBar.Width == SideBar.MaximumSize.Width)
                {
                    SideBarExpand = true;
                    SideBarTimer.Stop();
                }
            }
        }
        private void MenuButton_Click(object sender, EventArgs e)
        {
            SideBarTimer.Start();
        }
    }
}
