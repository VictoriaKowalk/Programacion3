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

namespace Programacion_3
{
    public partial class frmListado : Form
    {
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

        private void lbxArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            pbxLista.ImageLocation = "C:\\Users\\kowal\\Desktop\\UTN\\2024\\Programacion\\Actividad 2\\Repositorio\\Programacion3\\Programacion 3\\imagenes" + lbxArticulos.Text + ".png";
        }
    }
}
