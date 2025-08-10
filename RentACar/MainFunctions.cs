using Guna.UI2.AnimatorNS;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;

namespace RentACar
{
    public class MainFunctions
    {
        ClsConnection con = new ClsConnection();
        DataTable table;
        public string DefaultCarPicture = Path.Combine(Application.StartupPath, @"default_car.png");

        public bool DML(SqlCommand cmd, string qry)
        {
            try
            {
                cmd.Connection = con.Connection();
                cmd.CommandText = qry;
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
            finally { con.Connection().Close(); }

        }
        public DataTable Listele(SqlDataAdapter adtr, string qry)
        {
            try
            {
                con.Connection();

                table = new DataTable();
                adtr = new SqlDataAdapter(qry, con.StrConnection);
                adtr.Fill(table);
                return table;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                return null;
            }

            finally { con.Connection().Close(); }
        }
        public void BringMarka(Guna2ComboBox Cmb)
        {
            try
            {
                DataTable BrgDt = new DataTable();

                con.Connection();
                SqlConnection connection = new SqlConnection(con.StrConnection);
                SqlDataAdapter AllCategories = new SqlDataAdapter("SELECT * FROM TblMarka", connection);
                AllCategories.Fill(BrgDt);

                Cmb.DataSource = BrgDt;
                Cmb.ValueMember = "MarkaID";
                Cmb.DisplayMember = "Marka";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void BringModel(Guna2ComboBox Cmb, int marka)
        {
            try
            {
                DataTable BrgMD = new DataTable();

                con.Connection();
                SqlConnection connection = new SqlConnection(con.StrConnection);
                SqlDataAdapter AllCategories = new SqlDataAdapter("SELECT * FROM TblModel WHERE marka = '" + marka + "'", connection);

                AllCategories.Fill(BrgMD);

                Cmb.ValueMember = "ModelID";
                Cmb.DisplayMember = "Model";
                Cmb.DataSource = BrgMD;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        public bool IsThereAny(SqlCommand _cmd, string _query, string _searchedValue)
        {
            try
            {
                _cmd.CommandText = _query;
                _cmd.Connection = con.Connection();

                SqlDataReader dr = _cmd.ExecuteReader();


                while (dr.Read())
                {
                    if (dr.Read().ToString() == _searchedValue)
                        return false;
                }
            
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        public void Bos_Araclar(ComboBox _cmb, string _qry)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(_qry, con.Connection());
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
            finally { con.Connection().Close(); }
        }
        public void TC_ara(Guna2TextBox _txtTC, Guna2TextBox _txtAdsoyad, Guna2TextBox _txtTelefon, string _qry)
        {
            try
            {
                con.Connection();
                SqlConnection connection = new SqlConnection(con.StrConnection);

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
            finally { con.Connection().Close(); }
        }

        public void CombodanGetir(Guna2ComboBox _araclar, Guna2TextBox _marka, Guna2TextBox _seri, Guna2TextBox _model, Guna2TextBox _renk, string _qry)
        {
            try
            {
                con.Connection();
                SqlConnection connection = new SqlConnection(con.StrConnection);

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
            finally { con.Connection().Close(); }
        }

        public void Ucret_Hesapla(Guna2ComboBox _kirasekli, Guna2TextBox ucret, string _qry)
        {
            try
            {
                con.Connection();
                SqlConnection connection = new SqlConnection(con.StrConnection);

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
            finally { con.Connection().Close(); }
        }

        public void SatisHesapla(Label lbl)
        {
            con.Connection();
            SqlConnection connection = new SqlConnection(con.StrConnection);

            SqlCommand command = new SqlCommand("SELECT SUM(tutar) FROM TblSatis", connection);
            lbl.Text = "Toplam Tutar= " + command.ExecuteScalar().ToString() + " TL";
            connection.Close();
        }
    }
}
