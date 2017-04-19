using System;
using System.Windows.Forms;
using Polsolcom.Clases;

namespace Polsolcom.Forms
{
	internal partial class frmWait : Form
	{
		public frmWait(WaitWindow parent)
		{
			InitializeComponent();
			this._Parent = parent;
			this.Top = Screen.PrimaryScreen.WorkingArea.Top + 32;
			this.Left = Screen.PrimaryScreen.WorkingArea.Right - this.Width - 32;
		}

		private WaitWindow _Parent;
		private delegate T FunctionInvoker<T>();
    	internal object _Result;
    	internal Exception _Error;
    	private IAsyncResult threadResult;
    	
		protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
		{
			base.OnPaint(e);
			ControlPaint.DrawBorder3D(e.Graphics, this.ClientRectangle, Border3DStyle.Raised);
		}

		protected override void OnShown(EventArgs e)
		{
			base.OnShown(e);
			FunctionInvoker<object> threadController = new FunctionInvoker<object>(this.DoWork);
			this.threadResult = threadController.BeginInvoke(this.WorkComplete, threadController);
    	}
		
		internal object DoWork()
		{
			WaitWindowEventArgs e = new WaitWindowEventArgs(this._Parent, this._Parent._Args);
			if ((this._Parent._WorkerMethod != null))
				this._Parent._WorkerMethod(this, e);

			return e.Result;
		}

    	private void WorkComplete(IAsyncResult results)
		{
    		if (!this.IsDisposed)
			{
	    		if (this.InvokeRequired)
	    			this.Invoke(new WaitWindow.MethodInvoker<IAsyncResult>(this.WorkComplete), results);
				else 
				{
	    			try 
					{
						this._Result = ((FunctionInvoker<object>)results.AsyncState).EndInvoke(results);
	    			} 
					catch (Exception ex) 
					{
						this._Error = ex;
	    			}
					this.Close();
	    		}
    		}
    	}
		
		internal void SetMessage(string message)
		{
			this.MessageLabel.Text = message;
		}
    	
    	internal void Cancel()
		{
    		this.Invoke(new MethodInvoker(this.Close), null);
    	}
	}
}
