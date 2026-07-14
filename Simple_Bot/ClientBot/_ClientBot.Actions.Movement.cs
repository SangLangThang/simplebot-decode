using System;
using Microsoft.VisualBasic.CompilerServices;

namespace Simple_Bot
{
	public partial class _ClientBot
	{
		public void ClickNPCId(int id)
		{
			NpcOnMap.Key_NpcOnMap key = new NpcOnMap.Key_NpcOnMap
			{
				_Idmap = Data_Player._MapId,
				_id = id
			};
			if (NpcOnMap.Data_NpcOnMap.ContainsKey(key))
			{
				_npctalking = NpcOnMap.Data_NpcOnMap[key]._Name;
			}
			string text = API.bytestohexstring(new byte[2]
			{
				API.hexstringtobyte(id.ToString("X4"))[1],
				API.hexstringtobyte(id.ToString("X4"))[0]
			});
			byte[] packet = API.hexstringtobyte("F44404001401" + text);
			SendPacket(packet);
		}

		public void ChoiceId(int id)
		{
			id = checked(id + 29);
			byte[] packet = API.hexstringtobyte("F44403001409" + id.ToString("X2"));
			SendPacket(packet);
		}

		public void Walk(int x, int y)
		{
			string text = API.bytestohexstring(new byte[2]
			{
				API.hexstringtobyte(x.ToString("X4"))[1],
				API.hexstringtobyte(x.ToString("X4"))[0]
			});
			string text2 = API.bytestohexstring(new byte[2]
			{
				API.hexstringtobyte(y.ToString("X4"))[1],
				API.hexstringtobyte(y.ToString("X4"))[0]
			});
			byte[] packet = API.hexstringtobyte("F4440900060105" + text + text2 + "47EB");
			SendPacket(packet);
			Data_Player._MapX = x;
			Data_Player._MapY = y;
		}

		public void Warp(int id)
		{
			byte[] packet = API.hexstringtobyte("F44404001408" + id.ToString("X2") + "00");
			SendPacket(packet);
		}

		public void Pickup(int id)
		{
			byte[] packet = API.hexstringtobyte("F44404001702" + API.Int32ToHex2(id));
			SendPacket(packet);
		}

		public void DropItem(int _slot, int _count)
		{
			byte[] packet = API.hexstringtobyte("F44404001703" + _slot.ToString("X2") + _count.ToString("X2"));
			SendPacket(packet);
		}

		public void DropGold(int _count)
		{
			byte[] packet = API.hexstringtobyte("F44406001710" + API.Int32ToHex4(_count));
			SendPacket(packet);
		}

		public void ContributeItem(int _slot)
		{
			byte[] packet = API.hexstringtobyte("F4440700270F00000000" + _slot.ToString("X2"));
			SendPacket(packet);
		}

		public void SendItem(int _IdBDY, int _IdPlayer, int _slot, int _count)
		{
			int num = 0;
			if (_list_BDY.Contains(Data_PetsInfo[1]._Id))
			{
				num = 1;
			}
			if (_list_BDY.Contains(Data_PetsInfo[2]._Id))
			{
				num = 1;
			}
			if (_list_BDY.Contains(Data_PetsInfo[3]._Id))
			{
				num = 1;
			}
			if (_list_BDY.Contains(Data_PetsInfo[4]._Id))
			{
				num = 1;
			}
			switch (num)
			{
			case 0:
				Label_BDY = "Không có BDY để gửi";
				break;
			case 1:
			{
				_stt_send = _slot;
				Label_BDY = "Đang gửi Ba Đậu Yêu";
				byte[] packet = API.hexstringtobyte("F44414001914" + API.Int32ToHex4(_IdBDY) + API.Int32ToHex4(_IdPlayer) + _slot.ToString("X2") + _count.ToString("X2") + "0000000000000000");
				SendPacket(packet);
				ProgressBarEx_BDY = 0;
				break;
			}
			}
		}

		public void Moveitem(int _slot1, int _count, int _slot2)
		{
			byte[] packet = API.hexstringtobyte("F4440500170A" + _slot1.ToString("X2") + _count.ToString("X2") + _slot2.ToString("X2"));
			SendPacket(packet);
		}

		public void SellItem(int _slot, int _count)
		{
			byte[] packet = API.hexstringtobyte("F44404001B02" + _slot.ToString("X2") + _count.ToString("X2"));
			SendPacket(packet);
		}

