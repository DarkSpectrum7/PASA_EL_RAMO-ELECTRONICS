using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Empresa
    {
        private int id;
        private int id_empresa;
        private string rut;
        private string giro;
        private string ciudad;
        private string comuna;
        private string direccion;
        private int telefono;
        private string email;
        private string referencia;

        public Empresa()
        {

        }
        public int Id { get => id; set => id = value; }
        public int Id_empresa { get => id_empresa; set => id_empresa = value; }
        public string Rut { get => rut; set => rut = value; }
        public string Giro { get => giro; set => giro = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string Comuna { get => comuna; set => comuna = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
        public string Referencia { get => referencia; set => referencia = value; }
    }
}
