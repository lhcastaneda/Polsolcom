using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polsolcom.Dominio.Modelos
{
    public class Ticket
    {
        public string Serie { get; set; }
        public string Nro_Ticket { get; set; }
        public DateTime Consultorio { get; set; }
        public string TipoDeColegiaturas { get; set; }
        public string NroDeColegiatura { get; set; }
        public string RNE { get; set; }
        public bool Estado { get; set; }
        public string Especialidad { get; set; }
        public string Descripcion { get; set; }
    }
        
}
