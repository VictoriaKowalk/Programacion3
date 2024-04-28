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
    public partial class frmImagenes : Form
    {
        private List<Imagen> listaImagenes;
        public frmImagenes()
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

        private void dgvImagenes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmImagenes_Load(object sender, EventArgs e)
        {
            cargar();
        }
        private void CargarImagen(string imagen)
        {
            try
            {
                pbxImagenes.Load(imagen);
            }
            catch (Exception)
            {
                pbxImagenes.Load("https://media.istockphoto.com/id/1409329028/vector/no-picture-available-placeholder-thumbnail-icon-illustration-design.jpg?s=612x612&w=0&k=20&c=_zOuJu755g2eEUioiOUdz_mHKJQJn-tDgIAhQzyeKUQ=");
            }
        }
        private void cargar()
        {
            ImagenesNegocio imagenes = new ImagenesNegocio();
            listaImagenes = imagenes.listar();
            dgvImagenes.DataSource = listaImagenes;
            dgvImagenes.Columns["IDImagen"].Visible = false;
            dgvImagenes.Columns["IDArticulo"].HeaderText = "ID de artículo asociado";
            dgvImagenes.Columns["ImagenURL"].HeaderText = "Enlace";
            if(listaImagenes.Count() > 0)
            {
                CargarImagen(listaImagenes[0].ImagenUrl);
            }
        }

        private void dgvImagenes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvImagenes.CurrentRow != null)
            {
                Imagen seleccionado = (Imagen)dgvImagenes.CurrentRow.DataBoundItem;
                CargarImagen(seleccionado.ImagenUrl);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvImagenes.CurrentRow != null)
            {
                ImagenesNegocio negocio = new ImagenesNegocio();
                Imagen seleccionado;
                try
                {
                    seleccionado = (Imagen)dgvImagenes.CurrentRow.DataBoundItem;
                    string mensaje = "¿Eliminar la imagen?";
                    if (seleccionado.ImagenUrl != "")
                    {
                        if (negocio.TieneProductosAsociados(seleccionado) == true)
                        {
                            mensaje = "Esta imagen tiene productos asociados, ¿está seguro que desea eliminarla?";
                        }
                        DialogResult respuesta = MessageBox.Show(mensaje, "Eliminar imagen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (respuesta == DialogResult.Yes)
                        {
                            negocio.eliminar(seleccionado.IDImagen);
                            MessageBox.Show("Se ha eliminado la imagen.");
                            cargar();
                        }
                    } else
                    {
                        negocio.eliminar(seleccionado.IDImagen);
                        MessageBox.Show("Se ha eliminado la imagen.");
                        cargar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar la imagen a eliminar.");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarImagen ventana = new AgregarImagen();
            ventana.ShowDialog();
            cargar();
        }
    }
}
