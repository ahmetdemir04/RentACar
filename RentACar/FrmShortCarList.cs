using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    public partial class FrmShortCarList : Form
    {
        public FrmShortCarList()
        {
            InitializeComponent();
        }
        ClsMainFunctions main = new ClsMainFunctions();
        ClsControlHelper cHelper = new ClsControlHelper();
        private void ShortCarList_Load(object sender, EventArgs e)
        {

            gridCarList.DefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            gridCarList.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Regular);

            string qry = "Exec ListExsCar";
            SqlDataAdapter adp = new SqlDataAdapter();
            gridCarList.DataSource = main.Listele(adp, qry);

            cHelper.DatagridFormatter(gridCarList);
        }

        private void gridCarList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lPlaka.Text = gridCarList.CurrentRow.Cells["Plaka"].Value.ToString();
            lMarka.Text = gridCarList.CurrentRow.Cells["Marka"].Value.ToString();
            lModel.Text = gridCarList.CurrentRow.Cells["Model"].Value.ToString();
            lYil.Text = gridCarList.CurrentRow.Cells["Yil"].Value.ToString();
            lRenk.Text = gridCarList.CurrentRow.Cells["Renk"].Value.ToString();
            lSansizman.Text = gridCarList.CurrentRow.Cells["Sansizman"].Value.ToString();
            lYakitTipi.Text = gridCarList.CurrentRow.Cells["YakitTipi"].Value.ToString();
            lGunluk.Text = gridCarList.CurrentRow.Cells["GunlukUcret"].Value + " ₺";
            lKm.Text = gridCarList.CurrentRow.Cells["Km"].Value.ToString();


            string ImgSource = gridCarList.CurrentRow.Cells["Resim"].Value.ToString();


            if (ImgSource != "" && ImgSource != null)
            {
                if (File.Exists(ImgSource))
                {
                    pcboxCar.Image = Image.FromFile(ImgSource);
                }
                else
                {
                    pcboxCar.ImageLocation = main.DefaultCarPicture;
                }
            }
        }

        private void bSelect_Click(object sender, EventArgs e)
        {

            if (lPlaka.Text != "...")
            {
                FrmContract acikForm = Application.OpenForms["FrmContract"] as FrmContract;
                acikForm.ArabaID = Convert.ToInt32(gridCarList.CurrentRow.Cells["ArabaID"].Value);
                acikForm.GunlukUcret = cHelper.MakeDouble(gridCarList.CurrentRow.Cells["GunlukUcret"].Value.ToString());
                acikForm.Plaka = lPlaka.Text;
                acikForm.KiralamaFiyati = cHelper.MakeDouble(lGunluk.Text);
                this.Close();
            }
            else
            {
                cHelper.Gmessagebox("Lütfen listeden araba seçiniz!", "Rent A Car", "Warning").Show();
            }

        }


        private void tSearchPlate_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tSearchPlate.Text))
            {
                gridCarList.DataSource = null;
                string plate = tSearchPlate.Text.Trim();

                string qry = "Select ArabaID, Plaka, tMrk.Marka, tModel.Model,\r\nYil, Renk, Km, Sansizman, YakitTipi, GunlukUcret,\r\nDurum, Resim From TBLARAC tArac\r\nINNER JOIN TblMarka tMrk ON\r\ntArac.ArabaID = tMrk.MarkaID\r\nINNER JOIN TblModel tModel ON \r\ntMrk.MarkaID = tModel.Marka\r\n\r\n\r\n\r\nWHERE Plaka LIKE '%" + plate +"%'";
                SqlDataAdapter adp = new SqlDataAdapter();
                gridCarList.DataSource = main.Listele(adp, qry); cHelper.DatagridFormatter(gridCarList);
            }
        }
    }
}
