namespace Bank_Mangment_System
{
    partial class TransactionsData
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
            this.TransactionsDatagrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionsDatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // TransactionsDatagrid
            // 
            this.TransactionsDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransactionsDatagrid.Location = new System.Drawing.Point(12, 27);
            this.TransactionsDatagrid.Name = "TransactionsDatagrid";
            this.TransactionsDatagrid.RowHeadersWidth = 62;
            this.TransactionsDatagrid.RowTemplate.Height = 28;
            this.TransactionsDatagrid.Size = new System.Drawing.Size(1271, 689);
            this.TransactionsDatagrid.TabIndex = 0;
            // 
            // TransactionsData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 728);
            this.Controls.Add(this.TransactionsDatagrid);
            this.Name = "TransactionsData";
            this.Text = "TransactionsData";
            this.Load += new System.EventHandler(this.TransactionsData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TransactionsDatagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TransactionsDatagrid;
    }
}