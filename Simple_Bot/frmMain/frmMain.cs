using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Simple_Bot
{
	public partial class frmMain : Form
	{
		public frmMain()
		{
			base.Load += Form2_Load;
			base.FormClosing += Form2_Closing;
			treeview1 = new TreeView();
			status = "";
			loaded = 0;
			team = 0;
			InitializeComponent();
		}

		[DllImport("User32.dll")]
		public static extern int RegisterHotKey(IntPtr hwnd, int id, int fsModifiers, int vk);

		[DllImport("User32.dll")]
		public static extern int UnregisterHotKey(IntPtr hwnd, int id);

		protected override void WndProc(ref Message m)
		{
			if (m.Msg == 786)
			{
				string left = m.WParam.ToString();
				if (Operators.CompareString(left, Conversions.ToString(1989), false) == 0)
				{
					Show();
				}
			}
			base.WndProc(ref m);
		}

		public void Form2_Load(object sender, EventArgs e)
		{
			RegisterHotKey(base.Handle, 1989, 1, 90);
			object obj = MyProject.Application.Info.DirectoryPath + "\\Setting\\";
			object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("Scripting.FileSystemObject"));
			object[] obj2 = new object[1] { obj };
			object[] array = obj2;
			bool[] obj3 = new bool[1] { true };
			bool[] array2 = obj3;
			object operand = NewLateBinding.LateGet(objectValue, null, "FolderExists", obj2, null, null, obj3);
			if (array2[0])
			{
				obj = RuntimeHelpers.GetObjectValue(array[0]);
			}
			if (Conversions.ToBoolean(Operators.NotObject(operand)))
			{
				object[] obj4 = new object[1] { obj };
				array = obj4;
				bool[] obj5 = new bool[1] { true };
				array2 = obj5;
				NewLateBinding.LateCall(objectValue, null, "CreateFolder", obj4, null, null, obj5, true);
				if (array2[0])
				{
					obj = RuntimeHelpers.GetObjectValue(array[0]);
				}
			}
			bool missingData = false;
			if (!File.Exists("data\\priest.ini"))
			{
				Interaction.MsgBox("Tập tin [priest.ini] không tồn tại, ứng dụng tự thoát!");
				missingData = true;
				Close();
			}
			if (!File.Exists("data\\priest_x.ini"))
			{
				Interaction.MsgBox("Tập tin [priest_x.ini] không tồn tại, ứng dụng tự thoát!");
				missingData = true;
				Close();
			}
			if (!File.Exists("data\\skill.dat"))
			{
				Interaction.MsgBox("Tập tin [data\\skill.dat] không tồn tại, ứng dụng tự thoát!");
				missingData = true;
				Close();
			}
			if (!File.Exists("data\\map.ini"))
			{
				Interaction.MsgBox("Tập tin [map.ini] không tồn tại, ứng dụng tự thoát!");
				missingData = true;
				Close();
			}
			if (!File.Exists("data\\door.ini"))
			{
				Interaction.MsgBox("Tập tin [door.ini] không tồn tại, ứng dụng tự thoát!");
				missingData = true;
				Close();
			}
			if (!File.Exists("data\\mapname.ini"))
			{
				Interaction.MsgBox("Tập tin [mapname.ini] không tồn tại, ứng dụng tự thoát!");
				missingData = true;
				Close();
			}
			if (!File.Exists("data\\npc.dat"))
			{
				Interaction.MsgBox("Tập tin [data\\npc.dat] không tồn tại, ứng dụng tự thoát!");
				missingData = true;
				Close();
			}
			if (!File.Exists("data\\item.dat"))
			{
				Interaction.MsgBox("Tập tin [item.dat] không tồn tại, ứng dụng tự thoát!");
				missingData = true;
				Close();
			}
			if (missingData)
			{
				return;
			}
			Thread thread = new Thread(LoadDataNpcs);
			thread.IsBackground = true;
			thread.Start();
			ToolStripComboBox1.SelectedIndex = API.Country;
			int country = API.Country;
			if (country == 1)
			{
				API.Language_Path = MyProject.Application.Info.DirectoryPath + "\\Country\\THAI.ini";
				if (File.Exists(API.Language_Path))
				{
					ToolStripMenuItem_system.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Main", "ToolStripMenuItem_system", "");
					ToolStripMenuItem_hide.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Main", "ToolStripMenuItem_hide", "");
					ToolStripMenuItem_exit.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Main", "ToolStripMenuItem_exit", "");
					ToolStripMenuItem_newtab.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Main", "ToolStripMenuItem_newtab", "");
					ToolStripMenuItem_info.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Main", "ToolStripMenuItem_info", "");
					ToolStripMenuItem_home.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Main", "ToolStripMenuItem_home", "");
					ToolStripMenuItem_about.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Main", "ToolStripMenuItem_about", "");
					NewtabConfigToolStripMenuItem.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Main", "NewtabConfigToolStripMenuItem", "");
					Save1FileToolStripMenuItem.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Main", "Save1FileToolStripMenuItem", "");
					Load1FileToolStripMenuItem.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Main", "Load1FileToolStripMenuItem", "");
					ToolStripMenuItem2.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Main", "ToolStripMenuItem2", "");
					ToolStripMenuItem_thuoctinh.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Main", "ToolStripMenuItem_thuoctinh", "");
					ToolStripMenuItem_lv.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Main", "ToolStripMenuItem_lv", "");
					ToolStripMenuItem_Mapname.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Main", "ToolStripMenuItem_Mapname", "");
					ToolStripMenuItem_Status.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Main", "ToolStripMenuItem_Status", "");
					ToolStripMenuItem_BattleCount.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Main", "ToolStripMenuItem_BattleCount", "");
					ToolStripMenuItem_PetName.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Main", "ToolStripMenuItem_PetName", "");
					ToolStripMenuItem_PetLv.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Main", "ToolStripMenuItem_PetLv", "");
					ColumnHeader_Name.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Main", "ColumnHeader_Name", "");
					ColumnHeader_MapName.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Main", "ColumnHeader_MapName", "");
					ColumnHeader_Status.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Main", "ColumnHeader_Status", "");
					ColumnHeader_Battles.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Main", "ColumnHeader_Battles", "");
					ColumnHeader_petName.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Main", "ColumnHeader_petName", "");
					ColumnHeader_PetLv.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Main", "ColumnHeader_PetLv", "");
				}
			}
		}


		public void Form2_Closing(object sender, FormClosingEventArgs e)
		{
			UnregisterHotKey(base.Handle, 1989);
			MsgBoxResult msgBoxResult = Interaction.MsgBox("Bạn có chắc chắn không?", MsgBoxStyle.YesNo, "Chú ý");
			if (msgBoxResult == MsgBoxResult.No)
			{
				e.Cancel = true;
			}
		}


		public void LoadDataNpcs()
		{
			GetPicture.GetLinks();
			GetPicture.GetPicture_item();
			status = "DataItems_Name loading...";
			GetDataName.LoadDataItems_Name();
			status = "DataNpcs_Name loading...";
			GetDataName.LoadDataNpcs_Name();
			status = "DataSkills_Name loading...";
			GetDataName.LoadDataSkills_Name();
			status = "DataTexps loading...";
			Texps.LoadDataTexps();
			status = "DataNpcs loading...";
			Npcs.LoadDataNpcs();
			status = "DataTalks loading...";
			talk.LoadDataTalks();
			NpcOnMap.LoadDataNpcOnMap();
			status = "DataItems loading...";
			Items.LoadDataItems();
			status = "DataGround loading...";
			Ground.LoadDataGrounds();
			status = "DataAstrolabe loading...";
			Astrolabes.LoadDataAstrolabes();
			Thread thread = new Thread(Getskill);
			thread.IsBackground = true;
			thread.Start();
		}

		public void Getskill()
		{
			status = "load skill.dat";
			Skills.LoadSkills();
			Thread thread = new Thread(Getdoor);
			thread.IsBackground = true;
			thread.Start();
		}

		public void Getdoor()
		{
			Doors.LoadDoors();
			Thread thread = new Thread(Getmap);
			thread.IsBackground = true;
			thread.Start();
		}

		public void Getmap()
		{
			status = "load map.ini";
			if (File.Exists("data\\map.ini"))
			{
				MapIni = MyProject.Computer.FileSystem.ReadAllText("data\\map.ini").Split('\r', '\r');
			}
			Thread thread = new Thread(Getmapname);
			thread.IsBackground = true;
			thread.Start();
		}

		public void Getmapname()
		{
			status = "load mapname.ini";
			MapNames.LoadMapNames();
			Thread thread = new Thread(UpdateMap);
			thread.IsBackground = true;
			thread.Start();
		}

		public void UpdateMap()
		{
			treeview1.Nodes.Clear();
			List<TreeNode> list = new List<TreeNode>();
			int num = 0;
			string[] mapIni = MapIni;
			foreach (string text in mapIni)
			{
				num = checked(num + 1);
				status = "[data\\map.ini] " + Strings.FormatPercent((double)num / (double)MapIni.Length).ToString();
				string text2 = text.Replace("\r\n", "").Replace("\r", "").Replace("\n", "");
				if (text2.Length == 0)
				{
					break;
				}
				string[] array = text2.Split('\t');
				string text3 = Conversions.ToString(Conversions.ToInteger(array[0]));
				string text4 = Conversions.ToString(Conversions.ToInteger(array[1]));
				TreeNode treeNode = new TreeNode();
				treeNode.Name = text3;
				treeNode.Text = text3;
				TreeNode treeNode2 = new TreeNode();
				treeNode2.Name = text4;
				treeNode2.Text = text4 + " - " + Getmapname(Conversions.ToInteger(text4));
				if (treeview1.Nodes.Count == 0)
				{
					treeview1.Nodes.Add(treeNode);
					list.Add(treeNode);
					treeview1.Update();
				}
				foreach (TreeNode item in list)
				{
					if (Operators.CompareString(item.Name, text3, false) == 0)
					{
						list.Add(treeNode2);
						item.Nodes.Add(treeNode2);
						treeview1.Update();
						break;
					}
				}
			}
			loaded = 1;
		}

		public string Getmapname(int id)
		{
			string result = "id";
			if (MapNames.Data_MapNames.ContainsKey(id))
			{
				result = MapNames.Data_MapNames[id];
			}
			return result;
		}


		private void ToolStripMenuItem_exit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void ToolStripMenuItem_about_Click(object sender, EventArgs e)
		{
			MyProject.Forms.About.ShowDialog();
		}

		private void ToolStripMenuItem_hide_Click(object sender, EventArgs e)
		{
			Interaction.MsgBox("Alt+z để hiện");
			Hide();
		}

		private void Timer1_Tick(object sender, EventArgs e)
		{
			try
			{
				if (status.Length > 0)
				{
					Text = "Simple Bot - TS online - " + status;
					status = "";
				}
				if (loaded == 1)
				{
					Text = "Simple Bot - TS online - " + base.ProductVersion + " - http://tsonline.xyz/";
					Timer1.Enabled = false;
					MenuStrip1.Enabled = true;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}


		private void Timer2_Tick(object sender, EventArgs e)
		{
			try
			{
				if (ToolStripMenuItem_MainStatus.Checked)
				{
					foreach (ListViewItem item in ListView1.Items)
					{
						try
						{
							_ClientBot clientBot = (_ClientBot)item.Tag;
							switch (clientBot.logined)
							{
							case 0:
								if (item.SubItems[1].BackColor != SystemColors.Window)
								{
									item.SubItems[1].BackColor = SystemColors.Window;
								}
								if (Operators.CompareString(item.SubItems[1].Text, "", false) != 0)
								{
									item.SubItems[1].Text = "";
								}
								if (Operators.CompareString(item.SubItems[6].Text, "OFF", false) != 0)
								{
									item.SubItems[6].Text = "OFF";
								}
								if ((Operators.CompareString(item.SubItems[7].Text, clientBot.Status, false) != 0) & ToolStripMenuItem_Status.Checked)
								{
									item.SubItems[7].Text = clientBot.Status;
								}
								break;
							case 1:
							{
								if ((clientBot.Data_Player._LeaderId == clientBot.Data_Player._Id) & (clientBot.Data_Player._Id > 0))
								{
									if (item.BackColor != Color.LightBlue)
									{
										item.BackColor = Color.LightBlue;
									}
								}
								else if (item.BackColor != SystemColors.Window)
								{
									item.BackColor = SystemColors.Window;
								}
								if (Operators.CompareString(item.SubItems[0].Text, clientBot.idlogin.ToString(), false) != 0)
								{
									item.SubItems[0].Text = clientBot.idlogin.ToString();
								}
								if (Operators.CompareString(item.SubItems[1].Text, clientBot.Data_Player._Name, false) != 0)
								{
									item.SubItems[1].Text = clientBot.Data_Player._Name;
								}
								int reborn = clientBot.Data_Player._Reborn;
								if (reborn == 3)
								{
									if ((Operators.CompareString(item.SubItems[2].Text, "200 + " + Conversions.ToString(clientBot.Data_Player._Lv2), false) != 0) & ToolStripMenuItem_lv.Checked)
									{
										item.SubItems[2].Text = "200 + " + Conversions.ToString(clientBot.Data_Player._Lv2);
									}
								}
								else if ((Conversions.ToDouble(item.SubItems[2].Text) != (double)clientBot.Data_Player._Lv) & ToolStripMenuItem_lv.Checked)
								{
									item.SubItems[2].Text = Conversions.ToString(clientBot.Data_Player._Lv);
								}
								if ((Conversions.ToDouble(item.SubItems[3].Text) != (double)clientBot.Data_Player._MapId) & ToolStripMenuItem_Mapid.Checked)
								{
									item.SubItems[3].Text = Conversions.ToString(clientBot.Data_Player._MapId);
								}
								if ((Operators.CompareString(item.SubItems[4].Text, clientBot.Data_Player._MapName, false) != 0) & ToolStripMenuItem_Mapname.Checked)
								{
									item.SubItems[4].Text = clientBot.Data_Player._MapName;
								}
								if ((Operators.CompareString(item.SubItems[5].Text, clientBot._Mini_Status, false) != 0) & ToolStripMenuItem_Mini.Checked)
								{
									item.SubItems[5].Text = clientBot._Mini_Status;
								}
								if (Operators.CompareString(item.SubItems[6].Text, clientBot.Online, false) != 0)
								{
									if (ToolStripMenuItem_thuoctinh.Checked)
									{
										item.SubItems[1].BackColor = API.GetColor(clientBot.Data_Player._ThuocTinh);
									}
									item.SubItems[6].Text = clientBot.Online;
								}
								if ((Operators.CompareString(item.SubItems[7].Text, clientBot.Status, false) != 0) & ToolStripMenuItem_Status.Checked)
								{
									item.SubItems[7].Text = clientBot.Status;
								}
								if ((Conversions.ToDouble(item.SubItems[8].Text) != (double)clientBot.Data_Player._ExpMin) & ToolStripMenuItem_Expmin.Checked)
								{
									item.SubItems[8].Text = Conversions.ToString(clientBot.Data_Player._ExpMin);
								}
								if ((Conversions.ToDouble(item.SubItems[9].Text) != (double)clientBot.battlecount) & ToolStripMenuItem_BattleCount.Checked)
								{
									item.SubItems[9].Text = Conversions.ToString(clientBot.battlecount);
								}
								if ((Operators.CompareString(item.SubItems[10].Text, clientBot.Data_PetInfo._Name, false) != 0) & ToolStripMenuItem_PetName.Checked)
								{
									item.SubItems[10].Text = clientBot.Data_PetInfo._Name;
								}
								if ((Conversions.ToDouble(item.SubItems[11].Text) != (double)clientBot.Data_PetInfo._Lv) & ToolStripMenuItem_PetLv.Checked)
								{
									item.SubItems[11].Text = Conversions.ToString(clientBot.Data_PetInfo._Lv);
								}
								break;
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
				}
				foreach (ListViewItem item2 in ListView1.Items)
				{
					try
					{
						_ClientBot clientBot2 = (_ClientBot)item2.Tag;
						if (clientBot2._Proxy && clientBot2._Proxy_Disconnect)
						{
							ListView1.Items.Remove(item2);
							break;
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
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				ProjectData.ClearProjectError();
			}
		}

	}
}
