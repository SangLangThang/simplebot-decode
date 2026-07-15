using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Simple_Bot.My.Resources;
using Simple_Bot.SPB;

namespace Simple_Bot
{
	public partial class frmClient : Form
	{
		public frmClient(_ClientBot _b)
		{
			base.Load += frmClient_Load;
			base.FormClosing += frmClient_FormClosing;
			Data_Trangbi_Char = new Dictionary<int, Trangbi_Info>();
			Data_Trangbi_Pet = new Dictionary<int, Trangbi_Info>();
			Data_Tuido = new Dictionary<int, Tuido_Info>();
			Data_Tuideo = new Dictionary<int, Tuideo_Info>();
			List_skill_char = new Dictionary<int, ComboBoxItem>();
			List_skill_pet = new Dictionary<int, ComboBoxItem>();
			tooltip_check = 0;
			_Tuideo_slot_select = 0;
			_Homdo_slot_select = 0;
			label_selected = new Label();
			r_Id_rtbsystem = 0;
			r_Id_rtbChat = 0;
			r_Id_rtbQuest = 0;
			_petSelect = 0;
			_list_Func = new List<string>(new string[9] { "warp", "warpid", "click", "menu", "end", "battle", "next", "catpet", "xuatchien" });
			_questSteps = new ArrayList();
			_questStepIndex = 0;
			InitializeComponent();
			_bot = _b;
			foreach (Skills._Skill value5 in Skills.Data_Skills.Values)
			{
				Bitmap image = GetPicture._GetPhoto_Skill(value5._Id);
				ImageList1.Images.Add(value5._Id.ToString(), image);
			}
			int country = API.Country;
			if (country == 1)
			{
				ComboBox_CharSkill.Items.Clear();
				List_skill_char.Clear();
				ComboBox_PetSkill.Items.Clear();
				List_skill_pet.Clear();
				foreach (Skills._Skill value6 in Skills.Data_Skills.Values)
				{
					ComboBox_CharSkill.Items.Add(value6._Name);
					ComboBox_PetSkill.Items.Add(value6._Name);
				}
				API.Language_Path = MyProject.Application.Info.DirectoryPath + "\\Country\\THAI.ini";
				LoadLanguage();
			}
			else
			{
				ComboBox_CharSkill.Items.Clear();
				List_skill_char.Clear();
				ComboBox_PetSkill.Items.Clear();
				List_skill_pet.Clear();
				foreach (Skills._Skill value7 in Skills.Data_Skills.Values)
				{
					Char_AddSkillToList(value7._Id);
					Pet_AddSkillToList(value7._Id);
				}
			}
			NewLateBinding.LateCall(TreeView1.Nodes, null, "Add", new object[1] { MyProject.Forms.MainForm.treeview1.Nodes[0].Clone() }, null, null, null, true);
			TreeView1.Refresh();
			TreeView1.Nodes[0].Expand();
			DataSet1.Tables["Table_Setting"].Rows.Add();
			int num = 1;
			checked
			{
				do
				{
					DataSet1.Tables["Table_Battle" + num].Rows.Add();
					num++;
				}
				while (num <= 20);
				int num2 = 1;
				do
				{
					DataSet1.Tables["Table_Tuido"].Rows.Add(num2);
					DataSet1.Tables["Table_Tuideo"].Rows.Add(num2);
					num2++;
				}
				while (num2 <= 25);
				int num3 = 1;
				do
				{
					DataSet1.Tables["Table_ItemOnMap"].Rows.Add();
					num3++;
				}
				while (num3 <= 255);
				DataSet1.Tables["Table_database"].Rows.Add(0);
				DataSet1.Tables["Table_databasepet"].Rows.Add(0);
				DataSet1.Tables["Table_CharEquit"].Rows.Add(0);
				DataSet1.Tables["Table_CharEquit"].Rows.Add(0);
				DataSet1.Tables["Table_CharEquit"].Rows.Add(0);
				DataSet1.Tables["Table_CharEquit"].Rows.Add(0);
				DataSet1.Tables["Table_CharEquit"].Rows.Add(0);
				DataSet1.Tables["Table_CharEquit"].Rows.Add(0);
				DataSet1.Tables["Table_PetEquit"].Rows.Add(0);
				DataSet1.Tables["Table_PetEquit"].Rows.Add(0);
				DataSet1.Tables["Table_PetEquit"].Rows.Add(0);
				DataSet1.Tables["Table_PetEquit"].Rows.Add(0);
				DataSet1.Tables["Table_PetEquit"].Rows.Add(0);
				DataSet1.Tables["Table_PetEquit"].Rows.Add(0);
				DataSet1.Tables["Table_pet1"].Rows.Add(0);
				DataSet1.Tables["Table_pet2"].Rows.Add(0);
				DataSet1.Tables["Table_pet3"].Rows.Add(0);
				DataSet1.Tables["Table_pet4"].Rows.Add(0);
				DataSet1.Tables["Table_petbattle"].Rows.Add(0);
				ListView_monster.ListViewItemSorter = new clsListviewSorter(4, SortOrder.Ascending);
				ComboBox_Server.Items.Clear();
				string text = "server.ini";
				if (File.Exists(text))
				{
					string[] array = MyProject.Computer.FileSystem.ReadAllText(text).Split('\r');
					foreach (string text2 in array)
					{
						string[] array2 = text2.Split('*');
						ComboBox_Server.Items.Add(array2[0]);
					}
				}
				else
				{
					Interaction.MsgBox("File server.ini không tồn tại");
				}
				foreach (int key in Ground.Data_Warps.Keys)
				{
					ComboBox_Mini_Warp.Items.Add(Conversions.ToString(Ground.Data_Warps[key]) + "  " + MapNames.Data_MapNames[Ground.Data_Warps[key]]);
				}
				int num4 = 0;
				do
				{
					Trangbi_Info value = new Trangbi_Info
					{
						_stt = num4,
						_id = 0
					};
					switch (num4)
					{
					case 0:
						value._photo = PictureBox_char1;
						break;
					case 1:
						value._photo = PictureBox_char2;
						break;
					case 2:
						value._photo = PictureBox_char3;
						break;
					case 3:
						value._photo = PictureBox_char4;
						break;
					case 4:
						value._photo = PictureBox_char5;
						break;
					case 5:
						value._photo = PictureBox_char6;
						break;
					}
					value._photo.Tag = num4;
					value._photo.MouseMove += PictureBox_CharEquit_MouseMove;
					value._photo.MouseLeave += Label_MouseLeave;
					value._photo.MouseClick += PictureBox_CharEquit_MouseClick_Unequip;
					Data_Trangbi_Char.Add(num4, value);
					num4++;
				}
				while (num4 <= 5);
				int num5 = 0;
				do
				{
					Trangbi_Info value2 = new Trangbi_Info
					{
						_stt = num5,
						_id = 0
					};
					switch (num5)
					{
					case 0:
						value2._photo = PictureBox_Pet1;
						break;
					case 1:
						value2._photo = PictureBox_Pet2;
						break;
					case 2:
						value2._photo = PictureBox_Pet3;
						break;
					case 3:
						value2._photo = PictureBox_Pet4;
						break;
					case 4:
						value2._photo = PictureBox_Pet5;
						break;
					case 5:
						value2._photo = PictureBox_Pet6;
						break;
					}
					value2._photo.Tag = num5;
					value2._photo.MouseMove += PictureBox_PetEquit_MouseMove;
					value2._photo.MouseLeave += Label_MouseLeave;
					value2._photo.MouseClick += PictureBox_PetEquit_MouseClick_Unequip;
					Data_Trangbi_Pet.Add(num5, value2);
					num5++;
				}
				while (num5 <= 5);
				int num6 = 1;
				do
				{
					Tuido_Info value3 = new Tuido_Info
					{
						_stt = num6,
						_id = 0,
						_count = 0
					};
					switch (num6)
					{
					case 1:
						value3._photo = Lb_tuido1;
						break;
					case 2:
						value3._photo = Lb_tuido2;
						break;
					case 3:
						value3._photo = Lb_tuido3;
						break;
					case 4:
						value3._photo = Lb_tuido4;
						break;
					case 5:
						value3._photo = Lb_tuido5;
						break;
					case 6:
						value3._photo = Lb_tuido6;
						break;
					case 7:
						value3._photo = Lb_tuido7;
						break;
					case 8:
						value3._photo = Lb_tuido8;
						break;
					case 9:
						value3._photo = Lb_tuido9;
						break;
					case 10:
						value3._photo = Lb_tuido10;
						break;
					case 11:
						value3._photo = Lb_tuido11;
						break;
					case 12:
						value3._photo = Lb_tuido12;
						break;
					case 13:
						value3._photo = Lb_tuido13;
						break;
					case 14:
						value3._photo = Lb_tuido14;
						break;
					case 15:
						value3._photo = Lb_tuido15;
						break;
					case 16:
						value3._photo = Lb_tuido16;
						break;
					case 17:
						value3._photo = Lb_tuido17;
						break;
					case 18:
						value3._photo = Lb_tuido18;
						break;
					case 19:
						value3._photo = Lb_tuido19;
						break;
					case 20:
						value3._photo = Lb_tuido20;
						break;
					case 21:
						value3._photo = Lb_tuido21;
						break;
					case 22:
						value3._photo = Lb_tuido22;
						break;
					case 23:
						value3._photo = Lb_tuido23;
						break;
					case 24:
						value3._photo = Lb_tuido24;
						break;
					case 25:
						value3._photo = Lb_tuido25;
						break;
					}
					value3._photo.Tag = num6;
					value3._photo.Size = new Size(35, 35);
					value3._photo.Location = new Point(value3._photo.Location.X - 2, value3._photo.Location.Y);
					value3._photo.ImageAlign = ContentAlignment.BottomLeft;
					value3._photo.Text = "";
					value3._photo.MouseClick += Label_Tuido_MouseClick;
					value3._photo.MouseMove += Label_Tuido_MouseMove;
					value3._photo.MouseLeave += Label_MouseLeave;
					value3._photo.MouseDown += Label_Tuido_MouseDown_SelectOrDrag;
					value3._photo.MouseUp += Label_Item_MouseUp_ResetCursor;
					value3._photo.DragDrop += Label_Tuido_DragDrop_MoveItem;
					value3._photo.DragEnter += Label_Tuido_DragEnter_AllowCopy;
					value3._photo.GiveFeedback += Label_Tuido_GiveFeedback_DragCursor;
					Data_Tuido.Add(num6, value3);
					num6++;
				}
				while (num6 <= 25);
				int num7 = 1;
				do
				{
					Tuideo_Info value4 = new Tuideo_Info
					{
						_stt = num7,
						_id = 0,
						_count = 0
					};
					switch (num7)
					{
					case 1:
						value4._photo = Lb_tuideo1;
						break;
					case 2:
						value4._photo = Lb_tuideo2;
						break;
					case 3:
						value4._photo = Lb_tuideo3;
						break;
					case 4:
						value4._photo = Lb_tuideo4;
						break;
					case 5:
						value4._photo = Lb_tuideo5;
						break;
					case 6:
						value4._photo = Lb_tuideo6;
						break;
					case 7:
						value4._photo = Lb_tuideo7;
						break;
					case 8:
						value4._photo = Lb_tuideo8;
						break;
					case 9:
						value4._photo = Lb_tuideo9;
						break;
					case 10:
						value4._photo = Lb_tuideo10;
						break;
					case 11:
						value4._photo = Lb_tuideo11;
						break;
					case 12:
						value4._photo = Lb_tuideo12;
						break;
					case 13:
						value4._photo = Lb_tuideo13;
						break;
					case 14:
						value4._photo = Lb_tuideo14;
						break;
					case 15:
						value4._photo = Lb_tuideo15;
						break;
					case 16:
						value4._photo = Lb_tuideo16;
						break;
					case 17:
						value4._photo = Lb_tuideo17;
						break;
					case 18:
						value4._photo = Lb_tuideo18;
						break;
					case 19:
						value4._photo = Lb_tuideo19;
						break;
					case 20:
						value4._photo = Lb_tuideo20;
						break;
					case 21:
						value4._photo = Lb_tuideo21;
						break;
					case 22:
						value4._photo = Lb_tuideo22;
						break;
					case 23:
						value4._photo = Lb_tuideo23;
						break;
					case 24:
						value4._photo = Lb_tuideo24;
						break;
					case 25:
						value4._photo = Lb_tuideo25;
						break;
					}
					value4._photo.Tag = num7;
					value4._photo.Size = new Size(35, 35);
					value4._photo.Location = new Point(value4._photo.Location.X - 2, value4._photo.Location.Y);
					value4._photo.ImageAlign = ContentAlignment.BottomLeft;
					value4._photo.Text = "";
					value4._photo.MouseDoubleClick += Label_Tuideo_MouseDoubleClick_Unequip;
					value4._photo.MouseMove += Label_Tuideo_MouseMove;
					value4._photo.MouseLeave += Label_MouseLeave;
					value4._photo.MouseDown += Label_Tuideo_MouseDown_Select;
					value4._photo.MouseUp += Label_Item_MouseUp_ResetCursor;
					Data_Tuideo.Add(num7, value4);
					num7++;
				}
				while (num7 <= 25);
				Bitmap bitmap = Resources.Arrow_L2;
				bitmap.MakeTransparent(Color.FromArgb(65280));
				PictureBox_Pet_back.BackgroundImage = bitmap;
				bitmap = Resources.Arrow_R2;
				bitmap.MakeTransparent(Color.FromArgb(65280));
				PictureBox_pet_next.BackgroundImage = bitmap;
				bitmap = Resources.arrow_upBig1;
				bitmap.MakeTransparent(Color.FromArgb(65280));
				PictureBox_char_add_int.BackgroundImage = bitmap;
				PictureBox_char_add_atk.BackgroundImage = bitmap;
				PictureBox_char_add_def.BackgroundImage = bitmap;
				PictureBox_char_add_hpx.BackgroundImage = bitmap;
				PictureBox_char_add_spx.BackgroundImage = bitmap;
				PictureBox_char_add_agi.BackgroundImage = bitmap;
			}
		}


