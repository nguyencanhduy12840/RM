using Restaurant_Management_App.Model;
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

namespace Restaurant_Management_App.View
{
    public partial class TableView : SampleView
    {
        public void getData()
        {
            string qry = "select * from Tables where tableName like N'%" + tbSearch.Text + "%' ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvname);
            MainClass_.loadData(qry, gunaDataGridView1, lb);
        }
        public void gotData()
        {
            tbSearch.Text = string.Empty;
            getData();
            tbSearch.Text = "🔎 Search here";
        }
        public TableView()
        {
            InitializeComponent();
            tbSearch.Text=string.Empty;
        }
        public override void btAdd_Click(object sender, EventArgs e)
        {
            MainClass_.blurBG(new frmTableAdd());
            gotData();
        }
        public override void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbSearch.Text != "🔎 Search here")
                getData();
        }

        private void TableView_Load(object sender, EventArgs e)
        {
            getData();
            tbSearch.Text = "🔎 Search here";
        }
        private void tbSearch_Enter(object sender, EventArgs e)
        {
            if (tbSearch.Text == "🔎 Search here")
                tbSearch.Text = string.Empty;
        }

        private void tbSearch_Leave(object sender, EventArgs e)
        {
            if (tbSearch.Text == string.Empty)
                tbSearch.Text = "🔎 Search here";
        }
        private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gunaDataGridView1.Rows.Count > 0)
            {
                if (gunaDataGridView1.CurrentCell.OwningColumn.Name == "dgvedit")
                {
                    frmTableAdd frm = new frmTableAdd();
                    frm.id = Convert.ToInt32(gunaDataGridView1.CurrentRow.Cells["dgvid"].Value);
                    frm.txtName.Text = Convert.ToString(gunaDataGridView1.CurrentRow.Cells["dgvname"].Value);
                    MainClass_.blurBG(frm);
                    gotData();
                }
                if (gunaDataGridView1.CurrentCell.OwningColumn.Name == "dgvdel")
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        int id = Convert.ToInt32(gunaDataGridView1.CurrentRow.Cells["dgvid"].Value);
                        string qry = "Delete from Tables where tableID =" + id + "";
                        Hashtable ht = new Hashtable();
                        MainClass_.SQL(qry, ht);
                        MessageBox.Show("Xóa thành công!");
                        gotData();
                    }
                }
            }
        }

      
    }
}
