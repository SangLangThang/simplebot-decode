using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Simple_Bot
{
	public partial class frmClient : Form
	{
		private void MenuItem_TuideoAction_Click(object sender, EventArgs e)
		{
			if (!((_Tuideo_slot_select < 1) | (_Tuideo_slot_select > 25)))
			{
				_Data._Tuideo tuideo = _bot.Data_Tuideo[_Tuideo_slot_select];
				int num = tuideo._Id;
				if (num > 0)
				{
					int stt = tuideo._Stt;
					_bot.SendPacket(API.hexstringtobyte("F44403001725" + stt.ToString("X2")));
				}
			}
		}

		private void MenuItem_TuideoAddDrop_Click(object sender, EventArgs e)
		{
			if (!((_Tuideo_slot_select < 1) | (_Tuideo_slot_select > 25)))
			{
				int num = _bot.Data_Tuideo[_Tuideo_slot_select]._Id;
				if (((num > 0) & Items.Data_Items.ContainsKey(num)) && !_bot.Data_ListDrop.Contains(num))
				{
					_bot.Data_ListDrop.Add(num);
					ListView_AutoDrop.Items.Add(Conversions.ToString(num)).SubItems.Add(GetItemName(num));
				}
			}
		}

		private void MenuItem_TuideoAddContribute_Click(object sender, EventArgs e)
		{
			if (!((_Tuideo_slot_select < 1) | (_Tuideo_slot_select > 25)))
			{
				int num = _bot.Data_Tuideo[_Tuideo_slot_select]._Id;
				if (((num > 0) & Items.Data_Items.ContainsKey(num)) && !_bot.Data_ListContribute.Contains(num))
				{
					_bot.Data_ListContribute.Add(num);
					ListView_AutoContribute.Items.Add(Conversions.ToString(num)).SubItems.Add(GetItemName(num));
				}
			}
		}

		private void MenuItem_TuideoAddSend_Click(object sender, EventArgs e)
		{
			if (!((_Tuideo_slot_select < 1) | (_Tuideo_slot_select > 25)))
			{
				int num = _bot.Data_Tuideo[_Tuideo_slot_select]._Id;
				if (((num > 0) & Items.Data_Items.ContainsKey(num)) && !_bot.Data_ListSend.Contains(num))
				{
					_bot.Data_ListSend.Add(num);
					ListView_AutoSend.Items.Add(Conversions.ToString(num)).SubItems.Add(GetItemName(num));
				}
			}
		}

		private void MenuItem_TuideoAddSell_Click(object sender, EventArgs e)
		{
			if (!((_Tuideo_slot_select < 1) | (_Tuideo_slot_select > 25)))
			{
				int num = _bot.Data_Tuideo[_Tuideo_slot_select]._Id;
				if (((num > 0) & Items.Data_Items.ContainsKey(num)) && !_bot.Data_ListSell.Contains(num))
				{
					_bot.Data_ListSell.Add(num);
					ListView_AutoSell.Items.Add(Conversions.ToString(num)).SubItems.Add(GetItemName(num));
				}
			}
		}

		private void MenuItem_SendToBDYPet_Click(object sender, EventArgs e)
		{
			if (((_Homdo_slot_select < 1) | (_Homdo_slot_select > 25)) || _bot == null || _bot.logined != 1 || _Homdo_slot_select <= 0)
			{
				return;
			}
			try
			{
				int num = Conversions.ToInteger(ToolStripTextBox_SendBDY_Id.Text);
				if (num > 0)
				{
					int idBDY = 0;
					int num2 = 1;
					do
					{
						if (_bot._list_BDY.Contains(_bot.Data_PetsInfo[num2]._Id))
						{
							idBDY = _bot.Data_PetsInfo[num2]._Id;
							break;
						}
						num2 = checked(num2 + 1);
					}
					while (num2 <= 4);
					_Data._Tuido tuido = _bot.Data_Tuido[_Homdo_slot_select];
					int stt = tuido._Stt;
					int num3 = tuido._Id;
					int count = tuido._Sl;
					if (num3 > 0)
					{
						_bot.SendItem(idBDY, num, stt, count);
					}
				}
				else
				{
					API.AddColorText(rtbsystem, "Nhân vật hiện không có !!! Không thể gửi đồ.", Color.Black);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

		private void MenuItem_HomdoAction_Click(object sender, EventArgs e)
		{
			if (!((_Homdo_slot_select < 1) | (_Homdo_slot_select > 25)))
			{
				_Data._Tuido tuido = _bot.Data_Tuido[_Homdo_slot_select];
				int num = tuido._Id;
				if (num > 0)
				{
					int stt = tuido._Stt;
					_bot.SendPacket(API.hexstringtobyte("F44403001724" + stt.ToString("X2")));
				}
			}
		}

		private void MenuItem_HomdoAddDrop_Click(object sender, EventArgs e)
		{
			if (!((_Homdo_slot_select < 1) | (_Homdo_slot_select > 25)))
			{
				int num = _bot.Data_Tuido[_Homdo_slot_select]._Id;
				if (((num > 0) & Items.Data_Items.ContainsKey(num)) && !_bot.Data_ListDrop.Contains(num))
				{
					_bot.Data_ListDrop.Add(num);
					ListView_AutoDrop.Items.Add(Conversions.ToString(num)).SubItems.Add(GetItemName(num));
				}
			}
		}

		private void MenuItem_HomdoAddContribute_Click(object sender, EventArgs e)
		{
			if (!((_Homdo_slot_select < 1) | (_Homdo_slot_select > 25)))
			{
				int num = _bot.Data_Tuido[_Homdo_slot_select]._Id;
				if (((num > 0) & Items.Data_Items.ContainsKey(num)) && !_bot.Data_ListContribute.Contains(num))
				{
					_bot.Data_ListContribute.Add(num);
					ListView_AutoContribute.Items.Add(Conversions.ToString(num)).SubItems.Add(GetItemName(num));
				}
			}
		}

		private void MenuItem_HomdoAddSend_Click(object sender, EventArgs e)
		{
			if (!((_Homdo_slot_select < 1) | (_Homdo_slot_select > 25)))
			{
				int num = _bot.Data_Tuido[_Homdo_slot_select]._Id;
				if (((num > 0) & Items.Data_Items.ContainsKey(num)) && !_bot.Data_ListSend.Contains(num))
				{
					_bot.Data_ListSend.Add(num);
					ListView_AutoSend.Items.Add(Conversions.ToString(num)).SubItems.Add(GetItemName(num));
				}
			}
		}

		private void MenuItem_HomdoAddSell_Click(object sender, EventArgs e)
		{
			if (!((_Homdo_slot_select < 1) | (_Homdo_slot_select > 25)))
			{
				int num = _bot.Data_Tuido[_Homdo_slot_select]._Id;
				if (((num > 0) & Items.Data_Items.ContainsKey(num)) && !_bot.Data_ListSell.Contains(num))
				{
					_bot.Data_ListSell.Add(num);
					ListView_AutoSell.Items.Add(Conversions.ToString(num)).SubItems.Add(GetItemName(num));
				}
			}
		}

		private void MenuItem_CharEquip_Click(object sender, EventArgs e)
		{
			if ((_Homdo_slot_select < 1) | (_Homdo_slot_select > 25))
			{
				return;
			}
			_Data._Tuido tuido = _bot.Data_Tuido[_Homdo_slot_select];
			if (!Items.Data_Items.ContainsKey(tuido._Id))
			{
				return;
			}
			if (Items.Data_Items[tuido._Id]._Loai == 0)
			{
				if (tuido._Sl > 1)
				{
					int count = 1;
					try
					{
						count = Conversions.ToInteger(Interaction.InputBox("Nhập số lượng."));
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ProjectData.ClearProjectError();
					}
					_bot.CharEquit(tuido._Stt, count);
				}
				else
				{
					_bot.CharEquit(tuido._Stt, 1);
				}
			}
			else
			{
				_bot.CharEquit(tuido._Stt, 1);
			}
		}

		private void MenuItem_PetEquip_Click(object sender, EventArgs e)
		{
			if ((_Homdo_slot_select < 1) | (_Homdo_slot_select > 25))
			{
				return;
			}
			_Data._Tuido tuido = _bot.Data_Tuido[_Homdo_slot_select];
			if (!Items.Data_Items.ContainsKey(tuido._Id))
			{
				return;
			}
			if (Items.Data_Items[tuido._Id]._Loai == 0)
			{
				if (tuido._Sl > 1)
				{
					int count = 1;
					try
					{
						count = Conversions.ToInteger(Interaction.InputBox("Nhập số lượng."));
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ProjectData.ClearProjectError();
					}
					_bot.PetEquit_bySlot(tuido._Stt, count, _petSelect);
				}
				else
				{
					_bot.PetEquit_bySlot(tuido._Stt, 1, _petSelect);
				}
			}
			else
			{
				_bot.PetEquit_bySlot(tuido._Stt, 1, _petSelect);
			}
		}

		private void PictureBox_CharStat_MouseClick(object sender, MouseEventArgs e)
		{
			switch (e.Button)
			{
			case MouseButtons.Left:
			{
				int num2 = 1;
				object left2 = NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null);
				if (Operators.ConditionalCompareObjectEqual(left2, PictureBox_char_add_int.Name, false))
				{
					if (_bot.Data_Player._Point > 0)
					{
						byte[] packet7 = API.hexstringtobyte("F4440A00080100001B" + num2.ToString("X2") + "00000000");
						_bot.SendPacket(packet7);
					}
				}
				else if (Operators.ConditionalCompareObjectEqual(left2, PictureBox_char_add_atk.Name, false))
				{
					if (_bot.Data_Player._Point > 0)
					{
						byte[] packet8 = API.hexstringtobyte("F4440A00080100001C" + num2.ToString("X2") + "00000000");
						_bot.SendPacket(packet8);
					}
				}
				else if (Operators.ConditionalCompareObjectEqual(left2, PictureBox_char_add_def.Name, false))
				{
					if (_bot.Data_Player._Point > 0)
					{
						byte[] packet9 = API.hexstringtobyte("F4440A00080100001D" + num2.ToString("X2") + "00000000");
						_bot.SendPacket(packet9);
					}
				}
				else if (Operators.ConditionalCompareObjectEqual(left2, PictureBox_char_add_hpx.Name, false))
				{
					if (_bot.Data_Player._Point > 0)
					{
						byte[] packet10 = API.hexstringtobyte("F4440A00080100001F" + num2.ToString("X2") + "00000000");
						_bot.SendPacket(packet10);
					}
				}
				else if (Operators.ConditionalCompareObjectEqual(left2, PictureBox_char_add_spx.Name, false))
				{
					if (_bot.Data_Player._Point > 0)
					{
						byte[] packet11 = API.hexstringtobyte("F4440A000801000020" + num2.ToString("X2") + "00000000");
						_bot.SendPacket(packet11);
					}
				}
				else if (Operators.ConditionalCompareObjectEqual(left2, PictureBox_char_add_agi.Name, false) && _bot.Data_Player._Point > 0)
				{
					byte[] packet12 = API.hexstringtobyte("F4440A00080100001E" + num2.ToString("X2") + "00000000");
					_bot.SendPacket(packet12);
				}
				break;
			}
			case MouseButtons.Right:
				try
				{
					int num = Conversions.ToInteger(Interaction.InputBox("Nhập số point."));
					object left = NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null);
					if (Operators.ConditionalCompareObjectEqual(left, PictureBox_char_add_int.Name, false))
					{
						if (_bot.Data_Player._Point > 0)
						{
							byte[] packet = API.hexstringtobyte("F4440A00080100001B" + num.ToString("X2") + "00000000");
							_bot.SendPacket(packet);
						}
					}
					else if (Operators.ConditionalCompareObjectEqual(left, PictureBox_char_add_atk.Name, false))
					{
						if (_bot.Data_Player._Point > 0)
						{
							byte[] packet2 = API.hexstringtobyte("F4440A00080100001C" + num.ToString("X2") + "00000000");
							_bot.SendPacket(packet2);
						}
					}
					else if (Operators.ConditionalCompareObjectEqual(left, PictureBox_char_add_def.Name, false))
					{
						if (_bot.Data_Player._Point > 0)
						{
							byte[] packet3 = API.hexstringtobyte("F4440A00080100001D" + num.ToString("X2") + "00000000");
							_bot.SendPacket(packet3);
						}
					}
					else if (Operators.ConditionalCompareObjectEqual(left, PictureBox_char_add_hpx.Name, false))
					{
						if (_bot.Data_Player._Point > 0)
						{
							byte[] packet4 = API.hexstringtobyte("F4440A00080100001F" + num.ToString("X2") + "00000000");
							_bot.SendPacket(packet4);
						}
					}
					else if (Operators.ConditionalCompareObjectEqual(left, PictureBox_char_add_spx.Name, false))
					{
						if (_bot.Data_Player._Point > 0)
						{
							byte[] packet5 = API.hexstringtobyte("F4440A000801000020" + num.ToString("X2") + "00000000");
							_bot.SendPacket(packet5);
						}
					}
					else if (Operators.ConditionalCompareObjectEqual(left, PictureBox_char_add_agi.Name, false) && _bot.Data_Player._Point > 0)
					{
						byte[] packet6 = API.hexstringtobyte("F4440A00080100001E" + num.ToString("X2") + "00000000");
						_bot.SendPacket(packet6);
					}
					break;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
					break;
				}
			}
		}

		private void MenuItem_HomdoDrop_Click(object sender, EventArgs e)
		{
			if ((_Homdo_slot_select < 1) | (_Homdo_slot_select > 25))
			{
				return;
			}
			try
			{
				int num = 1;
				_Data._Tuido tuido = _bot.Data_Tuido[_Homdo_slot_select];
				if (tuido._Sl > 1)
				{
					num = Conversions.ToInteger(Interaction.InputBox("Nhập số lượng."));
				}
				if ((num > 0) & (tuido._Sl > 0))
				{
					if (num > tuido._Sl)
					{
						_bot.DropItem(tuido._Stt, tuido._Sl);
					}
					else
					{
						_bot.DropItem(tuido._Stt, num);
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}

		private void MenuItem_HomdoContribute_Click(object sender, EventArgs e)
		{
			if (!((_Homdo_slot_select < 1) | (_Homdo_slot_select > 25)))
			{
				_Data._Tuido tuido = _bot.Data_Tuido[_Homdo_slot_select];
				if (tuido._Id > 0)
				{
					_bot.ContributeItem(tuido._Stt);
				}
			}
		}

		private void NoOpClickHandler(object sender, EventArgs e)
		{
		}

		private void Button_AutoSort_Click(object sender, EventArgs e)
		{
			if (_bot.logined == 1)
			{
				_bot.AutoSort_Tuido();
			}
		}
	}
}
