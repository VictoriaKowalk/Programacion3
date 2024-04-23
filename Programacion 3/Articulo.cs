﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_3
{
    internal class Articulo
    {
        public static Image Imagen { get; internal set; }
        public int IDArticulo { get; set; }
        [DisplayName("Codigo ")]
        public string Codigo { get; set; }
        [DisplayName("Descripcion")]
        public string Descripcion { get; set; }

        [DisplayName("Nombre")]
        public string Nombre { get; set; }

        public string UrlImagen { get; set; }

        [DisplayName("Precio")]
        public decimal Precio { get; set; }

        [DisplayName("Marca")]
        public Marca Marca { get; set; }

        [DisplayName("Categoria")]
        public Categoria Categoria { get; set; }
    }
}