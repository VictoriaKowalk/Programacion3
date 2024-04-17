using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_3
{
    internal class Marca
    {
        public int _idMarca { get; set; }
        public string _nombreMarca { get; set; }
        public override string ToString()
        {
            return _nombreMarca;
        }
    }
}
