using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Polsolcom.Forms;

namespace Polsolcom.Dominio.Helpers
{
	public class WaitWindow
	{
		public static object Show( EventHandler<WaitWindowEventArgs> workerMethod )
		{
			return WaitWindow.Show(workerMethod, null);
		}
		
		public static object Show( EventHandler<WaitWindowEventArgs> workerMethod, string message )
		{
			WaitWindow instance = new WaitWindow();
			return instance.Show(workerMethod, message, new List<object>());
		}
		
		public static object Show( EventHandler<WaitWindowEventArgs> workerMethod, string message, params object[] args )
		{
			List<object> arguments = new List<object>();
			arguments.AddRange(args);

			WaitWindow instance = new WaitWindow();
			return instance.Show(workerMethod, message, arguments);
		}

		private WaitWindow() { }

		private frmWait _GUI;
		internal delegate void MethodInvoker<T>( T parameter1 );
		internal EventHandler<WaitWindowEventArgs> _WorkerMethod;
		internal List<object> _Args;

		public string Message
		{
			set
			{
				this._GUI.Invoke(new MethodInvoker<string>(this._GUI.SetMessage), value);
			}
		}

		public void Cancel()
		{
			this._GUI.Invoke(new MethodInvoker(this._GUI.Cancel), null);
		}

		private object Show( EventHandler<WaitWindowEventArgs> workerMethod, string message, List<object> args )
		{
			//	Validate Parameters
			if ( workerMethod == null )
			{
				throw new ArgumentException("No worker method has been specified.", "workerMethod");
			}
			else
			{
				this._WorkerMethod = workerMethod;
			}

			this._Args = args;

			if ( string.IsNullOrEmpty(message) )
			{
				message = "Por favor espere mientras se procesa la operacion...";
			}

			this._GUI = new frmWait(this);
			this._GUI.MessageLabel.Text = message;

			this._GUI.ShowDialog();

			object result = this._GUI._Result;

			Exception _Error = this._GUI._Error;
			this._GUI.Dispose();

			if ( _Error != null )
				throw _Error;
			else
				return result;
		}
	}

	public class WaitWindowEventArgs : EventArgs
	{
		public WaitWindowEventArgs( WaitWindow GUI, List<object> args ) : base()
		{
			this._Window = GUI;
			this._Arguments = args;
		}

		private WaitWindow _Window;
		private List<object> _Arguments;
		private object _Result;

		public WaitWindow Window
		{
			get { return _Window; }
		}

		public List<object> Arguments
		{
			get { return _Arguments; }
		}

		public object Result
		{
			get { return _Result; }
			set { _Result = value; }
		}
	}


}
