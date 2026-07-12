using System.Collections.Generic;
using System.IO;
using Microsoft.VisualBasic.CompilerServices;

namespace Simple_Bot
{
	public class Doors
	{
		public struct Key_Door
		{
			public int _MapId1;

			public int _MapId2;
		}

		public static Dictionary<Key_Door, int> Data_Doors = new Dictionary<Key_Door, int>();

		public static void LoadDoors()
		{
			MyProject.Forms.MainForm.status = "load door.ini";
			if (File.Exists("data\\door.ini"))
			{
				MyProject.Forms.MainForm.DoorIni = MyProject.Computer.FileSystem.ReadAllText("data\\door.ini").Split('\r', '\r');
			}
			string[] doorIni = MyProject.Forms.MainForm.DoorIni;
			for (int i = 0; i < doorIni.Length; i = checked(i + 1))
			{
				string text = doorIni[i];
				text = text.Replace("\r\n", "").Replace("\r", "").Replace("\n", "");
				if (text.Length > 0)
				{
					string[] array = text.Split('\t');
					Key_Door key = new Key_Door
					{
						_MapId1 = Conversions.ToInteger(array[0]),
						_MapId2 = Conversions.ToInteger(array[2])
					};
					int value = Conversions.ToInteger(array[1]);
					if (!Data_Doors.ContainsKey(key))
					{
						Data_Doors.Add(key, value);
					}
				}
			}
		}
	}
}
