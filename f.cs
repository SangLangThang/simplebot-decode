using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Simple_Bot;

[StandardModule]
internal sealed class f
{
	private static Hashtable m_a;

	public static List<string> IgnoredControlNames = new List<string>(new string[86]
	{
		"Label_Name1", "Label_Name2", "Label_Name3", "Label_Name4", "Label_Name5", "Label_Name6", "Label_Name7", "Label_Name8", "Label_Name9", "Label_Name10",
		"Label_Name11", "Label_Name12", "Label_Name13", "Label_Name14", "Label_Name15", "Label_Name16", "Label_Name17", "Label_Name18", "Label_Name19", "Label_Name20",
		"StatusBar_Battle", "Label20", "Label21", "Label22", "Label23", "Label34", "Label35", "Label37", "Label38", "Label39",
		"Label40", "Label41", "Label42", "Label43", "Label44", "Label55", "Label56", "Label57", "Label58", "Label59",
		"Label60", "Label74", "Label84", "Label85", "Label88", "Label89", "Label183", "Label_PetLevel", "Label_CharLevel", "Label_Point",
		"Label_Lv", "Label_petLv", "Label_IdLeader", "Label_gold", "Label_SL_God", "Label_SL_Ghost", "Label_PetInt", "Label_PetAtk", "Label_PetDef", "Label_PetHpx",
		"Label_PetSpx", "Label_PetInt1", "Label_PetAtk1", "Label_PetDef1", "Label_PetHpx1", "Label_PetSpx1", "Label_CharInt", "Label_CharAtk", "Label_CharDef", "Label_CharHpx",
		"Label_CharSpx", "Label_CharInt1", "Label_CharAtk1", "Label_CharDef1", "Label_CharHpx1", "Label_CharSpx1", "ToolStrip1", "TBPassword", "TBId", "Button_AddAgi",
		"Button_AddSpx", "Button_AddHpx", "Button_AddDef", "Button_AddAtk", "Button_AddInt", "btnLogin"
	});

