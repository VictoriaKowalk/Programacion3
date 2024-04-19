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
    public partial class Principal : Form
    {
        public Principal()
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
            Listado ventana = new Listado();
            ventana.Show();
        }

        private void agregarArtículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agregar ventana = new Agregar();
            ventana.Show();
        }

        private void modificarArtículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modificar ventana = new Modificar();
            ventana.Show();
        }
    }
}
