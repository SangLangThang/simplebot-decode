using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Simple_Bot.ColorTables;
using Simple_Bot.Controls;
using Simple_Bot.My.Resources;
using Simple_Bot.Renderers;
using Simple_Bot.SPB;

namespace Simple_Bot
{
	public partial class frmClient : Form
	{
		internal virtual DataSet DataSet1
		{
			[CompilerGenerated]
			get => this.m_v;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => this.m_v = value;
		}

		internal virtual DataTable DataTable1
		{
			[CompilerGenerated]
			get => this.m_w;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => this.m_w = value;
		}

		internal virtual DataColumn DataColumn1
		{
			[CompilerGenerated]
			get => this.m_x;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => this.m_x = value;
		}

		internal virtual DataColumn DataColumn2
		{
			[CompilerGenerated]
			get => this.m_y;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => this.m_y = value;
		}

		internal virtual DataColumn DataColumn3
		{
			[CompilerGenerated]
			get => this.m_z;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => this.m_z = value;
		}

		internal virtual DataColumn DataColumn4
		{
			[CompilerGenerated]
			get => this.m_aa;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => this.m_aa = value;
		}

		internal virtual DataColumn DataColumn5
		{
			[CompilerGenerated]
			get => this.m_ab;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => this.m_ab = value;
		}

		internal virtual DataColumn DataColumn6
		{
			[CompilerGenerated]
			get => this.m_ac;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => this.m_ac = value;
		}

		internal virtual DataColumn DataColumn7
		{
			[CompilerGenerated]
			get => this.m_ad;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => this.m_ad = value;
		}

		internal virtual DataColumn DataColumn8
		{
			[CompilerGenerated]
			get => this.m_ae;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => this.m_ae = value;
		}

		internal virtual DataTable DataTable2
		{
			[CompilerGenerated]
			get => this.m_af;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => this.m_af = value;
		}

		internal virtual DataColumn DataColumn9
		{
			[CompilerGenerated]
			get => this.m_ag;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => this.m_ag = value;
		}

		internal virtual DataColumn DataColumn10
		{
			[CompilerGenerated]
			get => this.m_ah;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => this.m_ah = value;
		}

		internal virtual DataColumn DataColumn11
		{
			[CompilerGenerated]
			get => this.m_ai;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => this.m_ai = value;
		}

		internal virtual DataColumn DataColumn12
		{
			[CompilerGenerated]
			get => this.m_aj;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => this.m_aj = value;
		}

		internal virtual DataColumn DataColumn13
		{
			[CompilerGenerated]
			get => this.m_ak;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => this.m_ak = value;
		}

		internal virtual DataColumn DataColumn14
		{
			[CompilerGenerated]
			get => this.m_al;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => this.m_al = value;
		}

		internal virtual DataColumn DataColumn15
		{
			[CompilerGenerated]
			get => this.m_am;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => this.m_am = value;
		}

		internal virtual DataColumn DataColumn16
		{
			[CompilerGenerated]
			get => this.m_an;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => this.m_an = value;
		}

		internal virtual DataColumn DataColumn17
		{
			[CompilerGenerated]
			get => this.m_ao;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => this.m_ao = value;
		}

		internal virtual DataColumn DataColumn18
		{
			[CompilerGenerated]
			get => this.m_ap;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => this.m_ap = value;
		}

		internal virtual DataColumn DataColumn19
		{
			[CompilerGenerated]
			get => this.m_aq;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => this.m_aq = value;
		}

		internal virtual Label Label_PlayerCount
		{
			[CompilerGenerated]
			get => this.m_ar;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => this.m_ar = value;
		}

		internal virtual StatusBar StatusBar1
		{
			[CompilerGenerated]
			get => this.m_as;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => this.m_as = value;
		}

		internal virtual RadioButton RadioButton_dia
		{
			[CompilerGenerated]
			get
			{
				return this.m_at;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Settings_CheckedChanged;
				RadioButton radioButton = this.m_at;
				if (radioButton != null)
				{
					radioButton.CheckedChanged -= value2;
				}
				this.m_at = value;
				radioButton = this.m_at;
				if (radioButton != null)
				{
					radioButton.CheckedChanged += value2;
				}
			}
		}

		internal virtual RadioButton RadioButton_thuy
		{
			[CompilerGenerated]
			get
			{
				return this.m_au;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Settings_CheckedChanged;
				RadioButton radioButton = this.m_au;
				if (radioButton != null)
				{
					radioButton.CheckedChanged -= value2;
				}
				this.m_au = value;
				radioButton = this.m_au;
				if (radioButton != null)
				{
					radioButton.CheckedChanged += value2;
				}
			}
		}

		internal virtual RadioButton RadioButton_phong
		{
			[CompilerGenerated]
			get
			{
				return this.m_av;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Settings_CheckedChanged;
				RadioButton radioButton = this.m_av;
				if (radioButton != null)
				{
					radioButton.CheckedChanged -= value2;
				}
				this.m_av = value;
				radioButton = this.m_av;
				if (radioButton != null)
				{
					radioButton.CheckedChanged += value2;
				}
			}
		}

