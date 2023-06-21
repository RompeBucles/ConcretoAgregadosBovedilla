using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRegistro.Modelo
{
    public class modeloIngresoDatos
    {
        public int id { get; set; }
        public string producto { get; set; }
        public string nombreProceso { get; set; }
        public string tipoProcesos { get; set;}
        public string autor { get; set; }
        public string correo { get; set; }
        public string nombreFlujoR { get; set; }
       
    }
}
