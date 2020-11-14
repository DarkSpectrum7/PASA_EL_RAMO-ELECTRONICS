using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Documento
    {
        private int id;
        private int id_doc;
        private Empresa id_empresa;
        private Detalle id_det;
        private int total_neto;
        private int total_iva;
        private int total_bruto;
        private int anulada;
        private int emitida;
        private DateTime fecha;


        public Documento()
        {

        }

        public int Id { get => id; set => id = value; }
        public int Id_doc { get => id_doc; set => id_doc = value; }
        public Empresa Id_empresa { get => id_empresa; set => id_empresa = value; }
        public Detalle Id_det { get => id_det; set => id_det = value; }
        public int Total_neto { get => total_neto; set => total_neto = value; }
        public int Total_iva { get => total_iva; set => total_iva = value; }
        public int Total_bruto { get => total_bruto; set => total_bruto = value; }
        public int Anulada { get => anulada; set => anulada = value; }
        public int Emitida { get => emitida; set => emitida = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
    }
}
