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
using System.Windows.Forms;

namespace Restaurant_Management_App.View
{
    public partial class KitchenView : Form
    {
        public KitchenView()
        {
            InitializeComponent();
        }

        private void KitchenView_Load(object sender, EventArgs e)
        {
            getOrders();
        }
        private void getOrders()
        {
            flowLayoutPanel1.Controls.Clear();
            string qry1 = @"Select * from Orders where orderStatus = N'Chưa hoàn thành'";
            SqlCommand cmd1 = new SqlCommand(qry1, MainClass_.conn);
            DataTable dt1= new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);
            FlowLayoutPanel p1;
            for(int i=0;i<dt1.Rows.Count;i++)
            {
                p1 = new FlowLayoutPanel();
                p1.AutoSize = true;
                p1.Height = 310;
                p1.Width = 300;
                p1.FlowDirection = FlowDirection.TopDown;
                p1.BorderStyle = BorderStyle.FixedSingle;
                p1.BackColor = Color.FromArgb(243, 238, 234);
                p1.Margin= new Padding(10,10,10, 10);

                FlowLayoutPanel p2;
                p2 = new FlowLayoutPanel();
                p2.AutoSize = true;
                p2.Height = 160;
                p2.Width = 300;
                p2.FlowDirection = FlowDirection.TopDown;
                p2.Margin = new Padding(0, 0, 0, 0);
                p2.BackColor = Color.FromArgb(119, 107, 93);
                p2.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                

                Label lb1 = new Label();
                lb1.ForeColor = Color.White;
                lb1.Margin = new Padding(10, 10, 3, 0);
                lb1.AutoSize = true;
                lb1.TextAlign = ContentAlignment.MiddleLeft;

                Label lb2 = new Label();
                lb2.ForeColor = Color.White;
                lb2.Margin = new Padding(10, 5, 3, 0);
                lb2.TextAlign = ContentAlignment.MiddleLeft;
                lb2.AutoSize = true;

                Label lb3 = new Label();
                lb3.ForeColor = Color.White;
                lb3.Margin = new Padding(10, 5, 3, 0);
                lb3.TextAlign = ContentAlignment.MiddleLeft;
                lb3.AutoSize = true;

                Label lb4 = new Label();
                lb4.ForeColor = Color.White;
                lb4.Margin = new Padding(10, 5, 3, 0);
                lb4.TextAlign = ContentAlignment.MiddleLeft;
                lb4.AutoSize = true;

                lb1.Text="Bàn: " + dt1.Rows[i]["tableName"].ToString();
                lb2.Text = "Tên phục vụ: " + dt1.Rows[i]["waiterName"].ToString();
                lb3.Text = "Thời gian: " + dt1.Rows[i]["orderTime"].ToString();
                lb4.Text = "Loại đơn: " + dt1.Rows[i]["orderType"].ToString();

                p2.Controls.Add(lb1);
                p2.Controls.Add(lb2);
                p2.Controls.Add(lb3);
                p2.Controls.Add(lb4);

                p1.Controls.Add(p2);

                int mid = 0;
                mid = Convert.ToInt32(dt1.Rows[i]["mainID"].ToString());
                string qry2 = @"Select * from Orders o join Details d on o.mainID=d.mainID join Product p on p.productID=d.productID where o.mainID =" + mid + "";
                SqlCommand cmd2 = new SqlCommand(qry2, MainClass_.conn);
                DataTable dt2 = new DataTable();
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                da2.Fill(dt2);

                for(int j=0; j<dt2.Rows.Count; j++)
                {
                    Label lb5 = new Label();
                    lb5.ForeColor = Color.Black;
                    lb5.Margin = new Padding(10, 5, 3, 0);
                    lb5.AutoSize = true;
                    int number = j + 1;
                    lb5.Text = "" + number + ". " + dt2.Rows[j]["productName"].ToString() + " x" + dt2.Rows[j]["qty"].ToString();
                    p1.Controls.Add(lb5);
                }
                Guna.UI.WinForms.GunaButton b= new Guna.UI.WinForms.GunaButton();
                b.Radius = 15;
                b.Size = new Size(100, 35);
                b.Margin = new Padding(50, 5, 3, 10);
                b.Text = "Hoàn tất đơn";
                b.Image = null;
                b.OnHoverBaseColor = Color.FromArgb(199, 220, 167);
                b.Font = new Font("Segoe UI", 10,FontStyle.Bold);
                b.BaseColor = Color.FromArgb(115, 144, 114);
                b.Tag = dt1.Rows[i]["mainID"].ToString();
                b.Click += new EventHandler(completeClick);
                p1.Controls.Add(b);
                flowLayoutPanel1.Controls.Add(p1);
            }
        }
        private void completeClick(object sender, EventArgs e) 
        {
            int id =Convert.ToInt32((sender as Guna.UI.WinForms.GunaButton).Tag.ToString());
            DialogResult result = MessageBox.Show("Hoàn thành đơn này ?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result==DialogResult.Yes)
            {
                string qry = @"Update Orders set orderStatus = N'Đã hoàn thành' where mainID = @ID";
                Hashtable ht = new Hashtable();
                ht.Add("@ID", id);
                if (MainClass_.SQL(qry, ht) > 0)
                {
                    MessageBox.Show("Đã hoàn tất đơn", "", MessageBoxButtons.OK);
                }
                getOrders();
            }
        }
    }
}
