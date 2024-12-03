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
        private string NationalIDCardPath;
        private string PassportPath;
        private string ResidenceCardPath;
        private decimal Balance;
        private string CardNumber;
        private string ClientFilePath;
        private string transactionsFilePath;
        private List<string> clientTransactions = new List<string>();
        public ClientDetailForm(string fullName, string fullMotherName, string phoneNumber
                          , string age, string gender, string location, string email, string password,string nationalIDCardPath,
                            string passportPath,string residenceCardPath, decimal balance,string cardnumber,string clientFilePath)
        {
            InitializeComponent();
            FullName = fullName;
            FullMotherName = fullMotherName;
            PhoneNumber = phoneNumber;
            Gender = gender;
            Location = location;
            Email = email;
            Password = password;
            NationalIDCardPath = nationalIDCardPath;
            PassportPath = passportPath;
            ResidenceCardPath = residenceCardPath;
            Age = age;
            Balance = balance;
            CardNumber = cardnumber;
           ClientFilePath = clientFilePath;
            transactionsFilePath = Path.Combine(Application.StartupPath, "ClienteData", $"{FullName}_transactions.txt");

            if (!File.Exists(clientFilePath))
            {
                File.Create(clientFilePath).Close();
            }
            if (!File.Exists(transactionsFilePath))
            {
                File.Create(transactionsFilePath).Close();
            }
        }
        private void AddTransaction(string transactionType, decimal amount)
        {
            try
            {
                string transaction = $"{DateTime.Now};{transactionType};{amount};{Balance}";
                File.AppendAllText(transactionsFilePath, transaction + Environment.NewLine);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding transaction: {ex.Message}", "Error");
            }
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(NationalIDCardPath != "" && File.Exists(NationalIDCardPath))
                {
                    OfficialDocumentsPicBox.Image = null;
                    OfficialDocumentsPicBox.Image = Image.FromFile(NationalIDCardPath);
                }
                else
                {
                    MessageBox.Show("National Card image not found.", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Error");
            }

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (PassportPath != "" && File.Exists(PassportPath))
                {
                    OfficialDocumentsPicBox.Image = null;
                    OfficialDocumentsPicBox.Image = Image.FromFile(PassportPath);
                }
                else
                {
                    MessageBox.Show("Passport Card image not found.", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Error");
            }
            
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (ResidenceCardPath != "" && File.Exists(ResidenceCardPath))
                {
                    OfficialDocumentsPicBox.Image = null;
                    OfficialDocumentsPicBox.Image = Image.FromFile(ResidenceCardPath);
                }
                else
                {
                    MessageBox.Show("Residence Card image not found.", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Error");
            }
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(AmountTextBox.Text, out decimal amount))
            {
                string recipientCardNumber = RecipientTextBox.Text;

                // التحقق من رصيد المرسل
                if (amount > Balance)
                {
                    MessageBox.Show("Insufficient balance", "Error");
                    return;
                }

                // البحث عن المستقبل في ملف العملاء
                bool recipientFound = false;
                string[] clientLines = File.ReadAllLines(ClientFilePath);

                foreach (var line in clientLines)
                {
                    string[] userData = line.Split(';');

                    // افتراض أن رقم البطاقة هو العنصر الأخير قبل المسار
                    if (userData[18] == recipientCardNumber)
                    {
                        // خصم المبلغ من المرسل
                        Balance -= amount;
                        Balancetxt.Text = Balance.ToString();

                        // إضافة المعاملات للمرسل
                        AddTransaction($"Transfer to {recipientCardNumber}", amount);

                        // تحديث رصيد المستقبل (سيحتاج تعديل على ملف العملاء)
                        decimal recipientBalance = Convert.ToDecimal(userData[17]) + amount;

                        // تحديث الملف (هذا مثال بسيط، قد يحتاج لمعالجة أكثر تعقيدًا)
                        UpdateClientBalance(recipientCardNumber, recipientBalance);
                        UpdateClientBalance(CardNumber, Balance);

                        MessageBox.Show("Transfer successful!", "Success");
                        recipientFound = true;
                        break;
                    }
                }

                if (!recipientFound)
                {
                    MessageBox.Show("Recipient card number not found", "Error");
                }
            }
            else
            {
                MessageBox.Show("Invalid amount", "Error");
            }
        }
        private void UpdateClientBalance(string cardNumber, decimal newBalance)
        {
            string[] clientLines = File.ReadAllLines(ClientFilePath);
            for (int i = 0; i < clientLines.Length; i++)
            {
                string[] userData = clientLines[i].Split(';');
                if (userData[18] == cardNumber)
                {
                    // استبدال الرصيد القديم بالجديد
                    userData[17] = newBalance.ToString();
                    clientLines[i] = string.Join(";", userData);
                    break;
                }
            }

            File.WriteAllLines(ClientFilePath, clientLines);
        }
        
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(AmountTextBox.Text, out decimal amount))
            {

                Balance += amount;
                Balancetxt.Text = Balance.ToString();
                AddTransaction("Deposit", amount);
                UpdateClientBalance(CardNumber, Balance);
                MessageBox.Show("Deposit successful!", "Success");
            }
            else
            {
                MessageBox.Show("Invalid amount", "Error");
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(AmountTextBox.Text, out decimal amount))
            {
                if (amount <= Balance)
                {
                    Balance -= amount;
                    Balancetxt.Text = Balance.ToString();
                    AddTransaction("Withdraw", amount);
                    UpdateClientBalance(CardNumber, Balance);
                    MessageBox.Show("Withdrawal successful!", "Success");
                }
                else
                {
                    MessageBox.Show("Insufficient balance", "Error");
                }
            }
            else
            {
                MessageBox.Show("Invalid amount", "Error");
            }
        }
    }
}
