using System.Collections;
using System.Drawing;
using Microsoft.VisualBasic.CompilerServices;

namespace Simple_Bot
{
	public partial class _ClientBot
	{
		public void LeaderInvitePartyto(int id)
		{
			if (!AutoClearGhost)
			{
				byte[] packet = API.hexstringtobyte("F44406000D07" + API.Int32ToHex4(id));
				SendPacket(packet);
			}
		}

		public void LeaderAcceptedPartyFrom(int id)
		{
			if (!AutoClearGhost)
			{
				byte[] packet = API.hexstringtobyte("F44407000D0301" + API.Int32ToHex4(id));
				SendPacket(packet);
			}
		}

		public void MemRequestPartyto(int id)
		{
			if (!AutoClearGhost)
			{
				byte[] packet = API.hexstringtobyte("F44406000D01" + API.Int32ToHex4(id));
				SendPacket(packet);
			}
		}

		public void MemAcceptPartyto(int id)
		{
			if (!AutoClearGhost)
			{
				byte[] packet = API.hexstringtobyte("F44407000D0801" + API.Int32ToHex4(id));
				SendPacket(packet);
			}
		}

		public void OutParty()
		{
			if (Data_Player._LeaderId != 0)
			{
				byte[] packet = API.hexstringtobyte("F44406000D04" + API.Int32ToHex4(Data_Player._Id));
				SendPacket(packet);
			}
		}

		public void SetQuanSu(int id)
		{
			byte[] packet = API.hexstringtobyte("F44406000D05" + API.Int32ToHex4(id));
			SendPacket(packet);
		}

		public void AnswerBTQ(ArrayList listanswer)
		{
			int num = 0;
			checked
			{
				do
				{
					if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(listanswer[num], null, "Length", new object[0], null, null, null), 4, false) && Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet(listanswer[num], new object[1] { 1 }, null), 84, false))
					{
						API.AddColorText2(this, Rtbsystem, "Chọn :" + Conversions.ToString(num + 1) + ". " + API.HexToChar((byte[])listanswer[num]), Color.Red);
						byte[] packet = API.hexstringtobyte("F44406001001" + (num + 1).ToString("X2") + "000000");
						SendPacket(packet);
						if (Battle == 0)
						{
							BTQ = 0;
						}
						return;
					}
					num++;
				}
				while (num <= 3);
				int num2 = 0;
				do
				{
					if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(listanswer[num2], null, "Length", new object[0], null, null, null), 4, false) && Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet(listanswer[num2], new object[1] { 1 }, null), 187, false))
					{
						API.AddColorText2(this, Rtbsystem, "Chọn :" + Conversions.ToString(num2 + 1) + ". " + API.HexToChar((byte[])listanswer[num2]), Color.Red);
						byte[] packet2 = API.hexstringtobyte("F44406001001" + (num2 + 1).ToString("X2") + "000000");
						SendPacket(packet2);
						if (Battle == 0)
						{
							BTQ = 0;
						}
						return;
					}
					num2++;
				}
				while (num2 <= 3);
				int num3 = 0;
				do
				{
					if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(listanswer[num3], null, "Length", new object[0], null, null, null), 4, false) && Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet(listanswer[num3], new object[1] { 1 }, null), 69, false))
					{
						API.AddColorText2(this, Rtbsystem, "Chọn :" + Conversions.ToString(num3 + 1) + ". " + API.HexToChar((byte[])listanswer[num3]), Color.Red);
						byte[] packet3 = API.hexstringtobyte("F44406001001" + (num3 + 1).ToString("X2") + "000000");
						SendPacket(packet3);
						if (Battle == 0)
						{
							BTQ = 0;
						}
						return;
					}
					num3++;
				}
				while (num3 <= 3);
				API.AddColorText2(this, Rtbsystem, "Chọn : 2. " + API.HexToChar((byte[])listanswer[1]), Color.Red);
				byte[] packet4 = API.hexstringtobyte("F4440600100102000000");
				SendPacket(packet4);
				if (Battle == 0)
				{
					BTQ = 0;
				}
			}
		}

		public bool Party_CheckFull()
		{
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			bool flag4 = false;
			bool flag5 = false;
			flag2 = TextBox_IDmem1 == 0 || (((_IDmem1 != 0) & (TextBox_IDmem1 == _IDmem1)) ? true : false);
			flag3 = TextBox_IDmem2 == 0 || (((_IDmem2 != 0) & (TextBox_IDmem2 == _IDmem2)) ? true : false);
			flag4 = TextBox_IDmem3 == 0 || (((_IDmem3 != 0) & (TextBox_IDmem3 == _IDmem3)) ? true : false);
			flag5 = TextBox_IDmem4 == 0 || (((_IDmem4 != 0) & (TextBox_IDmem4 == _IDmem4)) ? true : false);
			if (flag2 && flag3 && flag4 && flag5)
			{
				return true;
			}
			return false;
		}
	}
}
