using System;
using System.ComponentModel;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Simple_Bot
{
	public partial class frmClient : Form
	{
		private void Button_SaveConfig_Click(object sender, EventArgs e)
		{
			if (_bot != null)
			{
				SaveFileDialog_setting.InitialDirectory = MyProject.Application.Info.DirectoryPath + "\\Setting\\";
				SaveFileDialog_setting.FileName = TBId.Text;
				SaveFileDialog_setting.ShowDialog();
			}
		}

		private void SaveFileDialog_setting_FileOk(object sender, CancelEventArgs e)
		{
			if (_bot != null)
			{
				string fileName = SaveFileDialog_setting.FileName;
				_bot.SaveConfig(fileName);
			}
		}

	}
}
