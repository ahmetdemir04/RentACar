namespace RentACar
{
    partial class FrmSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSales));
            this.gridSales = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bFilter = new Guna.UI2.WinForms.Guna2Button();
            this.dtStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridSales
            // 
            this.gridSales.AllowUserToAddRows = false;
            this.gridSales.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.gridSales.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridSales.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridSales.ColumnHeadersHeight = 20;
            this.gridSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridSales.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSales.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.gridSales.Location = new System.Drawing.Point(0, 0);
            this.gridSales.Margin = new System.Windows.Forms.Padding(4);
            this.gridSales.Name = "gridSales";
            this.gridSales.ReadOnly = true;
            this.gridSales.RowHeadersVisible = false;
            this.gridSales.Size = new System.Drawing.Size(1317, 374);
            this.gridSales.TabIndex = 2;
            this.gridSales.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.gridSales.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.gridSales.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridSales.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridSales.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridSales.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridSales.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.gridSales.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.gridSales.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.gridSales.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridSales.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridSales.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridSales.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridSales.ThemeStyle.HeaderStyle.Height = 20;
            this.gridSales.ThemeStyle.ReadOnly = true;
            this.gridSales.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.gridSales.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridSales.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridSales.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.gridSales.ThemeStyle.RowsStyle.Height = 22;
            this.gridSales.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.gridSales.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gridSales.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridSales_CellDoubleClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(23, 39);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 20);
            this.label10.TabIndex = 31;
            this.label10.Text = "Başlangıc:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gridSales);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.bFilter);
            this.splitContainer1.Panel2.Controls.Add(this.dtStart);
            this.splitContainer1.Panel2.Controls.Add(this.dtEnd);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Size = new System.Drawing.Size(1317, 556);
            this.splitContainer1.SplitterDistance = 374;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 32;
            // 
            // bFilter
            // 
            this.bFilter.AutoRoundedCorners = true;
            this.bFilter.BackColor = System.Drawing.Color.Transparent;
            this.bFilter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bFilter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bFilter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.bFilter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFilter.ForeColor = System.Drawing.Color.White;
            this.bFilter.Location = new System.Drawing.Point(109, 125);
            this.bFilter.Name = "bFilter";
            this.bFilter.Size = new System.Drawing.Size(122, 26);
            this.bFilter.TabIndex = 35;
            this.bFilter.Text = "Filitrele";
            this.bFilter.Click += new System.EventHandler(this.bFilter_Click);
            // 
            // dtStart
            // 
            this.dtStart.BorderRadius = 10;
            this.dtStart.Checked = true;
            this.dtStart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.dtStart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtStart.Location = new System.Drawing.Point(109, 39);
            this.dtStart.Margin = new System.Windows.Forms.Padding(4);
            this.dtStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(212, 29);
            this.dtStart.TabIndex = 33;
            this.dtStart.Value = new System.DateTime(2025, 7, 25, 0, 27, 9, 383);
            // 
            // dtEnd
            // 
            this.dtEnd.BorderRadius = 10;
            this.dtEnd.Checked = true;
            this.dtEnd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.dtEnd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtEnd.Location = new System.Drawing.Point(109, 80);
            this.dtEnd.Margin = new System.Windows.Forms.Padding(4);
            this.dtEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(212, 29);
            this.dtEnd.TabIndex = 34;
            this.dtEnd.Value = new System.DateTime(2025, 7, 25, 0, 27, 9, 383);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(58, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Bitiş:";
            // 
            // FrmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1317, 556);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSales";
            this.Load += new System.EventHandler(this.FrmSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridSales)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView gridSales;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtStart;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtEnd;
        private Guna.UI2.WinForms.Guna2Button bFilter;
    }
}