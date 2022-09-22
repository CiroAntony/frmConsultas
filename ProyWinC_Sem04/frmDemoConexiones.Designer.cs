namespace ProyWinC_Sem04
{
    partial class frmDemoConexiones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpConexiones = new System.Windows.Forms.GroupBox();
            this.btnCerrarConexion = new System.Windows.Forms.Button();
            this.btnAbrirConexion = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grpConexiones.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpConexiones
            // 
            this.grpConexiones.Controls.Add(this.btnCerrarConexion);
            this.grpConexiones.Controls.Add(this.btnAbrirConexion);
            this.grpConexiones.Location = new System.Drawing.Point(178, 120);
            this.grpConexiones.Name = "grpConexiones";
            this.grpConexiones.Size = new System.Drawing.Size(478, 205);
            this.grpConexiones.TabIndex = 0;
            this.grpConexiones.TabStop = false;
            this.grpConexiones.Text = "Manejo de conexiones";
            // 
            // btnCerrarConexion
            // 
            this.btnCerrarConexion.Enabled = false;
            this.btnCerrarConexion.Image = global::ProyWinC_Sem04.Properties.Resources.Cancelar;
            this.btnCerrarConexion.Location = new System.Drawing.Point(260, 79);
            this.btnCerrarConexion.Name = "btnCerrarConexion";
            this.btnCerrarConexion.Size = new System.Drawing.Size(115, 44);
            this.btnCerrarConexion.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnCerrarConexion, "Cierra la conexion a VentasLeon");
            this.btnCerrarConexion.UseVisualStyleBackColor = true;
            this.btnCerrarConexion.Click += new System.EventHandler(this.btnCerrarConexion_Click);
            // 
            // btnAbrirConexion
            // 
            this.btnAbrirConexion.Image = global::ProyWinC_Sem04.Properties.Resources.Aceptar;
            this.btnAbrirConexion.Location = new System.Drawing.Point(75, 79);
            this.btnAbrirConexion.Name = "btnAbrirConexion";
            this.btnAbrirConexion.Size = new System.Drawing.Size(115, 44);
            this.btnAbrirConexion.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnAbrirConexion, "Abre la conexion a VentasLeon");
            this.btnAbrirConexion.UseVisualStyleBackColor = true;
            this.btnAbrirConexion.Click += new System.EventHandler(this.btnAbrirConexion_Click);
            // 
            // frmDemoConexiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpConexiones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDemoConexiones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo Conexiones a Sql Server";
            this.grpConexiones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpConexiones;
        private Button btnCerrarConexion;
        private Button btnAbrirConexion;
        private ToolTip toolTip1;
    }
}