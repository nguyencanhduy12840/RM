using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Restaurant_Management_App.Model
{
    public partial class frmCategoryAdd : SampleAdd
    {
        public frmCategoryAdd()
        {
            InitializeComponent();
        }
        public int id = 0;
        public override void btSave_Click(object sender, EventArgs e)
        {
            string qry = "";
            if (id == 0)
            {
                qry = "Insert into Category values(@Name)";
            }
            else
            {
                qry = "Update Category set CatName = @Name where CatID=@ID";
            }
            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", txtName.Text);
            if (MainClass_.SQL(qry, ht) > 0)
            {
                MessageBox.Show("Lưu thành công!");
                id = 0;
                txtName.Text = "";
                txtName.Focus();
            }
        }

      
    }
}
