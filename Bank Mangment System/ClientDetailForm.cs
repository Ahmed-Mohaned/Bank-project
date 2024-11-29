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
            label1.Text = FullName;
            label2.Text = FullMotherName;
            label3.Text = PhoneNumber;
            label4.Text = Gender;
            label5.Text = Location;
            label6.Text = Email;
            label7.Text = Password;
            label8.Text = Age;
            label9.Text = Balance.ToString();
            label10.Text = CardNumber;
            
        }
    }
}
