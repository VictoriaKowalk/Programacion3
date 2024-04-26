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
                datos.setConsulta("SELECT A.Id, Codigo, Nombre, A.Descripcion AS Descripcion, M.Descripcion AS Marca, C.Descripcion AS Categoria, I.ImagenUrl, Precio,M.Id AS IDMarca,C.Id  AS IDCategoria FROM ARTICULOS A, MARCAS M, CATEGORIAS C, IMAGENES I WHERE M.Id = A.IdMarca AND C.Id = A.IdCategoria AND I.IdArticulo=A.Id");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                   
                    aux.IDArticulo = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                        aux.UrlImagen = (string)datos.Lector["ImagenUrl"];

                    aux.Marca = new Marca();
                    aux.Marca.Nombre = (string)datos.Lector["Marca"];
                    aux.Marca.IDMarca = (int)datos.Lector["IDMarca"];

                    aux.Categoria = new Categoria();
                    aux.Categoria.Nombre = (string)datos.Lector["Categoria"];
                    aux.Categoria.IDCategoria = (int)datos.Lector["IDCategoria"];

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
                datos.setConsulta("update ARTICULOS set Codigo = @codigo, Nombre = @nombre, Descripcion = @descripcion, IdMarca = @idMarca, IdCategoria = @idCategoria, Precio = @precio where Id = @id");
                datos.setParametros("@id", articulo.IDArticulo);
                datos.setParametros("@codigo", articulo.Codigo);
                datos.setParametros("@nombre", articulo.Nombre);
                datos.setParametros("@descripcion", articulo.Descripcion);
                datos.setParametros("@idMarca", articulo.Marca.IDMarca);
                datos.setParametros("@idCategoria", articulo.Categoria.IDCategoria);
                datos.setParametros("@precio", articulo.Precio);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}

