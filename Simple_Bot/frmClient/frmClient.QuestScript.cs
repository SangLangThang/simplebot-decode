using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Simple_Bot
{
	public partial class frmClient : Form
	{
		private void Button_StartAutoQuest_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(Button_StartAutoQuest.Text, "Dừng", false) == 0)
			{
				Button_StartAutoQuest.Text = "Bắt đầu";
				DataGridView1.Enabled = true;
				ComboBox_Quest.Enabled = true;
				_bot.Startautoquest = false;
				_bot.EndQuest = 0;
				_questSteps.Clear();
				if (_bot.showmenu == 1)
				{
					_bot.ChoiceId(0);
				}
				_bot.SendEnd();
				_bot.ClickNPCId(99);
				return;
			}
			Button_StartAutoQuest.Text = "Dừng";
			if ((_bot.ComboBox_Port != 0) & !_bot._Proxy)
			{
				Interaction.MsgBox("Bạn chỉ có thể sử dụng ở kênh 0!");
				return;
			}
			if (_bot.bott != 0)
			{
				MsgBoxResult msgBoxResult = Interaction.MsgBox("Bạn đang bot, Bạn có muốn dừng bot không?", MsgBoxStyle.YesNo, "Chú ý");
				if (msgBoxResult == MsgBoxResult.No)
				{
					return;
				}
				_bot.bott = 0;
			}
			if (_bot.atw != 0)
			{
				Interaction.MsgBox("Bạn đang autowarp, dừng autowarp trước!");
			}
			else if ((_bot.Data_Player._LeaderId != 0) & (_bot.Data_Player._LeaderId != _bot.Data_Player._Id))
			{
				Interaction.MsgBox("Bạn đang trong nhóm và không phải chủ nhóm!");
			}
			else if (Operators.CompareString(_bot.Online, "ON", false) != 0)
			{
				Interaction.MsgBox("Bạn phải đăng nhập vào game!");
			}
			else
			{
				CompileQuestScript();
			}
		}

		private void ComboBox_Quest_DropDown(object sender, EventArgs e)
		{
			try
			{
				string[] files = Directory.GetFiles(MyProject.Application.Info.DirectoryPath + "\\QuestFarm", "*.ini");
				ComboBox_Quest.Items.Clear();
				string[] array = files;
				foreach (string text in array)
				{
					if (text.Contains(".ini"))
					{
						ComboBox_Quest.Items.Add(text.Substring(checked(text.LastIndexOf("\\") + 1)).Replace(".ini", ""));
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

		private void ComboBox_Quest_SelectedIndexChanged(object sender, EventArgs e)
		{
			string file = "QuestFarm\\" + ComboBox_Quest.Text + ".ini";
			DataGridView1.Rows.Clear();
			string[] array = MyProject.Computer.FileSystem.ReadAllText(file).Split('\r', '\r');
			checked
			{
				foreach (string text in array)
				{
					if (text.Length <= 1)
					{
						continue;
					}
					string[] array2 = text.Split(' ');
					if (array2.Length > 1)
					{
						string text2 = array2[0].Replace("\n", "");
						string text3 = array2[1];
						string text4 = "";
						if (array2.Length > 2)
						{
							int num = array2.Length - 1;
							for (int j = 2; j <= num; j++)
							{
								text4 += array2[j];
							}
						}
						if (DataGridView1.Rows.Count == 1)
						{
							DataGridView1.Rows.Add(true, text2, text3, text4);
						}
						else
						{
							DataGridView1.Rows.Add(false, text2, text3, text4);
						}
					}
					else
					{
						DataGridView1.Rows.Add(false, text);
					}
				}
			}
		}

		public string StrToHex(ref string Data)
		{
			string text = "";
			while (Data.Length > 0)
			{
				string text2 = Strings.Asc(Data.Substring(0, 1)).ToString("X2");
				Data = Data.Substring(1, checked(Data.Length - 1));
				text += text2;
			}
			return text;
		}

		private void CompileQuestScript()
		{
			if (DataGridView1.Rows.Count == 0)
			{
				return;
			}
			DataGridView1.Enabled = false;
			ComboBox_Quest.Enabled = false;
			RichTextBox_hienthiquest.Clear();
			_questSteps.Clear();
			_questStepIndex = 0;
			try
			{
				int num = 0;
				foreach (DataGridViewRow item in (IEnumerable)DataGridView1.Rows)
				{
					if (Operators.ConditionalCompareObjectEqual(item.Cells[0].Value, true, false))
					{
						num = 1;
					}
					if (num != 1)
					{
						continue;
					}
					Type typeFromHandle = typeof(Strings);
					DataGridViewCell dataGridViewCell;
					object[] obj = new object[1] { (dataGridViewCell = item.Cells[1]).Value };
					object[] array = obj;
					bool[] obj2 = new bool[1] { true };
					bool[] array2 = obj2;
					object obj3 = NewLateBinding.LateGet(null, typeFromHandle, "LCase", obj, null, null, obj2);
					if (array2[0])
					{
						dataGridViewCell.Value = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
					}
					string text = obj3.ToString().Replace(" ", "");
					if (_list_Func.Contains(text))
					{
						int num2 = Conversions.ToInteger(item.Cells[2].Value);
						switch (text)
						{
						case "end":
						case "battle":
						case "next":
						case "catpet":
						{
							_QuestStep questStep2 = new _QuestStep
							{
								_Func = text,
								_id = 0,
								_index = item.Index
							};
							_questSteps.Add(questStep2);
							break;
						}
						default:
						{
							_QuestStep questStep = new _QuestStep
							{
								_Func = text,
								_id = num2,
								_index = item.Index
							};
							_questSteps.Add(questStep);
							break;
						}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox("Script lỗi!!!");
				ProjectData.ClearProjectError();
			}
			_bot.Step_sendend = 0;
			_bot.Startautoquest = true;
		}

		private void ExecuteQuestStep()
		{
			checked
			{
				if (_bot.Startautoquest & (_bot.EndQuest == 0) & (_bot.Battle == 0) & (_bot.BTQ == 0) & (_bot.atw == 0) & (_questSteps.Count > 0))
				{
					_QuestStep questStep = (_QuestStep)_questSteps[_questStepIndex];
					string func = questStep._Func;
					int num = questStep._id;
					int index = questStep._index;
					switch (FnvHash.Compute(func))
					{
					case 2398780079u:
						if (Operators.CompareString(func, "warp", false) == 0)
						{
							int num2 = num;
							if (num2 == _bot.Data_Player._MapId)
							{
								DataGridView1.Rows[index].Cells[1].Style.BackColor = Color.LightSkyBlue;
								DataGridView1.Rows[index].Cells[1].Selected = true;
								DataGridView1.FirstDisplayedScrollingRowIndex = index;
								RichTextBox_hienthiquest.AppendText("\r\n" + func + " " + num);
								_questStepIndex++;
							}
							else if (_bot._Questing == 0)
							{
								_bot.atw = 1;
								_bot.AutoWarptoMap = num.ToString();
								_bot.AutoWarp(_bot.AutoWarptoMap);
								DataGridView1.Rows[index].Cells[1].Style.BackColor = Color.LightSkyBlue;
								DataGridView1.Rows[index].Cells[1].Selected = true;
								DataGridView1.FirstDisplayedScrollingRowIndex = index;
								RichTextBox_hienthiquest.AppendText("\r\n" + func + " " + num);
								_questStepIndex++;
							}
						}
						break;
					case 2160783330u:
						if (Operators.CompareString(func, "warpid", false) == 0 && _bot._Questing == 0)
						{
							_bot.Warp(num);
							DataGridView1.Rows[index].Cells[1].Style.BackColor = Color.LightSkyBlue;
							DataGridView1.Rows[index].Cells[1].Selected = true;
							DataGridView1.FirstDisplayedScrollingRowIndex = index;
							RichTextBox_hienthiquest.AppendText("\r\n" + func + " " + num);
							_questStepIndex++;
						}
						break;
					case 1551804527u:
						if (Operators.CompareString(func, "click", false) == 0 && _bot._Questing == 0)
						{
							NpcOnMap.Key_NpcOnMap key = new NpcOnMap.Key_NpcOnMap
							{
								_Idmap = _bot.Data_Player._MapId,
								_id = num
							};
							if (NpcOnMap.Data_NpcOnMap.ContainsKey(key))
							{
								NpcOnMap.NpcMapInfo npcOnMap = NpcOnMap.Data_NpcOnMap[key];
								_bot.Walk(npcOnMap._X, npcOnMap._Y);
								Thread.Sleep(200);
							}
							_bot.ClickNPCId(num);
							DataGridView1.Rows[index].Cells[1].Style.BackColor = Color.LightSkyBlue;
							DataGridView1.Rows[index].Cells[1].Selected = true;
							DataGridView1.FirstDisplayedScrollingRowIndex = index;
							RichTextBox_hienthiquest.AppendText("\r\n" + func + " " + num);
							_questStepIndex++;
						}
						break;
					case 2581912890u:
						if (Operators.CompareString(func, "menu", false) == 0)
						{
							switch (_bot.showmenu)
							{
							case 1:
								_bot.showmenu = 0;
								_bot.ChoiceId(num);
								_bot.SendEnd();
								DataGridView1.Rows[index].Cells[1].Style.BackColor = Color.LightSkyBlue;
								DataGridView1.Rows[index].Cells[1].Selected = true;
								DataGridView1.FirstDisplayedScrollingRowIndex = index;
								RichTextBox_hienthiquest.AppendText("\r\n" + func + " " + num);
								_questStepIndex++;
								break;
							case 2:
								_bot.showmenu = 0;
								DataGridView1.Rows[index].Cells[1].Style.BackColor = Color.OrangeRed;
								DataGridView1.Rows[index].Cells[1].Selected = true;
								DataGridView1.FirstDisplayedScrollingRowIndex = index;
								RichTextBox_hienthiquest.AppendText("\r\n" + func + " [Cancel]");
								_questStepIndex++;
								break;
							}
						}
						break;
					case 1555467752u:
						if (Operators.CompareString(func, "next", false) == 0)
						{
							_bot.ClickNPCId(99);
							DataGridView1.Rows[index].Cells[1].Style.BackColor = Color.LightSkyBlue;
							DataGridView1.Rows[index].Cells[1].Selected = true;
							DataGridView1.FirstDisplayedScrollingRowIndex = index;
							RichTextBox_hienthiquest.AppendText("\r\n" + func);
							_questStepIndex++;
						}
						break;
					case 2820971575u:
						if (Operators.CompareString(func, "battle", false) == 0)
						{
							DataGridView1.Rows[index].Cells[1].Style.BackColor = Color.LightSkyBlue;
							DataGridView1.Rows[index].Cells[1].Selected = true;
							DataGridView1.FirstDisplayedScrollingRowIndex = index;
							RichTextBox_hienthiquest.AppendText("\r\n" + func);
							_questStepIndex++;
						}
						break;
					case 4216135404u:
						if (Operators.CompareString(func, "catpet", false) == 0)
						{
							_bot.SendPacket(API.hexstringtobyte("F44402001302"));
							DataGridView1.Rows[index].Cells[1].Style.BackColor = Color.LightSkyBlue;
							DataGridView1.Rows[index].Cells[1].Selected = true;
							DataGridView1.FirstDisplayedScrollingRowIndex = index;
							RichTextBox_hienthiquest.AppendText("\r\n" + func);
							_questStepIndex++;
						}
						break;
					case 1709849540u:
						if (Operators.CompareString(func, "xuatchien", false) == 0)
						{
							DataGridView1.Rows[index].Cells[1].Style.BackColor = Color.LightSkyBlue;
							DataGridView1.Rows[index].Cells[1].Selected = true;
							DataGridView1.FirstDisplayedScrollingRowIndex = index;
							_bot.SendPacket(API.hexstringtobyte("F44406001301" + API.Int32ToHex2(num) + "0000"));
							RichTextBox_hienthiquest.AppendText("\r\n" + func);
							_questStepIndex++;
						}
						break;
					case 1787721130u:
						if (Operators.CompareString(func, "end", false) == 0)
						{
							_bot.EndQuest = 1;
							_bot.DelayEndQuest = 0;
							DataGridView1.Rows[index].Cells[1].Style.BackColor = Color.LightSkyBlue;
							DataGridView1.Rows[index].Cells[1].Selected = true;
							DataGridView1.FirstDisplayedScrollingRowIndex = index;
							RichTextBox_hienthiquest.AppendText("\r\n" + func);
						}
						break;
					}
					_bot.DelayStepQuest = 0;
				}
				if (_bot.EndQuest == 1)
				{
					if (_bot.DelayEndQuest >= 2)
					{
						RichTextBox_hienthiquest.AppendText("\r\nXong Quest");
						Button_StartAutoQuest.Text = "Bắt đầu";
						DataGridView1.Enabled = true;
						ComboBox_Quest.Enabled = true;
						_bot.Startautoquest = false;
						_bot.EndQuest = 0;
					}
				}
				else
				{
					if (!((_bot.DelayStepQuest >= 5) & (_bot.Battle == 0) & (_questSteps.Count > 0)))
					{
						return;
					}
					_bot.DelayStepQuest = 0;
					_QuestStep questStep2 = (_QuestStep)_questSteps[_questStepIndex - 1];
					string func2 = questStep2._Func;
					int num3 = questStep2._id;
					int index2 = questStep2._index;
					if (Operators.CompareString(func2, "warp", false) == 0)
					{
						int num4 = num3;
						if (num4 == _bot.Data_Player._MapId)
						{
							DataGridView1.Rows[index2].Cells[1].Style.BackColor = Color.LightPink;
							DataGridView1.Rows[index2].Cells[1].Selected = true;
							DataGridView1.FirstDisplayedScrollingRowIndex = index2;
							RichTextBox_hienthiquest.AppendText("\r\n" + func2 + " " + num3);
						}
						else
						{
							_bot.atw = 1;
							_bot.AutoWarptoMap = num3.ToString();
							_bot.AutoWarp(_bot.AutoWarptoMap);
							DataGridView1.Rows[index2].Cells[1].Style.BackColor = Color.LightPink;
							DataGridView1.Rows[index2].Cells[1].Selected = true;
							DataGridView1.FirstDisplayedScrollingRowIndex = index2;
							RichTextBox_hienthiquest.AppendText("\r\n" + func2 + " " + num3);
						}
					}
				}
			}
		}

		private void Timer_QuestDelay_Tick(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					_bot.DelayStepQuest++;
					if (_bot.EndQuest == 1)
					{
						_bot.DelayEndQuest++;
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


		private void Button_QuestScriptHelp_Click(object sender, EventArgs e)
		{
			Interaction.MsgBox("Các hàm có thể sư dụng:\r\n\r\nwarp x       (x là mapid )\r\nwarpid x     (x là id)\r\nclick x      (x là id npc click)\r\nmenu x       (x là số trả lời câu hỏi)\r\ncatpet       (cất pet đi)\r\nxuatchien x  (x là id pet xuất chiến)\r\nend          (kết thúc)");
		}

		private void Button_RefreshQuestList_Click(object sender, EventArgs e)
		{
			if (ListView_Quest.Items.Count > 0)
			{
				ListView_Quest.Items.Clear();
			}
			if (_bot == null || _bot.logined != 1)
			{
				return;
			}
			checked
			{
				try
				{
					if (_bot.listquest_Done.Count > 0)
					{
						int num = _bot.listquest_Done.Count - 1;
						for (int i = 0; i <= num; i++)
						{
							int num2 = Conversions.ToInteger(_bot.listquest_Done[i]);
							switch (Ground.Data_Marks_Name.ContainsKey(num2))
							{
							case true:
							{
								ListViewItem listViewItem2 = ListView_Quest.Items.Add(Ground.Data_Marks_Name[num2]);
								listViewItem2.UseItemStyleForSubItems = false;
								break;
							}
							case false:
							{
								ListViewItem listViewItem = ListView_Quest.Items.Add(Conversions.ToString(num2));
								listViewItem.UseItemStyleForSubItems = false;
								break;
							}
							}
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
				try
				{
					if (_bot.listquest_Doing.Count <= 0)
					{
						return;
					}
					int num3 = _bot.listquest_Doing.Count - 1;
					for (int j = 0; j <= num3; j++)
					{
						int key = Conversions.ToInteger(_bot.listquest_Doing[j]);
						bool flag = Ground.Data_Marks_Name.ContainsKey(key);
						if (flag)
						{
							ListViewItem listViewItem3 = ListView_Quest.Items.Add(Ground.Data_Marks_Name[key]);
							listViewItem3.UseItemStyleForSubItems = false;
							listViewItem3.SubItems[0].ForeColor = Color.RoyalBlue;
						}
					}
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					ProjectData.ClearProjectError();
				}
			}
		}

		private void Button_CheckSpecificQuests_Click(object sender, EventArgs e)
		{
			ArrayList arrayList = new ArrayList(new int[8] { 10325, 10327, 10329, 10361, 10807, 10529, 10385, 10565 });
			string text = "";
			checked
			{
				int num = arrayList.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					int num2 = Conversions.ToInteger(arrayList[i]);
					text = ((!_bot.listquest_Done.Contains(num2)) ? (text + Ground.Data_Marks_Name[num2] + "\t [No]\r\n") : (text + Ground.Data_Marks_Name[num2] + "\t [Yes]\r\n"));
				}
				Interaction.MsgBox(text);
			}
		}

	}
}
