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

        public void agregarImagen(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                // Insertar en IMAGENES
                string consulta = "INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@IdArticulo, @ImagenUrl);";
                datos.setConsulta(consulta);

                // Establecer parámetros para la imagen
                datos.setParametros("@IdArticulo", nuevo.IDArticulo);
                datos.setParametros("@ImagenUrl", nuevo.Imagenes.ImagenUrl);
                datos.ejecutarAccion();
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

        public void actualizarImagen(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                // Insertar en IMAGENES
                string consulta = "UPDATE imagenes SET ImagenUrl=@ImagenUrl WHERE IDARTICULO=@IdArticulo;";
                datos.setConsulta(consulta);

                // Establecer parámetros para la imagen
                datos.setParametros("@IdArticulo", nuevo.IDArticulo);
                datos.setParametros("@ImagenUrl", nuevo.Imagenes.ImagenUrl);
                datos.ejecutarAccion();
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
