using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polsolcom.Dominio.Modelos
{
    public class Producto
    {
        public string Id { get; set; }
        public string Descripcion { get; set; }
        public double Monto { get; set; }
        public string Tipo { get; set; }
        public bool Estado { get; set; }
        public string TPEsp { get; set; }
    }
}
