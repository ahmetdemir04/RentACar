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
        ClsControlHelper cHelper = new ClsControlHelper();
        private void FrmCarList_Load(object sender, EventArgs e)
        {
            ListCars();
            gridCars.DefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            gridCars.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Regular);


            mainFunctions.BringMarka(cmbMarka);
        }

        private void ListCars()
        {
            string query_list_car = "Exec ListCars";
            SqlDataAdapter adpt = new SqlDataAdapter();

            gridCars.DataSource = mainFunctions.Listele(adpt, query_list_car);

            cHelper.DatagridFormatter(gridCars);

            gridCars.Columns["Durum"].HeaderText = "Boşta";

            gridCars.Columns["resim"].Visible = false;
            gridCars.Columns["aktif"].Visible = false;

        }
        string img;

        private void gridCars_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow columns = gridCars.CurrentRow;

            tPlaka.Text = columns.Cells["Plaka"].Value.ToString();
            cmbMarka.Text = columns.Cells["Marka"].Value.ToString();
            cmbSeri.Text = columns.Cells["Model"].Value.ToString();
            tModel.Text = columns.Cells["Yil"].Value.ToString();
            tRenk.Text = columns.Cells["renk"].Value.ToString();
            tKm.Text = columns.Cells["Km"].Value.ToString();
            CmbSanziman.Text = columns.Cells["Sansizman"].Value.ToString();
            cmbYakit.Text = columns.Cells["YakitTipi"].Value.ToString();
            tKiraUcreti.Text = columns.Cells["GunlukUcret"].Value.ToString();

            string durumu = columns.Cells["Durum"].Value.ToString();

            if (durumu == "True")
            {
                ChcDurumu.Checked = true;
            }
            else
            {
                ChcDurumu.Checked = false;
            }

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
        string AddImg(string _image, string _plateNumber)
        {
            string Destiny = Path.Combine(Application.StartupPath, @"Images", _plateNumber + ".png");

            if (File.Exists(Destiny))
                File.Delete(Destiny);

            File.Copy(Uimg, Destiny);

            return Destiny;
        }
        private bool CheckAllFields()
        {
            if (id != null)
            {
                return true;
            }
            else { return false; }
        }
        int? id;
        private void bGuncelle_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(gridCars.CurrentRow.Cells["ArabaID"].Value);

            if (CheckAllFields())
            {
                string query_upd_car = "UPDATE TblArac SET Plaka= @plaka, marka=@marka, model=@model, yil=@yil,renk=@renk,Sansizman=@sanziman, YakitTipi=@YakitTipi, km=@km,GunlukUcret=@gunlukucret,durum=@durum,resim=@resim WHERE ArabaID=@id";
                SqlCommand cmd_upd_car = new SqlCommand();
                cmd_upd_car.Parameters.AddWithValue("@marka", cmbMarka.SelectedValue);
                cmd_upd_car.Parameters.AddWithValue("@model", cmbSeri.SelectedValue);
                cmd_upd_car.Parameters.AddWithValue("@yil", tModel.Text);
                cmd_upd_car.Parameters.AddWithValue("@renk", tRenk.Text);
                cmd_upd_car.Parameters.AddWithValue("@sanziman", CmbSanziman.Text);
                cmd_upd_car.Parameters.AddWithValue("@YakitTipi", cmbYakit.Text);
                cmd_upd_car.Parameters.AddWithValue("@km", int.Parse(tKm.Text));
                cmd_upd_car.Parameters.AddWithValue("@gunlukucret", cHelper.MakeDouble(tKiraUcreti.Text));
                cmd_upd_car.Parameters.AddWithValue("@durum", ChcDurumu.CheckState);
                cmd_upd_car.Parameters.AddWithValue("@plaka", tPlaka.Text);
                cmd_upd_car.Parameters.AddWithValue("@id", id);

                if (resimdegisti == true)
                {
                    string img = AddImg(Uimg, tPlaka.Text);
                    cmd_upd_car.Parameters.AddWithValue("@resim", img);
                }
                else
                {
                    cmd_upd_car.Parameters.AddWithValue("@resim", img);
                }

                bool worked = mainFunctions.DML(cmd_upd_car, query_upd_car);

                if (worked)
                    cHelper.Gmessagebox("Güncelleme işlemi başarıyla gerçekleştirildi!", "Rent A Car", "Information").Show();

                ListCars();
                cHelper.ClearFields(this);
                id = null;
            }
        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSeri.DataSource = null;

            if (cmbMarka.Text == null)
                return;

            if (int.TryParse(cmbMarka.SelectedValue?.ToString(), out int markaId))
            {
                mainFunctions.BringModel(cmbSeri, markaId);
            }

        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(gridCars.CurrentRow.Cells["ArabaId"].Value);
            string plate = gridCars.CurrentRow.Cells["Plaka"].Value.ToString();

            DialogResult dialogue = cHelper.Gmessagebox($"{plate} Numarasına sahip olan kaydı silmek istediğinize emin misiniz?", "Rent A Car", "Question").Show();

            if (dialogue == DialogResult.Yes)
            {
                string qry_dlt_car = "UPDATE TblArac SET aktif = @aktif WHERE ArabaId = @id";
                SqlCommand cmd_del_car = new SqlCommand();

                cmd_del_car.Parameters.AddWithValue("@aktif", false);
                cmd_del_car.Parameters.AddWithValue("@id", id);

                bool worked = mainFunctions.DML(cmd_del_car, qry_dlt_car);
                if (worked)
                    cHelper.Gmessagebox("Silme işlemi başarıyla gerçekleştirildi!", "Rent A Car", "Information").Show();
                ListCars();

                cHelper.ClearFields(this);
                pcboxCar.Image = null;
            }


        }

        private void tSearch_TextChanged(object sender, EventArgs e)
        {
            string query_list_car = "SELECT * FROM Tblarac WHERE plaka LIKE '%" + tSearch.Text + "%' and aktif = 1";
            SqlDataAdapter adpt = new SqlDataAdapter();

            gridCars.Columns["durum"].HeaderText = false ? "Boşta" : "Kiralandı";



            gridCars.Columns["resim"].Visible = false;
            gridCars.Columns["aktif"].Visible = false;

            gridCars.DataSource = mainFunctions.Listele(adpt, query_list_car);
        }

        private void tKiraUcreti_MouseEnter(object sender, EventArgs e)
        {
            if (tKiraUcreti.Text == "")
            {
                tKiraUcreti.Text = string.Empty;
            }
        }

        private void tKiraUcreti_MouseLeave(object sender, EventArgs e)
        {
            string value = tKiraUcreti.Text;
            if (string.IsNullOrEmpty(value))
            {
                tKiraUcreti.Text = 0.ToString("N0");
            }
        }
    }
}
