using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRegistro.Modelo
{
    public class modeloEntrdasSalidas
    {
        public int id { get; set; }
        public int id_producto { get; set; }
        public string nombreFlujo { get; set; }
        public string tipoFlujo { get; set; }
        public string recursos { get; set; }
        public string? emisiones { get; set; }
        public string valor { get; set; }
        public string unidad { get; set; }
        public string tratamientoDato { get; set; }
        public string adquisicionDato { get; set; }
        public string? citaReferencia { get; set; }
        public string? comentario { get; set; }
    }
}
