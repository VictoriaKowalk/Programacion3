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
    public partial class AgregarImagen : Form
    {
        private Imagen imagen;

        public AgregarImagen()
        {
            InitializeComponent();
            //Fondo para la app
            Bitmap img = new Bitmap(Application.StartupPath + @"/Fondo/backgrounds.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;   //para que sea ajustable en tamaño
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            ImagenesNegocio negocio = new ImagenesNegocio();

            if (txtIDArticulo.Text == "" || txtURL.Text == "")
            {
                MessageBox.Show("Por favor complete todos los campos.");
            }
            else
            {
                try
                {
                    articulo.IDArticulo = int.Parse(txtIDArticulo.Text);
                    articulo.Imagenes.ImagenUrl = txtURL.Text;
                    negocio.agregarImagen(articulo);
                    MessageBox.Show("Se agregó la imagen exitosamente.");
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                }
            }
        }
    }
}
