using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    public partial class FrmSales : Form
    {
        public FrmSales()
        {
            InitializeComponent();
        }
        ClsMainFunctions mainFunctions = new ClsMainFunctions();
        ClsConnection con = new ClsConnection();
        ClsControlHelper cHelper = new ClsControlHelper();
        
        private void BringAllSales()
        {
            string qry_all_sales = "Exec ListAllRents";
            SqlDataAdapter adp = new SqlDataAdapter(qry_all_sales, con.Connection());
            gridSales.DataSource = mainFunctions.Listele(adp, qry_all_sales);
        }
        private void FrmSales_Load(object sender, EventArgs e)
        {

            gridSales.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Regular);
            gridSales.DefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            
            BringAllSales();
            cHelper.DatagridFormatter(gridSales);
            gridSales.Columns["KiralamaID"].Visible = false; 
        }

        private void bFilter_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime ds = dtStart.Value; // Tarih başlangıcı
                DateTime de = dtEnd.Value; // Tarih bitişi

                if ( ds > de)
                {
                    cHelper.Gmessagebox("Lütfen başlangıç tarihinden büyük bir bitiş tarihi seçiniz.", "Rent A Car", "Warning");
                    return;
                }


                string query = "Exec ListAllRentsBetween @DS = @ds, @DE = @de";
                using (SqlDataAdapter adp = new SqlDataAdapter(query, con.Connection()))
                {

                    DataTable dt  = new DataTable();

                    adp.SelectCommand.Parameters.Add("@ds", SqlDbType.DateTime).Value = ds;
                    adp.SelectCommand.Parameters.Add("@de", SqlDbType.DateTime).Value = de;
           
                    adp.Fill(dt);
                    gridSales.DataSource = dt;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Rent A Car", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { con.Connection().Close(); }
        }

        private void gridSales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int? id = Convert.ToInt32(gridSales.CurrentRow.Cells["OdemeID"].Value);

            if (id != null)
            {
                FrmSaleDetail fSalesDetail = new FrmSaleDetail();   
                fSalesDetail.OdemeID = id;
                fSalesDetail.ShowDialog();
            }
        }

        private void tSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)gridSales.DataSource;

            if (dt != null)
            {
                if (rdPlaka.Checked == Enabled)
                {
                    dt.DefaultView.RowFilter = string.Format("Plaka LIKE '%{0}%'", tSearch.Text);
                }
                else if (rdAdSoyad.Checked == Enabled)
                {
                    dt.DefaultView.RowFilter = string.Format("[Ad Soyad] LIKE '%{0}%'", tSearch.Text);
                }
                else
                {
                    cHelper.Gmessagebox("Lütfen bir filtre seçiniz.", "Rent A Car", "Warning");
                }

            }
        }
    }
}
