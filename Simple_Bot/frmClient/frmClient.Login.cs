using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Simple_Bot
{
	public partial class frmClient : Form
	{
		private void btnLogin_Click(object sender, EventArgs e)
		{
			if (_bot == null)
			{
				return;
			}
			if (Operators.CompareString(btnLogin.Text, "Thoát", false) == 0)
			{
				Disconnect();
				if (CheckBox_Reconnect.Checked)
				{
					Connect();
				}
			}
			else if (Operators.CompareString(btnLogin.Text, "Đăng nhập", false) == 0)
			{
				Connect();
			}
		}


		private void TextBox_PasswordOrClickMOD_TextChanged(object sender, EventArgs e)
		{
			if (_bot != null)
			{
				object left = NewLateBinding.LateGet(sender, null, "Name", new object[0], null, null, null);
				if (Operators.ConditionalCompareObjectEqual(left, TBPassword.Name, false))
				{
					_bot.passlogin = TBPassword.Text;
				}
				else if (Operators.ConditionalCompareObjectEqual(left, TextBox_ClickMOD.Name, false))
				{
					_bot.TextBox_ClickMOD = TextBox_ClickMOD.Text;
				}
			}
		}


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
							_Botting.ComboBox_Server = array2[1];
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

	}
}
