using Guna.UI.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management_App
{
    internal class MainClass_
    {
        public static readonly string con_string = "Data Source=Min-Zee;Initial Catalog=RestaurantManagement;Integrated Security=true;";
        public static SqlConnection conn = new SqlConnection(con_string);
        public static bool isValidUser(string user, string pass)
        {
            bool isValid = false;
            string query = @"Select * from Users where username ='" + user + "'and upass ='" + pass + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            if(dt.Rows.Count > 0 )
            {
                isValid = true;
                USER = dt.Rows[0]["uName"].ToString();
            }
            return isValid;
        }
        public static string user;
        public static string USER
        {
            get { return user; }
            private set { user = value; }
        }
        public static int SQL(string query, Hashtable ht)
        {
            int res = 0;
            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.Text;
                foreach(DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                res = cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Tên không được trùng hoặc để trống!");
                conn.Close();
            }
            return res;
        }
        public static void loadData(string qry, DataGridView gv,ListBox lb)
        {
            gv.CellFormatting += new DataGridViewCellFormattingEventHandler(gv_CellFormatting);
            try
            {
                SqlCommand cmd = new SqlCommand(qry, conn);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                for(int i = 0; i < lb.Items.Count; i++)
                {
                    string colName1 = ((DataGridViewColumn)lb.Items[i]).Name;
                    gv.Columns[colName1].DataPropertyName = dt.Columns[i].ToString();
                }
                gv.DataSource = dt;
            }
            catch( Exception e ) 
            {
                MessageBox.Show(e.ToString());
                conn.Close();
            }
        }
        private static void gv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Guna.UI.WinForms.GunaDataGridView gv = (Guna.UI.WinForms.GunaDataGridView)sender;
            int count = 0;
            foreach(DataGridViewRow row in gv.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }
        public static void blurBG(Form form)
        {
            Form bg = new Form();
            using (form)
            {
                bg.StartPosition = FormStartPosition.Manual;
                bg.FormBorderStyle = FormBorderStyle.None;
                bg.Opacity = 0.5d;
                bg.BackColor = Color.Black;
                bg.Size = frmMain.Instance.Size;
                bg.Location =frmMain.Instance.Location;
                bg.ShowInTaskbar = false;
                bg.Show();
                form.Owner = bg;
                form.ShowDialog(bg);
                bg.Dispose();
            }
        }
        public static void CBFill(string qry,ComboBox comboBox)
        {
            SqlCommand cmd = new SqlCommand(qry, conn);
            cmd.CommandType = CommandType.Text; 
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox.DisplayMember = "Name";
            comboBox.ValueMember = "id";
            comboBox.DataSource = dt;
            comboBox.SelectedIndex = -1;
        }

    }     
}
