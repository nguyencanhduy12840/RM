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
using System.Data.SqlClient;

namespace Restaurant_Management_App.Model
{
    public partial class frmTableAdd : SampleAdd
    {
        public frmTableAdd()
        {
            InitializeComponent();
        }
        public int id = 0;
        public override void btSave_Click(object sender, EventArgs e)
        {
            string qry = "";
            if (id == 0)
            {
                qry = "Insert into Tables values(@Name)";
            }
            else
            {
                qry = "Update Tables set tableName = @Name where tableID=@ID";
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
