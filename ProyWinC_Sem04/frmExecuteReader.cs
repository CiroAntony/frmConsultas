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
// Agregar...
using System.Data.SqlClient;

namespace ProyWinC_Sem04
{
    public partial class frmExecuteReader : Form
    {
        //Declaramos intancias
        SqlConnection cnx = new SqlConnection("server=VASQUEZ;Database=VentasLeon;Integrated Security=true");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;
        public frmExecuteReader()
        {
            InitializeComponent();
        }

        private void btnListarProductos_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.Connection = cnx;
                cmd.CommandText = "usp_ListarProducto";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                // Abrimos y ejecutamos
                cnx.Open();
                dtr = cmd.ExecuteReader();

                // Volvamos el resultado al lstProductos
                lstProductos.Items.Clear();
                while (dtr.Read())
                {
                    lstProductos.Items.Add(dtr["des_pro"].ToString());
                }
                dtr.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
;            }
            finally
            {

                // Finalmente si la conexion esta abierta se cierra...
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }

        private void btnListarProveedores_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.Connection = cnx;
                cmd.CommandText = "usp_ListarProveedor";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                // Abrimos y ejecutamos
                cnx.Open();
                dtr = cmd.ExecuteReader();

                // Volvamos el resultado al lstProducto
                lstProveedores.Items.Clear();
                while (dtr.Read())
                {
                    lstProveedores.Items.Add(dtr["raz_soc_prv"].ToString()+"-" + dtr["rep_ven"].ToString());
                }
                dtr.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
;
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
