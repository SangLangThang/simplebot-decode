using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace Simple_Bot
{
	public partial class _ClientBot
	{
		// opcode 0
		private void HandleLoginFailure(byte[] packet)
		{
			try
			{
				if (packet.Length >= 6)
				{
					switch (packet[5])
					{
					case 2:
						API.AddColorText2(this, Rtbsystem, "!!!Trả lời câu hỏi đăng nhập sai!!!", Color.Red);
						break;
					case 3:
						API.AddColorText2(this, Rtbsystem, "!!!Đăng nhập sai quá 3 lần!!!", Color.Red);
						break;
					case 9:
						API.AddColorText2(this, Rtbsystem, "!!!Mất kết nối không xác định!!!", Color.Red);
						break;
					case 17:
						API.AddColorText2(this, Rtbsystem, "!!!Phiên bản không phù hợp!!!", Color.Red);
						break;
					case 19:
						API.AddColorText2(this, Rtbsystem, "!!!Đăng nhập quá nhanh!!!", Color.Red);
						break;
					case 20:
						API.AddColorText2(this, Rtbsystem, "!!!Mất kết nối do có sự đăng nhập khác!!!", Color.Red);
						break;
					case 31:
						API.AddColorText2(this, Rtbsystem, "!!!Không thể dử dụng ID này!!!", Color.Red);
						break;
					case 56:
						API.AddColorText2(this, Rtbsystem, "!!!Máy chủ đầy!!!", Color.Red);
						break;
					default:
						API.AddColorText2(this, Rtbsystem, "!!!Đăng nhập thất bại! Mã lỗi: " + packet[5], Color.Red);
						break;
					}
					API.AddColorText2(this, Rtbsystem, "mất kết nối được từ máy chủ(4)!", Color.Red);
					_Disconnect();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				StackTrace stackTrace = new StackTrace(true);
				stackTrace = new StackTrace(ex2, true);
				API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - Update_H0] :" + ex2.Message + stackTrace.GetFrame(0).GetFileLineNumber() + "\r\n");
				ProjectData.ClearProjectError();
			}
		}

		// opcode 1
		private void HandleLoginFlow(byte[] packet)
		{
			checked
			{
				try
				{
					switch (packet[5])
					{
					case 1:
					{
						if (packet.Length < 8)
						{
							break;
						}
						int key = Convert.ToInt32(API.bytestohexstring(new byte[4]
						{
							packet[9],
							packet[8],
							packet[7],
							packet[6]
						}), 16);
						if (Data_Players.ContainsKey(key))
						{
							Listplayers._Player player = Data_Players[key];
							if (Operators.CompareString(player._Online, "ON", false) == 0)
							{
								PlayerCount--;
								player._Online = "OFF";
							}
						}
						break;
					}
					case 3:
						if (!_Check_CreatCharacter)
						{
						}
						break;
					case 6:
						API.AddColorText2(this, Rtbsystem, "ID hoặc Mật khẩu không đúng !!!", Color.Red);
						break;
					case 9:
						API.AddColorText2(this, Rtbsystem, "Đang đăng nhập...", Color.Red);
						_checkconnect = 0;
						SendLoginPacket(versionlogin, idlogin, passlogin);
						createdchar = 0;
						break;
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					StackTrace stackTrace = new StackTrace(true);
					stackTrace = new StackTrace(ex2, true);
					API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - Update_H1] :" + ex2.Message + stackTrace.GetFrame(0).GetFileLineNumber() + "\r\n");
					ProjectData.ClearProjectError();
				}
			}
		}

		// opcode 53: case 3 clears a battle slot (unrelated monster/player left combat);
		// case 13 is the (much larger) login-success bootstrap. Kept as one method since
		// the original protocol legitimately reuses this opcode for both.
		private void HandleLoginSuccessOrBattleSlotClear(byte[] packet)
		{
			try
			{
				switch (packet[5])
				{
				case 3:
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
					break;
				}
				case 13:
					if (logined != 0)
					{
						break;
					}
					logined = 1;
					Online = "ON";
					Status = "Đăng nhập thành công!!!";
					Walk(Data_Player._MapX, Data_Player._MapY);
					if (API.Proxy && ((API.Vip > 0) & API.List_Ip_nts.Contains(API.ServerIp)))
					{
						byte[] packet2Local = API.hexstringtobyte(API.Packet_Maker("08010201" + API.Vip.ToString("X2")));
						_Local_SendPacket(packet2Local);
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
						int num = Conversions.ToInteger(arrayList[0]);
						int num2 = Conversions.ToInteger(arrayList[1]);
						int num3 = Conversions.ToInteger(arrayList[2]);
						int num4 = Conversions.ToInteger(arrayList[3]);
						int num5 = Conversions.ToInteger(arrayList[4]);
						string text = "";
						if (num > 0)
						{
							text = text + API.Int32ToHex2(num) + "0000000000000000";
						}
						if (num2 > 0)
						{
							text = text + API.Int32ToHex2(num2) + "0000000000000000";
						}
						if (num3 > 0)
						{
							text = text + API.Int32ToHex2(num3) + "0000000000000000";
						}
						if (num4 > 0)
						{
							text = text + API.Int32ToHex2(num4) + "0000000000000000";
						}
						if (num5 > 0)
						{
							text = text + API.Int32ToHex2(num5) + "0000000000000000";
						}
						packet2Local = API.hexstringtobyte(API.Packet_Maker("170B" + text));
						_Local_SendPacket(packet2Local);
						text = "";
						if (num > 0)
						{
							text += API.Int32ToHex2(num);
						}
						if (num2 > 0)
						{
							text += API.Int32ToHex2(num2);
						}
						if (num3 > 0)
						{
							text += API.Int32ToHex2(num3);
						}
						if (num4 > 0)
						{
							text += API.Int32ToHex2(num4);
						}
						if (num5 > 0)
						{
							text += API.Int32ToHex2(num5);
						}
						int textBox_IDmem = TextBox_IDmem1;
						int textBox_IDmem2 = TextBox_IDmem2;
						int textBox_IDmem3 = TextBox_IDmem3;
						int textBox_IDmem4 = TextBox_IDmem4;
						byte[] packet2 = API.hexstringtobyte(API.Packet_Maker("0500" + API.Int32ToHex4(textBox_IDmem) + text));
						byte[] packet3 = API.hexstringtobyte(API.Packet_Maker("0500" + API.Int32ToHex4(textBox_IDmem2) + text));
						byte[] packet4 = API.hexstringtobyte(API.Packet_Maker("0500" + API.Int32ToHex4(textBox_IDmem3) + text));
						byte[] packet5 = API.hexstringtobyte(API.Packet_Maker("0500" + API.Int32ToHex4(textBox_IDmem4) + text));
						_Local_SendPacket(packet2);
						_Local_SendPacket(packet3);
						_Local_SendPacket(packet4);
						_Local_SendPacket(packet5);
						if (API.IDNgua > 0)
						{
							packet2 = API.hexstringtobyte(API.Packet_Maker("0F05" + API.Int32ToHex4(textBox_IDmem) + API.Int32ToHex4(API.IDNgua) + "00000000"));
							packet3 = API.hexstringtobyte(API.Packet_Maker("0F05" + API.Int32ToHex4(textBox_IDmem2) + API.Int32ToHex4(API.IDNgua) + "00000000"));
							packet4 = API.hexstringtobyte(API.Packet_Maker("0F05" + API.Int32ToHex4(textBox_IDmem3) + API.Int32ToHex4(API.IDNgua) + "00000000"));
							packet5 = API.hexstringtobyte(API.Packet_Maker("0F05" + API.Int32ToHex4(textBox_IDmem4) + API.Int32ToHex4(API.IDNgua) + "00000000"));
							_Local_SendPacket(packet2);
							_Local_SendPacket(packet3);
							_Local_SendPacket(packet4);
							_Local_SendPacket(packet5);
						}
					}
					time_online = 0L;
					_checkdisExp = 0;
					_checkdisFullHomdo = 0;
					_checkconnect = 0;
					if (_stt_send > 0)
					{
						_stt_send = 0;
					}
					logined = 1;
					time_online = 0L;
					_checkdisExp = 0;
					_checkconnect = 0;
					Label_BDY = "Gửi Ba Đậu Yêu";
					API.AddColorText2(this, Rtbsystem, "Đăng nhập thành công!", Color.DeepPink);
					if (C_CheckBox_AutoEquitExp)
					{
						int id = Data_CharEquit[5]._Id;
						int doben = Data_CharEquit[5]._Doben;
						if (id == 0 || id == 23024 || doben >= 250)
						{
							foreach (_Data._Tuido value2 in Data_Tuido.Values)
							{
								int id2 = value2._Id;
								int stt = value2._Stt;
								if (id2 > 0 && Items.Data_Items.ContainsKey(id2) && IDNgocEXP.Contains(Items.Data_Items[id2]._Type))
								{
									CharEquit(stt, 1);
									break;
								}
							}
						}
					}
					if (C_CheckBox_OpenMachine)
					{
						OpenMachineBox();
					}
					if (C_CheckBox_TuLenNgua)
					{
						LenNgua();
					}
					if ((Data_Player._MapId >= 10800) & (Data_Player._MapId <= 10820))
					{
						string text2 = "F444040014080100F44402001406F44402001406F44402001406F44402001406F44402001406F44402001406F44402001406F44402001406F44402001406";
						SendPacket(API.hexstringtobyte(text2));
						createdchar = 1;
					}
					if ((Data_Player._MapId >= 10850) & (Data_Player._MapId <= 10870))
					{
						Walk(1262, 255);
						string text3 = "F44404001401" + API.Int32ToHex2(2) + "F444030014091EF44402001406F44402001406F44402001406F44402001406F44402001406F44402001406F44402001406F44402001406F44402001406F444040014080200F444030014091EF44402001406F44402001406";
						SendPacket(API.hexstringtobyte(text3));
						createdchar = 1;
					}
					if (C_CheckBox_AutoEat)
					{
						CharEatHp();
						CharEatSp();
						PetEatHp();
						PetEatSp();
					}
					if (bott == 1)
					{
						Thread.Sleep(1000);
						_StartBot();
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
				API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - Update_H35] :" + ex2.Message + stackTrace.GetFrame(0).GetFileLineNumber() + "\r\n");
				ProjectData.ClearProjectError();
			}
		}
	}
}
