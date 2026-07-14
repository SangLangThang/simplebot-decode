using System;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Simple_Bot
{
	public partial class frmClient : Form
	{
		private void Vs2010TabControl_Main_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				if (_bot != null)
				{
					if (Operators.CompareString(Vs2010TabControl_Main.TabPages[Vs2010TabControl_Main.SelectedIndex].Name, "TabPage_Main", false) == 0)
					{
						updatesystem();
						updateChat();
					}
					if (Operators.CompareString(Vs2010TabControl_Main.TabPages[Vs2010TabControl_Main.SelectedIndex].Name, "TabPage_Quest", false) == 0)
					{
						updateQuest();
						ExecuteQuestStep();
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

		private void Button_BattleInfo_Click(object sender, EventArgs e)
		{
			if (_bot.battle_show == 0)
			{
				_bot.battle_show = 1;
				BattleInfo1 battleInfo = new BattleInfo1(ref _bot);
				battleInfo.Show();
			}
		}

		private void ComboBox_Port_SelectedIndexChanged(object sender, EventArgs e)
		{
			_bot.ComboBox_Port = Conversions.ToInteger(NewLateBinding.LateGet(ComboBox_Port.SelectedItem, null, "Substring", new object[1] { 5 }, null, null, null));
			if ((_bot.ComboBox_Port > 10) & (_bot.ComboBox_Port < 100))
			{
				ToolStripLabel1.Visible = true;
				ToolStripTextBox_KenhPassword.Visible = true;
			}
			else
			{
				ToolStripLabel1.Visible = false;
				ToolStripTextBox_KenhPassword.Visible = false;
			}
		}

		private void Timer_UpdateTabs_Tick(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					if (Operators.CompareString(Vs2010TabControl_Main.TabPages[Vs2010TabControl_Main.SelectedIndex].Name, "TabPage_Players", false) == 0)
					{
						ListPlayer listPlayer = new ListPlayer(_bot);
						listPlayer.TopLevel = false;
						listPlayer.FormBorderStyle = FormBorderStyle.None;
						listPlayer.Dock = DockStyle.Fill;
						listPlayer.Show();
						if (!Vs2010TabControl_Main.TabPages["TabPage_Players"].Controls.ContainsKey("ListPlayer"))
						{
							Vs2010TabControl_Main.SelectedTab.Controls.Add(listPlayer);
						}
						return;
					}
					if (Operators.CompareString(Vs2010TabControl_Main.TabPages[Vs2010TabControl_Main.SelectedIndex].Name, "TabPage_Shop", false) == 0)
					{
						ComboBox_ShopType.SelectedIndex = _bot.List_ShopType;
						TextBox_ShopName.Text = _bot.List_ShopName;
						if (_bot.List_ShopItem.Values.Count <= 0 || _bot.List_ShopItem.Values.Count == ListView_Shop.Items.Count)
						{
							return;
						}
						if (ListView_Shop.Items.Count > 0)
						{
							ListView_Shop.Items.Clear();
						}
						{
							foreach (Items.ShopItem value in _bot.List_ShopItem.Values)
							{
								int num = value._Id;
								string name = value._Name;
								int price = value._Price;
								ListViewItem listViewItem = ListView_Shop.Items.Add(Conversions.ToString(num));
								listViewItem.SubItems.Add(name);
								listViewItem.SubItems.Add(Conversions.ToString(price));
								ListView_Shop.Update();
							}
							return;
						}
					}
					if (Operators.CompareString(Vs2010TabControl_Main.TabPages[Vs2010TabControl_Main.SelectedIndex].Name, "TabPage_Attack", false) == 0 && _bot.logined == 1)
					{
						if (List_skill_char.Count != _bot.Data_CharListSkill.Count)
						{
							ComboBox_CharSkill.Items.Clear();
							List_skill_char.Clear();
							int num2 = _bot.Data_CharListSkill.Count - 1;
							for (int i = 0; i <= num2; i++)
							{
								Char_AddSkillToList(Conversions.ToInteger(_bot.Data_CharListSkill[i]));
							}
							ComboBox_CharTurnSetting.SelectedItem = 1;
							int idskill = Conversions.ToInteger(_bot.get__CharAttackSetting("Char_Skill1"));
							string text = GetSkillName(Conversions.ToInteger(_bot.get__CharAttackSetting("Char_Skill1")));
							string selectedValue = _bot.get__CharAttackSetting("Char_Location1").ToString();
							SkillSelected(idskill, ComboBox_CharSkill);
							ComboBox_CharLocation.SelectedValue = selectedValue;
						}
						if (List_skill_pet.Count != _bot.Data_PetListSkill.Count)
						{
							ComboBox_PetSkill.Items.Clear();
							List_skill_pet.Clear();
							int num3 = _bot.Data_PetListSkill.Count - 1;
							for (int j = 0; j <= num3; j++)
							{
								Pet_AddSkillToList(Conversions.ToInteger(_bot.Data_PetListSkill[j]));
							}
							ComboBox_PetTurnSetting.SelectedItem = 1;
							int idskill2 = Conversions.ToInteger(_bot.get__PetAttackSetting("Pet_Skill1"));
							string text2 = _bot.get__PetAttackSetting("Pet_Location1").ToString();
							SkillSelected(idskill2, ComboBox_PetSkill);
							ComboBox_PetLocation.Text = text2;
						}
					}
					if (Vs2010TabControl_Main.TabPages["TabPage_Players"].Controls.ContainsKey("ListPlayer"))
					{
						ListPlayer listPlayer2 = (ListPlayer)Vs2010TabControl_Main.TabPages["TabPage_Players"].Controls["ListPlayer"];
						listPlayer2.Close();
						Vs2010TabControl_Main.TabPages["TabPage_Players"].Controls.RemoveByKey("ListPlayer");
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

		private void ComboBox_nameprivate_TextChanged(object sender, EventArgs e)
		{
			if (_bot != null)
			{
				_bot.ComboBox_namePublic = ComboBox_nameprivate.Text;
			}
		}


		private void ToolStripTextBox_KenhPassword_TextChanged(object sender, EventArgs e)
		{
			_bot.ToolStripTextBox_KenhPassword = ToolStripTextBox_KenhPassword.Text;
		}

	}
}
