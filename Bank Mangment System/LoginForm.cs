using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Mangment_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("It work");
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0; // إلغاء الحدود
            button1.FlatAppearance.MouseDownBackColor = Color.DarkOrange; // لون عند الضغط
            button1.FlatAppearance.MouseOverBackColor = Color.DarkOrange; // لون عند المرور

            Email_Logintxt.Text = "Enter your email";
            Email_Logintxt.ForeColor = SystemColors.ControlDark;

            Password_Logintxt.Text = "Password";
            Password_Logintxt.ForeColor = SystemColors.ControlDark;

            // ربط الأحداث
            Email_Logintxt.Enter += textBox_Enter;
            Email_Logintxt.Leave += textBox_Leave;

            Password_Logintxt.Enter += textBox_Enter;
            Password_Logintxt.Leave += textBox_Leave;
        }
        private void textBox_Enter(object sender, EventArgs e)//When click on textbox
        {
            TextBox textBox = sender as TextBox;

            if (textBox.Text == "Enter your email" || textBox.Text == "Password")
            {
                textBox.Text = ""; // مسح النص الافتراضي
                textBox.ForeColor = Color.Black; // تغيير لون النص إلى الأسود
            }
        }
        private void textBox_Leave(object sender, EventArgs e)//When leave on textbox
        {
            TextBox textBox = sender as TextBox;

            if (textBox.Text == "")
            {
                // إعادة النص الافتراضي عند الخروج
                if (textBox.Name == "Email_Logintxt")
                {
                    textBox.Text = "Enter your email";
                }
                else if (textBox.Name == "Password_Logintxt")
                {
                    textBox.Text = "Password";
                }

                textBox.ForeColor = SystemColors.ControlDark; // تغيير لون النص إلى لون توضيحي
            }
        }
        private void Email_Logintxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
