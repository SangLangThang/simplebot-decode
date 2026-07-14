using System;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Simple_Bot
{
	public partial class frmClient : Form
	{
		private void Timer_QC_Tick(object sender, EventArgs e)
		{
			Timer_QC.Interval = Convert.ToInt32(NumericUpDown_sendpacket.Value);
			try
			{
				if (_bot != null && _bot._Proxy && (CheckBox_QC.Checked & (TextBox_idQC.Text.Length > 0)))
				{
					int num = Conversions.ToInteger(TextBox_idQC.Text);
					byte[] array = API.hexstringtobyte(Conversions.ToInteger(TextBox_idQC.Text).ToString("X12"));
					byte[] bytes = new byte[6]
					{
						array[5],
						array[4],
						array[3],
						array[2],
						array[1],
						array[0]
					};
					_bot.SendPacket(API.hexstringtobyte("F44409000B0204" + API.bytestohexstring(bytes)));
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

		public void LoadLanguage()
		{
			ComboBox_kenh.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "ComboBox_kenh", "");
			TabPage3.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "TabPage3", "");
			CheckBox_Pet_ChangeTG.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "CheckBox_Pet_ChangeTG", "");
			CheckBox_Char_ChangeTG.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "CheckBox_Char_ChangeTG", "");
			CheckBox_LeaderDissNotEnough.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "CheckBox_LeaderDissNotEnough", "");
			GroupBox8.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "GroupBox8", "");
			CheckBox_AutoClickNPC.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "CheckBox_AutoClickNPC", "");
			Label53.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "Label53", "");
			Label52.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "Label52", "");
			Label47.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "Label47", "");
			Label48.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "Label48", "");
			CheckBox_AutoRevival.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "CheckBox_AutoRevival", "");
			CheckBox_AutoFlee_Party.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "CheckBox_AutoFlee_Party", "");
			CheckBox_AutoFlee_Sp.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "CheckBox_AutoFlee_Sp", "");
			Label62.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "Label62", "");
			Label54.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "Label54", "");
			Label49.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "Label49", "");
			Label50.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "Label50", "");
			Button_StartAutoQuest.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "Button_StartAutoQuest", "");
			Button_warp.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "Button_warp", "");
			Label_PlayerCount.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "Label_PlayerCount", "");
			TabPage7.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "TabPage7", "");
			GroupBox_disconnect.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "GroupBox_disconnect", "");
			CheckBox_DisExp.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "CheckBox_DisExp", "");
			RadioButton_DCmemout.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "RadioButton_DCmemout", "");
			RadioButton_DCLeaderOut.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "RadioButton_DCLeaderOut", "");
			CheckBox_DCAfter1MinNoBattle.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "CheckBox_DCAfter1MinNoBattle", "");
			GroupBox9.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "GroupBox9", "");
			Label79.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "Label79", "");
			Label13.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "Label13", "");
			Label77.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "Label77", "");
			GroupBox_Basic.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "GroupBox_Basic", "");
			CheckBox_AutoUsePT.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "CheckBox_AutoUsePT", "");
			CheckBox_AutoEquitExp.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "CheckBox_AutoEquitExp", "");
			CheckBox_CatPet.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "CheckBox_CatPet", "");
			RadioButton_MemberRequestParty.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "RadioButton_MemberRequestParty", "");
			RadioButton_LeaderRequestParty.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "RadioButton_LeaderRequestParty", "");
			CheckBox_ClearGhost.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "CheckBox_ClearGhost", "");
			TabPage8.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "TabPage8", "");
			GroupBox3.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "GroupBox3", "");
			Label25.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "Label25", "");
			Label33.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "Label33", "");
			CheckBox_TL_mem1.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "CheckBox_TL_mem1", "");
			Label32.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "Label32", "");
			CheckBox_TL_mem2.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "CheckBox_TL_mem2", "");
			Label36.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "Label36", "");
			CheckBox_TL_mem3.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "CheckBox_TL_mem3", "");
			CheckBox_TL_pet2.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "CheckBox_TL_pet2", "");
			CheckBox_TL_pet1.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "CheckBox_TL_pet1", "");
			CheckBox_TL_mem4.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "CheckBox_TL_mem4", "");
			GroupBox2.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "GroupBox2", "");
			CheckBox_AutoEat.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "CheckBox_AutoEat", "");
			Label45.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "Label45", "");
			Label46.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "Label46", "");
			Label7.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "Label7", "");
			Label5.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "Label5", "");
			TabPage2.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "TabPage2", "");
			TabPage11.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "TabPage11", "");
			GroupBox5.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "GroupBox5", "");
			CheckBox_DropMineWood.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "CheckBox_DropMineWood", "");
			Button_AddIdDrop.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "Button_AddIdDrop", "");
			TabPage12.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "TabPage12", "");
			GroupBox6.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "GroupBox6", "");
			CheckBox_ContributeMineWood.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "CheckBox_ContributeMineWood", "");
			Button_AddIdContribute.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "Button_AddIdContribute", "");
			TabPage1.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "TabPage1", "");
			GroupBox7.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "GroupBox7", "");
			Label75.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "Label75", "");
			CheckBox_SendMineWood.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "CheckBox_SendMineWood", "");
			Button_AddIdSend.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "Button_AddIdSend", "");
			TabPage5.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "TabPage5", "");
			GroupBox10.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "GroupBox10", "");
			CheckBox_SellMineWood.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "CheckBox_SellMineWood", "");
			Button_AddIdSell.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "Button_AddIdSell", "");
			GroupBox4.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "GroupBox4", "");
			CheckBox_AutoPickup.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "CheckBox_AutoPickup", "");
			GroupBox11.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "GroupBox11", "");
			Label86.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "Label86", "");
			Label87.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "Label87", "");
			Label90.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "Label90", "");
			Label91.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "Label91", "");
			CheckBox_OpenMachine.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "CheckBox_OpenMachine", "");
			Label8.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "Label8", "");
			Label_BDY.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "Label_BDY", "");
			Label4.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "Label4", "");
			GroupBox_Bot.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "GroupBox_Bot", "");
			CheckBox_QuestProtect.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "CheckBox_QuestProtect", "");
			CheckBox_autosell.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "CheckBox_autosell", "");
			CheckBox_TuLenNgua.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "CheckBox_TuLenNgua", "");
			Button_bot.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "Button_bot", "");
			Label51.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "Label51", "");
			CheckBox_Bee.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "CheckBox_Bee", "");
			Button_warp2.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "Button_warp2", "");
			Button_walk.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "Button_walk", "");
			GroupBox_team.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "GroupBox_team", "");
			Button_OutParty.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "Button_OutParty", "");
			Button_InviteParty.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "Button_InviteParty", "");
			Button_RequestParty.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "Button_RequestParty", "");
			StatusBar1.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "StatusBar1", "");
			CheckBox_Reconnect.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "CheckBox_Reconnect", "");
			Button_BattleInfo.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "Button_BattleInfo", "");
			CheckBox_Autosort.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "CheckBox_Autosort", "");
			CheckBox_DCFullHomDo.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Language", "CheckBox_DCFullHomDo", "");
		}

	}
}
