using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyWinC_Sem04
{
    public partial class frmConsultaCliente : Form
    {
       
        public frmConsultaCliente()
        {
            InitializeComponent();
        }
        //Declaramos las instancias
        SqlConnection cnx = new SqlConnection(@"server=VASQUEZ;Database=VentasLeon;Integrated Security=true");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        private void txtcod_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Codifique

            try
            {
                if (e.KeyChar == 13)
                // Si pulsamos Enter
                {
                    cmd.Connection = cnx;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "usp_ConsultarCliente";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@vcod", txtcod.Text.Trim());

                    cnx.Open();
                    dtr = cmd.ExecuteReader();

                    // Tiene filas el dtr??
                    if (dtr.HasRows == true)
                    {
                        dtr.Read();
                        lblRaz.Text = dtr["raz_soc_cli"].ToString();
                        lblDir.Text = dtr["dir_cli"].ToString();
                        lblTel.Text = dtr["tel_cli"].ToString();
                        lblRuc.Text = dtr["ruc_cli"].ToString();
                        lblDeuda.Text = Convert.ToSingle(dtr["deuda"]).ToString("###,###.00 soles");
                    }
                    else 
                    { 
                        lblRaz.Text = ""; 
                        lblDir.Text = ""; 
                        lblTel.Text = ""; 
                        lblRuc.Text = ""; 
                        lblDeuda.Text = ""; 
                        throw new Exception("No existe cliente con el codigo ingresado."); 
                    }
                    dtr.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
            catch (Exception ex2)
            {
                MessageBox.Show("Error: " + ex2.Message, "Error");
            }
            finally
            {

                // Finalmente si la conexion esta abierta se cierra...
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }

        }
    }
}
