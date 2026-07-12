using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualBasic.CompilerServices;

namespace Simple_Bot
{
	public class Npcs
	{
		public struct NpcInfo
		{
			public int _Id;

			public int _IdPic;

			public string[] color;

			public string _Name;

			public int _Lv;

			public int _Thuoctinh;

			public int _Hp;

			public int _Sp;

			public int _Hpx;

			public int _Spx;

			public int _Int;

			public int _Atk;

			public int _Def;

			public int _Agi;

			public int _Skill1;

			public int _Skill2;

			public int _Skill3;

			public int _Skill4;

			public int _Skill5;

			public int _Skill6;

			public int _Item1;

			public int _Item2;

			public int _Item3;

			public int _Item4;

			public int _Item5;

			public int _Item6;

			public int _Bat;

			public int _Reborn;

			public int _Type;
		}

		public static Dictionary<int, NpcInfo> Data_Npcs = new Dictionary<int, NpcInfo>();

		public static Dictionary<int, NpcInfo> Data_Npcs2 = new Dictionary<int, NpcInfo>();

		public static object GetValueNPC(byte[] data)
		{
			int num = Convert.ToInt32(API.bytestohexstring(new byte[2]
			{
				data[1],
				data[0]
			}), 16);
			num = checked((num ^ 0x5200 ^ 9) - 1);
			return num;
		}

		public static object GetHPSPNPC(byte[] data)
		{
			int num = Convert.ToInt32(API.bytestohexstring(new byte[2]
			{
				data[1],
				data[0]
			}), 16);
			num = checked((num ^ 0xB71F ^ 9) - 1);
			return num;
		}

		public static object GetNPC_4bytes(byte[] data)
		{
			int num = Convert.ToInt32(API.bytestohexstring(new byte[4]
			{
				data[3],
				data[2],
				data[1],
				data[0]
			}), 16);
			num = checked((num ^ 0xBAEB716) - 1);
			return num;
		}

