using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Programacion_3
{
    public partial class frmArticulos : Form
    {
        private Articulo articulo;

        public frmArticulos()
        {
            InitializeComponent();
            //Fondo para la app
            Bitmap img = new Bitmap(Application.StartupPath + @"/Fondo/backgrounds.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;   //para que sea ajustable en tamaño
            Text = "Nuevo Artículo";
        }
        //segundo construcctor para selecionado
        public frmArticulos(Articulo articulo)
        {
            InitializeComponent();
            //Fondo para la app
            Bitmap img = new Bitmap(Application.StartupPath + @"/Fondo/backgrounds.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;   //para que sea ajustable en tamaño
            this.articulo = articulo;
            Text = "Modificar Artículo";
        }
        private void CargarImagen(string imagen)
        {
            // Usa la función Load de la PictureBox para mostrar la imagen de la URL dada
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception)
            {
                pbxArticulo.Load("https://media.istockphoto.com/id/1409329028/vector/no-picture-available-placeholder-thumbnail-icon-illustration-design.jpg?s=612x612&w=0&k=20&c=_zOuJu755g2eEUioiOUdz_mHKJQJn-tDgIAhQzyeKUQ=");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmModificar_Load(object sender, EventArgs e)
        {
            CategoriasNegocio categorias = new CategoriasNegocio();
            MarcasNegocio marcas = new MarcasNegocio();

            try
            {
                cboCategoria.DataSource = categorias.listar();
                cboCategoria.ValueMember = "IdCategoria";
                cboCategoria.DisplayMember = "Nombre";

                cboMarca.DataSource = marcas.listar();
                cboMarca.ValueMember = "IdMarca";
                cboMarca.DisplayMember = "Nombre";

                // Si el artículo no es null, es una modificación
                if (articulo!= null)
                {
                    // Precarga el articulo
                    txtNombre.Text = articulo.Nombre;
                    txtCodigo.Text = articulo.Codigo;
                    txtDescripcion.Text = articulo.Descripcion;

                    // NO FUNCIONA CORRECTAMENTE
                    cboCategoria.SelectedValue = articulo.Categoria.IDCategoria;
                    cboMarca.SelectedValue = articulo.Marca.IDMarca;
                    
                    txtPrecio.Text = articulo.Precio.ToString();
                    txtImagen.Text = articulo.Imagenes.ImagenUrl.ToString();
                    CargarImagen(articulo.Imagenes.ImagenUrl);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            btnAceptar_Click(sender, e, txtImagen);
        }

        private void btnAceptar_Click(object sender, EventArgs e, TextBox txtImagen)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            ImagenesNegocio negocioImagenes = new ImagenesNegocio();
            try
            {
                if (articulo == null)
                    articulo = new Articulo();

                articulo.Codigo = txtCodigo.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Precio = decimal.Parse(txtPrecio.Text);
                Imagenes imagen = new Imagenes();    
                imagen.ImagenUrl = txtImagen.Text;
                articulo.Imagenes.ImagenUrl = txtImagen.Text;


                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;
                articulo.Marca = (Marca)cboMarca.SelectedItem;


                if (articulo.IDArticulo != 0)
                {
                    negocio.modificar(articulo);
                    negocioImagenes.actualizarImagen(articulo);
                    MessageBox.Show("Modificado exitosamente.");
                }
                else
                {
                    negocio.agregar(articulo);
                    articulo.IDArticulo = negocio.obtenerIDArticulo();
                    negocioImagenes.agregarImagen(articulo);
                    MessageBox.Show("Agregado exitosamente.");
                }
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
