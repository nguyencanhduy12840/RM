using Guna.UI2.WinForms.Suite;
using Restaurant_Management_App.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management_App.View
{
    public partial class ProductView : SampleView
    {
   
        public ProductView()
        {
            InitializeComponent();
            tbSearch.Text = string.Empty;
        }

        private void ProductView_Load(object sender, EventArgs e)
        {
            getData();
            tbSearch.Text = "🔎 Search here";
        }
       
        public void getData()
        {
            string qry = "Select productID,productName,productPrice,p.catID,CatName from Product p join Category c on p.catID=c.CatID where productName like N'%" + tbSearch.Text + "%' order by CatName";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvname);
            lb.Items.Add(dgvprice);
            lb.Items.Add(dgvcatID);
            lb.Items.Add(dgvcat);
            MainClass_.loadData(qry, gunaDataGridView1, lb);
        }
        public void gotData()
        {
            tbSearch.Text = string.Empty;
            getData();
            tbSearch.Text = "🔎 Search here";
        }
        public override void btAdd_Click(object sender, EventArgs e)
        {
            MainClass_.blurBG(new frmProductAdd());
            gotData();
        }
        public override void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbSearch.Text != "🔎 Search here")
                getData();
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
                    frmProductAdd frm = new frmProductAdd();
                    frm.id = Convert.ToInt32(gunaDataGridView1.CurrentRow.Cells["dgvid"].Value);
                    frm.catID = Convert.ToInt32(gunaDataGridView1.CurrentRow.Cells["dgvcatID"].Value);
                    frm.txtName.Text = Convert.ToString(gunaDataGridView1.CurrentRow.Cells["dgvname"].Value);
                    frm.txtPrice.Text = Convert.ToString(gunaDataGridView1.CurrentRow.Cells["dgvprice"].Value);
                    int id = Convert.ToInt32(gunaDataGridView1.CurrentRow.Cells["dgvid"].Value);
                    string qry = "Select productImage from Product where productID =" + id + "";
                    SqlCommand cmd = new SqlCommand(qry, MainClass_.conn);
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    byte[] imageData = (byte[])dt.Rows[0]["productImage"];
                    Image image = Image.FromStream(new MemoryStream(imageData));
                    frm.txtImage.Image = image;
                    MainClass_.blurBG(frm);
                    gotData();
                }
                if (gunaDataGridView1.CurrentCell.OwningColumn.Name == "dgvdel")
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc xóa món ăn này?", "Xác nhận", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        int id = Convert.ToInt32(gunaDataGridView1.CurrentRow.Cells["dgvid"].Value);
                        string qry = "Delete from Product where ProductID =" + id + "";
                        Hashtable ht = new Hashtable();
                        MainClass_.SQL(qry, ht);
                        MessageBox.Show("Đã xóa món ăn!");
                        gotData();
                    }
                }
            }
        }
    }
}
