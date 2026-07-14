using Microsoft.VisualBasic;

namespace Simple_Bot
{
	public partial class _ClientBot
	{
		public void CreateChar(string name, int sex, int tt, int hair, int @int, int atk, int def, int hp, int sp, int agi, string mk, string am)
		{
			string text = "";
			checked
			{
				int num = name.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					text += Strings.Asc(name.Substring(i, 1)).ToString("X2");
				}
				string text2 = "F444" + API.bytestohexstring(new byte[2]
				{
					API.hexstringtobyte((name.Length + 2).ToString("X4"))[1],
					API.hexstringtobyte((name.Length + 2).ToString("X4"))[0]
				}) + "0902" + text;
				string text3 = "";
				int num2 = mk.Length - 1;
				for (int j = 0; j <= num2; j++)
				{
					text3 += Strings.Asc(mk.Substring(j, 1)).ToString("X2");
				}
				string text4 = "";
				int num3 = am.Length - 1;
				for (int k = 0; k <= num3; k++)
				{
					text4 += Strings.Asc(am.Substring(k, 1)).ToString("X2");
				}
				string text5 = "";
				switch (sex)
				{
				case 1:
					text5 = "1CAF";
					break;
				case 2:
					text5 = "3EAE";
					break;
				}
				string text6 = "F444" + API.bytestohexstring(new byte[2]
				{
					API.hexstringtobyte((mk.Length + am.Length + 23).ToString("X4"))[1],
					API.hexstringtobyte((mk.Length + am.Length + 23).ToString("X4"))[0]
				}) + "0901" + sex.ToString("X2") + "00" + hair.ToString("X2") + "001CAF7D1A" + text5 + "7D1A" + tt.ToString("X2") + @int.ToString("X2") + atk.ToString("X2") + def.ToString("X2") + hp.ToString("X2") + sp.ToString("X2") + agi.ToString("X2") + mk.Length.ToString("X2") + text3 + am.Length.ToString("X2") + text4;
				byte[] packet = API.hexstringtobyte(text2 + text6);
				SendPacket(packet);
			}
		}

		public void DeleteChar(string mk, string am)
		{
			string text = "";
			checked
			{
				int num = mk.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					text += Strings.Asc(mk.Substring(i, 1)).ToString("X2");
				}
				string text2 = "";
				int num2 = am.Length - 1;
				for (int j = 0; j <= num2; j++)
				{
					text2 += Strings.Asc(am.Substring(j, 1)).ToString("X2");
				}
				string text3 = "F444" + API.bytestohexstring(new byte[2]
				{
					API.hexstringtobyte((mk.Length + am.Length + 4).ToString("X4"))[1],
					API.hexstringtobyte((mk.Length + am.Length + 4).ToString("X4"))[0]
				}) + "2302";
				byte[] packet = API.hexstringtobyte(text3 + mk.Length.ToString("X2") + text + am.Length.ToString("X2") + text2);
				SendPacket(packet);
			}
		}

	}
}
