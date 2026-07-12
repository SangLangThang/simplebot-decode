using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualBasic.CompilerServices;
using Simple_Bot.My.Resources;

namespace Simple_Bot
{
	public class talkmenu
	{
		public struct Key_talkmenu
		{
			public int _Idmap;

			public int _id;
		}

		public struct _talkmenu
		{
			public int _MapId;

			public int _Id;

			public int _SLTalk;

			public ArrayList _Talks;
		}

		public static Dictionary<Key_talkmenu, _talkmenu> Data_talkmenu = new Dictionary<Key_talkmenu, _talkmenu>();

		public static void LoadDatatalkmenu()
		{
			MyProject.Forms.MainForm.status = "Datatalk loading...";
			string[] array = Resources.talkmenu.Split('\r', '\r');
			checked
			{
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
					_talkmenu value = new _talkmenu
					{
						_MapId = Conversions.ToInteger(array2[0]),
						_Id = Conversions.ToInteger(array2[1]),
						_SLTalk = Conversions.ToInteger(array2[2])
					};
					ArrayList arrayList = new ArrayList();
					int num = value._SLTalk + 2;
					for (int j = 3; j <= num; j++)
					{
						arrayList.Add(Conversions.ToInteger(array2[j]));
					}
					value._Talks = arrayList;
					Key_talkmenu key = new Key_talkmenu
					{
						_Idmap = value._MapId,
						_id = value._Id
					};
					try
					{
						if (!Data_talkmenu.ContainsKey(key))
						{
							Data_talkmenu.Add(key, value);
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
}
