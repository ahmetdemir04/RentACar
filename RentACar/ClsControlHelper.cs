using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    public class ClsControlHelper
    {
        CultureInfo tr = new CultureInfo("tr-TR");

        public void OnlyNumeric(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void OnlyAlphabetic(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public Guna2MessageDialog Gmessagebox(string content, string context, string icon)
        {
            Guna2MessageDialog message = new Guna2MessageDialog();

            switch (icon)
            {
                case "Error":
                    message.Icon = MessageDialogIcon.Error;
                    message.Buttons = MessageDialogButtons.OK;
                    break;
                case "Warning":
                    message.Icon = MessageDialogIcon.Warning;
                    message.Buttons = MessageDialogButtons.OK;
                    break;
                case "Information":
                    message.Icon = MessageDialogIcon.Information;
                    message.Buttons = MessageDialogButtons.OK;
                    break;
                case "Question":
                    message.Icon = MessageDialogIcon.Question;
                    message.Buttons = MessageDialogButtons.YesNo;
                    break;
            }

            message.Caption = context;
            message.Text = content;
            message.Parent = Application.OpenForms[0];

            return message;
        }

        public void ClearFields(Control control)
        {
            foreach (Control item in control.Controls)
            {
                if (item is Guna2TextBox || item is Guna2ComboBox)
                {
                    item.Text = "";
                }
            }
        }

        public void DatagridFormatter(DataGridView dgv)
        {
            if (dgv.Columns.Count > 0)
            {
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    switch (dgv.Columns[i].HeaderText)
                    {
                        case "Email": dgv.Columns[i].HeaderText = "E-Mail"; break;
                        case "LisansNumarasi": dgv.Columns[i].HeaderText = "Lisans Numarası"; break;
                        case "DogumTarihi":
                            dgv.Columns[i].HeaderText = "Doğum Tarihi"; break;
                        case "UrunAd":
                            dgv.Columns[i].HeaderText = "Ürün Adı"; break;
                        case "GirisTarihi":
                            dgv.Columns[i].HeaderText = "Giriş Tarihi"; break;
                        case "YakitTipi":
                            dgv.Columns[i].HeaderText = "Yakıt Tipi"; break;
                        case "GunlukUcret":
                            dgv.Columns[i].HeaderText = "Günlük Ücret";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dgv.Columns[i].DefaultCellStyle.Format = "C2"; break;
                        case "Resim":
                            dgv.Columns[i].Visible = false; break;
                        case "Aktif": 
                            dgv.Columns[i].Visible = false; break;
                        case "Km":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dgv.Columns[i].DefaultCellStyle.Format = "N0"; break; //
                        case "BaslangicTarihi":
                            dgv.Columns[i].HeaderText = "Başlangıc Tarihi";
                            dgv.Columns["BaslangicTarihi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;break;
                        case "BitisTarihi":
                            dgv.Columns[i].HeaderText = "Bitiş Tarihi"; break;
                        case "TotalPrice":
                            dgv.Columns[i].HeaderText = "Toplam Ücret";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dgv.Columns[i].DefaultCellStyle.Format = "C2"; break;
                        case "OdemeDurumu":
                            dgv.Columns[i].HeaderText = "Ödeme Durumu"; break;
                        case "GeriDonusDurumu":
                            dgv.Columns[i].HeaderText = "Geri Dönüş Durumu";
                            dgv.Columns["GeriDonusDurumu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; break;
                        case "ArabaID":
                            dgv.Columns[i].Visible = false; break;
                        case "Tutar":
                            dgv.Columns[i].HeaderText = "Toplam Ücret";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dgv.Columns["Tutar"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                            dgv.Columns[i].DefaultCellStyle.Format = "C2"; break;
                        case "OdemeTarihi":
                            dgv.Columns[i].HeaderText = "Ödeme Tarihi";
                            dgv.Columns["OdemeTarihi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; break;
                        case "OdemeYontemi":
                            dgv.Columns[i].HeaderText = "Ödeme Yöntemi";
                            dgv.Columns["OdemeYontemi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; break;
                        case "OdemeID":
                            dgv.Columns[i].HeaderText = "ID";
                            dgv.Columns["OdemeID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; break;
                        case "Plaka":
                            dgv.Columns["Plaka"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; break;
                        case "KiraID":
                            dgv.Columns["KiraID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; break;
                    }
                }
            }
        }
        public void MakeIt0(EventArgs e)
        {

        }
        public double MakeDouble(string value )
        {
            try
            {
                if (double.TryParse(value, NumberStyles.Any, tr, out double processed))
                {
                    return processed;
                }
            }
            catch (FormatException)
            {
                throw new FormatException("Geçersiz sayı formatı: " + value);
            }
            catch (Exception ex)
            {
                throw new Exception("Hata oluştu: " + ex.Message);
            }
            throw new Exception("Bilinmeyen bir hata oluştu.");
        }

    }


}
