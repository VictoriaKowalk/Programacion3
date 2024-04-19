using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_3
{
    internal class Articulos
    {
        public static Image Imagen { get; internal set; }
        public int _idArticulo { get; set; }
        [DisplayName("Codigo ")]
        public string _CodigoArticulo { get; set; }
        [DisplayName("Descripcion")]
        public string _descripArticulo { get; set; }

        [DisplayName("Nombre")]
        public string _nombre { get; set; }

        public string UrlImagen { get; set; }

        [DisplayName("Precio")]
        public decimal _precio { get; set; }

        [DisplayName("Marca")]
        public Marca DescripcionMarca { get; set; }

        [DisplayName("Categoria")]
        public Categoria DescripcionCategoria { get; set; }
    }
}
