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
            Text = "Nuevo artículo";
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
            Text = "Modificar artículo";
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

                    cboCategoria.SelectedValue = articulo.Categoria.IDCategoria;
                    cboMarca.SelectedValue = articulo.Marca.IDMarca;
                    
                    txtPrecio.Text = articulo.Precio.ToString();
                    if (articulo.Imagenes.Count() > 0)
                    {
                        txtImagen.Text = articulo.Imagenes[0].ImagenUrl.ToString();
                        CargarImagen(articulo.Imagenes[0].ImagenUrl);
                    }
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
            Imagen imagen = new Imagen();

            try
            {
                if (articulo == null)
                    articulo = new Articulo();

                articulo.Codigo = txtCodigo.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Precio = decimal.Parse(txtPrecio.Text);
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;
                articulo.Marca = (Marca)cboMarca.SelectedItem;

                // Si la ID es distinta de 0, se trata de un artículo ya existente (modificación)
                if (articulo.IDArticulo != 0)
                {
                    negocio.modificar(articulo);
                    // Si el enlace no está vacío, decidimos si actualizar o agregar una nueva imagen
                    if (txtImagen.Text != "")
                    {
                        imagen.ImagenUrl = txtImagen.Text;
                        imagen.IDArticulo = articulo.IDArticulo;
                        // Si el artículo tiene imágenes, modificamos la principal
                        if (articulo.Imagenes.Count > 0)
                        {
                            imagen.IDImagen = articulo.Imagenes[0].IDImagen;
                            negocioImagenes.actualizarImagen(imagen);
                        }
                        // De lo contrario, se agrega una nueva imagen
                        else
                        {
                            negocioImagenes.agregarImagen(imagen);
                        }
                    }
                    MessageBox.Show("Modificado exitosamente.");
                }
                else
                {
                    negocio.agregar(articulo);
                    if (txtImagen.Text != "")
                    {
                        // Si el enlace no está vacío, se agrega a la tabla de imágenes
                        // Se obtiene el artículo al cual se va a vincular la imagen
                        imagen.IDArticulo = negocio.obtenerIDArticulo();
                        imagen.ImagenUrl = txtImagen.Text;
                        MessageBox.Show(imagen.IDArticulo.ToString());
                        negocioImagenes.agregarImagen(imagen);
                    }
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
