using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    public class MainFunctions
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-K9SJG04\SQLEXPRESS;Initial Catalog=RentACar;Integrated Security=True");
        DataTable table;
        public string DefaultCarPicture = Path.Combine(Application.StartupPath, @"default_car.png");
        public void DML (SqlCommand cmd, string qry)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                cmd.Connection = connection;
                cmd.CommandText = qry;
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally { connection.Close(); }
         
        }
        public DataTable Listele(SqlDataAdapter adtr, string qry)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                table = new DataTable();
                adtr = new SqlDataAdapter(qry, connection);
                adtr.Fill(table);
                connection.Close();
                return table;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            return null;
            }
         
        }

        public void Bos_Araclar(ComboBox _cmb, string _qry)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                SqlCommand cmd = new SqlCommand(_qry,connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    _cmb.Items.Add(reader["Plaka"].ToString());
                }

                
            }
            catch (Exception)
            {
                throw;
            }
            finally { connection.Close(); }
        }
        public void TC_ara(Guna2TextBox _txtTC, Guna2TextBox _txtAdsoyad, Guna2TextBox _txtTelefon, string _qry)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                SqlCommand cmd = new SqlCommand(_qry, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    _txtAdsoyad.Text = reader["adsoyad"].ToString();
                    _txtTelefon.Text = reader["telefon"].ToString();
                }


            }
            catch (Exception)
            {
                throw;
            }
            finally { connection.Close(); }
        }

        public void CombodanGetir(Guna2ComboBox _araclar, Guna2TextBox _marka, Guna2TextBox _seri, Guna2TextBox _model, Guna2TextBox _renk, string _qry)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                SqlCommand cmd = new SqlCommand(_qry, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    _marka.Text = reader["marka"].ToString();
                    _seri.Text = reader["seri"].ToString();
                    _model.Text = reader["yil"].ToString();
                    _renk.Text = reader["renk"].ToString();
                }


            }
            catch (Exception)
            {
                throw;
            }
            finally { connection.Close(); }
        }

        public void Ucret_Hesapla(Guna2ComboBox _kirasekli, Guna2TextBox ucret,  string _qry)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                SqlCommand cmd = new SqlCommand(_qry, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (_kirasekli.SelectedIndex == 0) ucret.Text = (int.Parse(reader["kiraucreti"].ToString()) * 1).ToString();
                    if (_kirasekli.SelectedIndex == 1) ucret.Text = (int.Parse(reader["kiraucreti"].ToString()) * 0.80).ToString();
                    if (_kirasekli.SelectedIndex == 2) ucret.Text = (int.Parse(reader["kiraucreti"].ToString()) * 0.70).ToString();

                }


            }
            catch (Exception)
            {
                throw;
            }
            finally { connection.Close(); }
        }
    }
}
