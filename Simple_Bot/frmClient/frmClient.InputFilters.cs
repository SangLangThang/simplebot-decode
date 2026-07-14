using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Simple_Bot
{
	public partial class frmClient : Form
	{
		private void ComboBox_KeyPress_BlockInput(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;
		}


		private void ComboBox_MouseDown_ClearContextMenu(object sender, MouseEventArgs e)
		{
			Control control = sender as Control;
			if (control != null)
			{
				control.ContextMenuStrip = new ContextMenuStrip();
			}
		}


		private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			object left = NewLateBinding.LateGet(sender, null, "Name", new object[0], null, null, null);
			if (Operators.ConditionalCompareObjectEqual(left, "TextBox_ClickMOD", false))
			{
				string text = "0123456789;\b";
				if ((text.IndexOf(e.KeyChar) == -1) & (Strings.Asc(e.KeyChar) != 1) & (Strings.Asc(e.KeyChar) != 2) & (Strings.Asc(e.KeyChar) != 3) & (Strings.Asc(e.KeyChar) != 22) & (Strings.Asc(e.KeyChar) != 24) & (Strings.Asc(e.KeyChar) != 26))
				{
					e.Handled = true;
				}
			}
			else
			{
				string text2 = "0123456789\b";
				if ((text2.IndexOf(e.KeyChar) == -1) & (Strings.Asc(e.KeyChar) != 1) & (Strings.Asc(e.KeyChar) != 2) & (Strings.Asc(e.KeyChar) != 3) & (Strings.Asc(e.KeyChar) != 22) & (Strings.Asc(e.KeyChar) != 24) & (Strings.Asc(e.KeyChar) != 26))
				{
					e.Handled = true;
				}
			}
		}


		private void TextBox_DelayBot_KeyPress(object sender, KeyPressEventArgs e)
		{
			string text = "0123456789.\b";
			if ((text.IndexOf(e.KeyChar) == -1) & (Strings.Asc(e.KeyChar) != 1) & (Strings.Asc(e.KeyChar) != 2) & (Strings.Asc(e.KeyChar) != 3) & (Strings.Asc(e.KeyChar) != 22) & (Strings.Asc(e.KeyChar) != 24) & (Strings.Asc(e.KeyChar) != 26))
			{
				e.Handled = true;
			}
		}


		private void TextBox_NumericValue_TextChanged(object sender, EventArgs e)
		{
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, null, "text", new object[0], null, null, null), null, "Length", new object[0], null, null, null), 0, false))
			{
				NewLateBinding.LateSet(sender, null, "text", new object[1] { "0" }, null, null);
				NewLateBinding.LateCall(sender, null, "SelectAll", new object[0], null, null, null, true);
			}
			if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreater(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, null, "text", new object[0], null, null, null), null, "Length", new object[0], null, null, null), 1, false), Operators.CompareObjectNotEqual(NewLateBinding.LateGet(sender, null, "Name", new object[0], null, null, null), TextBox_DelayBot.Name, false))) && Operators.CompareString(NewLateBinding.LateGet(sender, null, "text", new object[0], null, null, null).ToString().Substring(0, 1), "0", false) == 0)
			{
				NewLateBinding.LateSet(sender, null, "text", new object[1] { NewLateBinding.LateGet(sender, null, "text", new object[0], null, null, null).ToString().Substring(1) }, null, null);
				NewLateBinding.LateSet(sender, null, "SelectionStart", new object[1] { 1 }, null, null);
			}
			if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreater(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, null, "text", new object[0], null, null, null), null, "Length", new object[0], null, null, null), 1, false), Operators.CompareObjectEqual(NewLateBinding.LateGet(sender, null, "Name", new object[0], null, null, null), TextBox_DelayBot.Name, false))) && Operators.CompareString(NewLateBinding.LateGet(sender, null, "text", new object[0], null, null, null).ToString().Substring(0, 1), ".", false) == 0)
			{
				NewLateBinding.LateSet(sender, null, "text", new object[1] { NewLateBinding.LateGet(sender, null, "text", new object[0], null, null, null).ToString().Substring(1) }, null, null);
				NewLateBinding.LateSet(sender, null, "SelectionStart", new object[1] { 1 }, null, null);
			}
			try
			{
				if (_bot == null)
				{
					return;
				}
				if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "Name", new object[0], null, null, null), ToolStripTextBox_SendBDY_Id.Name, false))
				{
					int num = Conversions.ToInteger(ToolStripTextBox_SendBDY_Id.Text);
					if (num <= 0)
					{
						ToolStripTextBox_SendBDY_Id.Text = Conversions.ToString(0);
					}
				}
				object left = NewLateBinding.LateGet(sender, null, "Name", new object[0], null, null, null);
				if (Operators.ConditionalCompareObjectEqual(left, TBId.Name, false))
				{
					_bot.idlogin = Conversions.ToInteger(TBId.Text);
				}
				else if (Operators.ConditionalCompareObjectEqual(left, TextBox_DelayBot.Name, false))
				{
					_bot.TextBox_DelayBot = Conversions.ToDouble(TextBox_DelayBot.Text);
				}
				else if (Operators.ConditionalCompareObjectEqual(left, TextBox_IDmem1.Name, false))
				{
					_bot.TextBox_IDmem1 = Conversions.ToInteger(TextBox_IDmem1.Text);
				}
				else if (Operators.ConditionalCompareObjectEqual(left, TextBox_IDmem2.Name, false))
				{
					_bot.TextBox_IDmem2 = Conversions.ToInteger(TextBox_IDmem2.Text);
				}
				else if (Operators.ConditionalCompareObjectEqual(left, TextBox_IDmem3.Name, false))
				{
					_bot.TextBox_IDmem3 = Conversions.ToInteger(TextBox_IDmem3.Text);
				}
				else if (Operators.ConditionalCompareObjectEqual(left, TextBox_IDmem4.Name, false))
				{
					_bot.TextBox_IDmem4 = Conversions.ToInteger(TextBox_IDmem4.Text);
				}
				else if (Operators.ConditionalCompareObjectEqual(left, TextBox_IdLeader.Name, false))
				{
					_bot.TextBox_IdLeader = Conversions.ToInteger(TextBox_IdLeader.Text);
				}
				else if (Operators.ConditionalCompareObjectEqual(left, TextBox_ValueSPFlee.Name, false))
				{
					_bot.TextBox_ValueSPFlee = Conversions.ToInteger(TextBox_ValueSPFlee.Text);
				}
				else if (Operators.ConditionalCompareObjectEqual(left, TextBox_Eat_char_hp_value.Name, false))
				{
					_bot.TextBox_Eat_char_hp_value = Conversions.ToInteger(TextBox_Eat_char_hp_value.Text);
				}
				else if (Operators.ConditionalCompareObjectEqual(left, TextBox_Eat_char_sp_value.Name, false))
				{
					_bot.TextBox_Eat_char_sp_value = Conversions.ToInteger(TextBox_Eat_char_sp_value.Text);
				}
				else if (Operators.ConditionalCompareObjectEqual(left, TextBox_Eat_pet_hp_value.Name, false))
				{
					_bot.TextBox_Eat_Pet_hp_value = Conversions.ToInteger(TextBox_Eat_pet_hp_value.Text);
				}
				else if (Operators.ConditionalCompareObjectEqual(left, TextBox_Eat_pet_sp_value.Name, false))
				{
					_bot.TextBox_Eat_Pet_sp_value = Conversions.ToInteger(TextBox_Eat_pet_sp_value.Text);
				}
				else if (Operators.ConditionalCompareObjectEqual(left, TextBox_TL_pet_hp_value.Name, false))
				{
					_bot.TextBox_TL_pet_hp_value = Conversions.ToInteger(TextBox_TL_pet_hp_value.Text);
				}
				else if (Operators.ConditionalCompareObjectEqual(left, TextBox_TL_pet_sp_value.Name, false))
				{
					_bot.TextBox_TL_pet_sp_value = Conversions.ToInteger(TextBox_TL_pet_sp_value.Text);
				}
				else if (Operators.ConditionalCompareObjectEqual(left, NumericUpDown_ItemCountPickup.Name, false))
				{
					_bot.NumericUpDown_ItemCountPickup = Conversions.ToInteger(NumericUpDown_ItemCountPickup.Text);
				}
				else if (Operators.ConditionalCompareObjectEqual(left, TextBox_Drop_HpValue.Name, false))
				{
					_bot.TextBox_Drop_HpValue = Conversions.ToInteger(TextBox_Drop_HpValue.Text);
				}
				else if (Operators.ConditionalCompareObjectEqual(left, TextBox_Drop_SpValue.Name, false))
				{
					_bot.TextBox_Drop_SpValue = Conversions.ToInteger(TextBox_Drop_SpValue.Text);
				}
				else if (Operators.ConditionalCompareObjectEqual(left, TextBox_Contribute_HpValue.Name, false))
				{
					_bot.TextBox_Contribute_HpValue = Conversions.ToInteger(TextBox_Contribute_HpValue.Text);
				}
				else if (Operators.ConditionalCompareObjectEqual(left, TextBox_Contribute_SpValue.Name, false))
				{
					_bot.TextBox_Contribute_SpValue = Conversions.ToInteger(TextBox_Contribute_SpValue.Text);
				}
				else if (Operators.ConditionalCompareObjectEqual(left, TextBox_AutoSend.Name, false))
				{
					_bot.TextBox_AutoSend = Conversions.ToInteger(TextBox_AutoSend.Text);
				}
				else if (Operators.ConditionalCompareObjectEqual(left, TextBox_Send_HpValue.Name, false))
				{
					_bot.TextBox_Send_HpValue = Conversions.ToInteger(TextBox_Send_HpValue.Text);
				}
				else if (Operators.ConditionalCompareObjectEqual(left, TextBox_Send_SpValue.Name, false))
				{
					_bot.TextBox_Send_SpValue = Conversions.ToInteger(TextBox_Send_SpValue.Text);
				}
				else if (Operators.ConditionalCompareObjectEqual(left, TextBox_Sell_HpValue.Name, false))
				{
					_bot.TextBox_Sell_HpValue = Conversions.ToInteger(TextBox_Sell_HpValue.Text);
				}
				else if (Operators.ConditionalCompareObjectEqual(left, TextBox_Sell_SpValue.Name, false))
				{
					_bot.TextBox_Sell_SpValue = Conversions.ToInteger(TextBox_Sell_SpValue.Text);
				}
				else if (Operators.ConditionalCompareObjectEqual(left, TextBox_OpenMachine_CharHp.Name, false))
				{
					_bot.TextBox_OpenMachine_CharHp = Conversions.ToInteger(TextBox_OpenMachine_CharHp.Text);
				}
				else if (Operators.ConditionalCompareObjectEqual(left, TextBox_OpenMachine_CharSp.Name, false))
				{
					_bot.TextBox_OpenMachine_CharSp = Conversions.ToInteger(TextBox_OpenMachine_CharSp.Text);
				}
				else if (Operators.ConditionalCompareObjectEqual(left, TextBox_OpenMachine_PetHp.Name, false))
				{
					_bot.TextBox_OpenMachine_PetHp = Conversions.ToInteger(TextBox_OpenMachine_PetHp.Text);
				}
				else if (Operators.ConditionalCompareObjectEqual(left, TextBox_OpenMachine_PetSp.Name, false))
				{
					_bot.TextBox_OpenMachine_PetSp = Conversions.ToInteger(TextBox_OpenMachine_PetSp.Text);
				}
				else if (Operators.ConditionalCompareObjectEqual(left, TextBox_ClickMOD_Delay.Name, false))
				{
					_bot.TextBox_ClickMOD_delay = Conversions.ToInteger(TextBox_ClickMOD_Delay.Text);
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
}
