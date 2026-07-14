using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Simple_Bot
{
	public partial class frmClient : Form
	{
		private void PictureBox_CharEquit_MouseClick_Unequip(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				int slot = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Tag", new object[0], null, null, null));
				_bot.CharRemoveEquit(slot);
			}
		}

		private void PictureBox_PetEquit_MouseClick_Unequip(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				int slotitem = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Tag", new object[0], null, null, null));
				_bot.PetRemoveEquit(_petSelect, slotitem);
			}
		}

		private void PictureBox_CharEquit_MouseMove(object sender, MouseEventArgs e)
		{
		}

		private void PictureBox_PetEquit_MouseMove(object sender, MouseEventArgs e)
		{
		}

	}
}
