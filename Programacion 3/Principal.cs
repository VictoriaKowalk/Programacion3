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
using Negocio;
using Dominio;

namespace TrabajoPractico
{
    public partial class frmPrincipal : Form
    {
        private List<Dominio.Articulo> listaArticulos;
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

      

        private void agregarArtículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArticulos ventana = new frmArticulos();
            ventana.ShowDialog();
        }

        private void modificarArtículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArticulos ventana = new frmArticulos();
            ventana.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmArticulos ventana = new frmArticulos();
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
        private void CargarImagen(string imagen)
        {
            // Usa la función Load de la PictureBox para mostrar la imagen de la URL dada
            try
            {
                pbxPrincipal.Load(imagen);
            }
            catch (Exception)
            {
                pbxPrincipal.Load("https://media.istockphoto.com/id/1409329028/vector/no-picture-available-placeholder-thumbnail-icon-illustration-design.jpg?s=612x612&w=0&k=20&c=_zOuJu755g2eEUioiOUdz_mHKJQJn-tDgIAhQzyeKUQ=");
            }
        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            listaArticulos = negocio.listar();
            dgvPrincipal.DataSource = listaArticulos;
            dgvPrincipal.Columns["Imagenes"].Visible = false;
            dgvPrincipal.Columns["IDArticulo"].Visible = false;
            CargarImagen(listaArticulos[0].Imagenes.ImagenUrl);

            MarcasNegocio marcaNegocio = new MarcasNegocio();
            CategoriasNegocio categoriaNegocio = new CategoriasNegocio();
            try
            {
                cboMarcas.DataSource = marcaNegocio.listar();
                cboCategoria.DataSource = categoriaNegocio.listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPrincipal_SelectionChanged(object sender, EventArgs e)
        {
            Articulo selecionado = (Articulo)dgvPrincipal.CurrentRow.DataBoundItem;
           CargarImagen(selecionado.Imagenes.ImagenUrl);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmArticulos ventana = new frmArticulos();
            ventana.ShowDialog();
        }
    }
}
