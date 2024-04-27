using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;


namespace Dominio
{
    public class Imagenes
    {
        public int IDImagenes { get; set; }
        public int IDArticulo { get; set; }
        public string ImagenUrl { get; set; }

        public Imagenes()
        {
            IDArticulo = 0;
            ImagenUrl = "";
        }
    }
}
