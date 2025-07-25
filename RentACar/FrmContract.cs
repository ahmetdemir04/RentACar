using Guna.UI2.WinForms;
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

namespace RentACar
{
    public partial class FrmContract : Form
    {
        public FrmContract()
        {
            InitializeComponent();
        }
        MainFunctions mainfunction = new MainFunctions();
        private void FrmContract_Load(object sender, EventArgs e)
        {
            BostakiAraclar();

            BringCarList();
        }

        private void BostakiAraclar()
        {
            string sorgu = "Select  * from tblarac WHERE durum = 1";
            mainfunction.Bos_Araclar(cmbArac, sorgu);
        }

        private void BringCarList()
        {
            string qry = "select * from Tblsozlesme";
            SqlDataAdapter adtr = new SqlDataAdapter();
            gridCustomer.DataSource = mainfunction.Listele(adtr, qry);
        }

        private void txtTC_TextChanged(object sender, EventArgs e)
        {
            if (txtTC.Text == "") foreach (Control item in splitContainer2.Panel1.Controls) if (item is Guna2TextBox) item.Text = "";
            if (txtTC.TextLength == 11)
            {
                string qry = "select * from Tblmusteri WHERE tc = '" + txtTC.Text + "'";
                mainfunction.TC_ara(txtTC, txtAdSoyad, txtTelefon, qry);
            }

        }

        private void cmbArac_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbArac.Text == "") foreach (Control item in splitContainer2.Panel2.Controls) if (item is Guna2TextBox) item.Text = "";

