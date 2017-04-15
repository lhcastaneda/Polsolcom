using System.Threading.Tasks;
using System.Windows.Forms;
using Polsolcom.Forms;

namespace Polsolcom
{
    static class Program
    {

		[System.STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new frmLogin());
                                    
        }
    }
}
