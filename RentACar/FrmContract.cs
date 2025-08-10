using Guna.UI2.WinForms;
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
    public partial class FrmContract : Form
    {
        public FrmContract()
        {
            InitializeComponent();
        }
        MainFunctions mainfunction = new MainFunctions();
        ClsControlHelper cHelper = new ClsControlHelper();
        ClsConnection con = new ClsConnection();

        public string Plaka { get; set; }
        public double KiralamaFiyati { get; set; }
        public int? ArabaID { get; set; }

        public double GunlukUcret { get; set; }

        private void FrmContract_Load(object sender, EventArgs e)
        {
            gridContract.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Regular);
            gridContract.DefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Regular);

            BostakiAraclar();

            BringCarList();
        }

        private void BostakiAraclar()
        {
            string sorgu = "Select * FROM Tblarac WHERE Durum = 1";
            mainfunction.Bos_Araclar(cmbArac, sorgu);
        }

        private void BringCarList()
        {
            string qry = "Exec ListRentCars";
            SqlDataAdapter adtr = new SqlDataAdapter();
            gridContract.DataSource = mainfunction.Listele(adtr, qry);
            cHelper.DatagridFormatter(gridContract);
        }

        private void txtTC_TextChanged(object sender, EventArgs e)
        {
            //if (txtTC.Text == "") foreach (Control item in splitContainer2.Panel1.Controls) if (item is Guna2TextBox) item.Text = "";
            //if (txtTC.TextLength == 11)
            //{
            //    string qry = "select * from Tblmusteri WHERE tc = '" + txtTC.Text + "'";
            //    mainfunction.TC_ara(txtTC, txtAdSoyad, txtTelefon, qry);
            //}

        }
        private double BringCarPrice(string _plaka)
        {
            SqlCommand cmd = new SqlCommand("SELECT GunlukUcret FROM TblArac WHERE Plaka = @pla", con.Connection());
            cmd.Parameters.AddWithValue("@pla", _plaka);
            object retValue = cmd.ExecuteScalar();
            con.Connection().Close();
            return Convert.ToDouble(retValue);
        }
        private void cmbArac_SelectedIndexChanged(object sender, EventArgs e)
        {
            KiralamaFiyati = BringCarPrice(cmbArac.Text);
            if (cmbArac.Text == "") foreach (Control item in splitContainer2.Panel2.Controls) if (item is Guna2TextBox) item.Text = "";

            string qry = "select ArabaID,GunlukUcret from Tblarac WHERE plaka = '" + cmbArac.SelectedItem + "'";
            using (SqlCommand cmd = new SqlCommand(qry, con.Connection()))
            {
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    ArabaID = Convert.ToInt32(rd["ArabaID"]);
                    GunlukUcret = Convert.ToDouble(rd["GunlukUcret"]);

                }

            }


            string imgPath = Path.Combine(Application.StartupPath, "Images", cmbArac.Text + ".png");

            if (File.Exists(imgPath))
            {
                pcboxCar.Image = Image.FromFile(imgPath);
            }
            else
            {
                pcboxCar.ImageLocation = mainfunction.DefaultCarPicture;
            }
            // mainfunction.CombodanGetir(cmbArac, txtMarka, txtseri, txtModel, txtrenk, qry);

        }

        private void txtKiraSekli_SelectedIndexChanged(object sender, EventArgs e)
        {
            string qry = "select * from Tblarac WHERE plaka = '" + cmbArac.SelectedItem + "'";
            //  mainfunction.Ucret_Hesapla(txtKiraSekli, txtKiraUcreti, qry);
        }

        private void bCalculate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbArac.Text))
            {
                DateTime gidis, donus;
                gidis = DateTime.Parse(datetimeDonus.Text);
                donus = DateTime.Parse(datetimeCikis.Text);

                TimeSpan gunfarki = gidis - donus;
                int toplamGun = gunfarki.Days;

                double ucret = toplamGun * KiralamaFiyati;

                txtKiraUcreti.Text = ucret.ToString();
            }
            else
            {
                cHelper.Gmessagebox("Lütfen bi araç seçimi yapınız!", "Rent A Car", "Warning");
            }
        }


        private void Clear()
        {
            datetimeCikis.Text = DateTime.Now.ToShortDateString();
            datetimeDonus.Text = DateTime.Now.ToShortDateString();
            txtKiraUcreti.Text = "";
            foreach (Control item in splitContainer1.Controls)
            {
                if (item is Guna2TextBox || item is Guna2ComboBox)
                {
                    item.Text = "";
                }
            }
        }

        private void bTemizle_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private bool CheckFields()
        {
            if (!string.IsNullOrEmpty(txtTC.Text) &&
                !string.IsNullOrEmpty(cmbArac.Text) &&
                !string.IsNullOrEmpty(txtKiraUcreti.Text) &&
                MusteriID != null &&
                ArabaID != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private void bContractAdd_Click(object sender, EventArgs e)
        {

            if (CheckFields())
            {
                DateTime baslangicTarihi = DateTime.Parse(datetimeCikis.Text);
                DateTime bitisTarihi = DateTime.Parse(datetimeDonus.Text);

                int toplamGun = (bitisTarihi - baslangicTarihi).Days;

                if (toplamGun <= 0)
                {
                    cHelper.Gmessagebox("Bitiş tarihi başlangıç tarihinden önce olamaz!", "Rent A Car", "Warning").Show();
                    return;
                }

                string query = "INSERT INTO TblKiralama (MusteriID,ArabaID,BaslangicTarihi,BitisTarihi,TotalPrice,GunlukUcret,OdemeDurumu,GeriDonusDurumu) VALUES (@MusteriID, @ArabaID, @BaslangicTarihi, @BitisTarihi, @TotalPrice, @GunlukUcret, @OdemeDurumu, @GeriDonusDurumu)";

                SqlCommand cmd_add_contract = new SqlCommand();
                cmd_add_contract.Parameters.AddWithValue("@MusteriID", MusteriID);
                cmd_add_contract.Parameters.AddWithValue("@ArabaID", ArabaID);
                cmd_add_contract.Parameters.AddWithValue("@BaslangicTarihi", DateTime.Parse(datetimeCikis.Text));
                cmd_add_contract.Parameters.AddWithValue("@BitisTarihi", DateTime.Parse(datetimeDonus.Text));
                cmd_add_contract.Parameters.AddWithValue("@TotalPrice", cHelper.MakeDouble(txtKiraUcreti.Text));
                cmd_add_contract.Parameters.AddWithValue("@GunlukUcret", GunlukUcret);
                cmd_add_contract.Parameters.AddWithValue("@OdemeDurumu", false);
                cmd_add_contract.Parameters.AddWithValue("@GeriDonusDurumu", false);

                bool worked = mainfunction.DML(cmd_add_contract, query);


                if (worked)
                {
                    string query2 = "UPDATE TblArac SET durum = 0 WHERE ArabaID = @Aid";
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Parameters.AddWithValue("@Aid", ArabaID);
                    mainfunction.DML(sqlCommand, query2);
                    cmbArac.Items.Clear();
                    BostakiAraclar();
                    BringCarList();

                    cHelper.Gmessagebox("Sözleşme başarıyla eklendi!", "Rent A Car", "Information").Show();
                    Clear();
                }

            }
            else
            {
                cHelper.Gmessagebox("Lütfen gerekli alanları doldurunuz!", "Rent A Car", "Warning").Show();
            }

        }


        private void bContractUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(plaka))
            {
                string query = "UPDATE TblSozlesme SET tc=@tc, adsoyad = @adsoyad, telefon=@telefon, ehliyetno=@ehliyetno, e_tarih = @e_tarih, e_yer =@e_yer, plaka=@plaka, marka=@marka, seri =@seri, yil=@yil, renk=@renk, kirasekli=@kirasekli, kiraucreti =@kiraucreti, gun=@gun, tutar=@tutar WHERE plaka =@plaka";

                SqlCommand cmd_upd_contract = new SqlCommand();
                cmd_upd_contract.Parameters.AddWithValue("@Tc", txtTC.Text);
                cmd_upd_contract.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                cmd_upd_contract.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                cmd_upd_contract.Parameters.AddWithValue("@ehliyetno", txtEhliyetNo.Text);
                cmd_upd_contract.Parameters.AddWithValue("@e_tarih", DateTime.Parse(dtEhliyetTarihi.Text));
                cmd_upd_contract.Parameters.AddWithValue("@e_yer", txtVerildigiYer.Text);
                cmd_upd_contract.Parameters.AddWithValue("@plaka", plaka); // Using the plaka variable set in gridCustomer_CellDoubleClick


                mainfunction.DML(cmd_upd_contract, query);


                BostakiAraclar();
                BringCarList();

                guna2MessageDialog1.Show("Sözleşme başarıyla güncellendi!", "Rent A Car");

                foreach (Control item in splitContainer1.Controls)
                {
                    if (item is Guna2TextBox || item is Guna2ComboBox)
                    {
                        item.Text = "";
                    }
                }
                datetimeCikis.Text = DateTime.Now.ToShortDateString();
                datetimeDonus.Text = DateTime.Now.ToShortDateString();
            }
            else
            {
                MessageBox.Show("Lütfen bir sözleşme seçiniz!", "Rent A Car", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        string plaka;
        private void gridCustomer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = gridContract.CurrentRow;

            //txtTC.Text = row.Cells["tc"].Value.ToString();
            //txtAdSoyad.Text = row.Cells["adsoyad"].Value.ToString();
            //txtTelefon.Text = row.Cells["telefon"].Value.ToString();
            //txtEhliyetNo.Text = row.Cells["ehliyetno"].Value.ToString();
            //dtEhliyetTarihi.Text = row.Cells["e_tarih"].Value.ToString();
            //txtVerildigiYer.Text = row.Cells["e_yer"].Value.ToString();
            //plaka = row.Cells["plaka"].Val
            int? kiraID = Convert.ToInt32(row.Cells["KiraID"].Value);

            if (kiraID == null)
                return;

            FrmCarTakeBack fCarTakeBack = new FrmCarTakeBack();
            fCarTakeBack.KiraID = kiraID;
            fCarTakeBack.BaslangicTarihi = DateTime.Parse(gridContract.CurrentRow.Cells["BaslangicTarihi"].Value.ToString()).ToShortDateString();
            fCarTakeBack.BitisTarihi = DateTime.Parse(gridContract.CurrentRow.Cells["BitisTarihi"].Value.ToString()).ToShortDateString();
            fCarTakeBack.ShowDialog();


        }

        private void gridCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridViewRow row = gridContract.CurrentRow;

            //DateTime bugun = DateTime.Parse(DateTime.Now.ToShortDateString());
            //DateTime donus = DateTime.Parse(row.Cells["dtarih"].Value.ToString());

            //double ucret = double.Parse(row.Cells["kiraucreti"].Value.ToString());

            //TimeSpan gunfarki = donus - bugun;
            //int _gunfarki = gunfarki.Days;

            //double ucretfarki = _gunfarki * ucret;
            //txtEkstra.Text = ucretfarki.ToString();
        }

        private void bCarDelivery_Click(object sender, EventArgs e)
        {
            if (double.Parse(txtEkstra.Text) >= 0)
            {
                DataGridViewRow row = gridContract.CurrentRow;
                DateTime bugun = DateTime.Parse(DateTime.Now.ToShortDateString());
                double ucret = double.Parse(row.Cells["kiraucreti"].Value.ToString());
                double tutar = double.Parse(row.Cells["tutar"].Value.ToString());
                DateTime cikis = DateTime.Parse(row.Cells["ctarih"].Value.ToString());
                TimeSpan gun = bugun - cikis;
                int _gun = gun.Days;

                double toplamtutar = _gun * ucret;
                // Toplam tutar, _gun satis tablosuna aktarılacak

                string sorgu = "UPDATE TblSozlesme SET GeriAlindi = 1 WHERE plaka = '" + row.Cells["plaka"].Value.ToString() + "'";
                SqlCommand cmd = new SqlCommand();
                mainfunction.DML(cmd, sorgu);

                string sorgu2 = "UPDATE TblArac SET durum = 1 WHERE plaka = '" + row.Cells["plaka"].Value.ToString() + "'";
                SqlCommand cmd2 = new SqlCommand();
                mainfunction.DML(cmd2, sorgu2);

                string sorgu3 = "INSERT INTO TblSatis (tc, adsoyad, plaka, marka, seri, yil, renk, gun, fiyat, tutar, tarih1, tarih2) VALUES (@tc, @adsoyad, @plaka, @marka, @seri, @yil, @renk, @gun, @fiyat, @tutar, @tarih1, @tarih2)";
                SqlCommand cmd3 = new SqlCommand();
                cmd3.Parameters.AddWithValue("@tc", row.Cells["tc"].Value.ToString());
                cmd3.Parameters.AddWithValue("@adsoyad", row.Cells["adsoyad"].Value.ToString());
                cmd3.Parameters.AddWithValue("@plaka", row.Cells["plaka"].Value.ToString());
                cmd3.Parameters.AddWithValue("@marka", row.Cells["marka"].Value.ToString());
                cmd3.Parameters.AddWithValue("@seri", row.Cells["seri"].Value.ToString());
                cmd3.Parameters.AddWithValue("@yil", row.Cells["yil"].Value.ToString());
                cmd3.Parameters.AddWithValue("@renk", row.Cells["renk"].Value.ToString());
                cmd3.Parameters.AddWithValue("@gun", _gun);
                cmd3.Parameters.AddWithValue("@fiyat", toplamtutar);
                cmd3.Parameters.AddWithValue("@tutar", ucret);
                cmd3.Parameters.AddWithValue("@tarih1", DateTime.Parse(row.Cells["ctarih"].Value.ToString()));
                cmd3.Parameters.AddWithValue("@tarih2", DateTime.Now);

                mainfunction.DML(cmd3, sorgu3);

                guna2MessageDialog1.Show("Araç teslim alındı!", "Rent A Car");
                txtEkstra.Text = "";

                cmbArac.Items.Clear();
                BostakiAraclar();
                BringCarList();

                guna2MessageDialog1.Show("Sözleşme başarıyla eklendi!", "RentACar");

                foreach (Control item in splitContainer1.Controls)
                {
                    if (item is Guna2TextBox || item is Guna2ComboBox)
                    {
                        item.Text = "";
                    }
                }
                datetimeCikis.Text = DateTime.Now.ToShortDateString();
                datetimeDonus.Text = DateTime.Now.ToShortDateString();
                Clear();
            }
            else
            {
                MessageBox.Show("Lütfen seçim yapınız", "Rent A Car", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCarList_Click(object sender, EventArgs e)
        {
            FrmShortCarList carList = new FrmShortCarList();
            carList.ShowDialog();

            cmbArac.Text = Plaka;

        }
        int? MusteriID;
        private void txtTC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtTC.Text))
                {
                    string tc = txtTC.Text.Trim();

                    string qry = "SELECT * FROM TblMusteri";
                    SqlCommand cmd = new SqlCommand();


                    if (mainfunction.IsThereAny(cmd, qry, tc))
                    {
                        string qry2 = "SELECT * FROM TblMusteri Where TC = @tc";


                        SqlCommand cmd2 = new SqlCommand(qry2, con.Connection());
                        cmd2.Parameters.AddWithValue("@tc", tc);
                        SqlDataReader rd = cmd2.ExecuteReader();

                        while (rd.Read())
                        {
                            txtAdSoyad.Text = rd["Ad"] + " " + rd["Soyad"];
                            txtTelefon.Text = rd["Telefon"].ToString();
                            txtTelefon.Text = rd["Email"].ToString();
                            txtEhliyetNo.Text = rd["LisansNumarasi"].ToString();
                            dtEhliyetTarihi.Text = rd["EhliyetinVerildigiTarih"].ToString();
                            txtVerildigiYer.Text = rd["VerildigiYer"].ToString();
                            MusteriID = Convert.ToInt32(rd["MusteriID"]);

                        }
                    }



                }
            }
        }

      
    }

}
