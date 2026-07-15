using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Simple_Bot
{
	public class Items
	{
		public struct ShopItem
		{
			public int _Id;

			public string _Name;

			public int _Stt;

			public int _Price;
		}

		public struct ItemInfo
		{
			public int _id;

			public int _idPic;

			public string _Name;

			public int _Lv;

			public int _tt;

			public int _Hp;

			public int _Sp;

			public int _Int1;

			public int _Atk1;

			public int _Def1;

			public int _Hpx1;

			public int _Spx1;

			public int _Agi1;

			public int _Fai1;

			public int _Loai;

			public int _Point;

			public int _Type;

			public string _Info;

			public int _Type_2;

			public int _Trade;

			public int _Type_Value1;

			public int _Value1;

			public int _Type_Value2;

			public int _Value2;

			public int _IdBua;
		}

		public struct Key_mix
		{
			public int _1;

			public int _2;

			public int _3;
		}

		public struct Key_mix_item
		{
			public int _mix;

			public int _cont;
		}

		private static Dictionary<int, ItemInfo> a = new Dictionary<int, ItemInfo>();

		public static Dictionary<int, ItemInfo> Data_Items = new Dictionary<int, ItemInfo>();

		public static Dictionary<int, int> Data_reborn3 = new Dictionary<int, int>();

		public static Dictionary<Key_mix, ArrayList> Data_Mixs = new Dictionary<Key_mix, ArrayList>();

		public static Dictionary<Key_mix_item, ArrayList> Data_Mixs_item = new Dictionary<Key_mix_item, ArrayList>();

		public static Dictionary<int, ArrayList> Data_Mixs_item1 = new Dictionary<int, ArrayList>();

		public static Dictionary<int, ArrayList> Data_Mixs_item2 = new Dictionary<int, ArrayList>();

		public static Dictionary<int, ArrayList> Data_Mixs_item4 = new Dictionary<int, ArrayList>();

		public static Dictionary<int, ArrayList> Data_Mixs_item5 = new Dictionary<int, ArrayList>();

		public static ArrayList Data_Tuongtinh = new ArrayList();

		public static ArrayList Data_Tuongtinh_Pro = new ArrayList();

		public static ArrayList Data_TuongTinh_Dia_Pro = new ArrayList();

		public static ArrayList Data_TuongTinh_Thuy_Pro = new ArrayList();

		public static ArrayList Data_TuongTinh_Hoa_Pro = new ArrayList();

		public static ArrayList Data_TuongTinh_Phong_Pro = new ArrayList();

		public static ArrayList listNPC130to150reborned = new ArrayList();

		public static ArrayList ListItemBox2K = new ArrayList();

		public static ArrayList Data_Kimtoa_100 = new ArrayList();

		public static ArrayList Data_Kimtoa_120 = new ArrayList();

		public static ArrayList Data_Kimtoa_150 = new ArrayList();

		public static ArrayList Data_Kimtoa_100to150 = new ArrayList();

		public static Key_mix GetKey_mix(int _1, int _2, int _3)
		{
			return new Key_mix
			{
				_1 = _1,
				_2 = _2,
				_3 = _3
			};
		}

		public static Key_mix_item GetKey_mix_item(int _mix, int _cont)
		{
			return new Key_mix_item
			{
				_mix = _mix,
				_cont = _cont
			};
		}

		public static int _EFC3(byte[] data)
		{
			int num = Convert.ToInt32(API.bytestohexstring(new byte[2]
			{
				data[1],
				data[0]
			}), 16);
			if (num > 0)
			{
				num = checked((num ^ 0xEFC3) - 9);
			}
			if (num == 0)
			{
				num = 0;
			}
			return num;
		}

		public static void LoadDataItems2()
		{
			string text = "data\\item2.dat";
			int country = API.Country;
			if (country != 1)
			{
				return;
			}
			text = "data\\ItemTHAI.dat";
			if (!File.Exists(text))
			{
				return;
			}
			byte[] array = File.ReadAllBytes(text);
			checked
			{
				int num = array.Length - 1;
				for (int i = 0; i <= num; i += 370)
				{
					try
					{
						byte[] array2 = API.ByteArrayToByteArray(array, i, 370);
						byte[] data = API.ByteArrayToByteArray(array2, 22, 2);
						int idItem = API.GetIdItem(data);
						if (idItem <= 0)
						{
							continue;
						}
						byte[] array3 = API.ByteArrayToByteArray(array2, 0, 1);
						byte[] data2 = API.ByteArrayToByteArray(array2, 1, 20);
						byte[] array4 = API.ByteArrayToByteArray(array2, 21, 1);
						int idPic = _EFC3(API.ByteArrayToByteArray(array2, 24, 2));
						byte[] array5 = API.ByteArrayToByteArray(array2, 32, 2);
						byte[] array6 = API.ByteArrayToByteArray(array2, 38, 4);
						byte[] array7 = API.ByteArrayToByteArray(array2, 34, 4);
						byte[] array8 = API.ByteArrayToByteArray(array2, 42, 5);
						byte[] data3 = API.ByteArrayToByteArray(array2, 88, 4);
						byte[] array9 = API.ByteArrayToByteArray(array2, 98, 1);
						byte[] array10 = API.ByteArrayToByteArray(array2, 99, 2);
						byte[] array11 = API.ByteArrayToByteArray(array2, 48, 1);
						byte[] array12 = API.ByteArrayToByteArray(array2, 49, 1);
						byte[] data4 = API.ByteArrayToByteArray(array2, 83, 1);
						byte[] array13 = API.ByteArrayToByteArray(array2, 116, array2.Length - 116);
						byte[] array14 = API.ByteArrayToByteArray(array2, 93, 1);
						string Str = "";
						int lVItem = API.GetLVItem(data4);
						int num2 = 0;
						int num3 = 0;
						int @int = 0;
						int atk = 0;
						int def = 0;
						int hpx = 0;
						int spx = 0;
						int agi = 0;
						int fai = 0;
						int num4 = 0;
						int num5 = 0;
						int num6 = 0;
						int num7 = 0;
						int num8 = 0;
						int num9 = 0;
						int num10 = 0;
						int num11 = 0;
						int num12 = 0;
						int num13 = 0;
						int num14 = 0;
						int num15 = (Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							array6[1],
							array6[0]
						}), 16) ^ 0xF4B4) - 109;
						switch (Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							array5[1],
							array5[0]
						}), 16) ^ 0xEFCA)
						{
						case 209:
							hpx = num15;
							break;
						case 208:
							spx = num15;
							break;
						case 212:
							@int = num15;
							break;
						case 210:
							atk = num15;
							break;
						case 213:
							def = num15;
							break;
						case 234:
							num11 = num15;
							break;
						case 237:
							num12 = num15;
							break;
						case 214:
							agi = num15;
							break;
						case 43:
							num2 = num15;
							break;
						case 42:
							num3 = num15;
							break;
						case 64:
							fai = num15;
							break;
						}
						int num16 = (Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							array8[1],
							array8[0]
						}), 16) ^ 0xF4B4) - 109;
						switch (Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							array7[1],
							array7[0]
						}), 16) ^ 0xEFCA)
						{
						case 209:
							num7 = num16;
							break;
						case 208:
							num8 = num16;
							break;
						case 212:
							num4 = num16;
							break;
						case 210:
							num5 = num16;
							break;
						case 213:
							num6 = num16;
							break;
						case 234:
							num13 = num16;
							break;
						case 237:
							num14 = num16;
							break;
						case 214:
							num9 = num16;
							break;
						case 43:
							num2 += num16;
							break;
						case 42:
							num3 += num16;
							break;
						case 64:
							num10 = num16;
							break;
						}
						int num17 = (array9[0] ^ 0x9A) - 9;
						int num18 = 0;
						if (num17 > 0)
						{
							num18 = Conversions.ToInteger(((Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								array10[1],
								array10[0]
							}), 16) ^ 0xF4B4) - 109).ToString());
						}
						int loai = Conversions.ToInteger(((array11[0] ^ 0x9A) - 9).ToString());
						string Str2 = "";
						int country2 = API.Country;
						if (country2 == 1)
						{
							API.GetNameItem(data2);
							int num19 = array13.Length - 1;
							for (int j = num19; j >= 0; j += -1)
							{
								if (array13[j] > 0)
								{
									Str2 += Conversions.ToString(Strings.Chr(array13[j]));
								}
							}
							Str = Conversions.ToString(API.THAIEncodeString(ref Str));
							Str2 = Conversions.ToString(API.THAIEncodeString(ref Str2));
						}
						else
						{
							if (GetDataName.Data_Item_Name.ContainsKey(idItem))
							{
								Str = GetDataName.Data_Item_Name[idItem];
							}
							if (GetDataName.Data_Item_Info.ContainsKey(idItem))
							{
								Str2 = GetDataName.Data_Item_Info[idItem];
							}
						}
						ItemInfo value = new ItemInfo
						{
							_id = idItem,
							_idPic = idPic,
							_Name = API.VISCII_to_Unicode(Str),
							_Lv = lVItem,
							_tt = num17,
							_Hp = num2,
							_Sp = num3,
							_Int1 = @int,
							_Atk1 = atk,
							_Def1 = def,
							_Hpx1 = hpx,
							_Spx1 = spx,
							_Agi1 = agi,
							_Fai1 = fai,
							_Loai = loai,
							_Point = API.GetGiaItem(data3),
							_Type = (array12[0] ^ 0x9A) - 9,
							_Info = API.VISCII_to_Unicode(Str2),
							_Type_2 = (array4[0] ^ 0x9A) - 9,
							_Trade = (array14[0] ^ 0x9A) - 9
						};
						a.Add(value._id, value);
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ProjectData.ClearProjectError();
						break;
					}
				}
			}
		}

		public static void LoadDataItems()
		{
			LoadDataItems2();
			string path = "data\\item.dat";
			byte[] array = File.ReadAllBytes(path);
			checked
			{
				int num = array.Length - 1;
				for (int i = 0; i <= num; i += 370)
				{
					try
					{
						byte[] array2 = API.ByteArrayToByteArray(array, i, 370);
						byte[] data = API.ByteArrayToByteArray(array2, 22, 2);
						int idItem = API.GetIdItem(data);
						if (idItem <= 0)
						{
							continue;
						}
						byte[] array3 = API.ByteArrayToByteArray(array2, 0, 1);
						byte[] data2 = API.ByteArrayToByteArray(array2, 1, 20);
						byte[] array4 = API.ByteArrayToByteArray(array2, 21, 1);
						int idPic = _EFC3(API.ByteArrayToByteArray(array2, 24, 2));
						byte[] array5 = API.ByteArrayToByteArray(array2, 32, 2);
						byte[] array6 = API.ByteArrayToByteArray(array2, 38, 4);
						byte[] array7 = API.ByteArrayToByteArray(array2, 34, 4);
						byte[] array8 = API.ByteArrayToByteArray(array2, 42, 5);
						byte[] data3 = API.ByteArrayToByteArray(array2, 88, 4);
						byte[] array9 = API.ByteArrayToByteArray(array2, 98, 1);
						byte[] array10 = API.ByteArrayToByteArray(array2, 99, 2);
						byte[] array11 = API.ByteArrayToByteArray(array2, 48, 1);
						byte[] array12 = API.ByteArrayToByteArray(array2, 49, 1);
						byte[] data4 = API.ByteArrayToByteArray(array2, 83, 1);
						byte[] array13 = API.ByteArrayToByteArray(array2, 116, array2.Length - 116);
						byte[] data5 = API.ByteArrayToByteArray(array2, 103, 2);
						string text = "";
						int lVItem = API.GetLVItem(data4);
						int num2 = 0;
						int num3 = 0;
						int @int = 0;
						int atk = 0;
						int def = 0;
						int hpx = 0;
						int spx = 0;
						int agi = 0;
						int fai = 0;
						int num4 = 0;
						int num5 = 0;
						int num6 = 0;
						int num7 = 0;
						int num8 = 0;
						int num9 = 0;
						int num10 = 0;
						int num11 = 0;
						int num12 = 0;
						int num13 = 0;
						int num14 = 0;
						int num15 = (Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							array6[1],
							array6[0]
						}), 16) ^ 0xF4B4) - 109;
						switch (Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							array5[1],
							array5[0]
						}), 16) ^ 0xEFCA)
						{
						case 209:
							hpx = num15;
							break;
						case 208:
							spx = num15;
							break;
						case 212:
							@int = num15;
							break;
						case 210:
							atk = num15;
							break;
						case 213:
							def = num15;
							break;
						case 234:
							num11 = num15;
							break;
						case 237:
							num12 = num15;
							break;
						case 214:
							agi = num15;
							break;
						case 43:
							num2 = num15;
							break;
						case 42:
							num3 = num15;
							break;
						case 64:
							fai = num15;
							break;
						}
						int num16 = (Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							array8[1],
							array8[0]
						}), 16) ^ 0xF4B4) - 109;
						switch (Convert.ToInt32(API.bytestohexstring(new byte[2]
						{
							array7[1],
							array7[0]
						}), 16) ^ 0xEFCA)
						{
						case 209:
							num7 = num16;
							break;
						case 208:
							num8 = num16;
							break;
						case 212:
							num4 = num16;
							break;
						case 210:
							num5 = num16;
							break;
						case 213:
							num6 = num16;
							break;
						case 234:
							num13 = num16;
							break;
						case 237:
							num14 = num16;
							break;
						case 214:
							num9 = num16;
							break;
						case 43:
							num2 += num16;
							break;
						case 42:
							num3 += num16;
							break;
						case 64:
							num10 = num16;
							break;
						}
						int num17 = (array9[0] ^ 0x9A) - 9;
						int num18 = 0;
						if (num17 > 0)
						{
							num18 = Conversions.ToInteger(((Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								array10[1],
								array10[0]
							}), 16) ^ 0xF4B4) - 109).ToString());
						}
						int loai = Conversions.ToInteger(((array11[0] ^ 0x9A) - 9).ToString());
						string text2 = "";
						int country = API.Country;
						if (country == 1)
						{
							if (a.ContainsKey(idItem))
							{
								text = a[idItem]._Name;
								text2 = a[idItem]._Info;
							}
							else
							{
								text = API.GetNameItem(data2);
								int num19 = array13.Length - 1;
								for (int j = num19; j >= 0; j += -1)
								{
									if (array13[j] > 0)
									{
										text2 += Conversions.ToString(Strings.Chr(array13[j]));
									}
								}
							}
						}
						else
						{
							text = (GetDataName.Data_Item_Name.ContainsKey(idItem) ? GetDataName.Data_Item_Name[idItem] : ((!a.ContainsKey(idItem)) ? API.GetNameItem(data2) : a[idItem]._Name));
							if (GetDataName.Data_Item_Info.ContainsKey(idItem))
							{
								text2 = GetDataName.Data_Item_Info[idItem];
							}
							else if (a.ContainsKey(idItem))
							{
								text2 = a[idItem]._Info;
							}
							else
							{
								int num20 = array13.Length - 1;
								for (int k = num20; k >= 0; k += -1)
								{
									if (array13[k] > 0)
									{
										text2 += Conversions.ToString(Strings.Chr(array13[k]));
									}
								}
							}
						}
						ItemInfo value = new ItemInfo
						{
							_id = idItem,
							_idPic = idPic,
							_Name = text,
							_Lv = lVItem,
							_tt = num17,
							_Hp = num2,
							_Sp = num3,
							_Int1 = @int,
							_Atk1 = atk,
							_Def1 = def,
							_Hpx1 = hpx,
							_Spx1 = spx,
							_Agi1 = agi,
							_Fai1 = fai,
							_Loai = loai,
							_Point = API.GetGiaItem(data3),
							_Type = (array12[0] ^ 0x9A) - 9,
							_Info = text2,
							_Type_2 = (array4[0] ^ 0x9A) - 9,
							_Type_Value1 = (Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								array5[1],
								array5[0]
							}), 16) ^ 0xEFC3) - 9,
							_Value1 = num15,
							_Type_Value2 = (Convert.ToInt32(API.bytestohexstring(new byte[2]
							{
								array7[1],
								array7[0]
							}), 16) ^ 0xEFC3) - 9,
							_Value2 = num16,
							_IdBua = API.GetValue5Item(data5)
						};
						Data_Items.Add(value._id, value);
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ProjectData.ClearProjectError();
						continue;
					}
				}
			}
		}
	}
}
