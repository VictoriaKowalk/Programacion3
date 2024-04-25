using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Programacion_3
{
    internal class ArticulosNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=(LocalDb)\\MSSQLLocalDB; database=CATALOGO_P3_DB; integrated security=true";
                //conexion.ConnectionString = "Data Source=DESKTOP-LPCCPED\\SQLEXPRESS;Initial Catalog=CATALOGO_P3_DB;Integrated Security=True";
                comando.CommandText = "SELECT A.Id, Codigo, Nombre, A.Descripcion AS Descripcion, M.Descripcion AS Marca, C.Descripcion AS Categoria,\r\nI.ImagenUrl, Precio,M.Id,C.Id \r\nFROM ARTICULOS A, MARCAS M, CATEGORIAS C, IMAGENES I WHERE M.Id = A.IdMarca AND C.Id = A.IdCategoria AND I.IdArticulo=A.Id";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.IDArticulo = lector.GetInt32(0);
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    // Esto será necesario??
                    if (!(lector["ImagenUrl"] is DBNull))
                        aux.UrlImagen = (string)lector["ImagenUrl"];

                    aux.Marca = new Marca();
                    aux.Marca.Nombre = (string)lector["Marca"];
                    aux.Marca.IDMarca = (int)lector["Id"];

                    aux.Categoria = new Categoria();
                    aux.Categoria.Nombre = (string)lector["Categoria"];
                    aux.Categoria.IDCategoria = (int)lector["Id"];

                    aux.Precio = (decimal)lector["Precio"];

                    lista.Add(aux);

                }

                return lista;

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public void agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConsulta(" insert into ARTICULOS(Codigo,Nombre,Descripcion,IdMarca, IdCategoria, Precio) Values ('" + nuevo.Codigo + "','" + nuevo.Nombre + "' ,'" + nuevo.Descripcion + "'," + nuevo.Marca + "," + nuevo.Categoria + "," + nuevo.Precio + ")\r\n");

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

