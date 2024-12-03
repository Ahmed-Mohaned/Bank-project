using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Util;
using System.Windows.Forms;

namespace Bank_Mangment_System
{
    public partial class TransactionsData : Form
    {
        public TransactionsData(string[] transactions)
        {
            InitializeComponent();
            TransactionsDatagrid.Rows.Clear(); // مسح أي بيانات سابقة في الجدول
            TransactionsDatagrid.Columns.Clear();

            // إضافة الأعمدة في الـ DataGridView
            TransactionsDatagrid.Columns.Add("Date", "Date");
            TransactionsDatagrid.Columns.Add("TransactionType", "Transaction Type");
            TransactionsDatagrid.Columns.Add("Amount", "Amount");
            TransactionsDatagrid.Columns.Add("BalanceAfter", "Balance After");

            // إضافة المعاملات إلى الـ DataGridView
            foreach (var transaction in transactions)
            {
                string[] transactionDetails = transaction.Split(';');
                if (transactionDetails.Length == 4)
                {
                    TransactionsDatagrid.Rows.Add(transactionDetails);
                }
            }
        }

        private void TransactionsData_Load(object sender, EventArgs e)
        {

        }
    }
}
