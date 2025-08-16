using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
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
        ClsMainFunctions main = new ClsMainFunctions();
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
            FrmCarAdd frm = new FrmCarAdd();
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

        private void Charts()
        {
            try
            {


                string last5monthsRevenue = "Exec GetLastFiveMonthsRevenue";
                SqlDataAdapter adp = new SqlDataAdapter();
                DataTable dt = new DataTable();

                string Last5MonthsRevenueQty = "Exec GetLastFiveMonthsRevenueCounts";
                SqlDataAdapter adp2 = new SqlDataAdapter();


                DataTable dt2 = new DataTable();


                #region Chart1 

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
                #endregion

                #region Chart2

                dt2 = main.Listele(adp2, Last5MonthsRevenueQty); // Senin DataTable

                var series2 = new LiveCharts.Wpf.LineSeries
                {
                    Values = new LiveCharts.ChartValues<double>()
                };

                // X ekseni etiketleri
                cartesianChart2.AxisX.Clear();
                cartesianChart2.AxisX.Add(new LiveCharts.Wpf.Axis
                {
                    Labels = dt2.AsEnumerable()
                               .Where(r => r[2] != DBNull.Value)
                               .Select(r => r[2].ToString())
                               .ToArray()
                });

                // SeriesCollection'i tam isimle oluştur
                cartesianChart2.Series = new LiveCharts.SeriesCollection { series2 };

                // Y değerlerini ekle
                foreach (DataRow row in dt2.Rows)
                {
                    if (row[3] != DBNull.Value)
                    {
                        double y = Convert.ToDouble(row[3]);
                        series2.Values.Add(y);
                    }
                }

                #endregion
            }
            catch (Exception ex)
            {

                MessageBox.Show(Text = "Hata: \n" + ex.Message, "Rent A Car", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

            Charts();

        
        }
    }
}