	public static void a(Control A_0, bool A_1 = true)
	{
		if (A_1)
		{
			if (f.m_a == null)
			{
				f.m_a = new Hashtable(A_0.Controls.Count);
			}
			f.m_a.Clear();
		}
		Control control = new Control();
		if (A_0 == null || A_0.Controls == null || A_0.Controls.Count <= 0)
		{
			return;
		}
		checked
		{
			int num = A_0.Controls.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				if (A_0.Controls[i].Name.Length > 0 && !f.m_a.Contains(A_0.Controls[i].Name))
				{
					f.m_a.Add(A_0.Controls[i].Name, A_0.Controls[i]);
					a(A_0.Controls[i], false);
				}
			}
		}
	}

	public static void a(object A_0, string A_1)
	{
		if (A_0 == null)
		{
			return;
		}
		checked
		{
			try
			{
				string text = A_1;
				if (Operators.CompareString(text, "", false) == 0)
				{
					return;
				}
				switch (A_0.GetType().ToString())
				{
				case "System.Windows.Forms.TextBox":
					NewLateBinding.LateSet(A_0, null, "Text", new object[1] { text }, null, null);
					break;
				case "System.Windows.Forms.ComboBox":
				{
					object left = NewLateBinding.LateGet(A_0, null, "name", new object[0], null, null, null);
					if (Conversions.ToBoolean(Conversions.ToBoolean(Operators.CompareObjectEqual(left, "ComboBox_Port", false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(left, "ComboBox_botname", false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(left, "ComboBox_nameprivate", false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(left, "ComboBox_CharTurnSetting", false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(left, "ComboBox_CharSkill", false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(left, "ComboBox_CharLocation", false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(left, "ComboBox_sex", false))))
					{
						break;
					}
					object left3;
					object[] array2;
					bool[] array3;
					if (Operators.ConditionalCompareObjectEqual(left, "ComboBox_Server", false))
					{
						string text2 = "server.ini";
						if (!File.Exists(text2))
						{
							break;
						}
						string[] array = MyProject.Computer.FileSystem.ReadAllText(text2).Split('\r');
						foreach (string text3 in array)
						{
							string text4 = text3.Replace("\n", "").Substring(text3.IndexOf(".") + 1);
							text4 = text4.Substring(0, text4.IndexOf("*"));
							string left2 = text3.Substring(text3.IndexOf("*") + 1);
							if (Operators.CompareString(left2, text, false) != 0)
							{
								continue;
							}
							object instance = NewLateBinding.LateGet(A_0, null, "Items", new object[0], null, null, null);
							object[] obj = new object[1] { text4 };
							array2 = obj;
							bool[] obj2 = new bool[1] { true };
							array3 = obj2;
							left3 = NewLateBinding.LateGet(instance, null, "Contains", obj, null, null, obj2);
							if (array3[0])
							{
								text4 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
							}
							if (Operators.ConditionalCompareObjectEqual(left3, false, false))
							{
								object instance2 = NewLateBinding.LateGet(A_0, null, "Items", new object[0], null, null, null);
								object[] obj3 = new object[1] { text4 };
								array2 = obj3;
								bool[] obj4 = new bool[1] { true };
								array3 = obj4;
								NewLateBinding.LateCall(instance2, null, "Add", obj3, null, null, obj4, true);
								if (array3[0])
								{
									text4 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
								}
							}
							NewLateBinding.LateSet(A_0, null, "SelectedItem", new object[1] { text4 }, null, null);
							break;
						}
						break;
					}
					object instance3 = NewLateBinding.LateGet(A_0, null, "Items", new object[0], null, null, null);
					object[] obj5 = new object[1] { text };
					array2 = obj5;
					bool[] obj6 = new bool[1] { true };
					array3 = obj6;
					left3 = NewLateBinding.LateGet(instance3, null, "Contains", obj5, null, null, obj6);
					if (array3[0])
					{
						text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
					}
					if (Operators.ConditionalCompareObjectEqual(left3, false, false))
					{
						object instance4 = NewLateBinding.LateGet(A_0, null, "Items", new object[0], null, null, null);
						object[] obj7 = new object[1] { text };
						array2 = obj7;
						bool[] obj8 = new bool[1] { true };
						array3 = obj8;
						NewLateBinding.LateCall(instance4, null, "Add", obj7, null, null, obj8, true);
						if (array3[0])
						{
							text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
						}
					}
					NewLateBinding.LateSet(A_0, null, "SelectedItem", new object[1] { text }, null, null);
					break;
				}
				case "System.Windows.Forms.NumericUpDown":
					NewLateBinding.LateSet(A_0, null, "value", new object[1] { text }, null, null);
					break;
				case "System.Windows.Forms.RadioButton":
					if (Operators.CompareString(Strings.Mid(text, 1, 1), "1", false) == 0)
					{
						NewLateBinding.LateSet(A_0, null, "checked", new object[1] { true }, null, null);
					}
					else
					{
						NewLateBinding.LateSet(A_0, null, "checked", new object[1] { false }, null, null);
					}
					break;
				case "System.Windows.Forms.CheckBox":
					if (Operators.CompareString(Strings.Mid(text, 1, 1), "1", false) == 0)
					{
						NewLateBinding.LateSet(A_0, null, "checked", new object[1] { true }, null, null);
					}
					else
					{
						NewLateBinding.LateSet(A_0, null, "checked", new object[1] { false }, null, null);
					}
					break;
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

	public static void a(StreamReader A_0, DataSet A_1, Control A_2)
	{
		string name = "Table_ListDrop";
		bool flag = true;
		while (A_0.Peek() != -1)
		{
			string text = A_0.ReadLine();
			switch (text)
			{
			case "[Setting Skill]":
				flag = false;
				break;
			case "[Setting Drop]":
				name = "Table_ListDrop";
				break;
			case "[Setting Contribute]":
				name = "Table_ListContribute";
				break;
			case "[Setting Send]":
				name = "Table_ListSend";
				break;
			case "[Setting Pickup]":
				name = "Table_Pickup";
				break;
			case "[Setting Sell]":
				name = "Table_ListSell";
				break;
			}
			if (flag)
			{
				Control a_ = (Control)f.m_a[text];
				string a_2 = A_0.ReadLine();
				a(a_, a_2);
			}
			else if (text.Contains("="))
			{
				A_1.Tables["Table_Setting"].Rows[0][text.Substring(0, text.IndexOf("="))] = text.Substring(checked(text.IndexOf("=") + 1));
			}
			else
			{
				if (!text.Contains("id+"))
				{
					continue;
				}
				int num = Conversions.ToInteger(text.Substring(3));
				if (num > 0 && !A_1.Tables[name].Rows.Contains(num))
				{
					if (Items.Data_Items.ContainsKey(num))
					{
						A_1.Tables[name].Rows.Add(num, API.VISCII_to_Unicode(Items.Data_Items[num]._Name));
					}
					else
					{
						A_1.Tables[name].Rows.Add(num, num);
					}
				}
			}
		}
	}

	public static void a(StreamWriter A_0, Control A_1)
	{
		if (A_1 == null || A_1.Controls == null || A_1.Controls.Count <= 0)
		{
			return;
		}
		checked
		{
			int num = A_1.Controls.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				object obj = A_1.Controls[i];
				try
				{
					switch (obj.GetType().ToString())
					{
					case "System.Windows.Forms.TextBox":
					{
						string[] array = new string[31]
						{
							"TextBox_Country", "TBId", "TBPassword", "TextBox_RemoteDis", "TextBox_IDmem1", "TextBox_IDmem2", "TextBox_IDmem3", "TextBox_IDmem4", "TextBox_nameLeader", "TextBox_ClickMOD",
							"TextBox_Eat_char_hp_value", "TextBox_Eat_char_sp_value", "TextBox_Eat_pet_hp_value", "TextBox_Eat_pet_sp_value", "TextBox_TL_char_hp_value", "TextBox_TL_char_sp_value", "TextBox_TL_pet_hp_value", "TextBox_TL_pet_sp_value", "TextBox_createName", "TextBox_Pass",
							"TextBox_amma", "TextBox_DelayBot", "TextBox_AutoSend", "TextBox_Drop_HpValue", "TextBox_Drop_SpValue", "TextBox_Contribute_HpValue", "TextBox_Contribute_SpValue", "TextBox_Send_HpValue", "TextBox_Send_SpValue", "TextBox_Sell_HpValue",
							"TextBox_Sell_SpValue"
						};
						string[] array2 = array;
						foreach (string left in array2)
						{
							if (Operators.ConditionalCompareObjectEqual(left, NewLateBinding.LateGet(obj, null, "name", new object[0], null, null, null), false))
							{
								a(A_0, Conversions.ToString(NewLateBinding.LateGet(obj, null, "name", new object[0], null, null, null)), Conversions.ToString(NewLateBinding.LateGet(obj, null, "text", new object[0], null, null, null)));
							}
						}
						break;
					}
					case "System.Windows.Forms.ComboBox":
						if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(obj, null, "name", new object[0], null, null, null), "ComboBox_sex", false))
						{
							a(A_0, Conversions.ToString(NewLateBinding.LateGet(obj, null, "name", new object[0], null, null, null)), Conversions.ToString(NewLateBinding.LateGet(obj, null, "text", new object[0], null, null, null)));
						}
						else
						{
							if (!Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(obj, null, "name", new object[0], null, null, null), "ComboBox_Server", false))
							{
								break;
							}
							string text = "server.ini";
							if (!File.Exists(text))
							{
								break;
							}
							string[] array3 = MyProject.Computer.FileSystem.ReadAllText(text).Split('\r');
							foreach (string text2 in array3)
							{
								string text3 = text2.Replace("\n", "").Substring(text2.IndexOf(".") + 1);
								text3 = text3.Substring(0, text3.IndexOf("*"));
								if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(obj, null, "text", new object[0], null, null, null), text3, false))
								{
									a(A_0, Conversions.ToString(NewLateBinding.LateGet(obj, null, "name", new object[0], null, null, null)), text2.Substring(text2.LastIndexOf("*") + 1));
									break;
								}
							}
						}
						break;
					case "System.Windows.Forms.NumericUpDown":
						a(A_0, Conversions.ToString(NewLateBinding.LateGet(obj, null, "name", new object[0], null, null, null)), Conversions.ToString(NewLateBinding.LateGet(obj, null, "value", new object[0], null, null, null)));
						break;
					case "System.Windows.Forms.RadioButton":
						if (Conversions.ToBoolean(NewLateBinding.LateGet(obj, null, "checked", new object[0], null, null, null)))
						{
							a(A_0, Conversions.ToString(NewLateBinding.LateGet(obj, null, "name", new object[0], null, null, null)), "1");
						}
						else
						{
							a(A_0, Conversions.ToString(NewLateBinding.LateGet(obj, null, "name", new object[0], null, null, null)), "0");
						}
						break;
					case "System.Windows.Forms.CheckBox":
						if (Conversions.ToBoolean(NewLateBinding.LateGet(obj, null, "checked", new object[0], null, null, null)))
						{
							a(A_0, Conversions.ToString(NewLateBinding.LateGet(obj, null, "name", new object[0], null, null, null)), "1");
						}
						else
						{
							a(A_0, Conversions.ToString(NewLateBinding.LateGet(obj, null, "name", new object[0], null, null, null)), "0");
						}
						break;
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
				a(A_0, A_1.Controls[i]);
			}
		}
	}

	public static void b(Control A_0, DataSet A_1, string A_2)
	{
		checked
		{
			using (FileStream stream = new FileStream(A_2, FileMode.Create, FileAccess.Write, FileShare.Read))
			{
				using (StreamWriter streamWriter = new StreamWriter(stream, Encoding.Unicode))
				{
					a(A_0, true);
					a(streamWriter, A_0);
					streamWriter.WriteLine("[Setting Skill]");
					int num = A_1.Tables["Table_Setting"].Columns.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						streamWriter.WriteLine(A_1.Tables["Table_Setting"].Columns[i].ColumnName + "=" + A_1.Tables["Table_Setting"].Rows[0][i].ToString());
					}
					streamWriter.WriteLine("[Setting Drop]");
					int num2 = A_1.Tables["Table_ListDrop"].Rows.Count - 1;
					for (int j = 0; j <= num2; j++)
					{
						streamWriter.WriteLine("id+" + A_1.Tables["Table_ListDrop"].Rows[j][0].ToString());
					}
					streamWriter.WriteLine("[Setting Contribute]");
					int num3 = A_1.Tables["Table_ListContribute"].Rows.Count - 1;
					for (int k = 0; k <= num3; k++)
					{
						streamWriter.WriteLine("id+" + A_1.Tables["Table_ListContribute"].Rows[k][0].ToString());
					}
					streamWriter.WriteLine("[Setting Send]");
					int num4 = A_1.Tables["Table_ListSend"].Rows.Count - 1;
					for (int l = 0; l <= num4; l++)
					{
						streamWriter.WriteLine("id+" + A_1.Tables["Table_ListSend"].Rows[l][0].ToString());
					}
					streamWriter.WriteLine("[Setting Pickup]");
					int num5 = A_1.Tables["Table_Pickup"].Rows.Count - 1;
					for (int m = 0; m <= num5; m++)
					{
						streamWriter.WriteLine("id+" + A_1.Tables["Table_Pickup"].Rows[m][0].ToString());
					}
					streamWriter.WriteLine("[Setting Sell]");
					int num6 = A_1.Tables["Table_ListSell"].Rows.Count - 1;
					for (int n = 0; n <= num6; n++)
					{
						streamWriter.WriteLine("id+" + A_1.Tables["Table_ListSell"].Rows[n][0].ToString());
					}
				}
			}
		}
	}

	public static void a(Control A_0, DataSet A_1, string A_2)
	{
		StreamReader streamReader = new StreamReader(A_2);
		a(A_0, true);
		a(streamReader, A_1, A_0);
		streamReader.Close();
	}

	public static void d(Control A_0)
	{
		c(A_0);
	}

	public static void c(Control A_0)
	{
		if (A_0 == null || A_0.Controls == null || A_0.Controls.Count <= 0)
		{
			return;
		}
		checked
		{
			int num = A_0.Controls.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				object obj = A_0.Controls[i];
				try
				{
					switch (obj.GetType().ToString())
					{
					case "System.Windows.Forms.TextBox":
						break;
					case "System.Windows.Forms.NumericUpDown":
						break;
					case "Simple_Bot.SPB.ProgressBarEx":
						break;
					default:
						if (!IgnoredControlNames.Contains(Conversions.ToString(NewLateBinding.LateGet(obj, null, "name", new object[0], null, null, null))) && Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(obj, null, "text", new object[0], null, null, null), "", false))
						{
							IniFile.WriteString(API.Language_Path, "Language", Conversions.ToString(NewLateBinding.LateGet(obj, null, "name", new object[0], null, null, null)), Conversions.ToString(NewLateBinding.LateGet(obj, null, "text", new object[0], null, null, null)));
						}
						break;
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
				c(A_0.Controls[i]);
			}
		}
	}

	public static void b(Control A_0)
	{
		a(A_0);
	}

	public static void a(Control A_0)
	{
		if (A_0 == null || A_0.Controls == null || A_0.Controls.Count <= 0)
		{
			return;
		}
		checked
		{
			int num = A_0.Controls.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				object obj = A_0.Controls[i];
				try
				{
					switch (obj.GetType().ToString())
					{
					case "System.Windows.Forms.TextBox":
						break;
					case "System.Windows.Forms.NumericUpDown":
						break;
					case "Simple_Bot.SPB.ProgressBarEx":
						break;
					case "System.Windows.Forms.ComboBox":
						break;
					default:
						if (!IgnoredControlNames.Contains(Conversions.ToString(NewLateBinding.LateGet(obj, null, "name", new object[0], null, null, null))))
						{
							string left = IniFile.ReadString(API.Language_Path, "Language", Conversions.ToString(NewLateBinding.LateGet(obj, null, "name", new object[0], null, null, null)), "");
							if (Operators.CompareString(left, "nothing", false) != 0)
							{
								NewLateBinding.LateSet(obj, null, "text", new object[1] { IniFile.ReadString(API.Language_Path, "Language", Conversions.ToString(NewLateBinding.LateGet(obj, null, "name", new object[0], null, null, null)), "") }, null, null);
							}
						}
						break;
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
				a(A_0.Controls[i]);
			}
		}
	}

	private static void a(StreamWriter A_0, string A_1, string A_2)
	{
		A_0.WriteLine(A_1);
		A_0.WriteLine(A_2);
	}
}
