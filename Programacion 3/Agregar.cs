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
    public partial class frmAgregar : Form
    {
        public frmAgregar()
        {
            InitializeComponent();
            //Fondo para la app
            Bitmap img = new Bitmap(Application.StartupPath + @"/Fondo/backgrounds.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;   //para que sea ajustable en tamaño
        }

        private void btnAgregado_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            ArticulosNegocio negocio= new ArticulosNegocio();

            try
            {
                articulo.Nombre = txtNombre.Text;
                articulo.Codigo= txtCodigo.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Marca=(Marca)cboMarca.SelectedItem;   
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;
                articulo.Precio=int.Parse(txtPrecio.Text);
                articulo.UrlImagen=txtImagen.Text;
                negocio.agregar(articulo);
                MessageBox.Show("AGREGADO CORRECTAMENTE");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                
            }
        }

        private void lblAgregarArt_Click(object sender, EventArgs e)
        {

        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmAgregar_Load(object sender, EventArgs e)
        {
            MarcasNegocio marcaNegocio = new MarcasNegocio();
            CategoriasNegocio categoriaNegocio = new CategoriasNegocio();
            try
            {
                cboMarca.DataSource = marcaNegocio.listar();
                cboCategoria.DataSource = categoriaNegocio.listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
