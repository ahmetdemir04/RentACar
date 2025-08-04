using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    public class ClsControlHelper
    {

        public void OnlyNumeric (object sender, KeyPressEventArgs e)
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
                    message.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                    message.Buttons = MessageDialogButtons.OK;
                    break;
                case "Warning":
                    message.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
                    message.Buttons = MessageDialogButtons.OK;
                    break;
                case "Information":
                    message.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                    message.Buttons = MessageDialogButtons.OK;
                    break;
                case "Question":
                    message.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
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
                    }
                }
            }
        }

    }

    
}
