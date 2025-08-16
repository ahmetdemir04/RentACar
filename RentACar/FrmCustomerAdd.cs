using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RentACar
{
    public partial class FrmCustomerAdd : Form
    {
        public FrmCustomerAdd()
        {
            InitializeComponent();
        }
        ClsMainFunctions mainFunctions = new ClsMainFunctions();
        private void FrmCustomerAdd_Load(object sender, EventArgs e)
        {
            #region CheckFields
            tLisansNumarasi.KeyPress += Chelper.OnlyNumeric;
            tTC.KeyPress += Chelper.OnlyNumeric;
            tTelefon.KeyPress += Chelper.OnlyNumeric;

            tAd.KeyPress += Chelper.OnlyAlphabetic;
            tSoyad.KeyPress += Chelper.OnlyAlphabetic;
            #endregion
        }
        ClsControlHelper Chelper = new ClsControlHelper();
        private bool CheckAllFields()
        {
            if (!string.IsNullOrEmpty(tLisansNumarasi.Text) &&
                !string.IsNullOrEmpty(tTC.Text) &&
                !string.IsNullOrEmpty(tAd.Text) &&
                !string.IsNullOrEmpty(tSoyad.Text) &&
                !string.IsNullOrEmpty(tTelefon.Text) &&
                !string.IsNullOrEmpty(tEposta.Text) &&
                !string.IsNullOrEmpty(tAdres.Text))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private bool YasHesapla(DateTime DT)
        {
            int Fark = DateTime.Now.Year - DT.Year;

            if (Fark >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        CultureInfo TRculture = new CultureInfo("tr-TR");
        private void bSave_Click(object sender, EventArgs e)
        {
            DateTime dt = DtDogumTarihi.Value;
            string TC = tTC.Text.Trim();
            string Lisans = tLisansNumarasi.Text.Trim();

            if (!CheckAllFields())
            {
                Chelper.Gmessagebox("Lütfen tüm alanları doldurun!", "Rent A Car", "Error").Show();
                return;
            }

            if (!YasHesapla(dt))
            {
                Chelper.Gmessagebox("Yaşınız 18'in altında!", "Rent A Car", "Error").Show();
                return;
            }


            string qry_src_tc = "SELECT TC FROM TblMusteri";
            SqlCommand cmd = new SqlCommand();
            if(mainFunctions.IsThereAny(cmd, qry_src_tc, TC))
            {
                Chelper.Gmessagebox($"{TC} Bu T. C. kimlik numarasına sahip kayıt var!", "Rent A Car", "Error").Show();
                return;
            }


            string qry_src_lisans = "SELECT LisansNumarasi FROM TblMusteri";
            SqlCommand cmd2 = new SqlCommand();
            if (mainFunctions.IsThereAny(cmd2, qry_src_lisans, Lisans))
            {
                Chelper.Gmessagebox($"{Lisans} Bu Lisans numarasına sahip kayıt var!", "Rent A Car", "Error").Show();
                return;
            }



            Chelper.Gmessagebox("Kayıt başarıyla gerçekleştirildi!", "Rent A Car", "Information");
            string qry_add = "INSERT INTO TblMusteri (TC, Ad, Soyad, Telefon, Email, Adres, LisansNumarasi, DogumTarihi, EhliyetinVerildigiTarih, VerildigiYer, Durumu) VALUES (@TC, @Ad, @Soyad, @Telefon, @Email, @Adres, @LN, @DT, @VT,@VY, @Durumu)";
            SqlCommand cmdAdd = new SqlCommand();
            cmdAdd.Parameters.AddWithValue("@TC", tTC.Text);
            cmdAdd.Parameters.AddWithValue("@Ad", tAd.Text.Trim());
            cmdAdd.Parameters.AddWithValue("@Soyad", tSoyad.Text.Trim());
            cmdAdd.Parameters.AddWithValue("@Telefon", tTelefon.Text.Trim());
            cmdAdd.Parameters.AddWithValue("@Adres", tAdres.Text.Trim());
            cmdAdd.Parameters.AddWithValue("@Email", tEposta.Text.Trim());
            cmdAdd.Parameters.AddWithValue("@LN", tLisansNumarasi.Text.Trim());
            cmdAdd.Parameters.AddWithValue("@DT", DateTime.Parse(DtDogumTarihi.Text));
            cmdAdd.Parameters.AddWithValue("@VT", DateTime.Parse(DtTarih.Text));
            cmdAdd.Parameters.AddWithValue("@Durumu", true);
            cmdAdd.Parameters.AddWithValue("@VY", cmbIl.Text);

            bool worked = mainFunctions.DML(cmdAdd, qry_add);
            if (worked)

                Chelper.Gmessagebox("Kayıt başarıyla gerçekleştirildi!", "Rent A Car", "Information").Show();

            Chelper.ClearFields(this);
            cmbIl.SelectedIndex = -1;
            DtDogumTarihi.Value = DateTime.Now;
            tLisansNumarasi.Focus();

        }
        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
