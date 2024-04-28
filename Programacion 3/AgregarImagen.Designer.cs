namespace Programacion_3
{
    partial class AgregarImagen
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.lblURL = new System.Windows.Forms.Label();
            this.txtIDArticulo = new System.Windows.Forms.TextBox();
            this.lblIDArticulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(136, 80);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(248, 111);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(136, 22);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(179, 20);
            this.txtURL.TabIndex = 0;
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.BackColor = System.Drawing.Color.Transparent;
            this.lblURL.Location = new System.Drawing.Point(7, 25);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(95, 13);
            this.lblURL.TabIndex = 10;
            this.lblURL.Text = "URL de la imagen:";
            // 
            // txtIDArticulo
            // 
            this.txtIDArticulo.Location = new System.Drawing.Point(136, 54);
            this.txtIDArticulo.Name = "txtIDArticulo";
            this.txtIDArticulo.Size = new System.Drawing.Size(179, 20);
            this.txtIDArticulo.TabIndex = 1;
            // 
            // lblIDArticulo
            // 
            this.lblIDArticulo.AutoSize = true;
            this.lblIDArticulo.BackColor = System.Drawing.Color.Transparent;
            this.lblIDArticulo.Location = new System.Drawing.Point(7, 57);
            this.lblIDArticulo.Name = "lblIDArticulo";
            this.lblIDArticulo.Size = new System.Drawing.Size(123, 13);
            this.lblIDArticulo.TabIndex = 14;
            this.lblIDArticulo.Text = "ID del artículo asociado:";
            // 
            // AgregarImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 157);
            this.Controls.Add(this.txtIDArticulo);
            this.Controls.Add(this.lblIDArticulo);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.lblURL);
            this.Name = "AgregarImagen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva imagen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.TextBox txtIDArticulo;
        private System.Windows.Forms.Label lblIDArticulo;
    }
}