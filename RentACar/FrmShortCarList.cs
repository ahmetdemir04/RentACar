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
        MainFunctions main = new MainFunctions();
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
            tPlaka.Text = gridCarList.CurrentRow.Cells["Plaka"].Value.ToString();
            tMarka.Text = gridCarList.CurrentRow.Cells["Marka"].Value.ToString();
            tModel.Text = gridCarList.CurrentRow.Cells["Model"].Value.ToString();
            tYil.Text = gridCarList.CurrentRow.Cells["Yil"].Value.ToString();
            tRenk.Text = gridCarList.CurrentRow.Cells["Renk"].Value.ToString();
            tSansizman.Text = gridCarList.CurrentRow.Cells["Sansizman"].Value.ToString();
            tYakitTipi.Text = gridCarList.CurrentRow.Cells["YakitTipi"].Value.ToString();
            tGunluk.Text = gridCarList.CurrentRow.Cells["GunlukUcret"].Value + " ₺";
            tKm.Text = gridCarList.CurrentRow.Cells["Km"].Value.ToString();


            string pics = gridCarList.CurrentRow.Cells["Resim"].Value.ToString();

            string pLocation = Path.Combine(Application.StartupPath, "Images", pics);

            if (pics != "" && pics != null)
            {
                if (File.Exists(pLocation))
                {
                    pcboxCar.Image = Image.FromFile(pics);
                }
                else
                {
                    pcboxCar.ImageLocation = main.DefaultCarPicture;
                }
            }
        }

        private void bSelect_Click(object sender, EventArgs e)
        {

            if (tPlaka.Text != "...")
            {
                FrmContract acikForm = Application.OpenForms["FrmContract"] as FrmContract;
                acikForm.ArabaID = Convert.ToInt32(gridCarList.CurrentRow.Cells["ArabaID"].Value);
                acikForm.GunlukUcret = cHelper.MakeDouble(gridCarList.CurrentRow.Cells["GunlukUcret"].Value.ToString());
                acikForm.Plaka = tPlaka.Text;
                acikForm.KiralamaFiyati = cHelper.MakeDouble(tGunluk.Text);
                this.Close();
            }
            else
            {
                cHelper.Gmessagebox("Lütfen listeden araba seçiniz!", "Rent A Car", "Warning").Show();
            }

        }

    
    }
}
