using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using Microsoft.VisualBasic.CompilerServices;

namespace Simple_Bot
{
	public partial class _ClientBot
	{
		private void HandlePartyEvent(byte[] packet)
		{
			try
			{
				switch (packet[5])
				{
				case 1:
				{
					int num2 = API.HexToInt32(API.bytestohexstring(packet).Substring(12, 8));
					string namePlayer2 = GetNamePlayer(num2);
					API.AddColorText2(this, Rtbsystem, namePlayer2 + " xin vào nhóm", Color.Blue);
					if ((num2 == TextBox_IDmem1) | (num2 == TextBox_IDmem2) | (num2 == TextBox_IDmem3) | (num2 == TextBox_IDmem4))
					{
						LeaderAcceptedPartyFrom(num2);
					}
					break;
				}
				case 4:
				{
					int num6 = API.HexToInt32(API.bytestohexstring(packet).Substring(12, 8));
					int textBox_IDmem = TextBox_IDmem1;
					int textBox_IDmem2 = TextBox_IDmem2;
					int textBox_IDmem3 = TextBox_IDmem3;
					int textBox_IDmem4 = TextBox_IDmem4;
					int num7 = num6;
					if (num7 == textBox_IDmem)
					{
						_IDmem1 = 0;
						API.AddColorText2(this, Rtbsystem, GetNamePlayer(textBox_IDmem) + " rời khỏi nhóm!", Color.Blue);
						if (C_RadioButton_DCmemout)
						{
							_Disconnect();
							if (C_CheckBox_Reconnect)
							{
								_Connect();
							}
						}
					}
					else if (num7 == textBox_IDmem2)
					{
						_IDmem2 = 0;
						API.AddColorText2(this, Rtbsystem, GetNamePlayer(textBox_IDmem2) + " rời khỏi nhóm!", Color.Blue);
						if (C_RadioButton_DCmemout)
						{
							_Disconnect();
							if (C_CheckBox_Reconnect)
							{
								_Connect();
							}
						}
					}
					else if (num7 == textBox_IDmem3)
					{
						_IDmem3 = 0;
						API.AddColorText2(this, Rtbsystem, GetNamePlayer(textBox_IDmem3) + " rời khỏi nhóm!", Color.Blue);
						if (C_RadioButton_DCmemout)
						{
							_Disconnect();
							if (C_CheckBox_Reconnect)
							{
								_Connect();
							}
						}
					}
					else if (num7 == textBox_IDmem4)
					{
						_IDmem4 = 0;
						API.AddColorText2(this, Rtbsystem, GetNamePlayer(textBox_IDmem4) + " rời khỏi nhóm!", Color.Blue);
						if (C_RadioButton_DCmemout)
						{
							_Disconnect();
							if (C_CheckBox_Reconnect)
							{
								_Connect();
							}
						}
					}
					else if (num7 == Data_Player._LeaderId)
					{
						API.AddColorText2(this, Rtbsystem, "Chủ party đã giải tán nhóm!" + Conversions.ToString(num6), Color.Blue);
						Data_Player._LeaderId = 0;
						if (C_RadioButton_DCLeaderOut)
						{
							_Disconnect();
							if (C_CheckBox_Reconnect)
							{
								_Connect();
							}
						}
					}
					else if (num7 == Data_Player._Id)
					{
						API.AddColorText2(this, Rtbsystem, "Giải tán nhóm thành công!", Color.Blue);
						Data_Player._LeaderId = 0;
						if (C_RadioButton_DCmemout)
						{
							_Disconnect();
							if (C_CheckBox_Reconnect)
							{
								_Connect();
							}
						}
					}
					bool flag = false;
					bool flag2 = false;
					bool flag3 = false;
					bool flag4 = false;
					flag = (double)TextBox_IDmem1 == Conversions.ToDouble("0") || ((_IDmem1 != 0) ? true : false);
					flag2 = (double)TextBox_IDmem2 == Conversions.ToDouble("0") || ((_IDmem2 != 0) ? true : false);
					flag3 = (double)TextBox_IDmem3 == Conversions.ToDouble("0") || ((_IDmem3 != 0) ? true : false);
					flag4 = (double)TextBox_IDmem4 == Conversions.ToDouble("0") || ((_IDmem4 != 0) ? true : false);
					if (flag && flag2 && flag3 && flag4)
					{
						Data_Player._PartyFull = true;
					}
					else
					{
						Data_Player._PartyFull = false;
					}
					break;
				}
				case 5:
				{
					int num3 = API.HexToInt32(API.bytestohexstring(packet).Substring(12, 8));
					int num4 = API.HexToInt32(API.bytestohexstring(packet).Substring(20, 8));
					int id = Data_Player._Id;
					if (id == num3)
					{
						if (Data_Player._LeaderId == 0)
						{
							Data_Player._LeaderId = num3;
						}
						if (C_RadioButton_QS1)
						{
							SetQuanSu(TextBox_IDmem1);
						}
						else if (C_RadioButton_QS2)
						{
							SetQuanSu(TextBox_IDmem2);
						}
						else if (C_RadioButton_QS3)
						{
							SetQuanSu(TextBox_IDmem3);
						}
						else if (C_RadioButton_QS4)
						{
							SetQuanSu(TextBox_IDmem4);
						}
						int num5 = num4;
						if (num5 == TextBox_IDmem1)
						{
							_IDmem1 = num4;
							API.AddColorText2(this, Rtbsystem, GetNamePlayer(TextBox_IDmem1) + " vào nhóm thành công!", Color.Blue);
						}
						else if (num5 == TextBox_IDmem2)
						{
							_IDmem2 = num4;
							API.AddColorText2(this, Rtbsystem, GetNamePlayer(TextBox_IDmem2) + " vào nhóm thành công!", Color.Blue);
						}
						else if (num5 == TextBox_IDmem3)
						{
							_IDmem3 = num4;
							API.AddColorText2(this, Rtbsystem, GetNamePlayer(TextBox_IDmem3) + " vào nhóm thành công!", Color.Blue);
						}
						else if (num5 == TextBox_IDmem4)
						{
							_IDmem4 = num4;
							API.AddColorText2(this, Rtbsystem, GetNamePlayer(TextBox_IDmem4) + " vào nhóm thành công!", Color.Blue);
						}
						Data_Player._PartyFull = Party_CheckFull();
						if (bott == 1 && Data_Player._PartyFull)
						{
							ClickNPCId(99);
							StartBot();
						}
					}
					else if (id == num4)
					{
						if (Data_Player._LeaderId == 0)
						{
							Data_Player._LeaderId = num3;
						}
						API.AddColorText2(this, Rtbsystem, "Đã gia nhập vào nhóm của " + GetNamePlayer(num3), Color.Blue);
					}
					else if (Data_Player._LeaderId == num3)
					{
						API.AddColorText2(this, Rtbsystem, GetNamePlayer(num4) + " đã gia nhập vào nhóm", Color.Blue);
					}
					break;
				}
				case 9:
				{
					int num = API.HexToInt32(API.bytestohexstring(packet).Substring(12, 8));
					string namePlayer = GetNamePlayer(num);
					API.AddColorText2(this, Rtbsystem, namePlayer + " mời vào nhóm ", Color.Blue);
					if (num == TextBox_IdLeader)
					{
						MemAcceptPartyto(num);
					}
					break;
				}
				}
				if (!(API.Proxy & API.List_Ip_nts.Contains(API.ServerIp)))
				{
					return;
				}
				if (API.Vip == 0)
				{
					try
					{
						int textBox_IDmem5 = TextBox_IDmem1;
						int textBox_IDmem6 = TextBox_IDmem2;
						int textBox_IDmem7 = TextBox_IDmem3;
						int textBox_IDmem8 = TextBox_IDmem4;
						byte[] packet1 = API.hexstringtobyte(API.Packet_Maker("080D" + API.Int32ToHex4(textBox_IDmem5) + API.Vip.ToString("X2")));
						byte[] packet2 = API.hexstringtobyte(API.Packet_Maker("080D" + API.Int32ToHex4(textBox_IDmem6) + API.Vip.ToString("X2")));
						byte[] packet3 = API.hexstringtobyte(API.Packet_Maker("080D" + API.Int32ToHex4(textBox_IDmem7) + API.Vip.ToString("X2")));
						byte[] packet4 = API.hexstringtobyte(API.Packet_Maker("080D" + API.Int32ToHex4(textBox_IDmem8) + API.Vip.ToString("X2")));
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
						int textBox_IDmem9 = TextBox_IDmem1;
						int textBox_IDmem10 = TextBox_IDmem2;
						int textBox_IDmem11 = TextBox_IDmem3;
						int textBox_IDmem12 = TextBox_IDmem4;
						byte[] packet5 = API.hexstringtobyte(API.Packet_Maker("080D" + API.Int32ToHex4(textBox_IDmem9) + API.Vip.ToString("X2")));
						byte[] packet6 = API.hexstringtobyte(API.Packet_Maker("080D" + API.Int32ToHex4(textBox_IDmem10) + API.Vip.ToString("X2")));
						byte[] packet7 = API.hexstringtobyte(API.Packet_Maker("080D" + API.Int32ToHex4(textBox_IDmem11) + API.Vip.ToString("X2")));
						byte[] packet8 = API.hexstringtobyte(API.Packet_Maker("080D" + API.Int32ToHex4(textBox_IDmem12) + API.Vip.ToString("X2")));
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
				int num8 = Conversions.ToInteger(arrayList[0]);
				int num9 = Conversions.ToInteger(arrayList[1]);
				int num10 = Conversions.ToInteger(arrayList[2]);
				int num11 = Conversions.ToInteger(arrayList[3]);
				int num12 = Conversions.ToInteger(arrayList[4]);
				string text = "";
				if (num8 > 0)
				{
					text = text + API.Int32ToHex2(num8) + "0000000000000000";
				}
				if (num9 > 0)
				{
					text = text + API.Int32ToHex2(num9) + "0000000000000000";
				}
				if (num10 > 0)
				{
					text = text + API.Int32ToHex2(num10) + "0000000000000000";
				}
				if (num11 > 0)
				{
					text = text + API.Int32ToHex2(num11) + "0000000000000000";
				}
				if (num12 > 0)
				{
					text = text + API.Int32ToHex2(num12) + "0000000000000000";
				}
				byte[] packet9 = API.hexstringtobyte(API.Packet_Maker("170B" + text));
				_Local_SendPacket(packet9);
				text = "";
				if (num8 > 0)
				{
					text += API.Int32ToHex2(num8);
				}
				if (num9 > 0)
				{
					text += API.Int32ToHex2(num9);
				}
				if (num10 > 0)
				{
					text += API.Int32ToHex2(num10);
				}
				if (num11 > 0)
				{
					text += API.Int32ToHex2(num11);
				}
				if (num12 > 0)
				{
					text += API.Int32ToHex2(num12);
				}
				int textBox_IDmem13 = TextBox_IDmem1;
				int textBox_IDmem14 = TextBox_IDmem2;
				int textBox_IDmem15 = TextBox_IDmem3;
				int textBox_IDmem16 = TextBox_IDmem4;
				byte[] packet10 = API.hexstringtobyte(API.Packet_Maker("0500" + API.Int32ToHex4(textBox_IDmem13) + text));
				byte[] packet11 = API.hexstringtobyte(API.Packet_Maker("0500" + API.Int32ToHex4(textBox_IDmem14) + text));
				byte[] packet12 = API.hexstringtobyte(API.Packet_Maker("0500" + API.Int32ToHex4(textBox_IDmem15) + text));
				byte[] packet13 = API.hexstringtobyte(API.Packet_Maker("0500" + API.Int32ToHex4(textBox_IDmem16) + text));
				_Local_SendPacket(packet10);
				_Local_SendPacket(packet11);
				_Local_SendPacket(packet12);
				_Local_SendPacket(packet13);
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				StackTrace stackTrace = new StackTrace(true);
				stackTrace = new StackTrace(ex6, true);
				API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - Update_HD] :" + ex6.Message + stackTrace.GetFrame(0).GetFileLineNumber() + "\r\n");
				ProjectData.ClearProjectError();
			}
		}

	}
}
