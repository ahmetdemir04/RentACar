namespace RentACar
{
    partial class FrmVehicleRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVehicleRegistration));
            this.tPlaka = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbMarka = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbSeri = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tModel = new Guna.UI2.WinForms.Guna2TextBox();
            this.tRenk = new Guna.UI2.WinForms.Guna2TextBox();
            this.tKm = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.bAddPicture = new Guna.UI2.WinForms.Guna2Button();
            this.bSave = new Guna.UI2.WinForms.Guna2Button();
            this.bCancel = new Guna.UI2.WinForms.Guna2Button();
            this.cmbYakit = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tGunlukUcret = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cSansizman = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.tPlaka.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tPlaka.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tPlaka.Location = new System.Drawing.Point(139, 38);
            this.tPlaka.MaxLength = 11;
            this.tPlaka.Name = "tPlaka";
            this.tPlaka.PlaceholderText = "";
            this.tPlaka.SelectedText = "";
            this.tPlaka.Size = new System.Drawing.Size(215, 26);
            this.tPlaka.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(85, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Plaka:";
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
            this.cmbMarka.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbMarka.ItemHeight = 20;
            this.cmbMarka.Items.AddRange(new object[] {
            "Opel",
            "Renault",
            "Fiat",
            "Ford",
            "BMW",
            "Mercedes"});
            this.cmbMarka.Location = new System.Drawing.Point(139, 76);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(215, 26);
            this.cmbMarka.TabIndex = 1;
            this.cmbMarka.SelectedIndexChanged += new System.EventHandler(this.cmbMarka_SelectedIndexChanged);
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
            this.cmbSeri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbSeri.ItemHeight = 20;
            this.cmbSeri.Location = new System.Drawing.Point(139, 115);
            this.cmbSeri.Name = "cmbSeri";
            this.cmbSeri.Size = new System.Drawing.Size(215, 26);
            this.cmbSeri.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(80, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Marka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(95, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Seri:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(49, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Model (Yıl):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(92, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Renk";
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
            this.tModel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tModel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tModel.Location = new System.Drawing.Point(139, 153);
            this.tModel.MaxLength = 11;
            this.tModel.Name = "tModel";
            this.tModel.PlaceholderText = "";
            this.tModel.SelectedText = "";
            this.tModel.Size = new System.Drawing.Size(215, 26);
            this.tModel.TabIndex = 2;
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
            this.tRenk.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tRenk.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tRenk.Location = new System.Drawing.Point(139, 190);
            this.tRenk.MaxLength = 11;
            this.tRenk.Name = "tRenk";
            this.tRenk.PlaceholderText = "";
            this.tRenk.SelectedText = "";
            this.tRenk.Size = new System.Drawing.Size(215, 26);
            this.tRenk.TabIndex = 4;
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
            this.tKm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tKm.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tKm.Location = new System.Drawing.Point(139, 228);
            this.tKm.MaxLength = 11;
            this.tKm.Name = "tKm";
            this.tKm.PlaceholderText = "";
            this.tKm.SelectedText = "";
            this.tKm.Size = new System.Drawing.Size(215, 26);
            this.tKm.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(102, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Km";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(92, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 17);
            this.label7.TabIndex = 29;
            this.label7.Text = "Yakıt";
            // 
            // PictureBox1
            // 
            this.PictureBox1.BorderRadius = 10;
            this.PictureBox1.ImageRotate = 0F;
            this.PictureBox1.Location = new System.Drawing.Point(425, 38);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(195, 198);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 33;
            this.PictureBox1.TabStop = false;
            // 
            // bAddPicture
            // 
            this.bAddPicture.AutoRoundedCorners = true;
            this.bAddPicture.BackColor = System.Drawing.Color.Transparent;
            this.bAddPicture.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bAddPicture.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bAddPicture.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bAddPicture.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bAddPicture.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.bAddPicture.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAddPicture.ForeColor = System.Drawing.Color.White;
            this.bAddPicture.Location = new System.Drawing.Point(457, 244);
            this.bAddPicture.Name = "bAddPicture";
            this.bAddPicture.Size = new System.Drawing.Size(128, 35);
            this.bAddPicture.TabIndex = 9;
            this.bAddPicture.Text = "Resim Ekle";
            this.bAddPicture.Click += new System.EventHandler(this.bAddPicture_Click);
            // 
            // bSave
            // 
            this.bSave.AutoRoundedCorners = true;
            this.bSave.BackColor = System.Drawing.Color.Transparent;
            this.bSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.bSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSave.ForeColor = System.Drawing.Color.White;
            this.bSave.Location = new System.Drawing.Point(127, 390);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(106, 35);
            this.bSave.TabIndex = 10;
            this.bSave.Text = "Kaydet";
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bCancel
            // 
            this.bCancel.AutoRoundedCorners = true;
            this.bCancel.BackColor = System.Drawing.Color.Transparent;
            this.bCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.bCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancel.ForeColor = System.Drawing.Color.White;
            this.bCancel.Location = new System.Drawing.Point(248, 390);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(106, 35);
            this.bCancel.TabIndex = 11;
            this.bCancel.Text = "İptal";
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
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
            this.cmbYakit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbYakit.ItemHeight = 20;
            this.cmbYakit.Items.AddRange(new object[] {
            "Benzin",
            "Dizel",
            "Elektrik",
            "Hibrit",
            "Benzin + Dizel"});
            this.cmbYakit.Location = new System.Drawing.Point(139, 266);
            this.cmbYakit.Name = "cmbYakit";
            this.cmbYakit.Size = new System.Drawing.Size(215, 26);
            this.cmbYakit.TabIndex = 6;
            // 
            // tGunlukUcret
            // 
            this.tGunlukUcret.BorderRadius = 10;
            this.tGunlukUcret.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tGunlukUcret.DefaultText = "0";
            this.tGunlukUcret.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tGunlukUcret.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tGunlukUcret.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tGunlukUcret.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tGunlukUcret.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tGunlukUcret.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tGunlukUcret.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tGunlukUcret.Location = new System.Drawing.Point(139, 342);
            this.tGunlukUcret.MaxLength = 11;
            this.tGunlukUcret.Name = "tGunlukUcret";
            this.tGunlukUcret.PlaceholderText = "";
            this.tGunlukUcret.SelectedText = "";
            this.tGunlukUcret.SelectionStart = 1;
            this.tGunlukUcret.Size = new System.Drawing.Size(215, 26);
            this.tGunlukUcret.TabIndex = 8;
            this.tGunlukUcret.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tGunlukUcret.Enter += new System.EventHandler(this.tGunlukUcret_Enter);
            this.tGunlukUcret.Leave += new System.EventHandler(this.tGunlukUcret_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(34, 346);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 17);
            this.label9.TabIndex = 36;
            this.label9.Text = "Günlük Ücreti:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(59, 308);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 17);
            this.label10.TabIndex = 38;
            this.label10.Text = "Şansıman:";
            // 
            // cSansizman
            // 
            this.cSansizman.AutoRoundedCorners = true;
            this.cSansizman.BackColor = System.Drawing.Color.Transparent;
            this.cSansizman.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cSansizman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cSansizman.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cSansizman.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cSansizman.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cSansizman.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cSansizman.ItemHeight = 20;
            this.cSansizman.Items.AddRange(new object[] {
            "Manuel Şanzıman (Düz Vites)",
            "Otomatik Şanzıman",
            "Yarı Otomatik Şanzıman",
            "Elektrikli Araç Şanzımanı"});
            this.cSansizman.Location = new System.Drawing.Point(139, 305);
            this.cSansizman.Name = "cSansizman";
            this.cSansizman.Size = new System.Drawing.Size(215, 26);
            this.cSansizman.TabIndex = 39;
            // 
            // FrmVehicleRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(659, 452);
            this.Controls.Add(this.cSansizman);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tGunlukUcret);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbYakit);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.bAddPicture);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tKm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tRenk);
            this.Controls.Add(this.tModel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSeri);
            this.Controls.Add(this.cmbMarka);
            this.Controls.Add(this.tPlaka);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(675, 491);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(675, 491);
            this.Name = "FrmVehicleRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araba Kayıt Sayfası";
            this.Load += new System.EventHandler(this.FrmVehicleRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox tPlaka;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox cmbMarka;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSeri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox tModel;
        private Guna.UI2.WinForms.Guna2TextBox tRenk;
        private Guna.UI2.WinForms.Guna2TextBox tKm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2PictureBox PictureBox1;
        private Guna.UI2.WinForms.Guna2Button bAddPicture;
        private Guna.UI2.WinForms.Guna2Button bSave;
        private Guna.UI2.WinForms.Guna2Button bCancel;
        private Guna.UI2.WinForms.Guna2ComboBox cmbYakit;
        private Guna.UI2.WinForms.Guna2TextBox tGunlukUcret;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2ComboBox cSansizman;
    }
}