using System;
using System.Diagnostics;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Simple_Bot
{
	public partial class _ClientBot
	{
		public void Doi_Ngua()
		{
			if ((API.IDNgua > 0) & (this.m_q.Length > 0))
			{
				_Local_SendPacket(API.hexstringtobyte(API.Packet_Maker("0F08" + this.m_g.ToString("X2") + API.Int32ToHex2(API.IDNgua) + this.m_q)));
				_Local_SendPacket(API.hexstringtobyte(API.Packet_Maker("0F05" + API.Int32ToHex4(idlogin) + API.Int32ToHex4(API.IDNgua) + "00000000")));
			}
			int textBox_IDmem = TextBox_IDmem1;
			int textBox_IDmem2 = TextBox_IDmem2;
			int textBox_IDmem3 = TextBox_IDmem3;
			int textBox_IDmem4 = TextBox_IDmem4;
			byte[] packet = API.hexstringtobyte(API.Packet_Maker("0F05" + API.Int32ToHex4(textBox_IDmem) + API.Int32ToHex4(API.IDNgua) + "00000000"));
			byte[] packet2 = API.hexstringtobyte(API.Packet_Maker("0F05" + API.Int32ToHex4(textBox_IDmem2) + API.Int32ToHex4(API.IDNgua) + "00000000"));
			byte[] packet3 = API.hexstringtobyte(API.Packet_Maker("0F05" + API.Int32ToHex4(textBox_IDmem3) + API.Int32ToHex4(API.IDNgua) + "00000000"));
			byte[] packet4 = API.hexstringtobyte(API.Packet_Maker("0F05" + API.Int32ToHex4(textBox_IDmem4) + API.Int32ToHex4(API.IDNgua) + "00000000"));
			_Local_SendPacket(packet);
			_Local_SendPacket(packet2);
			_Local_SendPacket(packet3);
			_Local_SendPacket(packet4);
		}

		public void Doi_Xuong_Ngua()
		{
			if ((API.IDNgua > 0) & (this.m_q.Length > 0))
			{
				_Local_SendPacket(API.hexstringtobyte(API.Packet_Maker("0F08" + this.m_g.ToString("X2") + API.Int32ToHex2(this.m_l) + this.m_q)));
			}
		}

		private void HandlePetListAndHorse(byte[] packet)
		{
			checked
			{
				try
				{
					switch (packet[5])
					{
					case 5:
					{
						if (!API.List_Ip_nts.Contains(API.ServerIp))
						{
							break;
						}
						int num7 = Convert.ToInt32(API.bytestohexstring(new byte[4]
						{
							packet[9],
							packet[8],
							packet[7],
							packet[6]
						}), 16);
						int num8 = Convert.ToInt32(API.bytestohexstring(new byte[4]
						{
							packet[13],
							packet[12],
							packet[11],
							packet[10]
						}), 16);
						if (num7 != idlogin)
						{
							break;
						}
						_CuoiNgua = 1;
						if (API.List_Ip_nts.Contains(API.ServerIp))
						{
							this.m_l = num8;
							int num9 = num8;
							if (num9 == this.m_m)
							{
								this.m_q = this.m_r;
								this.m_g = this.m_h;
							}
							else if (num9 == this.m_n)
							{
								this.m_q = this.m_s;
								this.m_g = this.m_i;
							}
							else if (num9 == this.m_o)
							{
								this.m_q = this.m_t;
								this.m_g = this.m_j;
							}
							else if (num9 == this.m_p)
							{
								this.m_q = this.m_u;
								this.m_g = this.m_k;
							}
							Doi_Ngua();
						}
						break;
					}
					case 6:
					{
						if (!API.List_Ip_nts.Contains(API.ServerIp))
						{
							break;
						}
						int num10 = Convert.ToInt32(API.bytestohexstring(new byte[4]
						{
							packet[9],
							packet[8],
							packet[7],
							packet[6]
						}), 16);
						if (num10 == idlogin)
						{
							if (C_CheckBox_TuLenNgua)
							{
								LenNgua();
							}
							if (API.List_Ip_nts.Contains(API.ServerIp))
							{
								Doi_Xuong_Ngua();
							}
						}
						break;
					}
					case 8:
					{
						string text = API.bytestohexstring(packet).Substring(12);
						while (text.Length != 0)
						{
							string text2 = text.Substring(0, 196 + (API.hexstringtobyte(text)[29] + 1) * 2);
							byte[] array = API.hexstringtobyte(text2);
							int num = array[0];
							int num2 = API.HexToInt32(text2.Substring(2, 4));
							if (API.List_Ip_nts.Contains(API.ServerIp) && Npcs.Data_Npcs.ContainsKey(num2) && Npcs.Data_Npcs[num2]._Type == 9)
							{
								switch (num)
								{
								case 1:
									this.m_h = 1;
									this.m_m = num2;
									this.m_r = text2.Substring(6);
									break;
								case 2:
									this.m_i = 2;
									this.m_n = num2;
									this.m_s = text2.Substring(6);
									break;
								case 3:
									this.m_j = 3;
									this.m_o = num2;
									this.m_t = text2.Substring(6);
									break;
								case 4:
									this.m_k = 4;
									this.m_p = num2;
									this.m_u = text2.Substring(6);
									break;
								}
							}
							string text3 = "";
							int num3 = 29 + array[29];
							for (int i = 30; i <= num3; i++)
							{
								text3 += Conversions.ToString(Strings.Chr(array[i]));
							}
							int num4 = array[7];
							int thuocTinh = 0;
							int hp = API.HexToInt32(text2.Substring(16, 4));
							int hpMax = API.HexToInt32(text2.Substring(16, 4));
							int sp = API.HexToInt32(text2.Substring(20, 4));
							int spMax = API.HexToInt32(text2.Substring(20, 4));
							int fai = array[25];
							int num5 = API.HexToInt32(text2.Substring(6, 8));
							int num6 = API.HexToInt32(text2.Substring(24, 4));
							int atk = API.HexToInt32(text2.Substring(28, 4));
							int def = API.HexToInt32(text2.Substring(32, 4));
							int agi = API.HexToInt32(text2.Substring(36, 4));
							int hpx = API.HexToInt32(text2.Substring(40, 4));
							int spx = API.HexToInt32(text2.Substring(44, 4));
							int mu = API.HexToInt32(text2.Substring(text2.Length - 132, 4));
							int ao = API.HexToInt32(text2.Substring(text2.Length - 112, 4));
							int vukhi = API.HexToInt32(text2.Substring(text2.Length - 92, 4));
							int tay = API.HexToInt32(text2.Substring(text2.Length - 72, 4));
							int chan = API.HexToInt32(text2.Substring(text2.Length - 52, 4));
							int dacthu = API.HexToInt32(text2.Substring(text2.Length - 32, 4));
							Texps._Texp texp = Texps.Data_Texps[num4];
							Texps._Texp texp2 = Texps.Data_Texps[num4 - 1];
							int exp = num5 - texp2._0;
							int expMax = texp._0 - texp2._0;
							int reborn = array[28];
							int reborn2 = Npcs.Data_Npcs[num2]._Reborn;
							if (reborn2 == 2)
							{
								exp = num5 - texp2._1;
								expMax = texp._1 - texp2._1;
							}
							_Data._Pets value = Data_PetsInfo[num];
							value._Id = num2;
							value._Name = API.VISCII_to_Unicode(text3);
							value._Lv = num4;
							value._ThuocTinh = thuocTinh;
							value._Hp = hp;
							value._HpMax = hpMax;
							value._Sp = sp;
							value._SpMax = spMax;
							value._Fai = fai;
							value._Exp = exp;
							value._ExpMax = expMax;
							value._ExpTotal = num5;
							value._Texp = 0;
							value._Reborn = reborn;
							value._Int = num6;
							value._Atk = atk;
							value._Def = def;
							value._Agi = agi;
							value._Hpx = hpx;
							value._Spx = spx;
							value._Mu = mu;
							value._Ao = ao;
							value._vukhi = vukhi;
							value._tay = tay;
							value._chan = chan;
							value._dacthu = dacthu;
							Data_PetsInfo[num] = value;
							text = text.Replace(text2, "");
						}
						break;
					}
					case 7:
						break;
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					StackTrace stackTrace = new StackTrace(true);
					stackTrace = new StackTrace(ex2, true);
					API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - Update_HF] :" + ex2.Message + stackTrace.GetFrame(0).GetFileLineNumber() + "\r\n");
					ProjectData.ClearProjectError();
				}
			}
		}

	}
}
