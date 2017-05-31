using System.Windows.Forms;
using System.Diagnostics;
using Polsolcom.Forms;

namespace Polsolcom.Properties
{					 
    internal sealed partial class Settings
	{		           
        public Settings()
		{

		}
        
        private void SettingChangingEventHandler(object sender, System.Configuration.SettingChangingEventArgs e)
		{

        }
        
        private void SettingsSavingEventHandler(object sender, System.ComponentModel.CancelEventArgs e)
		{
            //comentario
        }

		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault( false );
			Process[] process = Process.GetProcessesByName(Application.ProductName);
			//Prevent multiple instance
			if( process.Length > 1 )
			{
				MessageBox.Show( "{Application Name} ya esta en ejecucion. Esta instancia se cerrara.", "{Application Name}",
				MessageBoxButtons.OK, MessageBoxIcon.Information );
				Application.Exit();
			}
			else
			{
				Application.Run( new frmLogin() );
			}
		}

	}
}
