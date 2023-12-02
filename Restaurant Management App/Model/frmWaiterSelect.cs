﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management_App.Model
{
    public partial class frmWaiterSelect : Form
    {
        public frmWaiterSelect()
        {
            InitializeComponent();
        }
        public string waiterName;
        private void frmWaiterSelect_Load(object sender, EventArgs e)
        {
            string qry = "Select * from Staff where staffRole like N'%Phục vụ%'";
            SqlCommand cmd = new SqlCommand(qry, MainClass_.conn);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Guna.UI.WinForms.GunaButton b = new Guna.UI.WinForms.GunaButton();
                b.Text = dr["staffName"].ToString();
                b.Width = 230;
                b.Height = 80;
                b.Font = new Font("Segoe UI", 16, FontStyle.Bold);
                b.TextAlign = HorizontalAlignment.Center;
                b.ForeColor = Color.Black;
                b.Image = null;
                b.BaseColor = Color.FromArgb(235, 227, 213);
                b.OnHoverBaseColor = Color.FromArgb(115, 144, 114);
                b.MouseClick += new MouseEventHandler(waiterClick);
                flowLayoutPanel1.Controls.Add(b);
            }
        }
        private void waiterClick(object sender, MouseEventArgs e)
        {
            waiterName = (sender as Guna.UI.WinForms.GunaButton).Text.ToString();
            this.Close();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
