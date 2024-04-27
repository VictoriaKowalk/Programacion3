using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Negocio
{
    public class MarcasNegocio
    {
        public List<Marca> listar()
        {
            List<Marca> lista = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setConsulta("SELECT ID, DESCRIPCION FROM MARCAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.IDMarca = (int)datos.Lector["Id"];
                    aux.Nombre = (string)datos.Lector["Descripcion"];

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

        public void agregar(Marca nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConsulta("insert into MARCAS(Descripcion) Values ('" + nuevo.Nombre+ "')");
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

        public void eliminar(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setConsulta("DELETE FROM Marcas WHERE ID=@id");
                datos.setParametros("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool TieneProductosAsociados(Marca marca)
        {
            bool tieneProductos = false;

            // Conexión a la base de datos
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-LPCCPED\\SQLEXPRESS;Initial Catalog=CATALOGO_P3_DB;Integrated Security=True"))
            {
                // Consulta SQL para contar los productos asociados a la marca
                string query = "SELECT CASE WHEN EXISTS (\r\n    SELECT 1\r\n    FROM ARTICULOS AS a\r\n    INNER JOIN MARCAS AS m ON a.IdMarca = m.Id\r\n    WHERE m.Id = @IdMarca\r\n) THEN 1 ELSE 0 END AS TieneProductosAsociados;\r\n";

                // Crear y configurar el comando SQL
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Establecer el parámetro de la marca seleccionada
                    command.Parameters.AddWithValue("@IDMarca", marca.IDMarca);

                    // Abrir la conexión
                    connection.Open();

                    // Ejecutar la consulta y obtener el resultado
                    object result = command.ExecuteScalar();

                    // Verificar si hay productos asociados
                    if (result != null && result != DBNull.Value)
                    {
                        int count = Convert.ToInt32(result);
                        tieneProductos = (count > 0);
                    }
                }
            }

            return tieneProductos;
        }
    }
}
