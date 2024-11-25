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

namespace Bank_Mangment_System
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
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
        
      /*  private void CopyImageToAppFolder(string imagePath)
        {
            string appFolder = Path.Combine(Application.StartupPath, "Images");
            if (!Directory.Exists(appFolder))
            {
                Directory.CreateDirectory(appFolder);
            }

            string imageName = Path.GetFileName(imagePath);
            string destinationPath = Path.Combine(appFolder, imageName);

            File.Copy(imagePath, destinationPath, overwrite: true);
            MessageBox.Show($"Image copied to: {destinationPath}");
        }*/

        private void guna2Button1_Click(object sender, EventArgs e)
        {
          /*  using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg;*.jpeg;*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedImagePath = openFileDialog.FileName;

                    // عرض المسار باستخدام رسالة بدلاً من TextBox
                    MessageBox.Show($"Selected image path: {selectedImagePath}");

                    // نسخ الصورة إلى مجلد التطبيق
                    CopyImageToAppFolder(selectedImagePath);
                    DisplayImageInPictureBox(selectedImagePath);

                }
            }*/
        }
        /*private void DisplayImageInPictureBox(string imagePath)
        {
            if (File.Exists(imagePath))
            {
                pictureBox1.Image = Image.FromFile(imagePath); // تحميل الصورة إلى PictureBox
            }
            else
            {
                MessageBox.Show("The selected image could not be found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/

    }
}
