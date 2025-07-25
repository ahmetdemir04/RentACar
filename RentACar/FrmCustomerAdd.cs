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
    public partial class FrmCustomerAdd : Form
    {
        public FrmCustomerAdd()
        {
            InitializeComponent();
        }
        MainFunctions mainFunctions = new MainFunctions();
        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            string qry_add = "INSERT INTO TblMusteri (TC, Adsoyad, Telefon, Adres, Eposta) VALUES (@tc, @adsoyad, @telefon, @adres, @email)";
            SqlCommand cmdAdd = new SqlCommand();
            cmdAdd.Parameters.AddWithValue("@tc", tTC.Text);
            cmdAdd.Parameters.AddWithValue("@adsoyad", tAdSoyad.Text);
            cmdAdd.Parameters.AddWithValue("@telefon", tTelefon.Text);
            cmdAdd.Parameters.AddWithValue("@email", tEposta.Text.Trim());
            cmdAdd.Parameters.AddWithValue("@adres", tAdres.Text.Trim());

            mainFunctions.DML(cmdAdd, qry_add);
            guna2MessageDialog1.Show("Kayıt başarıyla gerçekleştirildi!", "RentACar");

            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
  
        }
    }
}
