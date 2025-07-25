using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;


namespace RentACar
{
    public partial class FrmCarList : Form
    {
        public FrmCarList()
        {
            InitializeComponent();
        }
        MainFunctions mainFunctions = new MainFunctions();
        private void FrmCarList_Load(object sender, EventArgs e)
        {
            ListCars();
            gridCars.DefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            gridCars.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Regular);


        }

        private void ListCars()
        {
            string query_list_car = "SELECT * FROM Tblarac WHERE aktif = 1";
            SqlDataAdapter adpt = new SqlDataAdapter();

            gridCars.DataSource = mainFunctions.Listele(adpt, query_list_car);

            gridCars.Columns["plaka"].HeaderText = "Plaka";
            gridCars.Columns["marka"].HeaderText = "Marka";
            gridCars.Columns["seri"].HeaderText = "Seri";
            gridCars.Columns["yil"].HeaderText = "Yıl";
            gridCars.Columns["renk"].HeaderText = "Km";
            gridCars.Columns["km"].HeaderText = "Plaka";
            gridCars.Columns["yakit"].HeaderText = "Yakıt";
            gridCars.Columns["kiraucreti"].HeaderText = "Kira Ücreti";

            gridCars.Columns["tarih"].HeaderText = "Tarih";

            gridCars.Columns["durum"].HeaderText = false ? "Boşta" : "Kiralandı";



            gridCars.Columns["resim"].Visible = false;
            gridCars.Columns["aktif"].Visible = false;

        }
        string img;

        private void gridCars_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow columns = gridCars.CurrentRow;

            tPlaka.Text = columns.Cells["plaka"].Value.ToString();
            cmbMarka.Text = columns.Cells["marka"].Value.ToString();
            cmbSeriNo.Text = columns.Cells["seri"].Value.ToString();
            tRenk.Text = columns.Cells["renk"].Value.ToString();
            tKm.Text = columns.Cells["km"].Value.ToString();
            cmbYakit.Text = columns.Cells["yakit"].Value.ToString();
            tKiraUcreti.Text = columns.Cells["kiraucreti"].Value.ToString();
            tModel.Text = columns.Cells["yil"].Value.ToString();

            string imgLocation = columns.Cells["resim"].Value.ToString();

            if (File.Exists(imgLocation))
            {
                pcboxCar.ImageLocation = imgLocation;
                img = imgLocation;
            }
            else
            {
                pcboxCar.Image = System.Drawing.Image.FromFile(mainFunctions.DefaultCarPicture);
            }
        
           
        }
        string Uimg;
        bool resimdegisti = false;
        private void pcboxCar_Click(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            opd.Filter = "Select Image |*.jpg;*.png;*jpeg;";


            if (opd.ShowDialog() == DialogResult.OK)
            {
                pcboxCar.ImageLocation = opd.FileName;
                Uimg = opd.FileName;
                resimdegisti = true;
            }

        }

        private void bGuncelle_Click(object sender, EventArgs e)
        {
            string query_upd_car = "UPDATE TblArac SET marka=@marka, seri=@seri, yil=@yil,renk=@renk,km=@km,yakit=@yakit,kiraucreti=@kiraucreti,resim=@resim,tarih=@tarih WHERE plaka=@plaka";
            SqlCommand cmd_upd_car = new SqlCommand();
            cmd_upd_car.Parameters.AddWithValue("@marka", cmbMarka.Text);
            cmd_upd_car.Parameters.AddWithValue("@seri", cmbSeriNo.Text);
            cmd_upd_car.Parameters.AddWithValue("@yil", tModel.Text);
            cmd_upd_car.Parameters.AddWithValue("@renk", tRenk.Text);
            cmd_upd_car.Parameters.AddWithValue("@km", tKm.Text);
            cmd_upd_car.Parameters.AddWithValue("@kiraucreti", tKiraUcreti.Text);
            cmd_upd_car.Parameters.AddWithValue("@yakit", cmbYakit.Text);
            cmd_upd_car.Parameters.AddWithValue("@tarih", DateTime.Today.ToShortDateString());
            cmd_upd_car.Parameters.AddWithValue("@plaka", tPlaka.Text);

            if (resimdegisti == true)
            {
                cmd_upd_car.Parameters.AddWithValue("@resim", Uimg);
            }
            else
            {
                cmd_upd_car.Parameters.AddWithValue("@resim", img);
            }

            mainFunctions.DML(cmd_upd_car, query_upd_car);
            ListCars();
            guna2MessageDialog1.Show("Güncelleme işlemi başarıyla gerçekleştirildi!", "Rent a Car");
     
        }

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
                else if (cmbMarka.SelectedIndex == 1)
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

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string qry_dlt_car = "UPDATE TblArac SET aktif = @aktif WHERE plaka = @plaka";
            SqlCommand cmd_del_car = new SqlCommand();


            string plk = gridCars.CurrentRow.Cells["Plaka"].Value.ToString();

            cmd_del_car.Parameters.AddWithValue("@aktif", false);
            cmd_del_car.Parameters.AddWithValue("@plaka", plk);

            mainFunctions.DML(cmd_del_car, qry_dlt_car);
            ListCars();
            guna2MessageDialog1.Show("Silme işlemi başarıyla gerçekleştirildi!", "Rent A Car");

            foreach(Control item in Controls)
            {
                if (item is Guna2TextBox || item is Guna2ComboBox)
                {
                    item.Text = "";
                }
                
            }
            pcboxCar.Image = null;
        }

        private void tSearch_TextChanged(object sender, EventArgs e)
        {
            string query_list_car = "SELECT * FROM Tblarac WHERE plaka LIKE '%"+tSearch.Text +"%' and aktif = 1";
            SqlDataAdapter adpt = new SqlDataAdapter();


            gridCars.Columns["plaka"].HeaderText = "Plaka";
            gridCars.Columns["marka"].HeaderText = "Marka";
            gridCars.Columns["seri"].HeaderText = "Seri";
            gridCars.Columns["yil"].HeaderText = "Yıl";
            gridCars.Columns["renk"].HeaderText = "Km";
            gridCars.Columns["km"].HeaderText = "Plaka";
            gridCars.Columns["yakit"].HeaderText = "Yakıt";
            gridCars.Columns["kiraucreti"].HeaderText = "Kira Ücreti";

            gridCars.Columns["tarih"].HeaderText = "Tarih";

            gridCars.Columns["durum"].HeaderText = false ? "Boşta" : "Kiralandı";



            gridCars.Columns["resim"].Visible = false;
            gridCars.Columns["aktif"].Visible = false;

            gridCars.DataSource = mainFunctions.Listele(adpt, query_list_car);
        }
    }
}
