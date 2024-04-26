using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Negocio
{
    public class ArticulosNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setConsulta("SELECT A.Id, Codigo, Nombre, A.Descripcion AS Descripcion, M.Descripcion AS Marca, C.Descripcion AS Categoria,\r\nI.ImagenUrl, Precio,M.Id,C.Id \r\nFROM ARTICULOS A, MARCAS M, CATEGORIAS C, IMAGENES I WHERE M.Id = A.IdMarca AND C.Id = A.IdCategoria AND I.IdArticulo=A.Id");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                   
                    aux.IDArticulo = datos.Lector.GetInt32(0);
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                        aux.UrlImagen = (string)datos.Lector["ImagenUrl"];

                    aux.Marca = new Marca();
                    aux.Marca.Nombre = (string)datos.Lector["Marca"];
                    aux.Marca.IDMarca = (int)datos.Lector["Id"];

                    aux.Categoria = new Categoria();
                    aux.Categoria.Nombre = (string)datos.Lector["Categoria"];
                    aux.Categoria.IDCategoria = (int)datos.Lector["Id"];

                    aux.Precio = (decimal)datos.Lector["Precio"];

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
        public void agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConsulta(" insert into ARTICULOS(Codigo,Nombre,Descripcion,IdMarca, IdCategoria, Precio) Values ('" + nuevo.Codigo + "','" + nuevo.Nombre + "' ,'" + nuevo.Descripcion + "'," + nuevo.Marca.IDMarca + "," + nuevo.Categoria.IDCategoria + "," + nuevo.Precio + ")");
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

        public void modificar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setConsulta("\r\nupdate ARTICULOS set Codigo = @codigo, Nombre = @nombre, Descripcion = @descripcion, IdCategoria = @idCategoria, IdMarca = @idMarca where Id = @id");
                datos.setParametros("@codigo", articulo.Codigo);
                datos.setParametros("@nombre", articulo.Nombre);
                datos.setParametros("@descripcion", articulo.Descripcion);
               
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}

