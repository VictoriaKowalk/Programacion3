using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPractico;
using Dominio;
using Negocio;

namespace Programacion_3
{
    public partial class frmListado : Form
    {
        private List<Articulo> listaArticulos;
        public frmListado()
        {
            InitializeComponent();
            //Fondo para la app
            Bitmap img = new Bitmap(Application.StartupPath + @"/Fondo/backgrounds.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;   //para que sea ajustable en tamaño
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            listaArticulos = negocio.listar();
            dgvArticulos.DataSource = listaArticulos;
            dgvArticulos.Columns["UrlImagen"].Visible = false;
            dgvArticulos.Columns["IDArticulo"].Visible = false;
            CargarImagen(listaArticulos[0].UrlImagen); // Es necesario para asegurarnos que el primer item tenga una imagen apropiada
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregar ventana = new frmAgregar();
            ventana.Show();
        }

        private void lblCatagolo_Click(object sender, EventArgs e)
        {
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            // Recupera el objeto de la fila actual
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            // Pasa como parámetro la URL a la función CargarImagen
            CargarImagen(seleccionado.UrlImagen);
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

        private void button1_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado=(Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            frmModificar ventana = new frmModificar();
            ventana.Show();
        }

        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
