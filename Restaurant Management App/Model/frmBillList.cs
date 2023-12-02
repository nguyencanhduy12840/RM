using Guna.UI.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management_App.Model
{
    public partial class frmBillList : SampleAdd
    {
        public frmBillList()
        {
            InitializeComponent();
        }
        public int mainID = 0;
        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBillList_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            string qry = "Select mainID,tableName,waiterName,orderType,orderStatus,total from Orders where orderStatus <> 'Chưa thanh toán'";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvtable);
            lb.Items.Add(dgvwaiter);
            lb.Items.Add(dgvtype);
            lb.Items.Add(dgvstatus);
            lb.Items.Add(dgvtotal);
            MainClass_.loadData(qry, gunaDataGridView1, lb);    
        }
        private void gunaDataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int count = 0;
            foreach (DataGridViewRow row in gunaDataGridView1.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }

        private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gunaDataGridView1.Rows.Count > 0)
            {
                if (gunaDataGridView1.CurrentCell.OwningColumn.Name == "dgvedit")
                {
                    mainID = Convert.ToInt32(gunaDataGridView1.CurrentRow.Cells["dgvid"].Value);
                    this.Close();
                }
            }
        }


    }
}
