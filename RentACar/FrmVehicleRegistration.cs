using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    public partial class FrmVehicleRegistration : Form
    {
        public FrmVehicleRegistration()
        {
            InitializeComponent();
        }

        ClsControlHelper cHelper = new ClsControlHelper();

        string DefaultCarPicture = Path.Combine(Application.StartupPath, @"default_car.png");
        private void FrmVehicleRegistration_Load(object sender, EventArgs e)
        {
            PictureBox1.Image = Image.FromFile(DefaultCarPicture);
        }
        private void showImage(string _plaka)
        {
            string image = Path.Combine(Application.StartupPath, @"Images\" + _plaka);
            PictureBox1.Image = Image.FromFile(image);
        }
        string source = "";
        private void bAddPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files |*.jpg;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                source = ofd.FileName;
                PictureBox1.ImageLocation = ofd.FileName;
            }

        }
        void AddImage(string _imgPath)
        {
            string AllImagesPath = Path.Combine(Application.StartupPath, @"Images");

            if (!Directory.Exists(AllImagesPath))
            {
                Directory.CreateDirectory(AllImagesPath);
            }

            File.Copy(source, Path.Combine(AllImagesPath, tPlaka.Text + ".png"));

            PictureBox1.Image = Image.FromFile(_imgPath);

            source = string.Empty;

        }

        bool FieldCheck()
        {
            if (!string.IsNullOrEmpty(tPlaka.Text) &&
                !string.IsNullOrEmpty(cmbMarka.Text) && 
                !string.IsNullOrEmpty(cmbSeri.Text) &&
                !string.IsNullOrEmpty(tModel.Text) &&
                !string.IsNullOrEmpty(tRenk.Text) &&
                Convert.ToInt32(tKm.Text) != 0 &&
                !string.IsNullOrEmpty(cmbYakit.Text) &&
                !string.IsNullOrEmpty(cSansizman.Text) &&
                !string.IsNullOrEmpty(tGunlukUcret.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        MainFunctions mainfunction = new MainFunctions();
        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmbSeri.Items.Clear();
                if (cmbMarka.SelectedIndex == 0)
                {
                    cmbSeri.Items.Add("Astra");
                    cmbSeri.Items.Add("Vectra");
                    cmbSeri.Items.Add("Corsa");
                }
                else if (cmbMarka.SelectedIndex == 1)
                {
                    cmbSeri.Items.Add("Megane");
                    cmbSeri.Items.Add("Cleo");
                }
                else if (cmbMarka.SelectedIndex == 2)
                {
                    cmbSeri.Items.Add("Linea");
                    cmbSeri.Items.Add("Egea");
                }
                else if (cmbMarka.SelectedIndex == 3)
                {
                    cmbSeri.Items.Add("Fiesta");
                    cmbSeri.Items.Add("Focus");
                }
                else if (cmbMarka.SelectedIndex == 4)
                {
                    cmbSeri.Items.Add("Gran");
                    cmbSeri.Items.Add("Sedan");
                }
                else if (cmbMarka.SelectedIndex == 5)
                {
                    cmbSeri.Items.Add("GLC");
                    cmbSeri.Items.Add("EQB 250+ Night Edition");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (!FieldCheck())
            {
                cHelper.Gmessagebox("Lütfen tüm alanları doldurun!", "Rent A Car", "Warning").Show();
                return;
            }

            string qry_car = "INSERT INTO TblArac (Plaka,Marka,Model,Yil,Renk,Sansizman, YakitTipi,GunlukUcret,Durum,Km,Resim,Aktif) VALUES (@Plaka,@Marka,@Model,@Yil,@Renk,@Sansizman, @YakitTipi,@GunlukUcret,@Durum,@Km,@Resim,@Aktif) ";

            SqlCommand cmd_car_add = new SqlCommand();

            string imagepath = Path.Combine(Application.StartupPath, "Images", tPlaka.Text + ".png");

            cmd_car_add.Parameters.AddWithValue("@Plaka", tPlaka.Text);
            cmd_car_add.Parameters.AddWithValue("@Marka", cmbMarka.Text);
            cmd_car_add.Parameters.AddWithValue("@Model", cmbSeri.Text);
            cmd_car_add.Parameters.AddWithValue("@Yil", tModel.Text);
            cmd_car_add.Parameters.AddWithValue("@Renk", tRenk.Text);
            cmd_car_add.Parameters.AddWithValue("@Sansizman", cSansizman.SelectedItem);
            cmd_car_add.Parameters.AddWithValue("@YakitTipi", cmbYakit.Text);
            cmd_car_add.Parameters.AddWithValue("@GunlukUcret", g_value);
            cmd_car_add.Parameters.AddWithValue("@Durum", true);
            cmd_car_add.Parameters.AddWithValue("@Km", int.Parse(tKm.Text));
            cmd_car_add.Parameters.AddWithValue("@Resim", imagepath);
            cmd_car_add.Parameters.AddWithValue("@Aktif", true);

            bool worked = mainfunction.DML(cmd_car_add, qry_car);
            AddImage(imagepath);

            if (worked)
                cHelper.Gmessagebox("Araç kaydı başarıyla gerçekleştirildi!", "Rent A Car", "Information").Show();

            cHelper.ClearFields(this);

            cmbMarka.SelectedIndex = -1;
            cmbYakit.SelectedIndex = -1;
            cSansizman.SelectedIndex = -1;

            tPlaka.Focus();
        }


        private void tGunlukUcret_Leave(object sender, EventArgs e)
        {
            if (decimal.TryParse(tGunlukUcret.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal value))
            {
                tGunlukUcret.Text = string.Format(CultureInfo.GetCultureInfo("tr-TR"), "{0:C2}", value);
            }
        }
        decimal g_value = 0;
        private void tGunlukUcret_Enter(object sender, EventArgs e)
        {
            string text = tGunlukUcret.Text;

            // Formatlıysa (₺ içeriyorsa) temizle
            if (text.Contains("₺"))
            {
                if (decimal.TryParse(text, NumberStyles.Currency, CultureInfo.GetCultureInfo("tr-TR"), out decimal value))
                {
                    tGunlukUcret.Text = value.ToString(CultureInfo.InvariantCulture);
                    g_value = value;
                }
            }
        }
    }
}