		public static void LoadDataNpcs2()
		{
			string text = "data\\npc2.dat";
			int country = API.Country;
			if (country != 1)
			{
				return;
			}
			text = "data\\NpcTHAI.dat";
			if (!File.Exists(text))
			{
				return;
			}
			byte[] array = File.ReadAllBytes(text);
			checked
			{
				int num = array.Length - 1;
				for (int i = 0; i <= num; i += 92)
				{
					byte[] byteArray = API.ByteArrayToByteArray(array, i, 92);
					byte[] array2 = API.ByteArrayToByteArray(byteArray, 0, 1);
					byte[] data = API.ByteArrayToByteArray(byteArray, 1, 14);
					byte[] array3 = API.ByteArrayToByteArray(byteArray, 15, 1);
					byte[] array4 = API.ByteArrayToByteArray(byteArray, 16, 2);
					byte[] data2 = API.ByteArrayToByteArray(byteArray, 18, 2);
					byte[] data3 = API.ByteArrayToByteArray(byteArray, 20, 2);
					byte[] array5 = API.ByteArrayToByteArray(byteArray, 22, 4);
					byte[] array6 = API.ByteArrayToByteArray(byteArray, 26, 4);
					byte[] array7 = API.ByteArrayToByteArray(byteArray, 30, 4);
					byte[] array8 = API.ByteArrayToByteArray(byteArray, 34, 4);
					byte[] array9 = API.ByteArrayToByteArray(byteArray, 38, 1);
					byte[] array10 = API.ByteArrayToByteArray(byteArray, 39, 1);
					byte[] array11 = API.ByteArrayToByteArray(byteArray, 40, 1);
					byte[] array12 = API.ByteArrayToByteArray(byteArray, 41, 1);
					byte[] data4 = API.ByteArrayToByteArray(byteArray, 42, 2);
					byte[] data5 = API.ByteArrayToByteArray(byteArray, 46, 2);
					byte[] data6 = API.ByteArrayToByteArray(byteArray, 50, 2);
					byte[] data7 = API.ByteArrayToByteArray(byteArray, 52, 2);
					byte[] data8 = API.ByteArrayToByteArray(byteArray, 54, 2);
					byte[] data9 = API.ByteArrayToByteArray(byteArray, 56, 2);
					byte[] data10 = API.ByteArrayToByteArray(byteArray, 58, 2);
					byte[] data11 = API.ByteArrayToByteArray(byteArray, 60, 2);
					byte[] array13 = API.ByteArrayToByteArray(byteArray, 65, 1);
					byte[] data12 = API.ByteArrayToByteArray(byteArray, 66, 2);
					byte[] data13 = API.ByteArrayToByteArray(byteArray, 68, 2);
					byte[] data14 = API.ByteArrayToByteArray(byteArray, 70, 2);
					byte[] data15 = API.ByteArrayToByteArray(byteArray, 72, 2);
					byte[] data16 = API.ByteArrayToByteArray(byteArray, 74, 2);
					byte[] data17 = API.ByteArrayToByteArray(byteArray, 76, 2);
					byte[] data18 = API.ByteArrayToByteArray(byteArray, 78, 2);
					byte[] data19 = API.ByteArrayToByteArray(byteArray, 80, 2);
					byte[] data20 = API.ByteArrayToByteArray(byteArray, 82, 2);
					byte[] array14 = API.ByteArrayToByteArray(byteArray, 84, 1);
					byte[] data21 = API.ByteArrayToByteArray(byteArray, 85, 2);
					byte[] array15 = API.ByteArrayToByteArray(byteArray, 87, 1);
					byte[] data22 = API.ByteArrayToByteArray(byteArray, 88, 2);
					byte[] data23 = API.ByteArrayToByteArray(byteArray, 90, 2);
					int num2 = Convert.ToInt32(API.bytestohexstring(new byte[2]
					{
						array4[1],
						array4[0]
					}), 16);
					int num3 = (num2 ^ 0x5200 ^ 9) - 1;
					if (num3 > 0)
					{
						string text2 = "";
						int lv = (array12[0] ^ 0xC8) - 1;
						int thuoctinh = (array13[0] ^ 0xC8) - 1;
						int hp = Conversions.ToInteger(GetHPSPNPC(data4));
						int sp = Conversions.ToInteger(GetHPSPNPC(data5));
						int hpx = Conversions.ToInteger(GetValueNPC(data6));
						int spx = Conversions.ToInteger(GetValueNPC(data7));
						int num4 = Conversions.ToInteger(GetValueNPC(data8));
						int atk = Conversions.ToInteger(GetValueNPC(data9));
						int def = Conversions.ToInteger(GetValueNPC(data10));
						int agi = Conversions.ToInteger(GetValueNPC(data11));
						int skill = Conversions.ToInteger(GetValueNPC(data12));
						int skill2 = Conversions.ToInteger(GetValueNPC(data13));
						int skill3 = Conversions.ToInteger(GetValueNPC(data14));
						int item = Conversions.ToInteger(GetValueNPC(data15));
						int item2 = Conversions.ToInteger(GetValueNPC(data16));
						int item3 = Conversions.ToInteger(GetValueNPC(data17));
						int item4 = Conversions.ToInteger(GetValueNPC(data18));
						int item5 = Conversions.ToInteger(GetValueNPC(data19));
						int item6 = Conversions.ToInteger(GetValueNPC(data20));
						int bat = (array9[0] ^ 0xC1 ^ 9) - 1;
						int num5 = (array10[0] ^ 0xC1 ^ 9) - 1;
						int num6 = (array11[0] ^ 0xC1 ^ 9) - 1;
						int reborn = (array15[0] ^ 0xC1 ^ 9) - 1;
						int type = (array3[0] ^ 0xC1 ^ 9) - 1;
						int num7 = (array14[0] ^ 0xC1 ^ 9) - 1;
						int num8 = Conversions.ToInteger(GetValueNPC(data21));
						int num9 = Conversions.ToInteger(GetValueNPC(data22));
						int num10 = Conversions.ToInteger(GetValueNPC(data23));
						int num11 = Conversions.ToInteger(GetValueNPC(data2));
						int num12 = Conversions.ToInteger(GetValueNPC(data3));
						int country2 = API.Country;
						if (country2 == 1)
						{
							text2 = API.GetNameItem(data);
							text2 = Conversions.ToString(API.THAIEncodeString(ref text2));
						}
						else
						{
							text2 = ((!GetDataName.Data_Npc_Name.ContainsKey(num2)) ? API.GetNameItem(data) : GetDataName.Data_Npc_Name[num2]);
						}
						NpcInfo value = new NpcInfo
						{
							_Id = num3,
							_Name = text2,
							_Lv = lv,
							_Thuoctinh = thuoctinh,
							_Hp = hp,
							_Sp = sp,
							_Hpx = hpx,
							_Spx = spx,
							_Int = num4,
							_Atk = atk,
							_Def = def,
							_Agi = agi,
							_Skill1 = skill,
							_Skill2 = skill2,
							_Skill3 = skill3,
							_Skill4 = num8,
							_Skill5 = num8,
							_Skill6 = num8,
							_Item1 = item,
							_Item2 = item2,
							_Item3 = item3,
							_Item4 = item4,
							_Item5 = item5,
							_Item6 = item6,
							_Bat = bat,
							_Reborn = reborn,
							_Type = type
						};
						Data_Npcs2.Add(value._Id, value);
					}
				}
			}
		}

