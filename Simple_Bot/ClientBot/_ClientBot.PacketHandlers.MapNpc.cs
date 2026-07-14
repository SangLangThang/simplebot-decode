using System;
using System.Collections;
using System.Diagnostics;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace Simple_Bot
{
	public partial class _ClientBot
	{
		private void HandleMapArrival(byte[] packet)
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
				if (num != Data_Player._Id)
				{
					return;
				}
				if (Data_NpcInMap.Count > 0)
				{
					Data_NpcInMap.Clear();
				}
				SendPacket(API.hexstringtobyte("F44402001730"));
				SendPacket(API.hexstringtobyte("F44402000C01"));
				if (C_CheckBox_OpenMachine)
				{
					OpenMachineBox();
				}
				int num2 = 0;
				do
				{
					Data_ItemOnMaps[num2] = default(_Data._ItemOnMap);
					num2 = checked(num2 + 1);
				}
				while (num2 <= 254);
				Data_Player._MapId = Convert.ToInt32(API.bytestohexstring(new byte[2]
				{
					packet[10],
					packet[9]
				}), 16);
				Data_Player._MapX = Convert.ToInt32(API.bytestohexstring(new byte[2]
				{
					packet[12],
					packet[11]
				}), 16);
				Data_Player._MapY = Convert.ToInt32(API.bytestohexstring(new byte[2]
				{
					packet[14],
					packet[13]
				}), 16);
				Data_Player._MapName = MyProject.Forms.MainForm.Getmapname(Conversions.ToInteger(Data_Player._MapId.ToString()));
				Thread.Sleep(200);
				if ((Data_Player._LeaderId == Data_Player._Id) | (Data_Player._LeaderId == 0))
				{
					if ((atw == 1) & (listWarp.Count > 0) & (BTQ == 0))
					{
						SendEnd();
						if ((Data_Player._MapId == 58000) & (Conversions.ToDouble(AutoWarptoMap) != 58000.0))
						{
							Warp(1);
						}
						else
						{
							string text = Data_Player._MapId.ToString();
							int num3 = 0;
							string autoWarptoMap = AutoWarptoMap;
							if (Operators.CompareString(autoWarptoMap, Conversions.ToString(55000), false) == 0)
							{
								string left = text;
								if (Operators.CompareString(left, Conversions.ToString(11000), false) == 0)
								{
									num3 = 1;
									Warp(11);
								}
								else if (Operators.CompareString(left, Conversions.ToString(58000), false) == 0)
								{
									num3 = 1;
									Warp(1);
								}
							}
							else if (Operators.CompareString(autoWarptoMap, Conversions.ToString(58000), false) == 0)
							{
								string left2 = text;
								if (Operators.CompareString(left2, Conversions.ToString(11000), false) == 0)
								{
									num3 = 1;
									Warp(11);
								}
								else if (Operators.CompareString(left2, Conversions.ToString(55000), false) == 0)
								{
									num3 = 1;
									Warp(1);
								}
							}
							if (num3 == 0)
							{
								string mapIdNext = GetMapIdNext(listWarp, text);
								int warpID = GetWarpID(text, mapIdNext);
								if (Operators.CompareString(mapIdNext, AutoWarptoMap, false) == 0)
								{
									if (warpID > 0)
									{
										Warp(warpID);
									}
									else
									{
										listWarp.Clear();
										atw = 0;
									}
								}
								else if (Operators.CompareString(mapIdNext, AutoWarptoMap, false) != 0)
								{
									if (warpID > 0)
									{
										Warp(warpID);
									}
									else
									{
										listWarp.Clear();
										atw = 0;
									}
								}
							}
						}
					}
					else
					{
						SendEnd();
					}
				}
				if ((Data_Player._MapId >= 10850) & (Data_Player._MapId <= 10870))
				{
					SendEnd();
					Walk(1262, 255);
					string text2 = "F44404001401" + API.Int32ToHex2(2) + "F444030014091EF44402001406F44402001406F44402001406F44402001406F44402001406F44402001406F44402001406F44402001406F44402001406F444040014080200F444030014091EF44402001406F44402001406";
					SendPacket(API.hexstringtobyte(text2));
					createdchar = 1;
				}
				if (C_CheckBox_autosell)
				{
					int mapId = Data_Player._MapId;
					if (mapId == 12223)
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
						AutoWarptoMap = "12223";
						AutoWarp(AutoWarptoMap);
					}
				}
				if (API.Proxy & API.List_Ip_nts.Contains(API.ServerIp))
				{
					if (API.Vip == 0)
					{
						try
						{
							int textBox_IDmem = TextBox_IDmem1;
							int textBox_IDmem2 = TextBox_IDmem2;
							int textBox_IDmem3 = TextBox_IDmem3;
							int textBox_IDmem4 = TextBox_IDmem4;
							byte[] packet1 = API.hexstringtobyte(API.Packet_Maker("080D" + API.Int32ToHex4(textBox_IDmem) + API.Vip.ToString("X2")));
							byte[] packet2 = API.hexstringtobyte(API.Packet_Maker("080D" + API.Int32ToHex4(textBox_IDmem2) + API.Vip.ToString("X2")));
							byte[] packet3 = API.hexstringtobyte(API.Packet_Maker("080D" + API.Int32ToHex4(textBox_IDmem3) + API.Vip.ToString("X2")));
							byte[] packet4 = API.hexstringtobyte(API.Packet_Maker("080D" + API.Int32ToHex4(textBox_IDmem4) + API.Vip.ToString("X2")));
							_Local_SendPacket(packet1);
							_Local_SendPacket(packet2);
							_Local_SendPacket(packet3);
							_Local_SendPacket(packet4);
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							ProjectData.ClearProjectError();
						}
					}
					else
					{
						try
						{
							int textBox_IDmem5 = TextBox_IDmem1;
							int textBox_IDmem6 = TextBox_IDmem2;
							int textBox_IDmem7 = TextBox_IDmem3;
							int textBox_IDmem8 = TextBox_IDmem4;
							byte[] packet5 = API.hexstringtobyte(API.Packet_Maker("080D" + API.Int32ToHex4(textBox_IDmem5) + API.Vip.ToString("X2")));
							byte[] packet6 = API.hexstringtobyte(API.Packet_Maker("080D" + API.Int32ToHex4(textBox_IDmem6) + API.Vip.ToString("X2")));
							byte[] packet7 = API.hexstringtobyte(API.Packet_Maker("080D" + API.Int32ToHex4(textBox_IDmem7) + API.Vip.ToString("X2")));
							byte[] packet8 = API.hexstringtobyte(API.Packet_Maker("080D" + API.Int32ToHex4(textBox_IDmem8) + API.Vip.ToString("X2")));
							_Local_SendPacket(packet5);
							_Local_SendPacket(packet6);
							_Local_SendPacket(packet7);
							_Local_SendPacket(packet8);
						}
						catch (Exception ex3)
						{
							ProjectData.SetProjectError(ex3);
							Exception ex4 = ex3;
							ProjectData.ClearProjectError();
						}
					}
					ArrayList arrayList = new ArrayList();
					switch (API.Style)
					{
					case 0:
						arrayList = API.List_Style0;
						break;
					case 1:
						arrayList = API.List_Style1;
						break;
					case 2:
						arrayList = API.List_Style2;
						break;
					case 3:
						arrayList = API.List_Style3;
						break;
					case 4:
						arrayList = API.List_Style4;
						break;
					}
					int num4 = Conversions.ToInteger(arrayList[0]);
					int num5 = Conversions.ToInteger(arrayList[1]);
					int num6 = Conversions.ToInteger(arrayList[2]);
					int num7 = Conversions.ToInteger(arrayList[3]);
					int num8 = Conversions.ToInteger(arrayList[4]);
					string text3 = "";
					if (num4 > 0)
					{
						text3 = text3 + API.Int32ToHex2(num4) + "0000000000000000";
					}
					if (num5 > 0)
					{
						text3 = text3 + API.Int32ToHex2(num5) + "0000000000000000";
					}
					if (num6 > 0)
					{
						text3 = text3 + API.Int32ToHex2(num6) + "0000000000000000";
					}
					if (num7 > 0)
					{
						text3 = text3 + API.Int32ToHex2(num7) + "0000000000000000";
					}
					if (num8 > 0)
					{
						text3 = text3 + API.Int32ToHex2(num8) + "0000000000000000";
					}
					byte[] packet9 = API.hexstringtobyte(API.Packet_Maker("170B" + text3));
					_Local_SendPacket(packet9);
					text3 = "";
					if (num4 > 0)
					{
						text3 += API.Int32ToHex2(num4);
					}
					if (num5 > 0)
					{
						text3 += API.Int32ToHex2(num5);
					}
					if (num6 > 0)
					{
						text3 += API.Int32ToHex2(num6);
					}
					if (num7 > 0)
					{
						text3 += API.Int32ToHex2(num7);
					}
					if (num8 > 0)
					{
						text3 += API.Int32ToHex2(num8);
					}
					int textBox_IDmem9 = TextBox_IDmem1;
					int textBox_IDmem10 = TextBox_IDmem2;
					int textBox_IDmem11 = TextBox_IDmem3;
					int textBox_IDmem12 = TextBox_IDmem4;
					byte[] packet10 = API.hexstringtobyte(API.Packet_Maker("0500" + API.Int32ToHex4(textBox_IDmem9) + text3));
					byte[] packet11 = API.hexstringtobyte(API.Packet_Maker("0500" + API.Int32ToHex4(textBox_IDmem10) + text3));
					byte[] packet12 = API.hexstringtobyte(API.Packet_Maker("0500" + API.Int32ToHex4(textBox_IDmem11) + text3));
					byte[] packet13 = API.hexstringtobyte(API.Packet_Maker("0500" + API.Int32ToHex4(textBox_IDmem12) + text3));
					_Local_SendPacket(packet10);
					_Local_SendPacket(packet11);
					_Local_SendPacket(packet12);
					_Local_SendPacket(packet13);
					if (API.IDNgua > 0)
					{
						packet10 = API.hexstringtobyte(API.Packet_Maker("0F05" + API.Int32ToHex4(textBox_IDmem9) + API.Int32ToHex4(API.IDNgua) + "00000000"));
						packet11 = API.hexstringtobyte(API.Packet_Maker("0F05" + API.Int32ToHex4(textBox_IDmem10) + API.Int32ToHex4(API.IDNgua) + "00000000"));
						packet12 = API.hexstringtobyte(API.Packet_Maker("0F05" + API.Int32ToHex4(textBox_IDmem11) + API.Int32ToHex4(API.IDNgua) + "00000000"));
						packet13 = API.hexstringtobyte(API.Packet_Maker("0F05" + API.Int32ToHex4(textBox_IDmem12) + API.Int32ToHex4(API.IDNgua) + "00000000"));
						_Local_SendPacket(packet10);
						_Local_SendPacket(packet11);
						_Local_SendPacket(packet12);
						_Local_SendPacket(packet13);
					}
				}
				if (bott == 1)
				{
					StartBot();
				}
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				StackTrace stackTrace = new StackTrace(true);
				stackTrace = new StackTrace(ex6, true);
				API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - Update_HC] :" + ex6.Message + stackTrace.GetFrame(0).GetFileLineNumber() + "\r\n");
				ProjectData.ClearProjectError();
			}
		}


		private void HandleNpcMapUpdate(byte[] packet)
		{
			checked
			{
				try
				{
					switch (packet[5])
					{
					case 2:
					{
						int num8 = Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							packet[7],
							packet[6]
						}), 16);
						if (Data_NpcInMap.ContainsKey(num8))
						{
							int num9 = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								packet[9],
								packet[8]
							}), 16);
							int num10 = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								packet[11],
								packet[10]
							}), 16);
							int num11 = (int)Math.Round(Math.Sqrt(Math.Pow(Data_Player._MapX - num9, 2.0) + Math.Pow(Data_Player._MapY - num10, 2.0)));
							this.set_DataNpcInMap(num8, _Data.Type_NpcInMap._MapX, (object)num9);
							this.set_DataNpcInMap(num8, _Data.Type_NpcInMap._MapY, (object)num10);
							this.set_DataNpcInMap(num8, _Data.Type_NpcInMap._KC, (object)num11);
						}
						else
						{
							int num12 = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								packet[9],
								packet[8]
							}), 16);
							int num13 = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								packet[11],
								packet[10]
							}), 16);
							int kC2 = (int)Math.Round(Math.Sqrt(Math.Pow(Data_Player._MapX - num12, 2.0) + Math.Pow(Data_Player._MapY - num13, 2.0)));
							_Data._NpcInMap value2 = new _Data._NpcInMap
							{
								_Id = num8,
								_MapX = num12,
								_MapY = num13,
								_Delay = 0,
								_KC = kC2
							};
							Data_NpcInMap.Add(num8, value2);
						}
						break;
					}
					case 3:
					{
						int num7 = Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							packet[7],
							packet[6]
						}), 16);
						if (Data_NpcInMap.ContainsKey(num7))
						{
							this.set_DataNpcInMap(num7, _Data.Type_NpcInMap._Delay, (object)(Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								packet[9],
								packet[8]
							}), 16) + 2));
						}
						break;
					}
					case 4:
					{
						if (Data_NpcInMap.Count > 0)
						{
							Data_NpcInMap.Clear();
						}
						string text = API.bytestohexstring(packet).Substring(12);
						while (text.Length != 0)
						{
							byte[] array = API.hexstringtobyte(text.Substring(0, 26));
							int num14 = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								array[1],
								array[0]
							}), 16);
							if (!Data_NpcInMap.ContainsKey(num14))
							{
								int num15 = Convert.ToInt32(API.bytestohexstring(new byte[2]
								{
									array[5],
									array[4]
								}), 16);
								int num16 = Convert.ToInt32(API.bytestohexstring(new byte[2]
								{
									array[7],
									array[6]
								}), 16);
								int kC3 = (int)Math.Round(Math.Sqrt(Math.Pow(Data_Player._MapX - num15, 2.0) + Math.Pow(Data_Player._MapY - num16, 2.0)));
								_Data._NpcInMap value3 = new _Data._NpcInMap
								{
									_Id = num14,
									_MapX = num15,
									_MapY = num16,
									_Delay = 0,
									_KC = kC3
								};
								Data_NpcInMap.Add(num14, value3);
							}
							text = text.Replace(API.bytestohexstring(array), "");
						}
						break;
					}
					case 5:
					{
						int num = Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							packet[7],
							packet[6]
						}), 16);
						if (Data_NpcInMap.ContainsKey(num))
						{
							int num2 = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								packet[9],
								packet[8]
							}), 16);
							int num3 = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								packet[11],
								packet[10]
							}), 16);
							int num4 = (int)Math.Round(Math.Sqrt(Math.Pow(Data_Player._MapX - num2, 2.0) + Math.Pow(Data_Player._MapY - num3, 2.0)));
							this.set_DataNpcInMap(num, _Data.Type_NpcInMap._MapX, (object)num2);
							this.set_DataNpcInMap(num, _Data.Type_NpcInMap._MapY, (object)num3);
							this.set_DataNpcInMap(num, _Data.Type_NpcInMap._KC, (object)num4);
						}
						else
						{
							int num5 = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								packet[9],
								packet[8]
							}), 16);
							int num6 = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								packet[11],
								packet[10]
							}), 16);
							int kC = (int)Math.Round(Math.Sqrt(Math.Pow(Data_Player._MapX - num5, 2.0) + Math.Pow(Data_Player._MapY - num6, 2.0)));
							_Data._NpcInMap value = new _Data._NpcInMap
							{
								_Id = num,
								_MapX = num5,
								_MapY = num6,
								_Delay = 0,
								_KC = kC
							};
							Data_NpcInMap.Add(num, value);
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
					API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - Update_H16] :" + ex2.Message + stackTrace.GetFrame(0).GetFileLineNumber() + "\r\n");
					ProjectData.ClearProjectError();
				}
			}
		}

	}
}
