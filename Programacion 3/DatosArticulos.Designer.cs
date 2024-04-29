namespace Programacion_3
{
    partial class frmArticulos
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtImagen = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblImagen = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCodArt = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombreArt = new System.Windows.Forms.Label();
            this.lblModificar = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.lblCampos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(216, 248);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(71, 26);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(107, 100);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(180, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(107, 124);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(180, 20);
            this.txtDescripcion.TabIndex = 2;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(107, 198);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(180, 20);
            this.txtPrecio.TabIndex = 5;
            // 
            // txtImagen
            // 
            this.txtImagen.Location = new System.Drawing.Point(107, 222);
            this.txtImagen.Margin = new System.Windows.Forms.Padding(2);
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.Size = new System.Drawing.Size(180, 20);
            this.txtImagen.TabIndex = 6;
            this.txtImagen.Leave += new System.EventHandler(this.txtImagen_Leave_1);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(107, 76);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(180, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.BackColor = System.Drawing.Color.Transparent;
            this.lblImagen.Location = new System.Drawing.Point(15, 225);
            this.lblImagen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(87, 13);
            this.lblImagen.TabIndex = 23;
            this.lblImagen.Text = "Imagen principal:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.BackColor = System.Drawing.Color.Transparent;
            this.lblMarca.Location = new System.Drawing.Point(15, 151);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(47, 13);
            this.lblMarca.TabIndex = 22;
            this.lblMarca.Text = "Marca: *";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoria.Location = new System.Drawing.Point(15, 176);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(64, 13);
            this.lblCategoria.TabIndex = 21;
            this.lblCategoria.Text = "Categoría: *";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecio.Location = new System.Drawing.Point(15, 201);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(47, 13);
            this.lblPrecio.TabIndex = 20;
            this.lblPrecio.Text = "Precio: *";
            // 
            // lblCodArt
            // 
            this.lblCodArt.AutoSize = true;
            this.lblCodArt.BackColor = System.Drawing.Color.Transparent;
            this.lblCodArt.Location = new System.Drawing.Point(15, 103);
            this.lblCodArt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodArt.Name = "lblCodArt";
            this.lblCodArt.Size = new System.Drawing.Size(50, 13);
            this.lblCodArt.TabIndex = 19;
            this.lblCodArt.Text = "Código: *";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcion.Location = new System.Drawing.Point(15, 127);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 18;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblNombreArt
            // 
            this.lblNombreArt.AutoSize = true;
            this.lblNombreArt.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreArt.Location = new System.Drawing.Point(15, 79);
            this.lblNombreArt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreArt.Name = "lblNombreArt";
            this.lblNombreArt.Size = new System.Drawing.Size(54, 13);
            this.lblNombreArt.TabIndex = 17;
            this.lblNombreArt.Text = "Nombre: *";
            // 
            // lblModificar
            // 
            this.lblModificar.AutoSize = true;
            this.lblModificar.BackColor = System.Drawing.Color.Transparent;
            this.lblModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblModificar.Location = new System.Drawing.Point(11, 27);
            this.lblModificar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModificar.Name = "lblModificar";
            this.lblModificar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblModificar.Size = new System.Drawing.Size(184, 31);
            this.lblModificar.TabIndex = 16;
            this.lblModificar.Text = "Datos Artículo";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(358, 265);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(56, 34);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Volver";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(107, 173);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(180, 21);
            this.cboCategoria.TabIndex = 4;
            // 
            // cboMarca
            // 
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(107, 148);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(180, 21);
            this.cboMarca.TabIndex = 3;
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Location = new System.Drawing.Point(293, 90);
            this.pbxArticulo.Margin = new System.Windows.Forms.Padding(2);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(121, 123);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 35;
            this.pbxArticulo.TabStop = false;
            // 
            // lblCampos
            // 
            this.lblCampos.AutoSize = true;
            this.lblCampos.BackColor = System.Drawing.Color.Transparent;
            this.lblCampos.ForeColor = System.Drawing.Color.Red;
            this.lblCampos.Location = new System.Drawing.Point(20, 276);
            this.lblCampos.Name = "lblCampos";
            this.lblCampos.Size = new System.Drawing.Size(108, 13);
            this.lblCampos.TabIndex = 36;
            this.lblCampos.Text = "* Campos obligatorios";
            // 
            // frmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 310);
            this.Controls.Add(this.lblCampos);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtImagen);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblCodArt);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombreArt);
            this.Controls.Add(this.lblModificar);
            this.Name = "frmArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Artículos";
            this.Load += new System.EventHandler(this.frmModificar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtImagen;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCodArt;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombreArt;
        private System.Windows.Forms.Label lblModificar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.Label lblCampos;
    }
}