using System;
using System.Diagnostics;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Simple_Bot
{
	public partial class _ClientBot
	{
		private void HandleSelfOrPlayerInfo(byte[] packet)
		{
			checked
			{
				try
				{
					int num = Convert.ToInt32(API.bytestohexstring(new byte[4]
					{
						packet[8],
						packet[7],
						packet[6],
						packet[5]
					}), 16);
					int num2 = num;
					if (num2 == idlogin)
					{
						Data_Player._Id = num;
						Data_Player._Sex = packet[9];
						Data_Player._Ghost = packet[10];
						Data_Player._God = packet[11];
						Data_Player._MapId = Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							packet[13],
							packet[12]
						}), 16);
						Data_Player._MapX = Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							packet[15],
							packet[14]
						}), 16);
						Data_Player._MapY = Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							packet[17],
							packet[16]
						}), 16);
						Data_Player._Hair = Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							packet[20],
							packet[19]
						}), 16);
						Data_Player._HairColor = Convert.ToInt32(API.bytestohexstring(new byte[4]
						{
							packet[24],
							packet[23],
							packet[22],
							packet[21]
						}), 16);
						Data_Player._SkinColor = Convert.ToInt32(API.bytestohexstring(new byte[4]
						{
							packet[28],
							packet[27],
							packet[26],
							packet[25]
						}), 16);
						Data_Player._MapName = MyProject.Forms.MainForm.Getmapname(Conversions.ToInteger(Data_Player._MapId.ToString()));
						string text = "";
						int num3 = 29 + packet[29] * 2 + 8;
						int num4 = packet.Length - 1;
						for (int i = num3; i <= num4; i++)
						{
							text += Conversions.ToString(Strings.Chr(packet[i]));
						}
						Data_Player._Name = text;
						Data_Player._Reborn = packet[29 + packet[29] * 2 + 6];
						return;
					}
					int thuocTinh = packet[10];
					string text2 = "";
					int num5 = 31 + packet[31] * 2 + 9;
					int num6 = packet.Length - 1;
					for (int j = num5; j <= num6 && packet[j] != 0; j++)
					{
						text2 += Conversions.ToString(Strings.Chr(packet[j]));
					}
					int lv = packet[11];
					int mapId = Convert.ToInt32(API.bytestohexstring(new byte[2]
					{
						packet[15],
						packet[14]
					}), 16);
					int mapX = Convert.ToInt32(API.bytestohexstring(new byte[2]
					{
						packet[17],
						packet[16]
					}), 16);
					int mapY = Convert.ToInt32(API.bytestohexstring(new byte[2]
					{
						packet[19],
						packet[18]
					}), 16);
					int reborn = packet[31 + packet[31] * 2 + 7];
					if (Data_Players.ContainsKey(num))
					{
						PlayerCount++;
						Listplayers._Player value = Data_Players[num];
						value._Id = num;
						value._Name = text2;
						value._Lv = lv;
						value._MapId = mapId;
						value._MapX = mapX;
						value._MapY = mapY;
						value._Reborn = reborn;
						value._ThuocTinh = thuocTinh;
						value._Online = "ON";
						Data_Players[num] = value;
					}
					else
					{
						PlayerCount++;
						Listplayers._Player value2 = new Listplayers._Player
						{
							_Id = num,
							_Name = text2,
							_Lv = lv,
							_MapId = mapId,
							_MapX = mapX,
							_MapY = mapY,
							_Reborn = reborn,
							_ThuocTinh = thuocTinh,
							_Online = "ON"
						};
						Data_Players.Add(num, value2);
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					StackTrace stackTrace = new StackTrace(true);
					stackTrace = new StackTrace(ex2, true);
					API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - Update_H3] :" + ex2.Message + stackTrace.GetFrame(0).GetFileLineNumber() + "\r\n");
					ProjectData.ClearProjectError();
				}
			}
		}

		private void HandleOtherPlayerInfo(byte[] packet)
		{
			checked
			{
				try
				{
					int num = Convert.ToInt32(API.bytestohexstring(new byte[4]
					{
						packet[8],
						packet[7],
						packet[6],
						packet[5]
					}), 16);
					int thuocTinh = packet[10];
					string text = "";
					int num2 = 31 + packet[31] * 2 + 9;
					int num3 = packet.Length - 1;
					for (int i = num2; i <= num3 && packet[i] != 0; i++)
					{
						text += Conversions.ToString(Strings.Chr(packet[i]));
					}
					int lv = packet[11];
					int mapId = Convert.ToInt32(API.bytestohexstring(new byte[2]
					{
						packet[15],
						packet[14]
					}), 16);
					int mapX = Convert.ToInt32(API.bytestohexstring(new byte[2]
					{
						packet[17],
						packet[16]
					}), 16);
					int mapY = Convert.ToInt32(API.bytestohexstring(new byte[2]
					{
						packet[19],
						packet[18]
					}), 16);
					int reborn = packet[31 + packet[31] * 2 + 7];
					if (Data_Players.ContainsKey(num))
					{
						Listplayers._Player value = Data_Players[num];
						value._Id = num;
						value._Name = text;
						value._Lv = lv;
						value._MapId = mapId;
						value._MapX = mapX;
						value._MapY = mapY;
						value._Reborn = reborn;
						value._ThuocTinh = thuocTinh;
						value._Online = "ON";
						Data_Players[num] = value;
					}
					else
					{
						PlayerCount++;
						Listplayers._Player value2 = new Listplayers._Player
						{
							_Id = num,
							_Name = text,
							_Lv = lv,
							_MapId = mapId,
							_MapX = mapX,
							_MapY = mapY,
							_Reborn = reborn,
							_ThuocTinh = thuocTinh,
							_Online = "ON"
						};
						Data_Players.Add(num, value2);
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					StackTrace stackTrace = new StackTrace(true);
					stackTrace = new StackTrace(ex2, true);
					API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - Update_H4] :" + ex2.Message + stackTrace.GetFrame(0).GetFileLineNumber() + "\r\n");
					ProjectData.ClearProjectError();
				}
			}
		}

		private void HandleCharacterStats(byte[] packet)
		{
			checked
			{
				try
				{
					switch (packet[5])
					{
					case 2:
						if (packet.Length >= 8)
						{
							int num7 = Convert.ToInt32(API.bytestohexstring(new byte[4]
							{
								packet[9],
								packet[8],
								packet[7],
								packet[6]
							}), 16);
							string text3 = "";
							int num8 = packet.Length - 1;
							for (int j = num8; j >= 0 && packet[j] != 0; j += -1)
							{
								text3 = Conversions.ToString(Strings.Chr(packet[j])) + text3;
							}
						}
						break;
					case 4:
						if (packet.Length >= 8)
						{
							int num5 = Convert.ToInt32(API.bytestohexstring(new byte[4]
							{
								packet[9],
								packet[8],
								packet[7],
								packet[6]
							}), 16);
							string text2 = "";
							int num6 = packet.Length - 1;
							for (int i = num6; i >= 0 && packet[i] != 0; i += -1)
							{
								text2 = Conversions.ToString(Strings.Chr(packet[i])) + text2;
							}
						}
						break;
					case 3:
					{
						_Value_Item_OnMap = packet[32];
						Data_Player._ThuocTinh = packet[6];
						Data_Player._Lv = packet[23];
						Data_Player._ExpTotal = Convert.ToInt32(API.bytestohexstring(new byte[4]
						{
							packet[27],
							packet[26],
							packet[25],
							packet[24]
						}), 16);
						Data_Player._Point = Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							packet[31],
							packet[30]
						}), 16);
						Texps._Texp texp = Texps.Data_Texps[Data_Player._Lv];
						Texps._Texp texp2 = Texps.Data_Texps[Data_Player._Lv - 1];
						switch (Data_Player._Reborn)
						{
						case 0:
							Data_Player._Exp = (int)(Data_Player._ExpTotal - texp2._0 - 5);
							Data_Player._ExpMax = texp._0 - texp2._0;
							break;
						case 1:
							Data_Player._Exp = (int)(Data_Player._ExpTotal - texp._1 - 5);
							Data_Player._ExpMax = texp._1 - texp2._1;
							break;
						case 2:
							Data_Player._Exp = (int)(Data_Player._ExpTotal - texp._2 - 5);
							Data_Player._ExpMax = texp._2 - texp2._2;
							break;
						}
						Data_Player._Hp = Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							packet[8],
							packet[7]
						}), 16);
						Data_Player._Sp = Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							packet[10],
							packet[9]
						}), 16);
						Data_Player._Int = Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							packet[12],
							packet[11]
						}), 16);
						Data_Player._Atk = Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							packet[14],
							packet[13]
						}), 16);
						Data_Player._Def = Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							packet[16],
							packet[15]
						}), 16);
						Data_Player._Agi = Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							packet[18],
							packet[17]
						}), 16);
						Data_Player._Hpx = Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							packet[20],
							packet[19]
						}), 16);
						Data_Player._Spx = Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							packet[22],
							packet[21]
						}), 16);
						Data_Player._HpMax = Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							packet[37],
							packet[36]
						}), 16);
						Data_Player._SpMax = Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							packet[39],
							packet[38]
						}), 16);
						Data_Player._Atk2 = Convert.ToInt32(API.bytestohexstring(new byte[4]
						{
							packet[43],
							packet[42],
							packet[41],
							packet[40]
						}), 16);
						Data_Player._Def2 = Convert.ToInt32(API.bytestohexstring(new byte[4]
						{
							packet[47],
							packet[46],
							packet[45],
							packet[44]
						}), 16);
						Data_Player._Int2 = Convert.ToInt32(API.bytestohexstring(new byte[4]
						{
							packet[51],
							packet[50],
							packet[49],
							packet[48]
						}), 16);
						Data_Player._Agi2 = Convert.ToInt32(API.bytestohexstring(new byte[4]
						{
							packet[55],
							packet[54],
							packet[53],
							packet[52]
						}), 16);
						Data_Player._Hpx2 = Convert.ToInt32(API.bytestohexstring(new byte[4]
						{
							packet[59],
							packet[58],
							packet[57],
							packet[56]
						}), 16);
						Data_Player._Spx2 = Convert.ToInt32(API.bytestohexstring(new byte[4]
						{
							packet[63],
							packet[62],
							packet[61],
							packet[60]
						}), 16);
						if (Data_Player._Int2 >= 0)
						{
							Data_Player._Int_Plus1 = 1;
						}
						else
						{
							Data_Player._Int_Plus1 = 0;
						}
						if (Data_Player._Atk2 >= 0)
						{
							Data_Player._Atk_Plus1 = 1;
						}
						else
						{
							Data_Player._Atk_Plus1 = 0;
						}
						if (Data_Player._Def2 >= 0)
						{
							Data_Player._Def_Plus1 = 1;
						}
						else
						{
							Data_Player._Def_Plus1 = 0;
						}
						if (Data_Player._Agi2 >= 0)
						{
							Data_Player._Agi_Plus1 = 1;
						}
						else
						{
							Data_Player._Agi_Plus1 = 0;
						}
						if (Data_Player._Hpx2 >= 0)
						{
							Data_Player._Hpx_Plus1 = 1;
						}
						else
						{
							Data_Player._Hpx_Plus1 = 0;
						}
						if (Data_Player._Spx2 >= 0)
						{
							Data_Player._Spx_Plus1 = 1;
						}
						else
						{
							Data_Player._Spx_Plus1 = 0;
						}
						Data_CharListSkill.Add(10000);
						Data_CharListSkill.Add(17001);
						Data_CharListSkill.Add(18001);
						string text = API.bytestohexstring(API.ByteArrayToByteArray(packet, 117));
						int num = 0;
						do
						{
							int num2 = API.HexToInt32(text.Substring(num, 4));
							if (!Skills.Data_Skills.ContainsKey(num2))
							{
								break;
							}
							if (num2 == 14002)
							{
								skilldaotau = 14002;
							}
							if (num2 == 11013)
							{
								skillHoiSinh = 11013;
							}
							if (num2 == 14003)
							{
								skill_buonban = API.HexToInt32(text.Substring(num + 4, 2));
							}
							Data_CharListSkill.Add(num2);
							num += 6;
						}
						while (num <= 500);
						if (Data_Player._Reborn == 3)
						{
							int num3 = packet.Length - 4;
							Data_Player._Lv2 = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								packet[num3 - 20],
								packet[num3 - 21]
							}), 16);
							Data_Player._ExpTotal = Convert.ToInt64(API.bytestohexstring(new byte[8]
							{
								packet[num3 - 12],
								packet[num3 - 13],
								packet[num3 - 14],
								packet[num3 - 15],
								packet[num3 - 16],
								packet[num3 - 17],
								packet[num3 - 18],
								packet[num3 - 19]
							}), 16);
							Data_Player._Int3 = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								packet[num3 - 10],
								packet[num3 - 11]
							}), 16);
							Data_Player._Atk3 = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								packet[num3 - 8],
								packet[num3 - 9]
							}), 16);
							Data_Player._Def3 = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								packet[num3 - 6],
								packet[num3 - 7]
							}), 16);
							Data_Player._Hpx3 = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								packet[num3 - 2],
								packet[num3 - 3]
							}), 16);
							Data_Player._Spx3 = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								packet[num3],
								packet[num3 - 1]
							}), 16);
							Data_Player._Spx3 = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								packet[num3],
								packet[num3 - 1]
							}), 16);
							if (Data_Player._Lv2 == 0)
							{
								texp = Texps.Data_Texps[Data_Player._Lv2];
								Data_Player._Exp = (int)Data_Player._ExpTotal;
								Data_Player._ExpMax = texp._3;
							}
							else
							{
								texp = Texps.Data_Texps[Data_Player._Lv2];
								texp2 = Texps.Data_Texps[Data_Player._Lv2 - 1];
								Data_Player._Exp = (int)(Data_Player._ExpTotal - texp2._3);
								Data_Player._ExpMax = texp._3 - texp2._3;
							}
							int num4 = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								packet[packet.Length - 1],
								packet[packet.Length - 2]
							}), 16);
							if (num4 > 0)
							{
								Data_CharListSkill.Add(num4);
							}
						}
						if (Data_Players.ContainsKey(Data_Player._Id))
						{
							Listplayers._Player value = Data_Players[Data_Player._Id];
							value._Id = Data_Player._Id;
							value._Name = Data_Player._Name;
							value._Lv = Data_Player._Lv;
							value._MapId = Data_Player._MapId;
							value._MapX = Data_Player._MapX;
							value._MapY = Data_Player._MapY;
							value._Reborn = Data_Player._Reborn;
							value._ThuocTinh = Data_Player._ThuocTinh;
							value._Online = "ON";
							Data_Players[Data_Player._Id] = value;
						}
						else
						{
							PlayerCount++;
							Listplayers._Player value2 = new Listplayers._Player
							{
								_Id = Data_Player._Id,
								_Name = Data_Player._Name,
								_Lv = Data_Player._Lv,
								_MapId = Data_Player._MapId,
								_MapX = Data_Player._MapX,
								_MapY = Data_Player._MapY,
								_Reborn = Data_Player._Reborn,
								_ThuocTinh = Data_Player._ThuocTinh,
								_Online = "ON"
							};
							Data_Players.Add(Data_Player._Id, value2);
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
					API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - Update_H5] :" + ex2.Message + stackTrace.GetFrame(0).GetFileLineNumber() + "\r\n");
					ProjectData.ClearProjectError();
				}
			}
		}


		private void HandleAstrolabeBonus(byte[] packet)
		{
			checked
			{
				try
				{
					byte b = packet[5];
					if (b != 1 || packet[6] != 1)
					{
						return;
					}
					int num = packet[7];
					int num2 = packet[8];
					int num3 = packet[9];
					int num4 = packet[10];
					int num5 = packet[11];
					int num6 = packet[12];
					int num7 = num3;
					for (int i = 0; i <= num7; i++)
					{
						if (Astrolabes._int.ContainsKey(i))
						{
							Data_Player._Int4 += Astrolabes._int[i];
						}
					}
					int num8 = num6;
					for (int j = 0; j <= num8; j++)
					{
						if (Astrolabes._atk.ContainsKey(j))
						{
							Data_Player._Atk4 += Astrolabes._atk[j];
						}
					}
					int num9 = num2;
					for (int k = 0; k <= num9; k++)
					{
						if (Astrolabes._def.ContainsKey(k))
						{
							Data_Player._Def4 += Astrolabes._def[k];
						}
					}
					int num10 = num;
					for (int l = 0; l <= num10; l++)
					{
						if (Astrolabes._hpx.ContainsKey(l))
						{
							Data_Player._Hpx4 += Astrolabes._hpx[l];
						}
					}
					int num11 = num4;
					for (int m = 0; m <= num11; m++)
					{
						if (Astrolabes._spx.ContainsKey(m))
						{
							Data_Player._Spx4 += Astrolabes._spx[m];
						}
					}
					int num12 = num5;
					for (int n = 0; n <= num12; n++)
					{
						if (Astrolabes._agi.ContainsKey(n))
						{
							Data_Player._Agi4 += Astrolabes._agi[n];
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					StackTrace stackTrace = new StackTrace(true);
					stackTrace = new StackTrace(ex2, true);
					API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - Update_H4E] :" + ex2.Message + stackTrace.GetFrame(0).GetFileLineNumber() + "\r\n");
					ProjectData.ClearProjectError();
				}
			}
		}

	}
}
