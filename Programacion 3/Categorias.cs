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
    public partial class frmCategorias : Form

    {
        private List<Categoria> listaCategoria;
        public frmCategorias()
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

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvMarcas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            CategoriasNegocio categoria = new CategoriasNegocio();
            listaCategoria = categoria.listar();
            dgvMarcas.DataSource = listaCategoria;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AgregarCategoria agregarCategoria = new AgregarCategoria();
            agregarCategoria.ShowDialog();
        }
    }
}
