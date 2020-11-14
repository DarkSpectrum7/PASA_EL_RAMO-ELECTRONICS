using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;

namespace CapaPersistencia
{
    public class DAODetalle
    {
        public bool registarDetalle(Detalle detalle)
        {
            ConexionBD conexionBD = new ConexionBD();

            try
            {
                string queryInsert = "INSERT INTO detalle VALUE ('" + detalle.Id + "','" 
                    + detalle.Id_det + "','" +
                    detalle.Id_prod + "','" +
                    detalle.Cantidad + "'," +
                    detalle.Id_doc +"');"; //-------------consultar

                conexionBD.abrirConexion();
                SqlCommand cmd = new SqlCommand(queryInsert,conexionBD.Conexion);

                int aux = cmd.ExecuteNonQuery();

                if (aux > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                conexionBD.cerrarConexion();
            }
        }
        public bool modificarDetalle(Detalle detalle)
        {
            return true;
        }
        public List<Detalle>listarDetalle()
        {
            return null;
        }
    }
}
