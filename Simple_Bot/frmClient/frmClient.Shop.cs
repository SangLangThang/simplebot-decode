using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Simple_Bot
{
	public partial class frmClient : Form
	{
		private void Button_ShopAddItem_Click(object sender, EventArgs e)
		{
			if (_bot == null)
			{
				return;
			}
			checked
			{
				if (_bot.skill_buonban > 0)
				{
					int num = Conversions.ToInteger(TextBox_ShopAddId.Text);
					int num2 = Conversions.ToInteger(TextBox_ShopAddPrice.Text);
					string text = "Không biết tên!!!";
					if (Items.Data_Items.ContainsKey(num))
					{
						if (ListView_Shop.Items.Count < _bot.skill_buonban + 3)
						{
							if (ListView_Shop.Items.Count > 0)
							{
								try
								{
									ListViewItem listViewItem = ListView_Shop.FindItemWithText(num.ToString(), false, 0);
									if (listViewItem.Text.Length > 0)
									{
										Interaction.MsgBox("Vật phẩm đã tồn tại!!!");
									}
									return;
								}
								catch (Exception ex)
								{
									ProjectData.SetProjectError(ex);
									Exception ex2 = ex;
									ProjectData.ClearProjectError();
								}
							}
							text = Items.Data_Items[num]._Name;
							ListViewItem listViewItem2 = ListView_Shop.Items.Add(Conversions.ToString(num));
							listViewItem2.SubItems.Add(text);
							listViewItem2.SubItems.Add(Conversions.ToString(num2));
						}
						else
						{
							Interaction.MsgBox("Thuật buôn bán cấp " + _bot.skill_buonban + " chỉ bán được " + (_bot.skill_buonban + 3) + " đồ !!!");
						}
					}
					else
					{
						Interaction.MsgBox("Không có vật phẩm này!!!");
					}
				}
				else
				{
					Interaction.MsgBox("Chưa học thuật buôn bán!!!");
				}
			}
		}

		private void Button_Shop_Start_Click(object sender, EventArgs e)
		{
			if (_bot == null)
			{
				return;
			}
			string left = Button_Shop_Start.Text;
			checked
			{
				if (Operators.CompareString(left, "Bày bán", false) == 0)
				{
					if (_bot.ComboBox_Port != 0)
					{
						Interaction.MsgBox("Bạn chỉ có thể sử dụng ở kênh 0!");
					}
					else if (ListView_Shop.Items.Count == 0)
					{
						Interaction.MsgBox("Chưa có đồ để bán!");
					}
					else
					{
						if (ListView_Shop.Items.Count <= 0)
						{
							return;
						}
						if (_bot.List_ShopItem.Count > 0)
						{
							_bot.List_ShopItem.Clear();
						}
						int num = ListView_Shop.Items.Count - 1;
						for (int i = 0; i <= num; i++)
						{
							foreach (_Data._Tuido value2 in _bot.Data_Tuido.Values)
							{
								int num2 = value2._Id;
								if (num2 == Conversions.ToInteger(ListView_Shop.Items[i].Text))
								{
									Items.ShopItem value = new Items.ShopItem
									{
										_Id = num2,
										_Name = ListView_Shop.Items[i].SubItems[1].Text,
										_Stt = value2._Stt,
										_Price = Conversions.ToInteger(ListView_Shop.Items[i].SubItems[2].Text)
									};
									if (!_bot.List_ShopItem.ContainsKey(value2._Stt))
									{
										_bot.List_ShopItem.Add(value2._Stt, value);
									}
								}
							}
						}
						if (_bot.List_ShopItem.Count <= 0)
						{
							return;
						}
						_bot.List_ShopType = 1;
						_bot.List_ShopName = "";
						try
						{
							if (ComboBox_ShopType.SelectedItem.ToString().Length > 0)
							{
								_bot.List_ShopType = ComboBox_ShopType.SelectedIndex;
							}
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							ProjectData.ClearProjectError();
						}
						if (TextBox_ShopName.TextLength > 0)
						{
							_bot.List_ShopName = TextBox_ShopName.Text;
						}
						_bot.Shop_Opening();
					}
				}
				else
				{
					_bot.Shop_Closing();
				}
			}
		}

		private void MenuItem_AddToShop_Click(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					int num = Conversions.ToInteger(Interaction.InputBox("Nhập giá muốn bán", "Lưu ý giá gồm các chữ số, lớn hơn 1 và nhỏ hơn 2 tỷ", "1"));
					string text = "Không biết tên!!!";
					if (num <= 0)
					{
						return;
					}
					int num2 = _bot.Data_Tuido[_Homdo_slot_select]._Id;
					if (!((num2 > 0) & Items.Data_Items.ContainsKey(num2)))
					{
						return;
					}
					if (ListView_Shop.Items.Count < _bot.skill_buonban + 3)
					{
						if (ListView_Shop.Items.Count > 0)
						{
							try
							{
								ListViewItem listViewItem = ListView_Shop.FindItemWithText(num2.ToString(), false, 0);
								if (listViewItem.Text.Length > 0)
								{
									Interaction.MsgBox("Vật phẩm đã tồn tại!!!");
								}
								return;
							}
							catch (Exception ex)
							{
								ProjectData.SetProjectError(ex);
								Exception ex2 = ex;
								ProjectData.ClearProjectError();
							}
						}
						text = Items.Data_Items[num2]._Name;
						ListViewItem listViewItem2 = ListView_Shop.Items.Add(Conversions.ToString(num2));
						listViewItem2.SubItems.Add(text);
						listViewItem2.SubItems.Add(Conversions.ToString(num));
					}
					else
					{
						Interaction.MsgBox("Thuật buôn bán cấp " + _bot.skill_buonban + " chỉ bán được " + (_bot.skill_buonban + 3) + " đồ !!!");
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