		private void frmClient_Load(object sender, EventArgs e)
		{
			checked
			{
				if (!_bot._Proxy)
				{
					try
					{
						ComboBox_Port.SelectedItem = "Kênh " + _bot.ComboBox_Port;
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ProjectData.ClearProjectError();
					}
					ToolStripTextBox_KenhPassword.Text = _bot.ToolStripTextBox_KenhPassword;
					ComboBox_sex.SelectedIndex = 0;
					ComboBox_kenh.SelectedIndex = 1;
					Label_Mini.Text = "";
					TBId.Text = _bot.idlogin.ToString();
					TBPassword.Text = _bot.passlogin.ToString();
					TextBox_DelayBot.Text = _bot.TextBox_DelayBot.ToString();
					TextBox_IDmem1.Text = _bot.TextBox_IDmem1.ToString();
					TextBox_IDmem2.Text = _bot.TextBox_IDmem2.ToString();
					TextBox_IDmem3.Text = _bot.TextBox_IDmem3.ToString();
					TextBox_IDmem4.Text = _bot.TextBox_IDmem4.ToString();
					TextBox_IdLeader.Text = _bot.TextBox_IdLeader.ToString();
					TextBox_Eat_char_hp_value.Text = _bot.TextBox_Eat_char_hp_value.ToString();
					TextBox_Eat_char_sp_value.Text = _bot.TextBox_Eat_char_sp_value.ToString();
					TextBox_Eat_pet_hp_value.Text = _bot.TextBox_Eat_Pet_hp_value.ToString();
					TextBox_Eat_pet_sp_value.Text = _bot.TextBox_Eat_Pet_sp_value.ToString();
					TextBox_TL_pet_hp_value.Text = _bot.TextBox_TL_pet_hp_value.ToString();
					TextBox_TL_pet_sp_value.Text = _bot.TextBox_TL_pet_sp_value.ToString();
					TextBox_AutoSend.Text = _bot.TextBox_AutoSend.ToString();
					TextBox_Drop_HpValue.Text = _bot.TextBox_Drop_HpValue.ToString();
					TextBox_Drop_SpValue.Text = _bot.TextBox_Drop_SpValue.ToString();
					TextBox_Contribute_HpValue.Text = _bot.TextBox_Contribute_HpValue.ToString();
					TextBox_Contribute_SpValue.Text = _bot.TextBox_Contribute_SpValue.ToString();
					TextBox_Send_HpValue.Text = _bot.TextBox_Send_HpValue.ToString();
					TextBox_Send_SpValue.Text = _bot.TextBox_Send_SpValue.ToString();
					TextBox_Sell_HpValue.Text = _bot.TextBox_Sell_HpValue.ToString();
					TextBox_Sell_SpValue.Text = _bot.TextBox_Sell_SpValue.ToString();
					TextBox_OpenMachine_CharHp.Text = _bot.TextBox_OpenMachine_CharHp.ToString();
					TextBox_OpenMachine_CharSp.Text = _bot.TextBox_OpenMachine_CharSp.ToString();
					TextBox_OpenMachine_PetHp.Text = _bot.TextBox_OpenMachine_PetHp.ToString();
					TextBox_OpenMachine_PetSp.Text = _bot.TextBox_OpenMachine_PetSp.ToString();
					NumericUpDown_ItemCountPickup.Text = _bot.NumericUpDown_ItemCountPickup.ToString();
					TextBox_ValueSPFlee.Text = _bot.TextBox_ValueSPFlee.ToString();
					TextBox_ClickMOD.Text = _bot.TextBox_ClickMOD;
					TextBox_ClickMOD_Delay.Text = _bot.TextBox_ClickMOD_delay.ToString();
					if (_bot.Disconnected == 0)
					{
						btnLogin.Text = "Đăng xuất";
						ComboBox_Server.Enabled = false;
						ComboBox_Port.Enabled = false;
						TBId.Enabled = false;
						TBPassword.Enabled = false;
					}
					else
					{
						btnLogin.Text = "Đăng nhập";
						ComboBox_Server.Enabled = true;
						ComboBox_Port.Enabled = true;
						TBId.Enabled = true;
						TBPassword.Enabled = true;
					}
					if (_bot.bott == 1)
					{
						ComboBox_botname.Enabled = false;
						Button_bot.Enabled = false;
						Button_bot.Text = "Dừng";
					}
					else
					{
						ComboBox_botname.Enabled = true;
						Button_bot.Enabled = true;
						Button_bot.Text = "Bắt đầu";
					}
					CheckBox_Reconnect.Checked = _bot.C_CheckBox_Reconnect;
					CheckBox_QuestProtect.Checked = _bot.C_CheckBox_QuestProtect;
					CheckBox_autosell.Checked = _bot.C_CheckBox_autosell;
					CheckBox_TuLenNgua.Checked = _bot.C_CheckBox_TuLenNgua;
					CheckBox_Bee.Checked = _bot.C_CheckBox_Bee;
					CheckBox_AutoRevival.Checked = _bot.C_CheckBox_AutoRevival;
					CheckBox_LeaderDissNotEnough.Checked = _bot.C_CheckBox_LeaderDissNotEnough;
					CheckBox_Char_ChangeTG.Checked = _bot.C_CheckBox_Char_ChangeTG;
					CheckBox_AutoFlee_Sp.Checked = _bot.C_CheckBox_AutoFlee_Sp;
					CheckBox_AutoFlee_Party.Checked = _bot.C_CheckBox_AutoFlee_Party;
					CheckBox_Pet_ChangeTG.Checked = _bot.C_CheckBox_Pet_ChangeTG;
					CheckBox_AutoClickNPC.Checked = _bot.C_CheckBox_AutoClickNPC;
					CheckBox_AutoPickup.Checked = _bot.C_CheckBox_AutoPickup;
					CheckBox_DropHp.Checked = _bot.C_CheckBox_DropHp;
					CheckBox_DropSp.Checked = _bot.C_CheckBox_DropSp;
					CheckBox_DropHpSp.Checked = _bot.C_CheckBox_DropHpSp;
					CheckBox_DropMineWood.Checked = _bot.C_CheckBox_DropMineWood;
					CheckBox_ContributeHp.Checked = _bot.C_CheckBox_ContributeHp;
					CheckBox_ContributeSp.Checked = _bot.C_CheckBox_ContributeSp;
					CheckBox_ContributeHpSp.Checked = _bot.C_CheckBox_ContributeHpSp;
					CheckBox_ContributeMineWood.Checked = _bot.C_CheckBox_ContributeMineWood;
					CheckBox_SendHp.Checked = _bot.C_CheckBox_SendHp;
					CheckBox_SendSp.Checked = _bot.C_CheckBox_SendSp;
					CheckBox_SendHpSp.Checked = _bot.C_CheckBox_SendHpSp;
					CheckBox_SendMineWood.Checked = _bot.C_CheckBox_SendMineWood;
					CheckBox_SellHp.Checked = _bot.C_CheckBox_SellHp;
					CheckBox_SellSP.Checked = _bot.C_CheckBox_SellSP;
					CheckBox_SellHpSp.Checked = _bot.C_CheckBox_SellHpSp;
					CheckBox_SellMineWood.Checked = _bot.C_CheckBox_SellMineWood;
					CheckBox_Pickup.Checked = _bot.C_CheckBox_Pickup;
					RadioButton_QS1.Checked = _bot.C_RadioButton_QS1;
					RadioButton_QS2.Checked = _bot.C_RadioButton_QS2;
					RadioButton_QS3.Checked = _bot.C_RadioButton_QS3;
					RadioButton_QS4.Checked = _bot.C_RadioButton_QS4;
					CheckBox_CatPet.Checked = _bot.C_CheckBox_CatPet;
					CheckBox_ClearGhost.Checked = _bot.C_CheckBox_ClearGhost;
					CheckBox_AutoEquitExp.Checked = _bot.C_CheckBox_AutoEquitExp;
					CheckBox_AutoUsePT.Checked = _bot.C_CheckBox_AutoUsePT;
					RadioButton_LeaderRequestParty.Checked = _bot.C_RadioButton_LeaderRequestParty;
					RadioButton_MemberRequestParty.Checked = _bot.C_RadioButton_MemberRequestParty;
					RadioButton_PT_no.Checked = _bot.C_RadioButton_PT_no;
					CheckBox_DCAfter1MinNoBattle.Checked = _bot.C_CheckBox_DCAfter1MinNoBattle;
					CheckBox_DisExp.Checked = _bot.C_CheckBox_DisExp;
					RadioButton_DCLeaderOut.Checked = _bot.C_RadioButton_DCLeaderOut;
					RadioButton_DCmemout.Checked = _bot.C_RadioButton_DCmemout;
					RadioButton_DC_no.Checked = _bot.C_RadioButton_DC_no;
					CheckBox_AutoEat.Checked = _bot.C_CheckBox_AutoEat;
					CheckBox_TL_mem1.Checked = _bot.C_CheckBox_TL_mem1;
					CheckBox_TL_mem2.Checked = _bot.C_CheckBox_TL_mem2;
					CheckBox_TL_mem3.Checked = _bot.C_CheckBox_TL_mem3;
					CheckBox_TL_mem4.Checked = _bot.C_CheckBox_TL_mem4;
					CheckBox_TL_pet1.Checked = _bot.C_CheckBox_TL_pet1;
					CheckBox_TL_pet2.Checked = _bot.C_CheckBox_TL_pet2;
					CheckBox_AutoCreatCharacter.Checked = _bot.C_CheckBox_AutoCreatCharacter;
					CheckBox_OpenMachine.Checked = _bot.C_CheckBox_OpenMachine;
					RadioButton_dia.Checked = _bot.C_RadioButton_dia;
					RadioButton_thuy.Checked = _bot.C_RadioButton_thuy;
					RadioButton_hoa.Checked = _bot.C_RadioButton_hoa;
					RadioButton_phong.Checked = _bot.C_RadioButton_phong;
					CheckBox_Autosort.Checked = _bot.C_CheckBox_Autosort;
					CheckBox_DCFullHomDo.Checked = _bot.C_CheckBox_DCFullHomdo;
					int leaderId = _bot.Data_Player._LeaderId;
					if (leaderId == _bot.Data_Player._Id)
					{
						if ((_bot.TextBox_IDmem1 == _bot._IDmem1) & (_bot._IDmem1 > 0))
						{
							TextBox_IDmem1.BackColor = Color.LightGreen;
						}
						else
						{
							TextBox_IDmem1.BackColor = SystemColors.Window;
						}
						if ((_bot.TextBox_IDmem2 == _bot._IDmem2) & (_bot._IDmem2 > 0))
						{
							TextBox_IDmem2.BackColor = Color.LightGreen;
						}
						else
						{
							TextBox_IDmem2.BackColor = SystemColors.Window;
						}
						if ((_bot.TextBox_IDmem3 == _bot._IDmem3) & (_bot._IDmem3 > 0))
						{
							TextBox_IDmem3.BackColor = Color.LightGreen;
						}
						else
						{
							TextBox_IDmem3.BackColor = SystemColors.Window;
						}
						if ((_bot.TextBox_IDmem4 == _bot._IDmem4) & (_bot._IDmem4 > 0))
						{
							TextBox_IDmem4.BackColor = Color.LightGreen;
						}
						else
						{
							TextBox_IDmem4.BackColor = SystemColors.Window;
						}
					}
					else if ((_bot.TextBox_IdLeader == _bot.Data_Player._LeaderId) & (_bot.Data_Player._LeaderId > 0))
					{
						TextBox_IdLeader.BackColor = Color.LightGreen;
					}
					else
					{
						TextBox_IdLeader.BackColor = SystemColors.Window;
					}
					if (_bot.Data_ListDrop.Count > 0)
					{
						int num = _bot.Data_ListDrop.Count - 1;
						for (int i = 0; i <= num; i++)
						{
							int num2 = Conversions.ToInteger(_bot.Data_ListDrop[i]);
							ListView_AutoDrop.Items.Add(Conversions.ToString(num2)).SubItems.Add(GetItemName(num2));
						}
					}
					if (_bot.Data_ListContribute.Count > 0)
					{
						int num3 = _bot.Data_ListContribute.Count - 1;
						for (int j = 0; j <= num3; j++)
						{
							int num4 = Conversions.ToInteger(_bot.Data_ListContribute[j]);
							ListView_AutoContribute.Items.Add(Conversions.ToString(num4)).SubItems.Add(GetItemName(num4));
						}
					}
					if (_bot.Data_ListSend.Count > 0)
					{
						int num5 = _bot.Data_ListSend.Count - 1;
						for (int k = 0; k <= num5; k++)
						{
							int num6 = Conversions.ToInteger(_bot.Data_ListSend[k]);
							ListView_AutoSend.Items.Add(Conversions.ToString(num6)).SubItems.Add(GetItemName(num6));
						}
					}
					if (_bot.Data_ListSell.Count > 0)
					{
						int num7 = _bot.Data_ListSell.Count - 1;
						for (int l = 0; l <= num7; l++)
						{
							int num8 = Conversions.ToInteger(_bot.Data_ListSell[l]);
							ListView_AutoSell.Items.Add(Conversions.ToString(num8)).SubItems.Add(GetItemName(num8));
						}
					}
					try
					{
						string text = "server.ini";
						if (File.Exists(text))
						{
							string[] array = MyProject.Computer.FileSystem.ReadAllText(text).Split('\r');
							foreach (string text2 in array)
							{
								string[] array2 = text2.Split('*');
								if (Operators.CompareString(array2[1], _bot.ComboBox_Server, false) == 0)
								{
									if (!ComboBox_Server.Items.Contains(array2[0]))
									{
										ComboBox_Server.Items.Add(array2[0]);
									}
									ComboBox_Server.SelectedItem = array2[0];
									break;
								}
							}
						}
						else
						{
							Interaction.MsgBox("File server.ini không tồn tại");
						}
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception ex4 = ex3;
						ProjectData.ClearProjectError();
					}
					ComboBox_CharTurnSetting.Items.Clear();
					ComboBox_PetTurnSetting.Items.Clear();
					int turnCount = _bot.Data_CharAttackSetting._TurnCount;
					int num9 = turnCount;
					for (int n = 1; n <= num9; n++)
					{
						ComboBox_CharTurnSetting.Items.Add(n);
					}
					int turnCount2 = _bot.Data_PetAttackSetting._TurnCount;
					int num10 = turnCount2;
					for (int num11 = 1; num11 <= num10; num11++)
					{
						ComboBox_PetTurnSetting.Items.Add(num11);
					}
					if (_bot.logined == 1)
					{
						if (ComboBox_CharSkill.Items.Count != _bot.Data_CharListSkill.Count)
						{
							ComboBox_CharSkill.Items.Clear();
							List_skill_char.Clear();
							int num12 = _bot.Data_CharListSkill.Count - 1;
							for (int num13 = 0; num13 <= num12; num13++)
							{
								Char_AddSkillToList(Conversions.ToInteger(_bot.Data_CharListSkill[num13]));
							}
						}
						if (ComboBox_PetSkill.Items.Count != _bot.Data_PetListSkill.Count)
						{
							ComboBox_PetSkill.Items.Clear();
							List_skill_pet.Clear();
							int num14 = _bot.Data_PetListSkill.Count - 1;
							for (int num15 = 0; num15 <= num14; num15++)
							{
								Pet_AddSkillToList(Conversions.ToInteger(_bot.Data_PetListSkill[num15]));
							}
						}
						if (ListView_Quest.Items.Count > 0)
						{
							ListView_Quest.Items.Clear();
						}
						try
						{
							if (_bot.listquest_Done.Count > 0)
							{
								int num16 = _bot.listquest_Done.Count - 1;
								for (int num17 = 0; num17 <= num16; num17++)
								{
									int num18 = Conversions.ToInteger(_bot.listquest_Done[num17]);
									switch (Ground.Data_Marks_Name.ContainsKey(num18))
									{
									case true:
									{
										ListViewItem listViewItem2 = ListView_Quest.Items.Add(Ground.Data_Marks_Name[num18]);
										listViewItem2.UseItemStyleForSubItems = false;
										break;
									}
									case false:
									{
										ListViewItem listViewItem = ListView_Quest.Items.Add(Conversions.ToString(num18));
										listViewItem.UseItemStyleForSubItems = false;
										break;
									}
									}
								}
							}
						}
						catch (Exception ex5)
						{
							ProjectData.SetProjectError(ex5);
							Exception ex6 = ex5;
							ProjectData.ClearProjectError();
						}
						try
						{
							if (_bot.listquest_Doing.Count > 0)
							{
								int num19 = _bot.listquest_Doing.Count - 1;
								for (int num20 = 0; num20 <= num19; num20++)
								{
									int key = Conversions.ToInteger(_bot.listquest_Doing[num20]);
									bool flag = Ground.Data_Marks_Name.ContainsKey(key);
									if (flag)
									{
										ListViewItem listViewItem3 = ListView_Quest.Items.Add(Ground.Data_Marks_Name[key]);
										listViewItem3.UseItemStyleForSubItems = false;
										listViewItem3.SubItems[0].ForeColor = Color.RoyalBlue;
									}
								}
							}
						}
						catch (Exception ex7)
						{
							ProjectData.SetProjectError(ex7);
							Exception ex8 = ex7;
							ProjectData.ClearProjectError();
						}
					}
					ComboBox_CharTurnSetting.SelectedItem = 1;
					int idskill = Conversions.ToInteger(_bot.get__CharAttackSetting("Char_Skill1"));
					string selectedValue = _bot.get__CharAttackSetting("Char_Location1").ToString();
					SkillSelected(idskill, ComboBox_CharSkill);
					ComboBox_CharLocation.SelectedValue = selectedValue;
					ComboBox_PetTurnSetting.SelectedItem = 1;
					idskill = Conversions.ToInteger(_bot.get__PetAttackSetting("Pet_Skill1"));
					selectedValue = _bot.get__PetAttackSetting("Pet_Location1").ToString();
					SkillSelected(idskill, ComboBox_PetSkill);
					ComboBox_PetLocation.Text = selectedValue;
				}
				else
				{
					Panel_Login.Enabled = false;
					ToolStrip1.Enabled = false;
					TabPage9.Enabled = false;
					TabPage2.Enabled = false;
					GroupBox_Bot.Enabled = false;
					Label_Mini.Text = "";
					TextBox_DelayBot.Text = _bot.TextBox_DelayBot.ToString();
					TextBox_IDmem1.Text = _bot.TextBox_IDmem1.ToString();
					TextBox_IDmem2.Text = _bot.TextBox_IDmem2.ToString();
					TextBox_IDmem3.Text = _bot.TextBox_IDmem3.ToString();
					TextBox_IDmem4.Text = _bot.TextBox_IDmem4.ToString();
					TextBox_IdLeader.Text = _bot.TextBox_IdLeader.ToString();
					TextBox_Eat_char_hp_value.Text = _bot.TextBox_Eat_char_hp_value.ToString();
					TextBox_Eat_char_sp_value.Text = _bot.TextBox_Eat_char_sp_value.ToString();
					TextBox_Eat_pet_hp_value.Text = _bot.TextBox_Eat_Pet_hp_value.ToString();
					TextBox_Eat_pet_sp_value.Text = _bot.TextBox_Eat_Pet_sp_value.ToString();
					TextBox_TL_pet_hp_value.Text = _bot.TextBox_TL_pet_hp_value.ToString();
					TextBox_TL_pet_sp_value.Text = _bot.TextBox_TL_pet_sp_value.ToString();
					TextBox_AutoSend.Text = _bot.TextBox_AutoSend.ToString();
					TextBox_Drop_HpValue.Text = _bot.TextBox_Drop_HpValue.ToString();
					TextBox_Drop_SpValue.Text = _bot.TextBox_Drop_SpValue.ToString();
					TextBox_Contribute_HpValue.Text = _bot.TextBox_Contribute_HpValue.ToString();
					TextBox_Contribute_SpValue.Text = _bot.TextBox_Contribute_SpValue.ToString();
					TextBox_Send_HpValue.Text = _bot.TextBox_Send_HpValue.ToString();
					TextBox_Send_SpValue.Text = _bot.TextBox_Send_SpValue.ToString();
					TextBox_Sell_HpValue.Text = _bot.TextBox_Sell_HpValue.ToString();
					TextBox_Sell_SpValue.Text = _bot.TextBox_Sell_SpValue.ToString();
					TextBox_OpenMachine_CharHp.Text = _bot.TextBox_OpenMachine_CharHp.ToString();
					TextBox_OpenMachine_CharSp.Text = _bot.TextBox_OpenMachine_CharSp.ToString();
					TextBox_OpenMachine_PetHp.Text = _bot.TextBox_OpenMachine_PetHp.ToString();
					TextBox_OpenMachine_PetSp.Text = _bot.TextBox_OpenMachine_PetSp.ToString();
					NumericUpDown_ItemCountPickup.Text = _bot.NumericUpDown_ItemCountPickup.ToString();
					TextBox_ValueSPFlee.Text = _bot.TextBox_ValueSPFlee.ToString();
					TextBox_ClickMOD.Text = _bot.TextBox_ClickMOD;
					TextBox_ClickMOD_Delay.Text = _bot.TextBox_ClickMOD_delay.ToString();
					CheckBox_QuestProtect.Checked = _bot.C_CheckBox_QuestProtect;
					CheckBox_autosell.Checked = _bot.C_CheckBox_autosell;
					CheckBox_TuLenNgua.Checked = _bot.C_CheckBox_TuLenNgua;
					CheckBox_Bee.Checked = _bot.C_CheckBox_Bee;
					CheckBox_AutoRevival.Checked = _bot.C_CheckBox_AutoRevival;
					CheckBox_LeaderDissNotEnough.Checked = _bot.C_CheckBox_LeaderDissNotEnough;
					CheckBox_Char_ChangeTG.Checked = _bot.C_CheckBox_Char_ChangeTG;
					CheckBox_AutoFlee_Sp.Checked = _bot.C_CheckBox_AutoFlee_Sp;
					CheckBox_AutoFlee_Party.Checked = _bot.C_CheckBox_AutoFlee_Party;
					CheckBox_Pet_ChangeTG.Checked = _bot.C_CheckBox_Pet_ChangeTG;
					CheckBox_AutoClickNPC.Checked = _bot.C_CheckBox_AutoClickNPC;
					CheckBox_AutoPickup.Checked = _bot.C_CheckBox_AutoPickup;
					CheckBox_Pickup.Checked = _bot.C_CheckBox_Pickup;
					RadioButton_QS1.Checked = _bot.C_RadioButton_QS1;
					RadioButton_QS2.Checked = _bot.C_RadioButton_QS2;
					RadioButton_QS3.Checked = _bot.C_RadioButton_QS3;
					RadioButton_QS4.Checked = _bot.C_RadioButton_QS4;
					CheckBox_CatPet.Checked = _bot.C_CheckBox_CatPet;
					CheckBox_ClearGhost.Checked = _bot.C_CheckBox_ClearGhost;
					CheckBox_AutoEquitExp.Checked = _bot.C_CheckBox_AutoEquitExp;
					CheckBox_AutoUsePT.Checked = _bot.C_CheckBox_AutoUsePT;
					RadioButton_LeaderRequestParty.Checked = _bot.C_RadioButton_LeaderRequestParty;
					RadioButton_MemberRequestParty.Checked = _bot.C_RadioButton_MemberRequestParty;
					RadioButton_PT_no.Checked = _bot.C_RadioButton_PT_no;
					CheckBox_DCAfter1MinNoBattle.Checked = _bot.C_CheckBox_DCAfter1MinNoBattle;
					CheckBox_DisExp.Checked = _bot.C_CheckBox_DisExp;
					RadioButton_DCLeaderOut.Checked = _bot.C_RadioButton_DCLeaderOut;
					RadioButton_DCmemout.Checked = _bot.C_RadioButton_DCmemout;
					RadioButton_DC_no.Checked = _bot.C_RadioButton_DC_no;
					CheckBox_AutoEat.Checked = _bot.C_CheckBox_AutoEat;
					CheckBox_TL_mem1.Checked = _bot.C_CheckBox_TL_mem1;
					CheckBox_TL_mem2.Checked = _bot.C_CheckBox_TL_mem2;
					CheckBox_TL_mem3.Checked = _bot.C_CheckBox_TL_mem3;
					CheckBox_TL_mem4.Checked = _bot.C_CheckBox_TL_mem4;
					CheckBox_TL_pet1.Checked = _bot.C_CheckBox_TL_pet1;
					CheckBox_TL_pet2.Checked = _bot.C_CheckBox_TL_pet2;
					CheckBox_OpenMachine.Checked = _bot.C_CheckBox_OpenMachine;
					CheckBox_Autosort.Checked = _bot.C_CheckBox_Autosort;
					CheckBox_DCFullHomDo.Checked = _bot.C_CheckBox_DCFullHomdo;
					int leaderId2 = _bot.Data_Player._LeaderId;
					if (leaderId2 == _bot.Data_Player._Id)
					{
						if ((_bot.TextBox_IDmem1 == _bot._IDmem1) & (_bot._IDmem1 > 0))
						{
							TextBox_IDmem1.BackColor = Color.LightGreen;
						}
						else
						{
							TextBox_IDmem1.BackColor = SystemColors.Window;
						}
						if ((_bot.TextBox_IDmem2 == _bot._IDmem2) & (_bot._IDmem2 > 0))
						{
							TextBox_IDmem2.BackColor = Color.LightGreen;
						}
						else
						{
							TextBox_IDmem2.BackColor = SystemColors.Window;
						}
						if ((_bot.TextBox_IDmem3 == _bot._IDmem3) & (_bot._IDmem3 > 0))
						{
							TextBox_IDmem3.BackColor = Color.LightGreen;
						}
						else
						{
							TextBox_IDmem3.BackColor = SystemColors.Window;
						}
						if ((_bot.TextBox_IDmem4 == _bot._IDmem4) & (_bot._IDmem4 > 0))
						{
							TextBox_IDmem4.BackColor = Color.LightGreen;
						}
						else
						{
							TextBox_IDmem4.BackColor = SystemColors.Window;
						}
					}
					else if ((_bot.TextBox_IdLeader == _bot.Data_Player._LeaderId) & (_bot.Data_Player._LeaderId > 0))
					{
						TextBox_IdLeader.BackColor = Color.LightGreen;
					}
					else
					{
						TextBox_IdLeader.BackColor = SystemColors.Window;
					}
					ComboBox_CharTurnSetting.Items.Clear();
					ComboBox_PetTurnSetting.Items.Clear();
					int turnCount3 = _bot.Data_CharAttackSetting._TurnCount;
					int num21 = turnCount3;
					for (int num22 = 1; num22 <= num21; num22++)
					{
						ComboBox_CharTurnSetting.Items.Add(num22);
					}
					int turnCount4 = _bot.Data_PetAttackSetting._TurnCount;
					int num23 = turnCount4;
					for (int num24 = 1; num24 <= num23; num24++)
					{
						ComboBox_PetTurnSetting.Items.Add(num24);
					}
					if (_bot.logined == 1)
					{
						if (ComboBox_CharSkill.Items.Count != _bot.Data_CharListSkill.Count)
						{
							ComboBox_CharSkill.Items.Clear();
							List_skill_char.Clear();
							int num25 = _bot.Data_CharListSkill.Count - 1;
							for (int num26 = 0; num26 <= num25; num26++)
							{
								Char_AddSkillToList(Conversions.ToInteger(_bot.Data_CharListSkill[num26]));
							}
						}
						if (ComboBox_PetSkill.Items.Count != _bot.Data_PetListSkill.Count)
						{
							ComboBox_PetSkill.Items.Clear();
							List_skill_pet.Clear();
							int num27 = _bot.Data_PetListSkill.Count - 1;
							for (int num28 = 0; num28 <= num27; num28++)
							{
								Pet_AddSkillToList(Conversions.ToInteger(_bot.Data_PetListSkill[num28]));
							}
						}
					}
					if (_bot.Data_CharAttackSetting._TurnCount > 0)
					{
						ComboBox_CharTurnSetting.SelectedItem = 1;
						int idskill2 = Conversions.ToInteger(_bot.get__CharAttackSetting("Char_Skill1"));
						string selectedValue2 = _bot.get__CharAttackSetting("Char_Location1").ToString();
						SkillSelected(idskill2, ComboBox_CharSkill);
						ComboBox_CharLocation.SelectedValue = selectedValue2;
					}
					if (_bot.Data_PetAttackSetting._TurnCount > 0)
					{
						ComboBox_PetTurnSetting.SelectedItem = 1;
						int idskill3 = Conversions.ToInteger(_bot.get__PetAttackSetting("Pet_Skill1"));
						string text3 = _bot.get__PetAttackSetting("Pet_Location1").ToString();
						SkillSelected(idskill3, ComboBox_PetSkill);
						ComboBox_PetLocation.Text = text3;
					}
				}
				if (_bot.PetBattle > 0)
				{
					_petSelect = _bot.PetBattle;
					return;
				}
				Label_Petname.Text = "";
				Label_petlv.Text = Conversions.ToString(0);
				Label_Pet_int.Text = Conversions.ToString(0);
				Label_Pet_atk.Text = Conversions.ToString(0);
				Label_Pet_def.Text = Conversions.ToString(0);
				Label_Pet_hpx.Text = Conversions.ToString(0);
				Label_Pet_spx.Text = Conversions.ToString(0);
				Label_Pet_agi.Text = Conversions.ToString(0);
				Label_Pet_fai.Text = Conversions.ToString(0);
				Bitmap bitmap = Resources.btn_AssignFight;
				bitmap.MakeTransparent(Color.FromArgb(65280));
				PictureBox_Pet_XuatChien.BackgroundImage = bitmap;
				Label8.Visible = false;
				Label_PetExpMin.Visible = false;
			}
		}

