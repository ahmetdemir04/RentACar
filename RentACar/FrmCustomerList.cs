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
    public partial class FrmCustomerList : Form
    {
        public FrmCustomerList()
        {
            InitializeComponent();
        }
        MainFunctions mainfunction = new MainFunctions();
        private void FrmCustomerList_Load(object sender, EventArgs e)
        {
            ListCustomer();
        }

        private void ListCustomer()
        {
            string qry_customer = "Select * FROM TBLMUSTERI";
            SqlDataAdapter adtr = new SqlDataAdapter();

            gridCustomer.DataSource = mainfunction.Listele(adtr, qry_customer);


            gridCustomer.Columns["AdSoyad"].HeaderText = "Ad Soyad";
            gridCustomer.Columns["Telefon"].HeaderText = "Telefon Numarası";
            gridCustomer.Columns["Eposta"].HeaderText = "E-Posta";
        }

        private void tSearch_TextChanged(object sender, EventArgs e)
        {
            string qry_customer = "Select * FROM TBLMUSTERI WHERE adsoyad LIKE '%" + tSearch.Text + "%' ";
            SqlDataAdapter adtr = new SqlDataAdapter();

            gridCustomer.Columns["AdSoyad"].HeaderText = "Ad Soyad";
            gridCustomer.Columns["Telefon"].HeaderText = "Telefon Numarası";
            gridCustomer.Columns["Eposta"].HeaderText = "E-Posta";
          

            gridCustomer.DataSource = mainfunction.Listele(adtr, qry_customer);
        }

        private void gridCustomer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = gridCustomer.CurrentRow;

            tTC.Text = satir.Cells["TC"].Value.ToString();
            tAdSoyad.Text = satir.Cells["AdSoyad"].Value.ToString();
            tEposta.Text = satir.Cells["Eposta"].Value.ToString();
            tTelefon.Text = satir.Cells["Telefon"].Value.ToString();
            tAdres.Text = satir.Cells["Adres"].Value.ToString();
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {

            string tc = tTC.Text;
            if (!string.IsNullOrEmpty(tc))
            {
                string qry_update_customer = "UPDATE TblMusteri SET adsoyad = @adsoyad, Telefon =@telefon, adres=@adres, eposta=@eposta WHERE tc =@tc";
                SqlCommand cmd_update_customer = new SqlCommand();
                cmd_update_customer.Parameters.AddWithValue("@tc", tc);
                cmd_update_customer.Parameters.AddWithValue("@adsoyad", tAdSoyad.Text);
                cmd_update_customer.Parameters.AddWithValue("@telefon", tTelefon.Text);
                cmd_update_customer.Parameters.AddWithValue("@eposta", tEposta.Text.Trim());
                cmd_update_customer.Parameters.AddWithValue("@adres", tAdres.Text.Trim());
                mainfunction.DML(cmd_update_customer, qry_update_customer);
                ListCustomer();
                guna2MessageDialog1.Show($"{tc} Numarasına sahip kişinin güncelleme işlemi başarılı!", "RentACar");
                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("Güncellemek istediğiniz veriyi lütfen listeden seçiniz!", "RentACar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void bSave_Click(object sender, EventArgs e)
        {

        }

        private void guna2ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
         
            
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string TC = gridCustomer.CurrentRow.Cells["TC"].Value.ToString();
            string delete_qry = "DELETE FROM TblMusteri WHERE TC = @tc";
            SqlCommand cmd_delete = new SqlCommand();
            cmd_delete.Parameters.AddWithValue("@tc", TC);

            DialogResult dialog = MessageBox.Show($"{TC} Kimlik numarasına sahip kaydı silmek istediğnize emin misiniz? ", "RentACar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                mainfunction.DML(cmd_delete, delete_qry);
                guna2MessageDialog1.Show($"{TC} Numarasına sahip kişinin silme işlemi başarılı!", "RentACar");
            }
            ListCustomer();
        }
    }
}
