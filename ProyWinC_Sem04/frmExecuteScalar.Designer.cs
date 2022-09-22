namespace ProyWinC_Sem04
{
    partial class frmExecuteScalar
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
            this.btnObtenerMaximoPrecio = new System.Windows.Forms.Button();
            this.mskAño = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnObtenerVentasAño = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnObtenerMaximoPrecio
            // 
            this.btnObtenerMaximoPrecio.Location = new System.Drawing.Point(123, 67);
            this.btnObtenerMaximoPrecio.Name = "btnObtenerMaximoPrecio";
            this.btnObtenerMaximoPrecio.Size = new System.Drawing.Size(196, 40);
            this.btnObtenerMaximoPrecio.TabIndex = 0;
            this.btnObtenerMaximoPrecio.Text = "Maximo precio producto";
            this.btnObtenerMaximoPrecio.UseVisualStyleBackColor = true;
            this.btnObtenerMaximoPrecio.Click += new System.EventHandler(this.btnObtenerMaximoPrecio_Click);
            // 
            // mskAño
            // 
            this.mskAño.Location = new System.Drawing.Point(298, 160);
            this.mskAño.Mask = "9999";
            this.mskAño.Name = "mskAño";
            this.mskAño.Size = new System.Drawing.Size(125, 27);
            this.mskAño.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Año: ";
            // 
            // btnObtenerVentasAño
            // 
            this.btnObtenerVentasAño.Location = new System.Drawing.Point(222, 232);
            this.btnObtenerVentasAño.Name = "btnObtenerVentasAño";
            this.btnObtenerVentasAño.Size = new System.Drawing.Size(120, 38);
            this.btnObtenerVentasAño.TabIndex = 3;
            this.btnObtenerVentasAño.Text = "Ventas año";
            this.btnObtenerVentasAño.UseVisualStyleBackColor = true;
            this.btnObtenerVentasAño.Click += new System.EventHandler(this.btnObtenerVentasAño_Click);
            // 
            // frmExecuteScalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnObtenerVentasAño);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mskAño);
            this.Controls.Add(this.btnObtenerMaximoPrecio);
            this.Name = "frmExecuteScalar";
            this.Text = "Demo ExecuteScalar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnObtenerMaximoPrecio;
        private MaskedTextBox mskAño;
        private Label label1;
        private Button btnObtenerVentasAño;
    }
}