using System;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Simple_Bot
{
	public partial class _ClientBot
	{
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

	}
}