            string qry = "select * from Tblarac WHERE plaka = '" + cmbArac.SelectedItem + "'";
            mainfunction.CombodanGetir(cmbArac, txtMarka, txtseri, txtModel, txtrenk, qry);

        }

        private void txtKiraSekli_SelectedIndexChanged(object sender, EventArgs e)
        {
            string qry = "select * from Tblarac WHERE plaka = '" + cmbArac.SelectedItem + "'";
            mainfunction.Ucret_Hesapla(txtKiraSekli, txtKiraUcreti, qry);
        }

        private void bCalculate_Click(object sender, EventArgs e)
        {
            DateTime gidis, donus;
            gidis = DateTime.Parse(datetimeDonus.Text);
            donus = DateTime.Parse(datetimeCikis.Text);

            TimeSpan gunfarki = gidis - donus;
            int gun = gunfarki.Days;
            txtGun.Text = gun.ToString();

            txtTutar.Text = (gun * int.Parse(txtKiraUcreti.Text)).ToString();
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            datetimeCikis.Text = DateTime.Now.ToShortDateString();
            datetimeDonus.Text = DateTime.Now.ToShortDateString();
            txtKiraUcreti.Text = "";
            txtKiraSekli.Text = "";
            txtGun.Text = "";
            txtTutar.Text = "";
        }

        private void bTemizle_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void bContractAdd_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO TblSozlesme (Tc,adsoyad,telefon,ehliyetno,e_tarih,e_yer,plaka,marka,seri,yil,renk,kirasekli,kiraucreti,gun,tutar,cTarih,dTarih) VALUES (@Tc,@adsoyad,@telefon,@ehliyetno,@e_tarih,@e_yer,@plaka,@marka,@seri,@yil,@renk,@kirasekli,@kiraucreti,@gun,@tutar,@cTarih,@dTarih)";

            SqlCommand cmd_add_contract = new SqlCommand();
            cmd_add_contract.Parameters.AddWithValue("@Tc", txtTC.Text);
            cmd_add_contract.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            cmd_add_contract.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            cmd_add_contract.Parameters.AddWithValue("@ehliyetno", txtEhliyetNo.Text);
            cmd_add_contract.Parameters.AddWithValue("@e_tarih", txtEhliyetTarihi.Text);
            cmd_add_contract.Parameters.AddWithValue("@e_yer", txtEhlytVerildigiTarih.Text);
            cmd_add_contract.Parameters.AddWithValue("@plaka", cmbArac.SelectedItem);
            cmd_add_contract.Parameters.AddWithValue("@marka", txtMarka.Text);
            cmd_add_contract.Parameters.AddWithValue("@seri", txtseri.Text);
            cmd_add_contract.Parameters.AddWithValue("@yil", txtModel.Text);
            cmd_add_contract.Parameters.AddWithValue("@renk", txtrenk.Text);
            cmd_add_contract.Parameters.AddWithValue("@kirasekli", txtKiraSekli.Text);
            cmd_add_contract.Parameters.AddWithValue("@kiraucreti", double.Parse(txtKiraUcreti.Text));
            cmd_add_contract.Parameters.AddWithValue("@gun", int.Parse(txtGun.Text));
            cmd_add_contract.Parameters.AddWithValue("@tutar", double.Parse(txtTutar.Text));
            cmd_add_contract.Parameters.AddWithValue("@cTarih", DateTime.Parse(datetimeCikis.Text));
            cmd_add_contract.Parameters.AddWithValue("@dTarih", DateTime.Parse(datetimeDonus.Text));


            mainfunction.DML(cmd_add_contract, query);


            string query2 = "UPDATE TblArac SET durum = 0 WHERE plaka = @plaka";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Parameters.AddWithValue("@plaka", cmbArac.SelectedItem);
            mainfunction.DML(sqlCommand, query2);
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
        }

        private void bContractUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(plaka))
            {
                string query = "UPDATE TblSozlesme SET tc=@tc, adsoyad = @adsoyad, telefon=@telefon, ehliyetno=@ehliyetno, e_tarih = @e_tarih, e_yer =@e_yer, plaka=@plaka, marka=@marka, seri =@seri, yil=@yil, renk=@renk, kirasekli=@kirasekli, kiraucreti =@kiraucreti, gun=@gun, tutar=@tutar WHERE plaka =@plaka";

                SqlCommand cmd_upd_contract = new SqlCommand();
                cmd_upd_contract.Parameters.AddWithValue("@Tc", txtTC.Text);
                cmd_upd_contract.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                cmd_upd_contract.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                cmd_upd_contract.Parameters.AddWithValue("@ehliyetno", txtEhliyetNo.Text);
                cmd_upd_contract.Parameters.AddWithValue("@e_tarih", txtEhliyetTarihi.Text);
                cmd_upd_contract.Parameters.AddWithValue("@e_yer", txtEhlytVerildigiTarih.Text);
                cmd_upd_contract.Parameters.AddWithValue("@plaka", plaka); // Using the plaka variable set in gridCustomer_CellDoubleClick
                cmd_upd_contract.Parameters.AddWithValue("@marka", txtMarka.Text);
                cmd_upd_contract.Parameters.AddWithValue("@seri", txtseri.Text);
                cmd_upd_contract.Parameters.AddWithValue("@yil", txtModel.Text);
                cmd_upd_contract.Parameters.AddWithValue("@renk", txtrenk.Text);
                cmd_upd_contract.Parameters.AddWithValue("@kirasekli", txtKiraSekli.Text);
                cmd_upd_contract.Parameters.AddWithValue("@kiraucreti", double.Parse(txtKiraUcreti.Text));
                cmd_upd_contract.Parameters.AddWithValue("@gun", int.Parse(txtGun.Text));
                cmd_upd_contract.Parameters.AddWithValue("@tutar", double.Parse(txtTutar.Text));
                cmd_upd_contract.Parameters.AddWithValue("@cTarih", DateTime.Parse(datetimeCikis.Text));
                cmd_upd_contract.Parameters.AddWithValue("@dTarih", DateTime.Parse(datetimeDonus.Text));

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
                MessageBox.Show("Lütfen bir sözleşme seçiniz!", "Rent A Car",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }
        string plaka;
        private void gridCustomer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = gridCustomer.CurrentRow;

            txtTC.Text = row.Cells["tc"].Value.ToString();
            txtAdSoyad.Text = row.Cells["adsoyad"].Value.ToString();
            txtTelefon.Text = row.Cells["telefon"].Value.ToString();
            txtEhliyetNo.Text = row.Cells["ehliyetno"].Value.ToString();
            txtEhliyetTarihi.Text = row.Cells["e_tarih"].Value.ToString();
            txtEhlytVerildigiTarih.Text = row.Cells["e_yer"].Value.ToString();
            plaka = row.Cells["plaka"].Value.ToString();
            txtMarka.Text = row.Cells["marka"].Value.ToString();
            txtseri.Text = row.Cells["seri"].Value.ToString();
            txtModel.Text = row.Cells["yil"].Value.ToString();
            txtrenk.Text = row.Cells["renk"].Value.ToString();
            txtKiraSekli.Text = row.Cells["kirasekli"].Value.ToString();
            txtKiraUcreti.Text = row.Cells["kiraucreti"].Value.ToString();
            txtGun.Text = row.Cells["gun"].Value.ToString();
            txtTutar.Text = row.Cells["tutar"].Value.ToString();
            datetimeCikis.Text = row.Cells["cTarih"].Value.ToString();
            datetimeDonus.Text = row.Cells["dTarih"].Value.ToString();
        }
    }
}
