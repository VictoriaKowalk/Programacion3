using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_3
{
    internal class Categoria
    {
        public int IDCategoria { get; set; }
        public string Nombre { get; set; }
        public override string ToString()
        {
            return Nombre;
        }

    }
}
