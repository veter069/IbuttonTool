using System;
using System.Windows.Forms;
using IbuttonTool.Properties;
using SerialPortUsing;

namespace IbuttonTool
{
	public partial class UIDReadingForm : Form
	{
		private UIDCOMDialog _dialog;
		public string ResultingUID;
		public UIDReadingForm(){
			InitializeComponent();
		}

		private void ReceivingHandler(object sender, string uid, bool enterExit)
		{
			_dialog.Close();
			ReturnUID(uid);
		}

		private delegate void CloseCallBack(string uid);
		private void ReturnUID(string uid)
		{
			if (this.InvokeRequired)
			{
				CloseCallBack cb = ReturnUID;
				Invoke(cb, uid);
			}
			else
			{
				this.DialogResult = DialogResult.OK;
				ResultingUID = uid;
				Close();
			}
		}

		private void b_cancel_Click(object sender, EventArgs e)
		{
			_dialog.Close();
			DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void UIDReadingForm_Load(object sender, EventArgs e)
		{
			try
			{
				_dialog = new UIDCOMDialog(Settings.Default.COMName, Settings.Default.BaudRate, 8, ReceivingHandler);
			}
			catch (Exception)
			{
				DialogResult = DialogResult.Cancel;
				this.Close();
			}
		}
	}
}
