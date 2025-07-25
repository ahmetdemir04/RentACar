using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
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
        string DefaultCarPicture = Path.Combine(Application.StartupPath, @"default_car.png");
        private void FrmVehicleRegistration_Load(object sender, EventArgs e)
        {
            guna2PictureBox1.Image = Image.FromFile(DefaultCarPicture);
        }
        private void showImage(string _plaka)
        {
            string image = Path.Combine(Application.StartupPath, @"Images\" + _plaka);
            guna2PictureBox1.Image = Image.FromFile(image);
        }
        private void bAddPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files |*.jpg;*.png";

            ofd.ShowDialog();
            string source = ofd.FileName;

            string AllImagesPath = Path.Combine(Application.StartupPath, @"Images");

            if (!Directory.Exists(AllImagesPath))
            {
                Directory.CreateDirectory(AllImagesPath);
            }

            File.Copy(source, Path.Combine(AllImagesPath, tPlaka.Text + ".png"));

            guna2PictureBox1.ImageLocation = ofd.FileName;


            //string x = ofd.FileName;
            //File.Copy(x, )
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
                cmbSeriNo.Items.Clear();
                if (cmbMarka.SelectedIndex == 0)
                {
                    cmbSeriNo.Items.Add("Astra");
                    cmbSeriNo.Items.Add("Vectra");
                    cmbSeriNo.Items.Add("Corsa");
                }
                else if(cmbMarka.SelectedIndex == 1)
                {
                    cmbSeriNo.Items.Add("Megane");
                    cmbSeriNo.Items.Add("Cleo");
                }
                else if (cmbMarka.SelectedIndex == 2)
                {
                    cmbSeriNo.Items.Add("Linea");
                    cmbSeriNo.Items.Add("Egea");
                }
                else if (cmbMarka.SelectedIndex == 3)
                {
                    cmbSeriNo.Items.Add("Fiesta");
                    cmbSeriNo.Items.Add("Focus");
                }
                else if (cmbMarka.SelectedIndex == 4)
                {
                    cmbSeriNo.Items.Add("Gran");
                    cmbSeriNo.Items.Add("Sedan");
                }
                else if (cmbMarka.SelectedIndex == 5)
                {
                    cmbSeriNo.Items.Add("GLC");
                    cmbSeriNo.Items.Add("EQB 250+ Night Edition");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            string qry_car = "INSERT INTO TblArac (plaka,marka,seri,yil,renk,km,yakit,kiraucreti,resim,durum,tarih) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)";

            SqlCommand cmd_car_add = new SqlCommand();

            string imagepath = Path.Combine(Application.StartupPath, @"\Images"+tPlaka.Text + ".png");

            cmd_car_add.Parameters.AddWithValue("@p1", tPlaka.Text);
            cmd_car_add.Parameters.AddWithValue("@p2", cmbMarka.Text);
            cmd_car_add.Parameters.AddWithValue("@p3", cmbSeriNo.Text);
            cmd_car_add.Parameters.AddWithValue("@p4", tModel.Text);
            cmd_car_add.Parameters.AddWithValue("@p5", tRenk.Text);
            cmd_car_add.Parameters.AddWithValue("@p6", Convert.ToInt32(tKm.Text));
            cmd_car_add.Parameters.AddWithValue("@p7", cmbYakit.Text);
            cmd_car_add.Parameters.AddWithValue("@p8", tKiraUcreti.Text);
            cmd_car_add.Parameters.AddWithValue("@p9", imagepath);
            cmd_car_add.Parameters.AddWithValue("@p10", false);
            cmd_car_add.Parameters.AddWithValue("@p11", DateTime.Today.ToShortDateString());

            mainfunction.DML(cmd_car_add, qry_car);


            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";

                }
            }
            cmbMarka.SelectedIndex = -1;
            cmbSeriNo.Items.Clear();
            cmbYakit.SelectedIndex = -1;
        }
    }
}
