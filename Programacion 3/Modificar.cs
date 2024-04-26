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
    public partial class frmModificar : Form
    {
        private Articulo articulo = null;

        public frmModificar()
        {
            InitializeComponent();
            //Fondo para la app
            Bitmap img = new Bitmap(Application.StartupPath + @"/Fondo/backgrounds.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;   //para que sea ajustable en tamaño
        }
        //segundo construcctor para selecionado
        public frmModificar(Articulo articulo)
        {
            InitializeComponent();
           /* //Fondo para la app
            Bitmap img = new Bitmap(Application.StartupPath + @"/Fondo/backgrounds.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;   //para que sea ajustable en tamaño
            this.articulo = articulo;*/
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
                //capturo el id del articulo para que en el desplegable se vea el correcto
                cboCategoria.ValueMember = "IdCategoria";
                cboCategoria.DisplayMember = "Descripcion";

                cboMarca.DataSource = marcas.listar();
                cboMarca.ValueMember = "IdMarca";
                cboMarca.DisplayMember = "Nombre";

                // verifico que sea modificacion
                if (articulo!= null)
                {
                    //pregarga el articulo
                    txtNombre.Text = articulo.Nombre;
                    txtCodigo.Text = articulo.Codigo;
                    txtDescripcion.Text = articulo.Descripcion;

                    //me faltan los cbo
                    cboCategoria.SelectedValue = articulo.Codigo;
                    cboMarca.SelectedValue = articulo.Descripcion;


                    txtPrecio.Text = articulo.Precio.ToString();
                  

                    txtImagen.Text = articulo.UrlImagen;
                    CargarImagen(articulo.UrlImagen);
                    MessageBox.Show("Modificado exitosamente");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            try
            {
                articulo.IDArticulo = int.Parse(txtCodigo.Text);
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Precio = int.Parse(txtPrecio.Text);
                articulo.UrlImagen = txtImagen.Text;

                negocio.modificar(articulo);
                MessageBox.Show("Modificado exitosamente.");

                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
