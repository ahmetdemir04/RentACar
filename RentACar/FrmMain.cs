using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        MainFunctions main = new MainFunctions();
        private void bExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bAddCustomer_Click(object sender, EventArgs e)
        {
            FrmCustomerAdd frm = new FrmCustomerAdd();
            frm.ShowDialog();
        }

        private void bListCustomer_Click(object sender, EventArgs e)
        {
            FrmCustomerList frm = new FrmCustomerList();
            frm.ShowDialog();
        }

        private void bCarRegistration_Click(object sender, EventArgs e)
        {
            FrmVehicleRegistration frm = new FrmVehicleRegistration();
            frm.ShowDialog();
        }

        private void bCarList_Click(object sender, EventArgs e)
        {
            FrmCarList frm = new FrmCarList();
            frm.ShowDialog();
        }

        private void bContract_Click(object sender, EventArgs e)
        {
            FrmContract frm = new FrmContract();
            frm.ShowDialog();
        }

        private void bSales_Click(object sender, EventArgs e)
        {
            FrmSales frm = new FrmSales();
            frm.ShowDialog();
        }

 
        private void FrmMain_Load(object sender, EventArgs e)
        {
            List<string> dashboardData = new List<string>();
            dashboardData = main.Dashboard();


            lArabaSayisi.Text = dashboardData[0];
            lMusteriSayisi.Text = dashboardData[1];
            lSozlesme.Text = dashboardData[2];
            lBitmisSozelesme.Text = dashboardData[3];
        }
    }
}
