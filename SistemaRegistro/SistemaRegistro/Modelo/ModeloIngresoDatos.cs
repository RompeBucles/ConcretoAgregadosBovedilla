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
        public string tecnologia { get; set; }
        public string otro { get; set; }
        public string nombreProceso { get; set; }
        public string? tipoProceso { get; set; }
        public string autor { get; set; }
        public string correo { get; set; }
        public string nombreFlujoR { get; set; }
        public string unidad { get; set; }
        public string valorR { get; set; }
        public string? objetivo {get; set;}
        public string? limitesSistema { get; set; }
        public byte[]? imagen { get; set; }    
        public string tipoTecnologia { get; set; }
        public string? condicionesOperacion { get; set; }
        public string? fechaReferencia { get; set; }
        public string? datosValidos { get; set; }
        public string? descripcion { get; set; }
        public int id_estado {get; set;  }
        public int id_area {get; set;  }
        public string latitud { get; set;}
        public string longitud { get; set; }


       
    }
}
