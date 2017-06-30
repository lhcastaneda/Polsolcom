using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polsolcom.Dominio.Helpers
{
    public class Serie
    {
        public string leyenda;
        public Color color;

        public Serie(string leyenda, Color color)
        {
            this.leyenda = leyenda;
            this.color = color;
        }

    }
}
