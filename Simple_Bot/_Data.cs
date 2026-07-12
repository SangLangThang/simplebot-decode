using System.Drawing;
using System.Runtime.InteropServices;

namespace Simple_Bot
{
	public class _Data
	{
		public struct _Player
		{
			public int _Id;

			public string _Name;

			public int _Lv;

			public int _Lv2;

			public int _Sex;

			public int _Hair;

			public int _HairColor;

			public int _SkinColor;

			public int _Hp;

			public int _HpMax;

			public int _Sp;

			public int _SpMax;

			public int _MapId;

			public int _MapX;

			public int _MapY;

			public int _Gold;

			public long _ExpTotal;

			public int _Exp;

			public int _ExpMax;

			public int _ExpMin;

			public int _Int;

			public int _Atk;

			public int _Def;

			public int _Hpx;

			public int _Spx;

			public int _Agi;

			public int _Int2;

			public int _Atk2;

			public int _Def2;

			public int _Hpx2;

			public int _Spx2;

			public int _Agi2;

			public int _Int_Plus1;

			public int _Atk_Plus1;

			public int _Def_Plus1;

			public int _Hpx_Plus1;

			public int _Spx_Plus1;

			public int _Agi_Plus1;

			public int _Int_Plus2;

			public int _Atk_Plus2;

			public int _Def_Plus2;

			public int _Hpx_Plus2;

			public int _Spx_Plus2;

			public int _Agi_Plus2;

			public int _Int3;

			public int _Atk3;

			public int _Def3;

			public int _Hpx3;

			public int _Spx3;

			public int _Int4;

			public int _Atk4;

			public int _Def4;

			public int _Hpx4;

			public int _Spx4;

			public int _Agi4;

			public int _Texp;

			public int _God;

			public int _Ghost;

			public int _Reborn;

			public int _ThuocTinh;

			public int _PlayerOnline;

			public int _LeaderId;

			public bool _PartyFull;

			public int _Point;

			public string _MapName;
		}

		public struct _Pets
		{
			public int _Id;

			public string _Name;

			public int _Lv;

			public int _ThuocTinh;

			public int _Hp;

			public int _HpMax;

			public int _Sp;

			public int _SpMax;

			public int _Fai;

			public int _ExpTotal;

			public int _Exp;

			public int _ExpMax;

			public int _ExpMin;

			public int _Texp;

			public int _Reborn;

			public int _Int;

			public int _Atk;

			public int _Def;

			public int _Hpx;

			public int _Spx;

			public int _Agi;

			public int _Int2;

			public int _Atk2;

			public int _Def2;

			public int _Hpx2;

			public int _Spx2;

			public int _Agi2;

			public int _Int3;

			public int _Atk3;

			public int _Def3;

			public int _Hpx3;

			public int _Spx3;

			public int _Agi3;

			public int _Mu;

			public int _Ao;

			public int _vukhi;

			public int _tay;

			public int _chan;

			public int _dacthu;

			public int _Mu_Doben;

			public int _Ao_Doben;

			public int _vukhi_Doben;

			public int _tay_Doben;

			public int _chan_Doben;

			public int _dacthu_Doben;

			public int _Proto;
		}

		public struct _NpcInMap
		{
			public int _Id;

			public int _MapX;

			public int _MapY;

			public int _Delay;

			public int _KC;
		}

		[StructLayout(LayoutKind.Sequential, Size = 1)]
		public struct Type_Pets
		{
			public static string _Id = "_Id";

			public static string _Name = "_Name";

			public static string _Lv = "_Lv";

			public static string _ThuocTinh = "_ThuocTinh";

			public static string _Hp = "_Hp";

			public static string _HpMax = "_HpMax";

			public static string _Sp = "_Sp";

			public static string _SpMax = "_SpMax";

			public static string _Fai = "_Fai";

			public static string _ExpTotal = "_ExpTotal";

			public static string _TExp = "_TExp";

			public static string _Exp = "_Exp";

			public static string _ExpMax = "_ExpMax";

			public static string _ExpMin = "_ExpMin";

			public static string _Reborn = "_Reborn";

			public static string _Int = "_Int";

			public static string _Atk = "_Atk";

			public static string _Def = "_Def";

			public static string _Hpx = "_Hpx";

			public static string _Spx = "_Spx";

			public static string _Agi = "_Agi";

			public static string _Int2 = "_Int2";

			public static string _Atk2 = "_Atk2";

