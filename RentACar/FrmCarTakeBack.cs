using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    public partial class FrmCarTakeBack : Form
    {
        public FrmCarTakeBack()
        {
            InitializeComponent();
        }
        ClsConnection con = new ClsConnection();
        public int? KiraID { get; set; }
        public string BaslangicTarihi { get; set; }
        public string BitisTarihi { get; set; }
        private void FrmCarTakeBack_Load(object sender, EventArgs e)
        {
            LKiralamaId.Text = KiraID.ToString();
            lBaslangicTarihi.Text = BaslangicTarihi.ToString();
            lBitisTarihi.Text= BitisTarihi.ToString();
        }

        private void bCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime plananBitis = DateTime.MinValue , gercekBitis = DateTime.MinValue;
                double gunlukucret=0;
                double toplamucret = 0;
                int gunFarki;

                string qry_kiralama = "SELECT * FROM TblKiralama WHERE KiraID = @KID";

                using (SqlCommand cmd_kiralama = new SqlCommand(qry_kiralama, con.Connection()))
                {
                    cmd_kiralama.Parameters.AddWithValue("@KID", KiraID);
                    SqlDataReader rd = cmd_kiralama.ExecuteReader();

                    if (rd.Read())
                    {
                        plananBitis = DateTime.Parse(rd["BitisTarihi"].ToString());
                        gercekBitis = DateTime.Now;

                        gunlukucret = Convert.ToDouble(rd["GunlukUcret"]);
                        toplamucret = Convert.ToDouble(rd["ToplamUcret"]);
                    }
                    gunFarki = (gercekBitis - plananBitis).Days;
                    double ekTutar = 0;
                    if (gunFarki < 0)
                    {
                        int erkenGunSayisi = Math.Abs(gunFarki);
                        ekTutar = -erkenGunSayisi * gunlukucret;
                    }
                    else if( gunFarki > 0 )
                    {
                        int ekstragunSayisi = gunFarki;
                        double cezaOrani = 1.2; // %20 ceza
                        ekTutar = ekstragunSayisi * gunlukucret * cezaOrani;
                    }

                    double nihaiTutar = toplamucret + ekTutar;
                    
                    lOdenecekTutar.Text = nihaiTutar.ToString();

                }


            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
