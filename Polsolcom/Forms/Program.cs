using System.Threading.Tasks;
using System.Windows.Forms;
using Polsolcom.Forms;
using Polsolcom.Forms.Procesos;

namespace Polsolcom
{
    static class Program
    {

		[System.STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Para efectos de prueba lo primero que cargaremos ser el formulario con el que estemos trabajando
            //Application.Run(new frmLogin());
            //Application.Run(new frmLogin());

            Application.Run(new frmLogin());

        }
    }
}
