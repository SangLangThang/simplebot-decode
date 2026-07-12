using System.Collections.Generic;
using Microsoft.VisualBasic.CompilerServices;
using Simple_Bot.My.Resources;

namespace Simple_Bot
{
	public class GetDataName
	{
		public static Dictionary<int, string> Data_Item_Name = new Dictionary<int, string>();

		public static Dictionary<int, string> Data_Item_Info = new Dictionary<int, string>();

		public static Dictionary<int, string> Data_Npc_Name = new Dictionary<int, string>();

		public static Dictionary<int, string> Data_Skill_Name = new Dictionary<int, string>();

		public static void LoadDataItems_Name()
		{
			string[] array = Resources.itemvnkoco.Split('\r', '\r');
			foreach (string text in array)
			{
				if (text.Length > 0)
				{
					string[] array2 = text.Split('\t');
					if (!array2[0].StartsWith("//") & (array2[0].Length > 0))
					{
						Data_Item_Name.Add(Conversions.ToInteger(array2[0]), array2[1]);
						Data_Item_Info.Add(Conversions.ToInteger(array2[0]), array2[2]);
					}
				}
			}
		}

		public static void LoadDataNpcs_Name()
		{
			string[] array = Resources.npcvnkoco.Split('\r', '\r');
			foreach (string text in array)
			{
				if (text.Length > 0)
				{
					string[] array2 = text.Split('\t');
					if (!array2[0].StartsWith("//") & (array2[0].Length > 0))
					{
						Data_Npc_Name.Add(Conversions.ToInteger(array2[0]), array2[1]);
					}
				}
			}
		}

		public static void LoadDataSkills_Name()
		{
			string[] array = Resources.skillvnkoco.Split('\r', '\r');
			foreach (string text in array)
			{
				if (text.Length > 0)
				{
					string[] array2 = text.Split('\t');
					if (!array2[0].StartsWith("//") & (array2[0].Length > 0))
					{
						Data_Skill_Name.Add(Conversions.ToInteger(array2[0]), array2[1]);
					}
				}
			}
		}
	}
}
