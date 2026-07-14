using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Simple_Bot
{
	public partial class frmClient : Form
	{
		private void ComboBox_chat_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar != '\r' || _bot.logined != 1)
			{
				return;
			}
			string text = ComboBox_kenh.Text;
			switch (FnvHash.Compute(text))
			{
			case 2999784422u:
				if (Operators.CompareString(text, "Toàn", false) == 0)
				{
					_bot.Chat(1, ComboBox_chat.Text);
					API.AddColorText_Chat(_bot, _bot.Rtbchat, "[Toàn] " + _bot.Data_Player._Name + ": " + ComboBox_chat.Text, Color.Khaki);
				}
				break;
			case 2950256199u:
				if (Operators.CompareString(text, "Gần", false) == 0)
				{
					_bot.Chat(2, ComboBox_chat.Text);
					API.AddColorText_Chat(_bot, _bot.Rtbchat, "[Gần] " + _bot.Data_Player._Name + ": " + ComboBox_chat.Text, Color.Gold);
				}
				break;
			case 3592419773u:
			{
				if (Operators.CompareString(text, "Thì thầm", false) != 0)
				{
					break;
				}
				int idPlayer = _bot.GetIdPlayer(ComboBox_nameprivate.Text);
				if (idPlayer > 0)
				{
					_bot.ChatPrivate(idPlayer, ComboBox_chat.Text);
					if (!ComboBox_nameprivate.Items.Contains(ComboBox_nameprivate.Text))
					{
						ComboBox_nameprivate.Items.Add(ComboBox_nameprivate.Text);
					}
				}
				else
				{
					API.AddColorText2(_bot, _bot.Rtbsystem, ComboBox_nameprivate.Text + " không có hoặc đã rời mạng!", Color.Orange);
				}
				break;
			}
			case 1674640113u:
				if (Operators.CompareString(text, "GM", false) == 0)
				{
					_bot.Chat(4, ComboBox_chat.Text);
				}
				break;
			case 1183301393u:
				if (Operators.CompareString(text, "Đội", false) == 0)
				{
					_bot.Chat(5, ComboBox_chat.Text);
				}
				break;
			case 3289375914u:
				if (Operators.CompareString(text, "Đoàn", false) == 0)
				{
					_bot.Chat(6, ComboBox_chat.Text);
				}
				break;
			case 3393541234u:
				if (Operators.CompareString(text, "Liên Minh", false) == 0)
				{
					_bot.Chat(7, ComboBox_chat.Text);
				}
				break;
			}
			if (!ComboBox_chat.Items.Contains(ComboBox_chat.Text))
			{
				ComboBox_chat.Items.Add(ComboBox_chat.Text);
			}
			ComboBox_chat.Text = "";
		}

		public void updatesystem()
		{
			if (r_Id_rtbsystem >= _bot._id_rtbsystem)
			{
				return;
			}
			checked
			{
				int num = r_Id_rtbsystem + 1;
				int id_rtbsystem = _bot._id_rtbsystem;
				for (int i = num; i <= id_rtbsystem; i++)
				{
					if (_bot.Rtbsystem.ContainsKey(i))
					{
						_Data._InfoText infoText = _bot.Rtbsystem[i];
						API.AddColorText(rtbsystem, infoText._Text, infoText._Color);
					}
				}
				r_Id_rtbsystem = _bot._id_rtbsystem;
				rtbsystem.SelectionStart = rtbsystem.Text.Length;
				rtbsystem.ScrollToCaret();
			}
		}

		public void updateChat()
		{
			if (r_Id_rtbChat >= _bot._id_rtbChat)
			{
				return;
			}
			checked
			{
				int num = r_Id_rtbChat + 1;
				int id_rtbChat = _bot._id_rtbChat;
				for (int i = num; i <= id_rtbChat; i++)
				{
					if (_bot.Rtbchat.ContainsKey(i))
					{
						_Data._InfoText infoText = _bot.Rtbchat[i];
						API.AddColorText(RtbChat, infoText._Text, infoText._Color);
					}
				}
				r_Id_rtbChat = _bot._id_rtbChat;
			}
		}

		public void updateQuest()
		{
			if (r_Id_rtbQuest >= _bot._id_rtbQuest)
			{
				return;
			}
			checked
			{
				int num = r_Id_rtbQuest + 1;
				int id_rtbQuest = _bot._id_rtbQuest;
				for (int i = num; i <= id_rtbQuest; i++)
				{
					if (_bot.RtbQuest.ContainsKey(i))
					{
						_Data._InfoText infoText = _bot.RtbQuest[i];
						API.AddColorText(RtbQuest, infoText._Text, infoText._Color);
					}
				}
				r_Id_rtbQuest = _bot._id_rtbQuest;
			}
		}

	}
}
