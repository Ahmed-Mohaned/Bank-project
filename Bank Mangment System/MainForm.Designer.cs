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
            this.panel1 = new System.Windows.Forms.Panel();
            this.MinMainFormBtn = new System.Windows.Forms.Button();
            this.CloseMainFormBtn = new System.Windows.Forms.Button();
            this.SideBar = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Menulabel = new System.Windows.Forms.Label();
            this.MenuButton = new System.Windows.Forms.PictureBox();
            this.SideBarTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SideBar.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.MinMainFormBtn);
            this.panel1.Controls.Add(this.CloseMainFormBtn);
            this.panel1.Location = new System.Drawing.Point(62, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1889, 55);
            this.panel1.TabIndex = 0;
            // 
            // MinMainFormBtn
            // 
            this.MinMainFormBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.MinMainFormBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinMainFormBtn.ForeColor = System.Drawing.Color.White;
            this.MinMainFormBtn.Location = new System.Drawing.Point(1767, 5);
            this.MinMainFormBtn.Name = "MinMainFormBtn";
            this.MinMainFormBtn.Size = new System.Drawing.Size(36, 43);
            this.MinMainFormBtn.TabIndex = 3;
            this.MinMainFormBtn.Text = "-";
            this.MinMainFormBtn.UseVisualStyleBackColor = false;
            this.MinMainFormBtn.Click += new System.EventHandler(this.MinMainFormBtn_Click);
            // 
            // CloseMainFormBtn
            // 
            this.CloseMainFormBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.CloseMainFormBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseMainFormBtn.ForeColor = System.Drawing.Color.White;
            this.CloseMainFormBtn.Location = new System.Drawing.Point(1810, 5);
            this.CloseMainFormBtn.Name = "CloseMainFormBtn";
            this.CloseMainFormBtn.Size = new System.Drawing.Size(36, 43);
            this.CloseMainFormBtn.TabIndex = 1;
            this.CloseMainFormBtn.Text = "X";
            this.CloseMainFormBtn.UseVisualStyleBackColor = false;
            this.CloseMainFormBtn.Click += new System.EventHandler(this.CloseMainFormBtn_Click);
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.SideBar.Controls.Add(this.panel3);
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.Location = new System.Drawing.Point(0, 0);
            this.SideBar.MaximumSize = new System.Drawing.Size(203, 1129);
            this.SideBar.MinimumSize = new System.Drawing.Size(70, 1200);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(70, 1200);
            this.SideBar.TabIndex = 1;
            this.SideBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Menulabel);
            this.panel3.Controls.Add(this.MenuButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(70, 80);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1917, 1106);
            this.Controls.Add(this.SideBar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.SideBar.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CloseMainFormBtn;
        private System.Windows.Forms.Button MinMainFormBtn;
        private System.Windows.Forms.Panel SideBar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Menulabel;
        private System.Windows.Forms.Timer SideBarTimer;
        private System.Windows.Forms.PictureBox MenuButton;
    }
}