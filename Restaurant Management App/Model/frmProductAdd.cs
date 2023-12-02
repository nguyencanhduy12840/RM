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

namespace Restaurant_Management_App.Model
{
    public partial class frmProductAdd : SampleAdd
    {

        public frmProductAdd()
        {
            InitializeComponent();
        }
        public int id = 0;
        public int catID = 0;
        string filePath;
        Byte[] imageByteArray;
        private void frmProductAdd_Load(object sender, EventArgs e)
        {
            btSave.Location = new Point(667, 27);
            btExit.Location = new Point(836, 27);
            string qry = " Select CatID 'id',CatName 'name' from Category";
            MainClass_.CBFill(qry,txtCat);
            if(catID>0)
            {
                txtCat.SelectedValue = catID;
            }
            if(id>0)
            {
                update_LoadData();
            }
        }
        public override void btSave_Click(object sender, EventArgs e)
        {
            string qry = "";
            if (id == 0)
            {
                qry = "Insert into Product values(@Name,@Price,@Category,@Image)";
            }
            else
            {
                qry = "Update Product set productName = @Name,productPrice=@Price,CatID=@Category,productImage=@Image where productID=@ID";
            }
            Image temp = new Bitmap(txtImage.Image);
            MemoryStream ms = new MemoryStream();
            temp.Save(ms,System.Drawing.Imaging.ImageFormat.Png);
            imageByteArray = ms.ToArray();

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", txtName.Text);
            ht.Add("@Price", txtPrice.Text);
            ht.Add("@Category",Convert.ToInt32(txtCat.SelectedValue));
            ht.Add("@Image", imageByteArray);
            if (txtCat.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn danh mục!", "", MessageBoxButtons.OK);
            }
            else if(!double.TryParse(txtPrice.Text, out _))
            {
                MessageBox.Show("Vui lòng nhập giá hợp lệ!", "", MessageBoxButtons.OK);
            }
            
            else if (MainClass_.SQL(qry, ht) > 0)
            {
                MessageBox.Show("Lưu thành công!");
                id = 0;
                catID = 0;
                txtName.Text = "";
                txtPrice.Text = "";
                txtCat.SelectedIndex = 0;
                txtCat.SelectedIndex = -1;
                txtImage.Image = Restaurant_Management_App.Properties.Resources.dish;
                txtName.Focus();
            }
        }
        private void update_LoadData()
        {
            string qry = @"Select * from Product where productID=" + id + "";
            SqlCommand cmd = new SqlCommand(qry, MainClass_.conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count < 0)
            {
                txtName.Text = dt.Rows[0]["productName"].ToString();
                txtPrice.Text = dt.Rows[0]["productPrice"].ToString();
                Byte[] imageArray = (byte[])(dt.Rows[0]["productImage"]);
                byte[] imageByteArray = imageArray;
                txtImage.Image = Image.FromStream(new MemoryStream(imageArray));
            }
        }
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Images(.jpg,.png)|* .png;*.jpg";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                txtImage.Image = new Bitmap(filePath);
            }
        }
    }
}
