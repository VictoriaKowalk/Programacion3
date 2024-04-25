using Programacion_3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPractico
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            //Fondo para la app
            Bitmap img = new Bitmap(Application.StartupPath + @"/Fondo/backgrounds.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;   //para que sea ajustable en tamaño
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void artículosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listarArtículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListado ventana = new frmListado();
            ventana.ShowDialog();
        }

        private void agregarArtículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregar ventana = new frmAgregar();
            ventana.ShowDialog();
        }

        private void modificarArtículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModificar ventana = new frmModificar();
            ventana.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmModificar ventana = new frmModificar();
            ventana.ShowDialog();
        }

        private void administrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMarcas ventana = new frmMarcas();
            ventana.ShowDialog();
        }

        private void administrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCategorias ventana = new frmCategorias();
            ventana.ShowDialog();
        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            CategoriasNegocio categorias = new CategoriasNegocio();
            MarcasNegocio marcas = new MarcasNegocio();

            try
            {
                cboCategoria.DataSource = categorias.listar();
                cboMarcas.DataSource = marcas.listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