		internal virtual RadioButton RadioButton_hoa
		{
			[CompilerGenerated]
			get
			{
				return this.m_aw;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Settings_CheckedChanged;
				RadioButton radioButton = this.m_aw;
				if (radioButton != null)
				{
					radioButton.CheckedChanged -= value2;
				}
				this.m_aw = value;
				radioButton = this.m_aw;
				if (radioButton != null)
				{
					radioButton.CheckedChanged += value2;
				}
			}
		}

		internal virtual Label Label11
		{
			[CompilerGenerated]
			get => this.m_ax;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => this.m_ax = value;
		}

		internal virtual Label Label1
		{
			[CompilerGenerated]
			get => this.m_ay;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => this.m_ay = value;
		}

		internal virtual Label Label2
		{
			[CompilerGenerated]
			get => this.m_az;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => this.m_az = value;
		}

		internal virtual NumericUpDown NumericUpDown_createDef
		{
			[CompilerGenerated]
			get => this.m_a0;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => this.m_a0 = value;
		}

		internal virtual NumericUpDown NumericUpDown_createAtk
		{
			[CompilerGenerated]
			get => this.m_a1;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => this.m_a1 = value;
		}

		internal virtual Label Label16
		{
			[CompilerGenerated]
			get => this.m_a2;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => this.m_a2 = value;
		}

		internal virtual Label Label_point
		{
			[CompilerGenerated]
			get => this.m_a3;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => this.m_a3 = value;
		}

		internal virtual NumericUpDown NumericUpDown_createInt
		{
			[CompilerGenerated]
			get => this.m_a4;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => this.m_a4 = value;
		}

		internal virtual Label Label10
		{
			[CompilerGenerated]
			get => this.m_a5;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => this.m_a5 = value;
		}

		internal virtual NumericUpDown NumericUpDown_createAgi
		{
			[CompilerGenerated]
			get => this.m_a6;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => this.m_a6 = value;
		}

		internal virtual NumericUpDown NumericUpDown_createHp
		{
			[CompilerGenerated]
			get => this.m_a7;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => this.m_a7 = value;
		}

		internal virtual Label Label15
		{
			[CompilerGenerated]
			get => this.m_a8;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => this.m_a8 = value;
		}

		internal virtual NumericUpDown NumericUpDown_createSp
		{
			[CompilerGenerated]
			get => this.m_a9;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => this.m_a9 = value;
		}

		internal virtual Label Label14
		{
			[CompilerGenerated]
			get => this.m_ba;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => this.m_ba = value;
		}

		internal virtual Label Label17
		{
			[CompilerGenerated]
			get => this.m_bb;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => this.m_bb = value;
		}

		internal virtual ComboBox ComboBox_sex
		{
			[CompilerGenerated]
			get
			{
				return this.m_bc;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyPressEventHandler value2 = ComboBox_KeyPress_BlockInput;
				MouseEventHandler value3 = NoOpClickHandler;
				ComboBox comboBox = this.m_bc;
				if (comboBox != null)
				{
					comboBox.KeyPress -= value2;
					comboBox.MouseDown -= value3;
				}
				this.m_bc = value;
				comboBox = this.m_bc;
				if (comboBox != null)
				{
					comboBox.KeyPress += value2;
					comboBox.MouseDown += value3;
				}
			}
		}

		internal virtual Label Label19
		{
			[CompilerGenerated]
			get => this.m_bd;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => this.m_bd = value;
		}

		internal virtual Label Label18
		{
			[CompilerGenerated]
			get => this.m_be;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => this.m_be = value;
		}

		internal virtual TextBox TextBox_createName
		{
			[CompilerGenerated]
			get => this.m_bf;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => this.m_bf = value;
		}

		internal virtual TextBox TextBox_Pass
		{
			[CompilerGenerated]
			get => this.m_bg;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => this.m_bg = value;
		}

		internal virtual TextBox TextBox_amma
		{
			[CompilerGenerated]
			get => this.m_bh;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => this.m_bh = value;
		}

