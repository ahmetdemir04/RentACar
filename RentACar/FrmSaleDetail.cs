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
    public partial class FrmSaleDetail : Form
    {
        public FrmSaleDetail()
        {
            InitializeComponent();
        }

        ClsConnection con = new ClsConnection();
        public int? OdemeID { get; set; }

        private void BringCarDetail()
        {
            try
            {

                int ArabaID = 0;

                string qry_rent = "SELECT ArabaID,BaslangicTarihi,GercekTeslimTarihi FROM TblKiralama WHERE KiraID = @KID";
                using (SqlCommand cmd_rent = new SqlCommand(qry_rent, con.Connection()))
                {

                    cmd_rent.Parameters.AddWithValue("@KID", OdemeID);
                    SqlDataReader rd = cmd_rent.ExecuteReader();

                    if (rd.Read())
                    {
                        lblBaslangicTarihi.Text = DateTime.Parse(rd["BaslangicTarihi"].ToString()).ToShortDateString();
                        lblBitisTarihi.Text = DateTime.Parse(rd["GercekTeslimTarihi"].ToString()).ToShortDateString();
                        ArabaID = Convert.ToInt32(rd["ArabaID"]);
                    }

                }


                string qry_car_detail = "Select * From TblArac WHERE ArabaID = @carid";
                using (SqlCommand cmd_car_detail = new SqlCommand(qry_car_detail, con.Connection()))
                {
                    cmd_car_detail.Parameters.AddWithValue("@carid", ArabaID);

                    SqlDataReader rd2 = cmd_car_detail.ExecuteReader();

                    if (rd2.Read())
                    {
                        tPlaka.Text = rd2["Plaka"].ToString();
                        tMarka.Text = rd2["Marka"].ToString();
                        tModel.Text = rd2["Model"].ToString();
                        tYil.Text = rd2["Yil"].ToString();
                        tRenk.Text = rd2["Renk"].ToString();
                        tSansizman.Text = rd2["Sansizman"].ToString();
                        tYakitTipi.Text = rd2["YakitTipi"].ToString();
                        tGunluk.Text = rd2["GunlukUcret"].ToString();
                        tKm.Text = rd2["Km"].ToString();
                        string ImgPath = rd2["Resim"].ToString();


                        if (File.Exists(ImgPath))
                        {
                            pcboxCar.Image = Image.FromFile(ImgPath);
                        }

                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally { con.Connection().Close(); }
        }
        private void FrmSaleDetail_Load(object sender, EventArgs e)
        {


            lblID.Text = OdemeID.ToString();
            BringCarDetail();


        }
    }
}
