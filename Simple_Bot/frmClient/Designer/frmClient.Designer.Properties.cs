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
		internal virtual RichTextBox rtbsystem
		{
			[CompilerGenerated]
			get => this.m_b;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => this.m_b = value;
		}

		internal virtual GroupBox GroupBox_team
		{
			[CompilerGenerated]
			get => this.m_c;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => this.m_c = value;
		}

		internal virtual RadioButton RadioButton_QS4
		{
			[CompilerGenerated]
			get
			{
				return this.m_d;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Settings_CheckedChanged;
				RadioButton radioButton = this.m_d;
				if (radioButton != null)
				{
					radioButton.CheckedChanged -= value2;
				}
				this.m_d = value;
				radioButton = this.m_d;
				if (radioButton != null)
				{
					radioButton.CheckedChanged += value2;
				}
			}
		}

		internal virtual RadioButton RadioButton_QS3
		{
			[CompilerGenerated]
			get
			{
				return this.m_e;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Settings_CheckedChanged;
				RadioButton radioButton = this.m_e;
				if (radioButton != null)
				{
					radioButton.CheckedChanged -= value2;
				}
				this.m_e = value;
				radioButton = this.m_e;
				if (radioButton != null)
				{
					radioButton.CheckedChanged += value2;
				}
			}
		}

		internal virtual RadioButton RadioButton_QS2
		{
			[CompilerGenerated]
			get
			{
				return this.m_f;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Settings_CheckedChanged;
				RadioButton radioButton = this.m_f;
				if (radioButton != null)
				{
					radioButton.CheckedChanged -= value2;
				}
				this.m_f = value;
				radioButton = this.m_f;
				if (radioButton != null)
				{
					radioButton.CheckedChanged += value2;
				}
			}
		}

		internal virtual RadioButton RadioButton_QS1
		{
			[CompilerGenerated]
			get
			{
				return this.m_g;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Settings_CheckedChanged;
				RadioButton radioButton = this.m_g;
				if (radioButton != null)
				{
					radioButton.CheckedChanged -= value2;
				}
				this.m_g = value;
				radioButton = this.m_g;
				if (radioButton != null)
				{
					radioButton.CheckedChanged += value2;
				}
			}
		}

		internal virtual TextBox TextBox_IDmem1
		{
			[CompilerGenerated]
			get
			{
				return this.m_h;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyPressEventHandler value2 = NumericTextBox_KeyPress;
				EventHandler value3 = TextBox_NumericValue_TextChanged;
				TextBox textBox = this.m_h;
				if (textBox != null)
				{
					textBox.KeyPress -= value2;
					textBox.TextChanged -= value3;
				}
				this.m_h = value;
				textBox = this.m_h;
				if (textBox != null)
				{
					textBox.KeyPress += value2;
					textBox.TextChanged += value3;
				}
			}
		}

		internal virtual TextBox TextBox_IDmem4
		{
			[CompilerGenerated]
			get
			{
				return this.m_i;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyPressEventHandler value2 = NumericTextBox_KeyPress;
				EventHandler value3 = TextBox_NumericValue_TextChanged;
				TextBox textBox = this.m_i;
				if (textBox != null)
				{
					textBox.KeyPress -= value2;
					textBox.TextChanged -= value3;
				}
				this.m_i = value;
				textBox = this.m_i;
				if (textBox != null)
				{
					textBox.KeyPress += value2;
					textBox.TextChanged += value3;
				}
			}
		}

		internal virtual TextBox TextBox_IDmem3
		{
			[CompilerGenerated]
			get
			{
				return this.m_j;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyPressEventHandler value2 = NumericTextBox_KeyPress;
				EventHandler value3 = TextBox_NumericValue_TextChanged;
				TextBox textBox = this.m_j;
				if (textBox != null)
				{
					textBox.KeyPress -= value2;
					textBox.TextChanged -= value3;
				}
				this.m_j = value;
				textBox = this.m_j;
				if (textBox != null)
				{
					textBox.KeyPress += value2;
					textBox.TextChanged += value3;
				}
			}
		}

		internal virtual TextBox TextBox_IDmem2
		{
			[CompilerGenerated]
			get
			{
				return this.m_k;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyPressEventHandler value2 = NumericTextBox_KeyPress;
				EventHandler value3 = TextBox_NumericValue_TextChanged;
				TextBox textBox = this.m_k;
				if (textBox != null)
				{
					textBox.KeyPress -= value2;
					textBox.TextChanged -= value3;
				}
				this.m_k = value;
				textBox = this.m_k;
				if (textBox != null)
				{
					textBox.KeyPress += value2;
					textBox.TextChanged += value3;
				}
			}
		}

		internal virtual TextBox TextBox_IdLeader
		{
			[CompilerGenerated]
			get
			{
				return this.m_l;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = TextBox_NumericValue_TextChanged;
				TextBox textBox = this.m_l;
				if (textBox != null)
				{
					textBox.TextChanged -= value2;
				}
				this.m_l = value;
				textBox = this.m_l;
				if (textBox != null)
				{
					textBox.TextChanged += value2;
				}
			}
		}

		internal virtual Label Label_PetExpMin
		{
			[CompilerGenerated]
			get => this.m_m;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => this.m_m = value;
		}

		internal virtual ProgressBarEx ProgressBarEx_PetHp
		{
			[CompilerGenerated]
			get => this.m_n;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => this.m_n = value;
		}

		internal virtual Label Label8
		{
			[CompilerGenerated]
			get => this.m_o;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => this.m_o = value;
		}

		internal virtual ProgressBarEx ProgressBarEx_PetSp
		{
			[CompilerGenerated]
			get => this.m_p;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => this.m_p = value;
		}

		internal virtual ProgressBarEx ProgressBarEx_PetExp
		{
			[CompilerGenerated]
			get => this.m_q;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => this.m_q = value;
		}

		internal virtual RichTextBox RtbChat
		{
			[CompilerGenerated]
			get => this.m_r;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => this.m_r = value;
		}

		internal virtual ComboBox ComboBox_chat
		{
			[CompilerGenerated]
			get
			{
				return this.m_s;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyPressEventHandler value2 = ComboBox_chat_KeyPress;
				ComboBox comboBox = this.m_s;
				if (comboBox != null)
				{
					comboBox.KeyPress -= value2;
				}
				this.m_s = value;
				comboBox = this.m_s;
				if (comboBox != null)
				{
					comboBox.KeyPress += value2;
				}
			}
		}

		internal virtual ComboBox ComboBox_nameprivate
		{
			[CompilerGenerated]
			get
			{
				return this.m_t;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = ComboBox_nameprivate_TextChanged;
				ComboBox comboBox = this.m_t;
				if (comboBox != null)
				{
					comboBox.TextChanged -= value2;
				}
				this.m_t = value;
				comboBox = this.m_t;
				if (comboBox != null)
				{
					comboBox.TextChanged += value2;
				}
			}
		}

		internal virtual ComboBox ComboBox_kenh
		{
			[CompilerGenerated]
			get
			{
				return this.m_u;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyPressEventHandler value2 = ComboBox_KeyPress_BlockInput;
				MouseEventHandler value3 = NoOpClickHandler;
				ComboBox comboBox = this.m_u;
				if (comboBox != null)
				{
					comboBox.KeyPress -= value2;
					comboBox.MouseDown -= value3;
				}
				this.m_u = value;
				comboBox = this.m_u;
				if (comboBox != null)
				{
					comboBox.KeyPress += value2;
					comboBox.MouseDown += value3;
				}
			}
		}


		internal virtual Button Button_BattleInfo
		{
			[CompilerGenerated]
			get
			{
				return zf;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button_BattleInfo_Click;
				Button button = zf;
				if (button != null)
				{
					button.Click -= value2;
				}
				zf = value;
				button = zf;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual Label Label55
		{
			[CompilerGenerated]
			get => zg;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => zg = value;
		}

		internal virtual ListView ListView_AutoDrop
		{
			[CompilerGenerated]
			get
			{
				return zh;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				MouseEventHandler value2 = Button_AutoSort_Click;
				ListView listView = zh;
				if (listView != null)
				{
					listView.MouseDoubleClick -= value2;
				}
				zh = value;
				listView = zh;
				if (listView != null)
				{
					listView.MouseDoubleClick += value2;
				}
			}
		}

		internal virtual ColumnHeader ColumnHeader_Id
		{
			[CompilerGenerated]
			get => zi;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => zi = value;
		}

		internal virtual ColumnHeader ColumnHeader_Name
		{
			[CompilerGenerated]
			get => zj;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => zj = value;
		}

		internal virtual ListView ListView_AutoContribute
		{
			[CompilerGenerated]
			get
			{
				return zk;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				MouseEventHandler value2 = Button_AutoSort_Click;
				ListView listView = zk;
				if (listView != null)
				{
					listView.MouseDoubleClick -= value2;
				}
				zk = value;
				listView = zk;
				if (listView != null)
				{
					listView.MouseDoubleClick += value2;
				}
			}
		}

		internal virtual ColumnHeader ColumnHeader1
		{
			[CompilerGenerated]
			get => zl;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => zl = value;
		}

		internal virtual ColumnHeader ColumnHeader2
		{
			[CompilerGenerated]
			get => zm;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => zm = value;
		}

		internal virtual ListView ListView_AutoSend
		{
			[CompilerGenerated]
			get
			{
				return zn;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				MouseEventHandler value2 = Button_AutoSort_Click;
				ListView listView = zn;
				if (listView != null)
				{
					listView.MouseDoubleClick -= value2;
				}
				zn = value;
				listView = zn;
				if (listView != null)
				{
					listView.MouseDoubleClick += value2;
				}
			}
		}

		internal virtual ColumnHeader ColumnHeader3
		{
			[CompilerGenerated]
			get => zo;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => zo = value;
		}

		internal virtual ColumnHeader ColumnHeader4
		{
			[CompilerGenerated]
			get => zp;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => zp = value;
		}

		internal virtual ListView ListView_AutoSell
		{
			[CompilerGenerated]
			get
			{
				return zq;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				MouseEventHandler value2 = Button_AutoSort_Click;
				ListView listView = zq;
				if (listView != null)
				{
					listView.MouseDoubleClick -= value2;
				}
				zq = value;
				listView = zq;
				if (listView != null)
				{
					listView.MouseDoubleClick += value2;
				}
			}
		}

		internal virtual ColumnHeader ColumnHeader10
		{
			[CompilerGenerated]
			get => zr;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => zr = value;
		}

		internal virtual ColumnHeader ColumnHeader11
		{
			[CompilerGenerated]
			get => zs;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => zs = value;
		}

		internal virtual CheckBox CheckBox_Autosort
		{
			[CompilerGenerated]
			get
			{
				return zt;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Settings_CheckedChanged;
				CheckBox checkBox = zt;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				zt = value;
				checkBox = zt;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		internal virtual Label Label56
		{
			[CompilerGenerated]
			get => zu;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => zu = value;
		}

		internal virtual TextBox TextBox_ClickMOD_Delay
		{
			[CompilerGenerated]
			get
			{
				return zv;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyPressEventHandler value2 = NumericTextBox_KeyPress;
				EventHandler value3 = TextBox_NumericValue_TextChanged;
				TextBox textBox = zv;
				if (textBox != null)
				{
					textBox.KeyPress -= value2;
					textBox.TextChanged -= value3;
				}
				zv = value;
				textBox = zv;
				if (textBox != null)
				{
					textBox.KeyPress += value2;
					textBox.TextChanged += value3;
				}
			}
		}

		internal virtual ComboBox ComboBox_Port
		{
			[CompilerGenerated]
			get
			{
				return zw;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyPressEventHandler value2 = ComboBox_KeyPress_BlockInput;
				MouseEventHandler value3 = NoOpClickHandler;
				EventHandler value4 = ComboBox_Port_SelectedIndexChanged;
				ComboBox comboBox = zw;
				if (comboBox != null)
				{
					comboBox.KeyPress -= value2;
					comboBox.MouseDown -= value3;
					comboBox.SelectedIndexChanged -= value4;
				}
				zw = value;
				comboBox = zw;
				if (comboBox != null)
				{
					comboBox.KeyPress += value2;
					comboBox.MouseDown += value3;
					comboBox.SelectedIndexChanged += value4;
				}
			}
		}

		internal virtual RichTextBox RtbQuest
		{
			[CompilerGenerated]
			get => zx;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => zx = value;
		}

		internal virtual CheckBox CheckBox_DCFullHomDo
		{
			[CompilerGenerated]
			get
			{
				return zy;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Settings_CheckedChanged;
				CheckBox checkBox = zy;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				zy = value;
				checkBox = zy;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		internal virtual ColumnHeader ColumnHeader12
		{
			[CompilerGenerated]
			get => zz;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => zz = value;
		}

		internal virtual ColumnHeader ColumnHeader13
		{
			[CompilerGenerated]
			get => z0;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => z0 = value;
		}

		internal virtual ColumnHeader ColumnHeader14
		{
			[CompilerGenerated]
			get => z1;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => z1 = value;
		}

		internal virtual DataGridView DataGridView1
		{
			[CompilerGenerated]
			get => z2;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => z2 = value;
		}

		internal virtual Label Label_Lv2
		{
			[CompilerGenerated]
			get => z3;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => z3 = value;
		}

		internal virtual Label Label_Lv_Plus
		{
			[CompilerGenerated]
			get => z4;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => z4 = value;
		}

		internal virtual DataGridViewCheckBoxColumn Column_Quest_check
		{
			[CompilerGenerated]
			get => z5;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => z5 = value;
		}

		internal virtual DataGridViewTextBoxColumn Column_Quest_Func
		{
			[CompilerGenerated]
			get => z6;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => z6 = value;
		}

		internal virtual DataGridViewTextBoxColumn Column_Quest_Id
		{
			[CompilerGenerated]
			get => z7;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => z7 = value;
		}

		internal virtual DataGridViewTextBoxColumn Column_Quest_Info
		{
			[CompilerGenerated]
			get => z8;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => z8 = value;
		}

		internal virtual ComboBox ComboBox_ShopType
		{
			[CompilerGenerated]
			get => z9;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => z9 = value;
		}

		internal virtual Label Label38
		{
			[CompilerGenerated]
			get => aaa;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => aaa = value;
		}

		internal virtual Label Label_ShopName
		{
			[CompilerGenerated]
			get => aab;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => aab = value;
		}

		internal virtual TextBox TextBox_ShopName
		{
			[CompilerGenerated]
			get => aac;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => aac = value;
		}

		internal virtual Label Label40
		{
			[CompilerGenerated]
			get => aad;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => aad = value;
		}

		internal virtual Label Label39
		{
			[CompilerGenerated]
			get => aae;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => aae = value;
		}

		internal virtual TextBox TextBox_ShopAddPrice
		{
			[CompilerGenerated]
			get
			{
				return aaf;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyPressEventHandler value2 = NumericTextBox_KeyPress;
				EventHandler value3 = TextBox_NumericValue_TextChanged;
				TextBox textBox = aaf;
				if (textBox != null)
				{
					textBox.KeyPress -= value2;
					textBox.TextChanged -= value3;
				}
				aaf = value;
				textBox = aaf;
				if (textBox != null)
				{
					textBox.KeyPress += value2;
					textBox.TextChanged += value3;
				}
			}
		}

		internal virtual TextBox TextBox_ShopAddId
		{
			[CompilerGenerated]
			get
			{
				return aag;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyPressEventHandler value2 = NumericTextBox_KeyPress;
				EventHandler value3 = TextBox_NumericValue_TextChanged;
				TextBox textBox = aag;
				if (textBox != null)
				{
					textBox.KeyPress -= value2;
					textBox.TextChanged -= value3;
				}
				aag = value;
				textBox = aag;
				if (textBox != null)
				{
					textBox.KeyPress += value2;
					textBox.TextChanged += value3;
				}
			}
		}

		internal virtual Button Button_Shop_Start
		{
			[CompilerGenerated]
			get
			{
				return aah;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button_Shop_Start_Click;
				Button button = aah;
				if (button != null)
				{
					button.Click -= value2;
				}
				aah = value;
				button = aah;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual ListView ListView_Shop
		{
			[CompilerGenerated]
			get
			{
				return aai;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				MouseEventHandler value2 = Button_AutoSort_Click;
				ListView listView = aai;
				if (listView != null)
				{
					listView.MouseDoubleClick -= value2;
				}
				aai = value;
				listView = aai;
				if (listView != null)
				{
					listView.MouseDoubleClick += value2;
				}
			}
		}

		internal virtual ColumnHeader ColumnHeader15
		{
			[CompilerGenerated]
			get => aaj;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => aaj = value;
		}

		internal virtual ColumnHeader ColumnHeader16
		{
			[CompilerGenerated]
			get => aak;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => aak = value;
		}

		internal virtual ColumnHeader ColumnHeader17
		{
			[CompilerGenerated]
			get => aal;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => aal = value;
		}

		internal virtual Button Button_ShopAdd
		{
			[CompilerGenerated]
			get
			{
				return aam;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button_ShopAddItem_Click;
				Button button = aam;
				if (button != null)
				{
					button.Click -= value2;
				}
				aam = value;
				button = aam;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem ToolStripMenuItem_AddToShop
		{
			[CompilerGenerated]
			get
			{
				return aan;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = MenuItem_AddToShop_Click;
				ToolStripMenuItem toolStripMenuItem = aan;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				aan = value;
				toolStripMenuItem = aan;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual Label Label42
		{
			[CompilerGenerated]
			get => aao;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => aao = value;
		}

		internal virtual NumericUpDown NumericUpDown_sendpacket
		{
			[CompilerGenerated]
			get => aap;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => aap = value;
		}

		internal virtual Label Label41
		{
			[CompilerGenerated]
			get => aaq;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => aaq = value;
		}

		internal virtual TextBox TextBox_idQC
		{
			[CompilerGenerated]
			get => aar;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => aar = value;
		}

		internal virtual CheckBox CheckBox_QC
		{
			[CompilerGenerated]
			get => aas;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => aas = value;
		}

		internal virtual System.Windows.Forms.Timer Timer_QC
		{
			[CompilerGenerated]
			get
			{
				return aat;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Timer_QC_Tick;
				System.Windows.Forms.Timer timer = aat;
				if (timer != null)
				{
					timer.Tick -= value2;
				}
				aat = value;
				timer = aat;
				if (timer != null)
				{
					timer.Tick += value2;
				}
			}
		}

		internal virtual PictureBox PictureBox1
		{
			[CompilerGenerated]
			get
			{
				return aau;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				MouseEventHandler value2 = PictureBox1_MouseDown;
				PictureBox pictureBox = aau;
				if (pictureBox != null)
				{
					pictureBox.MouseClick -= value2;
				}
				aau = value;
				pictureBox = aau;
				if (pictureBox != null)
				{
					pictureBox.MouseClick += value2;
				}
			}
		}

		internal virtual GroupBox GroupBox12
		{
			[CompilerGenerated]
			get => aav;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => aav = value;
		}

		internal virtual Button Button_Mini_Warp
		{
			[CompilerGenerated]
			get
			{
				return aaw;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = ComboBox_Mini_Warp_SelectedIndexChanged;
				Button button = aaw;
				if (button != null)
				{
					button.Click -= value2;
				}
				aaw = value;
				button = aaw;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual ComboBox ComboBox_Mini_Warp
		{
			[CompilerGenerated]
			get
			{
				return aax;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = ComboBox_Mini_Warp_Populate;
				ComboBox comboBox = aax;
				if (comboBox != null)
				{
					comboBox.DropDown -= value2;
				}
				aax = value;
				comboBox = aax;
				if (comboBox != null)
				{
					comboBox.DropDown += value2;
				}
			}
		}

		internal virtual Button Button_Func
		{
			[CompilerGenerated]
			get
			{
				return aay;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button_QuestScriptHelp_Click;
				Button button = aay;
				if (button != null)
				{
					button.Click -= value2;
				}
				aay = value;
				button = aay;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual ListView ListView_Quest
		{
			[CompilerGenerated]
			get => aaz;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => aaz = value;
		}

		internal virtual ColumnHeader ColumnHeader19
		{
			[CompilerGenerated]
			get => aa0;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => aa0 = value;
		}

		internal virtual Button Button_Quest_Refresh
		{
			[CompilerGenerated]
			get
			{
				return aa1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button_RefreshQuestList_Click;
				Button button = aa1;
				if (button != null)
				{
					button.Click -= value2;
				}
				aa1 = value;
				button = aa1;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual Button Button2
		{
			[CompilerGenerated]
			get
			{
				return aa2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button_CheckSpecificQuests_Click;
				Button button = aa2;
				if (button != null)
				{
					button.Click -= value2;
				}
				aa2 = value;
				button = aa2;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual Label Lb_tuido25
		{
			[CompilerGenerated]
			get => aa3;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => aa3 = value;
		}

		internal virtual Label Lb_tuido24
		{
			[CompilerGenerated]
			get => aa4;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => aa4 = value;
		}

		internal virtual Label Lb_tuido23
		{
			[CompilerGenerated]
			get => aa5;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => aa5 = value;
		}

		internal virtual Label Lb_tuido22
		{
			[CompilerGenerated]
			get => aa6;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => aa6 = value;
		}

		internal virtual Label Lb_tuido21
		{
			[CompilerGenerated]
			get => aa7;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => aa7 = value;
		}

		internal virtual Label Lb_tuido20
		{
			[CompilerGenerated]
			get => aa8;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => aa8 = value;
		}

		internal virtual Label Lb_tuido19
		{
			[CompilerGenerated]
			get => aa9;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => aa9 = value;
		}

		internal virtual Label Lb_tuido18
		{
			[CompilerGenerated]
			get => aba;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => aba = value;
		}

		internal virtual Label Lb_tuido17
		{
			[CompilerGenerated]
			get => abb;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => abb = value;
		}

		internal virtual Label Lb_tuido16
		{
			[CompilerGenerated]
			get => abc;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => abc = value;
		}

		internal virtual Label Lb_tuido15
		{
			[CompilerGenerated]
			get => abd;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => abd = value;
		}

		internal virtual Label Lb_tuido14
		{
			[CompilerGenerated]
			get => abe;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => abe = value;
		}

		internal virtual Label Lb_tuido13
		{
			[CompilerGenerated]
			get => abf;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => abf = value;
		}

		internal virtual Label Lb_tuido12
		{
			[CompilerGenerated]
			get => abg;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => abg = value;
		}

		internal virtual Label Lb_tuido11
		{
			[CompilerGenerated]
			get => abh;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => abh = value;
		}

		internal virtual Label Lb_tuido10
		{
			[CompilerGenerated]
			get => abi;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => abi = value;
		}

		internal virtual Label Lb_tuido9
		{
			[CompilerGenerated]
			get => abj;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => abj = value;
		}

		internal virtual Label Lb_tuido8
		{
			[CompilerGenerated]
			get => abk;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => abk = value;
		}

		internal virtual Label Lb_tuido7
		{
			[CompilerGenerated]
			get => abl;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => abl = value;
		}

		internal virtual Label Lb_tuido6
		{
			[CompilerGenerated]
			get => abm;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => abm = value;
		}

		internal virtual Label Lb_tuido5
		{
			[CompilerGenerated]
			get => abn;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => abn = value;
		}

		internal virtual Label Lb_tuido4
		{
			[CompilerGenerated]
			get => abo;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => abo = value;
		}

		internal virtual Label Lb_tuido3
		{
			[CompilerGenerated]
			get => abp;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => abp = value;
		}

		internal virtual Label Lb_tuido2
		{
			[CompilerGenerated]
			get => abq;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => abq = value;
		}

		internal virtual Label Lb_tuido1
		{
			[CompilerGenerated]
			get => abr;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => abr = value;
		}

		internal virtual Label Lb_tuideo25
		{
			[CompilerGenerated]
			get => abs;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => abs = value;
		}

		internal virtual Label Lb_tuideo24
		{
			[CompilerGenerated]
			get => abt;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => abt = value;
		}

		internal virtual Label Lb_tuideo23
		{
			[CompilerGenerated]
			get => abu;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => abu = value;
		}

		internal virtual Label Lb_tuideo22
		{
			[CompilerGenerated]
			get => abv;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => abv = value;
		}

		internal virtual Label Lb_tuideo21
		{
			[CompilerGenerated]
			get => abw;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => abw = value;
		}

		internal virtual Label Lb_tuideo20
		{
			[CompilerGenerated]
			get => abx;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => abx = value;
		}

		internal virtual Label Lb_tuideo19
		{
			[CompilerGenerated]
			get => aby;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => aby = value;
		}

		internal virtual Label Lb_tuideo18
		{
			[CompilerGenerated]
			get => abz;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => abz = value;
		}

		internal virtual Label Lb_tuideo17
		{
			[CompilerGenerated]
			get => ab0;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ab0 = value;
		}

		internal virtual Label Lb_tuideo16
		{
			[CompilerGenerated]
			get => ab1;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ab1 = value;
		}

		internal virtual Label Lb_tuideo15
		{
			[CompilerGenerated]
			get => ab2;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ab2 = value;
		}

		internal virtual Label Lb_tuideo14
		{
			[CompilerGenerated]
			get => ab3;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ab3 = value;
		}

		internal virtual Label Lb_tuideo13
		{
			[CompilerGenerated]
			get => ab4;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ab4 = value;
		}

		internal virtual Label Lb_tuideo12
		{
			[CompilerGenerated]
			get => ab5;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ab5 = value;
		}

		internal virtual Label Lb_tuideo11
		{
			[CompilerGenerated]
			get => ab6;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ab6 = value;
		}

		internal virtual Label Lb_tuideo10
		{
			[CompilerGenerated]
			get => ab7;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ab7 = value;
		}

		internal virtual Label Lb_tuideo9
		{
			[CompilerGenerated]
			get => ab8;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ab8 = value;
		}

		internal virtual Label Lb_tuideo8
		{
			[CompilerGenerated]
			get => ab9;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ab9 = value;
		}

		internal virtual Label Lb_tuideo7
		{
			[CompilerGenerated]
			get => aca;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => aca = value;
		}

		internal virtual Label Lb_tuideo6
		{
			[CompilerGenerated]
			get => acb;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => acb = value;
		}

		internal virtual Label Lb_tuideo5
		{
			[CompilerGenerated]
			get => acc;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => acc = value;
		}

		internal virtual Label Lb_tuideo4
		{
			[CompilerGenerated]
			get => acd;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => acd = value;
		}

		internal virtual Label Lb_tuideo3
		{
			[CompilerGenerated]
			get => ace;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ace = value;
		}

		internal virtual Label Lb_tuideo2
		{
			[CompilerGenerated]
			get => acf;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => acf = value;
		}

		internal virtual Label Lb_tuideo1
		{
			[CompilerGenerated]
			get => acg;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => acg = value;
		}

		internal virtual Vs2010TabControl Vs2010TabControl_Main
		{
			[CompilerGenerated]
			get
			{
				return ach;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Timer_UpdateTabs_Tick;
				Vs2010TabControl vs2010TabControl = ach;
				if (vs2010TabControl != null)
				{
					vs2010TabControl.SelectedIndexChanged -= value2;
				}
				ach = value;
				vs2010TabControl = ach;
				if (vs2010TabControl != null)
				{
					vs2010TabControl.SelectedIndexChanged += value2;
				}
			}
		}

		internal virtual TabPage TabPage_Main
		{
			[CompilerGenerated]
			get => aci;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => aci = value;
		}

		internal virtual TabPage TabPage_Attack
		{
			[CompilerGenerated]
			get => acj;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => acj = value;
		}

		internal virtual Vs2010ToolStrip miniToolStrip
		{
			[CompilerGenerated]
			get => ack;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ack = value;
		}

		internal virtual Vs2010ToolStrip ToolStrip1
		{
			[CompilerGenerated]
			get => acl;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => acl = value;
		}

		internal virtual ToolStripSplitButton ToolStripSplitButton_save
		{
			[CompilerGenerated]
			get
			{
				return acm;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button_SaveConfig_Click;
				ToolStripSplitButton toolStripSplitButton = acm;
				if (toolStripSplitButton != null)
				{
					toolStripSplitButton.ButtonClick -= value2;
				}
				acm = value;
				toolStripSplitButton = acm;
				if (toolStripSplitButton != null)
				{
					toolStripSplitButton.ButtonClick += value2;
				}
			}
		}

		internal virtual ToolStripLabel ToolStripLabel1
		{
			[CompilerGenerated]
			get => acn;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => acn = value;
		}

		internal virtual ToolStripTextBox ToolStripTextBox_KenhPassword
		{
			[CompilerGenerated]
			get
			{
				return aco;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = ToolStripTextBox_KenhPassword_TextChanged;
				ToolStripTextBox toolStripTextBox = aco;
				if (toolStripTextBox != null)
				{
					toolStripTextBox.TextChanged -= value2;
				}
				aco = value;
				toolStripTextBox = aco;
				if (toolStripTextBox != null)
				{
					toolStripTextBox.TextChanged += value2;
				}
			}
		}

		internal virtual Panel Panel_Login
		{
			[CompilerGenerated]
			get => acp;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => acp = value;
		}

		internal virtual Panel Panel10
		{
			[CompilerGenerated]
			get => acq;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => acq = value;
		}

		internal virtual Panel Panel9
		{
			[CompilerGenerated]
			get => acr;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => acr = value;
		}

		internal virtual PictureBox PictureBox_Pet_photo
		{
			[CompilerGenerated]
			get => acs;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => acs = value;
		}

		internal virtual PictureBox PictureBox_char5
		{
			[CompilerGenerated]
			get => act;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => act = value;
		}

		internal virtual PictureBox PictureBox_char6
		{
			[CompilerGenerated]
			get => acu;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => acu = value;
		}

		internal virtual PictureBox PictureBox_char3
		{
			[CompilerGenerated]
			get => acv;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => acv = value;
		}

		internal virtual PictureBox PictureBox_char2
		{
			[CompilerGenerated]
			get => acw;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => acw = value;
		}

		internal virtual PictureBox PictureBox_char4
		{
			[CompilerGenerated]
			get => acx;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => acx = value;
		}

		internal virtual PictureBox PictureBox_char1
		{
			[CompilerGenerated]
			get => acy;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => acy = value;
		}

		internal virtual PictureBox PictureBox_Pet5
		{
			[CompilerGenerated]
			get => acz;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => acz = value;
		}

		internal virtual PictureBox PictureBox_Pet6
		{
			[CompilerGenerated]
			get => ac0;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ac0 = value;
		}

		internal virtual PictureBox PictureBox_Pet3
		{
			[CompilerGenerated]
			get => ac1;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ac1 = value;
		}

		internal virtual PictureBox PictureBox_Pet2
		{
			[CompilerGenerated]
			get => ac2;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ac2 = value;
		}

		internal virtual PictureBox PictureBox_Pet4
		{
			[CompilerGenerated]
			get => ac3;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ac3 = value;
		}

		internal virtual PictureBox PictureBox_Pet1
		{
			[CompilerGenerated]
			get => ac4;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ac4 = value;
		}

		internal virtual PictureBox PictureBox_Pet_Thuoctinh
		{
			[CompilerGenerated]
			get => ac5;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ac5 = value;
		}

		internal virtual PictureBox PictureBox_Char_Thuoctinh
		{
			[CompilerGenerated]
			get => ac6;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ac6 = value;
		}

		internal virtual PictureBox PictureBox_Pet_XuatChien
		{
			[CompilerGenerated]
			get
			{
				return ac7;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button_TogglePetBattle_Click;
				MouseEventHandler value3 = PictureBox_MouseMove_ShowCropPreview;
				MouseEventHandler value4 = PictureBox_MouseDown_ShowCropPreview;
				EventHandler value5 = PictureBox_MouseLeave_ClearImage;
				MouseEventHandler value6 = PictureBox_MouseUp_ClearImage;
				PictureBox pictureBox = ac7;
				if (pictureBox != null)
				{
					pictureBox.Click -= value2;
					pictureBox.MouseMove -= value3;
					pictureBox.MouseDown -= value4;
					pictureBox.MouseLeave -= value5;
					pictureBox.MouseUp -= value6;
				}
				ac7 = value;
				pictureBox = ac7;
				if (pictureBox != null)
				{
					pictureBox.Click += value2;
					pictureBox.MouseMove += value3;
					pictureBox.MouseDown += value4;
					pictureBox.MouseLeave += value5;
					pictureBox.MouseUp += value6;
				}
			}
		}

		internal virtual Label Label94
		{
			[CompilerGenerated]
			get => ac8;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ac8 = value;
		}

		internal virtual Label Label_Char_agi
		{
			[CompilerGenerated]
			get => ac9;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ac9 = value;
		}

		internal virtual Label Label_Char_spx
		{
			[CompilerGenerated]
			get => ada;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ada = value;
		}

		internal virtual Label Label_Char_hpx
		{
			[CompilerGenerated]
			get => adb;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => adb = value;
		}

		internal virtual Label Label_Char_def
		{
			[CompilerGenerated]
			get => adc;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => adc = value;
		}

		internal virtual Label Label_Char_atk
		{
			[CompilerGenerated]
			get => add;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => add = value;
		}

		internal virtual Label Label_Char_int
		{
			[CompilerGenerated]
			get => ade;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ade = value;
		}

		internal virtual Label Label_Pet_fai
		{
			[CompilerGenerated]
			get => adf;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => adf = value;
		}

		internal virtual Label Label_Pet_agi
		{
			[CompilerGenerated]
			get => adg;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => adg = value;
		}

		internal virtual Label Label_Pet_spx
		{
			[CompilerGenerated]
			get => adh;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => adh = value;
		}

		internal virtual Label Label_Pet_hpx
		{
			[CompilerGenerated]
			get => adi;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => adi = value;
		}

		internal virtual Label Label_Pet_def
		{
			[CompilerGenerated]
			get => adj;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => adj = value;
		}

		internal virtual Label Label_Pet_atk
		{
			[CompilerGenerated]
			get => adk;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => adk = value;
		}

		internal virtual Label Label_Pet_int
		{
			[CompilerGenerated]
			get => adl;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => adl = value;
		}

		internal virtual TabPage TabPage_Quest
		{
			[CompilerGenerated]
			get => adm;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => adm = value;
		}

		internal virtual TabPage TabPage_Warp
		{
			[CompilerGenerated]
			get => adn;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => adn = value;
		}

		internal virtual TabPage TabPage_Players
		{
			[CompilerGenerated]
			get => ado;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ado = value;
		}

		internal virtual TabPage TabPage_Setting
		{
			[CompilerGenerated]
			get => adp;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => adp = value;
		}

		internal virtual TabPage TabPage_Shop
		{
			[CompilerGenerated]
			get => adq;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => adq = value;
		}

		internal virtual TabPage TabPage4
		{
			[CompilerGenerated]
			get => adr;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => adr = value;
		}

		internal virtual TabPage TabPage_Map
		{
			[CompilerGenerated]
			get => ads;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ads = value;
		}

		internal virtual PictureBox PictureBox_pet_next
		{
			[CompilerGenerated]
			get
			{
				return adt;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				MouseEventHandler value2 = PictureBox_MouseMove_ShowCropPreview;
				MouseEventHandler value3 = PictureBox_MouseDown_ShowCropPreview;
				EventHandler value4 = PictureBox_MouseLeave_ClearImage;
				MouseEventHandler value5 = PictureBox_MouseUp_ClearImage;
				EventHandler value6 = Button_PetSelectNext_Click;
				PictureBox pictureBox = adt;
				if (pictureBox != null)
				{
					pictureBox.MouseMove -= value2;
					pictureBox.MouseDown -= value3;
					pictureBox.MouseLeave -= value4;
					pictureBox.MouseUp -= value5;
					pictureBox.Click -= value6;
				}
				adt = value;
				pictureBox = adt;
				if (pictureBox != null)
				{
					pictureBox.MouseMove += value2;
					pictureBox.MouseDown += value3;
					pictureBox.MouseLeave += value4;
					pictureBox.MouseUp += value5;
					pictureBox.Click += value6;
				}
			}
		}

		internal virtual PictureBox PictureBox_Pet_back
		{
			[CompilerGenerated]
			get
			{
				return adu;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				MouseEventHandler value2 = PictureBox_MouseMove_ShowCropPreview;
				MouseEventHandler value3 = PictureBox_MouseDown_ShowCropPreview;
				EventHandler value4 = PictureBox_MouseLeave_ClearImage;
				MouseEventHandler value5 = PictureBox_MouseUp_ClearImage;
				EventHandler value6 = Button_PetSelectPrev_Click;
				PictureBox pictureBox = adu;
				if (pictureBox != null)
				{
					pictureBox.MouseMove -= value2;
					pictureBox.MouseDown -= value3;
					pictureBox.MouseLeave -= value4;
					pictureBox.MouseUp -= value5;
					pictureBox.Click -= value6;
				}
				adu = value;
				pictureBox = adu;
				if (pictureBox != null)
				{
					pictureBox.MouseMove += value2;
					pictureBox.MouseDown += value3;
					pictureBox.MouseLeave += value4;
					pictureBox.MouseUp += value5;
					pictureBox.Click += value6;
				}
			}
		}

		internal virtual ToolStripMenuItem ToolStripMenuItem_CharUse
		{
			[CompilerGenerated]
			get
			{
				return adv;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = MenuItem_CharEquip_Click;
				ToolStripMenuItem toolStripMenuItem = adv;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				adv = value;
				toolStripMenuItem = adv;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripSeparator ToolStripSeparator3
		{
			[CompilerGenerated]
			get => adw;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => adw = value;
		}

		internal virtual ToolStripMenuItem ToolStripMenuItem_Petuse
		{
			[CompilerGenerated]
			get
			{
				return adx;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = MenuItem_PetEquip_Click;
				ToolStripMenuItem toolStripMenuItem = adx;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				adx = value;
				toolStripMenuItem = adx;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem ToolStripMenuItem_dropitem
		{
			[CompilerGenerated]
			get => ady;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ady = value;
		}

		internal virtual ToolStripMenuItem ToolStripMenuItem_ContributeItem
		{
			[CompilerGenerated]
			get => adz;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => adz = value;
		}

		internal virtual ToolStripSeparator ToolStripSeparator4
		{
			[CompilerGenerated]
			get => ad0;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ad0 = value;
		}

		internal virtual ToolStripMenuItem ToolStripMenuItem_SendBDY
		{
			[CompilerGenerated]
			get
			{
				return ad1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = MenuItem_SendToBDYPet_Click;
				ToolStripMenuItem toolStripMenuItem = ad1;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				ad1 = value;
				toolStripMenuItem = ad1;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripTextBox ToolStripTextBox_SendBDY_Id
		{
			[CompilerGenerated]
			get
			{
				return ad2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyPressEventHandler value2 = NumericTextBox_KeyPress;
				EventHandler value3 = TextBox_NumericValue_TextChanged;
				ToolStripTextBox toolStripTextBox = ad2;
				if (toolStripTextBox != null)
				{
					toolStripTextBox.KeyPress -= value2;
					toolStripTextBox.TextChanged -= value3;
				}
				ad2 = value;
				toolStripTextBox = ad2;
				if (toolStripTextBox != null)
				{
					toolStripTextBox.KeyPress += value2;
					toolStripTextBox.TextChanged += value3;
				}
			}
		}

		internal virtual ToolStripSeparator ToolStripSeparator5
		{
			[CompilerGenerated]
			get => ad3;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ad3 = value;
		}

		internal virtual PictureBox PictureBox_char_add_agi
		{
			[CompilerGenerated]
			get
			{
				return ad4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				MouseEventHandler value2 = PictureBox_MouseMove_ShowCropPreview;
				MouseEventHandler value3 = PictureBox_MouseDown_ShowCropPreview;
				EventHandler value4 = PictureBox_MouseLeave_ClearImage;
				MouseEventHandler value5 = PictureBox_MouseUp_ClearImage;
				EventHandler value6 = [SpecialName] [DebuggerHidden] (object sender, EventArgs e) =>
				{
					PictureBox_CharStat_MouseClick(RuntimeHelpers.GetObjectValue(sender), (MouseEventArgs)e);
				};
				EventHandler value7 = NoOpClickHandler;
				PictureBox pictureBox = ad4;
				if (pictureBox != null)
				{
					pictureBox.MouseMove -= value2;
					pictureBox.MouseDown -= value3;
					pictureBox.MouseLeave -= value4;
					pictureBox.MouseUp -= value5;
					pictureBox.Click -= value6;
					pictureBox.Click -= value7;
				}
				ad4 = value;
				pictureBox = ad4;
				if (pictureBox != null)
				{
					pictureBox.MouseMove += value2;
					pictureBox.MouseDown += value3;
					pictureBox.MouseLeave += value4;
					pictureBox.MouseUp += value5;
					pictureBox.Click += value6;
					pictureBox.Click += value7;
				}
			}
		}

		internal virtual PictureBox PictureBox_char_add_spx
		{
			[CompilerGenerated]
			get
			{
				return ad5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				MouseEventHandler value2 = PictureBox_MouseMove_ShowCropPreview;
				MouseEventHandler value3 = PictureBox_MouseDown_ShowCropPreview;
				EventHandler value4 = PictureBox_MouseLeave_ClearImage;
				MouseEventHandler value5 = PictureBox_MouseUp_ClearImage;
				EventHandler value6 = [SpecialName] [DebuggerHidden] (object sender, EventArgs e) =>
				{
					PictureBox_CharStat_MouseClick(RuntimeHelpers.GetObjectValue(sender), (MouseEventArgs)e);
				};
				EventHandler value7 = NoOpClickHandler;
				PictureBox pictureBox = ad5;
				if (pictureBox != null)
				{
					pictureBox.MouseMove -= value2;
					pictureBox.MouseDown -= value3;
					pictureBox.MouseLeave -= value4;
					pictureBox.MouseUp -= value5;
					pictureBox.Click -= value6;
					pictureBox.Click -= value7;
				}
				ad5 = value;
				pictureBox = ad5;
				if (pictureBox != null)
				{
					pictureBox.MouseMove += value2;
					pictureBox.MouseDown += value3;
					pictureBox.MouseLeave += value4;
					pictureBox.MouseUp += value5;
					pictureBox.Click += value6;
					pictureBox.Click += value7;
				}
			}
		}

		internal virtual PictureBox PictureBox_char_add_hpx
		{
			[CompilerGenerated]
			get
			{
				return ad6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				MouseEventHandler value2 = PictureBox_MouseMove_ShowCropPreview;
				MouseEventHandler value3 = PictureBox_MouseDown_ShowCropPreview;
				EventHandler value4 = PictureBox_MouseLeave_ClearImage;
				MouseEventHandler value5 = PictureBox_MouseUp_ClearImage;
				EventHandler value6 = [SpecialName] [DebuggerHidden] (object sender, EventArgs e) =>
				{
					PictureBox_CharStat_MouseClick(RuntimeHelpers.GetObjectValue(sender), (MouseEventArgs)e);
				};
				EventHandler value7 = NoOpClickHandler;
				PictureBox pictureBox = ad6;
				if (pictureBox != null)
				{
					pictureBox.MouseMove -= value2;
					pictureBox.MouseDown -= value3;
					pictureBox.MouseLeave -= value4;
					pictureBox.MouseUp -= value5;
					pictureBox.Click -= value6;
					pictureBox.Click -= value7;
				}
				ad6 = value;
				pictureBox = ad6;
				if (pictureBox != null)
				{
					pictureBox.MouseMove += value2;
					pictureBox.MouseDown += value3;
					pictureBox.MouseLeave += value4;
					pictureBox.MouseUp += value5;
					pictureBox.Click += value6;
					pictureBox.Click += value7;
				}
			}
		}

		internal virtual PictureBox PictureBox_char_add_def
		{
			[CompilerGenerated]
			get
			{
				return ad7;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				MouseEventHandler value2 = PictureBox_MouseMove_ShowCropPreview;
				MouseEventHandler value3 = PictureBox_MouseDown_ShowCropPreview;
				EventHandler value4 = PictureBox_MouseLeave_ClearImage;
				MouseEventHandler value5 = PictureBox_MouseUp_ClearImage;
				EventHandler value6 = [SpecialName] [DebuggerHidden] (object sender, EventArgs e) =>
				{
					PictureBox_CharStat_MouseClick(RuntimeHelpers.GetObjectValue(sender), (MouseEventArgs)e);
				};
				EventHandler value7 = NoOpClickHandler;
				PictureBox pictureBox = ad7;
				if (pictureBox != null)
				{
					pictureBox.MouseMove -= value2;
					pictureBox.MouseDown -= value3;
					pictureBox.MouseLeave -= value4;
					pictureBox.MouseUp -= value5;
					pictureBox.Click -= value6;
					pictureBox.Click -= value7;
				}
				ad7 = value;
				pictureBox = ad7;
				if (pictureBox != null)
				{
					pictureBox.MouseMove += value2;
					pictureBox.MouseDown += value3;
					pictureBox.MouseLeave += value4;
					pictureBox.MouseUp += value5;
					pictureBox.Click += value6;
					pictureBox.Click += value7;
				}
			}
		}

		internal virtual PictureBox PictureBox_char_add_atk
		{
			[CompilerGenerated]
			get
			{
				return ad8;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				MouseEventHandler value2 = PictureBox_MouseMove_ShowCropPreview;
				MouseEventHandler value3 = PictureBox_MouseDown_ShowCropPreview;
				EventHandler value4 = PictureBox_MouseLeave_ClearImage;
				MouseEventHandler value5 = PictureBox_MouseUp_ClearImage;
				EventHandler value6 = [SpecialName] [DebuggerHidden] (object sender, EventArgs e) =>
				{
					PictureBox_CharStat_MouseClick(RuntimeHelpers.GetObjectValue(sender), (MouseEventArgs)e);
				};
				EventHandler value7 = NoOpClickHandler;
				PictureBox pictureBox = ad8;
				if (pictureBox != null)
				{
					pictureBox.MouseMove -= value2;
					pictureBox.MouseDown -= value3;
					pictureBox.MouseLeave -= value4;
					pictureBox.MouseUp -= value5;
					pictureBox.Click -= value6;
					pictureBox.Click -= value7;
				}
				ad8 = value;
				pictureBox = ad8;
				if (pictureBox != null)
				{
					pictureBox.MouseMove += value2;
					pictureBox.MouseDown += value3;
					pictureBox.MouseLeave += value4;
					pictureBox.MouseUp += value5;
					pictureBox.Click += value6;
					pictureBox.Click += value7;
				}
			}
		}

		internal virtual PictureBox PictureBox_char_add_int
		{
			[CompilerGenerated]
			get
			{
				return ad9;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				MouseEventHandler value2 = PictureBox_MouseMove_ShowCropPreview;
				MouseEventHandler value3 = PictureBox_MouseDown_ShowCropPreview;
				EventHandler value4 = PictureBox_MouseLeave_ClearImage;
				MouseEventHandler value5 = PictureBox_MouseUp_ClearImage;
				EventHandler value6 = [SpecialName] [DebuggerHidden] (object sender, EventArgs e) =>
				{
					PictureBox_CharStat_MouseClick(RuntimeHelpers.GetObjectValue(sender), (MouseEventArgs)e);
				};
				EventHandler value7 = NoOpClickHandler;
				PictureBox pictureBox = ad9;
				if (pictureBox != null)
				{
					pictureBox.MouseMove -= value2;
					pictureBox.MouseDown -= value3;
					pictureBox.MouseLeave -= value4;
					pictureBox.MouseUp -= value5;
					pictureBox.Click -= value6;
					pictureBox.Click -= value7;
				}
				ad9 = value;
				pictureBox = ad9;
				if (pictureBox != null)
				{
					pictureBox.MouseMove += value2;
					pictureBox.MouseDown += value3;
					pictureBox.MouseLeave += value4;
					pictureBox.MouseUp += value5;
					pictureBox.Click += value6;
					pictureBox.Click += value7;
				}
			}
		}

		internal virtual ImageList ImageList1
		{
			[CompilerGenerated]
			get => aea;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => aea = value;
		}

		internal virtual ComboBoxIcon ComboBox_CharSkill
		{
			[CompilerGenerated]
			get
			{
				return aeb;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyPressEventHandler value2 = ComboBox_KeyPress_BlockInput;
				MouseEventHandler value3 = NoOpClickHandler;
				EventHandler value4 = ComboBox_CharSkill_SelectedIndexChanged;
				ComboBoxIcon comboBoxIcon = aeb;
				if (comboBoxIcon != null)
				{
					comboBoxIcon.KeyPress -= value2;
					comboBoxIcon.MouseDown -= value3;
					comboBoxIcon.SelectedIndexChanged -= value4;
				}
				aeb = value;
				comboBoxIcon = aeb;
				if (comboBoxIcon != null)
				{
					comboBoxIcon.KeyPress += value2;
					comboBoxIcon.MouseDown += value3;
					comboBoxIcon.SelectedIndexChanged += value4;
				}
			}
		}

		internal virtual ComboBoxIcon ComboBox_PetSkill
		{
			[CompilerGenerated]
			get
			{
				return aec;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyPressEventHandler value2 = ComboBox_KeyPress_BlockInput;
				MouseEventHandler value3 = NoOpClickHandler;
				EventHandler value4 = ComboBox_PetSkill_SelectedIndexChanged;
				ComboBoxIcon comboBoxIcon = aec;
				if (comboBoxIcon != null)
				{
					comboBoxIcon.KeyPress -= value2;
					comboBoxIcon.MouseDown -= value3;
					comboBoxIcon.SelectedIndexChanged -= value4;
				}
				aec = value;
				comboBoxIcon = aec;
				if (comboBoxIcon != null)
				{
					comboBoxIcon.KeyPress += value2;
					comboBoxIcon.MouseDown += value3;
					comboBoxIcon.SelectedIndexChanged += value4;
				}
			}
		}

		internal virtual ToolStripMenuItem DongYVutDoToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return aed;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = MenuItem_HomdoDrop_Click;
				ToolStripMenuItem toolStripMenuItem = aed;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				aed = value;
				toolStripMenuItem = aed;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem DongYDongGopToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return aee;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = MenuItem_HomdoContribute_Click;
				ToolStripMenuItem toolStripMenuItem = aee;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				aee = value;
				toolStripMenuItem = aee;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual PictureBox PictureBox_mini
		{
			[CompilerGenerated]
			get => aef;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => aef = value;
		}

		internal virtual ToolStripSeparator ToolStripSeparator6
		{
			[CompilerGenerated]
			get => aeg;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => aeg = value;
		}

		internal virtual ToolStripMenuItem ToolStripMenuItem_Tuido_Sort
		{
			[CompilerGenerated]
			get
			{
				return aeh;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button_AutoSort_Click;
				ToolStripMenuItem toolStripMenuItem = aeh;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				aeh = value;
				toolStripMenuItem = aeh;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual PictureBox PictureBox_avatar
		{
			[CompilerGenerated]
			get => aei;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => aei = value;
		}
	}
}
