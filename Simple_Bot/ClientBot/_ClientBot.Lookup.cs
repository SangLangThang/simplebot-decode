using System;
using Microsoft.VisualBasic.CompilerServices;

namespace Simple_Bot
{
	public partial class _ClientBot
	{
		public string GetNamePlayer(int id)
		{
			string result = "";
			if (id == Data_Player._Id)
			{
				result = Data_Player._Name;
			}
			else if (Data_Players.ContainsKey(id))
			{
				result = Data_Players[id]._Name;
			}
			return result;
		}

		public int GetIdPlayer(string name)
		{
			int id = default(int);
			foreach (Listplayers._Player value in Data_Players.Values)
			{
				if (Operators.CompareString(value._Name, name, false) == 0)
				{
					id = value._Id;
				}
			}
			return id;
		}

		public string GetItemName(int _id)
		{
			string result = "";
			try
			{
				if (List_Items.ContainsKey(_id))
				{
					result = List_Items[_id]._Name;
				}
				else if (Items.Data_Items.ContainsKey(_id))
				{
					Items.ItemInfo value = Items.Data_Items[_id];
					List_Items.Add(_id, value);
					result = value._Name;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		public int GetItemHp(int _id)
		{
			int result = 0;
			try
			{
				if (List_Items.ContainsKey(_id))
				{
					result = List_Items[_id]._Hp;
				}
				else if (Items.Data_Items.ContainsKey(_id))
				{
					Items.ItemInfo value = Items.Data_Items[_id];
					List_Items.Add(_id, value);
					result = value._Hp;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		public int GetItemSp(int _id)
		{
			int result = 0;
			try
			{
				if (List_Items.ContainsKey(_id))
				{
					result = List_Items[_id]._Sp;
				}
				else if (Items.Data_Items.ContainsKey(_id))
				{
					Items.ItemInfo value = Items.Data_Items[_id];
					List_Items.Add(_id, value);
					result = value._Sp;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		public string GetItemInfo(int _id)
		{
			string text = "";
			try
			{
				if (List_Items.ContainsKey(_id))
				{
					Items.ItemInfo value = List_Items[_id];
					List_Items.Add(_id, value);
					if (value._Lv >= 0)
					{
						text = text + "Lv: " + value._Lv + "\r\n";
					}
					if (value._tt >= 0)
					{
						text = text + "TT: " + API.GetThuocTinh(value._tt) + "\r\n";
					}
					if (value._Hp > 0)
					{
						text = text + "Hp: " + value._Hp + "\r\n";
					}
					if (value._Sp > 0)
					{
						text = text + "Sp: " + value._Sp + "\r\n";
					}
					if (value._Int1 > 0)
					{
						text = text + "Int: " + value._Int1 + "\r\n";
					}
					if (value._Atk1 > 0)
					{
						text = text + "Atk: " + value._Atk1 + "\r\n";
					}
					if (value._Def1 > 0)
					{
						text = text + "Def: " + value._Def1 + "\r\n";
					}
					if (value._Hpx1 > 0)
					{
						text = text + "Hpx: " + value._Hpx1 + "\r\n";
					}
					if (value._Spx1 > 0)
					{
						text = text + "Spx: " + value._Spx1 + "\r\n";
					}
					if (value._Agi1 > 0)
					{
						text = text + "Agi: " + value._Agi1 + "\r\n";
					}
					if (value._Fai1 > 0)
					{
						text = text + "Fai: " + value._Fai1 + "\r\n";
					}
					text = "\r\n" + text + API.VISCII_to_Unicode(value._Info);
				}
				else if (Items.Data_Items.ContainsKey(_id))
				{
					Items.ItemInfo value2 = Items.Data_Items[_id];
					List_Items.Add(_id, value2);
					if (value2._Lv >= 0)
					{
						text = text + "Lv: " + value2._Lv + "\r\n";
					}
					if (value2._tt >= 0)
					{
						text = text + "TT: " + API.GetThuocTinh(value2._tt) + "\r\n";
					}
					if (value2._Hp > 0)
					{
						text = text + "Hp: " + value2._Hp + "\r\n";
					}
					if (value2._Sp > 0)
					{
						text = text + "Sp: " + value2._Sp + "\r\n";
					}
					if (value2._Int1 > 0)
					{
						text = text + "Int: " + value2._Int1 + "\r\n";
					}
					if (value2._Atk1 > 0)
					{
						text = text + "Atk: " + value2._Atk1 + "\r\n";
					}
					if (value2._Def1 > 0)
					{
						text = text + "Def: " + value2._Def1 + "\r\n";
					}
					if (value2._Hpx1 > 0)
					{
						text = text + "Hpx: " + value2._Hpx1 + "\r\n";
					}
					if (value2._Spx1 > 0)
					{
						text = text + "Spx: " + value2._Spx1 + "\r\n";
					}
					if (value2._Agi1 > 0)
					{
						text = text + "Agi: " + value2._Agi1 + "\r\n";
					}
					if (value2._Fai1 > 0)
					{
						text = text + "Fai: " + value2._Fai1 + "\r\n";
					}
					text = "\r\n" + text + API.VISCII_to_Unicode(value2._Info);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			return text;
		}

		public string GetNameNPC(int id)
		{
			string result = "";
			try
			{
				if (List_Npcs.ContainsKey(id))
				{
					result = List_Npcs[id]._Name;
				}
				else if (Npcs.Data_Npcs.ContainsKey(id))
				{
					List_Npcs.Add(id, Npcs.Data_Npcs[id]);
					if (id > 0)
					{
						result = Npcs.Data_Npcs[id]._Name;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		public int GetSkillId(string name)
		{
			int result = 10000;
			if (Skills.Data_Skills_Name.ContainsKey(name))
			{
				result = Skills.Data_Skills_Name[name]._Id;
			}
			return result;
		}

		public string GetSkillName(int id)
		{
			string result = Conversions.ToString(id);
			if (Skills.Data_Skills.ContainsKey(id))
			{
				result = Skills.Data_Skills[id]._Name;
			}
			return result;
		}

		public int GetSkillSP(int id)
		{
			int result = 0;
			if (Skills.Data_Skills.ContainsKey(id))
			{
				result = Skills.Data_Skills[id]._Sp;
			}
			return result;
		}

	}
}
