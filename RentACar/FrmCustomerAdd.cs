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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RentACar
{
    public partial class FrmCustomerAdd : Form
    {
        public FrmCustomerAdd()
        {
            InitializeComponent();
        }
        MainFunctions mainFunctions = new MainFunctions();
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
            if(!string.IsNullOrEmpty(tLisansNumarasi.Text) &&
                !string.IsNullOrEmpty(tTC.Text) &&
                !string.IsNullOrEmpty(tAd.Text) &&
                !string.IsNullOrEmpty(tSoyad.Text) &&
                !string.IsNullOrEmpty(tTelefon.Text) &&
                !string.IsNullOrEmpty(tEposta.Text) &&
                !string.IsNullOrEmpty(tAdres.Text) )
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (!CheckAllFields())
            {
                Chelper.Gmessagebox("Lütfen tüm alanları doldurun!", "Rent A Car", "Error").Show();
                return;
            }


            Chelper.Gmessagebox("Kayıt başarıyla gerçekleştirildi!", "Rent A Car", "Information");
            string qry_add = "INSERT INTO TblMusteri (TC, Ad, Soyad, Telefon, Email, Adres, LisansNumarasi, DogumTarihi, EhliyetinVerildigiTarih, Durumu) VALUES (@TC, @Ad, @Soyad, @Telefon, @Email, @Adres, @LN, @DT, @VT, @Durumu)";
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
            cmdAdd.Parameters.AddWithValue("@Durumu", 1);

            bool worked = mainFunctions.DML(cmdAdd, qry_add);
            if(worked)
           
                Chelper.Gmessagebox("Kayıt başarıyla gerçekleştirildi!", "Rent A Car", "Information").Show();

            Chelper.ClearFields(this);
            tLisansNumarasi.Focus();

        }
        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
