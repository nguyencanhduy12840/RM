namespace Restaurant_Management_App.Model
{
    partial class Product
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.imProd = new Guna.UI.WinForms.GunaPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtProdName = new System.Windows.Forms.RichTextBox();
            this.gunaShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imProd)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(238)))), ((int)(((byte)(234)))));
            this.gunaShadowPanel1.Controls.Add(this.gunaSeparator1);
            this.gunaShadowPanel1.Controls.Add(this.imProd);
            this.gunaShadowPanel1.Controls.Add(this.panel1);
            this.gunaShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(250, 250);
            this.gunaShadowPanel1.TabIndex = 0;
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaSeparator1.LineColor = System.Drawing.Color.Black;
            this.gunaSeparator1.Location = new System.Drawing.Point(18, 183);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(210, 10);
            this.gunaSeparator1.TabIndex = 2;
            this.gunaSeparator1.Thickness = 2;
            // 
            // imProd
            // 
            this.imProd.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(238)))), ((int)(((byte)(234)))));
            this.imProd.Image = global::Restaurant_Management_App.Properties.Resources.ba_rọi_béo;
            this.imProd.Location = new System.Drawing.Point(41, 22);
            this.imProd.Name = "imProd";
            this.imProd.Size = new System.Drawing.Size(167, 155);
            this.imProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imProd.TabIndex = 1;
            this.imProd.TabStop = false;
            this.imProd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.imProd_MouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtProdName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 199);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 51);
            this.panel1.TabIndex = 0;
            // 
            // txtProdName
            // 
            this.txtProdName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProdName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(238)))), ((int)(((byte)(234)))));
            this.txtProdName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProdName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdName.Location = new System.Drawing.Point(41, 3);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.ReadOnly = true;
            this.txtProdName.Size = new System.Drawing.Size(167, 35);
            this.txtProdName.TabIndex = 0;
            this.txtProdName.Text = "";
            // 
            // Product
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.gunaShadowPanel1);
            this.Name = "Product";
            this.Size = new System.Drawing.Size(250, 250);
            this.gunaShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imProd)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox txtProdName;
        public Guna.UI.WinForms.GunaPictureBox imProd;
    }
}
