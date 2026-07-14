using System;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Simple_Bot
{
	public partial class frmClient : Form
	{
		public void SkillSelected(int _idskill, ComboBoxIcon sender)
		{
			string name = sender.Name;
			if (Operators.CompareString(name, ComboBox_CharSkill.Name, false) == 0)
			{
				if (List_skill_char.ContainsKey(_idskill))
				{
					sender.SelectedItem = List_skill_char[_idskill];
				}
				else
				{
					sender.SelectedItem = List_skill_char[10000];
				}
			}
			else if (Operators.CompareString(name, ComboBox_PetSkill.Name, false) == 0)
			{
				if (List_skill_pet.ContainsKey(_idskill))
				{
					sender.SelectedItem = List_skill_pet[_idskill];
				}
				else
				{
					sender.SelectedItem = List_skill_pet[10000];
				}
			}
		}

		public void Char_AddSkillToList(int id)
		{
			if (Skills.Data_Skills.ContainsKey(id))
			{
				Skills._Skill skill = Skills.Data_Skills[id];
				ComboBoxItem comboBoxItem = new ComboBoxItem
				{
					Text = skill._Name,
					Value = skill._Id,
					ImageKey = skill._Id.ToString()
				};
				ComboBox_CharSkill.Items.Add(comboBoxItem);
				List_skill_char.Add(skill._Id, comboBoxItem);
			}
			else
			{
				ComboBoxItem value = new ComboBoxItem
				{
					Text = "",
					Value = 0,
					ImageKey = "0"
				};
				List_skill_char.Add(id, value);
			}
		}

		public void Pet_AddSkillToList(int id)
		{
			if (Skills.Data_Skills.ContainsKey(id))
			{
				Skills._Skill skill = Skills.Data_Skills[id];
				ComboBoxItem comboBoxItem = new ComboBoxItem
				{
					Text = skill._Name,
					Value = skill._Id,
					ImageKey = skill._Id.ToString()
				};
				ComboBox_PetSkill.Items.Add(comboBoxItem);
				List_skill_pet.Add(skill._Id, comboBoxItem);
			}
			else
			{
				ComboBoxItem value = new ComboBoxItem
				{
					Text = "",
					Value = 0,
					ImageKey = "0"
				};
				List_skill_pet.Add(id, value);
			}
		}


		private void ComboBox_CharSkill_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Conversions.ToInteger(ComboBox_CharTurnSetting.SelectedItem) > 0)
			{
				_bot.set__CharAttackSetting("Char_Skill" + Conversions.ToInteger(ComboBox_CharTurnSetting.SelectedItem), (object)GetSkillIdByName(ComboBox_CharSkill.Text));
			}
		}

		private void ComboBox_CharLocation_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Conversions.ToInteger(ComboBox_CharTurnSetting.SelectedItem) > 0)
			{
				_bot.set__CharAttackSetting("Char_Location" + Conversions.ToInteger(ComboBox_CharTurnSetting.SelectedItem), (object)ComboBox_CharLocation.Text);
			}
		}

		private void ComboBox_PetSkill_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Conversions.ToInteger(ComboBox_PetTurnSetting.SelectedItem) > 0)
			{
				_bot.set__PetAttackSetting("Pet_Skill" + Conversions.ToInteger(ComboBox_PetTurnSetting.SelectedItem), (object)GetSkillIdByName(ComboBox_PetSkill.Text));
			}
		}

		private void ComboBox_PetLocation_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Conversions.ToInteger(ComboBox_PetTurnSetting.SelectedItem) > 0)
			{
				_bot.set__PetAttackSetting("Pet_Location" + Conversions.ToInteger(ComboBox_PetTurnSetting.SelectedItem), (object)ComboBox_PetLocation.Text);
			}
		}

		private void Button_CharTurn_Click(object sender, EventArgs e)
		{
			int num = _bot.Data_CharAttackSetting._TurnCount;
			checked
			{
				if (sender == Button_CharTurnAdd)
				{
					if (num < 10)
					{
						_bot.Data_CharAttackSetting._TurnCount++;
						num++;
					}
					ComboBox_CharTurnSetting.Items.Add(num);
				}
				else
				{
					if (sender != Button_CharTurnRemove)
					{
						return;
					}
					switch (_bot._Proxy)
					{
					case false:
						if (num > 1)
						{
							_bot.Data_CharAttackSetting._TurnCount--;
							num--;
						}
						break;
					case true:
						if (num >= 1)
						{
							_bot.Data_CharAttackSetting._TurnCount--;
							num--;
						}
						break;
					}
					ComboBox_CharTurnSetting.Items.Remove(num + 1);
				}
			}
		}

		private void ComboBox_CharTurnSetting_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				if (Conversions.ToInteger(ComboBox_CharTurnSetting.SelectedItem) > 0)
				{
					string text = GetSkillName(Conversions.ToInteger(_bot.get__CharAttackSetting("Char_Skill" + ComboBox_CharTurnSetting.Text)));
					string text2 = _bot.get__CharAttackSetting("Char_Location" + ComboBox_CharTurnSetting.Text).ToString();
					if (ComboBox_CharSkill.Items.Contains(text))
					{
						ComboBox_CharSkill.SelectedItem = text;
					}
					else
					{
						ComboBox_CharSkill.SelectedItem = "Đấu vật";
					}
					ComboBox_CharLocation.Text = text2;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

		private void Button_PetTurn_Click(object sender, EventArgs e)
		{
			int num = _bot.Data_PetAttackSetting._TurnCount;
			checked
			{
				if (sender == Button_PetTurnAdd)
				{
					if (num < 10)
					{
						_bot.Data_PetAttackSetting._TurnCount++;
						num++;
					}
					ComboBox_PetTurnSetting.Items.Add(num);
				}
				else
				{
					if (sender != Button_PetTurnRemove)
					{
						return;
					}
					switch (_bot._Proxy)
					{
					case false:
						if (num > 1)
						{
							_bot.Data_PetAttackSetting._TurnCount--;
							num--;
						}
						break;
					case true:
						if (num >= 1)
						{
							_bot.Data_PetAttackSetting._TurnCount--;
							num--;
						}
						break;
					}
					ComboBox_PetTurnSetting.Items.Remove(num + 1);
				}
			}
		}

		private void ComboBox_PetTurnSetting_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				if (Conversions.ToInteger(ComboBox_PetTurnSetting.SelectedItem) > 0)
				{
					string text = GetSkillName(Conversions.ToInteger(_bot.get__PetAttackSetting("Pet_Skill" + ComboBox_PetTurnSetting.Text)));
					string text2 = _bot.get__PetAttackSetting("Pet_Location" + ComboBox_PetTurnSetting.Text).ToString();
					if (ComboBox_PetSkill.Items.Contains(text))
					{
						ComboBox_PetSkill.SelectedItem = text;
					}
					else
					{
						ComboBox_PetSkill.SelectedItem = "Đấu vật";
					}
					ComboBox_PetLocation.Text = text2;
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
