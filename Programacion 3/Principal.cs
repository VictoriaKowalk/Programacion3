using Programacion_3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPractico
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            cboMarcas.Items.Add("Apple");
            cboMarcas.Items.Add("Huawei");
            cboMarcas.Items.Add("Motorola");
            cboMarcas.Items.Add("Samsung");
            cboMarcas.Items.Add("Sony");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void artículosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listarArtículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListado ventana = new frmListado();
            ventana.Show();
        }

        private void agregarArtículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregar ventana = new frmAgregar();
            ventana.Show();
        }

        private void modificarArtículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModificar ventana = new frmModificar();
            ventana.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmModificar ventana = new frmModificar();
            ventana.Show();
        }

        private void administrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMarcas ventana = new frmMarcas();
            ventana.Show();
        }

        private void administrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCategorias ventana = new frmCategorias();
            ventana.Show();
        }
    }
}
