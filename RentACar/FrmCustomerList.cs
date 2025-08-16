using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    public partial class FrmCustomerList : Form
    {
        public FrmCustomerList()
        {
            InitializeComponent();
        }
        ClsMainFunctions mainfunction = new ClsMainFunctions();
        ClsControlHelper Chelper = new ClsControlHelper();
        private void FrmCustomerList_Load(object sender, EventArgs e)
        {
            ListCustomer();
            gridCustomer.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 11);
            gridCustomer.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 11);

            #region CheckFields
            tLisansNumarasi.KeyPress += Chelper.OnlyNumeric;
            tTC.KeyPress += Chelper.OnlyNumeric;
            tTelefon.KeyPress += Chelper.OnlyNumeric;

            tAd.KeyPress += Chelper.OnlyAlphabetic;
            tSoyad.KeyPress += Chelper.OnlyAlphabetic;
            #endregion
        }
        private void ClearFields()
        {
            Chelper.ClearFields(splitContainer1.Panel1);
            tSearch.Clear();
            tLisansNumarasi.Focus();
        }
        private bool CheckAllFields()
        {
            if (!string.IsNullOrEmpty(tLisansNumarasi.Text) &&
                !string.IsNullOrEmpty(tTC.Text) &&
                !string.IsNullOrEmpty(tAd.Text) &&
                !string.IsNullOrEmpty(tSoyad.Text) &&
                !string.IsNullOrEmpty(tTelefon.Text) &&
                !string.IsNullOrEmpty(tEposta.Text) &&
                !string.IsNullOrEmpty(tAdres.Text))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        private void ClearSerach(object sender, EventArgs e)
        {
            tSearch.Text = string.Empty;
            tSearch.Focus();
        }
        private void ListCustomer()
        {
            gridCustomer.DataSource = null;

            string qry_customer = "Select * FROM TBLMUSTERI WHERE durumu = 1";
            SqlDataAdapter adtr = new SqlDataAdapter();

            gridCustomer.DataSource = mainfunction.Listele(adtr, qry_customer);


            Chelper.DatagridFormatter(gridCustomer);

            gridCustomer.Columns["Durumu"].Visible = false;
            gridCustomer.Columns["Durumu"].Visible = false;
        }

        private void tSearch_TextChanged(object sender, EventArgs e)
        {
            string qry_customer = string.Empty;
            SqlDataAdapter adtr = new SqlDataAdapter();
            if (rdAdSoyad.Checked == true)
            {
              qry_customer = "Select * FROM TBLMUSTERI WHERE (AD + Soyad) LIKE '%" + tSearch.Text + "%' and durumu = 1";
            }
            else if (rdTC.Checked == true)
            {
                qry_customer = "Select * FROM TBLMUSTERI WHERE TC LIKE '%" + tSearch.Text + "%' and durumu = 1";
            }
            gridCustomer.DataSource = mainfunction.Listele(adtr, qry_customer);

            Chelper.DatagridFormatter(gridCustomer);
            gridCustomer.Columns["Durumu"].Visible = false;
        }

        private void gridCustomer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = gridCustomer.CurrentRow;

            tTC.Text = satir.Cells["TC"].Value.ToString();
            tAd.Text = satir.Cells["Ad"].Value.ToString();
            tSoyad.Text = satir.Cells["Soyad"].Value.ToString();
            tTelefon.Text = satir.Cells["Telefon"].Value.ToString();
            tEposta.Text = satir.Cells["Email"].Value.ToString();
            tAdres.Text = satir.Cells["Adres"].Value.ToString();
            tLisansNumarasi.Text = satir.Cells["LisansNumarasi"].Value.ToString();
            DtDogumTarihi.Value = DateTime.Parse(satir.Cells["DogumTarihi"].Value.ToString());
            DtTarih.Value = DateTime.Parse(satir.Cells["EhliyetinVerildigiTarih"].Value.ToString());
            bool durumu = Convert.ToBoolean(satir.Cells["Durumu"].Value.ToString());

            if (durumu)
            {
                ChcDurumu.Checked = true;
            }
            else
            {
                ChcDurumu.Checked = false;
            }
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {
            if (CheckAllFields())
            {
                int? id = Convert.ToInt32(gridCustomer.CurrentRow.Cells["MusteriID"].Value);
                if (id != null)
                {
                    string qry_update_customer = "UPDATE TblMusteri SET Tc = @tc, Ad = @ad, Soyad=@soyad, Telefon =@telefon, Adres=@adres, Email=@Email, LisansNumarasi = @LN, DogumTarihi =@DT, EhliyetinVerildigiTarih =@VT,Durumu = @Durumu WHERE MusteriID = @ID";
                    SqlCommand cmd_update_customer = new SqlCommand();
                    cmd_update_customer.Parameters.AddWithValue("@Tc", tTC.Text);
                    cmd_update_customer.Parameters.AddWithValue("@Ad", tAd.Text);
                    cmd_update_customer.Parameters.AddWithValue("@Soyad", tSoyad.Text);
                    cmd_update_customer.Parameters.AddWithValue("@Telefon", tTelefon.Text.Trim());
                    cmd_update_customer.Parameters.AddWithValue("@Adres", tAdres.Text.Trim());
                    cmd_update_customer.Parameters.AddWithValue("@Email", tEposta.Text.Trim());
                    cmd_update_customer.Parameters.AddWithValue("@LN", tLisansNumarasi.Text.Trim());
                    cmd_update_customer.Parameters.AddWithValue("@DT", DateTime.Parse(DtDogumTarihi.Text));
                    cmd_update_customer.Parameters.AddWithValue("@VT", DateTime.Parse(DtTarih.Text));
                    cmd_update_customer.Parameters.AddWithValue("@ID", id);
                    cmd_update_customer.Parameters.AddWithValue("@Durumu", ChcDurumu.CheckState);

                    bool worked = mainfunction.DML(cmd_update_customer, qry_update_customer);

                    if (worked)
                        Chelper.Gmessagebox($"{tTC.Text} Numarasına sahip kişinin güncelleme işlemi başarılı!", "Rent A Car", "Information").Show();

                    ListCustomer();

                    Chelper.ClearFields(splitContainer1.Panel1);
                    ChcDurumu.Checked = false;
                    tLisansNumarasi.Focus();
                }
                else
                {
                    Chelper.Gmessagebox("Güncellemek istediğiniz veriyi lütfen listeden seçiniz!", "Rent A Car", "Warning").Show();
                }
            }
            else
            {
                Chelper.Gmessagebox($"Lütfen boş bi alan bırakmayınız!", "Rent A Car", "Warning").Show();
            }


        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string TC = gridCustomer.CurrentRow.Cells["TC"].Value.ToString();
            long ID = Convert.ToInt64(gridCustomer.CurrentRow.Cells["MusteriID"].Value);

            string delete_qry = "UPDATE TblMusteri SET durumu = 0 WHERE MusteriID = @id";
            SqlCommand cmd_delete = new SqlCommand();
            cmd_delete.Parameters.AddWithValue("@id", ID);

            DialogResult dialog = Chelper.Gmessagebox($"{TC} Kimlik numarasına sahip kaydı silmek istediğnize emin misiniz? ", "Rent A Car", "Question").Show();
            if (dialog == DialogResult.Yes)
            {
                bool worked = mainfunction.DML(cmd_delete, delete_qry);

                if (worked)
                    Chelper.Gmessagebox($"{TC} Kimlik numarasına sahip müşteri kaydı başarıyla silindi.", "Rent A Car", "Information").Show();
            }
            ListCustomer();
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

       
    }
}
