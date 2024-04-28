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
    public partial class AgregarCategoria : Form
    {
        public AgregarCategoria()
        {
            InitializeComponent();
        }

        private void AgregarCategoria_Load(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(Application.StartupPath + @"/Fondo/backgrounds.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private bool validarCategoria()
        {
            if (txtNombreCategoria.Text == "")
            {
                MessageBox.Show("La categoría debe tener un nombre.");
                return false;
            }
            if (txtNombreCategoria.Text.Length > 50)
            {
                MessageBox.Show("El nombre de la categoría es muy largo.");
                return false;
            }
            return true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            CategoriasNegocio negocio = new CategoriasNegocio();

            if (!validarCategoria())
            {
                return;
            }

            try
            {
                categoria.Nombre = txtNombreCategoria.Text;
                negocio.agregar(categoria);
                MessageBox.Show("Se agregó la categoría exitosamente.");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
