using System;
using System.Collections.Generic;
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
                    detalle.Id_doc +"');";
            }
            catch (Exception)
            {

      
            }
            finally
            {

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
