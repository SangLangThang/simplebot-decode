using System.Collections.Generic;
using Microsoft.VisualBasic.CompilerServices;
using Simple_Bot.My.Resources;

namespace Simple_Bot
{
	public class Texps
	{
		public struct _Texp
		{
			public int _Lv;

			public int _0;

			public int _1;

			public int _2;

			public int _3;
		}

		public static Dictionary<int, _Texp> Data_Texps = new Dictionary<int, _Texp>();

		public static void LoadDataTexps()
		{
			string[] array = Resources.Texps.Split('\r', '\r');
			foreach (string text in array)
			{
				if (text.Length <= 0)
				{
					break;
				}
				string[] array2 = text.Split('\t');
				if (!array2[0].StartsWith("//"))
				{
					_Texp value = new _Texp
					{
						_Lv = Conversions.ToInteger(array2[0]),
						_0 = Conversions.ToInteger(array2[1]),
						_1 = Conversions.ToInteger(array2[2]),
						_2 = Conversions.ToInteger(array2[3]),
						_3 = Conversions.ToInteger(array2[4])
					};
					Data_Texps.Add(value._Lv, value);
				}
			}
		}

		public static int TexpGetLvUp(int _Lv, int _Reborn, int _Texp)
		{
			int result = 0;
			checked
			{
				if (_Lv < 200)
				{
					for (int i = _Lv; i <= 199; i++)
					{
						switch (_Reborn)
						{
						case 0:
							if (_Texp < Data_Texps[i]._0)
							{
								break;
							}
							if (_Texp >= Data_Texps[i]._0)
							{
								result = i - _Lv + 1;
							}
							continue;
						case 1:
							if (_Texp < Data_Texps[i]._1)
							{
								break;
							}
							if (_Texp >= Data_Texps[i]._1)
							{
								result = i - _Lv + 1;
							}
							continue;
						case 2:
							if (_Texp < Data_Texps[i]._2)
							{
								break;
							}
							if (_Texp >= Data_Texps[i]._2)
							{
								result = i - _Lv + 1;
							}
							continue;
						case 3:
							if (_Texp < Data_Texps[i]._3)
							{
								break;
							}
							if (_Texp >= Data_Texps[i]._3)
							{
								result = i - _Lv + 1;
							}
							continue;
						default:
							continue;
						}
						break;
					}
				}
				return result;
			}
		}
	}
}