		internal virtual Button Button_StartAutoQuest
		{
			[CompilerGenerated]
			get
			{
				return this.m_bi;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button_StartAutoQuest_Click;
				Button button = this.m_bi;
				if (button != null)
				{
					button.Click -= value2;
				}
				this.m_bi = value;
				button = this.m_bi;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual ComboBox ComboBox_Quest
		{
			[CompilerGenerated]
			get
			{
				return this.m_bj;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyPressEventHandler value2 = ComboBox_KeyPress_BlockInput;
				MouseEventHandler value3 = NoOpClickHandler;
				EventHandler value4 = ComboBox_Quest_DropDown;
				EventHandler value5 = ComboBox_Quest_SelectedIndexChanged;
				ComboBox comboBox = this.m_bj;
				if (comboBox != null)
				{
					comboBox.KeyPress -= value2;
					comboBox.MouseDown -= value3;
					comboBox.DropDown -= value4;
					comboBox.SelectedIndexChanged -= value5;
				}
				this.m_bj = value;
				comboBox = this.m_bj;
				if (comboBox != null)
				{
					comboBox.KeyPress += value2;
					comboBox.MouseDown += value3;
					comboBox.DropDown += value4;
					comboBox.SelectedIndexChanged += value5;
				}
			}
		}

		internal virtual TreeView TreeView1
		{
			[CompilerGenerated]
			get
			{
				return this.m_bk;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				MouseEventHandler value2 = TreeView1_MouseDown;
				TreeView treeView = this.m_bk;
				if (treeView != null)
				{
					treeView.MouseDown -= value2;
				}
				this.m_bk = value;
				treeView = this.m_bk;
				if (treeView != null)
				{
					treeView.MouseDown += value2;
				}
			}
		}

		internal virtual TextBox TextBox_idWarp
		{
			[CompilerGenerated]
			get
			{
				return this.m_bl;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyPressEventHandler value2 = NumericTextBox_KeyPress;
				TextBox textBox = this.m_bl;
				if (textBox != null)
				{
					textBox.KeyPress -= value2;
				}
				this.m_bl = value;
				textBox = this.m_bl;
				if (textBox != null)
				{
					textBox.KeyPress += value2;
				}
			}
		}

		internal virtual Button Button_warp
		{
			[CompilerGenerated]
			get
			{
				return this.m_bm;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button_warp_Click;
				Button button = this.m_bm;
				if (button != null)
				{
					button.Click -= value2;
				}
				this.m_bm = value;
				button = this.m_bm;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual System.Windows.Forms.Timer Timer_100
		{
			[CompilerGenerated]
			get
			{
				return this.m_bn;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Timer_100_Tick;
				System.Windows.Forms.Timer timer = this.m_bn;
				if (timer != null)
				{
					timer.Tick -= value2;
				}
				this.m_bn = value;
				timer = this.m_bn;
				if (timer != null)
				{
					timer.Tick += value2;
				}
			}
		}

		internal virtual System.Windows.Forms.Timer Timer_autoquest
		{
			[CompilerGenerated]
			get
			{
				return this.m_bo;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Vs2010TabControl_Main_SelectedIndexChanged;
				System.Windows.Forms.Timer timer = this.m_bo;
				if (timer != null)
				{
					timer.Tick -= value2;
				}
				this.m_bo = value;
				timer = this.m_bo;
				if (timer != null)
				{
					timer.Tick += value2;
				}
			}
		}

		internal virtual System.Windows.Forms.Timer Timer_delay
		{
			[CompilerGenerated]
			get
			{
				return this.m_bp;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Timer_QuestDelay_Tick;
				System.Windows.Forms.Timer timer = this.m_bp;
				if (timer != null)
				{
					timer.Tick -= value2;
				}
				this.m_bp = value;
				timer = this.m_bp;
				if (timer != null)
				{
					timer.Tick += value2;
				}
			}
		}

		internal virtual ContextMenuStrip ContextMenuStrip_Warp
		{
			[CompilerGenerated]
			get => this.m_bq;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => this.m_bq = value;
		}

		internal virtual ToolStripMenuItem ToolStripMenuItem_Warp
		{
			[CompilerGenerated]
			get
			{
				return this.m_br;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button_WarpFromTree_Click;
				ToolStripMenuItem toolStripMenuItem = this.m_br;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				this.m_br = value;
				toolStripMenuItem = this.m_br;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual Button Button_bot
		{
			[CompilerGenerated]
			get
			{
				return this.m_bs;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button_bot_Click;
				Button button = this.m_bs;
				if (button != null)
				{
					button.Click -= value2;
				}
				this.m_bs = value;
				button = this.m_bs;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual ComboBox ComboBox_botname
		{
			[CompilerGenerated]
			get
			{
				return this.m_bt;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyPressEventHandler value2 = ComboBox_KeyPress_BlockInput;
				MouseEventHandler value3 = NoOpClickHandler;
				EventHandler value4 = ComboBox_botname_DropDown_RefreshList;
				EventHandler value5 = ComboBox_botname_SelectedIndexChanged_LoadScript;
				ComboBox comboBox = this.m_bt;
				if (comboBox != null)
				{
					comboBox.KeyPress -= value2;
					comboBox.MouseDown -= value3;
					comboBox.DropDown -= value4;
					comboBox.SelectedIndexChanged -= value5;
				}
				this.m_bt = value;
				comboBox = this.m_bt;
				if (comboBox != null)
				{
					comboBox.KeyPress += value2;
					comboBox.MouseDown += value3;
					comboBox.DropDown += value4;
					comboBox.SelectedIndexChanged += value5;
				}
			}
		}

		internal virtual Button Button_walk
		{
			[CompilerGenerated]
			get
			{
				return bu;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button_walk_Click;
				Button button = bu;
				if (button != null)
				{
					button.Click -= value2;
				}
				bu = value;
				button = bu;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual TextBox TextBox_walkY
		{
			[CompilerGenerated]
			get
			{
				return bv;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyPressEventHandler value2 = NumericTextBox_KeyPress;
				TextBox textBox = bv;
				if (textBox != null)
				{
					textBox.KeyPress -= value2;
				}
				bv = value;
				textBox = bv;
				if (textBox != null)
				{
					textBox.KeyPress += value2;
				}
			}
		}

		internal virtual TextBox TextBox_walkX
		{
			[CompilerGenerated]
			get
			{
				return bw;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyPressEventHandler value2 = NumericTextBox_KeyPress;
				TextBox textBox = bw;
				if (textBox != null)
				{
					textBox.KeyPress -= value2;
				}
				bw = value;
				textBox = bw;
				if (textBox != null)
				{
					textBox.KeyPress += value2;
				}
			}
		}

		internal virtual DataColumn DataColumn20
		{
			[CompilerGenerated]
			get => bx;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => bx = value;
		}

		internal virtual DataColumn DataColumn21
		{
			[CompilerGenerated]
			get => by;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => by = value;
		}

		internal virtual DataColumn DataColumn22
		{
			[CompilerGenerated]
			get => bz;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => bz = value;
		}

		internal virtual DataTable DataTable3
		{
			[CompilerGenerated]
			get => b0;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => b0 = value;
		}

		internal virtual DataColumn DataColumn23
		{
			[CompilerGenerated]
			get => b1;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => b1 = value;
		}

		internal virtual DataColumn DataColumn24
		{
			[CompilerGenerated]
			get => b2;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => b2 = value;
		}

		internal virtual DataColumn DataColumn25
		{
			[CompilerGenerated]
			get => b3;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => b3 = value;
		}

		internal virtual DataColumn DataColumn26
		{
			[CompilerGenerated]
			get => b4;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => b4 = value;
		}

		internal virtual DataColumn DataColumn27
		{
			[CompilerGenerated]
			get => b5;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => b5 = value;
		}

		internal virtual DataColumn DataColumn28
		{
			[CompilerGenerated]
			get => b6;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => b6 = value;
		}

		internal virtual DataColumn DataColumn29
		{
			[CompilerGenerated]
			get => b7;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => b7 = value;
		}

		internal virtual DataColumn DataColumn30
		{
			[CompilerGenerated]
			get => b8;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => b8 = value;
		}

		internal virtual DataColumn DataColumn31
		{
			[CompilerGenerated]
			get => b9;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => b9 = value;
		}

		internal virtual DataColumn DataColumn32
		{
			[CompilerGenerated]
			get => ca;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ca = value;
		}

		internal virtual DataColumn DataColumn33
		{
			[CompilerGenerated]
			get => cb;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => cb = value;
		}

		internal virtual DataColumn DataColumn34
		{
			[CompilerGenerated]
			get => cc;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => cc = value;
		}

		internal virtual Panel Panel_Chat
		{
			[CompilerGenerated]
			get => cd;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => cd = value;
		}

		internal virtual Label Label_CharExpMin
		{
			[CompilerGenerated]
			get => ce;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ce = value;
		}

		internal virtual Label Label4
		{
			[CompilerGenerated]
			get => cf;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => cf = value;
		}

		internal virtual Label Label_gold
		{
			[CompilerGenerated]
			get => cg;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => cg = value;
		}

		internal virtual ProgressBarEx ProgressBarEx_CharExp
		{
			[CompilerGenerated]
			get => ch;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ch = value;
		}

		internal virtual ProgressBarEx ProgressBarEx_CharSp
		{
			[CompilerGenerated]
			get => ci;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ci = value;
		}

		internal virtual ProgressBarEx ProgressBarEx_CharHp
		{
			[CompilerGenerated]
			get => cj;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => cj = value;
		}

		internal virtual GroupBox GroupBox_Bot
		{
			[CompilerGenerated]
			get => ck;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ck = value;
		}

		internal virtual TextBox TextBox_idWarp2
		{
			[CompilerGenerated]
			get
			{
				return cl;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyPressEventHandler value2 = NumericTextBox_KeyPress;
				TextBox textBox = cl;
				if (textBox != null)
				{
					textBox.KeyPress -= value2;
				}
				cl = value;
				textBox = cl;
				if (textBox != null)
				{
					textBox.KeyPress += value2;
				}
			}
		}

		internal virtual Button Button_warp2
		{
			[CompilerGenerated]
			get
			{
				return cm;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button_warp2_Click;
				Button button = cm;
				if (button != null)
				{
					button.Click -= value2;
				}
				cm = value;
				button = cm;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual StatusBarPanel StatusBarPanel_online
		{
			[CompilerGenerated]
			get => cn;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => cn = value;
		}

		internal virtual Label Label_Lv
		{
			[CompilerGenerated]
			get => co;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => co = value;
		}

		internal virtual Button Button_RequestParty
		{
			[CompilerGenerated]
			get
			{
				return cp;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button_InviteParty_Click;
				Button button = cp;
				if (button != null)
				{
					button.Click -= value2;
				}
				cp = value;
				button = cp;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual DataTable DataTable4
		{
			[CompilerGenerated]
			get => cq;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => cq = value;
		}

		internal virtual DataColumn DataColumn35
		{
			[CompilerGenerated]
			get => cr;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => cr = value;
		}

		internal virtual DataColumn DataColumn36
		{
			[CompilerGenerated]
			get => cs;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => cs = value;
		}

		internal virtual DataColumn DataColumn37
		{
			[CompilerGenerated]
			get => ct;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ct = value;
		}

		internal virtual DataColumn DataColumn38
		{
			[CompilerGenerated]
			get => cu;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => cu = value;
		}

		internal virtual DataColumn DataColumn39
		{
			[CompilerGenerated]
			get => cv;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => cv = value;
		}

		internal virtual DataTable DataTable5
		{
			[CompilerGenerated]
			get => cw;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => cw = value;
		}

		internal virtual DataColumn DataColumn40
		{
			[CompilerGenerated]
			get => cx;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => cx = value;
		}

		internal virtual DataColumn DataColumn41
		{
			[CompilerGenerated]
			get => cy;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => cy = value;
		}

		internal virtual DataColumn DataColumn42
		{
			[CompilerGenerated]
			get => cz;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => cz = value;
		}

		internal virtual DataColumn DataColumn43
		{
			[CompilerGenerated]
			get => c0;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => c0 = value;
		}

		internal virtual DataColumn DataColumn44
		{
			[CompilerGenerated]
			get => c1;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => c1 = value;
		}

		internal virtual DataTable DataTable6
		{
			[CompilerGenerated]
			get => c2;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => c2 = value;
		}

		internal virtual DataColumn DataColumn45
		{
			[CompilerGenerated]
			get => c3;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => c3 = value;
		}

		internal virtual DataColumn DataColumn46
		{
			[CompilerGenerated]
			get => c4;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => c4 = value;
		}

		internal virtual DataColumn DataColumn47
		{
			[CompilerGenerated]
			get => c5;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => c5 = value;
		}

		internal virtual DataColumn DataColumn48
		{
			[CompilerGenerated]
			get => c6;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => c6 = value;
		}

		internal virtual DataColumn DataColumn49
		{
			[CompilerGenerated]
			get => c7;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => c7 = value;
		}

		internal virtual DataColumn DataColumn50
		{
			[CompilerGenerated]
			get => c8;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => c8 = value;
		}

		internal virtual DataColumn DataColumn51
		{
			[CompilerGenerated]
			get => c9;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => c9 = value;
		}

		internal virtual DataColumn DataColumn52
		{
			[CompilerGenerated]
			get => da;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => da = value;
		}

		internal virtual DataTable DataTable7
		{
			[CompilerGenerated]
			get => db;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => db = value;
		}

		internal virtual DataTable DataTable8
		{
			[CompilerGenerated]
			get => dc;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => dc = value;
		}

		internal virtual DataColumn DataColumn53
		{
			[CompilerGenerated]
			get => dd;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => dd = value;
		}

		internal virtual DataColumn DataColumn54
		{
			[CompilerGenerated]
			get => de;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => de = value;
		}

		internal virtual DataColumn DataColumn55
		{
			[CompilerGenerated]
			get => df;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => df = value;
		}

		internal virtual DataColumn DataColumn56
		{
			[CompilerGenerated]
			get => dg;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => dg = value;
		}

		internal virtual DataColumn DataColumn57
		{
			[CompilerGenerated]
			get => dh;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => dh = value;
		}

		internal virtual DataColumn DataColumn58
		{
			[CompilerGenerated]
			get => di;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => di = value;
		}

		internal virtual DataColumn DataColumn59
		{
			[CompilerGenerated]
			get => dj;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => dj = value;
		}

		internal virtual DataColumn DataColumn60
		{
			[CompilerGenerated]
			get => dk;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => dk = value;
		}

		internal virtual DataColumn DataColumn61
		{
			[CompilerGenerated]
			get => dl;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => dl = value;
		}

		internal virtual DataColumn DataColumn62
		{
			[CompilerGenerated]
			get => dm;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => dm = value;
		}

		internal virtual DataColumn DataColumn63
		{
			[CompilerGenerated]
			get => dn;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => dn = value;
		}

		internal virtual DataColumn DataColumn64
		{
			[CompilerGenerated]
			get => dp;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => dp = value;
		}

		internal virtual DataColumn DataColumn65
		{
			[CompilerGenerated]
			get => dq;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => dq = value;
		}

		internal virtual DataColumn DataColumn66
		{
			[CompilerGenerated]
			get => dr;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => dr = value;
		}

		internal virtual DataColumn DataColumn67
		{
			[CompilerGenerated]
			get => ds;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ds = value;
		}

		internal virtual DataColumn DataColumn68
		{
			[CompilerGenerated]
			get => dt;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => dt = value;
		}

		internal virtual DataColumn DataColumn69
		{
			[CompilerGenerated]
			get => du;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => du = value;
		}

		internal virtual DataColumn DataColumn70
		{
			[CompilerGenerated]
			get => dv;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => dv = value;
		}

		internal virtual DataColumn DataColumn71
		{
			[CompilerGenerated]
			get => dw;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => dw = value;
		}

		internal virtual DataColumn DataColumn72
		{
			[CompilerGenerated]
			get => dx;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => dx = value;
		}

		internal virtual DataColumn DataColumn73
		{
			[CompilerGenerated]
			get => dy;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => dy = value;
		}

		internal virtual DataColumn DataColumn74
		{
			[CompilerGenerated]
			get => dz;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => dz = value;
		}

		internal virtual DataColumn DataColumn75
		{
			[CompilerGenerated]
			get => d0;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => d0 = value;
		}

		internal virtual DataColumn DataColumn76
		{
			[CompilerGenerated]
			get => d1;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => d1 = value;
		}

		internal virtual DataColumn DataColumn77
		{
			[CompilerGenerated]
			get => d2;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => d2 = value;
		}

		internal virtual DataColumn DataColumn78
		{
			[CompilerGenerated]
			get => d3;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => d3 = value;
		}

		internal virtual DataColumn DataColumn79
		{
			[CompilerGenerated]
			get => d4;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => d4 = value;
		}

		internal virtual DataColumn DataColumn80
		{
			[CompilerGenerated]
			get => d5;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => d5 = value;
		}

		internal virtual DataTable DataTable9
		{
			[CompilerGenerated]
			get => d6;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => d6 = value;
		}

		internal virtual DataColumn DataColumn81
		{
			[CompilerGenerated]
			get => d7;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => d7 = value;
		}

		internal virtual DataColumn DataColumn82
		{
			[CompilerGenerated]
			get => d8;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => d8 = value;
		}

		internal virtual DataColumn DataColumn83
		{
			[CompilerGenerated]
			get => d9;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => d9 = value;
		}

		internal virtual DataColumn DataColumn84
		{
			[CompilerGenerated]
			get => ea;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ea = value;
		}

		internal virtual DataColumn DataColumn85
		{
			[CompilerGenerated]
			get => eb;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => eb = value;
		}

		internal virtual DataColumn DataColumn86
		{
			[CompilerGenerated]
			get => ec;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ec = value;
		}

		internal virtual DataColumn DataColumn87
		{
			[CompilerGenerated]
			get => ed;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ed = value;
		}

		internal virtual DataColumn DataColumn88
		{
			[CompilerGenerated]
			get => ee;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ee = value;
		}

		internal virtual DataColumn DataColumn89
		{
			[CompilerGenerated]
			get => ef;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ef = value;
		}

		internal virtual DataColumn DataColumn90
		{
			[CompilerGenerated]
			get => eg;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => eg = value;
		}

		internal virtual DataColumn DataColumn91
		{
			[CompilerGenerated]
			get => eh;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => eh = value;
		}

		internal virtual DataColumn DataColumn92
		{
			[CompilerGenerated]
			get => ei;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ei = value;
		}

		internal virtual DataColumn DataColumn93
		{
			[CompilerGenerated]
			get => ej;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ej = value;
		}

		internal virtual DataColumn DataColumn94
		{
			[CompilerGenerated]
			get => ek;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ek = value;
		}

		internal virtual DataColumn DataColumn95
		{
			[CompilerGenerated]
			get => el;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => el = value;
		}

		internal virtual DataColumn DataColumn96
		{
			[CompilerGenerated]
			get => em;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => em = value;
		}

		internal virtual DataTable DataTable10
		{
			[CompilerGenerated]
			get => en;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => en = value;
		}

		internal virtual DataColumn DataColumn97
		{
			[CompilerGenerated]
			get => eo;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => eo = value;
		}

		internal virtual DataColumn DataColumn98
		{
			[CompilerGenerated]
			get => ep;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ep = value;
		}

		internal virtual DataColumn DataColumn99
		{
			[CompilerGenerated]
			get => eq;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => eq = value;
		}

		internal virtual DataColumn DataColumn100
		{
			[CompilerGenerated]
			get => er;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => er = value;
		}

		internal virtual DataColumn DataColumn101
		{
			[CompilerGenerated]
			get => es;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => es = value;
		}

		internal virtual DataColumn DataColumn102
		{
			[CompilerGenerated]
			get => et;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => et = value;
		}

		internal virtual DataColumn DataColumn103
		{
			[CompilerGenerated]
			get => eu;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => eu = value;
		}

		internal virtual DataColumn DataColumn104
		{
			[CompilerGenerated]
			get => ev;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ev = value;
		}

		internal virtual DataColumn DataColumn105
		{
			[CompilerGenerated]
			get => ew;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ew = value;
		}

		internal virtual DataColumn DataColumn106
		{
			[CompilerGenerated]
			get => ex;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ex = value;
		}

		internal virtual DataColumn DataColumn107
		{
			[CompilerGenerated]
			get => ey;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ey = value;
		}

		internal virtual DataColumn DataColumn108
		{
			[CompilerGenerated]
			get => ez;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ez = value;
		}

		internal virtual DataColumn DataColumn109
		{
			[CompilerGenerated]
			get => e0;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => e0 = value;
		}

		internal virtual Label Label_petlv
		{
			[CompilerGenerated]
			get => e1;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => e1 = value;
		}

		internal virtual ToolBarButton OpenButton
		{
			[CompilerGenerated]
			get => e2;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => e2 = value;
		}

		internal virtual ToolBarButton SaveButton
		{
			[CompilerGenerated]
			get => e3;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => e3 = value;
		}

		internal virtual Label Label_mapy
		{
			[CompilerGenerated]
			get => e4;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => e4 = value;
		}

		internal virtual Label Label_mapx
		{
			[CompilerGenerated]
			get => e5;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => e5 = value;
		}

		internal virtual Label Label_mapid
		{
			[CompilerGenerated]
			get => e6;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => e6 = value;
		}

		internal virtual StatusBarPanel StatusBarPanel_status
		{
			[CompilerGenerated]
			get => e7;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => e7 = value;
		}

		internal virtual ContextMenuStrip ContextMenuStrip_saveas
		{
			[CompilerGenerated]
			get => e8;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => e8 = value;
		}

		internal virtual Panel Panel5
		{
			[CompilerGenerated]
			get => e9;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => e9 = value;
		}

		internal virtual Panel Panel7
		{
			[CompilerGenerated]
			get => fa;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => fa = value;
		}

		internal virtual Button Button_InviteParty
		{
			[CompilerGenerated]
			get
			{
				return fb;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button_RequestParty_Click;
				Button button = fb;
				if (button != null)
				{
					button.Click -= value2;
				}
				fb = value;
				button = fb;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual DataTable DataTable11
		{
			[CompilerGenerated]
			get => fc;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => fc = value;
		}

		internal virtual DataColumn DataColumn111
		{
			[CompilerGenerated]
			get => fd;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => fd = value;
		}

		internal virtual DataColumn DataColumn112
		{
			[CompilerGenerated]
			get => fe;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => fe = value;
		}

		internal virtual DataColumn DataColumn113
		{
			[CompilerGenerated]
			get => ff;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ff = value;
		}

		internal virtual DataColumn DataColumn117
		{
			[CompilerGenerated]
			get => fg;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => fg = value;
		}

		internal virtual DataColumn DataColumn118
		{
			[CompilerGenerated]
			get => fh;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => fh = value;
		}

		internal virtual DataColumn DataColumn119
		{
			[CompilerGenerated]
			get => fi;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => fi = value;
		}

		internal virtual DataColumn DataColumn120
		{
			[CompilerGenerated]
			get => fj;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => fj = value;
		}

		internal virtual DataColumn DataColumn121
		{
			[CompilerGenerated]
			get => fk;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => fk = value;
		}

		internal virtual DataColumn DataColumn122
		{
			[CompilerGenerated]
			get => fl;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => fl = value;
		}

		internal virtual DataColumn DataColumn123
		{
			[CompilerGenerated]
			get => fm;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => fm = value;
		}

		internal virtual DataColumn DataColumn124
		{
			[CompilerGenerated]
			get => fn;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => fn = value;
		}

		internal virtual DataColumn DataColumn125
		{
			[CompilerGenerated]
			get => fo;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => fo = value;
		}

		internal virtual DataColumn DataColumn126
		{
			[CompilerGenerated]
			get => fp;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => fp = value;
		}

		internal virtual DataColumn DataColumn127
		{
			[CompilerGenerated]
			get => fq;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => fq = value;
		}

		internal virtual DataColumn DataColumn128
		{
			[CompilerGenerated]
			get => fr;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => fr = value;
		}

		internal virtual DataColumn DataColumn129
		{
			[CompilerGenerated]
			get => fs;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => fs = value;
		}

		internal virtual DataColumn DataColumn130
		{
			[CompilerGenerated]
			get => ft;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ft = value;
		}

		internal virtual DataColumn DataColumn131
		{
			[CompilerGenerated]
			get => fu;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => fu = value;
		}

		internal virtual DataColumn DataColumn132
		{
			[CompilerGenerated]
			get => fv;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => fv = value;
		}

		internal virtual DataColumn DataColumn133
		{
			[CompilerGenerated]
			get => fw;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => fw = value;
		}

		internal virtual DataColumn DataColumn134
		{
			[CompilerGenerated]
			get => fx;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => fx = value;
		}

		internal virtual DataColumn DataColumn135
		{
			[CompilerGenerated]
			get => fy;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => fy = value;
		}

		internal virtual DataColumn DataColumn136
		{
			[CompilerGenerated]
			get => fz;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => fz = value;
		}

		internal virtual DataColumn DataColumn137
		{
			[CompilerGenerated]
			get => f0;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => f0 = value;
		}

		internal virtual DataColumn DataColumn138
		{
			[CompilerGenerated]
			get => f1;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => f1 = value;
		}

		internal virtual DataColumn DataColumn139
		{
			[CompilerGenerated]
			get => f2;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => f2 = value;
		}

		internal virtual DataColumn DataColumn140
		{
			[CompilerGenerated]
			get => f3;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => f3 = value;
		}

		internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn1
		{
			[CompilerGenerated]
			get => f4;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => f4 = value;
		}

		internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn2
		{
			[CompilerGenerated]
			get => f5;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => f5 = value;
		}

		internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn3
		{
			[CompilerGenerated]
			get => f6;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => f6 = value;
		}

		internal virtual DataColumn DataColumn141
		{
			[CompilerGenerated]
			get => f7;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => f7 = value;
		}

		internal virtual DataColumn DataColumn142
		{
			[CompilerGenerated]
			get => f8;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => f8 = value;
		}

		internal virtual DataColumn DataColumn143
		{
			[CompilerGenerated]
			get => f9;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => f9 = value;
		}

		internal virtual DataColumn DataColumn144
		{
			[CompilerGenerated]
			get => ga;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ga = value;
		}

		internal virtual DataColumn DataColumn145
		{
			[CompilerGenerated]
			get => gb;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => gb = value;
		}

		internal virtual DataColumn DataColumn146
		{
			[CompilerGenerated]
			get => gc;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => gc = value;
		}

		internal virtual DataColumn DataColumn147
		{
			[CompilerGenerated]
			get => gd;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => gd = value;
		}

		internal virtual DataColumn DataColumn148
		{
			[CompilerGenerated]
			get => ge;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ge = value;
		}

		internal virtual DataColumn DataColumn149
		{
			[CompilerGenerated]
			get => gf;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => gf = value;
		}

		internal virtual DataColumn DataColumn150
		{
			[CompilerGenerated]
			get => gg;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => gg = value;
		}

		internal virtual DataColumn DataColumn151
		{
			[CompilerGenerated]
			get => gh;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => gh = value;
		}

		internal virtual DataColumn DataColumn152
		{
			[CompilerGenerated]
			get => gi;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => gi = value;
		}

		internal virtual DataColumn DataColumn153
		{
			[CompilerGenerated]
			get => gj;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => gj = value;
		}

		internal virtual DataColumn DataColumn154
		{
			[CompilerGenerated]
			get => gk;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => gk = value;
		}

		internal virtual DataColumn DataColumn155
		{
			[CompilerGenerated]
			get => gl;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => gl = value;
		}

		internal virtual DataColumn DataColumn156
		{
			[CompilerGenerated]
			get => gm;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => gm = value;
		}

		internal virtual DataColumn DataColumn157
		{
			[CompilerGenerated]
			get => gn;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => gn = value;
		}

		internal virtual DataColumn DataColumn158
		{
			[CompilerGenerated]
			get => go;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => go = value;
		}

		internal virtual DataColumn DataColumn159
		{
			[CompilerGenerated]
			get => gp;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => gp = value;
		}

		internal virtual DataColumn DataColumn160
		{
			[CompilerGenerated]
			get => gq;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => gq = value;
		}

		internal virtual DataColumn DataColumn161
		{
			[CompilerGenerated]
			get => gr;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => gr = value;
		}

		internal virtual DataColumn DataColumn162
		{
			[CompilerGenerated]
			get => gs;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => gs = value;
		}

		internal virtual DataColumn DataColumn163
		{
			[CompilerGenerated]
			get => gt;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => gt = value;
		}

		internal virtual DataColumn DataColumn164
		{
			[CompilerGenerated]
			get => gu;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => gu = value;
		}

		internal virtual DataColumn DataColumn165
		{
			[CompilerGenerated]
			get => gv;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => gv = value;
		}

		internal virtual DataColumn DataColumn166
		{
			[CompilerGenerated]
			get => gw;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => gw = value;
		}

		internal virtual DataColumn DataColumn167
		{
			[CompilerGenerated]
			get => gx;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => gx = value;
		}

		internal virtual DataColumn DataColumn168
		{
			[CompilerGenerated]
			get => gy;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => gy = value;
		}

		internal virtual DataColumn DataColumn169
		{
			[CompilerGenerated]
			get => gz;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => gz = value;
		}

		internal virtual DataColumn DataColumn170
		{
			[CompilerGenerated]
			get => g0;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => g0 = value;
		}

		internal virtual DataColumn DataColumn171
		{
			[CompilerGenerated]
			get => g1;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => g1 = value;
		}

		internal virtual DataColumn DataColumn172
		{
			[CompilerGenerated]
			get => g2;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => g2 = value;
		}

		internal virtual DataColumn DataColumn173
		{
			[CompilerGenerated]
			get => g3;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => g3 = value;
		}

		internal virtual DataColumn DataColumn174
		{
			[CompilerGenerated]
			get => g4;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => g4 = value;
		}

		internal virtual DataColumn DataColumn175
		{
			[CompilerGenerated]
			get => g5;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => g5 = value;
		}

		internal virtual DataColumn DataColumn176
		{
			[CompilerGenerated]
			get => g6;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => g6 = value;
		}

		internal virtual DataColumn DataColumn177
		{
			[CompilerGenerated]
			get => g7;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => g7 = value;
		}

		internal virtual DataColumn DataColumn178
		{
			[CompilerGenerated]
			get => g8;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => g8 = value;
		}

		internal virtual DataColumn DataColumn179
		{
			[CompilerGenerated]
			get => g9;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => g9 = value;
		}

		internal virtual DataColumn DataColumn180
		{
			[CompilerGenerated]
			get => ha;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ha = value;
		}

		internal virtual DataColumn DataColumn181
		{
			[CompilerGenerated]
			get => hb;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => hb = value;
		}

		internal virtual DataColumn DataColumn182
		{
			[CompilerGenerated]
			get => hc;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => hc = value;
		}

		internal virtual DataColumn DataColumn183
		{
			[CompilerGenerated]
			get => hd;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => hd = value;
		}

		internal virtual DataColumn DataColumn184
		{
			[CompilerGenerated]
			get => he;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => he = value;
		}

		internal virtual DataColumn DataColumn185
		{
			[CompilerGenerated]
			get => hf;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => hf = value;
		}

		internal virtual DataColumn DataColumn186
		{
			[CompilerGenerated]
			get => hg;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => hg = value;
		}

		internal virtual DataColumn DataColumn187
		{
			[CompilerGenerated]
			get => hh;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => hh = value;
		}

		internal virtual DataColumn DataColumn188
		{
			[CompilerGenerated]
			get => hi;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => hi = value;
		}

		internal virtual DataColumn DataColumn114
		{
			[CompilerGenerated]
			get => hj;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => hj = value;
		}

		internal virtual DataColumn DataColumn115
		{
			[CompilerGenerated]
			get => hk;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => hk = value;
		}

		internal virtual DataColumn DataColumn116
		{
			[CompilerGenerated]
			get => hl;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => hl = value;
		}

		internal virtual DataColumn DataColumn189
		{
			[CompilerGenerated]
			get => hm;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => hm = value;
		}

		internal virtual DataColumn DataColumn190
		{
			[CompilerGenerated]
			get => hn;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => hn = value;
		}

	}
}
