using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Simple_Bot
{
	public partial class frmMain : Form
	{
		private void OpenFileDialog_newtabconfig_FileOk(object sender, CancelEventArgs e)
		{
			string[] fileNames = OpenFileDialog_newtabconfig.FileNames;
			LoadConfigClosure closure = default(LoadConfigClosure);
			foreach (string text in fileNames)
			{
				if (File.Exists(text) && text.EndsWith(".Ini"))
				{
					_ClientBot clientBot = new _ClientBot();
					closure = new LoadConfigClosure(closure);
					closure.Bot = clientBot;
					Thread thread = new Thread(closure.Run);
					thread.IsBackground = true;
					thread.Start(text);
					ListViewItem listViewItem = ListView1.Items.Add(clientBot.idlogin.ToString());
					listViewItem.UseItemStyleForSubItems = false;
					listViewItem.SubItems.Add(clientBot.Data_Player._Name);
					listViewItem.SubItems.Add(Conversions.ToString(clientBot.Data_Player._Lv));
					listViewItem.SubItems.Add(Conversions.ToString(clientBot.Data_Player._MapId));
					listViewItem.SubItems.Add(clientBot.Data_Player._MapName);
					listViewItem.SubItems.Add("");
					listViewItem.SubItems.Add(clientBot.Online.ToString());
					listViewItem.SubItems.Add(clientBot.Status);
					listViewItem.SubItems.Add(Conversions.ToString(clientBot.Data_Player._ExpMin));
					listViewItem.SubItems.Add(Conversions.ToString(clientBot.battlecount));
					listViewItem.SubItems.Add(clientBot.Data_PetInfo._Name);
					listViewItem.SubItems.Add(Conversions.ToString(clientBot.Data_PetInfo._Lv));
					listViewItem.SubItems.Add(Conversions.ToString(team));
					listViewItem.Tag = clientBot;
				}
			}
		}

		private void TeamToolStripMenuItem_Click(object sender, EventArgs e)
		{
			team = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null).ToString().Substring(4, 2)
				.Replace("T", ""));
			OpenFileDialog_newtabconfig.InitialDirectory = MyProject.Application.Info.DirectoryPath + "\\Setting\\";
			OpenFileDialog_newtabconfig.ShowDialog();
		}

		private void TeamToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			team = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null).ToString().Substring(4, 2)
				.Replace("T", ""));
			_ClientBot clientBot = new _ClientBot();
			_ClientBot a = clientBot;
			Thread thread = new Thread([SpecialName] [DebuggerHidden] (object obj) =>
			{
				a.LoadConfig(Conversions.ToString(obj));
			});
			thread.IsBackground = true;
			thread.Start("Setting\\default.Ini");
			ListViewItem listViewItem = ListView1.Items.Add(clientBot.idlogin.ToString());
			listViewItem.UseItemStyleForSubItems = false;
			listViewItem.SubItems.Add(clientBot.Data_Player._Name);
			listViewItem.SubItems.Add(Conversions.ToString(clientBot.Data_Player._Lv));
			listViewItem.SubItems.Add(Conversions.ToString(clientBot.Data_Player._MapId));
			listViewItem.SubItems.Add(clientBot.Data_Player._MapName);
			listViewItem.SubItems.Add("");
			listViewItem.SubItems.Add(clientBot.Online.ToString());
			listViewItem.SubItems.Add(clientBot.Status);
			listViewItem.SubItems.Add(Conversions.ToString(clientBot.Data_Player._ExpMin));
			listViewItem.SubItems.Add(Conversions.ToString(clientBot.battlecount));
			listViewItem.SubItems.Add(clientBot.Data_PetInfo._Name);
			listViewItem.SubItems.Add(Conversions.ToString(clientBot.Data_PetInfo._Lv));
			listViewItem.SubItems.Add(Conversions.ToString(team));
			listViewItem.Tag = clientBot;
		}

		private void Save1FileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (ListView1.Items.Count > 0)
			{
				SaveFileDialog_1file.InitialDirectory = MyProject.Application.Info.DirectoryPath + "\\Setting\\";
				SaveFileDialog_1file.ShowDialog();
			}
		}

		private void Load1FileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog_Load1File.InitialDirectory = MyProject.Application.Info.DirectoryPath + "\\Setting\\";
			OpenFileDialog_Load1File.ShowDialog();
		}

		private void OpenFileDialog_Load1File_FileOk(object sender, CancelEventArgs e)
		{
			string[] fileNames = OpenFileDialog_Load1File.FileNames;
			Thread thread = new Thread([SpecialName] [DebuggerHidden] (object obj) =>
			{
				add1file((string[])obj);
			});
			thread.IsBackground = true;
			thread.Start(fileNames);
		}

		public void add1file(string[] FileNames)
		{
			Delegate method = new load1FileDelegate(add1file_adding);
			Invoke(method, new object[1] { FileNames });
		}

		public void add1file_adding(string[] FileNames)
		{
			LoadConfigThreadClosure closure = default(LoadConfigThreadClosure);
			foreach (string text in FileNames)
			{
				if (!File.Exists(text) || !text.EndsWith(".1file"))
				{
					continue;
				}
				string[] array = IniFile.ReadStringOrEmpty(text, "ListAccount", "Ids", "").Split(',');
				if (array.Length <= 0)
				{
					continue;
				}
				string[] array2 = array;
				foreach (string text2 in array2)
				{
					if (text2.Length > 0)
					{
						_ClientBot clientBot = new _ClientBot();
						if (Operators.CompareString(IniFile.ReadStringOrEmpty(text, text2.ToString(), "_Team", ""), "", false) != 0)
						{
							API._Type_LoadConfig type_LoadConfig = new API._Type_LoadConfig
							{
								_path = text,
								_name = text2
							};
							closure = new LoadConfigThreadClosure(closure);
							closure.Bot = clientBot;
							Thread thread = new Thread(closure.Run);
							thread.IsBackground = true;
							thread.Start(type_LoadConfig);
							ListViewItem listViewItem = ListView1.Items.Add(clientBot.idlogin.ToString());
							listViewItem.UseItemStyleForSubItems = false;
							listViewItem.SubItems.Add(clientBot.Data_Player._Name);
							listViewItem.SubItems.Add(Conversions.ToString(clientBot.Data_Player._Lv));
							listViewItem.SubItems.Add(Conversions.ToString(clientBot.Data_Player._MapId));
							listViewItem.SubItems.Add(clientBot.Data_Player._MapName);
							listViewItem.SubItems.Add("");
							listViewItem.SubItems.Add(clientBot.Online.ToString());
							listViewItem.SubItems.Add(clientBot.Status);
							listViewItem.SubItems.Add(Conversions.ToString(clientBot.Data_Player._ExpMin));
							listViewItem.SubItems.Add(Conversions.ToString(clientBot.battlecount));
							listViewItem.SubItems.Add(clientBot.Data_PetInfo._Name);
							listViewItem.SubItems.Add(Conversions.ToString(clientBot.Data_PetInfo._Lv));
							listViewItem.SubItems.Add(IniFile.ReadStringOrEmpty(text, text2.ToString(), "_Team", ""));
							listViewItem.Tag = clientBot;
						}
					}
					ListView1.Update();
					Thread.Sleep(100);
				}
			}
		}

		private void SaveFileDialog_1file_FileOk(object sender, CancelEventArgs e)
		{
			string fileName = SaveFileDialog_1file.FileName;
			string text = "";
			foreach (ListViewItem item in ListView1.Items)
			{
				_ClientBot clientBot = (_ClientBot)item.Tag;
				if (!clientBot._Proxy)
				{
					clientBot.SaveConfig(fileName, clientBot.idlogin.ToString());
					text = text + "," + item.SubItems[0].Text;
					IniFile.WriteString(fileName, clientBot.idlogin.ToString(), "_Team", item.SubItems[checked(ListView1.Columns.Count - 1)].Text);
				}
			}
			IniFile.WriteString(fileName, "ListAccount", "Ids", text);
		}


		private void OpenFileDialog_setting_FileOk(object sender, CancelEventArgs e)
		{
			string[] fileNames = OpenFileDialog_setting.FileNames;
			foreach (string text in fileNames)
			{
				if (File.Exists(text))
				{
					string text2 = text.Substring(checked(text.LastIndexOf("\\") + 1));
					text2 = text2.Replace(".lx", "");
					if (!text.EndsWith(".lx"))
					{
					}
				}
			}
		}
	}
}
