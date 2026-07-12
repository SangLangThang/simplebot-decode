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
	public class frmMain : Form
	{
		public delegate void load1FileDelegate(string[] FileNames);

		public delegate void load1File_botDelegate(string FileName, string _Name);

		public delegate void UpdateMainGridDelegate(TcpClient _s);

		[CompilerGenerated]
		internal sealed class LoadConfigClosure
		{
			public _ClientBot a;

			public LoadConfigClosure(LoadConfigClosure A_0)
			{
				if (A_0 != null)
				{
					a = A_0.a;
				}
			}

			[SpecialName]
			[DebuggerHidden]
			internal void b(object A_0)
			{
				a.LoadConfig(Conversions.ToString(A_0));
			}
		}

		[CompilerGenerated]
		internal sealed class LoadDefaultConfigClosure
		{
			public _ClientBot a;

			[SpecialName]
			[DebuggerHidden]
			internal void b(object A_0)
			{
				a.LoadConfig(Conversions.ToString(A_0));
			}
		}

		[CompilerGenerated]
		internal sealed class LoadConfigThreadClosure
		{
			public _ClientBot a;

			public LoadConfigThreadClosure(LoadConfigThreadClosure A_0)
			{
				if (A_0 != null)
				{
					a = A_0.a;
				}
			}

			[SpecialName]
			[DebuggerHidden]
			internal void b(object A_0)
			{
				a.LoadConfig_Thread((A_0 != null) ? ((API._Type_LoadConfig)A_0) : default(API._Type_LoadConfig));
			}
		}

		private IContainer m_a;

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
		[AccessedThroughProperty("CheckBox_Proxy")]
		[CompilerGenerated]
		private CheckBox bo;

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

		private IPAddress by;

		private IPEndPoint bz;

		private IPEndPoint b0;

		private Socket b1;

		public TreeView treeview1;

		private int b2;

		private Thread b3;

		public string[] SkillIni;

		public string[] PriestIni;

		public string[] Priest_XIni;

		public string[] DoorIni;

		public string[] MapIni;

		public string status;

		public int loaded;

		public const int MOD_ALT = 1;

		public const int MOD_SHIFT = 4;

		public const int MOD_CTRL = 2;

		public const int MOD_WIN = 8;

		public const int WM_HOTKEY = 786;

		public int team;

		private string b4;

		public TcpListener server1;

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
				EventHandler value2 = ad;
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
				EventHandler value2 = aa;
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
				EventHandler value2 = ac;
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
				EventHandler value2 = a;
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
				EventHandler value2 = ab;
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
				CancelEventHandler value2 = c;
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
				EventHandler value2 = z;
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
				CancelEventHandler value2 = e;
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
				EventHandler value2 = y;
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
				EventHandler value2 = u;
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
				EventHandler value2 = x;
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
				CancelEventHandler value2 = d;
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
				MouseEventHandler value2 = a;
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
				EventHandler value2 = v;
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
				EventHandler value2 = t;
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
				EventHandler value2 = t;
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
				EventHandler value2 = t;
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
				EventHandler value2 = t;
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
				EventHandler value2 = t;
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
				EventHandler value2 = t;
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
				EventHandler value2 = t;
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
				EventHandler value2 = t;
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
				EventHandler value2 = t;
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
				EventHandler value2 = t;
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
				EventHandler value2 = s;
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
				EventHandler value2 = s;
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
				EventHandler value2 = s;
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
				EventHandler value2 = s;
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
				EventHandler value2 = s;
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
				EventHandler value2 = s;
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
				EventHandler value2 = s;
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
				EventHandler value2 = s;
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
				EventHandler value2 = s;
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
				EventHandler value2 = s;
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
				EventHandler value2 = r;
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
				EventHandler value2 = q;
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
				CancelEventHandler value2 = b;
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
				CancelEventHandler value2 = a;
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
				EventHandler value2 = p;
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
				EventHandler value2 = o;
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
				EventHandler value2 = n;
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
				EventHandler value2 = m;
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
				EventHandler value2 = l;
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
				EventHandler value2 = k;
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
				EventHandler value2 = j;
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
				EventHandler value2 = i;
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

		internal virtual CheckBox CheckBox_Proxy
		{
			[CompilerGenerated]
			get
			{
				return bo;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = h;
				CheckBox checkBox = bo;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				bo = value;
				checkBox = bo;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
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
				EventHandler value2 = g;
				EventHandler value3 = f;
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
				EventHandler value2 = d;
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
				EventHandler value2 = e;
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
				EventHandler value2 = c;
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
				EventHandler value2 = b;
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

		public frmMain()
		{
			base.Load += Form2_Load;
			base.FormClosing += Form2_Closing;
			by = IPAddress.Any;
			bz = new IPEndPoint(by, 6421);
			b0 = new IPEndPoint(IPAddress.Parse("159.196.179.229"), 6421);
			b1 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
			treeview1 = new TreeView();
			b2 = 0;
			b3 = null;
			status = "";
			loaded = 0;
			team = 0;
			b4 = "127.0.0.1";
			server1 = null;
			b();
		}

		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.m_a != null)
				{
					this.m_a.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		[DebuggerStepThrough]
		private void b()
		{
			this.m_a = new Container();
			Vs2010MenuStripRenderer vs2010MenuStripRenderer = new Vs2010MenuStripRenderer();
			Vs2010DefaultMenuStripColorTable colorTable = new Vs2010DefaultMenuStripColorTable();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMain));
			Timer1 = new System.Windows.Forms.Timer(this.m_a);
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
			ContextMenuStrip_Bot = new ContextMenuStrip(this.m_a);
			ToolStripMenuItem_Login = new ToolStripMenuItem();
			ToolStripSeparator3 = new ToolStripSeparator();
			ToolStripComboBox_bot = new ToolStripComboBox();
			ToolStripMenuItem_Bot = new ToolStripMenuItem();
			ToolStripSeparator4 = new ToolStripSeparator();
			ToolStripMenuItem_battle = new ToolStripMenuItem();
			ToolStripSeparator5 = new ToolStripSeparator();
			ToolStripMenuItem_Delete = new ToolStripMenuItem();
			Timer2 = new System.Windows.Forms.Timer(this.m_a);
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
			ToolTip_info = new ToolTip(this.m_a);
			OpenFileDialog_Load1File = new OpenFileDialog();
			SaveFileDialog_1file = new SaveFileDialog();
			CheckBox_Proxy = new CheckBox();
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
			CheckBox_Proxy.AutoSize = true;
			CheckBox_Proxy.Location = new Point(101, 4);
			CheckBox_Proxy.Name = "CheckBox_Proxy";
			CheckBox_Proxy.Size = new Size(52, 17);
			CheckBox_Proxy.TabIndex = 110;
			CheckBox_Proxy.Text = "Proxy";
			CheckBox_Proxy.UseVisualStyleBackColor = true;
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
			Panel1.Controls.Add(CheckBox_Proxy);
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

		[DllImport("User32.dll")]
		public static extern int RegisterHotKey(IntPtr hwnd, int id, int fsModifiers, int vk);

		[DllImport("User32.dll")]
		public static extern int UnregisterHotKey(IntPtr hwnd, int id);

		protected override void WndProc(ref Message m)
		{
			if (m.Msg == 786)
			{
				string left = m.WParam.ToString();
				if (Operators.CompareString(left, Conversions.ToString(1989), false) == 0)
				{
					Show();
				}
			}
			base.WndProc(ref m);
		}

		public void Form2_Load(object sender, EventArgs e)
		{
			RegisterHotKey(base.Handle, 1989, 1, 90);
			object obj = MyProject.Application.Info.DirectoryPath + "\\Setting\\";
			object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("Scripting.FileSystemObject"));
			object[] obj2 = new object[1] { obj };
			object[] array = obj2;
			bool[] obj3 = new bool[1] { true };
			bool[] array2 = obj3;
			object operand = NewLateBinding.LateGet(objectValue, null, "FolderExists", obj2, null, null, obj3);
			if (array2[0])
			{
				obj = RuntimeHelpers.GetObjectValue(array[0]);
			}
			if (Conversions.ToBoolean(Operators.NotObject(operand)))
			{
				object[] obj4 = new object[1] { obj };
				array = obj4;
				bool[] obj5 = new bool[1] { true };
				array2 = obj5;
				NewLateBinding.LateCall(objectValue, null, "CreateFolder", obj4, null, null, obj5, true);
				if (array2[0])
				{
					obj = RuntimeHelpers.GetObjectValue(array[0]);
				}
			}
			bool missingData = false;
			if (!File.Exists("data\\priest.ini"))
			{
				Interaction.MsgBox("Tập tin [priest.ini] không tồn tại, ứng dụng tự thoát!");
				missingData = true;
				Close();
			}
			if (!File.Exists("data\\priest_x.ini"))
			{
				Interaction.MsgBox("Tập tin [priest_x.ini] không tồn tại, ứng dụng tự thoát!");
				missingData = true;
				Close();
			}
			if (!File.Exists("data\\skill.dat"))
			{
				Interaction.MsgBox("Tập tin [data\\skill.dat] không tồn tại, ứng dụng tự thoát!");
				missingData = true;
				Close();
			}
			if (!File.Exists("data\\map.ini"))
			{
				Interaction.MsgBox("Tập tin [map.ini] không tồn tại, ứng dụng tự thoát!");
				missingData = true;
				Close();
			}
			if (!File.Exists("data\\door.ini"))
			{
				Interaction.MsgBox("Tập tin [door.ini] không tồn tại, ứng dụng tự thoát!");
				missingData = true;
				Close();
			}
			if (!File.Exists("data\\mapname.ini"))
			{
				Interaction.MsgBox("Tập tin [mapname.ini] không tồn tại, ứng dụng tự thoát!");
				missingData = true;
				Close();
			}
			if (!File.Exists("data\\npc.dat"))
			{
				Interaction.MsgBox("Tập tin [data\\npc.dat] không tồn tại, ứng dụng tự thoát!");
				missingData = true;
				Close();
			}
			if (!File.Exists("data\\item.dat"))
			{
				Interaction.MsgBox("Tập tin [item.dat] không tồn tại, ứng dụng tự thoát!");
				missingData = true;
				Close();
			}
			if (missingData)
			{
				return;
			}
			Thread thread = new Thread(LoadDataNpcs);
			thread.IsBackground = true;
			thread.Start();
			ToolStripComboBox1.SelectedIndex = API.Country;
			int country = API.Country;
			if (country == 1)
			{
				API.Language_Path = MyProject.Application.Info.DirectoryPath + "\\Country\\THAI.ini";
				if (File.Exists(API.Language_Path))
				{
					ToolStripMenuItem_system.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Main", "ToolStripMenuItem_system", "");
					ToolStripMenuItem_hide.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Main", "ToolStripMenuItem_hide", "");
					ToolStripMenuItem_exit.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Main", "ToolStripMenuItem_exit", "");
					ToolStripMenuItem_newtab.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Main", "ToolStripMenuItem_newtab", "");
					ToolStripMenuItem_info.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Main", "ToolStripMenuItem_info", "");
					ToolStripMenuItem_home.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Main", "ToolStripMenuItem_home", "");
					ToolStripMenuItem_about.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Main", "ToolStripMenuItem_about", "");
					NewtabConfigToolStripMenuItem.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Main", "NewtabConfigToolStripMenuItem", "");
					Save1FileToolStripMenuItem.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Main", "Save1FileToolStripMenuItem", "");
					Load1FileToolStripMenuItem.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Main", "Load1FileToolStripMenuItem", "");
					ToolStripMenuItem2.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Main", "ToolStripMenuItem2", "");
					ToolStripMenuItem_thuoctinh.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Main", "ToolStripMenuItem_thuoctinh", "");
					ToolStripMenuItem_lv.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Main", "ToolStripMenuItem_lv", "");
					ToolStripMenuItem_Mapname.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Main", "ToolStripMenuItem_Mapname", "");
					ToolStripMenuItem_Status.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Main", "ToolStripMenuItem_Status", "");
					ToolStripMenuItem_BattleCount.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Main", "ToolStripMenuItem_BattleCount", "");
					ToolStripMenuItem_PetName.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Main", "ToolStripMenuItem_PetName", "");
					ToolStripMenuItem_PetLv.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Main", "ToolStripMenuItem_PetLv", "");
					ColumnHeader_Name.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Main", "ColumnHeader_Name", "");
					ColumnHeader_MapName.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Main", "ColumnHeader_MapName", "");
					ColumnHeader_Status.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Main", "ColumnHeader_Status", "");
					ColumnHeader_Battles.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Main", "ColumnHeader_Battles", "");
					ColumnHeader_petName.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Main", "ColumnHeader_petName", "");
					ColumnHeader_PetLv.Text = IniFile.ReadStringOrEmpty(API.Language_Path, "Main", "ColumnHeader_PetLv", "");
				}
			}
		}

		public void Form2_Closing(object sender, FormClosingEventArgs e)
		{
			UnregisterHotKey(base.Handle, 1989);
			MsgBoxResult msgBoxResult = Interaction.MsgBox("Bạn có chắc chắn không?", MsgBoxStyle.YesNo, "Chú ý");
			if (msgBoxResult == MsgBoxResult.No)
			{
				e.Cancel = true;
			}
		}

		public void LoadDataNpcs()
		{
			GetPicture.GetLinks();
			GetPicture.GetPicture_item();
			status = "DataItems_Name loading...";
			GetDataName.LoadDataItems_Name();
			status = "DataNpcs_Name loading...";
			GetDataName.LoadDataNpcs_Name();
			status = "DataSkills_Name loading...";
			GetDataName.LoadDataSkills_Name();
			status = "DataTexps loading...";
			Texps.LoadDataTexps();
			status = "DataNpcs loading...";
			Npcs.LoadDataNpcs();
			status = "DataTalks loading...";
			talk.LoadDataTalks();
			NpcOnMap.LoadDataNpcOnMap();
			status = "DataItems loading...";
			Items.LoadDataItems();
			status = "DataGround loading...";
			Ground.LoadDataGrounds();
			status = "DataAstrolabe loading...";
			Astrolabes.LoadDataAstrolabes();
			Thread thread = new Thread(Getskill);
			thread.IsBackground = true;
			thread.Start();
		}

		public void Getskill()
		{
			status = "load skill.dat";
			Skills.LoadSkills();
			Thread thread = new Thread(Getdoor);
			thread.IsBackground = true;
			thread.Start();
		}

		public void Getdoor()
		{
			Doors.LoadDoors();
			Thread thread = new Thread(Getmap);
			thread.IsBackground = true;
			thread.Start();
		}

		public void Getmap()
		{
			status = "load map.ini";
			if (File.Exists("data\\map.ini"))
			{
				MapIni = MyProject.Computer.FileSystem.ReadAllText("data\\map.ini").Split('\r', '\r');
			}
			Thread thread = new Thread(Getmapname);
			thread.IsBackground = true;
			thread.Start();
		}

		public void Getmapname()
		{
			status = "load mapname.ini";
			MapNames.LoadMapNames();
			Thread thread = new Thread(UpdateMap);
			thread.IsBackground = true;
			thread.Start();
		}

		public void UpdateMap()
		{
			treeview1.Nodes.Clear();
			List<TreeNode> list = new List<TreeNode>();
			int num = 0;
			string[] mapIni = MapIni;
			foreach (string text in mapIni)
			{
				num = checked(num + 1);
				status = "[data\\map.ini] " + Strings.FormatPercent((double)num / (double)MapIni.Length).ToString();
				string text2 = text.Replace("\r\n", "").Replace("\r", "").Replace("\n", "");
				if (text2.Length == 0)
				{
					break;
				}
				string[] array = text2.Split('\t');
				string text3 = Conversions.ToString(Conversions.ToInteger(array[0]));
				string text4 = Conversions.ToString(Conversions.ToInteger(array[1]));
				TreeNode treeNode = new TreeNode();
				treeNode.Name = text3;
				treeNode.Text = text3;
				TreeNode treeNode2 = new TreeNode();
				treeNode2.Name = text4;
				treeNode2.Text = text4 + " - " + Getmapname(Conversions.ToInteger(text4));
				if (treeview1.Nodes.Count == 0)
				{
					treeview1.Nodes.Add(treeNode);
					list.Add(treeNode);
					treeview1.Update();
				}
				foreach (TreeNode item in list)
				{
					if (Operators.CompareString(item.Name, text3, false) == 0)
					{
						list.Add(treeNode2);
						item.Nodes.Add(treeNode2);
						treeview1.Update();
						break;
					}
				}
			}
			loaded = 1;
		}

		public string Getmapname(int id)
		{
			string result = "id";
			if (MapNames.Data_MapNames.ContainsKey(id))
			{
				result = MapNames.Data_MapNames[id];
			}
			return result;
		}

		private void ad(object A_0, EventArgs A_1)
		{
			try
			{
				if (status.Length > 0)
				{
					Text = "Simple Bot - TS online - " + status;
					status = "";
				}
				if (loaded == 1)
				{
					Text = "Simple Bot - TS online - " + base.ProductVersion + " - http://tsonline.xyz/";
					Timer1.Enabled = false;
					MenuStrip1.Enabled = true;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

		private void ac(object A_0, EventArgs A_1)
		{
			Close();
		}

		private void ab(object A_0, EventArgs A_1)
		{
			MyProject.Forms.About.ShowDialog();
		}

		private void aa(object A_0, EventArgs A_1)
		{
			Interaction.MsgBox("Alt+z để hiện");
			Hide();
		}

		private void z(object A_0, EventArgs A_1)
		{
			try
			{
				if (ToolStripMenuItem_MainStatus.Checked)
				{
					foreach (ListViewItem item in ListView1.Items)
					{
						try
						{
							_ClientBot clientBot = (_ClientBot)item.Tag;
							switch (clientBot.logined)
							{
							case 0:
								if (item.SubItems[1].BackColor != SystemColors.Window)
								{
									item.SubItems[1].BackColor = SystemColors.Window;
								}
								if (Operators.CompareString(item.SubItems[1].Text, "", false) != 0)
								{
									item.SubItems[1].Text = "";
								}
								if (Operators.CompareString(item.SubItems[6].Text, "OFF", false) != 0)
								{
									item.SubItems[6].Text = "OFF";
								}
								if ((Operators.CompareString(item.SubItems[7].Text, clientBot.Status, false) != 0) & ToolStripMenuItem_Status.Checked)
								{
									item.SubItems[7].Text = clientBot.Status;
								}
								break;
							case 1:
							{
								if ((clientBot.Data_Player._LeaderId == clientBot.Data_Player._Id) & (clientBot.Data_Player._Id > 0))
								{
									if (item.BackColor != Color.LightBlue)
									{
										item.BackColor = Color.LightBlue;
									}
								}
								else if (item.BackColor != SystemColors.Window)
								{
									item.BackColor = SystemColors.Window;
								}
								if (Operators.CompareString(item.SubItems[0].Text, clientBot.idlogin.ToString(), false) != 0)
								{
									item.SubItems[0].Text = clientBot.idlogin.ToString();
								}
								if (Operators.CompareString(item.SubItems[1].Text, clientBot.Data_Player._Name, false) != 0)
								{
									item.SubItems[1].Text = clientBot.Data_Player._Name;
								}
								int reborn = clientBot.Data_Player._Reborn;
								if (reborn == 3)
								{
									if ((Operators.CompareString(item.SubItems[2].Text, "200 + " + Conversions.ToString(clientBot.Data_Player._Lv2), false) != 0) & ToolStripMenuItem_lv.Checked)
									{
										item.SubItems[2].Text = "200 + " + Conversions.ToString(clientBot.Data_Player._Lv2);
									}
								}
								else if ((Conversions.ToDouble(item.SubItems[2].Text) != (double)clientBot.Data_Player._Lv) & ToolStripMenuItem_lv.Checked)
								{
									item.SubItems[2].Text = Conversions.ToString(clientBot.Data_Player._Lv);
								}
								if ((Conversions.ToDouble(item.SubItems[3].Text) != (double)clientBot.Data_Player._MapId) & ToolStripMenuItem_Mapid.Checked)
								{
									item.SubItems[3].Text = Conversions.ToString(clientBot.Data_Player._MapId);
								}
								if ((Operators.CompareString(item.SubItems[4].Text, clientBot.Data_Player._MapName, false) != 0) & ToolStripMenuItem_Mapname.Checked)
								{
									item.SubItems[4].Text = clientBot.Data_Player._MapName;
								}
								if ((Operators.CompareString(item.SubItems[5].Text, clientBot._Mini_Status, false) != 0) & ToolStripMenuItem_Mini.Checked)
								{
									item.SubItems[5].Text = clientBot._Mini_Status;
								}
								if (Operators.CompareString(item.SubItems[6].Text, clientBot.Online, false) != 0)
								{
									if (ToolStripMenuItem_thuoctinh.Checked)
									{
										item.SubItems[1].BackColor = API.GetColor(clientBot.Data_Player._ThuocTinh);
									}
									item.SubItems[6].Text = clientBot.Online;
								}
								if ((Operators.CompareString(item.SubItems[7].Text, clientBot.Status, false) != 0) & ToolStripMenuItem_Status.Checked)
								{
									item.SubItems[7].Text = clientBot.Status;
								}
								if ((Conversions.ToDouble(item.SubItems[8].Text) != (double)clientBot.Data_Player._ExpMin) & ToolStripMenuItem_Expmin.Checked)
								{
									item.SubItems[8].Text = Conversions.ToString(clientBot.Data_Player._ExpMin);
								}
								if ((Conversions.ToDouble(item.SubItems[9].Text) != (double)clientBot.battlecount) & ToolStripMenuItem_BattleCount.Checked)
								{
									item.SubItems[9].Text = Conversions.ToString(clientBot.battlecount);
								}
								if ((Operators.CompareString(item.SubItems[10].Text, clientBot.Data_PetInfo._Name, false) != 0) & ToolStripMenuItem_PetName.Checked)
								{
									item.SubItems[10].Text = clientBot.Data_PetInfo._Name;
								}
								if ((Conversions.ToDouble(item.SubItems[11].Text) != (double)clientBot.Data_PetInfo._Lv) & ToolStripMenuItem_PetLv.Checked)
								{
									item.SubItems[11].Text = Conversions.ToString(clientBot.Data_PetInfo._Lv);
								}
								break;
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
				}
				foreach (ListViewItem item2 in ListView1.Items)
				{
					try
					{
						_ClientBot clientBot2 = (_ClientBot)item2.Tag;
						if (clientBot2._Proxy && clientBot2._Proxy_Disconnect)
						{
							ListView1.Items.Remove(item2);
							break;
						}
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception ex4 = ex3;
						ProjectData.ClearProjectError();
					}
				}
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				ProjectData.ClearProjectError();
			}
		}

		private void y(object A_0, EventArgs A_1)
		{
			try
			{
				if (ListView1.Items.Count <= 0)
				{
					return;
				}
				_ClientBot clientBot = (_ClientBot)ListView1.SelectedItems[0].Tag;
				if (clientBot != null)
				{
					if (clientBot.Disconnected == 1)
					{
						clientBot._Connect();
					}
					else
					{
						clientBot._Disconnect();
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

		private void e(object A_0, CancelEventArgs A_1)
		{
			try
			{
				if (ListView1.Items.Count <= 0)
				{
					return;
				}
				_ClientBot clientBot = (_ClientBot)ListView1.SelectedItems[0].Tag;
				if (clientBot == null)
				{
					return;
				}
				if (clientBot._Proxy)
				{
					ToolStripComboBox_bot.Visible = false;
					ToolStripMenuItem_Bot.Visible = false;
				}
				else if (clientBot.bott == 0)
				{
					ToolStripMenuItem_Bot.Text = "Bắt đầu Bot";
					if ((clientBot.Data_Player._LeaderId == clientBot.Data_Player._Id) | (clientBot.Data_Player._LeaderId == 0))
					{
						ToolStripComboBox_bot.Enabled = true;
						ToolStripMenuItem_Bot.Enabled = true;
						try
						{
							string[] files = Directory.GetFiles(MyProject.Application.Info.DirectoryPath + "\\QuestBot", "*.ini");
							ToolStripComboBox_bot.Items.Clear();
							string[] array = files;
							foreach (string text in array)
							{
								ToolStripComboBox_bot.Items.Add(checked(text.Substring(text.LastIndexOf("\\") + 1, text.IndexOf(".") - text.LastIndexOf("\\") - 1)));
							}
							if (ToolStripComboBox_bot.Items.Count > 0)
							{
								ToolStripComboBox_bot.SelectedIndex = 0;
							}
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							ProjectData.ClearProjectError();
						}
					}
					else
					{
						ToolStripComboBox_bot.Enabled = false;
						ToolStripMenuItem_Bot.Enabled = false;
					}
				}
				else if (clientBot.bott == 1)
				{
					ToolStripMenuItem_Bot.Text = "Dừng Bot";
					ToolStripComboBox_bot.Enabled = false;
				}
				else if (clientBot.bott == 2)
				{
					ToolStripMenuItem_Bot.Text = "Bắt đầu Bot";
					ToolStripComboBox_bot.Enabled = false;
				}
				if (clientBot.Disconnected == 0)
				{
					ToolStripMenuItem_Login.Text = "Thoát";
				}
				else
				{
					ToolStripMenuItem_Login.Text = "Đăng nhập";
				}
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ProjectData.ClearProjectError();
			}
		}

		private void x(object A_0, EventArgs A_1)
		{
			string text = MyProject.Application.Info.DirectoryPath + "\\QuestBot\\" + ToolStripComboBox_bot.Text + ".ini";
			if (!File.Exists(text))
			{
				return;
			}
			checked
			{
				try
				{
					if (ListView1.Items.Count <= 0)
					{
						return;
					}
					_ClientBot clientBot = (_ClientBot)ListView1.SelectedItems[0].Tag;
					if (clientBot == null)
					{
						return;
					}
					clientBot.packetbot = "";
					clientBot.idmapbot = 0;
					string[] array = MyProject.Computer.FileSystem.ReadAllText(text).Split('\r');
					for (int i = 0; i < array.Length; i++)
					{
						string text2 = array[i];
						text2 = text2.Replace("\n", "");
						if (text2.StartsWith("warpid "))
						{
							int num = Conversions.ToInteger(text2.Substring(7));
							clientBot.packetbot = clientBot.packetbot + "F44404001408" + num.ToString("X2") + "00";
						}
						else if (text2.StartsWith("[") & text2.EndsWith("]"))
						{
							clientBot.idmapbot = Conversions.ToInteger(text2.Replace("]", "").Replace("[", ""));
						}
						else if (text2.StartsWith("walk "))
						{
							string text3 = text2.Substring(5);
							int num2 = Conversions.ToInteger(text3.Substring(0, text3.IndexOf(",")));
							int num3 = Conversions.ToInteger(text3.Substring(text3.IndexOf(",") + 1));
							string text4 = API.bytestohexstring(new byte[2]
							{
								API.hexstringtobyte(num2.ToString("X4"))[1],
								API.hexstringtobyte(num2.ToString("X4"))[0]
							});
							string text5 = API.bytestohexstring(new byte[2]
							{
								API.hexstringtobyte(num3.ToString("X4"))[1],
								API.hexstringtobyte(num3.ToString("X4"))[0]
							});
							clientBot.packetbot = clientBot.packetbot + "F4440900060105" + text4 + text5 + "47EB";
						}
						else if (text2.StartsWith("click "))
						{
							int num4 = Conversions.ToInteger(text2.Substring(6));
							string text6 = API.Int32ToHex2(num4);
							clientBot.packetbot = clientBot.packetbot + "F44404001401" + text6;
						}
						else if (text2.StartsWith("menu "))
						{
							int num5 = Conversions.ToInteger(text2.Substring(5)) + 29;
							clientBot.packetbot = clientBot.packetbot + "F44403001409" + num5.ToString("X2");
						}
						else if (text2.StartsWith("send "))
						{
							int num6 = Conversions.ToInteger(text2.Substring(5));
							string text7 = "";
							int num7 = num6;
							for (int j = 1; j <= num7; j++)
							{
								text7 += "F44402001406";
							}
							clientBot.packetbot += text7;
						}
						else if (text2.StartsWith("battle"))
						{
							break;
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
		}

		private void w(object A_0, EventArgs A_1)
		{
			OpenFileDialog_setting.InitialDirectory = MyProject.Application.Info.DirectoryPath + "\\Setting\\";
			OpenFileDialog_setting.ShowDialog();
		}

		private void d(object A_0, CancelEventArgs A_1)
		{
			string[] fileNames = OpenFileDialog_setting.FileNames;
			foreach (string text in fileNames)
			{
				if (File.Exists(text))
				{
					string text2 = text.Substring(checked(text.LastIndexOf("\\") + 1));
					text2 = text2.Replace(".lx", "");
					if (!text.EndsWith(".lx"))
					{
					}
				}
			}
		}

		private void a(object A_0, MouseEventArgs A_1)
		{
			if (A_1.Button != MouseButtons.Left || ListView1.Items.Count <= 0)
			{
				return;
			}
			try
			{
				_ClientBot clientBot = (_ClientBot)ListView1.SelectedItems[0].Tag;
				if (clientBot != null && clientBot.Setting_show == 0)
				{
					frmClient frmClient2 = new frmClient(clientBot);
					ListView1.SelectedItems[0].SubItems[0].Tag = frmClient2;
					frmClient2.Show();
					clientBot.Setting_show = 1;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

		private void v(object A_0, EventArgs A_1)
		{
			try
			{
				if (ListView1.Items.Count > 0)
				{
					_ClientBot _b = (_ClientBot)ListView1.SelectedItems[0].Tag;
					if (_b != null && _b.battle_show == 0)
					{
						_b.battle_show = 1;
						BattleInfo1 battleInfo = new BattleInfo1(ref _b);
						ListView1.SelectedItems[0].SubItems[1].Tag = battleInfo;
						battleInfo.Show();
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

		private void u(object A_0, EventArgs A_1)
		{
			try
			{
				if (ListView1.Items.Count <= 0)
				{
					return;
				}
				_ClientBot clientBot = (_ClientBot)ListView1.SelectedItems[0].Tag;
				if (clientBot == null)
				{
					return;
				}
				if (clientBot.bott == 0)
				{
					clientBot.bott = 1;
					if (clientBot.logined == 1)
					{
						clientBot._StartBot();
					}
				}
				else if (clientBot.bott == 1)
				{
					clientBot.bott = 2;
					if (clientBot.Battle == 0)
					{
						clientBot.ClickNPCId(99);
					}
				}
				else if (clientBot.bott == 2)
				{
					clientBot.bott = 1;
					if (clientBot.Battle == 0)
					{
						clientBot.ClickNPCId(99);
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

		private void c(object A_0, CancelEventArgs A_1)
		{
			string[] fileNames = OpenFileDialog_newtabconfig.FileNames;
			LoadConfigClosure closure = default(LoadConfigClosure);
			foreach (string text in fileNames)
			{
				if (File.Exists(text) && text.EndsWith(".Ini"))
				{
					_ClientBot clientBot = new _ClientBot();
					closure = new LoadConfigClosure(closure);
					closure.a = clientBot;
					Thread thread = new Thread(closure.b);
					thread.IsBackground = true;
					thread.Start(text);
					ListViewItem listViewItem = ListView1.Items.Add(clientBot.idlogin.ToString());
					listViewItem.UseItemStyleForSubItems = false;
					listViewItem.SubItems.Add(clientBot.Data_Player._Name);
					listViewItem.SubItems.Add(Conversions.ToString(clientBot.Data_Player._Lv));
					listViewItem.SubItems.Add(Conversions.ToString(clientBot.Data_Player._MapId));
					listViewItem.SubItems.Add(clientBot.Data_Player._MapName);
					listViewItem.SubItems.Add("");
					listViewItem.SubItems.Add(clientBot.Online.ToString());
					listViewItem.SubItems.Add(clientBot.Status);
					listViewItem.SubItems.Add(Conversions.ToString(clientBot.Data_Player._ExpMin));
					listViewItem.SubItems.Add(Conversions.ToString(clientBot.battlecount));
					listViewItem.SubItems.Add(clientBot.Data_PetInfo._Name);
					listViewItem.SubItems.Add(Conversions.ToString(clientBot.Data_PetInfo._Lv));
					listViewItem.SubItems.Add(Conversions.ToString(team));
					listViewItem.Tag = clientBot;
				}
			}
		}

		private void t(object A_0, EventArgs A_1)
		{
			team = Conversions.ToInteger(NewLateBinding.LateGet(A_0, null, "name", new object[0], null, null, null).ToString().Substring(4, 2)
				.Replace("T", ""));
			OpenFileDialog_newtabconfig.InitialDirectory = MyProject.Application.Info.DirectoryPath + "\\Setting\\";
			OpenFileDialog_newtabconfig.ShowDialog();
		}

		private void s(object A_0, EventArgs A_1)
		{
			team = Conversions.ToInteger(NewLateBinding.LateGet(A_0, null, "name", new object[0], null, null, null).ToString().Substring(4, 2)
				.Replace("T", ""));
			_ClientBot clientBot = new _ClientBot();
			_ClientBot a = clientBot;
			Thread thread = new Thread([SpecialName] [DebuggerHidden] (object obj) =>
			{
				a.LoadConfig(Conversions.ToString(obj));
			});
			thread.IsBackground = true;
			thread.Start("Setting\\default.Ini");
			ListViewItem listViewItem = ListView1.Items.Add(clientBot.idlogin.ToString());
			listViewItem.UseItemStyleForSubItems = false;
			listViewItem.SubItems.Add(clientBot.Data_Player._Name);
			listViewItem.SubItems.Add(Conversions.ToString(clientBot.Data_Player._Lv));
			listViewItem.SubItems.Add(Conversions.ToString(clientBot.Data_Player._MapId));
			listViewItem.SubItems.Add(clientBot.Data_Player._MapName);
			listViewItem.SubItems.Add("");
			listViewItem.SubItems.Add(clientBot.Online.ToString());
			listViewItem.SubItems.Add(clientBot.Status);
			listViewItem.SubItems.Add(Conversions.ToString(clientBot.Data_Player._ExpMin));
			listViewItem.SubItems.Add(Conversions.ToString(clientBot.battlecount));
			listViewItem.SubItems.Add(clientBot.Data_PetInfo._Name);
			listViewItem.SubItems.Add(Conversions.ToString(clientBot.Data_PetInfo._Lv));
			listViewItem.SubItems.Add(Conversions.ToString(team));
			listViewItem.Tag = clientBot;
		}

		private void r(object A_0, EventArgs A_1)
		{
			if (ListView1.Items.Count > 0)
			{
				SaveFileDialog_1file.InitialDirectory = MyProject.Application.Info.DirectoryPath + "\\Setting\\";
				SaveFileDialog_1file.ShowDialog();
			}
		}

		private void q(object A_0, EventArgs A_1)
		{
			OpenFileDialog_Load1File.InitialDirectory = MyProject.Application.Info.DirectoryPath + "\\Setting\\";
			OpenFileDialog_Load1File.ShowDialog();
		}

		private void b(object A_0, CancelEventArgs A_1)
		{
			string[] fileNames = OpenFileDialog_Load1File.FileNames;
			Thread thread = new Thread([SpecialName] [DebuggerHidden] (object obj) =>
			{
				add1file((string[])obj);
			});
			thread.IsBackground = true;
			thread.Start(fileNames);
		}

		public void add1file(string[] FileNames)
		{
			Delegate method = new load1FileDelegate(add1file_adding);
			Invoke(method, new object[1] { FileNames });
		}

		public void add1file_adding(string[] FileNames)
		{
			LoadConfigThreadClosure closure = default(LoadConfigThreadClosure);
			foreach (string text in FileNames)
			{
				if (!File.Exists(text) || !text.EndsWith(".1file"))
				{
					continue;
				}
				string[] array = IniFile.ReadStringOrEmpty(text, "ListAccount", "Ids", "").Split(',');
				if (array.Length <= 0)
				{
					continue;
				}
				string[] array2 = array;
				foreach (string text2 in array2)
				{
					if (text2.Length > 0)
					{
						_ClientBot clientBot = new _ClientBot();
						if (Operators.CompareString(IniFile.ReadStringOrEmpty(text, text2.ToString(), "_Team", ""), "", false) != 0)
						{
							API._Type_LoadConfig type_LoadConfig = new API._Type_LoadConfig
							{
								_path = text,
								_name = text2
							};
							closure = new LoadConfigThreadClosure(closure);
							closure.a = clientBot;
							Thread thread = new Thread(closure.b);
							thread.IsBackground = true;
							thread.Start(type_LoadConfig);
							ListViewItem listViewItem = ListView1.Items.Add(clientBot.idlogin.ToString());
							listViewItem.UseItemStyleForSubItems = false;
							listViewItem.SubItems.Add(clientBot.Data_Player._Name);
							listViewItem.SubItems.Add(Conversions.ToString(clientBot.Data_Player._Lv));
							listViewItem.SubItems.Add(Conversions.ToString(clientBot.Data_Player._MapId));
							listViewItem.SubItems.Add(clientBot.Data_Player._MapName);
							listViewItem.SubItems.Add("");
							listViewItem.SubItems.Add(clientBot.Online.ToString());
							listViewItem.SubItems.Add(clientBot.Status);
							listViewItem.SubItems.Add(Conversions.ToString(clientBot.Data_Player._ExpMin));
							listViewItem.SubItems.Add(Conversions.ToString(clientBot.battlecount));
							listViewItem.SubItems.Add(clientBot.Data_PetInfo._Name);
							listViewItem.SubItems.Add(Conversions.ToString(clientBot.Data_PetInfo._Lv));
							listViewItem.SubItems.Add(IniFile.ReadStringOrEmpty(text, text2.ToString(), "_Team", ""));
							listViewItem.Tag = clientBot;
						}
					}
					ListView1.Update();
					Thread.Sleep(100);
				}
			}
		}

		private void a(object A_0, CancelEventArgs A_1)
		{
			string fileName = SaveFileDialog_1file.FileName;
			string text = "";
			foreach (ListViewItem item in ListView1.Items)
			{
				_ClientBot clientBot = (_ClientBot)item.Tag;
				if (!clientBot._Proxy)
				{
					clientBot.SaveConfig(fileName, clientBot.idlogin.ToString());
					text = text + "," + item.SubItems[0].Text;
					IniFile.WriteString(fileName, clientBot.idlogin.ToString(), "_Team", item.SubItems[checked(ListView1.Columns.Count - 1)].Text);
				}
			}
			IniFile.WriteString(fileName, "ListAccount", "Ids", text);
		}

		private void p(object A_0, EventArgs A_1)
		{
			try
			{
				if (ListView1.Items.Count <= 0)
				{
					return;
				}
				_ClientBot clientBot = (_ClientBot)ListView1.SelectedItems[0].Tag;
				if (clientBot != null)
				{
					MsgBoxResult msgBoxResult = Interaction.MsgBox("Bạn có chắc chắn muốn tắt bot của Id [" + Conversions.ToString(clientBot.idlogin) + "] không?", MsgBoxStyle.YesNo, "Cảnh báo!");
					if (msgBoxResult == MsgBoxResult.No)
					{
						return;
					}
					clientBot.Deleted = 1;
					clientBot.C_CheckBox_Reconnect = false;
					clientBot._Disconnect();
				}
				ListView1.Items.Remove(ListView1.SelectedItems[0]);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

		private void o(object A_0, EventArgs A_1)
		{
			object left = NewLateBinding.LateGet(A_0, null, "Checked", new object[0], null, null, null);
			if (Operators.ConditionalCompareObjectEqual(left, true, false))
			{
				if (ListView1.Columns.Count > 2)
				{
					ListView1.Columns[2].Width = 36;
				}
			}
			else if (Operators.ConditionalCompareObjectEqual(left, false, false) && ListView1.Columns.Count > 2)
			{
				ListView1.Columns[2].Width = 0;
			}
		}

		private void n(object A_0, EventArgs A_1)
		{
			object left = NewLateBinding.LateGet(A_0, null, "Checked", new object[0], null, null, null);
			if (Operators.ConditionalCompareObjectEqual(left, true, false))
			{
				if (ListView1.Columns.Count > 3)
				{
					ListView1.Columns[3].Width = 60;
				}
			}
			else if (Operators.ConditionalCompareObjectEqual(left, false, false) && ListView1.Columns.Count > 3)
			{
				ListView1.Columns[3].Width = 0;
			}
		}

		private void m(object A_0, EventArgs A_1)
		{
			object left = NewLateBinding.LateGet(A_0, null, "Checked", new object[0], null, null, null);
			if (Operators.ConditionalCompareObjectEqual(left, true, false))
			{
				if (ListView1.Columns.Count > 4)
				{
					ListView1.Columns[4].Width = 140;
				}
			}
			else if (Operators.ConditionalCompareObjectEqual(left, false, false) && ListView1.Columns.Count > 4)
			{
				ListView1.Columns[4].Width = 0;
			}
		}

		private void l(object A_0, EventArgs A_1)
		{
			object left = NewLateBinding.LateGet(A_0, null, "Checked", new object[0], null, null, null);
			if (Operators.ConditionalCompareObjectEqual(left, true, false))
			{
				if (ListView1.Columns.Count > 5)
				{
					ListView1.Columns[5].Width = 60;
				}
			}
			else if (Operators.ConditionalCompareObjectEqual(left, false, false) && ListView1.Columns.Count > 5)
			{
				ListView1.Columns[5].Width = 0;
			}
		}

		private void k(object A_0, EventArgs A_1)
		{
			object left = NewLateBinding.LateGet(A_0, null, "Checked", new object[0], null, null, null);
			if (Operators.ConditionalCompareObjectEqual(left, true, false))
			{
				if (ListView1.Columns.Count > 6)
				{
					ListView1.Columns[7].Width = 163;
				}
			}
			else if (Operators.ConditionalCompareObjectEqual(left, false, false) && ListView1.Columns.Count > 6)
			{
				ListView1.Columns[7].Width = 0;
			}
		}

		private void j(object A_0, EventArgs A_1)
		{
			object left = NewLateBinding.LateGet(A_0, null, "Checked", new object[0], null, null, null);
			if (Operators.ConditionalCompareObjectEqual(left, true, false))
			{
				if (ListView1.Columns.Count > 7)
				{
					ListView1.Columns[8].Width = 60;
				}
			}
			else if (Operators.ConditionalCompareObjectEqual(left, false, false) && ListView1.Columns.Count > 7)
			{
				ListView1.Columns[8].Width = 0;
			}
		}

		private void i(object A_0, EventArgs A_1)
		{
			object left = NewLateBinding.LateGet(A_0, null, "Checked", new object[0], null, null, null);
			if (Operators.ConditionalCompareObjectEqual(left, true, false))
			{
				if (ListView1.Columns.Count > 8)
				{
					ListView1.Columns[9].Width = 60;
				}
			}
			else if (Operators.ConditionalCompareObjectEqual(left, false, false) && ListView1.Columns.Count > 8)
			{
				ListView1.Columns[9].Width = 0;
			}
		}

		private void h(object A_0, EventArgs A_1)
		{
			switch (CheckBox_Proxy.Checked)
			{
			case true:
				try
				{
					ComboBox_Server.Enabled = false;
					IPAddress localaddr = IPAddress.Parse(b4);
					try
					{
						server1 = new TcpListener(localaddr, 6414);
						server1.Start(65535);
						API.Proxy = true;
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception ex4 = ex3;
						Interaction.MsgBox("Không thể tạo Proxy, có thể phần mềm khác đã tạo, vui lòng kiểm tra!!!");
						CheckBox_Proxy.Checked = false;
						ProjectData.ClearProjectError();
						break;
					}
					Interaction.MsgBox("Tạo Proxy thành công!!!");
					Thread thread = new Thread(GetConnect);
					thread.IsBackground = true;
					thread.Start();
					break;
				}
				catch (Exception ex5)
				{
					ProjectData.SetProjectError(ex5);
					Exception ex6 = ex5;
					Interaction.MsgBox("Không thể tạo Proxy, có thể phần mềm khác đã tạo, vui lòng kiểm tra!!!");
					ProjectData.ClearProjectError();
					break;
				}
			case false:
				try
				{
					ComboBox_Server.Enabled = true;
					API.Proxy = false;
					server1.Stop();
					Interaction.MsgBox("Dừng Proxy thành công!!!");
					break;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
					break;
				}
			}
		}

		public void Connection(TcpClient _s)
		{
			_ClientBot clientBot = new _ClientBot(_s);
			clientBot._Proxy = true;
			clientBot.ComboBox_Port = 0;
			ListViewItem listViewItem = ListView1.Items.Add(clientBot.idlogin.ToString());
			listViewItem.UseItemStyleForSubItems = false;
			listViewItem.SubItems.Add(clientBot.Data_Player._Name);
			listViewItem.SubItems.Add(Conversions.ToString(clientBot.Data_Player._Lv));
			listViewItem.SubItems.Add(Conversions.ToString(clientBot.Data_Player._MapId));
			listViewItem.SubItems.Add(clientBot.Data_Player._MapName);
			listViewItem.SubItems.Add("");
			listViewItem.SubItems.Add(clientBot.Online.ToString());
			listViewItem.SubItems.Add(clientBot.Status);
			listViewItem.SubItems.Add(Conversions.ToString(clientBot.Data_Player._ExpMin));
			listViewItem.SubItems.Add(Conversions.ToString(clientBot.battlecount));
			listViewItem.SubItems.Add(clientBot.Data_PetInfo._Name);
			listViewItem.SubItems.Add(Conversions.ToString(clientBot.Data_PetInfo._Lv));
			listViewItem.SubItems.Add(Conversions.ToString(team));
			listViewItem.Tag = clientBot;
		}

		public void GetConnect()
		{
			Delegate method = new UpdateMainGridDelegate(Connection);
			while (true)
			{
				try
				{
					TcpClient tcpClient = server1.AcceptTcpClient();
					Invoke(method, tcpClient);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
			}
		}

		private void g(object A_0, EventArgs A_1)
		{
			try
			{
				string text = "server.ini";
				if (File.Exists(text))
				{
					string[] array = MyProject.Computer.FileSystem.ReadAllText(text).Split('\r');
					foreach (string text2 in array)
					{
						string[] array2 = text2.Split('*');
						if (Operators.CompareString(ComboBox_Server.Text, array2[0], false) == 0)
						{
							API.ServerIp = array2[1];
							switch (API.List_Ip_nts.Contains(API.ServerIp))
							{
							case true:
								ComboBox_Style.Enabled = true;
								ComboBox_Style.Visible = true;
								CheckBox_SVip.Enabled = true;
								CheckBox_SVip.Visible = true;
								ComboBox_Horse.Enabled = true;
								ComboBox_Horse.Visible = true;
								Label1.Enabled = true;
								Label1.Visible = true;
								Label2.Enabled = true;
								Label2.Visible = true;
								break;
							case false:
								ComboBox_Style.Enabled = false;
								ComboBox_Style.Visible = false;
								CheckBox_SVip.Enabled = false;
								CheckBox_SVip.Visible = false;
								ComboBox_Horse.Enabled = false;
								ComboBox_Horse.Visible = false;
								Label1.Enabled = false;
								Label1.Visible = false;
								Label2.Enabled = false;
								Label2.Visible = false;
								break;
							}
							break;
						}
					}
				}
				else
				{
					Interaction.MsgBox("File server.ini không tồn tại");
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

		private void f(object A_0, EventArgs A_1)
		{
			try
			{
				string text = "server.ini";
				ComboBox_Server.Items.Clear();
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
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

		private void e(object A_0, EventArgs A_1)
		{
			switch (ComboBox_Style.Text)
			{
			case "None":
				API.Style = 0;
				break;
			case "Set Cap":
				API.Style = 1;
				break;
			case "Set Thor":
				API.Style = 2;
				break;
			case "Set Iron":
				API.Style = 3;
				break;
			case "Set Thai Duong":
				API.Style = 4;
				break;
			}
			a(API.Style);
		}

		private void a(int A_0)
		{
			foreach (ListViewItem item in ListView1.Items)
			{
				try
				{
					_ClientBot clientBot = (_ClientBot)item.Tag;
					if (!(clientBot._Proxy & (clientBot.logined == 1) & API.List_Ip_nts.Contains(API.ServerIp)))
					{
						continue;
					}
					ArrayList arrayList = new ArrayList();
					switch (A_0)
					{
					case 0:
						arrayList = API.List_Style0;
						break;
					case 1:
						arrayList = API.List_Style1;
						break;
					case 2:
						arrayList = API.List_Style2;
						break;
					case 3:
						arrayList = API.List_Style3;
						break;
					case 4:
						arrayList = API.List_Style4;
						break;
					}
					int num = Conversions.ToInteger(arrayList[0]);
					int num2 = Conversions.ToInteger(arrayList[1]);
					int num3 = Conversions.ToInteger(arrayList[2]);
					int num4 = Conversions.ToInteger(arrayList[3]);
					int num5 = Conversions.ToInteger(arrayList[4]);
					string text = "";
					if (A_0 == 0)
					{
						text = API.Packet_Maker("17100700");
						text += API.Packet_Maker("17100800");
						text += API.Packet_Maker("17100900");
						text += API.Packet_Maker("17100A00");
						text += API.Packet_Maker("17100B00");
						byte[] packet = API.hexstringtobyte(text);
						clientBot._Local_SendPacket(packet);
					}
					else
					{
						if (num > 0)
						{
							text = text + API.Int32ToHex2(num) + "0000000000000000";
						}
						if (num2 > 0)
						{
							text = text + API.Int32ToHex2(num2) + "0000000000000000";
						}
						if (num3 > 0)
						{
							text = text + API.Int32ToHex2(num3) + "0000000000000000";
						}
						if (num4 > 0)
						{
							text = text + API.Int32ToHex2(num4) + "0000000000000000";
						}
						if (num5 > 0)
						{
							text = text + API.Int32ToHex2(num5) + "0000000000000000";
						}
						byte[] packet2 = API.hexstringtobyte(API.Packet_Maker("170B" + text));
						clientBot._Local_SendPacket(packet2);
					}
					text = "";
					if (num > 0)
					{
						text += API.Int32ToHex2(num);
					}
					if (num2 > 0)
					{
						text += API.Int32ToHex2(num2);
					}
					if (num3 > 0)
					{
						text += API.Int32ToHex2(num3);
					}
					if (num4 > 0)
					{
						text += API.Int32ToHex2(num4);
					}
					if (num5 > 0)
					{
						text += API.Int32ToHex2(num5);
					}
					int textBox_IDmem = clientBot.TextBox_IDmem1;
					int textBox_IDmem2 = clientBot.TextBox_IDmem2;
					int textBox_IDmem3 = clientBot.TextBox_IDmem3;
					int textBox_IDmem4 = clientBot.TextBox_IDmem4;
					byte[] packet3 = API.hexstringtobyte(API.Packet_Maker("0500" + API.Int32ToHex4(textBox_IDmem) + text));
					byte[] packet4 = API.hexstringtobyte(API.Packet_Maker("0500" + API.Int32ToHex4(textBox_IDmem2) + text));
					byte[] packet5 = API.hexstringtobyte(API.Packet_Maker("0500" + API.Int32ToHex4(textBox_IDmem3) + text));
					byte[] packet6 = API.hexstringtobyte(API.Packet_Maker("0500" + API.Int32ToHex4(textBox_IDmem4) + text));
					clientBot._Local_SendPacket(packet3);
					clientBot._Local_SendPacket(packet4);
					clientBot._Local_SendPacket(packet5);
					clientBot._Local_SendPacket(packet6);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
			}
		}

		private void d(object A_0, EventArgs A_1)
		{
			switch (CheckBox_SVip.Checked)
			{
			case true:
				API.Vip = 4;
				break;
			case false:
				API.Vip = 0;
				break;
			}
			foreach (ListViewItem item in ListView1.Items)
			{
				try
				{
					_ClientBot clientBot = (_ClientBot)item.Tag;
					if ((clientBot._Proxy & (clientBot.logined == 1)) && ((API.Vip >= 0) & API.List_Ip_nts.Contains(API.ServerIp)))
					{
						byte[] packet = API.hexstringtobyte(API.Packet_Maker("08010201" + API.Vip.ToString("X2")));
						clientBot._Local_SendPacket(packet);
						try
						{
							int textBox_IDmem = clientBot.TextBox_IDmem1;
							int textBox_IDmem2 = clientBot.TextBox_IDmem2;
							int textBox_IDmem3 = clientBot.TextBox_IDmem3;
							int textBox_IDmem4 = clientBot.TextBox_IDmem4;
							byte[] packet2 = API.hexstringtobyte(API.Packet_Maker("080D" + API.Int32ToHex4(textBox_IDmem) + API.Vip.ToString("X2")));
							byte[] packet3 = API.hexstringtobyte(API.Packet_Maker("080D" + API.Int32ToHex4(textBox_IDmem2) + API.Vip.ToString("X2")));
							byte[] packet4 = API.hexstringtobyte(API.Packet_Maker("080D" + API.Int32ToHex4(textBox_IDmem3) + API.Vip.ToString("X2")));
							byte[] packet5 = API.hexstringtobyte(API.Packet_Maker("080D" + API.Int32ToHex4(textBox_IDmem4) + API.Vip.ToString("X2")));
							clientBot._Local_SendPacket(packet2);
							clientBot._Local_SendPacket(packet3);
							clientBot._Local_SendPacket(packet4);
							clientBot._Local_SendPacket(packet5);
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							ProjectData.ClearProjectError();
						}
					}
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					ProjectData.ClearProjectError();
				}
			}
		}

		private void c(object A_0, EventArgs A_1)
		{
			if (ComboBox_Horse.Text.Length > 0)
			{
				string[] array = ComboBox_Horse.Text.Split('\t');
				int iDNgua = Conversions.ToInteger(array[0]);
				API.IDNgua = iDNgua;
			}
			a();
		}

		private void a()
		{
			foreach (ListViewItem item in ListView1.Items)
			{
				try
				{
					_ClientBot clientBot = (_ClientBot)item.Tag;
					if (clientBot._Proxy & (clientBot.logined == 1) & API.List_Ip_nts.Contains(API.ServerIp))
					{
						clientBot.Doi_Ngua();
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

		private void b(object A_0, EventArgs A_1)
		{
			string left = ToolStripComboBox1.Text;
			if (Operators.CompareString(left, "VIET", false) != 0)
			{
				if (Operators.CompareString(left, "THAI", false) == 0 && API.Country != 1)
				{
					API.Country = 1;
					Interaction.MsgBox("ร\u0e35สตาร\u0e4cทซอฟต\u0e4cแวร\u0e4cเพ\u0e37\u0e48อเป\u0e34ดใช\u0e49งาน");
				}
			}
			else if (API.Country != 0)
			{
				API.Country = 0;
				Interaction.MsgBox("Khởi động lại phần mềm để kích hoạt");
			}
		}

		private void a(object A_0, EventArgs A_1)
		{
			a("http://tsonline.xyz");
		}

		private void a(string A_0, string A_1 = "default")
		{
			try
			{
				if (Operators.CompareString(A_1, "default", false) != 0)
				{
					try
					{
						Process.Start(A_1, A_0);
						return;
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						Process.Start(A_0);
						ProjectData.ClearProjectError();
						return;
					}
				}
				Process.Start(A_0);
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ProjectData.ClearProjectError();
			}
		}

		[SpecialName]
		[CompilerGenerated]
		[DebuggerHidden]
		private void a(object A_0)
		{
			add1file((string[])A_0);
		}
	}
}
