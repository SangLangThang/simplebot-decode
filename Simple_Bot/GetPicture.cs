using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using Microsoft.VisualBasic.CompilerServices;
using Simple_Bot.My.Resources;

namespace Simple_Bot
{
	public class GetPicture
	{
		public struct _Data_Photos_item
		{
			public ushort _id;

			public byte _type;

			public ushort _len;

			public byte[] _photo;
		}

		public struct _Photo_pet
		{
			public ushort _id;

			public ushort _x;

			public ushort _y;

			public int _len;

			public Dictionary<int, byte[]> _colors;

			public byte[] _photo;
		}

		public struct _Photo_info
		{
			public int _x;

			public int _y;

			public Dictionary<int, Color> _colors;
		}

		public static Dictionary<int, _Data_Photos_item> Data_Photos_item_bytes = new Dictionary<int, _Data_Photos_item>();

		public static Dictionary<int, _Photo_pet> Data_Photos_npc_bytes = new Dictionary<int, _Photo_pet>();

		public static Dictionary<int, Bitmap> Mini_Photo = new Dictionary<int, Bitmap>();

		private static readonly Dictionary<int, Bitmap> ItemPhotoCache = new Dictionary<int, Bitmap>();

		private static readonly string[] DataSearchRoots = new string[2]
		{
			AppDomain.CurrentDomain.BaseDirectory,
			Directory.GetCurrentDirectory()
		};

		public static void GetLinks()
		{
			GetPicture_NPC();
		}

		public static void GetPicture_item()
		{
			Data_Photos_item_bytes.Clear();
			ItemPhotoCache.Clear();
			LoadItemPhotoFile(ResolveDataFile("TalkVN.dat"));
			AddItemPhotoAlias(8914, 10000);
			AddItemPhotoAlias(8924, 17001);
			AddItemPhotoAlias(14002, 18001);
		}

		private static string ResolveDataFile(string fileName)
		{
			foreach (string root in DataSearchRoots)
			{
				if (string.IsNullOrEmpty(root))
				{
					continue;
				}
				string path = Path.Combine(root, "data", fileName);
				if (File.Exists(path))
				{
					return path;
				}
			}
			return Path.Combine("data", fileName);
		}

