using System;
using System.Collections;
using System.Drawing;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Simple_Bot
{
	public partial class _ClientBot
	{
		public void AutoThanhLuu()
		{
			string text = "";
			if (C_CheckBox_TL_mem1)
			{
				text = text + "F4440B00171402FC2A0200" + API.Int32ToHex4(TextBox_IDmem1);
			}
			if (C_CheckBox_TL_mem2)
			{
				text = text + "F4440B00171402FC2A0200" + API.Int32ToHex4(TextBox_IDmem2);
			}
			if (C_CheckBox_TL_mem3)
			{
				text = text + "F4440B00171402FC2A0200" + API.Int32ToHex4(TextBox_IDmem3);
			}
			if (C_CheckBox_TL_mem4)
			{
				text = text + "F4440B00171402FC2A0200" + API.Int32ToHex4(TextBox_IDmem4);
			}
			if (C_CheckBox_TL_pet1 && PetBattle > 0 && ((Conversion.Val((double)Data_PetInfo._Hp / (double)Data_PetInfo._HpMax * 100.0) < Conversion.Val(TextBox_TL_pet_hp_value)) | (Conversion.Val((double)Data_PetInfo._Sp / (double)Data_PetInfo._SpMax * 100.0) < Conversion.Val(TextBox_TL_pet_sp_value))))
			{
				text = text + "F4440B00171402FC2A04" + PetBattle.ToString("X2") + API.Int32ToHex4(Data_PetInfo._Id);
			}
			if (C_CheckBox_TL_pet2 && PetBattle > 0 && ((Conversion.Val((double)Data_PetInfo._Hp / (double)Data_PetInfo._HpMax * 100.0) < Conversion.Val(TextBox_TL_pet_hp_value)) | (Conversion.Val((double)Data_PetInfo._Sp / (double)Data_PetInfo._SpMax * 100.0) < Conversion.Val(TextBox_TL_pet_sp_value))))
			{
				text = text + "F4440B00171402FC2A04" + PetBattle.ToString("X2") + API.Int32ToHex4(Data_PetInfo._Id);
				text = text + "F4440B00171402FC2A04" + PetBattle.ToString("X2") + API.Int32ToHex4(Data_PetInfo._Id);
			}
			if (text.Length > 0)
			{
				SendPacket(API.hexstringtobyte(text));
			}
		}

		public void AutoDropContribute()
		{
			string text = "";
			foreach (_Data._Tuido value in Data_Tuido.Values)
			{
				int id = value._Id;
				int stt = value._Stt;
				int sl = value._Sl;
				if (!((id > 0) & Items.Data_Items.ContainsKey(id)))
				{
					continue;
				}
				Items.ItemInfo items = Items.Data_Items[id];
				if (Data_ListDrop.Contains(id))
				{
					text = text + "F44404001703" + stt.ToString("X2") + sl.ToString("X2");
				}
				if (sl != 0)
				{
					if (C_CheckBox_DropHp)
					{
						int hp = items._Hp;
						if ((hp > 0) & (hp < TextBox_Drop_HpValue))
						{
							text = text + "F44404001703" + stt.ToString("X2") + sl.ToString("X2");
						}
					}
					if (C_CheckBox_DropSp)
					{
						int sp = items._Sp;
						if ((sp > 0) & (sp < TextBox_Drop_SpValue))
						{
							text = text + "F44404001703" + stt.ToString("X2") + sl.ToString("X2");
						}
					}
					if (C_CheckBox_DropHpSp)
					{
						int hp2 = items._Hp;
						int sp2 = items._Sp;
						if (hp2 > 0 && sp2 > 0 && ((hp2 < TextBox_Drop_HpValue) & (sp2 < TextBox_Drop_SpValue)))
						{
							text = text + "F44404001703" + stt.ToString("X2") + sl.ToString("X2");
						}
					}
					if (C_CheckBox_DropMineWood)
					{
						int type_ = items._Type_2;
						if (type_ == 25 || (uint)(type_ - 40) <= 6u)
						{
							text = text + "F44404001703" + stt.ToString("X2") + sl.ToString("X2");
						}
					}
				}
				if (Data_ListContribute.Contains(id))
				{
					text = text + "F4440700270F00000000" + stt.ToString("X2");
				}
				if (sl == 0)
				{
					continue;
				}
				if (C_CheckBox_ContributeHp)
				{
					int hp3 = items._Hp;
					if ((hp3 > 0) & (hp3 < TextBox_Contribute_HpValue))
					{
						text = text + "F4440700270F00000000" + stt.ToString("X2");
					}
				}
				if (C_CheckBox_ContributeSp)
				{
					int sp3 = items._Sp;
					if ((sp3 > 0) & (sp3 < TextBox_Contribute_SpValue))
					{
						text = text + "F4440700270F00000000" + stt.ToString("X2");
					}
				}
				if (C_CheckBox_ContributeHpSp)
				{
					int hp4 = items._Hp;
					int sp4 = items._Sp;
					if (hp4 > 0 && sp4 > 0 && ((hp4 < TextBox_Contribute_HpValue) & (sp4 < TextBox_Contribute_SpValue)))
					{
						text = text + "F4440700270F00000000" + stt.ToString("X2");
					}
				}
				if (C_CheckBox_ContributeMineWood)
				{
					int type_2 = items._Type_2;
					if (type_2 == 25 || (uint)(type_2 - 40) <= 6u)
					{
						text = text + "F4440700270F00000000" + stt.ToString("X2");
					}
				}
			}
			if (checked(text.Length + packetAutoContribute.Length) > 0)
			{
				SendPacket(API.hexstringtobyte(text + packetAutoContribute));
			}
		}

		public void AutoSendItem()
		{
			if (ProgressBarEx_BDY > 0)
			{
				ProgressBarEx_BDY = 0;
			}
			int textBox_AutoSend = TextBox_AutoSend;
			if (textBox_AutoSend <= 0)
			{
				return;
			}
			foreach (_Data._Tuido value in Data_Tuido.Values)
			{
				int id = value._Id;
				int stt = value._Stt;
				int sl = value._Sl;
				int num = 0;
				int num2 = 1;
				do
				{
					if (_list_BDY.Contains(Data_PetsInfo[num2]._Id))
					{
						num = Data_PetsInfo[num2]._Id;
					}
					num2 = checked(num2 + 1);
				}
				while (num2 <= 4);
				if (!((id > 0 && num > 0) & Items.Data_Items.ContainsKey(id)))
				{
					continue;
				}
				Items.ItemInfo items = Items.Data_Items[id];
				switch (items._Trade)
				{
				case 11:
				case 13:
				case 14:
				case 15:
				case 29:
				case 30:
				case 31:
				case 63:
				case 65:
				case 75:
				case 77:
				case 79:
				case 91:
				case 93:
				case 95:
				case 111:
				case 119:
				case 123:
				case 127:
				case 143:
				case 159:
					continue;
				}
				if (Data_ListSend.Contains(id))
				{
					switch (items._Loai)
					{
					case 0:
						if (sl == 50)
						{
							SendItem(num, textBox_AutoSend, stt, sl);
							return;
						}
						break;
					case 1:
					case 2:
					case 3:
					case 4:
					case 5:
					case 6:
						SendItem(num, textBox_AutoSend, stt, sl);
						return;
					}
				}
				if (sl != 50)
				{
					continue;
				}
				if (C_CheckBox_SendHp)
				{
					int hp = items._Hp;
					if ((hp > 0) & (hp < TextBox_Send_HpValue))
					{
						SendItem(num, textBox_AutoSend, stt, sl);
						return;
					}
				}
				if (C_CheckBox_SendSp)
				{
					int sp = items._Sp;
					if ((sp > 0) & (sp < TextBox_Send_SpValue))
					{
						SendItem(num, textBox_AutoSend, stt, sl);
						return;
					}
				}
				if (C_CheckBox_SendHpSp)
				{
					int hp2 = items._Hp;
					int sp2 = items._Sp;
					if (hp2 > 0 && sp2 > 0 && ((hp2 < TextBox_Send_HpValue) & (sp2 < TextBox_Send_SpValue)))
					{
						SendItem(num, textBox_AutoSend, stt, sl);
						return;
					}
				}
				if (C_CheckBox_SendMineWood)
				{
					int type_ = items._Type_2;
					if (type_ == 25 || (uint)(type_ - 40) <= 6u)
					{
						SendItem(num, textBox_AutoSend, stt, sl);
						return;
					}
				}
			}
		}

		public void DC_FullHomdo()
		{
			int num = 0;
			foreach (_Data._Tuido value in Data_Tuido.Values)
			{
				if (value._Id == 0)
				{
					num = 1;
					break;
				}
			}
			if (num == 0)
			{
				API.AddColorText2(this, Rtbsystem, "Ngắt kết vì thiết lập đầy hòm!", Color.Red);
				_Disconnect();
			}
		}

		public void AutoSellItem()
		{
			foreach (_Data._Tuido value in Data_Tuido.Values)
			{
				int id = value._Id;
				int stt = value._Stt;
				int sl = value._Sl;
				if (id <= 0)
				{
					continue;
				}
				Thread.Sleep(200);
				if (!Items.Data_Items.ContainsKey(id))
				{
					continue;
				}
				Items.ItemInfo items = Items.Data_Items[id];
				if (items._Point <= 0)
				{
					continue;
				}
				int mapId = Data_Player._MapId;
				if (mapId != 12223)
				{
					continue;
				}
				if (C_CheckBox_SellHp)
				{
					int hp = items._Hp;
					if ((hp > 0) & (hp < TextBox_Sell_HpValue))
					{
						SellItem(stt, sl);
						API.AddColorText2(this, Rtbsystem, "Đã bán :" + Conversions.ToString(sl) + " " + value._Name, Color.DarkRed);
					}
				}
				if (C_CheckBox_SellSP)
				{
					int sp = items._Sp;
					if ((sp > 0) & (sp < TextBox_Sell_SpValue))
					{
						SellItem(stt, sl);
						API.AddColorText2(this, Rtbsystem, "Đã bán :" + Conversions.ToString(sl) + " " + value._Name, Color.DarkRed);
					}
				}
				if (C_CheckBox_SellHpSp)
				{
					int hp2 = items._Hp;
					int sp2 = items._Sp;
					if (hp2 > 0 && sp2 > 0 && ((hp2 < TextBox_Sell_HpValue) & (sp2 < TextBox_Sell_SpValue)))
					{
						SellItem(stt, sl);
						API.AddColorText2(this, Rtbsystem, "Đã bán : " + Conversions.ToString(sl) + " " + value._Name, Color.DarkRed);
					}
				}
				if (Data_ListSell.Contains(id))
				{
					SellItem(stt, sl);
					API.AddColorText2(this, Rtbsystem, "Đã bán :" + Conversions.ToString(sl) + " " + value._Name, Color.DarkRed);
				}
				if (C_CheckBox_SellMineWood)
				{
					int type_ = items._Type_2;
					if (type_ == 25 || (uint)(type_ - 40) <= 6u)
					{
						SellItem(stt, sl);
						API.AddColorText2(this, Rtbsystem, "Đã bán :" + Conversions.ToString(sl) + " " + value._Name, Color.DarkRed);
					}
				}
			}
		}

		public void replybot()
		{
			Thread.Sleep(checked((int)Math.Round(TextBox_DelayBot * 1000.0)));
			try
			{
				if (Operators.CompareString(API.ServerIp, "159.196.70.237", false) == 0)
				{
					SendPacket(API.hexstringtobyte("F444040014890000"));
				}
				ClickNPCId(99);
				StartBot();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				_Disconnect();
				ProjectData.ClearProjectError();
			}
		}

		public void StartBot()
		{
			if ((idmapbot == 0) | (idmapbot == Data_Player._MapId))
			{
				SendPacket(API.hexstringtobyte(packetbot));
			}
			else if (atw == 0)
			{
				atw = 1;
				AutoWarptoMap = idmapbot.ToString();
				AutoWarp(AutoWarptoMap);
			}
		}

		public void SendEnd()
		{
			SendPacket(API.hexstringtobyte("F44402001406"));
		}


		public int TuidoGetSlotConstainId50(int Id)
		{
			int result = 0;
			int num = 1;
			do
			{
				int id = Data_Tuido[num]._Id;
				int sl = Data_Tuido[num]._Sl;
				if (id == Id && sl < 50)
				{
					result = num;
					break;
				}
				num = checked(num + 1);
			}
			while (num <= 25);
			return result;
		}

		public int TuidoGetSlotNothing()
		{
			int result = 0;
			int num = 1;
			do
			{
				if (Data_Tuido[num]._Id == 0)
				{
					result = num;
					break;
				}
				num = checked(num + 1);
			}
			while (num <= 25);
			return result;
		}

		public void AutoSort_Tuido()
		{
			int count = Data_Tuido.Count;
			if (count <= 0)
			{
				return;
			}
			ArrayList arrayList = new ArrayList();
			ArrayList arrayList2 = new ArrayList();
			ArrayList arrayList3 = new ArrayList();
			ArrayList arrayList4 = new ArrayList();
			int num = 1;
			checked
			{
				do
				{
					switch (Data_Tuido[num]._Id)
					{
					case 23086:
						arrayList.Add(num);
						break;
					case 23087:
						arrayList2.Add(num);
						break;
					case 23088:
						arrayList3.Add(num);
						break;
					case 23089:
						arrayList4.Add(num);
						break;
					}
					num++;
				}
				while (num <= 25);
				if (arrayList.Count > 4)
				{
					Moveitem(Conversions.ToInteger(arrayList[0]), 1, Conversions.ToInteger(arrayList[1]));
				}
				if (arrayList2.Count > 4)
				{
					Moveitem(Conversions.ToInteger(arrayList2[0]), 1, Conversions.ToInteger(arrayList2[1]));
				}
				if (arrayList3.Count > 4)
				{
					Moveitem(Conversions.ToInteger(arrayList3[0]), 1, Conversions.ToInteger(arrayList3[1]));
				}
				if (arrayList4.Count > 4)
				{
					Moveitem(Conversions.ToInteger(arrayList4[0]), 1, Conversions.ToInteger(arrayList4[1]));
				}
				int num2 = 1;
				do
				{
					_Data._Tuido tuido = Data_Tuido[num2];
					int id = tuido._Id;
					if (((id > 0) & Items.Data_Items.ContainsKey(id)) && Items.Data_Items[id]._Loai == 0)
					{
						int sl = tuido._Sl;
						if (sl < 50)
						{
							int num3 = 1;
							do
							{
								if (num2 != num3)
								{
									_Data._Tuido tuido2 = Data_Tuido[num3];
									int id2 = tuido2._Id;
									int sl2 = tuido2._Sl;
									if (id == id2 && sl2 < 50)
									{
										int num4 = 50 - sl2;
										if (sl >= num4)
										{
											Moveitem(num2, num4, num3);
										}
										else
										{
											Moveitem(num2, sl, num3);
										}
										return;
									}
								}
								num3++;
							}
							while (num3 <= 25);
						}
					}
					num2++;
				}
				while (num2 <= 25);
			}
		}


		private bool IsSpBelowFleeThreshold(int slot)
		{
			bool result = false;
			int num = checked((int)Math.Round(Conversion.Val(Operators.MultiplyObject(Operators.DivideObject(this.get_DataBattle(slot, _Data.Type_Battleinfo._Sp), this.get_DataBattle(slot, _Data.Type_Battleinfo._SpMax)), 100))));
			if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreater(this.get_DataBattle(slot, _Data.Type_Battleinfo._Id), 0, false), num <= TextBox_ValueSPFlee)))
			{
				result = true;
			}
			return result;
		}


		private void ExecuteAttackTurn(int turn)
		{
			int num = 10000;
			int idskill = 10000;
			string location = "1";
			string location2 = "1";
			int num2 = 0;
			if (Data_CharAttackSetting._TurnCount > 0)
			{
				num2 = turn % Data_CharAttackSetting._TurnCount;
				if (num2 == 0)
				{
					num2 = Data_CharAttackSetting._TurnCount;
				}
				num = Conversions.ToInteger(this.get__CharAttackSetting("Char_Skill" + num2));
				location = Conversions.ToString(this.get__CharAttackSetting("Char_Location" + num2));
				if (num == 14026)
				{
					switch (Data_Player._ThuocTinh)
					{
					case 1:
						num = 10016;
						break;
					case 2:
						num = 11016;
						break;
					case 3:
						num = 12016;
						break;
					case 4:
						num = 13015;
						break;
					}
				}
			}
			int num3 = 0;
			if (Data_PetAttackSetting._TurnCount > 0)
			{
				num3 = turn % Data_PetAttackSetting._TurnCount;
				if (num3 == 0)
				{
					num3 = Data_PetAttackSetting._TurnCount;
				}
				idskill = Conversions.ToInteger(this.get__PetAttackSetting("Pet_Skill" + num3));
				location2 = Conversions.ToString(this.get__PetAttackSetting("Pet_Location" + num3));
			}
			int num4 = 0;
			int num5 = 0;
			if (!AutoClearGhost)
			{
				checked
				{
					if (C_CheckBox_AutoFlee_Party && Operators.ConditionalCompareObjectEqual(this.get_DataBattle(18, _Data.Type_Battleinfo._Id), Data_Player._Id, false) && (!Data_Player._PartyFull | (Data_Player._LeaderId == 0)))
					{
						CharacterAttack(skilldaotau, (Char_col + 15).ToString());
						if (PetBattle > 0)
						{
							PetAttack(18001, (Char_col + 10).ToString());
						}
						return;
					}
					if (C_CheckBox_AutoFlee_Sp && (IsSpBelowFleeThreshold(11) | IsSpBelowFleeThreshold(12) | IsSpBelowFleeThreshold(13) | IsSpBelowFleeThreshold(14) | IsSpBelowFleeThreshold(15) | IsSpBelowFleeThreshold(16) | IsSpBelowFleeThreshold(17) | IsSpBelowFleeThreshold(18) | IsSpBelowFleeThreshold(19) | IsSpBelowFleeThreshold(20)))
					{
						CharacterAttack(18001, (Char_col + 15).ToString());
						if (PetBattle > 0)
						{
							PetAttack(18001, (Char_col + 10).ToString());
						}
						return;
					}
					if (C_CheckBox_AutoRevival && skillHoiSinh == 11013)
					{
						int num6 = 16;
						do
						{
							if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreater(this.get_DataBattle(num6, _Data.Type_Battleinfo._Id), 0, false), Operators.CompareObjectLessEqual(this.get_DataBattle(num6, _Data.Type_Battleinfo._Hp), 0, false))))
							{
								CharacterAttack(11013, num6.ToString());
								num4 = 1;
							}
							num6++;
						}
						while (num6 <= 20);
						int num7 = 11;
						do
						{
							if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreater(this.get_DataBattle(num7, _Data.Type_Battleinfo._Id), 0, false), Operators.CompareObjectLessEqual(this.get_DataBattle(num7, _Data.Type_Battleinfo._Hp), 0, false))))
							{
								CharacterAttack(11013, num7.ToString());
								num4 = 1;
							}
							num7++;
						}
						while (num7 <= 15);
					}
				}
				if (C_CheckBox_Char_ChangeTG)
				{
					int id = Data_CharEquit[5]._Id;
					int doben = Data_CharEquit[5]._Doben;
					if (id == 0 || id == 23024 || doben >= 250)
					{
						foreach (_Data._Tuido value in Data_Tuido.Values)
						{
							int id2 = value._Id;
							int stt = value._Stt;
							switch (id2)
							{
							case 23086:
							case 23135:
								if (Data_Player._ThuocTinh == 1)
								{
									CharEquit(stt, 1);
									num4 = 1;
									goto end_IL_0568;
								}
								break;
							case 23087:
							case 23136:
								if (Data_Player._ThuocTinh == 2)
								{
									CharEquit(stt, 1);
									num4 = 1;
									goto end_IL_0568;
								}
								break;
							case 23088:
							case 23137:
								if (Data_Player._ThuocTinh == 3)
								{
									CharEquit(stt, 1);
									num4 = 1;
									goto end_IL_0568;
								}
								break;
							case 23089:
							case 23138:
								if (Data_Player._ThuocTinh == 4)
								{
									CharEquit(stt, 1);
									num4 = 1;
									goto end_IL_0568;
								}
								break;
							}
							continue;
							end_IL_0568:
							break;
						}
					}
				}
				if (C_CheckBox_Pet_ChangeTG)
				{
					int id3 = Data_PetEquit[5]._Id;
					int doben2 = Data_PetEquit[5]._Doben;
					int id4 = Data_PetInfo._Id;
					if (Npcs.Data_Npcs.ContainsKey(id4))
					{
						int thuoctinh = Npcs.Data_Npcs[id4]._Thuoctinh;
						if (id3 == 0 || id3 == 23024 || doben2 >= 250)
						{
							foreach (_Data._Tuido value2 in Data_Tuido.Values)
							{
								int id5 = value2._Id;
								int stt2 = value2._Stt;
								switch (id5)
								{
								case 23086:
								case 23135:
									if (thuoctinh == 1)
									{
										PetEquit(stt2, 1);
										num5 = 1;
										goto end_IL_0707;
									}
									break;
								case 23087:
								case 23136:
									if (thuoctinh == 2)
									{
										PetEquit(stt2, 1);
										num5 = 1;
										goto end_IL_0707;
									}
									break;
								case 23088:
								case 23137:
									if (thuoctinh == 3)
									{
										PetEquit(stt2, 1);
										num5 = 1;
										goto end_IL_0707;
									}
									break;
								case 23089:
								case 23138:
									if (thuoctinh == 4)
									{
										PetEquit(stt2, 1);
										num5 = 1;
										goto end_IL_0707;
									}
									break;
								}
								continue;
								end_IL_0707:
								break;
							}
						}
					}
				}
			}
			if ((num4 == 0) & (Data_CharAttackSetting._TurnCount > 0))
			{
				CharacterAttack(num, location);
			}
			if (((num5 == 0) & (Data_PetAttackSetting._TurnCount > 0)) && PetBattle > 0)
			{
				PetAttack(idskill, location2);
			}
		}


		public void _StartBot()
		{
			if (bott != 1)
			{
				return;
			}
			try
			{
				Data_Player._PartyFull = Party_CheckFull();
				if (Data_Player._PartyFull && ((Data_Player._LeaderId == Data_Player._Id) | (Data_Player._LeaderId == 0)))
				{
					if (Operators.CompareString(API.ServerIp, "159.196.70.237", false) == 0)
					{
						SendPacket(API.hexstringtobyte("F444040014890000"));
					}
					ClickNPCId(99);
					StartBot();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}


		private int LocationCodeToSlot(string locationCode)
		{
			int result = 1;
			switch (FnvHash.Compute(locationCode))
			{
			case 3052262101u:
				if (Operators.CompareString(locationCode, "0000", false) == 0)
				{
					result = 1;
				}
				break;
			case 3035484482u:
				if (Operators.CompareString(locationCode, "0001", false) == 0)
				{
					result = 2;
				}
				break;
			case 3018706863u:
				if (Operators.CompareString(locationCode, "0002", false) == 0)
				{
					result = 3;
				}
				break;
			case 3001929244u:
				if (Operators.CompareString(locationCode, "0003", false) == 0)
				{
					result = 4;
				}
				break;
			case 2985151625u:
				if (Operators.CompareString(locationCode, "0004", false) == 0)
				{
					result = 5;
				}
				break;
			case 3591938314u:
				if (Operators.CompareString(locationCode, "0100", false) == 0)
				{
					result = 6;
				}
				break;
			case 3608715933u:
				if (Operators.CompareString(locationCode, "0101", false) == 0)
				{
					result = 7;
				}
				break;
			case 3558383076u:
				if (Operators.CompareString(locationCode, "0102", false) == 0)
				{
					result = 8;
				}
				break;
			case 3575160695u:
				if (Operators.CompareString(locationCode, "0103", false) == 0)
				{
					result = 9;
				}
				break;
			case 3524827838u:
				if (Operators.CompareString(locationCode, "0104", false) == 0)
				{
					result = 10;
				}
				break;
			case 1468087007u:
				if (Operators.CompareString(locationCode, "0200", false) == 0)
				{
					result = 11;
				}
				break;
			case 1451309388u:
				if (Operators.CompareString(locationCode, "0201", false) == 0)
				{
					result = 12;
				}
				break;
			case 1501642245u:
				if (Operators.CompareString(locationCode, "0202", false) == 0)
				{
					result = 13;
				}
				break;
			case 1484864626u:
				if (Operators.CompareString(locationCode, "0203", false) == 0)
				{
					result = 14;
				}
				break;
			case 1400976531u:
				if (Operators.CompareString(locationCode, "0204", false) == 0)
				{
					result = 15;
				}
				break;
			case 4176086804u:
				if (Operators.CompareString(locationCode, "0300", false) == 0)
				{
					result = 16;
				}
				break;
			case 4192864423u:
				if (Operators.CompareString(locationCode, "0301", false) == 0)
				{
					result = 17;
				}
				break;
			case 4209642042u:
				if (Operators.CompareString(locationCode, "0302", false) == 0)
				{
					result = 18;
				}
				break;
			case 4226419661u:
				if (Operators.CompareString(locationCode, "0303", false) == 0)
				{
					result = 19;
				}
				break;
			case 4108976328u:
				if (Operators.CompareString(locationCode, "0304", false) == 0)
				{
					result = 20;
				}
				break;
			}
			return result;
		}


		public void Running()
		{
			checked
			{
				while (true)
				{
					Thread.Sleep(1000);
					try
					{
						if (REMOTE_DIS & !_Proxy)
						{
							Delay_REMOTE_DIS++;
							if (Delay_REMOTE_DIS >= 600)
							{
								REMOTE_DIS = false;
								_Connect();
							}
						}
						try
						{
							if (Rtbsystem.Count > 100)
							{
								foreach (int key in Rtbsystem.Keys)
								{
									Rtbsystem.Remove(key);
								}
							}
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							ProjectData.ClearProjectError();
						}
						try
						{
							if (Rtbchat.Count > 100)
							{
								foreach (int key2 in Rtbchat.Keys)
								{
									Rtbchat.Remove(key2);
								}
							}
						}
						catch (Exception ex3)
						{
							ProjectData.SetProjectError(ex3);
							Exception ex4 = ex3;
							ProjectData.ClearProjectError();
						}
						try
						{
							if (RtbQuest.Count > 100)
							{
								foreach (int key3 in RtbQuest.Keys)
								{
									RtbQuest.Remove(key3);
								}
							}
						}
						catch (Exception ex5)
						{
							ProjectData.SetProjectError(ex5);
							Exception ex6 = ex5;
							ProjectData.ClearProjectError();
						}
						if ((logined == 0) & !_Proxy)
						{
							_checkconnect++;
							if (ComboBox_Port == 0)
							{
								if (_checkconnect >= 20)
								{
									_checkconnect = 0;
									try
									{
										if (clientSocket.GetStream().CanRead)
										{
											API.AddColorText2(this, Rtbsystem, "Ngắt kết nối vì sau 20 giây không đăng nhập thành công!", Color.Red);
											_Disconnect();
										}
									}
									catch (Exception ex7)
									{
										ProjectData.SetProjectError(ex7);
										Exception ex8 = ex7;
										ProjectData.ClearProjectError();
									}
									if (C_CheckBox_Reconnect)
									{
										_Connect();
									}
								}
							}
							else if (_checkconnect >= 5)
							{
								_checkconnect = 0;
								try
								{
									if (clientSocket.GetStream().CanRead)
									{
										API.AddColorText2(this, Rtbsystem, "Ngắt kết nối vì sau 5 giây không đăng nhập thành công!", Color.Red);
										_Disconnect();
									}
								}
								catch (Exception ex9)
								{
									ProjectData.SetProjectError(ex9);
									Exception ex10 = ex9;
									ProjectData.ClearProjectError();
								}
								if (C_CheckBox_Reconnect)
								{
									_Connect();
								}
							}
						}
						if (logined != 1)
						{
							continue;
						}
						if ((_MiniRuning == 0) & C_CheckBox_OpenMachine)
						{
							OpenMachineBox();
						}
						if (bott == 1)
						{
							StatusBarPanel_checkbot = ((int)(time_online - this.m_v)).ToString();
							if (time_online - this.m_v >= 10)
							{
								if (Party_CheckFull())
								{
									StatusBarPanel_botreset++;
									if (Operators.CompareString(API.ServerIp, "159.196.70.237", false) == 0)
									{
										SendPacket(API.hexstringtobyte("F444040014890000"));
									}
									ClickNPCId(99);
									StartBot();
								}
								this.m_v = (int)time_online;
							}
						}
						else if (C_CheckBox_AutoClickNPC && ((Data_Player._MapX != _MapX_Monster) | (Data_Player._MapY != _MapY_Monster)) && ((_MapX_Monster > 0) & (_MapY_Monster > 0)) && ((TextBox_ClickMOD.Length > 0) & !AutoClearGhost & (atw == 0)))
						{
							if (Data_Player._PartyFull | (Data_Player._LeaderId == 0))
							{
							}
							Walk(_MapX_Monster, _MapY_Monster);
						}
						if (C_CheckBox_DisExp && time_online - _checkdisExp >= 30)
						{
							_checkdisExp = (int)time_online;
							if (C_CheckBox_Reconnect)
							{
								API.AddColorText2(this, Rtbsystem, "Ngắt kết nối vì sau 30 giây không có kinh nghiệm!", Color.Red);
								_Disconnect();
								_Connect();
							}
						}
						if (C_CheckBox_DCFullHomdo && time_online - _checkdisFullHomdo >= 300)
						{
							_checkdisFullHomdo = (int)time_online;
							DC_FullHomdo();
						}
						if (_time_AutoSendBDY >= 30)
						{
							_time_AutoSendBDY = 0;
							AutoSendItem();
						}
						if (_stt_send > 0)
						{
							ProgressBarEx_BDY++;
							if (ProgressBarEx_BDY == 31 && _stt_send > 0)
							{
								_stt_send = 0;
							}
						}
						else if (ProgressBarEx_BDY != 1)
						{
							ProgressBarEx_BDY = 0;
						}
						if (_time_AutoSell >= 30 && C_CheckBox_autosell)
						{
							_time_AutoSell = 0;
							if (Data_Player._MapId == 12223)
							{
								ClickNPCId(99);
								ClickNPCId(1);
								ChoiceId(2);
								SendEnd();
								AutoSellItem();
								SendEnd();
								ClickNPCId(99);
							}
							else
							{
								atw = 1;
								AutoWarptoMap = "12223";
								AutoWarp(AutoWarptoMap);
							}
						}
						if (C_RadioButton_MemberRequestParty)
						{
							if ((Data_Player._LeaderId == Data_Player._Id) | (Data_Player._LeaderId == 0))
							{
								int textBox_IdLeader = TextBox_IdLeader;
								if (textBox_IdLeader > 0)
								{
									MemRequestPartyto(textBox_IdLeader);
								}
							}
						}
						else if (C_RadioButton_LeaderRequestParty)
						{
							if ((_IDmem1 == 0) & (TextBox_IDmem1 > 0))
							{
								int textBox_IDmem = TextBox_IDmem1;
								LeaderInvitePartyto(textBox_IDmem);
							}
							if ((_IDmem2 == 0) & (TextBox_IDmem2 > 0))
							{
								int textBox_IDmem2 = TextBox_IDmem2;
								LeaderInvitePartyto(textBox_IDmem2);
							}
							if ((_IDmem3 == 0) & (TextBox_IDmem3 > 0))
							{
								int textBox_IDmem3 = TextBox_IDmem3;
								LeaderInvitePartyto(textBox_IDmem3);
							}
							if ((_IDmem4 == 0) & (TextBox_IDmem4 > 0))
							{
								int textBox_IDmem4 = TextBox_IDmem4;
								LeaderInvitePartyto(textBox_IDmem4);
							}
						}
						if (bott == 0 && C_CheckBox_Bee)
						{
							if ((_Bee_X == 0) & (_Bee_Y == 0))
							{
								_Bee_X = Data_Player._MapX;
								_Bee_Y = Data_Player._MapY;
							}
							else if ((_Bee_X == Data_Player._MapX) & (_Bee_Y == Data_Player._MapY))
							{
								int num = _Bee_X + 60;
								int num2 = _Bee_Y - 60;
								Walk(num, num2);
							}
							else if ((Data_Player._MapX == _Bee_X + 60) & (Data_Player._MapY == _Bee_Y - 60))
							{
								int num3 = _Bee_X + 60;
								int num4 = _Bee_Y + 60;
								Walk(num3, num4);
							}
							else if ((Data_Player._MapX == _Bee_X + 60) & (Data_Player._MapY == _Bee_Y + 60))
							{
								int num5 = _Bee_X - 60;
								int num6 = _Bee_Y - 60;
								Walk(num5, num6);
							}
							else if ((Data_Player._MapX == _Bee_X - 60) & (Data_Player._MapY == _Bee_Y - 60))
							{
								int num7 = _Bee_X - 60;
								int num8 = _Bee_Y + 60;
								Walk(num7, num8);
							}
							else if ((Data_Player._MapX == _Bee_X - 60) & (Data_Player._MapY == _Bee_Y + 60))
							{
								int num9 = _Bee_X + 60;
								int num10 = _Bee_Y - 60;
								Walk(num9, num10);
							}
						}
						if (C_CheckBox_AutoPickup & !AutoClearGhost)
						{
							string text = "F444040017020100";
							int numericUpDown_ItemCountPickup = NumericUpDown_ItemCountPickup;
							for (int i = 2; i <= numericUpDown_ItemCountPickup; i++)
							{
								text = text + "F44404001702" + API.Int32ToHex2(i);
							}
							byte[] packet = API.hexstringtobyte(text);
							SendPacket(packet);
						}
						if (!C_CheckBox_DCAfter1MinNoBattle)
						{
							continue;
						}
						DelayDisconnectNoBattle++;
						if (DelayDisconnectNoBattle >= 60)
						{
							DelayDisconnectNoBattle = 0;
							API.AddColorText2(this, Rtbsystem, "Ngắt kết nối vì sau 1 phút không đánh!", Color.Red);
							_Disconnect();
							if (C_CheckBox_Reconnect)
							{
								_Connect();
							}
						}
					}
					catch (Exception ex11)
					{
						ProjectData.SetProjectError(ex11);
						Exception ex12 = ex11;
						ProjectData.ClearProjectError();
					}
				}
			}
		}

		public void AutoWalkToMonster()
		{
			while (true)
			{
				Thread.Sleep(1000);
				try
				{
					if (!((logined == 1) & (bott == 0)) || !C_CheckBox_AutoClickNPC || !((TextBox_ClickMOD.Length > 0) & !AutoClearGhost & (atw == 0)) || !(Data_Player._PartyFull | (Data_Player._LeaderId == 0)))
					{
						continue;
					}
					string[] array = TextBox_ClickMOD.Split(';');
					if (array.Length <= 0)
					{
						continue;
					}
					string[] array2 = array;
					foreach (string value in array2)
					{
						int key = Conversions.ToInteger(value);
						if (Data_NpcInMap.ContainsKey(key))
						{
							_Data._NpcInMap npcInMap = Data_NpcInMap[key];
							_MapX_Monster = npcInMap._MapX;
							_MapY_Monster = npcInMap._MapY;
							Thread.Sleep(checked(TextBox_ClickMOD_delay * 1000));
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
			}
		}


		private void OnBattleEnd()
		{
			checked
			{
				battlecount++;
				Status = "Trận đấu kết thúc";
				API.AddColorText_battle2(this, RtbBattle, "==================== Trận đấu kết thúc ====================", Color.Red);
				RtbBattle.Clear();
				this.m_v = (int)time_online;
				if (_CuoiNgua == 0 && C_CheckBox_TuLenNgua)
				{
					LenNgua();
				}
				StatusBarPanel_BattleCount = battlecount.ToString();
				AutoThanhLuu();
				if (C_CheckBox_AutoEat)
				{
					CharEatHp();
					CharEatSp();
					PetEatHp();
					PetEatSp();
				}
				if (C_CheckBox_CatPet && (int)Math.Round(Conversion.Val((double)Data_PetInfo._Hp / (double)Data_PetInfo._HpMax * 100.0)) <= 10)
				{
					SendPacket(API.hexstringtobyte("F44402001302"));
				}
			}
			if (C_CheckBox_AutoUsePT && ((Data_Player._God == 0) & (Data_Player._Ghost == 0)))
			{
				foreach (_Data._Tuido value in Data_Tuido.Values)
				{
					int id = value._Id;
					int stt = value._Stt;
					if (id > 0)
					{
						int type = Items.Data_Items[id]._Type;
						if ((uint)(type - 33) <= 1u || type == 93)
						{
							CharEquit(stt, 1);
							break;
						}
					}
				}
			}
			if (C_CheckBox_Char_ChangeTG)
			{
				int id2 = Data_CharEquit[5]._Id;
				int doben = Data_CharEquit[5]._Doben;
				if (id2 == 0 || id2 == 23024 || doben >= 250)
				{
					foreach (_Data._Tuido value2 in Data_Tuido.Values)
					{
						int id3 = value2._Id;
						int stt2 = value2._Stt;
						switch (id3)
						{
						case 23086:
						case 23135:
							if (Data_Player._ThuocTinh == 1)
							{
								CharEquit(stt2, 1);
								goto end_IL_0337;
							}
							break;
						case 23087:
						case 23136:
							if (Data_Player._ThuocTinh == 2)
							{
								CharEquit(stt2, 1);
								goto end_IL_0337;
							}
							break;
						case 23088:
						case 23137:
							if (Data_Player._ThuocTinh == 3)
							{
								CharEquit(stt2, 1);
								goto end_IL_0337;
							}
							break;
						case 23089:
						case 23138:
							if (Data_Player._ThuocTinh == 4)
							{
								CharEquit(stt2, 1);
								goto end_IL_0337;
							}
							break;
						}
						continue;
						end_IL_0337:
						break;
					}
				}
			}
			if (C_CheckBox_Pet_ChangeTG)
			{
				int id4 = Data_PetEquit[5]._Id;
				int doben2 = Data_PetEquit[5]._Doben;
				int id5 = Data_PetInfo._Id;
				if (Npcs.Data_Npcs.ContainsKey(id5))
				{
					int thuoctinh = Npcs.Data_Npcs[id5]._Thuoctinh;
					if (id4 == 0 || id4 == 23024 || doben2 >= 250)
					{
						foreach (_Data._Tuido value3 in Data_Tuido.Values)
						{
							int id6 = value3._Id;
							int stt3 = value3._Stt;
							switch (id6)
							{
							case 23086:
							case 23135:
								if (thuoctinh == 1)
								{
									PetEquit(stt3, 1);
									goto end_IL_04ca;
								}
								break;
							case 23087:
							case 23136:
								if (thuoctinh == 2)
								{
									PetEquit(stt3, 1);
									goto end_IL_04ca;
								}
								break;
							case 23088:
							case 23137:
								if (thuoctinh == 3)
								{
									PetEquit(stt3, 1);
									goto end_IL_04ca;
								}
								break;
							case 23089:
							case 23138:
								if (thuoctinh == 4)
								{
									PetEquit(stt3, 1);
									goto end_IL_04ca;
								}
								break;
							}
							continue;
							end_IL_04ca:
							break;
						}
					}
				}
			}
			if (C_CheckBox_AutoEquitExp)
			{
				int id7 = Data_CharEquit[5]._Id;
				int doben3 = Data_CharEquit[5]._Doben;
				if (id7 == 0 || id7 == 23024 || doben3 >= 250)
				{
					foreach (_Data._Tuido value4 in Data_Tuido.Values)
					{
						int id8 = value4._Id;
						int stt4 = value4._Stt;
						if (id8 > 0 && Items.Data_Items.ContainsKey(id8) && IDNgocEXP.Contains(Items.Data_Items[id8]._Type))
						{
							CharEquit(stt4, 1);
							break;
						}
					}
				}
			}
			AutoDropContribute();
			turn = 0;
			Battle = 0;
			if (AutoClearGhost)
			{
				SendEnd();
			}
			else
			{
				if (AutoClearGhost)
				{
					return;
				}
				if (atw == 1)
				{
					SendEnd();
				}
				else if ((Data_Player._LeaderId == Data_Player._Id) | (Data_Player._LeaderId == 0))
				{
					if (bott == 0)
					{
						if (Operators.CompareString(API.ServerIp, "159.196.70.237", false) == 0)
						{
							SendPacket(API.hexstringtobyte("F444040014900000"));
						}
						SendEnd();
						Button_bot = true;
					}
					else if (bott == 1)
					{
						if (Operators.CompareString(API.ServerIp, "159.196.70.237", false) == 0)
						{
							SendPacket(API.hexstringtobyte("F444040014890000"));
						}
						ClickNPCId(99);
						if (Data_Player._PartyFull)
						{
							API.AddColorText_battle2(this, RtbBattle, "đợi trận đấu mới", Color.Black);
							Thread thread = new Thread(replybot);
							thread.IsBackground = true;
							thread.Start();
						}
					}
					else if (bott == 2)
					{
						if (Operators.CompareString(API.ServerIp, "159.196.70.237", false) == 0)
						{
							SendPacket(API.hexstringtobyte("F444040014890000"));
						}
						ClickNPCId(99);
						bott = 0;
					}
				}
				else if (Operators.CompareString(API.ServerIp, "159.196.70.237", false) == 0)
				{
					SendPacket(API.hexstringtobyte("F444040014900000"));
				}
			}
		}

	}
}
