using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Simple_Bot
{
	public class Ground
	{
		public static Dictionary<int, byte[]> Data_Grounds = new Dictionary<int, byte[]>();

		public static Dictionary<int, int> Data_Warps = new Dictionary<int, int>();

		public static Dictionary<int, int> Data_Warps_QuestID = new Dictionary<int, int>();

		public static Dictionary<int, int> Data_Warps_MapID = new Dictionary<int, int>();

		public static Dictionary<int, int> Data_Marks = new Dictionary<int, int>();

		public static Dictionary<int, string> Data_Marks_Name = new Dictionary<int, string>();

		public static Dictionary<int, string> Data_Marks_Name_VN = new Dictionary<int, string>();

		public static void LoadDataGrounds()
		{
			MyProject.Forms.MainForm.status = "Ground loading...";
			string path = "data\\Ground.MMG";
			byte[] array = File.ReadAllBytes(path);
			checked
			{
				int num = array.Length - 2;
				for (int i = 25524964; i <= num; i += 29)
				{
					byte[] array2 = API.ByteArrayToByteArray(array, i, 29);
					string value = Encoding.ASCII.GetString(new byte[5]
					{
						array2[0],
						array2[1],
						array2[2],
						array2[3],
						array2[4]
					});
					int startIndex = Convert.ToInt32(API.bytestohexstring(new byte[4]
					{
						array2[23],
						array2[22],
						array2[21],
						array2[20]
					}), 16);
					int lengthIndex = Convert.ToInt32(API.bytestohexstring(new byte[4]
					{
						array2[27],
						array2[26],
						array2[25],
						array2[24]
					}), 16);
					byte[] array3 = API.ByteArrayToByteArray(array, startIndex, lengthIndex);
					array3 = API.ByteArrayToByteArray(array3, 9 + array3[8] * 6);
					int num2 = Convert.ToInt32(API.bytestohexstring(new byte[2]
					{
						array3[1],
						array3[0]
					}), 16) * Convert.ToInt32(API.bytestohexstring(new byte[2]
					{
						array3[3],
						array3[2]
					}), 16);
					int key = Conversions.ToInteger(value);
					try
					{
						Data_Grounds.Add(key, array3);
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ProjectData.ClearProjectError();
					}
				}
				LoadDataWarps();
				LoadDataMarks_VN();
				LoadDataMarks();
			}
		}

		public static void LoadDataWarps()
		{
			MyProject.Forms.MainForm.status = "Ground loading...";
			string path = "data\\warp.dat";
			byte[] array = File.ReadAllBytes(path);
			checked
			{
				int num = unchecked(array.Length / 23) - 1;
				for (int i = 1; i <= num; i++)
				{
					try
					{
						byte[] array2 = API.ByteArrayToByteArray(array, i * 23, 23);
						int num2 = (Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							array2[12],
							array2[11]
						}), 16) ^ 0xC1 ^ 9) - 1;
						int key = (Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							array2[14],
							array2[13]
						}), 16) ^ 0x5200 ^ 9) - 1;
						Data_Warps.Add(i, num2);
						Data_Warps_QuestID.Add(key, i);
						Data_Warps_MapID.Add(num2, i);
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ProjectData.ClearProjectError();
					}
				}
			}
		}

		public static void LoadDataMarks_VN()
		{
			MyProject.Forms.MainForm.status = "Ground loading...";
			string path = "data\\Mark2.dat";
			int country = API.Country;
			if (country == 1)
			{
				path = "data\\MarkTHAI.dat";
			}
			byte[] array = File.ReadAllBytes(path);
			checked
			{
				int num = array.Length - 1;
				for (int i = 0; i <= num; i += 516)
				{
					byte[] array2 = API.ByteArrayToByteArray(array, i, 516);
					byte[] array3 = API.ByteArrayToByteArray(array2, 255, 2);
					byte[] packet = API.ByteArrayToByteArray(array2, 258, 2);
					byte[] packet2 = API.ByteArrayToByteArray(array2, 256, 2);
					byte b = array2[0];
					string Str = "";
					int num2 = 255 - b;
					for (int j = 254; j >= num2; j += -1)
					{
						Str += Conversions.ToString(Strings.ChrW(array2[j]));
					}
					int country2 = API.Country;
					Str = ((country2 != 1) ? API.VISCII_to_Unicode(Str) : Conversions.ToString(API.THAIEncodeString(ref Str)));
					int key = (API.BytetoInt32(packet2) ^ 0x2773 ^ 7) - 7;
					if (API.BytetoInt32(packet2) > 0)
					{
						int num3 = (API.BytetoInt32(packet) ^ 0x2773 ^ 7) - 7;
						if ((API.BytetoInt32(packet) ^ 0x2773) > 0)
						{
							Data_Marks_Name_VN.Add(key, Str);
						}
					}
				}
			}
		}

		public static void LoadDataMarks()
		{
			MyProject.Forms.MainForm.status = "Ground loading...";
			string path = "data\\mark.dat";
			byte[] array = File.ReadAllBytes(path);
			checked
			{
				int num = array.Length - 1;
				for (int i = 0; i <= num; i += 516)
				{
					byte[] array2 = API.ByteArrayToByteArray(array, i, 516);
					byte[] array3 = API.ByteArrayToByteArray(array2, 255, 2);
					byte[] packet = API.ByteArrayToByteArray(array2, 258, 2);
					byte[] packet2 = API.ByteArrayToByteArray(array2, 256, 2);
					byte b = array2[0];
					string text = "";
					byte b2 = array2[261];
					string text2 = "";
					int num2 = 255 - b;
					for (int j = 254; j >= num2; j += -1)
					{
						text += Conversions.ToString(Strings.ChrW(array2[j]));
					}
					int num3 = 515 - b2;
					for (int k = 515; k >= num3; k += -1)
					{
						text2 += Conversions.ToString(Strings.ChrW(array2[k]));
					}
					text = API.VISCII_to_Unicode(text);
					text2 = API.VISCII_to_Unicode(text2);
					int num4 = (API.BytetoInt32(packet2) ^ 0x2773 ^ 7) - 7;
					if (API.BytetoInt32(packet2) <= 0)
					{
						continue;
					}
					int key = (API.BytetoInt32(packet) ^ 0x2773 ^ 7) - 7;
					if ((API.BytetoInt32(packet) ^ 0x2773) > 0)
					{
						Data_Marks.Add(key, num4);
						bool flag = Data_Marks_Name_VN.ContainsKey(num4);
						if (flag)
						{
							Data_Marks_Name.Add(num4, Data_Marks_Name_VN[num4]);
						}
						else
						{
							Data_Marks_Name.Add(num4, text);
						}
					}
				}
			}
		}
	}
}
