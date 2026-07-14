using System;
using System.Diagnostics;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Simple_Bot
{
	public partial class _ClientBot
	{
		public int Getnumber(string txt)
		{
			string text = " __ @(  )@ )( @(__)@";
			string text2 = " ___ @(__ \\@/ __/@\\___)@";
			string text3 = " ___ @(__ )@ (_ \\@(___/@";
			string text4 = "  __  @ / ,) @(_  _)@  (_) @";
			string text5 = " ___ @/ __)@\\__ \\@(___/@";
			string text6 = "  _  @ / ) @/ , \\@\\___/@";
			string text7 = " ___ @(__ )@ / / @(_/  @";
			string text8 = " ___ @( , )@/ , \\@\\___/@";
			string text9 = " ___ @/ , \\@\\   /@ (_/ @";
			int num = 0;
			if (text.Contains(txt))
			{
				num = 1;
			}
			if (text2.Contains(txt))
			{
				num = 2;
			}
			if (text3.Contains(txt))
			{
				num = 3;
			}
			if (text4.Contains(txt))
			{
				num = 4;
			}
			if (text5.Contains(txt))
			{
				num = 5;
			}
			if (text6.Contains(txt))
			{
				num = 6;
			}
			if (text7.Contains(txt))
			{
				num = 7;
			}
			if (text8.Contains(txt))
			{
				num = 8;
			}
			if (text9.Contains(txt))
			{
				num = 9;
			}
			if (num == 0)
			{
				num = Getnumber1(txt);
			}
			return num;
		}

		public int Getnumber1(string txt)
		{
			string text = "  __ @ /  )@  )( @ (__)@";
			string text2 = " ___  @(__ \\ @ / _/ @(____)@";
			string text3 = " ___ @(__ )@ (_ \\@(___/@";
			string text4 = "  __  @ /. | @(_  _)@  (_) @";
			string text5 = " ___ @| __)@|__ \\@(___/@";
			string text6 = "  _  @ / ) @/ _ \\@\\___/@";
			string text7 = " ___ @(__ )@ / / @(_/  @";
			string text8 = " ___ @( _ )@/ _ \\@\\___/@";
			string text9 = " ___ @/ _ \\@\\_  /@ (_/ @";
			int result = 0;
			if (text.Contains(txt))
			{
				result = 1;
			}
			if (text2.Contains(txt))
			{
				result = 2;
			}
			if (text3.Contains(txt))
			{
				result = 3;
			}
			if (text4.Contains(txt))
			{
				result = 4;
			}
			if (text5.Contains(txt))
			{
				result = 5;
			}
			if (text6.Contains(txt))
			{
				result = 6;
			}
			if (text7.Contains(txt))
			{
				result = 7;
			}
			if (text8.Contains(txt))
			{
				result = 8;
			}
			if (text9.Contains(txt))
			{
				result = 9;
			}
			return result;
		}

		private void HandleCaptchaChallenge(byte[] packet)
		{
			checked
			{
				try
				{
					byte b = packet[5];
					if (b != 2 || _Proxy)
					{
						return;
					}
					if (ComboBox_Port == 0)
					{
						byte[] bytes = API.ByteArrayToByteArray(packet, 6);
						string antibot_str = API.VISCII_to_Unicode(Encoding.Default.GetString(bytes));
						_Antibot_str = antibot_str;
						_Antibot_ask = 1;
						return;
					}
					byte[] bytes2 = API.ByteArrayToByteArray(packet, 6);
					string text = API.VISCII_to_Unicode(Encoding.Default.GetString(bytes2));
					text = text.Substring(text.LastIndexOf(":") + 1);
					string text2 = "";
					string text3 = "";
					string text4 = "";
					string text5 = "";
					int num = 1;
					text = text.Replace("\r\n", "");
					text = text.Substring(0, text.Length - 1);
					string[] array = text.Split('\t');
					foreach (string text6 in array)
					{
						switch (num)
						{
						case 1:
							text2 = text2 + text6 + "@";
							break;
						case 2:
							text3 = text3 + text6 + "@";
							break;
						case 3:
							text4 = text4 + text6 + "@";
							break;
						case 4:
							text5 = text5 + text6 + "@";
							num = 0;
							break;
						}
						num++;
					}
					int num2 = 0;
					int num3 = 0;
					int num4 = 0;
					int num5 = 0;
					if (num2 == 0)
					{
						num2 = Getnumber(text2);
					}
					if (num3 == 0)
					{
						num3 = Getnumber(text3);
					}
					if (num4 == 0)
					{
						num4 = Getnumber(text4);
					}
					if (num5 == 0)
					{
						num5 = Getnumber(text5);
					}
					SendPacket(API.hexstringtobyte("F44406003701" + Strings.Asc(num2.ToString()).ToString("X2") + Strings.Asc(num3.ToString()).ToString("X2") + Strings.Asc(num4.ToString()).ToString("X2") + Strings.Asc(num5.ToString()).ToString("X2")));
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - Update_H1A] :" + ex2.Message + "\r\n");
					ProjectData.ClearProjectError();
				}
			}
		}

	}
}
