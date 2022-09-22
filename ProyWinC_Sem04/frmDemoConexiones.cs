using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Agregar...
using System.Data.SqlClient;

namespace ProyWinC_Sem04
{
    public partial class frmDemoConexiones : Form
    {

        //Creamos una instancia de conexion a SQLServer
        SqlConnection cnx = new SqlConnection("server=VASQUEZ;Database=VentasLeon;Integrated Security=true");
        public frmDemoConexiones()
        {
            InitializeComponent();
        }

        private void btnAbrirConexion_Click(object sender, EventArgs e)
        {
            try
            {
                cnx.Open();
                MessageBox.Show("Conexion abierta a VentasLeon!!!!","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);
                btnAbrirConexion.Enabled = false;
                btnCerrarConexion.Enabled = true;
            }
            catch (SqlException ex1)
            {
                MessageBox.Show("Error: " + ex1.Message, "Error");
            }
            catch (Exception ex2)
            {
                MessageBox.Show("Error: " + ex2.Message, "Error");
            }
        }

        private void btnCerrarConexion_Click(object sender, EventArgs e)
        {
            cnx.Close();
            MessageBox.Show("Conexion cerrada a VentasLeon!!!!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            btnAbrirConexion.Enabled = true;
            btnCerrarConexion.Enabled = false;
        }
    }
}