			public static string _Def2 = "_Def2";

			public static string _Hpx2 = "_Hpx2";

			public static string _Spx2 = "_Spx2";

			public static string _Agi2 = "_Agi2";

			public static string _Int3 = "_Int3";

			public static string _Atk3 = "_Atk3";

			public static string _Def3 = "_Def3";

			public static string _Hpx3 = "_Hpx3";

			public static string _Spx3 = "_Spx3";

			public static string _Agi3 = "_Agi3";

			public static string _Mu = "_Mu";

			public static string _Ao = "_Ao";

			public static string _vukhi = "_vukhi";

			public static string _tay = "_tay";

			public static string _chan = "_chan";

			public static string _dacthu = "_dacthu";

			public static string _Mu_Doben = "_Mu_Doben";

			public static string _Ao_Doben = "_Ao_Doben";

			public static string _vukhi_Doben = "_vukhi_Doben";

			public static string _tay_Doben = "_tay_Doben";

			public static string _chan_Doben = "_chan_Doben";

			public static string _dacthu_Doben = "_dacthu_Doben";

			public static string _Proto = "_Proto";
		}

		public struct _CharEquit
		{
			public int _Id;

			public string _Name;

			public int _Doben;
		}

		public struct _PetEquit
		{
			public int _Id;

			public string _Name;

			public int _Doben;
		}

		[StructLayout(LayoutKind.Sequential, Size = 1)]
		public struct Type_Equit
		{
			public static string _Id = "Id";

			public static string _Name = "Name";

			public static string _Doben = "Doben";
		}

		public struct _Tuido
		{
			public int _Stt;

			public int _Id;

			public string _Name;

			public int _Sl;

			public int _Doben;
		}

		public struct _Tuideo
		{
			public int _Stt;

			public int _Id;

			public string _Name;

			public int _Sl;

			public int _Doben;
		}

		[StructLayout(LayoutKind.Sequential, Size = 1)]
		public struct Type_Tui
		{
			public static string _Stt = "Stt";

			public static string _Id = "Id";

			public static string _Name = "Name";

			public static string _Sl = "Sl";

			public static string _Doben = "Doben";
		}

		public struct _AttackSetting
		{
			public int _TurnCount;

			public int _Skill1;

			public int _Skill2;

			public int _Skill3;

			public int _Skill4;

			public int _Skill5;

			public int _Skill6;

			public int _Skill7;

			public int _Skill8;

			public int _Skill9;

			public int _Skill10;

			public string _Location1;

			public string _Location2;

			public string _Location3;

			public string _Location4;

			public string _Location5;

			public string _Location6;

			public string _Location7;

			public string _Location8;

			public string _Location9;

			public string _Location10;
		}

		public struct _Battleinfo
		{
			public int _Id;

			public string _Name;

			public int _Lv;

			public int _Hp;

			public int _HpMax;

			public int _Sp;

			public int _SpMax;

			public int _ThuocTinh;

			public int _Type;

			public int _IdChar;

			public Color _Color;
		}

		[StructLayout(LayoutKind.Sequential, Size = 1)]
		public struct Type_Battleinfo
		{
			public static string _Id = "Id";

			public static string _Name = "Name";

			public static string _Lv = "Lv";

			public static string _Hp = "Hp";

			public static string _HpMax = "HpMax";

			public static string _Sp = "Sp";

			public static string _SpMax = "SpMax";

			public static string _ThuocTinh = "ThuocTinh";

			public static string _Type = "Type";

			public static string _IdChar = "IdChar";

			public static string _Color = "Color";
		}

		public struct _ItemOnMap
		{
			public int _Gold;

			public int _Id;

			public string _Name;

			public int _MapX;

			public int _MapY;
		}

		[StructLayout(LayoutKind.Sequential, Size = 1)]
		public struct Type_ItemOnMap
		{
			public static string _Gold = "Gold";

			public static string _Id = "Id";

			public static string _Name = "Name";

			public static string _MapX = "MapX";

			public static string _MapY = "MapY";
		}

		[StructLayout(LayoutKind.Sequential, Size = 1)]
		public struct Type_NpcInMap
		{
			public static string _Id = "Id";

			public static string _MapX = "MapX";

			public static string _MapY = "MapY";

			public static string _Delay = "Delay";

			public static string _KC = "KC";
		}

		public struct _InfoText
		{
			public string _Text;

			public Color _Color;
		}
	}
}
