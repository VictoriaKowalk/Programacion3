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
    public partial class Listado : Form
    {
        public Listado()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar ventana = new Agregar();
            ventana.Show();
        }

        private void lblCatagolo_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Close();
            Principal ventana = new Principal();
            ventana.Show();
        }
    }
}
