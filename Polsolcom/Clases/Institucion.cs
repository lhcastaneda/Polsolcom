using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polsolcom.Clases
{
    public class Institucion
    {
        public int Id { get; set; }
        public string Nom_Raz_Soc { get; set; }
        public string RUC { get; set; }
        public string Direccion { get; set; }
        public string Id_Distrito { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Id_Represent { get; set; }
        public string Representante { get; set; }
        public string Id_Cargo { get; set; }
        public string Mod_Trans { get; set; }
        public string Email { get; set; }
        public string Observacion { get; set; }
        public string Estado { get; set; }
        public DateTime Fec_Ing { get; set; }
        public string Us_Ing { get; set; }
        public DateTime Fec_Mod { get; set; }
        public string Us_Mod { get; set; }
    }
}
