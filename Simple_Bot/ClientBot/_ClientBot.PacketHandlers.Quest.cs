using System;
using System.Diagnostics;
using System.Drawing;
using Microsoft.VisualBasic.CompilerServices;

namespace Simple_Bot
{
	public partial class _ClientBot
	{
		private void HandleBtqQuizPrompt(byte[] packet)
		{
			checked
			{
				try
				{
					byte b = packet[5];
					if (b == 1)
					{
						ListAnswerBTQ.Clear();
						BTQ = 1;
						string text = API.bytestohexstring(packet).Substring(12);
						string text2 = text.Substring(0, 2 + API.hexstringtobyte(text)[0] * 2);
						byte[] questionBytes = API.hexstringtobyte(text2.Substring(2));
						text = text.Replace(text2, "");
						string text3 = text.Substring(0, 2 + API.hexstringtobyte(text)[0] * 2);
						byte[] array = API.hexstringtobyte(text3.Substring(2));
						ListAnswerBTQ.Add(array);
						text = text.Replace(text3, "");
						string text4 = text.Substring(0, 2 + API.hexstringtobyte(text)[0] * 2);
						byte[] array2 = API.hexstringtobyte(text4.Substring(2));
						ListAnswerBTQ.Add(array2);
						text = text.Replace(text4, "");
						string text5 = text.Substring(0, 2 + API.hexstringtobyte(text)[0] * 2);
						byte[] array3 = API.hexstringtobyte(text5.Substring(2));
						ListAnswerBTQ.Add(array3);
						text = text.Replace(text5, "");
						string text6 = text;
						byte[] array4 = API.hexstringtobyte(text6);
						ListAnswerBTQ.Add(array4);
						API.AddColorText2(this, Rtbsystem, "***************Gặp Bắc Tinh Quân***************\r\n" + API.VISCII_to_Unicode(API.HexToChar(questionBytes)) + "\r\n1. " + API.HexToChar(array) + "\r\n2. " + API.HexToChar(array2) + "\r\n3. " + API.HexToChar(array3) + "\r\n4. " + API.HexToChar(array4), Color.Blue);
						if (Battle != 0)
						{
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					StackTrace stackTrace = new StackTrace(true);
					stackTrace = new StackTrace(ex2, true);
					API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - Update_H10] :" + ex2.Message + stackTrace.GetFrame(0).GetFileLineNumber() + "\r\n");
					ProjectData.ClearProjectError();
				}
			}
		}


		private void HandleQuestDialogState(byte[] packet)
		{
			checked
			{
				try
				{
					switch (packet[5])
					{
					case 1:
						if (packet[10] != 6)
						{
							_Questing = 1;
							showmenu = 0;
							ushort a_ = (ushort)Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								packet[20],
								packet[19]
							}), 16);
							HandleQuestDialogText(a_);
						}
						else if (packet[10] == 6)
						{
							ushort a_2 = (ushort)Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								packet[20],
								packet[19]
							}), 16);
							HandleQuestDialogMenu(a_2);
						}
						break;
					case 7:
						_Questing = 0;
						break;
					case 8:
						_Questing = 0;
						if (showmenu == 0)
						{
							showmenu = 2;
						}
						break;
					case 13:
						if (atw == 1)
						{
							SendEnd();
						}
						break;
					case 16:
						if (atw == 1)
						{
							SendEnd();
						}
						break;
					case 17:
						SendEnd();
						break;
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					StackTrace stackTrace = new StackTrace(true);
					stackTrace = new StackTrace(ex2, true);
					API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - Update_H14] :" + ex2.Message + stackTrace.GetFrame(0).GetFileLineNumber() + "\r\n");
					ProjectData.ClearProjectError();
				}
			}
		}


		private void HandleQuestProgress(byte[] packet)
		{
			try
			{
				switch (packet[5])
				{
				case 1:
				{
					int num2 = Convert.ToInt32(API.bytestohexstring(new byte[2]
					{
						packet[7],
						packet[6]
					}), 16);
					listquest_Doing.Add(num2);
					listquest_Doing.Sort();
					break;
				}
				case 5:
				{
					int key = Convert.ToInt32(API.bytestohexstring(new byte[2]
					{
						packet[7],
						packet[6]
					}), 16);
					if (Ground.Data_Marks.ContainsKey(key))
					{
						int num = Ground.Data_Marks[key];
						listquest_Done.Add(num);
						listquest_Done.Sort();
					}
					break;
				}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				StackTrace stackTrace = new StackTrace(true);
				stackTrace = new StackTrace(ex2, true);
				API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - Update_H18] :" + ex2.Message + stackTrace.GetFrame(0).GetFileLineNumber() + "\r\n");
				ProjectData.ClearProjectError();
			}
		}


		private void HandleQuestDialogText(ushort dialogId)
		{
			if (Startautoquest)
			{
				if (talk.Data_Talks.ContainsKey(dialogId))
				{
					talk.Talks talks = talk.Data_Talks[dialogId];
					API.AddColorText_Quest(this, RtbQuest, _npctalking, API.VISCII_to_Unicode(talk._Get_Talk_String(talks)), Color.Blue);
				}
				SendEnd();
			}
			if (bott == 0)
			{
				API.AddColorText2(this, Rtbsystem, "Dialog Id : " + dialogId, Color.Blue);
			}
			if (AutoClearGhost)
			{
				SendEnd();
			}
			if (atw == 1)
			{
				SendEnd();
			}
		}


		private void HandleQuestDialogMenu(ushort dialogId)
		{
			checked
			{
				if (Startautoquest)
				{
					talkmenu.Key_talkmenu key = new talkmenu.Key_talkmenu
					{
						_Idmap = Data_Player._MapId,
						_id = dialogId
					};
					if (talkmenu.Data_talkmenu.ContainsKey(key))
					{
						talkmenu._talkmenu talkmenu2 = talkmenu.Data_talkmenu[key];
						string text = "";
						int num = talkmenu2._Talks.Count - 1;
						for (int i = 0; i <= num; i++)
						{
							string text2 = talk._Get_Talk_String(talk.Data_Talks[Conversions.ToInteger(talkmenu2._Talks[i])]);
							int num2 = i;
							if (num2 == 0)
							{
								text = text2;
							}
							else if (num2 == talkmenu2._Talks.Count - 1)
							{
								text = "0. " + text2;
							}
							else
							{
								switch (num2)
								{
								case 1:
									text = "1. " + text2;
									break;
								case 2:
									text = "2. " + text2;
									break;
								case 3:
									text = "3. " + text2;
									break;
								case 4:
									text = "4. " + text2;
									break;
								case 5:
									text = "5. " + text2;
									break;
								case 6:
									text = "6. " + text2;
									break;
								case 7:
									text = "7. " + text2;
									break;
								default:
									text = text + "\r\n[" + text2 + "]";
									break;
								}
							}
							API.AddColorText_QuestMenu(this, RtbQuest, _npctalking, API.VISCII_to_Unicode(text), Color.Purple);
						}
					}
				}
				showmenu = 1;
				if (bott == 0)
				{
					API.AddColorText2(this, Rtbsystem, "Dialog Menu Id : " + dialogId, Color.Blue);
				}
			}
		}

	}
}
