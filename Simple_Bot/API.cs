using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Simple_Bot
{
	[StandardModule]
	public sealed class API
	{
		public struct _Type_LoadConfig
		{
			public string _path;

			public string _name;
		}

		public const short MAX_PATH = 260;

		public static string Setting_Path = MyProject.Application.Info.DirectoryPath + "\\Setting.ini";

		public static string Language_Path = MyProject.Application.Info.DirectoryPath + "\\Country\\THAI.ini";

		public const long PROCESS_ALL_ACCESS = 2035711L;

		public static long BASE_ADDRESS = 9465848L;

		public const long Offset_id = 4L;

		public const long Offset_X = 76L;

		public const long Offset_Y = 80L;

		public const long Offset_map = 1594L;

		public const long Offset_SPchar = 1004L;

		public const long Offset_Slotpet = 4837L;

		public const long Offset_SPPet = 1408L;

		public static long BASE_ADDRESS_id = checked(BASE_ADDRESS + 4508);

		public const long Offset_NPC = 41176L;

		public const long Offset_WARP = 41180L;

		public static string ServerIp = "159.196.70.237";

		public static bool Proxy = false;

		public static int Vip = 0;

		public static int IDNgua = 0;

		public static int Style = 0;

		public static ArrayList List_Ip = new ArrayList(new string[15]
		{
			"159.196.70.237", "47.100.96.88", "47.100.98.95", "47.100.185.104", "106.14.113.189", "47.102.135.246", "47.103.90.10", "106.14.214.40", "106.15.95.216", "47.101.59.107",
			"47.100.95.96", "106.14.173.155", "47.100.102.67", "106.14.182.96", "47.100.102.67"
		});

		public static ArrayList List_Ip_nts = new ArrayList(new string[14]
		{
			"47.100.96.88", "47.100.98.95", "47.100.185.104", "106.14.113.189", "47.102.135.246", "47.103.90.10", "106.14.214.40", "106.15.95.216", "47.101.59.107", "47.100.95.96",
			"106.14.173.155", "47.100.102.67", "106.14.182.96", "47.100.102.67"
		});

		public static ArrayList List_Style0 = new ArrayList(new int[5]);

		public static ArrayList List_Style1 = new ArrayList(new int[5] { 23501, 23502, 23503, 23504, 23505 });

		public static ArrayList List_Style2 = new ArrayList(new int[5] { 23506, 23507, 23508, 23509, 23510 });

		public static ArrayList List_Style3 = new ArrayList(new int[5] { 23511, 23512, 23513, 23514, 23515 });

		public static ArrayList List_Style4 = new ArrayList(new int[5] { 23516, 23517, 23518, 23519, 23520 });

		public static string SERVER_Path = MyProject.Application.Info.DirectoryPath + "\\path.ini";

		public static string Game_Path = IniFile.ReadStringOrEmpty(SERVER_Path, "Game", "path", "");

		private const int a = 5;

		private const int b = 207;

		public static int Country
		{
			get
			{
				return Conversions.ToInteger(IniFile.ReadNumberString(Setting_Path, "Language", "Country", ""));
			}
			set
			{
				IniFile.WriteString(Setting_Path, "Language", "Country", value.ToString());
			}
		}

		[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "ReadProcessMemory", ExactSpelling = true, SetLastError = true)]
		public static extern int ReadMemoryByte(int hProcess, int lpBaseAddress, ref byte lpBuffer, int nSize, ref int lpNumberOfBytesWritten);

		[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "ReadProcessMemory", ExactSpelling = true, SetLastError = true)]
		public static extern int ReadMemoryInteger(int hProcess, int lpBaseAddress, ref int lpBuffer, int nSize, ref int lpNumberOfBytesWritten);

		[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "ReadProcessMemory", ExactSpelling = true, SetLastError = true)]
		public static extern int ReadMemoryShort(int hProcess, int lpBaseAddress, ref short lpBuffer, int nSize, ref int lpNumberOfBytesWritten);

		[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "ReadProcessMemory", ExactSpelling = true, SetLastError = true)]
		public static extern int ReadMemoryUShort(int hProcess, int lpBaseAddress, ref ushort lpBuffer, int nSize, ref int lpNumberOfBytesWritten);

		[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern int WriteProcessMemory(int hProcess, int lpBaseAddress, ref long lpBuffer, int nSize, int lpNumberOfBytesWritten);

		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern int GetWindowThreadProcessId(int hwnd, ref int lpdwProcessId);

		[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern int OpenProcess(int dwDesiredAccess, int bInheritHandle, int dwProcessId);

		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern int SetForegroundWindow(int hwnd);

		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern int GetForegroundWindow();

		[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern int CloseHandle(int hObject);

		[DllImport("winmm.dll", CharSet = CharSet.Ansi, EntryPoint = "mciSendStringA", ExactSpelling = true, SetLastError = true)]
		public static extern int mciSendString([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpstrCommand, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpstrReturnString, int uReturnLength, int hwndCallback);

		[DllImport("user32", CharSet = CharSet.Ansi, EntryPoint = "GetClassNameA", ExactSpelling = true, SetLastError = true)]
		public static extern int GetClassName(int hwnd, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpClassName, int nMaxCount);

		public static void AddColorText2(_ClientBot _bot, Dictionary<int, _Data._InfoText> myRTB, string myText, Color myColor)
		{
			checked
			{
				try
				{
					_Data._InfoText value = new _Data._InfoText
					{
						_Text = "[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + "] " + myText,
						_Color = myColor
					};
					if (myRTB.Count >= 100)
					{
						myRTB.Clear();
					}
					_bot._id_rtbsystem++;
					myRTB.Add(_bot._id_rtbsystem, value);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
			}
		}

		public static void AddColorText_Quest(_ClientBot _bot, Dictionary<int, _Data._InfoText> myRTB, string title, string myText, Color myColor)
		{
			checked
			{
				try
				{
					_Data._InfoText value = new _Data._InfoText
					{
						_Text = "[" + title + "] \r\n" + myText,
						_Color = myColor
					};
					if (myRTB.Count >= 150)
					{
						myRTB.Clear();
					}
					_bot._id_rtbQuest++;
					myRTB.Add(_bot._id_rtbQuest, value);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
			}
		}

		public static void AddColorText_QuestMenu(_ClientBot _bot, Dictionary<int, _Data._InfoText> myRTB, string title, string myText, Color myColor)
		{
			checked
			{
				try
				{
					_Data._InfoText value = new _Data._InfoText
					{
						_Text = myText,
						_Color = myColor
					};
					if (myRTB.Count >= 150)
					{
						myRTB.Clear();
					}
					_bot._id_rtbQuest++;
					myRTB.Add(_bot._id_rtbQuest, value);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
			}
		}

		public static void AddColorText_Chat(_ClientBot _bot, Dictionary<int, _Data._InfoText> myRTB, string myText, Color myColor)
		{
			checked
			{
				try
				{
					_Data._InfoText value = new _Data._InfoText
					{
						_Text = "[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + "] " + myText,
						_Color = myColor
					};
					if (myRTB.Count >= 150)
					{
						myRTB.Clear();
					}
					_bot._id_rtbChat++;
					myRTB.Add(_bot._id_rtbChat, value);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
			}
		}

		public static void AddColorText_battle2(_ClientBot _bot, Dictionary<int, _Data._InfoText> myRTB, string myText, Color myColor)
		{
			if (_bot._BattleInfo_Update == 0)
			{
				return;
			}
			checked
			{
				try
				{
					_Data._InfoText value = new _Data._InfoText
					{
						_Text = myText,
						_Color = myColor
					};
					if (myRTB.Count >= 150)
					{
						myRTB.Clear();
					}
					_bot._id_rtbBattle++;
					myRTB.Add(_bot._id_rtbBattle, value);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
			}
		}

		public static void AddColorText(RichTextBox myRTB, string myText, Color myColor)
		{
			try
			{
				int length = myRTB.Text.Length;
				if (myText.EndsWith("\r\n"))
				{
					myRTB.AppendText(myText);
				}
				else
				{
					myRTB.AppendText(myText + "\r\n");
				}
				myRTB.Select(length, checked(myText.Length + 1));
				myRTB.SelectionColor = myColor;
				if (myColor == Color.Green)
				{
					myRTB.SelectionFont = new Font("Consolas", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
				}
				myRTB.Select(length, 0);
				myRTB.ScrollToCaret();
				if (myRTB.Lines.Length >= 150)
				{
					myRTB.Clear();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

		public static void AddColorText_battle(RichTextBox myRTB, string myText, Color myColor)
		{
			try
			{
				int length = myRTB.Text.Length;
				if (myText.EndsWith("\r\n"))
				{
					myRTB.AppendText(myText);
				}
				else
				{
					myRTB.AppendText(myText + "\r\n");
				}
				myRTB.Select(length, checked(myText.Length + 1));
				myRTB.SelectionColor = myColor;
				myRTB.Select(length, 0);
				myRTB.ScrollToCaret();
				if (myRTB.Lines.Length >= 150)
				{
					myRTB.Clear();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

		public static void AddColorText1(RichTextBox myRTB, string myText, Color myColor)
		{
			int length = myRTB.Text.Length;
			if (myText.EndsWith("\r\n"))
			{
				myRTB.AppendText(myText);
			}
			else
			{
				myRTB.AppendText(myText + "\r\n");
			}
			myRTB.Select(length, checked(myText.Length + 1));
			myRTB.SelectionColor = myColor;
			myRTB.Select(length, 0);
			myRTB.ScrollToCaret();
			if (myRTB.Lines.Length >= 111150)
			{
				myRTB.Clear();
			}
		}

		public static void SaveToLog(string text)
		{
			try
			{
				string text2 = MyProject.Application.Info.DirectoryPath + "\\log.txt";
				if (!MyProject.Computer.FileSystem.FileExists(text2))
				{
					FileStream fileStream = new FileStream(text2, FileMode.Create, FileAccess.Write);
				}
				StreamWriter streamWriter = new StreamWriter(text2, true);
				streamWriter.BaseStream.Seek(0L, SeekOrigin.End);
				streamWriter.WriteLine(text);
				streamWriter.Close();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

		public static int SlotPet(int pid)
		{
			checked
			{
				int lpBuffer = default(int);
				if (pid > 0)
				{
					int num = OpenProcess(2035711, 0, pid);
					int lpBaseAddress = (int)BASE_ADDRESS;
					int lpNumberOfBytesWritten = 0;
					ReadMemoryInteger(num, lpBaseAddress, ref lpBuffer, 4, ref lpNumberOfBytesWritten);
					int lpBaseAddress2 = (int)(unchecked((long)lpBuffer) + 4837L);
					lpNumberOfBytesWritten = 0;
					ReadMemoryInteger(num, lpBaseAddress2, ref lpBuffer, 4, ref lpNumberOfBytesWritten);
					if (num > 0)
					{
						CloseHandle(num);
					}
				}
				return lpBuffer;
			}
		}

		public static string bytestohexstring(byte[] bytes)
		{
			string text = "";
			foreach (byte b in bytes)
			{
				text += b.ToString("X2");
			}
			return text;
		}

		public static byte[] hexstringtobyte(string s)
		{
			checked
			{
				byte[] array = new byte[(int)Math.Round((double)s.Length / 2.0 - 1.0) + 1];
				for (int i = 0; i < s.Length; i += 2)
				{
					array[(int)Math.Round((double)i / 2.0)] = byte.Parse(s.Substring(i, 2), NumberStyles.HexNumber);
				}
				return array;
			}
		}

		public static byte[] EncDec_byte(byte[] packet)
		{
			checked
			{
				byte[] array = new byte[packet.Length - 1 + 1];
				int num = packet.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					array[i] = (byte)(packet[i] ^ 0xAD);
				}
				return array;
			}
		}

		public static int BytetoInt32(byte[] packet)
		{
			int result = 0;
			switch (packet.Length)
			{
			case 1:
				result = packet[0];
				break;
			case 2:
				result = Convert.ToInt32(bytestohexstring(new byte[2]
				{
					packet[1],
					packet[0]
				}), 16);
				break;
			case 4:
				result = Convert.ToInt32(bytestohexstring(new byte[4]
				{
					packet[3],
					packet[2],
					packet[1],
					packet[0]
				}), 16);
				break;
			case 8:
				result = Convert.ToInt32(bytestohexstring(new byte[8]
				{
					packet[7],
					packet[6],
					packet[5],
					packet[4],
					packet[3],
					packet[2],
					packet[1],
					packet[0]
				}), 16);
				break;
			}
			return result;
		}

		public static int BytetoInt32_Xuoi(byte[] packet)
		{
			int result = 0;
			switch (packet.Length)
			{
			case 1:
				result = packet[0];
				break;
			case 2:
				result = Convert.ToInt32(bytestohexstring(new byte[2]
				{
					packet[0],
					packet[1]
				}), 16);
				break;
			case 4:
				result = Convert.ToInt32(bytestohexstring(new byte[4]
				{
					packet[0],
					packet[1],
					packet[2],
					packet[3]
				}), 16);
				break;
			case 8:
				result = Convert.ToInt32(bytestohexstring(new byte[8]
				{
					packet[0],
					packet[1],
					packet[2],
					packet[3],
					packet[4],
					packet[5],
					packet[6],
					packet[7]
				}), 16);
				break;
			}
			return result;
		}

		public static Bitmap Bytes_to_Bitmap(int _mapid)
		{
			Bitmap bitmap = new Bitmap(1, 1);
			try
			{
				byte[] array = Ground.Data_Grounds[_mapid];
				int num = Convert.ToInt32(bytestohexstring(new byte[2]
				{
					array[1],
					array[0]
				}), 16);
				int num2 = Convert.ToInt32(bytestohexstring(new byte[2]
				{
					array[3],
					array[2]
				}), 16);
				int num7;
				checked
				{
					int num3 = num * num2;
					bitmap = new Bitmap(num * 3, num2 * 3);
					int num4 = num - 1;
					for (int i = 0; i <= num4; i++)
					{
						int num5 = num2 - 1;
						for (int j = 0; j <= num5; j++)
						{
							int num6 = array[4 + j + i * num2];
							Color color = Color.Blue;
							switch (num6)
							{
							case 0:
								color = Color.White;
								break;
							case 1:
								color = Color.Green;
								break;
							}
							bitmap = ResizeImage(bitmap, i, j, color);
						}
					}
					num7 = 1;
				}
				do
				{
					NpcOnMap.Key_NpcOnMap key = new NpcOnMap.Key_NpcOnMap
					{
						_Idmap = _mapid,
						_id = num7
					};
					if (NpcOnMap.Data_NpcOnMap.ContainsKey(key))
					{
						NpcOnMap.NpcMapInfo npcOnMap = NpcOnMap.Data_NpcOnMap[key];
						int num8 = npcOnMap._X / 20;
						int num9 = npcOnMap._Y / 20;
						if (num8 <= num && num9 <= num2)
						{
							bitmap = ResizeImage(bitmap, num8, num9, Color.Purple);
						}
						num7 = checked(num7 + 1);
						continue;
					}
					break;
				}
				while (num7 <= 100);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			return bitmap;
		}

		public static Bitmap ResizeImage(Bitmap bmp, int _X, int _Y, Color color)
		{
			checked
			{
				bmp.SetPixel(_X * 3, _Y * 3, color);
				bmp.SetPixel(_X * 3, _Y * 3 + 1, color);
				bmp.SetPixel(_X * 3, _Y * 3 + 2, color);
				bmp.SetPixel(_X * 3 + 1, _Y * 3, color);
				bmp.SetPixel(_X * 3 + 1, _Y * 3 + 1, color);
				bmp.SetPixel(_X * 3 + 1, _Y * 3 + 2, color);
				bmp.SetPixel(_X * 3 + 2, _Y * 3, color);
				bmp.SetPixel(_X * 3 + 2, _Y * 3 + 1, color);
				bmp.SetPixel(_X * 3 + 2, _Y * 3 + 2, color);
				return bmp;
			}
		}

		public static string Packet_Maker(string packet)
		{
			string text = "";
			return "F444" + Int32ToHex2(packet.Length / 2) + packet;
		}

		public static string HexToChar(byte[] packet)
		{
			string text = "";
			checked
			{
				int num = packet.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					text += Conversions.ToString(Strings.Chr(packet[i]));
				}
				return text;
			}
		}

		public static string Demthoigian(long time)
		{
			string text = "";
			int num = default(int);
			int num2 = default(int);
			int num3 = default(int);
			if (time >= 86400)
			{
				text = Conversions.ToString(time / 86400) + " ngày ";
				num = ((time % 86400 / 3600 <= 9) ? Conversions.ToInteger(Conversions.ToString(0) + Conversions.ToString(time % 86400 / 3600)) : checked((int)unchecked(time % 86400 / 3600)));
				num2 = ((time % 86400 % 3600 / 60 <= 9) ? Conversions.ToInteger(Conversions.ToString(0) + Conversions.ToString(time % 86400 % 3600 / 60)) : checked((int)unchecked(time % 86400 % 3600 / 60)));
				num3 = ((time % 86400 % 3600 % 60 <= 9) ? Conversions.ToInteger(Conversions.ToString(0) + Conversions.ToString(time % 86400 % 3600 % 60)) : checked((int)unchecked(time % 86400 % 3600 % 60)));
			}
			else if (time < 86400 && time >= 3600)
			{
				num = ((time / 3600 <= 9) ? Conversions.ToInteger(Conversions.ToString(0) + Conversions.ToString(time / 3600)) : checked((int)unchecked(time / 3600)));
				num2 = ((time % 3600 / 60 <= 9) ? Conversions.ToInteger(Conversions.ToString(0) + Conversions.ToString(time % 3600 / 60)) : checked((int)unchecked(time % 3600 / 60)));
				num3 = ((time % 3600 % 60 <= 9) ? Conversions.ToInteger(Conversions.ToString(0) + Conversions.ToString(time % 3600 % 60)) : checked((int)unchecked(time % 3600 % 60)));
			}
			else if (time < 3600 && time >= 60)
			{
				num2 = ((time / 60 <= 9) ? Conversions.ToInteger(Conversions.ToString(0) + Conversions.ToString(time / 60)) : checked((int)unchecked(time / 60)));
				num3 = ((time % 60 <= 9) ? Conversions.ToInteger(Conversions.ToString(0) + Conversions.ToString(time % 60)) : checked((int)unchecked(time % 60)));
			}
			else if (time < 60)
			{
				num3 = ((time <= 9) ? Conversions.ToInteger(Conversions.ToString(0) + Conversions.ToString(time)) : checked((int)time));
			}
			return text + num.ToString("00") + ":" + num2.ToString("00") + ":" + num3.ToString("00");
		}

		public static string GetThuocTinh(int num)
		{
			string text = "Không";
			switch (num)
			{
			case 1:
				return "Địa";
			case 2:
				return "Thuỷ";
			case 3:
				return "Hoả";
			case 4:
				return "Phong";
			default:
				return "Không";
			}
		}

		public static string Int32ToHex2(int num)
		{
			return num.ToString("X4").Substring(2, 2) + num.ToString("X4").Substring(0, 2);
		}

		public static string Int32ToHex4(int num)
		{
			return num.ToString("X8").Substring(6, 2) + num.ToString("X8").Substring(4, 2) + num.ToString("X8").Substring(2, 2) + num.ToString("X8").Substring(0, 2);
		}

		public static int BytesToInt32(byte[] packet)
		{
			int result = 0;
			switch (packet.Length)
			{
			case 2:
				result = Convert.ToInt32(bytestohexstring(new byte[2]
				{
					packet[1],
					packet[0]
				}), 16);
				break;
			case 4:
				result = Convert.ToInt32(bytestohexstring(new byte[4]
				{
					packet[3],
					packet[2],
					packet[1],
					packet[0]
				}), 16);
				break;
			}
			return result;
		}

		public static int HexToInt32(string num)
		{
			byte[] array = hexstringtobyte(num);
			int result = 0;
			switch (array.Length)
			{
			case 1:
				result = Convert.ToInt32(bytestohexstring(new byte[1] { array[0] }), 16);
				break;
			case 2:
				result = Convert.ToInt32(bytestohexstring(new byte[2]
				{
					array[1],
					array[0]
				}), 16);
				break;
			case 4:
				result = Convert.ToInt32(bytestohexstring(new byte[4]
				{
					array[3],
					array[2],
					array[1],
					array[0]
				}), 16);
				break;
			}
			return result;
		}

		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern int SendMessage(IntPtr hwnd, int uMsg, int wParam, int lParam);

		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr GetWindow(IntPtr A_0, int A_1);

		public static void ComboBox_ReadOnly(int Mode, ref ComboBox cb)
		{
			try
			{
				IntPtr window = GetWindow(cb.Handle, 5);
				if (!window.Equals(IntPtr.Zero))
				{
					SendMessage(window, 207, Mode, 0);
					cb.Refresh();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

		public static Color GetColor(int id)
		{
			Color result = SystemColors.Control;
			switch (id)
			{
			case 0:
				result = Color.Black;
				break;
			case 1:
				result = Color.Peru;
				break;
			case 2:
				result = Color.DodgerBlue;
				break;
			case 3:
				result = Color.LightCoral;
				break;
			case 4:
				result = Color.LimeGreen;
				break;
			case 5:
				result = Color.Violet;
				break;
			case 7:
				result = Color.LightYellow;
				break;
			case 8:
				result = Color.DarkViolet;
				break;
			}
			return result;
		}

		public static string Unicode_to_VISCII(string text1)
		{
			string str = "áàäãÕå¡¢ÆÇ£â¤¥¦ç§éèë\u00a8©êª«¬\u00ad®íìïî\u00b8óòöõ÷ô\u00af°±²µ½¾¶·ÞþúùüûøßÑ×ØæñýÏÖÛÜðÁÀÄÃÁÅ\u0081‚AAƒÂ„…†\u0006‡ÉÈËˆ‰ÊŠ‹Œ\u008dÊÍÌ›Î\u02dcÓÒ???Ô\u008f\u0090‘’\u00b4•–—³ÚÙœ\u009dÚ¿º»¼ÿ¹ÝŸ???Ð";
			string @string = "áàảãạăắằẳẵặâấầẩẫậéèẻẽẹêếềểễệíìỉĩịóòỏõọôốồổỗộơớờởỡợúùủũụưứừửữựýỳỷỹỵđÁÀẢÃẠĂẮẰẲẴẶÂẤẦẨẪẬÉÈẺẼẸÊẾỀỂỄỆÍÌỈĨỊÓÒỎÕỌÔỐỒỔỖƠỚỜỞỠÚÙỦŨỤƯỨỪỬỮỰÝỲỶỸỴĐ";
			string text2 = "";
			object CounterResult = default(object);
			object LoopForResult = default(object);
			if (ObjectFlowControl.ForLoopControl.ForLoopInitObj(CounterResult, 0, checked(text1.Length - 1), 1, ref LoopForResult, ref CounterResult))
			{
				do
				{
					string text3 = text1.Substring(Conversions.ToInteger(CounterResult), 1);
					if (Operators.CompareString(text3, "\r", false) == 0)
					{
						text2 += "\r";
						continue;
					}
					if (Operators.CompareString(text3, "\n", false) == 0)
					{
						text2 += "\n";
						continue;
					}
					object obj = Strings.InStr(@string, text3);
					text2 = ((!Operators.ConditionalCompareObjectLessEqual(obj, 0, false)) ? (text2 + Strings.Mid(str, Conversions.ToInteger(obj), 1)) : (text2 + text3));
				}
				while (ObjectFlowControl.ForLoopControl.ForNextCheckObj(CounterResult, LoopForResult, ref CounterResult));
			}
			return text2;
		}

		public static string VISCII_to_Unicode(string text1)
		{
			byte[] array = hexstringtobyte("E1E0E4E3D5E5A1A2C6C7A3E2A4A5A6E7A7E9E8EBA8A9EAAAABACADAEEDECEFEEB8F3F2F6F5F7F4AFB0B1B2B5BDBEB6B7DEFEFAF9FCFBF8DFD1D7D8E6F1FDCFD6DBDCF0C1C0C4C380C58182020583C28485860687C9C8CB8889CA8A8B8C8D8ECDCC9BCE98D3D299F59AD48F90919293B4959697B394DAD99C9D9EBFBABBBCFFB9DD9F14191ED0");
			string str = "áàảãạăắằẳẵặâấầẩẫậéèẻẽẹêếềểễệíìỉĩịóòỏõọôốồổỗộơớờởỡợúùủũụưứừửữựýỳỷỹỵđÁÀẢÃẠĂẮẰẲẴẶÂẤẦẨẪẬÉÈẺẼẸÊẾỀỂỄỆÍÌỈĨỊÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢÚÙỦŨỤƯỨỪỬỮỰÝỲỶỸỴĐ";
			string text2 = "";
			checked
			{
				object CounterResult = default(object);
				object LoopForResult = default(object);
				if (ObjectFlowControl.ForLoopControl.ForLoopInitObj(CounterResult, 0, text1.Length - 1, 1, ref LoopForResult, ref CounterResult))
				{
					object obj = default(object);
					do
					{
						string text3 = text1.Substring(Conversions.ToInteger(CounterResult), 1);
						if (Operators.CompareString(text3, "\r", false) == 0)
						{
							text2 += "\r";
							continue;
						}
						if (Operators.CompareString(text3, "\n", false) == 0)
						{
							text2 += "\n";
							continue;
						}
						int num = array.Length - 1;
						for (int i = 0; i <= num; i++)
						{
							if (array[i] == Strings.AscW(text3))
							{
								obj = i + 1;
								break;
							}
						}
						if (Operators.ConditionalCompareObjectLessEqual(obj, 0, false))
						{
							text2 += text3;
							continue;
						}
						text2 += Strings.Mid(str, Conversions.ToInteger(obj), 1);
						obj = 0;
					}
					while (ObjectFlowControl.ForLoopControl.ForNextCheckObj(CounterResult, LoopForResult, ref CounterResult));
				}
				return text2;
			}
		}

		public static byte[] ByteArrayToByteArray(byte[] ByteArray, int StartIndex)
		{
			byte[] array = new byte[checked(ByteArray.Length - StartIndex - 1 + 1)];
			Array.Copy(ByteArray, StartIndex, array, 0, array.Length);
			return array;
		}

		public static byte[] ByteArrayToByteArray(byte[] ByteArray, int StartIndex, int LengthIndex)
		{
			byte[] array = new byte[checked(LengthIndex - 1 + 1)];
			Array.Copy(ByteArray, StartIndex, array, 0, LengthIndex);
			return array;
		}

		public static int GetIdItem(byte[] data)
		{
			int num = Convert.ToInt32(bytestohexstring(new byte[2]
			{
				data[1],
				data[0]
			}), 16);
			if (num > 0)
			{
				num = checked((num ^ 0x5200 ^ 3 ^ 0xBDC0) - 9);
			}
			if (num == 0)
			{
				num = 0;
			}
			return num;
		}

		public static int GetGiaItem(byte[] data)
		{
			int num = Convert.ToInt32(bytestohexstring(new byte[4]
			{
				data[3],
				data[2],
				data[1],
				data[0]
			}), 16);
			if (num > 0)
			{
				num = checked((num ^ 0xB80F4B4) - 9);
			}
			if (num == 0)
			{
				num = 0;
			}
			return num;
		}

		public static int GetLVItem(byte[] data)
		{
			int num = data[0];
			if (num > 0)
			{
				num = checked((num ^ 0x99 ^ 3) - 9);
			}
			if (num == 0)
			{
				num = 0;
			}
			return num;
		}

		public static object THAIEncodeString(ref string Str)
		{
			Encoding encoding = Encoding.GetEncoding("iso-8859-1");
			Encoding encoding2 = Encoding.GetEncoding("TIS-620");
			byte[] bytes = encoding.GetBytes(Str);
			return encoding2.GetString(bytes);
		}

		public static string GetNameItem(byte[] data)
		{
			string text = "";
			checked
			{
				int num = data.Length - 1;
				for (int i = num; i >= 0 && data[i] > 0; i += -1)
				{
					text += Conversions.ToString(Strings.ChrW(data[i]));
				}
				return text;
			}
		}

		public static int GetValue5Item(byte[] data)
		{
			int num = Convert.ToInt32(bytestohexstring(new byte[2]
			{
				data[1],
				data[0]
			}), 16);
			if (num > 0)
			{
				num = checked((num ^ 0xEFC3) - 9);
			}
			if (num == 0)
			{
				num = 0;
			}
			return num;
		}
	}
}