		public string GetLocation(string i)
		{
			string result = "0002";
			switch (FnvHash.Compute(i))
			{
			case 873244444u:
				if (Operators.CompareString(i, "1", false) == 0)
				{
					result = "0000";
				}
				break;
			case 923577301u:
				if (Operators.CompareString(i, "2", false) == 0)
				{
					result = "0001";
				}
				break;
			case 906799682u:
				if (Operators.CompareString(i, "3", false) == 0)
				{
					result = "0002";
				}
				break;
			case 822911587u:
				if (Operators.CompareString(i, "4", false) == 0)
				{
					result = "0003";
				}
				break;
			case 806133968u:
				if (Operators.CompareString(i, "5", false) == 0)
				{
					result = "0004";
				}
				break;
			case 856466825u:
				if (Operators.CompareString(i, "6", false) == 0)
				{
					result = "0100";
				}
				break;
			case 839689206u:
				if (Operators.CompareString(i, "7", false) == 0)
				{
					result = "0101";
				}
				break;
			case 1024243015u:
				if (Operators.CompareString(i, "8", false) == 0)
				{
					result = "0102";
				}
				break;
			case 1007465396u:
				if (Operators.CompareString(i, "9", false) == 0)
				{
					result = "0103";
				}
				break;
			case 468396612u:
				if (Operators.CompareString(i, "10", false) == 0)
				{
					result = "0104";
				}
				break;
			case 485174231u:
				if (Operators.CompareString(i, "11", false) == 0)
				{
					result = "0200";
				}
				break;
			case 501951850u:
				if (Operators.CompareString(i, "12", false) == 0)
				{
					result = "0201";
				}
				break;
			case 518729469u:
				if (Operators.CompareString(i, "13", false) == 0)
				{
					result = "0202";
				}
				break;
			case 401286136u:
				if (Operators.CompareString(i, "14", false) == 0)
				{
					result = "0203";
				}
				break;
			case 418063755u:
				if (Operators.CompareString(i, "15", false) == 0)
				{
					result = "0204";
				}
				break;
			case 434841374u:
				if (Operators.CompareString(i, "16", false) == 0)
				{
					result = "0300";
				}
				break;
			case 451618993u:
				if (Operators.CompareString(i, "17", false) == 0)
				{
					result = "0301";
				}
				break;
			case 334175660u:
				if (Operators.CompareString(i, "18", false) == 0)
				{
					result = "0302";
				}
				break;
			case 350953279u:
				if (Operators.CompareString(i, "19", false) == 0)
				{
					result = "0303";
				}
				break;
			case 2381486463u:
				if (Operators.CompareString(i, "20", false) == 0)
				{
					result = "0304";
				}
				break;
			}
			return result;
		}

		public int GetLocation2(string i)
		{
			int result = 1;
			switch (FnvHash.Compute(i))
			{
			case 3052262101u:
				if (Operators.CompareString(i, "0000", false) == 0)
				{
					result = 1;
				}
				break;
			case 3035484482u:
				if (Operators.CompareString(i, "0001", false) == 0)
				{
					result = 2;
				}
				break;
			case 3018706863u:
				if (Operators.CompareString(i, "0002", false) == 0)
				{
					result = 3;
				}
				break;
			case 3001929244u:
				if (Operators.CompareString(i, "0003", false) == 0)
				{
					result = 4;
				}
				break;
			case 2985151625u:
				if (Operators.CompareString(i, "0004", false) == 0)
				{
					result = 5;
				}
				break;
			case 3591938314u:
				if (Operators.CompareString(i, "0100", false) == 0)
				{
					result = 6;
				}
				break;
			case 3608715933u:
				if (Operators.CompareString(i, "0101", false) == 0)
				{
					result = 7;
				}
				break;
			case 3558383076u:
				if (Operators.CompareString(i, "0102", false) == 0)
				{
					result = 8;
				}
				break;
			case 3575160695u:
				if (Operators.CompareString(i, "0103", false) == 0)
				{
					result = 9;
				}
				break;
			case 3524827838u:
				if (Operators.CompareString(i, "0104", false) == 0)
				{
					result = 10;
				}
				break;
			case 1468087007u:
				if (Operators.CompareString(i, "0200", false) == 0)
				{
					result = 11;
				}
				break;
			case 1451309388u:
				if (Operators.CompareString(i, "0201", false) == 0)
				{
					result = 12;
				}
				break;
			case 1501642245u:
				if (Operators.CompareString(i, "0202", false) == 0)
				{
					result = 13;
				}
				break;
			case 1484864626u:
				if (Operators.CompareString(i, "0203", false) == 0)
				{
					result = 14;
				}
				break;
			case 1400976531u:
				if (Operators.CompareString(i, "0204", false) == 0)
				{
					result = 15;
				}
				break;
			case 4176086804u:
				if (Operators.CompareString(i, "0300", false) == 0)
				{
					result = 16;
				}
				break;
			case 4192864423u:
				if (Operators.CompareString(i, "0301", false) == 0)
				{
					result = 17;
				}
				break;
			case 4209642042u:
				if (Operators.CompareString(i, "0302", false) == 0)
				{
					result = 18;
				}
				break;
			case 4226419661u:
				if (Operators.CompareString(i, "0303", false) == 0)
				{
					result = 19;
				}
				break;
			case 4108976328u:
				if (Operators.CompareString(i, "0304", false) == 0)
				{
					result = 20;
				}
				break;
			}
			return result;
		}

