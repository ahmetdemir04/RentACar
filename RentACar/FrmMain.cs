using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


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

        private void CenterAligmentLbl()
        {
            lArabaSayisi.Dock = DockStyle.Fill;
            lArabaSayisi.TextAlign = ContentAlignment.MiddleCenter;

            lMusteriSayisi.Dock = DockStyle.Fill;
            lMusteriSayisi.TextAlign = ContentAlignment.MiddleCenter;

            lSozlesme.Dock = DockStyle.Fill;
            lSozlesme.TextAlign = ContentAlignment.MiddleCenter;


            lBitmisSozelesme.Dock = DockStyle.Fill;
            lBitmisSozelesme.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            CenterAligmentLbl();
            

            List<string> dashboardData = new List<string>();
            dashboardData = main.Dashboard();


            lArabaSayisi.Text = dashboardData[0];
            lMusteriSayisi.Text = dashboardData[1];
            lSozlesme.Text = dashboardData[2];
            lBitmisSozelesme.Text = dashboardData[3];


            string last5monthsRevenue = "Exec GetLastFiveMonthsRevenue";
            SqlDataAdapter adp = new SqlDataAdapter();
            DataTable dt = new DataTable();


             dt = main.Listele(adp, last5monthsRevenue); // Senin DataTable

            var series = new LiveCharts.Wpf.LineSeries
            {
                Values = new LiveCharts.ChartValues<double>()
            };

            // X ekseni etiketleri
            cartesianChart1.AxisX.Clear();
            cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Labels = dt.AsEnumerable()
                           .Where(r => r[2] != DBNull.Value)
                           .Select(r => r[2].ToString())
                           .ToArray()
            });

            // SeriesCollection'i tam isimle oluştur
            cartesianChart1.Series = new LiveCharts.SeriesCollection { series };

            // Y değerlerini ekle
            foreach (DataRow row in dt.Rows)
            {
                if (row[3] != DBNull.Value)
                {
                    double y = Convert.ToDouble(row[3]);
                    series.Values.Add(y);
                }
            }

        }
    }
}
