using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Simple_Bot
{
	public partial class _ClientBot
	{
		private void HandleInventoryUpdate(byte[] packet)
		{
			checked
			{
				switch (packet[5])
				{
				case 2:
					try
					{
						string text2 = API.bytestohexstring(packet).Substring(12);
						int num8 = API.HexToInt32(text2.Substring(0, 4));
						Data_ItemOnMaps[num8 - 1] = default(_Data._ItemOnMap);
						break;
					}
					catch (Exception ex5)
					{
						ProjectData.SetProjectError(ex5);
						Exception ex6 = ex5;
						StackTrace stackTrace3 = new StackTrace(true);
						stackTrace3 = new StackTrace(ex6, true);
						API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - Update_Inventory2] :" + ex6.Message + stackTrace3.GetFrame(0).GetFileLineNumber() + "\r\n");
						ProjectData.ClearProjectError();
						break;
					}
				case 3:
					try
					{
						string text8 = API.bytestohexstring(packet).Substring(12);
						int id3 = API.HexToInt32(text8.Substring(0, 4));
						int mapX = API.HexToInt32(text8.Substring(4, 4));
						int mapY = API.HexToInt32(text8.Substring(8, 4));
						int gold = 0;
						foreach (int key in Data_ItemOnMaps.Keys)
						{
							_Data._ItemOnMap value3 = Data_ItemOnMaps[key];
							if (value3._Id == 0)
							{
								value3._Gold = gold;
								value3._Id = id3;
								value3._Name = GetItemName(id3);
								value3._MapX = mapX;
								value3._MapY = mapY;
								Data_ItemOnMaps[key] = value3;
								break;
							}
						}
						break;
					}
					catch (Exception ex37)
					{
						ProjectData.SetProjectError(ex37);
						Exception ex38 = ex37;
						StackTrace stackTrace19 = new StackTrace(true);
						stackTrace19 = new StackTrace(ex38, true);
						API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - Update_Inventory3] :" + ex38.Message + stackTrace19.GetFrame(0).GetFileLineNumber() + "\r\n");
						ProjectData.ClearProjectError();
						break;
					}
				case 4:
					try
					{
						string text6 = API.bytestohexstring(packet).Substring(12);
						while (text6.Length != 0)
						{
							string text7 = text6.Substring(0, 22);
							int num48 = API.HexToInt32(text7.Substring(6, 8));
							int num49 = API.HexToInt32(text7.Substring(14, 4));
							int num50 = API.HexToInt32(text7.Substring(18, 4));
							int num51 = API.HexToInt32(text7.Substring(2, 4));
							int num52 = API.HexToInt32(text7.Substring(0, 2));
							text6 = text6.Replace(text7, "");
						}
						break;
					}
					catch (Exception ex35)
					{
						ProjectData.SetProjectError(ex35);
						Exception ex36 = ex35;
						StackTrace stackTrace18 = new StackTrace(true);
						stackTrace18 = new StackTrace(ex36, true);
						API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - Update_Inventory4] :" + ex36.Message + stackTrace18.GetFrame(0).GetFileLineNumber() + "\r\n");
						ProjectData.ClearProjectError();
						break;
					}
				case 5:
					try
					{
						string text5 = API.bytestohexstring(packet).Substring(12);
						while (text5.Length != 0)
						{
							byte[] array2 = API.hexstringtobyte(text5.Substring(0, 24));
							int stt15 = array2[0];
							int num45 = API.HexToInt32(API.bytestohexstring(array2).Substring(2, 4));
							int num46 = array2[3];
							int num47 = array2[4];
							this.set_DataTuido(stt15, _Data.Type_Tui._Id, (object)num45);
							this.set_DataTuido(stt15, _Data.Type_Tui._Sl, (object)num46);
							this.set_DataTuido(stt15, _Data.Type_Tui._Doben, (object)num47);
							text5 = text5.Replace(API.bytestohexstring(array2), "");
						}
						break;
					}
					catch (Exception ex33)
					{
						ProjectData.SetProjectError(ex33);
						Exception ex34 = ex33;
						StackTrace stackTrace17 = new StackTrace(true);
						stackTrace17 = new StackTrace(ex34, true);
						API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - Update_Inventory5] :" + ex34.Message + stackTrace17.GetFrame(0).GetFileLineNumber() + "\r\n");
						ProjectData.ClearProjectError();
						break;
					}
				case 10:
					try
					{
						int stt13 = packet[6];
						int num44 = packet[7];
						int stt14 = packet[8];
						if (Operators.ConditionalCompareObjectEqual(this.get_DataTuido(stt14, _Data.Type_Tui._Sl), 0, false))
						{
							this.set_DataTuido(stt14, _Data.Type_Tui._Id, RuntimeHelpers.GetObjectValue(this.get_DataTuido(stt13, _Data.Type_Tui._Id)));
							this.set_DataTuido(stt14, _Data.Type_Tui._Sl, (object)num44);
							this.set_DataTuido(stt14, _Data.Type_Tui._Doben, RuntimeHelpers.GetObjectValue(this.get_DataTuido(stt13, _Data.Type_Tui._Doben)));
						}
						else
						{
							this.set_DataTuido(stt14, _Data.Type_Tui._Sl, Operators.AddObject(this.get_DataTuido(stt14, _Data.Type_Tui._Sl), num44));
						}
						if (Operators.ConditionalCompareObjectEqual(Operators.SubtractObject(this.get_DataTuido(stt13, _Data.Type_Tui._Sl), num44), 0, false))
						{
							this.set_DataTuido(stt13, _Data.Type_Tui._Id, (object)0);
							this.set_DataTuido(stt13, _Data.Type_Tui._Sl, (object)0);
							this.set_DataTuido(stt13, _Data.Type_Tui._Doben, (object)0);
						}
						else
						{
							this.set_DataTuido(stt13, _Data.Type_Tui._Sl, Operators.SubtractObject(this.get_DataTuido(stt13, _Data.Type_Tui._Sl), num44));
						}
						break;
					}
					catch (Exception ex31)
					{
						ProjectData.SetProjectError(ex31);
						Exception ex32 = ex31;
						StackTrace stackTrace16 = new StackTrace(true);
						stackTrace16 = new StackTrace(ex32, true);
						API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - Update_InventoryA] :" + ex32.Message + stackTrace16.GetFrame(0).GetFileLineNumber() + "\r\n");
						ProjectData.ClearProjectError();
						break;
					}
				case 11:
					try
					{
						string text3 = API.bytestohexstring(packet).Substring(12);
						while (text3.Length != 0)
						{
							string text4 = text3.Substring(0, 20);
							int num42 = API.HexToInt32(text4.Substring(0, 4));
							int num43 = API.HexToInt32(text4.Substring(5, 2));
							int stt12 = Items.Data_Items[num42]._Loai - 1;
							this.set_DataCharEquit(stt12, _Data.Type_Equit._Id, (object)num42);
							this.set_DataCharEquit(stt12, _Data.Type_Equit._Doben, (object)num43);
							text3 = text3.Replace(text4, "");
						}
						break;
					}
					catch (Exception ex29)
					{
						ProjectData.SetProjectError(ex29);
						Exception ex30 = ex29;
						StackTrace stackTrace15 = new StackTrace(true);
						stackTrace15 = new StackTrace(ex30, true);
						API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - Update_InventoryB] :" + ex30.Message + stackTrace15.GetFrame(0).GetFileLineNumber() + "\r\n");
						ProjectData.ClearProjectError();
						break;
					}
				case 6:
					try
					{
						int num34 = API.HexToInt32(API.bytestohexstring(packet).Substring(12, 4));
						int num35 = API.HexToInt32(API.bytestohexstring(packet).Substring(16, 2));
						API.AddColorText2(this, Rtbsystem, "Nhận được : " + Conversions.ToString(num35) + " " + GetItemName(num34), Color.DeepPink);
						if (!Items.Data_Items.ContainsKey(num34))
						{
							break;
						}
						Items.ItemInfo items = Items.Data_Items[num34];
						switch (items._Loai)
						{
						case 1:
						case 2:
						case 3:
						case 4:
						case 5:
						case 6:
						{
							int num40 = 1;
							do
							{
								if (Data_Tuido[num40]._Id == 0)
								{
									this.set_DataTuido(num40, _Data.Type_Tui._Id, (object)num34);
									this.set_DataTuido(num40, _Data.Type_Tui._Sl, (object)1);
									break;
								}
								num40++;
							}
							while (num40 <= 25);
							break;
						}
						case 0:
							if (TuidoGetSlotConstainId50(num34) == 0)
							{
								if (TuidoGetSlotNothing() > 0)
								{
									int stt11 = TuidoGetSlotNothing();
									this.set_DataTuido(stt11, _Data.Type_Tui._Id, (object)num34);
									this.set_DataTuido(stt11, _Data.Type_Tui._Sl, (object)num35);
								}
								break;
							}
							while (num35 > 0)
							{
								int num36 = TuidoGetSlotConstainId50(num34);
								if (num36 == 0)
								{
									int num37 = TuidoGetSlotNothing();
									if (num37 == 0)
									{
										num35 = 0;
										break;
									}
									this.set_DataTuido(num37, _Data.Type_Tui._Id, (object)num34);
									this.set_DataTuido(num37, _Data.Type_Tui._Sl, (object)num35);
									num35 = 0;
									break;
								}
								int num38 = Conversions.ToInteger(this.get_DataTuido(num36, _Data.Type_Tui._Sl));
								int stt2;
								string sl;
								if (num35 + num38 <= 50)
								{
									this.set_DataTuido(stt2 = num36, sl = _Data.Type_Tui._Sl, Operators.AddObject(this.get_DataTuido(stt2, sl), num35));
									num35 = 0;
									break;
								}
								int num39 = 50 - num38;
								this.set_DataTuido(stt2 = num36, sl = _Data.Type_Tui._Sl, Operators.AddObject(this.get_DataTuido(stt2, sl), num39));
								num35 -= num39;
							}
							break;
						}
						int num41 = 0;
						if (Data_ListSend.Count > 0 && Data_ListSend.Contains(num34))
						{
							num41 = 1;
						}
						if (C_CheckBox_SendHp)
						{
							int itemHp = GetItemHp(num34);
							if ((itemHp > 0) & (itemHp < TextBox_Send_HpValue))
							{
								num41 = 1;
							}
						}
						if (C_CheckBox_SendSp)
						{
							int itemSp = GetItemSp(num34);
							if ((itemSp > 0) & (itemSp < TextBox_Send_SpValue))
							{
								num41 = 1;
							}
						}
						unchecked
						{
							if (C_CheckBox_SendHpSp)
							{
								int itemHp2 = GetItemHp(num34);
								int itemSp2 = GetItemSp(num34);
								if (itemHp2 > 0 && itemSp2 > 0)
								{
									num41 = 1;
								}
							}
							if (!C_CheckBox_SendMineWood)
							{
								break;
							}
							if (Items.Data_Items.ContainsKey(num34))
							{
								int type_ = Items.Data_Items[num34]._Type_2;
								if (type_ == 25 || (uint)(type_ - 40) <= 6u)
								{
									num41 = 1;
								}
							}
							if (C_CheckBox_Autosort)
							{
								int id2 = items._id;
								if ((uint)(id2 - 23086) <= 3u)
								{
									AutoSort_Tuido();
								}
							}
							if (_stt_send == 0 && num41 == 1)
							{
								if (ProgressBarEx_BDY > 0)
								{
									ProgressBarEx_BDY = 0;
								}
								if (TextBox_AutoSend > 0)
								{
									AutoSendItem();
								}
							}
							break;
						}
					}
					catch (Exception ex27)
					{
						ProjectData.SetProjectError(ex27);
						Exception ex28 = ex27;
						StackTrace stackTrace14 = new StackTrace(true);
						stackTrace14 = new StackTrace(ex28, true);
						API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - Update_Inventory6] :" + ex28.StackTrace + " - " + stackTrace14.GetFrame(0).GetFileLineNumber() + "\r\n");
						ProjectData.ClearProjectError();
						break;
					}
				case 7:
					try
					{
						int num30 = Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							packet[7],
							packet[6]
						}), 16);
						int num31 = packet[8];
						API.AddColorText2(this, Rtbsystem, "Mất : " + num31 + " " + GetItemName(num30), Color.Red);
						if (num31 <= 1)
						{
							break;
						}
						int num32 = num31;
						for (int i = 1; i <= num32; i++)
						{
							int num33 = 1;
							do
							{
								if (Data_Tuido[num33]._Id == num30)
								{
									if (Operators.ConditionalCompareObjectEqual(this.get_DataTuido(num33, _Data.Type_Tui._Sl), num31, false))
									{
										this.set_DataTuido(num33, _Data.Type_Tui._Id, (object)0);
										this.set_DataTuido(num33, _Data.Type_Tui._Sl, (object)0);
									}
									else if (Operators.ConditionalCompareObjectGreater(this.get_DataTuido(num33, _Data.Type_Tui._Sl), num31, false))
									{
										int stt2;
										string sl;
										this.set_DataTuido(stt2 = num33, sl = _Data.Type_Tui._Sl, Operators.SubtractObject(this.get_DataTuido(stt2, sl), num31));
									}
									else if (Operators.ConditionalCompareObjectLess(this.get_DataTuido(num33, _Data.Type_Tui._Sl), num31, false))
									{
										if (Operators.ConditionalCompareObjectGreater(this.get_DataTuido(num33, _Data.Type_Tui._Sl), 1, false))
										{
											int stt2;
											string sl;
											this.set_DataTuido(stt2 = num33, sl = _Data.Type_Tui._Sl, Operators.SubtractObject(this.get_DataTuido(stt2, sl), 1));
											break;
										}
										this.set_DataTuido(num33, _Data.Type_Tui._Id, (object)0);
										this.set_DataTuido(num33, _Data.Type_Tui._Sl, (object)0);
									}
									break;
								}
								num33++;
							}
							while (num33 <= 25);
						}
						break;
					}
					catch (Exception ex25)
					{
						ProjectData.SetProjectError(ex25);
						Exception ex26 = ex25;
						StackTrace stackTrace13 = new StackTrace(true);
						stackTrace13 = new StackTrace(ex26, true);
						API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - Update_Inventory7 :" + ex26.Message + stackTrace13.GetFrame(0).GetFileLineNumber() + "\r\n");
						ProjectData.ClearProjectError();
						break;
					}
				case 8:
					unchecked
					{
						try
						{
							int num28 = API.HexToInt32(API.bytestohexstring(packet).Substring(14, 4));
							object left = this.get_DataTuido((int)packet[6], _Data.Type_Tui._Id);
							if (Operators.ConditionalCompareObjectEqual(left, num28, false))
							{
								int num29 = Conversions.ToInteger(Operators.AddObject(this.get_DataTuido((int)packet[6], _Data.Type_Tui._Sl), packet[9]));
								if (num29 >= 50)
								{
									this.set_DataTuido((int)packet[6], _Data.Type_Tui._Id, (object)num28);
									this.set_DataTuido((int)packet[6], _Data.Type_Tui._Sl, (object)packet[9]);
								}
								else
								{
									this.set_DataTuido((int)packet[6], _Data.Type_Tui._Id, (object)num28);
									int stt2;
									string sl;
									this.set_DataTuido(stt2 = packet[6], sl = _Data.Type_Tui._Sl, Operators.AddObject(this.get_DataTuido(stt2, sl), packet[9]));
								}
							}
							else
							{
								this.set_DataTuido((int)packet[6], _Data.Type_Tui._Id, (object)num28);
								this.set_DataTuido((int)packet[6], _Data.Type_Tui._Sl, (object)packet[9]);
							}
							if (C_CheckBox_Autosort && (uint)(num28 - 23086) <= 3u)
							{
								AutoSort_Tuido();
							}
							break;
						}
						catch (Exception ex23)
						{
							ProjectData.SetProjectError(ex23);
							Exception ex24 = ex23;
							StackTrace stackTrace12 = new StackTrace(true);
							stackTrace12 = new StackTrace(ex24, true);
							API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - Update_Inventory8] :" + ex24.Message + stackTrace12.GetFrame(0).GetFileLineNumber() + "\r\n");
							ProjectData.ClearProjectError();
							break;
						}
					}
				case 9:
					try
					{
						int num26 = packet[6];
						int num27 = packet[7];
						API.AddColorText2(this, Rtbsystem, "Mất : " + num27 + " " + GetItemName(Conversions.ToInteger(this.get_DataTuido(num26, _Data.Type_Tui._Id))), Color.Red);
						if (Operators.ConditionalCompareObjectLessEqual(Operators.SubtractObject(this.get_DataTuido(num26, _Data.Type_Tui._Sl), num27), 0, false))
						{
							this.set_DataTuido(num26, _Data.Type_Tui._Id, (object)0);
							this.set_DataTuido(num26, _Data.Type_Tui._Sl, (object)0);
						}
						else
						{
							int stt2;
							string sl;
							this.set_DataTuido(stt2 = num26, sl = _Data.Type_Tui._Sl, Operators.SubtractObject(this.get_DataTuido(stt2, sl), num27));
						}
						break;
					}
					catch (Exception ex21)
					{
						ProjectData.SetProjectError(ex21);
						Exception ex22 = ex21;
						StackTrace stackTrace11 = new StackTrace(true);
						stackTrace11 = new StackTrace(ex22, true);
						API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - Update_Inventory9] :" + ex22.Message + stackTrace11.GetFrame(0).GetFileLineNumber() + "\r\n");
						ProjectData.ClearProjectError();
						break;
					}
				case 16:
					try
					{
						int num25 = packet[6];
						int stt10 = packet[7];
						this.set_DataTuido(stt10, _Data.Type_Tui._Id, RuntimeHelpers.GetObjectValue(this.get_DataCharEquit(num25 - 1, _Data.Type_Equit._Id)));
						this.set_DataTuido(stt10, _Data.Type_Tui._Sl, (object)1);
						this.set_DataCharEquit(num25 - 1, _Data.Type_Equit._Id, (object)0);
						break;
					}
					catch (Exception ex19)
					{
						ProjectData.SetProjectError(ex19);
						Exception ex20 = ex19;
						StackTrace stackTrace10 = new StackTrace(true);
						stackTrace10 = new StackTrace(ex20, true);
						API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - Update_Inventory10] :" + ex20.Message + stackTrace10.GetFrame(0).GetFileLineNumber() + "\r\n");
						ProjectData.ClearProjectError();
						break;
					}
				case 17:
					try
					{
						int stt8 = packet[6];
						int num23 = Conversions.ToInteger(this.get_DataTuido(stt8, _Data.Type_Tui._Id));
						int stt9 = Items.Data_Items[num23]._Loai - 1;
						int num24 = Conversions.ToInteger(this.get_DataCharEquit(stt9, _Data.Type_Equit._Id));
						string value2 = Conversions.ToString(this.get_DataCharEquit(stt9, _Data.Type_Equit._Doben));
						this.set_DataCharEquit(stt9, _Data.Type_Equit._Id, (object)num23);
						this.set_DataCharEquit(stt9, _Data.Type_Equit._Doben, RuntimeHelpers.GetObjectValue(this.get_DataTuido(stt8, _Data.Type_Tui._Doben)));
						if (num24 == 0)
						{
							this.set_DataTuido(stt8, _Data.Type_Tui._Id, (object)0);
							this.set_DataTuido(stt8, _Data.Type_Tui._Sl, (object)0);
							this.set_DataTuido(stt8, _Data.Type_Tui._Doben, (object)0);
						}
						else
						{
							this.set_DataTuido(stt8, _Data.Type_Tui._Id, (object)num24);
							this.set_DataTuido(stt8, _Data.Type_Tui._Sl, (object)1);
							this.set_DataTuido(stt8, _Data.Type_Tui._Doben, (object)value2);
						}
						break;
					}
					catch (Exception ex17)
					{
						ProjectData.SetProjectError(ex17);
						Exception ex18 = ex17;
						StackTrace stackTrace9 = new StackTrace(true);
						stackTrace9 = new StackTrace(ex18, true);
						API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - Update_Inventory11] :" + ex18.Message + stackTrace9.GetFrame(0).GetFileLineNumber() + "\r\n");
						ProjectData.ClearProjectError();
						break;
					}
				case 22:
					try
					{
						int num20 = packet[6];
						int num21 = packet[7];
						int stt7 = packet[8];
						int num22 = 0;
						switch (num21)
						{
						case 1:
							num22 = Conversions.ToInteger(this.get_DataPets(num20, _Data.Type_Pets._Mu));
							this.set_DataPets(num20, _Data.Type_Pets._Mu, (object)0);
							break;
						case 2:
							num22 = Conversions.ToInteger(this.get_DataPets(num20, _Data.Type_Pets._Ao));
							this.set_DataPets(num20, _Data.Type_Pets._Ao, (object)0);
							break;
						case 3:
							num22 = Conversions.ToInteger(this.get_DataPets(num20, _Data.Type_Pets._vukhi));
							this.set_DataPets(num20, _Data.Type_Pets._vukhi, (object)0);
							break;
						case 4:
							num22 = Conversions.ToInteger(this.get_DataPets(num20, _Data.Type_Pets._tay));
							this.set_DataPets(num20, _Data.Type_Pets._tay, (object)0);
							break;
						case 5:
							num22 = Conversions.ToInteger(this.get_DataPets(num20, _Data.Type_Pets._chan));
							this.set_DataPets(num20, _Data.Type_Pets._chan, (object)0);
							break;
						case 6:
							num22 = Conversions.ToInteger(this.get_DataPets(num20, _Data.Type_Pets._dacthu));
							this.set_DataPets(num20, _Data.Type_Pets._dacthu, (object)0);
							break;
						}
						this.set_DataTuido(stt7, _Data.Type_Tui._Id, (object)num22);
						this.set_DataTuido(stt7, _Data.Type_Tui._Sl, (object)1);
						if (num20 == PetBattle)
						{
							this.set_DataPetEquit(num21 - 1, _Data.Type_Tui._Id, (object)0);
							this.set_DataPetEquit(num21 - 1, _Data.Type_Tui._Doben, (object)0);
						}
						break;
					}
					catch (Exception ex15)
					{
						ProjectData.SetProjectError(ex15);
						Exception ex16 = ex15;
						StackTrace stackTrace8 = new StackTrace(true);
						stackTrace8 = new StackTrace(ex16, true);
						API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - Update_Inventory16] :" + ex16.Message + stackTrace8.GetFrame(0).GetFileLineNumber() + "\r\n");
						ProjectData.ClearProjectError();
						break;
					}
				case 23:
					try
					{
						int stt5 = packet[6];
						int stt6 = packet[7];
						int num17 = Conversions.ToInteger(this.get_DataTuido(stt6, _Data.Type_Tui._Id));
						int num18 = Items.Data_Items[num17]._Loai - 1;
						int num19 = default(int);
						switch (num18)
						{
						case 0:
							num19 = Conversions.ToInteger(this.get_DataPets(stt5, _Data.Type_Pets._Mu));
							this.set_DataPets(stt5, _Data.Type_Pets._Mu, (object)num17);
							break;
						case 1:
							num19 = Conversions.ToInteger(this.get_DataPets(stt5, _Data.Type_Pets._Ao));
							this.set_DataPets(stt5, _Data.Type_Pets._Ao, (object)num17);
							break;
						case 2:
							num19 = Conversions.ToInteger(this.get_DataPets(stt5, _Data.Type_Pets._vukhi));
							this.set_DataPets(stt5, _Data.Type_Pets._vukhi, (object)num17);
							break;
						case 3:
							num19 = Conversions.ToInteger(this.get_DataPets(stt5, _Data.Type_Pets._tay));
							this.set_DataPets(stt5, _Data.Type_Pets._tay, (object)num17);
							break;
						case 4:
							num19 = Conversions.ToInteger(this.get_DataPets(stt5, _Data.Type_Pets._chan));
							this.set_DataPets(stt5, _Data.Type_Pets._chan, (object)num17);
							break;
						case 5:
							num19 = Conversions.ToInteger(this.get_DataPets(stt5, _Data.Type_Pets._dacthu));
							this.set_DataPets(stt5, _Data.Type_Pets._dacthu, (object)num17);
							break;
						}
						this.set_DataPetEquit(num18, _Data.Type_Equit._Id, (object)num17);
						this.set_DataPetEquit(num18, _Data.Type_Equit._Doben, (object)0);
						if (num19 == 0)
						{
							this.set_DataTuido(stt6, _Data.Type_Tui._Id, (object)0);
							this.set_DataTuido(stt6, _Data.Type_Tui._Sl, (object)0);
						}
						else
						{
							this.set_DataTuido(stt6, _Data.Type_Tui._Id, (object)num19);
							this.set_DataTuido(stt6, _Data.Type_Tui._Sl, (object)1);
						}
						break;
					}
					catch (Exception ex13)
					{
						ProjectData.SetProjectError(ex13);
						Exception ex14 = ex13;
						StackTrace stackTrace7 = new StackTrace(true);
						stackTrace7 = new StackTrace(ex14, true);
						API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - Update_Inventory17] :" + ex14.Message + stackTrace7.GetFrame(0).GetFileLineNumber() + "\r\n");
						ProjectData.ClearProjectError();
						break;
					}
				case 24:
					try
					{
						int num12 = packet[6];
						int num13 = API.HexToInt32(API.bytestohexstring(packet).Substring(14, 4));
						int num14 = packet[9];
						if (!Items.Data_Items.ContainsKey(num13))
						{
							break;
						}
						int num15 = Items.Data_Items[num13]._Loai - 1;
						switch (num15)
						{
						case 0:
							this.set_DataPets(num12, _Data.Type_Pets._Mu, (object)num13);
							this.set_DataPets(num12, _Data.Type_Pets._Mu_Doben, (object)num14);
							break;
						case 1:
							this.set_DataPets(num12, _Data.Type_Pets._Ao, (object)num13);
							this.set_DataPets(num12, _Data.Type_Pets._Ao_Doben, (object)num14);
							break;
						case 2:
							this.set_DataPets(num12, _Data.Type_Pets._vukhi, (object)num13);
							this.set_DataPets(num12, _Data.Type_Pets._vukhi_Doben, (object)num14);
							break;
						case 3:
							this.set_DataPets(num12, _Data.Type_Pets._tay, (object)num13);
							this.set_DataPets(num12, _Data.Type_Pets._tay_Doben, (object)num14);
							break;
						case 4:
							this.set_DataPets(num12, _Data.Type_Pets._chan, (object)num13);
							this.set_DataPets(num12, _Data.Type_Pets._chan_Doben, (object)num14);
							break;
						case 5:
							this.set_DataPets(num12, _Data.Type_Pets._dacthu, (object)num13);
							this.set_DataPets(num12, _Data.Type_Pets._dacthu_Doben, (object)num14);
							break;
						}
						int num16 = num12;
						if (num16 == PetBattle)
						{
							_Data._Pets value = Data_PetsInfo[PetBattle];
							switch (num15)
							{
							case 0:
								value._Mu = num13;
								value._Mu_Doben = num14;
								break;
							case 1:
								value._Ao = num13;
								value._Ao_Doben = num14;
								break;
							case 2:
								value._vukhi = num13;
								value._vukhi_Doben = num14;
								break;
							case 3:
								value._tay = num13;
								value._tay_Doben = num14;
								break;
							case 4:
								value._chan = num13;
								value._chan_Doben = num14;
								break;
							case 5:
								value._dacthu = num13;
								value._dacthu_Doben = num14;
								break;
							}
							Data_PetsInfo[PetBattle] = value;
							this.set_DataPetEquit(num15, _Data.Type_Equit._Doben, (object)num14);
						}
						break;
					}
					catch (Exception ex11)
					{
						ProjectData.SetProjectError(ex11);
						Exception ex12 = ex11;
						StackTrace stackTrace6 = new StackTrace(true);
						stackTrace6 = new StackTrace(ex12, true);
						API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - Update_Inventory18] :" + ex12.Message + stackTrace6.GetFrame(0).GetFileLineNumber() + "\r\n");
						ProjectData.ClearProjectError();
						break;
					}
				case 27:
					try
					{
						int stt4 = packet[6] - 1;
						int num11 = packet[7];
						this.set_DataCharEquit(stt4, _Data.Type_Equit._Doben, (object)num11);
						break;
					}
					catch (Exception ex9)
					{
						ProjectData.SetProjectError(ex9);
						Exception ex10 = ex9;
						StackTrace stackTrace5 = new StackTrace(true);
						stackTrace5 = new StackTrace(ex10, true);
						API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - Update_Inventory1B] :" + ex10.Message + stackTrace5.GetFrame(0).GetFileLineNumber() + "\r\n");
						ProjectData.ClearProjectError();
						break;
					}
				case 28:
					try
					{
						int num9 = packet[6];
						int stt3 = packet[7] - 1;
						int num10 = packet[8];
						this.set_DataPetEquit(stt3, _Data.Type_Equit._Doben, (object)num10);
						break;
					}
					catch (Exception ex7)
					{
						ProjectData.SetProjectError(ex7);
						Exception ex8 = ex7;
						StackTrace stackTrace4 = new StackTrace(true);
						stackTrace4 = new StackTrace(ex8, true);
						API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - Update_Inventory1C] :" + ex8.Message + stackTrace4.GetFrame(0).GetFileLineNumber() + "\r\n");
						ProjectData.ClearProjectError();
						break;
					}
				case 31:
				{
					int num7 = API.BytesToInt32(new byte[4]
					{
						packet[6],
						packet[7],
						packet[8],
						packet[9]
					});
					if (idlogin == num7)
					{
						List_Shopping = 1;
					}
					break;
				}
				case 47:
					try
					{
						string text = API.bytestohexstring(packet).Substring(12);
						while (text.Length != 0)
						{
							byte[] array = API.hexstringtobyte(text.Substring(0, 24));
							int num2 = array[0];
							int num3 = API.HexToInt32(API.bytestohexstring(array).Substring(2, 4));
							int num4 = array[3];
							int num5 = array[4];
							int id = Data_Tuideo[num2]._Id;
							if (id == num3)
							{
								int num6 = Conversions.ToInteger(Operators.AddObject(this.get_DataTuideo(num2, _Data.Type_Tui._Sl), num4));
								if (num6 >= 50)
								{
									this.set_DataTuideo(num2, _Data.Type_Tui._Id, (object)num3);
									this.set_DataTuideo(num2, _Data.Type_Tui._Sl, (object)num4);
									this.set_DataTuideo(num2, _Data.Type_Tui._Doben, (object)num5);
								}
								else
								{
									this.set_DataTuideo(num2, _Data.Type_Tui._Id, (object)num3);
									int stt2;
									string sl;
									this.set_DataTuideo(stt2 = num2, sl = _Data.Type_Tui._Sl, Operators.AddObject(this.get_DataTuideo(stt2, sl), num4));
									this.set_DataTuideo(num2, _Data.Type_Tui._Doben, (object)num5);
								}
							}
							else
							{
								this.set_DataTuideo(num2, _Data.Type_Tui._Id, (object)num3);
								this.set_DataTuideo(num2, _Data.Type_Tui._Sl, (object)num4);
								this.set_DataTuideo(num2, _Data.Type_Tui._Doben, (object)num5);
							}
							text = text.Replace(API.bytestohexstring(array), "");
						}
						break;
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception ex4 = ex3;
						StackTrace stackTrace2 = new StackTrace(true);
						stackTrace2 = new StackTrace(ex4, true);
						API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - Update_Inventory2F] :" + ex4.Message + stackTrace2.GetFrame(0).GetFileLineNumber() + "\r\n");
						ProjectData.ClearProjectError();
						break;
					}
				case 49:
					try
					{
						int stt = packet[6];
						int num = packet[7];
						if (Operators.ConditionalCompareObjectLessEqual(Operators.SubtractObject(this.get_DataTuideo(stt, _Data.Type_Tui._Sl), num), 0, false))
						{
							this.set_DataTuideo(stt, _Data.Type_Tui._Id, (object)0);
							this.set_DataTuideo(stt, _Data.Type_Tui._Sl, (object)0);
						}
						else
						{
							this.set_DataTuideo(stt, _Data.Type_Tui._Sl, Operators.SubtractObject(this.get_DataTuideo(stt, _Data.Type_Tui._Sl), num));
						}
						break;
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						StackTrace stackTrace = new StackTrace(true);
						stackTrace = new StackTrace(ex2, true);
						API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - Update_Inventory31] :" + ex2.Message + stackTrace.GetFrame(0).GetFileLineNumber() + "\r\n");
						ProjectData.ClearProjectError();
						break;
					}
				}
			}
		}


		private void HandleGoldUpdate(byte[] packet)
		{
			checked
			{
				try
				{
					int num = Convert.ToInt32(API.bytestohexstring(new byte[4]
					{
						packet[9],
						packet[8],
						packet[7],
						packet[6]
					}), 16);
					switch (packet[5])
					{
					case 1:
						Data_Player._Gold += num;
						API.AddColorText2(this, Rtbsystem, "Kiếm được : " + Conversions.ToString(num) + " Vàng", Color.Gold);
						break;
					case 2:
						Data_Player._Gold -= num;
						API.AddColorText2(this, Rtbsystem, "Mất : " + Conversions.ToString(num) + " Vàng", Color.Gold);
						break;
					case 4:
						Data_Player._Gold = Convert.ToInt32(API.bytestohexstring(new byte[4]
						{
							packet[9],
							packet[8],
							packet[7],
							packet[6]
						}), 16);
						break;
					case 3:
						break;
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					StackTrace stackTrace = new StackTrace(true);
					stackTrace = new StackTrace(ex2, true);
					API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - Update_H1A] :" + ex2.Message + stackTrace.GetFrame(0).GetFileLineNumber() + "\r\n");
					ProjectData.ClearProjectError();
				}
			}
		}


		private void HandleItemTradeResult(byte[] packet)
		{
			try
			{
				switch (packet[5])
				{
				case 22:
					switch (packet[6])
					{
					case 2:
						API.AddColorText2(this, Rtbsystem, "Không thể gửi do người nhận không Online", Color.Red);
						Label_BDY = "Người nhận không Online";
						break;
					case 3:
						API.AddColorText2(this, Rtbsystem, "Không thể gửi do túi đồ của người nhận không còn chỗ trống", Color.Red);
						break;
					case 6:
						API.AddColorText2(this, Rtbsystem, "Không thể gửi do dữ liệu sai lệch", Color.Red);
						break;
					default:
						API.AddColorText2(this, Rtbsystem, "Không thể gửi đồ", Color.Red);
						break;
					}
					Label_BDY = "Không thể gửi BDY";
					_stt_send = 0;
					break;
				case 23:
				{
					int id = API.HexToInt32(API.bytestohexstring(packet).Substring(14, 8));
					int id2 = API.HexToInt32(API.bytestohexstring(packet).Substring(22, 4));
					int num = packet[13];
					switch (packet[6])
					{
					case 1:
						API.AddColorText2(this, Rtbsystem, "Đã nhận " + Conversions.ToString(num) + " " + GetItemName(id2) + " từ " + GetNamePlayer(id), Color.Blue);
						if (C_CheckBox_autosell)
						{
							int mapId = Data_Player._MapId;
							if (mapId == 12223)
							{
								ClickNPCId(99);
								ClickNPCId(1);
								ChoiceId(2);
								SendEnd();
								AutoSellItem();
								SendEnd();
								ClickNPCId(99);
							}
							else
							{
								atw = 1;
								AutoWarptoMap = "12223";
								AutoWarp(AutoWarptoMap);
							}
						}
						break;
					case 2:
						API.AddColorText2(this, Rtbsystem, "Đã gửi " + Conversions.ToString(num) + " " + GetItemName(id2) + " đến " + GetNamePlayer(id), Color.Orange);
						_stt_send = 0;
						Label_BDY = "Gửi Ba Đậu Yêu";
						if (_stt_send == 0)
						{
							_time_AutoSendBDY = 0;
							if (ProgressBarEx_BDY > 0)
							{
								ProgressBarEx_BDY = 0;
							}
							if (TextBox_AutoSend > 0)
							{
								AutoSendItem();
							}
						}
						break;
					}
					break;
				}
				case 41:
					SendPacket(API.hexstringtobyte("F44403001929" + (0x7B ^ _Value_Item_OnMap).ToString("X2")));
					break;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				StackTrace stackTrace = new StackTrace(true);
				stackTrace = new StackTrace(ex2, true);
				API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - Update_H19] :" + ex2.Message + stackTrace.GetFrame(0).GetFileLineNumber() + "\r\n");
				ProjectData.ClearProjectError();
			}
		}

	}
}
