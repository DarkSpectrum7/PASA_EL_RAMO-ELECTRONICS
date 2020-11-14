using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Producto
    {
        private int id;
        private int id_prod;
        private string nombre_prod;
        private int precio_uni;

        public Producto()
        {

        }
        public int Id { get => id; set => id = value; }
        public int Id_prod { get => id_prod; set => id_prod = value; }
        public string Nombre_prod { get => nombre_prod; set => nombre_prod = value; }
        public int Precio_uni { get => precio_uni; set => precio_uni = value; }
    }
}
