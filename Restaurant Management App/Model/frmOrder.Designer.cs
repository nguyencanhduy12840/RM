namespace Restaurant_Management_App.Model
{
    partial class frmOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.btDinIn = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.btTakeAway = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.btDelivery = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.btExit = new Guna.UI.WinForms.GunaPictureBox();
            this.lbwaiter = new Guna.UI.WinForms.GunaLabel();
            this.lbtable = new Guna.UI.WinForms.GunaLabel();
            this.btKOT = new Guna.UI.WinForms.GunaTileButton();
            this.btBill = new Guna.UI.WinForms.GunaTileButton();
            this.btHold = new Guna.UI.WinForms.GunaTileButton();
            this.btNew = new Guna.UI.WinForms.GunaTileButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.btCheckOut = new Guna.UI.WinForms.GunaLabel();
            this.txtSum = new Guna.UI.WinForms.GunaTextBox();
            this.pnProd = new System.Windows.Forms.FlowLayoutPanel();
            this.gunaDataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.dgvstt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvproID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvsl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnCategory = new System.Windows.Forms.FlowLayoutPanel();
            this.btAllCategory = new Guna.UI.WinForms.GunaAdvenceButton();
            this.tbSearch = new Guna.UI.WinForms.GunaTextBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btExit)).BeginInit();
            this.gunaPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).BeginInit();
            this.pnCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(107)))), ((int)(((byte)(93)))));
            this.gunaPanel1.Controls.Add(this.btDinIn);
            this.gunaPanel1.Controls.Add(this.btTakeAway);
            this.gunaPanel1.Controls.Add(this.btDelivery);
            this.gunaPanel1.Controls.Add(this.btExit);
            this.gunaPanel1.Controls.Add(this.lbwaiter);
            this.gunaPanel1.Controls.Add(this.lbtable);
            this.gunaPanel1.Controls.Add(this.btKOT);
            this.gunaPanel1.Controls.Add(this.btBill);
            this.gunaPanel1.Controls.Add(this.btHold);
            this.gunaPanel1.Controls.Add(this.btNew);
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1416, 116);
            this.gunaPanel1.TabIndex = 0;
            // 
            // btDinIn
            // 
            this.btDinIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btDinIn.AnimationHoverSpeed = 0.07F;
            this.btDinIn.AnimationSpeed = 0.03F;
            this.btDinIn.BackColor = System.Drawing.Color.Transparent;
            this.btDinIn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(227)))), ((int)(((byte)(213)))));
            this.btDinIn.BorderColor = System.Drawing.Color.Black;
            this.btDinIn.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btDinIn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(144)))), ((int)(((byte)(114)))));
            this.btDinIn.CheckedBorderColor = System.Drawing.Color.Black;
            this.btDinIn.CheckedForeColor = System.Drawing.Color.Black;
            this.btDinIn.CheckedImage = global::Restaurant_Management_App.Properties.Resources.dinner_table1;
            this.btDinIn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btDinIn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btDinIn.FocusedColor = System.Drawing.Color.Empty;
            this.btDinIn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btDinIn.ForeColor = System.Drawing.Color.Black;
            this.btDinIn.Image = global::Restaurant_Management_App.Properties.Resources.dinner_table1;
            this.btDinIn.ImageSize = new System.Drawing.Size(52, 52);
            this.btDinIn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btDinIn.Location = new System.Drawing.Point(972, 12);
            this.btDinIn.Name = "btDinIn";
            this.btDinIn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(220)))), ((int)(((byte)(167)))));
            this.btDinIn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btDinIn.OnHoverForeColor = System.Drawing.Color.White;
            this.btDinIn.OnHoverImage = null;
            this.btDinIn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btDinIn.OnPressedColor = System.Drawing.Color.Black;
            this.btDinIn.Radius = 30;
            this.btDinIn.Size = new System.Drawing.Size(95, 95);
            this.btDinIn.TabIndex = 14;
            this.btDinIn.Text = "Ăn Tại Bàn";
            this.btDinIn.Click += new System.EventHandler(this.btDineIn_Click);
            // 
            // btTakeAway
            // 
            this.btTakeAway.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btTakeAway.AnimationHoverSpeed = 0.07F;
            this.btTakeAway.AnimationSpeed = 0.03F;
            this.btTakeAway.BackColor = System.Drawing.Color.Transparent;
            this.btTakeAway.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(227)))), ((int)(((byte)(213)))));
            this.btTakeAway.BorderColor = System.Drawing.Color.Black;
            this.btTakeAway.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btTakeAway.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(144)))), ((int)(((byte)(114)))));
            this.btTakeAway.CheckedBorderColor = System.Drawing.Color.Black;
            this.btTakeAway.CheckedForeColor = System.Drawing.Color.Black;
            this.btTakeAway.CheckedImage = global::Restaurant_Management_App.Properties.Resources.take_away;
            this.btTakeAway.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btTakeAway.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btTakeAway.FocusedColor = System.Drawing.Color.Empty;
            this.btTakeAway.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btTakeAway.ForeColor = System.Drawing.Color.Black;
            this.btTakeAway.Image = global::Restaurant_Management_App.Properties.Resources.take_away;
            this.btTakeAway.ImageSize = new System.Drawing.Size(52, 52);
            this.btTakeAway.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btTakeAway.Location = new System.Drawing.Point(869, 12);
            this.btTakeAway.Name = "btTakeAway";
            this.btTakeAway.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(220)))), ((int)(((byte)(167)))));
            this.btTakeAway.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btTakeAway.OnHoverForeColor = System.Drawing.Color.White;
            this.btTakeAway.OnHoverImage = null;
            this.btTakeAway.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btTakeAway.OnPressedColor = System.Drawing.Color.Black;
            this.btTakeAway.Radius = 30;
            this.btTakeAway.Size = new System.Drawing.Size(95, 95);
            this.btTakeAway.TabIndex = 13;
            this.btTakeAway.Text = "Mang Đi";
            this.btTakeAway.Click += new System.EventHandler(this.btTakeAway_Click);
            // 
            // btDelivery
            // 
            this.btDelivery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btDelivery.AnimationHoverSpeed = 0.07F;
            this.btDelivery.AnimationSpeed = 0.03F;
            this.btDelivery.BackColor = System.Drawing.Color.Transparent;
            this.btDelivery.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(227)))), ((int)(((byte)(213)))));
            this.btDelivery.BorderColor = System.Drawing.Color.Black;
            this.btDelivery.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btDelivery.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(144)))), ((int)(((byte)(114)))));
            this.btDelivery.CheckedBorderColor = System.Drawing.Color.Black;
            this.btDelivery.CheckedForeColor = System.Drawing.Color.Black;
            this.btDelivery.CheckedImage = global::Restaurant_Management_App.Properties.Resources.delivery;
            this.btDelivery.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btDelivery.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btDelivery.FocusedColor = System.Drawing.Color.Empty;
            this.btDelivery.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btDelivery.ForeColor = System.Drawing.Color.Black;
            this.btDelivery.Image = global::Restaurant_Management_App.Properties.Resources.delivery;
            this.btDelivery.ImageSize = new System.Drawing.Size(52, 52);
            this.btDelivery.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btDelivery.Location = new System.Drawing.Point(766, 12);
            this.btDelivery.Name = "btDelivery";
            this.btDelivery.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(220)))), ((int)(((byte)(167)))));
            this.btDelivery.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btDelivery.OnHoverForeColor = System.Drawing.Color.White;
            this.btDelivery.OnHoverImage = null;
            this.btDelivery.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btDelivery.OnPressedColor = System.Drawing.Color.Black;
            this.btDelivery.Radius = 30;
            this.btDelivery.Size = new System.Drawing.Size(95, 95);
            this.btDelivery.TabIndex = 12;
            this.btDelivery.Text = "Giao Hàng";
            this.btDelivery.Click += new System.EventHandler(this.btDelivery_Click);
            // 
            // btExit
            // 
            this.btExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btExit.BaseColor = System.Drawing.Color.White;
            this.btExit.Image = global::Restaurant_Management_App.Properties.Resources.button;
            this.btExit.Location = new System.Drawing.Point(1323, 26);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(64, 63);
            this.btExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btExit.TabIndex = 11;
            this.btExit.TabStop = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // lbwaiter
            // 
            this.lbwaiter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbwaiter.AutoSize = true;
            this.lbwaiter.BackColor = System.Drawing.Color.Transparent;
            this.lbwaiter.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbwaiter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbwaiter.Location = new System.Drawing.Point(1085, 57);
            this.lbwaiter.Name = "lbwaiter";
            this.lbwaiter.Size = new System.Drawing.Size(0, 31);
            this.lbwaiter.TabIndex = 10;
            // 
            // lbtable
            // 
            this.lbtable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbtable.AutoSize = true;
            this.lbtable.BackColor = System.Drawing.Color.Transparent;
            this.lbtable.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbtable.Location = new System.Drawing.Point(1085, 26);
            this.lbtable.Name = "lbtable";
            this.lbtable.Size = new System.Drawing.Size(0, 31);
            this.lbtable.TabIndex = 9;
            // 
            // btKOT
            // 
            this.btKOT.AnimationHoverSpeed = 0.07F;
            this.btKOT.AnimationSpeed = 0.03F;
            this.btKOT.BackColor = System.Drawing.Color.Transparent;
            this.btKOT.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(227)))), ((int)(((byte)(213)))));
            this.btKOT.BorderColor = System.Drawing.Color.Black;
            this.btKOT.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btKOT.FocusedColor = System.Drawing.Color.Empty;
            this.btKOT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKOT.ForeColor = System.Drawing.Color.Black;
            this.btKOT.Image = global::Restaurant_Management_App.Properties.Resources.cooking;
            this.btKOT.ImageSize = new System.Drawing.Size(52, 52);
            this.btKOT.Location = new System.Drawing.Point(512, 12);
            this.btKOT.Name = "btKOT";
            this.btKOT.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(144)))), ((int)(((byte)(114)))));
            this.btKOT.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btKOT.OnHoverForeColor = System.Drawing.Color.White;
            this.btKOT.OnHoverImage = null;
            this.btKOT.OnPressedColor = System.Drawing.Color.Black;
            this.btKOT.Radius = 30;
            this.btKOT.Size = new System.Drawing.Size(95, 95);
            this.btKOT.TabIndex = 5;
            this.btKOT.Text = "Nhận Đơn";
            this.btKOT.Click += new System.EventHandler(this.btKOT_Click);
            // 
            // btBill
            // 
            this.btBill.AnimationHoverSpeed = 0.07F;
            this.btBill.AnimationSpeed = 0.03F;
            this.btBill.BackColor = System.Drawing.Color.Transparent;
            this.btBill.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(227)))), ((int)(((byte)(213)))));
            this.btBill.BorderColor = System.Drawing.Color.Black;
            this.btBill.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btBill.FocusedColor = System.Drawing.Color.Empty;
            this.btBill.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBill.ForeColor = System.Drawing.Color.Black;
            this.btBill.Image = global::Restaurant_Management_App.Properties.Resources.bill;
            this.btBill.ImageSize = new System.Drawing.Size(52, 52);
            this.btBill.Location = new System.Drawing.Point(409, 12);
            this.btBill.Name = "btBill";
            this.btBill.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(144)))), ((int)(((byte)(114)))));
            this.btBill.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btBill.OnHoverForeColor = System.Drawing.Color.White;
            this.btBill.OnHoverImage = null;
            this.btBill.OnPressedColor = System.Drawing.Color.Black;
            this.btBill.Radius = 30;
            this.btBill.Size = new System.Drawing.Size(95, 95);
            this.btBill.TabIndex = 4;
            this.btBill.Text = "Hóa Đơn";
            this.btBill.Click += new System.EventHandler(this.btBill_Click);
            // 
            // btHold
            // 
            this.btHold.AnimationHoverSpeed = 0.07F;
            this.btHold.AnimationSpeed = 0.03F;
            this.btHold.BackColor = System.Drawing.Color.Transparent;
            this.btHold.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(227)))), ((int)(((byte)(213)))));
            this.btHold.BorderColor = System.Drawing.Color.Black;
            this.btHold.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btHold.FocusedColor = System.Drawing.Color.Empty;
            this.btHold.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHold.ForeColor = System.Drawing.Color.Black;
            this.btHold.Image = global::Restaurant_Management_App.Properties.Resources.checklist;
            this.btHold.ImageSize = new System.Drawing.Size(52, 52);
            this.btHold.Location = new System.Drawing.Point(306, 12);
            this.btHold.Name = "btHold";
            this.btHold.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(144)))), ((int)(((byte)(114)))));
            this.btHold.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btHold.OnHoverForeColor = System.Drawing.Color.White;
            this.btHold.OnHoverImage = null;
            this.btHold.OnPressedColor = System.Drawing.Color.Black;
            this.btHold.Radius = 30;
            this.btHold.Size = new System.Drawing.Size(95, 95);
            this.btHold.TabIndex = 3;
            this.btHold.Text = "Đơn Chờ";
            // 
            // btNew
            // 
            this.btNew.AnimationHoverSpeed = 0.07F;
            this.btNew.AnimationSpeed = 0.03F;
            this.btNew.BackColor = System.Drawing.Color.Transparent;
            this.btNew.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(227)))), ((int)(((byte)(213)))));
            this.btNew.BorderColor = System.Drawing.Color.Black;
            this.btNew.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btNew.FocusedColor = System.Drawing.Color.Empty;
            this.btNew.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNew.ForeColor = System.Drawing.Color.Black;
            this.btNew.Image = global::Restaurant_Management_App.Properties.Resources.new__1_;
            this.btNew.ImageSize = new System.Drawing.Size(52, 52);
            this.btNew.Location = new System.Drawing.Point(203, 12);
            this.btNew.Name = "btNew";
            this.btNew.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(144)))), ((int)(((byte)(114)))));
            this.btNew.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btNew.OnHoverForeColor = System.Drawing.Color.White;
            this.btNew.OnHoverImage = null;
            this.btNew.OnPressedColor = System.Drawing.Color.Black;
            this.btNew.Radius = 30;
            this.btNew.Size = new System.Drawing.Size(95, 95);
            this.btNew.TabIndex = 2;
            this.btNew.Text = "Đơn Mới";
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gunaLabel1.Location = new System.Drawing.Point(62, 45);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(123, 31);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "ĐẶT MÓN";
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(107)))), ((int)(((byte)(93)))));
            this.gunaPanel2.Controls.Add(this.gunaButton1);
            this.gunaPanel2.Controls.Add(this.btCheckOut);
            this.gunaPanel2.Controls.Add(this.txtSum);
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaPanel2.Location = new System.Drawing.Point(0, 754);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(1416, 70);
            this.gunaPanel2.TabIndex = 1;
            // 
            // gunaButton1
            // 
            this.gunaButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(227)))), ((int)(((byte)(213)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.Black;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(972, 8);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(220)))), ((int)(((byte)(167)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 20;
            this.gunaButton1.Size = new System.Drawing.Size(160, 55);
            this.gunaButton1.TabIndex = 14;
            this.gunaButton1.Text = "Thanh Toán";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // btCheckOut
            // 
            this.btCheckOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCheckOut.AutoSize = true;
            this.btCheckOut.BackColor = System.Drawing.Color.Transparent;
            this.btCheckOut.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCheckOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCheckOut.Location = new System.Drawing.Point(1134, 15);
            this.btCheckOut.Name = "btCheckOut";
            this.btCheckOut.Size = new System.Drawing.Size(91, 41);
            this.btCheckOut.TabIndex = 13;
            this.btCheckOut.Text = "Tổng";
            // 
            // txtSum
            // 
            this.txtSum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSum.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(238)))), ((int)(((byte)(234)))));
            this.txtSum.BorderColor = System.Drawing.Color.Transparent;
            this.txtSum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSum.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(238)))), ((int)(((byte)(234)))));
            this.txtSum.FocusedBorderColor = System.Drawing.Color.Teal;
            this.txtSum.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSum.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSum.ForeColor = System.Drawing.Color.Black;
            this.txtSum.Location = new System.Drawing.Point(1230, 12);
            this.txtSum.Name = "txtSum";
            this.txtSum.PasswordChar = '\0';
            this.txtSum.ReadOnly = true;
            this.txtSum.SelectedText = "";
            this.txtSum.Size = new System.Drawing.Size(164, 46);
            this.txtSum.TabIndex = 12;
            this.txtSum.Text = "0";
            // 
            // pnProd
            // 
            this.pnProd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnProd.AutoScroll = true;
            this.pnProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(238)))), ((int)(((byte)(234)))));
            this.pnProd.Location = new System.Drawing.Point(203, 192);
            this.pnProd.Name = "pnProd";
            this.pnProd.Size = new System.Drawing.Size(692, 546);
            this.pnProd.TabIndex = 3;
            // 
            // gunaDataGridView1
            // 
            this.gunaDataGridView1.AllowUserToAddRows = false;
            this.gunaDataGridView1.AllowUserToResizeColumns = false;
            this.gunaDataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.gunaDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(238)))), ((int)(((byte)(234)))));
            this.gunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(107)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(179)))), ((int)(((byte)(132)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.gunaDataGridView1.ColumnHeadersHeight = 40;
            this.gunaDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gunaDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvstt,
            this.dgvid,
            this.dgvproID,
            this.dgvname,
            this.dgvsl,
            this.dgvprice,
            this.dgvtong});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridView1.DefaultCellStyle = dataGridViewCellStyle9;
            this.gunaDataGridView1.EnableHeadersVisualStyles = false;
            this.gunaDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(238)))), ((int)(((byte)(234)))));
            this.gunaDataGridView1.Location = new System.Drawing.Point(901, 192);
            this.gunaDataGridView1.Name = "gunaDataGridView1";
            this.gunaDataGridView1.RowHeadersVisible = false;
            this.gunaDataGridView1.RowHeadersWidth = 51;
            this.gunaDataGridView1.RowTemplate.Height = 35;
            this.gunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridView1.Size = new System.Drawing.Size(493, 546);
            this.gunaDataGridView1.TabIndex = 9;
            this.gunaDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(238)))), ((int)(((byte)(234)))));
            this.gunaDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(238)))), ((int)(((byte)(234)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(107)))), ((int)(((byte)(93)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Height = 40;
            this.gunaDataGridView1.ThemeStyle.ReadOnly = false;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Height = 35;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.gunaDataGridView1_CellBeginEdit);
            this.gunaDataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gunaDataGridView1_CellFormatting);
            this.gunaDataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaDataGridView1_CellValueChanged);
            this.gunaDataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.gunaDataGridView1_RowsRemoved);
            // 
            // dgvstt
            // 
            this.dgvstt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvstt.FillWeight = 60F;
            this.dgvstt.HeaderText = "STT";
            this.dgvstt.MinimumWidth = 60;
            this.dgvstt.Name = "dgvstt";
            this.dgvstt.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvstt.Width = 60;
            // 
            // dgvid
            // 
            this.dgvid.HeaderText = "id";
            this.dgvid.MinimumWidth = 6;
            this.dgvid.Name = "dgvid";
            this.dgvid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvid.Visible = false;
            // 
            // dgvproID
            // 
            this.dgvproID.HeaderText = "productID";
            this.dgvproID.MinimumWidth = 6;
            this.dgvproID.Name = "dgvproID";
            this.dgvproID.Visible = false;
            // 
            // dgvname
            // 
            this.dgvname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvname.FillWeight = 150F;
            this.dgvname.HeaderText = "Tên";
            this.dgvname.MinimumWidth = 150;
            this.dgvname.Name = "dgvname";
            this.dgvname.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgvsl
            // 
            this.dgvsl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvsl.FillWeight = 40F;
            this.dgvsl.HeaderText = "SL";
            this.dgvsl.MinimumWidth = 40;
            this.dgvsl.Name = "dgvsl";
            // 
            // dgvprice
            // 
            this.dgvprice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvprice.FillWeight = 70F;
            this.dgvprice.HeaderText = "Giá";
            this.dgvprice.MinimumWidth = 70;
            this.dgvprice.Name = "dgvprice";
            // 
            // dgvtong
            // 
            this.dgvtong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvtong.FillWeight = 60F;
            this.dgvtong.HeaderText = "Tổng";
            this.dgvtong.MinimumWidth = 60;
            this.dgvtong.Name = "dgvtong";
            // 
            // pnCategory
            // 
            this.pnCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(166)))), ((int)(((byte)(149)))));
            this.pnCategory.Controls.Add(this.btAllCategory);
            this.pnCategory.Location = new System.Drawing.Point(12, 192);
            this.pnCategory.Name = "pnCategory";
            this.pnCategory.Size = new System.Drawing.Size(173, 546);
            this.pnCategory.TabIndex = 4;
            // 
            // btAllCategory
            // 
            this.btAllCategory.AnimationHoverSpeed = 0.07F;
            this.btAllCategory.AnimationSpeed = 0.03F;
            this.btAllCategory.BackColor = System.Drawing.Color.Transparent;
            this.btAllCategory.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(107)))), ((int)(((byte)(93)))));
            this.btAllCategory.BorderColor = System.Drawing.Color.Black;
            this.btAllCategory.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btAllCategory.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(144)))), ((int)(((byte)(114)))));
            this.btAllCategory.CheckedBorderColor = System.Drawing.Color.Black;
            this.btAllCategory.CheckedForeColor = System.Drawing.Color.White;
            this.btAllCategory.CheckedImage = global::Restaurant_Management_App.Properties.Resources._checked;
            this.btAllCategory.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btAllCategory.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btAllCategory.FocusedColor = System.Drawing.Color.Empty;
            this.btAllCategory.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAllCategory.ForeColor = System.Drawing.Color.White;
            this.btAllCategory.Image = null;
            this.btAllCategory.ImageSize = new System.Drawing.Size(20, 20);
            this.btAllCategory.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btAllCategory.Location = new System.Drawing.Point(3, 3);
            this.btAllCategory.Name = "btAllCategory";
            this.btAllCategory.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(220)))), ((int)(((byte)(167)))));
            this.btAllCategory.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btAllCategory.OnHoverForeColor = System.Drawing.Color.White;
            this.btAllCategory.OnHoverImage = null;
            this.btAllCategory.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btAllCategory.OnPressedColor = System.Drawing.Color.Black;
            this.btAllCategory.Radius = 20;
            this.btAllCategory.Size = new System.Drawing.Size(170, 54);
            this.btAllCategory.TabIndex = 0;
            this.btAllCategory.Text = "Tất Cả";
            this.btAllCategory.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gunaAdvenceButton1_MouseClick);
            // 
            // tbSearch
            // 
            this.tbSearch.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(238)))), ((int)(((byte)(234)))));
            this.tbSearch.BorderColor = System.Drawing.Color.Transparent;
            this.tbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearch.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(238)))), ((int)(((byte)(234)))));
            this.tbSearch.FocusedBorderColor = System.Drawing.Color.Teal;
            this.tbSearch.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.tbSearch.Location = new System.Drawing.Point(203, 140);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PasswordChar = '\0';
            this.tbSearch.SelectedText = "";
            this.tbSearch.Size = new System.Drawing.Size(236, 46);
            this.tbSearch.TabIndex = 11;
            this.tbSearch.Text = "🔎 Search here";
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            this.tbSearch.Enter += new System.EventHandler(this.tbSearch_Enter);
            this.tbSearch.Leave += new System.EventHandler(this.tbSearch_Leave);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.FillWeight = 50F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Restaurant_Management_App.Properties.Resources.pngwing_com__2_;
            this.dataGridViewImageColumn1.MinimumWidth = 50;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn2.FillWeight = 50F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::Restaurant_Management_App.Properties.Resources.pngwing_com__3_;
            this.dataGridViewImageColumn2.MinimumWidth = 50;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn2.Width = 50;
            // 
            // frmOrder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(166)))), ((int)(((byte)(149)))));
            this.ClientSize = new System.Drawing.Size(1416, 824);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.pnCategory);
            this.Controls.Add(this.gunaDataGridView1);
            this.Controls.Add(this.pnProd);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.gunaPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOrder";
            this.Text = "frmOrder";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmOrder_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmOrder_MouseClick);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btExit)).EndInit();
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).EndInit();
            this.pnCategory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaTileButton btNew;
        private Guna.UI.WinForms.GunaTileButton btKOT;
        private Guna.UI.WinForms.GunaTileButton btBill;
        private Guna.UI.WinForms.GunaTileButton btHold;
        private Guna.UI.WinForms.GunaPictureBox btExit;
        private System.Windows.Forms.FlowLayoutPanel pnProd;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.FlowLayoutPanel pnCategory;
        private Guna.UI.WinForms.GunaTextBox tbSearch;
        public Guna.UI.WinForms.GunaDataGridView gunaDataGridView1;
        private Guna.UI.WinForms.GunaTextBox txtSum;
        private Guna.UI.WinForms.GunaLabel btCheckOut;
        private Guna.UI.WinForms.GunaAdvenceTileButton btDelivery;
        private Guna.UI.WinForms.GunaAdvenceTileButton btDinIn;
        private Guna.UI.WinForms.GunaAdvenceTileButton btTakeAway;
        public Guna.UI.WinForms.GunaLabel lbwaiter;
        public Guna.UI.WinForms.GunaLabel lbtable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvstt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvproID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvsl;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtong;
        private Guna.UI.WinForms.GunaAdvenceButton btAllCategory;
        private Guna.UI.WinForms.GunaButton gunaButton1;
    }
}