		public void CharacterAttack(int idskill, string location)
		{
			if (Data_Player._Sp < GetSkillSP(idskill))
			{
				idskill = 10000;
			}
			string text = API.Int32ToHex2(idskill);
			string text2 = "0002";
			checked
			{
				if (Operators.CompareString(location, "Lần lượt", false) != 0)
				{
					if (Operators.CompareString(location, "F1", false) == 0)
					{
						int num = 1;
						do
						{
							if (Data_Battles[num]._Hp > 0)
							{
								if (num < 10)
								{
									text2 = GetLocation(num.ToString());
									int num2 = num + 1;
									for (int i = num2; i <= 10; i++)
									{
										if (Data_Battles[i]._Hp > 0)
										{
											text2 = GetLocation(i.ToString());
											break;
										}
									}
								}
								else
								{
									text2 = "0104";
								}
								break;
							}
							num++;
						}
						while (num <= 10);
					}
					else
					{
						text2 = GetLocation(location);
					}
				}
				else
				{
					int num3 = 1;
					do
					{
						if (Data_Battles[num3]._Hp > 0)
						{
							text2 = GetLocation(num3.ToString());
							break;
						}
						num3++;
					}
					while (num3 <= 10);
				}
				SendPacket(API.hexstringtobyte("F4440A00320103" + Char_col.ToString("X2") + text2 + text + "0F16"));
				SendPacket(API.hexstringtobyte("F4440A00320103" + Char_col.ToString("X2") + text2 + text + "0F16"));
			}
		}

		public void PetAttack(int idskill, string location)
		{
			if (Data_PetInfo._Sp < GetSkillSP(idskill))
			{
				idskill = 10000;
			}
			string text = API.Int32ToHex2(idskill);
			string text2 = "0002";
			checked
			{
				if (Operators.CompareString(location, "Lần lượt", false) != 0)
				{
					if (Operators.CompareString(location, "F1", false) == 0)
					{
						int num = 1;
						do
						{
							if (Data_Battles[num]._Hp > 0)
							{
								if (num < 10)
								{
									text2 = GetLocation(num.ToString());
									int num2 = num + 1;
									for (int i = num2; i <= 10; i++)
									{
										if (Data_Battles[i]._Hp > 0)
										{
											text2 = GetLocation(i.ToString());
											break;
										}
									}
								}
								else
								{
									text2 = "0104";
								}
								break;
							}
							num++;
						}
						while (num <= 10);
					}
					else
					{
						text2 = GetLocation(location);
					}
				}
				else
				{
					int num3 = 1;
					do
					{
						if (Data_Battles[num3]._Hp > 0)
						{
							text2 = GetLocation(num3.ToString());
							break;
						}
						num3++;
					}
					while (num3 <= 10);
				}
				SendPacket(API.hexstringtobyte("F4440A00320102" + Char_col.ToString("X2") + text2 + text + "0F16"));
				SendPacket(API.hexstringtobyte("F4440A00320102" + Char_col.ToString("X2") + text2 + text + "0F16"));
			}
		}

	}
}
