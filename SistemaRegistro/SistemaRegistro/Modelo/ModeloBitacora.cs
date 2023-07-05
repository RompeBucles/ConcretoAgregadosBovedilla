using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRegistro.Modelo
{
    public class modeloBitacora
    {
        public int id { get; set; }
        public string operacion { get; set; }
        public DateTime fecha { get; set; }
        public string descripcionEvento { get; set; }
        public string usuario { get; set; }


    }
}
