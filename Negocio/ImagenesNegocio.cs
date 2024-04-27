using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public  class ImagenesNegocio
    {

        List<Imagenes> listar()
        {
            List<Imagenes> lista= new List<Imagenes>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setConsulta("select Id,Idarticulo,ImagenUrl from IMAGENES");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Imagenes aux = new Imagenes();
                    aux.IDImagenes = (int)datos.Lector["Id"];
                    aux.IDArticulo = (int)datos.Lector["IdArticulo"];
                    aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];

                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
