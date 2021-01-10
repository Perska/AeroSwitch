using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AeroSwitch
{
	public partial class AeroSwitch : Form
	{
		public AeroSwitch()
		{
			InitializeComponent();
		}

		[DllImport("dwmapi.dll", EntryPoint = "DwmEnableComposition")]
		protected extern static uint DwmEnableComposition(uint uCompositionAction);
		public bool ControlAero(bool enable)
		{
			try
			{
				DwmEnableComposition((uint)(enable ? 1 : 0));
				AeroMode = enable;
				return true;
			}
			catch
			{
				return false;
			}
		}

		bool AeroMode = true;

		private void ToggleAero()
		{
			if (ControlAero(!AeroMode))
			{

			}
			else
			{
				MessageBox.Show("Could not toggle Aero!", "AeroSwitcher", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			Show();
			WindowState = FormWindowState.Normal;
		}

		private void toggleAero_Click(object sender, EventArgs e)
		{
			ToggleAero();
		}

		private void toggleAeroToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ToggleAero();
		}

		private void showWindowToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Show();
			WindowState = FormWindowState.Normal;
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void AeroSwitch_Resize(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Minimized)
			{
				Hide();
			}
		}

		private void AeroSwitch_Load(object sender, EventArgs e)
		{
			Resize += AeroSwitch_Resize;
		}
	}
}
