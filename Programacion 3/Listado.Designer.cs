namespace Programacion_3
{
    partial class frmListado
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblCatagolo = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lbxArticulos = new System.Windows.Forms.ListBox();
            this.pbxLista = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLista)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(72, 279);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(156, 23);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar artículo";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // lblCatagolo
            // 
            this.lblCatagolo.AutoSize = true;
            this.lblCatagolo.BackColor = System.Drawing.Color.Transparent;
            this.lblCatagolo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatagolo.Location = new System.Drawing.Point(64, 50);
            this.lblCatagolo.Name = "lblCatagolo";
            this.lblCatagolo.Size = new System.Drawing.Size(343, 39);
            this.lblCatagolo.TabIndex = 3;
            this.lblCatagolo.Text = "Listado de artículos";
            this.lblCatagolo.Click += new System.EventHandler(this.lblCatagolo_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(477, 345);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Volver";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lbxArticulos
            // 
            this.lbxArticulos.FormattingEnabled = true;
            this.lbxArticulos.ItemHeight = 16;
            this.lbxArticulos.Items.AddRange(new object[] {
            "Remera",
            "Zapatillas"});
            this.lbxArticulos.Location = new System.Drawing.Point(71, 116);
            this.lbxArticulos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbxArticulos.Name = "lbxArticulos";
            this.lbxArticulos.Size = new System.Drawing.Size(314, 132);
            this.lbxArticulos.TabIndex = 5;
            this.lbxArticulos.SelectedIndexChanged += new System.EventHandler(this.lbxArticulos_SelectedIndexChanged);
            // 
            // pbxLista
            // 
            this.pbxLista.Location = new System.Drawing.Point(391, 118);
            this.pbxLista.Name = "pbxLista";
            this.pbxLista.Size = new System.Drawing.Size(160, 130);
            this.pbxLista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLista.TabIndex = 6;
            this.pbxLista.TabStop = false;
            // 
            // frmListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 382);
            this.Controls.Add(this.pbxLista);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lbxArticulos);
            this.Controls.Add(this.lblCatagolo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmListado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblCatagolo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ListBox lbxArticulos;
        private System.Windows.Forms.PictureBox pbxLista;
    }
}