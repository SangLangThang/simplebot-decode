using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Simple_Bot
{
	public partial class frmClient : Form
	{
		private void Settings_CheckedChanged(object sender, EventArgs e)
		{
			if (_Botting == null)
			{
				return;
			}
			object left = NewLateBinding.LateGet(sender, null, "Name", new object[0], null, null, null);
			if (Operators.ConditionalCompareObjectEqual(left, CheckBox_Reconnect.Name, false))
			{
				_Botting.C_CheckBox_Reconnect = Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null));
			}
			else if (Operators.ConditionalCompareObjectEqual(left, CheckBox_QuestProtect.Name, false))
			{
				_Botting.C_CheckBox_QuestProtect = Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null));
			}
			else if (Operators.ConditionalCompareObjectEqual(left, CheckBox_autosell.Name, false))
			{
				_Botting.C_CheckBox_autosell = Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null));
				if (CheckBox_autosell.Checked && _Botting.Data_Player._MapId != 12001)
				{
					_Botting.atw = 1;
					_Botting.AutoWarptoMap = "12001";
					_Botting.AutoWarp(_Botting.AutoWarptoMap);
					_Botting._time_AutoSell = 0;
				}
			}
			else if (Operators.ConditionalCompareObjectEqual(left, CheckBox_TuLenNgua.Name, false))
			{
				_Botting.C_CheckBox_TuLenNgua = Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null));
				if (CheckBox_TuLenNgua.Checked)
				{
					_Botting.LenNgua();
				}
				else
				{
					_Botting.XuongNgua();
				}
			}
			else if (Operators.ConditionalCompareObjectEqual(left, CheckBox_Bee.Name, false))
			{
				_Botting.C_CheckBox_Bee = Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null));
				if (Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null)) && _Botting.logined == 1)
				{
					_Botting._Bee_X = _Botting.Data_Player._MapX;
					_Botting._Bee_Y = _Botting.Data_Player._MapY;
				}
			}
			else if (Operators.ConditionalCompareObjectEqual(left, CheckBox_AutoRevival.Name, false))
			{
				_Botting.C_CheckBox_AutoRevival = Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null));
			}
			else if (Operators.ConditionalCompareObjectEqual(left, CheckBox_LeaderDissNotEnough.Name, false))
			{
				_Botting.C_CheckBox_LeaderDissNotEnough = Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null));
			}
			else if (Operators.ConditionalCompareObjectEqual(left, CheckBox_Char_ChangeTG.Name, false))
			{
				_Botting.C_CheckBox_Char_ChangeTG = Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null));
			}
			else if (Operators.ConditionalCompareObjectEqual(left, CheckBox_AutoFlee_Sp.Name, false))
			{
				_Botting.C_CheckBox_AutoFlee_Sp = Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null));
			}
			else if (Operators.ConditionalCompareObjectEqual(left, CheckBox_AutoFlee_Party.Name, false))
			{
				_Botting.C_CheckBox_AutoFlee_Party = Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null));
			}
			else if (Operators.ConditionalCompareObjectEqual(left, CheckBox_Pet_ChangeTG.Name, false))
			{
				_Botting.C_CheckBox_Pet_ChangeTG = Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null));
			}
			else if (Operators.ConditionalCompareObjectEqual(left, CheckBox_AutoClickNPC.Name, false))
			{
				_Botting.C_CheckBox_AutoClickNPC = Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null));
				if (CheckBox_AutoClickNPC.Checked)
				{
					if (TextBox_ClickMOD.Text.Length == 0)
					{
						CheckBox_AutoClickNPC.Checked = false;
						Interaction.MsgBox("Bạn chưa điền id npc");
					}
					else
					{
						TextBox_ClickMOD.Enabled = false;
					}
				}
				else
				{
					TextBox_ClickMOD.Enabled = true;
				}
			}
			else if (Operators.ConditionalCompareObjectEqual(left, CheckBox_AutoPickup.Name, false))
			{
				_Botting.C_CheckBox_AutoPickup = Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null));
			}
			else if (Operators.ConditionalCompareObjectEqual(left, CheckBox_DropHp.Name, false))
			{
				_Botting.C_CheckBox_DropHp = Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null));
			}
			else if (Operators.ConditionalCompareObjectEqual(left, CheckBox_DropSp.Name, false))
			{
				_Botting.C_CheckBox_DropSp = Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null));
			}
			else if (Operators.ConditionalCompareObjectEqual(left, CheckBox_DropHpSp.Name, false))
			{
				_Botting.C_CheckBox_DropHpSp = Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null));
			}
			else if (Operators.ConditionalCompareObjectEqual(left, CheckBox_DropMineWood.Name, false))
			{
				_Botting.C_CheckBox_DropMineWood = Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null));
			}
			else if (Operators.ConditionalCompareObjectEqual(left, CheckBox_ContributeHp.Name, false))
			{
				_Botting.C_CheckBox_ContributeHp = Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null));
			}
			else if (Operators.ConditionalCompareObjectEqual(left, CheckBox_ContributeSp.Name, false))
			{
				_Botting.C_CheckBox_ContributeSp = Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null));
			}
			else if (Operators.ConditionalCompareObjectEqual(left, CheckBox_ContributeHpSp.Name, false))
			{
				_Botting.C_CheckBox_ContributeHpSp = Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null));
			}
			else if (Operators.ConditionalCompareObjectEqual(left, CheckBox_ContributeMineWood.Name, false))
			{
				_Botting.C_CheckBox_ContributeMineWood = Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null));
			}
			else if (Operators.ConditionalCompareObjectEqual(left, CheckBox_SendHp.Name, false))
			{
				_Botting.C_CheckBox_SendHp = Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null));
			}
			else if (Operators.ConditionalCompareObjectEqual(left, CheckBox_SendSp.Name, false))
			{
				_Botting.C_CheckBox_SendSp = Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null));
			}
			else if (Operators.ConditionalCompareObjectEqual(left, CheckBox_SendHpSp.Name, false))
			{
				_Botting.C_CheckBox_SendHpSp = Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null));
			}
			else if (Operators.ConditionalCompareObjectEqual(left, CheckBox_SendMineWood.Name, false))
			{
				_Botting.C_CheckBox_SendMineWood = Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null));
			}
			else if (Operators.ConditionalCompareObjectEqual(left, CheckBox_SellHp.Name, false))
			{
				_Botting.C_CheckBox_SellHp = Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null));
			}
			else if (Operators.ConditionalCompareObjectEqual(left, CheckBox_SellSP.Name, false))
			{
				_Botting.C_CheckBox_SellSP = Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null));
			}
			else if (Operators.ConditionalCompareObjectEqual(left, CheckBox_SellHpSp.Name, false))
			{
				_Botting.C_CheckBox_SellHpSp = Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null));
			}
			else if (Operators.ConditionalCompareObjectEqual(left, CheckBox_SellMineWood.Name, false))
			{
				_Botting.C_CheckBox_SellMineWood = Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null));
			}
			else if (Operators.ConditionalCompareObjectEqual(left, CheckBox_Pickup.Name, false))
			{
				_Botting.C_CheckBox_Pickup = Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null));
			}
			else if (Operators.ConditionalCompareObjectEqual(left, RadioButton_QS1.Name, false))
			{
				_Botting.C_RadioButton_QS1 = Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null));
				if (RadioButton_QS1.Checked & (TextBox_IDmem1.BackColor == Color.LightGreen))
				{
					_Botting.SetQuanSu(Conversions.ToInteger(TextBox_IDmem1.Text));
				}
			}
			else if (Operators.ConditionalCompareObjectEqual(left, RadioButton_QS2.Name, false))
			{
				_Botting.C_RadioButton_QS2 = Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null));
				if (RadioButton_QS2.Checked & (TextBox_IDmem2.BackColor == Color.LightGreen))
				{
					_Botting.SetQuanSu(Conversions.ToInteger(TextBox_IDmem2.Text));
				}
			}
			else if (Operators.ConditionalCompareObjectEqual(left, RadioButton_QS3.Name, false))
			{
				_Botting.C_RadioButton_QS3 = Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null));
				if (RadioButton_QS3.Checked & (TextBox_IDmem3.BackColor == Color.LightGreen))
				{
					_Botting.SetQuanSu(Conversions.ToInteger(TextBox_IDmem3.Text));
				}
			}
			else if (Operators.ConditionalCompareObjectEqual(left, RadioButton_QS4.Name, false))
			{
				_Botting.C_RadioButton_QS4 = Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null));
				if (RadioButton_QS4.Checked & (TextBox_IDmem4.BackColor == Color.LightGreen))
				{
					_Botting.SetQuanSu(Conversions.ToInteger(TextBox_IDmem4.Text));
				}
			}
			else if (Operators.ConditionalCompareObjectEqual(left, CheckBox_CatPet.Name, false))
			{
				_Botting.C_CheckBox_CatPet = Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null));
			}
			else if (Operators.ConditionalCompareObjectEqual(left, CheckBox_ClearGhost.Name, false))
			{
				_Botting.C_CheckBox_ClearGhost = Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null));
			}
			else if (Operators.ConditionalCompareObjectEqual(left, CheckBox_AutoEquitExp.Name, false))
			{
				_Botting.C_CheckBox_AutoEquitExp = Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null));
				if (!CheckBox_AutoEquitExp.Checked)
				{
					return;
				}
				int num = _Botting.Data_CharEquit[5]._Id;
				int doben = _Botting.Data_CharEquit[5]._Doben;
				if (!(num == 0 || num == 23024 || doben >= 250))
				{
					return;
				}
				int num2 = 1;
				do
				{
					_Data._Tuido tuido = _Botting.Data_Tuido[num2];
					int num3 = tuido._Id;
					int stt = tuido._Stt;
					if (num3 > 0 && Items.Data_Items.ContainsKey(num3) && _Botting.IDNgocEXP.Contains(Items.Data_Items[num3]._Type))
					{
						_Botting.CharEquit(stt, 1);
						break;
					}
					num2 = checked(num2 + 1);
				}
				while (num2 <= 25);
			}
			else if (Operators.ConditionalCompareObjectEqual(left, CheckBox_AutoUsePT.Name, false))
			{
				_Botting.C_CheckBox_AutoUsePT = Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null));
				if (!CheckBox_AutoUsePT.Checked || !((_Botting.Data_Player._God == 0) & (_Botting.Data_Player._Ghost == 0)))
				{
					return;
				}
				int num4 = 1;
				do
				{
					_Data._Tuido tuido2 = _Botting.Data_Tuido[num4];
					int num5 = tuido2._Id;
					int stt2 = tuido2._Stt;
					if (num5 > 0)
					{
						int type = Items.Data_Items[num5]._Type;
						if ((uint)(type - 33) <= 1u || type == 93)
						{
							_Botting.CharEquit(stt2, 1);
							break;
						}
					}
					num4 = checked(num4 + 1);
				}
				while (num4 <= 25);
			}
			else if (Operators.ConditionalCompareObjectEqual(left, RadioButton_LeaderRequestParty.Name, false))
			{
				_Botting.C_RadioButton_LeaderRequestParty = Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null));
			}
			else if (Operators.ConditionalCompareObjectEqual(left, RadioButton_MemberRequestParty.Name, false))
			{
				_Botting.C_RadioButton_MemberRequestParty = Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null));
			}
			else if (Operators.ConditionalCompareObjectEqual(left, RadioButton_PT_no.Name, false))
			{
				_Botting.C_RadioButton_PT_no = Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null));
			}
			else if (Operators.ConditionalCompareObjectEqual(left, CheckBox_DCAfter1MinNoBattle.Name, false))
			{
				_Botting.C_CheckBox_DCAfter1MinNoBattle = Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null));
			}
			else if (Operators.ConditionalCompareObjectEqual(left, CheckBox_DisExp.Name, false))
			{
				_Botting.C_CheckBox_DisExp = Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null));
			}
			else if (Operators.ConditionalCompareObjectEqual(left, RadioButton_DCLeaderOut.Name, false))
			{
				_Botting.C_RadioButton_DCLeaderOut = Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null));
			}
			else if (Operators.ConditionalCompareObjectEqual(left, RadioButton_DCmemout.Name, false))
			{
				_Botting.C_RadioButton_DCmemout = Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null));
			}
			else if (Operators.ConditionalCompareObjectEqual(left, RadioButton_DC_no.Name, false))
			{
				_Botting.C_RadioButton_DC_no = Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null));
			}
			else if (Operators.ConditionalCompareObjectEqual(left, CheckBox_AutoEat.Name, false))
			{
				_Botting.C_CheckBox_AutoEat = Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null));
			}
			else if (Operators.ConditionalCompareObjectEqual(left, CheckBox_TL_mem1.Name, false))
			{
				_Botting.C_CheckBox_TL_mem1 = Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null));
			}
			else if (Operators.ConditionalCompareObjectEqual(left, CheckBox_TL_mem2.Name, false))
			{
				_Botting.C_CheckBox_TL_mem2 = Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null));
			}
			else if (Operators.ConditionalCompareObjectEqual(left, CheckBox_TL_mem3.Name, false))
			{
				_Botting.C_CheckBox_TL_mem3 = Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null));
			}
			else if (Operators.ConditionalCompareObjectEqual(left, CheckBox_TL_mem4.Name, false))
			{
				_Botting.C_CheckBox_TL_mem4 = Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null));
			}
			else if (Operators.ConditionalCompareObjectEqual(left, CheckBox_TL_pet1.Name, false))
			{
				_Botting.C_CheckBox_TL_pet1 = Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null));
			}
			else if (Operators.ConditionalCompareObjectEqual(left, CheckBox_TL_pet2.Name, false))
			{
				_Botting.C_CheckBox_TL_pet2 = Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null));
			}
			else if (Operators.ConditionalCompareObjectEqual(left, CheckBox_AutoCreatCharacter.Name, false))
			{
				_Botting.C_CheckBox_AutoCreatCharacter = Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null));
			}
			else if (Operators.ConditionalCompareObjectEqual(left, CheckBox_OpenMachine.Name, false))
			{
				_Botting.C_CheckBox_OpenMachine = Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null));
				switch (CheckBox_OpenMachine.Checked)
				{
				case true:
					_Botting.OpenMachineBox();
					break;
				case false:
					_Botting.StopMachineBox();
					break;
				}
			}
			else if (Operators.ConditionalCompareObjectEqual(left, RadioButton_dia.Name, false))
			{
				_Botting.C_RadioButton_dia = Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null));
			}
			else if (Operators.ConditionalCompareObjectEqual(left, RadioButton_thuy.Name, false))
			{
				_Botting.C_RadioButton_thuy = Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null));
			}
			else if (Operators.ConditionalCompareObjectEqual(left, RadioButton_hoa.Name, false))
			{
				_Botting.C_RadioButton_hoa = Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null));
			}
			else if (Operators.ConditionalCompareObjectEqual(left, RadioButton_phong.Name, false))
			{
				_Botting.C_RadioButton_phong = Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null));
			}
			else if (Operators.ConditionalCompareObjectEqual(left, CheckBox_Autosort.Name, false))
			{
				_Botting.C_CheckBox_Autosort = Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null));
			}
			else if (Operators.ConditionalCompareObjectEqual(left, CheckBox_DCFullHomDo.Name, false))
			{
				_Botting.C_CheckBox_DCFullHomdo = Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null));
			}
		}

		private void Button_bot_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(Button_bot.Text, "Bắt đầu", false) == 0)
			{
				Button_bot.Text = "Dừng";
				_Botting.bott = 1;
				if (_Botting.logined == 1)
				{
					_Botting._StartBot();
				}
				return;
			}
			_Botting.bott = 2;
			if (_bot.Battle == 0)
			{
				_bot.ClickNPCId(99);
			}
			Button_bot.Text = "Bắt đầu";
			ComboBox_botname.Enabled = true;
			Button_bot.Enabled = true;
		}

	}
}
