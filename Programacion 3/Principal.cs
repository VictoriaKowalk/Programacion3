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
using System.Reflection;
using System.CodeDom;

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
            cargar();
        }

        private void cargar()
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            listaArticulos = negocio.listar();
            dgvPrincipal.DataSource = listaArticulos;
            dgvPrincipal.Columns["Imagenes"].Visible = false;
            dgvPrincipal.Columns["IDArticulo"].Visible = false;
            dgvPrincipal.Columns["Codigo"].HeaderText = "Código";
            dgvPrincipal.Columns["Descripcion"].HeaderText = "Descripción";
            dgvPrincipal.Columns["Categoria"].HeaderText = "Categoría";
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

        private void dgvPrincipal_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvPrincipal.CurrentRow.DataBoundItem;
            CargarImagen(seleccionado.Imagenes.ImagenUrl);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmArticulos ventana = new frmArticulos();
            ventana.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvPrincipal.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvPrincipal.CurrentRow.DataBoundItem;
                frmArticulos ventana = new frmArticulos(seleccionado);
                ventana.ShowDialog();
                cargar();
            }
            else 
            {
                MessageBox.Show("Debe seleccionar el artículo a modificar.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPrincipal.CurrentRow != null)
            {
                ArticulosNegocio negocio = new ArticulosNegocio();
                Articulo seleccionado;
                try
                {
                    seleccionado = (Articulo)dgvPrincipal.CurrentRow.DataBoundItem;
                    DialogResult respuesta = MessageBox.Show("¿Eliminar el registro " + seleccionado.Nombre + "?", "Eliminar artículo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        negocio.eliminar(seleccionado.IDArticulo);
                        MessageBox.Show("Se ha eliminado el artículo.");
                        cargar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar el artículo a eliminar.");
            }
        }

        private void administrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmImagenes ventana = new frmImagenes();
            ventana.ShowDialog();
            cargar();
        }

        private void dgvPrincipal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
