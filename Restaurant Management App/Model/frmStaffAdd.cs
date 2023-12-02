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
    public partial class frmStaffAdd : SampleAdd

    {
        public frmStaffAdd()
        {
            InitializeComponent();
        }
        public int id = 0;
        public override void btSave_Click(object sender, EventArgs e)
        {
            string qry = "";
            if (id == 0)
            {
                qry = "Insert into Staff values(@Name,@Phone,@Role)";
            }
            else
            {
                qry = "Update Staff set staffName = @Name,staffPhone=@Phone,staffRole=@Role where staffID=@ID";
            }
            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", txtName.Text);
            ht.Add("@Phone",txtSDT.Text);
            ht.Add("@Role", txtRole.Text);
            if (MainClass_.SQL(qry, ht) > 0)
            {
                MessageBox.Show("Lưu thành công!");
                id = 0;
                txtName.Text = "";
                txtSDT.Text = "";
                txtRole.SelectedIndex = -1;
                txtName.Focus();
            }
        }

       
    }

}