		private void frmClient_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (_bot != null)
			{
				_bot.Setting_show = 0;
			}
		}


		private void Connect()
		{
			try
			{
				if (_bot.ComboBox_Server.Length > 0)
				{
					ComboBox_Server.Enabled = false;
					ComboBox_Port.Enabled = false;
					TBId.Enabled = false;
					TBPassword.Enabled = false;
					Thread thread = new Thread(_bot._Connect);
					thread.IsBackground = true;
					thread.Start();
					btnLogin.Text = "Thoát";
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				StackTrace stackTrace = new StackTrace(true);
				stackTrace = new StackTrace(ex2, true);
				API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - Connect] :" + ex2.Message + stackTrace.GetFrame(0).GetFileLineNumber() + "\r\n");
				ProjectData.ClearProjectError();
			}
		}

		private void Disconnect()
		{
			if (_bot == null)
			{
				return;
			}
			try
			{
				if (Operators.CompareString(Text, "Chưa kết nối!", false) != 0)
				{
					Text = "Chưa kết nối!";
				}
				Label_Mini.Text = "";
				ComboBox_botname.Enabled = true;
				Button_bot.Enabled = true;
				btnLogin.Text = "Đăng nhập";
				ComboBox_Server.Enabled = true;
				ComboBox_Port.Enabled = true;
				TBId.Enabled = true;
				TBPassword.Enabled = true;
				_bot._Disconnect();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				StackTrace stackTrace = new StackTrace(true);
				stackTrace = new StackTrace(ex2, true);
				API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - Disconnect] :" + ex2.Message + stackTrace.GetFrame(0).GetFileLineNumber() + "\r\n");
				ProjectData.ClearProjectError();
			}
		}


		private DataRow GetDatabaseRow()
		{
			if (DataSet1.Tables["Table_database"].Rows.Count == 0)
			{
				DataSet1.Tables["Table_database"].Rows.Add(0);
			}
			return DataSet1.Tables["Table_database"].Rows[0];
		}

		private void Timer_100_Tick(object sender, EventArgs e)
		{
			_ClientBot bot = _bot;
			try
			{
				if (_bot != null)
				{
					if ((_bot._Antibot_ask == 1) & (bot.logined == 0))
					{
						_bot._Antibot_ask = 0;
						Form1 form = new Form1(_bot, base.Location);
						form.ShowDialog();
					}
					if (_bot.Deleted == 1)
					{
						Close();
					}
					if (_bot.Disconnected == 0)
					{
						btnLogin.Text = "Thoát";
						ComboBox_Server.Enabled = false;
						ComboBox_Port.Enabled = false;
						TBId.Enabled = false;
						TBPassword.Enabled = false;
					}
					else
					{
						btnLogin.Text = "Đăng nhập";
						ComboBox_Server.Enabled = true;
						ComboBox_Port.Enabled = true;
						TBId.Enabled = true;
						TBPassword.Enabled = true;
					}
					if (_bot.bott == 1)
					{
						ComboBox_botname.Enabled = false;
						Button_bot.Text = "Dừng";
					}
					else
					{
						ComboBox_botname.Enabled = true;
						Button_bot.Text = "Bắt đầu";
					}
					if (_bot.Button_bot)
					{
						Button_bot.Enabled = true;
					}
					if (Operators.CompareString(Label_CharTurnCount.Text, _bot.Data_CharAttackSetting._TurnCount.ToString(), false) != 0)
					{
						Label_CharTurnCount.Text = _bot.Data_CharAttackSetting._TurnCount.ToString();
					}
					if (Operators.CompareString(Label_PetTurnCount.Text, _bot.Data_PetAttackSetting._TurnCount.ToString(), false) != 0)
					{
						Label_PetTurnCount.Text = _bot.Data_PetAttackSetting._TurnCount.ToString();
					}
					if (Operators.CompareString(StatusBarPanel_status.Text, bot.packetcount.ToString(), false) != 0)
					{
						StatusBarPanel_status.Text = bot.packetcount.ToString();
					}
					if (bot.logined == 1)
					{
						switch (_bot.List_Shopping)
						{
						case 0:
							if (Operators.CompareString(Button_Shop_Start.Text, "Bày bán", false) != 0)
							{
								Button_Shop_Start.Text = "Bày bán";
							}
							break;
						case 1:
							if (Operators.CompareString(Button_Shop_Start.Text, "Dọn hàng", false) != 0)
							{
								Button_Shop_Start.Text = "Dọn hàng";
							}
							break;
						}
						StatusBarPanel_online.Text = API.Demthoigian(_bot.time_online);
						switch (_bot._MiniRuning)
						{
						case 1:
							if (Operators.CompareString(Label_Mini.Text, "Mini-Bật", false) != 0)
							{
								Label_Mini.Text = "Mini-Bật";
								if (GetPicture.Mini_Photo.ContainsKey(bot.Data_Player._ThuocTinh))
								{
									PictureBox_mini.BackgroundImage = GetPicture.Mini_Photo[bot.Data_Player._ThuocTinh];
								}
							}
							break;
						case 0:
							if (Operators.CompareString(Label_Mini.Text, "Mini-Tắt", false) != 0)
							{
								Label_Mini.Text = "Mini-Tắt";
								PictureBox_mini.BackgroundImage = null;
							}
							break;
						}
						string text = bot.Data_Player._Int.ToString();
						if (bot.Data_Player._Int2 != 0)
						{
							switch (bot.Data_Player._Int_Plus1)
							{
							case 1:
								text = text + "+" + bot.Data_Player._Int2;
								break;
							case 0:
								text = text + "-" + bot.Data_Player._Int2;
								break;
							}
						}
						checked
						{
							if (bot.Data_Player._Int3 + bot.Data_Player._Int4 != 0)
							{
								text = text + "+" + (bot.Data_Player._Int3 + bot.Data_Player._Int4);
							}
							if (Operators.CompareString(Label_Char_int.Text, text, false) != 0)
							{
								Label_Char_int.Text = text;
								int idPic = 0;
								switch (bot.Data_Player._Sex)
								{
								case 1:
									idPic = 4000 + bot.Data_Player._Hair;
									break;
								case 2:
									idPic = 5000 + bot.Data_Player._Hair;
									break;
								}
								PictureBox_avatar.BackgroundImage = GetPicture._GetPhoto(idPic, bot.Data_Player._HairColor, bot.Data_Player._SkinColor);
							}
							string text2 = bot.Data_Player._Atk.ToString();
							if (bot.Data_Player._Atk2 != 0)
							{
								switch (bot.Data_Player._Atk_Plus1)
								{
								case 1:
									text2 = text2 + "+" + bot.Data_Player._Atk2;
									break;
								case 0:
									text2 = text2 + "-" + bot.Data_Player._Atk2;
									break;
								}
							}
							if (bot.Data_Player._Atk3 + bot.Data_Player._Atk4 != 0)
							{
								text2 = text2 + "+" + (bot.Data_Player._Atk3 + bot.Data_Player._Atk4);
							}
							if (Operators.CompareString(Label_Char_atk.Text, text2, false) != 0)
							{
								Label_Char_atk.Text = text2;
							}
							string text3 = bot.Data_Player._Def.ToString();
							if (bot.Data_Player._Def2 != 0)
							{
								switch (bot.Data_Player._Def_Plus1)
								{
								case 1:
									text3 = text3 + "+" + bot.Data_Player._Def2;
									break;
								case 0:
									text3 = text3 + "-" + bot.Data_Player._Def2;
									break;
								}
							}
							if (bot.Data_Player._Def3 + bot.Data_Player._Def4 != 0)
							{
								text3 = text3 + "+" + (bot.Data_Player._Def3 + bot.Data_Player._Def4);
							}
							if (Operators.CompareString(Label_Char_def.Text, text3, false) != 0)
							{
								Label_Char_def.Text = text3;
							}
							string text4 = bot.Data_Player._Hpx.ToString();
							if (bot.Data_Player._Hpx2 != 0)
							{
								switch (bot.Data_Player._Hpx_Plus1)
								{
								case 1:
									text4 = text4 + "+" + bot.Data_Player._Hpx2;
									break;
								case 0:
									text4 = text4 + "-" + bot.Data_Player._Hpx2;
									break;
								}
							}
							if (bot.Data_Player._Hpx3 + bot.Data_Player._Hpx4 != 0)
							{
								text4 = text4 + "+" + (bot.Data_Player._Hpx3 + bot.Data_Player._Hpx4);
							}
							if (Operators.CompareString(Label_Char_hpx.Text, text4, false) != 0)
							{
								Label_Char_hpx.Text = text4;
							}
							string text5 = bot.Data_Player._Spx.ToString();
							if (bot.Data_Player._Spx2 != 0)
							{
								switch (bot.Data_Player._Spx_Plus1)
								{
								case 1:
									text5 = text5 + "+" + bot.Data_Player._Spx2;
									break;
								case 0:
									text5 = text5 + "-" + bot.Data_Player._Spx2;
									break;
								}
							}
							if (bot.Data_Player._Spx3 + bot.Data_Player._Spx4 != 0)
							{
								text5 = text5 + "+" + (bot.Data_Player._Spx3 + bot.Data_Player._Spx4);
							}
							if (Operators.CompareString(Label_Char_spx.Text, text5, false) != 0)
							{
								Label_Char_spx.Text = text5;
							}
							string text6 = bot.Data_Player._Agi.ToString();
							if (bot.Data_Player._Agi2 != 0)
							{
								switch (bot.Data_Player._Agi_Plus1)
								{
								case 1:
									text6 = text6 + "+" + bot.Data_Player._Agi2;
									break;
								case 0:
									text6 = text6 + "-" + bot.Data_Player._Agi2;
									break;
								}
							}
							if (bot.Data_Player._Agi4 != 0)
							{
								text6 = text6 + "+" + bot.Data_Player._Agi4;
							}
							if (Operators.CompareString(Label_Char_agi.Text, text6, false) != 0)
							{
								Label_Char_agi.Text = text6;
							}
							int num = 1;
							do
							{
								_Data._Tuido tuido = _bot.Data_Tuido[num];
								Tuido_Info value = Data_Tuido[num];
								if (value._id != tuido._Id)
								{
									value._id = tuido._Id;
									value._count = tuido._Sl;
									value._iconResolved = false;
									if (tuido._Id > 0)
									{
										value._photo.Text = Conversions.ToString(tuido._Sl);
									}
									else
									{
										value._photo.Image = new Bitmap(32, 32);
										value._photo.Text = "";
									}
								}
								else if (value._count != tuido._Sl)
								{
									value._count = tuido._Sl;
									value._photo.Text = Conversions.ToString(tuido._Sl);
								}
								if (tuido._Id > 0 && !value._iconResolved && Items.Data_Items.ContainsKey(tuido._Id))
								{
									value._photo.Image = GetPicture._GetPhoto_Item(Items.Data_Items[tuido._Id]._idPic);
									ToolTip_info.SetToolTip(value._photo, MakeItemInfo((ushort)tuido._Id));
									value._iconResolved = true;
								}
								if ((value._id == 0) & (Operators.CompareString(value._photo.Text, "", false) != 0))
								{
									Bitmap image2 = new Bitmap(32, 32);
									value._photo.Image = image2;
									value._photo.Text = "";
								}
								Data_Tuido[num] = value;
								num++;
							}
							while (num <= 25);
							int num2 = 1;
							do
							{
								_Data._Tuideo tuideo = _bot.Data_Tuideo[num2];
								Tuideo_Info value2 = Data_Tuideo[num2];
								if (value2._id != tuideo._Id)
								{
									value2._id = tuideo._Id;
									value2._count = tuideo._Sl;
									value2._iconResolved = false;
									if (tuideo._Id > 0)
									{
										value2._photo.Text = Conversions.ToString(tuideo._Sl);
									}
									else
									{
										value2._photo.Image = new Bitmap(32, 32);
										value2._photo.Text = "";
									}
								}
								if (tuideo._Id > 0 && !value2._iconResolved && Items.Data_Items.ContainsKey(tuideo._Id))
								{
									value2._photo.Image = GetPicture._GetPhoto_Item(Items.Data_Items[tuideo._Id]._idPic);
									ToolTip_info.SetToolTip(value2._photo, MakeItemInfo((ushort)tuideo._Id));
									value2._iconResolved = true;
								}
								if ((value2._id == 0) & (Operators.CompareString(value2._photo.Text, "", false) != 0))
								{
									Bitmap image4 = new Bitmap(32, 32);
									value2._photo.Image = image4;
									value2._photo.Text = "";
								}
								Data_Tuideo[num2] = value2;
								num2++;
							}
							while (num2 <= 25);
							int num3 = 0;
							do
							{
								_Data._CharEquit charEquit = _bot.Data_CharEquit[num3];
								Trangbi_Info value3 = Data_Trangbi_Char[num3];
								bool flag2 = false;
								if (value3._id != charEquit._Id)
								{
									value3._id = charEquit._Id;
									value3._iconResolved = false;
									if (charEquit._Id == 0)
									{
										value3._photo.Image = null;
									}
									flag2 = true;
								}
								if (charEquit._Id != 0 && !value3._iconResolved && Items.Data_Items.ContainsKey(charEquit._Id))
								{
									value3._photo.Image = GetPicture._GetPhoto_Item(Items.Data_Items[charEquit._Id]._idPic);
									ToolTip_info.SetToolTip(value3._photo, MakeItemInfo((ushort)value3._id));
									value3._iconResolved = true;
									flag2 = true;
								}
								if (flag2)
								{
									Data_Trangbi_Char[num3] = value3;
								}
								num3++;
							}
							while (num3 <= 5);
							if (_bot.PetBattle == 0)
							{
								if (_petSelect == 0)
								{
									int num4 = 1;
									do
									{
										int num5 = Conversions.ToInteger(_bot.get_DataPets(num4, _Data.Type_Pets._Id));
										if (num5 > 0)
										{
											_petSelect = num4;
											break;
										}
										num4++;
									}
									while (num4 <= 4);
								}
							}
							else if (_petSelect == 0)
							{
								_petSelect = _bot.PetBattle;
							}
							if (_petSelect > 0)
							{
								if (_petSelect == _bot.PetBattle)
								{
									if (!Label8.Visible | (PictureBox_Pet_XuatChien.BackgroundImage == null))
									{
										Bitmap bitmap = Resources.btn_AssignRest;
										bitmap.MakeTransparent(Color.FromArgb(65280));
										PictureBox_Pet_XuatChien.BackgroundImage = bitmap;
										Label8.Visible = true;
										Label_PetExpMin.Visible = true;
									}
								}
								else if (Label8.Visible)
								{
									Bitmap bitmap2 = Resources.btn_AssignFight;
									bitmap2.MakeTransparent(Color.FromArgb(65280));
									PictureBox_Pet_XuatChien.BackgroundImage = bitmap2;
									Label8.Visible = false;
									Label_PetExpMin.Visible = false;
								}
								int petSelect = _petSelect;
								int key = Conversions.ToInteger(_bot.get_DataPets(petSelect, _Data.Type_Pets._Id));
								if (Npcs.Data_Npcs.ContainsKey(key))
								{
									Npcs.NpcInfo npc = Npcs.Data_Npcs[key];
									_Data._Pets pets = _bot.Data_PetsInfo[petSelect];
									if (Operators.ConditionalCompareObjectNotEqual(PictureBox_Pet_photo.Tag, pets._Id, false))
									{
										PictureBox_Pet_photo.Tag = pets._Id;
										PictureBox_Pet_photo.Image = GetPicture._GetPhoto(npc);
										switch (npc._Thuoctinh)
										{
										case 0:
											PictureBox_Pet_Thuoctinh.BackgroundImage = new Bitmap(1, 1);
											break;
										case 1:
											PictureBox_Pet_Thuoctinh.BackgroundImage = Resources.icon_01;
											break;
										case 2:
											PictureBox_Pet_Thuoctinh.BackgroundImage = Resources.icon_02;
											break;
										case 3:
											PictureBox_Pet_Thuoctinh.BackgroundImage = Resources.icon_03;
											break;
										case 4:
											PictureBox_Pet_Thuoctinh.BackgroundImage = Resources.icon_04;
											break;
										case 5:
											PictureBox_Pet_Thuoctinh.BackgroundImage = Resources.icon_05;
											break;
										case 7:
											PictureBox_Pet_Thuoctinh.BackgroundImage = Resources.icon_07;
											break;
										case 8:
											PictureBox_Pet_Thuoctinh.BackgroundImage = Resources.icon_08;
											break;
										}
									}
									if (Operators.CompareString(Label_Petname.Text, pets._Name, false) != 0)
									{
										Label_Petname.Text = pets._Name;
									}
									if (Conversions.ToDouble(Label_petlv.Text) != (double)pets._Lv)
									{
										Label_petlv.Text = Conversions.ToString(pets._Lv);
									}
									if (pets._HpMax >= pets._Hp)
									{
										if (ProgressBarEx_PetHp.Value != pets._Hp)
										{
											ProgressBarEx_PetHp.Value = pets._Hp;
										}
										if (ProgressBarEx_PetHp.Maximum != pets._HpMax)
										{
											ProgressBarEx_PetHp.Maximum = pets._HpMax;
										}
									}
									if (pets._SpMax >= pets._Sp)
									{
										if (ProgressBarEx_PetSp.Value != pets._Sp)
										{
											ProgressBarEx_PetSp.Value = pets._Sp;
										}
										if (ProgressBarEx_PetSp.Maximum != pets._SpMax)
										{
											ProgressBarEx_PetSp.Maximum = pets._SpMax;
										}
									}
									if (pets._ExpMax >= pets._Exp)
									{
										if (ProgressBarEx_PetExp.Value != pets._Exp)
										{
											ProgressBarEx_PetExp.Value = pets._Exp;
										}
										if (ProgressBarEx_PetExp.Maximum != pets._ExpMax)
										{
											ProgressBarEx_PetExp.Maximum = pets._ExpMax;
										}
									}
									int num6 = 0;
									do
									{
										int num7 = 0;
										switch (num6)
										{
										case 0:
											num7 = pets._Mu;
											break;
										case 1:
											num7 = pets._Ao;
											break;
										case 2:
											num7 = pets._vukhi;
											break;
										case 3:
											num7 = pets._tay;
											break;
										case 4:
											num7 = pets._chan;
											break;
										case 5:
											num7 = pets._dacthu;
											break;
										}
										Trangbi_Info value4 = Data_Trangbi_Pet[num6];
										bool flag3 = false;
										if (value4._id != num7)
										{
											value4._id = num7;
											value4._iconResolved = false;
											if (num7 == 0)
											{
												value4._photo.Image = null;
											}
											flag3 = true;
										}
										if (num7 != 0 && !value4._iconResolved && Items.Data_Items.ContainsKey(num7))
										{
											value4._photo.Image = GetPicture._GetPhoto_Item(Items.Data_Items[num7]._idPic);
											ToolTip_info.SetToolTip(value4._photo, MakeItemInfo((ushort)value4._id));
											value4._iconResolved = true;
											flag3 = true;
										}
										if (flag3)
										{
											Data_Trangbi_Pet[num6] = value4;
										}
										num6++;
									}
									while (num6 <= 5);
									string text7 = Conversions.ToString(pets._Int);
									if (pets._Int2 != 0)
									{
										text7 = ((pets._Int3 != 1) ? (text7 + "-" + pets._Int2) : (text7 + "+" + pets._Int2));
									}
									string text8 = Conversions.ToString(pets._Atk);
									if (pets._Atk2 != 0)
									{
										text8 = ((pets._Atk3 != 1) ? (text8 + "-" + pets._Atk2) : (text8 + "+" + pets._Atk2));
									}
									string text9 = Conversions.ToString(pets._Def);
									if (pets._Def2 != 0)
									{
										text9 = ((pets._Def3 != 1) ? (text9 + "-" + pets._Def2) : (text9 + "+" + pets._Def2));
									}
									string text10 = Conversions.ToString(pets._Hpx);
									if (pets._Hpx2 != 0)
									{
										text10 = ((pets._Hpx3 != 1) ? (text10 + "-" + pets._Hpx2) : (text10 + "+" + pets._Hpx2));
									}
									string text11 = Conversions.ToString(pets._Spx);
									if (pets._Spx2 != 0)
									{
										text11 = ((pets._Spx3 != 1) ? (text11 + "-" + pets._Spx2) : (text11 + "+" + pets._Spx2));
									}
									string text12 = Conversions.ToString(pets._Agi);
									if (pets._Agi2 != 0)
									{
										text12 = ((pets._Agi3 != 1) ? (text12 + "-" + pets._Agi2) : (text12 + "+" + pets._Agi2));
									}
									string right = Conversions.ToString(pets._Fai);
									if (Operators.CompareString(Label_Pet_int.Text, text7, false) != 0)
									{
										Label_Pet_int.Text = text7;
									}
									if (Operators.CompareString(Label_Pet_atk.Text, text8, false) != 0)
									{
										Label_Pet_atk.Text = text8;
									}
									if (Operators.CompareString(Label_Pet_def.Text, text9, false) != 0)
									{
										Label_Pet_def.Text = text9;
									}
									if (Operators.CompareString(Label_Pet_hpx.Text, text10, false) != 0)
									{
										Label_Pet_hpx.Text = text10;
									}
									if (Operators.CompareString(Label_Pet_spx.Text, text11, false) != 0)
									{
										Label_Pet_spx.Text = text11;
									}
									if (Operators.CompareString(Label_Pet_agi.Text, text12, false) != 0)
									{
										Label_Pet_agi.Text = text12;
									}
									if (Operators.CompareString(Label_Pet_fai.Text, right, false) != 0)
									{
										Label_Pet_fai.Text = right;
									}
								}
							}
							if (Operators.CompareString(Vs2010TabControl_Main.TabPages[Vs2010TabControl_Main.SelectedIndex].Name, "TabPage_Attack", false) == 0 && _bot.Data_NpcInMap.Count > 0)
							{
								try
								{
									foreach (_Data._NpcInMap value5 in _bot.Data_NpcInMap.Values)
									{
										NpcOnMap.Key_NpcOnMap key2 = new NpcOnMap.Key_NpcOnMap
										{
											_Idmap = _bot.Data_Player._MapId,
											_id = value5._Id
										};
										if (!NpcOnMap.Data_NpcOnMap.ContainsKey(key2) || !Npcs.Data_Npcs.ContainsKey(NpcOnMap.Data_NpcOnMap[key2]._NPCId))
										{
											continue;
										}
										Npcs.NpcInfo npcs = Npcs.Data_Npcs[NpcOnMap.Data_NpcOnMap[key2]._NPCId];
										if (ListView_monster.Items.Count > 0)
										{
											if (ListView_monster.FindItemWithText(value5._Id.ToString(), false, 0) != null)
											{
												ListViewItem listViewItem = ListView_monster.FindItemWithText(value5._Id.ToString(), false, 0);
												if (listViewItem.BackColor != API.GetColor(npcs._Thuoctinh))
												{
													listViewItem.BackColor = API.GetColor(npcs._Thuoctinh);
												}
												if (Operators.CompareString(listViewItem.SubItems[4].Text, value5._MapX.ToString(), false) != 0)
												{
													listViewItem.SubItems[4].Text = value5._MapX.ToString();
												}
												if (Operators.CompareString(listViewItem.SubItems[5].Text, value5._MapY.ToString(), false) != 0)
												{
													listViewItem.SubItems[5].Text = value5._MapY.ToString();
												}
												if (Operators.CompareString(listViewItem.SubItems[6].Text, value5._Delay.ToString(), false) != 0)
												{
													listViewItem.SubItems[6].Text = value5._Delay.ToString();
												}
												if (Operators.CompareString(listViewItem.SubItems[7].Text, value5._KC.ToString(), false) != 0)
												{
													listViewItem.SubItems[7].Text = value5._KC.ToString();
												}
											}
											else
											{
												ListViewItem listViewItem2 = ListView_monster.Items.Add(value5._Id.ToString());
												listViewItem2.Text = value5._Id.ToString();
												listViewItem2.SubItems.Add(npcs._Name);
												listViewItem2.SubItems.Add(Conversions.ToString(npcs._Lv));
												listViewItem2.SubItems.Add(Conversions.ToString(npcs._Agi));
												listViewItem2.SubItems.Add(Conversions.ToString(value5._MapX));
												listViewItem2.SubItems.Add(Conversions.ToString(value5._MapY));
												listViewItem2.SubItems.Add(Conversions.ToString(value5._Delay));
												listViewItem2.SubItems.Add(Conversions.ToString(value5._KC));
												if (listViewItem2.BackColor != API.GetColor(npcs._Thuoctinh))
												{
													listViewItem2.BackColor = API.GetColor(npcs._Thuoctinh);
												}
											}
										}
										else
										{
											ListViewItem listViewItem3 = ListView_monster.Items.Add(value5._Id.ToString());
											listViewItem3.Text = value5._Id.ToString();
											listViewItem3.SubItems.Add(npcs._Name);
											listViewItem3.SubItems.Add(Conversions.ToString(npcs._Lv));
											listViewItem3.SubItems.Add(Conversions.ToString(npcs._Agi));
											listViewItem3.SubItems.Add(Conversions.ToString(value5._MapX));
											listViewItem3.SubItems.Add(Conversions.ToString(value5._MapY));
											listViewItem3.SubItems.Add(Conversions.ToString(value5._Delay));
											listViewItem3.SubItems.Add(Conversions.ToString(value5._KC));
											if (listViewItem3.BackColor != API.GetColor(npcs._Thuoctinh))
											{
												listViewItem3.BackColor = API.GetColor(npcs._Thuoctinh);
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
							if (Operators.ConditionalCompareObjectNotEqual(GetDatabaseRow()["Name"], bot.Data_Player._Name, false))
							{
								Label_CharName.ForeColor = API.GetColor(bot.Data_Player._ThuocTinh);
								GetDatabaseRow()["Name"] = bot.Data_Player._Name;
								Text = bot.Data_Player._Name;
								switch (bot.Data_Player._ThuocTinh)
								{
								case 1:
									PictureBox_Char_Thuoctinh.BackgroundImage = Resources.icon_01;
									break;
								case 2:
									PictureBox_Char_Thuoctinh.BackgroundImage = Resources.icon_02;
									break;
								case 3:
									PictureBox_Char_Thuoctinh.BackgroundImage = Resources.icon_03;
									break;
								case 4:
									PictureBox_Char_Thuoctinh.BackgroundImage = Resources.icon_04;
									break;
								case 5:
									PictureBox_Char_Thuoctinh.BackgroundImage = Resources.icon_05;
									break;
								case 7:
									PictureBox_Char_Thuoctinh.BackgroundImage = Resources.icon_07;
									break;
								case 8:
									PictureBox_Char_Thuoctinh.BackgroundImage = Resources.icon_08;
									break;
								}
							}
							if (Operators.CompareString(Vs2010TabControl_Main.TabPages[Vs2010TabControl_Main.SelectedIndex].Name, "TabPage_Attack", false) == 0)
							{
								if (List_skill_char.Count < _bot.Data_CharListSkill.Count)
								{
									ComboBox_CharSkill.Items.Clear();
									List_skill_char.Clear();
									int num8 = _bot.Data_CharListSkill.Count - 1;
									for (int i = 0; i <= num8; i++)
									{
										Char_AddSkillToList(Conversions.ToInteger(bot.Data_CharListSkill[i]));
									}
									ComboBox_CharTurnSetting.SelectedItem = 1;
									int idskill = Conversions.ToInteger(_bot.get__CharAttackSetting("Char_Skill1"));
									string selectedValue = _bot.get__CharAttackSetting("Char_Location1").ToString();
									SkillSelected(idskill, ComboBox_CharSkill);
									ComboBox_CharLocation.SelectedValue = selectedValue;
								}
								if (List_skill_pet.Count < _bot.Data_PetListSkill.Count)
								{
									ComboBox_PetSkill.Items.Clear();
									List_skill_pet.Clear();
									int num9 = _bot.Data_PetListSkill.Count - 1;
									for (int j = 0; j <= num9; j++)
									{
										Pet_AddSkillToList(Conversions.ToInteger(_bot.Data_PetListSkill[j]));
									}
									ComboBox_PetTurnSetting.SelectedItem = 1;
									int idskill2 = Conversions.ToInteger(_bot.get__PetAttackSetting("Pet_Skill1"));
									string text13 = _bot.get__PetAttackSetting("Pet_Location1").ToString();
									SkillSelected(idskill2, ComboBox_PetSkill);
									ComboBox_PetLocation.Text = text13;
								}
							}
							if (Operators.ConditionalCompareObjectNotEqual(GetDatabaseRow()["Lv"], bot.Data_Player._Lv, false))
							{
								GetDatabaseRow()["Lv"] = bot.Data_Player._Lv;
							}
							if (Operators.ConditionalCompareObjectNotEqual(GetDatabaseRow()["Hp"], bot.Data_Player._Hp, false))
							{
								GetDatabaseRow()["Hp"] = bot.Data_Player._Hp;
							}
							if (Operators.ConditionalCompareObjectNotEqual(GetDatabaseRow()["MaxHp"], bot.Data_Player._HpMax, false))
							{
								GetDatabaseRow()["MaxHp"] = bot.Data_Player._HpMax;
							}
							if (Operators.ConditionalCompareObjectNotEqual(GetDatabaseRow()["Sp"], bot.Data_Player._Sp, false))
							{
								GetDatabaseRow()["Sp"] = bot.Data_Player._Sp;
							}
							if (Operators.ConditionalCompareObjectNotEqual(GetDatabaseRow()["MaxSp"], bot.Data_Player._SpMax, false))
							{
								GetDatabaseRow()["MaxSp"] = bot.Data_Player._SpMax;
							}
						}
						if (Operators.ConditionalCompareObjectNotEqual(GetDatabaseRow()["MapId"], _bot.Data_Player._MapId, false))
						{
							GetDatabaseRow()["MapId"] = _bot.Data_Player._MapId;
							try
							{
								_map = API.Bytes_to_Bitmap(_bot.Data_Player._MapId);
								Bitmap bmp = (Bitmap)_map.Clone();
								int num10 = _bot.Data_Player._MapX / 20;
								int num11 = _bot.Data_Player._MapY / 20;
								bmp = API.ResizeImage(bmp, num10, num11, Color.Red);
								PictureBox1.Width = bmp.Width;
								PictureBox1.Height = bmp.Height;
								PictureBox1.Image = bmp;
							}
							catch (Exception ex3)
							{
								ProjectData.SetProjectError(ex3);
								Exception ex4 = ex3;
								ProjectData.ClearProjectError();
							}
						}
						if (Operators.ConditionalCompareObjectNotEqual(GetDatabaseRow()["MapX"], bot.Data_Player._MapX, false))
						{
							GetDatabaseRow()["MapX"] = bot.Data_Player._MapX;
						}
						if (Operators.ConditionalCompareObjectNotEqual(GetDatabaseRow()["MapY"], bot.Data_Player._MapY, false))
						{
							GetDatabaseRow()["MapY"] = bot.Data_Player._MapY;
						}
						if (Operators.ConditionalCompareObjectNotEqual(GetDatabaseRow()["Gold"], bot.Data_Player._Gold, false))
						{
							GetDatabaseRow()["Gold"] = bot.Data_Player._Gold;
						}
						if (Operators.ConditionalCompareObjectNotEqual(GetDatabaseRow()["TotalExp"], bot.Data_Player._ExpTotal, false))
						{
							GetDatabaseRow()["TotalExp"] = bot.Data_Player._ExpTotal;
						}
						if (Operators.ConditionalCompareObjectNotEqual(GetDatabaseRow()["Exp"], bot.Data_Player._Exp, false))
						{
							GetDatabaseRow()["Exp"] = bot.Data_Player._Exp;
						}
						if (Operators.ConditionalCompareObjectNotEqual(GetDatabaseRow()["MaxExp"], bot.Data_Player._ExpMax, false))
						{
							GetDatabaseRow()["MaxExp"] = bot.Data_Player._ExpMax;
						}
						if (Operators.ConditionalCompareObjectNotEqual(GetDatabaseRow()["ExpMin"], bot.Data_Player._ExpMin, false))
						{
							GetDatabaseRow()["ExpMin"] = bot.Data_Player._ExpMin;
						}
						if (Operators.ConditionalCompareObjectNotEqual(GetDatabaseRow()["Int"], bot.Data_Player._Int, false))
						{
							GetDatabaseRow()["Int"] = bot.Data_Player._Int;
						}
						if (Operators.ConditionalCompareObjectNotEqual(GetDatabaseRow()["Atk"], bot.Data_Player._Atk, false))
						{
							GetDatabaseRow()["Atk"] = bot.Data_Player._Atk;
						}
						if (Operators.ConditionalCompareObjectNotEqual(GetDatabaseRow()["Def"], bot.Data_Player._Def, false))
						{
							GetDatabaseRow()["Def"] = bot.Data_Player._Def;
						}
						if (Operators.ConditionalCompareObjectNotEqual(GetDatabaseRow()["Hpx"], bot.Data_Player._Hpx, false))
						{
							GetDatabaseRow()["Hpx"] = bot.Data_Player._Hpx;
						}
						if (Operators.ConditionalCompareObjectNotEqual(GetDatabaseRow()["Spx"], bot.Data_Player._Spx, false))
						{
							GetDatabaseRow()["Spx"] = bot.Data_Player._Spx;
						}
						if (Operators.ConditionalCompareObjectNotEqual(GetDatabaseRow()["Agi"], bot.Data_Player._Agi, false))
						{
							GetDatabaseRow()["Agi"] = bot.Data_Player._Agi;
						}
						if (Operators.ConditionalCompareObjectNotEqual(GetDatabaseRow()["+Int"], bot.Data_Player._Int2, false))
						{
							GetDatabaseRow()["+Int"] = bot.Data_Player._Int2;
						}
						if (Operators.ConditionalCompareObjectNotEqual(GetDatabaseRow()["+Atk"], bot.Data_Player._Atk2, false))
						{
							GetDatabaseRow()["+Atk"] = bot.Data_Player._Atk2;
						}
						if (Operators.ConditionalCompareObjectNotEqual(GetDatabaseRow()["+Def"], bot.Data_Player._Def2, false))
						{
							GetDatabaseRow()["+Def"] = bot.Data_Player._Def2;
						}
						if (Operators.ConditionalCompareObjectNotEqual(GetDatabaseRow()["+Hpx"], bot.Data_Player._Hpx2, false))
						{
							GetDatabaseRow()["+Hpx"] = bot.Data_Player._Hpx2;
						}
						if (Operators.ConditionalCompareObjectNotEqual(GetDatabaseRow()["+Spx"], bot.Data_Player._Spx2, false))
						{
							GetDatabaseRow()["+Spx"] = bot.Data_Player._Spx2;
						}
						if (Operators.ConditionalCompareObjectNotEqual(GetDatabaseRow()["+agi"], bot.Data_Player._Agi2, false))
						{
							GetDatabaseRow()["+agi"] = bot.Data_Player._Agi2;
						}
						int reborn = bot.Data_Player._Reborn;
						if (reborn == 3)
						{
							if (ProgressBarEx_CharExp.BarColor1 != Label_Lv2.ForeColor)
							{
								ProgressBarEx_CharExp.BarColor1 = Label_Lv2.ForeColor;
							}
							if (!Label_Lv2.Visible)
							{
								Label_Lv2.Visible = true;
							}
							if (!Label_Lv_Plus.Visible)
							{
								Label_Lv_Plus.Visible = true;
							}
							if (Operators.CompareString(Label_Lv2.Text, bot.Data_Player._Lv2.ToString(), false) != 0)
							{
								Label_Lv2.Text = bot.Data_Player._Lv2.ToString();
							}
						}
						else
						{
							if (ProgressBarEx_CharExp.BarColor1 != ProgressBarEx_PetExp.BackColor1)
							{
								ProgressBarEx_CharExp.BarColor1 = ProgressBarEx_PetExp.BackColor1;
							}
							if (Label_Lv2.Visible)
							{
								Label_Lv2.Visible = false;
							}
							if (Label_Lv_Plus.Visible)
							{
								Label_Lv_Plus.Visible = false;
							}
						}
						if (Operators.ConditionalCompareObjectNotEqual(GetDatabaseRow()["Texp"], bot.Data_Player._Texp, false))
						{
							GetDatabaseRow()["Texp"] = bot.Data_Player._Texp;
						}
						if (Operators.ConditionalCompareObjectNotEqual(GetDatabaseRow()["God"], bot.Data_Player._God, false))
						{
							GetDatabaseRow()["God"] = bot.Data_Player._God;
						}
						if (Operators.ConditionalCompareObjectNotEqual(GetDatabaseRow()["Ghost"], bot.Data_Player._Ghost, false))
						{
							GetDatabaseRow()["Ghost"] = bot.Data_Player._Ghost;
						}
						if (Operators.ConditionalCompareObjectNotEqual(GetDatabaseRow()["Reborn"], bot.Data_Player._Reborn, false))
						{
							GetDatabaseRow()["Reborn"] = bot.Data_Player._Reborn;
						}
						if (Operators.ConditionalCompareObjectNotEqual(GetDatabaseRow()["proto"], bot.Data_Player._ThuocTinh, false))
						{
							GetDatabaseRow()["proto"] = bot.Data_Player._ThuocTinh;
						}
						if (Operators.ConditionalCompareObjectNotEqual(GetDatabaseRow()["PlayerOnline"], bot.Data_Player._PlayerOnline, false))
						{
							GetDatabaseRow()["PlayerOnline"] = bot.Data_Player._PlayerOnline;
						}
						if (Operators.ConditionalCompareObjectNotEqual(GetDatabaseRow()["LeaderId"], bot.Data_Player._LeaderId, false))
						{
							GetDatabaseRow()["LeaderId"] = bot.Data_Player._LeaderId;
						}
						if (Operators.ConditionalCompareObjectNotEqual(GetDatabaseRow()["PartyFull"], bot.Data_Player._PartyFull, false))
						{
							GetDatabaseRow()["PartyFull"] = bot.Data_Player._PartyFull;
						}
						if (Operators.ConditionalCompareObjectNotEqual(GetDatabaseRow()["Point"], bot.Data_Player._Point, false))
						{
							GetDatabaseRow()["Point"] = bot.Data_Player._Point;
						}
						if (Operators.CompareString(StatusBarPanel_MapName.Text, bot.Data_Player._MapName, false) != 0)
						{
							StatusBarPanel_MapName.Text = bot.Data_Player._MapName;
						}
						if (Conversions.ToDouble(Label_PetExpMin.Text) != (double)bot.Data_PetInfo._ExpMin)
						{
							Label_PetExpMin.Text = Conversions.ToString(bot.Data_PetInfo._ExpMin);
						}
						if (_bot.Data_Player._Point > 0)
						{
							if (!PictureBox_char_add_int.Visible)
							{
								PictureBox_char_add_int.Visible = true;
							}
							if (!PictureBox_char_add_atk.Visible)
							{
								PictureBox_char_add_atk.Visible = true;
							}
							if (!PictureBox_char_add_def.Visible)
							{
								PictureBox_char_add_def.Visible = true;
							}
							if (!PictureBox_char_add_hpx.Visible)
							{
								PictureBox_char_add_hpx.Visible = true;
							}
							if (!PictureBox_char_add_spx.Visible)
							{
								PictureBox_char_add_spx.Visible = true;
							}
							if (!PictureBox_char_add_agi.Visible)
							{
								PictureBox_char_add_agi.Visible = true;
							}
						}
						else
						{
							if (PictureBox_char_add_int.Visible)
							{
								PictureBox_char_add_int.Visible = false;
							}
							if (PictureBox_char_add_atk.Visible)
							{
								PictureBox_char_add_atk.Visible = false;
							}
							if (PictureBox_char_add_def.Visible)
							{
								PictureBox_char_add_def.Visible = false;
							}
							if (PictureBox_char_add_hpx.Visible)
							{
								PictureBox_char_add_hpx.Visible = false;
							}
							if (PictureBox_char_add_spx.Visible)
							{
								PictureBox_char_add_spx.Visible = false;
							}
							if (PictureBox_char_add_agi.Visible)
							{
								PictureBox_char_add_agi.Visible = false;
							}
						}
						if (Operators.CompareString(Label_BDY.Text, _bot.Label_BDY, false) != 0)
						{
							Label_BDY.Text = _bot.Label_BDY;
						}
						if (ProgressBarEx_BDY.Value != _bot.ProgressBarEx_BDY)
						{
							ProgressBarEx_BDY.Value = _bot.ProgressBarEx_BDY;
						}
						if (bot.Data_Player._LeaderId > 0)
						{
							int leaderId = bot.Data_Player._LeaderId;
							if (leaderId == bot.Data_Player._Id)
							{
								if ((_bot.TextBox_IDmem1 == _bot._IDmem1) & (_bot._IDmem1 > 0))
								{
									if (TextBox_IDmem1.BackColor != Color.LightGreen)
									{
										TextBox_IDmem1.BackColor = Color.LightGreen;
									}
								}
								else if (TextBox_IDmem1.BackColor != SystemColors.Window)
								{
									TextBox_IDmem1.BackColor = SystemColors.Window;
								}
								if ((_bot.TextBox_IDmem2 == _bot._IDmem2) & (_bot._IDmem2 > 0))
								{
									if (TextBox_IDmem2.BackColor != Color.LightGreen)
									{
										TextBox_IDmem2.BackColor = Color.LightGreen;
									}
								}
								else if (TextBox_IDmem2.BackColor != SystemColors.Window)
								{
									TextBox_IDmem2.BackColor = SystemColors.Window;
								}
								if ((_bot.TextBox_IDmem3 == _bot._IDmem3) & (_bot._IDmem3 > 0))
								{
									if (TextBox_IDmem3.BackColor != Color.LightGreen)
									{
										TextBox_IDmem3.BackColor = Color.LightGreen;
									}
								}
								else if (TextBox_IDmem3.BackColor != SystemColors.Window)
								{
									TextBox_IDmem3.BackColor = SystemColors.Window;
								}
								if ((_bot.TextBox_IDmem4 == _bot._IDmem4) & (_bot._IDmem4 > 0))
								{
									if (TextBox_IDmem4.BackColor != Color.LightGreen)
									{
										TextBox_IDmem4.BackColor = Color.LightGreen;
									}
								}
								else if (TextBox_IDmem4.BackColor != SystemColors.Window)
								{
									TextBox_IDmem4.BackColor = SystemColors.Window;
								}
								if (TextBox_IdLeader.BackColor != SystemColors.Window)
								{
									TextBox_IdLeader.BackColor = SystemColors.Window;
								}
							}
							else
							{
								if (TextBox_IDmem1.BackColor != SystemColors.Window)
								{
									TextBox_IDmem1.BackColor = SystemColors.Window;
								}
								if (TextBox_IDmem2.BackColor != SystemColors.Window)
								{
									TextBox_IDmem2.BackColor = SystemColors.Window;
								}
								if (TextBox_IDmem3.BackColor != SystemColors.Window)
								{
									TextBox_IDmem3.BackColor = SystemColors.Window;
								}
								if (TextBox_IDmem4.BackColor != SystemColors.Window)
								{
									TextBox_IDmem4.BackColor = SystemColors.Window;
								}
								if ((_bot.TextBox_IdLeader == bot.Data_Player._LeaderId) & (bot.Data_Player._LeaderId > 0) & (_bot.TextBox_IdLeader > 0))
								{
									if (TextBox_IdLeader.BackColor != Color.LightGreen)
									{
										TextBox_IdLeader.BackColor = Color.LightGreen;
									}
								}
								else if (TextBox_IdLeader.BackColor != SystemColors.Window)
								{
									TextBox_IdLeader.BackColor = SystemColors.Window;
								}
							}
						}
						else if (TextBox_IdLeader.BackColor != SystemColors.Window)
						{
							TextBox_IdLeader.BackColor = SystemColors.Window;
						}
					}
				}
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				ProjectData.ClearProjectError();
			}
			bot = null;
		}

	}
}
