using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Simple_Bot
{
	public partial class _ClientBot
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
	}
}
