using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Agregar...
using System.Data.SqlClient;

namespace ProyWinC_Sem04
{
    public partial class frmExecuteScalar : Form
    {
        //Declaramos intancias
        SqlConnection cnx = new SqlConnection("server=VASQUEZ;Database=VentasLeon;Integrated Security=true");
        SqlCommand cmd = new SqlCommand();
        public frmExecuteScalar()
        {
            InitializeComponent();
        }

        private void btnObtenerMaximoPrecio_Click(object sender, EventArgs e)
        {
            try
            {
                // Preparamos al comando...
                cmd.Connection = cnx;
                cmd.CommandText = "usp_MaximoPrecioProducto";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();

                // Abrir conexion y ejecutar
                cnx.Open();
                MessageBox.Show("El maximo precio de producto es... " + cmd.ExecuteScalar().ToString(),"Resultado");

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");

            }
            finally
            {

                // Finalmente si la conexion esta abierta se cierra...
                if(cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }

        private void btnObtenerVentasAño_Click(object sender, EventArgs e)
        {
            try
            {
                // Preparamos al comando...
                cmd.Connection = cnx;
                cmd.CommandText = "usp_VentaAnual";
                cmd.CommandType = CommandType.StoredProcedure;

                // Manejamos el parametro
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@año",Convert.ToInt16(mskAño.Text));
                // Abrir y ejecutar
                cnx.Open();
                MessageBox.Show("El total de ventas en el año " + mskAño.Text + " es... " + cmd.ExecuteScalar().ToString(), " Resultado");

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");

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
