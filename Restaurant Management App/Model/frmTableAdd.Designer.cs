namespace Restaurant_Management_App.Model
{
    partial class frmTableAdd
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
            this.txtName = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Dock = System.Windows.Forms.DockStyle.None;
            this.panel1.Location = new System.Drawing.Point(-8, -6);
            this.panel1.Size = new System.Drawing.Size(388, 134);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 272);
            this.panel2.Size = new System.Drawing.Size(367, 86);
            this.panel2.TabIndex = 2;
            // 
            // header
            // 
            this.header.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.header.Location = new System.Drawing.Point(127, 55);
            this.header.Size = new System.Drawing.Size(120, 31);
            this.header.Text = "Thêm bàn";
            // 
            // rjCircularPictureBox1
            // 
            this.rjCircularPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rjCircularPictureBox1.Location = new System.Drawing.Point(23, 18);
            // 
            // btSave
            // 
            this.btSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btSave.FlatAppearance.BorderSize = 0;
            this.btSave.Location = new System.Drawing.Point(20, 18);
            this.btSave.Text = "Lưu";
            // 
            // btExit
            // 
            this.btExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btExit.FlatAppearance.BorderSize = 0;
            this.btExit.Location = new System.Drawing.Point(208, 18);
            this.btExit.Text = "Đóng";
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
            this.txtName.Location = new System.Drawing.Point(20, 179);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(327, 45);
            this.txtName.TabIndex = 0;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(15, 148);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(45, 28);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Tên";
            // 
            // frmTableAdd
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(367, 358);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.gunaLabel1);
            this.MaximumSize = new System.Drawing.Size(367, 419);
            this.Name = "frmTableAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTableAdd";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.gunaLabel1, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI.WinForms.GunaTextBox txtName;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}