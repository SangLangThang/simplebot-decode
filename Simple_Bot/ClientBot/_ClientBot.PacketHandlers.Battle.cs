using System;
using System.Diagnostics;
using System.Drawing;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Simple_Bot
{
	public partial class _ClientBot
	{
		private void HandleBattleStatDelta(byte[] packet)
		{
			try
			{
				switch (packet[5])
				{
				case 1:
					checked
					{
						switch (packet[6])
						{
						case 25:
							if (packet[7] != 1)
							{
								break;
							}
							Data_Player._Hp = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								packet[9],
								packet[8]
							}), 16);
							switch (Battle)
							{
							case 0:
								if (C_CheckBox_AutoEat)
								{
									CharEatHp();
								}
								break;
							case 1:
							{
								int num8 = 1;
								do
								{
									if (Data_Battles[num8]._Type == 2 && Operators.ConditionalCompareObjectEqual(this.get_DataBattle(num8, _Data.Type_Battleinfo._Type), 2, false) && Operators.ConditionalCompareObjectEqual(this.get_DataBattle(num8, _Data.Type_Battleinfo._Id), Data_Player._Id, false))
									{
										this.set_DataBattle(num8, _Data.Type_Battleinfo._Hp, (object)Data_Player._Hp);
									}
									num8++;
								}
								while (num8 <= 20);
								break;
							}
							}
							break;
						case 26:
							if (packet[7] != 1)
							{
								break;
							}
							Data_Player._Sp = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								packet[9],
								packet[8]
							}), 16);
							switch (Battle)
							{
							case 0:
								if (C_CheckBox_AutoEat)
								{
									CharEatSp();
								}
								break;
							case 1:
							{
								int num7 = 1;
								do
								{
									if (Operators.ConditionalCompareObjectEqual(this.get_DataBattle(num7, _Data.Type_Battleinfo._Type), 2, false) && Operators.ConditionalCompareObjectEqual(this.get_DataBattle(num7, _Data.Type_Battleinfo._Id), Data_Player._Id, false))
									{
										this.set_DataBattle(num7, _Data.Type_Battleinfo._Sp, (object)Data_Player._Sp);
									}
									num7++;
								}
								while (num7 <= 20);
								break;
							}
							}
							break;
						case 27:
							Data_Player._Int = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								packet[9],
								packet[8]
							}), 16);
							break;
						case 28:
							Data_Player._Atk = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								packet[9],
								packet[8]
							}), 16);
							break;
						case 29:
							Data_Player._Def = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								packet[9],
								packet[8]
							}), 16);
							break;
						case 30:
							Data_Player._Agi = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								packet[9],
								packet[8]
							}), 16);
							break;
						case 31:
							Data_Player._Hpx = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								packet[9],
								packet[8]
							}), 16);
							break;
						case 32:
							Data_Player._Spx = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								packet[9],
								packet[8]
							}), 16);
							break;
						case 35:
						{
							int reborn2 = Data_Player._Reborn;
							if (reborn2 == 3)
							{
								Data_Player._Lv2 = packet[8];
							}
							else
							{
								Data_Player._Lv = packet[8];
							}
							break;
						}
						case 36:
						{
							if (packet[7] != 1)
							{
								break;
							}
							int num5 = Convert.ToInt32(API.bytestohexstring(new byte[4]
							{
								packet[11],
								packet[10],
								packet[9],
								packet[8]
							}), 16);
							int num6 = (int)(num5 - Data_Player._ExpTotal);
							if (num6 > 0)
							{
								_checkdisExp = (int)time_online;
							}
							API.AddColorText_battle2(this, RtbBattle, Data_Player._Name + " nhận được : " + num6 + " exp", Color.Green);
							_BattleInfo_ExpChar = num6;
							Data_Player._Texp += num6;
							if (unchecked(time_online / 60) == 0)
							{
								Data_Player._ExpMin = Data_Player._Texp;
							}
							else
							{
								Data_Player._ExpMin = (int)Math.Round(Conversion.Val((double)Data_Player._Texp / ((double)time_online / 60.0)));
							}
							Data_Player._ExpTotal = Convert.ToInt32(API.bytestohexstring(new byte[4]
							{
								packet[11],
								packet[10],
								packet[9],
								packet[8]
							}), 16);
							Texps._Texp texp3 = Texps.Data_Texps[Data_Player._Lv];
							Texps._Texp texp4 = Texps.Data_Texps[Data_Player._Lv - 1];
							switch (Data_Player._Reborn)
							{
							case 0:
								Data_Player._Exp = (int)(Data_Player._ExpTotal - texp4._0 - 5);
								Data_Player._ExpMax = texp3._0 - texp4._0;
								break;
							case 1:
								Data_Player._Exp = (int)(Data_Player._ExpTotal - texp4._1 - 5);
								Data_Player._ExpMax = texp3._1 - texp4._1;
								break;
							case 2:
								Data_Player._Exp = (int)(Data_Player._ExpTotal - texp4._2 - 5);
								Data_Player._ExpMax = texp3._2 - texp4._2;
								break;
							case 3:
								if (Data_Player._Lv2 == 0)
								{
									texp3 = Texps.Data_Texps[Data_Player._Lv2];
									Data_Player._Exp = (int)Data_Player._ExpTotal;
									Data_Player._ExpMax = texp3._3;
								}
								else
								{
									texp3 = Texps.Data_Texps[Data_Player._Lv2];
									texp4 = Texps.Data_Texps[Data_Player._Lv2 - 1];
									Data_Player._Exp = (int)(Data_Player._ExpTotal - texp4._3);
									Data_Player._ExpMax = texp3._3 - texp4._3;
								}
								break;
							}
							break;
						}
						case 38:
							Data_Player._Point = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								packet[9],
								packet[8]
							}), 16);
							break;
						case 208:
							switch (packet[7])
							{
							case 1:
								Data_Player._Spx_Plus1 = 1;
								break;
							case 2:
								Data_Player._Spx_Plus1 = 0;
								break;
							}
							Data_Player._Spx2 = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								packet[9],
								packet[8]
							}), 16);
							break;
						case 209:
							switch (packet[7])
							{
							case 1:
								Data_Player._Hpx_Plus1 = 1;
								break;
							case 2:
								Data_Player._Hpx_Plus1 = 0;
								break;
							}
							Data_Player._Hpx2 = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								packet[9],
								packet[8]
							}), 16);
							break;
						case 210:
							switch (packet[7])
							{
							case 1:
								Data_Player._Atk_Plus1 = 1;
								break;
							case 2:
								Data_Player._Atk_Plus1 = 0;
								break;
							}
							Data_Player._Atk2 = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								packet[9],
								packet[8]
							}), 16);
							break;
						case 211:
							switch (packet[7])
							{
							case 1:
								Data_Player._Def_Plus1 = 1;
								break;
							case 2:
								Data_Player._Def_Plus1 = 0;
								break;
							}
							Data_Player._Def2 = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								packet[9],
								packet[8]
							}), 16);
							break;
						case 212:
							switch (packet[7])
							{
							case 1:
								Data_Player._Int_Plus1 = 1;
								break;
							case 2:
								Data_Player._Int_Plus1 = 0;
								break;
							}
							Data_Player._Int2 = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								packet[9],
								packet[8]
							}), 16);
							break;
						case 214:
							switch (packet[7])
							{
							case 1:
								Data_Player._Agi_Plus1 = 1;
								break;
							case 2:
								Data_Player._Agi_Plus1 = 0;
								break;
							}
							Data_Player._Agi2 = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								packet[9],
								packet[8]
							}), 16);
							break;
						case 81:
							switch (packet[7])
							{
							case 1:
								Data_Player._Int_Plus2 = 1;
								break;
							case 2:
								Data_Player._Int_Plus2 = 0;
								break;
							}
							Data_Player._Int3 = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								packet[9],
								packet[8]
							}), 16);
							break;
						case 82:
							switch (packet[7])
							{
							case 1:
								Data_Player._Atk_Plus2 = 1;
								break;
							case 2:
								Data_Player._Atk_Plus2 = 0;
								break;
							}
							Data_Player._Atk3 = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								packet[9],
								packet[8]
							}), 16);
							break;
						case 83:
							switch (packet[7])
							{
							case 1:
								Data_Player._Def_Plus2 = 1;
								break;
							case 2:
								Data_Player._Def_Plus2 = 0;
								break;
							}
							Data_Player._Def3 = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								packet[9],
								packet[8]
							}), 16);
							break;
						case 84:
							switch (packet[7])
							{
							case 1:
								Data_Player._Hpx_Plus2 = 1;
								break;
							case 2:
								Data_Player._Hpx_Plus2 = 0;
								break;
							}
							Data_Player._Hpx3 = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								packet[9],
								packet[8]
							}), 16);
							break;
						case 85:
							switch (packet[7])
							{
							case 1:
								Data_Player._Spx_Plus2 = 1;
								break;
							case 2:
								Data_Player._Spx_Plus2 = 0;
								break;
							}
							Data_Player._Spx3 = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								packet[9],
								packet[8]
							}), 16);
							break;
						}
						break;
					}
				case 2:
					switch (packet[9])
					{
					case 25:
						this.set_DataPets((int)packet[7], _Data.Type_Pets._Hp, (object)Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							packet[12],
							packet[11]
						}), 16));
						if (C_CheckBox_AutoEat & (Battle == 0))
						{
							PetEatHp();
						}
						break;
					case 26:
						this.set_DataPets((int)packet[7], _Data.Type_Pets._Sp, (object)Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							packet[12],
							packet[11]
						}), 16));
						if (C_CheckBox_AutoEat & (Battle == 0))
						{
							PetEatHp();
						}
						break;
					case 27:
						this.set_DataPets((int)packet[7], _Data.Type_Pets._Int, (object)Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							packet[12],
							packet[11]
						}), 16));
						break;
					case 28:
						this.set_DataPets((int)packet[7], _Data.Type_Pets._Atk, (object)Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							packet[12],
							packet[11]
						}), 16));
						break;
					case 29:
						this.set_DataPets((int)packet[7], _Data.Type_Pets._Def, (object)Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							packet[12],
							packet[11]
						}), 16));
						break;
					case 30:
						this.set_DataPets((int)packet[7], _Data.Type_Pets._Agi, (object)Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							packet[12],
							packet[11]
						}), 16));
						break;
					case 31:
						this.set_DataPets((int)packet[7], _Data.Type_Pets._Hpx, (object)Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							packet[12],
							packet[11]
						}), 16));
						break;
					case 32:
						this.set_DataPets((int)packet[7], _Data.Type_Pets._Spx, (object)Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							packet[12],
							packet[11]
						}), 16));
						break;
					case 35:
						this.set_DataPets((int)packet[7], _Data.Type_Pets._Lv, (object)Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							packet[12],
							packet[11]
						}), 16));
						break;
					case 36:
					{
						_Data._Pets pets = Data_PetsInfo[packet[7]];
						Texps._Texp texp = Texps.Data_Texps[pets._Lv];
						int num;
						int num2;
						int num3;
						int num4;
						checked
						{
							Texps._Texp texp2 = Texps.Data_Texps[pets._Lv - 1];
							num = Convert.ToInt32(API.bytestohexstring(new byte[4]
							{
								packet[14],
								packet[13],
								packet[12],
								packet[11]
							}), 16);
							num2 = num - texp2._0;
							num3 = texp._0 - texp2._0;
							int reborn = Npcs.Data_Npcs[pets._Id]._Reborn;
							if (reborn == 2)
							{
								num2 = num - texp2._1;
								num3 = texp._1 - texp2._1;
							}
							num4 = num - Data_PetInfo._ExpTotal;
							API.AddColorText_battle2(this, RtbBattle, Data_PetInfo._Name + " nhận được : " + num4 + " exp", Color.Green);
							_BattleInfo_ExpPet = num4;
						}
						if (packet[7] == PetBattle)
						{
							int stt;
							string tExp;
							this.set_DataPets(stt = packet[7], tExp = _Data.Type_Pets._TExp, Operators.AddObject(this.get_DataPets(stt, tExp), num4));
							if (time_online / 60 == 0)
							{
								this.set_DataPets((int)packet[7], _Data.Type_Pets._ExpMin, (object)Data_PetInfo._Texp);
							}
							else
							{
								this.set_DataPets((int)packet[7], _Data.Type_Pets._ExpMin, (object)checked((int)Math.Round(Conversion.Val((double)Data_PetInfo._Texp / ((double)time_online / 60.0)))));
							}
						}
						this.set_DataPets((int)packet[7], _Data.Type_Pets._ExpTotal, (object)num);
						this.set_DataPets((int)packet[7], _Data.Type_Pets._Exp, (object)num2);
						this.set_DataPets((int)packet[7], _Data.Type_Pets._ExpMax, (object)num3);
						pets = default(_Data._Pets);
						break;
					}
					case 64:
						this.set_DataPets((int)packet[7], _Data.Type_Pets._Fai, (object)Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							packet[12],
							packet[11]
						}), 16));
						break;
					case 208:
						switch (packet[10])
						{
						case 1:
							this.set_DataPets((int)packet[7], _Data.Type_Pets._Spx3, (object)1);
							break;
						case 2:
							this.set_DataPets((int)packet[7], _Data.Type_Pets._Spx3, (object)0);
							break;
						}
						this.set_DataPets((int)packet[7], _Data.Type_Pets._Spx2, (object)Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							packet[12],
							packet[11]
						}), 16));
						break;
					case 209:
						switch (packet[10])
						{
						case 1:
							this.set_DataPets((int)packet[7], _Data.Type_Pets._Hpx3, (object)1);
							break;
						case 2:
							this.set_DataPets((int)packet[7], _Data.Type_Pets._Hpx3, (object)0);
							break;
						}
						this.set_DataPets((int)packet[7], _Data.Type_Pets._Hpx2, (object)Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							packet[12],
							packet[11]
						}), 16));
						break;
					case 210:
						switch (packet[10])
						{
						case 1:
							this.set_DataPets((int)packet[7], _Data.Type_Pets._Atk3, (object)1);
							break;
						case 2:
							this.set_DataPets((int)packet[7], _Data.Type_Pets._Atk3, (object)0);
							break;
						}
						this.set_DataPets((int)packet[7], _Data.Type_Pets._Atk2, (object)Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							packet[12],
							packet[11]
						}), 16));
						break;
					case 211:
						switch (packet[10])
						{
						case 1:
							this.set_DataPets((int)packet[7], _Data.Type_Pets._Def3, (object)1);
							break;
						case 2:
							this.set_DataPets((int)packet[7], _Data.Type_Pets._Def3, (object)0);
							break;
						}
						this.set_DataPets((int)packet[7], _Data.Type_Pets._Def2, (object)Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							packet[12],
							packet[11]
						}), 16));
						break;
					case 212:
						switch (packet[10])
						{
						case 1:
							this.set_DataPets((int)packet[7], _Data.Type_Pets._Int3, (object)1);
							break;
						case 2:
							this.set_DataPets((int)packet[7], _Data.Type_Pets._Int3, (object)0);
							break;
						}
						this.set_DataPets((int)packet[7], _Data.Type_Pets._Int2, (object)Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							packet[12],
							packet[11]
						}), 16));
						break;
					case 214:
						switch (packet[10])
						{
						case 1:
							this.set_DataPets((int)packet[7], _Data.Type_Pets._Agi3, (object)1);
							break;
						case 2:
							this.set_DataPets((int)packet[7], _Data.Type_Pets._Agi3, (object)0);
							break;
						}
						this.set_DataPets((int)packet[7], _Data.Type_Pets._Agi2, (object)Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							packet[12],
							packet[11]
						}), 16));
						break;
					}
					break;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				StackTrace stackTrace = new StackTrace(true);
				stackTrace = new StackTrace(ex2, true);
				API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - Update_H8] :" + ex2.Message + stackTrace.GetFrame(0).GetFileLineNumber() + "\r\n");
				ProjectData.ClearProjectError();
			}
		}


		private void HandleBattleRoster(byte[] packet)
		{
			checked
			{
				try
				{
					byte b = packet[5];
					switch (b)
					{
					case 1:
						if (b == 1)
						{
							int location = GetLocation2(packet[6].ToString("X2") + packet[7].ToString("X2"));
							_Data._Battleinfo value = Data_Battles[location];
							value._Id = 0;
							value._Name = "";
							value._Lv = 0;
							value._Hp = 0;
							value._HpMax = 0;
							value._Sp = 0;
							value._SpMax = 0;
							value._ThuocTinh = 0;
							value._Type = 0;
							value._IdChar = 0;
							value._Color = Color.Black;
							Data_Battles[location] = value;
						}
						break;
					case 0:
					{
						int num17 = Convert.ToInt32(API.bytestohexstring(new byte[4]
						{
							packet[9],
							packet[8],
							packet[7],
							packet[6]
						}), 16);
						if ((num17 == Data_Player._Id) | (num17 == Data_Player._LeaderId))
						{
							int num18 = 1;
							do
							{
								Data_Battles[num18] = default(_Data._Battleinfo);
								num18++;
							}
							while (num18 <= 20);
							turn = 0;
							if (BTQ == 1)
							{
							}
							if (Battle == 1)
							{
								OnBattleEnd();
							}
						}
						break;
					}
					case 5:
					{
						int num9 = API.HexToInt32(API.bytestohexstring(packet).Substring(16, 8));
						int num10 = API.HexToInt32(API.bytestohexstring(packet).Substring(28, 8));
						string a_2 = API.bytestohexstring(packet).Substring(36, 4);
						int num11 = API.HexToInt32(API.bytestohexstring(packet).Substring(48, 4));
						int num12 = API.HexToInt32(API.bytestohexstring(packet).Substring(40, 4));
						int num13 = API.HexToInt32(API.bytestohexstring(packet).Substring(52, 4));
						int num14 = API.HexToInt32(API.bytestohexstring(packet).Substring(44, 4));
						int num15 = packet[28];
						int num16 = packet[29];
						string text4 = "";
						byte b2 = packet[7];
						if (b2 == 2)
						{
							text4 = GetNamePlayer(num9);
							if (TextBox_IDmem1 != 0 && TextBox_IDmem1 == num9)
							{
								_checkdisparty++;
							}
							if (TextBox_IDmem2 != 0 && TextBox_IDmem2 == num9)
							{
								_checkdisparty++;
							}
							if (TextBox_IDmem3 != 0 && TextBox_IDmem3 == num9)
							{
								_checkdisparty++;
							}
							if (TextBox_IDmem4 != 0 && TextBox_IDmem4 == num9)
							{
								_checkdisparty++;
							}
						}
						else
						{
							text4 = GetNameNPC(num9);
						}
						this.set_DataBattle(LocationCodeToSlot(a_2), _Data.Type_Battleinfo._Id, (object)num9);
						this.set_DataBattle(LocationCodeToSlot(a_2), _Data.Type_Battleinfo._Name, (object)text4);
						this.set_DataBattle(LocationCodeToSlot(a_2), _Data.Type_Battleinfo._Lv, (object)num15);
						this.set_DataBattle(LocationCodeToSlot(a_2), _Data.Type_Battleinfo._Hp, (object)num11);
						this.set_DataBattle(LocationCodeToSlot(a_2), _Data.Type_Battleinfo._HpMax, (object)num12);
						this.set_DataBattle(LocationCodeToSlot(a_2), _Data.Type_Battleinfo._Sp, (object)num13);
						this.set_DataBattle(LocationCodeToSlot(a_2), _Data.Type_Battleinfo._SpMax, (object)num14);
						this.set_DataBattle(LocationCodeToSlot(a_2), _Data.Type_Battleinfo._ThuocTinh, (object)num16);
						this.set_DataBattle(LocationCodeToSlot(a_2), _Data.Type_Battleinfo._Type, (object)unchecked((int)packet[7]));
						this.set_DataBattle(LocationCodeToSlot(a_2), _Data.Type_Battleinfo._IdChar, (object)num10);
						this.set_DataBattle(LocationCodeToSlot(a_2), _Data.Type_Battleinfo._Color, (object)API.GetColor(packet[29]));
						if ((num9 == Data_PetInfo._Id) & (Char_col == packet[19]))
						{
							this.set_DataPets(PetBattle, _Data.Type_Pets._Hp, (object)num11);
							this.set_DataPets(PetBattle, _Data.Type_Pets._Sp, (object)num13);
							this.set_DataPets(PetBattle, _Data.Type_Pets._HpMax, (object)num12);
							this.set_DataPets(PetBattle, _Data.Type_Pets._SpMax, (object)num14);
						}
						API.AddColorText_battle2(this, RtbBattle, text4 + " " + Conversions.ToString(num16) + " Cấp:" + Conversions.ToString(num15) + " HP:" + Conversions.ToString(num11) + "/" + Conversions.ToString(num12) + " SP:" + Conversions.ToString(num13) + "/" + Conversions.ToString(num14), Color.Purple);
						break;
					}
					case 250:
					{
						_checkdisparty = 0;
						this.m_v = (int)(time_online + 999999);
						string text = API.bytestohexstring(packet).Substring(16);
						while (text.Length != 0)
						{
							string text2 = text.Substring(0, 48);
							byte[] array = API.hexstringtobyte(text2);
							int num = API.HexToInt32(text2.Substring(4, 8));
							int num2 = API.HexToInt32(text2.Substring(26, 8));
							string a_ = text2.Substring(24, 4);
							string text3 = "";
							text3 = ((GetNamePlayer(num).Length <= 0) ? GetNameNPC(num) : GetNamePlayer(num));
							int num3 = API.HexToInt32(text2.Substring(36, 4));
							int num4 = API.HexToInt32(text2.Substring(28, 4));
							int num5 = API.HexToInt32(text2.Substring(40, 4));
							int num6 = API.HexToInt32(text2.Substring(32, 4));
							int num7 = array[22];
							int num8 = packet[23];
							this.set_DataBattle(LocationCodeToSlot(a_), _Data.Type_Battleinfo._Id, (object)num);
							this.set_DataBattle(LocationCodeToSlot(a_), _Data.Type_Battleinfo._Name, (object)text3);
							this.set_DataBattle(LocationCodeToSlot(a_), _Data.Type_Battleinfo._Lv, (object)num7);
							this.set_DataBattle(LocationCodeToSlot(a_), _Data.Type_Battleinfo._Hp, (object)num3);
							this.set_DataBattle(LocationCodeToSlot(a_), _Data.Type_Battleinfo._HpMax, (object)num4);
							this.set_DataBattle(LocationCodeToSlot(a_), _Data.Type_Battleinfo._Sp, (object)num5);
							this.set_DataBattle(LocationCodeToSlot(a_), _Data.Type_Battleinfo._SpMax, (object)num6);
							this.set_DataBattle(LocationCodeToSlot(a_), _Data.Type_Battleinfo._ThuocTinh, (object)num8);
							this.set_DataBattle(LocationCodeToSlot(a_), _Data.Type_Battleinfo._Type, (object)2);
							this.set_DataBattle(LocationCodeToSlot(a_), _Data.Type_Battleinfo._IdChar, (object)num2);
							this.set_DataBattle(LocationCodeToSlot(a_), _Data.Type_Battleinfo._Color, (object)API.GetColor(array[23]));
							if (num == Data_Player._Id)
							{
								Char_col = array[13];
								Battle = 1;
								turn = 0;
								_BattleInfo_ExpChar = 0;
								_BattleInfo_ExpPet = 0;
								Status = "Trận đấu bắt đầu";
								Button_bot = true;
								API.AddColorText_battle2(this, RtbBattle, "==================== Trận đấu bắt đầu ====================", Color.Red);
								packetAutoContribute = "";
								if (C_CheckBox_QuestProtect)
								{
									if (Operators.CompareString(API.ServerIp, "159.196.70.237", false) == 0)
									{
										SendPacket(API.hexstringtobyte("F444040014890000"));
									}
								}
								else if (Operators.CompareString(API.ServerIp, "159.196.70.237", false) == 0)
								{
									SendPacket(API.hexstringtobyte("F444040014900000"));
								}
							}
							API.AddColorText_battle2(this, RtbBattle, text3 + " " + Conversions.ToString(num8) + " Cấp:" + Conversions.ToString(num7) + " HP:" + Conversions.ToString(num3) + "/" + Conversions.ToString(num4) + " SP:" + Conversions.ToString(num5) + "/" + Conversions.ToString(num6), Color.Black);
							text = text.Replace(text2, "");
						}
						break;
					}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					StackTrace stackTrace = new StackTrace(true);
					stackTrace = new StackTrace(ex2, true);
					API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - Update_HB] :" + ex2.Message + stackTrace.GetFrame(0).GetFileLineNumber() + "\r\n");
					ProjectData.ClearProjectError();
				}
			}
		}


		private void HandlePetBattleSelect(byte[] packet)
		{
			try
			{
				byte b = packet[5];
				if (b == 2)
				{
					PetBattle = 0;
					return;
				}
				int num = API.HexToInt32(API.bytestohexstring(new byte[2]
				{
					packet[6],
					packet[7]
				}));
				if (Operators.ConditionalCompareObjectEqual(num, this.get_DataPets(1, _Data.Type_Pets._Id), false))
				{
					PetBattle = 1;
				}
				else if (Operators.ConditionalCompareObjectEqual(num, this.get_DataPets(2, _Data.Type_Pets._Id), false))
				{
					PetBattle = 2;
				}
				else if (Operators.ConditionalCompareObjectEqual(num, this.get_DataPets(3, _Data.Type_Pets._Id), false))
				{
					PetBattle = 3;
				}
				else if (Operators.ConditionalCompareObjectEqual(num, this.get_DataPets(4, _Data.Type_Pets._Id), false))
				{
					PetBattle = 4;
				}
				if (PetBattle > 0)
				{
					_Data._Pets value = Data_PetsInfo[PetBattle];
					Data_PetListSkill.Clear();
					Data_PetListSkill.Add(10000);
					Data_PetListSkill.Add(17001);
					Data_PetListSkill.Add(18001);
					Npcs.NpcInfo npcs = Npcs.Data_Npcs[value._Id];
					if (npcs._Skill1 > 0)
					{
						Data_PetListSkill.Add(npcs._Skill1);
					}
					if (npcs._Skill2 > 0)
					{
						Data_PetListSkill.Add(npcs._Skill2);
					}
					if (npcs._Skill3 > 0)
					{
						Data_PetListSkill.Add(npcs._Skill3);
					}
					if (npcs._Skill4 > 0)
					{
						Data_PetListSkill.Add(npcs._Skill4);
					}
					if (npcs._Skill5 > 0)
					{
						Data_PetListSkill.Add(npcs._Skill5);
					}
					if (npcs._Skill6 > 0)
					{
						Data_PetListSkill.Add(npcs._Skill6);
					}
					npcs = default(Npcs.NpcInfo);
					Data_PetsInfo[PetBattle] = value;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				StackTrace stackTrace = new StackTrace(true);
				stackTrace = new StackTrace(ex2, true);
				API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - Update_H13] :" + ex2.Message + stackTrace.GetFrame(0).GetFileLineNumber() + "\r\n");
				ProjectData.ClearProjectError();
			}
		}


		private void HandleBattleSkillEffect(byte[] packet)
		{
			checked
			{
				try
				{
					byte b = packet[5];
					if (b != 1)
					{
						return;
					}
					int num = 0;
					string text = API.bytestohexstring(packet).Substring(12);
					string text2 = "";
					while (text.Length != 0)
					{
						num++;
						byte[] array = API.hexstringtobyte(text);
						string text3 = text.Substring(0, 4 + API.HexToInt32(text.Substring(0, 4)) * 2);
						string a_ = text3.Substring(4, 4);
						string text4 = Conversions.ToString(this.get_DataBattle(LocationCodeToSlot(a_), _Data.Type_Battleinfo._Name));
						int id = API.HexToInt32(text3.Substring(8, 4));
						int stt;
						string sp;
						this.set_DataBattle(stt = LocationCodeToSlot(a_), sp = _Data.Type_Battleinfo._Sp, Operators.SubtractObject(this.get_DataBattle(stt, sp), GetSkillSP(id)));
						string text5 = text3.Substring(16);
						while (text5.Length != 0)
						{
							int num2 = API.HexToInt32(text5.Substring(8, 2));
							string text6 = text5.Substring(0, 10 + num2 * 8);
							string a_2 = text5.Substring(0, 4);
							string text7 = "";
							switch (API.HexToInt32(text5.Substring(4, 2)))
							{
							case 0:
								text7 = "Trượt";
								break;
							case 1:
								text7 = "Trúng";
								break;
							}
							string text8 = Conversions.ToString(this.get_DataBattle(LocationCodeToSlot(a_2), _Data.Type_Battleinfo._Name));
							int num3 = API.HexToInt32(text6.Substring(10, 2));
							int num4 = API.HexToInt32(text6.Substring(12, 4));
							switch (API.HexToInt32(text6.Substring(16, 2)))
							{
							case 0:
								switch (num3)
								{
								case 25:
									if (Operators.ConditionalCompareObjectLess(this.get_DataBattle(LocationCodeToSlot(a_2), _Data.Type_Battleinfo._Hp), 0, false))
									{
										this.set_DataBattle(LocationCodeToSlot(a_2), _Data.Type_Battleinfo._Hp, (object)num4);
									}
									else
									{
										this.set_DataBattle(stt = LocationCodeToSlot(a_2), sp = _Data.Type_Battleinfo._Hp, Operators.AddObject(this.get_DataBattle(stt, sp), num4));
									}
									text2 = text2 + text4 + " --> " + GetSkillName(id) + " -[" + text7 + "]-> " + text8 + " (+" + Conversions.ToString(num4) + " hp)\r\n";
									break;
								case 26:
									if (Operators.ConditionalCompareObjectLess(this.get_DataBattle(LocationCodeToSlot(a_2), _Data.Type_Battleinfo._Sp), 0, false))
									{
										this.set_DataBattle(LocationCodeToSlot(a_2), _Data.Type_Battleinfo._Sp, (object)num4);
									}
									else
									{
										this.set_DataBattle(stt = LocationCodeToSlot(a_2), sp = _Data.Type_Battleinfo._Sp, Operators.AddObject(this.get_DataBattle(stt, sp), num4));
									}
									text2 = text2 + text4 + " --> " + GetSkillName(id) + " -[" + text7 + "]-> " + text8 + " (+" + Conversions.ToString(num4) + " Sp)\r\n";
									break;
								default:
									text2 = text2 + text4 + " --> " + GetSkillName(id) + " -[" + text7 + "]-> " + text8 + "\r\n";
									break;
								}
								break;
							case 1:
								switch (num3)
								{
								case 25:
									this.set_DataBattle(stt = LocationCodeToSlot(a_2), sp = _Data.Type_Battleinfo._Hp, Operators.SubtractObject(this.get_DataBattle(stt, sp), num4));
									text2 = text2 + text4 + " " + GetSkillName(id) + " -[" + text7 + "]-> " + text8 + " (-" + Conversions.ToString(num4) + " hp)\r\n";
									break;
								case 26:
									this.set_DataBattle(stt = LocationCodeToSlot(a_2), sp = _Data.Type_Battleinfo._Sp, Operators.SubtractObject(this.get_DataBattle(stt, sp), num4));
									text2 = text2 + text4 + " --> " + GetSkillName(id) + " -[" + text7 + "]-> " + text8 + " (-" + Conversions.ToString(num4) + " Sp)\r\n";
									break;
								default:
									text2 = text2 + text4 + " --> " + GetSkillName(id) + " -[" + text7 + "]-> " + text8 + "\r\n";
									break;
								}
								break;
							}
							text5 = text5.Replace(text6, "");
						}
						text = text.Replace(text3, "");
					}
					if (text2.Length > 0)
					{
						API.AddColorText_battle2(this, RtbBattle, text2, Color.DarkOrange);
					}
					if (num > 1)
					{
						API.AddColorText_battle2(this, RtbBattle, "Combo", Color.Black);
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					StackTrace stackTrace = new StackTrace(true);
					stackTrace = new StackTrace(ex2, true);
					API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - Update_H32] :" + ex2.Message + stackTrace.GetFrame(0).GetFileLineNumber() + "\r\n");
					ProjectData.ClearProjectError();
				}
			}
		}


		private void HandleBattleTurnAdvance(byte[] packet)
		{
			checked
			{
				try
				{
					byte b = packet[5];
					if (b != 1)
					{
						return;
					}
					turn++;
					Status = "Lượt đánh: " + Conversions.ToString(turn);
					if (Battle == 1)
					{
						DelayDisconnectNoBattle = 0;
						API.AddColorText_battle2(this, RtbBattle, "Lượt : " + turn, Color.Blue);
						if (Data_Player._LeaderId == Data_Player._Id)
						{
							int num = 0;
							if (TextBox_IDmem1 != 0)
							{
								num++;
							}
							if (TextBox_IDmem2 != 0)
							{
								num++;
							}
							if (TextBox_IDmem3 != 0)
							{
								num++;
							}
							if (TextBox_IDmem4 != 0)
							{
								num++;
							}
							if (num > _checkdisparty)
							{
								Data_Player._PartyFull = false;
								if (C_CheckBox_LeaderDissNotEnough)
								{
									API.AddColorText2(this, Rtbsystem, "không đủ thành viên, ngắt kết nôi!", Color.Red);
									_Disconnect();
								}
							}
						}
					}
					if ((BTQ == 1) & (turn > 0))
					{
						AnswerBTQ(ListAnswerBTQ);
					}
					else if ((BTQ == 0) & (turn > 0))
					{
						ExecuteAttackTurn(turn);
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					StackTrace stackTrace = new StackTrace(true);
					stackTrace = new StackTrace(ex2, true);
					API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - Update_H34] :" + ex2.Message + stackTrace.GetFrame(0).GetFileLineNumber() + "\r\n");
					ProjectData.ClearProjectError();
				}
			}
		}


		private void HandleBattleAck(byte[] packet)
		{
			try
			{
				byte b = packet[5];
				if (b == 1)
				{
					SendPacket(API.hexstringtobyte("F44402000301"));
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				StackTrace stackTrace = new StackTrace(true);
				stackTrace = new StackTrace(ex2, true);
				API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - Update_H9] :" + ex2.Message + stackTrace.GetFrame(0).GetFileLineNumber() + "\r\n");
				ProjectData.ClearProjectError();
			}
		}

	}
}
