using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Detalle
    {
        private int id;
        private int id_det;
        private Producto id_prod;
        private string cantidad;
        private Documento id_doc;


        public Detalle()
        {

        }

        public int Id { get => id; set => id = value; }
        public int Id_det { get => id_det; set => id_det = value; }
        public Producto Id_prod { get => id_prod; set => id_prod = value; }
        public string Cantidad { get => cantidad; set => cantidad = value; }
        public Documento Id_doc { get => id_doc; set => id_doc = value; }
    }

}
