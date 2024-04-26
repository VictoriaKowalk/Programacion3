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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.artículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarArtículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarArtículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoríasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.artículosToolStripMenuItem,
            this.marcasToolStripMenuItem,
            this.categoríasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(825, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // artículosToolStripMenuItem
            // 
            this.artículosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarArtículosToolStripMenuItem,
            this.agregarArtículosToolStripMenuItem});
            this.artículosToolStripMenuItem.Name = "artículosToolStripMenuItem";
            this.artículosToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.artículosToolStripMenuItem.Text = "Artículos";
            this.artículosToolStripMenuItem.Click += new System.EventHandler(this.artículosToolStripMenuItem_Click);
            // 
            // listarArtículosToolStripMenuItem
            // 
            this.listarArtículosToolStripMenuItem.Name = "listarArtículosToolStripMenuItem";
            this.listarArtículosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.listarArtículosToolStripMenuItem.Text = "Listar";
            this.listarArtículosToolStripMenuItem.Click += new System.EventHandler(this.listarArtículosToolStripMenuItem_Click);
            // 
            // agregarArtículosToolStripMenuItem
            // 
            this.agregarArtículosToolStripMenuItem.Name = "agregarArtículosToolStripMenuItem";
            this.agregarArtículosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.agregarArtículosToolStripMenuItem.Text = "Agregar";
            this.agregarArtículosToolStripMenuItem.Click += new System.EventHandler(this.agregarArtículosToolStripMenuItem_Click);
            // 
            // marcasToolStripMenuItem
            // 
            this.marcasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarToolStripMenuItem});
            this.marcasToolStripMenuItem.Name = "marcasToolStripMenuItem";
            this.marcasToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.marcasToolStripMenuItem.Text = "Marcas";
            // 
            // administrarToolStripMenuItem
            // 
            this.administrarToolStripMenuItem.Name = "administrarToolStripMenuItem";
            this.administrarToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.administrarToolStripMenuItem.Text = "Administrar";
            this.administrarToolStripMenuItem.Click += new System.EventHandler(this.administrarToolStripMenuItem_Click);
            // 
            // categoríasToolStripMenuItem
            // 
            this.categoríasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarToolStripMenuItem1});
            this.categoríasToolStripMenuItem.Name = "categoríasToolStripMenuItem";
            this.categoríasToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.categoríasToolStripMenuItem.Text = "Categorías";
            // 
            // administrarToolStripMenuItem1
            // 
            this.administrarToolStripMenuItem1.Name = "administrarToolStripMenuItem1";
            this.administrarToolStripMenuItem1.Size = new System.Drawing.Size(169, 26);
            this.administrarToolStripMenuItem1.Text = "Administrar";
            this.administrarToolStripMenuItem1.Click += new System.EventHandler(this.administrarToolStripMenuItem1_Click);
            // 
            // lblFiltrarArticulo
            // 
            this.lblFiltrarArticulo.AutoSize = true;
            this.lblFiltrarArticulo.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltrarArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrarArticulo.Location = new System.Drawing.Point(10, 60);
            this.lblFiltrarArticulo.Name = "lblFiltrarArticulo";
            this.lblFiltrarArticulo.Size = new System.Drawing.Size(127, 18);
            this.lblFiltrarArticulo.TabIndex = 2;
            this.lblFiltrarArticulo.Text = "Filtrar por artículo:";
            this.lblFiltrarArticulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblFiltrarMarca
            // 
            this.lblFiltrarMarca.AutoSize = true;
            this.lblFiltrarMarca.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltrarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrarMarca.Location = new System.Drawing.Point(10, 171);
            this.lblFiltrarMarca.Name = "lblFiltrarMarca";
            this.lblFiltrarMarca.Size = new System.Drawing.Size(121, 18);
            this.lblFiltrarMarca.TabIndex = 3;
            this.lblFiltrarMarca.Text = "Filtrar por marca:";
            // 
            // txtArticulo
            // 
            this.txtArticulo.Location = new System.Drawing.Point(136, 58);
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.Size = new System.Drawing.Size(100, 20);
            this.txtArticulo.TabIndex = 4;
            // 
            // cboMarcas
            // 
            this.cboMarcas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarcas.FormattingEnabled = true;
            this.cboMarcas.Location = new System.Drawing.Point(136, 169);
            this.cboMarcas.Name = "cboMarcas";
            this.cboMarcas.Size = new System.Drawing.Size(100, 21);
            this.cboMarcas.TabIndex = 5;
            this.cboMarcas.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(136, 93);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 7;
            this.txtCodigo.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblFiltrarCodigo
            // 
            this.lblFiltrarCodigo.AutoSize = true;
            this.lblFiltrarCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltrarCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrarCodigo.Location = new System.Drawing.Point(10, 94);
            this.lblFiltrarCodigo.Name = "lblFiltrarCodigo";
            this.lblFiltrarCodigo.Size = new System.Drawing.Size(124, 18);
            this.lblFiltrarCodigo.TabIndex = 6;
            this.lblFiltrarCodigo.Text = "Filtrar por código:";
            this.lblFiltrarCodigo.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblFiltrarCategoria
            // 
            this.lblFiltrarCategoria.AutoSize = true;
            this.lblFiltrarCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltrarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrarCategoria.Location = new System.Drawing.Point(10, 132);
            this.lblFiltrarCategoria.Name = "lblFiltrarCategoria";
            this.lblFiltrarCategoria.Size = new System.Drawing.Size(140, 18);
            this.lblFiltrarCategoria.TabIndex = 9;
            this.lblFiltrarCategoria.Text = "Filtrar por categoría:";
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(136, 126);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(100, 21);
            this.cboCategoria.TabIndex = 10;
            this.cboCategoria.SelectedIndexChanged += new System.EventHandler(this.cboCategoria_SelectedIndexChanged);
            // 
            // btnAplicarFiltro
            // 
            this.btnAplicarFiltro.Location = new System.Drawing.Point(136, 211);
            this.btnAplicarFiltro.Name = "btnAplicarFiltro";
            this.btnAplicarFiltro.Size = new System.Drawing.Size(100, 23);
            this.btnAplicarFiltro.TabIndex = 11;
            this.btnAplicarFiltro.Text = "Aplicar filtros";
            this.btnAplicarFiltro.UseVisualStyleBackColor = true;
            // 
            // dgvPrincipal
            // 
            this.dgvPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrincipal.Location = new System.Drawing.Point(274, 62);
            this.dgvPrincipal.Name = "dgvPrincipal";
            this.dgvPrincipal.RowHeadersWidth = 51;
            this.dgvPrincipal.Size = new System.Drawing.Size(240, 227);
            this.dgvPrincipal.TabIndex = 12;
            this.dgvPrincipal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvPrincipal.SelectionChanged += new System.EventHandler(this.dgvPrincipal_SelectionChanged);
            // 
            // pbxPrincipal
            // 
            this.pbxPrincipal.Location = new System.Drawing.Point(560, 62);
            this.pbxPrincipal.Name = "pbxPrincipal";
            this.pbxPrincipal.Size = new System.Drawing.Size(253, 227);
            this.pbxPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPrincipal.TabIndex = 13;
            this.pbxPrincipal.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 310);
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
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem artículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarArtículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarArtículosToolStripMenuItem;
        private System.Windows.Forms.Label lblFiltrarArticulo;
        private System.Windows.Forms.Label lblFiltrarMarca;
        private System.Windows.Forms.TextBox txtArticulo;
        private System.Windows.Forms.ComboBox cboMarcas;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblFiltrarCodigo;
        private System.Windows.Forms.ToolStripMenuItem marcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoríasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarToolStripMenuItem1;
        private System.Windows.Forms.Label lblFiltrarCategoria;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Button btnAplicarFiltro;
        private System.Windows.Forms.DataGridView dgvPrincipal;
        private System.Windows.Forms.PictureBox pbxPrincipal;
    }
}

