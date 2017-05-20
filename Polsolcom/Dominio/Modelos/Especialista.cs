using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polsolcom.Dominio.Modelos
{
    public class Especialista
    {
        public string Id_Esp { get; set; }
        public string FullName { get; set; }
        public string Consultorio { get; set; }
        public string Bus { get; set; }
        public string Id_Bus { get; set; }
        public string CMP { get; set; }
        public int Estado { get; set; }
        public string Obs { get; set; }
        public string Us_Ing { get; set; }
        public DateTime Fec_Ing { get; set; }
        public string Us_Mod { get; set; }
        public DateTime Fec_Mod { get; set; }
        public string Idmb { get; set; }

        private bool _valorEstado;

        public bool ValorEstado
        {
            get { return _valorEstado; }
            set { _valorEstado = (Estado == 1) ? true : false; }
        }

    }
        
}