		private static void LoadItemPhotoFile(string path)
		{
			if (!File.Exists(path))
			{
				return;
			}
			byte[] byteArray = File.ReadAllBytes(path);
			int num = 0;
			checked
			{
				while (num + 5 <= byteArray.Length)
				{
					try
					{
						ushort id = (ushort)API.BytetoInt32(API.ByteArrayToByteArray(byteArray, num, 2));
						num += 2;
						byte type = (byte)API.BytetoInt32(API.ByteArrayToByteArray(byteArray, num, 1));
						num++;
						ushort num2 = (ushort)API.BytetoInt32(API.ByteArrayToByteArray(byteArray, num, 2));
						num += 2;
						if (num2 <= 0 || num + num2 > byteArray.Length)
						{
							break;
						}
						byte[] photo = API.ByteArrayToByteArray(byteArray, num, num2);
						num += num2;
						_Data_Photos_item value = new _Data_Photos_item
						{
							_id = id,
							_type = type,
							_len = num2,
							_photo = photo
						};
						Data_Photos_item_bytes[value._id] = value;
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

		private static void AddItemPhotoAlias(int sourceId, int aliasId)
		{
			if (Data_Photos_item_bytes.ContainsKey(sourceId) && !Data_Photos_item_bytes.ContainsKey(aliasId))
			{
				_Data_Photos_item value = Data_Photos_item_bytes[sourceId];
				value._id = (ushort)aliasId;
				Data_Photos_item_bytes.Add(aliasId, value);
			}
		}

		public static void GetPicture_NPC()
		{
			string path = ResolveDataFile("QuestVN.dat");
			if (!File.Exists(path))
			{
				return;
			}
			byte[] array = File.ReadAllBytes(path);
			int num = 0;
			checked
			{
				do
				{
					ushort id = (ushort)API.BytetoInt32(API.ByteArrayToByteArray(array, num, 2));
					num += 2;
					ushort x = (ushort)API.BytetoInt32(API.ByteArrayToByteArray(array, num, 2));
					num += 2;
					ushort y = (ushort)API.BytetoInt32(API.ByteArrayToByteArray(array, num, 2));
					num += 2;
					int num2 = API.BytetoInt32(API.ByteArrayToByteArray(array, num, 4));
					num += 4;
					byte[] byteArray = API.ByteArrayToByteArray(array, num, 1024);
					num += 1024;
					byte[] photo = API.ByteArrayToByteArray(array, num, num2);
					num += num2;
					_Photo_pet value = new _Photo_pet
					{
						_id = id,
						_x = x,
						_y = y,
						_len = num2
					};
					Dictionary<int, byte[]> dictionary = new Dictionary<int, byte[]>();
					int num3 = 0;
					do
					{
						byte[] value2 = API.ByteArrayToByteArray(byteArray, num3 * 4, 4);
						dictionary.Add(num3, value2);
						num3++;
					}
					while (num3 <= 255);
					value._colors = dictionary;
					value._photo = photo;
					if (!Data_Photos_npc_bytes.ContainsKey(value._id))
					{
						Data_Photos_npc_bytes.Add(value._id, value);
					}
					switch (value._id)
					{
					case 1577:
						Mini_Photo.Add(1, _GetPhoto(1577));
						break;
					case 1578:
						Mini_Photo.Add(2, _GetPhoto(1577));
						break;
					case 1579:
						Mini_Photo.Add(3, _GetPhoto(1577));
						break;
					case 1580:
						Mini_Photo.Add(4, _GetPhoto(1577));
						break;
					}
				}
				while (num != array.Length);
			}
		}

		public static Bitmap _GetPhoto_Item(int _id)
		{
			if (ItemPhotoCache.ContainsKey(_id))
			{
				return new Bitmap(ItemPhotoCache[_id]);
			}
			if (Data_Photos_item_bytes.ContainsKey(_id))
			{
				try
				{
					byte[] photo = Data_Photos_item_bytes[_id]._photo;
					using MemoryStream stream = new MemoryStream(photo);
					Bitmap bitmap = new Bitmap(Image.FromStream(stream));
					bitmap.MakeTransparent(Color.FromArgb(65280));
					ItemPhotoCache[_id] = bitmap;
					return new Bitmap(bitmap);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
			}
			return new Bitmap(Resources._1000);
		}

		public static Bitmap _GetPhoto_Skill(int _id)
		{
			return _GetPhoto_Item(_id);
		}

		public static Bitmap _GetPhoto(Npcs.NpcInfo npc)
		{
			Bitmap bitmap = Resources._1000;
			checked
			{
				if (Data_Photos_npc_bytes.ContainsKey(npc._IdPic))
				{
					_Photo_pet photo_pet = Data_Photos_npc_bytes[npc._IdPic];
					byte[] photo = photo_pet._photo;
					int x = photo_pet._x;
					int y = photo_pet._y;
					Dictionary<int, byte[]> colors = photo_pet._colors;
					try
					{
						byte[] array = photo;
						int num = x;
						int num2 = y;
						bitmap = new Bitmap(num, num2);
						int num3 = num - 1;
						int num6 = default(int);
						int num7 = default(int);
						int num8 = default(int);
						for (int i = 0; i <= num3; i++)
						{
							int num4 = num2 - 1;
							for (int j = 0; j <= num4; j++)
							{
								int num5 = array[i + j * num];
								if (num5 == 255)
								{
									num5 = 0;
								}
								byte[] array2 = (byte[])colors[num5].Clone();
								num6 *= 25;
								num7 *= 25;
								num8 *= 25;
								string text = "444";
								if (npc.color[0].ToString().Length == 8)
								{
									npc.color[0] = Conversions.ToString(Conversions.ToUInteger("0" + npc.color[0].ToString()));
								}
								if (npc.color[1].ToString().Length == 8)
								{
									npc.color[1] = Conversions.ToString(Conversions.ToUInteger("0" + npc.color[1].ToString()));
								}
								if (npc.color[2].ToString().Length == 8)
								{
									npc.color[2] = Conversions.ToString(Conversions.ToUInteger("0" + npc.color[2].ToString()));
								}
								if (npc.color[3].ToString().Length == 8)
								{
									npc.color[3] = Conversions.ToString(Conversions.ToUInteger("0" + npc.color[3].ToString()));
								}
								switch (num5)
								{
								case 1:
								case 2:
								case 3:
								case 4:
								case 5:
								case 6:
								case 7:
								case 8:
								case 9:
								case 10:
								case 11:
								case 12:
								case 13:
								case 14:
								case 15:
								case 16:
								case 17:
								case 18:
								case 19:
								case 20:
								case 21:
								case 22:
								case 23:
								case 24:
								case 25:
								case 26:
								case 27:
								case 28:
								case 29:
								case 30:
								case 31:
									text = npc.color[0].ToString().Substring(0, 3);
									break;
								case 32:
								case 33:
								case 34:
								case 35:
								case 36:
								case 37:
								case 38:
								case 39:
								case 40:
								case 41:
								case 42:
								case 43:
								case 44:
								case 45:
								case 46:
								case 47:
								case 48:
									text = npc.color[0].ToString().Substring(3, 3);
									break;
								case 49:
								case 50:
								case 51:
								case 52:
								case 53:
								case 54:
								case 55:
								case 56:
								case 57:
								case 58:
								case 59:
								case 60:
								case 61:
								case 62:
								case 63:
									text = npc.color[0].ToString().Substring(6, 3);
									break;
								case 64:
								case 65:
								case 66:
								case 67:
								case 68:
								case 69:
								case 70:
								case 71:
								case 72:
								case 73:
								case 74:
								case 75:
								case 76:
								case 77:
								case 78:
								case 79:
									text = npc.color[1].ToString().Substring(0, 3);
									break;
								case 80:
								case 81:
								case 82:
								case 83:
								case 84:
								case 85:
								case 86:
								case 87:
								case 88:
								case 89:
								case 90:
								case 91:
								case 92:
								case 93:
								case 94:
									text = npc.color[0].ToString().Substring(3, 3);
									break;
								case 95:
								case 96:
								case 97:
								case 98:
								case 99:
								case 100:
								case 101:
								case 102:
								case 103:
								case 104:
								case 105:
								case 106:
								case 107:
								case 108:
								case 109:
									text = npc.color[1].ToString().Substring(6, 3);
									break;
								case 110:
								case 111:
								case 112:
								case 113:
								case 114:
								case 115:
								case 116:
								case 117:
								case 118:
								case 119:
								case 120:
								case 121:
								case 122:
								case 123:
								case 124:
								case 125:
								case 126:
									text = npc.color[2].ToString().Substring(0, 3);
									break;
								case 127:
								case 128:
								case 129:
								case 130:
								case 131:
								case 132:
								case 133:
								case 134:
								case 135:
								case 136:
								case 137:
								case 138:
								case 139:
								case 140:
								case 141:
								case 142:
								case 143:
									text = npc.color[2].ToString().Substring(3, 3);
									break;
								case 144:
								case 145:
								case 146:
								case 147:
								case 148:
								case 149:
								case 150:
								case 151:
								case 152:
								case 153:
								case 154:
								case 155:
									text = npc.color[2].ToString().Substring(6, 3);
									break;
								case 156:
								case 157:
								case 158:
								case 159:
								case 160:
								case 161:
								case 162:
								case 163:
								case 164:
								case 165:
								case 166:
								case 167:
								case 168:
								case 169:
								case 170:
								case 171:
								case 172:
								case 173:
								case 174:
								case 175:
									text = npc.color[3].ToString().Substring(0, 3);
									break;
								case 176:
								case 177:
								case 178:
								case 179:
								case 180:
								case 181:
								case 182:
								case 183:
								case 184:
								case 185:
								case 186:
								case 187:
								case 188:
								case 189:
								case 190:
								case 191:
								case 192:
								case 193:
								case 194:
								case 195:
								case 196:
								case 197:
								case 198:
								case 199:
								case 200:
								case 201:
								case 202:
								case 203:
								case 204:
								case 205:
								case 206:
								case 207:
								case 208:
								case 209:
								case 210:
								case 211:
								case 212:
								case 213:
								case 214:
								case 215:
								case 216:
								case 217:
								case 218:
								case 219:
									text = npc.color[3].ToString().Substring(3, 3);
									break;
								case 220:
								case 221:
								case 222:
								case 223:
								case 224:
								case 225:
								case 226:
								case 227:
								case 228:
								case 229:
								case 230:
								case 231:
								case 232:
								case 233:
								case 234:
								case 235:
								case 236:
								case 237:
								case 238:
								case 239:
								case 240:
								case 241:
								case 242:
								case 243:
								case 244:
								case 245:
								case 246:
								case 247:
								case 248:
								case 249:
								case 250:
								case 251:
								case 252:
								case 253:
								case 254:
									text = npc.color[3].ToString().Substring(6, 3);
									break;
								}
								num6 = Conversions.ToInteger(text.Substring(0, 1)) - 4;
								num7 = Conversions.ToInteger(text.Substring(1, 1)) - 4;
								num8 = Conversions.ToInteger(text.Substring(2, 1)) - 4;
								num6 *= 25;
								num7 *= 25;
								num8 *= 25;
								if (array2[0] + num8 > 250)
								{
									array2[0] = 250;
								}
								else if (array2[0] + num8 < 0)
								{
									array2[0] = 0;
								}
								else
								{
									array2[0] = (byte)(array2[0] + num8);
								}
								if (array2[1] + num7 > 250)
								{
									array2[1] = 250;
								}
								else if (array2[1] + num7 < 0)
								{
									array2[1] = 0;
								}
								else
								{
									array2[1] = (byte)(array2[1] + num7);
								}
								if (array2[2] + num6 > 250)
								{
									array2[2] = 250;
								}
								else if (array2[2] + num6 < 0)
								{
									array2[2] = 0;
								}
								else
								{
									array2[2] = (byte)(array2[2] + num6);
								}
								Color color = Color.FromArgb(array2[2], array2[1], array2[0]);
								if (num5 == 0)
								{
									bitmap.SetPixel(i, j, Color.Transparent);
								}
								else
								{
									bitmap.SetPixel(i, j, color);
								}
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
				return bitmap;
			}
		}

		public static Bitmap _GetPhoto(int IdPic, int _haircolor, int _skincolor)
		{
			Bitmap bitmap = Resources._1000;
			checked
			{
				if (Data_Photos_npc_bytes.ContainsKey(IdPic))
				{
					_Photo_pet photo_pet = Data_Photos_npc_bytes[IdPic];
					byte[] photo = photo_pet._photo;
					int x = photo_pet._x;
					int y = photo_pet._y;
					Dictionary<int, byte[]> colors = photo_pet._colors;
					try
					{
						byte[] array = photo;
						int num = x;
						int num2 = y;
						bitmap = new Bitmap(num, num2);
						int num3 = num - 1;
						int num6 = default(int);
						int num7 = default(int);
						int num8 = default(int);
						for (int i = 0; i <= num3; i++)
						{
							int num4 = num2 - 1;
							for (int j = 0; j <= num4; j++)
							{
								int num5 = array[i + j * num];
								if (num5 == 255)
								{
									num5 = 0;
								}
								byte[] array2 = (byte[])colors[num5].Clone();
								num6 *= 25;
								num7 *= 25;
								num8 *= 25;
								string text = "444";
								switch (num5)
								{
								case 1:
								case 2:
								case 3:
								case 4:
								case 5:
								case 6:
								case 7:
								case 8:
								case 9:
								case 10:
								case 11:
								case 12:
								case 13:
								case 14:
								case 15:
								case 16:
								case 17:
								case 18:
								case 19:
								case 20:
								case 21:
								case 22:
								case 23:
								case 24:
								case 25:
								case 26:
								case 27:
								case 28:
								case 29:
								case 30:
								case 31:
									text = _haircolor.ToString("000000000").Substring(0, 3);
									break;
								case 32:
								case 33:
								case 34:
								case 35:
								case 36:
								case 37:
								case 38:
								case 39:
								case 40:
								case 41:
								case 42:
								case 43:
								case 44:
								case 45:
								case 46:
								case 47:
								case 48:
									text = _haircolor.ToString("000000000").Substring(3, 3);
									break;
								case 49:
								case 50:
								case 51:
								case 52:
								case 53:
								case 54:
								case 55:
								case 56:
								case 57:
								case 58:
								case 59:
								case 60:
								case 61:
								case 62:
								case 63:
									text = _haircolor.ToString("000000000").Substring(6, 3);
									break;
								case 64:
								case 65:
								case 66:
								case 67:
								case 68:
								case 69:
								case 70:
								case 71:
								case 72:
								case 73:
								case 74:
								case 75:
								case 76:
								case 77:
								case 78:
								case 79:
									text = _skincolor.ToString("000000000").Substring(0, 3);
									break;
								case 80:
								case 81:
								case 82:
								case 83:
								case 84:
								case 85:
								case 86:
								case 87:
								case 88:
								case 89:
								case 90:
								case 91:
								case 92:
								case 93:
								case 94:
									text = _skincolor.ToString("000000000").Substring(3, 3);
									break;
								case 95:
								case 96:
								case 97:
								case 98:
								case 99:
								case 100:
								case 101:
								case 102:
								case 103:
								case 104:
								case 105:
								case 106:
								case 107:
								case 108:
								case 109:
									text = _skincolor.ToString("000000000").Substring(6, 3);
									break;
								}
								num6 = Conversions.ToInteger(text.Substring(0, 1)) - 4;
								num7 = Conversions.ToInteger(text.Substring(1, 1)) - 4;
								num8 = Conversions.ToInteger(text.Substring(2, 1)) - 4;
								num6 *= 25;
								num7 *= 25;
								num8 *= 25;
								if (array2[0] + num8 > 250)
								{
									array2[0] = 250;
								}
								else if (array2[0] + num8 < 0)
								{
									array2[0] = 0;
								}
								else
								{
									array2[0] = (byte)(array2[0] + num8);
								}
								if (array2[1] + num7 > 250)
								{
									array2[1] = 250;
								}
								else if (array2[1] + num7 < 0)
								{
									array2[1] = 0;
								}
								else
								{
									array2[1] = (byte)(array2[1] + num7);
								}
								if (array2[2] + num6 > 250)
								{
									array2[2] = 250;
								}
								else if (array2[2] + num6 < 0)
								{
									array2[2] = 0;
								}
								else
								{
									array2[2] = (byte)(array2[2] + num6);
								}
								Color color = Color.FromArgb(array2[2], array2[1], array2[0]);
								if (num5 == 0)
								{
									bitmap.SetPixel(i, j, Color.Transparent);
								}
								else
								{
									bitmap.SetPixel(i, j, color);
								}
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
				return bitmap;
			}
		}

		public static Bitmap _GetPhoto(int IdPic)
		{
			Bitmap bitmap = Resources._1000;
			checked
			{
				if (Data_Photos_npc_bytes.ContainsKey(IdPic))
				{
					_Photo_pet photo_pet = Data_Photos_npc_bytes[IdPic];
					byte[] photo = photo_pet._photo;
					int x = photo_pet._x;
					int y = photo_pet._y;
					Dictionary<int, byte[]> colors = photo_pet._colors;
					try
					{
						byte[] array = photo;
						int num = x;
						int num2 = y;
						bitmap = new Bitmap(num, num2);
						int num3 = num - 1;
						for (int i = 0; i <= num3; i++)
						{
							int num4 = num2 - 1;
							for (int j = 0; j <= num4; j++)
							{
								int num5 = array[i + j * num];
								if (num5 == 255)
								{
									num5 = 0;
								}
								byte[] array2 = (byte[])colors[num5].Clone();
								Color color = Color.FromArgb(array2[2], array2[1], array2[0]);
								if (num5 == 0)
								{
									bitmap.SetPixel(i, j, Color.Transparent);
								}
								else
								{
									bitmap.SetPixel(i, j, color);
								}
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
				return bitmap;
			}
		}
	}
}
