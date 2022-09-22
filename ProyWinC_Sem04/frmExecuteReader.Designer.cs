namespace ProyWinC_Sem04
{
    partial class frmExecuteReader
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
            this.btnListarProductos = new System.Windows.Forms.Button();
            this.lstProductos = new System.Windows.Forms.ListBox();
            this.btnListarProveedores = new System.Windows.Forms.Button();
            this.lstProveedores = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnListarProductos
            // 
            this.btnListarProductos.Location = new System.Drawing.Point(119, 73);
            this.btnListarProductos.Name = "btnListarProductos";
            this.btnListarProductos.Size = new System.Drawing.Size(146, 49);
            this.btnListarProductos.TabIndex = 0;
            this.btnListarProductos.Text = "Listar Productos";
            this.btnListarProductos.UseVisualStyleBackColor = true;
            this.btnListarProductos.Click += new System.EventHandler(this.btnListarProductos_Click);
            // 
            // lstProductos
            // 
            this.lstProductos.FormattingEnabled = true;
            this.lstProductos.ItemHeight = 20;
            this.lstProductos.Location = new System.Drawing.Point(377, 73);
            this.lstProductos.Name = "lstProductos";
            this.lstProductos.Size = new System.Drawing.Size(411, 124);
            this.lstProductos.TabIndex = 1;
            // 
            // btnListarProveedores
            // 
            this.btnListarProveedores.Location = new System.Drawing.Point(119, 253);
            this.btnListarProveedores.Name = "btnListarProveedores";
            this.btnListarProveedores.Size = new System.Drawing.Size(146, 49);
            this.btnListarProveedores.TabIndex = 0;
            this.btnListarProveedores.Text = "Listar proveedores";
            this.btnListarProveedores.UseVisualStyleBackColor = true;
            this.btnListarProveedores.Click += new System.EventHandler(this.btnListarProveedores_Click);
            // 
            // lstProveedores
            // 
            this.lstProveedores.FormattingEnabled = true;
            this.lstProveedores.ItemHeight = 20;
            this.lstProveedores.Location = new System.Drawing.Point(377, 253);
            this.lstProveedores.Name = "lstProveedores";
            this.lstProveedores.Size = new System.Drawing.Size(411, 124);
            this.lstProveedores.TabIndex = 1;
            // 
            // frmExecuteReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstProveedores);
            this.Controls.Add(this.btnListarProveedores);
            this.Controls.Add(this.lstProductos);
            this.Controls.Add(this.btnListarProductos);
            this.Name = "frmExecuteReader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo ExecuteReader";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnListarProductos;
        private ListBox lstProductos;
        private Button btnListarProveedores;
        private ListBox lstProveedores;
    }
}