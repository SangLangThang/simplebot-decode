using System;
using System.Diagnostics;
using System.Drawing;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Simple_Bot
{
	public partial class _ClientBot
	{
		// opcode 2
		private void HandleChatMessage(byte[] packet)
		{
			checked
			{
				try
				{
					if (packet.Length < 11)
					{
						return;
					}
					string text = "";
					int num = packet.Length - 1;
					for (int i = 10; i <= num; i++)
					{
						text += Conversions.ToString(Strings.Chr(packet[i]));
					}
					text = API.VISCII_to_Unicode(text);
					int key = Convert.ToInt32(API.bytestohexstring(new byte[4]
					{
						packet[9],
						packet[8],
						packet[7],
						packet[6]
					}), 16);
					string text2 = "";
					if (Data_Players.ContainsKey(key))
					{
						text2 = Data_Players[key]._Name;
					}
					switch (packet[5])
					{
					case 1:
						API.AddColorText_Chat(this, Rtbchat, "[Toàn] " + text2 + ": " + text, Color.Khaki);
						break;
					case 2:
						API.AddColorText_Chat(this, Rtbchat, "[Gần] " + text2 + ": " + text, Color.Gold);
						break;
					case 3:
						if (Operators.CompareString(text2, Data_Player._Name, false) != 0)
						{
							if (Strings.LCase(text).StartsWith("!dis ") | Strings.LCase(text).StartsWith("!dis-r "))
							{
								string text3 = Strings.LCase(TextBox_RemoteDis);
								if (Operators.CompareString(Strings.LCase(text), "!dis " + text3, false) == 0)
								{
									C_CheckBox_Reconnect = false;
									API.AddColorText2(this, Rtbsystem, "Ngắt kết nối từ xa!", Color.Red);
									_Disconnect();
								}
								else if (Operators.CompareString(Strings.LCase(text), "!dis-r " + text3, false) == 0)
								{
									API.AddColorText2(this, Rtbsystem, "Ngắt kết nối từ xa, kết nối lại sau 15 phút!", Color.Red);
									_Disconnect();
									REMOTE_DIS = true;
									Delay_REMOTE_DIS = 0;
								}
							}
							else
							{
								API.AddColorText_Chat(this, Rtbchat, "[Thì thầm] " + text2 + " -> " + Data_Player._Name + ": " + text, Color.Orange);
							}
						}
						else
						{
							API.AddColorText_Chat(this, Rtbchat, "[Thì thầm] " + Data_Player._Name + " -> " + ComboBox_namePublic + ": " + text, Color.Orange);
						}
						break;
					case 4:
						API.AddColorText_Chat(this, Rtbchat, "[GM] " + text2 + ": " + text, Color.Red);
						break;
					case 5:
						API.AddColorText_Chat(this, Rtbchat, "[Đội] " + text2 + ": " + text, Color.White);
						break;
					case 6:
						API.AddColorText_Chat(this, Rtbchat, "[Đoàn] " + text2 + ": " + text, Color.DodgerBlue);
						break;
					case 7:
						API.AddColorText_Chat(this, Rtbchat, "[Liên Minh] " + text2 + ": " + text, Color.Green);
						break;
					case 11:
						API.AddColorText_Chat(this, Rtbchat, "Công bố hệ thống: " + text, Color.Red);
						break;
					case 12:
					{
						text = "";
						int num2 = packet.Length - 1;
						for (int j = 7; j <= num2; j++)
						{
							text += Conversions.ToString(Strings.Chr(packet[j]));
						}
						text = API.VISCII_to_Unicode(text);
						API.AddColorText_Chat(this, Rtbchat, "Công bố hệ thống: " + text, Color.Red);
						break;
					}
					default:
						API.AddColorText_Chat(this, Rtbchat, "Công bố hệ thống: " + text, Color.Red);
						break;
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					StackTrace stackTrace = new StackTrace(true);
					stackTrace = new StackTrace(ex2, true);
					API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - Update_H2] :" + ex2.Message + stackTrace.GetFrame(0).GetFileLineNumber() + "\r\n");
					ProjectData.ClearProjectError();
				}
			}
		}
	}
}
