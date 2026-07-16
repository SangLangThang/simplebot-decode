using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Simple_Bot.ColorTables;
using Simple_Bot.Controls;
using Simple_Bot.Renderers;

namespace Simple_Bot
{
	[DesignerGenerated]
	public partial class frmMain : Form
	{
		private IContainer components;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("Timer1")]
		private System.Windows.Forms.Timer m_b;

		[AccessedThroughProperty("MenuStrip1")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Vs2010MenuStrip m_c;

		[AccessedThroughProperty("ToolStripMenuItem_newtab")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ToolStripMenuItem m_d;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ToolStripMenuItem_system")]
		private ToolStripMenuItem m_e;

		[AccessedThroughProperty("ToolStripMenuItem_hide")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ToolStripMenuItem m_f;

		[AccessedThroughProperty("ToolStripSeparator2")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private ToolStripSeparator m_g;

		[AccessedThroughProperty("ToolStripMenuItem_exit")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ToolStripMenuItem m_h;

		[AccessedThroughProperty("ToolStripMenuItem_info")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ToolStripMenuItem m_i;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ToolStripMenuItem_home")]
		private ToolStripMenuItem m_j;

		[CompilerGenerated]
		[AccessedThroughProperty("ToolStripSeparator1")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ToolStripSeparator m_k;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ToolStripMenuItem_about")]
		private ToolStripMenuItem m_l;

		[AccessedThroughProperty("NewtabConfigToolStripMenuItem")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ToolStripMenuItem m_m;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("OpenFileDialog_newtabconfig")]
		private OpenFileDialog m_n;

		[AccessedThroughProperty("Timer2")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private System.Windows.Forms.Timer m_o;

		[CompilerGenerated]
		[AccessedThroughProperty("SaveFileDialog_setting")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private SaveFileDialog m_p;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ContextMenuStrip_Bot")]
		private ContextMenuStrip m_q;

		[AccessedThroughProperty("ToolStripMenuItem_Login")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ToolStripMenuItem m_r;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("ToolStripSeparator3")]
		private ToolStripSeparator m_s;

		[CompilerGenerated]
		[AccessedThroughProperty("ToolStripMenuItem_Bot")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ToolStripMenuItem m_t;

		[AccessedThroughProperty("ToolStripComboBox_bot")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ToolStripComboBox m_u;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("OpenFileDialog_setting")]
		private OpenFileDialog m_v;

		[AccessedThroughProperty("ListView1")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private ListView m_w;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("ColumnHeader_Id")]
		private ColumnHeader m_x;

		[AccessedThroughProperty("ColumnHeader_Name")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ColumnHeader m_y;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("ColumnHeader_Online")]
		private ColumnHeader m_z;

		[CompilerGenerated]
		[AccessedThroughProperty("ColumnHeader_Status")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ColumnHeader m_aa;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ToolStripSeparator4")]
		private ToolStripSeparator m_ab;

		[AccessedThroughProperty("ToolStripMenuItem_battle")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ToolStripMenuItem m_ac;

		[AccessedThroughProperty("ToolTip_info")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private ToolTip m_ad;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Team1ToolStripMenuItem")]
		[CompilerGenerated]
		private ToolStripMenuItem ae;

		[AccessedThroughProperty("Team2ToolStripMenuItem")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ToolStripMenuItem af;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Team3ToolStripMenuItem")]
		[CompilerGenerated]
		private ToolStripMenuItem ag;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Team4ToolStripMenuItem")]
		private ToolStripMenuItem ah;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("Team5ToolStripMenuItem")]
		private ToolStripMenuItem ai;

		[AccessedThroughProperty("Team6ToolStripMenuItem")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ToolStripMenuItem aj;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("Team7ToolStripMenuItem")]
		private ToolStripMenuItem ak;

		[CompilerGenerated]
		[AccessedThroughProperty("Team8ToolStripMenuItem")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ToolStripMenuItem al;

		[CompilerGenerated]
		[AccessedThroughProperty("Team9ToolStripMenuItem")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ToolStripMenuItem am;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Team10ToolStripMenuItem")]
		[CompilerGenerated]
		private ToolStripMenuItem an;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Team1ToolStripMenuItem1")]
		private ToolStripMenuItem ao;

		[AccessedThroughProperty("Team2ToolStripMenuItem1")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ToolStripMenuItem ap;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Team3ToolStripMenuItem1")]
		private ToolStripMenuItem aq;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("Team4ToolStripMenuItem1")]
		private ToolStripMenuItem ar;

		[CompilerGenerated]
		[AccessedThroughProperty("Team5ToolStripMenuItem1")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ToolStripMenuItem @as;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Team6ToolStripMenuItem1")]
		[CompilerGenerated]
		private ToolStripMenuItem at;

		[AccessedThroughProperty("Team7ToolStripMenuItem1")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ToolStripMenuItem au;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("Team8ToolStripMenuItem1")]
		private ToolStripMenuItem av;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("Team9ToolStripMenuItem1")]
		private ToolStripMenuItem aw;

		[CompilerGenerated]
		[AccessedThroughProperty("Team10ToolStripMenuItem1")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ToolStripMenuItem ax;

		[AccessedThroughProperty("ColumnHeader_Team")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ColumnHeader ay;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ColumnHeader_Mapid")]
		[CompilerGenerated]
		private ColumnHeader az;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ColumnHeader_MapName")]
		private ColumnHeader a0;

		[CompilerGenerated]
		[AccessedThroughProperty("ColumnHeader_Mini")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ColumnHeader a1;

		[AccessedThroughProperty("Save1FileToolStripMenuItem")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ToolStripMenuItem a2;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Load1FileToolStripMenuItem")]
		[CompilerGenerated]
		private ToolStripMenuItem a3;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("OpenFileDialog_Load1File")]
		[CompilerGenerated]
		private OpenFileDialog a4;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("SaveFileDialog_1file")]
		[CompilerGenerated]
		private SaveFileDialog a5;

		[AccessedThroughProperty("ToolStripSeparator5")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ToolStripSeparator a6;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("ToolStripMenuItem_Delete")]
		private ToolStripMenuItem a7;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ColumnHeader_Lv")]
		private ColumnHeader a8;

		[AccessedThroughProperty("ColumnHeader_ExpMin")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ColumnHeader a9;

		[AccessedThroughProperty("ColumnHeader_Battles")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private ColumnHeader ba;

		[CompilerGenerated]
		[AccessedThroughProperty("ToolStripMenuItem2")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ToolStripMenuItem bb;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ToolStripMenuItem_thuoctinh")]
		private ToolStripMenuItem bc;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ToolStripMenuItem_lv")]
		[CompilerGenerated]
		private ToolStripMenuItem bd;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ToolStripMenuItem_Mapid")]
		[CompilerGenerated]
		private ToolStripMenuItem be;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("ToolStripMenuItem_Mapname")]
		private ToolStripMenuItem bf;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ToolStripMenuItem_Mini")]
		private ToolStripMenuItem bg;

		[AccessedThroughProperty("ToolStripMenuItem_Status")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ToolStripMenuItem bh;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ToolStripMenuItem_Expmin")]
		private ToolStripMenuItem bi;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ToolStripMenuItem_BattleCount")]
		private ToolStripMenuItem bj;

		[AccessedThroughProperty("ColumnHeader_petName")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ColumnHeader bk;

		[AccessedThroughProperty("ColumnHeader_PetLv")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ColumnHeader bl;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ToolStripMenuItem_PetName")]
		private ToolStripMenuItem bm;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ToolStripMenuItem_PetLv")]
		[CompilerGenerated]
		private ToolStripMenuItem bn;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("ComboBox_Server")]
		private ComboBox bp;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("CheckBox_SVip")]
		private CheckBox bq;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("ComboBox_Style")]
		private ComboBox br;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("ComboBox_Horse")]
		private ComboBox bs;

		[AccessedThroughProperty("Label1")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Label bt;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label2")]
		private Label bu;

		[AccessedThroughProperty("ToolStripComboBox1")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ToolStripComboBox bv;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("ToolStripMenuItem_MainStatus")]
		private ToolStripMenuItem bw;

		[AccessedThroughProperty("Panel1")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Panel bx;

		internal virtual System.Windows.Forms.Timer Timer1
		{
			[CompilerGenerated]
			get
			{
				return this.m_b;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Timer1_Tick;
				System.Windows.Forms.Timer timer = this.m_b;
				if (timer != null)
				{
					timer.Tick -= value2;
				}
				this.m_b = value;
				timer = this.m_b;
				if (timer != null)
				{
					timer.Tick += value2;
				}
			}
		}

		internal virtual Vs2010MenuStrip MenuStrip1
		{
			[CompilerGenerated]
			get
			{
				return this.m_c;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				this.m_c = value;
			}
		}

		internal virtual ToolStripMenuItem ToolStripMenuItem_newtab
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
				this.m_d = value;
			}
		}

		internal virtual ToolStripMenuItem ToolStripMenuItem_system
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
				this.m_e = value;
			}
		}

		internal virtual ToolStripMenuItem ToolStripMenuItem_hide
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
				EventHandler value2 = ToolStripMenuItem_hide_Click;
				ToolStripMenuItem toolStripMenuItem = this.m_f;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				this.m_f = value;
				toolStripMenuItem = this.m_f;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripSeparator ToolStripSeparator2
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
				this.m_g = value;
			}
		}

		internal virtual ToolStripMenuItem ToolStripMenuItem_exit
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
				EventHandler value2 = ToolStripMenuItem_exit_Click;
				ToolStripMenuItem toolStripMenuItem = this.m_h;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				this.m_h = value;
				toolStripMenuItem = this.m_h;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem ToolStripMenuItem_info
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
				this.m_i = value;
			}
		}

		internal virtual ToolStripMenuItem ToolStripMenuItem_home
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
				EventHandler value2 = ToolStripMenuItem_home_Click;
				ToolStripMenuItem toolStripMenuItem = this.m_j;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				this.m_j = value;
				toolStripMenuItem = this.m_j;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripSeparator ToolStripSeparator1
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
				this.m_k = value;
			}
		}

		internal virtual ToolStripMenuItem ToolStripMenuItem_about
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
				EventHandler value2 = ToolStripMenuItem_about_Click;
				ToolStripMenuItem toolStripMenuItem = this.m_l;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				this.m_l = value;
				toolStripMenuItem = this.m_l;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem NewtabConfigToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this.m_m;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				this.m_m = value;
			}
		}

		internal virtual OpenFileDialog OpenFileDialog_newtabconfig
		{
			[CompilerGenerated]
			get
			{
				return this.m_n;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				CancelEventHandler value2 = OpenFileDialog_newtabconfig_FileOk;
				OpenFileDialog openFileDialog = this.m_n;
				if (openFileDialog != null)
				{
					openFileDialog.FileOk -= value2;
				}
				this.m_n = value;
				openFileDialog = this.m_n;
				if (openFileDialog != null)
				{
					openFileDialog.FileOk += value2;
				}
			}
		}

		internal virtual System.Windows.Forms.Timer Timer2
		{
			[CompilerGenerated]
			get
			{
				return this.m_o;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Timer2_Tick;
				System.Windows.Forms.Timer timer = this.m_o;
				if (timer != null)
				{
					timer.Tick -= value2;
				}
				this.m_o = value;
				timer = this.m_o;
				if (timer != null)
				{
					timer.Tick += value2;
				}
			}
		}

		internal virtual SaveFileDialog SaveFileDialog_setting
		{
			[CompilerGenerated]
			get
			{
				return this.m_p;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				this.m_p = value;
			}
		}

		internal virtual ContextMenuStrip ContextMenuStrip_Bot
		{
			[CompilerGenerated]
			get
			{
				return this.m_q;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				CancelEventHandler value2 = ContextMenuStrip_Bot_Opening;
				ContextMenuStrip contextMenuStrip = this.m_q;
				if (contextMenuStrip != null)
				{
					contextMenuStrip.Opening -= value2;
				}
				this.m_q = value;
				contextMenuStrip = this.m_q;
				if (contextMenuStrip != null)
				{
					contextMenuStrip.Opening += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem ToolStripMenuItem_Login
		{
			[CompilerGenerated]
			get
			{
				return this.m_r;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = ToolStripMenuItem_Login_Click;
				ToolStripMenuItem toolStripMenuItem = this.m_r;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				this.m_r = value;
				toolStripMenuItem = this.m_r;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripSeparator ToolStripSeparator3
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
				this.m_s = value;
			}
		}

		internal virtual ToolStripMenuItem ToolStripMenuItem_Bot
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
				EventHandler value2 = ToolStripMenuItem_Bot_Click;
				ToolStripMenuItem toolStripMenuItem = this.m_t;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				this.m_t = value;
				toolStripMenuItem = this.m_t;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripComboBox ToolStripComboBox_bot
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
				EventHandler value2 = ToolStripComboBox_bot_SelectedIndexChanged;
				ToolStripComboBox toolStripComboBox = this.m_u;
				if (toolStripComboBox != null)
				{
					toolStripComboBox.SelectedIndexChanged -= value2;
				}
				this.m_u = value;
				toolStripComboBox = this.m_u;
				if (toolStripComboBox != null)
				{
					toolStripComboBox.SelectedIndexChanged += value2;
				}
			}
		}

		internal virtual OpenFileDialog OpenFileDialog_setting
		{
			[CompilerGenerated]
			get
			{
				return this.m_v;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				CancelEventHandler value2 = OpenFileDialog_setting_FileOk;
				OpenFileDialog openFileDialog = this.m_v;
				if (openFileDialog != null)
				{
					openFileDialog.FileOk -= value2;
				}
				this.m_v = value;
				openFileDialog = this.m_v;
				if (openFileDialog != null)
				{
					openFileDialog.FileOk += value2;
				}
			}
		}

		internal virtual ListView ListView1
		{
			[CompilerGenerated]
			get
			{
				return this.m_w;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				MouseEventHandler value2 = ListView1_MouseDoubleClick;
				ListView listView = this.m_w;
				if (listView != null)
				{
					listView.MouseDoubleClick -= value2;
				}
				this.m_w = value;
				listView = this.m_w;
				if (listView != null)
				{
					listView.MouseDoubleClick += value2;
				}
			}
		}

		internal virtual ColumnHeader ColumnHeader_Id
		{
			[CompilerGenerated]
			get
			{
				return this.m_x;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				this.m_x = value;
			}
		}

		internal virtual ColumnHeader ColumnHeader_Name
		{
			[CompilerGenerated]
			get
			{
				return this.m_y;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				this.m_y = value;
			}
		}

		internal virtual ColumnHeader ColumnHeader_Online
		{
			[CompilerGenerated]
			get
			{
				return this.m_z;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				this.m_z = value;
			}
		}

		internal virtual ColumnHeader ColumnHeader_Status
		{
			[CompilerGenerated]
			get
			{
				return this.m_aa;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				this.m_aa = value;
			}
		}

		internal virtual ToolStripSeparator ToolStripSeparator4
		{
			[CompilerGenerated]
			get
			{
				return this.m_ab;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				this.m_ab = value;
			}
		}

		internal virtual ToolStripMenuItem ToolStripMenuItem_battle
		{
			[CompilerGenerated]
			get
			{
				return this.m_ac;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = ToolStripMenuItem_battle_Click;
				ToolStripMenuItem toolStripMenuItem = this.m_ac;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				this.m_ac = value;
				toolStripMenuItem = this.m_ac;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolTip ToolTip_info
		{
			[CompilerGenerated]
			get
			{
				return this.m_ad;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				this.m_ad = value;
			}
		}

		internal virtual ToolStripMenuItem Team1ToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return ae;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = TeamToolStripMenuItem_Click;
				ToolStripMenuItem toolStripMenuItem = ae;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				ae = value;
				toolStripMenuItem = ae;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem Team2ToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return af;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = TeamToolStripMenuItem_Click;
				ToolStripMenuItem toolStripMenuItem = af;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				af = value;
				toolStripMenuItem = af;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem Team3ToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return ag;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = TeamToolStripMenuItem_Click;
				ToolStripMenuItem toolStripMenuItem = ag;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				ag = value;
				toolStripMenuItem = ag;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem Team4ToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return ah;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = TeamToolStripMenuItem_Click;
				ToolStripMenuItem toolStripMenuItem = ah;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				ah = value;
				toolStripMenuItem = ah;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem Team5ToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return ai;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = TeamToolStripMenuItem_Click;
				ToolStripMenuItem toolStripMenuItem = ai;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				ai = value;
				toolStripMenuItem = ai;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem Team6ToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return aj;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = TeamToolStripMenuItem_Click;
				ToolStripMenuItem toolStripMenuItem = aj;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				aj = value;
				toolStripMenuItem = aj;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem Team7ToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return ak;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = TeamToolStripMenuItem_Click;
				ToolStripMenuItem toolStripMenuItem = ak;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				ak = value;
				toolStripMenuItem = ak;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem Team8ToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return al;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = TeamToolStripMenuItem_Click;
				ToolStripMenuItem toolStripMenuItem = al;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				al = value;
				toolStripMenuItem = al;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem Team9ToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return am;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = TeamToolStripMenuItem_Click;
				ToolStripMenuItem toolStripMenuItem = am;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				am = value;
				toolStripMenuItem = am;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem Team10ToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return an;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = TeamToolStripMenuItem_Click;
				ToolStripMenuItem toolStripMenuItem = an;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				an = value;
				toolStripMenuItem = an;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem Team1ToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return ao;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = TeamToolStripMenuItem1_Click;
				ToolStripMenuItem toolStripMenuItem = ao;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				ao = value;
				toolStripMenuItem = ao;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem Team2ToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return ap;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = TeamToolStripMenuItem1_Click;
				ToolStripMenuItem toolStripMenuItem = ap;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				ap = value;
				toolStripMenuItem = ap;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem Team3ToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return aq;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = TeamToolStripMenuItem1_Click;
				ToolStripMenuItem toolStripMenuItem = aq;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				aq = value;
				toolStripMenuItem = aq;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem Team4ToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return ar;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = TeamToolStripMenuItem1_Click;
				ToolStripMenuItem toolStripMenuItem = ar;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				ar = value;
				toolStripMenuItem = ar;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem Team5ToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return @as;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = TeamToolStripMenuItem1_Click;
				ToolStripMenuItem toolStripMenuItem = @as;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				@as = value;
				toolStripMenuItem = @as;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem Team6ToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return at;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = TeamToolStripMenuItem1_Click;
				ToolStripMenuItem toolStripMenuItem = at;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				at = value;
				toolStripMenuItem = at;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem Team7ToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return au;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = TeamToolStripMenuItem1_Click;
				ToolStripMenuItem toolStripMenuItem = au;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				au = value;
				toolStripMenuItem = au;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem Team8ToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return av;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = TeamToolStripMenuItem1_Click;
				ToolStripMenuItem toolStripMenuItem = av;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				av = value;
				toolStripMenuItem = av;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem Team9ToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return aw;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = TeamToolStripMenuItem1_Click;
				ToolStripMenuItem toolStripMenuItem = aw;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				aw = value;
				toolStripMenuItem = aw;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem Team10ToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return ax;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = TeamToolStripMenuItem1_Click;
				ToolStripMenuItem toolStripMenuItem = ax;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				ax = value;
				toolStripMenuItem = ax;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ColumnHeader ColumnHeader_Team
		{
			[CompilerGenerated]
			get
			{
				return ay;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ay = value;
			}
		}

		internal virtual ColumnHeader ColumnHeader_Mapid
		{
			[CompilerGenerated]
			get
			{
				return az;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				az = value;
			}
		}

		internal virtual ColumnHeader ColumnHeader_MapName
		{
			[CompilerGenerated]
			get
			{
				return a0;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				a0 = value;
			}
		}

		internal virtual ColumnHeader ColumnHeader_Mini
		{
			[CompilerGenerated]
			get
			{
				return a1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				a1 = value;
			}
		}

		internal virtual ToolStripMenuItem Save1FileToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return a2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Save1FileToolStripMenuItem_Click;
				ToolStripMenuItem toolStripMenuItem = a2;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				a2 = value;
				toolStripMenuItem = a2;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem Load1FileToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return a3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Load1FileToolStripMenuItem_Click;
				ToolStripMenuItem toolStripMenuItem = a3;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				a3 = value;
				toolStripMenuItem = a3;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual OpenFileDialog OpenFileDialog_Load1File
		{
			[CompilerGenerated]
			get
			{
				return a4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				CancelEventHandler value2 = OpenFileDialog_Load1File_FileOk;
				OpenFileDialog openFileDialog = a4;
				if (openFileDialog != null)
				{
					openFileDialog.FileOk -= value2;
				}
				a4 = value;
				openFileDialog = a4;
				if (openFileDialog != null)
				{
					openFileDialog.FileOk += value2;
				}
			}
		}

		internal virtual SaveFileDialog SaveFileDialog_1file
		{
			[CompilerGenerated]
			get
			{
				return a5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				CancelEventHandler value2 = SaveFileDialog_1file_FileOk;
				SaveFileDialog saveFileDialog = a5;
				if (saveFileDialog != null)
				{
					saveFileDialog.FileOk -= value2;
				}
				a5 = value;
				saveFileDialog = a5;
				if (saveFileDialog != null)
				{
					saveFileDialog.FileOk += value2;
				}
			}
		}

		internal virtual ToolStripSeparator ToolStripSeparator5
		{
			[CompilerGenerated]
			get
			{
				return a6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				a6 = value;
			}
		}

		internal virtual ToolStripMenuItem ToolStripMenuItem_Delete
		{
			[CompilerGenerated]
			get
			{
				return a7;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = ToolStripMenuItem_Delete_Click;
				ToolStripMenuItem toolStripMenuItem = a7;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				a7 = value;
				toolStripMenuItem = a7;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ColumnHeader ColumnHeader_Lv
		{
			[CompilerGenerated]
			get
			{
				return a8;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				a8 = value;
			}
		}

		internal virtual ColumnHeader ColumnHeader_ExpMin
		{
			[CompilerGenerated]
			get
			{
				return a9;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				a9 = value;
			}
		}

		internal virtual ColumnHeader ColumnHeader_Battles
		{
			[CompilerGenerated]
			get
			{
				return ba;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ba = value;
			}
		}

		internal virtual ToolStripMenuItem ToolStripMenuItem2
		{
			[CompilerGenerated]
			get
			{
				return bb;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				bb = value;
			}
		}

		internal virtual ToolStripMenuItem ToolStripMenuItem_thuoctinh
		{
			[CompilerGenerated]
			get
			{
				return bc;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				bc = value;
			}
		}

		internal virtual ToolStripMenuItem ToolStripMenuItem_lv
		{
			[CompilerGenerated]
			get
			{
				return bd;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = ToolStripMenuItem_lv_CheckedChanged;
				ToolStripMenuItem toolStripMenuItem = bd;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.CheckedChanged -= value2;
				}
				bd = value;
				toolStripMenuItem = bd;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.CheckedChanged += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem ToolStripMenuItem_Mapid
		{
			[CompilerGenerated]
			get
			{
				return be;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = ToolStripMenuItem_Mapid_CheckedChanged;
				ToolStripMenuItem toolStripMenuItem = be;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.CheckedChanged -= value2;
				}
				be = value;
				toolStripMenuItem = be;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.CheckedChanged += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem ToolStripMenuItem_Mapname
		{
			[CompilerGenerated]
			get
			{
				return bf;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = ToolStripMenuItem_Mapname_CheckedChanged;
				ToolStripMenuItem toolStripMenuItem = bf;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.CheckedChanged -= value2;
				}
				bf = value;
				toolStripMenuItem = bf;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.CheckedChanged += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem ToolStripMenuItem_Mini
		{
			[CompilerGenerated]
			get
			{
				return bg;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = ToolStripMenuItem_Mini_CheckedChanged;
				ToolStripMenuItem toolStripMenuItem = bg;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.CheckedChanged -= value2;
				}
				bg = value;
				toolStripMenuItem = bg;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.CheckedChanged += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem ToolStripMenuItem_Status
		{
			[CompilerGenerated]
			get
			{
				return bh;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = ToolStripMenuItem_Status_CheckedChanged;
				ToolStripMenuItem toolStripMenuItem = bh;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.CheckedChanged -= value2;
				}
				bh = value;
				toolStripMenuItem = bh;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.CheckedChanged += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem ToolStripMenuItem_Expmin
		{
			[CompilerGenerated]
			get
			{
				return bi;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = ToolStripMenuItem_Expmin_CheckedChanged;
				ToolStripMenuItem toolStripMenuItem = bi;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.CheckedChanged -= value2;
				}
				bi = value;
				toolStripMenuItem = bi;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.CheckedChanged += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem ToolStripMenuItem_BattleCount
		{
			[CompilerGenerated]
			get
			{
				return bj;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = ToolStripMenuItem_BattleCount_CheckedChanged;
				ToolStripMenuItem toolStripMenuItem = bj;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.CheckedChanged -= value2;
				}
				bj = value;
				toolStripMenuItem = bj;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.CheckedChanged += value2;
				}
			}
		}

		internal virtual ColumnHeader ColumnHeader_petName
		{
			[CompilerGenerated]
			get
			{
				return bk;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				bk = value;
			}
		}

		internal virtual ColumnHeader ColumnHeader_PetLv
		{
			[CompilerGenerated]
			get
			{
				return bl;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				bl = value;
			}
		}

		internal virtual ToolStripMenuItem ToolStripMenuItem_PetName
		{
			[CompilerGenerated]
			get
			{
				return bm;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				bm = value;
			}
		}

		internal virtual ToolStripMenuItem ToolStripMenuItem_PetLv
		{
			[CompilerGenerated]
			get
			{
				return bn;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				bn = value;
			}
		}


		internal virtual ComboBox ComboBox_Server
		{
			[CompilerGenerated]
			get
			{
				return bp;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = ComboBox_Server_SelectedIndexChanged;
				EventHandler value3 = ComboBox_Server_DropDown;
				ComboBox comboBox = bp;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= value2;
					comboBox.DropDown -= value3;
				}
				bp = value;
				comboBox = bp;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += value2;
					comboBox.DropDown += value3;
				}
			}
		}

		internal virtual CheckBox CheckBox_SVip
		{
			[CompilerGenerated]
			get
			{
				return bq;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = CheckBox_SVip_CheckedChanged;
				CheckBox checkBox = bq;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				bq = value;
				checkBox = bq;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		internal virtual ComboBox ComboBox_Style
		{
			[CompilerGenerated]
			get
			{
				return br;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = ComboBox_Style_SelectedIndexChanged;
				ComboBox comboBox = br;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= value2;
				}
				br = value;
				comboBox = br;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += value2;
				}
			}
		}

		internal virtual ComboBox ComboBox_Horse
		{
			[CompilerGenerated]
			get
			{
				return bs;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = ComboBox_Horse_SelectedIndexChanged;
				ComboBox comboBox = bs;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= value2;
				}
				bs = value;
				comboBox = bs;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += value2;
				}
			}
		}

		internal virtual Label Label1
		{
			[CompilerGenerated]
			get
			{
				return bt;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				bt = value;
			}
		}

		internal virtual Label Label2
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
				bu = value;
			}
		}

		internal virtual ToolStripComboBox ToolStripComboBox1
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
				EventHandler value2 = ToolStripComboBox1_SelectedIndexChanged;
				ToolStripComboBox toolStripComboBox = bv;
				if (toolStripComboBox != null)
				{
					toolStripComboBox.SelectedIndexChanged -= value2;
				}
				bv = value;
				toolStripComboBox = bv;
				if (toolStripComboBox != null)
				{
					toolStripComboBox.SelectedIndexChanged += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem ToolStripMenuItem_MainStatus
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
				bw = value;
			}
		}

		internal virtual Panel Panel1
		{
			[CompilerGenerated]
			get
			{
				return bx;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				bx = value;
			}
		}


		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.components != null)
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		private void InitializeComponent()
		{
			this.components = new Container();
			Vs2010MenuStripRenderer vs2010MenuStripRenderer = new Vs2010MenuStripRenderer();
			Vs2010DefaultMenuStripColorTable colorTable = new Vs2010DefaultMenuStripColorTable();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMain));
			Timer1 = new System.Windows.Forms.Timer(this.components);
			MenuStrip1 = new Vs2010MenuStrip();
			ToolStripMenuItem_system = new ToolStripMenuItem();
			ToolStripMenuItem_hide = new ToolStripMenuItem();
			ToolStripSeparator2 = new ToolStripSeparator();
			ToolStripMenuItem_exit = new ToolStripMenuItem();
			ToolStripMenuItem_newtab = new ToolStripMenuItem();
			Team1ToolStripMenuItem1 = new ToolStripMenuItem();
			Team2ToolStripMenuItem1 = new ToolStripMenuItem();
			Team3ToolStripMenuItem1 = new ToolStripMenuItem();
			Team4ToolStripMenuItem1 = new ToolStripMenuItem();
			Team5ToolStripMenuItem1 = new ToolStripMenuItem();
			Team6ToolStripMenuItem1 = new ToolStripMenuItem();
			Team7ToolStripMenuItem1 = new ToolStripMenuItem();
			Team8ToolStripMenuItem1 = new ToolStripMenuItem();
			Team9ToolStripMenuItem1 = new ToolStripMenuItem();
			Team10ToolStripMenuItem1 = new ToolStripMenuItem();
			ToolStripMenuItem_info = new ToolStripMenuItem();
			ToolStripMenuItem_home = new ToolStripMenuItem();
			ToolStripSeparator1 = new ToolStripSeparator();
			ToolStripMenuItem_about = new ToolStripMenuItem();
			NewtabConfigToolStripMenuItem = new ToolStripMenuItem();
			Team1ToolStripMenuItem = new ToolStripMenuItem();
			Team2ToolStripMenuItem = new ToolStripMenuItem();
			Team3ToolStripMenuItem = new ToolStripMenuItem();
			Team4ToolStripMenuItem = new ToolStripMenuItem();
			Team5ToolStripMenuItem = new ToolStripMenuItem();
			Team6ToolStripMenuItem = new ToolStripMenuItem();
			Team7ToolStripMenuItem = new ToolStripMenuItem();
			Team8ToolStripMenuItem = new ToolStripMenuItem();
			Team9ToolStripMenuItem = new ToolStripMenuItem();
			Team10ToolStripMenuItem = new ToolStripMenuItem();
			Save1FileToolStripMenuItem = new ToolStripMenuItem();
			Load1FileToolStripMenuItem = new ToolStripMenuItem();
			ToolStripMenuItem2 = new ToolStripMenuItem();
			ToolStripMenuItem_thuoctinh = new ToolStripMenuItem();
			ToolStripMenuItem_lv = new ToolStripMenuItem();
			ToolStripMenuItem_Mapid = new ToolStripMenuItem();
			ToolStripMenuItem_Mapname = new ToolStripMenuItem();
			ToolStripMenuItem_Mini = new ToolStripMenuItem();
			ToolStripMenuItem_Status = new ToolStripMenuItem();
			ToolStripMenuItem_Expmin = new ToolStripMenuItem();
			ToolStripMenuItem_BattleCount = new ToolStripMenuItem();
			ToolStripMenuItem_PetName = new ToolStripMenuItem();
			ToolStripMenuItem_PetLv = new ToolStripMenuItem();
			ToolStripMenuItem_MainStatus = new ToolStripMenuItem();
			ToolStripComboBox1 = new ToolStripComboBox();
			OpenFileDialog_newtabconfig = new OpenFileDialog();
			ContextMenuStrip_Bot = new ContextMenuStrip(this.components);
			ToolStripMenuItem_Login = new ToolStripMenuItem();
			ToolStripSeparator3 = new ToolStripSeparator();
			ToolStripComboBox_bot = new ToolStripComboBox();
			ToolStripMenuItem_Bot = new ToolStripMenuItem();
			ToolStripSeparator4 = new ToolStripSeparator();
			ToolStripMenuItem_battle = new ToolStripMenuItem();
			ToolStripSeparator5 = new ToolStripSeparator();
			ToolStripMenuItem_Delete = new ToolStripMenuItem();
			Timer2 = new System.Windows.Forms.Timer(this.components);
			SaveFileDialog_setting = new SaveFileDialog();
			OpenFileDialog_setting = new OpenFileDialog();
			ListView1 = new ListView();
			ColumnHeader_Id = new ColumnHeader();
			ColumnHeader_Name = new ColumnHeader();
			ColumnHeader_Lv = new ColumnHeader();
			ColumnHeader_Mapid = new ColumnHeader();
			ColumnHeader_MapName = new ColumnHeader();
			ColumnHeader_Mini = new ColumnHeader();
			ColumnHeader_Online = new ColumnHeader();
			ColumnHeader_Status = new ColumnHeader();
			ColumnHeader_ExpMin = new ColumnHeader();
			ColumnHeader_Battles = new ColumnHeader();
			ColumnHeader_petName = new ColumnHeader();
			ColumnHeader_PetLv = new ColumnHeader();
			ColumnHeader_Team = new ColumnHeader();
			ToolTip_info = new ToolTip(this.components);
			OpenFileDialog_Load1File = new OpenFileDialog();
			SaveFileDialog_1file = new SaveFileDialog();
			ComboBox_Server = new ComboBox();
			CheckBox_SVip = new CheckBox();
			ComboBox_Style = new ComboBox();
			ComboBox_Horse = new ComboBox();
			Label1 = new Label();
			Label2 = new Label();
			Panel1 = new Panel();
			MenuStrip1.SuspendLayout();
			ContextMenuStrip_Bot.SuspendLayout();
			Panel1.SuspendLayout();
			SuspendLayout();
			Timer1.Enabled = true;
			Timer1.Interval = 1;
			MenuStrip1.Enabled = false;
			MenuStrip1.Font = new Font("Segoe UI", 7.5f);
			MenuStrip1.Items.AddRange(new ToolStripItem[8] { ToolStripMenuItem_system, ToolStripMenuItem_newtab, ToolStripMenuItem_info, NewtabConfigToolStripMenuItem, Save1FileToolStripMenuItem, Load1FileToolStripMenuItem, ToolStripMenuItem2, ToolStripComboBox1 });
			MenuStrip1.Location = new Point(0, 0);
			MenuStrip1.Name = "MenuStrip1";
			MenuStrip1.Padding = new Padding(8, 2, 0, 2);
			vs2010MenuStripRenderer.ColorTable = colorTable;
			vs2010MenuStripRenderer.RoundedEdges = true;
			MenuStrip1.Renderer = vs2010MenuStripRenderer;
			MenuStrip1.Size = new Size(1008, 27);
			MenuStrip1.TabIndex = 37;
			MenuStrip1.Text = "MenuStrip1";
			ToolStripMenuItem_system.DropDownItems.AddRange(new ToolStripItem[3] { ToolStripMenuItem_hide, ToolStripSeparator2, ToolStripMenuItem_exit });
			ToolStripMenuItem_system.ForeColor = Color.FromArgb(59, 41, 62);
			ToolStripMenuItem_system.Name = "ToolStripMenuItem_system";
			ToolStripMenuItem_system.Size = new Size(59, 23);
			ToolStripMenuItem_system.Text = "Hệ thống";
			ToolStripMenuItem_hide.ForeColor = Color.FromArgb(59, 41, 62);
			ToolStripMenuItem_hide.Name = "ToolStripMenuItem_hide";
			ToolStripMenuItem_hide.ShortcutKeys = Keys.H | Keys.Control;
			ToolStripMenuItem_hide.Size = new Size(180, 22);
			ToolStripMenuItem_hide.Text = "Ẩn";
			ToolStripSeparator2.Name = "ToolStripSeparator2";
			ToolStripSeparator2.Size = new Size(177, 6);
			ToolStripMenuItem_exit.ForeColor = Color.FromArgb(59, 41, 62);
			ToolStripMenuItem_exit.Name = "ToolStripMenuItem_exit";
			ToolStripMenuItem_exit.Size = new Size(180, 22);
			ToolStripMenuItem_exit.Text = "Thoát";
			ToolStripMenuItem_newtab.DropDownItems.AddRange(new ToolStripItem[10] { Team1ToolStripMenuItem1, Team2ToolStripMenuItem1, Team3ToolStripMenuItem1, Team4ToolStripMenuItem1, Team5ToolStripMenuItem1, Team6ToolStripMenuItem1, Team7ToolStripMenuItem1, Team8ToolStripMenuItem1, Team9ToolStripMenuItem1, Team10ToolStripMenuItem1 });
			ToolStripMenuItem_newtab.Font = new Font("Segoe UI", 7.5f);
			ToolStripMenuItem_newtab.ForeColor = Color.FromArgb(59, 41, 62);
			ToolStripMenuItem_newtab.Name = "ToolStripMenuItem_newtab";
			ToolStripMenuItem_newtab.ShortcutKeys = Keys.N | Keys.Control;
			ToolStripMenuItem_newtab.Size = new Size(77, 23);
			ToolStripMenuItem_newtab.Text = "Thêm thẻ bot";
			Team1ToolStripMenuItem1.ForeColor = Color.FromArgb(59, 41, 62);
			Team1ToolStripMenuItem1.Name = "Team1ToolStripMenuItem1";
			Team1ToolStripMenuItem1.Size = new Size(103, 22);
			Team1ToolStripMenuItem1.Text = "Team1";
			Team2ToolStripMenuItem1.ForeColor = Color.FromArgb(59, 41, 62);
			Team2ToolStripMenuItem1.Name = "Team2ToolStripMenuItem1";
			Team2ToolStripMenuItem1.Size = new Size(103, 22);
			Team2ToolStripMenuItem1.Text = "Team2";
			Team3ToolStripMenuItem1.ForeColor = Color.FromArgb(59, 41, 62);
			Team3ToolStripMenuItem1.Name = "Team3ToolStripMenuItem1";
			Team3ToolStripMenuItem1.Size = new Size(103, 22);
			Team3ToolStripMenuItem1.Text = "Team3";
			Team4ToolStripMenuItem1.ForeColor = Color.FromArgb(59, 41, 62);
			Team4ToolStripMenuItem1.Name = "Team4ToolStripMenuItem1";
			Team4ToolStripMenuItem1.Size = new Size(103, 22);
			Team4ToolStripMenuItem1.Text = "Team4";
			Team5ToolStripMenuItem1.ForeColor = Color.FromArgb(59, 41, 62);
			Team5ToolStripMenuItem1.Name = "Team5ToolStripMenuItem1";
			Team5ToolStripMenuItem1.Size = new Size(103, 22);
			Team5ToolStripMenuItem1.Text = "Team5";
			Team6ToolStripMenuItem1.ForeColor = Color.FromArgb(59, 41, 62);
			Team6ToolStripMenuItem1.Name = "Team6ToolStripMenuItem1";
			Team6ToolStripMenuItem1.Size = new Size(103, 22);
			Team6ToolStripMenuItem1.Text = "Team6";
			Team7ToolStripMenuItem1.ForeColor = Color.FromArgb(59, 41, 62);
			Team7ToolStripMenuItem1.Name = "Team7ToolStripMenuItem1";
			Team7ToolStripMenuItem1.Size = new Size(103, 22);
			Team7ToolStripMenuItem1.Text = "Team7";
			Team8ToolStripMenuItem1.ForeColor = Color.FromArgb(59, 41, 62);
			Team8ToolStripMenuItem1.Name = "Team8ToolStripMenuItem1";
			Team8ToolStripMenuItem1.Size = new Size(103, 22);
			Team8ToolStripMenuItem1.Text = "Team8";
			Team9ToolStripMenuItem1.ForeColor = Color.FromArgb(59, 41, 62);
			Team9ToolStripMenuItem1.Name = "Team9ToolStripMenuItem1";
			Team9ToolStripMenuItem1.Size = new Size(103, 22);
			Team9ToolStripMenuItem1.Text = "Team9";
			Team10ToolStripMenuItem1.ForeColor = Color.FromArgb(59, 41, 62);
			Team10ToolStripMenuItem1.Name = "Team10ToolStripMenuItem1";
			Team10ToolStripMenuItem1.Size = new Size(103, 22);
			Team10ToolStripMenuItem1.Text = "Team10";
			ToolStripMenuItem_info.DropDownItems.AddRange(new ToolStripItem[3] { ToolStripMenuItem_home, ToolStripSeparator1, ToolStripMenuItem_about });
			ToolStripMenuItem_info.ForeColor = Color.FromArgb(59, 41, 62);
			ToolStripMenuItem_info.Name = "ToolStripMenuItem_info";
			ToolStripMenuItem_info.Size = new Size(60, 23);
			ToolStripMenuItem_info.Text = "Thông tin";
			ToolStripMenuItem_home.ForeColor = Color.FromArgb(59, 41, 62);
			ToolStripMenuItem_home.Name = "ToolStripMenuItem_home";
			ToolStripMenuItem_home.Size = new Size(133, 22);
			ToolStripMenuItem_home.Text = "Trang chủ";
			ToolStripSeparator1.Name = "ToolStripSeparator1";
			ToolStripSeparator1.Size = new Size(130, 6);
			ToolStripMenuItem_about.ForeColor = Color.FromArgb(59, 41, 62);
			ToolStripMenuItem_about.Name = "ToolStripMenuItem_about";
			ToolStripMenuItem_about.Size = new Size(133, 22);
			ToolStripMenuItem_about.Text = "Về phần mềm";
			NewtabConfigToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[10] { Team1ToolStripMenuItem, Team2ToolStripMenuItem, Team3ToolStripMenuItem, Team4ToolStripMenuItem, Team5ToolStripMenuItem, Team6ToolStripMenuItem, Team7ToolStripMenuItem, Team8ToolStripMenuItem, Team9ToolStripMenuItem, Team10ToolStripMenuItem });
			NewtabConfigToolStripMenuItem.ForeColor = Color.FromArgb(59, 41, 62);
			NewtabConfigToolStripMenuItem.Name = "NewtabConfigToolStripMenuItem";
			NewtabConfigToolStripMenuItem.Size = new Size(131, 23);
			NewtabConfigToolStripMenuItem.Text = "Thêm thẻ bot theo config";
			Team1ToolStripMenuItem.ForeColor = Color.FromArgb(59, 41, 62);
			Team1ToolStripMenuItem.Name = "Team1ToolStripMenuItem";
			Team1ToolStripMenuItem.Size = new Size(103, 22);
			Team1ToolStripMenuItem.Text = "Team1";
			Team2ToolStripMenuItem.ForeColor = Color.FromArgb(59, 41, 62);
			Team2ToolStripMenuItem.Name = "Team2ToolStripMenuItem";
			Team2ToolStripMenuItem.Size = new Size(103, 22);
			Team2ToolStripMenuItem.Text = "Team2";
			Team3ToolStripMenuItem.ForeColor = Color.FromArgb(59, 41, 62);
			Team3ToolStripMenuItem.Name = "Team3ToolStripMenuItem";
			Team3ToolStripMenuItem.Size = new Size(103, 22);
			Team3ToolStripMenuItem.Text = "Team3";
			Team4ToolStripMenuItem.ForeColor = Color.FromArgb(59, 41, 62);
			Team4ToolStripMenuItem.Name = "Team4ToolStripMenuItem";
			Team4ToolStripMenuItem.Size = new Size(103, 22);
			Team4ToolStripMenuItem.Text = "Team4";
			Team5ToolStripMenuItem.ForeColor = Color.FromArgb(59, 41, 62);
			Team5ToolStripMenuItem.Name = "Team5ToolStripMenuItem";
			Team5ToolStripMenuItem.Size = new Size(103, 22);
			Team5ToolStripMenuItem.Text = "Team5";
			Team6ToolStripMenuItem.ForeColor = Color.FromArgb(59, 41, 62);
			Team6ToolStripMenuItem.Name = "Team6ToolStripMenuItem";
			Team6ToolStripMenuItem.Size = new Size(103, 22);
			Team6ToolStripMenuItem.Text = "Team6";
			Team7ToolStripMenuItem.ForeColor = Color.FromArgb(59, 41, 62);
			Team7ToolStripMenuItem.Name = "Team7ToolStripMenuItem";
			Team7ToolStripMenuItem.Size = new Size(103, 22);
			Team7ToolStripMenuItem.Text = "Team7";
			Team8ToolStripMenuItem.ForeColor = Color.FromArgb(59, 41, 62);
			Team8ToolStripMenuItem.Name = "Team8ToolStripMenuItem";
			Team8ToolStripMenuItem.Size = new Size(103, 22);
			Team8ToolStripMenuItem.Text = "Team8";
			Team9ToolStripMenuItem.ForeColor = Color.FromArgb(59, 41, 62);
			Team9ToolStripMenuItem.Name = "Team9ToolStripMenuItem";
			Team9ToolStripMenuItem.Size = new Size(103, 22);
			Team9ToolStripMenuItem.Text = "Team9";
			Team10ToolStripMenuItem.ForeColor = Color.FromArgb(59, 41, 62);
			Team10ToolStripMenuItem.Name = "Team10ToolStripMenuItem";
			Team10ToolStripMenuItem.Size = new Size(103, 22);
			Team10ToolStripMenuItem.Text = "Team10";
			Save1FileToolStripMenuItem.ForeColor = Color.FromArgb(59, 41, 62);
			Save1FileToolStripMenuItem.Name = "Save1FileToolStripMenuItem";
			Save1FileToolStripMenuItem.Size = new Size(57, 23);
			Save1FileToolStripMenuItem.Text = "Lưu 1 file";
			Load1FileToolStripMenuItem.ForeColor = Color.FromArgb(59, 41, 62);
			Load1FileToolStripMenuItem.Name = "Load1FileToolStripMenuItem";
			Load1FileToolStripMenuItem.Size = new Size(52, 23);
			Load1FileToolStripMenuItem.Text = "Tải 1 file";
			ToolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[11]
			{
				ToolStripMenuItem_thuoctinh, ToolStripMenuItem_lv, ToolStripMenuItem_Mapid, ToolStripMenuItem_Mapname, ToolStripMenuItem_Mini, ToolStripMenuItem_Status, ToolStripMenuItem_Expmin, ToolStripMenuItem_BattleCount, ToolStripMenuItem_PetName, ToolStripMenuItem_PetLv,
				ToolStripMenuItem_MainStatus
			});
			ToolStripMenuItem2.ForeColor = Color.FromArgb(59, 41, 62);
			ToolStripMenuItem2.Name = "ToolStripMenuItem2";
			ToolStripMenuItem2.Size = new Size(102, 23);
			ToolStripMenuItem2.Text = "Thông tin nhân vật";
			ToolStripMenuItem_thuoctinh.Checked = true;
			ToolStripMenuItem_thuoctinh.CheckOnClick = true;
			ToolStripMenuItem_thuoctinh.CheckState = CheckState.Checked;
			ToolStripMenuItem_thuoctinh.ForeColor = Color.FromArgb(59, 41, 62);
			ToolStripMenuItem_thuoctinh.Name = "ToolStripMenuItem_thuoctinh";
			ToolStripMenuItem_thuoctinh.Size = new Size(207, 22);
			ToolStripMenuItem_thuoctinh.Text = "Màu thuộc tính";
			ToolStripMenuItem_lv.Checked = true;
			ToolStripMenuItem_lv.CheckOnClick = true;
			ToolStripMenuItem_lv.CheckState = CheckState.Checked;
			ToolStripMenuItem_lv.ForeColor = Color.FromArgb(59, 41, 62);
			ToolStripMenuItem_lv.Name = "ToolStripMenuItem_lv";
			ToolStripMenuItem_lv.Size = new Size(207, 22);
			ToolStripMenuItem_lv.Text = "Cấp";
			ToolStripMenuItem_Mapid.Checked = true;
			ToolStripMenuItem_Mapid.CheckOnClick = true;
			ToolStripMenuItem_Mapid.CheckState = CheckState.Checked;
			ToolStripMenuItem_Mapid.ForeColor = Color.FromArgb(59, 41, 62);
			ToolStripMenuItem_Mapid.Name = "ToolStripMenuItem_Mapid";
			ToolStripMenuItem_Mapid.Size = new Size(207, 22);
			ToolStripMenuItem_Mapid.Text = "Mapid";
			ToolStripMenuItem_Mapname.Checked = true;
			ToolStripMenuItem_Mapname.CheckOnClick = true;
			ToolStripMenuItem_Mapname.CheckState = CheckState.Checked;
			ToolStripMenuItem_Mapname.ForeColor = Color.FromArgb(59, 41, 62);
			ToolStripMenuItem_Mapname.Name = "ToolStripMenuItem_Mapname";
			ToolStripMenuItem_Mapname.Size = new Size(207, 22);
			ToolStripMenuItem_Mapname.Text = "Bản đồ";
			ToolStripMenuItem_Mini.Checked = true;
			ToolStripMenuItem_Mini.CheckOnClick = true;
			ToolStripMenuItem_Mini.CheckState = CheckState.Checked;
			ToolStripMenuItem_Mini.ForeColor = Color.FromArgb(59, 41, 62);
			ToolStripMenuItem_Mini.Name = "ToolStripMenuItem_Mini";
			ToolStripMenuItem_Mini.Size = new Size(207, 22);
			ToolStripMenuItem_Mini.Text = "Mini";
			ToolStripMenuItem_Status.Checked = true;
			ToolStripMenuItem_Status.CheckOnClick = true;
			ToolStripMenuItem_Status.CheckState = CheckState.Checked;
			ToolStripMenuItem_Status.ForeColor = Color.FromArgb(59, 41, 62);
			ToolStripMenuItem_Status.Name = "ToolStripMenuItem_Status";
			ToolStripMenuItem_Status.Size = new Size(207, 22);
			ToolStripMenuItem_Status.Text = "Hiện tại đang";
			ToolStripMenuItem_Expmin.Checked = true;
			ToolStripMenuItem_Expmin.CheckOnClick = true;
			ToolStripMenuItem_Expmin.CheckState = CheckState.Checked;
			ToolStripMenuItem_Expmin.ForeColor = Color.FromArgb(59, 41, 62);
			ToolStripMenuItem_Expmin.Name = "ToolStripMenuItem_Expmin";
			ToolStripMenuItem_Expmin.Size = new Size(207, 22);
			ToolStripMenuItem_Expmin.Text = "Exp/min";
			ToolStripMenuItem_BattleCount.Checked = true;
			ToolStripMenuItem_BattleCount.CheckOnClick = true;
			ToolStripMenuItem_BattleCount.CheckState = CheckState.Checked;
			ToolStripMenuItem_BattleCount.ForeColor = Color.FromArgb(59, 41, 62);
			ToolStripMenuItem_BattleCount.Name = "ToolStripMenuItem_BattleCount";
			ToolStripMenuItem_BattleCount.Size = new Size(207, 22);
			ToolStripMenuItem_BattleCount.Text = "Số trận đã đánh";
			ToolStripMenuItem_PetName.Checked = true;
			ToolStripMenuItem_PetName.CheckOnClick = true;
			ToolStripMenuItem_PetName.CheckState = CheckState.Checked;
			ToolStripMenuItem_PetName.ForeColor = Color.FromArgb(59, 41, 62);
			ToolStripMenuItem_PetName.Name = "ToolStripMenuItem_PetName";
			ToolStripMenuItem_PetName.Size = new Size(207, 22);
			ToolStripMenuItem_PetName.Text = "Tên Võ Tướng";
			ToolStripMenuItem_PetLv.Checked = true;
			ToolStripMenuItem_PetLv.CheckOnClick = true;
			ToolStripMenuItem_PetLv.CheckState = CheckState.Checked;
			ToolStripMenuItem_PetLv.ForeColor = Color.FromArgb(59, 41, 62);
			ToolStripMenuItem_PetLv.Name = "ToolStripMenuItem_PetLv";
			ToolStripMenuItem_PetLv.Size = new Size(207, 22);
			ToolStripMenuItem_PetLv.Text = "Cấp Võ Tướng";
			ToolStripMenuItem_MainStatus.Checked = true;
			ToolStripMenuItem_MainStatus.CheckOnClick = true;
			ToolStripMenuItem_MainStatus.CheckState = CheckState.Checked;
			ToolStripMenuItem_MainStatus.ForeColor = Color.FromArgb(59, 41, 62);
			ToolStripMenuItem_MainStatus.Name = "ToolStripMenuItem_MainStatus";
			ToolStripMenuItem_MainStatus.Size = new Size(207, 22);
			ToolStripMenuItem_MainStatus.Text = "Cập nhật thông tin 1 giây 1 lần";
			ToolStripComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
			ToolStripComboBox1.Items.AddRange(new object[2] { "VIET", "THAI" });
			ToolStripComboBox1.Name = "ToolStripComboBox1";
			ToolStripComboBox1.Size = new Size(75, 23);
			OpenFileDialog_newtabconfig.FileName = "default";
			OpenFileDialog_newtabconfig.Filter = "Setting files (*.Ini)|*.Ini";
			OpenFileDialog_newtabconfig.Multiselect = true;
			OpenFileDialog_newtabconfig.RestoreDirectory = true;
			ContextMenuStrip_Bot.ImageScalingSize = new Size(20, 20);
			ContextMenuStrip_Bot.Items.AddRange(new ToolStripItem[8] { ToolStripMenuItem_Login, ToolStripSeparator3, ToolStripComboBox_bot, ToolStripMenuItem_Bot, ToolStripSeparator4, ToolStripMenuItem_battle, ToolStripSeparator5, ToolStripMenuItem_Delete });
			ContextMenuStrip_Bot.Name = "ContextMenuStrip_Warp";
			ContextMenuStrip_Bot.RenderMode = ToolStripRenderMode.Professional;
			ContextMenuStrip_Bot.Size = new Size(198, 137);
			ToolStripMenuItem_Login.Name = "ToolStripMenuItem_Login";
			ToolStripMenuItem_Login.Size = new Size(197, 22);
			ToolStripMenuItem_Login.Text = "Đăng nhập";
			ToolStripSeparator3.Name = "ToolStripSeparator3";
			ToolStripSeparator3.Size = new Size(194, 6);
			ToolStripComboBox_bot.DropDownStyle = ComboBoxStyle.DropDownList;
			ToolStripComboBox_bot.Items.AddRange(new object[4] { "a", "b", "c", "d" });
			ToolStripComboBox_bot.Name = "ToolStripComboBox_bot";
			ToolStripComboBox_bot.Size = new Size(121, 23);
			ToolStripMenuItem_Bot.Name = "ToolStripMenuItem_Bot";
			ToolStripMenuItem_Bot.Size = new Size(197, 22);
			ToolStripMenuItem_Bot.Text = "Bắt đầu Bot";
			ToolStripSeparator4.Name = "ToolStripSeparator4";
			ToolStripSeparator4.Size = new Size(194, 6);
			ToolStripMenuItem_battle.Name = "ToolStripMenuItem_battle";
			ToolStripMenuItem_battle.Size = new Size(197, 22);
			ToolStripMenuItem_battle.Text = "Xem thông tin trận đấu";
			ToolStripSeparator5.Name = "ToolStripSeparator5";
			ToolStripSeparator5.Size = new Size(194, 6);
			ToolStripMenuItem_Delete.Name = "ToolStripMenuItem_Delete";
			ToolStripMenuItem_Delete.Size = new Size(197, 22);
			ToolStripMenuItem_Delete.Text = "Xóa";
			Timer2.Enabled = true;
			Timer2.Interval = 1000;
			SaveFileDialog_setting.Filter = "Setting files (*.Ini)|*.Ini";
			SaveFileDialog_setting.RestoreDirectory = true;
			OpenFileDialog_setting.FileName = "default";
			OpenFileDialog_setting.Filter = "Setting files (*.lx)|*.lx";
			OpenFileDialog_setting.RestoreDirectory = true;
			ListView1.Activation = ItemActivation.OneClick;
			ListView1.AutoArrange = false;
			ListView1.Columns.AddRange(new ColumnHeader[13]
			{
				ColumnHeader_Id, ColumnHeader_Name, ColumnHeader_Lv, ColumnHeader_Mapid, ColumnHeader_MapName, ColumnHeader_Mini, ColumnHeader_Online, ColumnHeader_Status, ColumnHeader_ExpMin, ColumnHeader_Battles,
				ColumnHeader_petName, ColumnHeader_PetLv, ColumnHeader_Team
			});
			ListView1.ContextMenuStrip = ContextMenuStrip_Bot;
			ListView1.Dock = DockStyle.Fill;
			ListView1.FullRowSelect = true;
			ListView1.GridLines = true;
			ListView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
			ListView1.HideSelection = false;
			ListView1.Location = new Point(0, 27);
			ListView1.MultiSelect = false;
			ListView1.Name = "ListView1";
			ListView1.ShowGroups = false;
			ListView1.Size = new Size(1008, 508);
			ListView1.TabIndex = 109;
			ToolTip_info.SetToolTip(ListView1, "Nháy đúp chuột trái để hien bang cai dat");
			ListView1.UseCompatibleStateImageBehavior = false;
			ListView1.View = View.Details;
			ColumnHeader_Id.Text = "Id";
			ColumnHeader_Name.Text = "Tên";
			ColumnHeader_Name.Width = 120;
			ColumnHeader_Lv.Text = "Cấp";
			ColumnHeader_Lv.Width = 70;
			ColumnHeader_Mapid.Text = "Mapid";
			ColumnHeader_MapName.Text = "Bản đồ";
			ColumnHeader_MapName.Width = 120;
			ColumnHeader_Mini.Text = "Mini";
			ColumnHeader_Online.Text = "Online";
			ColumnHeader_Status.Text = "Hiện tại đang";
			ColumnHeader_Status.Width = 163;
			ColumnHeader_ExpMin.Text = "Exp/Min";
			ColumnHeader_Battles.Text = "Đã Đánh";
			ColumnHeader_petName.Text = "Võ tướng";
			ColumnHeader_PetLv.Text = "Cấp";
			ColumnHeader_PetLv.Width = 36;
			ColumnHeader_Team.Text = "Team";
			ColumnHeader_Team.Width = 45;
			OpenFileDialog_Load1File.FileName = "default";
			OpenFileDialog_Load1File.Filter = "Setting files (*.1file)|*.1file";
			OpenFileDialog_Load1File.Multiselect = true;
			OpenFileDialog_Load1File.RestoreDirectory = true;
			SaveFileDialog_1file.Filter = "Setting files (*.1file)|*.1file";
			SaveFileDialog_1file.RestoreDirectory = true;
			ComboBox_Server.DropDownStyle = ComboBoxStyle.DropDownList;
			ComboBox_Server.DropDownWidth = 132;
			ComboBox_Server.FlatStyle = FlatStyle.System;
			ComboBox_Server.FormattingEnabled = true;
			ComboBox_Server.Location = new Point(6, 2);
			ComboBox_Server.Margin = new Padding(6, 2, 2, 2);
			ComboBox_Server.Name = "ComboBox_Server";
			ComboBox_Server.Size = new Size(90, 21);
			ComboBox_Server.TabIndex = 111;
			CheckBox_SVip.AutoSize = true;
			CheckBox_SVip.Enabled = false;
			CheckBox_SVip.Location = new Point(159, 4);
			CheckBox_SVip.Name = "CheckBox_SVip";
			CheckBox_SVip.Size = new Size(48, 17);
			CheckBox_SVip.TabIndex = 112;
			CheckBox_SVip.Text = "SVip";
			CheckBox_SVip.UseVisualStyleBackColor = true;
			CheckBox_SVip.Visible = false;
			ComboBox_Style.DropDownStyle = ComboBoxStyle.DropDownList;
			ComboBox_Style.DropDownWidth = 132;
			ComboBox_Style.Enabled = false;
			ComboBox_Style.FlatStyle = FlatStyle.System;
			ComboBox_Style.FormattingEnabled = true;
			ComboBox_Style.Items.AddRange(new object[5] { "None", "Set Thor", "Set Iron", "Set Cap", "Set Thai Duong" });
			ComboBox_Style.Location = new Point(467, 2);
			ComboBox_Style.Margin = new Padding(6, 2, 2, 2);
			ComboBox_Style.Name = "ComboBox_Style";
			ComboBox_Style.Size = new Size(87, 21);
			ComboBox_Style.TabIndex = 113;
			ComboBox_Style.Visible = false;
			ComboBox_Horse.DropDownStyle = ComboBoxStyle.DropDownList;
			ComboBox_Horse.DropDownWidth = 132;
			ComboBox_Horse.Enabled = false;
			ComboBox_Horse.FlatStyle = FlatStyle.System;
			ComboBox_Horse.FormattingEnabled = true;
			ComboBox_Horse.Items.AddRange(new object[60]
			{
				"0\tNone", "18059\tBạch Hổ", "18058\tThú Độc Giác", "18057\tChim Ưng", "18056\tXe Tử Luân", "18055\tChó CTTT", "18054\tXe CTT BắcQuốc", "18053\tXe CTT BắcQuốc", "18052\tXe CTT BắcQuốc", "18051\tXe CTT BắcQuốc",
				"18050\tXe CTT BắcQuốc", "18049\tXe CTT BắcQuốc", "18048\tThiếtkỵCônLôn", "18047\tThiếtkỵCônLôn", "18046\tThiếtkỵCônLôn", "18045\tSưtửchiếudngọc", "18044\tPhi hồng", "18043\tTử tuynh", "18042\tBạch hạc", "18041\tÐạp tuyết",
				"18040\tLưu tinh", "18039\tKỵ Tây Ninh", "18038\tChiếnmãnướcOa", "18037\tU Châu kỵ", "18036\tThanh cúc mã", "18035\tSư vương", "18034\tSư tử", "18033\tMãnh hổ", "18032\tHổ", "18031\tBáo vương",
				"18030\tBáo", "18029\tGấu to", "18028\tGấu", "18027\tSói vương", "18026\tSói", "18025\tVõ trang lạcđà", "18024\tLạc đà", "18023\tLưu Mã", "18022\tMộc Ngưu", "18021\tTiểu thánh",
				"18020\tCônLôn ThầnCâu", "18019\tCônLôn ThầnCâu", "18018\tCônLôn ThầnCâu", "18017\tCônLôn ThầnCâu", "18016\tCoân Loân Caâu", "18015\tNgựa Hung Nô", "18014\tNgựa Tr.Nguyên", "18013\tHạnHuyết BửuMã", "18012\tChảo.H.PhiÐiện", "18011\tTuyệt Bóng mã",
				"18010\tÐích Lô mã", "18009\tÐại Uyển mã", "18008\tGiang Ðông Câu", "18007\tXích Thủ mã", "18006\tÔ Hằng Bạch Mã", "18005\tBạch Mã", "18004\tThanh Tông Mã", "18003\tHòang Biêu Mã", "18002\tÔ Duy Mã", "18001\tTuấn Mã"
			});
			ComboBox_Horse.Location = new Point(254, 2);
			ComboBox_Horse.Margin = new Padding(6, 2, 2, 2);
			ComboBox_Horse.Name = "ComboBox_Horse";
			ComboBox_Horse.Size = new Size(136, 21);
			ComboBox_Horse.TabIndex = 114;
			ComboBox_Horse.Visible = false;
			Label1.AutoSize = true;
			Label1.Enabled = false;
			Label1.Location = new Point(213, 5);
			Label1.Name = "Label1";
			Label1.Size = new Size(32, 13);
			Label1.TabIndex = 115;
			Label1.Text = "Ngựa";
			Label1.Visible = false;
			Label2.AutoSize = true;
			Label2.Enabled = false;
			Label2.Location = new Point(395, 4);
			Label2.Name = "Label2";
			Label2.Size = new Size(63, 13);
			Label2.TabIndex = 116;
			Label2.Text = "Ngoại Trang";
			Label2.Visible = false;
			Panel1.Controls.Add(ComboBox_Server);
			Panel1.Controls.Add(Label2);
			Panel1.Controls.Add(CheckBox_SVip);
			Panel1.Controls.Add(Label1);
			Panel1.Controls.Add(ComboBox_Style);
			Panel1.Controls.Add(ComboBox_Horse);
			Panel1.Dock = DockStyle.Bottom;
			Panel1.Location = new Point(0, 535);
			Panel1.MinimumSize = new Size(1008, 26);
			Panel1.Name = "Panel1";
			Panel1.Size = new Size(1008, 26);
			Panel1.TabIndex = 118;
			base.AutoScaleMode = AutoScaleMode.None;
			base.ClientSize = new Size(1008, 561);
			base.Controls.Add(ListView1);
			base.Controls.Add(MenuStrip1);
			base.Controls.Add(Panel1);
			Font = new Font("Microsoft Sans Serif", 7.5f, FontStyle.Regular, GraphicsUnit.Point, 0);
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.MainMenuStrip = MenuStrip1;
			base.Margin = new Padding(5);
			base.MaximizeBox = false;
			base.Name = "frmMain";
			Text = "Simple Bot 2 - TS online (http://tsonline.xyz)";
			MenuStrip1.ResumeLayout(false);
			MenuStrip1.PerformLayout();
			ContextMenuStrip_Bot.ResumeLayout(false);
			Panel1.ResumeLayout(false);
			Panel1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}
	}
}
