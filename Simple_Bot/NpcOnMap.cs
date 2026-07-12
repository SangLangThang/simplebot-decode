using System;
using System.Collections.Generic;
using Microsoft.VisualBasic.CompilerServices;
using Simple_Bot.My.Resources;

namespace Simple_Bot
{
	public class NpcOnMap
	{
		public struct Key_NpcOnMap
		{
			public int _Idmap;

			public int _id;
		}

		public struct NpcMapInfo
		{
			public int _MapId;

			public int _Id;

			public int _NPCId;

			public string _Name;

			public int _X;

			public int _Y;
		}

		public static Dictionary<Key_NpcOnMap, NpcMapInfo> Data_NpcOnMap = new Dictionary<Key_NpcOnMap, NpcMapInfo>();

		public static void LoadDataNpcOnMap()
		{
			MyProject.Forms.MainForm.status = "Datanpc loading...";
			string[] array = Resources.NpcOnMap.Split('\r', '\r');
			foreach (string text in array)
			{
				if (text.Length <= 5)
				{
					break;
				}
				string[] array2 = text.Split('\t');
				if (array2[0].StartsWith("//"))
				{
					continue;
				}
				int key = Conversions.ToInteger(array2[2]);
				if (!Npcs.Data_Npcs.ContainsKey(key))
				{
					continue;
				}
				NpcMapInfo value = new NpcMapInfo
				{
					_MapId = Conversions.ToInteger(array2[0]),
					_Id = Conversions.ToInteger(array2[1]),
					_Name = API.VISCII_to_Unicode(Npcs.Data_Npcs[key]._Name),
					_NPCId = Conversions.ToInteger(array2[2]),
					_X = Conversions.ToInteger(array2[3]),
					_Y = Conversions.ToInteger(array2[4])
				};
				Key_NpcOnMap key2 = new Key_NpcOnMap
				{
					_Idmap = value._MapId,
					_id = value._Id
				};
				try
				{
					if (!Data_NpcOnMap.ContainsKey(key2))
					{
						Data_NpcOnMap.Add(key2, value);
					}
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
}
