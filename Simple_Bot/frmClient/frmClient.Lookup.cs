using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Simple_Bot
{
	public partial class frmClient : Form
	{
		public string MakeItemInfo(ushort id)
		{
			string text = "";
			if (Items.Data_Items.ContainsKey(id))
			{
				Items.ItemInfo items = Items.Data_Items[id];
				text += "[ ";
				if (Items.Data_Items.ContainsKey(id))
				{
					text += Items.Data_Items[id]._Name;
				}
				text += " ]\r\n";
				if (items._Lv > 0)
				{
					text = text + "Cấp: +" + Conversions.ToString(items._Lv) + "\r\n";
				}
				int value = items._Value1;
				switch (items._Type_Value1)
				{
				case 207:
					text = text + "HPX: +" + Conversions.ToString(value) + "\r\n";
					break;
				case 208:
					text = text + "SPX: +" + Conversions.ToString(value) + "\r\n";
					break;
				case 212:
					text = text + "INT: +" + Conversions.ToString(value) + "\r\n";
					break;
				case 210:
					text = text + "ATK: +" + Conversions.ToString(value) + "\r\n";
					break;
				case 211:
					text = text + "DEF: +" + Conversions.ToString(value) + "\r\n";
					break;
				case 218:
					text = text + "Hp Max: +" + Conversions.ToString(value) + "\r\n";
					break;
				case 219:
					text = text + "Sp Max: +" + Conversions.ToString(value) + "\r\n";
					break;
				case 214:
					text = text + "AGI: +" + Conversions.ToString(value) + "\r\n";
					break;
				case 25:
					text = text + "HP: +" + Conversions.ToString(value) + "\r\n";
					break;
				case 26:
					text = text + "SP: +" + Conversions.ToString(value) + "\r\n";
					break;
				case 64:
					text = text + "Fai: +" + Conversions.ToString(value) + "\r\n";
					break;
				}
				value = items._Value2;
				switch (items._Type_Value2)
				{
				case 207:
					text = text + "HPX: +" + Conversions.ToString(value) + "\r\n";
					break;
				case 208:
					text = text + "SPX: +" + Conversions.ToString(value) + "\r\n";
					break;
				case 212:
					text = text + "INT: +" + Conversions.ToString(value) + "\r\n";
					break;
				case 210:
					text = text + "ATK: +" + Conversions.ToString(value) + "\r\n";
					break;
				case 211:
					text = text + "DEF: +" + Conversions.ToString(value) + "\r\n";
					break;
				case 218:
					text = text + "Hp Max: +" + Conversions.ToString(value) + "\r\n";
					break;
				case 219:
					text = text + "Sp Max: +" + Conversions.ToString(value) + "\r\n";
					break;
				case 214:
					text = text + "AGI: +" + Conversions.ToString(value) + "\r\n";
					break;
				case 25:
					text = text + "HP: +" + Conversions.ToString(value) + "\r\n";
					break;
				case 26:
					text = text + "SP: +" + Conversions.ToString(value) + "\r\n";
					break;
				case 64:
					text = text + "Fai: +" + Conversions.ToString(value) + "\r\n";
					break;
				}
				if (items._Type == 42)
				{
					text = text + "Bạo kích: +" + Conversions.ToString(items._IdBua) + "%\r\n";
				}
				if (Items.Data_Items.ContainsKey(id))
				{
					text += Items.Data_Items[id]._Info;
				}
				text = text.Replace("+-", "-");
			}
			return text;
		}


		private int GetSkillIdByName(string skillName)
		{
			int result = 10000;
			if (Skills.Data_Skills_Name.ContainsKey(skillName))
			{
				result = Skills.Data_Skills_Name[skillName]._Id;
			}
			return result;
		}

		private string GetSkillName(int skillId)
		{
			string result = Conversions.ToString(skillId);
			if (Skills.Data_Skills.ContainsKey(skillId))
			{
				result = Skills.Data_Skills[skillId]._Name;
			}
			return result;
		}

		private int GetSkillSpCost(int skillId)
		{
			int result = 0;
			if (Skills.Data_Skills.ContainsKey(skillId))
			{
				result = Skills.Data_Skills[skillId]._Sp;
			}
			return result;
		}

		private string GetItemName(int itemId)
		{
			string result = "";
			if (Items.Data_Items.ContainsKey(itemId))
			{
				result = Items.Data_Items[itemId]._Name;
			}
			return result;
		}

		private int GetItemHp(int itemId)
		{
			int result = 0;
			if (Items.Data_Items.ContainsKey(itemId))
			{
				result = Items.Data_Items[itemId]._Hp;
			}
			return result;
		}

		private int GetItemSp(int itemId)
		{
			int result = 0;
			if (Items.Data_Items.ContainsKey(itemId))
			{
				result = Items.Data_Items[itemId]._Sp;
			}
			return result;
		}

		private string GetItemTooltipText(int itemId)
		{
			string text = "";
			if (Items.Data_Items.ContainsKey(itemId))
			{
				Items.ItemInfo items = Items.Data_Items[itemId];
				if (items._Lv != 0)
				{
					text = text + "Lv: " + items._Lv + "\r\n";
				}
				if (items._tt != 0)
				{
					text = text + "TT: " + API.GetThuocTinh(items._tt) + "\r\n";
				}
				if (items._Hp != 0)
				{
					text = text + "Hp: " + items._Hp + "\r\n";
				}
				if (items._Sp != 0)
				{
					text = text + "Sp: " + items._Sp + "\r\n";
				}
				if (items._Int1 != 0)
				{
					text = text + "Int: " + items._Int1 + "\r\n";
				}
				if (items._Atk1 != 0)
				{
					text = text + "Atk: " + items._Atk1 + "\r\n";
				}
				if (items._Def1 != 0)
				{
					text = text + "Def: " + items._Def1 + "\r\n";
				}
				if (items._Hpx1 != 0)
				{
					text = text + "Hpx: " + items._Hpx1 + "\r\n";
				}
				if (items._Spx1 != 0)
				{
					text = text + "Spx: " + items._Spx1 + "\r\n";
				}
				if (items._Agi1 != 0)
				{
					text = text + "Agi: " + items._Agi1 + "\r\n";
				}
				if (items._Fai1 != 0)
				{
					text = text + "Fai: " + items._Fai1 + "\r\n";
				}
				text = "\r\n" + text + API.VISCII_to_Unicode(items._Info);
			}
			return text;
		}

		private string GetNpcName(int npcId)
		{
			string result = "";
			if (Npcs.Data_Npcs.ContainsKey(npcId) && npcId > 0)
			{
				result = Npcs.Data_Npcs[npcId]._Name;
			}
			return result;
		}

	}
}
