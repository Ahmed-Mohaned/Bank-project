namespace Bank_Mangment_System
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SideBar = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SearchButton = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SignUpButton = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Menulabel = new System.Windows.Forms.Label();
            this.MenuButton = new System.Windows.Forms.PictureBox();
            this.SideBarTimer = new System.Windows.Forms.Timer(this.components);
            this.Searchtxtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.NamesdataGridView = new System.Windows.Forms.DataGridView();
            this.Searchbtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.SideBar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchButton)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SignUpButton)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NamesdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SideBar
            // 
            this.SideBar.AutoSize = true;
            this.SideBar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.SideBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SideBar.Controls.Add(this.panel2);
            this.SideBar.Controls.Add(this.panel1);
            this.SideBar.Controls.Add(this.panel3);
            this.SideBar.Location = new System.Drawing.Point(0, 0);
            this.SideBar.MaximumSize = new System.Drawing.Size(203, 855);
            this.SideBar.MinimumSize = new System.Drawing.Size(40, 855);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(40, 855);
            this.SideBar.TabIndex = 1;
            this.SideBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SearchButton);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 180);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(38, 100);
            this.panel2.TabIndex = 2;
            // 
            // SearchButton
            // 
            this.SearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchButton.Image = ((System.Drawing.Image)(resources.GetObject("SearchButton.Image")));
            this.SearchButton.Location = new System.Drawing.Point(9, 27);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(52, 41);
            this.SearchButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SearchButton.TabIndex = 2;
            this.SearchButton.TabStop = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(67, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SignUpButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(38, 100);
            this.panel1.TabIndex = 1;
            // 
            // SignUpButton
            // 
            this.SignUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUpButton.Image = ((System.Drawing.Image)(resources.GetObject("SignUpButton.Image")));
            this.SignUpButton.Location = new System.Drawing.Point(9, 27);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(52, 41);
            this.SignUpButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SignUpButton.TabIndex = 2;
            this.SignUpButton.TabStop = false;
            this.SignUpButton.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(67, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sign Up";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Menulabel);
            this.panel3.Controls.Add(this.MenuButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(38, 80);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Menulabel
            // 
            this.Menulabel.AutoSize = true;
            this.Menulabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Menulabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menulabel.ForeColor = System.Drawing.Color.White;
            this.Menulabel.Location = new System.Drawing.Point(67, 29);
            this.Menulabel.Name = "Menulabel";
            this.Menulabel.Size = new System.Drawing.Size(65, 23);
            this.Menulabel.TabIndex = 1;
            this.Menulabel.Text = "Menu";
            this.Menulabel.Click += new System.EventHandler(this.Menulabel_Click);
            // 
            // MenuButton
            // 
            this.MenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuButton.Image = ((System.Drawing.Image)(resources.GetObject("MenuButton.Image")));
            this.MenuButton.Location = new System.Drawing.Point(9, 20);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(52, 41);
            this.MenuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MenuButton.TabIndex = 0;
            this.MenuButton.TabStop = false;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // SideBarTimer
            // 
            this.SideBarTimer.Interval = 10;
            this.SideBarTimer.Tick += new System.EventHandler(this.SideBarTimer_Tick);
            // 
            // Searchtxtbox
            // 
            this.Searchtxtbox.BorderRadius = 13;
            this.Searchtxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Searchtxtbox.DefaultText = "";
            this.Searchtxtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Searchtxtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Searchtxtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Searchtxtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Searchtxtbox.FillColor = System.Drawing.Color.Gainsboro;
            this.Searchtxtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Searchtxtbox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchtxtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Searchtxtbox.Location = new System.Drawing.Point(237, 14);
            this.Searchtxtbox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Searchtxtbox.Name = "Searchtxtbox";
            this.Searchtxtbox.PasswordChar = '\0';
            this.Searchtxtbox.PlaceholderText = "";
            this.Searchtxtbox.SelectedText = "";
            this.Searchtxtbox.Size = new System.Drawing.Size(464, 70);
            this.Searchtxtbox.TabIndex = 2;
            this.Searchtxtbox.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // NamesdataGridView
            // 
            this.NamesdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NamesdataGridView.Location = new System.Drawing.Point(237, 92);
            this.NamesdataGridView.Name = "NamesdataGridView";
            this.NamesdataGridView.RowHeadersWidth = 62;
            this.NamesdataGridView.RowTemplate.Height = 28;
            this.NamesdataGridView.Size = new System.Drawing.Size(464, 482);
            this.NamesdataGridView.TabIndex = 3;
            this.NamesdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NamesdataGridView_CellContentClick);
            // 
            // Searchbtn
            // 
            this.Searchbtn.BorderRadius = 13;
            this.Searchbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Searchbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Searchbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Searchbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Searchbtn.FillColor = System.Drawing.Color.MediumAquamarine;
            this.Searchbtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchbtn.ForeColor = System.Drawing.Color.White;
            this.Searchbtn.Location = new System.Drawing.Point(237, 580);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(464, 38);
            this.Searchbtn.TabIndex = 4;
            this.Searchbtn.Text = "Search";
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 13;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.MediumAquamarine;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(237, 624);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(464, 46);
            this.guna2Button1.TabIndex = 5;
            this.guna2Button1.Text = "creat clint account";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 1044);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.Searchbtn);
            this.Controls.Add(this.NamesdataGridView);
            this.Controls.Add(this.Searchtxtbox);
            this.Controls.Add(this.SideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SideBar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchButton)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SignUpButton)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NamesdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel SideBar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Menulabel;
        private System.Windows.Forms.Timer SideBarTimer;
        private System.Windows.Forms.PictureBox MenuButton;
        private Guna.UI2.WinForms.Guna2TextBox Searchtxtbox;
        private System.Windows.Forms.DataGridView NamesdataGridView;
        private Guna.UI2.WinForms.Guna2Button Searchbtn;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox SignUpButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox SearchButton;
        private System.Windows.Forms.Label label2;
    }
}