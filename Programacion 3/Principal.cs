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
using System.Diagnostics.Eventing.Reader;

namespace TrabajoPractico
{
    public partial class frmPrincipal : Form
    {
        private List<Dominio.Articulo> listaArticulos;
        private List<Dominio.Imagen> listaImagenes;
        private int indiceImagen;
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

        private void CargarImagen()
        {
            // Usa la función Load de la PictureBox para mostrar la imagen de la URL dada
            pbxPrincipal.Image = null;
            pbxPrincipal.Update();
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
            cboCampo.Items.Add("Precio");
            cboCampo.Items.Add("Código");
            cboCampo.Items.Add("Nombre");
        }

        private void cargar()
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            ImagenesNegocio imagenesNegocio = new ImagenesNegocio();
            indiceImagen = 0;

            listaArticulos = negocio.listar();
            listaImagenes = imagenesNegocio.listar();
            imagenesNegocio.vincularImagenes(listaArticulos, listaImagenes);
            dgvPrincipal.DataSource = listaArticulos;
            dgvPrincipal.Columns["IDArticulo"].Visible = false;
            dgvPrincipal.Columns["Codigo"].HeaderText = "Código";
            dgvPrincipal.Columns["Descripcion"].HeaderText = "Descripción";
            dgvPrincipal.Columns["Categoria"].HeaderText = "Categoría";
            // Si el artículo tiene imágenes, se carga la primera, de lo contrario
            // se setea la imagen vacía.
            if (listaArticulos.Count() > 0)
            {
                if (listaArticulos[0].Imagenes.Count() > 0)
                {
                    CargarImagen(listaArticulos[0].Imagenes[0].ImagenUrl);
                }
                else
                {
                    CargarImagen();
                }
            }
        }

        private void dgvPrincipal_SelectionChanged(object sender, EventArgs e)
        {
            // Cuando cambiamos de registro, reseteamos el índice a 0.
            indiceImagen = 0;
            if (dgvPrincipal.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvPrincipal.CurrentRow.DataBoundItem;
                if (seleccionado.Imagenes.Count() > 0)
                {
                    CargarImagen(seleccionado.Imagenes[indiceImagen].ImagenUrl);
                }
                else
                {
                    CargarImagen();
                }
            }
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

        private void btnImagenSiguiente_Click(object sender, EventArgs e)
        {
            if (dgvPrincipal.CurrentRow != null)
            {
                // Para pasar a la siguiente imagen, aumentamos el índice.
                // Comprobamos que aún podamos avanzar en la lista.
                Articulo seleccionado = (Articulo)dgvPrincipal.CurrentRow.DataBoundItem;
                if (seleccionado.Imagenes.Count() - 1 > indiceImagen)
                {
                    indiceImagen++;
                    CargarImagen(seleccionado.Imagenes[indiceImagen].ImagenUrl);
                }
            }
        }

        private void btnImagenAnterior_Click(object sender, EventArgs e)
        {
            if (dgvPrincipal.CurrentRow != null)
            {
                // Para pasar a la anterior imagen, reducimos el índice.
                // Comprobamos que aún podamos retroceder en la lista.
                if (indiceImagen > 0)
                {
                    indiceImagen--;
                    Articulo seleccionado = (Articulo)dgvPrincipal.CurrentRow.DataBoundItem;
                    CargarImagen(seleccionado.Imagenes[indiceImagen].ImagenUrl);
                }
            }
        }

        private bool validarCampos()
        {
            if (cboCampo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el campo por el cual filtrar.");
                return false;
            }
            if (cboCriterio.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el criterio por el cual filtrar.");
                return false;
            }
            if (cboCampo.SelectedIndex == 0)
            {
                if (txtFiltro.Text == "")
                {
                    MessageBox.Show("Ingrese un valor numérico para filtrar.");
                    return false;
                }
                else
                {
                    foreach (char caracter in txtFiltro.Text)
                    {
                        if (!char.IsNumber(caracter))
                        {
                            MessageBox.Show("Introduzca valor númericos únicamente.");
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            ImagenesNegocio imagenesNegocio = new ImagenesNegocio();
            indiceImagen = 0;
            try
            {
                if (!validarCampos())
                {
                    return;
                }
                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltro.Text;

                listaArticulos = negocio.filtrar(campo, criterio, filtro);
                listaImagenes = imagenesNegocio.listar();
                imagenesNegocio.vincularImagenes(listaArticulos, listaImagenes);
                dgvPrincipal.DataSource = listaArticulos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCampo.SelectedIndex == -1)
            {
                return;
            }
            string opcion = cboCampo.SelectedItem.ToString();
            if (opcion == "Precio")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Igual a");
                cboCriterio.Items.Add("Menor a");
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Empieza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dgvPrincipal.CurrentRow != null)
            {
                Articulo seleccionado;
                seleccionado = (Articulo)dgvPrincipal.CurrentRow.DataBoundItem;
                verDetalle detalle = new verDetalle(seleccionado);
                detalle.ShowDialog();
                cargar();
            } else
            {
                MessageBox.Show("Debe seleccionar el artículo a visualizar.");
            }
        }

        private void lblDesactivarFiltro_Click(object sender, EventArgs e)
        {
            // Refrescamos los artículos
            cargar();
            // Reseteamos el campo seleccionado
            cboCampo.SelectedIndex = -1;
            // Vaciamos el listado de criterio
            cboCriterio.Items.Clear();
            // Vaciamos la caja de texto
            txtFiltro.Clear();
        }
    }
}
