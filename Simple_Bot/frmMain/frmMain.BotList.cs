using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Simple_Bot
{
	public partial class frmMain : Form
	{
		private void ToolStripMenuItem_Login_Click(object sender, EventArgs e)
		{
			try
			{
				if (ListView1.Items.Count <= 0)
				{
					return;
				}
				_ClientBot clientBot = (_ClientBot)ListView1.SelectedItems[0].Tag;
				if (clientBot != null)
				{
					if (clientBot.Disconnected == 1)
					{
						clientBot._Connect();
					}
					else
					{
						clientBot._Disconnect();
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


		private void ContextMenuStrip_Bot_Opening(object sender, CancelEventArgs e)
		{
			try
			{
				if (ListView1.Items.Count <= 0)
				{
					return;
				}
				_ClientBot clientBot = (_ClientBot)ListView1.SelectedItems[0].Tag;
				if (clientBot == null)
				{
					return;
				}
				if (clientBot._Proxy)
				{
					ToolStripComboBox_bot.Visible = false;
					ToolStripMenuItem_Bot.Visible = false;
				}
				else if (clientBot.bott == 0)
				{
					ToolStripMenuItem_Bot.Text = "Bắt đầu Bot";
					if ((clientBot.Data_Player._LeaderId == clientBot.Data_Player._Id) | (clientBot.Data_Player._LeaderId == 0))
					{
						ToolStripComboBox_bot.Enabled = true;
						ToolStripMenuItem_Bot.Enabled = true;
						try
						{
							string[] files = Directory.GetFiles(MyProject.Application.Info.DirectoryPath + "\\QuestBot", "*.ini");
							ToolStripComboBox_bot.Items.Clear();
							string[] array = files;
							foreach (string text in array)
							{
								ToolStripComboBox_bot.Items.Add(checked(text.Substring(text.LastIndexOf("\\") + 1, text.IndexOf(".") - text.LastIndexOf("\\") - 1)));
							}
							if (ToolStripComboBox_bot.Items.Count > 0)
							{
								ToolStripComboBox_bot.SelectedIndex = 0;
							}
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							ProjectData.ClearProjectError();
						}
					}
					else
					{
						ToolStripComboBox_bot.Enabled = false;
						ToolStripMenuItem_Bot.Enabled = false;
					}
				}
				else if (clientBot.bott == 1)
				{
					ToolStripMenuItem_Bot.Text = "Dừng Bot";
					ToolStripComboBox_bot.Enabled = false;
				}
				else if (clientBot.bott == 2)
				{
					ToolStripMenuItem_Bot.Text = "Bắt đầu Bot";
					ToolStripComboBox_bot.Enabled = false;
				}
				if (clientBot.Disconnected == 0)
				{
					ToolStripMenuItem_Login.Text = "Thoát";
				}
				else
				{
					ToolStripMenuItem_Login.Text = "Đăng nhập";
				}
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ProjectData.ClearProjectError();
			}
		}


		private void ToolStripComboBox_bot_SelectedIndexChanged(object sender, EventArgs e)
		{
			string text = MyProject.Application.Info.DirectoryPath + "\\QuestBot\\" + ToolStripComboBox_bot.Text + ".ini";
			if (!File.Exists(text))
			{
				return;
			}
			checked
			{
				try
				{
					if (ListView1.Items.Count <= 0)
					{
						return;
					}
					_ClientBot clientBot = (_ClientBot)ListView1.SelectedItems[0].Tag;
					if (clientBot == null)
					{
						return;
					}
					clientBot.packetbot = "";
					clientBot.idmapbot = 0;
					string[] array = MyProject.Computer.FileSystem.ReadAllText(text).Split('\r');
					for (int i = 0; i < array.Length; i++)
					{
						string text2 = array[i];
						text2 = text2.Replace("\n", "");
						if (text2.StartsWith("warpid "))
						{
							int num = Conversions.ToInteger(text2.Substring(7));
							clientBot.packetbot = clientBot.packetbot + "F44404001408" + num.ToString("X2") + "00";
						}
						else if (text2.StartsWith("[") & text2.EndsWith("]"))
						{
							clientBot.idmapbot = Conversions.ToInteger(text2.Replace("]", "").Replace("[", ""));
						}
						else if (text2.StartsWith("walk "))
						{
							string text3 = text2.Substring(5);
							int num2 = Conversions.ToInteger(text3.Substring(0, text3.IndexOf(",")));
							int num3 = Conversions.ToInteger(text3.Substring(text3.IndexOf(",") + 1));
							string text4 = API.bytestohexstring(new byte[2]
							{
								API.hexstringtobyte(num2.ToString("X4"))[1],
								API.hexstringtobyte(num2.ToString("X4"))[0]
							});
							string text5 = API.bytestohexstring(new byte[2]
							{
								API.hexstringtobyte(num3.ToString("X4"))[1],
								API.hexstringtobyte(num3.ToString("X4"))[0]
							});
							clientBot.packetbot = clientBot.packetbot + "F4440900060105" + text4 + text5 + "47EB";
						}
						else if (text2.StartsWith("click "))
						{
							int num4 = Conversions.ToInteger(text2.Substring(6));
							string text6 = API.Int32ToHex2(num4);
							clientBot.packetbot = clientBot.packetbot + "F44404001401" + text6;
						}
						else if (text2.StartsWith("menu "))
						{
							int num5 = Conversions.ToInteger(text2.Substring(5)) + 29;
							clientBot.packetbot = clientBot.packetbot + "F44403001409" + num5.ToString("X2");
						}
						else if (text2.StartsWith("send "))
						{
							int num6 = Conversions.ToInteger(text2.Substring(5));
							string text7 = "";
							int num7 = num6;
							for (int j = 1; j <= num7; j++)
							{
								text7 += "F44402001406";
							}
							clientBot.packetbot += text7;
						}
						else if (text2.StartsWith("battle"))
						{
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

		private void ListView1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (e.Button != MouseButtons.Left || ListView1.Items.Count <= 0)
			{
				return;
			}
			try
			{
				_ClientBot clientBot = (_ClientBot)ListView1.SelectedItems[0].Tag;
				if (clientBot != null && clientBot.Setting_show == 0)
				{
					frmClient frmClient2 = new frmClient(clientBot);
					ListView1.SelectedItems[0].SubItems[0].Tag = frmClient2;
					frmClient2.Show();
					clientBot.Setting_show = 1;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}


		private void ToolStripMenuItem_battle_Click(object sender, EventArgs e)
		{
			try
			{
				if (ListView1.Items.Count > 0)
				{
					_ClientBot _b = (_ClientBot)ListView1.SelectedItems[0].Tag;
					if (_b != null && _b.battle_show == 0)
					{
						_b.battle_show = 1;
						BattleInfo1 battleInfo = new BattleInfo1(ref _b);
						ListView1.SelectedItems[0].SubItems[1].Tag = battleInfo;
						battleInfo.Show();
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


		private void ToolStripMenuItem_Bot_Click(object sender, EventArgs e)
		{
			try
			{
				if (ListView1.Items.Count <= 0)
				{
					return;
				}
				_ClientBot clientBot = (_ClientBot)ListView1.SelectedItems[0].Tag;
				if (clientBot == null)
				{
					return;
				}
				if (clientBot.bott == 0)
				{
					clientBot.bott = 1;
					if (clientBot.logined == 1)
					{
						clientBot._StartBot();
					}
				}
				else if (clientBot.bott == 1)
				{
					clientBot.bott = 2;
					if (clientBot.Battle == 0)
					{
						clientBot.ClickNPCId(99);
					}
				}
				else if (clientBot.bott == 2)
				{
					clientBot.bott = 1;
					if (clientBot.Battle == 0)
					{
						clientBot.ClickNPCId(99);
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


		private void ToolStripMenuItem_Delete_Click(object sender, EventArgs e)
		{
			try
			{
				if (ListView1.Items.Count <= 0)
				{
					return;
				}
				_ClientBot clientBot = (_ClientBot)ListView1.SelectedItems[0].Tag;
				if (clientBot != null)
				{
					MsgBoxResult msgBoxResult = Interaction.MsgBox("Bạn có chắc chắn muốn tắt bot của Id [" + Conversions.ToString(clientBot.idlogin) + "] không?", MsgBoxStyle.YesNo, "Cảnh báo!");
					if (msgBoxResult == MsgBoxResult.No)
					{
						return;
					}
					clientBot.Deleted = 1;
					clientBot.C_CheckBox_Reconnect = false;
					clientBot._Disconnect();
				}
				ListView1.Items.Remove(ListView1.SelectedItems[0]);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

		private void ToolStripMenuItem_lv_CheckedChanged(object sender, EventArgs e)
		{
			object left = NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null);
			if (Operators.ConditionalCompareObjectEqual(left, true, false))
			{
				if (ListView1.Columns.Count > 2)
				{
					ListView1.Columns[2].Width = 36;
				}
			}
			else if (Operators.ConditionalCompareObjectEqual(left, false, false) && ListView1.Columns.Count > 2)
			{
				ListView1.Columns[2].Width = 0;
			}
		}

		private void ToolStripMenuItem_Mapid_CheckedChanged(object sender, EventArgs e)
		{
			object left = NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null);
			if (Operators.ConditionalCompareObjectEqual(left, true, false))
			{
				if (ListView1.Columns.Count > 3)
				{
					ListView1.Columns[3].Width = 60;
				}
			}
			else if (Operators.ConditionalCompareObjectEqual(left, false, false) && ListView1.Columns.Count > 3)
			{
				ListView1.Columns[3].Width = 0;
			}
		}

		private void ToolStripMenuItem_Mapname_CheckedChanged(object sender, EventArgs e)
		{
			object left = NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null);
			if (Operators.ConditionalCompareObjectEqual(left, true, false))
			{
				if (ListView1.Columns.Count > 4)
				{
					ListView1.Columns[4].Width = 140;
				}
			}
			else if (Operators.ConditionalCompareObjectEqual(left, false, false) && ListView1.Columns.Count > 4)
			{
				ListView1.Columns[4].Width = 0;
			}
		}

		private void ToolStripMenuItem_Mini_CheckedChanged(object sender, EventArgs e)
		{
			object left = NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null);
			if (Operators.ConditionalCompareObjectEqual(left, true, false))
			{
				if (ListView1.Columns.Count > 5)
				{
					ListView1.Columns[5].Width = 60;
				}
			}
			else if (Operators.ConditionalCompareObjectEqual(left, false, false) && ListView1.Columns.Count > 5)
			{
				ListView1.Columns[5].Width = 0;
			}
		}

		private void ToolStripMenuItem_Status_CheckedChanged(object sender, EventArgs e)
		{
			object left = NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null);
			if (Operators.ConditionalCompareObjectEqual(left, true, false))
			{
				if (ListView1.Columns.Count > 6)
				{
					ListView1.Columns[7].Width = 163;
				}
			}
			else if (Operators.ConditionalCompareObjectEqual(left, false, false) && ListView1.Columns.Count > 6)
			{
				ListView1.Columns[7].Width = 0;
			}
		}

		private void ToolStripMenuItem_Expmin_CheckedChanged(object sender, EventArgs e)
		{
			object left = NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null);
			if (Operators.ConditionalCompareObjectEqual(left, true, false))
			{
				if (ListView1.Columns.Count > 7)
				{
					ListView1.Columns[8].Width = 60;
				}
			}
			else if (Operators.ConditionalCompareObjectEqual(left, false, false) && ListView1.Columns.Count > 7)
			{
				ListView1.Columns[8].Width = 0;
			}
		}

		private void ToolStripMenuItem_BattleCount_CheckedChanged(object sender, EventArgs e)
		{
			object left = NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null);
			if (Operators.ConditionalCompareObjectEqual(left, true, false))
			{
				if (ListView1.Columns.Count > 8)
				{
					ListView1.Columns[9].Width = 60;
				}
			}
			else if (Operators.ConditionalCompareObjectEqual(left, false, false) && ListView1.Columns.Count > 8)
			{
				ListView1.Columns[9].Width = 0;
			}
		}

		private void CheckBox_Proxy_CheckedChanged(object sender, EventArgs e)
		{
			switch (CheckBox_Proxy.Checked)
			{
			case true:
				try
				{
					ComboBox_Server.Enabled = false;
					IPAddress localaddr = IPAddress.Parse(_proxyBindAddress);
					try
					{
						server1 = new TcpListener(localaddr, 6414);
						server1.Start(65535);
						API.Proxy = true;
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception ex4 = ex3;
						Interaction.MsgBox("Không thể tạo Proxy, có thể phần mềm khác đã tạo, vui lòng kiểm tra!!!");
						CheckBox_Proxy.Checked = false;
						ProjectData.ClearProjectError();
						break;
					}
					Interaction.MsgBox("Tạo Proxy thành công!!!");
					Thread thread = new Thread(GetConnect);
					thread.IsBackground = true;
					thread.Start();
					break;
				}
				catch (Exception ex5)
				{
					ProjectData.SetProjectError(ex5);
					Exception ex6 = ex5;
					Interaction.MsgBox("Không thể tạo Proxy, có thể phần mềm khác đã tạo, vui lòng kiểm tra!!!");
					ProjectData.ClearProjectError();
					break;
				}
			case false:
				try
				{
					ComboBox_Server.Enabled = true;
					API.Proxy = false;
					server1.Stop();
					Interaction.MsgBox("Dừng Proxy thành công!!!");
					break;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
					break;
				}
			}
		}


		public void Connection(TcpClient _s)
		{
			_ClientBot clientBot = new _ClientBot(_s);
			clientBot._Proxy = true;
			clientBot.ComboBox_Port = 0;
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

		public void GetConnect()
		{
			Delegate method = new UpdateMainGridDelegate(Connection);
			while (true)
			{
				try
				{
					TcpClient tcpClient = server1.AcceptTcpClient();
					Invoke(method, tcpClient);
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
