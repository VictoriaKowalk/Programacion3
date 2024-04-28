using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programacion_3
{
    public partial class verDetalle : Form
    {
        public Articulo articulo;

        public verDetalle(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Detalle del producto";
            //Fondo para la app
            Bitmap img = new Bitmap(Application.StartupPath + @"/Fondo/backgrounds.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;   //para que sea ajustable en tamaño
        }

        private void verDetalle_Load(object sender, EventArgs e)
        {
            ArticulosNegocio negocio= new ArticulosNegocio();

            try
            {
                txtIDArticulo.Text = articulo.IDArticulo.ToString();
                txtCodigo.Text = articulo.Codigo;
                txtDescripcion.Text = articulo.Descripcion;
                txtNombre.Text = articulo.Nombre;
                txtPrecio.Text = articulo.Precio.ToString("$0,00");
                txtMarca.Text = articulo.Marca.ToString();
                txtCategoria.Text=articulo.Categoria.ToString();

                if (articulo.Imagenes.Count() > 0)
                {
                    string UrlImagen = articulo.Imagenes[0].ImagenUrl;
                    cargarImagen(UrlImagen);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message.ToString());
            }

        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulosDetalle.Load(imagen);
            }
            catch (Exception)
            {
                pbxArticulosDetalle.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
