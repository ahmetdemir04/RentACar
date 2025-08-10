namespace RentACar
{
    partial class FrmShortCarList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmShortCarList));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bSelect = new Guna.UI2.WinForms.Guna2Button();
            this.tPlaka = new System.Windows.Forms.Label();
            this.tSansizman = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tMarka = new System.Windows.Forms.Label();
            this.tKm = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tModel = new System.Windows.Forms.Label();
            this.tGunluk = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tYil = new System.Windows.Forms.Label();
            this.tYakitTipi = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tRenk = new System.Windows.Forms.Label();
            this.pcboxCar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.gridCarList = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcboxCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCarList)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.guna2Panel1);
            this.splitContainer1.Panel1.Controls.Add(this.pcboxCar);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridCarList);
            this.splitContainer1.Size = new System.Drawing.Size(1078, 582);
            this.splitContainer1.SplitterDistance = 287;
            this.splitContainer1.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.bSelect);
            this.guna2Panel1.Controls.Add(this.tPlaka);
            this.guna2Panel1.Controls.Add(this.tSansizman);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.tMarka);
            this.guna2Panel1.Controls.Add(this.tKm);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.label16);
            this.guna2Panel1.Controls.Add(this.tModel);
            this.guna2Panel1.Controls.Add(this.tGunluk);
            this.guna2Panel1.Controls.Add(this.label12);
            this.guna2Panel1.Controls.Add(this.label14);
            this.guna2Panel1.Controls.Add(this.tYil);
            this.guna2Panel1.Controls.Add(this.tYakitTipi);
            this.guna2Panel1.Controls.Add(this.label10);
            this.guna2Panel1.Controls.Add(this.label8);
            this.guna2Panel1.Controls.Add(this.tRenk);
            this.guna2Panel1.Location = new System.Drawing.Point(32, 186);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(221, 375);
            this.guna2Panel1.TabIndex = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(53, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 61;
            this.label1.Text = "Plaka:";
            // 
            // bSelect
            // 
            this.bSelect.AutoRoundedCorners = true;
            this.bSelect.BackColor = System.Drawing.Color.Transparent;
            this.bSelect.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bSelect.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bSelect.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bSelect.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bSelect.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.bSelect.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bSelect.ForeColor = System.Drawing.Color.White;
            this.bSelect.Location = new System.Drawing.Point(45, 333);
            this.bSelect.Name = "bSelect";
            this.bSelect.Size = new System.Drawing.Size(132, 27);
            this.bSelect.TabIndex = 79;
            this.bSelect.Text = "Seç";
            this.bSelect.Click += new System.EventHandler(this.bSelect_Click);
            // 
            // tPlaka
            // 
            this.tPlaka.AutoSize = true;
            this.tPlaka.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tPlaka.ForeColor = System.Drawing.Color.White;
            this.tPlaka.Location = new System.Drawing.Point(111, 12);
            this.tPlaka.Name = "tPlaka";
            this.tPlaka.Size = new System.Drawing.Size(22, 21);
            this.tPlaka.TabIndex = 62;
            this.tPlaka.Text = "...";
            // 
            // tSansizman
            // 
            this.tSansizman.AutoSize = true;
            this.tSansizman.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSansizman.ForeColor = System.Drawing.Color.White;
            this.tSansizman.Location = new System.Drawing.Point(112, 299);
            this.tSansizman.Name = "tSansizman";
            this.tSansizman.Size = new System.Drawing.Size(22, 21);
            this.tSansizman.TabIndex = 78;
            this.tSansizman.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(46, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 21);
            this.label4.TabIndex = 63;
            this.label4.Text = "Marka:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 77;
            this.label3.Text = "Şansızman:";
            // 
            // tMarka
            // 
            this.tMarka.AutoSize = true;
            this.tMarka.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tMarka.ForeColor = System.Drawing.Color.White;
            this.tMarka.Location = new System.Drawing.Point(111, 47);
            this.tMarka.Name = "tMarka";
            this.tMarka.Size = new System.Drawing.Size(22, 21);
            this.tMarka.TabIndex = 64;
            this.tMarka.Text = "...";
            // 
            // tKm
            // 
            this.tKm.AutoSize = true;
            this.tKm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tKm.ForeColor = System.Drawing.Color.White;
            this.tKm.Location = new System.Drawing.Point(111, 263);
            this.tKm.Name = "tKm";
            this.tKm.Size = new System.Drawing.Size(22, 21);
            this.tKm.TabIndex = 76;
            this.tKm.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(46, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 21);
            this.label6.TabIndex = 65;
            this.label6.Text = "Model:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(67, 263);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 21);
            this.label16.TabIndex = 75;
            this.label16.Text = "Km:";
            // 
            // tModel
            // 
            this.tModel.AutoSize = true;
            this.tModel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tModel.ForeColor = System.Drawing.Color.White;
            this.tModel.Location = new System.Drawing.Point(111, 85);
            this.tModel.Name = "tModel";
            this.tModel.Size = new System.Drawing.Size(22, 21);
            this.tModel.TabIndex = 66;
            this.tModel.Text = "...";
            // 
            // tGunluk
            // 
            this.tGunluk.AutoSize = true;
            this.tGunluk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tGunluk.ForeColor = System.Drawing.Color.White;
            this.tGunluk.Location = new System.Drawing.Point(111, 230);
            this.tGunluk.Name = "tGunluk";
            this.tGunluk.Size = new System.Drawing.Size(22, 21);
            this.tGunluk.TabIndex = 74;
            this.tGunluk.Text = "...";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(73, 119);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 21);
            this.label12.TabIndex = 67;
            this.label12.Text = "Yıl:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(40, 230);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 21);
            this.label14.TabIndex = 73;
            this.label14.Text = "Günlük:";
            // 
            // tYil
            // 
            this.tYil.AutoSize = true;
            this.tYil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tYil.ForeColor = System.Drawing.Color.White;
            this.tYil.Location = new System.Drawing.Point(111, 119);
            this.tYil.Name = "tYil";
            this.tYil.Size = new System.Drawing.Size(22, 21);
            this.tYil.TabIndex = 68;
            this.tYil.Text = "...";
            // 
            // tYakitTipi
            // 
            this.tYakitTipi.AutoSize = true;
            this.tYakitTipi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tYakitTipi.ForeColor = System.Drawing.Color.White;
            this.tYakitTipi.Location = new System.Drawing.Point(111, 192);
            this.tYakitTipi.Name = "tYakitTipi";
            this.tYakitTipi.Size = new System.Drawing.Size(22, 21);
            this.tYakitTipi.TabIndex = 72;
            this.tYakitTipi.Text = "...";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(55, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 21);
            this.label10.TabIndex = 69;
            this.label10.Text = "Renk:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(28, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 21);
            this.label8.TabIndex = 71;
            this.label8.Text = "Yakıt Tipi:";
            // 
            // tRenk
            // 
            this.tRenk.AutoSize = true;
            this.tRenk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tRenk.ForeColor = System.Drawing.Color.White;
            this.tRenk.Location = new System.Drawing.Point(111, 154);
            this.tRenk.Name = "tRenk";
            this.tRenk.Size = new System.Drawing.Size(22, 21);
            this.tRenk.TabIndex = 70;
            this.tRenk.Text = "...";
            // 
            // pcboxCar
            // 
            this.pcboxCar.BorderRadius = 10;
            this.pcboxCar.Image = global::RentACar.Properties.Resources.default_car;
            this.pcboxCar.ImageRotate = 0F;
            this.pcboxCar.Location = new System.Drawing.Point(58, 12);
            this.pcboxCar.Name = "pcboxCar";
            this.pcboxCar.Size = new System.Drawing.Size(161, 168);
            this.pcboxCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcboxCar.TabIndex = 60;
            this.pcboxCar.TabStop = false;
            // 
            // gridCarList
            // 
            this.gridCarList.AllowUserToAddRows = false;
            this.gridCarList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.gridCarList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridCarList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCarList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridCarList.ColumnHeadersHeight = 40;
            this.gridCarList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridCarList.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridCarList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCarList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.gridCarList.Location = new System.Drawing.Point(0, 0);
            this.gridCarList.Name = "gridCarList";
            this.gridCarList.ReadOnly = true;
            this.gridCarList.RowHeadersVisible = false;
            this.gridCarList.RowHeadersWidth = 51;
            this.gridCarList.Size = new System.Drawing.Size(787, 582);
            this.gridCarList.TabIndex = 1;
            this.gridCarList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.gridCarList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.gridCarList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridCarList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridCarList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridCarList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridCarList.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.gridCarList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.gridCarList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.gridCarList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridCarList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridCarList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridCarList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridCarList.ThemeStyle.HeaderStyle.Height = 40;
            this.gridCarList.ThemeStyle.ReadOnly = true;
            this.gridCarList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.gridCarList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridCarList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridCarList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.gridCarList.ThemeStyle.RowsStyle.Height = 22;
            this.gridCarList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.gridCarList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gridCarList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCarList_CellDoubleClick);
            // 
            // FrmShortCarList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1078, 582);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmShortCarList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShortCarList";
            this.Load += new System.EventHandler(this.ShortCarList_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcboxCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCarList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private Guna.UI2.WinForms.Guna2DataGridView gridCarList;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox pcboxCar;
        private System.Windows.Forms.Label tKm;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label tGunluk;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label tYakitTipi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label tRenk;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label tYil;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label tModel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label tMarka;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label tPlaka;
        private System.Windows.Forms.Label tSansizman;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button bSelect;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}