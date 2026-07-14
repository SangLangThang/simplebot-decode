using Microsoft.VisualBasic;

namespace Simple_Bot
{
	public partial class _ClientBot
	{
		public void Chat(int kenh, string msg)
		{
			checked
			{
				int num = 2 + msg.Length;
				string text = "";
				int num2 = msg.Length - 1;
				for (int i = 0; i <= num2; i++)
				{
					text += Strings.Asc(msg.Substring(i, 1)).ToString("X2");
				}
				string text2 = "F444" + API.Int32ToHex2(num) + "02" + kenh.ToString("X2") + text;
				SendPacket(API.hexstringtobyte(text2));
			}
		}

		public void ChatPrivate(int id, string msg)
		{
			string text = API.Int32ToHex4(id);
			checked
			{
				int num = 6 + msg.Length;
				string text2 = "";
				int num2 = msg.Length - 1;
				for (int i = 0; i <= num2; i++)
				{
					text2 += Strings.Asc(msg.Substring(i, 1)).ToString("X2");
				}
				string text3 = "F444" + API.Int32ToHex2(num) + "0203" + text + text2;
				SendPacket(API.hexstringtobyte(text3));
			}
		}

	}
}
