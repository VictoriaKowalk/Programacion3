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
                datos.setConsulta("SELECT A.Id, Codigo, Nombre, A.Descripcion AS Descripcion, M.Descripcion AS Marca, C.Descripcion AS Categoria, I.ImagenUrl, Precio,M.Id AS IDMarca,C.Id  AS IDCategoria FROM ARTICULOS A, MARCAS M, CATEGORIAS C, IMAGENES I WHERE M.Id = A.IdMarca AND C.Id = A.IdCategoria AND I.IdArticulo=A.Id and I.IdArticulo=A.Id");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                   
                    aux.IDArticulo = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    aux.Imagenes = new Imagenes();

                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                        aux.Imagenes.ImagenUrl = (string)datos.Lector["ImagenUrl"];

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
                string consulta = "INSERT INTO ARTICULOS (Id, Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio, IDMarca, IDCategoria) VALUES (@Id, @Codigo, @Nombre, @Descripcion, @IDMarca, @IDCategoria, @ImagenUrl, @Precio, @IDMarca, @IDCategoria);";

                datos.setConsulta(consulta);

                // Establecer parámetros
                datos.setParametros("@Id", nuevo.IDArticulo);
                datos.setParametros("@Codigo", nuevo.Codigo);
                datos.setParametros("@Nombre", nuevo.Nombre);
                datos.setParametros("@Descripcion", nuevo.Descripcion);
                datos.setParametros("@Precio", nuevo.Precio);
                datos.setParametros("@IDMarca", nuevo.Marca.IDMarca);
                datos.setParametros("@IDCategoria", nuevo.Categoria.IDCategoria);
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


        public void modificar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setConsulta("update ARTICULOS SET Codigo=@codigo,Nombre=@nombre,Descripcion=@Descripcion,IdMarca=@IdMarca,IdCategoria=@IdCategoria,ImagenUrl=@Imagen,Precio=@Precio Where Id=@id");
              
                datos.setParametros("@codigo", articulo.Codigo);
                datos.setParametros("@nombre", articulo.Nombre);
                datos.setParametros("@descripcion", articulo.Descripcion);
                datos.setParametros("@idMarca", articulo.Marca.IDMarca);
                datos.setParametros("@idCategoria", articulo.Categoria.IDCategoria);
                datos.setParametros("@Imagen", articulo.Imagenes.ImagenUrl);
                datos.setParametros("@precio", articulo.Precio);
                datos.setParametros("@Id", articulo.IDArticulo);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}

