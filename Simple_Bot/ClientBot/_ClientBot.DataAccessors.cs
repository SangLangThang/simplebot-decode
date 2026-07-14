using System.Drawing;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Simple_Bot
{
	public partial class _ClientBot
	{
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
	}
}
