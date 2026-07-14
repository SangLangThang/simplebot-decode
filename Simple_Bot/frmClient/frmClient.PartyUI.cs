using System;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Simple_Bot
{
	public partial class frmClient : Form
	{
		private void Button_RequestParty_Click(object sender, EventArgs e)
		{
			if (_bot != null && _bot.logined == 1)
			{
				int num = Conversions.ToInteger(TextBox_IdLeader.Text);
				_bot.MemRequestPartyto(num);
			}
		}

		private void Button_InviteParty_Click(object sender, EventArgs e)
		{
			if (_bot != null && _bot.logined == 1)
			{
				int num = Conversions.ToInteger(TextBox_IdLeader.Text);
				_bot.LeaderInvitePartyto(num);
			}
		}

		private void Button_OutParty_Click(object sender, EventArgs e)
		{
			if (_bot != null && _bot.logined == 1)
			{
				_bot.OutParty();
			}
		}

	}
}
