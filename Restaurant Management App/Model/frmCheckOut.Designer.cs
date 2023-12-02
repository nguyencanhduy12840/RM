namespace Restaurant_Management_App.Model
{
    partial class frmCheckOut
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
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.tbTotal = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.tbChange = new Guna.UI.WinForms.GunaTextBox();
            this.tbreceived = new Guna.UI.WinForms.GunaTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(800, 139);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 480);
            this.panel2.Size = new System.Drawing.Size(800, 72);
            // 
            // header
            // 
            this.header.Size = new System.Drawing.Size(136, 31);
            this.header.Text = "Thanh toán";
            // 
            // btSave
            // 
            this.btSave.FlatAppearance.BorderSize = 0;
            this.btSave.Location = new System.Drawing.Point(23, 13);
            this.btSave.Text = "Lưu";
            // 
            // btExit
            // 
            this.btExit.FlatAppearance.BorderSize = 0;
            this.btExit.Location = new System.Drawing.Point(186, 13);
            this.btExit.Text = "Đóng";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(38, 208);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(145, 28);
            this.gunaLabel1.TabIndex = 16;
            this.gunaLabel1.Text = "Tổng hóa đơn";
            // 
            // tbTotal
            // 
            this.tbTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbTotal.BaseColor = System.Drawing.Color.White;
            this.tbTotal.BorderColor = System.Drawing.Color.Silver;
            this.tbTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTotal.FocusedBaseColor = System.Drawing.Color.White;
            this.tbTotal.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.tbTotal.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotal.Location = new System.Drawing.Point(43, 247);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.PasswordChar = '\0';
            this.tbTotal.ReadOnly = true;
            this.tbTotal.SelectedText = "";
            this.tbTotal.Size = new System.Drawing.Size(315, 45);
            this.tbTotal.TabIndex = 13;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(426, 208);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(91, 28);
            this.gunaLabel2.TabIndex = 17;
            this.gunaLabel2.Text = "Đã nhận";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(426, 317);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(103, 28);
            this.gunaLabel3.TabIndex = 18;
            this.gunaLabel3.Text = "Tiền thừa";
            // 
            // tbChange
            // 
            this.tbChange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbChange.BaseColor = System.Drawing.Color.White;
            this.tbChange.BorderColor = System.Drawing.Color.Silver;
            this.tbChange.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbChange.FocusedBaseColor = System.Drawing.Color.White;
            this.tbChange.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.tbChange.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbChange.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbChange.Location = new System.Drawing.Point(431, 359);
            this.tbChange.Name = "tbChange";
            this.tbChange.PasswordChar = '\0';
            this.tbChange.ReadOnly = true;
            this.tbChange.SelectedText = "";
            this.tbChange.Size = new System.Drawing.Size(315, 45);
            this.tbChange.TabIndex = 15;
            // 
            // tbreceived
            // 
            this.tbreceived.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbreceived.BaseColor = System.Drawing.Color.White;
            this.tbreceived.BorderColor = System.Drawing.Color.Silver;
            this.tbreceived.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbreceived.FocusedBaseColor = System.Drawing.Color.White;
            this.tbreceived.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.tbreceived.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbreceived.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbreceived.Location = new System.Drawing.Point(431, 247);
            this.tbreceived.Name = "tbreceived";
            this.tbreceived.PasswordChar = '\0';
            this.tbreceived.SelectedText = "";
            this.tbreceived.Size = new System.Drawing.Size(315, 45);
            this.tbreceived.TabIndex = 19;
            this.tbreceived.TextChanged += new System.EventHandler(this.gunaTextBox1_TextChanged);
            // 
            // frmCheckOut
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 552);
            this.Controls.Add(this.tbreceived);
            this.Controls.Add(this.tbChange);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.gunaLabel1);
            this.Name = "frmCheckOut";
            this.Text = "frmCheckOut";
            this.Load += new System.EventHandler(this.frmCheckOut_Load);
            this.Controls.SetChildIndex(this.gunaLabel1, 0);
            this.Controls.SetChildIndex(this.tbTotal, 0);
            this.Controls.SetChildIndex(this.gunaLabel2, 0);
            this.Controls.SetChildIndex(this.gunaLabel3, 0);
            this.Controls.SetChildIndex(this.tbChange, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.tbreceived, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        public Guna.UI.WinForms.GunaTextBox tbTotal;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        public Guna.UI.WinForms.GunaTextBox tbChange;
        public Guna.UI.WinForms.GunaTextBox tbreceived;
    }
}