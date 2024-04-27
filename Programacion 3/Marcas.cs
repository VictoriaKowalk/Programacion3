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

        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmMarcas_Load(object sender, EventArgs e)
        {
            MarcasNegocio marcas = new MarcasNegocio();
            listaMarcas = marcas.listar();
            dgvMarcas.DataSource = listaMarcas;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarMarca agregarMarca = new AgregarMarca();
            agregarMarca.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

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
                    DialogResult respuesta = MessageBox.Show("¿Eliminar el registro " + seleccionado.Nombre + "?", "Eliminar marca", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        if (negocio.TieneProductosAsociados(seleccionado) != false)
                        {
                            MessageBox.Show("No se puede borrar esta marca, tiene un producto asociado");
                        }
                        else
                        {
                            negocio.eliminar(seleccionado.IDMarca);
                            MessageBox.Show("Se ha eliminado la marca.");
                        }
                        //cargar();
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
