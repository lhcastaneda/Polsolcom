using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polsolcom.Dominio.Modelos
{
    public class Consultorio
    {
        public string Id { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public string Turno { get; set; }
        public string Tipo { get; set; }
        public string Observacion { get; set; }
        public string Us_Ing { get; set; }
        public string Fec_Ing { get; set; }
        public string Us_Mod { get; set; }
        public string Fec_Mod { get; set; }
    }
}
