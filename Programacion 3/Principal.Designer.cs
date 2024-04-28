namespace TrabajoPractico
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFiltrarArticulo = new System.Windows.Forms.Label();
            this.lblFiltrarMarca = new System.Windows.Forms.Label();
            this.txtArticulo = new System.Windows.Forms.TextBox();
            this.cboMarcas = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblFiltrarCodigo = new System.Windows.Forms.Label();
            this.lblFiltrarCategoria = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.btnAplicarFiltro = new System.Windows.Forms.Button();
            this.dgvPrincipal = new System.Windows.Forms.DataGridView();
            this.pbxPrincipal = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.marcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoríasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.imágenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnImagenAnterior = new System.Windows.Forms.Button();
            this.btnImagenSiguiente = new System.Windows.Forms.Button();
            this.lblCampo = new System.Windows.Forms.Label();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.cboFiltro = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPrincipal)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFiltrarArticulo
            // 
            this.lblFiltrarArticulo.AutoSize = true;
            this.lblFiltrarArticulo.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltrarArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrarArticulo.Location = new System.Drawing.Point(23, 70);
            this.lblFiltrarArticulo.Name = "lblFiltrarArticulo";
            this.lblFiltrarArticulo.Size = new System.Drawing.Size(105, 15);
            this.lblFiltrarArticulo.TabIndex = 2;
            this.lblFiltrarArticulo.Text = "Filtrar por artículo:";
            // 
            // lblFiltrarMarca
            // 
            this.lblFiltrarMarca.AutoSize = true;
            this.lblFiltrarMarca.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltrarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrarMarca.Location = new System.Drawing.Point(23, 181);
            this.lblFiltrarMarca.Name = "lblFiltrarMarca";
            this.lblFiltrarMarca.Size = new System.Drawing.Size(100, 15);
            this.lblFiltrarMarca.TabIndex = 3;
            this.lblFiltrarMarca.Text = "Filtrar por marca:";
            // 
            // txtArticulo
            // 
            this.txtArticulo.Location = new System.Drawing.Point(149, 68);
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.Size = new System.Drawing.Size(100, 20);
            this.txtArticulo.TabIndex = 1;
            // 
            // cboMarcas
            // 
            this.cboMarcas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarcas.FormattingEnabled = true;
            this.cboMarcas.Location = new System.Drawing.Point(149, 180);
            this.cboMarcas.Name = "cboMarcas";
            this.cboMarcas.Size = new System.Drawing.Size(100, 21);
            this.cboMarcas.TabIndex = 4;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(149, 105);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 2;
            // 
            // lblFiltrarCodigo
            // 
            this.lblFiltrarCodigo.AutoSize = true;
            this.lblFiltrarCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltrarCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrarCodigo.Location = new System.Drawing.Point(23, 107);
            this.lblFiltrarCodigo.Name = "lblFiltrarCodigo";
            this.lblFiltrarCodigo.Size = new System.Drawing.Size(102, 15);
            this.lblFiltrarCodigo.TabIndex = 6;
            this.lblFiltrarCodigo.Text = "Filtrar por código:";
            // 
            // lblFiltrarCategoria
            // 
            this.lblFiltrarCategoria.AutoSize = true;
            this.lblFiltrarCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltrarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrarCategoria.Location = new System.Drawing.Point(23, 144);
            this.lblFiltrarCategoria.Name = "lblFiltrarCategoria";
            this.lblFiltrarCategoria.Size = new System.Drawing.Size(116, 15);
            this.lblFiltrarCategoria.TabIndex = 9;
            this.lblFiltrarCategoria.Text = "Filtrar por categoría:";
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(149, 142);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(100, 21);
            this.cboCategoria.TabIndex = 3;
            this.cboCategoria.SelectedIndexChanged += new System.EventHandler(this.cboCategoria_SelectedIndexChanged);
            // 
            // btnAplicarFiltro
            // 
            this.btnAplicarFiltro.Location = new System.Drawing.Point(149, 218);
            this.btnAplicarFiltro.Name = "btnAplicarFiltro";
            this.btnAplicarFiltro.Size = new System.Drawing.Size(100, 23);
            this.btnAplicarFiltro.TabIndex = 5;
            this.btnAplicarFiltro.Text = "Aplicar filtros";
            this.btnAplicarFiltro.UseVisualStyleBackColor = true;
            // 
            // dgvPrincipal
            // 
            this.dgvPrincipal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrincipal.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPrincipal.Location = new System.Drawing.Point(270, 60);
            this.dgvPrincipal.MultiSelect = false;
            this.dgvPrincipal.Name = "dgvPrincipal";
            this.dgvPrincipal.RowHeadersWidth = 51;
            this.dgvPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrincipal.Size = new System.Drawing.Size(694, 227);
            this.dgvPrincipal.TabIndex = 12;
            this.dgvPrincipal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrincipal_CellContentClick);
            this.dgvPrincipal.SelectionChanged += new System.EventHandler(this.dgvPrincipal_SelectionChanged);
            // 
            // pbxPrincipal
            // 
            this.pbxPrincipal.Location = new System.Drawing.Point(991, 60);
            this.pbxPrincipal.Name = "pbxPrincipal";
            this.pbxPrincipal.Size = new System.Drawing.Size(253, 227);
            this.pbxPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPrincipal.TabIndex = 13;
            this.pbxPrincipal.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(270, 350);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar artículo";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // marcasToolStripMenuItem
            // 
            this.marcasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarToolStripMenuItem});
            this.marcasToolStripMenuItem.Name = "marcasToolStripMenuItem";
            this.marcasToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.marcasToolStripMenuItem.Text = "Marcas";
            // 
            // administrarToolStripMenuItem
            // 
            this.administrarToolStripMenuItem.Name = "administrarToolStripMenuItem";
            this.administrarToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.administrarToolStripMenuItem.Text = "Administrar";
            this.administrarToolStripMenuItem.Click += new System.EventHandler(this.administrarToolStripMenuItem_Click);
            // 
            // categoríasToolStripMenuItem
            // 
            this.categoríasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarToolStripMenuItem1});
            this.categoríasToolStripMenuItem.Name = "categoríasToolStripMenuItem";
            this.categoríasToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.categoríasToolStripMenuItem.Text = "Categorías";
            // 
            // administrarToolStripMenuItem1
            // 
            this.administrarToolStripMenuItem1.Name = "administrarToolStripMenuItem1";
            this.administrarToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.administrarToolStripMenuItem1.Text = "Administrar";
            this.administrarToolStripMenuItem1.Click += new System.EventHandler(this.administrarToolStripMenuItem1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marcasToolStripMenuItem,
            this.categoríasToolStripMenuItem,
            this.imágenesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1273, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // imágenesToolStripMenuItem
            // 
            this.imágenesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarToolStripMenuItem2});
            this.imágenesToolStripMenuItem.Name = "imágenesToolStripMenuItem";
            this.imágenesToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.imágenesToolStripMenuItem.Text = "Imágenes";
            // 
            // administrarToolStripMenuItem2
            // 
            this.administrarToolStripMenuItem2.Name = "administrarToolStripMenuItem2";
            this.administrarToolStripMenuItem2.Size = new System.Drawing.Size(136, 22);
            this.administrarToolStripMenuItem2.Text = "Administrar";
            this.administrarToolStripMenuItem2.Click += new System.EventHandler(this.administrarToolStripMenuItem2_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(385, 350);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 23);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar artículo";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(864, 350);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 23);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar artículo";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnImagenAnterior
            // 
            this.btnImagenAnterior.Location = new System.Drawing.Point(1012, 350);
            this.btnImagenAnterior.Name = "btnImagenAnterior";
            this.btnImagenAnterior.Size = new System.Drawing.Size(100, 23);
            this.btnImagenAnterior.TabIndex = 14;
            this.btnImagenAnterior.Text = "<< Anterior";
            this.btnImagenAnterior.UseVisualStyleBackColor = true;
            this.btnImagenAnterior.Click += new System.EventHandler(this.btnImagenAnterior_Click);
            // 
            // btnImagenSiguiente
            // 
            this.btnImagenSiguiente.Location = new System.Drawing.Point(1127, 350);
            this.btnImagenSiguiente.Name = "btnImagenSiguiente";
            this.btnImagenSiguiente.Size = new System.Drawing.Size(100, 23);
            this.btnImagenSiguiente.TabIndex = 15;
            this.btnImagenSiguiente.Text = "Siguiente >>";
            this.btnImagenSiguiente.UseVisualStyleBackColor = true;
            this.btnImagenSiguiente.Click += new System.EventHandler(this.btnImagenSiguiente_Click);
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(20, 319);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(40, 13);
            this.lblCampo.TabIndex = 18;
            this.lblCampo.Text = "Campo";
            // 
            // btnFiltro
            // 
            this.btnFiltro.Location = new System.Drawing.Point(640, 309);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(75, 23);
            this.btnFiltro.TabIndex = 19;
            this.btnFiltro.Text = "Buscar";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(225, 319);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(39, 13);
            this.lblCriterio.TabIndex = 20;
            this.lblCriterio.Text = "Criterio";
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(429, 319);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(29, 13);
            this.lblFiltro.TabIndex = 22;
            this.lblFiltro.Text = "Filtro";
            // 
            // cboCampo
            // 
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(82, 311);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(121, 21);
            this.cboCampo.TabIndex = 23;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged);
            // 
            // cboCriterio
            // 
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(286, 311);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(121, 21);
            this.cboCriterio.TabIndex = 24;
            // 
            // cboFiltro
            // 
            this.cboFiltro.Location = new System.Drawing.Point(494, 312);
            this.cboFiltro.Name = "cboFiltro";
            this.cboFiltro.Size = new System.Drawing.Size(100, 20);
            this.cboFiltro.TabIndex = 25;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 385);
            this.Controls.Add(this.cboFiltro);
            this.Controls.Add(this.cboCriterio);
            this.Controls.Add(this.cboCampo);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.btnImagenSiguiente);
            this.Controls.Add(this.btnImagenAnterior);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pbxPrincipal);
            this.Controls.Add(this.dgvPrincipal);
            this.Controls.Add(this.btnAplicarFiltro);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.lblFiltrarCategoria);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblFiltrarCodigo);
            this.Controls.Add(this.cboMarcas);
            this.Controls.Add(this.txtArticulo);
            this.Controls.Add(this.lblFiltrarMarca);
            this.Controls.Add(this.lblFiltrarArticulo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BusinessMaster 2024";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPrincipal)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFiltrarArticulo;
        private System.Windows.Forms.Label lblFiltrarMarca;
        private System.Windows.Forms.TextBox txtArticulo;
        private System.Windows.Forms.ComboBox cboMarcas;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblFiltrarCodigo;
        private System.Windows.Forms.Label lblFiltrarCategoria;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Button btnAplicarFiltro;
        private System.Windows.Forms.DataGridView dgvPrincipal;
        private System.Windows.Forms.PictureBox pbxPrincipal;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ToolStripMenuItem marcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoríasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ToolStripMenuItem imágenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarToolStripMenuItem2;
        private System.Windows.Forms.Button btnImagenAnterior;
        private System.Windows.Forms.Button btnImagenSiguiente;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.ComboBox cboCriterio;
        private System.Windows.Forms.TextBox cboFiltro;
    }
}

