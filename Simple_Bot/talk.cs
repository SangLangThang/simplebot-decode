using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Simple_Bot
{
	public class talk
	{
		public struct Talks
		{
			public int _Id;

			public int _l;

			public byte[] _Talk;
		}

		public static Dictionary<int, Talks> Data_Talks = new Dictionary<int, Talks>();

		public static void LoadDataTalks()
		{
			MyProject.Forms.MainForm.status = "Datanpc loading...";
			string path = "data\\talk.dat";
			int country = API.Country;
			if (country == 1)
			{
				path = "data\\TalkTHAI.dat";
			}
			byte[] array = File.ReadAllBytes(path);
			checked
			{
				int num = array.Length - 1;
				for (int i = 0; i <= num; i += 257)
				{
					try
					{
						byte[] array2 = API.ByteArrayToByteArray(array, i + 2, 257);
						int l = array2[0];
						byte[] array3 = API.ByteArrayToByteArray(array2, 255, 2);
						int num2 = Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							array3[1],
							array3[0]
						}), 16);
						if (num2 > 0)
						{
							num2 = (num2 ^ 0xECEA) - 6;
						}
						byte[] array4 = API.ByteArrayToByteArray(array2, 1, array2.Length - 3);
						Talks value = new Talks
						{
							_Id = num2,
							_l = l,
							_Talk = array4
						};
						Data_Talks.Add(value._Id, value);
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ProjectData.ClearProjectError();
						break;
					}
				}
				talkmenu.LoadDatatalkmenu();
			}
		}

		public static string _Get_Talk_String(Talks _t)
		{
			string Str = "";
			checked
			{
				int num = _t._Talk.Length - 1;
				int num2 = _t._Talk.Length - 1 - _t._l;
				for (int i = num; i >= num2; i += -1)
				{
					if (_t._Talk[i] > 0)
					{
						Str += Conversions.ToString(Strings.Chr(_t._Talk[i]));
					}
				}
				int country = API.Country;
				if (country == 1)
				{
					Str = Conversions.ToString(API.THAIEncodeString(ref Str));
				}
				return Str;
			}
		}
	}
}
