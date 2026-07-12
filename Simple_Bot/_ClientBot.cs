using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Simple_Bot
{
	public class _ClientBot
	{
		public TreeView TreeView1;

		public Dictionary<int, Listplayers._Player> Data_Players;

		public _Data._Player Data_Player;

		public Dictionary<int, _Data._Pets> Data_PetsInfo;

		public Dictionary<int, _Data._CharEquit> Data_CharEquit;

		public Dictionary<int, _Data._PetEquit> Data_PetEquit;

		public Dictionary<int, _Data._Tuido> Data_Tuido;

		public Dictionary<int, _Data._Tuideo> Data_Tuideo;

		public _Data._AttackSetting Data_CharAttackSetting;

		public _Data._AttackSetting Data_PetAttackSetting;

		public ArrayList Data_ListDrop;

		public ArrayList Data_ListContribute;

		public ArrayList Data_ListSend;

		public ArrayList Data_ListSell;

		public Dictionary<int, _Data._Battleinfo> Data_Battles;

		public Dictionary<int, _Data._ItemOnMap> Data_ItemOnMaps;

		public Dictionary<int, _Data._NpcInMap> Data_NpcInMap;

		public Dictionary<int, Npcs.NpcInfo> List_Npcs;

		public Dictionary<int, Items.ItemInfo> List_Items;

		public ArrayList Data_CharListSkill;

		public ArrayList Data_PetListSkill;

		public int List_Shopping;

		public Dictionary<int, Items.ShopItem> List_ShopItem;

		public int List_ShopType;

		public string List_ShopName;

		public int Deleted;

		public int Setting_show;

		public int battle_show;

		public bool Button_bot;

		public int _stt;

		public int packetcount;

		public int Disconnected;

		public byte[] _buffer;

		public int port;

		public TcpClient clientSocket;

		public int idlogin;

		public string passlogin;

		public int logined;

		public int delaylogin;

		public int CharTurnSetting;

		public int PetTurnSetting;

		public string Online;

		public string Status;

		public bool BotWhenFinishAnswer;

		public int MapID_Clear;

		public int MapX_Clear;

		public int MapY_Clear;

		public int NpcID_Clear;

		public int MapID_Back;

		public int MapX_Back;

		public int MapY_Back;

		public int _MiniRuning;

		public string _Mini_Status;

		public string packet_thua;

		public string packetAutoContribute;

		public int skillHoiSinh;

		public int skilldaotau;

		public int createdchar;

		public int skill_buonban;

		public bool REMOTE_DIS;

		public int Delay_REMOTE_DIS;

		public int _Value_Item_OnMap;

		public int _checkconnect;

		public int _checkdisparty;

		public int _checkdisExp;

		public int _checkdisFullHomdo;

		public string _loadconfig;

		public List<int> _list_BDY;

		public ArrayList IDNgocEXP;

		public int _disconected;

		public int _BattleInfo_Update;

		public int _BattleInfo_ExpChar;

		public int _BattleInfo_ExpPet;

		public bool C_CheckBox_Reconnect;

		public bool C_CheckBox_QuestProtect;

		public bool C_CheckBox_autosell;

		public bool C_CheckBox_TuLenNgua;

		public bool C_CheckBox_Bee;

		public bool C_CheckBox_AutoRevival;

		public bool C_CheckBox_LeaderDissNotEnough;

		public bool C_CheckBox_Char_ChangeTG;

		public bool C_CheckBox_AutoFlee_Sp;

		public bool C_CheckBox_AutoFlee_Party;

		public bool C_CheckBox_Pet_ChangeTG;

		public bool C_CheckBox_AutoClickNPC;

		public bool C_CheckBox_AutoPickup;

		public bool C_CheckBox_DropHp;

		public bool C_CheckBox_DropSp;

		public bool C_CheckBox_DropHpSp;

		public bool C_CheckBox_DropMineWood;

		public bool C_CheckBox_ContributeHp;

		public bool C_CheckBox_ContributeSp;

		public bool C_CheckBox_ContributeHpSp;

		public bool C_CheckBox_ContributeMineWood;

		public bool C_CheckBox_SendHp;

		public bool C_CheckBox_SendSp;

		public bool C_CheckBox_SendHpSp;

		public bool C_CheckBox_SendMineWood;

		public bool C_CheckBox_SellHp;

		public bool C_CheckBox_SellSP;

		public bool C_CheckBox_SellHpSp;

		public bool C_CheckBox_SellMineWood;

		public bool C_CheckBox_Pickup;

		public bool C_RadioButton_QS1;

		public bool C_RadioButton_QS2;

		public bool C_RadioButton_QS3;

		public bool C_RadioButton_QS4;

		public bool C_CheckBox_AutoEquitExp;

		public bool C_CheckBox_AutoUsePT;

		public bool C_CheckBox_CatPet;

		public bool C_CheckBox_ClearGhost;

		public bool C_RadioButton_LeaderRequestParty;

		public bool C_RadioButton_MemberRequestParty;

		public bool C_RadioButton_PT_no;

		public bool C_CheckBox_DCAfter1MinNoBattle;

		public bool C_CheckBox_DisExp;

		public bool C_RadioButton_DCLeaderOut;

		public bool C_RadioButton_DCmemout;

		public bool C_RadioButton_DC_no;

		public bool C_CheckBox_AutoEat;

		public bool C_CheckBox_TL_mem1;

		public bool C_CheckBox_TL_mem2;

		public bool C_CheckBox_TL_mem3;

		public bool C_CheckBox_TL_mem4;

		public bool C_CheckBox_TL_pet1;

		public bool C_CheckBox_TL_pet2;

		public bool C_CheckBox_AutoCreatCharacter;

		public bool C_CheckBox_OpenMachine;

		public bool C_RadioButton_dia;

		public bool C_RadioButton_thuy;

		public bool C_RadioButton_hoa;

		public bool C_RadioButton_phong;

		public bool C_CheckBox_Autosort;

		public bool C_CheckBox_DCFullHomdo;

		public string ToolStripTextBox_KenhPassword;

		public string ComboBox_Server;

		public int ComboBox_Port;

		public string TextBox_RemoteDis;

		public string ComboBox_namePublic;

		public double TextBox_DelayBot;

		public int TextBox_IDmem1;

		public int TextBox_IDmem2;

		public int TextBox_IDmem3;

		public int TextBox_IDmem4;

		public int TextBox_IdLeader;

		public int TextBox_AutoSend;

		public int ProgressBarEx_BDY;

		public int TextBox_TL_pet_hp_value;

		public int TextBox_TL_pet_sp_value;

		public int TextBox_Eat_char_hp_value;

		public int TextBox_Eat_char_sp_value;

		public int TextBox_Eat_Pet_hp_value;

		public int TextBox_Eat_Pet_sp_value;

		public int TextBox_Drop_HpValue;

		public int TextBox_Drop_SpValue;

		public int TextBox_Contribute_HpValue;

		public int TextBox_Contribute_SpValue;

		public int TextBox_Send_HpValue;

		public int TextBox_Send_SpValue;

		public int TextBox_Sell_HpValue;

		public int TextBox_Sell_SpValue;

		public int TextBox_OpenMachine_CharHp;

		public int TextBox_OpenMachine_CharSp;

		public int TextBox_OpenMachine_PetHp;

		public int TextBox_OpenMachine_PetSp;

		public int NumericUpDown_ItemCountPickup;

		public int TextBox_ValueSPFlee;

		public string TextBox_ClickMOD;

		public int TextBox_ClickMOD_delay;

		public int _IDmem1;

		public int _IDmem2;

		public int _IDmem3;

		public int _IDmem4;

		public string Label_BDY;

		public string StatusBarPanel_BattleCount;

		public string StatusBarPanel_checkbot;

		public int StatusBarPanel_botreset;

		public string Button_StartAutoQuest;

		public int versionlogin;

		public string _Status;

		public Dictionary<int, _Data._InfoText> Rtbsystem;

		public Dictionary<int, _Data._InfoText> Rtbchat;

		public Dictionary<int, _Data._InfoText> RtbBattle;

		public Dictionary<int, _Data._InfoText> RtbQuest;

		public int _id_rtbsystem;

		public int _id_rtbChat;

		public int _id_rtbBattle;

		public int _id_rtbQuest;

		public bool _Check_CreatCharacter;

		public string _CreatCharacter_Name;

		public int _CreatCharacter_Sex;

		public int _CreatCharacter_Thuoctinh;

		public int _CreatCharacter_int;

		public int _CreatCharacter_atk;

		public int _CreatCharacter_def;

		public int _CreatCharacter_hpx;

		public int _CreatCharacter_spx;

		public int _CreatCharacter_agi;

		public string _CreatCharacter_Pass1;

		public string _CreatCharacter_Pass2;

		public int _AutoSelling;

		public int _stt_send;

		public int delaywalk;

		public int _Bee_X;

		public int _Bee_Y;

		public int _CuoiNgua;

		public int _Antibot_ask;

		public string _Antibot_str;

		public long timelogined;

		public long _time_AutoSendBDY_clone;

		public long _time_AutoSell_clone;

		public string AccIDstr;

		public int Char_Sex;

		public int PetBattle;

		public int Char_col;

		public ArrayList listStart;

		public ArrayList listEnd;

		public ArrayList listWarp;

		public ArrayList liststeprecquest;

		public ArrayList ListAnswerBTQ;

		public string packetbot;

		public int idmapbot;

		public int bott;

		public string _npctalking;

		public bool Startautoquest;

		public int Step_sendend;

		public int EndQuest;

		public int DelayEndQuest;

		public int DelayStepQuest;

		public int showmenu;

		public int _Questing;

		public int battlecount;

		public int DelayDisconnectNoBattle;

		public bool AutoClearGhost;

		public int Battle;

		public int turn;

		public int atw;

		public string AutoWarptoMap;

		public int BTQ;

		public int _Ready;

		public bool _Proxy;

		public bool _Proxy_Disconnect;

		protected NetworkStream _local;

		protected NetworkStream _remote;

		private byte[] m_a;

		private byte[] m_b;

		private string m_c;

		private string m_d;

		private int m_e;

		private string m_f;

		public int PlayerCount;

		private int m_g;

		private int m_h;

		private int m_i;

		private int m_j;

		private int m_k;

		private int m_l;

		private int m_m;

		private int m_n;

		private int m_o;

		private int m_p;

		private string m_q;

		private string m_r;

		private string m_s;

		private string m_t;

		private string m_u;

		public ArrayList listquest_Done;

		public ArrayList listquest_Doing;

		private int m_v;

		public int _MapX_Monster;

		public int _MapY_Monster;

		public long time_online
		{
			get
			{
				return checked(DateAndTime.Now.Ticks - timelogined) / 10000000;
			}
			set
			{
				if (value == 0)
				{
					_time_AutoSendBDY = 0;
					_time_AutoSell = 0;
					timelogined = DateAndTime.Now.Ticks;
				}
			}
		}

		public int _time_AutoSendBDY
		{
			get
			{
				long num = checked(DateAndTime.Now.Ticks - _time_AutoSendBDY_clone) / 10000000;
				return checked((int)num);
			}
			set
			{
				if (value == 0)
				{
					_time_AutoSendBDY_clone = DateAndTime.Now.Ticks;
				}
			}
		}

		public int _time_AutoSell
		{
			get
			{
				long num = checked(DateAndTime.Now.Ticks - _time_AutoSell_clone) / 10000000;
				return checked((int)num);
			}
			set
			{
				if (value == 0)
				{
					_time_AutoSell_clone = DateAndTime.Now.Ticks;
				}
			}
		}

		public _Data._Pets Data_PetInfo
		{
			get
			{
				_Data._Pets result = default(_Data._Pets);
				if (PetBattle > 0)
				{
					return Data_PetsInfo[PetBattle];
				}
				return result;
			}
			set
			{
				Data_PetsInfo[PetBattle] = value;
			}
		}

				public object get_DataPets(int stt, string type)
		{
				object result = RuntimeHelpers.GetObjectValue(new object());
				if (Operators.CompareString(type, _Data.Type_Pets._Id, false) == 0)
				{
					result = Data_PetsInfo[stt]._Id;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._Name, false) == 0)
				{
					result = Data_PetsInfo[stt]._Name;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._Lv, false) == 0)
				{
					result = Data_PetsInfo[stt]._Lv;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._ThuocTinh, false) == 0)
				{
					result = Data_PetsInfo[stt]._ThuocTinh;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._Hp, false) == 0)
				{
					result = Data_PetsInfo[stt]._Hp;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._HpMax, false) == 0)
				{
					result = Data_PetsInfo[stt]._HpMax;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._Sp, false) == 0)
				{
					result = Data_PetsInfo[stt]._Sp;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._SpMax, false) == 0)
				{
					result = Data_PetsInfo[stt]._SpMax;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._Fai, false) == 0)
				{
					result = Data_PetsInfo[stt]._Fai;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._ExpTotal, false) == 0)
				{
					result = Data_PetsInfo[stt]._ExpTotal;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._Exp, false) == 0)
				{
					result = Data_PetsInfo[stt]._Exp;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._ExpMax, false) == 0)
				{
					result = Data_PetsInfo[stt]._ExpMax;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._ExpMin, false) == 0)
				{
					result = Data_PetsInfo[stt]._ExpMin;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._TExp, false) == 0)
				{
					result = Data_PetsInfo[stt]._Texp;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._Reborn, false) == 0)
				{
					result = Data_PetsInfo[stt]._Reborn;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._Int, false) == 0)
				{
					result = Data_PetsInfo[stt]._Int;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._Atk, false) == 0)
				{
					result = Data_PetsInfo[stt]._Atk;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._Def, false) == 0)
				{
					result = Data_PetsInfo[stt]._Def;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._Hpx, false) == 0)
				{
					result = Data_PetsInfo[stt]._Hpx;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._Spx, false) == 0)
				{
					result = Data_PetsInfo[stt]._Spx;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._Agi, false) == 0)
				{
					result = Data_PetsInfo[stt]._Agi;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._Int2, false) == 0)
				{
					result = Data_PetsInfo[stt]._Int2;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._Atk2, false) == 0)
				{
					result = Data_PetsInfo[stt]._Atk2;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._Def2, false) == 0)
				{
					result = Data_PetsInfo[stt]._Def2;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._Hpx2, false) == 0)
				{
					result = Data_PetsInfo[stt]._Hpx2;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._Spx2, false) == 0)
				{
					result = Data_PetsInfo[stt]._Spx2;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._Agi2, false) == 0)
				{
					result = Data_PetsInfo[stt]._Agi2;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._Int3, false) == 0)
				{
					result = Data_PetsInfo[stt]._Int3;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._Atk3, false) == 0)
				{
					result = Data_PetsInfo[stt]._Atk3;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._Def3, false) == 0)
				{
					result = Data_PetsInfo[stt]._Def3;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._Hpx3, false) == 0)
				{
					result = Data_PetsInfo[stt]._Hpx3;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._Spx3, false) == 0)
				{
					result = Data_PetsInfo[stt]._Spx3;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._Agi3, false) == 0)
				{
					result = Data_PetsInfo[stt]._Agi3;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._Mu, false) == 0)
				{
					result = Data_PetsInfo[stt]._Mu;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._Ao, false) == 0)
				{
					result = Data_PetsInfo[stt]._Ao;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._vukhi, false) == 0)
				{
					result = Data_PetsInfo[stt]._vukhi;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._tay, false) == 0)
				{
					result = Data_PetsInfo[stt]._tay;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._chan, false) == 0)
				{
					result = Data_PetsInfo[stt]._chan;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._dacthu, false) == 0)
				{
					result = Data_PetsInfo[stt]._dacthu;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._Proto, false) == 0)
				{
					result = Data_PetsInfo[stt]._Proto;
				}
				return result;
			}

		public void set_DataPets(int stt, string type, object value)
		{
				if (Operators.CompareString(type, _Data.Type_Pets._Id, false) == 0)
				{
					_Data._Pets value2 = Data_PetsInfo[stt];
					value2._Id = Conversions.ToInteger(value);
					Data_PetsInfo[stt] = value2;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._Name, false) == 0)
				{
					_Data._Pets value3 = Data_PetsInfo[stt];
					value3._Name = Conversions.ToString(value);
					Data_PetsInfo[stt] = value3;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._Lv, false) == 0)
				{
					_Data._Pets value4 = Data_PetsInfo[stt];
					value4._Lv = Conversions.ToInteger(value);
					Data_PetsInfo[stt] = value4;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._ThuocTinh, false) == 0)
				{
					_Data._Pets value5 = Data_PetsInfo[stt];
					value5._ThuocTinh = Conversions.ToInteger(value);
					Data_PetsInfo[stt] = value5;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._Hp, false) == 0)
				{
					_Data._Pets value6 = Data_PetsInfo[stt];
					value6._Hp = Conversions.ToInteger(value);
					Data_PetsInfo[stt] = value6;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._HpMax, false) == 0)
				{
					_Data._Pets value7 = Data_PetsInfo[stt];
					value7._HpMax = Conversions.ToInteger(value);
					Data_PetsInfo[stt] = value7;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._Sp, false) == 0)
				{
					_Data._Pets value8 = Data_PetsInfo[stt];
					value8._Sp = Conversions.ToInteger(value);
					Data_PetsInfo[stt] = value8;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._SpMax, false) == 0)
				{
					_Data._Pets value9 = Data_PetsInfo[stt];
					value9._SpMax = Conversions.ToInteger(value);
					Data_PetsInfo[stt] = value9;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._Fai, false) == 0)
				{
					_Data._Pets value10 = Data_PetsInfo[stt];
					value10._Fai = Conversions.ToInteger(value);
					Data_PetsInfo[stt] = value10;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._ExpTotal, false) == 0)
				{
					_Data._Pets value11 = Data_PetsInfo[stt];
					value11._ExpTotal = Conversions.ToInteger(value);
					Data_PetsInfo[stt] = value11;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._Exp, false) == 0)
				{
					_Data._Pets value12 = Data_PetsInfo[stt];
					value12._Exp = Conversions.ToInteger(value);
					Data_PetsInfo[stt] = value12;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._ExpMax, false) == 0)
				{
					_Data._Pets value13 = Data_PetsInfo[stt];
					value13._ExpMax = Conversions.ToInteger(value);
					Data_PetsInfo[stt] = value13;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._ExpMin, false) == 0)
				{
					_Data._Pets value14 = Data_PetsInfo[stt];
					value14._ExpMin = Conversions.ToInteger(value);
					Data_PetsInfo[stt] = value14;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._TExp, false) == 0)
				{
					_Data._Pets value15 = Data_PetsInfo[stt];
					value15._Texp = Conversions.ToInteger(value);
					Data_PetsInfo[stt] = value15;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._Reborn, false) == 0)
				{
					_Data._Pets value16 = Data_PetsInfo[stt];
					value16._Reborn = Conversions.ToInteger(value);
					Data_PetsInfo[stt] = value16;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._Int, false) == 0)
				{
					_Data._Pets value17 = Data_PetsInfo[stt];
					value17._Int = Conversions.ToInteger(value);
					Data_PetsInfo[stt] = value17;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._Atk, false) == 0)
				{
					_Data._Pets value18 = Data_PetsInfo[stt];
					value18._Atk = Conversions.ToInteger(value);
					Data_PetsInfo[stt] = value18;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._Def, false) == 0)
				{
					_Data._Pets value19 = Data_PetsInfo[stt];
					value19._Def = Conversions.ToInteger(value);
					Data_PetsInfo[stt] = value19;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._Hpx, false) == 0)
				{
					_Data._Pets value20 = Data_PetsInfo[stt];
					value20._Hpx = Conversions.ToInteger(value);
					Data_PetsInfo[stt] = value20;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._Spx, false) == 0)
				{
					_Data._Pets value21 = Data_PetsInfo[stt];
					value21._Spx = Conversions.ToInteger(value);
					Data_PetsInfo[stt] = value21;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._Agi, false) == 0)
				{
					_Data._Pets value22 = Data_PetsInfo[stt];
					value22._Agi = Conversions.ToInteger(value);
					Data_PetsInfo[stt] = value22;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._Int2, false) == 0)
				{
					_Data._Pets value23 = Data_PetsInfo[stt];
					value23._Int2 = Conversions.ToInteger(value);
					Data_PetsInfo[stt] = value23;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._Atk2, false) == 0)
				{
					_Data._Pets value24 = Data_PetsInfo[stt];
					value24._Atk2 = Conversions.ToInteger(value);
					Data_PetsInfo[stt] = value24;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._Def2, false) == 0)
				{
					_Data._Pets value25 = Data_PetsInfo[stt];
					value25._Def2 = Conversions.ToInteger(value);
					Data_PetsInfo[stt] = value25;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._Hpx2, false) == 0)
				{
					_Data._Pets value26 = Data_PetsInfo[stt];
					value26._Hpx2 = Conversions.ToInteger(value);
					Data_PetsInfo[stt] = value26;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._Spx2, false) == 0)
				{
					_Data._Pets value27 = Data_PetsInfo[stt];
					value27._Spx2 = Conversions.ToInteger(value);
					Data_PetsInfo[stt] = value27;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._Agi2, false) == 0)
				{
					_Data._Pets value28 = Data_PetsInfo[stt];
					value28._Agi2 = Conversions.ToInteger(value);
					Data_PetsInfo[stt] = value28;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._Int3, false) == 0)
				{
					_Data._Pets value29 = Data_PetsInfo[stt];
					value29._Int3 = Conversions.ToInteger(value);
					Data_PetsInfo[stt] = value29;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._Atk3, false) == 0)
				{
					_Data._Pets value30 = Data_PetsInfo[stt];
					value30._Atk3 = Conversions.ToInteger(value);
					Data_PetsInfo[stt] = value30;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._Def3, false) == 0)
				{
					_Data._Pets value31 = Data_PetsInfo[stt];
					value31._Def3 = Conversions.ToInteger(value);
					Data_PetsInfo[stt] = value31;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._Hpx3, false) == 0)
				{
					_Data._Pets value32 = Data_PetsInfo[stt];
					value32._Hpx3 = Conversions.ToInteger(value);
					Data_PetsInfo[stt] = value32;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._Spx3, false) == 0)
				{
					_Data._Pets value33 = Data_PetsInfo[stt];
					value33._Spx3 = Conversions.ToInteger(value);
					Data_PetsInfo[stt] = value33;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._Agi3, false) == 0)
				{
					_Data._Pets value34 = Data_PetsInfo[stt];
					value34._Agi3 = Conversions.ToInteger(value);
					Data_PetsInfo[stt] = value34;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._Mu, false) == 0)
				{
					_Data._Pets value35 = Data_PetsInfo[stt];
					value35._Mu = Conversions.ToInteger(value);
					Data_PetsInfo[stt] = value35;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._Ao, false) == 0)
				{
					_Data._Pets value36 = Data_PetsInfo[stt];
					value36._Ao = Conversions.ToInteger(value);
					Data_PetsInfo[stt] = value36;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._vukhi, false) == 0)
				{
					_Data._Pets value37 = Data_PetsInfo[stt];
					value37._vukhi = Conversions.ToInteger(value);
					Data_PetsInfo[stt] = value37;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._tay, false) == 0)
				{
					_Data._Pets value38 = Data_PetsInfo[stt];
					value38._tay = Conversions.ToInteger(value);
					Data_PetsInfo[stt] = value38;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._chan, false) == 0)
				{
					_Data._Pets value39 = Data_PetsInfo[stt];
					value39._chan = Conversions.ToInteger(value);
					Data_PetsInfo[stt] = value39;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._dacthu, false) == 0)
				{
					_Data._Pets value40 = Data_PetsInfo[stt];
					value40._dacthu = Conversions.ToInteger(value);
					Data_PetsInfo[stt] = value40;
				}
				else if (Operators.CompareString(type, _Data.Type_Pets._Proto, false) == 0)
				{
					_Data._Pets value41 = Data_PetsInfo[stt];
					value41._Proto = Conversions.ToInteger(value);
					Data_PetsInfo[stt] = value41;
				}
			}

				public object get_DataBattle(int stt, string type)
		{
				object result = RuntimeHelpers.GetObjectValue(new object());
				if (Operators.CompareString(type, _Data.Type_Battleinfo._Id, false) == 0)
				{
					result = Data_Battles[stt]._Id;
				}
				else if (Operators.CompareString(type, _Data.Type_Battleinfo._Name, false) == 0)
				{
					result = Data_Battles[stt]._Name;
				}
				else if (Operators.CompareString(type, _Data.Type_Battleinfo._Lv, false) == 0)
				{
					result = Data_Battles[stt]._Lv;
				}
				else if (Operators.CompareString(type, _Data.Type_Battleinfo._Hp, false) == 0)
				{
					result = Data_Battles[stt]._Hp;
				}
				else if (Operators.CompareString(type, _Data.Type_Battleinfo._HpMax, false) == 0)
				{
					result = Data_Battles[stt]._HpMax;
				}
				else if (Operators.CompareString(type, _Data.Type_Battleinfo._Sp, false) == 0)
				{
					result = Data_Battles[stt]._Sp;
				}
				else if (Operators.CompareString(type, _Data.Type_Battleinfo._SpMax, false) == 0)
				{
					result = Data_Battles[stt]._SpMax;
				}
				else if (Operators.CompareString(type, _Data.Type_Battleinfo._ThuocTinh, false) == 0)
				{
					result = Data_Battles[stt]._ThuocTinh;
				}
				else if (Operators.CompareString(type, _Data.Type_Battleinfo._Type, false) == 0)
				{
					result = Data_Battles[stt]._Type;
				}
				else if (Operators.CompareString(type, _Data.Type_Battleinfo._IdChar, false) == 0)
				{
					result = Data_Battles[stt]._IdChar;
				}
				else if (Operators.CompareString(type, _Data.Type_Battleinfo._Color, false) == 0)
				{
					result = Data_Battles[stt]._Color;
				}
				return result;
			}

		public void set_DataBattle(int stt, string type, object value)
		{
				if (Operators.CompareString(type, _Data.Type_Battleinfo._Id, false) == 0)
				{
					_Data._Battleinfo value2 = Data_Battles[stt];
					value2._Id = Conversions.ToInteger(value);
					Data_Battles[stt] = value2;
				}
				else if (Operators.CompareString(type, _Data.Type_Battleinfo._Name, false) == 0)
				{
					_Data._Battleinfo value3 = Data_Battles[stt];
					value3._Name = Conversions.ToString(value);
					Data_Battles[stt] = value3;
				}
				else if (Operators.CompareString(type, _Data.Type_Battleinfo._Lv, false) == 0)
				{
					_Data._Battleinfo value4 = Data_Battles[stt];
					value4._Lv = Conversions.ToInteger(value);
					Data_Battles[stt] = value4;
				}
				else if (Operators.CompareString(type, _Data.Type_Battleinfo._Hp, false) == 0)
				{
					_Data._Battleinfo value5 = Data_Battles[stt];
					value5._Hp = Conversions.ToInteger(value);
					Data_Battles[stt] = value5;
				}
				else if (Operators.CompareString(type, _Data.Type_Battleinfo._HpMax, false) == 0)
				{
					_Data._Battleinfo value6 = Data_Battles[stt];
					value6._HpMax = Conversions.ToInteger(value);
					Data_Battles[stt] = value6;
				}
				else if (Operators.CompareString(type, _Data.Type_Battleinfo._Sp, false) == 0)
				{
					_Data._Battleinfo value7 = Data_Battles[stt];
					value7._Sp = Conversions.ToInteger(value);
					Data_Battles[stt] = value7;
				}
				else if (Operators.CompareString(type, _Data.Type_Battleinfo._SpMax, false) == 0)
				{
					_Data._Battleinfo value8 = Data_Battles[stt];
					value8._SpMax = Conversions.ToInteger(value);
					Data_Battles[stt] = value8;
				}
				else if (Operators.CompareString(type, _Data.Type_Battleinfo._ThuocTinh, false) == 0)
				{
					_Data._Battleinfo value9 = Data_Battles[stt];
					value9._ThuocTinh = Conversions.ToInteger(value);
					Data_Battles[stt] = value9;
				}
				else if (Operators.CompareString(type, _Data.Type_Battleinfo._Type, false) == 0)
				{
					_Data._Battleinfo value10 = Data_Battles[stt];
					value10._Type = Conversions.ToInteger(value);
					Data_Battles[stt] = value10;
				}
				else if (Operators.CompareString(type, _Data.Type_Battleinfo._IdChar, false) == 0)
				{
					_Data._Battleinfo value11 = Data_Battles[stt];
					value11._IdChar = Conversions.ToInteger(value);
					Data_Battles[stt] = value11;
				}
				else if (Operators.CompareString(type, _Data.Type_Battleinfo._Color, false) == 0)
				{
					_Data._Battleinfo value12 = Data_Battles[stt];
					value12._Color = ((value != null) ? ((Color)value) : default(Color));
					Data_Battles[stt] = value12;
				}
			}

				public object get_DataItemOnMap(int stt, string type)
		{
				object result = RuntimeHelpers.GetObjectValue(new object());
				if (Operators.CompareString(type, _Data.Type_ItemOnMap._Gold, false) == 0)
				{
					result = Data_ItemOnMaps[stt]._Gold;
				}
				else if (Operators.CompareString(type, _Data.Type_ItemOnMap._Id, false) == 0)
				{
					result = Data_ItemOnMaps[stt]._Id;
				}
				else if (Operators.CompareString(type, _Data.Type_ItemOnMap._Name, false) == 0)
				{
					result = Data_ItemOnMaps[stt]._Name;
				}
				else if (Operators.CompareString(type, _Data.Type_ItemOnMap._MapX, false) == 0)
				{
					result = Data_ItemOnMaps[stt]._MapX;
				}
				else if (Operators.CompareString(type, _Data.Type_ItemOnMap._MapY, false) == 0)
				{
					result = Data_ItemOnMaps[stt]._MapY;
				}
				return result;
			}

		public void set_DataItemOnMap(int stt, string type, object value)
		{
				if (Operators.CompareString(type, _Data.Type_ItemOnMap._Gold, false) == 0)
				{
					_Data._ItemOnMap value2 = Data_ItemOnMaps[stt];
					value2._Gold = Conversions.ToInteger(value);
					Data_ItemOnMaps[stt] = value2;
				}
				else if (Operators.CompareString(type, _Data.Type_ItemOnMap._Id, false) == 0)
				{
					_Data._ItemOnMap value3 = Data_ItemOnMaps[stt];
					value3._Id = Conversions.ToInteger(value);
					Data_ItemOnMaps[stt] = value3;
				}
				else if (Operators.CompareString(type, _Data.Type_ItemOnMap._Name, false) == 0)
				{
					_Data._ItemOnMap value4 = Data_ItemOnMaps[stt];
					value4._Name = Conversions.ToString(value);
					Data_ItemOnMaps[stt] = value4;
				}
				else if (Operators.CompareString(type, _Data.Type_ItemOnMap._MapX, false) == 0)
				{
					_Data._ItemOnMap value5 = Data_ItemOnMaps[stt];
					value5._MapX = Conversions.ToInteger(value);
					Data_ItemOnMaps[stt] = value5;
				}
				else if (Operators.CompareString(type, _Data.Type_ItemOnMap._MapY, false) == 0)
				{
					_Data._ItemOnMap value6 = Data_ItemOnMaps[stt];
					value6._MapY = Conversions.ToInteger(value);
					Data_ItemOnMaps[stt] = value6;
				}
			}

				public object get_DataNpcInMap(int stt, string type)
		{
				object result = RuntimeHelpers.GetObjectValue(new object());
				if (Operators.CompareString(type, _Data.Type_NpcInMap._Id, false) == 0)
				{
					result = Data_NpcInMap[stt]._Id;
				}
				else if (Operators.CompareString(type, _Data.Type_NpcInMap._MapX, false) == 0)
				{
					result = Data_NpcInMap[stt]._MapX;
				}
				else if (Operators.CompareString(type, _Data.Type_NpcInMap._MapY, false) == 0)
				{
					result = Data_NpcInMap[stt]._MapY;
				}
				else if (Operators.CompareString(type, _Data.Type_NpcInMap._Delay, false) == 0)
				{
					result = Data_NpcInMap[stt]._Delay;
				}
				else if (Operators.CompareString(type, _Data.Type_NpcInMap._KC, false) == 0)
				{
					result = Data_NpcInMap[stt]._KC;
				}
				return result;
			}

		public void set_DataNpcInMap(int stt, string type, object value)
		{
				if (Operators.CompareString(type, _Data.Type_NpcInMap._Id, false) == 0)
				{
					_Data._NpcInMap value2 = Data_NpcInMap[stt];
					value2._Id = Conversions.ToInteger(value);
					Data_NpcInMap[stt] = value2;
				}
				else if (Operators.CompareString(type, _Data.Type_NpcInMap._MapX, false) == 0)
				{
					_Data._NpcInMap value3 = Data_NpcInMap[stt];
					value3._MapX = Conversions.ToInteger(value);
					Data_NpcInMap[stt] = value3;
				}
				else if (Operators.CompareString(type, _Data.Type_NpcInMap._MapY, false) == 0)
				{
					_Data._NpcInMap value4 = Data_NpcInMap[stt];
					value4._MapY = Conversions.ToInteger(value);
					Data_NpcInMap[stt] = value4;
				}
				else if (Operators.CompareString(type, _Data.Type_NpcInMap._Delay, false) == 0)
				{
					_Data._NpcInMap value5 = Data_NpcInMap[stt];
					value5._Delay = Conversions.ToInteger(value);
					Data_NpcInMap[stt] = value5;
				}
				else if (Operators.CompareString(type, _Data.Type_NpcInMap._KC, false) == 0)
				{
					_Data._NpcInMap value6 = Data_NpcInMap[stt];
					value6._KC = Conversions.ToInteger(value);
					Data_NpcInMap[stt] = value6;
				}
			}

				public object get_DataTuido(int stt, string type)
		{
				object result = RuntimeHelpers.GetObjectValue(new object());
				if (Operators.CompareString(type, _Data.Type_Tui._Stt, false) == 0)
				{
					result = Data_Tuido[stt]._Stt;
				}
				else if (Operators.CompareString(type, _Data.Type_Tui._Id, false) == 0)
				{
					result = Data_Tuido[stt]._Id;
				}
				else if (Operators.CompareString(type, _Data.Type_Tui._Name, false) == 0)
				{
					result = Data_Tuido[stt]._Name;
				}
				else if (Operators.CompareString(type, _Data.Type_Tui._Sl, false) == 0)
				{
					result = Data_Tuido[stt]._Sl;
				}
				else if (Operators.CompareString(type, _Data.Type_Tui._Doben, false) == 0)
				{
					result = Data_Tuido[stt]._Doben;
				}
				return result;
			}

		public void set_DataTuido(int stt, string type, object value)
		{
				_Data._Tuido value2 = Data_Tuido[stt];
				value2._Stt = stt;
				if (Operators.CompareString(type, _Data.Type_Tui._Stt, false) != 0)
				{
					if (Operators.CompareString(type, _Data.Type_Tui._Id, false) == 0)
					{
						value2._Id = Conversions.ToInteger(value);
						value2._Name = GetItemName(Conversions.ToInteger(value));
						Data_Tuido[stt] = value2;
					}
					else if (Operators.CompareString(type, _Data.Type_Tui._Sl, false) == 0)
					{
						value2._Sl = Conversions.ToInteger(value);
						Data_Tuido[stt] = value2;
					}
					else if (Operators.CompareString(type, _Data.Type_Tui._Doben, false) == 0)
					{
						value2._Doben = Conversions.ToInteger(value);
						Data_Tuido[stt] = value2;
					}
				}
			}

				public object get_DataTuideo(int stt, string type)
		{
				object result = RuntimeHelpers.GetObjectValue(new object());
				if (Operators.CompareString(type, _Data.Type_Tui._Stt, false) == 0)
				{
					result = Data_Tuideo[stt]._Stt;
				}
				else if (Operators.CompareString(type, _Data.Type_Tui._Id, false) == 0)
				{
					result = Data_Tuideo[stt]._Id;
				}
				else if (Operators.CompareString(type, _Data.Type_Tui._Name, false) == 0)
				{
					result = Data_Tuideo[stt]._Name;
				}
				else if (Operators.CompareString(type, _Data.Type_Tui._Sl, false) == 0)
				{
					result = Data_Tuideo[stt]._Sl;
				}
				else if (Operators.CompareString(type, _Data.Type_Tui._Doben, false) == 0)
				{
					result = Data_Tuideo[stt]._Doben;
				}
				return result;
			}

		public void set_DataTuideo(int stt, string type, object value)
		{
				_Data._Tuideo value2 = Data_Tuideo[stt];
				value2._Stt = stt;
				if (Operators.CompareString(type, _Data.Type_Tui._Stt, false) != 0)
				{
					if (Operators.CompareString(type, _Data.Type_Tui._Id, false) == 0)
					{
						value2._Id = Conversions.ToInteger(value);
						value2._Name = GetItemName(Conversions.ToInteger(value));
						Data_Tuideo[stt] = value2;
					}
					else if (Operators.CompareString(type, _Data.Type_Tui._Sl, false) == 0)
					{
						value2._Sl = Conversions.ToInteger(value);
						Data_Tuideo[stt] = value2;
					}
					else if (Operators.CompareString(type, _Data.Type_Tui._Doben, false) == 0)
					{
						value2._Doben = Conversions.ToInteger(value);
						Data_Tuideo[stt] = value2;
					}
				}
			}

				public object get_DataCharEquit(int stt, string type)
		{
				object result = RuntimeHelpers.GetObjectValue(new object());
				if (Operators.CompareString(type, _Data.Type_Equit._Id, false) == 0)
				{
					result = Data_CharEquit[stt]._Id;
				}
				else if (Operators.CompareString(type, _Data.Type_Equit._Name, false) == 0)
				{
					result = Data_CharEquit[stt]._Name;
				}
				else if (Operators.CompareString(type, _Data.Type_Equit._Doben, false) == 0)
				{
					result = Data_CharEquit[stt]._Doben;
				}
				return result;
			}

		public void set_DataCharEquit(int stt, string type, object value)
		{
				if (Operators.CompareString(type, _Data.Type_Equit._Id, false) == 0)
				{
					_Data._CharEquit value2 = Data_CharEquit[stt];
					value2._Id = Conversions.ToInteger(value);
					value2._Name = GetItemName(Conversions.ToInteger(value));
					Data_CharEquit[stt] = value2;
				}
				else if (Operators.CompareString(type, _Data.Type_Equit._Doben, false) == 0)
				{
					_Data._CharEquit value3 = Data_CharEquit[stt];
					value3._Doben = Conversions.ToInteger(value);
					Data_CharEquit[stt] = value3;
				}
			}

				public object get_DataPetEquit(int stt, string type)
		{
				object result = RuntimeHelpers.GetObjectValue(new object());
				if (Operators.CompareString(type, _Data.Type_Equit._Id, false) == 0)
				{
					result = Data_PetEquit[stt]._Id;
				}
				else if (Operators.CompareString(type, _Data.Type_Equit._Name, false) == 0)
				{
					result = Data_PetEquit[stt]._Name;
				}
				else if (Operators.CompareString(type, _Data.Type_Equit._Doben, false) == 0)
				{
					result = Data_PetEquit[stt]._Doben;
				}
				return result;
			}

		public void set_DataPetEquit(int stt, string type, object value)
		{
				if (Operators.CompareString(type, _Data.Type_Equit._Id, false) == 0)
				{
					_Data._PetEquit value2 = Data_PetEquit[stt];
					value2._Id = Conversions.ToInteger(value);
					value2._Name = GetItemName(Conversions.ToInteger(value));
					Data_PetEquit[stt] = value2;
				}
				else if (Operators.CompareString(type, _Data.Type_Equit._Doben, false) == 0)
				{
					_Data._PetEquit value3 = Data_PetEquit[stt];
					value3._Doben = Conversions.ToInteger(value);
					Data_PetEquit[stt] = value3;
				}
			}

				public object get__CharAttackSetting(string type)
		{
				switch (FnvHash.Compute(type))
				{
				case 497997450u:
					if (Operators.CompareString(type, "Char_Skill1", false) != 0)
					{
						break;
					}
					return Data_CharAttackSetting._Skill1;
				case 481219831u:
					if (Operators.CompareString(type, "Char_Skill2", false) != 0)
					{
						break;
					}
					return Data_CharAttackSetting._Skill2;
				case 464442212u:
					if (Operators.CompareString(type, "Char_Skill3", false) != 0)
					{
						break;
					}
					return Data_CharAttackSetting._Skill3;
				case 447664593u:
					if (Operators.CompareString(type, "Char_Skill4", false) != 0)
					{
						break;
					}
					return Data_CharAttackSetting._Skill4;
				case 430886974u:
					if (Operators.CompareString(type, "Char_Skill5", false) != 0)
					{
						break;
					}
					return Data_CharAttackSetting._Skill5;
				case 414109355u:
					if (Operators.CompareString(type, "Char_Skill6", false) != 0)
					{
						break;
					}
					return Data_CharAttackSetting._Skill6;
				case 397331736u:
					if (Operators.CompareString(type, "Char_Skill7", false) != 0)
					{
						break;
					}
					return Data_CharAttackSetting._Skill7;
				case 380554117u:
					if (Operators.CompareString(type, "Char_Skill8", false) != 0)
					{
						break;
					}
					return Data_CharAttackSetting._Skill8;
				case 363776498u:
					if (Operators.CompareString(type, "Char_Skill9", false) != 0)
					{
						break;
					}
					return Data_CharAttackSetting._Skill9;
				case 1950090958u:
					if (Operators.CompareString(type, "Char_Skill10", false) != 0)
					{
						break;
					}
					return Data_CharAttackSetting._Skill10;
				case 1018046868u:
					if (Operators.CompareString(type, "Char_Location1", false) != 0)
					{
						break;
					}
					return Data_CharAttackSetting._Location1;
				case 1068379725u:
					if (Operators.CompareString(type, "Char_Location2", false) != 0)
					{
						break;
					}
					return Data_CharAttackSetting._Location2;
				case 1051602106u:
					if (Operators.CompareString(type, "Char_Location3", false) != 0)
					{
						break;
					}
					return Data_CharAttackSetting._Location3;
				case 967714011u:
					if (Operators.CompareString(type, "Char_Location4", false) != 0)
					{
						break;
					}
					return Data_CharAttackSetting._Location4;
				case 950936392u:
					if (Operators.CompareString(type, "Char_Location5", false) != 0)
					{
						break;
					}
					return Data_CharAttackSetting._Location5;
				case 1001269249u:
					if (Operators.CompareString(type, "Char_Location6", false) != 0)
					{
						break;
					}
					return Data_CharAttackSetting._Location6;
				case 984491630u:
					if (Operators.CompareString(type, "Char_Location7", false) != 0)
					{
						break;
					}
					return Data_CharAttackSetting._Location7;
				case 900603535u:
					if (Operators.CompareString(type, "Char_Location8", false) != 0)
					{
						break;
					}
					return Data_CharAttackSetting._Location8;
				case 883825916u:
					if (Operators.CompareString(type, "Char_Location9", false) != 0)
					{
						break;
					}
					return Data_CharAttackSetting._Location9;
				case 707497260u:
					if (Operators.CompareString(type, "Char_Location10", false) != 0)
					{
						break;
					}
					return Data_CharAttackSetting._Location10;
				}
				object result = default(object);
				return result;
			}

		public void set__CharAttackSetting(string type, object value)
		{
				switch (FnvHash.Compute(type))
				{
				case 497997450u:
					if (Operators.CompareString(type, "Char_Skill1", false) == 0)
					{
						Data_CharAttackSetting._Skill1 = Conversions.ToInteger(value);
					}
					break;
				case 481219831u:
					if (Operators.CompareString(type, "Char_Skill2", false) == 0)
					{
						Data_CharAttackSetting._Skill2 = Conversions.ToInteger(value);
					}
					break;
				case 464442212u:
					if (Operators.CompareString(type, "Char_Skill3", false) == 0)
					{
						Data_CharAttackSetting._Skill3 = Conversions.ToInteger(value);
					}
					break;
				case 447664593u:
					if (Operators.CompareString(type, "Char_Skill4", false) == 0)
					{
						Data_CharAttackSetting._Skill4 = Conversions.ToInteger(value);
					}
					break;
				case 430886974u:
					if (Operators.CompareString(type, "Char_Skill5", false) == 0)
					{
						Data_CharAttackSetting._Skill5 = Conversions.ToInteger(value);
					}
					break;
				case 414109355u:
					if (Operators.CompareString(type, "Char_Skill6", false) == 0)
					{
						Data_CharAttackSetting._Skill6 = Conversions.ToInteger(value);
					}
					break;
				case 397331736u:
					if (Operators.CompareString(type, "Char_Skill7", false) == 0)
					{
						Data_CharAttackSetting._Skill7 = Conversions.ToInteger(value);
					}
					break;
				case 380554117u:
					if (Operators.CompareString(type, "Char_Skill8", false) == 0)
					{
						Data_CharAttackSetting._Skill8 = Conversions.ToInteger(value);
					}
					break;
				case 363776498u:
					if (Operators.CompareString(type, "Char_Skill9", false) == 0)
					{
						Data_CharAttackSetting._Skill9 = Conversions.ToInteger(value);
					}
					break;
				case 1950090958u:
					if (Operators.CompareString(type, "Char_Skill10", false) == 0)
					{
						Data_CharAttackSetting._Skill10 = Conversions.ToInteger(value);
					}
					break;
				case 1018046868u:
					if (Operators.CompareString(type, "Char_Location1", false) == 0)
					{
						Data_CharAttackSetting._Location1 = Conversions.ToString(value);
					}
					break;
				case 1068379725u:
					if (Operators.CompareString(type, "Char_Location2", false) == 0)
					{
						Data_CharAttackSetting._Location2 = Conversions.ToString(value);
					}
					break;
				case 1051602106u:
					if (Operators.CompareString(type, "Char_Location3", false) == 0)
					{
						Data_CharAttackSetting._Location3 = Conversions.ToString(value);
					}
					break;
				case 967714011u:
					if (Operators.CompareString(type, "Char_Location4", false) == 0)
					{
						Data_CharAttackSetting._Location4 = Conversions.ToString(value);
					}
					break;
				case 950936392u:
					if (Operators.CompareString(type, "Char_Location5", false) == 0)
					{
						Data_CharAttackSetting._Location5 = Conversions.ToString(value);
					}
					break;
				case 1001269249u:
					if (Operators.CompareString(type, "Char_Location6", false) == 0)
					{
						Data_CharAttackSetting._Location6 = Conversions.ToString(value);
					}
					break;
				case 984491630u:
					if (Operators.CompareString(type, "Char_Location7", false) == 0)
					{
						Data_CharAttackSetting._Location7 = Conversions.ToString(value);
					}
					break;
				case 900603535u:
					if (Operators.CompareString(type, "Char_Location8", false) == 0)
					{
						Data_CharAttackSetting._Location8 = Conversions.ToString(value);
					}
					break;
				case 883825916u:
					if (Operators.CompareString(type, "Char_Location9", false) == 0)
					{
						Data_CharAttackSetting._Location9 = Conversions.ToString(value);
					}
					break;
				case 707497260u:
					if (Operators.CompareString(type, "Char_Location10", false) == 0)
					{
						Data_CharAttackSetting._Location10 = Conversions.ToString(value);
					}
					break;
				}
			}

				public object get__PetAttackSetting(string type)
		{
				switch (FnvHash.Compute(type))
				{
				case 3573757795u:
					if (Operators.CompareString(type, "Pet_Skill1", false) != 0)
					{
						break;
					}
					return Data_PetAttackSetting._Skill1;
				case 3590535414u:
					if (Operators.CompareString(type, "Pet_Skill2", false) != 0)
					{
						break;
					}
					return Data_PetAttackSetting._Skill2;
				case 3607313033u:
					if (Operators.CompareString(type, "Pet_Skill3", false) != 0)
					{
						break;
					}
					return Data_PetAttackSetting._Skill3;
				case 3624090652u:
					if (Operators.CompareString(type, "Pet_Skill4", false) != 0)
					{
						break;
					}
					return Data_PetAttackSetting._Skill4;
				case 3640868271u:
					if (Operators.CompareString(type, "Pet_Skill5", false) != 0)
					{
						break;
					}
					return Data_PetAttackSetting._Skill5;
				case 3657645890u:
					if (Operators.CompareString(type, "Pet_Skill6", false) != 0)
					{
						break;
					}
					return Data_PetAttackSetting._Skill6;
				case 3674423509u:
					if (Operators.CompareString(type, "Pet_Skill7", false) != 0)
					{
						break;
					}
					return Data_PetAttackSetting._Skill7;
				case 3691201128u:
					if (Operators.CompareString(type, "Pet_Skill8", false) != 0)
					{
						break;
					}
					return Data_PetAttackSetting._Skill8;
				case 3707978747u:
					if (Operators.CompareString(type, "Pet_Skill9", false) != 0)
					{
						break;
					}
					return Data_PetAttackSetting._Skill9;
				case 2802849705u:
					if (Operators.CompareString(type, "Pet_Skill10", false) != 0)
					{
						break;
					}
					return Data_PetAttackSetting._Skill10;
				case 1772162479u:
					if (Operators.CompareString(type, "Pet_Location1", false) != 0)
					{
						break;
					}
					return Data_PetAttackSetting._Location1;
				case 1788940098u:
					if (Operators.CompareString(type, "Pet_Location2", false) != 0)
					{
						break;
					}
					return Data_PetAttackSetting._Location2;
				case 1805717717u:
					if (Operators.CompareString(type, "Pet_Location3", false) != 0)
					{
						break;
					}
					return Data_PetAttackSetting._Location3;
				case 1688274384u:
					if (Operators.CompareString(type, "Pet_Location4", false) != 0)
					{
						break;
					}
					return Data_PetAttackSetting._Location4;
				case 1705052003u:
					if (Operators.CompareString(type, "Pet_Location5", false) != 0)
					{
						break;
					}
					return Data_PetAttackSetting._Location5;
				case 1721829622u:
					if (Operators.CompareString(type, "Pet_Location6", false) != 0)
					{
						break;
					}
					return Data_PetAttackSetting._Location6;
				case 1738607241u:
					if (Operators.CompareString(type, "Pet_Location7", false) != 0)
					{
						break;
					}
					return Data_PetAttackSetting._Location7;
				case 1889605812u:
					if (Operators.CompareString(type, "Pet_Location8", false) != 0)
					{
						break;
					}
					return Data_PetAttackSetting._Location8;
				case 1906383431u:
					if (Operators.CompareString(type, "Pet_Location9", false) != 0)
					{
						break;
					}
					return Data_PetAttackSetting._Location9;
				case 3884478797u:
					if (Operators.CompareString(type, "Pet_Location10", false) != 0)
					{
						break;
					}
					return Data_PetAttackSetting._Location10;
				}
				object result = default(object);
				return result;
			}

		public void set__PetAttackSetting(string type, object value)
		{
				switch (FnvHash.Compute(type))
				{
				case 3573757795u:
					if (Operators.CompareString(type, "Pet_Skill1", false) == 0)
					{
						Data_PetAttackSetting._Skill1 = Conversions.ToInteger(value);
					}
					break;
				case 3590535414u:
					if (Operators.CompareString(type, "Pet_Skill2", false) == 0)
					{
						Data_PetAttackSetting._Skill2 = Conversions.ToInteger(value);
					}
					break;
				case 3607313033u:
					if (Operators.CompareString(type, "Pet_Skill3", false) == 0)
					{
						Data_PetAttackSetting._Skill3 = Conversions.ToInteger(value);
					}
					break;
				case 3624090652u:
					if (Operators.CompareString(type, "Pet_Skill4", false) == 0)
					{
						Data_PetAttackSetting._Skill4 = Conversions.ToInteger(value);
					}
					break;
				case 3640868271u:
					if (Operators.CompareString(type, "Pet_Skill5", false) == 0)
					{
						Data_PetAttackSetting._Skill5 = Conversions.ToInteger(value);
					}
					break;
				case 3657645890u:
					if (Operators.CompareString(type, "Pet_Skill6", false) == 0)
					{
						Data_PetAttackSetting._Skill6 = Conversions.ToInteger(value);
					}
					break;
				case 3674423509u:
					if (Operators.CompareString(type, "Pet_Skill7", false) == 0)
					{
						Data_PetAttackSetting._Skill7 = Conversions.ToInteger(value);
					}
					break;
				case 3691201128u:
					if (Operators.CompareString(type, "Pet_Skill8", false) == 0)
					{
						Data_PetAttackSetting._Skill8 = Conversions.ToInteger(value);
					}
					break;
				case 3707978747u:
					if (Operators.CompareString(type, "Pet_Skill9", false) == 0)
					{
						Data_PetAttackSetting._Skill9 = Conversions.ToInteger(value);
					}
					break;
				case 2802849705u:
					if (Operators.CompareString(type, "Pet_Skill10", false) == 0)
					{
						Data_PetAttackSetting._Skill10 = Conversions.ToInteger(value);
					}
					break;
				case 1772162479u:
					if (Operators.CompareString(type, "Pet_Location1", false) == 0)
					{
						Data_PetAttackSetting._Location1 = Conversions.ToString(value);
					}
					break;
				case 1788940098u:
					if (Operators.CompareString(type, "Pet_Location2", false) == 0)
					{
						Data_PetAttackSetting._Location2 = Conversions.ToString(value);
					}
					break;
				case 1805717717u:
					if (Operators.CompareString(type, "Pet_Location3", false) == 0)
					{
						Data_PetAttackSetting._Location3 = Conversions.ToString(value);
					}
					break;
				case 1688274384u:
					if (Operators.CompareString(type, "Pet_Location4", false) == 0)
					{
						Data_PetAttackSetting._Location4 = Conversions.ToString(value);
					}
					break;
				case 1705052003u:
					if (Operators.CompareString(type, "Pet_Location5", false) == 0)
					{
						Data_PetAttackSetting._Location5 = Conversions.ToString(value);
					}
					break;
				case 1721829622u:
					if (Operators.CompareString(type, "Pet_Location6", false) == 0)
					{
						Data_PetAttackSetting._Location6 = Conversions.ToString(value);
					}
					break;
				case 1738607241u:
					if (Operators.CompareString(type, "Pet_Location7", false) == 0)
					{
						Data_PetAttackSetting._Location7 = Conversions.ToString(value);
					}
					break;
				case 1889605812u:
					if (Operators.CompareString(type, "Pet_Location8", false) == 0)
					{
						Data_PetAttackSetting._Location8 = Conversions.ToString(value);
					}
					break;
				case 1906383431u:
					if (Operators.CompareString(type, "Pet_Location9", false) == 0)
					{
						Data_PetAttackSetting._Location9 = Conversions.ToString(value);
					}
					break;
				case 3884478797u:
					if (Operators.CompareString(type, "Pet_Location10", false) == 0)
					{
						Data_PetAttackSetting._Location10 = Conversions.ToString(value);
					}
					break;
				}
			}

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
						a(_s.GetStream());
						a(_remote);
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

		private void a(NetworkStream A_0)
		{
			try
			{
				AsyncCallback asyncCallback = a;
				if (A_0.Equals(_local))
				{
					A_0.BeginRead(this.m_b, 0, this.m_b.Length, a, A_0);
				}
				else
				{
					A_0.BeginRead(this.m_a, 0, this.m_a.Length, a, A_0);
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

		private void a(IAsyncResult A_0)
		{
			NetworkStream networkStream = (NetworkStream)A_0.AsyncState;
			checked
			{
				try
				{
					int num = networkStream.EndRead(A_0);
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
							ae(array);
						}
						else
						{
							byte[] array2 = new byte[num - 1 + 1];
							int num3 = num - 1;
							for (int j = 0; j <= num3; j++)
							{
								array2[j] = this.m_a[j];
							}
							ad(array2);
						}
						a(networkStream);
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

		private void ae(byte[] A_0)
		{
			checked
			{
				try
				{
					string text = API.bytestohexstring(API.EncDec_byte(A_0)).Replace("F444", " F444");
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
								ac(API.hexstringtobyte(text2));
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

		private void ad(byte[] A_0)
		{
			checked
			{
				try
				{
					string text = API.bytestohexstring(API.EncDec_byte(A_0)).Replace("F444", " F444");
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
								ab(array2);
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

		private void ac(byte[] A_0)
		{
			byte b = A_0[4];
			if (b == 1)
			{
				int num = API.BytesToInt32(new byte[4]
				{
					A_0[6],
					A_0[7],
					A_0[8],
					A_0[9]
				});
				idlogin = num;
				_remote.Write(API.EncDec_byte(A_0), 0, A_0.Length);
			}
			else
			{
				_remote.Write(API.EncDec_byte(A_0), 0, A_0.Length);
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
						if (ComboBox_Port == 0)
						{
							clientSocket.Connect(ComboBox_Server, 6414);
						}
						else
						{
							clientSocket.Connect(ComboBox_Server, 6420 + ComboBox_Port);
						}
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

		private void a(int A_0, int A_1, string A_2)
		{
			checked
			{
				if (!_Proxy)
				{
					string text = API.Int32ToHex4(A_1);
					string text2 = API.Int32ToHex2(A_0);
					string text3 = "";
					int num = A_2.Length - 1;
					for (int i = 0; i <= num; i++)
					{
						text3 += Strings.Asc(A_2.Substring(i, 1)).ToString("X2");
					}
					byte[] bytes = new byte[2];
					string text4 = "F444" + API.Int32ToHex2(10 + A_2.Length) + "01" + A_2.Length.ToString("X2") + text + API.bytestohexstring(bytes) + text2 + text3;
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
									ab(API.hexstringtobyte(text2));
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

		private void ab(byte[] A_0)
		{
			try
			{
				switch (A_0[4])
				{
				case 0:
					aa(A_0);
					break;
				case 1:
					z(A_0);
					break;
				case 2:
					y(A_0);
					break;
				case 3:
					x(A_0);
					break;
				case 4:
					w(A_0);
					break;
				case 5:
					v(A_0);
					break;
				case 6:
					u(A_0);
					break;
				case 8:
					t(A_0);
					break;
				case 9:
					s(A_0);
					break;
				case 11:
					r(A_0);
					break;
				case 12:
					q(A_0);
					break;
				case 13:
					p(A_0);
					break;
				case 15:
					o(A_0);
					break;
				case 16:
					n(A_0);
					break;
				case 19:
					m(A_0);
					break;
				case 20:
					l(A_0);
					break;
				case 22:
					k(A_0);
					break;
				case 23:
					j(A_0);
					break;
				case 24:
					i(A_0);
					break;
				case 25:
					h(A_0);
					break;
				case 26:
					g(A_0);
					break;
				case 36:
					f(A_0);
					break;
				case 50:
					e(A_0);
					break;
				case 52:
					d(A_0);
					break;
				case 53:
					c(A_0);
					break;
				case 65:
					b(A_0);
					break;
				case 78:
					a(A_0);
					break;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

		private void aa(byte[] A_0)
		{
			try
			{
				if (A_0.Length >= 6)
				{
					switch (A_0[5])
					{
					case 2:
						API.AddColorText2(this, Rtbsystem, "!!!Trả lời câu hỏi đăng nhập sai!!!", Color.Red);
						break;
					case 3:
						API.AddColorText2(this, Rtbsystem, "!!!Đăng nhập sai quá 3 lần!!!", Color.Red);
						break;
					case 9:
						API.AddColorText2(this, Rtbsystem, "!!!Mất kết nối không xác định!!!", Color.Red);
						break;
					case 17:
						API.AddColorText2(this, Rtbsystem, "!!!Phiên bản không phù hợp!!!", Color.Red);
						break;
					case 19:
						API.AddColorText2(this, Rtbsystem, "!!!Đăng nhập quá nhanh!!!", Color.Red);
						break;
					case 20:
						API.AddColorText2(this, Rtbsystem, "!!!Mất kết nối do có sự đăng nhập khác!!!", Color.Red);
						break;
					case 31:
						API.AddColorText2(this, Rtbsystem, "!!!Không thể dử dụng ID này!!!", Color.Red);
						break;
					case 56:
						API.AddColorText2(this, Rtbsystem, "!!!Máy chủ đầy!!!", Color.Red);
						break;
					default:
						API.AddColorText2(this, Rtbsystem, "!!!Đăng nhập thất bại! Mã lỗi: " + A_0[5], Color.Red);
						break;
					}
					API.AddColorText2(this, Rtbsystem, "mất kết nối được từ máy chủ(4)!", Color.Red);
					_Disconnect();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				StackTrace stackTrace = new StackTrace(true);
				stackTrace = new StackTrace(ex2, true);
				API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - Update_H0] :" + ex2.Message + stackTrace.GetFrame(0).GetFileLineNumber() + "\r\n");
				ProjectData.ClearProjectError();
			}
		}

		private void z(byte[] A_0)
		{
			checked
			{
				try
				{
					switch (A_0[5])
					{
					case 1:
					{
						if (A_0.Length < 8)
						{
							break;
						}
						int key = Convert.ToInt32(API.bytestohexstring(new byte[4]
						{
							A_0[9],
							A_0[8],
							A_0[7],
							A_0[6]
						}), 16);
						if (Data_Players.ContainsKey(key))
						{
							Listplayers._Player player = Data_Players[key];
							if (Operators.CompareString(player._Online, "ON", false) == 0)
							{
								PlayerCount--;
								player._Online = "OFF";
							}
						}
						break;
					}
					case 3:
						if (!_Check_CreatCharacter)
						{
						}
						break;
					case 6:
						API.AddColorText2(this, Rtbsystem, "ID hoặc Mật khẩu không đúng !!!", Color.Red);
						break;
					case 9:
						API.AddColorText2(this, Rtbsystem, "Đang đăng nhập...", Color.Red);
						_checkconnect = 0;
						a(versionlogin, idlogin, passlogin);
						createdchar = 0;
						break;
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					StackTrace stackTrace = new StackTrace(true);
					stackTrace = new StackTrace(ex2, true);
					API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - Update_H1] :" + ex2.Message + stackTrace.GetFrame(0).GetFileLineNumber() + "\r\n");
					ProjectData.ClearProjectError();
				}
			}
		}

		private void y(byte[] A_0)
		{
			checked
			{
				try
				{
					if (A_0.Length < 11)
					{
						return;
					}
					string text = "";
					int num = A_0.Length - 1;
					for (int i = 10; i <= num; i++)
					{
						text += Conversions.ToString(Strings.Chr(A_0[i]));
					}
					text = API.VISCII_to_Unicode(text);
					int key = Convert.ToInt32(API.bytestohexstring(new byte[4]
					{
						A_0[9],
						A_0[8],
						A_0[7],
						A_0[6]
					}), 16);
					string text2 = "";
					if (Data_Players.ContainsKey(key))
					{
						text2 = Data_Players[key]._Name;
					}
					switch (A_0[5])
					{
					case 1:
						API.AddColorText_Chat(this, Rtbchat, "[Toàn] " + text2 + ": " + text, Color.Khaki);
						break;
					case 2:
						API.AddColorText_Chat(this, Rtbchat, "[Gần] " + text2 + ": " + text, Color.Gold);
						break;
					case 3:
						if (Operators.CompareString(text2, Data_Player._Name, false) != 0)
						{
							if (Strings.LCase(text).StartsWith("!dis ") | Strings.LCase(text).StartsWith("!dis-r "))
							{
								string text3 = Strings.LCase(TextBox_RemoteDis);
								if (Operators.CompareString(Strings.LCase(text), "!dis " + text3, false) == 0)
								{
									C_CheckBox_Reconnect = false;
									API.AddColorText2(this, Rtbsystem, "Ngắt kết nối từ xa!", Color.Red);
									_Disconnect();
								}
								else if (Operators.CompareString(Strings.LCase(text), "!dis-r " + text3, false) == 0)
								{
									API.AddColorText2(this, Rtbsystem, "Ngắt kết nối từ xa, kết nối lại sau 15 phút!", Color.Red);
									_Disconnect();
									REMOTE_DIS = true;
									Delay_REMOTE_DIS = 0;
								}
							}
							else
							{
								API.AddColorText_Chat(this, Rtbchat, "[Thì thầm] " + text2 + " -> " + Data_Player._Name + ": " + text, Color.Orange);
							}
						}
						else
						{
							API.AddColorText_Chat(this, Rtbchat, "[Thì thầm] " + Data_Player._Name + " -> " + ComboBox_namePublic + ": " + text, Color.Orange);
						}
						break;
					case 4:
						API.AddColorText_Chat(this, Rtbchat, "[GM] " + text2 + ": " + text, Color.Red);
						break;
					case 5:
						API.AddColorText_Chat(this, Rtbchat, "[Đội] " + text2 + ": " + text, Color.White);
						break;
					case 6:
						API.AddColorText_Chat(this, Rtbchat, "[Đoàn] " + text2 + ": " + text, Color.DodgerBlue);
						break;
					case 7:
						API.AddColorText_Chat(this, Rtbchat, "[Liên Minh] " + text2 + ": " + text, Color.Green);
						break;
					case 11:
						API.AddColorText_Chat(this, Rtbchat, "Công bố hệ thống: " + text, Color.Red);
						break;
					case 12:
					{
						text = "";
						int num2 = A_0.Length - 1;
						for (int j = 7; j <= num2; j++)
						{
							text += Conversions.ToString(Strings.Chr(A_0[j]));
						}
						text = API.VISCII_to_Unicode(text);
						API.AddColorText_Chat(this, Rtbchat, "Công bố hệ thống: " + text, Color.Red);
						break;
					}
					default:
						API.AddColorText_Chat(this, Rtbchat, "Công bố hệ thống: " + text, Color.Red);
						break;
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					StackTrace stackTrace = new StackTrace(true);
					stackTrace = new StackTrace(ex2, true);
					API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - Update_H2] :" + ex2.Message + stackTrace.GetFrame(0).GetFileLineNumber() + "\r\n");
					ProjectData.ClearProjectError();
				}
			}
		}

		private void x(byte[] A_0)
		{
			checked
			{
				try
				{
					int num = Convert.ToInt32(API.bytestohexstring(new byte[4]
					{
						A_0[8],
						A_0[7],
						A_0[6],
						A_0[5]
					}), 16);
					int num2 = num;
					if (num2 == idlogin)
					{
						Data_Player._Id = num;
						Data_Player._Sex = A_0[9];
						Data_Player._Ghost = A_0[10];
						Data_Player._God = A_0[11];
						Data_Player._MapId = Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							A_0[13],
							A_0[12]
						}), 16);
						Data_Player._MapX = Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							A_0[15],
							A_0[14]
						}), 16);
						Data_Player._MapY = Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							A_0[17],
							A_0[16]
						}), 16);
						Data_Player._Hair = Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							A_0[20],
							A_0[19]
						}), 16);
						Data_Player._HairColor = Convert.ToInt32(API.bytestohexstring(new byte[4]
						{
							A_0[24],
							A_0[23],
							A_0[22],
							A_0[21]
						}), 16);
						Data_Player._SkinColor = Convert.ToInt32(API.bytestohexstring(new byte[4]
						{
							A_0[28],
							A_0[27],
							A_0[26],
							A_0[25]
						}), 16);
						Data_Player._MapName = MyProject.Forms.MainForm.Getmapname(Conversions.ToInteger(Data_Player._MapId.ToString()));
						string text = "";
						int num3 = 29 + A_0[29] * 2 + 8;
						int num4 = A_0.Length - 1;
						for (int i = num3; i <= num4; i++)
						{
							text += Conversions.ToString(Strings.Chr(A_0[i]));
						}
						Data_Player._Name = text;
						Data_Player._Reborn = A_0[29 + A_0[29] * 2 + 6];
						return;
					}
					int thuocTinh = A_0[10];
					string text2 = "";
					int num5 = 31 + A_0[31] * 2 + 9;
					int num6 = A_0.Length - 1;
					for (int j = num5; j <= num6 && A_0[j] != 0; j++)
					{
						text2 += Conversions.ToString(Strings.Chr(A_0[j]));
					}
					int lv = A_0[11];
					int mapId = Convert.ToInt32(API.bytestohexstring(new byte[2]
					{
						A_0[15],
						A_0[14]
					}), 16);
					int mapX = Convert.ToInt32(API.bytestohexstring(new byte[2]
					{
						A_0[17],
						A_0[16]
					}), 16);
					int mapY = Convert.ToInt32(API.bytestohexstring(new byte[2]
					{
						A_0[19],
						A_0[18]
					}), 16);
					int reborn = A_0[31 + A_0[31] * 2 + 7];
					if (Data_Players.ContainsKey(num))
					{
						PlayerCount++;
						Listplayers._Player value = Data_Players[num];
						value._Id = num;
						value._Name = text2;
						value._Lv = lv;
						value._MapId = mapId;
						value._MapX = mapX;
						value._MapY = mapY;
						value._Reborn = reborn;
						value._ThuocTinh = thuocTinh;
						value._Online = "ON";
						Data_Players[num] = value;
					}
					else
					{
						PlayerCount++;
						Listplayers._Player value2 = new Listplayers._Player
						{
							_Id = num,
							_Name = text2,
							_Lv = lv,
							_MapId = mapId,
							_MapX = mapX,
							_MapY = mapY,
							_Reborn = reborn,
							_ThuocTinh = thuocTinh,
							_Online = "ON"
						};
						Data_Players.Add(num, value2);
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					StackTrace stackTrace = new StackTrace(true);
					stackTrace = new StackTrace(ex2, true);
					API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - Update_H3] :" + ex2.Message + stackTrace.GetFrame(0).GetFileLineNumber() + "\r\n");
					ProjectData.ClearProjectError();
				}
			}
		}

		private void w(byte[] A_0)
		{
			checked
			{
				try
				{
					int num = Convert.ToInt32(API.bytestohexstring(new byte[4]
					{
						A_0[8],
						A_0[7],
						A_0[6],
						A_0[5]
					}), 16);
					int thuocTinh = A_0[10];
					string text = "";
					int num2 = 31 + A_0[31] * 2 + 9;
					int num3 = A_0.Length - 1;
					for (int i = num2; i <= num3 && A_0[i] != 0; i++)
					{
						text += Conversions.ToString(Strings.Chr(A_0[i]));
					}
					int lv = A_0[11];
					int mapId = Convert.ToInt32(API.bytestohexstring(new byte[2]
					{
						A_0[15],
						A_0[14]
					}), 16);
					int mapX = Convert.ToInt32(API.bytestohexstring(new byte[2]
					{
						A_0[17],
						A_0[16]
					}), 16);
					int mapY = Convert.ToInt32(API.bytestohexstring(new byte[2]
					{
						A_0[19],
						A_0[18]
					}), 16);
					int reborn = A_0[31 + A_0[31] * 2 + 7];
					if (Data_Players.ContainsKey(num))
					{
						Listplayers._Player value = Data_Players[num];
						value._Id = num;
						value._Name = text;
						value._Lv = lv;
						value._MapId = mapId;
						value._MapX = mapX;
						value._MapY = mapY;
						value._Reborn = reborn;
						value._ThuocTinh = thuocTinh;
						value._Online = "ON";
						Data_Players[num] = value;
					}
					else
					{
						PlayerCount++;
						Listplayers._Player value2 = new Listplayers._Player
						{
							_Id = num,
							_Name = text,
							_Lv = lv,
							_MapId = mapId,
							_MapX = mapX,
							_MapY = mapY,
							_Reborn = reborn,
							_ThuocTinh = thuocTinh,
							_Online = "ON"
						};
						Data_Players.Add(num, value2);
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					StackTrace stackTrace = new StackTrace(true);
					stackTrace = new StackTrace(ex2, true);
					API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - Update_H4] :" + ex2.Message + stackTrace.GetFrame(0).GetFileLineNumber() + "\r\n");
					ProjectData.ClearProjectError();
				}
			}
		}

		private void v(byte[] A_0)
		{
			checked
			{
				try
				{
					switch (A_0[5])
					{
					case 2:
						if (A_0.Length >= 8)
						{
							int num7 = Convert.ToInt32(API.bytestohexstring(new byte[4]
							{
								A_0[9],
								A_0[8],
								A_0[7],
								A_0[6]
							}), 16);
							string text3 = "";
							int num8 = A_0.Length - 1;
							for (int j = num8; j >= 0 && A_0[j] != 0; j += -1)
							{
								text3 = Conversions.ToString(Strings.Chr(A_0[j])) + text3;
							}
						}
						break;
					case 4:
						if (A_0.Length >= 8)
						{
							int num5 = Convert.ToInt32(API.bytestohexstring(new byte[4]
							{
								A_0[9],
								A_0[8],
								A_0[7],
								A_0[6]
							}), 16);
							string text2 = "";
							int num6 = A_0.Length - 1;
							for (int i = num6; i >= 0 && A_0[i] != 0; i += -1)
							{
								text2 = Conversions.ToString(Strings.Chr(A_0[i])) + text2;
							}
						}
						break;
					case 3:
					{
						_Value_Item_OnMap = A_0[32];
						Data_Player._ThuocTinh = A_0[6];
						Data_Player._Lv = A_0[23];
						Data_Player._ExpTotal = Convert.ToInt32(API.bytestohexstring(new byte[4]
						{
							A_0[27],
							A_0[26],
							A_0[25],
							A_0[24]
						}), 16);
						Data_Player._Point = Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							A_0[31],
							A_0[30]
						}), 16);
						Texps._Texp texp = Texps.Data_Texps[Data_Player._Lv];
						Texps._Texp texp2 = Texps.Data_Texps[Data_Player._Lv - 1];
						switch (Data_Player._Reborn)
						{
						case 0:
							Data_Player._Exp = (int)(Data_Player._ExpTotal - texp2._0 - 5);
							Data_Player._ExpMax = texp._0 - texp2._0;
							break;
						case 1:
							Data_Player._Exp = (int)(Data_Player._ExpTotal - texp._1 - 5);
							Data_Player._ExpMax = texp._1 - texp2._1;
							break;
						case 2:
							Data_Player._Exp = (int)(Data_Player._ExpTotal - texp._2 - 5);
							Data_Player._ExpMax = texp._2 - texp2._2;
							break;
						}
						Data_Player._Hp = Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							A_0[8],
							A_0[7]
						}), 16);
						Data_Player._Sp = Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							A_0[10],
							A_0[9]
						}), 16);
						Data_Player._Int = Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							A_0[12],
							A_0[11]
						}), 16);
						Data_Player._Atk = Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							A_0[14],
							A_0[13]
						}), 16);
						Data_Player._Def = Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							A_0[16],
							A_0[15]
						}), 16);
						Data_Player._Agi = Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							A_0[18],
							A_0[17]
						}), 16);
						Data_Player._Hpx = Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							A_0[20],
							A_0[19]
						}), 16);
						Data_Player._Spx = Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							A_0[22],
							A_0[21]
						}), 16);
						Data_Player._HpMax = Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							A_0[37],
							A_0[36]
						}), 16);
						Data_Player._SpMax = Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							A_0[39],
							A_0[38]
						}), 16);
						Data_Player._Atk2 = Convert.ToInt32(API.bytestohexstring(new byte[4]
						{
							A_0[43],
							A_0[42],
							A_0[41],
							A_0[40]
						}), 16);
						Data_Player._Def2 = Convert.ToInt32(API.bytestohexstring(new byte[4]
						{
							A_0[47],
							A_0[46],
							A_0[45],
							A_0[44]
						}), 16);
						Data_Player._Int2 = Convert.ToInt32(API.bytestohexstring(new byte[4]
						{
							A_0[51],
							A_0[50],
							A_0[49],
							A_0[48]
						}), 16);
						Data_Player._Agi2 = Convert.ToInt32(API.bytestohexstring(new byte[4]
						{
							A_0[55],
							A_0[54],
							A_0[53],
							A_0[52]
						}), 16);
						Data_Player._Hpx2 = Convert.ToInt32(API.bytestohexstring(new byte[4]
						{
							A_0[59],
							A_0[58],
							A_0[57],
							A_0[56]
						}), 16);
						Data_Player._Spx2 = Convert.ToInt32(API.bytestohexstring(new byte[4]
						{
							A_0[63],
							A_0[62],
							A_0[61],
							A_0[60]
						}), 16);
						if (Data_Player._Int2 >= 0)
						{
							Data_Player._Int_Plus1 = 1;
						}
						else
						{
							Data_Player._Int_Plus1 = 0;
						}
						if (Data_Player._Atk2 >= 0)
						{
							Data_Player._Atk_Plus1 = 1;
						}
						else
						{
							Data_Player._Atk_Plus1 = 0;
						}
						if (Data_Player._Def2 >= 0)
						{
							Data_Player._Def_Plus1 = 1;
						}
						else
						{
							Data_Player._Def_Plus1 = 0;
						}
						if (Data_Player._Agi2 >= 0)
						{
							Data_Player._Agi_Plus1 = 1;
						}
						else
						{
							Data_Player._Agi_Plus1 = 0;
						}
						if (Data_Player._Hpx2 >= 0)
						{
							Data_Player._Hpx_Plus1 = 1;
						}
						else
						{
							Data_Player._Hpx_Plus1 = 0;
						}
						if (Data_Player._Spx2 >= 0)
						{
							Data_Player._Spx_Plus1 = 1;
						}
						else
						{
							Data_Player._Spx_Plus1 = 0;
						}
						Data_CharListSkill.Add(10000);
						Data_CharListSkill.Add(17001);
						Data_CharListSkill.Add(18001);
						string text = API.bytestohexstring(API.ByteArrayToByteArray(A_0, 117));
						int num = 0;
						do
						{
							int num2 = API.HexToInt32(text.Substring(num, 4));
							if (!Skills.Data_Skills.ContainsKey(num2))
							{
								break;
							}
							if (num2 == 14002)
							{
								skilldaotau = 14002;
							}
							if (num2 == 11013)
							{
								skillHoiSinh = 11013;
							}
							if (num2 == 14003)
							{
								skill_buonban = API.HexToInt32(text.Substring(num + 4, 2));
							}
							Data_CharListSkill.Add(num2);
							num += 6;
						}
						while (num <= 500);
						if (Data_Player._Reborn == 3)
						{
							int num3 = A_0.Length - 4;
							Data_Player._Lv2 = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								A_0[num3 - 20],
								A_0[num3 - 21]
							}), 16);
							Data_Player._ExpTotal = Convert.ToInt64(API.bytestohexstring(new byte[8]
							{
								A_0[num3 - 12],
								A_0[num3 - 13],
								A_0[num3 - 14],
								A_0[num3 - 15],
								A_0[num3 - 16],
								A_0[num3 - 17],
								A_0[num3 - 18],
								A_0[num3 - 19]
							}), 16);
							Data_Player._Int3 = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								A_0[num3 - 10],
								A_0[num3 - 11]
							}), 16);
							Data_Player._Atk3 = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								A_0[num3 - 8],
								A_0[num3 - 9]
							}), 16);
							Data_Player._Def3 = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								A_0[num3 - 6],
								A_0[num3 - 7]
							}), 16);
							Data_Player._Hpx3 = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								A_0[num3 - 2],
								A_0[num3 - 3]
							}), 16);
							Data_Player._Spx3 = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								A_0[num3],
								A_0[num3 - 1]
							}), 16);
							Data_Player._Spx3 = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								A_0[num3],
								A_0[num3 - 1]
							}), 16);
							if (Data_Player._Lv2 == 0)
							{
								texp = Texps.Data_Texps[Data_Player._Lv2];
								Data_Player._Exp = (int)Data_Player._ExpTotal;
								Data_Player._ExpMax = texp._3;
							}
							else
							{
								texp = Texps.Data_Texps[Data_Player._Lv2];
								texp2 = Texps.Data_Texps[Data_Player._Lv2 - 1];
								Data_Player._Exp = (int)(Data_Player._ExpTotal - texp2._3);
								Data_Player._ExpMax = texp._3 - texp2._3;
							}
							int num4 = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								A_0[A_0.Length - 1],
								A_0[A_0.Length - 2]
							}), 16);
							if (num4 > 0)
							{
								Data_CharListSkill.Add(num4);
							}
						}
						if (Data_Players.ContainsKey(Data_Player._Id))
						{
							Listplayers._Player value = Data_Players[Data_Player._Id];
							value._Id = Data_Player._Id;
							value._Name = Data_Player._Name;
							value._Lv = Data_Player._Lv;
							value._MapId = Data_Player._MapId;
							value._MapX = Data_Player._MapX;
							value._MapY = Data_Player._MapY;
							value._Reborn = Data_Player._Reborn;
							value._ThuocTinh = Data_Player._ThuocTinh;
							value._Online = "ON";
							Data_Players[Data_Player._Id] = value;
						}
						else
						{
							PlayerCount++;
							Listplayers._Player value2 = new Listplayers._Player
							{
								_Id = Data_Player._Id,
								_Name = Data_Player._Name,
								_Lv = Data_Player._Lv,
								_MapId = Data_Player._MapId,
								_MapX = Data_Player._MapX,
								_MapY = Data_Player._MapY,
								_Reborn = Data_Player._Reborn,
								_ThuocTinh = Data_Player._ThuocTinh,
								_Online = "ON"
							};
							Data_Players.Add(Data_Player._Id, value2);
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
					API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - Update_H5] :" + ex2.Message + stackTrace.GetFrame(0).GetFileLineNumber() + "\r\n");
					ProjectData.ClearProjectError();
				}
			}
		}

		private void u(byte[] A_0)
		{
		}

		private void t(byte[] A_0)
		{
			try
			{
				switch (A_0[5])
				{
				case 1:
					checked
					{
						switch (A_0[6])
						{
						case 25:
							if (A_0[7] != 1)
							{
								break;
							}
							Data_Player._Hp = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								A_0[9],
								A_0[8]
							}), 16);
							switch (Battle)
							{
							case 0:
								if (C_CheckBox_AutoEat)
								{
									CharEatHp();
								}
								break;
							case 1:
							{
								int num8 = 1;
								do
								{
									if (Data_Battles[num8]._Type == 2 && Operators.ConditionalCompareObjectEqual(this.get_DataBattle(num8, _Data.Type_Battleinfo._Type), 2, false) && Operators.ConditionalCompareObjectEqual(this.get_DataBattle(num8, _Data.Type_Battleinfo._Id), Data_Player._Id, false))
									{
										this.set_DataBattle(num8, _Data.Type_Battleinfo._Hp, (object)Data_Player._Hp);
									}
									num8++;
								}
								while (num8 <= 20);
								break;
							}
							}
							break;
						case 26:
							if (A_0[7] != 1)
							{
								break;
							}
							Data_Player._Sp = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								A_0[9],
								A_0[8]
							}), 16);
							switch (Battle)
							{
							case 0:
								if (C_CheckBox_AutoEat)
								{
									CharEatSp();
								}
								break;
							case 1:
							{
								int num7 = 1;
								do
								{
									if (Operators.ConditionalCompareObjectEqual(this.get_DataBattle(num7, _Data.Type_Battleinfo._Type), 2, false) && Operators.ConditionalCompareObjectEqual(this.get_DataBattle(num7, _Data.Type_Battleinfo._Id), Data_Player._Id, false))
									{
										this.set_DataBattle(num7, _Data.Type_Battleinfo._Sp, (object)Data_Player._Sp);
									}
									num7++;
								}
								while (num7 <= 20);
								break;
							}
							}
							break;
						case 27:
							Data_Player._Int = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								A_0[9],
								A_0[8]
							}), 16);
							break;
						case 28:
							Data_Player._Atk = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								A_0[9],
								A_0[8]
							}), 16);
							break;
						case 29:
							Data_Player._Def = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								A_0[9],
								A_0[8]
							}), 16);
							break;
						case 30:
							Data_Player._Agi = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								A_0[9],
								A_0[8]
							}), 16);
							break;
						case 31:
							Data_Player._Hpx = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								A_0[9],
								A_0[8]
							}), 16);
							break;
						case 32:
							Data_Player._Spx = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								A_0[9],
								A_0[8]
							}), 16);
							break;
						case 35:
						{
							int reborn2 = Data_Player._Reborn;
							if (reborn2 == 3)
							{
								Data_Player._Lv2 = A_0[8];
							}
							else
							{
								Data_Player._Lv = A_0[8];
							}
							break;
						}
						case 36:
						{
							if (A_0[7] != 1)
							{
								break;
							}
							int num5 = Convert.ToInt32(API.bytestohexstring(new byte[4]
							{
								A_0[11],
								A_0[10],
								A_0[9],
								A_0[8]
							}), 16);
							int num6 = (int)(num5 - Data_Player._ExpTotal);
							if (num6 > 0)
							{
								_checkdisExp = (int)time_online;
							}
							API.AddColorText_battle2(this, RtbBattle, Data_Player._Name + " nhận được : " + num6 + " exp", Color.Green);
							_BattleInfo_ExpChar = num6;
							Data_Player._Texp += num6;
							if (unchecked(time_online / 60) == 0)
							{
								Data_Player._ExpMin = Data_Player._Texp;
							}
							else
							{
								Data_Player._ExpMin = (int)Math.Round(Conversion.Val((double)Data_Player._Texp / ((double)time_online / 60.0)));
							}
							Data_Player._ExpTotal = Convert.ToInt32(API.bytestohexstring(new byte[4]
							{
								A_0[11],
								A_0[10],
								A_0[9],
								A_0[8]
							}), 16);
							Texps._Texp texp3 = Texps.Data_Texps[Data_Player._Lv];
							Texps._Texp texp4 = Texps.Data_Texps[Data_Player._Lv - 1];
							switch (Data_Player._Reborn)
							{
							case 0:
								Data_Player._Exp = (int)(Data_Player._ExpTotal - texp4._0 - 5);
								Data_Player._ExpMax = texp3._0 - texp4._0;
								break;
							case 1:
								Data_Player._Exp = (int)(Data_Player._ExpTotal - texp4._1 - 5);
								Data_Player._ExpMax = texp3._1 - texp4._1;
								break;
							case 2:
								Data_Player._Exp = (int)(Data_Player._ExpTotal - texp4._2 - 5);
								Data_Player._ExpMax = texp3._2 - texp4._2;
								break;
							case 3:
								if (Data_Player._Lv2 == 0)
								{
									texp3 = Texps.Data_Texps[Data_Player._Lv2];
									Data_Player._Exp = (int)Data_Player._ExpTotal;
									Data_Player._ExpMax = texp3._3;
								}
								else
								{
									texp3 = Texps.Data_Texps[Data_Player._Lv2];
									texp4 = Texps.Data_Texps[Data_Player._Lv2 - 1];
									Data_Player._Exp = (int)(Data_Player._ExpTotal - texp4._3);
									Data_Player._ExpMax = texp3._3 - texp4._3;
								}
								break;
							}
							break;
						}
						case 38:
							Data_Player._Point = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								A_0[9],
								A_0[8]
							}), 16);
							break;
						case 208:
							switch (A_0[7])
							{
							case 1:
								Data_Player._Spx_Plus1 = 1;
								break;
							case 2:
								Data_Player._Spx_Plus1 = 0;
								break;
							}
							Data_Player._Spx2 = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								A_0[9],
								A_0[8]
							}), 16);
							break;
						case 209:
							switch (A_0[7])
							{
							case 1:
								Data_Player._Hpx_Plus1 = 1;
								break;
							case 2:
								Data_Player._Hpx_Plus1 = 0;
								break;
							}
							Data_Player._Hpx2 = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								A_0[9],
								A_0[8]
							}), 16);
							break;
						case 210:
							switch (A_0[7])
							{
							case 1:
								Data_Player._Atk_Plus1 = 1;
								break;
							case 2:
								Data_Player._Atk_Plus1 = 0;
								break;
							}
							Data_Player._Atk2 = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								A_0[9],
								A_0[8]
							}), 16);
							break;
						case 211:
							switch (A_0[7])
							{
							case 1:
								Data_Player._Def_Plus1 = 1;
								break;
							case 2:
								Data_Player._Def_Plus1 = 0;
								break;
							}
							Data_Player._Def2 = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								A_0[9],
								A_0[8]
							}), 16);
							break;
						case 212:
							switch (A_0[7])
							{
							case 1:
								Data_Player._Int_Plus1 = 1;
								break;
							case 2:
								Data_Player._Int_Plus1 = 0;
								break;
							}
							Data_Player._Int2 = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								A_0[9],
								A_0[8]
							}), 16);
							break;
						case 214:
							switch (A_0[7])
							{
							case 1:
								Data_Player._Agi_Plus1 = 1;
								break;
							case 2:
								Data_Player._Agi_Plus1 = 0;
								break;
							}
							Data_Player._Agi2 = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								A_0[9],
								A_0[8]
							}), 16);
							break;
						case 81:
							switch (A_0[7])
							{
							case 1:
								Data_Player._Int_Plus2 = 1;
								break;
							case 2:
								Data_Player._Int_Plus2 = 0;
								break;
							}
							Data_Player._Int3 = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								A_0[9],
								A_0[8]
							}), 16);
							break;
						case 82:
							switch (A_0[7])
							{
							case 1:
								Data_Player._Atk_Plus2 = 1;
								break;
							case 2:
								Data_Player._Atk_Plus2 = 0;
								break;
							}
							Data_Player._Atk3 = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								A_0[9],
								A_0[8]
							}), 16);
							break;
						case 83:
							switch (A_0[7])
							{
							case 1:
								Data_Player._Def_Plus2 = 1;
								break;
							case 2:
								Data_Player._Def_Plus2 = 0;
								break;
							}
							Data_Player._Def3 = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								A_0[9],
								A_0[8]
							}), 16);
							break;
						case 84:
							switch (A_0[7])
							{
							case 1:
								Data_Player._Hpx_Plus2 = 1;
								break;
							case 2:
								Data_Player._Hpx_Plus2 = 0;
								break;
							}
							Data_Player._Hpx3 = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								A_0[9],
								A_0[8]
							}), 16);
							break;
						case 85:
							switch (A_0[7])
							{
							case 1:
								Data_Player._Spx_Plus2 = 1;
								break;
							case 2:
								Data_Player._Spx_Plus2 = 0;
								break;
							}
							Data_Player._Spx3 = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								A_0[9],
								A_0[8]
							}), 16);
							break;
						}
						break;
					}
				case 2:
					switch (A_0[9])
					{
					case 25:
						this.set_DataPets((int)A_0[7], _Data.Type_Pets._Hp, (object)Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							A_0[12],
							A_0[11]
						}), 16));
						if (C_CheckBox_AutoEat & (Battle == 0))
						{
							PetEatHp();
						}
						break;
					case 26:
						this.set_DataPets((int)A_0[7], _Data.Type_Pets._Sp, (object)Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							A_0[12],
							A_0[11]
						}), 16));
						if (C_CheckBox_AutoEat & (Battle == 0))
						{
							PetEatHp();
						}
						break;
					case 27:
						this.set_DataPets((int)A_0[7], _Data.Type_Pets._Int, (object)Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							A_0[12],
							A_0[11]
						}), 16));
						break;
					case 28:
						this.set_DataPets((int)A_0[7], _Data.Type_Pets._Atk, (object)Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							A_0[12],
							A_0[11]
						}), 16));
						break;
					case 29:
						this.set_DataPets((int)A_0[7], _Data.Type_Pets._Def, (object)Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							A_0[12],
							A_0[11]
						}), 16));
						break;
					case 30:
						this.set_DataPets((int)A_0[7], _Data.Type_Pets._Agi, (object)Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							A_0[12],
							A_0[11]
						}), 16));
						break;
					case 31:
						this.set_DataPets((int)A_0[7], _Data.Type_Pets._Hpx, (object)Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							A_0[12],
							A_0[11]
						}), 16));
						break;
					case 32:
						this.set_DataPets((int)A_0[7], _Data.Type_Pets._Spx, (object)Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							A_0[12],
							A_0[11]
						}), 16));
						break;
					case 35:
						this.set_DataPets((int)A_0[7], _Data.Type_Pets._Lv, (object)Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							A_0[12],
							A_0[11]
						}), 16));
						break;
					case 36:
					{
						_Data._Pets pets = Data_PetsInfo[A_0[7]];
						Texps._Texp texp = Texps.Data_Texps[pets._Lv];
						int num;
						int num2;
						int num3;
						int num4;
						checked
						{
							Texps._Texp texp2 = Texps.Data_Texps[pets._Lv - 1];
							num = Convert.ToInt32(API.bytestohexstring(new byte[4]
							{
								A_0[14],
								A_0[13],
								A_0[12],
								A_0[11]
							}), 16);
							num2 = num - texp2._0;
							num3 = texp._0 - texp2._0;
							int reborn = Npcs.Data_Npcs[pets._Id]._Reborn;
							if (reborn == 2)
							{
								num2 = num - texp2._1;
								num3 = texp._1 - texp2._1;
							}
							num4 = num - Data_PetInfo._ExpTotal;
							API.AddColorText_battle2(this, RtbBattle, Data_PetInfo._Name + " nhận được : " + num4 + " exp", Color.Green);
							_BattleInfo_ExpPet = num4;
						}
						if (A_0[7] == PetBattle)
						{
							int stt;
							string tExp;
							this.set_DataPets(stt = A_0[7], tExp = _Data.Type_Pets._TExp, Operators.AddObject(this.get_DataPets(stt, tExp), num4));
							if (time_online / 60 == 0)
							{
								this.set_DataPets((int)A_0[7], _Data.Type_Pets._ExpMin, (object)Data_PetInfo._Texp);
							}
							else
							{
								this.set_DataPets((int)A_0[7], _Data.Type_Pets._ExpMin, (object)checked((int)Math.Round(Conversion.Val((double)Data_PetInfo._Texp / ((double)time_online / 60.0)))));
							}
						}
						this.set_DataPets((int)A_0[7], _Data.Type_Pets._ExpTotal, (object)num);
						this.set_DataPets((int)A_0[7], _Data.Type_Pets._Exp, (object)num2);
						this.set_DataPets((int)A_0[7], _Data.Type_Pets._ExpMax, (object)num3);
						pets = default(_Data._Pets);
						break;
					}
					case 64:
						this.set_DataPets((int)A_0[7], _Data.Type_Pets._Fai, (object)Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							A_0[12],
							A_0[11]
						}), 16));
						break;
					case 208:
						switch (A_0[10])
						{
						case 1:
							this.set_DataPets((int)A_0[7], _Data.Type_Pets._Spx3, (object)1);
							break;
						case 2:
							this.set_DataPets((int)A_0[7], _Data.Type_Pets._Spx3, (object)0);
							break;
						}
						this.set_DataPets((int)A_0[7], _Data.Type_Pets._Spx2, (object)Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							A_0[12],
							A_0[11]
						}), 16));
						break;
					case 209:
						switch (A_0[10])
						{
						case 1:
							this.set_DataPets((int)A_0[7], _Data.Type_Pets._Hpx3, (object)1);
							break;
						case 2:
							this.set_DataPets((int)A_0[7], _Data.Type_Pets._Hpx3, (object)0);
							break;
						}
						this.set_DataPets((int)A_0[7], _Data.Type_Pets._Hpx2, (object)Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							A_0[12],
							A_0[11]
						}), 16));
						break;
					case 210:
						switch (A_0[10])
						{
						case 1:
							this.set_DataPets((int)A_0[7], _Data.Type_Pets._Atk3, (object)1);
							break;
						case 2:
							this.set_DataPets((int)A_0[7], _Data.Type_Pets._Atk3, (object)0);
							break;
						}
						this.set_DataPets((int)A_0[7], _Data.Type_Pets._Atk2, (object)Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							A_0[12],
							A_0[11]
						}), 16));
						break;
					case 211:
						switch (A_0[10])
						{
						case 1:
							this.set_DataPets((int)A_0[7], _Data.Type_Pets._Def3, (object)1);
							break;
						case 2:
							this.set_DataPets((int)A_0[7], _Data.Type_Pets._Def3, (object)0);
							break;
						}
						this.set_DataPets((int)A_0[7], _Data.Type_Pets._Def2, (object)Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							A_0[12],
							A_0[11]
						}), 16));
						break;
					case 212:
						switch (A_0[10])
						{
						case 1:
							this.set_DataPets((int)A_0[7], _Data.Type_Pets._Int3, (object)1);
							break;
						case 2:
							this.set_DataPets((int)A_0[7], _Data.Type_Pets._Int3, (object)0);
							break;
						}
						this.set_DataPets((int)A_0[7], _Data.Type_Pets._Int2, (object)Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							A_0[12],
							A_0[11]
						}), 16));
						break;
					case 214:
						switch (A_0[10])
						{
						case 1:
							this.set_DataPets((int)A_0[7], _Data.Type_Pets._Agi3, (object)1);
							break;
						case 2:
							this.set_DataPets((int)A_0[7], _Data.Type_Pets._Agi3, (object)0);
							break;
						}
						this.set_DataPets((int)A_0[7], _Data.Type_Pets._Agi2, (object)Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							A_0[12],
							A_0[11]
						}), 16));
						break;
					}
					break;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				StackTrace stackTrace = new StackTrace(true);
				stackTrace = new StackTrace(ex2, true);
				API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - Update_H8] :" + ex2.Message + stackTrace.GetFrame(0).GetFileLineNumber() + "\r\n");
				ProjectData.ClearProjectError();
			}
		}

		private void s(byte[] A_0)
		{
			try
			{
				byte b = A_0[5];
				if (b == 1)
				{
					SendPacket(API.hexstringtobyte("F44402000301"));
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				StackTrace stackTrace = new StackTrace(true);
				stackTrace = new StackTrace(ex2, true);
				API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - Update_H9] :" + ex2.Message + stackTrace.GetFrame(0).GetFileLineNumber() + "\r\n");
				ProjectData.ClearProjectError();
			}
		}

		private void r(byte[] A_0)
		{
			checked
			{
				try
				{
					byte b = A_0[5];
					switch (b)
					{
					case 1:
						if (b == 1)
						{
							int location = GetLocation2(A_0[6].ToString("X2") + A_0[7].ToString("X2"));
							_Data._Battleinfo value = Data_Battles[location];
							value._Id = 0;
							value._Name = "";
							value._Lv = 0;
							value._Hp = 0;
							value._HpMax = 0;
							value._Sp = 0;
							value._SpMax = 0;
							value._ThuocTinh = 0;
							value._Type = 0;
							value._IdChar = 0;
							value._Color = Color.Black;
							Data_Battles[location] = value;
						}
						break;
					case 0:
					{
						int num17 = Convert.ToInt32(API.bytestohexstring(new byte[4]
						{
							A_0[9],
							A_0[8],
							A_0[7],
							A_0[6]
						}), 16);
						if ((num17 == Data_Player._Id) | (num17 == Data_Player._LeaderId))
						{
							int num18 = 1;
							do
							{
								Data_Battles[num18] = default(_Data._Battleinfo);
								num18++;
							}
							while (num18 <= 20);
							turn = 0;
							if (BTQ == 1)
							{
							}
							if (Battle == 1)
							{
								a();
							}
						}
						break;
					}
					case 5:
					{
						int num9 = API.HexToInt32(API.bytestohexstring(A_0).Substring(16, 8));
						int num10 = API.HexToInt32(API.bytestohexstring(A_0).Substring(28, 8));
						string a_2 = API.bytestohexstring(A_0).Substring(36, 4);
						int num11 = API.HexToInt32(API.bytestohexstring(A_0).Substring(48, 4));
						int num12 = API.HexToInt32(API.bytestohexstring(A_0).Substring(40, 4));
						int num13 = API.HexToInt32(API.bytestohexstring(A_0).Substring(52, 4));
						int num14 = API.HexToInt32(API.bytestohexstring(A_0).Substring(44, 4));
						int num15 = A_0[28];
						int num16 = A_0[29];
						string text4 = "";
						byte b2 = A_0[7];
						if (b2 == 2)
						{
							text4 = GetNamePlayer(num9);
							if (TextBox_IDmem1 != 0 && TextBox_IDmem1 == num9)
							{
								_checkdisparty++;
							}
							if (TextBox_IDmem2 != 0 && TextBox_IDmem2 == num9)
							{
								_checkdisparty++;
							}
							if (TextBox_IDmem3 != 0 && TextBox_IDmem3 == num9)
							{
								_checkdisparty++;
							}
							if (TextBox_IDmem4 != 0 && TextBox_IDmem4 == num9)
							{
								_checkdisparty++;
							}
						}
						else
						{
							text4 = GetNameNPC(num9);
						}
						this.set_DataBattle(a(a_2), _Data.Type_Battleinfo._Id, (object)num9);
						this.set_DataBattle(a(a_2), _Data.Type_Battleinfo._Name, (object)text4);
						this.set_DataBattle(a(a_2), _Data.Type_Battleinfo._Lv, (object)num15);
						this.set_DataBattle(a(a_2), _Data.Type_Battleinfo._Hp, (object)num11);
						this.set_DataBattle(a(a_2), _Data.Type_Battleinfo._HpMax, (object)num12);
						this.set_DataBattle(a(a_2), _Data.Type_Battleinfo._Sp, (object)num13);
						this.set_DataBattle(a(a_2), _Data.Type_Battleinfo._SpMax, (object)num14);
						this.set_DataBattle(a(a_2), _Data.Type_Battleinfo._ThuocTinh, (object)num16);
						this.set_DataBattle(a(a_2), _Data.Type_Battleinfo._Type, (object)unchecked((int)A_0[7]));
						this.set_DataBattle(a(a_2), _Data.Type_Battleinfo._IdChar, (object)num10);
						this.set_DataBattle(a(a_2), _Data.Type_Battleinfo._Color, (object)API.GetColor(A_0[29]));
						if ((num9 == Data_PetInfo._Id) & (Char_col == A_0[19]))
						{
							this.set_DataPets(PetBattle, _Data.Type_Pets._Hp, (object)num11);
							this.set_DataPets(PetBattle, _Data.Type_Pets._Sp, (object)num13);
							this.set_DataPets(PetBattle, _Data.Type_Pets._HpMax, (object)num12);
							this.set_DataPets(PetBattle, _Data.Type_Pets._SpMax, (object)num14);
						}
						API.AddColorText_battle2(this, RtbBattle, text4 + " " + Conversions.ToString(num16) + " Cấp:" + Conversions.ToString(num15) + " HP:" + Conversions.ToString(num11) + "/" + Conversions.ToString(num12) + " SP:" + Conversions.ToString(num13) + "/" + Conversions.ToString(num14), Color.Purple);
						break;
					}
					case 250:
					{
						_checkdisparty = 0;
						this.m_v = (int)(time_online + 999999);
						string text = API.bytestohexstring(A_0).Substring(16);
						while (text.Length != 0)
						{
							string text2 = text.Substring(0, 48);
							byte[] array = API.hexstringtobyte(text2);
							int num = API.HexToInt32(text2.Substring(4, 8));
							int num2 = API.HexToInt32(text2.Substring(26, 8));
							string a_ = text2.Substring(24, 4);
							string text3 = "";
							text3 = ((GetNamePlayer(num).Length <= 0) ? GetNameNPC(num) : GetNamePlayer(num));
							int num3 = API.HexToInt32(text2.Substring(36, 4));
							int num4 = API.HexToInt32(text2.Substring(28, 4));
							int num5 = API.HexToInt32(text2.Substring(40, 4));
							int num6 = API.HexToInt32(text2.Substring(32, 4));
							int num7 = array[22];
							int num8 = A_0[23];
							this.set_DataBattle(a(a_), _Data.Type_Battleinfo._Id, (object)num);
							this.set_DataBattle(a(a_), _Data.Type_Battleinfo._Name, (object)text3);
							this.set_DataBattle(a(a_), _Data.Type_Battleinfo._Lv, (object)num7);
							this.set_DataBattle(a(a_), _Data.Type_Battleinfo._Hp, (object)num3);
							this.set_DataBattle(a(a_), _Data.Type_Battleinfo._HpMax, (object)num4);
							this.set_DataBattle(a(a_), _Data.Type_Battleinfo._Sp, (object)num5);
							this.set_DataBattle(a(a_), _Data.Type_Battleinfo._SpMax, (object)num6);
							this.set_DataBattle(a(a_), _Data.Type_Battleinfo._ThuocTinh, (object)num8);
							this.set_DataBattle(a(a_), _Data.Type_Battleinfo._Type, (object)2);
							this.set_DataBattle(a(a_), _Data.Type_Battleinfo._IdChar, (object)num2);
							this.set_DataBattle(a(a_), _Data.Type_Battleinfo._Color, (object)API.GetColor(array[23]));
							if (num == Data_Player._Id)
							{
								Char_col = array[13];
								Battle = 1;
								turn = 0;
								_BattleInfo_ExpChar = 0;
								_BattleInfo_ExpPet = 0;
								Status = "Trận đấu bắt đầu";
								Button_bot = true;
								API.AddColorText_battle2(this, RtbBattle, "==================== Trận đấu bắt đầu ====================", Color.Red);
								packetAutoContribute = "";
								if (C_CheckBox_QuestProtect)
								{
									if (Operators.CompareString(API.ServerIp, "159.196.70.237", false) == 0)
									{
										SendPacket(API.hexstringtobyte("F444040014890000"));
									}
								}
								else if (Operators.CompareString(API.ServerIp, "159.196.70.237", false) == 0)
								{
									SendPacket(API.hexstringtobyte("F444040014900000"));
								}
							}
							API.AddColorText_battle2(this, RtbBattle, text3 + " " + Conversions.ToString(num8) + " Cấp:" + Conversions.ToString(num7) + " HP:" + Conversions.ToString(num3) + "/" + Conversions.ToString(num4) + " SP:" + Conversions.ToString(num5) + "/" + Conversions.ToString(num6), Color.Black);
							text = text.Replace(text2, "");
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
					API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - Update_HB] :" + ex2.Message + stackTrace.GetFrame(0).GetFileLineNumber() + "\r\n");
					ProjectData.ClearProjectError();
				}
			}
		}

		private void q(byte[] A_0)
		{
			try
			{
				int num = Convert.ToInt32(API.bytestohexstring(new byte[4]
				{
					A_0[8],
					A_0[7],
					A_0[6],
					A_0[5]
				}), 16);
				if (num != Data_Player._Id)
				{
					return;
				}
				if (Data_NpcInMap.Count > 0)
				{
					Data_NpcInMap.Clear();
				}
				SendPacket(API.hexstringtobyte("F44402001730"));
				SendPacket(API.hexstringtobyte("F44402000C01"));
				if (C_CheckBox_OpenMachine)
				{
					OpenMachineBox();
				}
				int num2 = 0;
				do
				{
					Data_ItemOnMaps[num2] = default(_Data._ItemOnMap);
					num2 = checked(num2 + 1);
				}
				while (num2 <= 254);
				Data_Player._MapId = Convert.ToInt32(API.bytestohexstring(new byte[2]
				{
					A_0[10],
					A_0[9]
				}), 16);
				Data_Player._MapX = Convert.ToInt32(API.bytestohexstring(new byte[2]
				{
					A_0[12],
					A_0[11]
				}), 16);
				Data_Player._MapY = Convert.ToInt32(API.bytestohexstring(new byte[2]
				{
					A_0[14],
					A_0[13]
				}), 16);
				Data_Player._MapName = MyProject.Forms.MainForm.Getmapname(Conversions.ToInteger(Data_Player._MapId.ToString()));
				Thread.Sleep(200);
				if ((Data_Player._LeaderId == Data_Player._Id) | (Data_Player._LeaderId == 0))
				{
					if ((atw == 1) & (listWarp.Count > 0) & (BTQ == 0))
					{
						SendEnd();
						if ((Data_Player._MapId == 58000) & (Conversions.ToDouble(AutoWarptoMap) != 58000.0))
						{
							Warp(1);
						}
						else
						{
							string text = Data_Player._MapId.ToString();
							int num3 = 0;
							string autoWarptoMap = AutoWarptoMap;
							if (Operators.CompareString(autoWarptoMap, Conversions.ToString(55000), false) == 0)
							{
								string left = text;
								if (Operators.CompareString(left, Conversions.ToString(11000), false) == 0)
								{
									num3 = 1;
									Warp(11);
								}
								else if (Operators.CompareString(left, Conversions.ToString(58000), false) == 0)
								{
									num3 = 1;
									Warp(1);
								}
							}
							else if (Operators.CompareString(autoWarptoMap, Conversions.ToString(58000), false) == 0)
							{
								string left2 = text;
								if (Operators.CompareString(left2, Conversions.ToString(11000), false) == 0)
								{
									num3 = 1;
									Warp(11);
								}
								else if (Operators.CompareString(left2, Conversions.ToString(55000), false) == 0)
								{
									num3 = 1;
									Warp(1);
								}
							}
							if (num3 == 0)
							{
								string mapIdNext = GetMapIdNext(listWarp, text);
								int warpID = GetWarpID(text, mapIdNext);
								if (Operators.CompareString(mapIdNext, AutoWarptoMap, false) == 0)
								{
									if (warpID > 0)
									{
										Warp(warpID);
									}
									else
									{
										listWarp.Clear();
										atw = 0;
									}
								}
								else if (Operators.CompareString(mapIdNext, AutoWarptoMap, false) != 0)
								{
									if (warpID > 0)
									{
										Warp(warpID);
									}
									else
									{
										listWarp.Clear();
										atw = 0;
									}
								}
							}
						}
					}
					else
					{
						SendEnd();
					}
				}
				if ((Data_Player._MapId >= 10850) & (Data_Player._MapId <= 10870))
				{
					SendEnd();
					Walk(1262, 255);
					string text2 = "F44404001401" + API.Int32ToHex2(2) + "F444030014091EF44402001406F44402001406F44402001406F44402001406F44402001406F44402001406F44402001406F44402001406F44402001406F444040014080200F444030014091EF44402001406F44402001406";
					SendPacket(API.hexstringtobyte(text2));
					createdchar = 1;
				}
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
						AutoWarptoMap = "12223";
						AutoWarp(AutoWarptoMap);
					}
				}
				if (API.Proxy & API.List_Ip_nts.Contains(API.ServerIp))
				{
					if (API.Vip == 0)
					{
						try
						{
							int textBox_IDmem = TextBox_IDmem1;
							int textBox_IDmem2 = TextBox_IDmem2;
							int textBox_IDmem3 = TextBox_IDmem3;
							int textBox_IDmem4 = TextBox_IDmem4;
							byte[] packet = API.hexstringtobyte(API.Packet_Maker("080D" + API.Int32ToHex4(textBox_IDmem) + API.Vip.ToString("X2")));
							byte[] packet2 = API.hexstringtobyte(API.Packet_Maker("080D" + API.Int32ToHex4(textBox_IDmem2) + API.Vip.ToString("X2")));
							byte[] packet3 = API.hexstringtobyte(API.Packet_Maker("080D" + API.Int32ToHex4(textBox_IDmem3) + API.Vip.ToString("X2")));
							byte[] packet4 = API.hexstringtobyte(API.Packet_Maker("080D" + API.Int32ToHex4(textBox_IDmem4) + API.Vip.ToString("X2")));
							_Local_SendPacket(packet);
							_Local_SendPacket(packet2);
							_Local_SendPacket(packet3);
							_Local_SendPacket(packet4);
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							ProjectData.ClearProjectError();
						}
					}
					else
					{
						try
						{
							int textBox_IDmem5 = TextBox_IDmem1;
							int textBox_IDmem6 = TextBox_IDmem2;
							int textBox_IDmem7 = TextBox_IDmem3;
							int textBox_IDmem8 = TextBox_IDmem4;
							byte[] packet5 = API.hexstringtobyte(API.Packet_Maker("080D" + API.Int32ToHex4(textBox_IDmem5) + API.Vip.ToString("X2")));
							byte[] packet6 = API.hexstringtobyte(API.Packet_Maker("080D" + API.Int32ToHex4(textBox_IDmem6) + API.Vip.ToString("X2")));
							byte[] packet7 = API.hexstringtobyte(API.Packet_Maker("080D" + API.Int32ToHex4(textBox_IDmem7) + API.Vip.ToString("X2")));
							byte[] packet8 = API.hexstringtobyte(API.Packet_Maker("080D" + API.Int32ToHex4(textBox_IDmem8) + API.Vip.ToString("X2")));
							_Local_SendPacket(packet5);
							_Local_SendPacket(packet6);
							_Local_SendPacket(packet7);
							_Local_SendPacket(packet8);
						}
						catch (Exception ex3)
						{
							ProjectData.SetProjectError(ex3);
							Exception ex4 = ex3;
							ProjectData.ClearProjectError();
						}
					}
					ArrayList arrayList = new ArrayList();
					switch (API.Style)
					{
					case 0:
						arrayList = API.List_Style0;
						break;
					case 1:
						arrayList = API.List_Style1;
						break;
					case 2:
						arrayList = API.List_Style2;
						break;
					case 3:
						arrayList = API.List_Style3;
						break;
					case 4:
						arrayList = API.List_Style4;
						break;
					}
					int num4 = Conversions.ToInteger(arrayList[0]);
					int num5 = Conversions.ToInteger(arrayList[1]);
					int num6 = Conversions.ToInteger(arrayList[2]);
					int num7 = Conversions.ToInteger(arrayList[3]);
					int num8 = Conversions.ToInteger(arrayList[4]);
					string text3 = "";
					if (num4 > 0)
					{
						text3 = text3 + API.Int32ToHex2(num4) + "0000000000000000";
					}
					if (num5 > 0)
					{
						text3 = text3 + API.Int32ToHex2(num5) + "0000000000000000";
					}
					if (num6 > 0)
					{
						text3 = text3 + API.Int32ToHex2(num6) + "0000000000000000";
					}
					if (num7 > 0)
					{
						text3 = text3 + API.Int32ToHex2(num7) + "0000000000000000";
					}
					if (num8 > 0)
					{
						text3 = text3 + API.Int32ToHex2(num8) + "0000000000000000";
					}
					byte[] packet9 = API.hexstringtobyte(API.Packet_Maker("170B" + text3));
					_Local_SendPacket(packet9);
					text3 = "";
					if (num4 > 0)
					{
						text3 += API.Int32ToHex2(num4);
					}
					if (num5 > 0)
					{
						text3 += API.Int32ToHex2(num5);
					}
					if (num6 > 0)
					{
						text3 += API.Int32ToHex2(num6);
					}
					if (num7 > 0)
					{
						text3 += API.Int32ToHex2(num7);
					}
					if (num8 > 0)
					{
						text3 += API.Int32ToHex2(num8);
					}
					int textBox_IDmem9 = TextBox_IDmem1;
					int textBox_IDmem10 = TextBox_IDmem2;
					int textBox_IDmem11 = TextBox_IDmem3;
					int textBox_IDmem12 = TextBox_IDmem4;
					byte[] packet10 = API.hexstringtobyte(API.Packet_Maker("0500" + API.Int32ToHex4(textBox_IDmem9) + text3));
					byte[] packet11 = API.hexstringtobyte(API.Packet_Maker("0500" + API.Int32ToHex4(textBox_IDmem10) + text3));
					byte[] packet12 = API.hexstringtobyte(API.Packet_Maker("0500" + API.Int32ToHex4(textBox_IDmem11) + text3));
					byte[] packet13 = API.hexstringtobyte(API.Packet_Maker("0500" + API.Int32ToHex4(textBox_IDmem12) + text3));
					_Local_SendPacket(packet10);
					_Local_SendPacket(packet11);
					_Local_SendPacket(packet12);
					_Local_SendPacket(packet13);
					if (API.IDNgua > 0)
					{
						packet10 = API.hexstringtobyte(API.Packet_Maker("0F05" + API.Int32ToHex4(textBox_IDmem9) + API.Int32ToHex4(API.IDNgua) + "00000000"));
						packet11 = API.hexstringtobyte(API.Packet_Maker("0F05" + API.Int32ToHex4(textBox_IDmem10) + API.Int32ToHex4(API.IDNgua) + "00000000"));
						packet12 = API.hexstringtobyte(API.Packet_Maker("0F05" + API.Int32ToHex4(textBox_IDmem11) + API.Int32ToHex4(API.IDNgua) + "00000000"));
						packet13 = API.hexstringtobyte(API.Packet_Maker("0F05" + API.Int32ToHex4(textBox_IDmem12) + API.Int32ToHex4(API.IDNgua) + "00000000"));
						_Local_SendPacket(packet10);
						_Local_SendPacket(packet11);
						_Local_SendPacket(packet12);
						_Local_SendPacket(packet13);
					}
				}
				if (bott == 1)
				{
					StartBot();
				}
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				StackTrace stackTrace = new StackTrace(true);
				stackTrace = new StackTrace(ex6, true);
				API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - Update_HC] :" + ex6.Message + stackTrace.GetFrame(0).GetFileLineNumber() + "\r\n");
				ProjectData.ClearProjectError();
			}
		}

		private void p(byte[] A_0)
		{
			try
			{
				switch (A_0[5])
				{
				case 1:
				{
					int num2 = API.HexToInt32(API.bytestohexstring(A_0).Substring(12, 8));
					string namePlayer2 = GetNamePlayer(num2);
					API.AddColorText2(this, Rtbsystem, namePlayer2 + " xin vào nhóm", Color.Blue);
					if ((num2 == TextBox_IDmem1) | (num2 == TextBox_IDmem2) | (num2 == TextBox_IDmem3) | (num2 == TextBox_IDmem4))
					{
						LeaderAcceptedPartyFrom(num2);
					}
					break;
				}
				case 4:
				{
					int num6 = API.HexToInt32(API.bytestohexstring(A_0).Substring(12, 8));
					int textBox_IDmem = TextBox_IDmem1;
					int textBox_IDmem2 = TextBox_IDmem2;
					int textBox_IDmem3 = TextBox_IDmem3;
					int textBox_IDmem4 = TextBox_IDmem4;
					int num7 = num6;
					if (num7 == textBox_IDmem)
					{
						_IDmem1 = 0;
						API.AddColorText2(this, Rtbsystem, GetNamePlayer(textBox_IDmem) + " rời khỏi nhóm!", Color.Blue);
						if (C_RadioButton_DCmemout)
						{
							_Disconnect();
							if (C_CheckBox_Reconnect)
							{
								_Connect();
							}
						}
					}
					else if (num7 == textBox_IDmem2)
					{
						_IDmem2 = 0;
						API.AddColorText2(this, Rtbsystem, GetNamePlayer(textBox_IDmem2) + " rời khỏi nhóm!", Color.Blue);
						if (C_RadioButton_DCmemout)
						{
							_Disconnect();
							if (C_CheckBox_Reconnect)
							{
								_Connect();
							}
						}
					}
					else if (num7 == textBox_IDmem3)
					{
						_IDmem3 = 0;
						API.AddColorText2(this, Rtbsystem, GetNamePlayer(textBox_IDmem3) + " rời khỏi nhóm!", Color.Blue);
						if (C_RadioButton_DCmemout)
						{
							_Disconnect();
							if (C_CheckBox_Reconnect)
							{
								_Connect();
							}
						}
					}
					else if (num7 == textBox_IDmem4)
					{
						_IDmem4 = 0;
						API.AddColorText2(this, Rtbsystem, GetNamePlayer(textBox_IDmem4) + " rời khỏi nhóm!", Color.Blue);
						if (C_RadioButton_DCmemout)
						{
							_Disconnect();
							if (C_CheckBox_Reconnect)
							{
								_Connect();
							}
						}
					}
					else if (num7 == Data_Player._LeaderId)
					{
						API.AddColorText2(this, Rtbsystem, "Chủ party đã giải tán nhóm!" + Conversions.ToString(num6), Color.Blue);
						Data_Player._LeaderId = 0;
						if (C_RadioButton_DCLeaderOut)
						{
							_Disconnect();
							if (C_CheckBox_Reconnect)
							{
								_Connect();
							}
						}
					}
					else if (num7 == Data_Player._Id)
					{
						API.AddColorText2(this, Rtbsystem, "Giải tán nhóm thành công!", Color.Blue);
						Data_Player._LeaderId = 0;
						if (C_RadioButton_DCmemout)
						{
							_Disconnect();
							if (C_CheckBox_Reconnect)
							{
								_Connect();
							}
						}
					}
					bool flag = false;
					bool flag2 = false;
					bool flag3 = false;
					bool flag4 = false;
					flag = (double)TextBox_IDmem1 == Conversions.ToDouble("0") || ((_IDmem1 != 0) ? true : false);
					flag2 = (double)TextBox_IDmem2 == Conversions.ToDouble("0") || ((_IDmem2 != 0) ? true : false);
					flag3 = (double)TextBox_IDmem3 == Conversions.ToDouble("0") || ((_IDmem3 != 0) ? true : false);
					flag4 = (double)TextBox_IDmem4 == Conversions.ToDouble("0") || ((_IDmem4 != 0) ? true : false);
					if (flag && flag2 && flag3 && flag4)
					{
						Data_Player._PartyFull = true;
					}
					else
					{
						Data_Player._PartyFull = false;
					}
					break;
				}
				case 5:
				{
					int num3 = API.HexToInt32(API.bytestohexstring(A_0).Substring(12, 8));
					int num4 = API.HexToInt32(API.bytestohexstring(A_0).Substring(20, 8));
					int id = Data_Player._Id;
					if (id == num3)
					{
						if (Data_Player._LeaderId == 0)
						{
							Data_Player._LeaderId = num3;
						}
						if (C_RadioButton_QS1)
						{
							SetQuanSu(TextBox_IDmem1);
						}
						else if (C_RadioButton_QS2)
						{
							SetQuanSu(TextBox_IDmem2);
						}
						else if (C_RadioButton_QS3)
						{
							SetQuanSu(TextBox_IDmem3);
						}
						else if (C_RadioButton_QS4)
						{
							SetQuanSu(TextBox_IDmem4);
						}
						int num5 = num4;
						if (num5 == TextBox_IDmem1)
						{
							_IDmem1 = num4;
							API.AddColorText2(this, Rtbsystem, GetNamePlayer(TextBox_IDmem1) + " vào nhóm thành công!", Color.Blue);
						}
						else if (num5 == TextBox_IDmem2)
						{
							_IDmem2 = num4;
							API.AddColorText2(this, Rtbsystem, GetNamePlayer(TextBox_IDmem2) + " vào nhóm thành công!", Color.Blue);
						}
						else if (num5 == TextBox_IDmem3)
						{
							_IDmem3 = num4;
							API.AddColorText2(this, Rtbsystem, GetNamePlayer(TextBox_IDmem3) + " vào nhóm thành công!", Color.Blue);
						}
						else if (num5 == TextBox_IDmem4)
						{
							_IDmem4 = num4;
							API.AddColorText2(this, Rtbsystem, GetNamePlayer(TextBox_IDmem4) + " vào nhóm thành công!", Color.Blue);
						}
						Data_Player._PartyFull = Party_CheckFull();
						if (bott == 1 && Data_Player._PartyFull)
						{
							ClickNPCId(99);
							StartBot();
						}
					}
					else if (id == num4)
					{
						if (Data_Player._LeaderId == 0)
						{
							Data_Player._LeaderId = num3;
						}
						API.AddColorText2(this, Rtbsystem, "Đã gia nhập vào nhóm của " + GetNamePlayer(num3), Color.Blue);
					}
					else if (Data_Player._LeaderId == num3)
					{
						API.AddColorText2(this, Rtbsystem, GetNamePlayer(num4) + " đã gia nhập vào nhóm", Color.Blue);
					}
					break;
				}
				case 9:
				{
					int num = API.HexToInt32(API.bytestohexstring(A_0).Substring(12, 8));
					string namePlayer = GetNamePlayer(num);
					API.AddColorText2(this, Rtbsystem, namePlayer + " mời vào nhóm ", Color.Blue);
					if (num == TextBox_IdLeader)
					{
						MemAcceptPartyto(num);
					}
					break;
				}
				}
				if (!(API.Proxy & API.List_Ip_nts.Contains(API.ServerIp)))
				{
					return;
				}
				if (API.Vip == 0)
				{
					try
					{
						int textBox_IDmem5 = TextBox_IDmem1;
						int textBox_IDmem6 = TextBox_IDmem2;
						int textBox_IDmem7 = TextBox_IDmem3;
						int textBox_IDmem8 = TextBox_IDmem4;
						byte[] packet = API.hexstringtobyte(API.Packet_Maker("080D" + API.Int32ToHex4(textBox_IDmem5) + API.Vip.ToString("X2")));
						byte[] packet2 = API.hexstringtobyte(API.Packet_Maker("080D" + API.Int32ToHex4(textBox_IDmem6) + API.Vip.ToString("X2")));
						byte[] packet3 = API.hexstringtobyte(API.Packet_Maker("080D" + API.Int32ToHex4(textBox_IDmem7) + API.Vip.ToString("X2")));
						byte[] packet4 = API.hexstringtobyte(API.Packet_Maker("080D" + API.Int32ToHex4(textBox_IDmem8) + API.Vip.ToString("X2")));
						_Local_SendPacket(packet);
						_Local_SendPacket(packet2);
						_Local_SendPacket(packet3);
						_Local_SendPacket(packet4);
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ProjectData.ClearProjectError();
					}
				}
				else
				{
					try
					{
						int textBox_IDmem9 = TextBox_IDmem1;
						int textBox_IDmem10 = TextBox_IDmem2;
						int textBox_IDmem11 = TextBox_IDmem3;
						int textBox_IDmem12 = TextBox_IDmem4;
						byte[] packet5 = API.hexstringtobyte(API.Packet_Maker("080D" + API.Int32ToHex4(textBox_IDmem9) + API.Vip.ToString("X2")));
						byte[] packet6 = API.hexstringtobyte(API.Packet_Maker("080D" + API.Int32ToHex4(textBox_IDmem10) + API.Vip.ToString("X2")));
						byte[] packet7 = API.hexstringtobyte(API.Packet_Maker("080D" + API.Int32ToHex4(textBox_IDmem11) + API.Vip.ToString("X2")));
						byte[] packet8 = API.hexstringtobyte(API.Packet_Maker("080D" + API.Int32ToHex4(textBox_IDmem12) + API.Vip.ToString("X2")));
						_Local_SendPacket(packet5);
						_Local_SendPacket(packet6);
						_Local_SendPacket(packet7);
						_Local_SendPacket(packet8);
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception ex4 = ex3;
						ProjectData.ClearProjectError();
					}
				}
				ArrayList arrayList = new ArrayList();
				switch (API.Style)
				{
				case 0:
					arrayList = API.List_Style0;
					break;
				case 1:
					arrayList = API.List_Style1;
					break;
				case 2:
					arrayList = API.List_Style2;
					break;
				case 3:
					arrayList = API.List_Style3;
					break;
				case 4:
					arrayList = API.List_Style4;
					break;
				}
				int num8 = Conversions.ToInteger(arrayList[0]);
				int num9 = Conversions.ToInteger(arrayList[1]);
				int num10 = Conversions.ToInteger(arrayList[2]);
				int num11 = Conversions.ToInteger(arrayList[3]);
				int num12 = Conversions.ToInteger(arrayList[4]);
				string text = "";
				if (num8 > 0)
				{
					text = text + API.Int32ToHex2(num8) + "0000000000000000";
				}
				if (num9 > 0)
				{
					text = text + API.Int32ToHex2(num9) + "0000000000000000";
				}
				if (num10 > 0)
				{
					text = text + API.Int32ToHex2(num10) + "0000000000000000";
				}
				if (num11 > 0)
				{
					text = text + API.Int32ToHex2(num11) + "0000000000000000";
				}
				if (num12 > 0)
				{
					text = text + API.Int32ToHex2(num12) + "0000000000000000";
				}
				byte[] packet9 = API.hexstringtobyte(API.Packet_Maker("170B" + text));
				_Local_SendPacket(packet9);
				text = "";
				if (num8 > 0)
				{
					text += API.Int32ToHex2(num8);
				}
				if (num9 > 0)
				{
					text += API.Int32ToHex2(num9);
				}
				if (num10 > 0)
				{
					text += API.Int32ToHex2(num10);
				}
				if (num11 > 0)
				{
					text += API.Int32ToHex2(num11);
				}
				if (num12 > 0)
				{
					text += API.Int32ToHex2(num12);
				}
				int textBox_IDmem13 = TextBox_IDmem1;
				int textBox_IDmem14 = TextBox_IDmem2;
				int textBox_IDmem15 = TextBox_IDmem3;
				int textBox_IDmem16 = TextBox_IDmem4;
				byte[] packet10 = API.hexstringtobyte(API.Packet_Maker("0500" + API.Int32ToHex4(textBox_IDmem13) + text));
				byte[] packet11 = API.hexstringtobyte(API.Packet_Maker("0500" + API.Int32ToHex4(textBox_IDmem14) + text));
				byte[] packet12 = API.hexstringtobyte(API.Packet_Maker("0500" + API.Int32ToHex4(textBox_IDmem15) + text));
				byte[] packet13 = API.hexstringtobyte(API.Packet_Maker("0500" + API.Int32ToHex4(textBox_IDmem16) + text));
				_Local_SendPacket(packet10);
				_Local_SendPacket(packet11);
				_Local_SendPacket(packet12);
				_Local_SendPacket(packet13);
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				StackTrace stackTrace = new StackTrace(true);
				stackTrace = new StackTrace(ex6, true);
				API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - Update_HD] :" + ex6.Message + stackTrace.GetFrame(0).GetFileLineNumber() + "\r\n");
				ProjectData.ClearProjectError();
			}
		}

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

		private void o(byte[] A_0)
		{
			checked
			{
				try
				{
					switch (A_0[5])
					{
					case 5:
					{
						if (!API.List_Ip_nts.Contains(API.ServerIp))
						{
							break;
						}
						int num7 = Convert.ToInt32(API.bytestohexstring(new byte[4]
						{
							A_0[9],
							A_0[8],
							A_0[7],
							A_0[6]
						}), 16);
						int num8 = Convert.ToInt32(API.bytestohexstring(new byte[4]
						{
							A_0[13],
							A_0[12],
							A_0[11],
							A_0[10]
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
							A_0[9],
							A_0[8],
							A_0[7],
							A_0[6]
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
						string text = API.bytestohexstring(A_0).Substring(12);
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

		private void n(byte[] A_0)
		{
			checked
			{
				try
				{
					byte b = A_0[5];
					if (b == 1)
					{
						ListAnswerBTQ.Clear();
						BTQ = 1;
						string text = API.bytestohexstring(A_0).Substring(12);
						string text2 = text.Substring(0, 2 + API.hexstringtobyte(text)[0] * 2);
						byte[] packet = API.hexstringtobyte(text2.Substring(2));
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
						API.AddColorText2(this, Rtbsystem, "***************Gặp Bắc Tinh Quân***************\r\n" + API.VISCII_to_Unicode(API.HexToChar(packet)) + "\r\n1. " + API.HexToChar(array) + "\r\n2. " + API.HexToChar(array2) + "\r\n3. " + API.HexToChar(array3) + "\r\n4. " + API.HexToChar(array4), Color.Blue);
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

		private void m(byte[] A_0)
		{
			try
			{
				byte b = A_0[5];
				if (b == 2)
				{
					PetBattle = 0;
					return;
				}
				int num = API.HexToInt32(API.bytestohexstring(new byte[2]
				{
					A_0[6],
					A_0[7]
				}));
				if (Operators.ConditionalCompareObjectEqual(num, this.get_DataPets(1, _Data.Type_Pets._Id), false))
				{
					PetBattle = 1;
				}
				else if (Operators.ConditionalCompareObjectEqual(num, this.get_DataPets(2, _Data.Type_Pets._Id), false))
				{
					PetBattle = 2;
				}
				else if (Operators.ConditionalCompareObjectEqual(num, this.get_DataPets(3, _Data.Type_Pets._Id), false))
				{
					PetBattle = 3;
				}
				else if (Operators.ConditionalCompareObjectEqual(num, this.get_DataPets(4, _Data.Type_Pets._Id), false))
				{
					PetBattle = 4;
				}
				if (PetBattle > 0)
				{
					_Data._Pets value = Data_PetsInfo[PetBattle];
					Data_PetListSkill.Clear();
					Data_PetListSkill.Add(10000);
					Data_PetListSkill.Add(17001);
					Data_PetListSkill.Add(18001);
					Npcs.NpcInfo npcs = Npcs.Data_Npcs[value._Id];
					if (npcs._Skill1 > 0)
					{
						Data_PetListSkill.Add(npcs._Skill1);
					}
					if (npcs._Skill2 > 0)
					{
						Data_PetListSkill.Add(npcs._Skill2);
					}
					if (npcs._Skill3 > 0)
					{
						Data_PetListSkill.Add(npcs._Skill3);
					}
					if (npcs._Skill4 > 0)
					{
						Data_PetListSkill.Add(npcs._Skill4);
					}
					if (npcs._Skill5 > 0)
					{
						Data_PetListSkill.Add(npcs._Skill5);
					}
					if (npcs._Skill6 > 0)
					{
						Data_PetListSkill.Add(npcs._Skill6);
					}
					npcs = default(Npcs.NpcInfo);
					Data_PetsInfo[PetBattle] = value;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				StackTrace stackTrace = new StackTrace(true);
				stackTrace = new StackTrace(ex2, true);
				API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - Update_H13] :" + ex2.Message + stackTrace.GetFrame(0).GetFileLineNumber() + "\r\n");
				ProjectData.ClearProjectError();
			}
		}

		private void l(byte[] A_0)
		{
			checked
			{
				try
				{
					switch (A_0[5])
					{
					case 1:
						if (A_0[10] != 6)
						{
							_Questing = 1;
							showmenu = 0;
							ushort a_ = (ushort)Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								A_0[20],
								A_0[19]
							}), 16);
							b(a_);
						}
						else if (A_0[10] == 6)
						{
							ushort a_2 = (ushort)Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								A_0[20],
								A_0[19]
							}), 16);
							a(a_2);
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

		private void k(byte[] A_0)
		{
			checked
			{
				try
				{
					switch (A_0[5])
					{
					case 2:
					{
						int num8 = Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							A_0[7],
							A_0[6]
						}), 16);
						if (Data_NpcInMap.ContainsKey(num8))
						{
							int num9 = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								A_0[9],
								A_0[8]
							}), 16);
							int num10 = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								A_0[11],
								A_0[10]
							}), 16);
							int num11 = (int)Math.Round(Math.Sqrt(Math.Pow(Data_Player._MapX - num9, 2.0) + Math.Pow(Data_Player._MapY - num10, 2.0)));
							this.set_DataNpcInMap(num8, _Data.Type_NpcInMap._MapX, (object)num9);
							this.set_DataNpcInMap(num8, _Data.Type_NpcInMap._MapY, (object)num10);
							this.set_DataNpcInMap(num8, _Data.Type_NpcInMap._KC, (object)num11);
						}
						else
						{
							int num12 = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								A_0[9],
								A_0[8]
							}), 16);
							int num13 = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								A_0[11],
								A_0[10]
							}), 16);
							int kC2 = (int)Math.Round(Math.Sqrt(Math.Pow(Data_Player._MapX - num12, 2.0) + Math.Pow(Data_Player._MapY - num13, 2.0)));
							_Data._NpcInMap value2 = new _Data._NpcInMap
							{
								_Id = num8,
								_MapX = num12,
								_MapY = num13,
								_Delay = 0,
								_KC = kC2
							};
							Data_NpcInMap.Add(num8, value2);
						}
						break;
					}
					case 3:
					{
						int num7 = Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							A_0[7],
							A_0[6]
						}), 16);
						if (Data_NpcInMap.ContainsKey(num7))
						{
							this.set_DataNpcInMap(num7, _Data.Type_NpcInMap._Delay, (object)(Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								A_0[9],
								A_0[8]
							}), 16) + 2));
						}
						break;
					}
					case 4:
					{
						if (Data_NpcInMap.Count > 0)
						{
							Data_NpcInMap.Clear();
						}
						string text = API.bytestohexstring(A_0).Substring(12);
						while (text.Length != 0)
						{
							byte[] array = API.hexstringtobyte(text.Substring(0, 26));
							int num14 = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								array[1],
								array[0]
							}), 16);
							if (!Data_NpcInMap.ContainsKey(num14))
							{
								int num15 = Convert.ToInt32(API.bytestohexstring(new byte[2]
								{
									array[5],
									array[4]
								}), 16);
								int num16 = Convert.ToInt32(API.bytestohexstring(new byte[2]
								{
									array[7],
									array[6]
								}), 16);
								int kC3 = (int)Math.Round(Math.Sqrt(Math.Pow(Data_Player._MapX - num15, 2.0) + Math.Pow(Data_Player._MapY - num16, 2.0)));
								_Data._NpcInMap value3 = new _Data._NpcInMap
								{
									_Id = num14,
									_MapX = num15,
									_MapY = num16,
									_Delay = 0,
									_KC = kC3
								};
								Data_NpcInMap.Add(num14, value3);
							}
							text = text.Replace(API.bytestohexstring(array), "");
						}
						break;
					}
					case 5:
					{
						int num = Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							A_0[7],
							A_0[6]
						}), 16);
						if (Data_NpcInMap.ContainsKey(num))
						{
							int num2 = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								A_0[9],
								A_0[8]
							}), 16);
							int num3 = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								A_0[11],
								A_0[10]
							}), 16);
							int num4 = (int)Math.Round(Math.Sqrt(Math.Pow(Data_Player._MapX - num2, 2.0) + Math.Pow(Data_Player._MapY - num3, 2.0)));
							this.set_DataNpcInMap(num, _Data.Type_NpcInMap._MapX, (object)num2);
							this.set_DataNpcInMap(num, _Data.Type_NpcInMap._MapY, (object)num3);
							this.set_DataNpcInMap(num, _Data.Type_NpcInMap._KC, (object)num4);
						}
						else
						{
							int num5 = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								A_0[9],
								A_0[8]
							}), 16);
							int num6 = Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								A_0[11],
								A_0[10]
							}), 16);
							int kC = (int)Math.Round(Math.Sqrt(Math.Pow(Data_Player._MapX - num5, 2.0) + Math.Pow(Data_Player._MapY - num6, 2.0)));
							_Data._NpcInMap value = new _Data._NpcInMap
							{
								_Id = num,
								_MapX = num5,
								_MapY = num6,
								_Delay = 0,
								_KC = kC
							};
							Data_NpcInMap.Add(num, value);
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
					API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - Update_H16] :" + ex2.Message + stackTrace.GetFrame(0).GetFileLineNumber() + "\r\n");
					ProjectData.ClearProjectError();
				}
			}
		}

		private void j(byte[] A_0)
		{
			checked
			{
				switch (A_0[5])
				{
				case 2:
					try
					{
						string text2 = API.bytestohexstring(A_0).Substring(12);
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
						string text8 = API.bytestohexstring(A_0).Substring(12);
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
						string text6 = API.bytestohexstring(A_0).Substring(12);
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
						string text5 = API.bytestohexstring(A_0).Substring(12);
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
						int stt13 = A_0[6];
						int num44 = A_0[7];
						int stt14 = A_0[8];
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
						string text3 = API.bytestohexstring(A_0).Substring(12);
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
						int num34 = API.HexToInt32(API.bytestohexstring(A_0).Substring(12, 4));
						int num35 = API.HexToInt32(API.bytestohexstring(A_0).Substring(16, 2));
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
							A_0[7],
							A_0[6]
						}), 16);
						int num31 = A_0[8];
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
							int num28 = API.HexToInt32(API.bytestohexstring(A_0).Substring(14, 4));
							object left = this.get_DataTuido((int)A_0[6], _Data.Type_Tui._Id);
							if (Operators.ConditionalCompareObjectEqual(left, num28, false))
							{
								int num29 = Conversions.ToInteger(Operators.AddObject(this.get_DataTuido((int)A_0[6], _Data.Type_Tui._Sl), A_0[9]));
								if (num29 >= 50)
								{
									this.set_DataTuido((int)A_0[6], _Data.Type_Tui._Id, (object)num28);
									this.set_DataTuido((int)A_0[6], _Data.Type_Tui._Sl, (object)A_0[9]);
								}
								else
								{
									this.set_DataTuido((int)A_0[6], _Data.Type_Tui._Id, (object)num28);
									int stt2;
									string sl;
									this.set_DataTuido(stt2 = A_0[6], sl = _Data.Type_Tui._Sl, Operators.AddObject(this.get_DataTuido(stt2, sl), A_0[9]));
								}
							}
							else
							{
								this.set_DataTuido((int)A_0[6], _Data.Type_Tui._Id, (object)num28);
								this.set_DataTuido((int)A_0[6], _Data.Type_Tui._Sl, (object)A_0[9]);
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
						int num26 = A_0[6];
						int num27 = A_0[7];
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
						int num25 = A_0[6];
						int stt10 = A_0[7];
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
						int stt8 = A_0[6];
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
						int num20 = A_0[6];
						int num21 = A_0[7];
						int stt7 = A_0[8];
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
						int stt5 = A_0[6];
						int stt6 = A_0[7];
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
						int num12 = A_0[6];
						int num13 = API.HexToInt32(API.bytestohexstring(A_0).Substring(14, 4));
						int num14 = A_0[9];
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
						int stt4 = A_0[6] - 1;
						int num11 = A_0[7];
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
						int num9 = A_0[6];
						int stt3 = A_0[7] - 1;
						int num10 = A_0[8];
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
						A_0[6],
						A_0[7],
						A_0[8],
						A_0[9]
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
						string text = API.bytestohexstring(A_0).Substring(12);
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
						int stt = A_0[6];
						int num = A_0[7];
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

		private void i(byte[] A_0)
		{
			try
			{
				switch (A_0[5])
				{
				case 1:
				{
					int num2 = Convert.ToInt32(API.bytestohexstring(new byte[2]
					{
						A_0[7],
						A_0[6]
					}), 16);
					listquest_Doing.Add(num2);
					listquest_Doing.Sort();
					break;
				}
				case 5:
				{
					int key = Convert.ToInt32(API.bytestohexstring(new byte[2]
					{
						A_0[7],
						A_0[6]
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

		private void h(byte[] A_0)
		{
			try
			{
				switch (A_0[5])
				{
				case 22:
					switch (A_0[6])
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
					int id = API.HexToInt32(API.bytestohexstring(A_0).Substring(14, 8));
					int id2 = API.HexToInt32(API.bytestohexstring(A_0).Substring(22, 4));
					int num = A_0[13];
					switch (A_0[6])
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

		private void g(byte[] A_0)
		{
			checked
			{
				try
				{
					int num = Convert.ToInt32(API.bytestohexstring(new byte[4]
					{
						A_0[9],
						A_0[8],
						A_0[7],
						A_0[6]
					}), 16);
					switch (A_0[5])
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
							A_0[9],
							A_0[8],
							A_0[7],
							A_0[6]
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

		public int Getnumber(string txt)
		{
			string text = " __ @(  )@ )( @(__)@";
			string text2 = " ___ @(__ \\@/ __/@\\___)@";
			string text3 = " ___ @(__ )@ (_ \\@(___/@";
			string text4 = "  __  @ / ,) @(_  _)@  (_) @";
			string text5 = " ___ @/ __)@\\__ \\@(___/@";
			string text6 = "  _  @ / ) @/ , \\@\\___/@";
			string text7 = " ___ @(__ )@ / / @(_/  @";
			string text8 = " ___ @( , )@/ , \\@\\___/@";
			string text9 = " ___ @/ , \\@\\   /@ (_/ @";
			int num = 0;
			if (text.Contains(txt))
			{
				num = 1;
			}
			if (text2.Contains(txt))
			{
				num = 2;
			}
			if (text3.Contains(txt))
			{
				num = 3;
			}
			if (text4.Contains(txt))
			{
				num = 4;
			}
			if (text5.Contains(txt))
			{
				num = 5;
			}
			if (text6.Contains(txt))
			{
				num = 6;
			}
			if (text7.Contains(txt))
			{
				num = 7;
			}
			if (text8.Contains(txt))
			{
				num = 8;
			}
			if (text9.Contains(txt))
			{
				num = 9;
			}
			if (num == 0)
			{
				num = Getnumber1(txt);
			}
			return num;
		}

		public int Getnumber1(string txt)
		{
			string text = "  __ @ /  )@  )( @ (__)@";
			string text2 = " ___  @(__ \\ @ / _/ @(____)@";
			string text3 = " ___ @(__ )@ (_ \\@(___/@";
			string text4 = "  __  @ /. | @(_  _)@  (_) @";
			string text5 = " ___ @| __)@|__ \\@(___/@";
			string text6 = "  _  @ / ) @/ _ \\@\\___/@";
			string text7 = " ___ @(__ )@ / / @(_/  @";
			string text8 = " ___ @( _ )@/ _ \\@\\___/@";
			string text9 = " ___ @/ _ \\@\\_  /@ (_/ @";
			int result = 0;
			if (text.Contains(txt))
			{
				result = 1;
			}
			if (text2.Contains(txt))
			{
				result = 2;
			}
			if (text3.Contains(txt))
			{
				result = 3;
			}
			if (text4.Contains(txt))
			{
				result = 4;
			}
			if (text5.Contains(txt))
			{
				result = 5;
			}
			if (text6.Contains(txt))
			{
				result = 6;
			}
			if (text7.Contains(txt))
			{
				result = 7;
			}
			if (text8.Contains(txt))
			{
				result = 8;
			}
			if (text9.Contains(txt))
			{
				result = 9;
			}
			return result;
		}

		private void f(byte[] A_0)
		{
			checked
			{
				try
				{
					byte b = A_0[5];
					if (b != 2 || _Proxy)
					{
						return;
					}
					if (ComboBox_Port == 0)
					{
						byte[] bytes = API.ByteArrayToByteArray(A_0, 6);
						string antibot_str = API.VISCII_to_Unicode(Encoding.Default.GetString(bytes));
						_Antibot_str = antibot_str;
						_Antibot_ask = 1;
						return;
					}
					byte[] bytes2 = API.ByteArrayToByteArray(A_0, 6);
					string text = API.VISCII_to_Unicode(Encoding.Default.GetString(bytes2));
					text = text.Substring(text.LastIndexOf(":") + 1);
					string text2 = "";
					string text3 = "";
					string text4 = "";
					string text5 = "";
					int num = 1;
					text = text.Replace("\r\n", "");
					text = text.Substring(0, text.Length - 1);
					string[] array = text.Split('\t');
					foreach (string text6 in array)
					{
						switch (num)
						{
						case 1:
							text2 = text2 + text6 + "@";
							break;
						case 2:
							text3 = text3 + text6 + "@";
							break;
						case 3:
							text4 = text4 + text6 + "@";
							break;
						case 4:
							text5 = text5 + text6 + "@";
							num = 0;
							break;
						}
						num++;
					}
					int num2 = 0;
					int num3 = 0;
					int num4 = 0;
					int num5 = 0;
					if (num2 == 0)
					{
						num2 = Getnumber(text2);
					}
					if (num3 == 0)
					{
						num3 = Getnumber(text3);
					}
					if (num4 == 0)
					{
						num4 = Getnumber(text4);
					}
					if (num5 == 0)
					{
						num5 = Getnumber(text5);
					}
					SendPacket(API.hexstringtobyte("F44406003701" + Strings.Asc(num2.ToString()).ToString("X2") + Strings.Asc(num3.ToString()).ToString("X2") + Strings.Asc(num4.ToString()).ToString("X2") + Strings.Asc(num5.ToString()).ToString("X2")));
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - Update_H1A] :" + ex2.Message + "\r\n");
					ProjectData.ClearProjectError();
				}
			}
		}

		private void e(byte[] A_0)
		{
			checked
			{
				try
				{
					byte b = A_0[5];
					if (b != 1)
					{
						return;
					}
					int num = 0;
					string text = API.bytestohexstring(A_0).Substring(12);
					string text2 = "";
					while (text.Length != 0)
					{
						num++;
						byte[] array = API.hexstringtobyte(text);
						string text3 = text.Substring(0, 4 + API.HexToInt32(text.Substring(0, 4)) * 2);
						string a_ = text3.Substring(4, 4);
						string text4 = Conversions.ToString(this.get_DataBattle(a(a_), _Data.Type_Battleinfo._Name));
						int id = API.HexToInt32(text3.Substring(8, 4));
						int stt;
						string sp;
						this.set_DataBattle(stt = a(a_), sp = _Data.Type_Battleinfo._Sp, Operators.SubtractObject(this.get_DataBattle(stt, sp), GetSkillSP(id)));
						string text5 = text3.Substring(16);
						while (text5.Length != 0)
						{
							int num2 = API.HexToInt32(text5.Substring(8, 2));
							string text6 = text5.Substring(0, 10 + num2 * 8);
							string a_2 = text5.Substring(0, 4);
							string text7 = "";
							switch (API.HexToInt32(text5.Substring(4, 2)))
							{
							case 0:
								text7 = "Trượt";
								break;
							case 1:
								text7 = "Trúng";
								break;
							}
							string text8 = Conversions.ToString(this.get_DataBattle(a(a_2), _Data.Type_Battleinfo._Name));
							int num3 = API.HexToInt32(text6.Substring(10, 2));
							int num4 = API.HexToInt32(text6.Substring(12, 4));
							switch (API.HexToInt32(text6.Substring(16, 2)))
							{
							case 0:
								switch (num3)
								{
								case 25:
									if (Operators.ConditionalCompareObjectLess(this.get_DataBattle(a(a_2), _Data.Type_Battleinfo._Hp), 0, false))
									{
										this.set_DataBattle(a(a_2), _Data.Type_Battleinfo._Hp, (object)num4);
									}
									else
									{
										this.set_DataBattle(stt = a(a_2), sp = _Data.Type_Battleinfo._Hp, Operators.AddObject(this.get_DataBattle(stt, sp), num4));
									}
									text2 = text2 + text4 + " --> " + GetSkillName(id) + " -[" + text7 + "]-> " + text8 + " (+" + Conversions.ToString(num4) + " hp)\r\n";
									break;
								case 26:
									if (Operators.ConditionalCompareObjectLess(this.get_DataBattle(a(a_2), _Data.Type_Battleinfo._Sp), 0, false))
									{
										this.set_DataBattle(a(a_2), _Data.Type_Battleinfo._Sp, (object)num4);
									}
									else
									{
										this.set_DataBattle(stt = a(a_2), sp = _Data.Type_Battleinfo._Sp, Operators.AddObject(this.get_DataBattle(stt, sp), num4));
									}
									text2 = text2 + text4 + " --> " + GetSkillName(id) + " -[" + text7 + "]-> " + text8 + " (+" + Conversions.ToString(num4) + " Sp)\r\n";
									break;
								default:
									text2 = text2 + text4 + " --> " + GetSkillName(id) + " -[" + text7 + "]-> " + text8 + "\r\n";
									break;
								}
								break;
							case 1:
								switch (num3)
								{
								case 25:
									this.set_DataBattle(stt = a(a_2), sp = _Data.Type_Battleinfo._Hp, Operators.SubtractObject(this.get_DataBattle(stt, sp), num4));
									text2 = text2 + text4 + " " + GetSkillName(id) + " -[" + text7 + "]-> " + text8 + " (-" + Conversions.ToString(num4) + " hp)\r\n";
									break;
								case 26:
									this.set_DataBattle(stt = a(a_2), sp = _Data.Type_Battleinfo._Sp, Operators.SubtractObject(this.get_DataBattle(stt, sp), num4));
									text2 = text2 + text4 + " --> " + GetSkillName(id) + " -[" + text7 + "]-> " + text8 + " (-" + Conversions.ToString(num4) + " Sp)\r\n";
									break;
								default:
									text2 = text2 + text4 + " --> " + GetSkillName(id) + " -[" + text7 + "]-> " + text8 + "\r\n";
									break;
								}
								break;
							}
							text5 = text5.Replace(text6, "");
						}
						text = text.Replace(text3, "");
					}
					if (text2.Length > 0)
					{
						API.AddColorText_battle2(this, RtbBattle, text2, Color.DarkOrange);
					}
					if (num > 1)
					{
						API.AddColorText_battle2(this, RtbBattle, "Combo", Color.Black);
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					StackTrace stackTrace = new StackTrace(true);
					stackTrace = new StackTrace(ex2, true);
					API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - Update_H32] :" + ex2.Message + stackTrace.GetFrame(0).GetFileLineNumber() + "\r\n");
					ProjectData.ClearProjectError();
				}
			}
		}

		private void d(byte[] A_0)
		{
			checked
			{
				try
				{
					byte b = A_0[5];
					if (b != 1)
					{
						return;
					}
					turn++;
					Status = "Lượt đánh: " + Conversions.ToString(turn);
					if (Battle == 1)
					{
						DelayDisconnectNoBattle = 0;
						API.AddColorText_battle2(this, RtbBattle, "Lượt : " + turn, Color.Blue);
						if (Data_Player._LeaderId == Data_Player._Id)
						{
							int num = 0;
							if (TextBox_IDmem1 != 0)
							{
								num++;
							}
							if (TextBox_IDmem2 != 0)
							{
								num++;
							}
							if (TextBox_IDmem3 != 0)
							{
								num++;
							}
							if (TextBox_IDmem4 != 0)
							{
								num++;
							}
							if (num > _checkdisparty)
							{
								Data_Player._PartyFull = false;
								if (C_CheckBox_LeaderDissNotEnough)
								{
									API.AddColorText2(this, Rtbsystem, "không đủ thành viên, ngắt kết nôi!", Color.Red);
									_Disconnect();
								}
							}
						}
					}
					if ((BTQ == 1) & (turn > 0))
					{
						AnswerBTQ(ListAnswerBTQ);
					}
					else if ((BTQ == 0) & (turn > 0))
					{
						a(turn);
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					StackTrace stackTrace = new StackTrace(true);
					stackTrace = new StackTrace(ex2, true);
					API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - Update_H34] :" + ex2.Message + stackTrace.GetFrame(0).GetFileLineNumber() + "\r\n");
					ProjectData.ClearProjectError();
				}
			}
		}

		private void c(byte[] A_0)
		{
			try
			{
				switch (A_0[5])
				{
				case 3:
				{
					int location = GetLocation2(A_0[6].ToString("X2") + A_0[7].ToString("X2"));
					_Data._Battleinfo value = Data_Battles[location];
					value._Id = 0;
					value._Name = "";
					value._Lv = 0;
					value._Hp = 0;
					value._HpMax = 0;
					value._Sp = 0;
					value._SpMax = 0;
					value._ThuocTinh = 0;
					value._Type = 0;
					value._IdChar = 0;
					value._Color = Color.Black;
					Data_Battles[location] = value;
					break;
				}
				case 13:
					if (logined != 0)
					{
						break;
					}
					logined = 1;
					Online = "ON";
					Status = "Đăng nhập thành công!!!";
					Walk(Data_Player._MapX, Data_Player._MapY);
					if (API.Proxy && ((API.Vip > 0) & API.List_Ip_nts.Contains(API.ServerIp)))
					{
						byte[] packet = API.hexstringtobyte(API.Packet_Maker("08010201" + API.Vip.ToString("X2")));
						_Local_SendPacket(packet);
						ArrayList arrayList = new ArrayList();
						switch (API.Style)
						{
						case 0:
							arrayList = API.List_Style0;
							break;
						case 1:
							arrayList = API.List_Style1;
							break;
						case 2:
							arrayList = API.List_Style2;
							break;
						case 3:
							arrayList = API.List_Style3;
							break;
						case 4:
							arrayList = API.List_Style4;
							break;
						}
						int num = Conversions.ToInteger(arrayList[0]);
						int num2 = Conversions.ToInteger(arrayList[1]);
						int num3 = Conversions.ToInteger(arrayList[2]);
						int num4 = Conversions.ToInteger(arrayList[3]);
						int num5 = Conversions.ToInteger(arrayList[4]);
						string text = "";
						if (num > 0)
						{
							text = text + API.Int32ToHex2(num) + "0000000000000000";
						}
						if (num2 > 0)
						{
							text = text + API.Int32ToHex2(num2) + "0000000000000000";
						}
						if (num3 > 0)
						{
							text = text + API.Int32ToHex2(num3) + "0000000000000000";
						}
						if (num4 > 0)
						{
							text = text + API.Int32ToHex2(num4) + "0000000000000000";
						}
						if (num5 > 0)
						{
							text = text + API.Int32ToHex2(num5) + "0000000000000000";
						}
						packet = API.hexstringtobyte(API.Packet_Maker("170B" + text));
						_Local_SendPacket(packet);
						text = "";
						if (num > 0)
						{
							text += API.Int32ToHex2(num);
						}
						if (num2 > 0)
						{
							text += API.Int32ToHex2(num2);
						}
						if (num3 > 0)
						{
							text += API.Int32ToHex2(num3);
						}
						if (num4 > 0)
						{
							text += API.Int32ToHex2(num4);
						}
						if (num5 > 0)
						{
							text += API.Int32ToHex2(num5);
						}
						int textBox_IDmem = TextBox_IDmem1;
						int textBox_IDmem2 = TextBox_IDmem2;
						int textBox_IDmem3 = TextBox_IDmem3;
						int textBox_IDmem4 = TextBox_IDmem4;
						byte[] packet2 = API.hexstringtobyte(API.Packet_Maker("0500" + API.Int32ToHex4(textBox_IDmem) + text));
						byte[] packet3 = API.hexstringtobyte(API.Packet_Maker("0500" + API.Int32ToHex4(textBox_IDmem2) + text));
						byte[] packet4 = API.hexstringtobyte(API.Packet_Maker("0500" + API.Int32ToHex4(textBox_IDmem3) + text));
						byte[] packet5 = API.hexstringtobyte(API.Packet_Maker("0500" + API.Int32ToHex4(textBox_IDmem4) + text));
						_Local_SendPacket(packet2);
						_Local_SendPacket(packet3);
						_Local_SendPacket(packet4);
						_Local_SendPacket(packet5);
						if (API.IDNgua > 0)
						{
							packet2 = API.hexstringtobyte(API.Packet_Maker("0F05" + API.Int32ToHex4(textBox_IDmem) + API.Int32ToHex4(API.IDNgua) + "00000000"));
							packet3 = API.hexstringtobyte(API.Packet_Maker("0F05" + API.Int32ToHex4(textBox_IDmem2) + API.Int32ToHex4(API.IDNgua) + "00000000"));
							packet4 = API.hexstringtobyte(API.Packet_Maker("0F05" + API.Int32ToHex4(textBox_IDmem3) + API.Int32ToHex4(API.IDNgua) + "00000000"));
							packet5 = API.hexstringtobyte(API.Packet_Maker("0F05" + API.Int32ToHex4(textBox_IDmem4) + API.Int32ToHex4(API.IDNgua) + "00000000"));
							_Local_SendPacket(packet2);
							_Local_SendPacket(packet3);
							_Local_SendPacket(packet4);
							_Local_SendPacket(packet5);
						}
					}
					time_online = 0L;
					_checkdisExp = 0;
					_checkdisFullHomdo = 0;
					_checkconnect = 0;
					if (_stt_send > 0)
					{
						_stt_send = 0;
					}
					logined = 1;
					time_online = 0L;
					_checkdisExp = 0;
					_checkconnect = 0;
					Label_BDY = "Gửi Ba Đậu Yêu";
					API.AddColorText2(this, Rtbsystem, "Đăng nhập thành công!", Color.DeepPink);
					if (C_CheckBox_AutoEquitExp)
					{
						int id = Data_CharEquit[5]._Id;
						int doben = Data_CharEquit[5]._Doben;
						if (id == 0 || id == 23024 || doben >= 250)
						{
							foreach (_Data._Tuido value2 in Data_Tuido.Values)
							{
								int id2 = value2._Id;
								int stt = value2._Stt;
								if (id2 > 0 && Items.Data_Items.ContainsKey(id2) && IDNgocEXP.Contains(Items.Data_Items[id2]._Type))
								{
									CharEquit(stt, 1);
									break;
								}
							}
						}
					}
					if (C_CheckBox_OpenMachine)
					{
						OpenMachineBox();
					}
					if (C_CheckBox_TuLenNgua)
					{
						LenNgua();
					}
					if ((Data_Player._MapId >= 10800) & (Data_Player._MapId <= 10820))
					{
						string text2 = "F444040014080100F44402001406F44402001406F44402001406F44402001406F44402001406F44402001406F44402001406F44402001406F44402001406";
						SendPacket(API.hexstringtobyte(text2));
						createdchar = 1;
					}
					if ((Data_Player._MapId >= 10850) & (Data_Player._MapId <= 10870))
					{
						Walk(1262, 255);
						string text3 = "F44404001401" + API.Int32ToHex2(2) + "F444030014091EF44402001406F44402001406F44402001406F44402001406F44402001406F44402001406F44402001406F44402001406F44402001406F444040014080200F444030014091EF44402001406F44402001406";
						SendPacket(API.hexstringtobyte(text3));
						createdchar = 1;
					}
					if (C_CheckBox_AutoEat)
					{
						CharEatHp();
						CharEatSp();
						PetEatHp();
						PetEatSp();
					}
					if (bott == 1)
					{
						Thread.Sleep(1000);
						_StartBot();
					}
					break;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				StackTrace stackTrace = new StackTrace(true);
				stackTrace = new StackTrace(ex2, true);
				API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - Update_H35] :" + ex2.Message + stackTrace.GetFrame(0).GetFileLineNumber() + "\r\n");
				ProjectData.ClearProjectError();
			}
		}

		private void b(byte[] A_0)
		{
			try
			{
				switch (A_0[5])
				{
				case 1:
					_MiniRuning = 1;
					_Mini_Status = "Bật";
					break;
				case 2:
					_MiniRuning = 0;
					_Mini_Status = "Tắt";
					break;
				case 3:
					break;
				case 7:
					if (A_0[6] != 2)
					{
					}
					break;
				case 4:
				case 5:
				case 6:
					break;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				StackTrace stackTrace = new StackTrace(true);
				stackTrace = new StackTrace(ex2, true);
				API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - Update_H41] :" + ex2.Message + stackTrace.GetFrame(0).GetFileLineNumber() + "\r\n");
				ProjectData.ClearProjectError();
			}
		}

		private void a(byte[] A_0)
		{
			checked
			{
				try
				{
					byte b = A_0[5];
					if (b != 1 || A_0[6] != 1)
					{
						return;
					}
					int num = A_0[7];
					int num2 = A_0[8];
					int num3 = A_0[9];
					int num4 = A_0[10];
					int num5 = A_0[11];
					int num6 = A_0[12];
					int num7 = num3;
					for (int i = 0; i <= num7; i++)
					{
						if (Astrolabes._int.ContainsKey(i))
						{
							Data_Player._Int4 += Astrolabes._int[i];
						}
					}
					int num8 = num6;
					for (int j = 0; j <= num8; j++)
					{
						if (Astrolabes._atk.ContainsKey(j))
						{
							Data_Player._Atk4 += Astrolabes._atk[j];
						}
					}
					int num9 = num2;
					for (int k = 0; k <= num9; k++)
					{
						if (Astrolabes._def.ContainsKey(k))
						{
							Data_Player._Def4 += Astrolabes._def[k];
						}
					}
					int num10 = num;
					for (int l = 0; l <= num10; l++)
					{
						if (Astrolabes._hpx.ContainsKey(l))
						{
							Data_Player._Hpx4 += Astrolabes._hpx[l];
						}
					}
					int num11 = num4;
					for (int m = 0; m <= num11; m++)
					{
						if (Astrolabes._spx.ContainsKey(m))
						{
							Data_Player._Spx4 += Astrolabes._spx[m];
						}
					}
					int num12 = num5;
					for (int n = 0; n <= num12; n++)
					{
						if (Astrolabes._agi.ContainsKey(n))
						{
							Data_Player._Agi4 += Astrolabes._agi[n];
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					StackTrace stackTrace = new StackTrace(true);
					stackTrace = new StackTrace(ex2, true);
					API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - Update_H4E] :" + ex2.Message + stackTrace.GetFrame(0).GetFileLineNumber() + "\r\n");
					ProjectData.ClearProjectError();
				}
			}
		}

		public void OpenMachineBox()
		{
			if (logined == 1)
			{
				int textBox_OpenMachine_CharHp = TextBox_OpenMachine_CharHp;
				int textBox_OpenMachine_CharSp = TextBox_OpenMachine_CharSp;
				int textBox_OpenMachine_PetHp = TextBox_OpenMachine_PetHp;
				int textBox_OpenMachine_PetSp = TextBox_OpenMachine_PetSp;
				SendPacket(API.hexstringtobyte("F4440A004101" + textBox_OpenMachine_CharHp.ToString("X2") + textBox_OpenMachine_CharSp.ToString("X2") + textBox_OpenMachine_PetHp.ToString("X2") + textBox_OpenMachine_PetSp.ToString("X2") + "00000000"));
			}
		}

		public void StopMachineBox()
		{
			if (logined == 1)
			{
				SendPacket(API.hexstringtobyte("F44402004102"));
			}
		}

		public void LenNgua()
		{
			try
			{
				if (logined != 1)
				{
					return;
				}
				int num = 1;
				do
				{
					int id = Data_PetsInfo[num]._Id;
					if (Npcs.Data_Npcs.ContainsKey(id) && Npcs.Data_Npcs[id]._Type == 9)
					{
						SendPacket(API.hexstringtobyte("F44406000F04" + API.Int32ToHex2(id) + "0000"));
						break;
					}
					num = checked(num + 1);
				}
				while (num <= 4);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

		public void XuongNgua()
		{
			SendPacket(API.hexstringtobyte("F44402000F05"));
		}

		public void ThanhLuuChar(int id)
		{
			SendPacket(API.hexstringtobyte("F4440B00171402FC2A0200" + API.Int32ToHex4(id)));
		}

		public void ThanhLuuPet()
		{
			SendPacket(API.hexstringtobyte("F4440B00171402FC2A04" + PetBattle.ToString("X2") + API.Int32ToHex4(Data_PetInfo._Id)));
		}

		public void CharEatHp()
		{
			if (Data_Player._HpMax <= 0 || checked((int)Math.Round(Conversion.Val((double)Data_Player._Hp / (double)Data_Player._HpMax * 100.0))) > TextBox_Eat_char_hp_value)
			{
				return;
			}
			foreach (_Data._Tuido value in Data_Tuido.Values)
			{
				if (value._Id > 0 && GetItemHp(value._Id) > 0)
				{
					SendPacket(API.hexstringtobyte("F4440600170F" + value._Stt.ToString("X2") + "010000"));
					break;
				}
			}
		}

		public void CharEatSp()
		{
			if (Data_Player._SpMax <= 0 || checked((int)Math.Round(Conversion.Val((double)Data_Player._Sp / (double)Data_Player._SpMax * 100.0))) > TextBox_Eat_char_sp_value)
			{
				return;
			}
			foreach (_Data._Tuido value in Data_Tuido.Values)
			{
				if (value._Id > 0 && GetItemSp(value._Id) > 0)
				{
					SendPacket(API.hexstringtobyte("F4440600170F" + value._Stt.ToString("X2") + "010000"));
					break;
				}
			}
		}

		public void PetEatHp()
		{
			if (Data_PetInfo._HpMax <= 0 || checked((int)Math.Round(Conversion.Val((double)Data_PetInfo._Hp / (double)Data_PetInfo._HpMax * 100.0))) > TextBox_Eat_Pet_hp_value)
			{
				return;
			}
			foreach (_Data._Tuido value in Data_Tuido.Values)
			{
				if (value._Id > 0 && GetItemHp(value._Id) > 0)
				{
					SendPacket(API.hexstringtobyte("F4440600170F" + value._Stt.ToString("X2") + "01" + PetBattle.ToString("X2") + "00"));
					break;
				}
			}
		}

		public void PetEatSp()
		{
			if (Data_PetInfo._SpMax <= 0 || checked((int)Math.Round(Conversion.Val((double)Data_PetInfo._Sp / (double)Data_PetInfo._SpMax * 100.0))) > TextBox_Eat_Pet_sp_value)
			{
				return;
			}
			foreach (_Data._Tuido value in Data_Tuido.Values)
			{
				if (value._Id > 0 && GetItemSp(value._Id) > 0)
				{
					SendPacket(API.hexstringtobyte("F4440600170F" + value._Stt.ToString("X2") + "01" + PetBattle.ToString("X2") + "00"));
					break;
				}
			}
		}

		public void CharEquit(int _slot, int _count)
		{
			SendPacket(API.hexstringtobyte("F4440300170B" + _slot.ToString("X2")));
			if (_count > Data_Tuido[_slot]._Sl)
			{
				SendPacket(API.hexstringtobyte("F4440600170F" + _slot.ToString("X2") + Data_Tuido[_slot]._Sl.ToString("X2") + "0000"));
			}
			else
			{
				SendPacket(API.hexstringtobyte("F4440600170F" + _slot.ToString("X2") + _count.ToString("X2") + "0000"));
			}
		}

		public void PetEquit(int _slot, int _count)
		{
			SendPacket(API.hexstringtobyte("F44404001711" + PetBattle.ToString("X2") + _slot.ToString("X2")));
			if (_count > Data_Tuido[_slot]._Sl)
			{
				SendPacket(API.hexstringtobyte("F4440600170F" + _slot.ToString("X2") + Data_Tuido[_slot]._Sl.ToString("X2") + PetBattle.ToString("X2") + "00"));
			}
			else
			{
				SendPacket(API.hexstringtobyte("F4440600170F" + _slot.ToString("X2") + _count.ToString("X2") + PetBattle.ToString("X2") + "00"));
			}
		}

		public void PetEquit_bySlot(int _slot, int _count, int _slotpet)
		{
			SendPacket(API.hexstringtobyte("F44404001711" + _slotpet.ToString("X2") + _slot.ToString("X2")));
			if (_count > Data_Tuido[_slot]._Sl)
			{
				SendPacket(API.hexstringtobyte("F4440600170F" + _slot.ToString("X2") + Data_Tuido[_slot]._Sl.ToString("X2") + _slotpet.ToString("X2") + "00"));
			}
			else
			{
				SendPacket(API.hexstringtobyte("F4440600170F" + _slot.ToString("X2") + _count.ToString("X2") + _slotpet.ToString("X2") + "00"));
			}
		}

		public void CharRemoveEquit(int _Slot)
		{
			foreach (_Data._Tuido value in Data_Tuido.Values)
			{
				if (value._Id == 0)
				{
					SendPacket(API.hexstringtobyte("F4440400170C" + checked(_Slot + 1).ToString("X2") + value._Stt.ToString("X2")));
					break;
				}
			}
		}

		public void PetRemoveEquit(int _sttpet, int _Slotitem)
		{
			foreach (_Data._Tuido value in Data_Tuido.Values)
			{
				if (value._Id == 0)
				{
					SendPacket(API.hexstringtobyte("F44405001712" + _sttpet.ToString("X2") + checked(_Slotitem + 1).ToString("X2") + value._Stt.ToString("X2")));
					break;
				}
			}
		}

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

		public void ClickNPCId(int id)
		{
			NpcOnMap.Key_NpcOnMap key = new NpcOnMap.Key_NpcOnMap
			{
				_Idmap = Data_Player._MapId,
				_id = id
			};
			if (NpcOnMap.Data_NpcOnMap.ContainsKey(key))
			{
				_npctalking = NpcOnMap.Data_NpcOnMap[key]._Name;
			}
			string text = API.bytestohexstring(new byte[2]
			{
				API.hexstringtobyte(id.ToString("X4"))[1],
				API.hexstringtobyte(id.ToString("X4"))[0]
			});
			byte[] packet = API.hexstringtobyte("F44404001401" + text);
			SendPacket(packet);
		}

		public void ChoiceId(int id)
		{
			id = checked(id + 29);
			byte[] packet = API.hexstringtobyte("F44403001409" + id.ToString("X2"));
			SendPacket(packet);
		}

		public void Walk(int x, int y)
		{
			string text = API.bytestohexstring(new byte[2]
			{
				API.hexstringtobyte(x.ToString("X4"))[1],
				API.hexstringtobyte(x.ToString("X4"))[0]
			});
			string text2 = API.bytestohexstring(new byte[2]
			{
				API.hexstringtobyte(y.ToString("X4"))[1],
				API.hexstringtobyte(y.ToString("X4"))[0]
			});
			byte[] packet = API.hexstringtobyte("F4440900060105" + text + text2 + "47EB");
			SendPacket(packet);
			Data_Player._MapX = x;
			Data_Player._MapY = y;
		}

		public void Warp(int id)
		{
			byte[] packet = API.hexstringtobyte("F44404001408" + id.ToString("X2") + "00");
			SendPacket(packet);
		}

		public void Pickup(int id)
		{
			byte[] packet = API.hexstringtobyte("F44404001702" + API.Int32ToHex2(id));
			SendPacket(packet);
		}

		public void DropItem(int _slot, int _count)
		{
			byte[] packet = API.hexstringtobyte("F44404001703" + _slot.ToString("X2") + _count.ToString("X2"));
			SendPacket(packet);
		}

		public void DropGold(int _count)
		{
			byte[] packet = API.hexstringtobyte("F44406001710" + API.Int32ToHex4(_count));
			SendPacket(packet);
		}

		public void ContributeItem(int _slot)
		{
			byte[] packet = API.hexstringtobyte("F4440700270F00000000" + _slot.ToString("X2"));
			SendPacket(packet);
		}

		public void SendItem(int _IdBDY, int _IdPlayer, int _slot, int _count)
		{
			int num = 0;
			if (_list_BDY.Contains(Data_PetsInfo[1]._Id))
			{
				num = 1;
			}
			if (_list_BDY.Contains(Data_PetsInfo[2]._Id))
			{
				num = 1;
			}
			if (_list_BDY.Contains(Data_PetsInfo[3]._Id))
			{
				num = 1;
			}
			if (_list_BDY.Contains(Data_PetsInfo[4]._Id))
			{
				num = 1;
			}
			switch (num)
			{
			case 0:
				Label_BDY = "Không có BDY để gửi";
				break;
			case 1:
			{
				_stt_send = _slot;
				Label_BDY = "Đang gửi Ba Đậu Yêu";
				byte[] packet = API.hexstringtobyte("F44414001914" + API.Int32ToHex4(_IdBDY) + API.Int32ToHex4(_IdPlayer) + _slot.ToString("X2") + _count.ToString("X2") + "0000000000000000");
				SendPacket(packet);
				ProgressBarEx_BDY = 0;
				break;
			}
			}
		}

		public void Moveitem(int _slot1, int _count, int _slot2)
		{
			byte[] packet = API.hexstringtobyte("F4440500170A" + _slot1.ToString("X2") + _count.ToString("X2") + _slot2.ToString("X2"));
			SendPacket(packet);
		}

		public void SellItem(int _slot, int _count)
		{
			byte[] packet = API.hexstringtobyte("F44404001B02" + _slot.ToString("X2") + _count.ToString("X2"));
			SendPacket(packet);
		}

		public string GetLocation(string i)
		{
			string result = "0002";
			switch (FnvHash.Compute(i))
			{
			case 873244444u:
				if (Operators.CompareString(i, "1", false) == 0)
				{
					result = "0000";
				}
				break;
			case 923577301u:
				if (Operators.CompareString(i, "2", false) == 0)
				{
					result = "0001";
				}
				break;
			case 906799682u:
				if (Operators.CompareString(i, "3", false) == 0)
				{
					result = "0002";
				}
				break;
			case 822911587u:
				if (Operators.CompareString(i, "4", false) == 0)
				{
					result = "0003";
				}
				break;
			case 806133968u:
				if (Operators.CompareString(i, "5", false) == 0)
				{
					result = "0004";
				}
				break;
			case 856466825u:
				if (Operators.CompareString(i, "6", false) == 0)
				{
					result = "0100";
				}
				break;
			case 839689206u:
				if (Operators.CompareString(i, "7", false) == 0)
				{
					result = "0101";
				}
				break;
			case 1024243015u:
				if (Operators.CompareString(i, "8", false) == 0)
				{
					result = "0102";
				}
				break;
			case 1007465396u:
				if (Operators.CompareString(i, "9", false) == 0)
				{
					result = "0103";
				}
				break;
			case 468396612u:
				if (Operators.CompareString(i, "10", false) == 0)
				{
					result = "0104";
				}
				break;
			case 485174231u:
				if (Operators.CompareString(i, "11", false) == 0)
				{
					result = "0200";
				}
				break;
			case 501951850u:
				if (Operators.CompareString(i, "12", false) == 0)
				{
					result = "0201";
				}
				break;
			case 518729469u:
				if (Operators.CompareString(i, "13", false) == 0)
				{
					result = "0202";
				}
				break;
			case 401286136u:
				if (Operators.CompareString(i, "14", false) == 0)
				{
					result = "0203";
				}
				break;
			case 418063755u:
				if (Operators.CompareString(i, "15", false) == 0)
				{
					result = "0204";
				}
				break;
			case 434841374u:
				if (Operators.CompareString(i, "16", false) == 0)
				{
					result = "0300";
				}
				break;
			case 451618993u:
				if (Operators.CompareString(i, "17", false) == 0)
				{
					result = "0301";
				}
				break;
			case 334175660u:
				if (Operators.CompareString(i, "18", false) == 0)
				{
					result = "0302";
				}
				break;
			case 350953279u:
				if (Operators.CompareString(i, "19", false) == 0)
				{
					result = "0303";
				}
				break;
			case 2381486463u:
				if (Operators.CompareString(i, "20", false) == 0)
				{
					result = "0304";
				}
				break;
			}
			return result;
		}

		public int GetLocation2(string i)
		{
			int result = 1;
			switch (FnvHash.Compute(i))
			{
			case 3052262101u:
				if (Operators.CompareString(i, "0000", false) == 0)
				{
					result = 1;
				}
				break;
			case 3035484482u:
				if (Operators.CompareString(i, "0001", false) == 0)
				{
					result = 2;
				}
				break;
			case 3018706863u:
				if (Operators.CompareString(i, "0002", false) == 0)
				{
					result = 3;
				}
				break;
			case 3001929244u:
				if (Operators.CompareString(i, "0003", false) == 0)
				{
					result = 4;
				}
				break;
			case 2985151625u:
				if (Operators.CompareString(i, "0004", false) == 0)
				{
					result = 5;
				}
				break;
			case 3591938314u:
				if (Operators.CompareString(i, "0100", false) == 0)
				{
					result = 6;
				}
				break;
			case 3608715933u:
				if (Operators.CompareString(i, "0101", false) == 0)
				{
					result = 7;
				}
				break;
			case 3558383076u:
				if (Operators.CompareString(i, "0102", false) == 0)
				{
					result = 8;
				}
				break;
			case 3575160695u:
				if (Operators.CompareString(i, "0103", false) == 0)
				{
					result = 9;
				}
				break;
			case 3524827838u:
				if (Operators.CompareString(i, "0104", false) == 0)
				{
					result = 10;
				}
				break;
			case 1468087007u:
				if (Operators.CompareString(i, "0200", false) == 0)
				{
					result = 11;
				}
				break;
			case 1451309388u:
				if (Operators.CompareString(i, "0201", false) == 0)
				{
					result = 12;
				}
				break;
			case 1501642245u:
				if (Operators.CompareString(i, "0202", false) == 0)
				{
					result = 13;
				}
				break;
			case 1484864626u:
				if (Operators.CompareString(i, "0203", false) == 0)
				{
					result = 14;
				}
				break;
			case 1400976531u:
				if (Operators.CompareString(i, "0204", false) == 0)
				{
					result = 15;
				}
				break;
			case 4176086804u:
				if (Operators.CompareString(i, "0300", false) == 0)
				{
					result = 16;
				}
				break;
			case 4192864423u:
				if (Operators.CompareString(i, "0301", false) == 0)
				{
					result = 17;
				}
				break;
			case 4209642042u:
				if (Operators.CompareString(i, "0302", false) == 0)
				{
					result = 18;
				}
				break;
			case 4226419661u:
				if (Operators.CompareString(i, "0303", false) == 0)
				{
					result = 19;
				}
				break;
			case 4108976328u:
				if (Operators.CompareString(i, "0304", false) == 0)
				{
					result = 20;
				}
				break;
			}
			return result;
		}

		public void CharacterAttack(int idskill, string location)
		{
			if (Data_Player._Sp < GetSkillSP(idskill))
			{
				idskill = 10000;
			}
			string text = API.Int32ToHex2(idskill);
			string text2 = "0002";
			checked
			{
				if (Operators.CompareString(location, "Lần lượt", false) != 0)
				{
					if (Operators.CompareString(location, "F1", false) == 0)
					{
						int num = 1;
						do
						{
							if (Data_Battles[num]._Hp > 0)
							{
								if (num < 10)
								{
									text2 = GetLocation(num.ToString());
									int num2 = num + 1;
									for (int i = num2; i <= 10; i++)
									{
										if (Data_Battles[i]._Hp > 0)
										{
											text2 = GetLocation(i.ToString());
											break;
										}
									}
								}
								else
								{
									text2 = "0104";
								}
								break;
							}
							num++;
						}
						while (num <= 10);
					}
					else
					{
						text2 = GetLocation(location);
					}
				}
				else
				{
					int num3 = 1;
					do
					{
						if (Data_Battles[num3]._Hp > 0)
						{
							text2 = GetLocation(num3.ToString());
							break;
						}
						num3++;
					}
					while (num3 <= 10);
				}
				SendPacket(API.hexstringtobyte("F4440A00320103" + Char_col.ToString("X2") + text2 + text + "0F16"));
				SendPacket(API.hexstringtobyte("F4440A00320103" + Char_col.ToString("X2") + text2 + text + "0F16"));
			}
		}

		public void PetAttack(int idskill, string location)
		{
			if (Data_PetInfo._Sp < GetSkillSP(idskill))
			{
				idskill = 10000;
			}
			string text = API.Int32ToHex2(idskill);
			string text2 = "0002";
			checked
			{
				if (Operators.CompareString(location, "Lần lượt", false) != 0)
				{
					if (Operators.CompareString(location, "F1", false) == 0)
					{
						int num = 1;
						do
						{
							if (Data_Battles[num]._Hp > 0)
							{
								if (num < 10)
								{
									text2 = GetLocation(num.ToString());
									int num2 = num + 1;
									for (int i = num2; i <= 10; i++)
									{
										if (Data_Battles[i]._Hp > 0)
										{
											text2 = GetLocation(i.ToString());
											break;
										}
									}
								}
								else
								{
									text2 = "0104";
								}
								break;
							}
							num++;
						}
						while (num <= 10);
					}
					else
					{
						text2 = GetLocation(location);
					}
				}
				else
				{
					int num3 = 1;
					do
					{
						if (Data_Battles[num3]._Hp > 0)
						{
							text2 = GetLocation(num3.ToString());
							break;
						}
						num3++;
					}
					while (num3 <= 10);
				}
				SendPacket(API.hexstringtobyte("F4440A00320102" + Char_col.ToString("X2") + text2 + text + "0F16"));
				SendPacket(API.hexstringtobyte("F4440A00320102" + Char_col.ToString("X2") + text2 + text + "0F16"));
			}
		}

		private List<TreeNode> a(TreeNode A_0)
		{
			List<TreeNode> list = new List<TreeNode>();
			a(A_0, list);
			return list;
		}

		private void a(TreeNode A_0, List<TreeNode> A_1)
		{
			A_1.Add(A_0);
			foreach (TreeNode node in A_0.Nodes)
			{
				A_1.Add(node);
				a(node, A_1);
			}
		}

		public void AutoWarp(string idmap)
		{
			string text = Conversions.ToString(Data_Player._MapId);
			checked
			{
				if ((Operators.CompareString(text, idmap, false) != 0) & (BTQ == 0))
				{
					listWarp.Clear();
					foreach (TreeNode item in a(TreeView1.Nodes[0]))
					{
						TreeNode treeNode = item;
						if (Operators.CompareString(treeNode.Name, text, false) != 0)
						{
							continue;
						}
						listStart.Clear();
						while (treeNode.Parent != null)
						{
							if (treeNode.Parent != null)
							{
								listStart.Add(treeNode.Name);
								treeNode = treeNode.Parent;
							}
						}
						listStart.Add(TreeView1.Nodes[0].Name);
						break;
					}
					if (!listStart.Contains(idmap))
					{
						foreach (TreeNode item2 in a(TreeView1.Nodes[0]))
						{
							TreeNode treeNode2 = item2;
							if (Operators.CompareString(treeNode2.Name, idmap, false) != 0)
							{
								continue;
							}
							listEnd.Clear();
							while (treeNode2.Parent != null)
							{
								if (treeNode2.Parent != null)
								{
									if (!listEnd.Contains(treeNode2.Name))
									{
										listEnd.Add(treeNode2.Name);
										treeNode2 = treeNode2.Parent;
									}
									else if (listEnd.Contains(treeNode2.Name))
									{
										break;
									}
								}
							}
							listEnd.Add(TreeView1.Nodes[0].Name);
							break;
						}
						foreach (object item3 in listStart)
						{
							string value = Conversions.ToString(item3);
							listWarp.Add(value);
							if (listEnd.IndexOf(value) > 0)
							{
								int num = listEnd.IndexOf(value) - 1;
								for (int i = num; i >= 0; i += -1)
								{
									listWarp.Add(RuntimeHelpers.GetObjectValue(listEnd[i]));
								}
								break;
							}
						}
					}
					else if (listStart.Contains(idmap))
					{
						foreach (object item4 in listStart)
						{
							string text2 = Conversions.ToString(item4);
							listWarp.Add(text2);
							if (Operators.CompareString(text2, idmap, false) == 0)
							{
								break;
							}
						}
					}
					if (Operators.CompareString(GetMapIdNext(listWarp, Data_Player._MapId.ToString()), AutoWarptoMap, false) == 0)
					{
						int warpID = GetWarpID(Data_Player._MapId.ToString(), GetMapIdNext(listWarp, Data_Player._MapId.ToString()));
						if (warpID > 0)
						{
							Warp(warpID);
							return;
						}
						listWarp.Clear();
						atw = 0;
					}
					else if (Operators.CompareString(GetMapIdNext(listWarp, Data_Player._MapId.ToString()), AutoWarptoMap, false) != 0)
					{
						int warpID2 = GetWarpID(Data_Player._MapId.ToString(), GetMapIdNext(listWarp, Data_Player._MapId.ToString()));
						if (warpID2 > 0)
						{
							Warp(warpID2);
							return;
						}
						listWarp.Clear();
						atw = 0;
					}
				}
				else
				{
					listWarp.Clear();
					atw = 0;
				}
			}
		}

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

		public void AutoThanhLuu()
		{
			string text = "";
			if (C_CheckBox_TL_mem1)
			{
				text = text + "F4440B00171402FC2A0200" + API.Int32ToHex4(TextBox_IDmem1);
			}
			if (C_CheckBox_TL_mem2)
			{
				text = text + "F4440B00171402FC2A0200" + API.Int32ToHex4(TextBox_IDmem2);
			}
			if (C_CheckBox_TL_mem3)
			{
				text = text + "F4440B00171402FC2A0200" + API.Int32ToHex4(TextBox_IDmem3);
			}
			if (C_CheckBox_TL_mem4)
			{
				text = text + "F4440B00171402FC2A0200" + API.Int32ToHex4(TextBox_IDmem4);
			}
			if (C_CheckBox_TL_pet1 && PetBattle > 0 && ((Conversion.Val((double)Data_PetInfo._Hp / (double)Data_PetInfo._HpMax * 100.0) < Conversion.Val(TextBox_TL_pet_hp_value)) | (Conversion.Val((double)Data_PetInfo._Sp / (double)Data_PetInfo._SpMax * 100.0) < Conversion.Val(TextBox_TL_pet_sp_value))))
			{
				text = text + "F4440B00171402FC2A04" + PetBattle.ToString("X2") + API.Int32ToHex4(Data_PetInfo._Id);
			}
			if (C_CheckBox_TL_pet2 && PetBattle > 0 && ((Conversion.Val((double)Data_PetInfo._Hp / (double)Data_PetInfo._HpMax * 100.0) < Conversion.Val(TextBox_TL_pet_hp_value)) | (Conversion.Val((double)Data_PetInfo._Sp / (double)Data_PetInfo._SpMax * 100.0) < Conversion.Val(TextBox_TL_pet_sp_value))))
			{
				text = text + "F4440B00171402FC2A04" + PetBattle.ToString("X2") + API.Int32ToHex4(Data_PetInfo._Id);
				text = text + "F4440B00171402FC2A04" + PetBattle.ToString("X2") + API.Int32ToHex4(Data_PetInfo._Id);
			}
			if (text.Length > 0)
			{
				SendPacket(API.hexstringtobyte(text));
			}
		}

		public void AutoDropContribute()
		{
			string text = "";
			foreach (_Data._Tuido value in Data_Tuido.Values)
			{
				int id = value._Id;
				int stt = value._Stt;
				int sl = value._Sl;
				if (!((id > 0) & Items.Data_Items.ContainsKey(id)))
				{
					continue;
				}
				Items.ItemInfo items = Items.Data_Items[id];
				if (Data_ListDrop.Contains(id))
				{
					text = text + "F44404001703" + stt.ToString("X2") + sl.ToString("X2");
				}
				if (sl != 0)
				{
					if (C_CheckBox_DropHp)
					{
						int hp = items._Hp;
						if ((hp > 0) & (hp < TextBox_Drop_HpValue))
						{
							text = text + "F44404001703" + stt.ToString("X2") + sl.ToString("X2");
						}
					}
					if (C_CheckBox_DropSp)
					{
						int sp = items._Sp;
						if ((sp > 0) & (sp < TextBox_Drop_SpValue))
						{
							text = text + "F44404001703" + stt.ToString("X2") + sl.ToString("X2");
						}
					}
					if (C_CheckBox_DropHpSp)
					{
						int hp2 = items._Hp;
						int sp2 = items._Sp;
						if (hp2 > 0 && sp2 > 0 && ((hp2 < TextBox_Drop_HpValue) & (sp2 < TextBox_Drop_SpValue)))
						{
							text = text + "F44404001703" + stt.ToString("X2") + sl.ToString("X2");
						}
					}
					if (C_CheckBox_DropMineWood)
					{
						int type_ = items._Type_2;
						if (type_ == 25 || (uint)(type_ - 40) <= 6u)
						{
							text = text + "F44404001703" + stt.ToString("X2") + sl.ToString("X2");
						}
					}
				}
				if (Data_ListContribute.Contains(id))
				{
					text = text + "F4440700270F00000000" + stt.ToString("X2");
				}
				if (sl == 0)
				{
					continue;
				}
				if (C_CheckBox_ContributeHp)
				{
					int hp3 = items._Hp;
					if ((hp3 > 0) & (hp3 < TextBox_Contribute_HpValue))
					{
						text = text + "F4440700270F00000000" + stt.ToString("X2");
					}
				}
				if (C_CheckBox_ContributeSp)
				{
					int sp3 = items._Sp;
					if ((sp3 > 0) & (sp3 < TextBox_Contribute_SpValue))
					{
						text = text + "F4440700270F00000000" + stt.ToString("X2");
					}
				}
				if (C_CheckBox_ContributeHpSp)
				{
					int hp4 = items._Hp;
					int sp4 = items._Sp;
					if (hp4 > 0 && sp4 > 0 && ((hp4 < TextBox_Contribute_HpValue) & (sp4 < TextBox_Contribute_SpValue)))
					{
						text = text + "F4440700270F00000000" + stt.ToString("X2");
					}
				}
				if (C_CheckBox_ContributeMineWood)
				{
					int type_2 = items._Type_2;
					if (type_2 == 25 || (uint)(type_2 - 40) <= 6u)
					{
						text = text + "F4440700270F00000000" + stt.ToString("X2");
					}
				}
			}
			if (checked(text.Length + packetAutoContribute.Length) > 0)
			{
				SendPacket(API.hexstringtobyte(text + packetAutoContribute));
			}
		}

		public void AutoSendItem()
		{
			if (ProgressBarEx_BDY > 0)
			{
				ProgressBarEx_BDY = 0;
			}
			int textBox_AutoSend = TextBox_AutoSend;
			if (textBox_AutoSend <= 0)
			{
				return;
			}
			foreach (_Data._Tuido value in Data_Tuido.Values)
			{
				int id = value._Id;
				int stt = value._Stt;
				int sl = value._Sl;
				int num = 0;
				int num2 = 1;
				do
				{
					if (_list_BDY.Contains(Data_PetsInfo[num2]._Id))
					{
						num = Data_PetsInfo[num2]._Id;
					}
					num2 = checked(num2 + 1);
				}
				while (num2 <= 4);
				if (!((id > 0 && num > 0) & Items.Data_Items.ContainsKey(id)))
				{
					continue;
				}
				Items.ItemInfo items = Items.Data_Items[id];
				switch (items._Trade)
				{
				case 11:
				case 13:
				case 14:
				case 15:
				case 29:
				case 30:
				case 31:
				case 63:
				case 65:
				case 75:
				case 77:
				case 79:
				case 91:
				case 93:
				case 95:
				case 111:
				case 119:
				case 123:
				case 127:
				case 143:
				case 159:
					continue;
				}
				if (Data_ListSend.Contains(id))
				{
					switch (items._Loai)
					{
					case 0:
						if (sl == 50)
						{
							SendItem(num, textBox_AutoSend, stt, sl);
							return;
						}
						break;
					case 1:
					case 2:
					case 3:
					case 4:
					case 5:
					case 6:
						SendItem(num, textBox_AutoSend, stt, sl);
						return;
					}
				}
				if (sl != 50)
				{
					continue;
				}
				if (C_CheckBox_SendHp)
				{
					int hp = items._Hp;
					if ((hp > 0) & (hp < TextBox_Send_HpValue))
					{
						SendItem(num, textBox_AutoSend, stt, sl);
						return;
					}
				}
				if (C_CheckBox_SendSp)
				{
					int sp = items._Sp;
					if ((sp > 0) & (sp < TextBox_Send_SpValue))
					{
						SendItem(num, textBox_AutoSend, stt, sl);
						return;
					}
				}
				if (C_CheckBox_SendHpSp)
				{
					int hp2 = items._Hp;
					int sp2 = items._Sp;
					if (hp2 > 0 && sp2 > 0 && ((hp2 < TextBox_Send_HpValue) & (sp2 < TextBox_Send_SpValue)))
					{
						SendItem(num, textBox_AutoSend, stt, sl);
						return;
					}
				}
				if (C_CheckBox_SendMineWood)
				{
					int type_ = items._Type_2;
					if (type_ == 25 || (uint)(type_ - 40) <= 6u)
					{
						SendItem(num, textBox_AutoSend, stt, sl);
						return;
					}
				}
			}
		}

		public void DC_FullHomdo()
		{
			int num = 0;
			foreach (_Data._Tuido value in Data_Tuido.Values)
			{
				if (value._Id == 0)
				{
					num = 1;
					break;
				}
			}
			if (num == 0)
			{
				API.AddColorText2(this, Rtbsystem, "Ngắt kết vì thiết lập đầy hòm!", Color.Red);
				_Disconnect();
			}
		}

		public void AutoSellItem()
		{
			foreach (_Data._Tuido value in Data_Tuido.Values)
			{
				int id = value._Id;
				int stt = value._Stt;
				int sl = value._Sl;
				if (id <= 0)
				{
					continue;
				}
				Thread.Sleep(200);
				if (!Items.Data_Items.ContainsKey(id))
				{
					continue;
				}
				Items.ItemInfo items = Items.Data_Items[id];
				if (items._Point <= 0)
				{
					continue;
				}
				int mapId = Data_Player._MapId;
				if (mapId != 12223)
				{
					continue;
				}
				if (C_CheckBox_SellHp)
				{
					int hp = items._Hp;
					if ((hp > 0) & (hp < TextBox_Sell_HpValue))
					{
						SellItem(stt, sl);
						API.AddColorText2(this, Rtbsystem, "Đã bán :" + Conversions.ToString(sl) + " " + value._Name, Color.DarkRed);
					}
				}
				if (C_CheckBox_SellSP)
				{
					int sp = items._Sp;
					if ((sp > 0) & (sp < TextBox_Sell_SpValue))
					{
						SellItem(stt, sl);
						API.AddColorText2(this, Rtbsystem, "Đã bán :" + Conversions.ToString(sl) + " " + value._Name, Color.DarkRed);
					}
				}
				if (C_CheckBox_SellHpSp)
				{
					int hp2 = items._Hp;
					int sp2 = items._Sp;
					if (hp2 > 0 && sp2 > 0 && ((hp2 < TextBox_Sell_HpValue) & (sp2 < TextBox_Sell_SpValue)))
					{
						SellItem(stt, sl);
						API.AddColorText2(this, Rtbsystem, "Đã bán : " + Conversions.ToString(sl) + " " + value._Name, Color.DarkRed);
					}
				}
				if (Data_ListSell.Contains(id))
				{
					SellItem(stt, sl);
					API.AddColorText2(this, Rtbsystem, "Đã bán :" + Conversions.ToString(sl) + " " + value._Name, Color.DarkRed);
				}
				if (C_CheckBox_SellMineWood)
				{
					int type_ = items._Type_2;
					if (type_ == 25 || (uint)(type_ - 40) <= 6u)
					{
						SellItem(stt, sl);
						API.AddColorText2(this, Rtbsystem, "Đã bán :" + Conversions.ToString(sl) + " " + value._Name, Color.DarkRed);
					}
				}
			}
		}

		public void replybot()
		{
			Thread.Sleep(checked((int)Math.Round(TextBox_DelayBot * 1000.0)));
			try
			{
				if (Operators.CompareString(API.ServerIp, "159.196.70.237", false) == 0)
				{
					SendPacket(API.hexstringtobyte("F444040014890000"));
				}
				ClickNPCId(99);
				StartBot();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				_Disconnect();
				ProjectData.ClearProjectError();
			}
		}

		public void StartBot()
		{
			if ((idmapbot == 0) | (idmapbot == Data_Player._MapId))
			{
				SendPacket(API.hexstringtobyte(packetbot));
			}
			else if (atw == 0)
			{
				atw = 1;
				AutoWarptoMap = idmapbot.ToString();
				AutoWarp(AutoWarptoMap);
			}
		}

		public void SendEnd()
		{
			SendPacket(API.hexstringtobyte("F44402001406"));
		}

		public string GetNamePlayer(int id)
		{
			string result = "";
			if (id == Data_Player._Id)
			{
				result = Data_Player._Name;
			}
			else if (Data_Players.ContainsKey(id))
			{
				result = Data_Players[id]._Name;
			}
			return result;
		}

		public int GetIdPlayer(string name)
		{
			int id = default(int);
			foreach (Listplayers._Player value in Data_Players.Values)
			{
				if (Operators.CompareString(value._Name, name, false) == 0)
				{
					id = value._Id;
				}
			}
			return id;
		}

		public string GetItemName(int _id)
		{
			string result = "";
			try
			{
				if (List_Items.ContainsKey(_id))
				{
					result = List_Items[_id]._Name;
				}
				else if (Items.Data_Items.ContainsKey(_id))
				{
					Items.ItemInfo value = Items.Data_Items[_id];
					List_Items.Add(_id, value);
					result = value._Name;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		public int GetItemHp(int _id)
		{
			int result = 0;
			try
			{
				if (List_Items.ContainsKey(_id))
				{
					result = List_Items[_id]._Hp;
				}
				else if (Items.Data_Items.ContainsKey(_id))
				{
					Items.ItemInfo value = Items.Data_Items[_id];
					List_Items.Add(_id, value);
					result = value._Hp;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		public int GetItemSp(int _id)
		{
			int result = 0;
			try
			{
				if (List_Items.ContainsKey(_id))
				{
					result = List_Items[_id]._Sp;
				}
				else if (Items.Data_Items.ContainsKey(_id))
				{
					Items.ItemInfo value = Items.Data_Items[_id];
					List_Items.Add(_id, value);
					result = value._Sp;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		public string GetItemInfo(int _id)
		{
			string text = "";
			try
			{
				if (List_Items.ContainsKey(_id))
				{
					Items.ItemInfo value = List_Items[_id];
					List_Items.Add(_id, value);
					if (value._Lv >= 0)
					{
						text = text + "Lv: " + value._Lv + "\r\n";
					}
					if (value._tt >= 0)
					{
						text = text + "TT: " + API.GetThuocTinh(value._tt) + "\r\n";
					}
					if (value._Hp > 0)
					{
						text = text + "Hp: " + value._Hp + "\r\n";
					}
					if (value._Sp > 0)
					{
						text = text + "Sp: " + value._Sp + "\r\n";
					}
					if (value._Int1 > 0)
					{
						text = text + "Int: " + value._Int1 + "\r\n";
					}
					if (value._Atk1 > 0)
					{
						text = text + "Atk: " + value._Atk1 + "\r\n";
					}
					if (value._Def1 > 0)
					{
						text = text + "Def: " + value._Def1 + "\r\n";
					}
					if (value._Hpx1 > 0)
					{
						text = text + "Hpx: " + value._Hpx1 + "\r\n";
					}
					if (value._Spx1 > 0)
					{
						text = text + "Spx: " + value._Spx1 + "\r\n";
					}
					if (value._Agi1 > 0)
					{
						text = text + "Agi: " + value._Agi1 + "\r\n";
					}
					if (value._Fai1 > 0)
					{
						text = text + "Fai: " + value._Fai1 + "\r\n";
					}
					text = "\r\n" + text + API.VISCII_to_Unicode(value._Info);
				}
				else if (Items.Data_Items.ContainsKey(_id))
				{
					Items.ItemInfo value2 = Items.Data_Items[_id];
					List_Items.Add(_id, value2);
					if (value2._Lv >= 0)
					{
						text = text + "Lv: " + value2._Lv + "\r\n";
					}
					if (value2._tt >= 0)
					{
						text = text + "TT: " + API.GetThuocTinh(value2._tt) + "\r\n";
					}
					if (value2._Hp > 0)
					{
						text = text + "Hp: " + value2._Hp + "\r\n";
					}
					if (value2._Sp > 0)
					{
						text = text + "Sp: " + value2._Sp + "\r\n";
					}
					if (value2._Int1 > 0)
					{
						text = text + "Int: " + value2._Int1 + "\r\n";
					}
					if (value2._Atk1 > 0)
					{
						text = text + "Atk: " + value2._Atk1 + "\r\n";
					}
					if (value2._Def1 > 0)
					{
						text = text + "Def: " + value2._Def1 + "\r\n";
					}
					if (value2._Hpx1 > 0)
					{
						text = text + "Hpx: " + value2._Hpx1 + "\r\n";
					}
					if (value2._Spx1 > 0)
					{
						text = text + "Spx: " + value2._Spx1 + "\r\n";
					}
					if (value2._Agi1 > 0)
					{
						text = text + "Agi: " + value2._Agi1 + "\r\n";
					}
					if (value2._Fai1 > 0)
					{
						text = text + "Fai: " + value2._Fai1 + "\r\n";
					}
					text = "\r\n" + text + API.VISCII_to_Unicode(value2._Info);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			return text;
		}

		public string GetNameNPC(int id)
		{
			string result = "";
			try
			{
				if (List_Npcs.ContainsKey(id))
				{
					result = List_Npcs[id]._Name;
				}
				else if (Npcs.Data_Npcs.ContainsKey(id))
				{
					List_Npcs.Add(id, Npcs.Data_Npcs[id]);
					if (id > 0)
					{
						result = Npcs.Data_Npcs[id]._Name;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		public int GetSkillId(string name)
		{
			int result = 10000;
			if (Skills.Data_Skills_Name.ContainsKey(name))
			{
				result = Skills.Data_Skills_Name[name]._Id;
			}
			return result;
		}

		public string GetSkillName(int id)
		{
			string result = Conversions.ToString(id);
			if (Skills.Data_Skills.ContainsKey(id))
			{
				result = Skills.Data_Skills[id]._Name;
			}
			return result;
		}

		public int GetSkillSP(int id)
		{
			int result = 0;
			if (Skills.Data_Skills.ContainsKey(id))
			{
				result = Skills.Data_Skills[id]._Sp;
			}
			return result;
		}

		public static string GetMapIdNext(ArrayList listmap, string mapid)
		{
			string result = "00000";
			checked
			{
				if (listmap.Contains(mapid))
				{
					int num = listmap.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(listmap[i], mapid, false), i < listmap.Count - 1)))
						{
							result = Conversions.ToString(listmap[i + 1]);
							break;
						}
					}
				}
				return result;
			}
		}

		public int GetWarpID(string mapid1, string mapid2)
		{
			int result = 0;
			Doors.Key_Door key = new Doors.Key_Door
			{
				_MapId1 = Conversions.ToInteger(mapid1),
				_MapId2 = Conversions.ToInteger(mapid2)
			};
			if (Doors.Data_Doors.ContainsKey(key))
			{
				result = Doors.Data_Doors[key];
			}
			return result;
		}

		public int TuidoGetSlotConstainId50(int Id)
		{
			int result = 0;
			int num = 1;
			do
			{
				int id = Data_Tuido[num]._Id;
				int sl = Data_Tuido[num]._Sl;
				if (id == Id && sl < 50)
				{
					result = num;
					break;
				}
				num = checked(num + 1);
			}
			while (num <= 25);
			return result;
		}

		public int TuidoGetSlotNothing()
		{
			int result = 0;
			int num = 1;
			do
			{
				if (Data_Tuido[num]._Id == 0)
				{
					result = num;
					break;
				}
				num = checked(num + 1);
			}
			while (num <= 25);
			return result;
		}

		public void AutoSort_Tuido()
		{
			int count = Data_Tuido.Count;
			if (count <= 0)
			{
				return;
			}
			ArrayList arrayList = new ArrayList();
			ArrayList arrayList2 = new ArrayList();
			ArrayList arrayList3 = new ArrayList();
			ArrayList arrayList4 = new ArrayList();
			int num = 1;
			checked
			{
				do
				{
					switch (Data_Tuido[num]._Id)
					{
					case 23086:
						arrayList.Add(num);
						break;
					case 23087:
						arrayList2.Add(num);
						break;
					case 23088:
						arrayList3.Add(num);
						break;
					case 23089:
						arrayList4.Add(num);
						break;
					}
					num++;
				}
				while (num <= 25);
				if (arrayList.Count > 4)
				{
					Moveitem(Conversions.ToInteger(arrayList[0]), 1, Conversions.ToInteger(arrayList[1]));
				}
				if (arrayList2.Count > 4)
				{
					Moveitem(Conversions.ToInteger(arrayList2[0]), 1, Conversions.ToInteger(arrayList2[1]));
				}
				if (arrayList3.Count > 4)
				{
					Moveitem(Conversions.ToInteger(arrayList3[0]), 1, Conversions.ToInteger(arrayList3[1]));
				}
				if (arrayList4.Count > 4)
				{
					Moveitem(Conversions.ToInteger(arrayList4[0]), 1, Conversions.ToInteger(arrayList4[1]));
				}
				int num2 = 1;
				do
				{
					_Data._Tuido tuido = Data_Tuido[num2];
					int id = tuido._Id;
					if (((id > 0) & Items.Data_Items.ContainsKey(id)) && Items.Data_Items[id]._Loai == 0)
					{
						int sl = tuido._Sl;
						if (sl < 50)
						{
							int num3 = 1;
							do
							{
								if (num2 != num3)
								{
									_Data._Tuido tuido2 = Data_Tuido[num3];
									int id2 = tuido2._Id;
									int sl2 = tuido2._Sl;
									if (id == id2 && sl2 < 50)
									{
										int num4 = 50 - sl2;
										if (sl >= num4)
										{
											Moveitem(num2, num4, num3);
										}
										else
										{
											Moveitem(num2, sl, num3);
										}
										return;
									}
								}
								num3++;
							}
							while (num3 <= 25);
						}
					}
					num2++;
				}
				while (num2 <= 25);
			}
		}

		private void b(ushort A_0)
		{
			if (Startautoquest)
			{
				if (talk.Data_Talks.ContainsKey(A_0))
				{
					talk.Talks talks = talk.Data_Talks[A_0];
					API.AddColorText_Quest(this, RtbQuest, _npctalking, API.VISCII_to_Unicode(talk._Get_Talk_String(talks)), Color.Blue);
				}
				SendEnd();
			}
			if (bott == 0)
			{
				API.AddColorText2(this, Rtbsystem, "Dialog Id : " + A_0, Color.Blue);
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

		private void a(ushort A_0)
		{
			checked
			{
				if (Startautoquest)
				{
					talkmenu.Key_talkmenu key = new talkmenu.Key_talkmenu
					{
						_Idmap = Data_Player._MapId,
						_id = A_0
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
					API.AddColorText2(this, Rtbsystem, "Dialog Menu Id : " + A_0, Color.Blue);
				}
			}
		}

		private bool b(int A_0)
		{
			bool result = false;
			int num = checked((int)Math.Round(Conversion.Val(Operators.MultiplyObject(Operators.DivideObject(this.get_DataBattle(A_0, _Data.Type_Battleinfo._Sp), this.get_DataBattle(A_0, _Data.Type_Battleinfo._SpMax)), 100))));
			if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreater(this.get_DataBattle(A_0, _Data.Type_Battleinfo._Id), 0, false), num <= TextBox_ValueSPFlee)))
			{
				result = true;
			}
			return result;
		}

		private void a(int A_0)
		{
			int num = 10000;
			int idskill = 10000;
			string location = "1";
			string location2 = "1";
			int num2 = 0;
			if (Data_CharAttackSetting._TurnCount > 0)
			{
				num2 = A_0 % Data_CharAttackSetting._TurnCount;
				if (num2 == 0)
				{
					num2 = Data_CharAttackSetting._TurnCount;
				}
				num = Conversions.ToInteger(this.get__CharAttackSetting("Char_Skill" + num2));
				location = Conversions.ToString(this.get__CharAttackSetting("Char_Location" + num2));
				if (num == 14026)
				{
					switch (Data_Player._ThuocTinh)
					{
					case 1:
						num = 10016;
						break;
					case 2:
						num = 11016;
						break;
					case 3:
						num = 12016;
						break;
					case 4:
						num = 13015;
						break;
					}
				}
			}
			int num3 = 0;
			if (Data_PetAttackSetting._TurnCount > 0)
			{
				num3 = A_0 % Data_PetAttackSetting._TurnCount;
				if (num3 == 0)
				{
					num3 = Data_PetAttackSetting._TurnCount;
				}
				idskill = Conversions.ToInteger(this.get__PetAttackSetting("Pet_Skill" + num3));
				location2 = Conversions.ToString(this.get__PetAttackSetting("Pet_Location" + num3));
			}
			int num4 = 0;
			int num5 = 0;
			if (!AutoClearGhost)
			{
				checked
				{
					if (C_CheckBox_AutoFlee_Party && Operators.ConditionalCompareObjectEqual(this.get_DataBattle(18, _Data.Type_Battleinfo._Id), Data_Player._Id, false) && (!Data_Player._PartyFull | (Data_Player._LeaderId == 0)))
					{
						CharacterAttack(skilldaotau, (Char_col + 15).ToString());
						if (PetBattle > 0)
						{
							PetAttack(18001, (Char_col + 10).ToString());
						}
						return;
					}
					if (C_CheckBox_AutoFlee_Sp && (b(11) | b(12) | b(13) | b(14) | b(15) | b(16) | b(17) | b(18) | b(19) | b(20)))
					{
						CharacterAttack(18001, (Char_col + 15).ToString());
						if (PetBattle > 0)
						{
							PetAttack(18001, (Char_col + 10).ToString());
						}
						return;
					}
					if (C_CheckBox_AutoRevival && skillHoiSinh == 11013)
					{
						int num6 = 16;
						do
						{
							if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreater(this.get_DataBattle(num6, _Data.Type_Battleinfo._Id), 0, false), Operators.CompareObjectLessEqual(this.get_DataBattle(num6, _Data.Type_Battleinfo._Hp), 0, false))))
							{
								CharacterAttack(11013, num6.ToString());
								num4 = 1;
							}
							num6++;
						}
						while (num6 <= 20);
						int num7 = 11;
						do
						{
							if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreater(this.get_DataBattle(num7, _Data.Type_Battleinfo._Id), 0, false), Operators.CompareObjectLessEqual(this.get_DataBattle(num7, _Data.Type_Battleinfo._Hp), 0, false))))
							{
								CharacterAttack(11013, num7.ToString());
								num4 = 1;
							}
							num7++;
						}
						while (num7 <= 15);
					}
				}
				if (C_CheckBox_Char_ChangeTG)
				{
					int id = Data_CharEquit[5]._Id;
					int doben = Data_CharEquit[5]._Doben;
					if (id == 0 || id == 23024 || doben >= 250)
					{
						foreach (_Data._Tuido value in Data_Tuido.Values)
						{
							int id2 = value._Id;
							int stt = value._Stt;
							switch (id2)
							{
							case 23086:
							case 23135:
								if (Data_Player._ThuocTinh == 1)
								{
									CharEquit(stt, 1);
									num4 = 1;
									goto end_IL_0568;
								}
								break;
							case 23087:
							case 23136:
								if (Data_Player._ThuocTinh == 2)
								{
									CharEquit(stt, 1);
									num4 = 1;
									goto end_IL_0568;
								}
								break;
							case 23088:
							case 23137:
								if (Data_Player._ThuocTinh == 3)
								{
									CharEquit(stt, 1);
									num4 = 1;
									goto end_IL_0568;
								}
								break;
							case 23089:
							case 23138:
								if (Data_Player._ThuocTinh == 4)
								{
									CharEquit(stt, 1);
									num4 = 1;
									goto end_IL_0568;
								}
								break;
							}
							continue;
							end_IL_0568:
							break;
						}
					}
				}
				if (C_CheckBox_Pet_ChangeTG)
				{
					int id3 = Data_PetEquit[5]._Id;
					int doben2 = Data_PetEquit[5]._Doben;
					int id4 = Data_PetInfo._Id;
					if (Npcs.Data_Npcs.ContainsKey(id4))
					{
						int thuoctinh = Npcs.Data_Npcs[id4]._Thuoctinh;
						if (id3 == 0 || id3 == 23024 || doben2 >= 250)
						{
							foreach (_Data._Tuido value2 in Data_Tuido.Values)
							{
								int id5 = value2._Id;
								int stt2 = value2._Stt;
								switch (id5)
								{
								case 23086:
								case 23135:
									if (thuoctinh == 1)
									{
										PetEquit(stt2, 1);
										num5 = 1;
										goto end_IL_0707;
									}
									break;
								case 23087:
								case 23136:
									if (thuoctinh == 2)
									{
										PetEquit(stt2, 1);
										num5 = 1;
										goto end_IL_0707;
									}
									break;
								case 23088:
								case 23137:
									if (thuoctinh == 3)
									{
										PetEquit(stt2, 1);
										num5 = 1;
										goto end_IL_0707;
									}
									break;
								case 23089:
								case 23138:
									if (thuoctinh == 4)
									{
										PetEquit(stt2, 1);
										num5 = 1;
										goto end_IL_0707;
									}
									break;
								}
								continue;
								end_IL_0707:
								break;
							}
						}
					}
				}
			}
			if ((num4 == 0) & (Data_CharAttackSetting._TurnCount > 0))
			{
				CharacterAttack(num, location);
			}
			if (((num5 == 0) & (Data_PetAttackSetting._TurnCount > 0)) && PetBattle > 0)
			{
				PetAttack(idskill, location2);
			}
		}

		public void _StartBot()
		{
			if (bott != 1)
			{
				return;
			}
			try
			{
				Data_Player._PartyFull = Party_CheckFull();
				if (Data_Player._PartyFull && ((Data_Player._LeaderId == Data_Player._Id) | (Data_Player._LeaderId == 0)))
				{
					if (Operators.CompareString(API.ServerIp, "159.196.70.237", false) == 0)
					{
						SendPacket(API.hexstringtobyte("F444040014890000"));
					}
					ClickNPCId(99);
					StartBot();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

		private int a(string A_0)
		{
			int result = 1;
			switch (FnvHash.Compute(A_0))
			{
			case 3052262101u:
				if (Operators.CompareString(A_0, "0000", false) == 0)
				{
					result = 1;
				}
				break;
			case 3035484482u:
				if (Operators.CompareString(A_0, "0001", false) == 0)
				{
					result = 2;
				}
				break;
			case 3018706863u:
				if (Operators.CompareString(A_0, "0002", false) == 0)
				{
					result = 3;
				}
				break;
			case 3001929244u:
				if (Operators.CompareString(A_0, "0003", false) == 0)
				{
					result = 4;
				}
				break;
			case 2985151625u:
				if (Operators.CompareString(A_0, "0004", false) == 0)
				{
					result = 5;
				}
				break;
			case 3591938314u:
				if (Operators.CompareString(A_0, "0100", false) == 0)
				{
					result = 6;
				}
				break;
			case 3608715933u:
				if (Operators.CompareString(A_0, "0101", false) == 0)
				{
					result = 7;
				}
				break;
			case 3558383076u:
				if (Operators.CompareString(A_0, "0102", false) == 0)
				{
					result = 8;
				}
				break;
			case 3575160695u:
				if (Operators.CompareString(A_0, "0103", false) == 0)
				{
					result = 9;
				}
				break;
			case 3524827838u:
				if (Operators.CompareString(A_0, "0104", false) == 0)
				{
					result = 10;
				}
				break;
			case 1468087007u:
				if (Operators.CompareString(A_0, "0200", false) == 0)
				{
					result = 11;
				}
				break;
			case 1451309388u:
				if (Operators.CompareString(A_0, "0201", false) == 0)
				{
					result = 12;
				}
				break;
			case 1501642245u:
				if (Operators.CompareString(A_0, "0202", false) == 0)
				{
					result = 13;
				}
				break;
			case 1484864626u:
				if (Operators.CompareString(A_0, "0203", false) == 0)
				{
					result = 14;
				}
				break;
			case 1400976531u:
				if (Operators.CompareString(A_0, "0204", false) == 0)
				{
					result = 15;
				}
				break;
			case 4176086804u:
				if (Operators.CompareString(A_0, "0300", false) == 0)
				{
					result = 16;
				}
				break;
			case 4192864423u:
				if (Operators.CompareString(A_0, "0301", false) == 0)
				{
					result = 17;
				}
				break;
			case 4209642042u:
				if (Operators.CompareString(A_0, "0302", false) == 0)
				{
					result = 18;
				}
				break;
			case 4226419661u:
				if (Operators.CompareString(A_0, "0303", false) == 0)
				{
					result = 19;
				}
				break;
			case 4108976328u:
				if (Operators.CompareString(A_0, "0304", false) == 0)
				{
					result = 20;
				}
				break;
			}
			return result;
		}

		public void Running()
		{
			checked
			{
				while (true)
				{
					Thread.Sleep(1000);
					try
					{
						if (REMOTE_DIS & !_Proxy)
						{
							Delay_REMOTE_DIS++;
							if (Delay_REMOTE_DIS >= 600)
							{
								REMOTE_DIS = false;
								_Connect();
							}
						}
						try
						{
							if (Rtbsystem.Count > 100)
							{
								foreach (int key in Rtbsystem.Keys)
								{
									Rtbsystem.Remove(key);
								}
							}
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							ProjectData.ClearProjectError();
						}
						try
						{
							if (Rtbchat.Count > 100)
							{
								foreach (int key2 in Rtbchat.Keys)
								{
									Rtbchat.Remove(key2);
								}
							}
						}
						catch (Exception ex3)
						{
							ProjectData.SetProjectError(ex3);
							Exception ex4 = ex3;
							ProjectData.ClearProjectError();
						}
						try
						{
							if (RtbQuest.Count > 100)
							{
								foreach (int key3 in RtbQuest.Keys)
								{
									RtbQuest.Remove(key3);
								}
							}
						}
						catch (Exception ex5)
						{
							ProjectData.SetProjectError(ex5);
							Exception ex6 = ex5;
							ProjectData.ClearProjectError();
						}
						if ((logined == 0) & !_Proxy)
						{
							_checkconnect++;
							if (ComboBox_Port == 0)
							{
								if (_checkconnect >= 20)
								{
									_checkconnect = 0;
									try
									{
										if (clientSocket.GetStream().CanRead)
										{
											API.AddColorText2(this, Rtbsystem, "Ngắt kết nối vì sau 20 giây không đăng nhập thành công!", Color.Red);
											_Disconnect();
										}
									}
									catch (Exception ex7)
									{
										ProjectData.SetProjectError(ex7);
										Exception ex8 = ex7;
										ProjectData.ClearProjectError();
									}
									if (C_CheckBox_Reconnect)
									{
										_Connect();
									}
								}
							}
							else if (_checkconnect >= 5)
							{
								_checkconnect = 0;
								try
								{
									if (clientSocket.GetStream().CanRead)
									{
										API.AddColorText2(this, Rtbsystem, "Ngắt kết nối vì sau 5 giây không đăng nhập thành công!", Color.Red);
										_Disconnect();
									}
								}
								catch (Exception ex9)
								{
									ProjectData.SetProjectError(ex9);
									Exception ex10 = ex9;
									ProjectData.ClearProjectError();
								}
								if (C_CheckBox_Reconnect)
								{
									_Connect();
								}
							}
						}
						if (logined != 1)
						{
							continue;
						}
						if ((_MiniRuning == 0) & C_CheckBox_OpenMachine)
						{
							OpenMachineBox();
						}
						if (bott == 1)
						{
							StatusBarPanel_checkbot = ((int)(time_online - this.m_v)).ToString();
							if (time_online - this.m_v >= 10)
							{
								if (Party_CheckFull())
								{
									StatusBarPanel_botreset++;
									if (Operators.CompareString(API.ServerIp, "159.196.70.237", false) == 0)
									{
										SendPacket(API.hexstringtobyte("F444040014890000"));
									}
									ClickNPCId(99);
									StartBot();
								}
								this.m_v = (int)time_online;
							}
						}
						else if (C_CheckBox_AutoClickNPC && ((Data_Player._MapX != _MapX_Monster) | (Data_Player._MapY != _MapY_Monster)) && ((_MapX_Monster > 0) & (_MapY_Monster > 0)) && ((TextBox_ClickMOD.Length > 0) & !AutoClearGhost & (atw == 0)))
						{
							if (Data_Player._PartyFull | (Data_Player._LeaderId == 0))
							{
							}
							Walk(_MapX_Monster, _MapY_Monster);
						}
						if (C_CheckBox_DisExp && time_online - _checkdisExp >= 30)
						{
							_checkdisExp = (int)time_online;
							if (C_CheckBox_Reconnect)
							{
								API.AddColorText2(this, Rtbsystem, "Ngắt kết nối vì sau 30 giây không có kinh nghiệm!", Color.Red);
								_Disconnect();
								_Connect();
							}
						}
						if (C_CheckBox_DCFullHomdo && time_online - _checkdisFullHomdo >= 300)
						{
							_checkdisFullHomdo = (int)time_online;
							DC_FullHomdo();
						}
						if (_time_AutoSendBDY >= 30)
						{
							_time_AutoSendBDY = 0;
							AutoSendItem();
						}
						if (_stt_send > 0)
						{
							ProgressBarEx_BDY++;
							if (ProgressBarEx_BDY == 31 && _stt_send > 0)
							{
								_stt_send = 0;
							}
						}
						else if (ProgressBarEx_BDY != 1)
						{
							ProgressBarEx_BDY = 0;
						}
						if (_time_AutoSell >= 30 && C_CheckBox_autosell)
						{
							_time_AutoSell = 0;
							if (Data_Player._MapId == 12223)
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
						if (C_RadioButton_MemberRequestParty)
						{
							if ((Data_Player._LeaderId == Data_Player._Id) | (Data_Player._LeaderId == 0))
							{
								int textBox_IdLeader = TextBox_IdLeader;
								if (textBox_IdLeader > 0)
								{
									MemRequestPartyto(textBox_IdLeader);
								}
							}
						}
						else if (C_RadioButton_LeaderRequestParty)
						{
							if ((_IDmem1 == 0) & (TextBox_IDmem1 > 0))
							{
								int textBox_IDmem = TextBox_IDmem1;
								LeaderInvitePartyto(textBox_IDmem);
							}
							if ((_IDmem2 == 0) & (TextBox_IDmem2 > 0))
							{
								int textBox_IDmem2 = TextBox_IDmem2;
								LeaderInvitePartyto(textBox_IDmem2);
							}
							if ((_IDmem3 == 0) & (TextBox_IDmem3 > 0))
							{
								int textBox_IDmem3 = TextBox_IDmem3;
								LeaderInvitePartyto(textBox_IDmem3);
							}
							if ((_IDmem4 == 0) & (TextBox_IDmem4 > 0))
							{
								int textBox_IDmem4 = TextBox_IDmem4;
								LeaderInvitePartyto(textBox_IDmem4);
							}
						}
						if (bott == 0 && C_CheckBox_Bee)
						{
							if ((_Bee_X == 0) & (_Bee_Y == 0))
							{
								_Bee_X = Data_Player._MapX;
								_Bee_Y = Data_Player._MapY;
							}
							else if ((_Bee_X == Data_Player._MapX) & (_Bee_Y == Data_Player._MapY))
							{
								int num = _Bee_X + 60;
								int num2 = _Bee_Y - 60;
								Walk(num, num2);
							}
							else if ((Data_Player._MapX == _Bee_X + 60) & (Data_Player._MapY == _Bee_Y - 60))
							{
								int num3 = _Bee_X + 60;
								int num4 = _Bee_Y + 60;
								Walk(num3, num4);
							}
							else if ((Data_Player._MapX == _Bee_X + 60) & (Data_Player._MapY == _Bee_Y + 60))
							{
								int num5 = _Bee_X - 60;
								int num6 = _Bee_Y - 60;
								Walk(num5, num6);
							}
							else if ((Data_Player._MapX == _Bee_X - 60) & (Data_Player._MapY == _Bee_Y - 60))
							{
								int num7 = _Bee_X - 60;
								int num8 = _Bee_Y + 60;
								Walk(num7, num8);
							}
							else if ((Data_Player._MapX == _Bee_X - 60) & (Data_Player._MapY == _Bee_Y + 60))
							{
								int num9 = _Bee_X + 60;
								int num10 = _Bee_Y - 60;
								Walk(num9, num10);
							}
						}
						if (C_CheckBox_AutoPickup & !AutoClearGhost)
						{
							string text = "F444040017020100";
							int numericUpDown_ItemCountPickup = NumericUpDown_ItemCountPickup;
							for (int i = 2; i <= numericUpDown_ItemCountPickup; i++)
							{
								text = text + "F44404001702" + API.Int32ToHex2(i);
							}
							byte[] packet = API.hexstringtobyte(text);
							SendPacket(packet);
						}
						if (!C_CheckBox_DCAfter1MinNoBattle)
						{
							continue;
						}
						DelayDisconnectNoBattle++;
						if (DelayDisconnectNoBattle >= 60)
						{
							DelayDisconnectNoBattle = 0;
							API.AddColorText2(this, Rtbsystem, "Ngắt kết nối vì sau 1 phút không đánh!", Color.Red);
							_Disconnect();
							if (C_CheckBox_Reconnect)
							{
								_Connect();
							}
						}
					}
					catch (Exception ex11)
					{
						ProjectData.SetProjectError(ex11);
						Exception ex12 = ex11;
						ProjectData.ClearProjectError();
					}
				}
			}
		}

		public void AutoWalkToMonster()
		{
			while (true)
			{
				Thread.Sleep(1000);
				try
				{
					if (!((logined == 1) & (bott == 0)) || !C_CheckBox_AutoClickNPC || !((TextBox_ClickMOD.Length > 0) & !AutoClearGhost & (atw == 0)) || !(Data_Player._PartyFull | (Data_Player._LeaderId == 0)))
					{
						continue;
					}
					string[] array = TextBox_ClickMOD.Split(';');
					if (array.Length <= 0)
					{
						continue;
					}
					string[] array2 = array;
					foreach (string value in array2)
					{
						int key = Conversions.ToInteger(value);
						if (Data_NpcInMap.ContainsKey(key))
						{
							_Data._NpcInMap npcInMap = Data_NpcInMap[key];
							_MapX_Monster = npcInMap._MapX;
							_MapY_Monster = npcInMap._MapY;
							Thread.Sleep(checked(TextBox_ClickMOD_delay * 1000));
						}
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

		public void SaveConfig(string _path, string _name = "Setting")
		{
			IniFile.WriteString(_path, _name, "C_CheckBox_Reconnect", C_CheckBox_Reconnect.ToString());
			IniFile.WriteString(_path, _name, "C_CheckBox_QuestProtect", C_CheckBox_QuestProtect.ToString());
			IniFile.WriteString(_path, _name, "C_CheckBox_autosell", C_CheckBox_autosell.ToString());
			IniFile.WriteString(_path, _name, "C_CheckBox_TuLenNgua", C_CheckBox_TuLenNgua.ToString());
			IniFile.WriteString(_path, _name, "C_CheckBox_Bee", C_CheckBox_Bee.ToString());
			IniFile.WriteString(_path, _name, "C_CheckBox_AutoRevival", C_CheckBox_AutoRevival.ToString());
			IniFile.WriteString(_path, _name, "C_CheckBox_LeaderDissNotEnough", C_CheckBox_LeaderDissNotEnough.ToString());
			IniFile.WriteString(_path, _name, "C_CheckBox_Char_ChangeTG", C_CheckBox_Char_ChangeTG.ToString());
			IniFile.WriteString(_path, _name, "C_CheckBox_AutoFlee_Sp", C_CheckBox_AutoFlee_Sp.ToString());
			IniFile.WriteString(_path, _name, "C_CheckBox_AutoFlee_Party", C_CheckBox_AutoFlee_Party.ToString());
			IniFile.WriteString(_path, _name, "C_CheckBox_Pet_ChangeTG", C_CheckBox_Pet_ChangeTG.ToString());
			IniFile.WriteString(_path, _name, "C_CheckBox_AutoClickNPC", C_CheckBox_AutoClickNPC.ToString());
			IniFile.WriteString(_path, _name, "C_CheckBox_AutoPickup", C_CheckBox_AutoPickup.ToString());
			IniFile.WriteString(_path, _name, "C_CheckBox_DropHp", C_CheckBox_DropHp.ToString());
			IniFile.WriteString(_path, _name, "C_CheckBox_DropSp", C_CheckBox_DropSp.ToString());
			IniFile.WriteString(_path, _name, "C_CheckBox_DropHpSp", C_CheckBox_DropHpSp.ToString());
			IniFile.WriteString(_path, _name, "C_CheckBox_DropMineWood", C_CheckBox_DropMineWood.ToString());
			IniFile.WriteString(_path, _name, "C_CheckBox_ContributeHp", C_CheckBox_ContributeHp.ToString());
			IniFile.WriteString(_path, _name, "C_CheckBox_ContributeSp", C_CheckBox_ContributeSp.ToString());
			IniFile.WriteString(_path, _name, "C_CheckBox_ContributeHpSp", C_CheckBox_ContributeHpSp.ToString());
			IniFile.WriteString(_path, _name, "C_CheckBox_ContributeMineWood", C_CheckBox_ContributeMineWood.ToString());
			IniFile.WriteString(_path, _name, "C_CheckBox_SendHp", C_CheckBox_SendHp.ToString());
			IniFile.WriteString(_path, _name, "C_CheckBox_SendSp", C_CheckBox_SendSp.ToString());
			IniFile.WriteString(_path, _name, "C_CheckBox_SendHpSp", C_CheckBox_SendHpSp.ToString());
			IniFile.WriteString(_path, _name, "C_CheckBox_SendMineWood", C_CheckBox_SendMineWood.ToString());
			IniFile.WriteString(_path, _name, "C_CheckBox_SellHp", C_CheckBox_SellHp.ToString());
			IniFile.WriteString(_path, _name, "C_CheckBox_SellSP", C_CheckBox_SellSP.ToString());
			IniFile.WriteString(_path, _name, "C_CheckBox_SellHpSp", C_CheckBox_SellHpSp.ToString());
			IniFile.WriteString(_path, _name, "C_CheckBox_SellMineWood", C_CheckBox_SellMineWood.ToString());
			IniFile.WriteString(_path, _name, "C_CheckBox_Pickup", C_CheckBox_Pickup.ToString());
			IniFile.WriteString(_path, _name, "C_RadioButton_QS1", C_RadioButton_QS1.ToString());
			IniFile.WriteString(_path, _name, "C_RadioButton_QS2", C_RadioButton_QS2.ToString());
			IniFile.WriteString(_path, _name, "C_RadioButton_QS3", C_RadioButton_QS3.ToString());
			IniFile.WriteString(_path, _name, "C_RadioButton_QS4", C_RadioButton_QS4.ToString());
			IniFile.WriteString(_path, _name, "C_CheckBox_AutoEquitExp", C_CheckBox_AutoEquitExp.ToString());
			IniFile.WriteString(_path, _name, "C_CheckBox_AutoUsePT", C_CheckBox_AutoUsePT.ToString());
			IniFile.WriteString(_path, _name, "C_CheckBox_CatPet", C_CheckBox_CatPet.ToString());
			IniFile.WriteString(_path, _name, "C_CheckBox_ClearGhost", C_CheckBox_ClearGhost.ToString());
			IniFile.WriteString(_path, _name, "C_RadioButton_LeaderRequestParty", C_RadioButton_LeaderRequestParty.ToString());
			IniFile.WriteString(_path, _name, "C_RadioButton_MemberRequestParty", C_RadioButton_MemberRequestParty.ToString());
			IniFile.WriteString(_path, _name, "C_RadioButton_PT_no", C_RadioButton_PT_no.ToString());
			IniFile.WriteString(_path, _name, "C_CheckBox_DCAfter1MinNoBattle", C_CheckBox_DCAfter1MinNoBattle.ToString());
			IniFile.WriteString(_path, _name, "C_CheckBox_DisExp", C_CheckBox_DisExp.ToString());
			IniFile.WriteString(_path, _name, "C_RadioButton_DCLeaderOut", C_RadioButton_DCLeaderOut.ToString());
			IniFile.WriteString(_path, _name, "C_RadioButton_DCmemout", C_RadioButton_DCmemout.ToString());
			IniFile.WriteString(_path, _name, "C_RadioButton_DC_no", C_RadioButton_DC_no.ToString());
			IniFile.WriteString(_path, _name, "C_CheckBox_AutoEat", C_CheckBox_AutoEat.ToString());
			IniFile.WriteString(_path, _name, "C_CheckBox_TL_mem1", C_CheckBox_TL_mem1.ToString());
			IniFile.WriteString(_path, _name, "C_CheckBox_TL_mem2", C_CheckBox_TL_mem2.ToString());
			IniFile.WriteString(_path, _name, "C_CheckBox_TL_mem3", C_CheckBox_TL_mem3.ToString());
			IniFile.WriteString(_path, _name, "C_CheckBox_TL_mem4", C_CheckBox_TL_mem4.ToString());
			IniFile.WriteString(_path, _name, "C_CheckBox_TL_pet1", C_CheckBox_TL_pet1.ToString());
			IniFile.WriteString(_path, _name, "C_CheckBox_TL_pet2", C_CheckBox_TL_pet2.ToString());
			IniFile.WriteString(_path, _name, "C_CheckBox_AutoCreatCharacter", C_CheckBox_AutoCreatCharacter.ToString());
			IniFile.WriteString(_path, _name, "C_CheckBox_OpenMachine", C_CheckBox_OpenMachine.ToString());
			IniFile.WriteString(_path, _name, "C_RadioButton_dia", C_RadioButton_dia.ToString());
			IniFile.WriteString(_path, _name, "C_RadioButton_thuy", C_RadioButton_thuy.ToString());
			IniFile.WriteString(_path, _name, "C_RadioButton_hoa", C_RadioButton_hoa.ToString());
			IniFile.WriteString(_path, _name, "C_RadioButton_phong", C_RadioButton_phong.ToString());
			IniFile.WriteString(_path, _name, "C_CheckBox_Autosort", C_CheckBox_Autosort.ToString());
			IniFile.WriteString(_path, _name, "C_CheckBox_DCFullHomDo", C_CheckBox_DCFullHomdo.ToString());
			IniFile.WriteString(_path, _name, "Char_TurnCount", Data_CharAttackSetting._TurnCount.ToString());
			IniFile.WriteString(_path, _name, "Char_Skill1", Data_CharAttackSetting._Skill1.ToString());
			IniFile.WriteString(_path, _name, "Char_Skill2", Data_CharAttackSetting._Skill2.ToString());
			IniFile.WriteString(_path, _name, "Char_Skill3", Data_CharAttackSetting._Skill3.ToString());
			IniFile.WriteString(_path, _name, "Char_Skill4", Data_CharAttackSetting._Skill4.ToString());
			IniFile.WriteString(_path, _name, "Char_Skill5", Data_CharAttackSetting._Skill5.ToString());
			IniFile.WriteString(_path, _name, "Char_Skill6", Data_CharAttackSetting._Skill6.ToString());
			IniFile.WriteString(_path, _name, "Char_Skill7", Data_CharAttackSetting._Skill7.ToString());
			IniFile.WriteString(_path, _name, "Char_Skill8", Data_CharAttackSetting._Skill8.ToString());
			IniFile.WriteString(_path, _name, "Char_Skill9", Data_CharAttackSetting._Skill9.ToString());
			IniFile.WriteString(_path, _name, "Char_Skill10", Data_CharAttackSetting._Skill10.ToString());
			IniFile.WriteString(_path, _name, "Char_Location1", Data_CharAttackSetting._Location1.ToString());
			IniFile.WriteString(_path, _name, "Char_Location2", Data_CharAttackSetting._Location2.ToString());
			IniFile.WriteString(_path, _name, "Char_Location3", Data_CharAttackSetting._Location3.ToString());
			IniFile.WriteString(_path, _name, "Char_Location4", Data_CharAttackSetting._Location4.ToString());
			IniFile.WriteString(_path, _name, "Char_Location5", Data_CharAttackSetting._Location5.ToString());
			IniFile.WriteString(_path, _name, "Char_Location6", Data_CharAttackSetting._Location6.ToString());
			IniFile.WriteString(_path, _name, "Char_Location7", Data_CharAttackSetting._Location7.ToString());
			IniFile.WriteString(_path, _name, "Char_Location8", Data_CharAttackSetting._Location8.ToString());
			IniFile.WriteString(_path, _name, "Char_Location9", Data_CharAttackSetting._Location9.ToString());
			IniFile.WriteString(_path, _name, "Char_Location10", Data_CharAttackSetting._Location10.ToString());
			IniFile.WriteString(_path, _name, "Pet_TurnCount", Data_PetAttackSetting._TurnCount.ToString());
			IniFile.WriteString(_path, _name, "Pet_Skill1", Data_PetAttackSetting._Skill1.ToString());
			IniFile.WriteString(_path, _name, "Pet_Skill2", Data_PetAttackSetting._Skill2.ToString());
			IniFile.WriteString(_path, _name, "Pet_Skill3", Data_PetAttackSetting._Skill3.ToString());
			IniFile.WriteString(_path, _name, "Pet_Skill4", Data_PetAttackSetting._Skill4.ToString());
			IniFile.WriteString(_path, _name, "Pet_Skill5", Data_PetAttackSetting._Skill5.ToString());
			IniFile.WriteString(_path, _name, "Pet_Skill6", Data_PetAttackSetting._Skill6.ToString());
			IniFile.WriteString(_path, _name, "Pet_Skill7", Data_PetAttackSetting._Skill7.ToString());
			IniFile.WriteString(_path, _name, "Pet_Skill8", Data_PetAttackSetting._Skill8.ToString());
			IniFile.WriteString(_path, _name, "Pet_Skill9", Data_PetAttackSetting._Skill9.ToString());
			IniFile.WriteString(_path, _name, "Pet_Skill10", Data_PetAttackSetting._Skill10.ToString());
			IniFile.WriteString(_path, _name, "Pet_Location1", Data_PetAttackSetting._Location1.ToString());
			IniFile.WriteString(_path, _name, "Pet_Location2", Data_PetAttackSetting._Location2.ToString());
			IniFile.WriteString(_path, _name, "Pet_Location3", Data_PetAttackSetting._Location3.ToString());
			IniFile.WriteString(_path, _name, "Pet_Location4", Data_PetAttackSetting._Location4.ToString());
			IniFile.WriteString(_path, _name, "Pet_Location5", Data_PetAttackSetting._Location5.ToString());
			IniFile.WriteString(_path, _name, "Pet_Location6", Data_PetAttackSetting._Location6.ToString());
			IniFile.WriteString(_path, _name, "Pet_Location7", Data_PetAttackSetting._Location7.ToString());
			IniFile.WriteString(_path, _name, "Pet_Location8", Data_PetAttackSetting._Location8.ToString());
			IniFile.WriteString(_path, _name, "Pet_Location9", Data_PetAttackSetting._Location9.ToString());
			IniFile.WriteString(_path, _name, "Pet_Location10", Data_PetAttackSetting._Location10.ToString());
			IniFile.WriteString(_path, _name, "idlogin", idlogin.ToString());
			IniFile.WriteString(_path, _name, "passlogin", passlogin.ToString());
			IniFile.WriteString(_path, _name, "ToolStripTextBox_KenhPassword", ToolStripTextBox_KenhPassword.ToString());
			IniFile.WriteString(_path, _name, "ComboBox_Server", ComboBox_Server.ToString());
			IniFile.WriteString(_path, _name, "ComboBox_Port", ComboBox_Port.ToString());
			IniFile.WriteString(_path, _name, "TextBox_RemoteDis", TextBox_RemoteDis.ToString());
			IniFile.WriteString(_path, _name, " ComboBox_namePublic", ComboBox_namePublic.ToString());
			IniFile.WriteString(_path, _name, "TextBox_DelayBot", TextBox_DelayBot.ToString());
			IniFile.WriteString(_path, _name, "TextBox_IDmem1", TextBox_IDmem1.ToString());
			IniFile.WriteString(_path, _name, "TextBox_IDmem2", TextBox_IDmem2.ToString());
			IniFile.WriteString(_path, _name, "TextBox_IDmem3", TextBox_IDmem3.ToString());
			IniFile.WriteString(_path, _name, "TextBox_IDmem4", TextBox_IDmem4.ToString());
			IniFile.WriteString(_path, _name, "TextBox_IdLeader", TextBox_IdLeader.ToString());
			IniFile.WriteString(_path, _name, "TextBox_AutoSend", TextBox_AutoSend.ToString());
			IniFile.WriteString(_path, _name, "ProgressBarEx_BDY", ProgressBarEx_BDY.ToString());
			IniFile.WriteString(_path, _name, "TextBox_TL_pet_hp_value", TextBox_TL_pet_hp_value.ToString());
			IniFile.WriteString(_path, _name, "TextBox_TL_pet_sp_value", TextBox_TL_pet_sp_value.ToString());
			IniFile.WriteString(_path, _name, "TextBox_Eat_char_hp_value", TextBox_Eat_char_hp_value.ToString());
			IniFile.WriteString(_path, _name, "TextBox_Eat_char_sp_value", TextBox_Eat_char_sp_value.ToString());
			IniFile.WriteString(_path, _name, "TextBox_Eat_Pet_hp_value", TextBox_Eat_Pet_hp_value.ToString());
			IniFile.WriteString(_path, _name, "TextBox_Eat_Pet_sp_value", TextBox_Eat_Pet_sp_value.ToString());
			IniFile.WriteString(_path, _name, "TextBox_Drop_HpValue", TextBox_Drop_HpValue.ToString());
			IniFile.WriteString(_path, _name, "TextBox_Drop_spValue", TextBox_Drop_SpValue.ToString());
			IniFile.WriteString(_path, _name, "TextBox_Contribute_HpValue", TextBox_Contribute_HpValue.ToString());
			IniFile.WriteString(_path, _name, "TextBox_Contribute_spValue", TextBox_Contribute_SpValue.ToString());
			IniFile.WriteString(_path, _name, "TextBox_Send_HpValue", TextBox_Send_HpValue.ToString());
			IniFile.WriteString(_path, _name, "TextBox_Send_spValue", TextBox_Send_SpValue.ToString());
			IniFile.WriteString(_path, _name, "TextBox_Sell_HpValue", TextBox_Sell_HpValue.ToString());
			IniFile.WriteString(_path, _name, "TextBox_Sell_spValue", TextBox_Sell_SpValue.ToString());
			IniFile.WriteString(_path, _name, "TextBox_OpenMachine_CharHp", TextBox_OpenMachine_CharHp.ToString());
			IniFile.WriteString(_path, _name, "TextBox_OpenMachine_CharSp", TextBox_OpenMachine_CharSp.ToString());
			IniFile.WriteString(_path, _name, "TextBox_OpenMachine_PetHp", TextBox_OpenMachine_PetHp.ToString());
			IniFile.WriteString(_path, _name, "TextBox_OpenMachine_PetSp", TextBox_OpenMachine_PetSp.ToString());
			IniFile.WriteString(_path, _name, "NumericUpDown_ItemCountPickup", NumericUpDown_ItemCountPickup.ToString());
			IniFile.WriteString(_path, _name, "TextBox_ValueSPFlee", TextBox_ValueSPFlee.ToString());
			IniFile.WriteString(_path, _name, "TextBox_ClickMOD", TextBox_ClickMOD.ToString());
			IniFile.WriteString(_path, _name, "TextBox_ClickMOD_delay", TextBox_ClickMOD_delay.ToString());
			IniFile.WriteString(_path, _name, "packetbot", packetbot.ToString());
			IniFile.WriteString(_path, _name, "idmapbot", idmapbot.ToString());
			IniFile.WriteString(_path, _name, "bott", bott.ToString());
			checked
			{
				try
				{
					string text = "";
					if (Data_ListDrop.Count > 0)
					{
						int num = Data_ListDrop.Count - 1;
						for (int i = 0; i <= num; i++)
						{
							text = ((text.Length != 0) ? Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(",", Data_ListDrop[i]))) : Conversions.ToString(Operators.ConcatenateObject(text, Data_ListDrop[i])));
						}
					}
					IniFile.WriteString(_path, _name, "Data_ListDrop", text);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					Interaction.MsgBox("Lỗi lưu danh sách đồ tự động vứt bỏ");
					ProjectData.ClearProjectError();
				}
				try
				{
					string text2 = "";
					if (Data_ListContribute.Count > 0)
					{
						int num2 = Data_ListContribute.Count - 1;
						for (int j = 0; j <= num2; j++)
						{
							text2 = ((text2.Length != 0) ? Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(",", Data_ListContribute[j]))) : Conversions.ToString(Operators.ConcatenateObject(text2, Data_ListContribute[j])));
						}
					}
					IniFile.WriteString(_path, _name, "Data_ListContribute", text2);
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					Interaction.MsgBox("Lỗi lưu danh sách đồ tự động đóng góp");
					ProjectData.ClearProjectError();
				}
				try
				{
					string text3 = "";
					if (Data_ListSend.Count > 0)
					{
						int num3 = Data_ListSend.Count - 1;
						for (int k = 0; k <= num3; k++)
						{
							text3 = ((text3.Length != 0) ? Conversions.ToString(Operators.ConcatenateObject(text3, Operators.ConcatenateObject(",", Data_ListSend[k]))) : Conversions.ToString(Operators.ConcatenateObject(text3, Data_ListSend[k])));
						}
					}
					IniFile.WriteString(_path, _name, "Data_ListSend", text3);
				}
				catch (Exception ex5)
				{
					ProjectData.SetProjectError(ex5);
					Exception ex6 = ex5;
					Interaction.MsgBox("Lỗi lưu danh sách đồ tự động gửi");
					ProjectData.ClearProjectError();
				}
				try
				{
					string text4 = "";
					if (Data_ListSell.Count > 0)
					{
						int num4 = Data_ListSell.Count - 1;
						for (int l = 0; l <= num4; l++)
						{
							text4 = ((text4.Length != 0) ? Conversions.ToString(Operators.ConcatenateObject(text4, Operators.ConcatenateObject(",", Data_ListSell[l]))) : Conversions.ToString(Operators.ConcatenateObject(text4, Data_ListSell[l])));
						}
					}
					IniFile.WriteString(_path, _name, "Data_ListSell", text4);
				}
				catch (Exception ex7)
				{
					ProjectData.SetProjectError(ex7);
					Exception ex8 = ex7;
					Interaction.MsgBox("Lỗi lưu danh sách đồ tự động bán");
					ProjectData.ClearProjectError();
				}
			}
		}

		public void LoadConfig_Thread(API._Type_LoadConfig _type)
		{
			LoadConfig(_type._path, _type._name);
		}

		public void LoadConfig(string _path, string _name = "Setting")
		{
			C_CheckBox_Reconnect = IniFile.ReadBool(_path, _name, "C_CheckBox_Reconnect", "");
			C_CheckBox_QuestProtect = IniFile.ReadBool(_path, _name, "C_CheckBox_QuestProtect", "");
			C_CheckBox_autosell = IniFile.ReadBool(_path, _name, "C_CheckBox_autosell", "");
			C_CheckBox_TuLenNgua = IniFile.ReadBool(_path, _name, "C_CheckBox_TuLenNgua", "");
			C_CheckBox_Bee = IniFile.ReadBool(_path, _name, "C_CheckBox_Bee", "");
			C_CheckBox_AutoRevival = IniFile.ReadBool(_path, _name, "C_CheckBox_AutoRevival", "");
			C_CheckBox_LeaderDissNotEnough = IniFile.ReadBool(_path, _name, "C_CheckBox_LeaderDissNotEnough", "");
			C_CheckBox_Char_ChangeTG = IniFile.ReadBool(_path, _name, "C_CheckBox_Char_ChangeTG", "");
			C_CheckBox_AutoFlee_Sp = IniFile.ReadBool(_path, _name, "C_CheckBox_AutoFlee_Sp", "");
			C_CheckBox_AutoFlee_Party = IniFile.ReadBool(_path, _name, "C_CheckBox_AutoFlee_Party", "");
			C_CheckBox_Pet_ChangeTG = IniFile.ReadBool(_path, _name, "C_CheckBox_Pet_ChangeTG", "");
			C_CheckBox_AutoClickNPC = IniFile.ReadBool(_path, _name, "C_CheckBox_AutoClickNPC", "");
			C_CheckBox_AutoPickup = IniFile.ReadBool(_path, _name, "C_CheckBox_AutoPickup", "");
			C_CheckBox_DropHp = IniFile.ReadBool(_path, _name, "C_CheckBox_DropHp", "");
			C_CheckBox_DropSp = IniFile.ReadBool(_path, _name, "C_CheckBox_DropSp", "");
			C_CheckBox_DropHpSp = IniFile.ReadBool(_path, _name, "C_CheckBox_DropHpSp", "");
			C_CheckBox_DropMineWood = IniFile.ReadBool(_path, _name, "C_CheckBox_DropMineWood", "");
			C_CheckBox_ContributeHp = IniFile.ReadBool(_path, _name, "C_CheckBox_ContributeHp", "");
			C_CheckBox_ContributeSp = IniFile.ReadBool(_path, _name, "C_CheckBox_ContributeSp", "");
			C_CheckBox_ContributeHpSp = IniFile.ReadBool(_path, _name, "C_CheckBox_ContributeHpSp", "");
			C_CheckBox_ContributeMineWood = IniFile.ReadBool(_path, _name, "C_CheckBox_ContributeMineWood", "");
			C_CheckBox_SendHp = IniFile.ReadBool(_path, _name, "C_CheckBox_SendHp", "");
			C_CheckBox_SendSp = IniFile.ReadBool(_path, _name, "C_CheckBox_SendSp", "");
			C_CheckBox_SendHpSp = IniFile.ReadBool(_path, _name, "C_CheckBox_SendHpSp", "");
			C_CheckBox_SendMineWood = IniFile.ReadBool(_path, _name, "C_CheckBox_SendMineWood", "");
			C_CheckBox_SellHp = IniFile.ReadBool(_path, _name, "C_CheckBox_SellHp", "");
			C_CheckBox_SellSP = IniFile.ReadBool(_path, _name, "C_CheckBox_SellSP", "");
			C_CheckBox_SellHpSp = IniFile.ReadBool(_path, _name, "C_CheckBox_SellHpSp", "");
			C_CheckBox_SellMineWood = IniFile.ReadBool(_path, _name, "C_CheckBox_SellMineWood", "");
			C_CheckBox_Pickup = IniFile.ReadBool(_path, _name, "C_CheckBox_Pickup", "");
			C_RadioButton_QS1 = IniFile.ReadBool(_path, _name, "C_RadioButton_QS1", "");
			C_RadioButton_QS2 = IniFile.ReadBool(_path, _name, "C_RadioButton_QS2", "");
			C_RadioButton_QS3 = IniFile.ReadBool(_path, _name, "C_RadioButton_QS3", "");
			C_RadioButton_QS4 = IniFile.ReadBool(_path, _name, "C_RadioButton_QS4", "");
			C_CheckBox_AutoEquitExp = IniFile.ReadBool(_path, _name, "C_CheckBox_AutoEquitExp", "");
			C_CheckBox_AutoUsePT = IniFile.ReadBool(_path, _name, "C_CheckBox_AutoUsePT", "");
			C_CheckBox_CatPet = IniFile.ReadBool(_path, _name, "C_CheckBox_CatPet", "");
			C_CheckBox_ClearGhost = IniFile.ReadBool(_path, _name, "C_CheckBox_ClearGhost", "");
			C_RadioButton_LeaderRequestParty = IniFile.ReadBool(_path, _name, "C_RadioButton_LeaderRequestParty", "");
			C_RadioButton_MemberRequestParty = IniFile.ReadBool(_path, _name, "C_RadioButton_MemberRequestParty", "");
			C_RadioButton_PT_no = IniFile.ReadBool(_path, _name, "C_RadioButton_PT_no", "");
			C_CheckBox_DCAfter1MinNoBattle = IniFile.ReadBool(_path, _name, "C_CheckBox_DCAfter1MinNoBattle", "");
			C_CheckBox_DisExp = IniFile.ReadBool(_path, _name, "C_CheckBox_DisExp", "");
			C_RadioButton_DCLeaderOut = IniFile.ReadBool(_path, _name, "C_RadioButton_DCLeaderOut", "");
			C_RadioButton_DCmemout = IniFile.ReadBool(_path, _name, "C_RadioButton_DCmemout", "");
			C_RadioButton_DC_no = IniFile.ReadBool(_path, _name, "C_RadioButton_DC_no", "");
			C_CheckBox_AutoEat = IniFile.ReadBool(_path, _name, "C_CheckBox_AutoEat", "");
			C_CheckBox_TL_mem1 = IniFile.ReadBool(_path, _name, "C_CheckBox_TL_mem1", "");
			C_CheckBox_TL_mem2 = IniFile.ReadBool(_path, _name, "C_CheckBox_TL_mem2", "");
			C_CheckBox_TL_mem3 = IniFile.ReadBool(_path, _name, "C_CheckBox_TL_mem3", "");
			C_CheckBox_TL_mem4 = IniFile.ReadBool(_path, _name, "C_CheckBox_TL_mem4", "");
			C_CheckBox_TL_pet1 = IniFile.ReadBool(_path, _name, "C_CheckBox_TL_pet1", "");
			C_CheckBox_TL_pet2 = IniFile.ReadBool(_path, _name, "C_CheckBox_TL_pet2", "");
			C_CheckBox_AutoCreatCharacter = IniFile.ReadBool(_path, _name, "C_CheckBox_AutoCreatCharacter", "");
			C_CheckBox_OpenMachine = IniFile.ReadBool(_path, _name, "C_CheckBox_OpenMachine", "");
			C_RadioButton_dia = IniFile.ReadBool(_path, _name, "C_RadioButton_dia", "");
			C_RadioButton_thuy = IniFile.ReadBool(_path, _name, "C_RadioButton_thuy", "");
			C_RadioButton_hoa = IniFile.ReadBool(_path, _name, "C_RadioButton_hoa", "");
			C_RadioButton_phong = IniFile.ReadBool(_path, _name, "C_RadioButton_phong", "");
			C_CheckBox_Autosort = IniFile.ReadBool(_path, _name, "C_CheckBox_Autosort", "");
			C_CheckBox_DCFullHomdo = IniFile.ReadBool(_path, _name, "C_CheckBox_DCFullHomdo", "");
			Data_CharAttackSetting._TurnCount = Conversions.ToInteger(IniFile.ReadNumberString(_path, _name, "Char_TurnCount", ""));
			Data_CharAttackSetting._Skill1 = Conversions.ToInteger(IniFile.ReadNumberString(_path, _name, "Char_Skill1", ""));
			Data_CharAttackSetting._Skill2 = Conversions.ToInteger(IniFile.ReadNumberString(_path, _name, "Char_Skill2", ""));
			Data_CharAttackSetting._Skill3 = Conversions.ToInteger(IniFile.ReadNumberString(_path, _name, "Char_Skill3", ""));
			Data_CharAttackSetting._Skill4 = Conversions.ToInteger(IniFile.ReadNumberString(_path, _name, "Char_Skill4", ""));
			Data_CharAttackSetting._Skill5 = Conversions.ToInteger(IniFile.ReadNumberString(_path, _name, "Char_Skill5", ""));
			Data_CharAttackSetting._Skill6 = Conversions.ToInteger(IniFile.ReadNumberString(_path, _name, "Char_Skill6", ""));
			Data_CharAttackSetting._Skill7 = Conversions.ToInteger(IniFile.ReadNumberString(_path, _name, "Char_Skill7", ""));
			Data_CharAttackSetting._Skill8 = Conversions.ToInteger(IniFile.ReadNumberString(_path, _name, "Char_Skill8", ""));
			Data_CharAttackSetting._Skill9 = Conversions.ToInteger(IniFile.ReadNumberString(_path, _name, "Char_Skill9", ""));
			Data_CharAttackSetting._Skill10 = Conversions.ToInteger(IniFile.ReadNumberString(_path, _name, "Char_Skill10", ""));
			Data_CharAttackSetting._Location1 = IniFile.ReadStringOrEmpty(_path, _name, "Char_Location1", "");
			Data_CharAttackSetting._Location2 = IniFile.ReadStringOrEmpty(_path, _name, "Char_Location2", "");
			Data_CharAttackSetting._Location3 = IniFile.ReadStringOrEmpty(_path, _name, "Char_Location3", "");
			Data_CharAttackSetting._Location4 = IniFile.ReadStringOrEmpty(_path, _name, "Char_Location4", "");
			Data_CharAttackSetting._Location5 = IniFile.ReadStringOrEmpty(_path, _name, "Char_Location5", "");
			Data_CharAttackSetting._Location6 = IniFile.ReadStringOrEmpty(_path, _name, "Char_Location6", "");
			Data_CharAttackSetting._Location7 = IniFile.ReadStringOrEmpty(_path, _name, "Char_Location7", "");
			Data_CharAttackSetting._Location8 = IniFile.ReadStringOrEmpty(_path, _name, "Char_Location8", "");
			Data_CharAttackSetting._Location9 = IniFile.ReadStringOrEmpty(_path, _name, "Char_Location9", "");
			Data_CharAttackSetting._Location10 = IniFile.ReadStringOrEmpty(_path, _name, "Char_Location10", "");
			Data_PetAttackSetting._TurnCount = Conversions.ToInteger(IniFile.ReadNumberString(_path, _name, "Pet_TurnCount", ""));
			Data_PetAttackSetting._Skill1 = Conversions.ToInteger(IniFile.ReadNumberString(_path, _name, "Pet_Skill1", ""));
			Data_PetAttackSetting._Skill2 = Conversions.ToInteger(IniFile.ReadNumberString(_path, _name, "Pet_Skill2", ""));
			Data_PetAttackSetting._Skill3 = Conversions.ToInteger(IniFile.ReadNumberString(_path, _name, "Pet_Skill3", ""));
			Data_PetAttackSetting._Skill4 = Conversions.ToInteger(IniFile.ReadNumberString(_path, _name, "Pet_Skill4", ""));
			Data_PetAttackSetting._Skill5 = Conversions.ToInteger(IniFile.ReadNumberString(_path, _name, "Pet_Skill5", ""));
			Data_PetAttackSetting._Skill6 = Conversions.ToInteger(IniFile.ReadNumberString(_path, _name, "Pet_Skill6", ""));
			Data_PetAttackSetting._Skill7 = Conversions.ToInteger(IniFile.ReadNumberString(_path, _name, "Pet_Skill7", ""));
			Data_PetAttackSetting._Skill8 = Conversions.ToInteger(IniFile.ReadNumberString(_path, _name, "Pet_Skill8", ""));
			Data_PetAttackSetting._Skill9 = Conversions.ToInteger(IniFile.ReadNumberString(_path, _name, "Pet_Skill9", ""));
			Data_PetAttackSetting._Skill10 = Conversions.ToInteger(IniFile.ReadNumberString(_path, _name, "Pet_Skill10", ""));
			Data_PetAttackSetting._Location1 = IniFile.ReadStringOrEmpty(_path, _name, "Pet_Location1", "");
			Data_PetAttackSetting._Location2 = IniFile.ReadStringOrEmpty(_path, _name, "Pet_Location2", "");
			Data_PetAttackSetting._Location3 = IniFile.ReadStringOrEmpty(_path, _name, "Pet_Location3", "");
			Data_PetAttackSetting._Location4 = IniFile.ReadStringOrEmpty(_path, _name, "Pet_Location4", "");
			Data_PetAttackSetting._Location5 = IniFile.ReadStringOrEmpty(_path, _name, "Pet_Location5", "");
			Data_PetAttackSetting._Location6 = IniFile.ReadStringOrEmpty(_path, _name, "Pet_Location6", "");
			Data_PetAttackSetting._Location7 = IniFile.ReadStringOrEmpty(_path, _name, "Pet_Location7", "");
			Data_PetAttackSetting._Location8 = IniFile.ReadStringOrEmpty(_path, _name, "Pet_Location8", "");
			Data_PetAttackSetting._Location9 = IniFile.ReadStringOrEmpty(_path, _name, "Pet_Location9", "");
			Data_PetAttackSetting._Location10 = IniFile.ReadStringOrEmpty(_path, _name, "Pet_Location10", "");
			idlogin = Conversions.ToInteger(IniFile.ReadNumberString(_path, _name, "idlogin", ""));
			passlogin = IniFile.ReadString(_path, _name, "passlogin", "");
			ToolStripTextBox_KenhPassword = IniFile.ReadString(_path, _name, "ToolStripTextBox_KenhPassword", "");
			ComboBox_Server = IniFile.ReadString(_path, _name, "ComboBox_Server", "");
			ComboBox_Port = Conversions.ToInteger(IniFile.ReadNumberString(_path, _name, "ComboBox_Port", ""));
			TextBox_RemoteDis = IniFile.ReadString(_path, _name, "TextBox_RemoteDis", "");
			ComboBox_namePublic = IniFile.ReadString(_path, _name, " ComboBox_namePublic", "");
			TextBox_DelayBot = Conversions.ToDouble(IniFile.ReadNumberString(_path, _name, "TextBox_DelayBot", ""));
			TextBox_IDmem1 = Conversions.ToInteger(IniFile.ReadNumberString(_path, _name, "TextBox_IDmem1", ""));
			TextBox_IDmem2 = Conversions.ToInteger(IniFile.ReadNumberString(_path, _name, "TextBox_IDmem2", ""));
			TextBox_IDmem3 = Conversions.ToInteger(IniFile.ReadNumberString(_path, _name, "TextBox_IDmem3", ""));
			TextBox_IDmem4 = Conversions.ToInteger(IniFile.ReadNumberString(_path, _name, "TextBox_IDmem4", ""));
			TextBox_IdLeader = Conversions.ToInteger(IniFile.ReadNumberString(_path, _name, "TextBox_IdLeader", ""));
			TextBox_AutoSend = Conversions.ToInteger(IniFile.ReadNumberString(_path, _name, "TextBox_AutoSend", ""));
			ProgressBarEx_BDY = Conversions.ToInteger(IniFile.ReadNumberString(_path, _name, "ProgressBarEx_BDY", ""));
			TextBox_TL_pet_hp_value = Conversions.ToInteger(IniFile.ReadNumberString(_path, _name, "TextBox_TL_pet_hp_value", ""));
			TextBox_TL_pet_sp_value = Conversions.ToInteger(IniFile.ReadNumberString(_path, _name, "TextBox_TL_pet_sp_value", ""));
			TextBox_Eat_char_hp_value = Conversions.ToInteger(IniFile.ReadNumberString(_path, _name, "TextBox_Eat_char_hp_value", ""));
			TextBox_Eat_char_sp_value = Conversions.ToInteger(IniFile.ReadNumberString(_path, _name, "TextBox_Eat_char_sp_value", ""));
			TextBox_Eat_Pet_hp_value = Conversions.ToInteger(IniFile.ReadNumberString(_path, _name, "TextBox_Eat_Pet_hp_value", ""));
			TextBox_Eat_Pet_sp_value = Conversions.ToInteger(IniFile.ReadNumberString(_path, _name, "TextBox_Eat_Pet_sp_value", ""));
			TextBox_Drop_HpValue = Conversions.ToInteger(IniFile.ReadNumberString(_path, _name, "TextBox_Drop_HpValue", ""));
			TextBox_Drop_SpValue = Conversions.ToInteger(IniFile.ReadNumberString(_path, _name, "TextBox_Drop_spValue", ""));
			TextBox_Contribute_HpValue = Conversions.ToInteger(IniFile.ReadNumberString(_path, _name, "TextBox_Contribute_HpValue", ""));
			TextBox_Contribute_SpValue = Conversions.ToInteger(IniFile.ReadNumberString(_path, _name, "TextBox_Contribute_spValue", ""));
			TextBox_Send_HpValue = Conversions.ToInteger(IniFile.ReadNumberString(_path, _name, "TextBox_Send_HpValue", ""));
			TextBox_Send_SpValue = Conversions.ToInteger(IniFile.ReadNumberString(_path, _name, "TextBox_Send_spValue", ""));
			TextBox_Sell_HpValue = Conversions.ToInteger(IniFile.ReadNumberString(_path, _name, "TextBox_Sell_HpValue", ""));
			TextBox_Sell_SpValue = Conversions.ToInteger(IniFile.ReadNumberString(_path, _name, "TextBox_Sell_spValue", ""));
			TextBox_OpenMachine_CharHp = Conversions.ToInteger(IniFile.ReadNumberString(_path, _name, "TextBox_OpenMachine_CharHp", ""));
			TextBox_OpenMachine_CharSp = Conversions.ToInteger(IniFile.ReadNumberString(_path, _name, "TextBox_OpenMachine_CharSp", ""));
			TextBox_OpenMachine_PetHp = Conversions.ToInteger(IniFile.ReadNumberString(_path, _name, "TextBox_OpenMachine_PetHp", ""));
			TextBox_OpenMachine_PetSp = Conversions.ToInteger(IniFile.ReadNumberString(_path, _name, "TextBox_OpenMachine_PetSp", ""));
			NumericUpDown_ItemCountPickup = Conversions.ToInteger(IniFile.ReadNumberString(_path, _name, "NumericUpDown_ItemCountPickup", ""));
			TextBox_ValueSPFlee = Conversions.ToInteger(IniFile.ReadNumberString(_path, _name, "TextBox_ValueSPFlee", ""));
			TextBox_ClickMOD = IniFile.ReadStringOrEmpty(_path, _name, "TextBox_ClickMOD", "");
			TextBox_ClickMOD_delay = Conversions.ToInteger(IniFile.ReadNumberString(_path, _name, "TextBox_ClickMOD_delay", ""));
			packetbot = IniFile.ReadStringOrEmpty(_path, _name, "packetbot", "");
			idmapbot = Conversions.ToInteger(IniFile.ReadNumberString(_path, _name, "idmapbot", ""));
			bott = Conversions.ToInteger(IniFile.ReadNumberString(_path, _name, "bott", ""));
			try
			{
				string text = IniFile.ReadStringOrEmpty(_path, _name, "Data_ListDrop", "");
				if (text.Length > 0)
				{
					string[] array = text.Split(',');
					if (array.Length > 0)
					{
						string[] array2 = array;
						foreach (string value in array2)
						{
							if (!Data_ListDrop.Contains(Conversions.ToInteger(value)))
							{
								Data_ListDrop.Add(Conversions.ToInteger(value));
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox("Lỗi tải danh sách đồ tự động vứt bỏ");
				ProjectData.ClearProjectError();
			}
			try
			{
				string text2 = IniFile.ReadStringOrEmpty(_path, _name, "Data_ListContribute", "");
				if (text2.Length > 0)
				{
					string[] array3 = text2.Split(',');
					if (array3.Length > 0)
					{
						string[] array4 = array3;
						foreach (string value2 in array4)
						{
							if (!Data_ListContribute.Contains(Conversions.ToInteger(value2)))
							{
								Data_ListContribute.Add(Conversions.ToInteger(value2));
							}
						}
					}
				}
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				Interaction.MsgBox("Lỗi tải danh sách đồ tự động đóng góp");
				ProjectData.ClearProjectError();
			}
			try
			{
				string text3 = IniFile.ReadStringOrEmpty(_path, _name, "Data_ListSend", "");
				if (text3.Length > 0)
				{
					string[] array5 = text3.Split(',');
					if (array5.Length > 0)
					{
						string[] array6 = array5;
						foreach (string value3 in array6)
						{
							if (!Data_ListSend.Contains(Conversions.ToInteger(value3)))
							{
								Data_ListSend.Add(Conversions.ToInteger(value3));
							}
						}
					}
				}
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				Interaction.MsgBox("Lỗi tải danh sách đồ tự động gửi");
				ProjectData.ClearProjectError();
			}
			try
			{
				string text4 = IniFile.ReadStringOrEmpty(_path, _name, "Data_ListSell", "");
				if (text4.Length <= 0)
				{
					return;
				}
				string[] array7 = text4.Split(',');
				if (array7.Length <= 0)
				{
					return;
				}
				string[] array8 = array7;
				foreach (string value4 in array8)
				{
					if (!Data_ListSell.Contains(Conversions.ToInteger(value4)))
					{
						Data_ListSell.Add(Conversions.ToInteger(value4));
					}
				}
			}
			catch (Exception ex7)
			{
				ProjectData.SetProjectError(ex7);
				Exception ex8 = ex7;
				Interaction.MsgBox("Lỗi tải danh sách đồ tự động bán");
				ProjectData.ClearProjectError();
			}
		}

		private void a()
		{
			checked
			{
				battlecount++;
				Status = "Trận đấu kết thúc";
				API.AddColorText_battle2(this, RtbBattle, "==================== Trận đấu kết thúc ====================", Color.Red);
				RtbBattle.Clear();
				this.m_v = (int)time_online;
				if (_CuoiNgua == 0 && C_CheckBox_TuLenNgua)
				{
					LenNgua();
				}
				StatusBarPanel_BattleCount = battlecount.ToString();
				AutoThanhLuu();
				if (C_CheckBox_AutoEat)
				{
					CharEatHp();
					CharEatSp();
					PetEatHp();
					PetEatSp();
				}
				if (C_CheckBox_CatPet && (int)Math.Round(Conversion.Val((double)Data_PetInfo._Hp / (double)Data_PetInfo._HpMax * 100.0)) <= 10)
				{
					SendPacket(API.hexstringtobyte("F44402001302"));
				}
			}
			if (C_CheckBox_AutoUsePT && ((Data_Player._God == 0) & (Data_Player._Ghost == 0)))
			{
				foreach (_Data._Tuido value in Data_Tuido.Values)
				{
					int id = value._Id;
					int stt = value._Stt;
					if (id > 0)
					{
						int type = Items.Data_Items[id]._Type;
						if ((uint)(type - 33) <= 1u || type == 93)
						{
							CharEquit(stt, 1);
							break;
						}
					}
				}
			}
			if (C_CheckBox_Char_ChangeTG)
			{
				int id2 = Data_CharEquit[5]._Id;
				int doben = Data_CharEquit[5]._Doben;
				if (id2 == 0 || id2 == 23024 || doben >= 250)
				{
					foreach (_Data._Tuido value2 in Data_Tuido.Values)
					{
						int id3 = value2._Id;
						int stt2 = value2._Stt;
						switch (id3)
						{
						case 23086:
						case 23135:
							if (Data_Player._ThuocTinh == 1)
							{
								CharEquit(stt2, 1);
								goto end_IL_0337;
							}
							break;
						case 23087:
						case 23136:
							if (Data_Player._ThuocTinh == 2)
							{
								CharEquit(stt2, 1);
								goto end_IL_0337;
							}
							break;
						case 23088:
						case 23137:
							if (Data_Player._ThuocTinh == 3)
							{
								CharEquit(stt2, 1);
								goto end_IL_0337;
							}
							break;
						case 23089:
						case 23138:
							if (Data_Player._ThuocTinh == 4)
							{
								CharEquit(stt2, 1);
								goto end_IL_0337;
							}
							break;
						}
						continue;
						end_IL_0337:
						break;
					}
				}
			}
			if (C_CheckBox_Pet_ChangeTG)
			{
				int id4 = Data_PetEquit[5]._Id;
				int doben2 = Data_PetEquit[5]._Doben;
				int id5 = Data_PetInfo._Id;
				if (Npcs.Data_Npcs.ContainsKey(id5))
				{
					int thuoctinh = Npcs.Data_Npcs[id5]._Thuoctinh;
					if (id4 == 0 || id4 == 23024 || doben2 >= 250)
					{
						foreach (_Data._Tuido value3 in Data_Tuido.Values)
						{
							int id6 = value3._Id;
							int stt3 = value3._Stt;
							switch (id6)
							{
							case 23086:
							case 23135:
								if (thuoctinh == 1)
								{
									PetEquit(stt3, 1);
									goto end_IL_04ca;
								}
								break;
							case 23087:
							case 23136:
								if (thuoctinh == 2)
								{
									PetEquit(stt3, 1);
									goto end_IL_04ca;
								}
								break;
							case 23088:
							case 23137:
								if (thuoctinh == 3)
								{
									PetEquit(stt3, 1);
									goto end_IL_04ca;
								}
								break;
							case 23089:
							case 23138:
								if (thuoctinh == 4)
								{
									PetEquit(stt3, 1);
									goto end_IL_04ca;
								}
								break;
							}
							continue;
							end_IL_04ca:
							break;
						}
					}
				}
			}
			if (C_CheckBox_AutoEquitExp)
			{
				int id7 = Data_CharEquit[5]._Id;
				int doben3 = Data_CharEquit[5]._Doben;
				if (id7 == 0 || id7 == 23024 || doben3 >= 250)
				{
					foreach (_Data._Tuido value4 in Data_Tuido.Values)
					{
						int id8 = value4._Id;
						int stt4 = value4._Stt;
						if (id8 > 0 && Items.Data_Items.ContainsKey(id8) && IDNgocEXP.Contains(Items.Data_Items[id8]._Type))
						{
							CharEquit(stt4, 1);
							break;
						}
					}
				}
			}
			AutoDropContribute();
			turn = 0;
			Battle = 0;
			if (AutoClearGhost)
			{
				SendEnd();
			}
			else
			{
				if (AutoClearGhost)
				{
					return;
				}
				if (atw == 1)
				{
					SendEnd();
				}
				else if ((Data_Player._LeaderId == Data_Player._Id) | (Data_Player._LeaderId == 0))
				{
					if (bott == 0)
					{
						if (Operators.CompareString(API.ServerIp, "159.196.70.237", false) == 0)
						{
							SendPacket(API.hexstringtobyte("F444040014900000"));
						}
						SendEnd();
						Button_bot = true;
					}
					else if (bott == 1)
					{
						if (Operators.CompareString(API.ServerIp, "159.196.70.237", false) == 0)
						{
							SendPacket(API.hexstringtobyte("F444040014890000"));
						}
						ClickNPCId(99);
						if (Data_Player._PartyFull)
						{
							API.AddColorText_battle2(this, RtbBattle, "đợi trận đấu mới", Color.Black);
							Thread thread = new Thread(replybot);
							thread.IsBackground = true;
							thread.Start();
						}
					}
					else if (bott == 2)
					{
						if (Operators.CompareString(API.ServerIp, "159.196.70.237", false) == 0)
						{
							SendPacket(API.hexstringtobyte("F444040014890000"));
						}
						ClickNPCId(99);
						bott = 0;
					}
				}
				else if (Operators.CompareString(API.ServerIp, "159.196.70.237", false) == 0)
				{
					SendPacket(API.hexstringtobyte("F444040014900000"));
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
