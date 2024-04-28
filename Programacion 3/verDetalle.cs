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
        public Articulo artii;

        public Imagen imagen;


        public verDetalle()
        {
            InitializeComponent();


        }
        public verDetalle(Articulo artii)
        {
            InitializeComponent();
            this.artii = artii;
            Text = "Detalle del producto";
        }

        private void verDetalle_Load(object sender, EventArgs e)
        {
            ArticulosNegocio negocio= new ArticulosNegocio();

            try
            {
                txtCodigo.Text = artii.Codigo;
                txtDescripcion.Text = artii.Descripcion;
                txtNombre.Text = artii.Nombre;
                txtPrecio.Text = artii.Precio.ToString("$0,00");
                txtMarca.Text = artii.Marca.ToString();
                txtCategoria.Text=artii.Categoria.ToString();

                string UrlImagen = imagen.ImagenUrl;
                cargarImagen(UrlImagen);




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
    }
}
