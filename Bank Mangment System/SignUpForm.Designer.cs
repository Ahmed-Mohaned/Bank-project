namespace Bank_Mangment_System
{
    partial class SignUpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.MinSignupBtn = new System.Windows.Forms.Button();
            this.CloseSignupBtn = new System.Windows.Forms.Button();
            this.FirstNametxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.MiddleNametxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.LastNametxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.FamilyNametxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.MotherFNtxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.MotherLNtxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.PhoneNumbertxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.PesonalInfosGB = new System.Windows.Forms.GroupBox();
            this.BirthDateDateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.FemaleLabel = new System.Windows.Forms.Label();
            this.MaleLabel = new System.Windows.Forms.Label();
            this.BirthLabel = new System.Windows.Forms.Label();
            this.FemaleRbtn = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.MaleRbtn = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.EmployeeRbtn = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.LocationandAccountinfosGB = new System.Windows.Forms.GroupBox();
            this.housingbtn = new Guna.UI2.WinForms.Guna2Button();
            this.Passportbtn = new Guna.UI2.WinForms.Guna2Button();
            this.Ncardbtn = new Guna.UI2.WinForms.Guna2Button();
            this.Alleytxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.Districttxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.Emailtxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.Housetxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.Passwordtxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.Capturedpicbox = new System.Windows.Forms.PictureBox();
            this.Camerapicbox = new System.Windows.Forms.PictureBox();
            this.Signupbtn = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.PesonalInfosGB.SuspendLayout();
            this.LocationandAccountinfosGB.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Capturedpicbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Camerapicbox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.MinSignupBtn);
            this.panel1.Controls.Add(this.CloseSignupBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 55);
            this.panel1.TabIndex = 3;
            // 
            // MinSignupBtn
            // 
            this.MinSignupBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.MinSignupBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinSignupBtn.ForeColor = System.Drawing.Color.White;
            this.MinSignupBtn.Location = new System.Drawing.Point(1830, 9);
            this.MinSignupBtn.Name = "MinSignupBtn";
            this.MinSignupBtn.Size = new System.Drawing.Size(36, 43);
            this.MinSignupBtn.TabIndex = 2;
            this.MinSignupBtn.Text = "-";
            this.MinSignupBtn.UseVisualStyleBackColor = false;
            this.MinSignupBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // CloseSignupBtn
            // 
            this.CloseSignupBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.CloseSignupBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseSignupBtn.ForeColor = System.Drawing.Color.White;
            this.CloseSignupBtn.Location = new System.Drawing.Point(1872, 9);
            this.CloseSignupBtn.Name = "CloseSignupBtn";
            this.CloseSignupBtn.Size = new System.Drawing.Size(36, 43);
            this.CloseSignupBtn.TabIndex = 0;
            this.CloseSignupBtn.Text = "X";
            this.CloseSignupBtn.UseVisualStyleBackColor = false;
            this.CloseSignupBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // FirstNametxt
            // 
            this.FirstNametxt.BorderRadius = 13;
            this.FirstNametxt.BorderThickness = 0;
            this.FirstNametxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FirstNametxt.DefaultText = "First Name";
            this.FirstNametxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FirstNametxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FirstNametxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FirstNametxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FirstNametxt.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.FirstNametxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FirstNametxt.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.FirstNametxt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FirstNametxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FirstNametxt.Location = new System.Drawing.Point(24, 50);
            this.FirstNametxt.Margin = new System.Windows.Forms.Padding(5);
            this.FirstNametxt.Name = "FirstNametxt";
            this.FirstNametxt.PasswordChar = '\0';
            this.FirstNametxt.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.FirstNametxt.PlaceholderText = "";
            this.FirstNametxt.SelectedText = "";
            this.FirstNametxt.Size = new System.Drawing.Size(343, 55);
            this.FirstNametxt.TabIndex = 5;
            // 
            // MiddleNametxt
            // 
            this.MiddleNametxt.BorderRadius = 13;
            this.MiddleNametxt.BorderThickness = 0;
            this.MiddleNametxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MiddleNametxt.DefaultText = "Middle Name";
            this.MiddleNametxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MiddleNametxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MiddleNametxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MiddleNametxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MiddleNametxt.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.MiddleNametxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MiddleNametxt.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.MiddleNametxt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MiddleNametxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MiddleNametxt.Location = new System.Drawing.Point(24, 153);
            this.MiddleNametxt.Margin = new System.Windows.Forms.Padding(5);
            this.MiddleNametxt.Name = "MiddleNametxt";
            this.MiddleNametxt.PasswordChar = '\0';
            this.MiddleNametxt.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.MiddleNametxt.PlaceholderText = "";
            this.MiddleNametxt.SelectedText = "";
            this.MiddleNametxt.Size = new System.Drawing.Size(343, 55);
            this.MiddleNametxt.TabIndex = 7;
            // 
            // LastNametxt
            // 
            this.LastNametxt.BorderRadius = 13;
            this.LastNametxt.BorderThickness = 0;
            this.LastNametxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LastNametxt.DefaultText = "Last Name";
            this.LastNametxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.LastNametxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.LastNametxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LastNametxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LastNametxt.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.LastNametxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LastNametxt.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.LastNametxt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LastNametxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LastNametxt.Location = new System.Drawing.Point(24, 258);
            this.LastNametxt.Margin = new System.Windows.Forms.Padding(5);
            this.LastNametxt.Name = "LastNametxt";
            this.LastNametxt.PasswordChar = '\0';
            this.LastNametxt.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.LastNametxt.PlaceholderText = "";
            this.LastNametxt.SelectedText = "";
            this.LastNametxt.Size = new System.Drawing.Size(343, 55);
            this.LastNametxt.TabIndex = 9;
            // 
            // FamilyNametxt
            // 
            this.FamilyNametxt.BorderRadius = 13;
            this.FamilyNametxt.BorderThickness = 0;
            this.FamilyNametxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FamilyNametxt.DefaultText = "Family Name";
            this.FamilyNametxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FamilyNametxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FamilyNametxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FamilyNametxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FamilyNametxt.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.FamilyNametxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FamilyNametxt.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.FamilyNametxt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FamilyNametxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FamilyNametxt.Location = new System.Drawing.Point(24, 369);
            this.FamilyNametxt.Margin = new System.Windows.Forms.Padding(5);
            this.FamilyNametxt.Name = "FamilyNametxt";
            this.FamilyNametxt.PasswordChar = '\0';
            this.FamilyNametxt.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.FamilyNametxt.PlaceholderText = "";
            this.FamilyNametxt.SelectedText = "";
            this.FamilyNametxt.Size = new System.Drawing.Size(343, 55);
            this.FamilyNametxt.TabIndex = 10;
            // 
            // MotherFNtxt
            // 
            this.MotherFNtxt.BorderRadius = 13;
            this.MotherFNtxt.BorderThickness = 0;
            this.MotherFNtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MotherFNtxt.DefaultText = "Mother`s First Name";
            this.MotherFNtxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MotherFNtxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MotherFNtxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MotherFNtxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MotherFNtxt.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.MotherFNtxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MotherFNtxt.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.MotherFNtxt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MotherFNtxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MotherFNtxt.Location = new System.Drawing.Point(24, 466);
            this.MotherFNtxt.Margin = new System.Windows.Forms.Padding(5);
            this.MotherFNtxt.Name = "MotherFNtxt";
            this.MotherFNtxt.PasswordChar = '\0';
            this.MotherFNtxt.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.MotherFNtxt.PlaceholderText = "";
            this.MotherFNtxt.SelectedText = "";
            this.MotherFNtxt.Size = new System.Drawing.Size(343, 55);
            this.MotherFNtxt.TabIndex = 11;
            // 
            // MotherLNtxt
            // 
            this.MotherLNtxt.BorderRadius = 13;
            this.MotherLNtxt.BorderThickness = 0;
            this.MotherLNtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MotherLNtxt.DefaultText = "Mother`s Last Name";
            this.MotherLNtxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MotherLNtxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MotherLNtxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MotherLNtxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MotherLNtxt.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.MotherLNtxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MotherLNtxt.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.MotherLNtxt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MotherLNtxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MotherLNtxt.Location = new System.Drawing.Point(24, 568);
            this.MotherLNtxt.Margin = new System.Windows.Forms.Padding(5);
            this.MotherLNtxt.Name = "MotherLNtxt";
            this.MotherLNtxt.PasswordChar = '\0';
            this.MotherLNtxt.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.MotherLNtxt.PlaceholderText = "";
            this.MotherLNtxt.SelectedText = "";
            this.MotherLNtxt.Size = new System.Drawing.Size(343, 55);
            this.MotherLNtxt.TabIndex = 12;
            // 
            // PhoneNumbertxt
            // 
            this.PhoneNumbertxt.BorderRadius = 13;
            this.PhoneNumbertxt.BorderThickness = 0;
            this.PhoneNumbertxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PhoneNumbertxt.DefaultText = "Phone Number";
            this.PhoneNumbertxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PhoneNumbertxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PhoneNumbertxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PhoneNumbertxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PhoneNumbertxt.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.PhoneNumbertxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PhoneNumbertxt.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.PhoneNumbertxt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.PhoneNumbertxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PhoneNumbertxt.Location = new System.Drawing.Point(24, 671);
            this.PhoneNumbertxt.Margin = new System.Windows.Forms.Padding(5);
            this.PhoneNumbertxt.Name = "PhoneNumbertxt";
            this.PhoneNumbertxt.PasswordChar = '\0';
            this.PhoneNumbertxt.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.PhoneNumbertxt.PlaceholderText = "";
            this.PhoneNumbertxt.SelectedText = "";
            this.PhoneNumbertxt.Size = new System.Drawing.Size(343, 55);
            this.PhoneNumbertxt.TabIndex = 13;
            // 
            // PesonalInfosGB
            // 
            this.PesonalInfosGB.Controls.Add(this.BirthDateDateTimePicker1);
            this.PesonalInfosGB.Controls.Add(this.FemaleLabel);
            this.PesonalInfosGB.Controls.Add(this.MaleLabel);
            this.PesonalInfosGB.Controls.Add(this.BirthLabel);
            this.PesonalInfosGB.Controls.Add(this.FemaleRbtn);
            this.PesonalInfosGB.Controls.Add(this.PhoneNumbertxt);
            this.PesonalInfosGB.Controls.Add(this.MaleRbtn);
            this.PesonalInfosGB.Controls.Add(this.MiddleNametxt);
            this.PesonalInfosGB.Controls.Add(this.FirstNametxt);
            this.PesonalInfosGB.Controls.Add(this.MotherLNtxt);
            this.PesonalInfosGB.Controls.Add(this.LastNametxt);
            this.PesonalInfosGB.Controls.Add(this.MotherFNtxt);
            this.PesonalInfosGB.Controls.Add(this.FamilyNametxt);
            this.PesonalInfosGB.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PesonalInfosGB.ForeColor = System.Drawing.Color.SeaGreen;
            this.PesonalInfosGB.Location = new System.Drawing.Point(12, 72);
            this.PesonalInfosGB.Name = "PesonalInfosGB";
            this.PesonalInfosGB.Size = new System.Drawing.Size(424, 978);
            this.PesonalInfosGB.TabIndex = 14;
            this.PesonalInfosGB.TabStop = false;
            this.PesonalInfosGB.Text = "Personal Information";
            // 
            // BirthDateDateTimePicker1
            // 
            this.BirthDateDateTimePicker1.BackColor = System.Drawing.Color.Transparent;
            this.BirthDateDateTimePicker1.BorderRadius = 13;
            this.BirthDateDateTimePicker1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.BirthDateDateTimePicker1.Checked = true;
            this.BirthDateDateTimePicker1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.BirthDateDateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.BirthDateDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.BirthDateDateTimePicker1.Location = new System.Drawing.Point(24, 821);
            this.BirthDateDateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.BirthDateDateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.BirthDateDateTimePicker1.Name = "BirthDateDateTimePicker1";
            this.BirthDateDateTimePicker1.Size = new System.Drawing.Size(343, 36);
            this.BirthDateDateTimePicker1.TabIndex = 19;
            this.BirthDateDateTimePicker1.Value = new System.DateTime(2024, 11, 23, 10, 43, 31, 902);
            // 
            // FemaleLabel
            // 
            this.FemaleLabel.AutoSize = true;
            this.FemaleLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FemaleLabel.Location = new System.Drawing.Point(207, 918);
            this.FemaleLabel.Name = "FemaleLabel";
            this.FemaleLabel.Size = new System.Drawing.Size(83, 23);
            this.FemaleLabel.TabIndex = 17;
            this.FemaleLabel.Text = "Female";
            // 
            // MaleLabel
            // 
            this.MaleLabel.AutoSize = true;
            this.MaleLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaleLabel.Location = new System.Drawing.Point(83, 918);
            this.MaleLabel.Name = "MaleLabel";
            this.MaleLabel.Size = new System.Drawing.Size(59, 23);
            this.MaleLabel.TabIndex = 16;
            this.MaleLabel.Text = "Male";
            // 
            // BirthLabel
            // 
            this.BirthLabel.AutoSize = true;
            this.BirthLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthLabel.Location = new System.Drawing.Point(19, 788);
            this.BirthLabel.Name = "BirthLabel";
            this.BirthLabel.Size = new System.Drawing.Size(123, 28);
            this.BirthLabel.TabIndex = 18;
            this.BirthLabel.Text = "Birth Date";
            // 
            // FemaleRbtn
            // 
            this.FemaleRbtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.FemaleRbtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FemaleRbtn.CheckedState.BorderThickness = 0;
            this.FemaleRbtn.CheckedState.FillColor = System.Drawing.Color.SeaGreen;
            this.FemaleRbtn.CheckedState.InnerColor = System.Drawing.Color.MediumSeaGreen;
            this.FemaleRbtn.Location = new System.Drawing.Point(148, 907);
            this.FemaleRbtn.Name = "FemaleRbtn";
            this.FemaleRbtn.Size = new System.Drawing.Size(53, 41);
            this.FemaleRbtn.TabIndex = 15;
            this.FemaleRbtn.Text = "guna2CustomRadioButton2";
            this.FemaleRbtn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.FemaleRbtn.UncheckedState.BorderThickness = 2;
            this.FemaleRbtn.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.FemaleRbtn.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.FemaleRbtn.CheckedChanged += new System.EventHandler(this.guna2CustomRadioButton2_CheckedChanged);
            // 
            // MaleRbtn
            // 
            this.MaleRbtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.MaleRbtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MaleRbtn.CheckedState.BorderThickness = 0;
            this.MaleRbtn.CheckedState.FillColor = System.Drawing.Color.SeaGreen;
            this.MaleRbtn.CheckedState.InnerColor = System.Drawing.Color.MediumSeaGreen;
            this.MaleRbtn.Location = new System.Drawing.Point(24, 907);
            this.MaleRbtn.Name = "MaleRbtn";
            this.MaleRbtn.Size = new System.Drawing.Size(53, 41);
            this.MaleRbtn.TabIndex = 14;
            this.MaleRbtn.Text = "guna2CustomRadioButton1";
            this.MaleRbtn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.MaleRbtn.UncheckedState.BorderThickness = 2;
            this.MaleRbtn.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.MaleRbtn.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 918);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "Employee";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // EmployeeRbtn
            // 
            this.EmployeeRbtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.EmployeeRbtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmployeeRbtn.CheckedState.BorderThickness = 0;
            this.EmployeeRbtn.CheckedState.FillColor = System.Drawing.Color.SeaGreen;
            this.EmployeeRbtn.CheckedState.InnerColor = System.Drawing.Color.MediumSeaGreen;
            this.EmployeeRbtn.Location = new System.Drawing.Point(24, 907);
            this.EmployeeRbtn.Name = "EmployeeRbtn";
            this.EmployeeRbtn.Size = new System.Drawing.Size(53, 41);
            this.EmployeeRbtn.TabIndex = 19;
            this.EmployeeRbtn.Text = "guna2CustomRadioButton2";
            this.EmployeeRbtn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.EmployeeRbtn.UncheckedState.BorderThickness = 2;
            this.EmployeeRbtn.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.EmployeeRbtn.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // LocationandAccountinfosGB
            // 
            this.LocationandAccountinfosGB.Controls.Add(this.housingbtn);
            this.LocationandAccountinfosGB.Controls.Add(this.Passportbtn);
            this.LocationandAccountinfosGB.Controls.Add(this.EmployeeRbtn);
            this.LocationandAccountinfosGB.Controls.Add(this.label2);
            this.LocationandAccountinfosGB.Controls.Add(this.Ncardbtn);
            this.LocationandAccountinfosGB.Controls.Add(this.Alleytxt);
            this.LocationandAccountinfosGB.Controls.Add(this.Districttxt);
            this.LocationandAccountinfosGB.Controls.Add(this.Emailtxt);
            this.LocationandAccountinfosGB.Controls.Add(this.Housetxt);
            this.LocationandAccountinfosGB.Controls.Add(this.Passwordtxt);
            this.LocationandAccountinfosGB.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationandAccountinfosGB.ForeColor = System.Drawing.Color.SeaGreen;
            this.LocationandAccountinfosGB.Location = new System.Drawing.Point(507, 72);
            this.LocationandAccountinfosGB.Name = "LocationandAccountinfosGB";
            this.LocationandAccountinfosGB.Size = new System.Drawing.Size(424, 978);
            this.LocationandAccountinfosGB.TabIndex = 22;
            this.LocationandAccountinfosGB.TabStop = false;
            this.LocationandAccountinfosGB.Text = "Location And Account information";
            // 
            // housingbtn
            // 
            this.housingbtn.BackColor = System.Drawing.Color.Transparent;
            this.housingbtn.BorderRadius = 13;
            this.housingbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.housingbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.housingbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.housingbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.housingbtn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.housingbtn.ForeColor = System.Drawing.Color.White;
            this.housingbtn.Location = new System.Drawing.Point(24, 788);
            this.housingbtn.Name = "housingbtn";
            this.housingbtn.Size = new System.Drawing.Size(343, 55);
            this.housingbtn.TabIndex = 25;
            this.housingbtn.Text = "بطاقة السكن";
            this.housingbtn.Click += new System.EventHandler(this.housingbtn_Click);
            // 
            // Passportbtn
            // 
            this.Passportbtn.BackColor = System.Drawing.Color.Transparent;
            this.Passportbtn.BorderRadius = 13;
            this.Passportbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Passportbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Passportbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Passportbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Passportbtn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Passportbtn.ForeColor = System.Drawing.Color.White;
            this.Passportbtn.Location = new System.Drawing.Point(24, 671);
            this.Passportbtn.Name = "Passportbtn";
            this.Passportbtn.Size = new System.Drawing.Size(343, 55);
            this.Passportbtn.TabIndex = 24;
            this.Passportbtn.Text = "جواز السفر";
            this.Passportbtn.Click += new System.EventHandler(this.Passportbtn_Click);
            // 
            // Ncardbtn
            // 
            this.Ncardbtn.BackColor = System.Drawing.Color.Transparent;
            this.Ncardbtn.BorderRadius = 13;
            this.Ncardbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Ncardbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Ncardbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Ncardbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Ncardbtn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Ncardbtn.ForeColor = System.Drawing.Color.White;
            this.Ncardbtn.Location = new System.Drawing.Point(24, 568);
            this.Ncardbtn.Name = "Ncardbtn";
            this.Ncardbtn.Size = new System.Drawing.Size(343, 55);
            this.Ncardbtn.TabIndex = 23;
            this.Ncardbtn.Text = "بطاقة الاحوال المدنية";
            this.Ncardbtn.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // Alleytxt
            // 
            this.Alleytxt.BorderRadius = 13;
            this.Alleytxt.BorderThickness = 0;
            this.Alleytxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Alleytxt.DefaultText = "Alley";
            this.Alleytxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Alleytxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Alleytxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Alleytxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Alleytxt.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.Alleytxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Alleytxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alleytxt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Alleytxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Alleytxt.Location = new System.Drawing.Point(24, 153);
            this.Alleytxt.Margin = new System.Windows.Forms.Padding(5);
            this.Alleytxt.Name = "Alleytxt";
            this.Alleytxt.PasswordChar = '\0';
            this.Alleytxt.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.Alleytxt.PlaceholderText = "";
            this.Alleytxt.SelectedText = "";
            this.Alleytxt.Size = new System.Drawing.Size(343, 55);
            this.Alleytxt.TabIndex = 7;
            // 
            // Districttxt
            // 
            this.Districttxt.BorderRadius = 13;
            this.Districttxt.BorderThickness = 0;
            this.Districttxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Districttxt.DefaultText = "District";
            this.Districttxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Districttxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Districttxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Districttxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Districttxt.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.Districttxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Districttxt.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Districttxt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Districttxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Districttxt.Location = new System.Drawing.Point(24, 50);
            this.Districttxt.Margin = new System.Windows.Forms.Padding(5);
            this.Districttxt.Name = "Districttxt";
            this.Districttxt.PasswordChar = '\0';
            this.Districttxt.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.Districttxt.PlaceholderText = "";
            this.Districttxt.SelectedText = "";
            this.Districttxt.Size = new System.Drawing.Size(343, 55);
            this.Districttxt.TabIndex = 5;
            // 
            // Emailtxt
            // 
            this.Emailtxt.BorderRadius = 13;
            this.Emailtxt.BorderThickness = 0;
            this.Emailtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Emailtxt.DefaultText = "E-Mail";
            this.Emailtxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Emailtxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Emailtxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Emailtxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Emailtxt.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.Emailtxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Emailtxt.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Emailtxt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Emailtxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Emailtxt.Location = new System.Drawing.Point(24, 369);
            this.Emailtxt.Margin = new System.Windows.Forms.Padding(5);
            this.Emailtxt.Name = "Emailtxt";
            this.Emailtxt.PasswordChar = '\0';
            this.Emailtxt.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.Emailtxt.PlaceholderText = "";
            this.Emailtxt.SelectedText = "";
            this.Emailtxt.Size = new System.Drawing.Size(343, 55);
            this.Emailtxt.TabIndex = 12;
            // 
            // Housetxt
            // 
            this.Housetxt.BorderRadius = 13;
            this.Housetxt.BorderThickness = 0;
            this.Housetxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Housetxt.DefaultText = "House";
            this.Housetxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Housetxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Housetxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Housetxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Housetxt.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.Housetxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Housetxt.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Housetxt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Housetxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Housetxt.Location = new System.Drawing.Point(24, 258);
            this.Housetxt.Margin = new System.Windows.Forms.Padding(5);
            this.Housetxt.Name = "Housetxt";
            this.Housetxt.PasswordChar = '\0';
            this.Housetxt.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.Housetxt.PlaceholderText = "";
            this.Housetxt.SelectedText = "";
            this.Housetxt.Size = new System.Drawing.Size(343, 55);
            this.Housetxt.TabIndex = 9;
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.BorderRadius = 13;
            this.Passwordtxt.BorderThickness = 0;
            this.Passwordtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Passwordtxt.DefaultText = "Password";
            this.Passwordtxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Passwordtxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Passwordtxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Passwordtxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Passwordtxt.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.Passwordtxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Passwordtxt.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Passwordtxt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Passwordtxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Passwordtxt.Location = new System.Drawing.Point(24, 466);
            this.Passwordtxt.Margin = new System.Windows.Forms.Padding(5);
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.PasswordChar = '\0';
            this.Passwordtxt.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.Passwordtxt.PlaceholderText = "";
            this.Passwordtxt.SelectedText = "";
            this.Passwordtxt.Size = new System.Drawing.Size(343, 55);
            this.Passwordtxt.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.guna2Button6);
            this.groupBox2.Controls.Add(this.guna2Button5);
            this.groupBox2.Controls.Add(this.guna2Button4);
            this.groupBox2.Controls.Add(this.Capturedpicbox);
            this.groupBox2.Controls.Add(this.Camerapicbox);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox2.Location = new System.Drawing.Point(1018, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(424, 978);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Photo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 455);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 23);
            this.label3.TabIndex = 29;
            this.label3.Text = "Captured photo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "Camera";
            // 
            // guna2Button6
            // 
            this.guna2Button6.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button6.BorderRadius = 13;
            this.guna2Button6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button6.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.guna2Button6.ForeColor = System.Drawing.Color.White;
            this.guna2Button6.Location = new System.Drawing.Point(39, 907);
            this.guna2Button6.Name = "guna2Button6";
            this.guna2Button6.Size = new System.Drawing.Size(343, 55);
            this.guna2Button6.TabIndex = 27;
            this.guna2Button6.Text = "Try Again";
            this.guna2Button6.Click += new System.EventHandler(this.guna2Button6_Click);
            // 
            // guna2Button5
            // 
            this.guna2Button5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button5.BorderRadius = 13;
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.Location = new System.Drawing.Point(39, 839);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(343, 55);
            this.guna2Button5.TabIndex = 27;
            this.guna2Button5.Text = "Save";
            // 
            // guna2Button4
            // 
            this.guna2Button4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button4.BorderRadius = 13;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Location = new System.Drawing.Point(39, 761);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(343, 55);
            this.guna2Button4.TabIndex = 26;
            this.guna2Button4.Text = "Take ";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // Capturedpicbox
            // 
            this.Capturedpicbox.Location = new System.Drawing.Point(22, 493);
            this.Capturedpicbox.Name = "Capturedpicbox";
            this.Capturedpicbox.Size = new System.Drawing.Size(308, 244);
            this.Capturedpicbox.TabIndex = 1;
            this.Capturedpicbox.TabStop = false;
            // 
            // Camerapicbox
            // 
            this.Camerapicbox.Location = new System.Drawing.Point(22, 107);
            this.Camerapicbox.Name = "Camerapicbox";
            this.Camerapicbox.Size = new System.Drawing.Size(377, 333);
            this.Camerapicbox.TabIndex = 0;
            this.Camerapicbox.TabStop = false;
            // 
            // Signupbtn
            // 
            this.Signupbtn.BackColor = System.Drawing.Color.Transparent;
            this.Signupbtn.BorderRadius = 13;
            this.Signupbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Signupbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Signupbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Signupbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Signupbtn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Signupbtn.ForeColor = System.Drawing.Color.White;
            this.Signupbtn.Location = new System.Drawing.Point(1490, 979);
            this.Signupbtn.Name = "Signupbtn";
            this.Signupbtn.Size = new System.Drawing.Size(343, 55);
            this.Signupbtn.TabIndex = 28;
            this.Signupbtn.Text = "Sign up";
            this.Signupbtn.Click += new System.EventHandler(this.guna2Button7_Click);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.Signupbtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.LocationandAccountinfosGB);
            this.Controls.Add(this.PesonalInfosGB);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUpForm";
            this.Text = "SignUpForm";
            this.Load += new System.EventHandler(this.SignUpForm_Load);
            this.panel1.ResumeLayout(false);
            this.PesonalInfosGB.ResumeLayout(false);
            this.PesonalInfosGB.PerformLayout();
            this.LocationandAccountinfosGB.ResumeLayout(false);
            this.LocationandAccountinfosGB.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Capturedpicbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Camerapicbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button MinSignupBtn;
        private System.Windows.Forms.Button CloseSignupBtn;
        private Guna.UI2.WinForms.Guna2TextBox FirstNametxt;
        private Guna.UI2.WinForms.Guna2TextBox MiddleNametxt;
        private Guna.UI2.WinForms.Guna2TextBox LastNametxt;
        private Guna.UI2.WinForms.Guna2TextBox FamilyNametxt;
        private Guna.UI2.WinForms.Guna2TextBox MotherFNtxt;
        private Guna.UI2.WinForms.Guna2TextBox MotherLNtxt;
        private Guna.UI2.WinForms.Guna2TextBox PhoneNumbertxt;
        private System.Windows.Forms.GroupBox PesonalInfosGB;
        private System.Windows.Forms.Label FemaleLabel;
        private System.Windows.Forms.Label MaleLabel;
        private Guna.UI2.WinForms.Guna2CustomRadioButton FemaleRbtn;
        private Guna.UI2.WinForms.Guna2CustomRadioButton MaleRbtn;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CustomRadioButton EmployeeRbtn;
        private Guna.UI2.WinForms.Guna2DateTimePicker BirthDateDateTimePicker1;
        private System.Windows.Forms.Label BirthLabel;
        private System.Windows.Forms.GroupBox LocationandAccountinfosGB;
        private Guna.UI2.WinForms.Guna2TextBox Alleytxt;
        private Guna.UI2.WinForms.Guna2TextBox Emailtxt;
        private Guna.UI2.WinForms.Guna2TextBox Housetxt;
        private Guna.UI2.WinForms.Guna2TextBox Passwordtxt;
        private Guna.UI2.WinForms.Guna2Button Ncardbtn;
        private Guna.UI2.WinForms.Guna2TextBox Districttxt;
        private Guna.UI2.WinForms.Guna2Button housingbtn;
        private Guna.UI2.WinForms.Guna2Button Passportbtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button6;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private System.Windows.Forms.PictureBox Capturedpicbox;
        private System.Windows.Forms.PictureBox Camerapicbox;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button Signupbtn;
    }
}