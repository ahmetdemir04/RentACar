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
    public partial class FrmSales : Form
    {
        public FrmSales()
        {
            InitializeComponent();
        }
        MainFunctions mainFunctions = new MainFunctions();
        private void FrmSales_Load(object sender, EventArgs e)
        {
            string query = "select * from Tblsatis";
            SqlDataAdapter adp = new SqlDataAdapter();
            gridSales.DataSource = mainFunctions.Listele(adp, query);


            mainFunctions.SatisHesapla(label10);
        }
    }
}
