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
    public partial class AgregarMarca : Form
    {
        public AgregarMarca()
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

        private bool validarMarca()
        {
            if (txtNombreMarca.Text == "")
            {
                MessageBox.Show("La marca debe tener un nombre.");
                return false;
            }
            if (txtNombreMarca.Text.Length > 50)
            {
                MessageBox.Show("El nombre de la marca es muy largo.");
                return false;
            }
            return true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Marca marca = new Marca();
            MarcasNegocio negocio = new MarcasNegocio();

            if (!validarMarca())
            {
                return;
            }

            try
            {
                marca.Nombre = txtNombreMarca.Text;
                negocio.agregar(marca);
                MessageBox.Show("Se agregó la marca exitosamente.");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }
    }
}
