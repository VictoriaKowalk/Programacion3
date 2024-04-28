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
    public partial class frmMarcas : Form
    {
        private List<Marca> listaMarcas;
        public frmMarcas()
        {
            InitializeComponent();
            //Fondo para la app
            Bitmap img = new Bitmap(Application.StartupPath + @"/Fondo/backgrounds.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;   //para que sea ajustable en tamaño
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMarcas_Load(object sender, EventArgs e)
        {
            cargar();
        }


        private void cargar()
        {
            MarcasNegocio marcas = new MarcasNegocio();
            listaMarcas = marcas.listar();
            dgvMarcas.DataSource = listaMarcas;
            dgvMarcas.Columns["IDMarca"].HeaderText = "ID";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarMarca agregarMarca = new AgregarMarca();
            agregarMarca.ShowDialog();
            cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvMarcas.CurrentRow != null)
            {
                MarcasNegocio negocio = new MarcasNegocio();
                Marca seleccionado;
                try
                {
                    seleccionado = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
                    if (negocio.TieneProductosAsociados(seleccionado) == true)
                    {
                        MessageBox.Show("No es posible borrar esta marca ya que tiene productos asociados.");
                    } 
                    else
                    {
                        DialogResult respuesta = MessageBox.Show("¿Eliminar la marca " + seleccionado.Nombre + "?", "Eliminar marca", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (respuesta == DialogResult.Yes)
                        {
                            negocio.eliminar(seleccionado.IDMarca);
                            MessageBox.Show("Se ha eliminado la marca.");
                            cargar();
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar la marca a eliminar.");
            }
        }
    }
}
