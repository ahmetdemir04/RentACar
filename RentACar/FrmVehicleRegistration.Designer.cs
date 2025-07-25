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
            this.cmbSeriNo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tModel = new Guna.UI2.WinForms.Guna2TextBox();
            this.tRenk = new Guna.UI2.WinForms.Guna2TextBox();
            this.tKm = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tKiraUcreti = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.bAddPicture = new Guna.UI2.WinForms.Guna2Button();
            this.bSave = new Guna.UI2.WinForms.Guna2Button();
            this.bCancel = new Guna.UI2.WinForms.Guna2Button();
            this.cmbYakit = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
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
            this.tPlaka.Location = new System.Drawing.Point(112, 38);
            this.tPlaka.MaxLength = 11;
            this.tPlaka.Name = "tPlaka";
            this.tPlaka.PlaceholderText = "";
            this.tPlaka.SelectedText = "";
            this.tPlaka.Size = new System.Drawing.Size(215, 22);
            this.tPlaka.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(61, 43);
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
            this.cmbMarka.Location = new System.Drawing.Point(112, 75);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(215, 26);
            this.cmbMarka.TabIndex = 1;
            this.cmbMarka.SelectedIndexChanged += new System.EventHandler(this.cmbMarka_SelectedIndexChanged);
            // 
            // cmbSeriNo
            // 
            this.cmbSeriNo.AutoRoundedCorners = true;
            this.cmbSeriNo.BackColor = System.Drawing.Color.Transparent;
            this.cmbSeriNo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSeriNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeriNo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSeriNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSeriNo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSeriNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbSeriNo.ItemHeight = 20;
            this.cmbSeriNo.Location = new System.Drawing.Point(112, 116);
            this.cmbSeriNo.Name = "cmbSeriNo";
            this.cmbSeriNo.Size = new System.Drawing.Size(215, 26);
            this.cmbSeriNo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(56, 81);
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
            this.label2.Location = new System.Drawing.Point(71, 119);
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
            this.label3.Location = new System.Drawing.Point(55, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Model:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(68, 195);
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
            this.tModel.Location = new System.Drawing.Point(112, 157);
            this.tModel.MaxLength = 11;
            this.tModel.Name = "tModel";
            this.tModel.PlaceholderText = "";
            this.tModel.SelectedText = "";
            this.tModel.Size = new System.Drawing.Size(215, 22);
            this.tModel.TabIndex = 3;
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
            this.tRenk.Location = new System.Drawing.Point(112, 194);
            this.tRenk.MaxLength = 11;
            this.tRenk.Name = "tRenk";
            this.tRenk.PlaceholderText = "";
            this.tRenk.SelectedText = "";
            this.tRenk.Size = new System.Drawing.Size(215, 22);
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
            this.tKm.Location = new System.Drawing.Point(112, 231);
            this.tKm.MaxLength = 11;
            this.tKm.Name = "tKm";
            this.tKm.PlaceholderText = "";
            this.tKm.SelectedText = "";
            this.tKm.Size = new System.Drawing.Size(215, 22);
            this.tKm.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(78, 233);
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
            this.label7.Location = new System.Drawing.Point(68, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 17);
            this.label7.TabIndex = 29;
            this.label7.Text = "Yakıt";
            // 
            // tKiraUcreti
            // 
            this.tKiraUcreti.BorderRadius = 10;
            this.tKiraUcreti.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tKiraUcreti.DefaultText = "";
            this.tKiraUcreti.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tKiraUcreti.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tKiraUcreti.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tKiraUcreti.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tKiraUcreti.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tKiraUcreti.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tKiraUcreti.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tKiraUcreti.Location = new System.Drawing.Point(112, 305);
            this.tKiraUcreti.MaxLength = 11;
            this.tKiraUcreti.Name = "tKiraUcreti";
            this.tKiraUcreti.PlaceholderText = "";
            this.tKiraUcreti.SelectedText = "";
            this.tKiraUcreti.Size = new System.Drawing.Size(215, 22);
            this.tKiraUcreti.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(30, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 17);
            this.label8.TabIndex = 31;
            this.label8.Text = "Kira Ücreti:";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BorderRadius = 10;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(370, 38);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(195, 198);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 33;
            this.guna2PictureBox1.TabStop = false;
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
            this.bAddPicture.Location = new System.Drawing.Point(402, 244);
            this.bAddPicture.Name = "bAddPicture";
            this.bAddPicture.Size = new System.Drawing.Size(128, 35);
            this.bAddPicture.TabIndex = 8;
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
            this.bSave.Location = new System.Drawing.Point(100, 349);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(106, 35);
            this.bSave.TabIndex = 9;
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
            this.bCancel.Location = new System.Drawing.Point(221, 349);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(106, 35);
            this.bCancel.TabIndex = 10;
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
            this.cmbYakit.Location = new System.Drawing.Point(112, 267);
            this.cmbYakit.Name = "cmbYakit";
            this.cmbYakit.Size = new System.Drawing.Size(215, 26);
            this.cmbYakit.TabIndex = 34;
            // 
            // FrmVehicleRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(600, 420);
            this.Controls.Add(this.cmbYakit);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.bAddPicture);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.tKiraUcreti);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tKm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tRenk);
            this.Controls.Add(this.tModel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSeriNo);
            this.Controls.Add(this.cmbMarka);
            this.Controls.Add(this.tPlaka);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmVehicleRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araba Kayıt Sayfası";
            this.Load += new System.EventHandler(this.FrmVehicleRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox tPlaka;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox cmbMarka;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSeriNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox tModel;
        private Guna.UI2.WinForms.Guna2TextBox tRenk;
        private Guna.UI2.WinForms.Guna2TextBox tKm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox tKiraUcreti;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button bAddPicture;
        private Guna.UI2.WinForms.Guna2Button bSave;
        private Guna.UI2.WinForms.Guna2Button bCancel;
        private Guna.UI2.WinForms.Guna2ComboBox cmbYakit;
    }
}