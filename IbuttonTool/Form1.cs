using System.IO;
using System.IO.Ports;
using System.Windows.Forms;

namespace IbuttonTool
{
	public partial class Form1 : Form
	{
		private HardListHolder NewList = new HardListHolder("keys.txt");
		public Form1()
		{
			InitializeComponent();
			int b = 8;
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			lB_UID_List.Items.AddRange(NewList.GetArray());
			foreach (string port in SerialPort.GetPortNames())
			{
				ms_settings_com.DropDownItems.Add(port);
			}
			foreach (ToolStripMenuItem msi in ms_settings_com.DropDownItems)
			{
				msi.CheckOnClick = true;
				msi.Click += msi_comN_Click;
			}
		}
		private void msi_comN_Click(object sender, System.EventArgs e){
			foreach (ToolStripMenuItem msi in ms_settings_com.DropDownItems){
				if (msi != sender)
				{
					msi.Checked = false;
				}
			}
		}

		private void b_Read_Click(object sender, System.EventArgs e)
		{
			UIDReadingForm form = new UIDReadingForm();
			DialogResult rez = form.ShowDialog();
			if(rez == DialogResult.OK)
				mtb_uid.Text = form.ResultingUID;
		}
	}
}
