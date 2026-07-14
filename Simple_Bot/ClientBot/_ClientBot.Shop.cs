using Microsoft.VisualBasic;

namespace Simple_Bot
{
	public partial class _ClientBot
	{
		public void Shop_Opening()
		{
			string text = "";
			string text2 = "";
			if (List_ShopItem.Count <= 0)
			{
				return;
			}
			foreach (Items.ShopItem value in List_ShopItem.Values)
			{
				int stt = value._Stt;
				int price = value._Price;
				text = text + stt.ToString("X2") + API.Int32ToHex4(price);
			}
			checked
			{
				if (List_ShopName.Length > 0)
				{
					int num = List_ShopName.Length - 1;
					for (int i = 0; i <= num; i++)
					{
						text2 += Strings.AscW(List_ShopName.Substring(i, 1)).ToString("X2");
					}
				}
				text = "171E" + List_ShopName.Length.ToString("X2") + text2 + List_ShopType.ToString("X2") + text;
				SendPacket(API.hexstringtobyte(API.Packet_Maker(text)));
				List_Shopping = 1;
			}
		}

		public void Shop_Closing()
		{
			string packet = "171F";
			SendPacket(API.hexstringtobyte(API.Packet_Maker(packet)));
			List_Shopping = 0;
		}
	}
}
