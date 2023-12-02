namespace Restaurant_Management_App.Model
{
    partial class frmProductAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCat = new Guna.UI.WinForms.GunaComboBox();
            this.txtPrice = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtName = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtImage = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(1001, 139);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 501);
            this.panel2.Size = new System.Drawing.Size(1001, 100);
            // 
            // header
            // 
            this.header.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.header.Location = new System.Drawing.Point(143, 55);
            this.header.Size = new System.Drawing.Size(206, 31);
            this.header.Text = "Thông tin món ăn";
            // 
            // rjCircularPictureBox1
            // 
            this.rjCircularPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rjCircularPictureBox1.Location = new System.Drawing.Point(34, 19);
            // 
            // btSave
            // 
            this.btSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSave.FlatAppearance.BorderSize = 0;
            this.btSave.Location = new System.Drawing.Point(1293, 27);
            this.btSave.Text = "Lưu";
            // 
            // btExit
            // 
            this.btExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btExit.FlatAppearance.BorderSize = 0;
            this.btExit.Location = new System.Drawing.Point(1462, 27);
            this.btExit.Text = "Đóng";
            // 
            // txtCat
            // 
            this.txtCat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCat.BackColor = System.Drawing.Color.Transparent;
            this.txtCat.BaseColor = System.Drawing.Color.White;
            this.txtCat.BorderColor = System.Drawing.Color.Silver;
            this.txtCat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtCat.FocusedColor = System.Drawing.Color.Empty;
            this.txtCat.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCat.ForeColor = System.Drawing.Color.Black;
            this.txtCat.FormattingEnabled = true;
            this.txtCat.ItemHeight = 38;
            this.txtCat.Location = new System.Drawing.Point(409, 229);
            this.txtCat.Name = "txtCat";
            this.txtCat.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCat.OnHoverItemForeColor = System.Drawing.Color.White;
            this.txtCat.Size = new System.Drawing.Size(315, 44);
            this.txtCat.TabIndex = 14;
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrice.BaseColor = System.Drawing.Color.White;
            this.txtPrice.BorderColor = System.Drawing.Color.Silver;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPrice.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.txtPrice.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(52, 319);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.SelectedText = "";
            this.txtPrice.Size = new System.Drawing.Size(315, 45);
            this.txtPrice.TabIndex = 15;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(47, 286);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(43, 28);
            this.gunaLabel3.TabIndex = 18;
            this.gunaLabel3.Text = "Giá";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(404, 190);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(128, 28);
            this.gunaLabel2.TabIndex = 17;
            this.gunaLabel2.Text = "Loại món ăn";
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.BaseColor = System.Drawing.Color.White;
            this.txtName.BorderColor = System.Drawing.Color.Silver;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.txtName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(52, 229);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(315, 45);
            this.txtName.TabIndex = 13;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(47, 191);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(45, 28);
            this.gunaLabel1.TabIndex = 16;
            this.gunaLabel1.Text = "Tên";
            // 
            // txtImage
            // 
            this.txtImage.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(216)))));
            this.txtImage.Image = global::Restaurant_Management_App.Properties.Resources.dish;
            this.txtImage.Location = new System.Drawing.Point(776, 177);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(182, 180);
            this.txtImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.txtImage.TabIndex = 19;
            this.txtImage.TabStop = false;
            this.txtImage.UseTransfarantBackground = false;
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.CadetBlue;
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(776, 393);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(197)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 20;
            this.gunaButton1.Size = new System.Drawing.Size(182, 58);
            this.gunaButton1.TabIndex = 21;
            this.gunaButton1.Text = "Chọn ảnh";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // frmProductAdd
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1001, 601);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.txtImage);
            this.Controls.Add(this.txtCat);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.gunaLabel1);
            this.Name = "frmProductAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProductAdd";
            this.Load += new System.EventHandler(this.frmProductAdd_Load);
            this.Controls.SetChildIndex(this.gunaLabel1, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.gunaLabel2, 0);
            this.Controls.SetChildIndex(this.gunaLabel3, 0);
            this.Controls.SetChildIndex(this.txtPrice, 0);
            this.Controls.SetChildIndex(this.txtCat, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.txtImage, 0);
            this.Controls.SetChildIndex(this.gunaButton1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI.WinForms.GunaComboBox txtCat;
        public Guna.UI.WinForms.GunaTextBox txtPrice;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        public Guna.UI.WinForms.GunaTextBox txtName;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        public Guna.UI.WinForms.GunaCirclePictureBox txtImage;
    }
}