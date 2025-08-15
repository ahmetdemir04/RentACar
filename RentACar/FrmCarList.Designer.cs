namespace RentACar
{
    partial class FrmCarList
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCarList));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ChcDurumu = new Guna.UI2.WinForms.Guna2CheckBox();
            this.CmbSanziman = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.bGuncelle = new Guna.UI2.WinForms.Guna2Button();
            this.pcboxCar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.cmbYakit = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tKiraUcreti = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tKm = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tRenk = new Guna.UI2.WinForms.Guna2TextBox();
            this.tModel = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSeri = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbMarka = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tPlaka = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gridCars = new Guna.UI2.WinForms.Guna2DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcboxCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCars)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.ChcDurumu);
            this.splitContainer1.Panel1.Controls.Add(this.CmbSanziman);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.bGuncelle);
            this.splitContainer1.Panel1.Controls.Add(this.pcboxCar);
            this.splitContainer1.Panel1.Controls.Add(this.cmbYakit);
            this.splitContainer1.Panel1.Controls.Add(this.tKiraUcreti);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.tKm);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.tRenk);
            this.splitContainer1.Panel1.Controls.Add(this.tModel);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.cmbSeri);
            this.splitContainer1.Panel1.Controls.Add(this.cmbMarka);
            this.splitContainer1.Panel1.Controls.Add(this.tPlaka);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1343, 685);
            this.splitContainer1.SplitterDistance = 423;
            this.splitContainer1.TabIndex = 0;
            // 
            // ChcDurumu
            // 
            this.ChcDurumu.AutoSize = true;
            this.ChcDurumu.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ChcDurumu.CheckedState.BorderRadius = 0;
            this.ChcDurumu.CheckedState.BorderThickness = 0;
            this.ChcDurumu.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ChcDurumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChcDurumu.ForeColor = System.Drawing.Color.White;
            this.ChcDurumu.Location = new System.Drawing.Point(118, 251);
            this.ChcDurumu.Name = "ChcDurumu";
            this.ChcDurumu.Size = new System.Drawing.Size(85, 24);
            this.ChcDurumu.TabIndex = 57;
            this.ChcDurumu.Text = "Durumu";
            this.ChcDurumu.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ChcDurumu.UncheckedState.BorderRadius = 0;
            this.ChcDurumu.UncheckedState.BorderThickness = 0;
            this.ChcDurumu.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // CmbSanziman
            // 
            this.CmbSanziman.AutoRoundedCorners = true;
            this.CmbSanziman.BackColor = System.Drawing.Color.Transparent;
            this.CmbSanziman.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbSanziman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSanziman.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbSanziman.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbSanziman.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CmbSanziman.ForeColor = System.Drawing.Color.Black;
            this.CmbSanziman.ItemHeight = 20;
            this.CmbSanziman.Items.AddRange(new object[] {
            "Manuel Şanzıman (Düz Vites)",
            "Otomatik Şanzıman",
            "Yarı Otomatik Şanzıman",
            "Elektrikli Araç Şanzımanı"});
            this.CmbSanziman.Location = new System.Drawing.Point(121, 518);
            this.CmbSanziman.Name = "CmbSanziman";
            this.CmbSanziman.Size = new System.Drawing.Size(250, 26);
            this.CmbSanziman.TabIndex = 56;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(27, 518);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 20);
            this.label10.TabIndex = 55;
            this.label10.Text = "Şansızman:";
            // 
            // bGuncelle
            // 
            this.bGuncelle.AutoRoundedCorners = true;
            this.bGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.bGuncelle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bGuncelle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bGuncelle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bGuncelle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bGuncelle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.bGuncelle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bGuncelle.ForeColor = System.Drawing.Color.White;
            this.bGuncelle.Location = new System.Drawing.Point(118, 631);
            this.bGuncelle.Name = "bGuncelle";
            this.bGuncelle.Size = new System.Drawing.Size(127, 35);
            this.bGuncelle.TabIndex = 54;
            this.bGuncelle.Text = "Güncelle";
            this.bGuncelle.Click += new System.EventHandler(this.bGuncelle_Click);
            // 
            // pcboxCar
            // 
            this.pcboxCar.BorderRadius = 10;
            this.pcboxCar.ImageRotate = 0F;
            this.pcboxCar.Location = new System.Drawing.Point(118, 32);
            this.pcboxCar.Name = "pcboxCar";
            this.pcboxCar.Size = new System.Drawing.Size(195, 198);
            this.pcboxCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcboxCar.TabIndex = 53;
            this.pcboxCar.TabStop = false;
            this.pcboxCar.Click += new System.EventHandler(this.pcboxCar_Click);
            // 
            // cmbYakit
            // 
            this.cmbYakit.AutoRoundedCorners = true;
            this.cmbYakit.BackColor = System.Drawing.Color.Transparent;
            this.cmbYakit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbYakit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYakit.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbYakit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbYakit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbYakit.ForeColor = System.Drawing.Color.Black;
            this.cmbYakit.ItemHeight = 20;
            this.cmbYakit.Items.AddRange(new object[] {
            "Benzin",
            "Dizel",
            "Elektrik",
            "Hibrit",
            "Benzin + Dizel"});
            this.cmbYakit.Location = new System.Drawing.Point(121, 553);
            this.cmbYakit.Name = "cmbYakit";
            this.cmbYakit.Size = new System.Drawing.Size(250, 26);
            this.cmbYakit.TabIndex = 52;
            // 
            // tKiraUcreti
            // 
            this.tKiraUcreti.BorderRadius = 10;
            this.tKiraUcreti.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tKiraUcreti.DefaultText = "0";
            this.tKiraUcreti.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tKiraUcreti.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tKiraUcreti.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tKiraUcreti.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tKiraUcreti.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tKiraUcreti.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tKiraUcreti.ForeColor = System.Drawing.Color.Black;
            this.tKiraUcreti.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tKiraUcreti.Location = new System.Drawing.Point(121, 594);
            this.tKiraUcreti.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tKiraUcreti.MaxLength = 11;
            this.tKiraUcreti.Name = "tKiraUcreti";
            this.tKiraUcreti.PlaceholderText = "";
            this.tKiraUcreti.SelectedText = "";
            this.tKiraUcreti.Size = new System.Drawing.Size(250, 25);
            this.tKiraUcreti.TabIndex = 41;
            this.tKiraUcreti.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tKiraUcreti.MouseEnter += new System.EventHandler(this.tKiraUcreti_MouseEnter);
            this.tKiraUcreti.MouseLeave += new System.EventHandler(this.tKiraUcreti_MouseLeave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(27, 595);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 20);
            this.label8.TabIndex = 51;
            this.label8.Text = "Kira Ücreti:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(67, 555);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 50;
            this.label7.Text = "Yakıt:";
            // 
            // tKm
            // 
            this.tKm.BorderRadius = 10;
            this.tKm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tKm.DefaultText = "";
            this.tKm.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tKm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tKm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tKm.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tKm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tKm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tKm.ForeColor = System.Drawing.Color.Black;
            this.tKm.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tKm.Location = new System.Drawing.Point(118, 481);
            this.tKm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tKm.MaxLength = 11;
            this.tKm.Name = "tKm";
            this.tKm.PlaceholderText = "";
            this.tKm.SelectedText = "";
            this.tKm.Size = new System.Drawing.Size(253, 26);
            this.tKm.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(75, 483);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 49;
            this.label5.Text = "Km:";
            // 
            // tRenk
            // 
            this.tRenk.BorderRadius = 10;
            this.tRenk.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tRenk.DefaultText = "";
            this.tRenk.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tRenk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tRenk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tRenk.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tRenk.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tRenk.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tRenk.ForeColor = System.Drawing.Color.Black;
            this.tRenk.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tRenk.Location = new System.Drawing.Point(121, 441);
            this.tRenk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tRenk.MaxLength = 11;
            this.tRenk.Name = "tRenk";
            this.tRenk.PlaceholderText = "";
            this.tRenk.SelectedText = "";
            this.tRenk.Size = new System.Drawing.Size(250, 26);
            this.tRenk.TabIndex = 39;
            // 
            // tModel
            // 
            this.tModel.BorderRadius = 10;
            this.tModel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tModel.DefaultText = "";
            this.tModel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tModel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tModel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tModel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tModel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tModel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tModel.ForeColor = System.Drawing.Color.Black;
            this.tModel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tModel.Location = new System.Drawing.Point(121, 402);
            this.tModel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tModel.MaxLength = 11;
            this.tModel.Name = "tModel";
            this.tModel.PlaceholderText = "";
            this.tModel.SelectedText = "";
            this.tModel.Size = new System.Drawing.Size(250, 26);
            this.tModel.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(61, 441);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 48;
            this.label4.Text = "Renk:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(78, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 20);
            this.label3.TabIndex = 47;
            this.label3.Text = "Yıl:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(51, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "Model:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(53, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "Marka:";
            // 
            // cmbSeri
            // 
            this.cmbSeri.AutoRoundedCorners = true;
            this.cmbSeri.BackColor = System.Drawing.Color.Transparent;
            this.cmbSeri.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSeri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeri.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSeri.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSeri.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSeri.ForeColor = System.Drawing.Color.Black;
            this.cmbSeri.ItemHeight = 20;
            this.cmbSeri.Location = new System.Drawing.Point(121, 363);
            this.cmbSeri.Name = "cmbSeri";
            this.cmbSeri.Size = new System.Drawing.Size(250, 26);
            this.cmbSeri.TabIndex = 37;
            // 
            // cmbMarka
            // 
            this.cmbMarka.AutoRoundedCorners = true;
            this.cmbMarka.BackColor = System.Drawing.Color.Transparent;
            this.cmbMarka.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMarka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarka.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbMarka.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbMarka.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbMarka.ForeColor = System.Drawing.Color.Black;
            this.cmbMarka.ItemHeight = 20;
            this.cmbMarka.Location = new System.Drawing.Point(121, 324);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(250, 26);
            this.cmbMarka.TabIndex = 36;
            this.cmbMarka.SelectedIndexChanged += new System.EventHandler(this.cmbMarka_SelectedIndexChanged);
            // 
            // tPlaka
            // 
            this.tPlaka.BorderRadius = 10;
            this.tPlaka.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tPlaka.DefaultText = "";
            this.tPlaka.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tPlaka.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tPlaka.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tPlaka.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tPlaka.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tPlaka.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tPlaka.ForeColor = System.Drawing.Color.Black;
            this.tPlaka.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tPlaka.Location = new System.Drawing.Point(121, 285);
            this.tPlaka.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tPlaka.MaxLength = 11;
            this.tPlaka.Name = "tPlaka";
            this.tPlaka.PlaceholderText = "";
            this.tPlaka.SelectedText = "";
            this.tPlaka.Size = new System.Drawing.Size(250, 26);
            this.tPlaka.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(58, 293);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 20);
            this.label9.TabIndex = 44;
            this.label9.Text = "Plaka:";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tSearch);
            this.splitContainer2.Panel1.Controls.Add(this.label6);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.gridCars);
            this.splitContainer2.Size = new System.Drawing.Size(916, 685);
            this.splitContainer2.SplitterDistance = 74;
            this.splitContainer2.TabIndex = 0;
            // 
            // tSearch
            // 
            this.tSearch.BorderRadius = 10;
            this.tSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tSearch.DefaultText = "";
            this.tSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tSearch.Location = new System.Drawing.Point(90, 32);
            this.tSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tSearch.MaxLength = 11;
            this.tSearch.Name = "tSearch";
            this.tSearch.PlaceholderText = "";
            this.tSearch.SelectedText = "";
            this.tSearch.Size = new System.Drawing.Size(215, 22);
            this.tSearch.TabIndex = 15;
            this.tSearch.TextChanged += new System.EventHandler(this.tSearch_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(21, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Araç Ara:";
            // 
            // gridCars
            // 
            this.gridCars.AllowUserToAddRows = false;
            this.gridCars.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.gridCars.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridCars.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridCars.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCars.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridCars.ColumnHeadersHeight = 40;
            this.gridCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridCars.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridCars.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridCars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCars.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.gridCars.Location = new System.Drawing.Point(0, 0);
            this.gridCars.Name = "gridCars";
            this.gridCars.ReadOnly = true;
            this.gridCars.RowHeadersVisible = false;
            this.gridCars.RowHeadersWidth = 51;
            this.gridCars.Size = new System.Drawing.Size(916, 607);
            this.gridCars.TabIndex = 1;
            this.gridCars.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.gridCars.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.gridCars.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridCars.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridCars.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridCars.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridCars.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.gridCars.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.gridCars.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.gridCars.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridCars.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridCars.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridCars.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridCars.ThemeStyle.HeaderStyle.Height = 40;
            this.gridCars.ThemeStyle.ReadOnly = true;
            this.gridCars.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.gridCars.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridCars.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridCars.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.gridCars.ThemeStyle.RowsStyle.Height = 22;
            this.gridCars.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.gridCars.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gridCars.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCars_CellDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(87, 26);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // guna2MessageDialog1
            // 
            this.guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.guna2MessageDialog1.Caption = null;
            this.guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.guna2MessageDialog1.Parent = null;
            this.guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.guna2MessageDialog1.Text = null;
            // 
            // FrmCarList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1343, 685);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCarList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCarList";
            this.Load += new System.EventHandler(this.FrmCarList_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcboxCar)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCars)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private Guna.UI2.WinForms.Guna2DataGridView gridCars;
        private Guna.UI2.WinForms.Guna2TextBox tSearch;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox cmbYakit;
        private Guna.UI2.WinForms.Guna2TextBox tKiraUcreti;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox tKm;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox tRenk;
        private Guna.UI2.WinForms.Guna2TextBox tModel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSeri;
        private Guna.UI2.WinForms.Guna2ComboBox cmbMarka;
        private Guna.UI2.WinForms.Guna2TextBox tPlaka;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2PictureBox pcboxCar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Button bGuncelle;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog1;
        private Guna.UI2.WinForms.Guna2CheckBox ChcDurumu;
        private Guna.UI2.WinForms.Guna2ComboBox CmbSanziman;
        private System.Windows.Forms.Label label10;
    }
}