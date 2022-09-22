using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;// Para las clases de acceso a SQL Server
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyWinC_Sem04
{
    public partial class frmConsultaProveedor : Form
    {
       
        public frmConsultaProveedor()
        {
            InitializeComponent();
        }


        //Declaramos las instancias
        SqlConnection cnx = new SqlConnection("server=VASQUEZ;Database=VentasLeon;Integrated Security=true");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;
        private void txtcod_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Codifique usp_ConsultarProveedor
            try
            {
                if (e.KeyChar == 13)
                {
                    cmd.Connection = cnx;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "usp_ConsultarProveedor";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@vcod", txtcod.Text.Trim());;

                    cnx.Open();
                    dtr = cmd.ExecuteReader();

                    if (dtr.HasRows == true)
                    {
                        dtr.Read();
                        lblRaz.Text = dtr["raz_soc_prv"].ToString();
                        lblDir.Text = dtr["dir_prv"].ToString();
                        lblDepartamento.Text = dtr["Departamento"].ToString();
                        lblProvincia.Text = dtr["Provincia"].ToString();
                        lblDistrito.Text = dtr["Distrito"].ToString();
                        lblTel.Text = dtr["Tel_prv"].ToString();
                        lblRepVen.Text = dtr["Rep_ven"].ToString();
                    }


                    else
                    {
                        lblRaz.Text = "";
                        lblDir.Text = "";
                        lblDepartamento.Text = "";
                        lblProvincia.Text = "";
                        lblDistrito.Text = "";
                        lblTel.Text = "";
                        lblRepVen.Text = "";
                        throw new Exception("No existe cliente con el codigo ingresado.");
                    }

                    dtr.Close();
                }

            }

            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);

            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }


            }

            try
            {
                if (e.KeyChar == 13)
                {
                    cmd.Connection = cnx;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "usp_ConsultarProductosProveedor";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@cod_prv", txtcod.Text.Trim()); ;

                    cnx.Open();
                    dtr = cmd.ExecuteReader();

                    lstProductos.Items.Clear();
                    while (dtr.Read())
                    {
                        lstProductos.Items.Add(dtr["des_pro"].ToString() + " - " + dtr["pre_aba"].ToString());
                    }

                    dtr.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);

            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }


            }
        }
        
    }
}
