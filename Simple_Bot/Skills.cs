using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualBasic.CompilerServices;

namespace Simple_Bot
{
	public class Skills
	{
		public struct _Skill
		{
			public int _Id;

			public string _Name;

			public int _Sp;
		}

		public static Dictionary<int, _Skill> Data_Skills = new Dictionary<int, _Skill>();

		public static Dictionary<string, _Skill> Data_Skills_Name = new Dictionary<string, _Skill>();

		public static Dictionary<int, string> Data_Skills_Thai = new Dictionary<int, string>();

		public static void LoadDataSkills_Thai()
		{
			string path = "data\\skillThai.dat";
			byte[] array = File.ReadAllBytes(path);
			checked
			{
				int num = array.Length - 1;
				for (int i = 0; i <= num; i += 86)
				{
					try
					{
						byte[] byteArray = API.ByteArrayToByteArray(array, i, 86);
						byte[] data = API.ByteArrayToByteArray(byteArray, 1, 20);
						byte[] array2 = API.ByteArrayToByteArray(byteArray, 22, 2);
						byte[] array3 = API.ByteArrayToByteArray(byteArray, 24, 2);
						int num2 = Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							array2[1],
							array2[0]
						}), 16);
						int num3 = Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							array3[1],
							array3[0]
						}), 16);
						string Str = API.GetNameItem(data);
						string value = Conversions.ToString(API.THAIEncodeString(ref Str));
						if (num2 > 0)
						{
							num2 = (num2 ^ 0x6EA4 ^ 4) - 4;
							if (!Data_Skills_Thai.ContainsKey(num2))
							{
								Data_Skills_Thai.Add(num2, value);
							}
						}
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ProjectData.ClearProjectError();
						break;
					}
				}
			}
		}

		public static void LoadSkills()
		{
			LoadDataSkills_Thai();
			string path = "data\\skill.dat";
			byte[] array = File.ReadAllBytes(path);
			checked
			{
				int num = array.Length - 1;
				for (int i = 0; i <= num; i += 86)
				{
					try
					{
						byte[] byteArray = API.ByteArrayToByteArray(array, i, 86);
						byte[] array2 = API.ByteArrayToByteArray(byteArray, 1, 20);
						byte[] array3 = API.ByteArrayToByteArray(byteArray, 22, 2);
						byte[] array4 = API.ByteArrayToByteArray(byteArray, 24, 2);
						int num2 = Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							array3[1],
							array3[0]
						}), 16);
						int num3 = Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							array4[1],
							array4[0]
						}), 16);
						string text = "";
						if (num2 <= 0)
						{
							continue;
						}
						num2 = (num2 ^ 0x6EA4 ^ 4) - 4;
						num3 = (num3 ^ 0x6EA4 ^ 4) - 4;
						int country = API.Country;
						if (country == 1)
						{
							if (Data_Skills_Thai.ContainsKey(num2))
							{
								text = Data_Skills_Thai[num2];
							}
						}
						else if (GetDataName.Data_Skill_Name.ContainsKey(num2))
						{
							text = GetDataName.Data_Skill_Name[num2];
						}
						_Skill value = new _Skill
						{
							_Id = num2,
							_Name = text,
							_Sp = num3
						};
						if (!Data_Skills.ContainsKey(num2))
						{
							Data_Skills.Add(num2, value);
						}
						if (!Data_Skills_Name.ContainsKey(text))
						{
							Data_Skills_Name.Add(text, value);
						}
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ProjectData.ClearProjectError();
						break;
					}
				}
			}
		}
	}
}
