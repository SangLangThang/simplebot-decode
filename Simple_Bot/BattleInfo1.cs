using System;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Simple_Bot.SPB;

namespace Simple_Bot
{
	public partial class BattleInfo1 : Form
	{
		private _ClientBot _clientBot;

		private int _lastRtbBattleId;

		// Set on open/close but never read anywhere; kept as-is from the original decompiled source.
		private int _unused;

		public BattleInfo1(ref _ClientBot bot)
		{
			base.Load += BattleInfo_Load;
			base.Closed += BattleInfo_close;
			_lastRtbBattleId = 0;
			_unused = 0;
			InitializeComponent();
			_clientBot = bot;
			_clientBot._BattleInfo_Update = 1;
		}

		public void updatebattle()
		{
			if (_lastRtbBattleId >= _clientBot._id_rtbBattle)
			{
				return;
			}
			checked
			{
				int num = _lastRtbBattleId + 1;
				int id_rtbBattle = _clientBot._id_rtbBattle;
				for (int i = num; i <= id_rtbBattle; i++)
				{
					if (_clientBot.RtbBattle.ContainsKey(i))
					{
						_Data._InfoText infoText = _clientBot.RtbBattle[i];
						_lastRtbBattleId = i;
						API.AddColorText(Rtb_Battle, infoText._Text, infoText._Color);
					}
				}
			}
		}

		public void BattleInfo_Load(object sender, EventArgs e)
		{
			Text = "Thông tin trận đấu của -- " + _clientBot.idlogin;
		}

		public void BattleInfo_close(object sender, EventArgs e)
		{
			_unused = 0;
			if (_clientBot != null)
			{
				_clientBot._BattleInfo_Update = 1;
			}
			if (_clientBot != null)
			{
				_clientBot.battle_show = 0;
			}
		}

		private string GetItemName(int itemId)
		{
			string result = "";
			if (Items.Data_Items.ContainsKey(itemId))
			{
				result = Items.Data_Items[itemId]._Name;
			}
			return result;
		}

		private void Timer1_Tick(object sender, EventArgs e)
		{
			if (_clientBot != null)
			{
				updatebattle();
			}
		}

