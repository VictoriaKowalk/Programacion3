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

        private bool validarImagen()
        {
            if (txtIDArticulo.Text == "" || txtURL.Text == "")
            {
                MessageBox.Show("Por favor complete todos los campos.");
                return false;
            }
            foreach (char caracter in txtIDArticulo.Text)
            {
                if (!char.IsNumber(caracter))
                {
                    MessageBox.Show("El ID de artículo debe ser numérico.");
                    return false;
                }
            }
            return true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ImagenesNegocio negocio = new ImagenesNegocio();

            if (!validarImagen())
            {
                return;
            }
            try
            {
                Imagen imagen = new Imagen();
                imagen.IDArticulo = int.Parse(txtIDArticulo.Text);
                imagen.ImagenUrl = txtURL.Text;
                negocio.agregarImagen(imagen);
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