		public static void LoadDataNpcs()
		{
			LoadDataNpcs2();
			string path = "data\\npc.dat";
			byte[] array = File.ReadAllBytes(path);
			checked
			{
				int num = array.Length - 1;
				for (int i = 0; i <= num; i += 97)
				{
					byte[] byteArray = API.ByteArrayToByteArray(array, i, 97);
					byte[] array2 = API.ByteArrayToByteArray(byteArray, 0, 1);
					byte[] data = API.ByteArrayToByteArray(byteArray, 1, 10);
					byte[] array3 = API.ByteArrayToByteArray(byteArray, 11, 1);
					byte[] array4 = API.ByteArrayToByteArray(byteArray, 12, 2);
					byte[] data2 = API.ByteArrayToByteArray(byteArray, 14, 2);
					byte[] data3 = API.ByteArrayToByteArray(byteArray, 18, 4);
					byte[] data4 = API.ByteArrayToByteArray(byteArray, 22, 4);
					byte[] data5 = API.ByteArrayToByteArray(byteArray, 26, 4);
					byte[] data6 = API.ByteArrayToByteArray(byteArray, 30, 4);
					byte[] array5 = API.ByteArrayToByteArray(byteArray, 34, 1);
					byte[] array6 = API.ByteArrayToByteArray(byteArray, 35, 1);
					byte[] array7 = API.ByteArrayToByteArray(byteArray, 36, 1);
					byte[] array8 = API.ByteArrayToByteArray(byteArray, 37, 1);
					byte[] data7 = API.ByteArrayToByteArray(byteArray, 38, 2);
					byte[] data8 = API.ByteArrayToByteArray(byteArray, 42, 2);
					byte[] data9 = API.ByteArrayToByteArray(byteArray, 46, 2);
					byte[] data10 = API.ByteArrayToByteArray(byteArray, 48, 2);
					byte[] data11 = API.ByteArrayToByteArray(byteArray, 50, 2);
					byte[] data12 = API.ByteArrayToByteArray(byteArray, 52, 2);
					byte[] data13 = API.ByteArrayToByteArray(byteArray, 54, 2);
					byte[] data14 = API.ByteArrayToByteArray(byteArray, 56, 2);
					byte[] array9 = API.ByteArrayToByteArray(byteArray, 61, 1);
					byte[] data15 = API.ByteArrayToByteArray(byteArray, 62, 2);
					byte[] data16 = API.ByteArrayToByteArray(byteArray, 64, 2);
					byte[] data17 = API.ByteArrayToByteArray(byteArray, 66, 2);
					byte[] data18 = API.ByteArrayToByteArray(byteArray, 68, 2);
					byte[] data19 = API.ByteArrayToByteArray(byteArray, 70, 2);
					byte[] data20 = API.ByteArrayToByteArray(byteArray, 72, 2);
					byte[] data21 = API.ByteArrayToByteArray(byteArray, 74, 2);
					byte[] data22 = API.ByteArrayToByteArray(byteArray, 76, 2);
					byte[] data23 = API.ByteArrayToByteArray(byteArray, 78, 2);
					byte[] array10 = API.ByteArrayToByteArray(byteArray, 80, 1);
					byte[] data24 = API.ByteArrayToByteArray(byteArray, 81, 2);
					byte[] array11 = API.ByteArrayToByteArray(byteArray, 83, 1);
					byte[] data25 = API.ByteArrayToByteArray(byteArray, 84, 2);
					byte[] data26 = API.ByteArrayToByteArray(byteArray, 86, 2);
					byte[] data27 = API.ByteArrayToByteArray(byteArray, 86, 2);
					byte[] data28 = API.ByteArrayToByteArray(byteArray, 93, 2);
					int num2 = Convert.ToInt32(API.bytestohexstring(new byte[2]
					{
						array4[1],
						array4[0]
					}), 16);
					int num3 = (num2 ^ 0x5200 ^ 9) - 1;
					if (num3 > 0)
					{
						string text = "";
						int idPic = Conversions.ToInteger(GetValueNPC(data2));
						string text2 = GetNPC_4bytes(data3).ToString();
						string text3 = GetNPC_4bytes(data4).ToString();
						string text4 = GetNPC_4bytes(data5).ToString();
						string text5 = GetNPC_4bytes(data6).ToString();
						int lv = (array8[0] ^ 0xC8) - 1;
						int thuoctinh = (array9[0] ^ 0xC8) - 1;
						int hp = Conversions.ToInteger(GetHPSPNPC(data7));
						int sp = Conversions.ToInteger(GetHPSPNPC(data8));
						int hpx = Conversions.ToInteger(GetValueNPC(data9));
						int spx = Conversions.ToInteger(GetValueNPC(data10));
						int num4 = Conversions.ToInteger(GetValueNPC(data11));
						int atk = Conversions.ToInteger(GetValueNPC(data12));
						int def = Conversions.ToInteger(GetValueNPC(data13));
						int agi = Conversions.ToInteger(GetValueNPC(data14));
						int skill = Conversions.ToInteger(GetValueNPC(data15));
						int skill2 = Conversions.ToInteger(GetValueNPC(data16));
						int skill3 = Conversions.ToInteger(GetValueNPC(data17));
						int item = Conversions.ToInteger(GetValueNPC(data18));
						int item2 = Conversions.ToInteger(GetValueNPC(data19));
						int item3 = Conversions.ToInteger(GetValueNPC(data20));
						int item4 = Conversions.ToInteger(GetValueNPC(data21));
						int item5 = Conversions.ToInteger(GetValueNPC(data22));
						int item6 = Conversions.ToInteger(GetValueNPC(data23));
						int bat = (array5[0] ^ 0xC1 ^ 9) - 1;
						int num5 = (array6[0] ^ 0xC1 ^ 9) - 1;
						int num6 = (array7[0] ^ 0xC1 ^ 9) - 1;
						int reborn = (array11[0] ^ 0xC1 ^ 9) - 1;
						int type = (array3[0] ^ 0xC1 ^ 9) - 1;
						int num7 = (array10[0] ^ 0xC1 ^ 9) - 1;
						int skill4 = Conversions.ToInteger(GetValueNPC(data24));
						int num8 = Conversions.ToInteger(GetValueNPC(data25));
						int num9 = Conversions.ToInteger(GetValueNPC(data26));
						int num10 = Conversions.ToInteger(GetValueNPC(data2));
						int skill5 = Conversions.ToInteger(GetValueNPC(data27));
						int skill6 = Conversions.ToInteger(GetValueNPC(data28));
						int country = API.Country;
						text = ((country != 1) ? (GetDataName.Data_Npc_Name.ContainsKey(num3) ? GetDataName.Data_Npc_Name[num3] : ((!Data_Npcs2.ContainsKey(num3)) ? API.GetNameItem(data) : Data_Npcs2[num3]._Name)) : ((!Data_Npcs2.ContainsKey(num3)) ? API.GetNameItem(data) : Data_Npcs2[num3]._Name));
						NpcInfo value = new NpcInfo
						{
							_Id = num3,
							_IdPic = idPic,
							color = new string[5]
						};
						value.color[0] = text2;
						value.color[1] = text3;
						value.color[2] = text4;
						value.color[3] = text5;
						value._Name = text;
						value._Lv = lv;
						value._Thuoctinh = thuoctinh;
						value._Hp = hp;
						value._Sp = sp;
						value._Hpx = hpx;
						value._Spx = spx;
						value._Int = num4;
						value._Atk = atk;
						value._Def = def;
						value._Agi = agi;
						value._Skill1 = skill;
						value._Skill2 = skill2;
						value._Skill3 = skill3;
						value._Skill4 = skill4;
						value._Skill5 = skill5;
						value._Skill6 = skill6;
						value._Item1 = item;
						value._Item2 = item2;
						value._Item3 = item3;
						value._Item4 = item4;
						value._Item5 = item5;
						value._Item6 = item6;
						value._Bat = bat;
						value._Reborn = reborn;
						value._Type = type;
						Data_Npcs.Add(value._Id, value);
					}
				}
			}
		}
	}
}