		private void Timer2_Tick(object sender, EventArgs e)
		{
			try
			{
				if (_clientBot != null)
				{
					if (_clientBot.Deleted == 1)
					{
						Close();
					}
					if (Operators.CompareString(StatusBarPanel_BattleCount.Text, _clientBot.battlecount.ToString(), false) != 0)
					{
						StatusBarPanel_BattleCount.Text = _clientBot.battlecount.ToString();
					}
					if (Operators.CompareString(StatusBarPanel_botreset.Text, _clientBot.StatusBarPanel_botreset.ToString(), false) != 0)
					{
						StatusBarPanel_botreset.Text = _clientBot.StatusBarPanel_botreset.ToString();
					}
					if (Operators.CompareString(StatusBarPanel_checkbot.Text, _clientBot.StatusBarPanel_checkbot.ToString(), false) != 0)
					{
						StatusBarPanel_checkbot.Text = _clientBot.StatusBarPanel_checkbot.ToString();
					}
					if (Operators.CompareString(StatusBarPanel_CharExp.Text, _clientBot._BattleInfo_ExpChar.ToString(), false) != 0)
					{
						StatusBarPanel_CharExp.Text = _clientBot._BattleInfo_ExpChar.ToString();
					}
					if (Operators.CompareString(StatusBarPanel_PetExp.Text, _clientBot._BattleInfo_ExpPet.ToString(), false) != 0)
					{
						StatusBarPanel_PetExp.Text = _clientBot._BattleInfo_ExpPet.ToString();
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			checked
			{
				try
				{
					int num = 1;
					do
					{
						_Data._Battleinfo battleinfo = _clientBot.Data_Battles[num];
						Control control = base.Controls["Panel_BattleEnemy"].Controls["Label_Name" + num];
						Control control2 = base.Controls["Panel_BattleEnemy"].Controls["PictureBox" + num];
						if (Operators.CompareString(control.Text, battleinfo._Name, false) != 0)
						{
							control.Text = battleinfo._Name;
							control.ForeColor = battleinfo._Color;
							switch (battleinfo._Type)
							{
							case 3:
							case 7:
								if (Npcs.Data_Npcs.ContainsKey(battleinfo._Id))
								{
									Npcs.NpcInfo npc2 = Npcs.Data_Npcs[battleinfo._Id];
									control2.BackgroundImage = GetPicture._GetPhoto(npc2);
									control2.BackgroundImageLayout = ImageLayout.Zoom;
									string text = "Tên : " + battleinfo._Name + "\r\nCấp : " + Conversions.ToString(battleinfo._Lv) + "\r\nThuộc tính : " + API.GetThuocTinh(battleinfo._ThuocTinh) + "\r\nInt : " + Conversions.ToString(npc2._Int) + "\r\nAtk : " + Conversions.ToString(npc2._Atk) + "\r\nDef : " + Conversions.ToString(npc2._Def) + "\r\nAgi : " + Conversions.ToString(npc2._Agi) + "\r\nVật phẩm rớt : ";
									if (npc2._Item1 > 0)
									{
										text = text + "\r\n- " + GetItemName(npc2._Item1);
									}
									if (npc2._Item2 > 0)
									{
										text = text + "\r\n- " + GetItemName(npc2._Item2);
									}
									if (npc2._Item3 > 0)
									{
										text = text + "\r\n- " + GetItemName(npc2._Item3);
									}
									if (npc2._Item4 > 0)
									{
										text = text + "\r\n- " + GetItemName(npc2._Item4);
									}
									if (npc2._Item5 > 0)
									{
										text = text + "\r\n- " + GetItemName(npc2._Item5);
									}
									if (npc2._Item6 > 0)
									{
										text = text + "\r\n- " + GetItemName(npc2._Item6);
									}
									if (battleinfo._Id > 0)
									{
										ToolTip_info.SetToolTip(control, text);
										ToolTip_info.SetToolTip(control2, text);
									}
									else
									{
										ToolTip_info.SetToolTip(control, "");
										ToolTip_info.SetToolTip(control2, "");
									}
								}
								else
								{
									control2.BackgroundImage = null;
									if (battleinfo._Id > 0)
									{
										ToolTip_info.SetToolTip(control, "Tên : " + battleinfo._Name + "\r\nCấp : " + Conversions.ToString(battleinfo._Lv));
									}
									else
									{
										ToolTip_info.SetToolTip(control, "");
									}
								}
								break;
							case 4:
								if (Npcs.Data_Npcs.ContainsKey(battleinfo._Id))
								{
									Npcs.NpcInfo npc = Npcs.Data_Npcs[battleinfo._Id];
									control2.BackgroundImage = GetPicture._GetPhoto(npc);
									control2.BackgroundImageLayout = ImageLayout.Zoom;
								}
								else
								{
									control2.BackgroundImage = null;
								}
								break;
							default:
								control2.BackgroundImage = null;
								if (battleinfo._Id > 0)
								{
									ToolTip_info.SetToolTip(control, "Tên : " + battleinfo._Name + "\r\nCấp : " + Conversions.ToString(battleinfo._Lv));
									ToolTip_info.SetToolTip(control2, "Tên : " + battleinfo._Name + "\r\nCấp : " + Conversions.ToString(battleinfo._Lv));
								}
								else
								{
									ToolTip_info.SetToolTip(control, "");
									ToolTip_info.SetToolTip(control2, "");
								}
								break;
							}
						}
						ProgressBarEx progressBarEx = (ProgressBarEx)base.Controls["Panel_BattleEnemy"].Controls["ProgressBarEx_HP" + num];
						if (progressBarEx.Value != battleinfo._Hp)
						{
							progressBarEx.Value = battleinfo._Hp;
						}
						if (progressBarEx.Maximum != battleinfo._HpMax)
						{
							progressBarEx.Maximum = battleinfo._HpMax;
						}
						ProgressBarEx progressBarEx2 = (ProgressBarEx)base.Controls["Panel_BattleEnemy"].Controls["ProgressBarEx_Sp" + num];
						if (progressBarEx2.Value != battleinfo._Sp)
						{
							progressBarEx2.Value = battleinfo._Sp;
						}
						if (progressBarEx2.Maximum != battleinfo._SpMax)
						{
							progressBarEx2.Maximum = battleinfo._SpMax;
						}
						num++;
					}
					while (num <= 10);
					int num2 = 11;
					do
					{
						_Data._Battleinfo battleinfo2 = _clientBot.Data_Battles[num2];
						Control control3 = base.Controls["Panel_BattleTeam"].Controls["Label_Name" + num2];
						Control control4 = base.Controls["Panel_BattleTeam"].Controls["PictureBox" + num2];
						if (Operators.CompareString(control3.Text, battleinfo2._Name, false) != 0)
						{
							control3.Text = battleinfo2._Name;
							control3.ForeColor = battleinfo2._Color;
							int type = battleinfo2._Type;
							if (type == 4)
							{
								if (Npcs.Data_Npcs.ContainsKey(battleinfo2._Id))
								{
									Npcs.NpcInfo npc3 = Npcs.Data_Npcs[battleinfo2._Id];
									control4.BackgroundImage = GetPicture._GetPhoto(npc3);
									control4.BackgroundImageLayout = ImageLayout.Zoom;
								}
								else
								{
									control4.BackgroundImage = null;
								}
							}
						}
						ProgressBarEx progressBarEx3 = (ProgressBarEx)base.Controls["Panel_BattleTeam"].Controls["ProgressBarEx_HP" + num2];
						if (progressBarEx3.Value != battleinfo2._Hp)
						{
							progressBarEx3.Value = battleinfo2._Hp;
						}
						if (progressBarEx3.Maximum != battleinfo2._HpMax)
						{
							progressBarEx3.Maximum = battleinfo2._HpMax;
						}
						ProgressBarEx progressBarEx4 = (ProgressBarEx)base.Controls["Panel_BattleTeam"].Controls["ProgressBarEx_Sp" + num2];
						if (progressBarEx4.Value != battleinfo2._Sp)
						{
							progressBarEx4.Value = battleinfo2._Sp;
						}
						if (progressBarEx4.Maximum != battleinfo2._SpMax)
						{
							progressBarEx4.Maximum = battleinfo2._SpMax;
						}
						num2++;
					}
					while (num2 <= 20);
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
