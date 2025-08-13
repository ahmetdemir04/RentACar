using Guna.UI2.WinForms;
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
            tNakit.KeyPress += cHelper.OnlyNumeric;
            tKart.KeyPress += cHelper.OnlyNumeric;
        }

        ClsControlHelper cHelper = new ClsControlHelper();
        ClsConnection con = new ClsConnection();
        public int? KiraID { get; set; }
        public string BaslangicTarihi { get; set; }
        public string BitisTarihi { get; set; }
        private void FrmCarTakeBack_Load(object sender, EventArgs e)
        {
            LKiralamaId.Text = KiraID.ToString();
            lBaslangicTarihi.Text = BaslangicTarihi.ToString();
            lBitisTarihi.Text = BitisTarihi.ToString();

            Calculate();

        }
        string OdemeDurum = "";
        private void Calculate()
        {
            try
            {
                DateTime plananBitis = DateTime.MinValue, gercekBitis = DateTime.MinValue;
                double gunlukucret = 0;
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
                        OdemeDurum = "Erken İade";
                    }
                    else if (gunFarki > 0)
                    {
                        int ekstragunSayisi = gunFarki;
                        double cezaOrani = 1.2; // %20 ceza
                        ekTutar = ekstragunSayisi * gunlukucret * cezaOrani;
                        OdemeDurum = "Gecikmeli İade";
                    }

                    double nihaiTutar = toplamucret + ekTutar;
                    OdemeDurum = string.IsNullOrEmpty(OdemeDurum) ? "Normal İade" : OdemeDurum;

                    lOdenecekTutar.Text = nihaiTutar.ToString("N2");


                }


            }
            catch (Exception)
            {

                throw;
            }
        }

        double? ParaUstu = 0; double OdenecekTutar;

        private void bCalculate_Click(object sender, EventArgs e)
        {
            Calculate();

            if (cmbOdemeTuru.SelectedIndex == -1)
            {
                cHelper.Gmessagebox("Lütfen ödeme yöntemini seçiniz!", "Rent A Car", "Warning").Show();
                return;
            }

            double Nakit = 0, Kart = 0, Odenen;
            OdenecekTutar = cHelper.MakeDouble(lOdenecekTutar.Text);

            Nakit = cHelper.MakeDouble(tNakit.Text);
            Kart = cHelper.MakeDouble(tKart.Text);

            Odenen = Nakit + Kart;
            ParaUstu = Odenen - OdenecekTutar;

            if (ParaUstu < 0)
            {
                cHelper.Gmessagebox("Ödenen tutar, ödenecek tutardan az olamaz.", "Rent A Car", "Error").Show();
                return;
            }

            tParaUstu.Text = ParaUstu.Value.ToString("N0");
            bPay.Enabled = true;

        }

        private void cmbOdemeTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOdemeTuru.Text == "Kart")
            {
                tKart.Enabled = true;
                tNakit.Enabled = false;
            }
            else if (cmbOdemeTuru.Text == "Nakit")
            {
                tKart.Enabled = false;
                tNakit.Enabled = true;
            }
            else if (cmbOdemeTuru.Text == "Kart-Nakit")
            {
                tKart.Enabled = true;
                tNakit.Enabled = true;
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir ödeme türü seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bPay_Click(object sender, EventArgs e)
        {
        
            try
            {
                string qry_add_odemeler = "INSERT INTO TblOdemeler (KiralamaID, Tutar, OdemeTarihi, OdemeYontemi, Durum) VALUES (@KiralamaID, @Tutar, @OdemeTarihi, @OdemeYontemi, @Durum)";
                using (SqlCommand cmd_add_odeme = new SqlCommand(qry_add_odemeler, con.Connection()))
                {
                    cmd_add_odeme.Parameters.AddWithValue("@KiralamaID", KiraID);
                    cmd_add_odeme.Parameters.AddWithValue("@Tutar", OdenecekTutar);
                    cmd_add_odeme.Parameters.AddWithValue("@OdemeTarihi", DateTime.Now.ToShortDateString());
                    cmd_add_odeme.Parameters.AddWithValue("@OdemeYontemi", cmbOdemeTuru.Text);
                    cmd_add_odeme.Parameters.AddWithValue("@Durum", OdemeDurum);
                    cmd_add_odeme.ExecuteNonQuery();
                }
                string qry_update_kiralama = "UPDATE TblKiralama SET GeriDonusDurumu = @Durum, GercekTeslimTarihi = @GTT WHERE KiraID = @KID";
                using (SqlCommand cmd_update_kiralama = new SqlCommand(qry_update_kiralama, con.Connection()))
                {
                    cmd_update_kiralama.Parameters.AddWithValue("@Durum", true);
                    cmd_update_kiralama.Parameters.AddWithValue("@GTT", DateTime.Now.ToShortDateString());
                    cmd_update_kiralama.Parameters.AddWithValue("@KID", KiraID);
                    cmd_update_kiralama.ExecuteNonQuery();
                }

                string qry_update_araba = "UPDATE TblArac SET Durum = @Durum WHERE ArabaID = (SELECT ArabaID FROM TblKiralama WHERE KiraID = @KID)";
                using (SqlCommand cmd_update_araba = new SqlCommand(qry_update_araba, con.Connection()))
                {
                    cmd_update_araba.Parameters.AddWithValue("@Durum", true);
                    cmd_update_araba.Parameters.AddWithValue("@KID", KiraID);
                    cmd_update_araba.ExecuteNonQuery();
                }

                cHelper.Gmessagebox("Ödeme işlemi başarılı bir şekilde tamamlandı.", "Rent A Car", "Information").Show();



                foreach (Control ctrl in guna2Panel1.Controls) { if (ctrl is Guna2TextBox item) { item.Text = ""; } }
                ParaUstu = 0;
                FrmContract frmContract = Application.OpenForms["FrmContract"] as FrmContract;
                frmContract.BringCarList();



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void MakeItZero(object sender, EventArgs e)
        {
            if (sender is Guna2TextBox textBox)
            {
                if (textBox.Text == "")
                {
                    textBox.Text = "0";
                }

                if (decimal.TryParse(textBox.Text, out decimal value))
                {
                    textBox.Text = value.ToString("N2");
                }
            }
        }
        private void MakeIEmpty(object sender, EventArgs e)
        {
            if (sender is Guna2TextBox textBox)
            {
                if (textBox.Text == "0")
                {
                    textBox.Text = "";
                }
            }

        }
    }
}
