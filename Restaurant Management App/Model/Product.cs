using System;
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
    public partial class Product : UserControl
    {
        public Product()
        {
            InitializeComponent();
            txtProdName.SelectionAlignment = HorizontalAlignment.Center;
        }
        public event EventHandler onSelect = null;
        public int Pid { get; set; }
        public string Pprice { get; set; }
        public string Pcategory { get; set; }
        public string Prodname
        {
            get { return txtProdName.Text; }
            set { txtProdName.Text = value; }
        }
        public Image Pimage
        {
            get { return imProd.Image; }
            set { imProd.Image = value; }
        }
        private void imProd_MouseClick(object sender, MouseEventArgs e)
        {
            onSelect?.Invoke(this, e);
        }
    }
}
