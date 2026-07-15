using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Simple_Bot
{
	public partial class frmMain : Form
	{
		private void ComboBox_Server_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				string text = "server.ini";
				if (File.Exists(text))
				{
					string[] array = MyProject.Computer.FileSystem.ReadAllText(text).Split('\r');
					foreach (string text2 in array)
					{
						string[] array2 = text2.Split('*');
						if (Operators.CompareString(ComboBox_Server.Text, array2[0], false) == 0)
						{
							API.ServerIp = array2[1];
							switch (API.List_Ip_nts.Contains(API.ServerIp))
							{
							case true:
								ComboBox_Style.Enabled = true;
								ComboBox_Style.Visible = true;
								CheckBox_SVip.Enabled = true;
								CheckBox_SVip.Visible = true;
								ComboBox_Horse.Enabled = true;
								ComboBox_Horse.Visible = true;
								Label1.Enabled = true;
								Label1.Visible = true;
								Label2.Enabled = true;
								Label2.Visible = true;
								break;
							case false:
								ComboBox_Style.Enabled = false;
								ComboBox_Style.Visible = false;
								CheckBox_SVip.Enabled = false;
								CheckBox_SVip.Visible = false;
								ComboBox_Horse.Enabled = false;
								ComboBox_Horse.Visible = false;
								Label1.Enabled = false;
								Label1.Visible = false;
								Label2.Enabled = false;
								Label2.Visible = false;
								break;
							}
							break;
						}
					}
				}
				else
				{
					Interaction.MsgBox("File server.ini không tồn tại");
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

		private void ComboBox_Server_DropDown(object sender, EventArgs e)
		{
			try
			{
				string text = "server.ini";
				ComboBox_Server.Items.Clear();
				if (File.Exists(text))
				{
					string[] array = MyProject.Computer.FileSystem.ReadAllText(text).Split('\r');
					foreach (string text2 in array)
					{
						string[] array2 = text2.Split('*');
						ComboBox_Server.Items.Add(array2[0]);
					}
				}
				else
				{
					Interaction.MsgBox("File server.ini không tồn tại");
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

		private void ComboBox_Style_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (ComboBox_Style.Text)
			{
			case "None":
				API.Style = 0;
				break;
			case "Set Cap":
				API.Style = 1;
				break;
			case "Set Thor":
				API.Style = 2;
				break;
			case "Set Iron":
				API.Style = 3;
				break;
			case "Set Thai Duong":
				API.Style = 4;
				break;
			}
			BroadcastStyleToProxyBots(API.Style);
		}

		private void BroadcastStyleToProxyBots(int style)
		{
			foreach (ListViewItem item in ListView1.Items)
			{
				try
				{
					_ClientBot clientBot = (_ClientBot)item.Tag;
					if (!(clientBot._Proxy & (clientBot.logined == 1) & API.List_Ip_nts.Contains(API.ServerIp)))
					{
						continue;
					}
					ArrayList arrayList = new ArrayList();
					switch (style)
					{
					case 0:
						arrayList = API.List_Style0;
						break;
					case 1:
						arrayList = API.List_Style1;
						break;
					case 2:
						arrayList = API.List_Style2;
						break;
					case 3:
						arrayList = API.List_Style3;
						break;
					case 4:
						arrayList = API.List_Style4;
						break;
					}
					int num = Conversions.ToInteger(arrayList[0]);
					int num2 = Conversions.ToInteger(arrayList[1]);
					int num3 = Conversions.ToInteger(arrayList[2]);
					int num4 = Conversions.ToInteger(arrayList[3]);
					int num5 = Conversions.ToInteger(arrayList[4]);
					string text = "";
					if (style == 0)
					{
						text = API.Packet_Maker("17100700");
						text += API.Packet_Maker("17100800");
						text += API.Packet_Maker("17100900");
						text += API.Packet_Maker("17100A00");
						text += API.Packet_Maker("17100B00");
						byte[] packet = API.hexstringtobyte(text);
						clientBot._Local_SendPacket(packet);
					}
					else
					{
						if (num > 0)
						{
							text = text + API.Int32ToHex2(num) + "0000000000000000";
						}
						if (num2 > 0)
						{
							text = text + API.Int32ToHex2(num2) + "0000000000000000";
						}
						if (num3 > 0)
						{
							text = text + API.Int32ToHex2(num3) + "0000000000000000";
						}
						if (num4 > 0)
						{
							text = text + API.Int32ToHex2(num4) + "0000000000000000";
						}
						if (num5 > 0)
						{
							text = text + API.Int32ToHex2(num5) + "0000000000000000";
						}
						byte[] packet2 = API.hexstringtobyte(API.Packet_Maker("170B" + text));
						clientBot._Local_SendPacket(packet2);
					}
					text = "";
					if (num > 0)
					{
						text += API.Int32ToHex2(num);
					}
					if (num2 > 0)
					{
						text += API.Int32ToHex2(num2);
					}
					if (num3 > 0)
					{
						text += API.Int32ToHex2(num3);
					}
					if (num4 > 0)
					{
						text += API.Int32ToHex2(num4);
					}
					if (num5 > 0)
					{
						text += API.Int32ToHex2(num5);
					}
					int textBox_IDmem = clientBot.TextBox_IDmem1;
					int textBox_IDmem2 = clientBot.TextBox_IDmem2;
					int textBox_IDmem3 = clientBot.TextBox_IDmem3;
					int textBox_IDmem4 = clientBot.TextBox_IDmem4;
					byte[] packet3 = API.hexstringtobyte(API.Packet_Maker("0500" + API.Int32ToHex4(textBox_IDmem) + text));
					byte[] packet4 = API.hexstringtobyte(API.Packet_Maker("0500" + API.Int32ToHex4(textBox_IDmem2) + text));
					byte[] packet5 = API.hexstringtobyte(API.Packet_Maker("0500" + API.Int32ToHex4(textBox_IDmem3) + text));
					byte[] packet6 = API.hexstringtobyte(API.Packet_Maker("0500" + API.Int32ToHex4(textBox_IDmem4) + text));
					clientBot._Local_SendPacket(packet3);
					clientBot._Local_SendPacket(packet4);
					clientBot._Local_SendPacket(packet5);
					clientBot._Local_SendPacket(packet6);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
			}
		}

		private void CheckBox_SVip_CheckedChanged(object sender, EventArgs e)
		{
			switch (CheckBox_SVip.Checked)
			{
			case true:
				API.Vip = 4;
				break;
			case false:
				API.Vip = 0;
				break;
			}
			foreach (ListViewItem item in ListView1.Items)
			{
				try
				{
					_ClientBot clientBot = (_ClientBot)item.Tag;
					if ((clientBot._Proxy & (clientBot.logined == 1)) && ((API.Vip >= 0) & API.List_Ip_nts.Contains(API.ServerIp)))
					{
						byte[] packet = API.hexstringtobyte(API.Packet_Maker("08010201" + API.Vip.ToString("X2")));
						clientBot._Local_SendPacket(packet);
						try
						{
							int textBox_IDmem = clientBot.TextBox_IDmem1;
							int textBox_IDmem2 = clientBot.TextBox_IDmem2;
							int textBox_IDmem3 = clientBot.TextBox_IDmem3;
							int textBox_IDmem4 = clientBot.TextBox_IDmem4;
							byte[] packet2 = API.hexstringtobyte(API.Packet_Maker("080D" + API.Int32ToHex4(textBox_IDmem) + API.Vip.ToString("X2")));
							byte[] packet3 = API.hexstringtobyte(API.Packet_Maker("080D" + API.Int32ToHex4(textBox_IDmem2) + API.Vip.ToString("X2")));
							byte[] packet4 = API.hexstringtobyte(API.Packet_Maker("080D" + API.Int32ToHex4(textBox_IDmem3) + API.Vip.ToString("X2")));
							byte[] packet5 = API.hexstringtobyte(API.Packet_Maker("080D" + API.Int32ToHex4(textBox_IDmem4) + API.Vip.ToString("X2")));
							clientBot._Local_SendPacket(packet2);
							clientBot._Local_SendPacket(packet3);
							clientBot._Local_SendPacket(packet4);
							clientBot._Local_SendPacket(packet5);
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							ProjectData.ClearProjectError();
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

		private void ComboBox_Horse_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (ComboBox_Horse.Text.Length > 0)
			{
				string[] array = ComboBox_Horse.Text.Split('\t');
				int iDNgua = Conversions.ToInteger(array[0]);
				API.IDNgua = iDNgua;
			}
			BroadcastMountToProxyBots();
		}

		private void BroadcastMountToProxyBots()
		{
			foreach (ListViewItem item in ListView1.Items)
			{
				try
				{
					_ClientBot clientBot = (_ClientBot)item.Tag;
					if (clientBot._Proxy & (clientBot.logined == 1) & API.List_Ip_nts.Contains(API.ServerIp))
					{
						clientBot.Doi_Ngua();
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

		private void ToolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			string left = ToolStripComboBox1.Text;
			if (Operators.CompareString(left, "VIET", false) != 0)
			{
				if (Operators.CompareString(left, "THAI", false) == 0 && API.Country != 1)
				{
					API.Country = 1;
					Interaction.MsgBox("ร\u0e35สตาร\u0e4cทซอฟต\u0e4cแวร\u0e4cเพ\u0e37\u0e48อเป\u0e34ดใช\u0e49งาน");
				}
			}
			else if (API.Country != 0)
			{
				API.Country = 0;
				Interaction.MsgBox("Khởi động lại phần mềm để kích hoạt");
			}
		}

		private void ToolStripMenuItem_home_Click(object sender, EventArgs e)
		{
			OpenUrl("http://tsonline.xyz");
		}

		private void OpenUrl(string url, string browserPath = "default")
		{
			try
			{
				if (Operators.CompareString(browserPath, "default", false) != 0)
				{
					try
					{
						Process.Start(browserPath, url);
						return;
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						Process.Start(url);
						ProjectData.ClearProjectError();
						return;
					}
				}
				Process.Start(url);
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ProjectData.ClearProjectError();
			}
		}
	}
}
