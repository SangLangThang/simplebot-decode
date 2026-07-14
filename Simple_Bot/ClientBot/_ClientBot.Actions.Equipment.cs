using System;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Simple_Bot
{
	public partial class _ClientBot
	{
		public void OpenMachineBox()
		{
			if (logined == 1)
			{
				int textBox_OpenMachine_CharHp = TextBox_OpenMachine_CharHp;
				int textBox_OpenMachine_CharSp = TextBox_OpenMachine_CharSp;
				int textBox_OpenMachine_PetHp = TextBox_OpenMachine_PetHp;
				int textBox_OpenMachine_PetSp = TextBox_OpenMachine_PetSp;
				SendPacket(API.hexstringtobyte("F4440A004101" + textBox_OpenMachine_CharHp.ToString("X2") + textBox_OpenMachine_CharSp.ToString("X2") + textBox_OpenMachine_PetHp.ToString("X2") + textBox_OpenMachine_PetSp.ToString("X2") + "00000000"));
			}
		}

		public void StopMachineBox()
		{
			if (logined == 1)
			{
				SendPacket(API.hexstringtobyte("F44402004102"));
			}
		}

		public void LenNgua()
		{
			try
			{
				if (logined != 1)
				{
					return;
				}
				int num = 1;
				do
				{
					int id = Data_PetsInfo[num]._Id;
					if (Npcs.Data_Npcs.ContainsKey(id) && Npcs.Data_Npcs[id]._Type == 9)
					{
						SendPacket(API.hexstringtobyte("F44406000F04" + API.Int32ToHex2(id) + "0000"));
						break;
					}
					num = checked(num + 1);
				}
				while (num <= 4);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

		public void XuongNgua()
		{
			SendPacket(API.hexstringtobyte("F44402000F05"));
		}

		public void ThanhLuuChar(int id)
		{
			SendPacket(API.hexstringtobyte("F4440B00171402FC2A0200" + API.Int32ToHex4(id)));
		}

		public void ThanhLuuPet()
		{
			SendPacket(API.hexstringtobyte("F4440B00171402FC2A04" + PetBattle.ToString("X2") + API.Int32ToHex4(Data_PetInfo._Id)));
		}

		public void CharEatHp()
		{
			if (Data_Player._HpMax <= 0 || checked((int)Math.Round(Conversion.Val((double)Data_Player._Hp / (double)Data_Player._HpMax * 100.0))) > TextBox_Eat_char_hp_value)
			{
				return;
			}
			foreach (_Data._Tuido value in Data_Tuido.Values)
			{
				if (value._Id > 0 && GetItemHp(value._Id) > 0)
				{
					SendPacket(API.hexstringtobyte("F4440600170F" + value._Stt.ToString("X2") + "010000"));
					break;
				}
			}
		}

		public void CharEatSp()
		{
			if (Data_Player._SpMax <= 0 || checked((int)Math.Round(Conversion.Val((double)Data_Player._Sp / (double)Data_Player._SpMax * 100.0))) > TextBox_Eat_char_sp_value)
			{
				return;
			}
			foreach (_Data._Tuido value in Data_Tuido.Values)
			{
				if (value._Id > 0 && GetItemSp(value._Id) > 0)
				{
					SendPacket(API.hexstringtobyte("F4440600170F" + value._Stt.ToString("X2") + "010000"));
					break;
				}
			}
		}

		public void PetEatHp()
		{
			if (Data_PetInfo._HpMax <= 0 || checked((int)Math.Round(Conversion.Val((double)Data_PetInfo._Hp / (double)Data_PetInfo._HpMax * 100.0))) > TextBox_Eat_Pet_hp_value)
			{
				return;
			}
			foreach (_Data._Tuido value in Data_Tuido.Values)
			{
				if (value._Id > 0 && GetItemHp(value._Id) > 0)
				{
					SendPacket(API.hexstringtobyte("F4440600170F" + value._Stt.ToString("X2") + "01" + PetBattle.ToString("X2") + "00"));
					break;
				}
			}
		}

		public void PetEatSp()
		{
			if (Data_PetInfo._SpMax <= 0 || checked((int)Math.Round(Conversion.Val((double)Data_PetInfo._Sp / (double)Data_PetInfo._SpMax * 100.0))) > TextBox_Eat_Pet_sp_value)
			{
				return;
			}
			foreach (_Data._Tuido value in Data_Tuido.Values)
			{
				if (value._Id > 0 && GetItemSp(value._Id) > 0)
				{
					SendPacket(API.hexstringtobyte("F4440600170F" + value._Stt.ToString("X2") + "01" + PetBattle.ToString("X2") + "00"));
					break;
				}
			}
		}

		public void CharEquit(int _slot, int _count)
		{
			SendPacket(API.hexstringtobyte("F4440300170B" + _slot.ToString("X2")));
			if (_count > Data_Tuido[_slot]._Sl)
			{
				SendPacket(API.hexstringtobyte("F4440600170F" + _slot.ToString("X2") + Data_Tuido[_slot]._Sl.ToString("X2") + "0000"));
			}
			else
			{
				SendPacket(API.hexstringtobyte("F4440600170F" + _slot.ToString("X2") + _count.ToString("X2") + "0000"));
			}
		}

		public void PetEquit(int _slot, int _count)
		{
			SendPacket(API.hexstringtobyte("F44404001711" + PetBattle.ToString("X2") + _slot.ToString("X2")));
			if (_count > Data_Tuido[_slot]._Sl)
			{
				SendPacket(API.hexstringtobyte("F4440600170F" + _slot.ToString("X2") + Data_Tuido[_slot]._Sl.ToString("X2") + PetBattle.ToString("X2") + "00"));
			}
			else
			{
				SendPacket(API.hexstringtobyte("F4440600170F" + _slot.ToString("X2") + _count.ToString("X2") + PetBattle.ToString("X2") + "00"));
			}
		}

		public void PetEquit_bySlot(int _slot, int _count, int _slotpet)
		{
			SendPacket(API.hexstringtobyte("F44404001711" + _slotpet.ToString("X2") + _slot.ToString("X2")));
			if (_count > Data_Tuido[_slot]._Sl)
			{
				SendPacket(API.hexstringtobyte("F4440600170F" + _slot.ToString("X2") + Data_Tuido[_slot]._Sl.ToString("X2") + _slotpet.ToString("X2") + "00"));
			}
			else
			{
				SendPacket(API.hexstringtobyte("F4440600170F" + _slot.ToString("X2") + _count.ToString("X2") + _slotpet.ToString("X2") + "00"));
			}
		}

		public void CharRemoveEquit(int _Slot)
		{
			foreach (_Data._Tuido value in Data_Tuido.Values)
			{
				if (value._Id == 0)
				{
					SendPacket(API.hexstringtobyte("F4440400170C" + checked(_Slot + 1).ToString("X2") + value._Stt.ToString("X2")));
					break;
				}
			}
		}

		public void PetRemoveEquit(int _sttpet, int _Slotitem)
		{
			foreach (_Data._Tuido value in Data_Tuido.Values)
			{
				if (value._Id == 0)
				{
					SendPacket(API.hexstringtobyte("F44405001712" + _sttpet.ToString("X2") + checked(_Slotitem + 1).ToString("X2") + value._Stt.ToString("X2")));
					break;
				}
			}
		}

	}
}
