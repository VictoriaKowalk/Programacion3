namespace TrabajoPractico
{
    partial class Principal
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
            this.modificarArtículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarArtículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoríasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lboArticulos = new System.Windows.Forms.ListBox();
            this.lblFiltrarArticulo = new System.Windows.Forms.Label();
            this.lblFiltrarMarca = new System.Windows.Forms.Label();
            this.txtArticulo = new System.Windows.Forms.TextBox();
            this.cboMarcas = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblFiltrarCodigo = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(567, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // artículosToolStripMenuItem
            // 
            this.artículosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarArtículosToolStripMenuItem,
            this.agregarArtículosToolStripMenuItem,
            this.modificarArtículosToolStripMenuItem,
            this.eliminarArtículosToolStripMenuItem});
            this.artículosToolStripMenuItem.Name = "artículosToolStripMenuItem";
            this.artículosToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.artículosToolStripMenuItem.Text = "Artículos";
            this.artículosToolStripMenuItem.Click += new System.EventHandler(this.artículosToolStripMenuItem_Click);
            // 
            // listarArtículosToolStripMenuItem
            // 
            this.listarArtículosToolStripMenuItem.Name = "listarArtículosToolStripMenuItem";
            this.listarArtículosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.listarArtículosToolStripMenuItem.Text = "Listar artículos";
            this.listarArtículosToolStripMenuItem.Click += new System.EventHandler(this.listarArtículosToolStripMenuItem_Click);
            // 
            // agregarArtículosToolStripMenuItem
            // 
            this.agregarArtículosToolStripMenuItem.Name = "agregarArtículosToolStripMenuItem";
            this.agregarArtículosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.agregarArtículosToolStripMenuItem.Text = "Agregar artículos";
            this.agregarArtículosToolStripMenuItem.Click += new System.EventHandler(this.agregarArtículosToolStripMenuItem_Click);
            // 
            // modificarArtículosToolStripMenuItem
            // 
            this.modificarArtículosToolStripMenuItem.Name = "modificarArtículosToolStripMenuItem";
            this.modificarArtículosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.modificarArtículosToolStripMenuItem.Text = "Modificar artículos";
            this.modificarArtículosToolStripMenuItem.Click += new System.EventHandler(this.modificarArtículosToolStripMenuItem_Click);
            // 
            // eliminarArtículosToolStripMenuItem
            // 
            this.eliminarArtículosToolStripMenuItem.Name = "eliminarArtículosToolStripMenuItem";
            this.eliminarArtículosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.eliminarArtículosToolStripMenuItem.Text = "Eliminar artículos";
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
            // 
            // lboArticulos
            // 
            this.lboArticulos.FormattingEnabled = true;
            this.lboArticulos.ItemHeight = 16;
            this.lboArticulos.Location = new System.Drawing.Point(320, 34);
            this.lboArticulos.Margin = new System.Windows.Forms.Padding(4);
            this.lboArticulos.Name = "lboArticulos";
            this.lboArticulos.Size = new System.Drawing.Size(159, 308);
            this.lboArticulos.TabIndex = 1;
            // 
            // lblFiltrarArticulo
            // 
            this.lblFiltrarArticulo.AutoSize = true;
            this.lblFiltrarArticulo.Location = new System.Drawing.Point(32, 38);
            this.lblFiltrarArticulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltrarArticulo.Name = "lblFiltrarArticulo";
            this.lblFiltrarArticulo.Size = new System.Drawing.Size(112, 16);
            this.lblFiltrarArticulo.TabIndex = 2;
            this.lblFiltrarArticulo.Text = "Filtrar por artículo:";
            this.lblFiltrarArticulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblFiltrarMarca
            // 
            this.lblFiltrarMarca.AutoSize = true;
            this.lblFiltrarMarca.Location = new System.Drawing.Point(32, 122);
            this.lblFiltrarMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltrarMarca.Name = "lblFiltrarMarca";
            this.lblFiltrarMarca.Size = new System.Drawing.Size(107, 16);
            this.lblFiltrarMarca.TabIndex = 3;
            this.lblFiltrarMarca.Text = "Filtrar por marca:";
            // 
            // txtArticulo
            // 
            this.txtArticulo.Location = new System.Drawing.Point(163, 34);
            this.txtArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.Size = new System.Drawing.Size(132, 22);
            this.txtArticulo.TabIndex = 4;
            // 
            // cboMarcas
            // 
            this.cboMarcas.FormattingEnabled = true;
            this.cboMarcas.Location = new System.Drawing.Point(163, 118);
            this.cboMarcas.Margin = new System.Windows.Forms.Padding(4);
            this.cboMarcas.Name = "cboMarcas";
            this.cboMarcas.Size = new System.Drawing.Size(132, 24);
            this.cboMarcas.TabIndex = 5;
            this.cboMarcas.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(163, 76);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(132, 22);
            this.txtCodigo.TabIndex = 7;
            this.txtCodigo.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblFiltrarCodigo
            // 
            this.lblFiltrarCodigo.AutoSize = true;
            this.lblFiltrarCodigo.Location = new System.Drawing.Point(32, 80);
            this.lblFiltrarCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltrarCodigo.Name = "lblFiltrarCodigo";
            this.lblFiltrarCodigo.Size = new System.Drawing.Size(111, 16);
            this.lblFiltrarCodigo.TabIndex = 6;
            this.lblFiltrarCodigo.Text = "Filtrar por código:";
            this.lblFiltrarCodigo.Click += new System.EventHandler(this.label3_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 382);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblFiltrarCodigo);
            this.Controls.Add(this.cboMarcas);
            this.Controls.Add(this.txtArticulo);
            this.Controls.Add(this.lblFiltrarMarca);
            this.Controls.Add(this.lblFiltrarArticulo);
            this.Controls.Add(this.lboArticulos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Principal";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem artículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarArtículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarArtículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarArtículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarArtículosToolStripMenuItem;
        private System.Windows.Forms.ListBox lboArticulos;
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
    }
}

