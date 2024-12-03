using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;
using AForge.Video;
using AForge.Video.DirectShow;
using Guna.UI2.WinForms;
using System.Runtime.Remoting.Lifetime;


namespace Bank_Mangment_System
{
    public partial class SignUpForm : Form
    {
        AccountInfos Person = new AccountInfos();

        private FilterInfoCollection videoDevices; // قائمة الأجهزة المتاحة
        private VideoCaptureDevice videoSource;    // مصدر الفيديو (الكاميرا)
        private Bitmap capturedImage;

        private string EmployeefolderPath = Path.Combine(Application.StartupPath, "EmployeeData");
        private string EmployeefilePath;
        private string ClientfolderPath = Path.Combine(Application.StartupPath, "ClienteData");
        private string ClientfilePath;
        public SignUpForm()
        {
            InitializeComponent();
            if (!Directory.Exists(EmployeefolderPath))
            {
                Directory.CreateDirectory(EmployeefolderPath);
            }
            EmployeefilePath = Path.Combine(EmployeefolderPath, "EmployeeData.txt");

            if (!Directory.Exists(ClientfolderPath))
            {
                Directory.CreateDirectory(ClientfolderPath);
            }
            ClientfilePath = Path.Combine(ClientfolderPath, "ClientData.txt");
        }

        
        private void SignUpForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;  
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2CustomRadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog Ncard = new OpenFileDialog())
            {
                // إعداد الفلاتر لتحديد الملفات المسموح بها
                Ncard.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                Ncard.Title = "Select an Image";

                // عرض مستعرض الملفات
                if (Ncard.ShowDialog() == DialogResult.OK)
                {
                    // تخزين مسار الملف المختار في المتغير
                    Person.NationalIDCardPath = Ncard.FileName;

                    // عرض المسار في رسالة أو تحديث عنصر واجهة مستخدم
                    MessageBox.Show($"Image Path: {Person.NationalIDCardPath}", "Selected Image");
                }
            }

        }
        
        private void guna2Button7_Click(object sender, EventArgs e)
        {
            Person.Name.First = FirstNametxt.Text;
            Person.Name.Middle = MiddleNametxt.Text;
            Person.Name.Last = LastNametxt.Text;
            Person.Name.Family = FamilyNametxt.Text;
            Person.MotherName.First = MotherFNtxt.Text;
            Person.MotherName.Last = MotherLNtxt.Text;
            Person.PhoneNumber = PhoneNumbertxt.Text;
            Person.Birth.Year = BirthDateDateTimePicker1.Value.Year;
            Person.Birth.Month = BirthDateDateTimePicker1.Value.Month;
            Person.Birth.Day = BirthDateDateTimePicker1.Value.Day;
            if (MaleRbtn.Checked)
                Person.Gender = "Male";
            else
                Person.Gender = "Female";
            Person.Location.District = Districttxt.Text;
            Person.Location.Alley = Alleytxt.Text;
            Person.Location.House = Housetxt.Text;
            Person.Email = Emailtxt.Text;
            Person.Password = Passwordtxt.Text;
            if (EmployeeRbtn.Checked)
                Person.Employee = true;
            Person.Balance = 0;
            Person.CardNumber = Person.GenerateRandomCardNumber(16);

            if (capturedImage == null)
            {
                MessageBox.Show("Please capture an image before signing up.", "Error");
                return;
            }

            // تحديد مسار الحفظ بناءً على نوع المستخدم
            string folderPath = (Person.Employee) ? EmployeefolderPath : ClientfolderPath;
            string filePath = Path.Combine(folderPath, $"{Person.Name.First}_{Person.Name.Last}.jpg");

            try
            {
                // حفظ الصورة
                capturedImage.Save(filePath);

                // تخزين معلومات المسار في الملف النصي المناسب
                string infoFilePath = (Person.Employee) ? EmployeefilePath : ClientfilePath;
               
                using (StreamWriter sw = new StreamWriter(infoFilePath, true))
                {
                    string userData = $"{Person.Name.First};{Person.Name.Middle};{Person.Name.Last};{Person.Name.Family};{Person.MotherName.First};{Person.MotherName.Last};{Person.PhoneNumber};" +
                                      $"{Person.Birth.Day}/{Person.Birth.Month}/{Person.Birth.Year};{Person.Gender};{Person.Location.District};" +
                                      $"{Person.Location.Alley};{Person.Location.House};{Person.Email};{Person.Password};" +
                                      $"{Person.NationalIDCardPath};{Person.PassportPath};{Person.ResidenceCardPath}"+
                                      $"{(Person.Employee ? "Yes" : "No")};{Person.Balance};{Person.CardNumber};{filePath}";

                    sw.WriteLine(userData);
                }

                MessageBox.Show($"User signed up successfully! Image saved at: {filePath}", "Success");
             
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving image or information: {ex.Message}", "Error");
            }

        }

        private void Passportbtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog Passport = new OpenFileDialog())
            {
                // إعداد الفلاتر لتحديد الملفات المسموح بها
                Passport.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                Passport.Title = "Select an Image";

                // عرض مستعرض الملفات
                if (Passport.ShowDialog() == DialogResult.OK)
                {
                    // تخزين مسار الملف المختار في المتغير
                    Person.PassportPath = Passport.FileName;

                    // عرض المسار في رسالة أو تحديث عنصر واجهة مستخدم
                    MessageBox.Show($"Image Path: {Person.PassportPath}", "Selected Image");
                }
            }
        }

        private void housingbtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ResidenceCard = new OpenFileDialog())
            {
                // إعداد الفلاتر لتحديد الملفات المسموح بها
                ResidenceCard.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                ResidenceCard.Title = "Select an Image";

                // عرض مستعرض الملفات
                if (ResidenceCard.ShowDialog() == DialogResult.OK)
                {
                    // تخزين مسار الملف المختار في المتغير
                    Person.ResidenceCardPath = ResidenceCard.FileName;

                    // عرض المسار في رسالة أو تحديث عنصر واجهة مستخدم
                    MessageBox.Show($"Image Path: {Person.ResidenceCardPath}", "Selected Image");
                }
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (capturedImage != null)
            {
                try
                {
                    string filePath = "captured_image.jpg";
                    capturedImage.Save(filePath);
                    MessageBox.Show($"Image saved at: {filePath}", "Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving image: {ex.Message}", "Error");
                }
            }
            else
            {
                MessageBox.Show("No image captured.", "Error");
            }
        }
       
        
        private void guna2Button6_Click(object sender, EventArgs e)
        {
            capturedImage = null;
            Camerapicbox.Image = null;
            videoSource.SignalToStop();
            videoSource.WaitForStop();
            videoSource.Start();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click_1(object sender, EventArgs e)
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoDevices.Count == 0)
            {
                MessageBox.Show("No video devices found.");
                return;
            }

            // اختر الكاميرا الأولى
            videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);

            // قم بتوصيل الكاميرا
            videoSource.NewFrame += new NewFrameEventHandler(videoSource_NewFrame);
            videoSource.Start();
        }
        private void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            // عرض الإطار في صورة PictureBox
            capturedImage = (Bitmap)eventArgs.Frame.Clone();
            Camerapicbox.Image = capturedImage;
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
            }
            // إعادة تعيين الفيديو إذا كان تم تهيئته
            videoSource = null;
        }
    }
}
