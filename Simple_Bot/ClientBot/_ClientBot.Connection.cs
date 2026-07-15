using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Simple_Bot
{
	public partial class _ClientBot
	{
		public _ClientBot(TcpClient _s)
		{
			TreeView1 = new TreeView();
			Data_Players = new Dictionary<int, Listplayers._Player>();
			Data_Player = default(_Data._Player);
			Data_PetsInfo = new Dictionary<int, _Data._Pets>();
			Data_CharEquit = new Dictionary<int, _Data._CharEquit>();
			Data_PetEquit = new Dictionary<int, _Data._PetEquit>();
			Data_Tuido = new Dictionary<int, _Data._Tuido>();
			Data_Tuideo = new Dictionary<int, _Data._Tuideo>();
			Data_CharAttackSetting = default(_Data._AttackSetting);
			Data_PetAttackSetting = default(_Data._AttackSetting);
			Data_ListDrop = new ArrayList();
			Data_ListContribute = new ArrayList();
			Data_ListSend = new ArrayList();
			Data_ListSell = new ArrayList();
			Data_Battles = new Dictionary<int, _Data._Battleinfo>();
			Data_ItemOnMaps = new Dictionary<int, _Data._ItemOnMap>();
			Data_NpcInMap = new Dictionary<int, _Data._NpcInMap>();
			List_Npcs = new Dictionary<int, Npcs.NpcInfo>();
			List_Items = new Dictionary<int, Items.ItemInfo>();
			Data_CharListSkill = new ArrayList();
			Data_PetListSkill = new ArrayList();
			List_Shopping = 0;
			List_ShopItem = new Dictionary<int, Items.ShopItem>();
			List_ShopType = 1;
			List_ShopName = "Lam an nho";
			Deleted = 0;
			Setting_show = 0;
			battle_show = 0;
			Button_bot = true;
			_stt = 0;
			packetcount = 0;
			Disconnected = 1;
			_buffer = new byte[8192];
			port = 6414;
			clientSocket = new TcpClient();
			idlogin = 0;
			passlogin = "";
			logined = 0;
			delaylogin = 0;
			CharTurnSetting = 0;
			PetTurnSetting = 0;
			Online = "OFF";
			Status = "";
			BotWhenFinishAnswer = false;
			_MiniRuning = 0;
			_Mini_Status = "";
			packet_thua = "";
			packetAutoContribute = "";
			skillHoiSinh = 0;
			skilldaotau = 18001;
			createdchar = 0;
			skill_buonban = 0;
			REMOTE_DIS = false;
			Delay_REMOTE_DIS = 0;
			_Value_Item_OnMap = 0;
			_checkconnect = 4;
			_checkdisparty = 0;
			_checkdisExp = 0;
			_checkdisFullHomdo = 0;
			_loadconfig = "";
			_list_BDY = new List<int>(new int[14]
			{
				18022, 18023, 22002, 22003, 22004, 22005, 22028, 22029, 22032, 22033,
				22034, 22035, 22039, 41187
			});
			IDNgocEXP = new ArrayList(new int[3] { 40, 50, 60 });
			_disconected = 0;
			_BattleInfo_Update = 0;
			_BattleInfo_ExpChar = 0;
			_BattleInfo_ExpPet = 0;
			C_CheckBox_Reconnect = false;
			C_CheckBox_QuestProtect = false;
			C_CheckBox_autosell = false;
			C_CheckBox_TuLenNgua = false;
			C_CheckBox_Bee = false;
			C_CheckBox_AutoRevival = false;
			C_CheckBox_LeaderDissNotEnough = false;
			C_CheckBox_Char_ChangeTG = false;
			C_CheckBox_AutoFlee_Sp = false;
			C_CheckBox_AutoFlee_Party = false;
			C_CheckBox_Pet_ChangeTG = false;
			C_CheckBox_AutoClickNPC = false;
			C_CheckBox_AutoPickup = false;
			C_CheckBox_DropHp = false;
			C_CheckBox_DropSp = false;
			C_CheckBox_DropHpSp = false;
			C_CheckBox_DropMineWood = false;
			C_CheckBox_ContributeHp = false;
			C_CheckBox_ContributeSp = false;
			C_CheckBox_ContributeHpSp = false;
			C_CheckBox_ContributeMineWood = false;
			C_CheckBox_SendHp = false;
			C_CheckBox_SendSp = false;
			C_CheckBox_SendHpSp = false;
			C_CheckBox_SendMineWood = false;
			C_CheckBox_SellHp = false;
			C_CheckBox_SellSP = false;
			C_CheckBox_SellHpSp = false;
			C_CheckBox_SellMineWood = false;
			C_CheckBox_Pickup = false;
			C_RadioButton_QS1 = false;
			C_RadioButton_QS2 = false;
			C_RadioButton_QS3 = false;
			C_RadioButton_QS4 = false;
			C_CheckBox_AutoEquitExp = false;
			C_CheckBox_AutoUsePT = false;
			C_CheckBox_CatPet = false;
			C_CheckBox_ClearGhost = false;
			C_RadioButton_LeaderRequestParty = false;
			C_RadioButton_MemberRequestParty = false;
			C_RadioButton_PT_no = false;
			C_CheckBox_DCAfter1MinNoBattle = false;
			C_CheckBox_DisExp = false;
			C_RadioButton_DCLeaderOut = false;
			C_RadioButton_DCmemout = false;
			C_RadioButton_DC_no = false;
			C_CheckBox_AutoEat = false;
			C_CheckBox_TL_mem1 = false;
			C_CheckBox_TL_mem2 = false;
			C_CheckBox_TL_mem3 = false;
			C_CheckBox_TL_mem4 = false;
			C_CheckBox_TL_pet1 = false;
			C_CheckBox_TL_pet2 = false;
			C_CheckBox_AutoCreatCharacter = false;
			C_CheckBox_OpenMachine = false;
			C_RadioButton_dia = false;
			C_RadioButton_thuy = false;
			C_RadioButton_hoa = false;
			C_RadioButton_phong = false;
			C_CheckBox_Autosort = false;
			C_CheckBox_DCFullHomdo = false;
			ToolStripTextBox_KenhPassword = "";
			ComboBox_Server = "159.196.70.237";
			ComboBox_Port = 1;
			TextBox_RemoteDis = "";
			ComboBox_namePublic = "";
			TextBox_DelayBot = 0.2;
			TextBox_IDmem1 = 0;
			TextBox_IDmem2 = 0;
			TextBox_IDmem3 = 0;
			TextBox_IDmem4 = 0;
			TextBox_IdLeader = 0;
			TextBox_AutoSend = 0;
			ProgressBarEx_BDY = 0;
			TextBox_TL_pet_hp_value = 0;
			TextBox_TL_pet_sp_value = 0;
			TextBox_Eat_char_hp_value = 100;
			TextBox_Eat_char_sp_value = 100;
			TextBox_Eat_Pet_hp_value = 100;
			TextBox_Eat_Pet_sp_value = 100;
			TextBox_Drop_HpValue = 0;
			TextBox_Drop_SpValue = 0;
			TextBox_Contribute_HpValue = 0;
			TextBox_Contribute_SpValue = 0;
			TextBox_Send_HpValue = 0;
			TextBox_Send_SpValue = 0;
			TextBox_Sell_HpValue = 0;
			TextBox_Sell_SpValue = 0;
			TextBox_OpenMachine_CharHp = 0;
			TextBox_OpenMachine_CharSp = 0;
			TextBox_OpenMachine_PetHp = 0;
			TextBox_OpenMachine_PetSp = 0;
			NumericUpDown_ItemCountPickup = 0;
			TextBox_ValueSPFlee = 0;
			TextBox_ClickMOD = "";
			TextBox_ClickMOD_delay = 0;
			_IDmem1 = 0;
			_IDmem2 = 0;
			_IDmem3 = 0;
			_IDmem4 = 0;
			Label_BDY = "";
			StatusBarPanel_BattleCount = "";
			StatusBarPanel_checkbot = "0";
			StatusBarPanel_botreset = 0;
			Button_StartAutoQuest = "Bắt đầu";
			versionlogin = 3;
			_Status = "";
			Rtbsystem = new Dictionary<int, _Data._InfoText>();
			Rtbchat = new Dictionary<int, _Data._InfoText>();
			RtbBattle = new Dictionary<int, _Data._InfoText>();
			RtbQuest = new Dictionary<int, _Data._InfoText>();
			_id_rtbsystem = 0;
			_id_rtbChat = 0;
			_id_rtbBattle = 0;
			_id_rtbQuest = 0;
			_Check_CreatCharacter = false;
			_CreatCharacter_Name = "";
			_CreatCharacter_Sex = 1;
			_CreatCharacter_Thuoctinh = 1;
			_CreatCharacter_int = 0;
			_CreatCharacter_atk = 0;
			_CreatCharacter_def = 0;
			_CreatCharacter_hpx = 0;
			_CreatCharacter_spx = 0;
			_CreatCharacter_agi = 0;
			_CreatCharacter_Pass1 = "";
			_CreatCharacter_Pass2 = "";
			_AutoSelling = 0;
			_stt_send = 0;
			_Bee_X = 0;
			_Bee_Y = 0;
			_CuoiNgua = 0;
			_Antibot_ask = 0;
			_Antibot_str = "";
			timelogined = 0L;
			_time_AutoSendBDY_clone = 0L;
			_time_AutoSell_clone = 0L;
			listStart = new ArrayList();
			listEnd = new ArrayList();
			listWarp = new ArrayList();
			liststeprecquest = new ArrayList();
			ListAnswerBTQ = new ArrayList();
			packetbot = "";
			idmapbot = 0;
			bott = 0;
			_npctalking = "";
			Startautoquest = false;
			Step_sendend = 0;
			EndQuest = 0;
			DelayEndQuest = 0;
			DelayStepQuest = 0;
			showmenu = 0;
			_Questing = 0;
			battlecount = 0;
			DelayDisconnectNoBattle = 0;
			AutoClearGhost = false;
			Battle = 0;
			turn = 0;
			atw = 0;
			AutoWarptoMap = Conversions.ToString(0);
			BTQ = 0;
			_Ready = 0;
			_Proxy = false;
			_Proxy_Disconnect = false;
			this.m_a = new byte[8192];
			this.m_b = new byte[8192];
			this.m_c = "";
			this.m_d = "";
			this.m_e = 0;
			this.m_f = "";
			PlayerCount = 0;
			this.m_g = 0;
			this.m_h = 0;
			this.m_i = 0;
			this.m_j = 0;
			this.m_k = 0;
			this.m_l = 0;
			this.m_m = 0;
			this.m_n = 0;
			this.m_o = 0;
			this.m_p = 0;
			this.m_q = "";
			this.m_r = "";
			this.m_s = "";
			this.m_t = "";
			this.m_u = "";
			listquest_Done = new ArrayList();
			listquest_Doing = new ArrayList();
			this.m_v = 0;
			_MapX_Monster = 0;
			_MapY_Monster = 0;
			TreeView1 = new TreeView();
			NewLateBinding.LateCall(TreeView1.Nodes, null, "Add", new object[1] { MyProject.Forms.MainForm.treeview1.Nodes[0].Clone() }, null, null, null, true);
			TreeView1.Refresh();
			TreeView1.Nodes[0].Expand();
			CharTurnSetting = 1;
			PetTurnSetting = 1;
			int num = 1;
			checked
			{
				do
				{
					Data_Battles.Add(num, default(_Data._Battleinfo));
					num++;
				}
				while (num <= 20);
				int num2 = 1;
				do
				{
					_Data._Tuido value = new _Data._Tuido
					{
						_Stt = num2
					};
					Data_Tuido.Add(num2, value);
					_Data._Tuideo value2 = new _Data._Tuideo
					{
						_Stt = num2
					};
					Data_Tuideo.Add(num2, value2);
					num2++;
				}
				while (num2 <= 25);
				int num3 = 0;
				do
				{
					Data_PetsInfo.Add(num3, default(_Data._Pets));
					num3++;
				}
				while (num3 <= 4);
				int num4 = 0;
				do
				{
					Data_CharEquit.Add(num4, default(_Data._CharEquit));
					Data_PetEquit.Add(num4, default(_Data._PetEquit));
					num4++;
				}
				while (num4 <= 6);
				int num5 = 1;
				do
				{
					Data_ItemOnMaps.Add(num5, default(_Data._ItemOnMap));
					num5++;
				}
				while (num5 <= 255);
				Thread thread = new Thread(Running);
				thread.IsBackground = true;
				thread.Start();
				Thread thread2 = new Thread(AutoWalkToMonster);
				thread2.IsBackground = true;
				thread2.Start();
				_local = _s.GetStream();
				clientSocket = new TcpClient();
				ComboBox_Server = API.ServerIp;
				if (!API.List_Ip.Contains(API.ServerIp))
				{
					return;
				}
				try
				{
					API.AddColorText2(this, Rtbsystem, "Kết nối tới máy chủ " + ComboBox_Server, SystemColors.Highlight);
					clientSocket.Connect(ComboBox_Server, 6414);
					if (clientSocket.GetStream().CanRead)
					{
						_remote = clientSocket.GetStream();
						BeginPipeRead(_s.GetStream());
						BeginPipeRead(_remote);
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					_remote.Close();
					_local.Close();
					ProjectData.ClearProjectError();
				}
			}
		}

		private void BeginPipeRead(NetworkStream stream)
		{
			try
			{
				AsyncCallback asyncCallback = OnPipeReadComplete;
				if (stream.Equals(_local))
				{
					stream.BeginRead(this.m_b, 0, this.m_b.Length, OnPipeReadComplete, stream);
				}
				else
				{
					stream.BeginRead(this.m_a, 0, this.m_a.Length, OnPipeReadComplete, stream);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				_remote.Close();
				_local.Close();
				ProjectData.ClearProjectError();
			}
		}

		private void OnPipeReadComplete(IAsyncResult ar)
		{
			NetworkStream networkStream = (NetworkStream)ar.AsyncState;
			checked
			{
				try
				{
					int num = networkStream.EndRead(ar);
					if (num > 0)
					{
						if (networkStream.Equals(_local))
						{
							byte[] array = new byte[num - 1 + 1];
							int num2 = num - 1;
							for (int i = 0; i <= num2; i++)
							{
								array[i] = this.m_b[i];
							}
							ProcessLocalClientBytes(array);
						}
						else
						{
							byte[] array2 = new byte[num - 1 + 1];
							int num3 = num - 1;
							for (int j = 0; j <= num3; j++)
							{
								array2[j] = this.m_a[j];
							}
							ProcessRemoteServerBytes(array2);
						}
						BeginPipeRead(networkStream);
					}
					else
					{
						_Proxy_Disconnect = true;
						_remote.Close();
						_local.Close();
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					_remote.Close();
					_local.Close();
					ProjectData.ClearProjectError();
				}
			}
		}

		private void ProcessLocalClientBytes(byte[] data)
		{
			checked
			{
				try
				{
					string text = API.bytestohexstring(API.EncDec_byte(data)).Replace("F444", " F444");
					string[] array = text.Split(' ');
					for (int i = 0; i < array.Length; i++)
					{
						string text2 = array[i];
						text2 = text2.Replace(" ", "");
						if (!text2.StartsWith("F444"))
						{
							continue;
						}
						if (API.hexstringtobyte(text2).Length >= 4)
						{
							if (API.hexstringtobyte(text2).Length == 4 + Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								API.hexstringtobyte(text2)[3],
								API.hexstringtobyte(text2)[2]
							}), 16))
							{
								ProcessLocalToRemoteBytes(API.hexstringtobyte(text2));
							}
							else
							{
								this.m_d = text2;
							}
						}
						else
						{
							this.m_d = text2;
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - PipeRead] :" + ex2.Message + "\r\n");
					ProjectData.ClearProjectError();
				}
			}
		}

		private void ProcessRemoteServerBytes(byte[] data)
		{
			checked
			{
				try
				{
					string text = API.bytestohexstring(API.EncDec_byte(data)).Replace("F444", " F444");
					string[] array = text.Split(' ');
					for (int i = 0; i < array.Length; i++)
					{
						string text2 = array[i];
						text2 = text2.Replace(" ", "");
						if (!text2.StartsWith("F444"))
						{
							continue;
						}
						if (API.hexstringtobyte(text2).Length >= 4)
						{
							if (API.hexstringtobyte(text2).Length == 4 + Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								API.hexstringtobyte(text2)[3],
								API.hexstringtobyte(text2)[2]
							}), 16))
							{
								byte[] array2 = API.hexstringtobyte(text2);
								byte b = array2[4];
								if (b == 20)
								{
									if (array2.Length > 10)
									{
										byte b2 = array2[10];
										if (b2 == 5)
										{
											if ((atw == 0) & !Startautoquest)
											{
												byte[] array3 = API.hexstringtobyte("F444110014010000000201030D000000000000246D");
												array3[9] = array2[9];
												_local.Write(API.EncDec_byte(array3), 0, array3.Length);
											}
										}
										else if ((atw == 0) & !Startautoquest)
										{
											_local.Write(API.EncDec_byte(array2), 0, array2.Length);
										}
									}
									else if ((atw == 0) & !Startautoquest)
									{
										_local.Write(API.EncDec_byte(array2), 0, array2.Length);
									}
								}
								else
								{
									_local.Write(API.EncDec_byte(array2), 0, array2.Length);
								}
								DispatchPacket(array2);
							}
							else
							{
								this.m_c = text2;
							}
						}
						else
						{
							this.m_c = text2;
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - PipeRead] :" + ex2.Message + "\r\n");
					ProjectData.ClearProjectError();
				}
			}
		}

		public void _Local_SendPacket(byte[] packet)
		{
			try
			{
				_local.Write(API.EncDec_byte(packet), 0, packet.Length);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				StackTrace stackTrace = new StackTrace(true);
				stackTrace = new StackTrace(ex2, true);
				API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - SendPacket] :" + ex2.Message + stackTrace.GetFrame(0).GetFileLineNumber() + "\r\n");
				ProjectData.ClearProjectError();
			}
		}

		private void ProcessLocalToRemoteBytes(byte[] data)
		{
			byte b = data[4];
			if (b == 1)
			{
				int num = API.BytesToInt32(new byte[4]
				{
					data[6],
					data[7],
					data[8],
					data[9]
				});
				idlogin = num;
				_remote.Write(API.EncDec_byte(data), 0, data.Length);
			}
			else
			{
				_remote.Write(API.EncDec_byte(data), 0, data.Length);
			}
		}

		public _ClientBot()
		{
			TreeView1 = new TreeView();
			Data_Players = new Dictionary<int, Listplayers._Player>();
			Data_Player = default(_Data._Player);
			Data_PetsInfo = new Dictionary<int, _Data._Pets>();
			Data_CharEquit = new Dictionary<int, _Data._CharEquit>();
			Data_PetEquit = new Dictionary<int, _Data._PetEquit>();
			Data_Tuido = new Dictionary<int, _Data._Tuido>();
			Data_Tuideo = new Dictionary<int, _Data._Tuideo>();
			Data_CharAttackSetting = default(_Data._AttackSetting);
			Data_PetAttackSetting = default(_Data._AttackSetting);
			Data_ListDrop = new ArrayList();
			Data_ListContribute = new ArrayList();
			Data_ListSend = new ArrayList();
			Data_ListSell = new ArrayList();
			Data_Battles = new Dictionary<int, _Data._Battleinfo>();
			Data_ItemOnMaps = new Dictionary<int, _Data._ItemOnMap>();
			Data_NpcInMap = new Dictionary<int, _Data._NpcInMap>();
			List_Npcs = new Dictionary<int, Npcs.NpcInfo>();
			List_Items = new Dictionary<int, Items.ItemInfo>();
			Data_CharListSkill = new ArrayList();
			Data_PetListSkill = new ArrayList();
			List_Shopping = 0;
			List_ShopItem = new Dictionary<int, Items.ShopItem>();
			List_ShopType = 1;
			List_ShopName = "Lam an nho";
			Deleted = 0;
			Setting_show = 0;
			battle_show = 0;
			Button_bot = true;
			_stt = 0;
			packetcount = 0;
			Disconnected = 1;
			_buffer = new byte[8192];
			port = 6414;
			clientSocket = new TcpClient();
			idlogin = 0;
			passlogin = "";
			logined = 0;
			delaylogin = 0;
			CharTurnSetting = 0;
			PetTurnSetting = 0;
			Online = "OFF";
			Status = "";
			BotWhenFinishAnswer = false;
			_MiniRuning = 0;
			_Mini_Status = "";
			packet_thua = "";
			packetAutoContribute = "";
			skillHoiSinh = 0;
			skilldaotau = 18001;
			createdchar = 0;
			skill_buonban = 0;
			REMOTE_DIS = false;
			Delay_REMOTE_DIS = 0;
			_Value_Item_OnMap = 0;
			_checkconnect = 4;
			_checkdisparty = 0;
			_checkdisExp = 0;
			_checkdisFullHomdo = 0;
			_loadconfig = "";
			_list_BDY = new List<int>(new int[14]
			{
				18022, 18023, 22002, 22003, 22004, 22005, 22028, 22029, 22032, 22033,
				22034, 22035, 22039, 41187
			});
			IDNgocEXP = new ArrayList(new int[3] { 40, 50, 60 });
			_disconected = 0;
			_BattleInfo_Update = 0;
			_BattleInfo_ExpChar = 0;
			_BattleInfo_ExpPet = 0;
			C_CheckBox_Reconnect = false;
			C_CheckBox_QuestProtect = false;
			C_CheckBox_autosell = false;
			C_CheckBox_TuLenNgua = false;
			C_CheckBox_Bee = false;
			C_CheckBox_AutoRevival = false;
			C_CheckBox_LeaderDissNotEnough = false;
			C_CheckBox_Char_ChangeTG = false;
			C_CheckBox_AutoFlee_Sp = false;
			C_CheckBox_AutoFlee_Party = false;
			C_CheckBox_Pet_ChangeTG = false;
			C_CheckBox_AutoClickNPC = false;
			C_CheckBox_AutoPickup = false;
			C_CheckBox_DropHp = false;
			C_CheckBox_DropSp = false;
			C_CheckBox_DropHpSp = false;
			C_CheckBox_DropMineWood = false;
			C_CheckBox_ContributeHp = false;
			C_CheckBox_ContributeSp = false;
			C_CheckBox_ContributeHpSp = false;
			C_CheckBox_ContributeMineWood = false;
			C_CheckBox_SendHp = false;
			C_CheckBox_SendSp = false;
			C_CheckBox_SendHpSp = false;
			C_CheckBox_SendMineWood = false;
			C_CheckBox_SellHp = false;
			C_CheckBox_SellSP = false;
			C_CheckBox_SellHpSp = false;
			C_CheckBox_SellMineWood = false;
			C_CheckBox_Pickup = false;
			C_RadioButton_QS1 = false;
			C_RadioButton_QS2 = false;
			C_RadioButton_QS3 = false;
			C_RadioButton_QS4 = false;
			C_CheckBox_AutoEquitExp = false;
			C_CheckBox_AutoUsePT = false;
			C_CheckBox_CatPet = false;
			C_CheckBox_ClearGhost = false;
			C_RadioButton_LeaderRequestParty = false;
			C_RadioButton_MemberRequestParty = false;
			C_RadioButton_PT_no = false;
			C_CheckBox_DCAfter1MinNoBattle = false;
			C_CheckBox_DisExp = false;
			C_RadioButton_DCLeaderOut = false;
			C_RadioButton_DCmemout = false;
			C_RadioButton_DC_no = false;
			C_CheckBox_AutoEat = false;
			C_CheckBox_TL_mem1 = false;
			C_CheckBox_TL_mem2 = false;
			C_CheckBox_TL_mem3 = false;
			C_CheckBox_TL_mem4 = false;
			C_CheckBox_TL_pet1 = false;
			C_CheckBox_TL_pet2 = false;
			C_CheckBox_AutoCreatCharacter = false;
			C_CheckBox_OpenMachine = false;
			C_RadioButton_dia = false;
			C_RadioButton_thuy = false;
			C_RadioButton_hoa = false;
			C_RadioButton_phong = false;
			C_CheckBox_Autosort = false;
			C_CheckBox_DCFullHomdo = false;
			ToolStripTextBox_KenhPassword = "";
			ComboBox_Server = "159.196.70.237";
			ComboBox_Port = 1;
			TextBox_RemoteDis = "";
			ComboBox_namePublic = "";
			TextBox_DelayBot = 0.2;
			TextBox_IDmem1 = 0;
			TextBox_IDmem2 = 0;
			TextBox_IDmem3 = 0;
			TextBox_IDmem4 = 0;
			TextBox_IdLeader = 0;
			TextBox_AutoSend = 0;
			ProgressBarEx_BDY = 0;
			TextBox_TL_pet_hp_value = 0;
			TextBox_TL_pet_sp_value = 0;
			TextBox_Eat_char_hp_value = 100;
			TextBox_Eat_char_sp_value = 100;
			TextBox_Eat_Pet_hp_value = 100;
			TextBox_Eat_Pet_sp_value = 100;
			TextBox_Drop_HpValue = 0;
			TextBox_Drop_SpValue = 0;
			TextBox_Contribute_HpValue = 0;
			TextBox_Contribute_SpValue = 0;
			TextBox_Send_HpValue = 0;
			TextBox_Send_SpValue = 0;
			TextBox_Sell_HpValue = 0;
			TextBox_Sell_SpValue = 0;
			TextBox_OpenMachine_CharHp = 0;
			TextBox_OpenMachine_CharSp = 0;
			TextBox_OpenMachine_PetHp = 0;
			TextBox_OpenMachine_PetSp = 0;
			NumericUpDown_ItemCountPickup = 0;
			TextBox_ValueSPFlee = 0;
			TextBox_ClickMOD = "";
			TextBox_ClickMOD_delay = 0;
			_IDmem1 = 0;
			_IDmem2 = 0;
			_IDmem3 = 0;
			_IDmem4 = 0;
			Label_BDY = "";
			StatusBarPanel_BattleCount = "";
			StatusBarPanel_checkbot = "0";
			StatusBarPanel_botreset = 0;
			Button_StartAutoQuest = "Bắt đầu";
			versionlogin = 3;
			_Status = "";
			Rtbsystem = new Dictionary<int, _Data._InfoText>();
			Rtbchat = new Dictionary<int, _Data._InfoText>();
			RtbBattle = new Dictionary<int, _Data._InfoText>();
			RtbQuest = new Dictionary<int, _Data._InfoText>();
			_id_rtbsystem = 0;
			_id_rtbChat = 0;
			_id_rtbBattle = 0;
			_id_rtbQuest = 0;
			_Check_CreatCharacter = false;
			_CreatCharacter_Name = "";
			_CreatCharacter_Sex = 1;
			_CreatCharacter_Thuoctinh = 1;
			_CreatCharacter_int = 0;
			_CreatCharacter_atk = 0;
			_CreatCharacter_def = 0;
			_CreatCharacter_hpx = 0;
			_CreatCharacter_spx = 0;
			_CreatCharacter_agi = 0;
			_CreatCharacter_Pass1 = "";
			_CreatCharacter_Pass2 = "";
			_AutoSelling = 0;
			_stt_send = 0;
			_Bee_X = 0;
			_Bee_Y = 0;
			_CuoiNgua = 0;
			_Antibot_ask = 0;
			_Antibot_str = "";
			timelogined = 0L;
			_time_AutoSendBDY_clone = 0L;
			_time_AutoSell_clone = 0L;
			listStart = new ArrayList();
			listEnd = new ArrayList();
			listWarp = new ArrayList();
			liststeprecquest = new ArrayList();
			ListAnswerBTQ = new ArrayList();
			packetbot = "";
			idmapbot = 0;
			bott = 0;
			_npctalking = "";
			Startautoquest = false;
			Step_sendend = 0;
			EndQuest = 0;
			DelayEndQuest = 0;
			DelayStepQuest = 0;
			showmenu = 0;
			_Questing = 0;
			battlecount = 0;
			DelayDisconnectNoBattle = 0;
			AutoClearGhost = false;
			Battle = 0;
			turn = 0;
			atw = 0;
			AutoWarptoMap = Conversions.ToString(0);
			BTQ = 0;
			_Ready = 0;
			_Proxy = false;
			_Proxy_Disconnect = false;
			this.m_a = new byte[8192];
			this.m_b = new byte[8192];
			this.m_c = "";
			this.m_d = "";
			this.m_e = 0;
			this.m_f = "";
			PlayerCount = 0;
			this.m_g = 0;
			this.m_h = 0;
			this.m_i = 0;
			this.m_j = 0;
			this.m_k = 0;
			this.m_l = 0;
			this.m_m = 0;
			this.m_n = 0;
			this.m_o = 0;
			this.m_p = 0;
			this.m_q = "";
			this.m_r = "";
			this.m_s = "";
			this.m_t = "";
			this.m_u = "";
			listquest_Done = new ArrayList();
			listquest_Doing = new ArrayList();
			this.m_v = 0;
			_MapX_Monster = 0;
			_MapY_Monster = 0;
			NewLateBinding.LateCall(TreeView1.Nodes, null, "Add", new object[1] { MyProject.Forms.MainForm.treeview1.Nodes[0].Clone() }, null, null, null, true);
			TreeView1.Refresh();
			TreeView1.Nodes[0].Expand();
			CharTurnSetting = 1;
			PetTurnSetting = 1;
			int num = 1;
			checked
			{
				do
				{
					Data_Battles.Add(num, default(_Data._Battleinfo));
					num++;
				}
				while (num <= 20);
				int num2 = 1;
				do
				{
					_Data._Tuido value = new _Data._Tuido
					{
						_Stt = num2
					};
					Data_Tuido.Add(num2, value);
					_Data._Tuideo value2 = new _Data._Tuideo
					{
						_Stt = num2
					};
					Data_Tuideo.Add(num2, value2);
					num2++;
				}
				while (num2 <= 25);
				int num3 = 0;
				do
				{
					Data_PetsInfo.Add(num3, default(_Data._Pets));
					num3++;
				}
				while (num3 <= 4);
				int num4 = 0;
				do
				{
					Data_CharEquit.Add(num4, default(_Data._CharEquit));
					Data_PetEquit.Add(num4, default(_Data._PetEquit));
					num4++;
				}
				while (num4 <= 6);
				int num5 = 1;
				do
				{
					Data_ItemOnMaps.Add(num5, default(_Data._ItemOnMap));
					num5++;
				}
				while (num5 <= 255);
				Thread thread = new Thread(Running);
				thread.IsBackground = true;
				thread.Start();
				Thread thread2 = new Thread(AutoWalkToMonster);
				thread2.IsBackground = true;
				thread2.Start();
			}
		}

		public void SendPacket(byte[] packet)
		{
			try
			{
				if (clientSocket.Connected)
				{
					byte[] array = API.EncDec_byte(packet);
					clientSocket.GetStream().Write(array, 0, array.Length);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				StackTrace stackTrace = new StackTrace(true);
				stackTrace = new StackTrace(ex2, true);
				API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - SendPacket] :" + ex2.Message + stackTrace.GetFrame(0).GetFileLineNumber() + "\r\n");
				ProjectData.ClearProjectError();
			}
		}

		public void _Connect()
		{
			_checkconnect = 0;
			checked
			{
				try
				{
					if (Deleted == 1)
					{
						return;
					}
					Data_CharListSkill.Clear();
					if (this.m_e == 1)
					{
						return;
					}
					this.m_e = 1;
					Disconnected = 0;
					clientSocket = new TcpClient();
					API.AddColorText2(this, Rtbsystem, "Kết nối tới máy chủ " + ComboBox_Server, SystemColors.Highlight);
					this.m_f = "";
					try
					{
						clientSocket.Connect(ComboBox_Server, ComboBox_Port);
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						API.SaveToLog(ex2.Message + "\r\n");
						ProjectData.ClearProjectError();
					}
					if (!clientSocket.GetStream().CanRead)
					{
						return;
					}
					API.AddColorText2(this, Rtbsystem, "Kết nối thành công đến máy chủ!", Color.Red);
					string text = "F444010000";
					if ((ComboBox_Port > 10) & (ComboBox_Port < 100))
					{
						string text2 = "";
						string toolStripTextBox_KenhPassword = ToolStripTextBox_KenhPassword;
						int num = toolStripTextBox_KenhPassword.Length - 1;
						for (int i = 0; i <= num; i++)
						{
							text2 += Strings.Asc(toolStripTextBox_KenhPassword.Substring(i, 1)).ToString("X2");
						}
						text = "F444" + API.Int32ToHex2(2 + toolStripTextBox_KenhPassword.Length) + "00" + toolStripTextBox_KenhPassword.Length.ToString("X2") + text2;
					}
					byte[] array = API.EncDec_byte(API.hexstringtobyte(text));
					clientSocket.GetStream().Write(array, 0, array.Length);
					clientSocket.GetStream().BeginRead(_buffer, 0, _buffer.Length, OnRecieve, clientSocket.GetStream());
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					API.AddColorText2(this, Rtbsystem, "không kết nối được đến máy chủ!", Color.Red);
					_Disconnect();
					ProjectData.ClearProjectError();
				}
			}
		}

		public void _Disconnect()
		{
			checked
			{
				if (logined == 1)
				{
					Data_Players = new Dictionary<int, Listplayers._Player>();
					Data_Player = default(_Data._Player);
					Data_PetInfo = default(_Data._Pets);
					int num = 1;
					do
					{
						Data_Battles[num] = default(_Data._Battleinfo);
						num++;
					}
					while (num <= 20);
					int num2 = 1;
					do
					{
						_Data._Tuido value = new _Data._Tuido
						{
							_Stt = num2
						};
						Data_Tuido[num2] = value;
						_Data._Tuideo value2 = new _Data._Tuideo
						{
							_Stt = num2
						};
						Data_Tuideo[num2] = value2;
						num2++;
					}
					while (num2 <= 25);
					int num3 = 0;
					do
					{
						Data_PetsInfo[num3] = default(_Data._Pets);
						num3++;
					}
					while (num3 <= 4);
					int num4 = 0;
					do
					{
						Data_CharEquit[num4] = default(_Data._CharEquit);
						Data_PetEquit[num4] = default(_Data._PetEquit);
						num4++;
					}
					while (num4 <= 5);
				}
				List_Shopping = 0;
				skill_buonban = 0;
				atw = 0;
				Battle = 0;
				_Questing = 0;
				logined = 0;
				packetcount = 0;
				Disconnected = 1;
				this.m_e = 0;
				_IDmem1 = 0;
				_IDmem2 = 0;
				_IDmem3 = 0;
				_IDmem4 = 0;
				Online = "OFF";
				Status = "Đã ngắt kết nối!!!";
				if (listquest_Done.Count > 0)
				{
					listquest_Done.Clear();
				}
				if (listquest_Doing.Count > 0)
				{
					listquest_Doing.Clear();
				}
				_CuoiNgua = 0;
				Data_Player._LeaderId = 0;
				Startautoquest = false;
				Step_sendend = 0;
				EndQuest = 0;
				DelayEndQuest = 0;
				DelayStepQuest = 0;
				showmenu = 0;
				try
				{
					try
					{
						clientSocket.Close();
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ProjectData.ClearProjectError();
					}
					try
					{
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception ex4 = ex3;
						ProjectData.ClearProjectError();
					}
				}
				catch (Exception ex5)
				{
					ProjectData.SetProjectError(ex5);
					Exception ex6 = ex5;
					StackTrace stackTrace = new StackTrace(true);
					stackTrace = new StackTrace(ex6, true);
					API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - Disconnect] :" + ex6.Message + stackTrace.GetFrame(0).GetFileLineNumber() + "\r\n");
					ProjectData.ClearProjectError();
				}
			}
		}

		private void SendLoginPacket(int version, int accountId, string password)
		{
			checked
			{
				if (!_Proxy)
				{
					string text = API.Int32ToHex4(accountId);
					string text2 = API.Int32ToHex2(version);
					string text3 = "";
					int num = password.Length - 1;
					for (int i = 0; i <= num; i++)
					{
						text3 += Strings.Asc(password.Substring(i, 1)).ToString("X2");
					}
					byte[] bytes = new byte[2];
					string text4 = "F444" + API.Int32ToHex2(10 + password.Length) + "01" + password.Length.ToString("X2") + text + API.bytestohexstring(bytes) + text2 + text3;
					SendPacket(API.hexstringtobyte(text4));
				}
			}
		}

		public void OnRecieve(IAsyncResult ar)
		{
			checked
			{
				try
				{
					NetworkStream networkStream = (NetworkStream)ar.AsyncState;
					int num = networkStream.EndRead(ar);
					if (num > 0)
					{
						packetcount++;
						Array.Resize(ref _buffer, num);
						OnRecievepacket(_buffer);
						Array.Resize(ref _buffer, 8192);
					}
					else
					{
						API.AddColorText2(this, Rtbsystem, "mất kết nối được từ máy chủ!", Color.Red);
						_Disconnect();
					}
					try
					{
						networkStream.BeginRead(_buffer, 0, _buffer.Length, OnRecieve, networkStream);
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						API.AddColorText2(this, Rtbsystem, "mất kết nối được từ máy chủ(2)!", Color.Red);
						_Disconnect();
						ProjectData.ClearProjectError();
					}
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					API.AddColorText2(this, Rtbsystem, "mất kết nối được từ máy chủ(3)!", Color.Red);
					_Disconnect();
					StackTrace stackTrace = new StackTrace(true);
					stackTrace = new StackTrace(ex4, true);
					API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - OnRecieve] :" + ex4.Message + stackTrace.GetFrame(0).GetFileLineNumber() + "\r\n");
					ProjectData.ClearProjectError();
				}
			}
		}

		public void OnRecievepacket(byte[] packet)
		{
			checked
			{
				try
				{
					string text = API.bytestohexstring(API.EncDec_byte(packet));
					if (this.m_f.Length > 0)
					{
						text = this.m_f + text;
						this.m_f = "";
					}
					text = text.Replace("F444", "#F444");
					string[] array = text.Split(new string[1] { "#" }, StringSplitOptions.None);
					for (int i = 0; i < array.Length; i++)
					{
						string text2 = array[i];
						try
						{
							if (this.m_f.Length > 0)
							{
								text2 = this.m_f + text2;
								this.m_f = "";
							}
							if (!text2.StartsWith("F444"))
							{
								continue;
							}
							if (text2.Length >= 8)
							{
								int num = API.HexToInt32(text2.Substring(4, 4));
								if (text2.Length >= 8 + num * 2)
								{
									DispatchPacket(API.hexstringtobyte(text2));
								}
								else if (text2.Length < 8 + num * 2)
								{
									this.m_f = text2;
								}
							}
							else
							{
								this.m_f = text2;
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
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					ProjectData.ClearProjectError();
				}
			}
		}
	}
}
