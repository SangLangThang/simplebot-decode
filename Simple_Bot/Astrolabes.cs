using System.Collections.Generic;
using Microsoft.VisualBasic.CompilerServices;
using Simple_Bot.My.Resources;

namespace Simple_Bot
{
	public class Astrolabes
	{
		public static Dictionary<int, int> _hpx = new Dictionary<int, int>();

		public static Dictionary<int, int> _def = new Dictionary<int, int>();

		public static Dictionary<int, int> _int = new Dictionary<int, int>();

		public static Dictionary<int, int> _spx = new Dictionary<int, int>();

		public static Dictionary<int, int> _agi = new Dictionary<int, int>();

		public static Dictionary<int, int> _atk = new Dictionary<int, int>();

		public static void LoadDataAstrolabes()
		{
			string[] array = Resources.Astrolabe.Split('\r', '\r');
			foreach (string text in array)
			{
				if (text.Length <= 0)
				{
					break;
				}
				string[] array2 = text.Split('\t');
				if (array2[0].StartsWith("//"))
				{
					continue;
				}
				int num = 1;
				do
				{
					switch (Conversions.ToInteger(array2[0]))
					{
					case 1:
						_hpx.Add(num, Conversions.ToInteger(array2[num]));
						break;
					case 2:
						_def.Add(num, Conversions.ToInteger(array2[num]));
						break;
					case 3:
						_int.Add(num, Conversions.ToInteger(array2[num]));
						break;
					case 4:
						_spx.Add(num, Conversions.ToInteger(array2[num]));
						break;
					case 5:
						_agi.Add(num, Conversions.ToInteger(array2[num]));
						break;
					case 6:
						_atk.Add(num, Conversions.ToInteger(array2[num]));
						break;
					}
					num = checked(num + 1);
				}
				while (num <= 10);
			}
		}
	}
}
