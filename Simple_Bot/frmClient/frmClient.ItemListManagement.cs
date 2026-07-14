using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Simple_Bot
{
	public partial class frmClient : Form
	{
		private void Button_AddIdDrop_Click(object sender, EventArgs e)
		{
			int num = Conversions.ToInteger(TextBox_AddIdDrop.Text);
			if (((num > 0) & Items.Data_Items.ContainsKey(num)) && !_bot.Data_ListDrop.Contains(num))
			{
				ListView_AutoDrop.Items.Add(Conversions.ToString(num)).SubItems.Add(GetItemName(num));
				_bot.Data_ListDrop.Add(num);
			}
		}

		private void ListView_ItemList_DoubleClick_Remove(object sender, MouseEventArgs e)
		{
			if (e.Button != MouseButtons.Left || !Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, null, "Items", new object[0], null, null, null), null, "Count", new object[0], null, null, null), 0, false))
			{
				return;
			}
			try
			{
				ListViewItem listViewItem = (ListViewItem)NewLateBinding.LateGet(NewLateBinding.LateGet(sender, null, "SelectedItems", new object[0], null, null, null), null, "Item", new object[1] { 0 }, null, null, null);
				int num = Conversions.ToInteger(listViewItem.SubItems[0].Text);
				object left = NewLateBinding.LateGet(sender, null, "Name", new object[0], null, null, null);
				if (Operators.ConditionalCompareObjectEqual(left, ListView_AutoDrop.Name, false))
				{
					if (_bot.Data_ListDrop.Contains(num))
					{
						_bot.Data_ListDrop.Remove(num);
					}
				}
				else if (Operators.ConditionalCompareObjectEqual(left, ListView_AutoContribute.Name, false))
				{
					if (_bot.Data_ListContribute.Contains(num))
					{
						_bot.Data_ListContribute.Remove(num);
					}
				}
				else if (Operators.ConditionalCompareObjectEqual(left, ListView_AutoSend.Name, false))
				{
					if (_bot.Data_ListSend.Contains(num))
					{
						_bot.Data_ListSend.Remove(num);
					}
				}
				else if (Operators.ConditionalCompareObjectEqual(left, ListView_AutoSell.Name, false))
				{
					if (_bot.Data_ListSell.Contains(num))
					{
						_bot.Data_ListSell.Remove(num);
					}
				}
				else if (!Operators.ConditionalCompareObjectEqual(left, ListView_Shop.Name, false))
				{
				}
				object[] array;
				bool[] array2;
				NewLateBinding.LateCall(NewLateBinding.LateGet(sender, null, "Items", new object[0], null, null, null), null, "Remove", array = new object[1] { listViewItem }, null, null, array2 = new bool[1] { true }, true);
				if (array2[0])
				{
					listViewItem = (ListViewItem)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(ListViewItem));
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

		private void Button_AddIdContribute_Click(object sender, EventArgs e)
		{
			int num = Conversions.ToInteger(TextBox_AddIdContribute.Text);
			if (((num > 0) & Items.Data_Items.ContainsKey(num)) && !_bot.Data_ListContribute.Contains(num))
			{
				ListView_AutoContribute.Items.Add(Conversions.ToString(num)).SubItems.Add(GetItemName(num));
				_bot.Data_ListContribute.Add(num);
			}
		}

		private void Button_AddIdSend_Click(object sender, EventArgs e)
		{
			int num = Conversions.ToInteger(TextBox_AddIdSend.Text);
			if (((num > 0) & Items.Data_Items.ContainsKey(num)) && !_bot.Data_ListSend.Contains(num))
			{
				ListView_AutoSend.Items.Add(Conversions.ToString(num)).SubItems.Add(GetItemName(num));
				_bot.Data_ListSend.Add(num);
			}
		}

		private void Button_AddIdSell_Click(object sender, EventArgs e)
		{
			int num = Conversions.ToInteger(TextBox_AddIdSell.Text);
			if (((num > 0) & Items.Data_Items.ContainsKey(num)) && !_bot.Data_ListSell.Contains(num))
			{
				ListView_AutoSell.Items.Add(Conversions.ToString(num)).SubItems.Add(GetItemName(num));
				_bot.Data_ListSell.Add(num);
			}
		}

		private void ListView_ItemList_MouseEnter_Tooltip(object sender, EventArgs e)
		{
			ToolTip_info.SetToolTip((Control)sender, "Nháy đúp chuột trái để xoá");
		}

		private void DataGridView_ListDrop_UserDeletedRow(object sender, DataGridViewCellEventArgs e)
		{
			int num = Conversions.ToInteger(DataSet1.Tables["Table_ListDrop"].Rows[e.RowIndex]["Id"]);
			DataSet1.Tables["Table_ListDrop"].Rows.RemoveAt(e.RowIndex);
			if (_bot.Data_ListDrop.Contains(num))
			{
				_bot.Data_ListDrop.Remove(num);
			}
		}

		private void DataGridView_ListSell_UserDeletedRow(object sender, DataGridViewCellEventArgs e)
		{
			int num = Conversions.ToInteger(DataSet1.Tables["Table_ListSell"].Rows[e.RowIndex]["Id"]);
			DataSet1.Tables["Table_ListSell"].Rows.RemoveAt(e.RowIndex);
			if (_bot.Data_ListSell.Contains(num))
			{
				_bot.Data_ListSell.Remove(num);
			}
		}

		private void DataGridView_ListContribute_UserDeletedRow(object sender, DataGridViewCellEventArgs e)
		{
			int num = Conversions.ToInteger(DataSet1.Tables["Table_ListContribute"].Rows[e.RowIndex]["Id"]);
			DataSet1.Tables["Table_ListContribute"].Rows.RemoveAt(e.RowIndex);
			if (_bot.Data_ListContribute.Contains(num))
			{
				_bot.Data_ListContribute.Remove(num);
			}
		}

		private void DataGridView_ListSend_UserDeletedRow(object sender, DataGridViewCellEventArgs e)
		{
			int num = Conversions.ToInteger(DataSet1.Tables["Table_ListSend"].Rows[e.RowIndex]["Id"]);
			DataSet1.Tables["Table_ListSend"].Rows.RemoveAt(e.RowIndex);
			if (_bot.Data_ListSend.Contains(num))
			{
				_bot.Data_ListSend.Remove(num);
			}
		}

	}
}
