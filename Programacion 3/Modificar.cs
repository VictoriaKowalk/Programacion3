using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Programacion_3
{
    public partial class frmModificar : Form
    {
        public frmModificar()
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

        private void frmModificar_Load(object sender, EventArgs e)
        {
            CategoriasNegocio categorias = new CategoriasNegocio();
            MarcasNegocio marcas = new MarcasNegocio();

            try
            {
                cboCategoria.DataSource = categorias.listar();
                cboMarca.DataSource = marcas.listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
