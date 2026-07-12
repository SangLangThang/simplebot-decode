using System.Collections.Generic;
using Microsoft.VisualBasic.CompilerServices;

namespace Simple_Bot
{
	public class MapNames
	{
		public static Dictionary<int, string> Data_MapNames = new Dictionary<int, string>();

		public static void LoadMapNames()
		{
			string[] array = MyProject.Computer.FileSystem.ReadAllText("data\\mapname.ini").Split('\r', '\r');
			for (int i = 0; i < array.Length; i = checked(i + 1))
			{
				string text = array[i];
				text = text.Replace("\r\n", "").Replace("\r", "").Replace("\n", "");
				if (text.Length > 0)
				{
					string[] array2 = text.Split('\t');
					int key = Conversions.ToInteger(array2[0]);
					string value = array2[1];
					if (!Data_MapNames.ContainsKey(key))
					{
						Data_MapNames.Add(key, value);
					}
				}
			}
		}
	}
}
