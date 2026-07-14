using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Simple_Bot
{
	public partial class frmClient : Form
	{
		private void ComboBox_botname_DropDown_RefreshList(object sender, EventArgs e)
		{
			try
			{
				string[] files = Directory.GetFiles(MyProject.Application.Info.DirectoryPath + "\\QuestBot", "*.ini");
				ComboBox_botname.Items.Clear();
				string[] array = files;
				foreach (string text in array)
				{
					ComboBox_botname.Items.Add(text.Substring(checked(text.LastIndexOf("\\") + 1)).Replace(".ini", ""));
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

		private void ComboBox_botname_SelectedIndexChanged_LoadScript(object sender, EventArgs e)
		{
			string text = "QuestBot\\" + ComboBox_botname.Text + ".ini";
			if (!File.Exists(text) || _bot == null)
			{
				return;
			}
			_bot.packetbot = "";
			_bot.idmapbot = 0;
			string[] array = MyProject.Computer.FileSystem.ReadAllText(text).Split('\r');
			checked
			{
				for (int i = 0; i < array.Length; i++)
				{
					string text2 = array[i];
					text2 = text2.Replace("\n", "");
					if (text2.StartsWith("warpid "))
					{
						int num = Conversions.ToInteger(text2.Substring(7));
						_bot.packetbot = _bot.packetbot + "F44404001408" + num.ToString("X2") + "00";
					}
					else if (text2.StartsWith("[") & text2.EndsWith("]"))
					{
						_bot.idmapbot = Conversions.ToInteger(text2.Replace("]", "").Replace("[", ""));
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
						_bot.packetbot = _bot.packetbot + "F4440900060105" + text4 + text5 + "47EB";
					}
					else if (text2.StartsWith("click "))
					{
						int num4 = Conversions.ToInteger(text2.Substring(6));
						string text6 = API.Int32ToHex2(num4);
						_bot.packetbot = _bot.packetbot + "F44404001401" + text6;
					}
					else if (text2.StartsWith("menu "))
					{
						int num5 = Conversions.ToInteger(text2.Substring(5)) + 29;
						_bot.packetbot = _bot.packetbot + "F44403001409" + num5.ToString("X2");
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
						_bot.packetbot += text7;
					}
					else if (text2.StartsWith("battle"))
					{
						break;
					}
				}
				Button_bot.Enabled = true;
			}
		}

	}
}
