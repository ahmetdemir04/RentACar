namespace RentACar
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bExit = new Guna.UI2.WinForms.Guna2Button();
            this.bSales = new Guna.UI2.WinForms.Guna2Button();
            this.bContract = new Guna.UI2.WinForms.Guna2Button();
            this.bCarList = new Guna.UI2.WinForms.Guna2Button();
            this.bCarRegistration = new Guna.UI2.WinForms.Guna2Button();
            this.bListCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.bAddCustomer = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.splitContainer1.Panel1.Controls.Add(this.bExit);
            this.splitContainer1.Panel1.Controls.Add(this.bSales);
            this.splitContainer1.Panel1.Controls.Add(this.bContract);
            this.splitContainer1.Panel1.Controls.Add(this.bCarList);
            this.splitContainer1.Panel1.Controls.Add(this.bCarRegistration);
            this.splitContainer1.Panel1.Controls.Add(this.bListCustomer);
            this.splitContainer1.Panel1.Controls.Add(this.bAddCustomer);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.splitContainer1.Size = new System.Drawing.Size(1121, 470);
            this.splitContainer1.SplitterDistance = 99;
            this.splitContainer1.TabIndex = 0;
            // 
            // bExit
            // 
            this.bExit.AutoRoundedCorners = true;
            this.bExit.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.bExit.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.bExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(90)))));
            this.bExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bExit.ForeColor = System.Drawing.Color.White;
            this.bExit.Image = global::RentACar.Properties.Resources.exit;
            this.bExit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bExit.ImageSize = new System.Drawing.Size(35, 30);
            this.bExit.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.bExit.Location = new System.Drawing.Point(991, 27);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(106, 45);
            this.bExit.TabIndex = 6;
            this.bExit.Text = "Çıkış";
            this.bExit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // bSales
            // 
            this.bSales.AutoRoundedCorners = true;
            this.bSales.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.bSales.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.bSales.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bSales.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bSales.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bSales.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bSales.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.bSales.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSales.ForeColor = System.Drawing.Color.White;
            this.bSales.Image = global::RentACar.Properties.Resources.growth;
            this.bSales.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bSales.ImageSize = new System.Drawing.Size(35, 30);
            this.bSales.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.bSales.Location = new System.Drawing.Point(861, 27);
            this.bSales.Name = "bSales";
            this.bSales.Size = new System.Drawing.Size(124, 45);
            this.bSales.TabIndex = 5;
            this.bSales.Text = "Satışlar";
            this.bSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.bSales.Click += new System.EventHandler(this.bSales_Click);
            // 
            // bContract
            // 
            this.bContract.AutoRoundedCorners = true;
            this.bContract.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.bContract.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.bContract.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bContract.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bContract.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bContract.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bContract.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.bContract.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bContract.ForeColor = System.Drawing.Color.White;
            this.bContract.Image = global::RentACar.Properties.Resources.agreement;
            this.bContract.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bContract.ImageSize = new System.Drawing.Size(35, 30);
            this.bContract.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.bContract.Location = new System.Drawing.Point(720, 27);
            this.bContract.Name = "bContract";
            this.bContract.Size = new System.Drawing.Size(135, 45);
            this.bContract.TabIndex = 4;
            this.bContract.Text = "Sözleşme";
            this.bContract.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.bContract.Click += new System.EventHandler(this.bContract_Click);
            // 
            // bCarList
            // 
            this.bCarList.AutoRoundedCorners = true;
            this.bCarList.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.bCarList.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.bCarList.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bCarList.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bCarList.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bCarList.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bCarList.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.bCarList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCarList.ForeColor = System.Drawing.Color.White;
            this.bCarList.Image = global::RentACar.Properties.Resources.registration_certificate;
            this.bCarList.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bCarList.ImageSize = new System.Drawing.Size(35, 30);
            this.bCarList.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.bCarList.Location = new System.Drawing.Point(541, 27);
            this.bCarList.Name = "bCarList";
            this.bCarList.Size = new System.Drawing.Size(172, 45);
            this.bCarList.TabIndex = 3;
            this.bCarList.Text = "Araç Listeleme";
            this.bCarList.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.bCarList.Click += new System.EventHandler(this.bCarList_Click);
            // 
            // bCarRegistration
            // 
            this.bCarRegistration.AutoRoundedCorners = true;
            this.bCarRegistration.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.bCarRegistration.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.bCarRegistration.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bCarRegistration.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bCarRegistration.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bCarRegistration.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bCarRegistration.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.bCarRegistration.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCarRegistration.ForeColor = System.Drawing.Color.White;
            this.bCarRegistration.Image = global::RentACar.Properties.Resources.car;
            this.bCarRegistration.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bCarRegistration.ImageSize = new System.Drawing.Size(35, 30);
            this.bCarRegistration.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.bCarRegistration.Location = new System.Drawing.Point(397, 27);
            this.bCarRegistration.Name = "bCarRegistration";
            this.bCarRegistration.Size = new System.Drawing.Size(138, 45);
            this.bCarRegistration.TabIndex = 2;
            this.bCarRegistration.Text = "Araç Kayıt";
            this.bCarRegistration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.bCarRegistration.Click += new System.EventHandler(this.bCarRegistration_Click);
            // 
            // bListCustomer
            // 
            this.bListCustomer.AutoRoundedCorners = true;
            this.bListCustomer.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.bListCustomer.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.bListCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bListCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bListCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bListCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bListCustomer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.bListCustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bListCustomer.ForeColor = System.Drawing.Color.White;
            this.bListCustomer.Image = global::RentACar.Properties.Resources.customer__2_;
            this.bListCustomer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bListCustomer.ImageSize = new System.Drawing.Size(35, 30);
            this.bListCustomer.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.bListCustomer.Location = new System.Drawing.Point(200, 27);
            this.bListCustomer.Name = "bListCustomer";
            this.bListCustomer.Size = new System.Drawing.Size(191, 45);
            this.bListCustomer.TabIndex = 1;
            this.bListCustomer.Text = "Müşteri Listeleme";
            this.bListCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.bListCustomer.Click += new System.EventHandler(this.bListCustomer_Click);
            // 
            // bAddCustomer
            // 
            this.bAddCustomer.AutoRoundedCorners = true;
            this.bAddCustomer.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.bAddCustomer.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.bAddCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bAddCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bAddCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bAddCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bAddCustomer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.bAddCustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAddCustomer.ForeColor = System.Drawing.Color.White;
            this.bAddCustomer.Image = global::RentACar.Properties.Resources.customer__1_;
            this.bAddCustomer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bAddCustomer.ImageSize = new System.Drawing.Size(35, 30);
            this.bAddCustomer.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.bAddCustomer.Location = new System.Drawing.Point(18, 27);
            this.bAddCustomer.Name = "bAddCustomer";
            this.bAddCustomer.Size = new System.Drawing.Size(176, 45);
            this.bAddCustomer.TabIndex = 0;
            this.bAddCustomer.Text = "Müşteri Ekleme";
            this.bAddCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.bAddCustomer.Click += new System.EventHandler(this.bAddCustomer_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1121, 470);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private Guna.UI2.WinForms.Guna2Button bAddCustomer;
        private Guna.UI2.WinForms.Guna2Button bListCustomer;
        private Guna.UI2.WinForms.Guna2Button bExit;
        private Guna.UI2.WinForms.Guna2Button bSales;
        private Guna.UI2.WinForms.Guna2Button bContract;
        private Guna.UI2.WinForms.Guna2Button bCarList;
        private Guna.UI2.WinForms.Guna2Button bCarRegistration;
    }
}

