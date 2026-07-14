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
	[DesignerGenerated]
	public partial class frmClient : Form
	{
		private IContainer components;

		[AccessedThroughProperty("rtbsystem")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private RichTextBox m_b;

		[AccessedThroughProperty("GroupBox_team")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private GroupBox m_c;

		[AccessedThroughProperty("RadioButton_QS4")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private RadioButton m_d;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("RadioButton_QS3")]
		[CompilerGenerated]
		private RadioButton m_e;

		[AccessedThroughProperty("RadioButton_QS2")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private RadioButton m_f;

		[AccessedThroughProperty("RadioButton_QS1")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private RadioButton m_g;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TextBox_IDmem1")]
		private TextBox m_h;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TextBox_IDmem4")]
		private TextBox m_i;

		[AccessedThroughProperty("TextBox_IDmem3")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private TextBox m_j;

		[CompilerGenerated]
		[AccessedThroughProperty("TextBox_IDmem2")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private TextBox m_k;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TextBox_IdLeader")]
		[CompilerGenerated]
		private TextBox m_l;

		[CompilerGenerated]
		[AccessedThroughProperty("Label_PetExpMin")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Label m_m;

		[AccessedThroughProperty("ProgressBarEx_PetHp")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ProgressBarEx m_n;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label8")]
		[CompilerGenerated]
		private Label m_o;

		[AccessedThroughProperty("ProgressBarEx_PetSp")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ProgressBarEx m_p;

		[AccessedThroughProperty("ProgressBarEx_PetExp")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ProgressBarEx m_q;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("RtbChat")]
		private RichTextBox m_r;

		[AccessedThroughProperty("ComboBox_chat")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ComboBox m_s;

		[CompilerGenerated]
		[AccessedThroughProperty("ComboBox_nameprivate")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ComboBox m_t;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ComboBox_kenh")]
		private ComboBox m_u;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataSet1")]
		[CompilerGenerated]
		private DataSet m_v;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataTable1")]
		private DataTable m_w;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn1")]
		private DataColumn m_x;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn2")]
		private DataColumn m_y;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn3")]
		[CompilerGenerated]
		private DataColumn m_z;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn4")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn m_aa;

		[AccessedThroughProperty("DataColumn5")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn m_ab;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn6")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn m_ac;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn7")]
		private DataColumn m_ad;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn8")]
		private DataColumn m_ae;

		[AccessedThroughProperty("DataTable2")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataTable m_af;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn9")]
		[CompilerGenerated]
		private DataColumn m_ag;

		[AccessedThroughProperty("DataColumn10")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn m_ah;

		[AccessedThroughProperty("DataColumn11")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn m_ai;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn12")]
		[CompilerGenerated]
		private DataColumn m_aj;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn13")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn m_ak;

		[AccessedThroughProperty("DataColumn14")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn m_al;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn15")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn m_am;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn16")]
		private DataColumn m_an;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn17")]
		[CompilerGenerated]
		private DataColumn m_ao;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn18")]
		private DataColumn m_ap;

		[AccessedThroughProperty("DataColumn19")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn m_aq;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("Label_PlayerCount")]
		private Label m_ar;

		[AccessedThroughProperty("StatusBar1")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private StatusBar m_as;

		[AccessedThroughProperty("RadioButton_dia")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private RadioButton m_at;

		[AccessedThroughProperty("RadioButton_thuy")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private RadioButton m_au;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("RadioButton_phong")]
		private RadioButton m_av;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("RadioButton_hoa")]
		private RadioButton m_aw;

		[CompilerGenerated]
		[AccessedThroughProperty("Label11")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Label m_ax;

		[CompilerGenerated]
		[AccessedThroughProperty("Label1")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Label m_ay;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label2")]
		[CompilerGenerated]
		private Label m_az;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("NumericUpDown_createDef")]
		private NumericUpDown m_a0;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("NumericUpDown_createAtk")]
		private NumericUpDown m_a1;

		[CompilerGenerated]
		[AccessedThroughProperty("Label16")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Label m_a2;

		[AccessedThroughProperty("Label_point")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Label m_a3;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("NumericUpDown_createInt")]
		[CompilerGenerated]
		private NumericUpDown m_a4;

		[AccessedThroughProperty("Label10")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Label m_a5;

		[CompilerGenerated]
		[AccessedThroughProperty("NumericUpDown_createAgi")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private NumericUpDown m_a6;

		[AccessedThroughProperty("NumericUpDown_createHp")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private NumericUpDown m_a7;

		[AccessedThroughProperty("Label15")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Label m_a8;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("NumericUpDown_createSp")]
		[CompilerGenerated]
		private NumericUpDown m_a9;

		[CompilerGenerated]
		[AccessedThroughProperty("Label14")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Label m_ba;

		[AccessedThroughProperty("Label17")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Label m_bb;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ComboBox_sex")]
		[CompilerGenerated]
		private ComboBox m_bc;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("Label19")]
		private Label m_bd;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label18")]
		private Label m_be;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TextBox_createName")]
		private TextBox m_bf;

		[AccessedThroughProperty("TextBox_Pass")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private TextBox m_bg;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TextBox_amma")]
		private TextBox m_bh;

		[AccessedThroughProperty("Button_StartAutoQuest")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Button m_bi;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("ComboBox_Quest")]
		private ComboBox m_bj;

		[CompilerGenerated]
		[AccessedThroughProperty("TreeView1")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private TreeView m_bk;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TextBox_idWarp")]
		[CompilerGenerated]
		private TextBox m_bl;

		[AccessedThroughProperty("Button_warp")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Button m_bm;

		[AccessedThroughProperty("Timer_100")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private System.Windows.Forms.Timer m_bn;

		[AccessedThroughProperty("Timer_autoquest")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private System.Windows.Forms.Timer m_bo;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Timer_delay")]
		[CompilerGenerated]
		private System.Windows.Forms.Timer m_bp;

		[AccessedThroughProperty("ContextMenuStrip_Warp")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private ContextMenuStrip m_bq;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("ToolStripMenuItem_Warp")]
		private ToolStripMenuItem m_br;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button_bot")]
		private Button m_bs;

		[CompilerGenerated]
		[AccessedThroughProperty("ComboBox_botname")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ComboBox m_bt;

		[CompilerGenerated]
		[AccessedThroughProperty("Button_walk")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Button bu;

		[AccessedThroughProperty("TextBox_walkY")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private TextBox bv;

		[AccessedThroughProperty("TextBox_walkX")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private TextBox bw;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn20")]
		private DataColumn bx;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn21")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn by;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn22")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn bz;

		[AccessedThroughProperty("DataTable3")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataTable b0;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn23")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn b1;

		[AccessedThroughProperty("DataColumn24")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn b2;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn25")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn b3;

		[AccessedThroughProperty("DataColumn26")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn b4;

		[AccessedThroughProperty("DataColumn27")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn b5;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn28")]
		private DataColumn b6;

		[AccessedThroughProperty("DataColumn29")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn b7;

		[AccessedThroughProperty("DataColumn30")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn b8;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn31")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn b9;

		[AccessedThroughProperty("DataColumn32")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn ca;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn33")]
		private DataColumn cb;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn34")]
		private DataColumn cc;

		[CompilerGenerated]
		[AccessedThroughProperty("Panel_Chat")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Panel cd;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label_CharExpMin")]
		[CompilerGenerated]
		private Label ce;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label4")]
		[CompilerGenerated]
		private Label cf;

		[CompilerGenerated]
		[AccessedThroughProperty("Label_gold")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Label cg;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ProgressBarEx_CharExp")]
		[CompilerGenerated]
		private ProgressBarEx ch;

		[AccessedThroughProperty("ProgressBarEx_CharSp")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ProgressBarEx ci;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("ProgressBarEx_CharHp")]
		private ProgressBarEx cj;

		[AccessedThroughProperty("GroupBox_Bot")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private GroupBox ck;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TextBox_idWarp2")]
		[CompilerGenerated]
		private TextBox cl;

		[AccessedThroughProperty("Button_warp2")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Button cm;

		[CompilerGenerated]
		[AccessedThroughProperty("StatusBarPanel_online")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private StatusBarPanel cn;

		[AccessedThroughProperty("Label_Lv")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Label co;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("Button_RequestParty")]
		private Button cp;

		[CompilerGenerated]
		[AccessedThroughProperty("DataTable4")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataTable cq;

		[AccessedThroughProperty("DataColumn35")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn cr;

		[AccessedThroughProperty("DataColumn36")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn cs;

		[AccessedThroughProperty("DataColumn37")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn ct;

		[AccessedThroughProperty("DataColumn38")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn cu;

		[AccessedThroughProperty("DataColumn39")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn cv;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataTable5")]
		[CompilerGenerated]
		private DataTable cw;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn40")]
		private DataColumn cx;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn41")]
		[CompilerGenerated]
		private DataColumn cy;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn42")]
		private DataColumn cz;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn43")]
		[CompilerGenerated]
		private DataColumn c0;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn44")]
		private DataColumn c1;

		[AccessedThroughProperty("DataTable6")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataTable c2;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn45")]
		private DataColumn c3;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn46")]
		private DataColumn c4;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn47")]
		private DataColumn c5;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn48")]
		private DataColumn c6;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn49")]
		private DataColumn c7;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn50")]
		private DataColumn c8;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn51")]
		private DataColumn c9;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn52")]
		private DataColumn da;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataTable7")]
		private DataTable db;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataTable8")]
		private DataTable dc;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn53")]
		private DataColumn dd;

		[AccessedThroughProperty("DataColumn54")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn de;

		[AccessedThroughProperty("DataColumn55")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn df;

		[AccessedThroughProperty("DataColumn56")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn dg;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn57")]
		private DataColumn dh;

		[AccessedThroughProperty("DataColumn58")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn di;

		[AccessedThroughProperty("DataColumn59")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn dj;

		[AccessedThroughProperty("DataColumn60")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn dk;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn61")]
		[CompilerGenerated]
		private DataColumn dl;

		[AccessedThroughProperty("DataColumn62")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn dm;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn63")]
		private DataColumn dn;

		[AccessedThroughProperty("DataColumn64")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn dp;

		[AccessedThroughProperty("DataColumn65")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn dq;

		[AccessedThroughProperty("DataColumn66")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn dr;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn67")]
		[CompilerGenerated]
		private DataColumn ds;

		[AccessedThroughProperty("DataColumn68")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn dt;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn69")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn du;

		[AccessedThroughProperty("DataColumn70")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn dv;

		[AccessedThroughProperty("DataColumn71")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn dw;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn72")]
		private DataColumn dx;

		[AccessedThroughProperty("DataColumn73")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn dy;

		[AccessedThroughProperty("DataColumn74")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn dz;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn75")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn d0;

		[AccessedThroughProperty("DataColumn76")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn d1;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn77")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn d2;

		[AccessedThroughProperty("DataColumn78")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn d3;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn79")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn d4;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn80")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn d5;

		[AccessedThroughProperty("DataTable9")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataTable d6;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn81")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn d7;

		[AccessedThroughProperty("DataColumn82")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn d8;

		[AccessedThroughProperty("DataColumn83")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn d9;

		[AccessedThroughProperty("DataColumn84")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn ea;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn85")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn eb;

		[AccessedThroughProperty("DataColumn86")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn ec;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn87")]
		private DataColumn ed;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn88")]
		private DataColumn ee;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn89")]
		private DataColumn ef;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn90")]
		private DataColumn eg;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn91")]
		private DataColumn eh;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn92")]
		private DataColumn ei;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn93")]
		private DataColumn ej;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn94")]
		private DataColumn ek;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn95")]
		private DataColumn el;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn96")]
		private DataColumn em;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataTable10")]
		private DataTable en;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn97")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn eo;

		[AccessedThroughProperty("DataColumn98")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn ep;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn99")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn eq;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn100")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn er;

		[AccessedThroughProperty("DataColumn101")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn es;

		[AccessedThroughProperty("DataColumn102")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn et;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn103")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn eu;

		[AccessedThroughProperty("DataColumn104")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn ev;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn105")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn ew;

		[AccessedThroughProperty("DataColumn106")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn ex;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn107")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn ey;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn108")]
		private DataColumn ez;

		[AccessedThroughProperty("DataColumn109")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn e0;

		[AccessedThroughProperty("Label_petlv")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Label e1;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("OpenButton")]
		[CompilerGenerated]
		private ToolBarButton e2;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("SaveButton")]
		private ToolBarButton e3;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("Label_mapy")]
		private Label e4;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label_mapx")]
		private Label e5;

		[CompilerGenerated]
		[AccessedThroughProperty("Label_mapid")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Label e6;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("StatusBarPanel_status")]
		private StatusBarPanel e7;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ContextMenuStrip_saveas")]
		[CompilerGenerated]
		private ContextMenuStrip e8;

		[AccessedThroughProperty("Panel5")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Panel e9;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Panel7")]
		private Panel fa;

		[CompilerGenerated]
		[AccessedThroughProperty("Button_InviteParty")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Button fb;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataTable11")]
		private DataTable fc;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn111")]
		[CompilerGenerated]
		private DataColumn fd;

		[AccessedThroughProperty("DataColumn112")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn fe;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn113")]
		[CompilerGenerated]
		private DataColumn ff;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn117")]
		private DataColumn fg;

		[AccessedThroughProperty("DataColumn118")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn fh;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn119")]
		private DataColumn fi;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn120")]
		private DataColumn fj;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn121")]
		[CompilerGenerated]
		private DataColumn fk;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn122")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn fl;

		[AccessedThroughProperty("DataColumn123")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn fm;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn124")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn fn;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn125")]
		[CompilerGenerated]
		private DataColumn fo;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn126")]
		private DataColumn fp;

		[AccessedThroughProperty("DataColumn127")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn fq;

		[AccessedThroughProperty("DataColumn128")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn fr;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn129")]
		private DataColumn fs;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn130")]
		private DataColumn ft;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn131")]
		private DataColumn fu;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn132")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn fv;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn133")]
		private DataColumn fw;

		[AccessedThroughProperty("DataColumn134")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn fx;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn135")]
		private DataColumn fy;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn136")]
		private DataColumn fz;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn137")]
		[CompilerGenerated]
		private DataColumn f0;

		[AccessedThroughProperty("DataColumn138")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn f1;

		[AccessedThroughProperty("DataColumn139")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn f2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn140")]
		private DataColumn f3;

		[CompilerGenerated]
		[AccessedThroughProperty("DataGridViewTextBoxColumn1")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataGridViewTextBoxColumn f4;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataGridViewTextBoxColumn2")]
		private DataGridViewTextBoxColumn f5;

		[CompilerGenerated]
		[AccessedThroughProperty("DataGridViewTextBoxColumn3")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataGridViewTextBoxColumn f6;

		[AccessedThroughProperty("DataColumn141")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn f7;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn142")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn f8;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn143")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn f9;

		[AccessedThroughProperty("DataColumn144")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn ga;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn145")]
		[CompilerGenerated]
		private DataColumn gb;

		[AccessedThroughProperty("DataColumn146")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn gc;

		[AccessedThroughProperty("DataColumn147")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn gd;

		[AccessedThroughProperty("DataColumn148")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn ge;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn149")]
		[CompilerGenerated]
		private DataColumn gf;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn150")]
		private DataColumn gg;

		[AccessedThroughProperty("DataColumn151")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn gh;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn152")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn gi;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn153")]
		private DataColumn gj;

		[AccessedThroughProperty("DataColumn154")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn gk;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn155")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn gl;

		[AccessedThroughProperty("DataColumn156")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn gm;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn157")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn gn;

		[AccessedThroughProperty("DataColumn158")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn go;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn159")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn gp;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn160")]
		private DataColumn gq;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn161")]
		private DataColumn gr;

		[AccessedThroughProperty("DataColumn162")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn gs;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn163")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn gt;

		[AccessedThroughProperty("DataColumn164")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn gu;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn165")]
		private DataColumn gv;

		[AccessedThroughProperty("DataColumn166")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn gw;

		[AccessedThroughProperty("DataColumn167")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn gx;

		[AccessedThroughProperty("DataColumn168")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn gy;

		[AccessedThroughProperty("DataColumn169")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn gz;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn170")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn g0;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn171")]
		private DataColumn g1;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn172")]
		private DataColumn g2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn173")]
		private DataColumn g3;

		[AccessedThroughProperty("DataColumn174")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn g4;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn175")]
		[CompilerGenerated]
		private DataColumn g5;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn176")]
		private DataColumn g6;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn177")]
		private DataColumn g7;

		[AccessedThroughProperty("DataColumn178")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn g8;

		[AccessedThroughProperty("DataColumn179")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn g9;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn180")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn ha;

		[AccessedThroughProperty("DataColumn181")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn hb;

		[AccessedThroughProperty("DataColumn182")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn hc;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn183")]
		private DataColumn hd;

		[AccessedThroughProperty("DataColumn184")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn he;

		[AccessedThroughProperty("DataColumn185")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn hf;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn186")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn hg;

		[AccessedThroughProperty("DataColumn187")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn hh;

		[AccessedThroughProperty("DataColumn188")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn hi;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn114")]
		private DataColumn hj;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn115")]
		private DataColumn hk;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn116")]
		private DataColumn hl;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn189")]
		private DataColumn hm;

		[AccessedThroughProperty("DataColumn190")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn hn;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn191")]
		private DataColumn ho;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn192")]
		private DataColumn hp;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn193")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn hq;

		[AccessedThroughProperty("DataColumn194")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn hr;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn195")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn hs;

		[AccessedThroughProperty("DataColumn196")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn ht;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn197")]
		private DataColumn hu;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn198")]
		private DataColumn hv;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn199")]
		private DataColumn hw;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn200")]
		private DataColumn hx;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn201")]
		private DataColumn hy;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn202")]
		private DataColumn hz;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn203")]
		private DataColumn h0;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn204")]
		private DataColumn h1;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn205")]
		private DataColumn h2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn206")]
		private DataColumn h3;

		[AccessedThroughProperty("DataColumn207")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn h4;

		[AccessedThroughProperty("DataColumn208")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn h5;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn209")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn h6;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn210")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn h7;

		[AccessedThroughProperty("DataColumn211")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn h8;

		[AccessedThroughProperty("DataColumn212")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn h9;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn213")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn ia;

		[AccessedThroughProperty("DataColumn214")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn ib;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn215")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn ic;

		[AccessedThroughProperty("DataColumn216")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn id;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn217")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn ie;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn218")]
		private DataColumn ig;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn219")]
		private DataColumn ih;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn220")]
		[CompilerGenerated]
		private DataColumn ii;

		[AccessedThroughProperty("DataColumn221")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn ij;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn222")]
		private DataColumn ik;

		[AccessedThroughProperty("DataColumn223")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn il;

		[AccessedThroughProperty("DataColumn224")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn im;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn225")]
		[CompilerGenerated]
		private DataColumn @in;

		[AccessedThroughProperty("DataColumn226")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn io;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn227")]
		[CompilerGenerated]
		private DataColumn ip;

		[AccessedThroughProperty("DataTable12")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataTable iq;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn228")]
		[CompilerGenerated]
		private DataColumn ir;

		[AccessedThroughProperty("DataColumn229")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn @is;

		[AccessedThroughProperty("DataColumn230")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn it;

		[AccessedThroughProperty("ToolTip_info")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ToolTip iu;

		[CompilerGenerated]
		[AccessedThroughProperty("Panel_PetSkillTurn")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Panel iv;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Panel_CharSkillTurn")]
		private Panel iw;

		[AccessedThroughProperty("DataColumn231")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn ix;

		[AccessedThroughProperty("btnLogin")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Button iy;

		[AccessedThroughProperty("TBPassword")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private TextBox iz;

		[CompilerGenerated]
		[AccessedThroughProperty("TBId")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private TextBox i0;

		[AccessedThroughProperty("ComboBox_Server")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ComboBox i1;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataTable13")]
		private DataTable i2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn110")]
		private DataColumn i3;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn232")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn i4;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn233")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn i5;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn234")]
		private DataColumn i6;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataTable14")]
		private DataTable i7;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn235")]
		private DataColumn i8;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn236")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn i9;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn237")]
		private DataColumn ja;

		[AccessedThroughProperty("DataColumn238")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn jb;

		[CompilerGenerated]
		[AccessedThroughProperty("OpenFileDialog_setting")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private OpenFileDialog jc;

		[AccessedThroughProperty("SaveFileDialog_setting")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private SaveFileDialog jd;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn239")]
		private DataColumn je;

		[AccessedThroughProperty("DataColumn240")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn jf;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("GroupBox_Basic")]
		private GroupBox jg;

		[CompilerGenerated]
		[AccessedThroughProperty("GroupBox_disconnect")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private GroupBox jh;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("CheckBox_OpenMachine")]
		[CompilerGenerated]
		private CheckBox ji;

		[AccessedThroughProperty("CheckBox_ClearGhost")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private CheckBox jj;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("CheckBox_Reconnect")]
		private CheckBox jk;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("RadioButton_DCmemout")]
		private RadioButton jl;

		[CompilerGenerated]
		[AccessedThroughProperty("RadioButton_DCLeaderOut")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private RadioButton jm;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("CheckBox_DCAfter1MinNoBattle")]
		private CheckBox jn;

		[AccessedThroughProperty("RadioButton_MemberRequestParty")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private RadioButton jo;

		[AccessedThroughProperty("RadioButton_LeaderRequestParty")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private RadioButton jp;

		[CompilerGenerated]
		[AccessedThroughProperty("GroupBox2")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private GroupBox jq;

		[AccessedThroughProperty("Label32")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Label jr;

		[AccessedThroughProperty("Label25")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Label js;

		[AccessedThroughProperty("Label23")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Label jt;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("TextBox_TL_char_sp_value")]
		private TextBox ju;

		[AccessedThroughProperty("Label22")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Label jv;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TextBox_TL_char_hp_value")]
		[CompilerGenerated]
		private TextBox jw;

		[CompilerGenerated]
		[AccessedThroughProperty("Label21")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Label jx;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TextBox_Eat_char_sp_value")]
		private TextBox jy;

		[AccessedThroughProperty("Label20")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Label jz;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TextBox_Eat_char_hp_value")]
		private TextBox j0;

		[AccessedThroughProperty("Label7")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Label j1;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label5")]
		[CompilerGenerated]
		private Label j2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("CheckBox_TL_mem1")]
		private CheckBox j3;

		[AccessedThroughProperty("CheckBox_TL_mem4")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private CheckBox j4;

		[AccessedThroughProperty("CheckBox_TL_mem3")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private CheckBox j5;

		[CompilerGenerated]
		[AccessedThroughProperty("CheckBox_TL_mem2")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private CheckBox j6;

		[AccessedThroughProperty("CheckBox_AutoCreatCharacter")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private CheckBox j7;

		[AccessedThroughProperty("DataColumn241")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn j8;

		[AccessedThroughProperty("DataColumn242")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn j9;

		[AccessedThroughProperty("CheckBox_TL_pet2")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private CheckBox ka;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("CheckBox_TL_pet1")]
		private CheckBox kb;

		[CompilerGenerated]
		[AccessedThroughProperty("TabControl1")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Vs2010TabControl kc;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TabPage7")]
		private TabPage kd;

		[AccessedThroughProperty("TabPage8")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private TabPage ke;

		[AccessedThroughProperty("TabPage9")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private TabPage kf;

		[CompilerGenerated]
		[AccessedThroughProperty("Label33")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Label kg;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label34")]
		private Label kh;

		[AccessedThroughProperty("TextBox_TL_pet_sp_value")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private TextBox ki;

		[AccessedThroughProperty("Label35")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Label kj;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label36")]
		[CompilerGenerated]
		private Label kk;

		[AccessedThroughProperty("TextBox_TL_pet_hp_value")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private TextBox kl;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("GroupBox3")]
		[CompilerGenerated]
		private GroupBox km;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label43")]
		[CompilerGenerated]
		private Label kn;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("TextBox_Eat_pet_sp_value")]
		private TextBox ko;

		[AccessedThroughProperty("Label44")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Label kp;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TextBox_Eat_pet_hp_value")]
		[CompilerGenerated]
		private TextBox kq;

		[CompilerGenerated]
		[AccessedThroughProperty("Label45")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Label kr;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label46")]
		private Label ks;

		[AccessedThroughProperty("RadioButton_PT_no")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private RadioButton kt;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("RadioButton_DC_no")]
		private RadioButton ku;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ComboBox_CharLocation")]
		[CompilerGenerated]
		private ComboBox kv;

		[AccessedThroughProperty("Label47")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Label kw;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label48")]
		private Label kx;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ComboBox_PetLocation")]
		private ComboBox ky;

		[AccessedThroughProperty("Label49")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Label kz;

		[AccessedThroughProperty("Label50")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Label k0;

		[AccessedThroughProperty("DataColumn243")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn k1;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn244")]
		private DataColumn k2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn245")]
		private DataColumn k3;

		[AccessedThroughProperty("DataColumn246")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn k4;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn247")]
		private DataColumn k5;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("ContextMenuStrip_ToTuido")]
		private ContextMenuStrip k6;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ToolStripMenuItem_ToTuiDeo")]
		private ToolStripMenuItem k7;

		[CompilerGenerated]
		[AccessedThroughProperty("ContextMenuStrip_ToTuideo")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ContextMenuStrip k8;

		[CompilerGenerated]
		[AccessedThroughProperty("ToolStripMenuItem_ToTuiDo")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ToolStripMenuItem k9;

		[AccessedThroughProperty("NumericUpDown_ItemCountPickup")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private NumericUpDown la;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("CheckBox_AutoPickup")]
		private CheckBox lb;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataTable15")]
		private DataTable lc;

		[AccessedThroughProperty("DataColumn248")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn ld;

		[CompilerGenerated]
		[AccessedThroughProperty("Label52")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Label le;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("Label_CharTurnCount")]
		private Label lf;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("Label53")]
		private Label lg;

		[AccessedThroughProperty("Button_CharTurnRemove")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Button lh;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("Button_CharTurnAdd")]
		private Button li;

		[AccessedThroughProperty("DataColumn249")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn lj;

		[AccessedThroughProperty("DataColumn250")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn lk;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn251")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn ll;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn252")]
		private DataColumn lm;

		[AccessedThroughProperty("DataColumn253")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn ln;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn254")]
		[CompilerGenerated]
		private DataColumn lo;

		[AccessedThroughProperty("DataColumn255")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn lp;

		[AccessedThroughProperty("DataColumn256")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn lq;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn257")]
		private DataColumn lr;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn258")]
		private DataColumn ls;

		[AccessedThroughProperty("DataColumn259")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn lt;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn260")]
		[CompilerGenerated]
		private DataColumn lu;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn261")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn lv;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn262")]
		private DataColumn lw;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn263")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn lx;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn264")]
		private DataColumn ly;

		[AccessedThroughProperty("DataColumn265")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn lz;

		[AccessedThroughProperty("DataColumn266")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn l0;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn267")]
		[CompilerGenerated]
		private DataColumn l1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn268")]
		private DataColumn l2;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn269")]
		[CompilerGenerated]
		private DataColumn l3;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn270")]
		private DataColumn l4;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn271")]
		private DataColumn l5;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn272")]
		private DataColumn l6;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn273")]
		private DataColumn l7;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn274")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn l8;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn275")]
		private DataColumn l9;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn276")]
		[CompilerGenerated]
		private DataColumn ma;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn277")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn mb;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn278")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn mc;

		[AccessedThroughProperty("DataColumn279")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn md;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn280")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn me;

		[AccessedThroughProperty("DataColumn281")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn mf;

		[AccessedThroughProperty("DataColumn282")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn mg;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn283")]
		private DataColumn mh;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn284")]
		[CompilerGenerated]
		private DataColumn mi;

		[AccessedThroughProperty("DataColumn285")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn mj;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn286")]
		private DataColumn mk;

		[AccessedThroughProperty("DataColumn287")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn ml;

		[AccessedThroughProperty("DataColumn288")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn mm;

		[AccessedThroughProperty("DataColumn289")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn mn;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ComboBox_CharTurnSetting")]
		private ComboBox mo;

		[AccessedThroughProperty("ComboBox_PetTurnSetting")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private ComboBox mp;

		[AccessedThroughProperty("Label54")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Label mq;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label_PetTurnCount")]
		private Label mr;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label62")]
		private Label ms;

		[CompilerGenerated]
		[AccessedThroughProperty("Button_PetTurnRemove")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Button mt;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button_PetTurnAdd")]
		private Button mu;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("RichTextBox_hienthiquest")]
		[CompilerGenerated]
		private RichTextBox mv;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("GroupBox7")]
		private GroupBox mw;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("GroupBox6")]
		[CompilerGenerated]
		private GroupBox mx;

		[AccessedThroughProperty("GroupBox5")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private GroupBox my;

		[AccessedThroughProperty("GroupBox4")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private GroupBox mz;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataTable16")]
		private DataTable m0;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn290")]
		private DataColumn m1;

		[AccessedThroughProperty("DataColumn291")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn m2;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataTable17")]
		private DataTable m3;

		[AccessedThroughProperty("DataColumn292")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn m4;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn293")]
		[CompilerGenerated]
		private DataColumn m5;

		[CompilerGenerated]
		[AccessedThroughProperty("DataTable18")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataTable m6;

		[AccessedThroughProperty("DataColumn294")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn m7;

		[AccessedThroughProperty("DataColumn295")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn m8;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TabControl_ItemSetting")]
		private TabControl m9;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("TabPage11")]
		private TabPage na;

		[AccessedThroughProperty("TabPage12")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private TabPage nb;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label63")]
		private Label nc;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TextBox_Drop_SpValue")]
		private TextBox nd;

		[CompilerGenerated]
		[AccessedThroughProperty("Label61")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Label ne;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TextBox_Drop_HpValue")]
		private TextBox nf;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("CheckBox_DropHpSp")]
		private CheckBox ng;

		[AccessedThroughProperty("CheckBox_DropSp")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private CheckBox nh;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("CheckBox_DropHp")]
		private CheckBox ni;

		[AccessedThroughProperty("Button_AddIdDrop")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Button nj;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("TextBox_AddIdDrop")]
		private TextBox nk;

		[CompilerGenerated]
		[AccessedThroughProperty("CheckBox_ContributeHpSp")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private CheckBox nl;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("CheckBox_ContributeSp")]
		private CheckBox nm;

		[AccessedThroughProperty("CheckBox_ContributeHp")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private CheckBox nn;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label64")]
		private Label no;

		[AccessedThroughProperty("TextBox_Contribute_SpValue")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private TextBox np;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label65")]
		[CompilerGenerated]
		private Label nq;

		[AccessedThroughProperty("TextBox_Contribute_HpValue")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private TextBox nr;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("Button_AddIdContribute")]
		private Button ns;

		[CompilerGenerated]
		[AccessedThroughProperty("TextBox_AddIdContribute")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private TextBox nt;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button_AddIdSend")]
		private Button nu;

		[AccessedThroughProperty("TextBox_AddIdSend")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private TextBox nv;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("CheckBox_SendHpSp")]
		[CompilerGenerated]
		private CheckBox nw;

		[CompilerGenerated]
		[AccessedThroughProperty("CheckBox_SendSp")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private CheckBox nx;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("CheckBox_SendHp")]
		private CheckBox ny;

		[AccessedThroughProperty("Label72")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Label nz;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TextBox_Send_SpValue")]
		private TextBox n0;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label73")]
		[CompilerGenerated]
		private Label n1;

		[AccessedThroughProperty("TextBox_Send_HpValue")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private TextBox n2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ToolStripSeparator1")]
		private ToolStripSeparator n3;

		[AccessedThroughProperty("ToolStripMenuItem_TuidoAddtoDrop")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private ToolStripMenuItem n4;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ToolStripMenuItem_TuidoAddtoContribute")]
		[CompilerGenerated]
		private ToolStripMenuItem n5;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ToolStripMenuItem_TuidoAddtoSend")]
		[CompilerGenerated]
		private ToolStripMenuItem n6;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ToolStripSeparator2")]
		private ToolStripSeparator n7;

		[AccessedThroughProperty("ToolStripMenuItem_TuideoAddtoDrop")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private ToolStripMenuItem n8;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("ToolStripMenuItem_TuideoAddtoContribute")]
		private ToolStripMenuItem n9;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ToolStripMenuItem_TuideoAddtoSend")]
		private ToolStripMenuItem oa;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("TextBox_DelayBot")]
		private TextBox ob;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("Label51")]
		private Label oc;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataTable19")]
		private DataTable od;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn296")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn oe;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn297")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn of;

		[AccessedThroughProperty("DataColumn298")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn og;

		[AccessedThroughProperty("DataColumn299")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn oh;

		[AccessedThroughProperty("DataColumn300")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn oi;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn301")]
		private DataColumn oj;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn302")]
		private DataColumn ok;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataTable21")]
		private DataTable ol;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn303")]
		private DataColumn om;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn304")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn on;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn305")]
		[CompilerGenerated]
		private DataColumn oo;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn306")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn op;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn307")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn oq;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn308")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn or;

		[AccessedThroughProperty("DataColumn309")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn os;

		[AccessedThroughProperty("DataTable22")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataTable ot;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn310")]
		[CompilerGenerated]
		private DataColumn ou;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn311")]
		private DataColumn ov;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn312")]
		private DataColumn ow;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn313")]
		private DataColumn ox;

		[AccessedThroughProperty("DataColumn314")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn oy;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn315")]
		private DataColumn oz;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn316")]
		private DataColumn o0;

		[CompilerGenerated]
		[AccessedThroughProperty("DataTable23")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataTable o1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn317")]
		private DataColumn o2;

		[AccessedThroughProperty("DataColumn318")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn o3;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn319")]
		private DataColumn o4;

		[AccessedThroughProperty("DataColumn320")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn o5;

		[AccessedThroughProperty("DataColumn321")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn o6;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn322")]
		private DataColumn o7;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn323")]
		[CompilerGenerated]
		private DataColumn o8;

		[AccessedThroughProperty("DataTable24")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataTable o9;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn324")]
		private DataColumn pa;

		[AccessedThroughProperty("DataColumn325")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn pb;

		[AccessedThroughProperty("DataColumn326")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn pc;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn327")]
		private DataColumn pd;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn328")]
		private DataColumn pe;

		[AccessedThroughProperty("DataColumn329")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn pf;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn330")]
		[CompilerGenerated]
		private DataColumn pg;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataTable25")]
		[CompilerGenerated]
		private DataTable ph;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn331")]
		private DataColumn pi;

		[AccessedThroughProperty("DataColumn332")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn pj;

		[AccessedThroughProperty("DataColumn333")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn pk;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn334")]
		private DataColumn pl;

		[AccessedThroughProperty("DataColumn335")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn pm;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn336")]
		[CompilerGenerated]
		private DataColumn pn;

		[AccessedThroughProperty("DataColumn337")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn po;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataTable26")]
		[CompilerGenerated]
		private DataTable pp;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn338")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn pq;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn339")]
		private DataColumn pr;

		[AccessedThroughProperty("DataColumn340")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn ps;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn341")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn pt;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn342")]
		private DataColumn pu;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn343")]
		private DataColumn pv;

		[AccessedThroughProperty("DataColumn344")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn pw;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataTable27")]
		private DataTable px;

		[AccessedThroughProperty("DataColumn345")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn py;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn346")]
		private DataColumn pz;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn347")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn p0;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn348")]
		private DataColumn p1;

		[AccessedThroughProperty("DataColumn349")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn p2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn350")]
		private DataColumn p3;

		[AccessedThroughProperty("DataColumn351")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn p4;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataTable28")]
		private DataTable p5;

		[AccessedThroughProperty("DataColumn352")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn p6;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn353")]
		private DataColumn p7;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn354")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn p8;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn355")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn p9;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn356")]
		private DataColumn qa;

		[AccessedThroughProperty("DataColumn357")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn qb;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn358")]
		[CompilerGenerated]
		private DataColumn qc;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataTable29")]
		[CompilerGenerated]
		private DataTable qd;

		[AccessedThroughProperty("DataColumn359")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn qe;

		[AccessedThroughProperty("DataColumn360")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn qf;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn361")]
		private DataColumn qg;

		[AccessedThroughProperty("DataColumn362")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn qh;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn363")]
		[CompilerGenerated]
		private DataColumn qi;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn364")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn qj;

		[AccessedThroughProperty("DataColumn365")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn qk;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataTable30")]
		private DataTable ql;

		[AccessedThroughProperty("DataColumn366")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn qm;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn367")]
		private DataColumn qn;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn368")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn qo;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn369")]
		[CompilerGenerated]
		private DataColumn qp;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn370")]
		[CompilerGenerated]
		private DataColumn qq;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn371")]
		private DataColumn qr;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn372")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn qs;

		[AccessedThroughProperty("DataTable31")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataTable qt;

		[AccessedThroughProperty("DataColumn373")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn qu;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn374")]
		private DataColumn qv;

		[AccessedThroughProperty("DataColumn375")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn qw;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn376")]
		private DataColumn qx;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn377")]
		private DataColumn qy;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn378")]
		[CompilerGenerated]
		private DataColumn qz;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn379")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn q0;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataTable32")]
		private DataTable q1;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn380")]
		[CompilerGenerated]
		private DataColumn q2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn381")]
		private DataColumn q3;

		[AccessedThroughProperty("DataColumn382")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn q4;

		[AccessedThroughProperty("DataColumn383")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn q5;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn384")]
		private DataColumn q6;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn385")]
		private DataColumn q7;

		[AccessedThroughProperty("DataColumn386")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn q8;

		[CompilerGenerated]
		[AccessedThroughProperty("DataTable33")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataTable q9;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn387")]
		private DataColumn ra;

		[AccessedThroughProperty("DataColumn388")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn rb;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn389")]
		private DataColumn rc;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn390")]
		private DataColumn rd;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn391")]
		private DataColumn re;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn392")]
		[CompilerGenerated]
		private DataColumn rf;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn393")]
		private DataColumn rg;

		[AccessedThroughProperty("DataTable34")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataTable rh;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn394")]
		[CompilerGenerated]
		private DataColumn ri;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn395")]
		[CompilerGenerated]
		private DataColumn rj;

		[AccessedThroughProperty("DataColumn396")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn rk;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn397")]
		[CompilerGenerated]
		private DataColumn rl;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn398")]
		private DataColumn rm;

		[AccessedThroughProperty("DataColumn399")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn rn;

		[AccessedThroughProperty("DataColumn400")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn ro;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataTable35")]
		[CompilerGenerated]
		private DataTable rp;

		[AccessedThroughProperty("DataColumn401")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn rq;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn402")]
		private DataColumn rr;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn403")]
		private DataColumn rs;

		[AccessedThroughProperty("DataColumn404")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn rt;

		[AccessedThroughProperty("DataColumn405")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn ru;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn406")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn rv;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn407")]
		private DataColumn rw;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataTable36")]
		[CompilerGenerated]
		private DataTable rx;

		[AccessedThroughProperty("DataColumn408")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn ry;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn409")]
		private DataColumn rz;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn410")]
		[CompilerGenerated]
		private DataColumn r0;

		[AccessedThroughProperty("DataColumn411")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn r1;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn412")]
		[CompilerGenerated]
		private DataColumn r2;

		[AccessedThroughProperty("DataColumn413")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn r3;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn414")]
		private DataColumn r4;

		[AccessedThroughProperty("DataTable37")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataTable r5;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn415")]
		[CompilerGenerated]
		private DataColumn r6;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn416")]
		[CompilerGenerated]
		private DataColumn r7;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn417")]
		[CompilerGenerated]
		private DataColumn r8;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn418")]
		private DataColumn r9;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn419")]
		[CompilerGenerated]
		private DataColumn sa;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn420")]
		private DataColumn sb;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn421")]
		private DataColumn sc;

		[AccessedThroughProperty("DataTable38")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataTable sd;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn422")]
		[CompilerGenerated]
		private DataColumn se;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn423")]
		private DataColumn sf;

		[AccessedThroughProperty("DataColumn424")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn sg;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn425")]
		private DataColumn sh;

		[AccessedThroughProperty("DataColumn426")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn si;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn427")]
		[CompilerGenerated]
		private DataColumn sj;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn428")]
		[CompilerGenerated]
		private DataColumn sk;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataTable39")]
		private DataTable sl;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn429")]
		[CompilerGenerated]
		private DataColumn sm;

		[AccessedThroughProperty("DataColumn430")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn sn;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn431")]
		private DataColumn so;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn432")]
		private DataColumn sp;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn433")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn sq;

		[AccessedThroughProperty("DataColumn434")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn sr;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn435")]
		[CompilerGenerated]
		private DataColumn ss;

		[AccessedThroughProperty("DataColumn436")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn st;

		[AccessedThroughProperty("DataColumn437")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn su;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn438")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn sv;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn439")]
		[CompilerGenerated]
		private DataColumn sw;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn440")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn sx;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn441")]
		[CompilerGenerated]
		private DataColumn sy;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn442")]
		[CompilerGenerated]
		private DataColumn sz;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn443")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn s0;

		[AccessedThroughProperty("DataColumn444")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn s1;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn445")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn s2;

		[AccessedThroughProperty("DataColumn446")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn s3;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn447")]
		private DataColumn s4;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn448")]
		private DataColumn s5;

		[AccessedThroughProperty("DataColumn449")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn s6;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn450")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn s7;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn451")]
		private DataColumn s8;

		[AccessedThroughProperty("DataColumn452")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn s9;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn453")]
		[CompilerGenerated]
		private DataColumn ta;

		[AccessedThroughProperty("DataColumn454")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn tb;

		[AccessedThroughProperty("DataColumn455")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn tc;

		[AccessedThroughProperty("CheckBox_DropMineWood")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private CheckBox td;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("CheckBox_ContributeMineWood")]
		private CheckBox te;

		[AccessedThroughProperty("CheckBox_SendMineWood")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private CheckBox tf;

		[AccessedThroughProperty("CheckBox_AutoEat")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private CheckBox tg;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn456")]
		[CompilerGenerated]
		private DataColumn th;

		[AccessedThroughProperty("DataColumn457")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn ti;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn458")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn tj;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn459")]
		private DataColumn tk;

		[AccessedThroughProperty("DataColumn460")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn tl;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn461")]
		private DataColumn tm;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn462")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn tn;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn463")]
		private DataColumn to;

		[AccessedThroughProperty("DataColumn464")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn tp;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn465")]
		[CompilerGenerated]
		private DataColumn tq;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn466")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn tr;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn467")]
		[CompilerGenerated]
		private DataColumn ts;

		[AccessedThroughProperty("DataColumn468")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn tt;

		[AccessedThroughProperty("DataColumn469")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn tu;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn470")]
		private DataColumn tv;

		[AccessedThroughProperty("DataColumn471")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn tw;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn472")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn tx;

		[AccessedThroughProperty("DataColumn473")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn ty;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn474")]
		[CompilerGenerated]
		private DataColumn tz;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn475")]
		private DataColumn t0;

		[AccessedThroughProperty("DataColumn476")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn t1;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn477")]
		[CompilerGenerated]
		private DataColumn t2;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn478")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn t3;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn479")]
		[CompilerGenerated]
		private DataColumn t4;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn480")]
		[CompilerGenerated]
		private DataColumn t5;

		[AccessedThroughProperty("DataColumn481")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn t6;

		[AccessedThroughProperty("DataColumn482")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn t7;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn483")]
		private DataColumn t8;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn484")]
		[CompilerGenerated]
		private DataColumn t9;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn485")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn ua;

		[AccessedThroughProperty("DataColumn486")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn ub;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn487")]
		private DataColumn uc;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn488")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn ud;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn489")]
		private DataColumn ue;

		[AccessedThroughProperty("DataColumn490")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn uf;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn491")]
		private DataColumn ug;

		[AccessedThroughProperty("DataColumn492")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn uh;

		[AccessedThroughProperty("DataColumn493")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn ui;

		[AccessedThroughProperty("DataColumn494")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn uj;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn495")]
		private DataColumn uk;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn496")]
		private DataColumn ul;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn497")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn um;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label_Petname")]
		private Label un;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label_CharName")]
		[CompilerGenerated]
		private Label uo;

		[AccessedThroughProperty("Label74")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Label up;

		[AccessedThroughProperty("TextBox_ValueSPFlee")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private TextBox uq;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("CheckBox_AutoFlee_Sp")]
		private CheckBox ur;

		[CompilerGenerated]
		[AccessedThroughProperty("CheckBox_AutoFlee_Party")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private CheckBox us;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn498")]
		[CompilerGenerated]
		private DataColumn ut;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label75")]
		private Label uu;

		[AccessedThroughProperty("TextBox_AutoSend")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private TextBox uv;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn499")]
		private DataColumn uw;

		[AccessedThroughProperty("DataColumn501")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn ux;

		[AccessedThroughProperty("DataColumn502")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn uy;

		[AccessedThroughProperty("DataColumn503")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn uz;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn504")]
		private DataColumn u0;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn500")]
		[CompilerGenerated]
		private DataColumn u1;

		[AccessedThroughProperty("TabPage2")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private TabPage u2;

		[AccessedThroughProperty("TabPage1")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private TabPage u3;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("CheckBox_AutoRevival")]
		private CheckBox u4;

		[AccessedThroughProperty("TabControl2")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private TabControl u5;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TabPage3")]
		[CompilerGenerated]
		private TabPage u6;

		[AccessedThroughProperty("ListView_monster")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ListView u7;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ColumnHeader5")]
		private ColumnHeader u8;

		[AccessedThroughProperty("ColumnHeader6")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private ColumnHeader u9;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("ColumnHeader7")]
		private ColumnHeader va;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ColumnHeader8")]
		private ColumnHeader vb;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("ColumnHeader9")]
		private ColumnHeader vc;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("CheckBox_AutoClickNPC")]
		private CheckBox vd;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TextBox_ClickMOD")]
		private TextBox ve;

		[AccessedThroughProperty("CheckBox_CatPet")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private CheckBox vf;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("GroupBox8")]
		[CompilerGenerated]
		private GroupBox vg;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("CheckBox_TuLenNgua")]
		private CheckBox vh;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label79")]
		private Label vi;

		[AccessedThroughProperty("Label77")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Label vj;

		[AccessedThroughProperty("Label13")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Label vk;

		[CompilerGenerated]
		[AccessedThroughProperty("TextBox_RemoteDis")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private TextBox vl;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("GroupBox9")]
		private GroupBox vm;

		[AccessedThroughProperty("CheckBox_AutoEquitExp")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private CheckBox vn;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("CheckBox_AutoUsePT")]
		private CheckBox vo;

		[AccessedThroughProperty("TextBox_Country")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private TextBox vp;

		[AccessedThroughProperty("DataTable20")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataTable vq;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn505")]
		private DataColumn vr;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn506")]
		private DataColumn vs;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataGridView_ItemOnMap")]
		[CompilerGenerated]
		private DataGridView vt;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn509")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn vu;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn507")]
		private DataColumn vv;

		[AccessedThroughProperty("DataColumn508")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn vw;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("CheckBox_Pickup")]
		[CompilerGenerated]
		private CheckBox vx;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Panel4")]
		private Panel vy;

		[AccessedThroughProperty("GoldDataGridViewTextBoxColumn")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataGridViewTextBoxColumn vz;

		[AccessedThroughProperty("IdDataGridViewTextBoxColumn")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn v0;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ItemNameDataGridViewTextBoxColumn")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn v1;

		[AccessedThroughProperty("MapXDataGridViewTextBoxColumn")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataGridViewTextBoxColumn v2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("MapYDataGridViewTextBoxColumn")]
		private DataGridViewTextBoxColumn v3;

		[AccessedThroughProperty("Label3")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Label v4;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button_IdAdd")]
		private Button v5;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("TextBox_IdAdd")]
		private TextBox v6;

		[CompilerGenerated]
		[AccessedThroughProperty("DataGridView_Pickup")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataGridView v7;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataTable40")]
		private DataTable v8;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn510")]
		[CompilerGenerated]
		private DataColumn v9;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn511")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn wa;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataGridViewTextBoxColumn14")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn wb;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataGridViewTextBoxColumn15")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn wc;

		[AccessedThroughProperty("TabPage5")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private TabPage wd;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("GroupBox10")]
		private GroupBox we;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("CheckBox_SellMineWood")]
		[CompilerGenerated]
		private CheckBox wf;

		[AccessedThroughProperty("Button_AddIdSell")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Button wg;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TextBox_AddIdSell")]
		private TextBox wh;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("CheckBox_SellHpSp")]
		private CheckBox wi;

		[CompilerGenerated]
		[AccessedThroughProperty("CheckBox_SellSP")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private CheckBox wj;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("CheckBox_SellHp")]
		private CheckBox wk;

		[AccessedThroughProperty("Label12")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Label wl;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TextBox_Sell_SpValue")]
		[CompilerGenerated]
		private TextBox wm;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label80")]
		private Label wn;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("TextBox_Sell_HpValue")]
		private TextBox wo;

		[AccessedThroughProperty("ToolStripMenuItem_TuideoAddtoSell")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private ToolStripMenuItem wp;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ToolStripMenuItem_TuidoAddtoSell")]
		[CompilerGenerated]
		private ToolStripMenuItem wq;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataTable41")]
		[CompilerGenerated]
		private DataTable wr;

		[AccessedThroughProperty("DataColumn512")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn ws;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn513")]
		private DataColumn wt;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("CheckBox_autosell")]
		private CheckBox wu;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("CheckBox_QuestProtect")]
		private CheckBox wv;

		[AccessedThroughProperty("DataColumn514")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn ww;

		[AccessedThroughProperty("Label83")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Label wx;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("CheckBox_Bee")]
		private CheckBox wy;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("Panel6")]
		private Panel wz;

		[AccessedThroughProperty("ProgressBarEx_BDY")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ProgressBarEx w0;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label_BDY")]
		[CompilerGenerated]
		private Label w1;

		[AccessedThroughProperty("CheckBox_DisExp")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private CheckBox w2;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("CheckBox_LeaderDissNotEnough")]
		private CheckBox w3;

		[CompilerGenerated]
		[AccessedThroughProperty("Label_IdLeader")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Label w4;

		[AccessedThroughProperty("DataColumn515")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn w5;

		[AccessedThroughProperty("DataColumn516")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn w6;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("TabPage6")]
		private TabPage w7;

		[CompilerGenerated]
		[AccessedThroughProperty("GroupBox11")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private GroupBox w8;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label84")]
		private Label w9;

		[AccessedThroughProperty("TextBox_OpenMachine_PetSp")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private TextBox xa;

		[AccessedThroughProperty("Label85")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Label xb;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TextBox_OpenMachine_PetHp")]
		private TextBox xc;

		[AccessedThroughProperty("Label86")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Label xd;

		[AccessedThroughProperty("Label87")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Label xe;

		[AccessedThroughProperty("Label88")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Label xf;

		[AccessedThroughProperty("TextBox_OpenMachine_CharSp")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private TextBox xg;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label89")]
		[CompilerGenerated]
		private Label xh;

		[AccessedThroughProperty("TextBox_OpenMachine_CharHp")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private TextBox xi;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label90")]
		[CompilerGenerated]
		private Label xj;

		[AccessedThroughProperty("Label91")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Label xk;

		[AccessedThroughProperty("DataColumn517")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn xl;

		[AccessedThroughProperty("DataColumn518")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn xm;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn519")]
		private DataColumn xn;

		[AccessedThroughProperty("DataColumn520")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn xo;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn521")]
		private DataColumn xp;

		[AccessedThroughProperty("DataColumn522")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn xq;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn523")]
		[CompilerGenerated]
		private DataColumn xr;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn524")]
		private DataColumn xs;

		[AccessedThroughProperty("DataColumn525")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn xt;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn526")]
		private DataColumn xu;

		[AccessedThroughProperty("DataColumn527")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn xv;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn528")]
		private DataColumn xw;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn529")]
		private DataColumn xx;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn530")]
		private DataColumn xy;

		[AccessedThroughProperty("DataColumn531")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn xz;

		[AccessedThroughProperty("DataColumn532")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn x0;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn533")]
		[CompilerGenerated]
		private DataColumn x1;

		[AccessedThroughProperty("DataColumn534")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn x2;

		[AccessedThroughProperty("DataColumn535")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn x3;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn536")]
		[CompilerGenerated]
		private DataColumn x4;

		[AccessedThroughProperty("DataColumn537")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn x5;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn538")]
		private DataColumn x6;

		[AccessedThroughProperty("DataColumn539")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn x7;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn540")]
		private DataColumn x8;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn541")]
		private DataColumn x9;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn542")]
		private DataColumn ya;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn543")]
		private DataColumn yb;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn544")]
		[CompilerGenerated]
		private DataColumn yc;

		[AccessedThroughProperty("DataColumn545")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn yd;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn546")]
		[CompilerGenerated]
		private DataColumn ye;

		[AccessedThroughProperty("DataColumn547")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn yf;

		[AccessedThroughProperty("DataColumn548")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn yg;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn549")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn yh;

		[AccessedThroughProperty("DataColumn550")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn yi;

		[AccessedThroughProperty("DataColumn551")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn yj;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn552")]
		private DataColumn yk;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn553")]
		[CompilerGenerated]
		private DataColumn yl;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn554")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn ym;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn555")]
		[CompilerGenerated]
		private DataColumn yn;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn556")]
		private DataColumn yo;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("CheckBox_Pet_ChangeTG")]
		private CheckBox yp;

		[AccessedThroughProperty("CheckBox_Char_ChangeTG")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private CheckBox yq;

		[AccessedThroughProperty("Label_Mini")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Label yr;

		[AccessedThroughProperty("DataColumn557")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn ys;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button_OutParty")]
		[CompilerGenerated]
		private Button yt;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("StatusBarPanel_MapName")]
		private StatusBarPanel yu;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn558")]
		private DataColumn yv;

		[AccessedThroughProperty("DataColumn559")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn yw;

		[AccessedThroughProperty("DataColumn560")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn yx;

		[AccessedThroughProperty("DataColumn561")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn yy;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn562")]
		[CompilerGenerated]
		private DataColumn yz;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn563")]
		private DataColumn y0;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn564")]
		private DataColumn y1;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn565")]
		[CompilerGenerated]
		private DataColumn y2;

		[AccessedThroughProperty("DataColumn566")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn y3;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn567")]
		private DataColumn y4;

		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn568")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn y5;

		[AccessedThroughProperty("DataColumn569")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn y6;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn570")]
		private DataColumn y7;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn571")]
		[CompilerGenerated]
		private DataColumn y8;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn572")]
		private DataColumn y9;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn573")]
		[CompilerGenerated]
		private DataColumn za;

		[AccessedThroughProperty("DataColumn574")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataColumn zb;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("DataColumn575")]
		private DataColumn zc;

		[AccessedThroughProperty("DataColumn576")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataColumn zd;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DataColumn577")]
		[CompilerGenerated]
		private DataColumn ze;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button_BattleInfo")]
		private Button zf;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label55")]
		private Label zg;

		[AccessedThroughProperty("ListView_AutoDrop")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ListView zh;

		[AccessedThroughProperty("ColumnHeader_Id")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ColumnHeader zi;

		[AccessedThroughProperty("ColumnHeader_Name")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ColumnHeader zj;

		[AccessedThroughProperty("ListView_AutoContribute")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ListView zk;

		[CompilerGenerated]
		[AccessedThroughProperty("ColumnHeader1")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ColumnHeader zl;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ColumnHeader2")]
		[CompilerGenerated]
		private ColumnHeader zm;

		[AccessedThroughProperty("ListView_AutoSend")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ListView zn;

		[AccessedThroughProperty("ColumnHeader3")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ColumnHeader zo;

		[AccessedThroughProperty("ColumnHeader4")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ColumnHeader zp;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("ListView_AutoSell")]
		private ListView zq;

		[CompilerGenerated]
		[AccessedThroughProperty("ColumnHeader10")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ColumnHeader zr;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ColumnHeader11")]
		private ColumnHeader zs;

		[AccessedThroughProperty("CheckBox_Autosort")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private CheckBox zt;

		[AccessedThroughProperty("Label56")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Label zu;

		[CompilerGenerated]
		[AccessedThroughProperty("TextBox_ClickMOD_Delay")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private TextBox zv;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ComboBox_Port")]
		private ComboBox zw;

		[AccessedThroughProperty("RtbQuest")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private RichTextBox zx;

		[AccessedThroughProperty("CheckBox_DCFullHomDo")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private CheckBox zy;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ColumnHeader12")]
		[CompilerGenerated]
		private ColumnHeader zz;

		[AccessedThroughProperty("ColumnHeader13")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ColumnHeader z0;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ColumnHeader14")]
		[CompilerGenerated]
		private ColumnHeader z1;

		[AccessedThroughProperty("DataGridView1")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataGridView z2;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("Label_Lv2")]
		private Label z3;

		[AccessedThroughProperty("Label_Lv_Plus")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Label z4;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("Column_Quest_check")]
		private DataGridViewCheckBoxColumn z5;

		[CompilerGenerated]
		[AccessedThroughProperty("Column_Quest_Func")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DataGridViewTextBoxColumn z6;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Column_Quest_Id")]
		private DataGridViewTextBoxColumn z7;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Column_Quest_Info")]
		[CompilerGenerated]
		private DataGridViewTextBoxColumn z8;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ComboBox_ShopType")]
		[CompilerGenerated]
		private ComboBox z9;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label38")]
		[CompilerGenerated]
		private Label aaa;

		[AccessedThroughProperty("Label_ShopName")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Label aab;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("TextBox_ShopName")]
		private TextBox aac;

		[CompilerGenerated]
		[AccessedThroughProperty("Label40")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Label aad;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label39")]
		[CompilerGenerated]
		private Label aae;

		[CompilerGenerated]
		[AccessedThroughProperty("TextBox_ShopAddPrice")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private TextBox aaf;

		[AccessedThroughProperty("TextBox_ShopAddId")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private TextBox aag;

		[AccessedThroughProperty("Button_Shop_Start")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Button aah;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ListView_Shop")]
		private ListView aai;

		[AccessedThroughProperty("ColumnHeader15")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ColumnHeader aaj;

		[AccessedThroughProperty("ColumnHeader16")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ColumnHeader aak;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ColumnHeader17")]
		[CompilerGenerated]
		private ColumnHeader aal;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("Button_ShopAdd")]
		private Button aam;

		[AccessedThroughProperty("ToolStripMenuItem_AddToShop")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ToolStripMenuItem aan;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label42")]
		[CompilerGenerated]
		private Label aao;

		[AccessedThroughProperty("NumericUpDown_sendpacket")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private NumericUpDown aap;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label41")]
		[CompilerGenerated]
		private Label aaq;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("TextBox_idQC")]
		private TextBox aar;

		[CompilerGenerated]
		[AccessedThroughProperty("CheckBox_QC")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private CheckBox aas;

		[AccessedThroughProperty("Timer_QC")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private System.Windows.Forms.Timer aat;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("PictureBox1")]
		[CompilerGenerated]
		private PictureBox aau;

		[AccessedThroughProperty("GroupBox12")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private GroupBox aav;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button_Mini_Warp")]
		[CompilerGenerated]
		private Button aaw;

		[AccessedThroughProperty("ComboBox_Mini_Warp")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ComboBox aax;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("Button_Func")]
		private Button aay;

		[CompilerGenerated]
		[AccessedThroughProperty("ListView_Quest")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ListView aaz;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ColumnHeader19")]
		private ColumnHeader aa0;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button_Quest_Refresh")]
		private Button aa1;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button2")]
		[CompilerGenerated]
		private Button aa2;

		[AccessedThroughProperty("Lb_tuido25")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Label aa3;

		[AccessedThroughProperty("Lb_tuido24")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Label aa4;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Lb_tuido23")]
		private Label aa5;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("Lb_tuido22")]
		private Label aa6;

		[CompilerGenerated]
		[AccessedThroughProperty("Lb_tuido21")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Label aa7;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Lb_tuido20")]
		[CompilerGenerated]
		private Label aa8;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("Lb_tuido19")]
		private Label aa9;

		[AccessedThroughProperty("Lb_tuido18")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Label aba;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("Lb_tuido17")]
		private Label abb;

		[CompilerGenerated]
		[AccessedThroughProperty("Lb_tuido16")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Label abc;

		[CompilerGenerated]
		[AccessedThroughProperty("Lb_tuido15")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Label abd;

		[AccessedThroughProperty("Lb_tuido14")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Label abe;

		[AccessedThroughProperty("Lb_tuido13")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Label abf;

		[AccessedThroughProperty("Lb_tuido12")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Label abg;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("Lb_tuido11")]
		private Label abh;

		[AccessedThroughProperty("Lb_tuido10")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Label abi;

		[AccessedThroughProperty("Lb_tuido9")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Label abj;

		[CompilerGenerated]
		[AccessedThroughProperty("Lb_tuido8")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Label abk;

		[AccessedThroughProperty("Lb_tuido7")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Label abl;

		[AccessedThroughProperty("Lb_tuido6")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Label abm;

		[AccessedThroughProperty("Lb_tuido5")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Label abn;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("Lb_tuido4")]
		private Label abo;

		[AccessedThroughProperty("Lb_tuido3")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Label abp;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Lb_tuido2")]
		private Label abq;

		[AccessedThroughProperty("Lb_tuido1")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Label abr;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Lb_tuideo25")]
		private Label abs;

		[AccessedThroughProperty("Lb_tuideo24")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Label abt;

		[AccessedThroughProperty("Lb_tuideo23")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Label abu;

		[AccessedThroughProperty("Lb_tuideo22")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Label abv;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("Lb_tuideo21")]
		private Label abw;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Lb_tuideo20")]
		private Label abx;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Lb_tuideo19")]
		[CompilerGenerated]
		private Label aby;

		[AccessedThroughProperty("Lb_tuideo18")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Label abz;

		[AccessedThroughProperty("Lb_tuideo17")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Label ab0;

		[AccessedThroughProperty("Lb_tuideo16")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Label ab1;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Lb_tuideo15")]
		[CompilerGenerated]
		private Label ab2;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("Lb_tuideo14")]
		private Label ab3;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("Lb_tuideo13")]
		private Label ab4;

		[CompilerGenerated]
		[AccessedThroughProperty("Lb_tuideo12")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Label ab5;

		[CompilerGenerated]
		[AccessedThroughProperty("Lb_tuideo11")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Label ab6;

		[CompilerGenerated]
		[AccessedThroughProperty("Lb_tuideo10")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Label ab7;

		[AccessedThroughProperty("Lb_tuideo9")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Label ab8;

		[AccessedThroughProperty("Lb_tuideo8")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Label ab9;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Lb_tuideo7")]
		[CompilerGenerated]
		private Label aca;

		[AccessedThroughProperty("Lb_tuideo6")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Label acb;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("Lb_tuideo5")]
		private Label acc;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Lb_tuideo4")]
		private Label acd;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("Lb_tuideo3")]
		private Label ace;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("Lb_tuideo2")]
		private Label acf;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("Lb_tuideo1")]
		private Label acg;

		[CompilerGenerated]
		[AccessedThroughProperty("Vs2010TabControl_Main")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Vs2010TabControl ach;

		[AccessedThroughProperty("TabPage_Main")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private TabPage aci;

		[AccessedThroughProperty("TabPage_Attack")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private TabPage acj;

		[AccessedThroughProperty("miniToolStrip")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Vs2010ToolStrip ack;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("ToolStrip1")]
		private Vs2010ToolStrip acl;

		[CompilerGenerated]
		[AccessedThroughProperty("ToolStripSplitButton_save")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ToolStripSplitButton acm;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ToolStripLabel1")]
		private ToolStripLabel acn;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("ToolStripTextBox_KenhPassword")]
		private ToolStripTextBox aco;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Panel_Login")]
		[CompilerGenerated]
		private Panel acp;

		[AccessedThroughProperty("Panel10")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Panel acq;

		[AccessedThroughProperty("Panel9")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Panel acr;

		[CompilerGenerated]
		[AccessedThroughProperty("PictureBox_Pet_photo")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private PictureBox acs;

		[CompilerGenerated]
		[AccessedThroughProperty("PictureBox_char5")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private PictureBox act;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("PictureBox_char6")]
		private PictureBox acu;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("PictureBox_char3")]
		private PictureBox acv;

		[AccessedThroughProperty("PictureBox_char2")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private PictureBox acw;

		[AccessedThroughProperty("PictureBox_char4")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private PictureBox acx;

		[AccessedThroughProperty("PictureBox_char1")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private PictureBox acy;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("PictureBox_Pet5")]
		private PictureBox acz;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("PictureBox_Pet6")]
		private PictureBox ac0;

		[AccessedThroughProperty("PictureBox_Pet3")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private PictureBox ac1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("PictureBox_Pet2")]
		private PictureBox ac2;

		[CompilerGenerated]
		[AccessedThroughProperty("PictureBox_Pet4")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private PictureBox ac3;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("PictureBox_Pet1")]
		private PictureBox ac4;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("PictureBox_Pet_Thuoctinh")]
		private PictureBox ac5;

		[AccessedThroughProperty("PictureBox_Char_Thuoctinh")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private PictureBox ac6;

		[AccessedThroughProperty("PictureBox_Pet_XuatChien")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private PictureBox ac7;

		[AccessedThroughProperty("Label94")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Label ac8;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label_Char_agi")]
		[CompilerGenerated]
		private Label ac9;

		[CompilerGenerated]
		[AccessedThroughProperty("Label_Char_spx")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Label ada;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label_Char_hpx")]
		private Label adb;

		[AccessedThroughProperty("Label_Char_def")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Label adc;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label_Char_atk")]
		[CompilerGenerated]
		private Label add;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label_Char_int")]
		private Label ade;

		[CompilerGenerated]
		[AccessedThroughProperty("Label_Pet_fai")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Label adf;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label_Pet_agi")]
		private Label adg;

		[AccessedThroughProperty("Label_Pet_spx")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Label adh;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label_Pet_hpx")]
		[CompilerGenerated]
		private Label adi;

		[CompilerGenerated]
		[AccessedThroughProperty("Label_Pet_def")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Label adj;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("Label_Pet_atk")]
		private Label adk;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("Label_Pet_int")]
		private Label adl;

		[CompilerGenerated]
		[AccessedThroughProperty("TabPage_Quest")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private TabPage adm;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TabPage_Warp")]
		private TabPage adn;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TabPage_Players")]
		[CompilerGenerated]
		private TabPage ado;

		[AccessedThroughProperty("TabPage_Setting")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private TabPage adp;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TabPage_Shop")]
		private TabPage adq;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TabPage4")]
		private TabPage adr;

		[AccessedThroughProperty("TabPage_Map")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private TabPage ads;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("PictureBox_pet_next")]
		private PictureBox adt;

		[AccessedThroughProperty("PictureBox_Pet_back")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private PictureBox adu;

		[AccessedThroughProperty("ToolStripMenuItem_CharUse")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private ToolStripMenuItem adv;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ToolStripSeparator3")]
		private ToolStripSeparator adw;

		[CompilerGenerated]
		[AccessedThroughProperty("ToolStripMenuItem_Petuse")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ToolStripMenuItem adx;

		[AccessedThroughProperty("ToolStripMenuItem_dropitem")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ToolStripMenuItem ady;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ToolStripMenuItem_ContributeItem")]
		[CompilerGenerated]
		private ToolStripMenuItem adz;

		[AccessedThroughProperty("ToolStripSeparator4")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ToolStripSeparator ad0;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("ToolStripMenuItem_SendBDY")]
		private ToolStripMenuItem ad1;

		[CompilerGenerated]
		[AccessedThroughProperty("ToolStripTextBox_SendBDY_Id")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ToolStripTextBox ad2;

		[AccessedThroughProperty("ToolStripSeparator5")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ToolStripSeparator ad3;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("PictureBox_char_add_agi")]
		private PictureBox ad4;

		[AccessedThroughProperty("PictureBox_char_add_spx")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private PictureBox ad5;

		[AccessedThroughProperty("PictureBox_char_add_hpx")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private PictureBox ad6;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("PictureBox_char_add_def")]
		private PictureBox ad7;

		[AccessedThroughProperty("PictureBox_char_add_atk")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private PictureBox ad8;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("PictureBox_char_add_int")]
		[CompilerGenerated]
		private PictureBox ad9;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ImageList1")]
		[CompilerGenerated]
		private ImageList aea;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ComboBox_CharSkill")]
		[CompilerGenerated]
		private ComboBoxIcon aeb;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ComboBox_PetSkill")]
		private ComboBoxIcon aec;

		[CompilerGenerated]
		[AccessedThroughProperty("DongYVutDoToolStripMenuItem")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ToolStripMenuItem aed;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("DongYDongGopToolStripMenuItem")]
		private ToolStripMenuItem aee;

		[AccessedThroughProperty("PictureBox_mini")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private PictureBox aef;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ToolStripSeparator6")]
		[CompilerGenerated]
		private ToolStripSeparator aeg;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ToolStripMenuItem_Tuido_Sort")]
		private ToolStripMenuItem aeh;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("PictureBox_avatar")]
		private PictureBox aei;
		internal virtual RichTextBox rtbsystem
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
				this.m_b = value;
			}
		}

		internal virtual GroupBox GroupBox_team
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

		internal virtual ProgressBarEx ProgressBarEx_PetHp
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
				this.m_n = value;
			}
		}

		internal virtual Label Label8
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
				this.m_o = value;
			}
		}

		internal virtual ProgressBarEx ProgressBarEx_PetSp
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

		internal virtual ProgressBarEx ProgressBarEx_PetExp
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
				this.m_q = value;
			}
		}

		internal virtual RichTextBox RtbChat
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
				this.m_r = value;
			}
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

		internal virtual DataSet DataSet1
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
				this.m_v = value;
			}
		}

		internal virtual DataTable DataTable1
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
				this.m_w = value;
			}
		}

		internal virtual DataColumn DataColumn1
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

		internal virtual DataColumn DataColumn2
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

		internal virtual DataColumn DataColumn3
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

		internal virtual DataColumn DataColumn4
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

		internal virtual DataColumn DataColumn5
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

		internal virtual DataColumn DataColumn6
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
				this.m_ac = value;
			}
		}

		internal virtual DataColumn DataColumn7
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

		internal virtual DataColumn DataColumn8
		{
			[CompilerGenerated]
			get
			{
				return this.m_ae;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				this.m_ae = value;
			}
		}

		internal virtual DataTable DataTable2
		{
			[CompilerGenerated]
			get
			{
				return this.m_af;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				this.m_af = value;
			}
		}

		internal virtual DataColumn DataColumn9
		{
			[CompilerGenerated]
			get
			{
				return this.m_ag;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				this.m_ag = value;
			}
		}

		internal virtual DataColumn DataColumn10
		{
			[CompilerGenerated]
			get
			{
				return this.m_ah;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				this.m_ah = value;
			}
		}

		internal virtual DataColumn DataColumn11
		{
			[CompilerGenerated]
			get
			{
				return this.m_ai;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				this.m_ai = value;
			}
		}

		internal virtual DataColumn DataColumn12
		{
			[CompilerGenerated]
			get
			{
				return this.m_aj;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				this.m_aj = value;
			}
		}

		internal virtual DataColumn DataColumn13
		{
			[CompilerGenerated]
			get
			{
				return this.m_ak;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				this.m_ak = value;
			}
		}

		internal virtual DataColumn DataColumn14
		{
			[CompilerGenerated]
			get
			{
				return this.m_al;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				this.m_al = value;
			}
		}

		internal virtual DataColumn DataColumn15
		{
			[CompilerGenerated]
			get
			{
				return this.m_am;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				this.m_am = value;
			}
		}

		internal virtual DataColumn DataColumn16
		{
			[CompilerGenerated]
			get
			{
				return this.m_an;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				this.m_an = value;
			}
		}

		internal virtual DataColumn DataColumn17
		{
			[CompilerGenerated]
			get
			{
				return this.m_ao;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				this.m_ao = value;
			}
		}

		internal virtual DataColumn DataColumn18
		{
			[CompilerGenerated]
			get
			{
				return this.m_ap;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				this.m_ap = value;
			}
		}

		internal virtual DataColumn DataColumn19
		{
			[CompilerGenerated]
			get
			{
				return this.m_aq;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				this.m_aq = value;
			}
		}

		internal virtual Label Label_PlayerCount
		{
			[CompilerGenerated]
			get
			{
				return this.m_ar;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				this.m_ar = value;
			}
		}

		internal virtual StatusBar StatusBar1
		{
			[CompilerGenerated]
			get
			{
				return this.m_as;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				this.m_as = value;
			}
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
			get
			{
				return this.m_ax;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				this.m_ax = value;
			}
		}

		internal virtual Label Label1
		{
			[CompilerGenerated]
			get
			{
				return this.m_ay;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				this.m_ay = value;
			}
		}

		internal virtual Label Label2
		{
			[CompilerGenerated]
			get
			{
				return this.m_az;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				this.m_az = value;
			}
		}

		internal virtual NumericUpDown NumericUpDown_createDef
		{
			[CompilerGenerated]
			get
			{
				return this.m_a0;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				this.m_a0 = value;
			}
		}

		internal virtual NumericUpDown NumericUpDown_createAtk
		{
			[CompilerGenerated]
			get
			{
				return this.m_a1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				this.m_a1 = value;
			}
		}

		internal virtual Label Label16
		{
			[CompilerGenerated]
			get
			{
				return this.m_a2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				this.m_a2 = value;
			}
		}

		internal virtual Label Label_point
		{
			[CompilerGenerated]
			get
			{
				return this.m_a3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				this.m_a3 = value;
			}
		}

		internal virtual NumericUpDown NumericUpDown_createInt
		{
			[CompilerGenerated]
			get
			{
				return this.m_a4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				this.m_a4 = value;
			}
		}

		internal virtual Label Label10
		{
			[CompilerGenerated]
			get
			{
				return this.m_a5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				this.m_a5 = value;
			}
		}

		internal virtual NumericUpDown NumericUpDown_createAgi
		{
			[CompilerGenerated]
			get
			{
				return this.m_a6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				this.m_a6 = value;
			}
		}

		internal virtual NumericUpDown NumericUpDown_createHp
		{
			[CompilerGenerated]
			get
			{
				return this.m_a7;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				this.m_a7 = value;
			}
		}

		internal virtual Label Label15
		{
			[CompilerGenerated]
			get
			{
				return this.m_a8;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				this.m_a8 = value;
			}
		}

		internal virtual NumericUpDown NumericUpDown_createSp
		{
			[CompilerGenerated]
			get
			{
				return this.m_a9;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				this.m_a9 = value;
			}
		}

		internal virtual Label Label14
		{
			[CompilerGenerated]
			get
			{
				return this.m_ba;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				this.m_ba = value;
			}
		}

		internal virtual Label Label17
		{
			[CompilerGenerated]
			get
			{
				return this.m_bb;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				this.m_bb = value;
			}
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
			get
			{
				return this.m_bd;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				this.m_bd = value;
			}
		}

		internal virtual Label Label18
		{
			[CompilerGenerated]
			get
			{
				return this.m_be;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				this.m_be = value;
			}
		}

		internal virtual TextBox TextBox_createName
		{
			[CompilerGenerated]
			get
			{
				return this.m_bf;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				this.m_bf = value;
			}
		}

		internal virtual TextBox TextBox_Pass
		{
			[CompilerGenerated]
			get
			{
				return this.m_bg;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				this.m_bg = value;
			}
		}

		internal virtual TextBox TextBox_amma
		{
			[CompilerGenerated]
			get
			{
				return this.m_bh;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				this.m_bh = value;
			}
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
			get
			{
				return this.m_bq;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				this.m_bq = value;
			}
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

		internal virtual DataColumn DataColumn21
		{
			[CompilerGenerated]
			get
			{
				return by;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				by = value;
			}
		}

		internal virtual DataColumn DataColumn22
		{
			[CompilerGenerated]
			get
			{
				return bz;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				bz = value;
			}
		}

		internal virtual DataTable DataTable3
		{
			[CompilerGenerated]
			get
			{
				return b0;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				b0 = value;
			}
		}

		internal virtual DataColumn DataColumn23
		{
			[CompilerGenerated]
			get
			{
				return b1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				b1 = value;
			}
		}

		internal virtual DataColumn DataColumn24
		{
			[CompilerGenerated]
			get
			{
				return b2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				b2 = value;
			}
		}

		internal virtual DataColumn DataColumn25
		{
			[CompilerGenerated]
			get
			{
				return b3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				b3 = value;
			}
		}

		internal virtual DataColumn DataColumn26
		{
			[CompilerGenerated]
			get
			{
				return b4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				b4 = value;
			}
		}

		internal virtual DataColumn DataColumn27
		{
			[CompilerGenerated]
			get
			{
				return b5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				b5 = value;
			}
		}

		internal virtual DataColumn DataColumn28
		{
			[CompilerGenerated]
			get
			{
				return b6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				b6 = value;
			}
		}

		internal virtual DataColumn DataColumn29
		{
			[CompilerGenerated]
			get
			{
				return b7;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				b7 = value;
			}
		}

		internal virtual DataColumn DataColumn30
		{
			[CompilerGenerated]
			get
			{
				return b8;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				b8 = value;
			}
		}

		internal virtual DataColumn DataColumn31
		{
			[CompilerGenerated]
			get
			{
				return b9;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				b9 = value;
			}
		}

		internal virtual DataColumn DataColumn32
		{
			[CompilerGenerated]
			get
			{
				return ca;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ca = value;
			}
		}

		internal virtual DataColumn DataColumn33
		{
			[CompilerGenerated]
			get
			{
				return cb;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				cb = value;
			}
		}

		internal virtual DataColumn DataColumn34
		{
			[CompilerGenerated]
			get
			{
				return cc;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				cc = value;
			}
		}

		internal virtual Panel Panel_Chat
		{
			[CompilerGenerated]
			get
			{
				return cd;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				cd = value;
			}
		}

		internal virtual Label Label_CharExpMin
		{
			[CompilerGenerated]
			get
			{
				return ce;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ce = value;
			}
		}

		internal virtual Label Label4
		{
			[CompilerGenerated]
			get
			{
				return cf;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				cf = value;
			}
		}

		internal virtual Label Label_gold
		{
			[CompilerGenerated]
			get
			{
				return cg;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				cg = value;
			}
		}

		internal virtual ProgressBarEx ProgressBarEx_CharExp
		{
			[CompilerGenerated]
			get
			{
				return ch;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ch = value;
			}
		}

		internal virtual ProgressBarEx ProgressBarEx_CharSp
		{
			[CompilerGenerated]
			get
			{
				return ci;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ci = value;
			}
		}

		internal virtual ProgressBarEx ProgressBarEx_CharHp
		{
			[CompilerGenerated]
			get
			{
				return cj;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				cj = value;
			}
		}

		internal virtual GroupBox GroupBox_Bot
		{
			[CompilerGenerated]
			get
			{
				return ck;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ck = value;
			}
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
			get
			{
				return cn;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				cn = value;
			}
		}

		internal virtual Label Label_Lv
		{
			[CompilerGenerated]
			get
			{
				return co;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				co = value;
			}
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
			get
			{
				return cq;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				cq = value;
			}
		}

		internal virtual DataColumn DataColumn35
		{
			[CompilerGenerated]
			get
			{
				return cr;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				cr = value;
			}
		}

		internal virtual DataColumn DataColumn36
		{
			[CompilerGenerated]
			get
			{
				return cs;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				cs = value;
			}
		}

		internal virtual DataColumn DataColumn37
		{
			[CompilerGenerated]
			get
			{
				return ct;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ct = value;
			}
		}

		internal virtual DataColumn DataColumn38
		{
			[CompilerGenerated]
			get
			{
				return cu;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				cu = value;
			}
		}

		internal virtual DataColumn DataColumn39
		{
			[CompilerGenerated]
			get
			{
				return cv;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				cv = value;
			}
		}

		internal virtual DataTable DataTable5
		{
			[CompilerGenerated]
			get
			{
				return cw;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				cw = value;
			}
		}

		internal virtual DataColumn DataColumn40
		{
			[CompilerGenerated]
			get
			{
				return cx;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				cx = value;
			}
		}

		internal virtual DataColumn DataColumn41
		{
			[CompilerGenerated]
			get
			{
				return cy;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				cy = value;
			}
		}

		internal virtual DataColumn DataColumn42
		{
			[CompilerGenerated]
			get
			{
				return cz;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				cz = value;
			}
		}

		internal virtual DataColumn DataColumn43
		{
			[CompilerGenerated]
			get
			{
				return c0;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				c0 = value;
			}
		}

		internal virtual DataColumn DataColumn44
		{
			[CompilerGenerated]
			get
			{
				return c1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				c1 = value;
			}
		}

		internal virtual DataTable DataTable6
		{
			[CompilerGenerated]
			get
			{
				return c2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				c2 = value;
			}
		}

		internal virtual DataColumn DataColumn45
		{
			[CompilerGenerated]
			get
			{
				return c3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				c3 = value;
			}
		}

		internal virtual DataColumn DataColumn46
		{
			[CompilerGenerated]
			get
			{
				return c4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				c4 = value;
			}
		}

		internal virtual DataColumn DataColumn47
		{
			[CompilerGenerated]
			get
			{
				return c5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				c5 = value;
			}
		}

		internal virtual DataColumn DataColumn48
		{
			[CompilerGenerated]
			get
			{
				return c6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				c6 = value;
			}
		}

		internal virtual DataColumn DataColumn49
		{
			[CompilerGenerated]
			get
			{
				return c7;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				c7 = value;
			}
		}

		internal virtual DataColumn DataColumn50
		{
			[CompilerGenerated]
			get
			{
				return c8;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				c8 = value;
			}
		}

		internal virtual DataColumn DataColumn51
		{
			[CompilerGenerated]
			get
			{
				return c9;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				c9 = value;
			}
		}

		internal virtual DataColumn DataColumn52
		{
			[CompilerGenerated]
			get
			{
				return da;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				da = value;
			}
		}

		internal virtual DataTable DataTable7
		{
			[CompilerGenerated]
			get
			{
				return db;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				db = value;
			}
		}

		internal virtual DataTable DataTable8
		{
			[CompilerGenerated]
			get
			{
				return dc;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				dc = value;
			}
		}

		internal virtual DataColumn DataColumn53
		{
			[CompilerGenerated]
			get
			{
				return dd;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				dd = value;
			}
		}

		internal virtual DataColumn DataColumn54
		{
			[CompilerGenerated]
			get
			{
				return de;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				de = value;
			}
		}

		internal virtual DataColumn DataColumn55
		{
			[CompilerGenerated]
			get
			{
				return df;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				df = value;
			}
		}

		internal virtual DataColumn DataColumn56
		{
			[CompilerGenerated]
			get
			{
				return dg;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				dg = value;
			}
		}

		internal virtual DataColumn DataColumn57
		{
			[CompilerGenerated]
			get
			{
				return dh;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				dh = value;
			}
		}

		internal virtual DataColumn DataColumn58
		{
			[CompilerGenerated]
			get
			{
				return di;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				di = value;
			}
		}

		internal virtual DataColumn DataColumn59
		{
			[CompilerGenerated]
			get
			{
				return dj;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				dj = value;
			}
		}

		internal virtual DataColumn DataColumn60
		{
			[CompilerGenerated]
			get
			{
				return dk;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				dk = value;
			}
		}

		internal virtual DataColumn DataColumn61
		{
			[CompilerGenerated]
			get
			{
				return dl;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				dl = value;
			}
		}

		internal virtual DataColumn DataColumn62
		{
			[CompilerGenerated]
			get
			{
				return dm;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				dm = value;
			}
		}

		internal virtual DataColumn DataColumn63
		{
			[CompilerGenerated]
			get
			{
				return dn;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				dn = value;
			}
		}

		internal virtual DataColumn DataColumn64
		{
			[CompilerGenerated]
			get
			{
				return dp;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				dp = value;
			}
		}

		internal virtual DataColumn DataColumn65
		{
			[CompilerGenerated]
			get
			{
				return dq;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				dq = value;
			}
		}

		internal virtual DataColumn DataColumn66
		{
			[CompilerGenerated]
			get
			{
				return dr;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				dr = value;
			}
		}

		internal virtual DataColumn DataColumn67
		{
			[CompilerGenerated]
			get
			{
				return ds;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ds = value;
			}
		}

		internal virtual DataColumn DataColumn68
		{
			[CompilerGenerated]
			get
			{
				return dt;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				dt = value;
			}
		}

		internal virtual DataColumn DataColumn69
		{
			[CompilerGenerated]
			get
			{
				return du;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				du = value;
			}
		}

		internal virtual DataColumn DataColumn70
		{
			[CompilerGenerated]
			get
			{
				return dv;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				dv = value;
			}
		}

		internal virtual DataColumn DataColumn71
		{
			[CompilerGenerated]
			get
			{
				return dw;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				dw = value;
			}
		}

		internal virtual DataColumn DataColumn72
		{
			[CompilerGenerated]
			get
			{
				return dx;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				dx = value;
			}
		}

		internal virtual DataColumn DataColumn73
		{
			[CompilerGenerated]
			get
			{
				return dy;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				dy = value;
			}
		}

		internal virtual DataColumn DataColumn74
		{
			[CompilerGenerated]
			get
			{
				return dz;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				dz = value;
			}
		}

		internal virtual DataColumn DataColumn75
		{
			[CompilerGenerated]
			get
			{
				return d0;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				d0 = value;
			}
		}

		internal virtual DataColumn DataColumn76
		{
			[CompilerGenerated]
			get
			{
				return d1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				d1 = value;
			}
		}

		internal virtual DataColumn DataColumn77
		{
			[CompilerGenerated]
			get
			{
				return d2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				d2 = value;
			}
		}

		internal virtual DataColumn DataColumn78
		{
			[CompilerGenerated]
			get
			{
				return d3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				d3 = value;
			}
		}

		internal virtual DataColumn DataColumn79
		{
			[CompilerGenerated]
			get
			{
				return d4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				d4 = value;
			}
		}

		internal virtual DataColumn DataColumn80
		{
			[CompilerGenerated]
			get
			{
				return d5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				d5 = value;
			}
		}

		internal virtual DataTable DataTable9
		{
			[CompilerGenerated]
			get
			{
				return d6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				d6 = value;
			}
		}

		internal virtual DataColumn DataColumn81
		{
			[CompilerGenerated]
			get
			{
				return d7;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				d7 = value;
			}
		}

		internal virtual DataColumn DataColumn82
		{
			[CompilerGenerated]
			get
			{
				return d8;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				d8 = value;
			}
		}

		internal virtual DataColumn DataColumn83
		{
			[CompilerGenerated]
			get
			{
				return d9;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				d9 = value;
			}
		}

		internal virtual DataColumn DataColumn84
		{
			[CompilerGenerated]
			get
			{
				return ea;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ea = value;
			}
		}

		internal virtual DataColumn DataColumn85
		{
			[CompilerGenerated]
			get
			{
				return eb;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				eb = value;
			}
		}

		internal virtual DataColumn DataColumn86
		{
			[CompilerGenerated]
			get
			{
				return ec;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ec = value;
			}
		}

		internal virtual DataColumn DataColumn87
		{
			[CompilerGenerated]
			get
			{
				return ed;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ed = value;
			}
		}

		internal virtual DataColumn DataColumn88
		{
			[CompilerGenerated]
			get
			{
				return ee;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ee = value;
			}
		}

		internal virtual DataColumn DataColumn89
		{
			[CompilerGenerated]
			get
			{
				return ef;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ef = value;
			}
		}

		internal virtual DataColumn DataColumn90
		{
			[CompilerGenerated]
			get
			{
				return eg;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				eg = value;
			}
		}

		internal virtual DataColumn DataColumn91
		{
			[CompilerGenerated]
			get
			{
				return eh;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				eh = value;
			}
		}

		internal virtual DataColumn DataColumn92
		{
			[CompilerGenerated]
			get
			{
				return ei;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ei = value;
			}
		}

		internal virtual DataColumn DataColumn93
		{
			[CompilerGenerated]
			get
			{
				return ej;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ej = value;
			}
		}

		internal virtual DataColumn DataColumn94
		{
			[CompilerGenerated]
			get
			{
				return ek;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ek = value;
			}
		}

		internal virtual DataColumn DataColumn95
		{
			[CompilerGenerated]
			get
			{
				return el;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				el = value;
			}
		}

		internal virtual DataColumn DataColumn96
		{
			[CompilerGenerated]
			get
			{
				return em;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				em = value;
			}
		}

		internal virtual DataTable DataTable10
		{
			[CompilerGenerated]
			get
			{
				return en;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				en = value;
			}
		}

		internal virtual DataColumn DataColumn97
		{
			[CompilerGenerated]
			get
			{
				return eo;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				eo = value;
			}
		}

		internal virtual DataColumn DataColumn98
		{
			[CompilerGenerated]
			get
			{
				return ep;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ep = value;
			}
		}

		internal virtual DataColumn DataColumn99
		{
			[CompilerGenerated]
			get
			{
				return eq;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				eq = value;
			}
		}

		internal virtual DataColumn DataColumn100
		{
			[CompilerGenerated]
			get
			{
				return er;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				er = value;
			}
		}

		internal virtual DataColumn DataColumn101
		{
			[CompilerGenerated]
			get
			{
				return es;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				es = value;
			}
		}

		internal virtual DataColumn DataColumn102
		{
			[CompilerGenerated]
			get
			{
				return et;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				et = value;
			}
		}

		internal virtual DataColumn DataColumn103
		{
			[CompilerGenerated]
			get
			{
				return eu;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				eu = value;
			}
		}

		internal virtual DataColumn DataColumn104
		{
			[CompilerGenerated]
			get
			{
				return ev;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ev = value;
			}
		}

		internal virtual DataColumn DataColumn105
		{
			[CompilerGenerated]
			get
			{
				return ew;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ew = value;
			}
		}

		internal virtual DataColumn DataColumn106
		{
			[CompilerGenerated]
			get
			{
				return ex;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ex = value;
			}
		}

		internal virtual DataColumn DataColumn107
		{
			[CompilerGenerated]
			get
			{
				return ey;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ey = value;
			}
		}

		internal virtual DataColumn DataColumn108
		{
			[CompilerGenerated]
			get
			{
				return ez;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ez = value;
			}
		}

		internal virtual DataColumn DataColumn109
		{
			[CompilerGenerated]
			get
			{
				return e0;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				e0 = value;
			}
		}

		internal virtual Label Label_petlv
		{
			[CompilerGenerated]
			get
			{
				return e1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				e1 = value;
			}
		}

		internal virtual ToolBarButton OpenButton
		{
			[CompilerGenerated]
			get
			{
				return e2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				e2 = value;
			}
		}

		internal virtual ToolBarButton SaveButton
		{
			[CompilerGenerated]
			get
			{
				return e3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				e3 = value;
			}
		}

		internal virtual Label Label_mapy
		{
			[CompilerGenerated]
			get
			{
				return e4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				e4 = value;
			}
		}

		internal virtual Label Label_mapx
		{
			[CompilerGenerated]
			get
			{
				return e5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				e5 = value;
			}
		}

		internal virtual Label Label_mapid
		{
			[CompilerGenerated]
			get
			{
				return e6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				e6 = value;
			}
		}

		internal virtual StatusBarPanel StatusBarPanel_status
		{
			[CompilerGenerated]
			get
			{
				return e7;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				e7 = value;
			}
		}

		internal virtual ContextMenuStrip ContextMenuStrip_saveas
		{
			[CompilerGenerated]
			get
			{
				return e8;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				e8 = value;
			}
		}

		internal virtual Panel Panel5
		{
			[CompilerGenerated]
			get
			{
				return e9;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				e9 = value;
			}
		}

		internal virtual Panel Panel7
		{
			[CompilerGenerated]
			get
			{
				return fa;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				fa = value;
			}
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
			get
			{
				return fc;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				fc = value;
			}
		}

		internal virtual DataColumn DataColumn111
		{
			[CompilerGenerated]
			get
			{
				return fd;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				fd = value;
			}
		}

		internal virtual DataColumn DataColumn112
		{
			[CompilerGenerated]
			get
			{
				return fe;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				fe = value;
			}
		}

		internal virtual DataColumn DataColumn113
		{
			[CompilerGenerated]
			get
			{
				return ff;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ff = value;
			}
		}

		internal virtual DataColumn DataColumn117
		{
			[CompilerGenerated]
			get
			{
				return fg;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				fg = value;
			}
		}

		internal virtual DataColumn DataColumn118
		{
			[CompilerGenerated]
			get
			{
				return fh;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				fh = value;
			}
		}

		internal virtual DataColumn DataColumn119
		{
			[CompilerGenerated]
			get
			{
				return fi;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				fi = value;
			}
		}

		internal virtual DataColumn DataColumn120
		{
			[CompilerGenerated]
			get
			{
				return fj;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				fj = value;
			}
		}

		internal virtual DataColumn DataColumn121
		{
			[CompilerGenerated]
			get
			{
				return fk;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				fk = value;
			}
		}

		internal virtual DataColumn DataColumn122
		{
			[CompilerGenerated]
			get
			{
				return fl;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				fl = value;
			}
		}

		internal virtual DataColumn DataColumn123
		{
			[CompilerGenerated]
			get
			{
				return fm;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				fm = value;
			}
		}

		internal virtual DataColumn DataColumn124
		{
			[CompilerGenerated]
			get
			{
				return fn;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				fn = value;
			}
		}

		internal virtual DataColumn DataColumn125
		{
			[CompilerGenerated]
			get
			{
				return fo;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				fo = value;
			}
		}

		internal virtual DataColumn DataColumn126
		{
			[CompilerGenerated]
			get
			{
				return fp;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				fp = value;
			}
		}

		internal virtual DataColumn DataColumn127
		{
			[CompilerGenerated]
			get
			{
				return fq;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				fq = value;
			}
		}

		internal virtual DataColumn DataColumn128
		{
			[CompilerGenerated]
			get
			{
				return fr;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				fr = value;
			}
		}

		internal virtual DataColumn DataColumn129
		{
			[CompilerGenerated]
			get
			{
				return fs;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				fs = value;
			}
		}

		internal virtual DataColumn DataColumn130
		{
			[CompilerGenerated]
			get
			{
				return ft;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ft = value;
			}
		}

		internal virtual DataColumn DataColumn131
		{
			[CompilerGenerated]
			get
			{
				return fu;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				fu = value;
			}
		}

		internal virtual DataColumn DataColumn132
		{
			[CompilerGenerated]
			get
			{
				return fv;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				fv = value;
			}
		}

		internal virtual DataColumn DataColumn133
		{
			[CompilerGenerated]
			get
			{
				return fw;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				fw = value;
			}
		}

		internal virtual DataColumn DataColumn134
		{
			[CompilerGenerated]
			get
			{
				return fx;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				fx = value;
			}
		}

		internal virtual DataColumn DataColumn135
		{
			[CompilerGenerated]
			get
			{
				return fy;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				fy = value;
			}
		}

		internal virtual DataColumn DataColumn136
		{
			[CompilerGenerated]
			get
			{
				return fz;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				fz = value;
			}
		}

		internal virtual DataColumn DataColumn137
		{
			[CompilerGenerated]
			get
			{
				return f0;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				f0 = value;
			}
		}

		internal virtual DataColumn DataColumn138
		{
			[CompilerGenerated]
			get
			{
				return f1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				f1 = value;
			}
		}

		internal virtual DataColumn DataColumn139
		{
			[CompilerGenerated]
			get
			{
				return f2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				f2 = value;
			}
		}

		internal virtual DataColumn DataColumn140
		{
			[CompilerGenerated]
			get
			{
				return f3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				f3 = value;
			}
		}

		internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn1
		{
			[CompilerGenerated]
			get
			{
				return f4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				f4 = value;
			}
		}

		internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn2
		{
			[CompilerGenerated]
			get
			{
				return f5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				f5 = value;
			}
		}

		internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn3
		{
			[CompilerGenerated]
			get
			{
				return f6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				f6 = value;
			}
		}

		internal virtual DataColumn DataColumn141
		{
			[CompilerGenerated]
			get
			{
				return f7;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				f7 = value;
			}
		}

		internal virtual DataColumn DataColumn142
		{
			[CompilerGenerated]
			get
			{
				return f8;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				f8 = value;
			}
		}

		internal virtual DataColumn DataColumn143
		{
			[CompilerGenerated]
			get
			{
				return f9;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				f9 = value;
			}
		}

		internal virtual DataColumn DataColumn144
		{
			[CompilerGenerated]
			get
			{
				return ga;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ga = value;
			}
		}

		internal virtual DataColumn DataColumn145
		{
			[CompilerGenerated]
			get
			{
				return gb;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				gb = value;
			}
		}

		internal virtual DataColumn DataColumn146
		{
			[CompilerGenerated]
			get
			{
				return gc;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				gc = value;
			}
		}

		internal virtual DataColumn DataColumn147
		{
			[CompilerGenerated]
			get
			{
				return gd;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				gd = value;
			}
		}

		internal virtual DataColumn DataColumn148
		{
			[CompilerGenerated]
			get
			{
				return ge;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ge = value;
			}
		}

		internal virtual DataColumn DataColumn149
		{
			[CompilerGenerated]
			get
			{
				return gf;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				gf = value;
			}
		}

		internal virtual DataColumn DataColumn150
		{
			[CompilerGenerated]
			get
			{
				return gg;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				gg = value;
			}
		}

		internal virtual DataColumn DataColumn151
		{
			[CompilerGenerated]
			get
			{
				return gh;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				gh = value;
			}
		}

		internal virtual DataColumn DataColumn152
		{
			[CompilerGenerated]
			get
			{
				return gi;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				gi = value;
			}
		}

		internal virtual DataColumn DataColumn153
		{
			[CompilerGenerated]
			get
			{
				return gj;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				gj = value;
			}
		}

		internal virtual DataColumn DataColumn154
		{
			[CompilerGenerated]
			get
			{
				return gk;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				gk = value;
			}
		}

		internal virtual DataColumn DataColumn155
		{
			[CompilerGenerated]
			get
			{
				return gl;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				gl = value;
			}
		}

		internal virtual DataColumn DataColumn156
		{
			[CompilerGenerated]
			get
			{
				return gm;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				gm = value;
			}
		}

		internal virtual DataColumn DataColumn157
		{
			[CompilerGenerated]
			get
			{
				return gn;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				gn = value;
			}
		}

		internal virtual DataColumn DataColumn158
		{
			[CompilerGenerated]
			get
			{
				return go;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				go = value;
			}
		}

		internal virtual DataColumn DataColumn159
		{
			[CompilerGenerated]
			get
			{
				return gp;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				gp = value;
			}
		}

		internal virtual DataColumn DataColumn160
		{
			[CompilerGenerated]
			get
			{
				return gq;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				gq = value;
			}
		}

		internal virtual DataColumn DataColumn161
		{
			[CompilerGenerated]
			get
			{
				return gr;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				gr = value;
			}
		}

		internal virtual DataColumn DataColumn162
		{
			[CompilerGenerated]
			get
			{
				return gs;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				gs = value;
			}
		}

		internal virtual DataColumn DataColumn163
		{
			[CompilerGenerated]
			get
			{
				return gt;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				gt = value;
			}
		}

		internal virtual DataColumn DataColumn164
		{
			[CompilerGenerated]
			get
			{
				return gu;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				gu = value;
			}
		}

		internal virtual DataColumn DataColumn165
		{
			[CompilerGenerated]
			get
			{
				return gv;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				gv = value;
			}
		}

		internal virtual DataColumn DataColumn166
		{
			[CompilerGenerated]
			get
			{
				return gw;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				gw = value;
			}
		}

		internal virtual DataColumn DataColumn167
		{
			[CompilerGenerated]
			get
			{
				return gx;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				gx = value;
			}
		}

		internal virtual DataColumn DataColumn168
		{
			[CompilerGenerated]
			get
			{
				return gy;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				gy = value;
			}
		}

		internal virtual DataColumn DataColumn169
		{
			[CompilerGenerated]
			get
			{
				return gz;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				gz = value;
			}
		}

		internal virtual DataColumn DataColumn170
		{
			[CompilerGenerated]
			get
			{
				return g0;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				g0 = value;
			}
		}

		internal virtual DataColumn DataColumn171
		{
			[CompilerGenerated]
			get
			{
				return g1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				g1 = value;
			}
		}

		internal virtual DataColumn DataColumn172
		{
			[CompilerGenerated]
			get
			{
				return g2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				g2 = value;
			}
		}

		internal virtual DataColumn DataColumn173
		{
			[CompilerGenerated]
			get
			{
				return g3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				g3 = value;
			}
		}

		internal virtual DataColumn DataColumn174
		{
			[CompilerGenerated]
			get
			{
				return g4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				g4 = value;
			}
		}

		internal virtual DataColumn DataColumn175
		{
			[CompilerGenerated]
			get
			{
				return g5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				g5 = value;
			}
		}

		internal virtual DataColumn DataColumn176
		{
			[CompilerGenerated]
			get
			{
				return g6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				g6 = value;
			}
		}

		internal virtual DataColumn DataColumn177
		{
			[CompilerGenerated]
			get
			{
				return g7;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				g7 = value;
			}
		}

		internal virtual DataColumn DataColumn178
		{
			[CompilerGenerated]
			get
			{
				return g8;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				g8 = value;
			}
		}

		internal virtual DataColumn DataColumn179
		{
			[CompilerGenerated]
			get
			{
				return g9;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				g9 = value;
			}
		}

		internal virtual DataColumn DataColumn180
		{
			[CompilerGenerated]
			get
			{
				return ha;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ha = value;
			}
		}

		internal virtual DataColumn DataColumn181
		{
			[CompilerGenerated]
			get
			{
				return hb;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				hb = value;
			}
		}

		internal virtual DataColumn DataColumn182
		{
			[CompilerGenerated]
			get
			{
				return hc;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				hc = value;
			}
		}

		internal virtual DataColumn DataColumn183
		{
			[CompilerGenerated]
			get
			{
				return hd;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				hd = value;
			}
		}

		internal virtual DataColumn DataColumn184
		{
			[CompilerGenerated]
			get
			{
				return he;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				he = value;
			}
		}

		internal virtual DataColumn DataColumn185
		{
			[CompilerGenerated]
			get
			{
				return hf;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				hf = value;
			}
		}

		internal virtual DataColumn DataColumn186
		{
			[CompilerGenerated]
			get
			{
				return hg;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				hg = value;
			}
		}

		internal virtual DataColumn DataColumn187
		{
			[CompilerGenerated]
			get
			{
				return hh;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				hh = value;
			}
		}

		internal virtual DataColumn DataColumn188
		{
			[CompilerGenerated]
			get
			{
				return hi;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				hi = value;
			}
		}

		internal virtual DataColumn DataColumn114
		{
			[CompilerGenerated]
			get
			{
				return hj;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				hj = value;
			}
		}

		internal virtual DataColumn DataColumn115
		{
			[CompilerGenerated]
			get
			{
				return hk;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				hk = value;
			}
		}

		internal virtual DataColumn DataColumn116
		{
			[CompilerGenerated]
			get
			{
				return hl;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				hl = value;
			}
		}

		internal virtual DataColumn DataColumn189
		{
			[CompilerGenerated]
			get
			{
				return hm;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				hm = value;
			}
		}

		internal virtual DataColumn DataColumn190
		{
			[CompilerGenerated]
			get
			{
				return hn;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				hn = value;
			}
		}

		internal virtual DataColumn DataColumn191
		{
			[CompilerGenerated]
			get
			{
				return ho;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ho = value;
			}
		}

		internal virtual DataColumn DataColumn192
		{
			[CompilerGenerated]
			get
			{
				return hp;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				hp = value;
			}
		}

		internal virtual DataColumn DataColumn193
		{
			[CompilerGenerated]
			get
			{
				return hq;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				hq = value;
			}
		}

		internal virtual DataColumn DataColumn194
		{
			[CompilerGenerated]
			get
			{
				return hr;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				hr = value;
			}
		}

		internal virtual DataColumn DataColumn195
		{
			[CompilerGenerated]
			get
			{
				return hs;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				hs = value;
			}
		}

		internal virtual DataColumn DataColumn196
		{
			[CompilerGenerated]
			get
			{
				return ht;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ht = value;
			}
		}

		internal virtual DataColumn DataColumn197
		{
			[CompilerGenerated]
			get
			{
				return hu;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				hu = value;
			}
		}

		internal virtual DataColumn DataColumn198
		{
			[CompilerGenerated]
			get
			{
				return hv;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				hv = value;
			}
		}

		internal virtual DataColumn DataColumn199
		{
			[CompilerGenerated]
			get
			{
				return hw;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				hw = value;
			}
		}

		internal virtual DataColumn DataColumn200
		{
			[CompilerGenerated]
			get
			{
				return hx;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				hx = value;
			}
		}

		internal virtual DataColumn DataColumn201
		{
			[CompilerGenerated]
			get
			{
				return hy;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				hy = value;
			}
		}

		internal virtual DataColumn DataColumn202
		{
			[CompilerGenerated]
			get
			{
				return hz;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				hz = value;
			}
		}

		internal virtual DataColumn DataColumn203
		{
			[CompilerGenerated]
			get
			{
				return h0;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				h0 = value;
			}
		}

		internal virtual DataColumn DataColumn204
		{
			[CompilerGenerated]
			get
			{
				return h1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				h1 = value;
			}
		}

		internal virtual DataColumn DataColumn205
		{
			[CompilerGenerated]
			get
			{
				return h2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				h2 = value;
			}
		}

		internal virtual DataColumn DataColumn206
		{
			[CompilerGenerated]
			get
			{
				return h3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				h3 = value;
			}
		}

		internal virtual DataColumn DataColumn207
		{
			[CompilerGenerated]
			get
			{
				return h4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				h4 = value;
			}
		}

		internal virtual DataColumn DataColumn208
		{
			[CompilerGenerated]
			get
			{
				return h5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				h5 = value;
			}
		}

		internal virtual DataColumn DataColumn209
		{
			[CompilerGenerated]
			get
			{
				return h6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				h6 = value;
			}
		}

		internal virtual DataColumn DataColumn210
		{
			[CompilerGenerated]
			get
			{
				return h7;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				h7 = value;
			}
		}

		internal virtual DataColumn DataColumn211
		{
			[CompilerGenerated]
			get
			{
				return h8;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				h8 = value;
			}
		}

		internal virtual DataColumn DataColumn212
		{
			[CompilerGenerated]
			get
			{
				return h9;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				h9 = value;
			}
		}

		internal virtual DataColumn DataColumn213
		{
			[CompilerGenerated]
			get
			{
				return ia;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ia = value;
			}
		}

		internal virtual DataColumn DataColumn214
		{
			[CompilerGenerated]
			get
			{
				return ib;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ib = value;
			}
		}

		internal virtual DataColumn DataColumn215
		{
			[CompilerGenerated]
			get
			{
				return ic;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ic = value;
			}
		}

		internal virtual DataColumn DataColumn216
		{
			[CompilerGenerated]
			get
			{
				return id;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				id = value;
			}
		}

		internal virtual DataColumn DataColumn217
		{
			[CompilerGenerated]
			get
			{
				return ie;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ie = value;
			}
		}

		internal virtual DataColumn DataColumn218
		{
			[CompilerGenerated]
			get
			{
				return ig;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ig = value;
			}
		}

		internal virtual DataColumn DataColumn219
		{
			[CompilerGenerated]
			get
			{
				return ih;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ih = value;
			}
		}

		internal virtual DataColumn DataColumn220
		{
			[CompilerGenerated]
			get
			{
				return ii;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ii = value;
			}
		}

		internal virtual DataColumn DataColumn221
		{
			[CompilerGenerated]
			get
			{
				return ij;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ij = value;
			}
		}

		internal virtual DataColumn DataColumn222
		{
			[CompilerGenerated]
			get
			{
				return ik;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ik = value;
			}
		}

		internal virtual DataColumn DataColumn223
		{
			[CompilerGenerated]
			get
			{
				return il;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				il = value;
			}
		}

		internal virtual DataColumn DataColumn224
		{
			[CompilerGenerated]
			get
			{
				return im;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				im = value;
			}
		}

		internal virtual DataColumn DataColumn225
		{
			[CompilerGenerated]
			get
			{
				return @in;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				@in = value;
			}
		}

		internal virtual DataColumn DataColumn226
		{
			[CompilerGenerated]
			get
			{
				return io;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				io = value;
			}
		}

		internal virtual DataColumn DataColumn227
		{
			[CompilerGenerated]
			get
			{
				return ip;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ip = value;
			}
		}

		internal virtual DataTable DataTable12
		{
			[CompilerGenerated]
			get
			{
				return iq;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				iq = value;
			}
		}

		internal virtual DataColumn DataColumn228
		{
			[CompilerGenerated]
			get
			{
				return ir;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ir = value;
			}
		}

		internal virtual DataColumn DataColumn229
		{
			[CompilerGenerated]
			get
			{
				return @is;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				@is = value;
			}
		}

		internal virtual DataColumn DataColumn230
		{
			[CompilerGenerated]
			get
			{
				return it;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				it = value;
			}
		}

		internal virtual ToolTip ToolTip_info
		{
			[CompilerGenerated]
			get
			{
				return iu;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				iu = value;
			}
		}

		internal virtual Panel Panel_PetSkillTurn
		{
			[CompilerGenerated]
			get
			{
				return iv;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				iv = value;
			}
		}

		internal virtual Panel Panel_CharSkillTurn
		{
			[CompilerGenerated]
			get
			{
				return iw;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				iw = value;
			}
		}

		internal virtual DataColumn DataColumn231
		{
			[CompilerGenerated]
			get
			{
				return ix;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ix = value;
			}
		}

		internal virtual Button btnLogin
		{
			[CompilerGenerated]
			get
			{
				return iy;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnLogin_Click;
				Button button = iy;
				if (button != null)
				{
					button.Click -= value2;
				}
				iy = value;
				button = iy;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual TextBox TBPassword
		{
			[CompilerGenerated]
			get
			{
				return iz;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = TextBox_PasswordOrClickMOD_TextChanged;
				TextBox textBox = iz;
				if (textBox != null)
				{
					textBox.TextChanged -= value2;
				}
				iz = value;
				textBox = iz;
				if (textBox != null)
				{
					textBox.TextChanged += value2;
				}
			}
		}

		internal virtual TextBox TBId
		{
			[CompilerGenerated]
			get
			{
				return i0;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyPressEventHandler value2 = NumericTextBox_KeyPress;
				EventHandler value3 = TextBox_NumericValue_TextChanged;
				TextBox textBox = i0;
				if (textBox != null)
				{
					textBox.KeyPress -= value2;
					textBox.TextChanged -= value3;
				}
				i0 = value;
				textBox = i0;
				if (textBox != null)
				{
					textBox.KeyPress += value2;
					textBox.TextChanged += value3;
				}
			}
		}

		internal virtual ComboBox ComboBox_Server
		{
			[CompilerGenerated]
			get
			{
				return i1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyPressEventHandler value2 = ComboBox_KeyPress_BlockInput;
				MouseEventHandler value3 = NoOpClickHandler;
				EventHandler value4 = ComboBox_Server_SelectedIndexChanged;
				EventHandler value5 = ComboBox_Server_DropDown;
				ComboBox comboBox = i1;
				if (comboBox != null)
				{
					comboBox.KeyPress -= value2;
					comboBox.MouseDown -= value3;
					comboBox.SelectedIndexChanged -= value4;
					comboBox.DropDown -= value5;
				}
				i1 = value;
				comboBox = i1;
				if (comboBox != null)
				{
					comboBox.KeyPress += value2;
					comboBox.MouseDown += value3;
					comboBox.SelectedIndexChanged += value4;
					comboBox.DropDown += value5;
				}
			}
		}

		internal virtual DataTable DataTable13
		{
			[CompilerGenerated]
			get
			{
				return i2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				i2 = value;
			}
		}

		internal virtual DataColumn DataColumn110
		{
			[CompilerGenerated]
			get
			{
				return i3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				i3 = value;
			}
		}

		internal virtual DataColumn DataColumn232
		{
			[CompilerGenerated]
			get
			{
				return i4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				i4 = value;
			}
		}

		internal virtual DataColumn DataColumn233
		{
			[CompilerGenerated]
			get
			{
				return i5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				i5 = value;
			}
		}

		internal virtual DataColumn DataColumn234
		{
			[CompilerGenerated]
			get
			{
				return i6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				i6 = value;
			}
		}

		internal virtual DataTable DataTable14
		{
			[CompilerGenerated]
			get
			{
				return i7;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				i7 = value;
			}
		}

		internal virtual DataColumn DataColumn235
		{
			[CompilerGenerated]
			get
			{
				return i8;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				i8 = value;
			}
		}

		internal virtual DataColumn DataColumn236
		{
			[CompilerGenerated]
			get
			{
				return i9;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				i9 = value;
			}
		}

		internal virtual DataColumn DataColumn237
		{
			[CompilerGenerated]
			get
			{
				return ja;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ja = value;
			}
		}

		internal virtual DataColumn DataColumn238
		{
			[CompilerGenerated]
			get
			{
				return jb;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				jb = value;
			}
		}

		internal virtual OpenFileDialog OpenFileDialog_setting
		{
			[CompilerGenerated]
			get
			{
				return jc;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				jc = value;
			}
		}

		internal virtual SaveFileDialog SaveFileDialog_setting
		{
			[CompilerGenerated]
			get
			{
				return jd;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				CancelEventHandler value2 = SaveFileDialog_setting_FileOk;
				SaveFileDialog saveFileDialog = jd;
				if (saveFileDialog != null)
				{
					saveFileDialog.FileOk -= value2;
				}
				jd = value;
				saveFileDialog = jd;
				if (saveFileDialog != null)
				{
					saveFileDialog.FileOk += value2;
				}
			}
		}

		internal virtual DataColumn DataColumn239
		{
			[CompilerGenerated]
			get
			{
				return je;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				je = value;
			}
		}

		internal virtual DataColumn DataColumn240
		{
			[CompilerGenerated]
			get
			{
				return jf;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				jf = value;
			}
		}

		internal virtual GroupBox GroupBox_Basic
		{
			[CompilerGenerated]
			get
			{
				return jg;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				jg = value;
			}
		}

		internal virtual GroupBox GroupBox_disconnect
		{
			[CompilerGenerated]
			get
			{
				return jh;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				jh = value;
			}
		}

		internal virtual CheckBox CheckBox_OpenMachine
		{
			[CompilerGenerated]
			get
			{
				return ji;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Settings_CheckedChanged;
				CheckBox checkBox = ji;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				ji = value;
				checkBox = ji;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		internal virtual CheckBox CheckBox_ClearGhost
		{
			[CompilerGenerated]
			get
			{
				return jj;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Settings_CheckedChanged;
				CheckBox checkBox = jj;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				jj = value;
				checkBox = jj;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		internal virtual CheckBox CheckBox_Reconnect
		{
			[CompilerGenerated]
			get
			{
				return jk;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Settings_CheckedChanged;
				CheckBox checkBox = jk;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				jk = value;
				checkBox = jk;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		internal virtual RadioButton RadioButton_DCmemout
		{
			[CompilerGenerated]
			get
			{
				return jl;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Settings_CheckedChanged;
				RadioButton radioButton = jl;
				if (radioButton != null)
				{
					radioButton.CheckedChanged -= value2;
				}
				jl = value;
				radioButton = jl;
				if (radioButton != null)
				{
					radioButton.CheckedChanged += value2;
				}
			}
		}

		internal virtual RadioButton RadioButton_DCLeaderOut
		{
			[CompilerGenerated]
			get
			{
				return jm;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Settings_CheckedChanged;
				RadioButton radioButton = jm;
				if (radioButton != null)
				{
					radioButton.CheckedChanged -= value2;
				}
				jm = value;
				radioButton = jm;
				if (radioButton != null)
				{
					radioButton.CheckedChanged += value2;
				}
			}
		}

		internal virtual CheckBox CheckBox_DCAfter1MinNoBattle
		{
			[CompilerGenerated]
			get
			{
				return jn;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Settings_CheckedChanged;
				CheckBox checkBox = jn;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				jn = value;
				checkBox = jn;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		internal virtual RadioButton RadioButton_MemberRequestParty
		{
			[CompilerGenerated]
			get
			{
				return jo;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Settings_CheckedChanged;
				RadioButton radioButton = jo;
				if (radioButton != null)
				{
					radioButton.CheckedChanged -= value2;
				}
				jo = value;
				radioButton = jo;
				if (radioButton != null)
				{
					radioButton.CheckedChanged += value2;
				}
			}
		}

		internal virtual RadioButton RadioButton_LeaderRequestParty
		{
			[CompilerGenerated]
			get
			{
				return jp;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Settings_CheckedChanged;
				RadioButton radioButton = jp;
				if (radioButton != null)
				{
					radioButton.CheckedChanged -= value2;
				}
				jp = value;
				radioButton = jp;
				if (radioButton != null)
				{
					radioButton.CheckedChanged += value2;
				}
			}
		}

		internal virtual GroupBox GroupBox2
		{
			[CompilerGenerated]
			get
			{
				return jq;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				jq = value;
			}
		}

		internal virtual Label Label32
		{
			[CompilerGenerated]
			get
			{
				return jr;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				jr = value;
			}
		}

		internal virtual Label Label25
		{
			[CompilerGenerated]
			get
			{
				return js;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				js = value;
			}
		}

		internal virtual Label Label23
		{
			[CompilerGenerated]
			get
			{
				return jt;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				jt = value;
			}
		}

		internal virtual TextBox TextBox_TL_char_sp_value
		{
			[CompilerGenerated]
			get
			{
				return ju;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ju = value;
			}
		}

		internal virtual Label Label22
		{
			[CompilerGenerated]
			get
			{
				return jv;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				jv = value;
			}
		}

		internal virtual TextBox TextBox_TL_char_hp_value
		{
			[CompilerGenerated]
			get
			{
				return jw;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				jw = value;
			}
		}

		internal virtual Label Label21
		{
			[CompilerGenerated]
			get
			{
				return jx;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				jx = value;
			}
		}

		internal virtual TextBox TextBox_Eat_char_sp_value
		{
			[CompilerGenerated]
			get
			{
				return jy;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyPressEventHandler value2 = NumericTextBox_KeyPress;
				EventHandler value3 = TextBox_NumericValue_TextChanged;
				TextBox textBox = jy;
				if (textBox != null)
				{
					textBox.KeyPress -= value2;
					textBox.TextChanged -= value3;
				}
				jy = value;
				textBox = jy;
				if (textBox != null)
				{
					textBox.KeyPress += value2;
					textBox.TextChanged += value3;
				}
			}
		}

		internal virtual Label Label20
		{
			[CompilerGenerated]
			get
			{
				return jz;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				jz = value;
			}
		}

		internal virtual TextBox TextBox_Eat_char_hp_value
		{
			[CompilerGenerated]
			get
			{
				return j0;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyPressEventHandler value2 = NumericTextBox_KeyPress;
				EventHandler value3 = TextBox_NumericValue_TextChanged;
				TextBox textBox = j0;
				if (textBox != null)
				{
					textBox.KeyPress -= value2;
					textBox.TextChanged -= value3;
				}
				j0 = value;
				textBox = j0;
				if (textBox != null)
				{
					textBox.KeyPress += value2;
					textBox.TextChanged += value3;
				}
			}
		}

		internal virtual Label Label7
		{
			[CompilerGenerated]
			get
			{
				return j1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				j1 = value;
			}
		}

		internal virtual Label Label5
		{
			[CompilerGenerated]
			get
			{
				return j2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				j2 = value;
			}
		}

		internal virtual CheckBox CheckBox_TL_mem1
		{
			[CompilerGenerated]
			get
			{
				return j3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Settings_CheckedChanged;
				CheckBox checkBox = j3;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				j3 = value;
				checkBox = j3;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		internal virtual CheckBox CheckBox_TL_mem4
		{
			[CompilerGenerated]
			get
			{
				return j4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Settings_CheckedChanged;
				CheckBox checkBox = j4;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				j4 = value;
				checkBox = j4;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		internal virtual CheckBox CheckBox_TL_mem3
		{
			[CompilerGenerated]
			get
			{
				return j5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Settings_CheckedChanged;
				CheckBox checkBox = j5;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				j5 = value;
				checkBox = j5;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		internal virtual CheckBox CheckBox_TL_mem2
		{
			[CompilerGenerated]
			get
			{
				return j6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Settings_CheckedChanged;
				CheckBox checkBox = j6;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				j6 = value;
				checkBox = j6;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		internal virtual CheckBox CheckBox_AutoCreatCharacter
		{
			[CompilerGenerated]
			get
			{
				return j7;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Settings_CheckedChanged;
				CheckBox checkBox = j7;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				j7 = value;
				checkBox = j7;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		internal virtual DataColumn DataColumn241
		{
			[CompilerGenerated]
			get
			{
				return j8;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				j8 = value;
			}
		}

		internal virtual DataColumn DataColumn242
		{
			[CompilerGenerated]
			get
			{
				return j9;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				j9 = value;
			}
		}

		internal virtual CheckBox CheckBox_TL_pet2
		{
			[CompilerGenerated]
			get
			{
				return ka;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Settings_CheckedChanged;
				CheckBox checkBox = ka;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				ka = value;
				checkBox = ka;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		internal virtual CheckBox CheckBox_TL_pet1
		{
			[CompilerGenerated]
			get
			{
				return kb;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Settings_CheckedChanged;
				CheckBox checkBox = kb;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				kb = value;
				checkBox = kb;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		internal virtual Vs2010TabControl TabControl1
		{
			[CompilerGenerated]
			get
			{
				return kc;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				kc = value;
			}
		}

		internal virtual TabPage TabPage7
		{
			[CompilerGenerated]
			get
			{
				return kd;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				kd = value;
			}
		}

		internal virtual TabPage TabPage8
		{
			[CompilerGenerated]
			get
			{
				return ke;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ke = value;
			}
		}

		internal virtual TabPage TabPage9
		{
			[CompilerGenerated]
			get
			{
				return kf;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				kf = value;
			}
		}

		internal virtual Label Label33
		{
			[CompilerGenerated]
			get
			{
				return kg;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				kg = value;
			}
		}

		internal virtual Label Label34
		{
			[CompilerGenerated]
			get
			{
				return kh;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				kh = value;
			}
		}

		internal virtual TextBox TextBox_TL_pet_sp_value
		{
			[CompilerGenerated]
			get
			{
				return ki;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = TextBox_NumericValue_TextChanged;
				TextBox textBox = ki;
				if (textBox != null)
				{
					textBox.TextChanged -= value2;
				}
				ki = value;
				textBox = ki;
				if (textBox != null)
				{
					textBox.TextChanged += value2;
				}
			}
		}

		internal virtual Label Label35
		{
			[CompilerGenerated]
			get
			{
				return kj;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				kj = value;
			}
		}

		internal virtual Label Label36
		{
			[CompilerGenerated]
			get
			{
				return kk;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				kk = value;
			}
		}

		internal virtual TextBox TextBox_TL_pet_hp_value
		{
			[CompilerGenerated]
			get
			{
				return kl;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = TextBox_NumericValue_TextChanged;
				TextBox textBox = kl;
				if (textBox != null)
				{
					textBox.TextChanged -= value2;
				}
				kl = value;
				textBox = kl;
				if (textBox != null)
				{
					textBox.TextChanged += value2;
				}
			}
		}

		internal virtual GroupBox GroupBox3
		{
			[CompilerGenerated]
			get
			{
				return km;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				km = value;
			}
		}

		internal virtual Label Label43
		{
			[CompilerGenerated]
			get
			{
				return kn;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				kn = value;
			}
		}

		internal virtual TextBox TextBox_Eat_pet_sp_value
		{
			[CompilerGenerated]
			get
			{
				return ko;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyPressEventHandler value2 = NumericTextBox_KeyPress;
				EventHandler value3 = TextBox_NumericValue_TextChanged;
				TextBox textBox = ko;
				if (textBox != null)
				{
					textBox.KeyPress -= value2;
					textBox.TextChanged -= value3;
				}
				ko = value;
				textBox = ko;
				if (textBox != null)
				{
					textBox.KeyPress += value2;
					textBox.TextChanged += value3;
				}
			}
		}

		internal virtual Label Label44
		{
			[CompilerGenerated]
			get
			{
				return kp;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				kp = value;
			}
		}

		internal virtual TextBox TextBox_Eat_pet_hp_value
		{
			[CompilerGenerated]
			get
			{
				return kq;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyPressEventHandler value2 = NumericTextBox_KeyPress;
				EventHandler value3 = TextBox_NumericValue_TextChanged;
				TextBox textBox = kq;
				if (textBox != null)
				{
					textBox.KeyPress -= value2;
					textBox.TextChanged -= value3;
				}
				kq = value;
				textBox = kq;
				if (textBox != null)
				{
					textBox.KeyPress += value2;
					textBox.TextChanged += value3;
				}
			}
		}

		internal virtual Label Label45
		{
			[CompilerGenerated]
			get
			{
				return kr;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				kr = value;
			}
		}

		internal virtual Label Label46
		{
			[CompilerGenerated]
			get
			{
				return ks;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ks = value;
			}
		}

		internal virtual RadioButton RadioButton_PT_no
		{
			[CompilerGenerated]
			get
			{
				return kt;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Settings_CheckedChanged;
				RadioButton radioButton = kt;
				if (radioButton != null)
				{
					radioButton.CheckedChanged -= value2;
				}
				kt = value;
				radioButton = kt;
				if (radioButton != null)
				{
					radioButton.CheckedChanged += value2;
				}
			}
		}

		internal virtual RadioButton RadioButton_DC_no
		{
			[CompilerGenerated]
			get
			{
				return ku;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Settings_CheckedChanged;
				RadioButton radioButton = ku;
				if (radioButton != null)
				{
					radioButton.CheckedChanged -= value2;
				}
				ku = value;
				radioButton = ku;
				if (radioButton != null)
				{
					radioButton.CheckedChanged += value2;
				}
			}
		}

		internal virtual ComboBox ComboBox_CharLocation
		{
			[CompilerGenerated]
			get
			{
				return kv;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyPressEventHandler value2 = ComboBox_KeyPress_BlockInput;
				MouseEventHandler value3 = NoOpClickHandler;
				EventHandler value4 = ComboBox_CharLocation_SelectedIndexChanged;
				ComboBox comboBox = kv;
				if (comboBox != null)
				{
					comboBox.KeyPress -= value2;
					comboBox.MouseDown -= value3;
					comboBox.SelectedIndexChanged -= value4;
				}
				kv = value;
				comboBox = kv;
				if (comboBox != null)
				{
					comboBox.KeyPress += value2;
					comboBox.MouseDown += value3;
					comboBox.SelectedIndexChanged += value4;
				}
			}
		}

		internal virtual Label Label47
		{
			[CompilerGenerated]
			get
			{
				return kw;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				kw = value;
			}
		}

		internal virtual Label Label48
		{
			[CompilerGenerated]
			get
			{
				return kx;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				kx = value;
			}
		}

		internal virtual ComboBox ComboBox_PetLocation
		{
			[CompilerGenerated]
			get
			{
				return ky;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyPressEventHandler value2 = ComboBox_KeyPress_BlockInput;
				MouseEventHandler value3 = NoOpClickHandler;
				EventHandler value4 = ComboBox_PetLocation_SelectedIndexChanged;
				ComboBox comboBox = ky;
				if (comboBox != null)
				{
					comboBox.KeyPress -= value2;
					comboBox.MouseDown -= value3;
					comboBox.TextChanged -= value4;
				}
				ky = value;
				comboBox = ky;
				if (comboBox != null)
				{
					comboBox.KeyPress += value2;
					comboBox.MouseDown += value3;
					comboBox.TextChanged += value4;
				}
			}
		}

		internal virtual Label Label49
		{
			[CompilerGenerated]
			get
			{
				return kz;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				kz = value;
			}
		}

		internal virtual Label Label50
		{
			[CompilerGenerated]
			get
			{
				return k0;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				k0 = value;
			}
		}

		internal virtual DataColumn DataColumn243
		{
			[CompilerGenerated]
			get
			{
				return k1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				k1 = value;
			}
		}

		internal virtual DataColumn DataColumn244
		{
			[CompilerGenerated]
			get
			{
				return k2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				k2 = value;
			}
		}

		internal virtual DataColumn DataColumn245
		{
			[CompilerGenerated]
			get
			{
				return k3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				k3 = value;
			}
		}

		internal virtual DataColumn DataColumn246
		{
			[CompilerGenerated]
			get
			{
				return k4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				k4 = value;
			}
		}

		internal virtual DataColumn DataColumn247
		{
			[CompilerGenerated]
			get
			{
				return k5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				k5 = value;
			}
		}

		internal virtual ContextMenuStrip ContextMenuStrip_ToTuido
		{
			[CompilerGenerated]
			get
			{
				return k6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				k6 = value;
			}
		}

		internal virtual ToolStripMenuItem ToolStripMenuItem_ToTuiDeo
		{
			[CompilerGenerated]
			get
			{
				return k7;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = MenuItem_HomdoAction_Click;
				ToolStripMenuItem toolStripMenuItem = k7;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				k7 = value;
				toolStripMenuItem = k7;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ContextMenuStrip ContextMenuStrip_ToTuideo
		{
			[CompilerGenerated]
			get
			{
				return k8;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				k8 = value;
			}
		}

		internal virtual ToolStripMenuItem ToolStripMenuItem_ToTuiDo
		{
			[CompilerGenerated]
			get
			{
				return k9;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = MenuItem_TuideoAction_Click;
				ToolStripMenuItem toolStripMenuItem = k9;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				k9 = value;
				toolStripMenuItem = k9;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual NumericUpDown NumericUpDown_ItemCountPickup
		{
			[CompilerGenerated]
			get
			{
				return la;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = TextBox_NumericValue_TextChanged;
				NumericUpDown numericUpDown = la;
				if (numericUpDown != null)
				{
					numericUpDown.TextChanged -= value2;
				}
				la = value;
				numericUpDown = la;
				if (numericUpDown != null)
				{
					numericUpDown.TextChanged += value2;
				}
			}
		}

		internal virtual CheckBox CheckBox_AutoPickup
		{
			[CompilerGenerated]
			get
			{
				return lb;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Settings_CheckedChanged;
				CheckBox checkBox = lb;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				lb = value;
				checkBox = lb;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		internal virtual DataTable DataTable15
		{
			[CompilerGenerated]
			get
			{
				return lc;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				lc = value;
			}
		}

		internal virtual DataColumn DataColumn248
		{
			[CompilerGenerated]
			get
			{
				return ld;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ld = value;
			}
		}

		internal virtual Label Label52
		{
			[CompilerGenerated]
			get
			{
				return le;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				le = value;
			}
		}

		internal virtual Label Label_CharTurnCount
		{
			[CompilerGenerated]
			get
			{
				return lf;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				lf = value;
			}
		}

		internal virtual Label Label53
		{
			[CompilerGenerated]
			get
			{
				return lg;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				lg = value;
			}
		}

		internal virtual Button Button_CharTurnRemove
		{
			[CompilerGenerated]
			get
			{
				return lh;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button_CharTurn_Click;
				Button button = lh;
				if (button != null)
				{
					button.Click -= value2;
				}
				lh = value;
				button = lh;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual Button Button_CharTurnAdd
		{
			[CompilerGenerated]
			get
			{
				return li;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button_CharTurn_Click;
				Button button = li;
				if (button != null)
				{
					button.Click -= value2;
				}
				li = value;
				button = li;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual DataColumn DataColumn249
		{
			[CompilerGenerated]
			get
			{
				return lj;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				lj = value;
			}
		}

		internal virtual DataColumn DataColumn250
		{
			[CompilerGenerated]
			get
			{
				return lk;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				lk = value;
			}
		}

		internal virtual DataColumn DataColumn251
		{
			[CompilerGenerated]
			get
			{
				return ll;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ll = value;
			}
		}

		internal virtual DataColumn DataColumn252
		{
			[CompilerGenerated]
			get
			{
				return lm;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				lm = value;
			}
		}

		internal virtual DataColumn DataColumn253
		{
			[CompilerGenerated]
			get
			{
				return ln;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ln = value;
			}
		}

		internal virtual DataColumn DataColumn254
		{
			[CompilerGenerated]
			get
			{
				return lo;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				lo = value;
			}
		}

		internal virtual DataColumn DataColumn255
		{
			[CompilerGenerated]
			get
			{
				return lp;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				lp = value;
			}
		}

		internal virtual DataColumn DataColumn256
		{
			[CompilerGenerated]
			get
			{
				return lq;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				lq = value;
			}
		}

		internal virtual DataColumn DataColumn257
		{
			[CompilerGenerated]
			get
			{
				return lr;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				lr = value;
			}
		}

		internal virtual DataColumn DataColumn258
		{
			[CompilerGenerated]
			get
			{
				return ls;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ls = value;
			}
		}

		internal virtual DataColumn DataColumn259
		{
			[CompilerGenerated]
			get
			{
				return lt;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				lt = value;
			}
		}

		internal virtual DataColumn DataColumn260
		{
			[CompilerGenerated]
			get
			{
				return lu;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				lu = value;
			}
		}

		internal virtual DataColumn DataColumn261
		{
			[CompilerGenerated]
			get
			{
				return lv;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				lv = value;
			}
		}

		internal virtual DataColumn DataColumn262
		{
			[CompilerGenerated]
			get
			{
				return lw;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				lw = value;
			}
		}

		internal virtual DataColumn DataColumn263
		{
			[CompilerGenerated]
			get
			{
				return lx;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				lx = value;
			}
		}

		internal virtual DataColumn DataColumn264
		{
			[CompilerGenerated]
			get
			{
				return ly;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ly = value;
			}
		}

		internal virtual DataColumn DataColumn265
		{
			[CompilerGenerated]
			get
			{
				return lz;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				lz = value;
			}
		}

		internal virtual DataColumn DataColumn266
		{
			[CompilerGenerated]
			get
			{
				return l0;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				l0 = value;
			}
		}

		internal virtual DataColumn DataColumn267
		{
			[CompilerGenerated]
			get
			{
				return l1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				l1 = value;
			}
		}

		internal virtual DataColumn DataColumn268
		{
			[CompilerGenerated]
			get
			{
				return l2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				l2 = value;
			}
		}

		internal virtual DataColumn DataColumn269
		{
			[CompilerGenerated]
			get
			{
				return l3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				l3 = value;
			}
		}

		internal virtual DataColumn DataColumn270
		{
			[CompilerGenerated]
			get
			{
				return l4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				l4 = value;
			}
		}

		internal virtual DataColumn DataColumn271
		{
			[CompilerGenerated]
			get
			{
				return l5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				l5 = value;
			}
		}

		internal virtual DataColumn DataColumn272
		{
			[CompilerGenerated]
			get
			{
				return l6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				l6 = value;
			}
		}

		internal virtual DataColumn DataColumn273
		{
			[CompilerGenerated]
			get
			{
				return l7;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				l7 = value;
			}
		}

		internal virtual DataColumn DataColumn274
		{
			[CompilerGenerated]
			get
			{
				return l8;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				l8 = value;
			}
		}

		internal virtual DataColumn DataColumn275
		{
			[CompilerGenerated]
			get
			{
				return l9;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				l9 = value;
			}
		}

		internal virtual DataColumn DataColumn276
		{
			[CompilerGenerated]
			get
			{
				return ma;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ma = value;
			}
		}

		internal virtual DataColumn DataColumn277
		{
			[CompilerGenerated]
			get
			{
				return mb;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				mb = value;
			}
		}

		internal virtual DataColumn DataColumn278
		{
			[CompilerGenerated]
			get
			{
				return mc;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				mc = value;
			}
		}

		internal virtual DataColumn DataColumn279
		{
			[CompilerGenerated]
			get
			{
				return md;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				md = value;
			}
		}

		internal virtual DataColumn DataColumn280
		{
			[CompilerGenerated]
			get
			{
				return me;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				me = value;
			}
		}

		internal virtual DataColumn DataColumn281
		{
			[CompilerGenerated]
			get
			{
				return mf;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				mf = value;
			}
		}

		internal virtual DataColumn DataColumn282
		{
			[CompilerGenerated]
			get
			{
				return mg;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				mg = value;
			}
		}

		internal virtual DataColumn DataColumn283
		{
			[CompilerGenerated]
			get
			{
				return mh;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				mh = value;
			}
		}

		internal virtual DataColumn DataColumn284
		{
			[CompilerGenerated]
			get
			{
				return mi;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				mi = value;
			}
		}

		internal virtual DataColumn DataColumn285
		{
			[CompilerGenerated]
			get
			{
				return mj;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				mj = value;
			}
		}

		internal virtual DataColumn DataColumn286
		{
			[CompilerGenerated]
			get
			{
				return mk;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				mk = value;
			}
		}

		internal virtual DataColumn DataColumn287
		{
			[CompilerGenerated]
			get
			{
				return ml;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ml = value;
			}
		}

		internal virtual DataColumn DataColumn288
		{
			[CompilerGenerated]
			get
			{
				return mm;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				mm = value;
			}
		}

		internal virtual DataColumn DataColumn289
		{
			[CompilerGenerated]
			get
			{
				return mn;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				mn = value;
			}
		}

		internal virtual ComboBox ComboBox_CharTurnSetting
		{
			[CompilerGenerated]
			get
			{
				return mo;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyPressEventHandler value2 = ComboBox_KeyPress_BlockInput;
				MouseEventHandler value3 = NoOpClickHandler;
				EventHandler value4 = ComboBox_CharTurnSetting_SelectedIndexChanged;
				ComboBox comboBox = mo;
				if (comboBox != null)
				{
					comboBox.KeyPress -= value2;
					comboBox.MouseDown -= value3;
					comboBox.SelectedIndexChanged -= value4;
				}
				mo = value;
				comboBox = mo;
				if (comboBox != null)
				{
					comboBox.KeyPress += value2;
					comboBox.MouseDown += value3;
					comboBox.SelectedIndexChanged += value4;
				}
			}
		}

		internal virtual ComboBox ComboBox_PetTurnSetting
		{
			[CompilerGenerated]
			get
			{
				return mp;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyPressEventHandler value2 = ComboBox_KeyPress_BlockInput;
				MouseEventHandler value3 = NoOpClickHandler;
				EventHandler value4 = ComboBox_PetTurnSetting_SelectedIndexChanged;
				ComboBox comboBox = mp;
				if (comboBox != null)
				{
					comboBox.KeyPress -= value2;
					comboBox.MouseDown -= value3;
					comboBox.SelectedIndexChanged -= value4;
				}
				mp = value;
				comboBox = mp;
				if (comboBox != null)
				{
					comboBox.KeyPress += value2;
					comboBox.MouseDown += value3;
					comboBox.SelectedIndexChanged += value4;
				}
			}
		}

		internal virtual Label Label54
		{
			[CompilerGenerated]
			get
			{
				return mq;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				mq = value;
			}
		}

		internal virtual Label Label_PetTurnCount
		{
			[CompilerGenerated]
			get
			{
				return mr;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				mr = value;
			}
		}

		internal virtual Label Label62
		{
			[CompilerGenerated]
			get
			{
				return ms;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ms = value;
			}
		}

		internal virtual Button Button_PetTurnRemove
		{
			[CompilerGenerated]
			get
			{
				return mt;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button_PetTurn_Click;
				Button button = mt;
				if (button != null)
				{
					button.Click -= value2;
				}
				mt = value;
				button = mt;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual Button Button_PetTurnAdd
		{
			[CompilerGenerated]
			get
			{
				return mu;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button_PetTurn_Click;
				Button button = mu;
				if (button != null)
				{
					button.Click -= value2;
				}
				mu = value;
				button = mu;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual RichTextBox RichTextBox_hienthiquest
		{
			[CompilerGenerated]
			get
			{
				return mv;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				mv = value;
			}
		}

		internal virtual GroupBox GroupBox7
		{
			[CompilerGenerated]
			get
			{
				return mw;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				mw = value;
			}
		}

		internal virtual GroupBox GroupBox6
		{
			[CompilerGenerated]
			get
			{
				return mx;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				mx = value;
			}
		}

		internal virtual GroupBox GroupBox5
		{
			[CompilerGenerated]
			get
			{
				return my;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				my = value;
			}
		}

		internal virtual GroupBox GroupBox4
		{
			[CompilerGenerated]
			get
			{
				return mz;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				mz = value;
			}
		}

		internal virtual DataTable DataTable16
		{
			[CompilerGenerated]
			get
			{
				return m0;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				m0 = value;
			}
		}

		internal virtual DataColumn DataColumn290
		{
			[CompilerGenerated]
			get
			{
				return m1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				m1 = value;
			}
		}

		internal virtual DataColumn DataColumn291
		{
			[CompilerGenerated]
			get
			{
				return m2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				m2 = value;
			}
		}

		internal virtual DataTable DataTable17
		{
			[CompilerGenerated]
			get
			{
				return m3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				m3 = value;
			}
		}

		internal virtual DataColumn DataColumn292
		{
			[CompilerGenerated]
			get
			{
				return m4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				m4 = value;
			}
		}

		internal virtual DataColumn DataColumn293
		{
			[CompilerGenerated]
			get
			{
				return m5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				m5 = value;
			}
		}

		internal virtual DataTable DataTable18
		{
			[CompilerGenerated]
			get
			{
				return m6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				m6 = value;
			}
		}

		internal virtual DataColumn DataColumn294
		{
			[CompilerGenerated]
			get
			{
				return m7;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				m7 = value;
			}
		}

		internal virtual DataColumn DataColumn295
		{
			[CompilerGenerated]
			get
			{
				return m8;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				m8 = value;
			}
		}

		internal virtual TabControl TabControl_ItemSetting
		{
			[CompilerGenerated]
			get
			{
				return m9;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				m9 = value;
			}
		}

		internal virtual TabPage TabPage11
		{
			[CompilerGenerated]
			get
			{
				return na;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				na = value;
			}
		}

		internal virtual TabPage TabPage12
		{
			[CompilerGenerated]
			get
			{
				return nb;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				nb = value;
			}
		}

		internal virtual Label Label63
		{
			[CompilerGenerated]
			get
			{
				return nc;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				nc = value;
			}
		}

		internal virtual TextBox TextBox_Drop_SpValue
		{
			[CompilerGenerated]
			get
			{
				return nd;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyPressEventHandler value2 = NumericTextBox_KeyPress;
				EventHandler value3 = TextBox_NumericValue_TextChanged;
				TextBox textBox = nd;
				if (textBox != null)
				{
					textBox.KeyPress -= value2;
					textBox.TextChanged -= value3;
				}
				nd = value;
				textBox = nd;
				if (textBox != null)
				{
					textBox.KeyPress += value2;
					textBox.TextChanged += value3;
				}
			}
		}

		internal virtual Label Label61
		{
			[CompilerGenerated]
			get
			{
				return ne;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ne = value;
			}
		}

		internal virtual TextBox TextBox_Drop_HpValue
		{
			[CompilerGenerated]
			get
			{
				return nf;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyPressEventHandler value2 = NumericTextBox_KeyPress;
				EventHandler value3 = TextBox_NumericValue_TextChanged;
				TextBox textBox = nf;
				if (textBox != null)
				{
					textBox.KeyPress -= value2;
					textBox.TextChanged -= value3;
				}
				nf = value;
				textBox = nf;
				if (textBox != null)
				{
					textBox.KeyPress += value2;
					textBox.TextChanged += value3;
				}
			}
		}

		internal virtual CheckBox CheckBox_DropHpSp
		{
			[CompilerGenerated]
			get
			{
				return ng;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Settings_CheckedChanged;
				CheckBox checkBox = ng;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				ng = value;
				checkBox = ng;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		internal virtual CheckBox CheckBox_DropSp
		{
			[CompilerGenerated]
			get
			{
				return nh;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Settings_CheckedChanged;
				CheckBox checkBox = nh;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				nh = value;
				checkBox = nh;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		internal virtual CheckBox CheckBox_DropHp
		{
			[CompilerGenerated]
			get
			{
				return ni;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Settings_CheckedChanged;
				CheckBox checkBox = ni;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				ni = value;
				checkBox = ni;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		internal virtual Button Button_AddIdDrop
		{
			[CompilerGenerated]
			get
			{
				return nj;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button_AddIdDrop_Click;
				Button button = nj;
				if (button != null)
				{
					button.Click -= value2;
				}
				nj = value;
				button = nj;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual TextBox TextBox_AddIdDrop
		{
			[CompilerGenerated]
			get
			{
				return nk;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyPressEventHandler value2 = NumericTextBox_KeyPress;
				TextBox textBox = nk;
				if (textBox != null)
				{
					textBox.KeyPress -= value2;
				}
				nk = value;
				textBox = nk;
				if (textBox != null)
				{
					textBox.KeyPress += value2;
				}
			}
		}

		internal virtual CheckBox CheckBox_ContributeHpSp
		{
			[CompilerGenerated]
			get
			{
				return nl;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Settings_CheckedChanged;
				CheckBox checkBox = nl;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				nl = value;
				checkBox = nl;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		internal virtual CheckBox CheckBox_ContributeSp
		{
			[CompilerGenerated]
			get
			{
				return nm;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Settings_CheckedChanged;
				CheckBox checkBox = nm;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				nm = value;
				checkBox = nm;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		internal virtual CheckBox CheckBox_ContributeHp
		{
			[CompilerGenerated]
			get
			{
				return nn;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Settings_CheckedChanged;
				CheckBox checkBox = nn;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				nn = value;
				checkBox = nn;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		internal virtual Label Label64
		{
			[CompilerGenerated]
			get
			{
				return no;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				no = value;
			}
		}

		internal virtual TextBox TextBox_Contribute_SpValue
		{
			[CompilerGenerated]
			get
			{
				return np;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyPressEventHandler value2 = NumericTextBox_KeyPress;
				EventHandler value3 = TextBox_NumericValue_TextChanged;
				TextBox textBox = np;
				if (textBox != null)
				{
					textBox.KeyPress -= value2;
					textBox.TextChanged -= value3;
				}
				np = value;
				textBox = np;
				if (textBox != null)
				{
					textBox.KeyPress += value2;
					textBox.TextChanged += value3;
				}
			}
		}

		internal virtual Label Label65
		{
			[CompilerGenerated]
			get
			{
				return nq;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				nq = value;
			}
		}

		internal virtual TextBox TextBox_Contribute_HpValue
		{
			[CompilerGenerated]
			get
			{
				return nr;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyPressEventHandler value2 = NumericTextBox_KeyPress;
				EventHandler value3 = TextBox_NumericValue_TextChanged;
				TextBox textBox = nr;
				if (textBox != null)
				{
					textBox.KeyPress -= value2;
					textBox.TextChanged -= value3;
				}
				nr = value;
				textBox = nr;
				if (textBox != null)
				{
					textBox.KeyPress += value2;
					textBox.TextChanged += value3;
				}
			}
		}

		internal virtual Button Button_AddIdContribute
		{
			[CompilerGenerated]
			get
			{
				return ns;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button_AddIdContribute_Click;
				Button button = ns;
				if (button != null)
				{
					button.Click -= value2;
				}
				ns = value;
				button = ns;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual TextBox TextBox_AddIdContribute
		{
			[CompilerGenerated]
			get
			{
				return nt;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyPressEventHandler value2 = NumericTextBox_KeyPress;
				TextBox textBox = nt;
				if (textBox != null)
				{
					textBox.KeyPress -= value2;
				}
				nt = value;
				textBox = nt;
				if (textBox != null)
				{
					textBox.KeyPress += value2;
				}
			}
		}

		internal virtual Button Button_AddIdSend
		{
			[CompilerGenerated]
			get
			{
				return nu;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button_AddIdSend_Click;
				Button button = nu;
				if (button != null)
				{
					button.Click -= value2;
				}
				nu = value;
				button = nu;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual TextBox TextBox_AddIdSend
		{
			[CompilerGenerated]
			get
			{
				return nv;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyPressEventHandler value2 = NumericTextBox_KeyPress;
				TextBox textBox = nv;
				if (textBox != null)
				{
					textBox.KeyPress -= value2;
				}
				nv = value;
				textBox = nv;
				if (textBox != null)
				{
					textBox.KeyPress += value2;
				}
			}
		}

		internal virtual CheckBox CheckBox_SendHpSp
		{
			[CompilerGenerated]
			get
			{
				return nw;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Settings_CheckedChanged;
				CheckBox checkBox = nw;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				nw = value;
				checkBox = nw;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		internal virtual CheckBox CheckBox_SendSp
		{
			[CompilerGenerated]
			get
			{
				return nx;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Settings_CheckedChanged;
				CheckBox checkBox = nx;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				nx = value;
				checkBox = nx;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		internal virtual CheckBox CheckBox_SendHp
		{
			[CompilerGenerated]
			get
			{
				return ny;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Settings_CheckedChanged;
				CheckBox checkBox = ny;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				ny = value;
				checkBox = ny;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		internal virtual Label Label72
		{
			[CompilerGenerated]
			get
			{
				return nz;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				nz = value;
			}
		}

		internal virtual TextBox TextBox_Send_SpValue
		{
			[CompilerGenerated]
			get
			{
				return n0;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyPressEventHandler value2 = NumericTextBox_KeyPress;
				EventHandler value3 = TextBox_NumericValue_TextChanged;
				TextBox textBox = n0;
				if (textBox != null)
				{
					textBox.KeyPress -= value2;
					textBox.TextChanged -= value3;
				}
				n0 = value;
				textBox = n0;
				if (textBox != null)
				{
					textBox.KeyPress += value2;
					textBox.TextChanged += value3;
				}
			}
		}

		internal virtual Label Label73
		{
			[CompilerGenerated]
			get
			{
				return n1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				n1 = value;
			}
		}

		internal virtual TextBox TextBox_Send_HpValue
		{
			[CompilerGenerated]
			get
			{
				return n2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyPressEventHandler value2 = NumericTextBox_KeyPress;
				EventHandler value3 = TextBox_NumericValue_TextChanged;
				TextBox textBox = n2;
				if (textBox != null)
				{
					textBox.KeyPress -= value2;
					textBox.TextChanged -= value3;
				}
				n2 = value;
				textBox = n2;
				if (textBox != null)
				{
					textBox.KeyPress += value2;
					textBox.TextChanged += value3;
				}
			}
		}

		internal virtual ToolStripSeparator ToolStripSeparator1
		{
			[CompilerGenerated]
			get
			{
				return n3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				n3 = value;
			}
		}

		internal virtual ToolStripMenuItem ToolStripMenuItem_TuidoAddtoDrop
		{
			[CompilerGenerated]
			get
			{
				return n4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = MenuItem_HomdoAddDrop_Click;
				ToolStripMenuItem toolStripMenuItem = n4;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				n4 = value;
				toolStripMenuItem = n4;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem ToolStripMenuItem_TuidoAddtoContribute
		{
			[CompilerGenerated]
			get
			{
				return n5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = MenuItem_HomdoAddContribute_Click;
				ToolStripMenuItem toolStripMenuItem = n5;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				n5 = value;
				toolStripMenuItem = n5;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem ToolStripMenuItem_TuidoAddtoSend
		{
			[CompilerGenerated]
			get
			{
				return n6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = MenuItem_HomdoAddSend_Click;
				ToolStripMenuItem toolStripMenuItem = n6;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				n6 = value;
				toolStripMenuItem = n6;
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
				return n7;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				n7 = value;
			}
		}

		internal virtual ToolStripMenuItem ToolStripMenuItem_TuideoAddtoDrop
		{
			[CompilerGenerated]
			get
			{
				return n8;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = MenuItem_TuideoAddDrop_Click;
				ToolStripMenuItem toolStripMenuItem = n8;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				n8 = value;
				toolStripMenuItem = n8;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem ToolStripMenuItem_TuideoAddtoContribute
		{
			[CompilerGenerated]
			get
			{
				return n9;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = MenuItem_TuideoAddContribute_Click;
				ToolStripMenuItem toolStripMenuItem = n9;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				n9 = value;
				toolStripMenuItem = n9;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem ToolStripMenuItem_TuideoAddtoSend
		{
			[CompilerGenerated]
			get
			{
				return oa;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = MenuItem_TuideoAddSend_Click;
				ToolStripMenuItem toolStripMenuItem = oa;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				oa = value;
				toolStripMenuItem = oa;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual TextBox TextBox_DelayBot
		{
			[CompilerGenerated]
			get
			{
				return ob;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyPressEventHandler value2 = TextBox_DelayBot_KeyPress;
				EventHandler value3 = TextBox_NumericValue_TextChanged;
				TextBox textBox = ob;
				if (textBox != null)
				{
					textBox.KeyPress -= value2;
					textBox.TextChanged -= value3;
				}
				ob = value;
				textBox = ob;
				if (textBox != null)
				{
					textBox.KeyPress += value2;
					textBox.TextChanged += value3;
				}
			}
		}

		internal virtual Label Label51
		{
			[CompilerGenerated]
			get
			{
				return oc;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				oc = value;
			}
		}

		internal virtual DataTable DataTable19
		{
			[CompilerGenerated]
			get
			{
				return od;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				od = value;
			}
		}

		internal virtual DataColumn DataColumn296
		{
			[CompilerGenerated]
			get
			{
				return oe;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				oe = value;
			}
		}

		internal virtual DataColumn DataColumn297
		{
			[CompilerGenerated]
			get
			{
				return of;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				of = value;
			}
		}

		internal virtual DataColumn DataColumn298
		{
			[CompilerGenerated]
			get
			{
				return og;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				og = value;
			}
		}

		internal virtual DataColumn DataColumn299
		{
			[CompilerGenerated]
			get
			{
				return oh;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				oh = value;
			}
		}

		internal virtual DataColumn DataColumn300
		{
			[CompilerGenerated]
			get
			{
				return oi;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				oi = value;
			}
		}

		internal virtual DataColumn DataColumn301
		{
			[CompilerGenerated]
			get
			{
				return oj;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				oj = value;
			}
		}

		internal virtual DataColumn DataColumn302
		{
			[CompilerGenerated]
			get
			{
				return ok;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ok = value;
			}
		}

		internal virtual DataTable DataTable21
		{
			[CompilerGenerated]
			get
			{
				return ol;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ol = value;
			}
		}

		internal virtual DataColumn DataColumn303
		{
			[CompilerGenerated]
			get
			{
				return om;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				om = value;
			}
		}

		internal virtual DataColumn DataColumn304
		{
			[CompilerGenerated]
			get
			{
				return on;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				on = value;
			}
		}

		internal virtual DataColumn DataColumn305
		{
			[CompilerGenerated]
			get
			{
				return oo;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				oo = value;
			}
		}

		internal virtual DataColumn DataColumn306
		{
			[CompilerGenerated]
			get
			{
				return op;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				op = value;
			}
		}

		internal virtual DataColumn DataColumn307
		{
			[CompilerGenerated]
			get
			{
				return oq;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				oq = value;
			}
		}

		internal virtual DataColumn DataColumn308
		{
			[CompilerGenerated]
			get
			{
				return or;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				or = value;
			}
		}

		internal virtual DataColumn DataColumn309
		{
			[CompilerGenerated]
			get
			{
				return os;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				os = value;
			}
		}

		internal virtual DataTable DataTable22
		{
			[CompilerGenerated]
			get
			{
				return ot;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ot = value;
			}
		}

		internal virtual DataColumn DataColumn310
		{
			[CompilerGenerated]
			get
			{
				return ou;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ou = value;
			}
		}

		internal virtual DataColumn DataColumn311
		{
			[CompilerGenerated]
			get
			{
				return ov;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ov = value;
			}
		}

		internal virtual DataColumn DataColumn312
		{
			[CompilerGenerated]
			get
			{
				return ow;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ow = value;
			}
		}

		internal virtual DataColumn DataColumn313
		{
			[CompilerGenerated]
			get
			{
				return ox;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ox = value;
			}
		}

		internal virtual DataColumn DataColumn314
		{
			[CompilerGenerated]
			get
			{
				return oy;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				oy = value;
			}
		}

		internal virtual DataColumn DataColumn315
		{
			[CompilerGenerated]
			get
			{
				return oz;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				oz = value;
			}
		}

		internal virtual DataColumn DataColumn316
		{
			[CompilerGenerated]
			get
			{
				return o0;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				o0 = value;
			}
		}

		internal virtual DataTable DataTable23
		{
			[CompilerGenerated]
			get
			{
				return o1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				o1 = value;
			}
		}

		internal virtual DataColumn DataColumn317
		{
			[CompilerGenerated]
			get
			{
				return o2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				o2 = value;
			}
		}

		internal virtual DataColumn DataColumn318
		{
			[CompilerGenerated]
			get
			{
				return o3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				o3 = value;
			}
		}

		internal virtual DataColumn DataColumn319
		{
			[CompilerGenerated]
			get
			{
				return o4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				o4 = value;
			}
		}

		internal virtual DataColumn DataColumn320
		{
			[CompilerGenerated]
			get
			{
				return o5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				o5 = value;
			}
		}

		internal virtual DataColumn DataColumn321
		{
			[CompilerGenerated]
			get
			{
				return o6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				o6 = value;
			}
		}

		internal virtual DataColumn DataColumn322
		{
			[CompilerGenerated]
			get
			{
				return o7;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				o7 = value;
			}
		}

		internal virtual DataColumn DataColumn323
		{
			[CompilerGenerated]
			get
			{
				return o8;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				o8 = value;
			}
		}

		internal virtual DataTable DataTable24
		{
			[CompilerGenerated]
			get
			{
				return o9;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				o9 = value;
			}
		}

		internal virtual DataColumn DataColumn324
		{
			[CompilerGenerated]
			get
			{
				return pa;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				pa = value;
			}
		}

		internal virtual DataColumn DataColumn325
		{
			[CompilerGenerated]
			get
			{
				return pb;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				pb = value;
			}
		}

		internal virtual DataColumn DataColumn326
		{
			[CompilerGenerated]
			get
			{
				return pc;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				pc = value;
			}
		}

		internal virtual DataColumn DataColumn327
		{
			[CompilerGenerated]
			get
			{
				return pd;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				pd = value;
			}
		}

		internal virtual DataColumn DataColumn328
		{
			[CompilerGenerated]
			get
			{
				return pe;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				pe = value;
			}
		}

		internal virtual DataColumn DataColumn329
		{
			[CompilerGenerated]
			get
			{
				return pf;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				pf = value;
			}
		}

		internal virtual DataColumn DataColumn330
		{
			[CompilerGenerated]
			get
			{
				return pg;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				pg = value;
			}
		}

		internal virtual DataTable DataTable25
		{
			[CompilerGenerated]
			get
			{
				return ph;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ph = value;
			}
		}

		internal virtual DataColumn DataColumn331
		{
			[CompilerGenerated]
			get
			{
				return pi;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				pi = value;
			}
		}

		internal virtual DataColumn DataColumn332
		{
			[CompilerGenerated]
			get
			{
				return pj;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				pj = value;
			}
		}

		internal virtual DataColumn DataColumn333
		{
			[CompilerGenerated]
			get
			{
				return pk;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				pk = value;
			}
		}

		internal virtual DataColumn DataColumn334
		{
			[CompilerGenerated]
			get
			{
				return pl;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				pl = value;
			}
		}

		internal virtual DataColumn DataColumn335
		{
			[CompilerGenerated]
			get
			{
				return pm;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				pm = value;
			}
		}

		internal virtual DataColumn DataColumn336
		{
			[CompilerGenerated]
			get
			{
				return pn;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				pn = value;
			}
		}

		internal virtual DataColumn DataColumn337
		{
			[CompilerGenerated]
			get
			{
				return po;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				po = value;
			}
		}

		internal virtual DataTable DataTable26
		{
			[CompilerGenerated]
			get
			{
				return pp;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				pp = value;
			}
		}

		internal virtual DataColumn DataColumn338
		{
			[CompilerGenerated]
			get
			{
				return pq;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				pq = value;
			}
		}

		internal virtual DataColumn DataColumn339
		{
			[CompilerGenerated]
			get
			{
				return pr;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				pr = value;
			}
		}

		internal virtual DataColumn DataColumn340
		{
			[CompilerGenerated]
			get
			{
				return ps;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ps = value;
			}
		}

		internal virtual DataColumn DataColumn341
		{
			[CompilerGenerated]
			get
			{
				return pt;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				pt = value;
			}
		}

		internal virtual DataColumn DataColumn342
		{
			[CompilerGenerated]
			get
			{
				return pu;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				pu = value;
			}
		}

		internal virtual DataColumn DataColumn343
		{
			[CompilerGenerated]
			get
			{
				return pv;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				pv = value;
			}
		}

		internal virtual DataColumn DataColumn344
		{
			[CompilerGenerated]
			get
			{
				return pw;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				pw = value;
			}
		}

		internal virtual DataTable DataTable27
		{
			[CompilerGenerated]
			get
			{
				return px;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				px = value;
			}
		}

		internal virtual DataColumn DataColumn345
		{
			[CompilerGenerated]
			get
			{
				return py;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				py = value;
			}
		}

		internal virtual DataColumn DataColumn346
		{
			[CompilerGenerated]
			get
			{
				return pz;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				pz = value;
			}
		}

		internal virtual DataColumn DataColumn347
		{
			[CompilerGenerated]
			get
			{
				return p0;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				p0 = value;
			}
		}

		internal virtual DataColumn DataColumn348
		{
			[CompilerGenerated]
			get
			{
				return p1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				p1 = value;
			}
		}

		internal virtual DataColumn DataColumn349
		{
			[CompilerGenerated]
			get
			{
				return p2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				p2 = value;
			}
		}

		internal virtual DataColumn DataColumn350
		{
			[CompilerGenerated]
			get
			{
				return p3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				p3 = value;
			}
		}

		internal virtual DataColumn DataColumn351
		{
			[CompilerGenerated]
			get
			{
				return p4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				p4 = value;
			}
		}

		internal virtual DataTable DataTable28
		{
			[CompilerGenerated]
			get
			{
				return p5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				p5 = value;
			}
		}

		internal virtual DataColumn DataColumn352
		{
			[CompilerGenerated]
			get
			{
				return p6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				p6 = value;
			}
		}

		internal virtual DataColumn DataColumn353
		{
			[CompilerGenerated]
			get
			{
				return p7;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				p7 = value;
			}
		}

		internal virtual DataColumn DataColumn354
		{
			[CompilerGenerated]
			get
			{
				return p8;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				p8 = value;
			}
		}

		internal virtual DataColumn DataColumn355
		{
			[CompilerGenerated]
			get
			{
				return p9;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				p9 = value;
			}
		}

		internal virtual DataColumn DataColumn356
		{
			[CompilerGenerated]
			get
			{
				return qa;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				qa = value;
			}
		}

		internal virtual DataColumn DataColumn357
		{
			[CompilerGenerated]
			get
			{
				return qb;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				qb = value;
			}
		}

		internal virtual DataColumn DataColumn358
		{
			[CompilerGenerated]
			get
			{
				return qc;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				qc = value;
			}
		}

		internal virtual DataTable DataTable29
		{
			[CompilerGenerated]
			get
			{
				return qd;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				qd = value;
			}
		}

		internal virtual DataColumn DataColumn359
		{
			[CompilerGenerated]
			get
			{
				return qe;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				qe = value;
			}
		}

		internal virtual DataColumn DataColumn360
		{
			[CompilerGenerated]
			get
			{
				return qf;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				qf = value;
			}
		}

		internal virtual DataColumn DataColumn361
		{
			[CompilerGenerated]
			get
			{
				return qg;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				qg = value;
			}
		}

		internal virtual DataColumn DataColumn362
		{
			[CompilerGenerated]
			get
			{
				return qh;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				qh = value;
			}
		}

		internal virtual DataColumn DataColumn363
		{
			[CompilerGenerated]
			get
			{
				return qi;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				qi = value;
			}
		}

		internal virtual DataColumn DataColumn364
		{
			[CompilerGenerated]
			get
			{
				return qj;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				qj = value;
			}
		}

		internal virtual DataColumn DataColumn365
		{
			[CompilerGenerated]
			get
			{
				return qk;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				qk = value;
			}
		}

		internal virtual DataTable DataTable30
		{
			[CompilerGenerated]
			get
			{
				return ql;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ql = value;
			}
		}

		internal virtual DataColumn DataColumn366
		{
			[CompilerGenerated]
			get
			{
				return qm;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				qm = value;
			}
		}

		internal virtual DataColumn DataColumn367
		{
			[CompilerGenerated]
			get
			{
				return qn;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				qn = value;
			}
		}

		internal virtual DataColumn DataColumn368
		{
			[CompilerGenerated]
			get
			{
				return qo;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				qo = value;
			}
		}

		internal virtual DataColumn DataColumn369
		{
			[CompilerGenerated]
			get
			{
				return qp;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				qp = value;
			}
		}

		internal virtual DataColumn DataColumn370
		{
			[CompilerGenerated]
			get
			{
				return qq;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				qq = value;
			}
		}

		internal virtual DataColumn DataColumn371
		{
			[CompilerGenerated]
			get
			{
				return qr;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				qr = value;
			}
		}

		internal virtual DataColumn DataColumn372
		{
			[CompilerGenerated]
			get
			{
				return qs;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				qs = value;
			}
		}

		internal virtual DataTable DataTable31
		{
			[CompilerGenerated]
			get
			{
				return qt;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				qt = value;
			}
		}

		internal virtual DataColumn DataColumn373
		{
			[CompilerGenerated]
			get
			{
				return qu;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				qu = value;
			}
		}

		internal virtual DataColumn DataColumn374
		{
			[CompilerGenerated]
			get
			{
				return qv;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				qv = value;
			}
		}

		internal virtual DataColumn DataColumn375
		{
			[CompilerGenerated]
			get
			{
				return qw;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				qw = value;
			}
		}

		internal virtual DataColumn DataColumn376
		{
			[CompilerGenerated]
			get
			{
				return qx;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				qx = value;
			}
		}

		internal virtual DataColumn DataColumn377
		{
			[CompilerGenerated]
			get
			{
				return qy;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				qy = value;
			}
		}

		internal virtual DataColumn DataColumn378
		{
			[CompilerGenerated]
			get
			{
				return qz;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				qz = value;
			}
		}

		internal virtual DataColumn DataColumn379
		{
			[CompilerGenerated]
			get
			{
				return q0;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				q0 = value;
			}
		}

		internal virtual DataTable DataTable32
		{
			[CompilerGenerated]
			get
			{
				return q1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				q1 = value;
			}
		}

		internal virtual DataColumn DataColumn380
		{
			[CompilerGenerated]
			get
			{
				return q2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				q2 = value;
			}
		}

		internal virtual DataColumn DataColumn381
		{
			[CompilerGenerated]
			get
			{
				return q3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				q3 = value;
			}
		}

		internal virtual DataColumn DataColumn382
		{
			[CompilerGenerated]
			get
			{
				return q4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				q4 = value;
			}
		}

		internal virtual DataColumn DataColumn383
		{
			[CompilerGenerated]
			get
			{
				return q5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				q5 = value;
			}
		}

		internal virtual DataColumn DataColumn384
		{
			[CompilerGenerated]
			get
			{
				return q6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				q6 = value;
			}
		}

		internal virtual DataColumn DataColumn385
		{
			[CompilerGenerated]
			get
			{
				return q7;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				q7 = value;
			}
		}

		internal virtual DataColumn DataColumn386
		{
			[CompilerGenerated]
			get
			{
				return q8;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				q8 = value;
			}
		}

		internal virtual DataTable DataTable33
		{
			[CompilerGenerated]
			get
			{
				return q9;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				q9 = value;
			}
		}

		internal virtual DataColumn DataColumn387
		{
			[CompilerGenerated]
			get
			{
				return ra;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ra = value;
			}
		}

		internal virtual DataColumn DataColumn388
		{
			[CompilerGenerated]
			get
			{
				return rb;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				rb = value;
			}
		}

		internal virtual DataColumn DataColumn389
		{
			[CompilerGenerated]
			get
			{
				return rc;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				rc = value;
			}
		}

		internal virtual DataColumn DataColumn390
		{
			[CompilerGenerated]
			get
			{
				return rd;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				rd = value;
			}
		}

		internal virtual DataColumn DataColumn391
		{
			[CompilerGenerated]
			get
			{
				return re;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				re = value;
			}
		}

		internal virtual DataColumn DataColumn392
		{
			[CompilerGenerated]
			get
			{
				return rf;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				rf = value;
			}
		}

		internal virtual DataColumn DataColumn393
		{
			[CompilerGenerated]
			get
			{
				return rg;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				rg = value;
			}
		}

		internal virtual DataTable DataTable34
		{
			[CompilerGenerated]
			get
			{
				return rh;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				rh = value;
			}
		}

		internal virtual DataColumn DataColumn394
		{
			[CompilerGenerated]
			get
			{
				return ri;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ri = value;
			}
		}

		internal virtual DataColumn DataColumn395
		{
			[CompilerGenerated]
			get
			{
				return rj;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				rj = value;
			}
		}

		internal virtual DataColumn DataColumn396
		{
			[CompilerGenerated]
			get
			{
				return rk;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				rk = value;
			}
		}

		internal virtual DataColumn DataColumn397
		{
			[CompilerGenerated]
			get
			{
				return rl;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				rl = value;
			}
		}

		internal virtual DataColumn DataColumn398
		{
			[CompilerGenerated]
			get
			{
				return rm;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				rm = value;
			}
		}

		internal virtual DataColumn DataColumn399
		{
			[CompilerGenerated]
			get
			{
				return rn;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				rn = value;
			}
		}

		internal virtual DataColumn DataColumn400
		{
			[CompilerGenerated]
			get
			{
				return ro;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ro = value;
			}
		}

		internal virtual DataTable DataTable35
		{
			[CompilerGenerated]
			get
			{
				return rp;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				rp = value;
			}
		}

		internal virtual DataColumn DataColumn401
		{
			[CompilerGenerated]
			get
			{
				return rq;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				rq = value;
			}
		}

		internal virtual DataColumn DataColumn402
		{
			[CompilerGenerated]
			get
			{
				return rr;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				rr = value;
			}
		}

		internal virtual DataColumn DataColumn403
		{
			[CompilerGenerated]
			get
			{
				return rs;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				rs = value;
			}
		}

		internal virtual DataColumn DataColumn404
		{
			[CompilerGenerated]
			get
			{
				return rt;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				rt = value;
			}
		}

		internal virtual DataColumn DataColumn405
		{
			[CompilerGenerated]
			get
			{
				return ru;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ru = value;
			}
		}

		internal virtual DataColumn DataColumn406
		{
			[CompilerGenerated]
			get
			{
				return rv;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				rv = value;
			}
		}

		internal virtual DataColumn DataColumn407
		{
			[CompilerGenerated]
			get
			{
				return rw;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				rw = value;
			}
		}

		internal virtual DataTable DataTable36
		{
			[CompilerGenerated]
			get
			{
				return rx;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				rx = value;
			}
		}

		internal virtual DataColumn DataColumn408
		{
			[CompilerGenerated]
			get
			{
				return ry;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ry = value;
			}
		}

		internal virtual DataColumn DataColumn409
		{
			[CompilerGenerated]
			get
			{
				return rz;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				rz = value;
			}
		}

		internal virtual DataColumn DataColumn410
		{
			[CompilerGenerated]
			get
			{
				return r0;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				r0 = value;
			}
		}

		internal virtual DataColumn DataColumn411
		{
			[CompilerGenerated]
			get
			{
				return r1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				r1 = value;
			}
		}

		internal virtual DataColumn DataColumn412
		{
			[CompilerGenerated]
			get
			{
				return r2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				r2 = value;
			}
		}

		internal virtual DataColumn DataColumn413
		{
			[CompilerGenerated]
			get
			{
				return r3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				r3 = value;
			}
		}

		internal virtual DataColumn DataColumn414
		{
			[CompilerGenerated]
			get
			{
				return r4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				r4 = value;
			}
		}

		internal virtual DataTable DataTable37
		{
			[CompilerGenerated]
			get
			{
				return r5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				r5 = value;
			}
		}

		internal virtual DataColumn DataColumn415
		{
			[CompilerGenerated]
			get
			{
				return r6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				r6 = value;
			}
		}

		internal virtual DataColumn DataColumn416
		{
			[CompilerGenerated]
			get
			{
				return r7;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				r7 = value;
			}
		}

		internal virtual DataColumn DataColumn417
		{
			[CompilerGenerated]
			get
			{
				return r8;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				r8 = value;
			}
		}

		internal virtual DataColumn DataColumn418
		{
			[CompilerGenerated]
			get
			{
				return r9;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				r9 = value;
			}
		}

		internal virtual DataColumn DataColumn419
		{
			[CompilerGenerated]
			get
			{
				return sa;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				sa = value;
			}
		}

		internal virtual DataColumn DataColumn420
		{
			[CompilerGenerated]
			get
			{
				return sb;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				sb = value;
			}
		}

		internal virtual DataColumn DataColumn421
		{
			[CompilerGenerated]
			get
			{
				return sc;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				sc = value;
			}
		}

		internal virtual DataTable DataTable38
		{
			[CompilerGenerated]
			get
			{
				return sd;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				sd = value;
			}
		}

		internal virtual DataColumn DataColumn422
		{
			[CompilerGenerated]
			get
			{
				return se;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				se = value;
			}
		}

		internal virtual DataColumn DataColumn423
		{
			[CompilerGenerated]
			get
			{
				return sf;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				sf = value;
			}
		}

		internal virtual DataColumn DataColumn424
		{
			[CompilerGenerated]
			get
			{
				return sg;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				sg = value;
			}
		}

		internal virtual DataColumn DataColumn425
		{
			[CompilerGenerated]
			get
			{
				return sh;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				sh = value;
			}
		}

		internal virtual DataColumn DataColumn426
		{
			[CompilerGenerated]
			get
			{
				return si;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				si = value;
			}
		}

		internal virtual DataColumn DataColumn427
		{
			[CompilerGenerated]
			get
			{
				return sj;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				sj = value;
			}
		}

		internal virtual DataColumn DataColumn428
		{
			[CompilerGenerated]
			get
			{
				return sk;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				sk = value;
			}
		}

		internal virtual DataTable DataTable39
		{
			[CompilerGenerated]
			get
			{
				return sl;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				sl = value;
			}
		}

		internal virtual DataColumn DataColumn429
		{
			[CompilerGenerated]
			get
			{
				return sm;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				sm = value;
			}
		}

		internal virtual DataColumn DataColumn430
		{
			[CompilerGenerated]
			get
			{
				return sn;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				sn = value;
			}
		}

		internal virtual DataColumn DataColumn431
		{
			[CompilerGenerated]
			get
			{
				return so;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				so = value;
			}
		}

		internal virtual DataColumn DataColumn432
		{
			[CompilerGenerated]
			get
			{
				return sp;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				sp = value;
			}
		}

		internal virtual DataColumn DataColumn433
		{
			[CompilerGenerated]
			get
			{
				return sq;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				sq = value;
			}
		}

		internal virtual DataColumn DataColumn434
		{
			[CompilerGenerated]
			get
			{
				return sr;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				sr = value;
			}
		}

		internal virtual DataColumn DataColumn435
		{
			[CompilerGenerated]
			get
			{
				return ss;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ss = value;
			}
		}

		internal virtual DataColumn DataColumn436
		{
			[CompilerGenerated]
			get
			{
				return st;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				st = value;
			}
		}

		internal virtual DataColumn DataColumn437
		{
			[CompilerGenerated]
			get
			{
				return su;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				su = value;
			}
		}

		internal virtual DataColumn DataColumn438
		{
			[CompilerGenerated]
			get
			{
				return sv;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				sv = value;
			}
		}

		internal virtual DataColumn DataColumn439
		{
			[CompilerGenerated]
			get
			{
				return sw;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				sw = value;
			}
		}

		internal virtual DataColumn DataColumn440
		{
			[CompilerGenerated]
			get
			{
				return sx;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				sx = value;
			}
		}

		internal virtual DataColumn DataColumn441
		{
			[CompilerGenerated]
			get
			{
				return sy;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				sy = value;
			}
		}

		internal virtual DataColumn DataColumn442
		{
			[CompilerGenerated]
			get
			{
				return sz;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				sz = value;
			}
		}

		internal virtual DataColumn DataColumn443
		{
			[CompilerGenerated]
			get
			{
				return s0;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				s0 = value;
			}
		}

		internal virtual DataColumn DataColumn444
		{
			[CompilerGenerated]
			get
			{
				return s1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				s1 = value;
			}
		}

		internal virtual DataColumn DataColumn445
		{
			[CompilerGenerated]
			get
			{
				return s2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				s2 = value;
			}
		}

		internal virtual DataColumn DataColumn446
		{
			[CompilerGenerated]
			get
			{
				return s3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				s3 = value;
			}
		}

		internal virtual DataColumn DataColumn447
		{
			[CompilerGenerated]
			get
			{
				return s4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				s4 = value;
			}
		}

		internal virtual DataColumn DataColumn448
		{
			[CompilerGenerated]
			get
			{
				return s5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				s5 = value;
			}
		}

		internal virtual DataColumn DataColumn449
		{
			[CompilerGenerated]
			get
			{
				return s6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				s6 = value;
			}
		}

		internal virtual DataColumn DataColumn450
		{
			[CompilerGenerated]
			get
			{
				return s7;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				s7 = value;
			}
		}

		internal virtual DataColumn DataColumn451
		{
			[CompilerGenerated]
			get
			{
				return s8;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				s8 = value;
			}
		}

		internal virtual DataColumn DataColumn452
		{
			[CompilerGenerated]
			get
			{
				return s9;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				s9 = value;
			}
		}

		internal virtual DataColumn DataColumn453
		{
			[CompilerGenerated]
			get
			{
				return ta;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ta = value;
			}
		}

		internal virtual DataColumn DataColumn454
		{
			[CompilerGenerated]
			get
			{
				return tb;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				tb = value;
			}
		}

		internal virtual DataColumn DataColumn455
		{
			[CompilerGenerated]
			get
			{
				return tc;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				tc = value;
			}
		}

		internal virtual CheckBox CheckBox_DropMineWood
		{
			[CompilerGenerated]
			get
			{
				return td;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Settings_CheckedChanged;
				CheckBox checkBox = td;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				td = value;
				checkBox = td;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		internal virtual CheckBox CheckBox_ContributeMineWood
		{
			[CompilerGenerated]
			get
			{
				return te;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Settings_CheckedChanged;
				CheckBox checkBox = te;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				te = value;
				checkBox = te;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		internal virtual CheckBox CheckBox_SendMineWood
		{
			[CompilerGenerated]
			get
			{
				return tf;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Settings_CheckedChanged;
				CheckBox checkBox = tf;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				tf = value;
				checkBox = tf;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		internal virtual CheckBox CheckBox_AutoEat
		{
			[CompilerGenerated]
			get
			{
				return tg;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Settings_CheckedChanged;
				CheckBox checkBox = tg;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				tg = value;
				checkBox = tg;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		internal virtual DataColumn DataColumn456
		{
			[CompilerGenerated]
			get
			{
				return th;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				th = value;
			}
		}

		internal virtual DataColumn DataColumn457
		{
			[CompilerGenerated]
			get
			{
				return ti;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ti = value;
			}
		}

		internal virtual DataColumn DataColumn458
		{
			[CompilerGenerated]
			get
			{
				return tj;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				tj = value;
			}
		}

		internal virtual DataColumn DataColumn459
		{
			[CompilerGenerated]
			get
			{
				return tk;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				tk = value;
			}
		}

		internal virtual DataColumn DataColumn460
		{
			[CompilerGenerated]
			get
			{
				return tl;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				tl = value;
			}
		}

		internal virtual DataColumn DataColumn461
		{
			[CompilerGenerated]
			get
			{
				return tm;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				tm = value;
			}
		}

		internal virtual DataColumn DataColumn462
		{
			[CompilerGenerated]
			get
			{
				return tn;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				tn = value;
			}
		}

		internal virtual DataColumn DataColumn463
		{
			[CompilerGenerated]
			get
			{
				return to;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				to = value;
			}
		}

		internal virtual DataColumn DataColumn464
		{
			[CompilerGenerated]
			get
			{
				return tp;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				tp = value;
			}
		}

		internal virtual DataColumn DataColumn465
		{
			[CompilerGenerated]
			get
			{
				return tq;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				tq = value;
			}
		}

		internal virtual DataColumn DataColumn466
		{
			[CompilerGenerated]
			get
			{
				return tr;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				tr = value;
			}
		}

		internal virtual DataColumn DataColumn467
		{
			[CompilerGenerated]
			get
			{
				return ts;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ts = value;
			}
		}

		internal virtual DataColumn DataColumn468
		{
			[CompilerGenerated]
			get
			{
				return tt;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				tt = value;
			}
		}

		internal virtual DataColumn DataColumn469
		{
			[CompilerGenerated]
			get
			{
				return tu;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				tu = value;
			}
		}

		internal virtual DataColumn DataColumn470
		{
			[CompilerGenerated]
			get
			{
				return tv;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				tv = value;
			}
		}

		internal virtual DataColumn DataColumn471
		{
			[CompilerGenerated]
			get
			{
				return tw;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				tw = value;
			}
		}

		internal virtual DataColumn DataColumn472
		{
			[CompilerGenerated]
			get
			{
				return tx;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				tx = value;
			}
		}

		internal virtual DataColumn DataColumn473
		{
			[CompilerGenerated]
			get
			{
				return ty;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ty = value;
			}
		}

		internal virtual DataColumn DataColumn474
		{
			[CompilerGenerated]
			get
			{
				return tz;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				tz = value;
			}
		}

		internal virtual DataColumn DataColumn475
		{
			[CompilerGenerated]
			get
			{
				return t0;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				t0 = value;
			}
		}

		internal virtual DataColumn DataColumn476
		{
			[CompilerGenerated]
			get
			{
				return t1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				t1 = value;
			}
		}

		internal virtual DataColumn DataColumn477
		{
			[CompilerGenerated]
			get
			{
				return t2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				t2 = value;
			}
		}

		internal virtual DataColumn DataColumn478
		{
			[CompilerGenerated]
			get
			{
				return t3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				t3 = value;
			}
		}

		internal virtual DataColumn DataColumn479
		{
			[CompilerGenerated]
			get
			{
				return t4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				t4 = value;
			}
		}

		internal virtual DataColumn DataColumn480
		{
			[CompilerGenerated]
			get
			{
				return t5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				t5 = value;
			}
		}

		internal virtual DataColumn DataColumn481
		{
			[CompilerGenerated]
			get
			{
				return t6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				t6 = value;
			}
		}

		internal virtual DataColumn DataColumn482
		{
			[CompilerGenerated]
			get
			{
				return t7;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				t7 = value;
			}
		}

		internal virtual DataColumn DataColumn483
		{
			[CompilerGenerated]
			get
			{
				return t8;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				t8 = value;
			}
		}

		internal virtual DataColumn DataColumn484
		{
			[CompilerGenerated]
			get
			{
				return t9;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				t9 = value;
			}
		}

		internal virtual DataColumn DataColumn485
		{
			[CompilerGenerated]
			get
			{
				return ua;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ua = value;
			}
		}

		internal virtual DataColumn DataColumn486
		{
			[CompilerGenerated]
			get
			{
				return ub;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ub = value;
			}
		}

		internal virtual DataColumn DataColumn487
		{
			[CompilerGenerated]
			get
			{
				return uc;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				uc = value;
			}
		}

		internal virtual DataColumn DataColumn488
		{
			[CompilerGenerated]
			get
			{
				return ud;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ud = value;
			}
		}

		internal virtual DataColumn DataColumn489
		{
			[CompilerGenerated]
			get
			{
				return ue;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ue = value;
			}
		}

		internal virtual DataColumn DataColumn490
		{
			[CompilerGenerated]
			get
			{
				return uf;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				uf = value;
			}
		}

		internal virtual DataColumn DataColumn491
		{
			[CompilerGenerated]
			get
			{
				return ug;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ug = value;
			}
		}

		internal virtual DataColumn DataColumn492
		{
			[CompilerGenerated]
			get
			{
				return uh;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				uh = value;
			}
		}

		internal virtual DataColumn DataColumn493
		{
			[CompilerGenerated]
			get
			{
				return ui;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ui = value;
			}
		}

		internal virtual DataColumn DataColumn494
		{
			[CompilerGenerated]
			get
			{
				return uj;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				uj = value;
			}
		}

		internal virtual DataColumn DataColumn495
		{
			[CompilerGenerated]
			get
			{
				return uk;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				uk = value;
			}
		}

		internal virtual DataColumn DataColumn496
		{
			[CompilerGenerated]
			get
			{
				return ul;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ul = value;
			}
		}

		internal virtual DataColumn DataColumn497
		{
			[CompilerGenerated]
			get
			{
				return um;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				um = value;
			}
		}

		internal virtual Label Label_Petname
		{
			[CompilerGenerated]
			get
			{
				return un;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				un = value;
			}
		}

		internal virtual Label Label_CharName
		{
			[CompilerGenerated]
			get
			{
				return uo;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				uo = value;
			}
		}

		internal virtual Label Label74
		{
			[CompilerGenerated]
			get
			{
				return up;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				up = value;
			}
		}

		internal virtual TextBox TextBox_ValueSPFlee
		{
			[CompilerGenerated]
			get
			{
				return uq;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = TextBox_NumericValue_TextChanged;
				TextBox textBox = uq;
				if (textBox != null)
				{
					textBox.TextChanged -= value2;
				}
				uq = value;
				textBox = uq;
				if (textBox != null)
				{
					textBox.TextChanged += value2;
				}
			}
		}

		internal virtual CheckBox CheckBox_AutoFlee_Sp
		{
			[CompilerGenerated]
			get
			{
				return ur;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Settings_CheckedChanged;
				CheckBox checkBox = ur;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				ur = value;
				checkBox = ur;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		internal virtual CheckBox CheckBox_AutoFlee_Party
		{
			[CompilerGenerated]
			get
			{
				return us;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Settings_CheckedChanged;
				CheckBox checkBox = us;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				us = value;
				checkBox = us;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		internal virtual DataColumn DataColumn498
		{
			[CompilerGenerated]
			get
			{
				return ut;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ut = value;
			}
		}

		internal virtual Label Label75
		{
			[CompilerGenerated]
			get
			{
				return uu;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				uu = value;
			}
		}

		internal virtual TextBox TextBox_AutoSend
		{
			[CompilerGenerated]
			get
			{
				return uv;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyPressEventHandler value2 = NumericTextBox_KeyPress;
				EventHandler value3 = TextBox_NumericValue_TextChanged;
				TextBox textBox = uv;
				if (textBox != null)
				{
					textBox.KeyPress -= value2;
					textBox.TextChanged -= value3;
				}
				uv = value;
				textBox = uv;
				if (textBox != null)
				{
					textBox.KeyPress += value2;
					textBox.TextChanged += value3;
				}
			}
		}

		internal virtual DataColumn DataColumn499
		{
			[CompilerGenerated]
			get
			{
				return uw;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				uw = value;
			}
		}

		internal virtual DataColumn DataColumn501
		{
			[CompilerGenerated]
			get
			{
				return ux;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ux = value;
			}
		}

		internal virtual DataColumn DataColumn502
		{
			[CompilerGenerated]
			get
			{
				return uy;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				uy = value;
			}
		}

		internal virtual DataColumn DataColumn503
		{
			[CompilerGenerated]
			get
			{
				return uz;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				uz = value;
			}
		}

		internal virtual DataColumn DataColumn504
		{
			[CompilerGenerated]
			get
			{
				return u0;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				u0 = value;
			}
		}

		internal virtual DataColumn DataColumn500
		{
			[CompilerGenerated]
			get
			{
				return u1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				u1 = value;
			}
		}

		internal virtual TabPage TabPage2
		{
			[CompilerGenerated]
			get
			{
				return u2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				u2 = value;
			}
		}

		internal virtual TabPage TabPage1
		{
			[CompilerGenerated]
			get
			{
				return u3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				u3 = value;
			}
		}

		internal virtual CheckBox CheckBox_AutoRevival
		{
			[CompilerGenerated]
			get
			{
				return u4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Settings_CheckedChanged;
				CheckBox checkBox = u4;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				u4 = value;
				checkBox = u4;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		internal virtual TabControl TabControl2
		{
			[CompilerGenerated]
			get
			{
				return u5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				u5 = value;
			}
		}

		internal virtual TabPage TabPage3
		{
			[CompilerGenerated]
			get
			{
				return u6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				u6 = value;
			}
		}

		internal virtual ListView ListView_monster
		{
			[CompilerGenerated]
			get
			{
				return u7;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				u7 = value;
			}
		}

		internal virtual ColumnHeader ColumnHeader5
		{
			[CompilerGenerated]
			get
			{
				return u8;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				u8 = value;
			}
		}

		internal virtual ColumnHeader ColumnHeader6
		{
			[CompilerGenerated]
			get
			{
				return u9;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				u9 = value;
			}
		}

		internal virtual ColumnHeader ColumnHeader7
		{
			[CompilerGenerated]
			get
			{
				return va;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				va = value;
			}
		}

		internal virtual ColumnHeader ColumnHeader8
		{
			[CompilerGenerated]
			get
			{
				return vb;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				vb = value;
			}
		}

		internal virtual ColumnHeader ColumnHeader9
		{
			[CompilerGenerated]
			get
			{
				return vc;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				vc = value;
			}
		}

		internal virtual CheckBox CheckBox_AutoClickNPC
		{
			[CompilerGenerated]
			get
			{
				return vd;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Settings_CheckedChanged;
				CheckBox checkBox = vd;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				vd = value;
				checkBox = vd;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		internal virtual TextBox TextBox_ClickMOD
		{
			[CompilerGenerated]
			get
			{
				return ve;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyPressEventHandler value2 = NumericTextBox_KeyPress;
				EventHandler value3 = TextBox_PasswordOrClickMOD_TextChanged;
				TextBox textBox = ve;
				if (textBox != null)
				{
					textBox.KeyPress -= value2;
					textBox.TextChanged -= value3;
				}
				ve = value;
				textBox = ve;
				if (textBox != null)
				{
					textBox.KeyPress += value2;
					textBox.TextChanged += value3;
				}
			}
		}

		internal virtual CheckBox CheckBox_CatPet
		{
			[CompilerGenerated]
			get
			{
				return vf;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Settings_CheckedChanged;
				CheckBox checkBox = vf;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				vf = value;
				checkBox = vf;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		internal virtual GroupBox GroupBox8
		{
			[CompilerGenerated]
			get
			{
				return vg;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				vg = value;
			}
		}

		internal virtual CheckBox CheckBox_TuLenNgua
		{
			[CompilerGenerated]
			get
			{
				return vh;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Settings_CheckedChanged;
				CheckBox checkBox = vh;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				vh = value;
				checkBox = vh;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		internal virtual Label Label79
		{
			[CompilerGenerated]
			get
			{
				return vi;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				vi = value;
			}
		}

		internal virtual Label Label77
		{
			[CompilerGenerated]
			get
			{
				return vj;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				vj = value;
			}
		}

		internal virtual Label Label13
		{
			[CompilerGenerated]
			get
			{
				return vk;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				vk = value;
			}
		}

		internal virtual TextBox TextBox_RemoteDis
		{
			[CompilerGenerated]
			get
			{
				return vl;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				vl = value;
			}
		}

		internal virtual GroupBox GroupBox9
		{
			[CompilerGenerated]
			get
			{
				return vm;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				vm = value;
			}
		}

		internal virtual CheckBox CheckBox_AutoEquitExp
		{
			[CompilerGenerated]
			get
			{
				return vn;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Settings_CheckedChanged;
				CheckBox checkBox = vn;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				vn = value;
				checkBox = vn;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		internal virtual CheckBox CheckBox_AutoUsePT
		{
			[CompilerGenerated]
			get
			{
				return vo;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Settings_CheckedChanged;
				CheckBox checkBox = vo;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				vo = value;
				checkBox = vo;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		internal virtual TextBox TextBox_Country
		{
			[CompilerGenerated]
			get
			{
				return vp;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				vp = value;
			}
		}

		internal virtual DataTable DataTable20
		{
			[CompilerGenerated]
			get
			{
				return vq;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				vq = value;
			}
		}

		internal virtual DataColumn DataColumn505
		{
			[CompilerGenerated]
			get
			{
				return vr;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				vr = value;
			}
		}

		internal virtual DataColumn DataColumn506
		{
			[CompilerGenerated]
			get
			{
				return vs;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				vs = value;
			}
		}

		internal virtual DataGridView DataGridView_ItemOnMap
		{
			[CompilerGenerated]
			get
			{
				return vt;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				vt = value;
			}
		}

		internal virtual DataColumn DataColumn509
		{
			[CompilerGenerated]
			get
			{
				return vu;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				vu = value;
			}
		}

		internal virtual DataColumn DataColumn507
		{
			[CompilerGenerated]
			get
			{
				return vv;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				vv = value;
			}
		}

		internal virtual DataColumn DataColumn508
		{
			[CompilerGenerated]
			get
			{
				return vw;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				vw = value;
			}
		}

		internal virtual CheckBox CheckBox_Pickup
		{
			[CompilerGenerated]
			get
			{
				return vx;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Settings_CheckedChanged;
				CheckBox checkBox = vx;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				vx = value;
				checkBox = vx;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		internal virtual Panel Panel4
		{
			[CompilerGenerated]
			get
			{
				return vy;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				vy = value;
			}
		}

		internal virtual DataGridViewTextBoxColumn GoldDataGridViewTextBoxColumn
		{
			[CompilerGenerated]
			get
			{
				return vz;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				vz = value;
			}
		}

		internal virtual DataGridViewTextBoxColumn IdDataGridViewTextBoxColumn
		{
			[CompilerGenerated]
			get
			{
				return v0;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				v0 = value;
			}
		}

		internal virtual DataGridViewTextBoxColumn ItemNameDataGridViewTextBoxColumn
		{
			[CompilerGenerated]
			get
			{
				return v1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				v1 = value;
			}
		}

		internal virtual DataGridViewTextBoxColumn MapXDataGridViewTextBoxColumn
		{
			[CompilerGenerated]
			get
			{
				return v2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				v2 = value;
			}
		}

		internal virtual DataGridViewTextBoxColumn MapYDataGridViewTextBoxColumn
		{
			[CompilerGenerated]
			get
			{
				return v3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				v3 = value;
			}
		}

		internal virtual Label Label3
		{
			[CompilerGenerated]
			get
			{
				return v4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				v4 = value;
			}
		}

		internal virtual Button Button_IdAdd
		{
			[CompilerGenerated]
			get
			{
				return v5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				v5 = value;
			}
		}

		internal virtual TextBox TextBox_IdAdd
		{
			[CompilerGenerated]
			get
			{
				return v6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				v6 = value;
			}
		}

		internal virtual DataGridView DataGridView_Pickup
		{
			[CompilerGenerated]
			get
			{
				return v7;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				v7 = value;
			}
		}

		internal virtual DataTable DataTable40
		{
			[CompilerGenerated]
			get
			{
				return v8;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				v8 = value;
			}
		}

		internal virtual DataColumn DataColumn510
		{
			[CompilerGenerated]
			get
			{
				return v9;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				v9 = value;
			}
		}

		internal virtual DataColumn DataColumn511
		{
			[CompilerGenerated]
			get
			{
				return wa;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				wa = value;
			}
		}

		internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn14
		{
			[CompilerGenerated]
			get
			{
				return wb;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				wb = value;
			}
		}

		internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn15
		{
			[CompilerGenerated]
			get
			{
				return wc;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				wc = value;
			}
		}

		internal virtual TabPage TabPage5
		{
			[CompilerGenerated]
			get
			{
				return wd;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				wd = value;
			}
		}

		internal virtual GroupBox GroupBox10
		{
			[CompilerGenerated]
			get
			{
				return we;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				we = value;
			}
		}

		internal virtual CheckBox CheckBox_SellMineWood
		{
			[CompilerGenerated]
			get
			{
				return wf;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Settings_CheckedChanged;
				CheckBox checkBox = wf;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				wf = value;
				checkBox = wf;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		internal virtual Button Button_AddIdSell
		{
			[CompilerGenerated]
			get
			{
				return wg;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button_AddIdSell_Click;
				Button button = wg;
				if (button != null)
				{
					button.Click -= value2;
				}
				wg = value;
				button = wg;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual TextBox TextBox_AddIdSell
		{
			[CompilerGenerated]
			get
			{
				return wh;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				wh = value;
			}
		}

		internal virtual CheckBox CheckBox_SellHpSp
		{
			[CompilerGenerated]
			get
			{
				return wi;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Settings_CheckedChanged;
				CheckBox checkBox = wi;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				wi = value;
				checkBox = wi;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		internal virtual CheckBox CheckBox_SellSP
		{
			[CompilerGenerated]
			get
			{
				return wj;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Settings_CheckedChanged;
				CheckBox checkBox = wj;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				wj = value;
				checkBox = wj;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		internal virtual CheckBox CheckBox_SellHp
		{
			[CompilerGenerated]
			get
			{
				return wk;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Settings_CheckedChanged;
				CheckBox checkBox = wk;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				wk = value;
				checkBox = wk;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		internal virtual Label Label12
		{
			[CompilerGenerated]
			get
			{
				return wl;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				wl = value;
			}
		}

		internal virtual TextBox TextBox_Sell_SpValue
		{
			[CompilerGenerated]
			get
			{
				return wm;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = TextBox_NumericValue_TextChanged;
				TextBox textBox = wm;
				if (textBox != null)
				{
					textBox.TextChanged -= value2;
				}
				wm = value;
				textBox = wm;
				if (textBox != null)
				{
					textBox.TextChanged += value2;
				}
			}
		}

		internal virtual Label Label80
		{
			[CompilerGenerated]
			get
			{
				return wn;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				wn = value;
			}
		}

		internal virtual TextBox TextBox_Sell_HpValue
		{
			[CompilerGenerated]
			get
			{
				return wo;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = TextBox_NumericValue_TextChanged;
				TextBox textBox = wo;
				if (textBox != null)
				{
					textBox.TextChanged -= value2;
				}
				wo = value;
				textBox = wo;
				if (textBox != null)
				{
					textBox.TextChanged += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem ToolStripMenuItem_TuideoAddtoSell
		{
			[CompilerGenerated]
			get
			{
				return wp;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = MenuItem_TuideoAddSell_Click;
				ToolStripMenuItem toolStripMenuItem = wp;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				wp = value;
				toolStripMenuItem = wp;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem ToolStripMenuItem_TuidoAddtoSell
		{
			[CompilerGenerated]
			get
			{
				return wq;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = MenuItem_HomdoAddSell_Click;
				ToolStripMenuItem toolStripMenuItem = wq;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				wq = value;
				toolStripMenuItem = wq;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual DataTable DataTable41
		{
			[CompilerGenerated]
			get
			{
				return wr;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				wr = value;
			}
		}

		internal virtual DataColumn DataColumn512
		{
			[CompilerGenerated]
			get
			{
				return ws;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ws = value;
			}
		}

		internal virtual DataColumn DataColumn513
		{
			[CompilerGenerated]
			get
			{
				return wt;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				wt = value;
			}
		}

		internal virtual CheckBox CheckBox_autosell
		{
			[CompilerGenerated]
			get
			{
				return wu;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Settings_CheckedChanged;
				CheckBox checkBox = wu;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				wu = value;
				checkBox = wu;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		internal virtual CheckBox CheckBox_QuestProtect
		{
			[CompilerGenerated]
			get
			{
				return wv;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Settings_CheckedChanged;
				CheckBox checkBox = wv;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				wv = value;
				checkBox = wv;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		internal virtual DataColumn DataColumn514
		{
			[CompilerGenerated]
			get
			{
				return ww;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ww = value;
			}
		}

		internal virtual Label Label83
		{
			[CompilerGenerated]
			get
			{
				return wx;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				wx = value;
			}
		}

		internal virtual CheckBox CheckBox_Bee
		{
			[CompilerGenerated]
			get
			{
				return wy;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Settings_CheckedChanged;
				CheckBox checkBox = wy;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				wy = value;
				checkBox = wy;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		internal virtual Panel Panel6
		{
			[CompilerGenerated]
			get
			{
				return wz;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				wz = value;
			}
		}

		internal virtual ProgressBarEx ProgressBarEx_BDY
		{
			[CompilerGenerated]
			get
			{
				return w0;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				w0 = value;
			}
		}

		internal virtual Label Label_BDY
		{
			[CompilerGenerated]
			get
			{
				return w1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				w1 = value;
			}
		}

		internal virtual CheckBox CheckBox_DisExp
		{
			[CompilerGenerated]
			get
			{
				return w2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Settings_CheckedChanged;
				CheckBox checkBox = w2;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				w2 = value;
				checkBox = w2;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		internal virtual CheckBox CheckBox_LeaderDissNotEnough
		{
			[CompilerGenerated]
			get
			{
				return w3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Settings_CheckedChanged;
				CheckBox checkBox = w3;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				w3 = value;
				checkBox = w3;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		internal virtual Label Label_IdLeader
		{
			[CompilerGenerated]
			get
			{
				return w4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				w4 = value;
			}
		}

		internal virtual DataColumn DataColumn515
		{
			[CompilerGenerated]
			get
			{
				return w5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				w5 = value;
			}
		}

		internal virtual DataColumn DataColumn516
		{
			[CompilerGenerated]
			get
			{
				return w6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				w6 = value;
			}
		}

		internal virtual TabPage TabPage6
		{
			[CompilerGenerated]
			get
			{
				return w7;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				w7 = value;
			}
		}

		internal virtual GroupBox GroupBox11
		{
			[CompilerGenerated]
			get
			{
				return w8;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				w8 = value;
			}
		}

		internal virtual Label Label84
		{
			[CompilerGenerated]
			get
			{
				return w9;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				w9 = value;
			}
		}

		internal virtual TextBox TextBox_OpenMachine_PetSp
		{
			[CompilerGenerated]
			get
			{
				return xa;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyPressEventHandler value2 = NumericTextBox_KeyPress;
				EventHandler value3 = TextBox_NumericValue_TextChanged;
				TextBox textBox = xa;
				if (textBox != null)
				{
					textBox.KeyPress -= value2;
					textBox.TextChanged -= value3;
				}
				xa = value;
				textBox = xa;
				if (textBox != null)
				{
					textBox.KeyPress += value2;
					textBox.TextChanged += value3;
				}
			}
		}

		internal virtual Label Label85
		{
			[CompilerGenerated]
			get
			{
				return xb;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				xb = value;
			}
		}

		internal virtual TextBox TextBox_OpenMachine_PetHp
		{
			[CompilerGenerated]
			get
			{
				return xc;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyPressEventHandler value2 = NumericTextBox_KeyPress;
				EventHandler value3 = TextBox_NumericValue_TextChanged;
				TextBox textBox = xc;
				if (textBox != null)
				{
					textBox.KeyPress -= value2;
					textBox.TextChanged -= value3;
				}
				xc = value;
				textBox = xc;
				if (textBox != null)
				{
					textBox.KeyPress += value2;
					textBox.TextChanged += value3;
				}
			}
		}

		internal virtual Label Label86
		{
			[CompilerGenerated]
			get
			{
				return xd;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				xd = value;
			}
		}

		internal virtual Label Label87
		{
			[CompilerGenerated]
			get
			{
				return xe;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				xe = value;
			}
		}

		internal virtual Label Label88
		{
			[CompilerGenerated]
			get
			{
				return xf;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				xf = value;
			}
		}

		internal virtual TextBox TextBox_OpenMachine_CharSp
		{
			[CompilerGenerated]
			get
			{
				return xg;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyPressEventHandler value2 = NumericTextBox_KeyPress;
				EventHandler value3 = TextBox_NumericValue_TextChanged;
				TextBox textBox = xg;
				if (textBox != null)
				{
					textBox.KeyPress -= value2;
					textBox.TextChanged -= value3;
				}
				xg = value;
				textBox = xg;
				if (textBox != null)
				{
					textBox.KeyPress += value2;
					textBox.TextChanged += value3;
				}
			}
		}

		internal virtual Label Label89
		{
			[CompilerGenerated]
			get
			{
				return xh;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				xh = value;
			}
		}

		internal virtual TextBox TextBox_OpenMachine_CharHp
		{
			[CompilerGenerated]
			get
			{
				return xi;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyPressEventHandler value2 = NumericTextBox_KeyPress;
				EventHandler value3 = TextBox_NumericValue_TextChanged;
				TextBox textBox = xi;
				if (textBox != null)
				{
					textBox.KeyPress -= value2;
					textBox.TextChanged -= value3;
				}
				xi = value;
				textBox = xi;
				if (textBox != null)
				{
					textBox.KeyPress += value2;
					textBox.TextChanged += value3;
				}
			}
		}

		internal virtual Label Label90
		{
			[CompilerGenerated]
			get
			{
				return xj;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				xj = value;
			}
		}

		internal virtual Label Label91
		{
			[CompilerGenerated]
			get
			{
				return xk;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				xk = value;
			}
		}

		internal virtual DataColumn DataColumn517
		{
			[CompilerGenerated]
			get
			{
				return xl;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				xl = value;
			}
		}

		internal virtual DataColumn DataColumn518
		{
			[CompilerGenerated]
			get
			{
				return xm;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				xm = value;
			}
		}

		internal virtual DataColumn DataColumn519
		{
			[CompilerGenerated]
			get
			{
				return xn;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				xn = value;
			}
		}

		internal virtual DataColumn DataColumn520
		{
			[CompilerGenerated]
			get
			{
				return xo;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				xo = value;
			}
		}

		internal virtual DataColumn DataColumn521
		{
			[CompilerGenerated]
			get
			{
				return xp;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				xp = value;
			}
		}

		internal virtual DataColumn DataColumn522
		{
			[CompilerGenerated]
			get
			{
				return xq;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				xq = value;
			}
		}

		internal virtual DataColumn DataColumn523
		{
			[CompilerGenerated]
			get
			{
				return xr;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				xr = value;
			}
		}

		internal virtual DataColumn DataColumn524
		{
			[CompilerGenerated]
			get
			{
				return xs;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				xs = value;
			}
		}

		internal virtual DataColumn DataColumn525
		{
			[CompilerGenerated]
			get
			{
				return xt;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				xt = value;
			}
		}

		internal virtual DataColumn DataColumn526
		{
			[CompilerGenerated]
			get
			{
				return xu;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				xu = value;
			}
		}

		internal virtual DataColumn DataColumn527
		{
			[CompilerGenerated]
			get
			{
				return xv;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				xv = value;
			}
		}

		internal virtual DataColumn DataColumn528
		{
			[CompilerGenerated]
			get
			{
				return xw;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				xw = value;
			}
		}

		internal virtual DataColumn DataColumn529
		{
			[CompilerGenerated]
			get
			{
				return xx;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				xx = value;
			}
		}

		internal virtual DataColumn DataColumn530
		{
			[CompilerGenerated]
			get
			{
				return xy;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				xy = value;
			}
		}

		internal virtual DataColumn DataColumn531
		{
			[CompilerGenerated]
			get
			{
				return xz;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				xz = value;
			}
		}

		internal virtual DataColumn DataColumn532
		{
			[CompilerGenerated]
			get
			{
				return x0;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				x0 = value;
			}
		}

		internal virtual DataColumn DataColumn533
		{
			[CompilerGenerated]
			get
			{
				return x1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				x1 = value;
			}
		}

		internal virtual DataColumn DataColumn534
		{
			[CompilerGenerated]
			get
			{
				return x2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				x2 = value;
			}
		}

		internal virtual DataColumn DataColumn535
		{
			[CompilerGenerated]
			get
			{
				return x3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				x3 = value;
			}
		}

		internal virtual DataColumn DataColumn536
		{
			[CompilerGenerated]
			get
			{
				return x4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				x4 = value;
			}
		}

		internal virtual DataColumn DataColumn537
		{
			[CompilerGenerated]
			get
			{
				return x5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				x5 = value;
			}
		}

		internal virtual DataColumn DataColumn538
		{
			[CompilerGenerated]
			get
			{
				return x6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				x6 = value;
			}
		}

		internal virtual DataColumn DataColumn539
		{
			[CompilerGenerated]
			get
			{
				return x7;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				x7 = value;
			}
		}

		internal virtual DataColumn DataColumn540
		{
			[CompilerGenerated]
			get
			{
				return x8;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				x8 = value;
			}
		}

		internal virtual DataColumn DataColumn541
		{
			[CompilerGenerated]
			get
			{
				return x9;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				x9 = value;
			}
		}

		internal virtual DataColumn DataColumn542
		{
			[CompilerGenerated]
			get
			{
				return ya;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ya = value;
			}
		}

		internal virtual DataColumn DataColumn543
		{
			[CompilerGenerated]
			get
			{
				return yb;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				yb = value;
			}
		}

		internal virtual DataColumn DataColumn544
		{
			[CompilerGenerated]
			get
			{
				return yc;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				yc = value;
			}
		}

		internal virtual DataColumn DataColumn545
		{
			[CompilerGenerated]
			get
			{
				return yd;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				yd = value;
			}
		}

		internal virtual DataColumn DataColumn546
		{
			[CompilerGenerated]
			get
			{
				return ye;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ye = value;
			}
		}

		internal virtual DataColumn DataColumn547
		{
			[CompilerGenerated]
			get
			{
				return yf;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				yf = value;
			}
		}

		internal virtual DataColumn DataColumn548
		{
			[CompilerGenerated]
			get
			{
				return yg;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				yg = value;
			}
		}

		internal virtual DataColumn DataColumn549
		{
			[CompilerGenerated]
			get
			{
				return yh;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				yh = value;
			}
		}

		internal virtual DataColumn DataColumn550
		{
			[CompilerGenerated]
			get
			{
				return yi;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				yi = value;
			}
		}

		internal virtual DataColumn DataColumn551
		{
			[CompilerGenerated]
			get
			{
				return yj;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				yj = value;
			}
		}

		internal virtual DataColumn DataColumn552
		{
			[CompilerGenerated]
			get
			{
				return yk;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				yk = value;
			}
		}

		internal virtual DataColumn DataColumn553
		{
			[CompilerGenerated]
			get
			{
				return yl;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				yl = value;
			}
		}

		internal virtual DataColumn DataColumn554
		{
			[CompilerGenerated]
			get
			{
				return ym;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ym = value;
			}
		}

		internal virtual DataColumn DataColumn555
		{
			[CompilerGenerated]
			get
			{
				return yn;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				yn = value;
			}
		}

		internal virtual DataColumn DataColumn556
		{
			[CompilerGenerated]
			get
			{
				return yo;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				yo = value;
			}
		}

		internal virtual CheckBox CheckBox_Pet_ChangeTG
		{
			[CompilerGenerated]
			get
			{
				return yp;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Settings_CheckedChanged;
				CheckBox checkBox = yp;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				yp = value;
				checkBox = yp;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		internal virtual CheckBox CheckBox_Char_ChangeTG
		{
			[CompilerGenerated]
			get
			{
				return yq;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Settings_CheckedChanged;
				CheckBox checkBox = yq;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				yq = value;
				checkBox = yq;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		internal virtual Label Label_Mini
		{
			[CompilerGenerated]
			get
			{
				return yr;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				yr = value;
			}
		}

		internal virtual DataColumn DataColumn557
		{
			[CompilerGenerated]
			get
			{
				return ys;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ys = value;
			}
		}

		internal virtual Button Button_OutParty
		{
			[CompilerGenerated]
			get
			{
				return yt;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button_OutParty_Click;
				Button button = yt;
				if (button != null)
				{
					button.Click -= value2;
				}
				yt = value;
				button = yt;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual StatusBarPanel StatusBarPanel_MapName
		{
			[CompilerGenerated]
			get
			{
				return yu;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				yu = value;
			}
		}

		internal virtual DataColumn DataColumn558
		{
			[CompilerGenerated]
			get
			{
				return yv;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				yv = value;
			}
		}

		internal virtual DataColumn DataColumn559
		{
			[CompilerGenerated]
			get
			{
				return yw;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				yw = value;
			}
		}

		internal virtual DataColumn DataColumn560
		{
			[CompilerGenerated]
			get
			{
				return yx;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				yx = value;
			}
		}

		internal virtual DataColumn DataColumn561
		{
			[CompilerGenerated]
			get
			{
				return yy;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				yy = value;
			}
		}

		internal virtual DataColumn DataColumn562
		{
			[CompilerGenerated]
			get
			{
				return yz;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				yz = value;
			}
		}

		internal virtual DataColumn DataColumn563
		{
			[CompilerGenerated]
			get
			{
				return y0;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				y0 = value;
			}
		}

		internal virtual DataColumn DataColumn564
		{
			[CompilerGenerated]
			get
			{
				return y1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				y1 = value;
			}
		}

		internal virtual DataColumn DataColumn565
		{
			[CompilerGenerated]
			get
			{
				return y2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				y2 = value;
			}
		}

		internal virtual DataColumn DataColumn566
		{
			[CompilerGenerated]
			get
			{
				return y3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				y3 = value;
			}
		}

		internal virtual DataColumn DataColumn567
		{
			[CompilerGenerated]
			get
			{
				return y4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				y4 = value;
			}
		}

		internal virtual DataColumn DataColumn568
		{
			[CompilerGenerated]
			get
			{
				return y5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				y5 = value;
			}
		}

		internal virtual DataColumn DataColumn569
		{
			[CompilerGenerated]
			get
			{
				return y6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				y6 = value;
			}
		}

		internal virtual DataColumn DataColumn570
		{
			[CompilerGenerated]
			get
			{
				return y7;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				y7 = value;
			}
		}

		internal virtual DataColumn DataColumn571
		{
			[CompilerGenerated]
			get
			{
				return y8;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				y8 = value;
			}
		}

		internal virtual DataColumn DataColumn572
		{
			[CompilerGenerated]
			get
			{
				return y9;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				y9 = value;
			}
		}

		internal virtual DataColumn DataColumn573
		{
			[CompilerGenerated]
			get
			{
				return za;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				za = value;
			}
		}

		internal virtual DataColumn DataColumn574
		{
			[CompilerGenerated]
			get
			{
				return zb;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				zb = value;
			}
		}

		internal virtual DataColumn DataColumn575
		{
			[CompilerGenerated]
			get
			{
				return zc;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				zc = value;
			}
		}

		internal virtual DataColumn DataColumn576
		{
			[CompilerGenerated]
			get
			{
				return zd;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				zd = value;
			}
		}

		internal virtual DataColumn DataColumn577
		{
			[CompilerGenerated]
			get
			{
				return ze;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ze = value;
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
			get
			{
				return zg;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				zg = value;
			}
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
			get
			{
				return zi;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				zi = value;
			}
		}

		internal virtual ColumnHeader ColumnHeader_Name
		{
			[CompilerGenerated]
			get
			{
				return zj;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				zj = value;
			}
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
			get
			{
				return zl;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				zl = value;
			}
		}

		internal virtual ColumnHeader ColumnHeader2
		{
			[CompilerGenerated]
			get
			{
				return zm;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				zm = value;
			}
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
			get
			{
				return zo;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				zo = value;
			}
		}

		internal virtual ColumnHeader ColumnHeader4
		{
			[CompilerGenerated]
			get
			{
				return zp;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				zp = value;
			}
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
			get
			{
				return zr;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				zr = value;
			}
		}

		internal virtual ColumnHeader ColumnHeader11
		{
			[CompilerGenerated]
			get
			{
				return zs;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				zs = value;
			}
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
			get
			{
				return zu;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				zu = value;
			}
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
			get
			{
				return zx;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				zx = value;
			}
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
			get
			{
				return zz;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				zz = value;
			}
		}

		internal virtual ColumnHeader ColumnHeader13
		{
			[CompilerGenerated]
			get
			{
				return z0;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				z0 = value;
			}
		}

		internal virtual ColumnHeader ColumnHeader14
		{
			[CompilerGenerated]
			get
			{
				return z1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				z1 = value;
			}
		}

		internal virtual DataGridView DataGridView1
		{
			[CompilerGenerated]
			get
			{
				return z2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				z2 = value;
			}
		}

		internal virtual Label Label_Lv2
		{
			[CompilerGenerated]
			get
			{
				return z3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				z3 = value;
			}
		}

		internal virtual Label Label_Lv_Plus
		{
			[CompilerGenerated]
			get
			{
				return z4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				z4 = value;
			}
		}

		internal virtual DataGridViewCheckBoxColumn Column_Quest_check
		{
			[CompilerGenerated]
			get
			{
				return z5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				z5 = value;
			}
		}

		internal virtual DataGridViewTextBoxColumn Column_Quest_Func
		{
			[CompilerGenerated]
			get
			{
				return z6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				z6 = value;
			}
		}

		internal virtual DataGridViewTextBoxColumn Column_Quest_Id
		{
			[CompilerGenerated]
			get
			{
				return z7;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				z7 = value;
			}
		}

		internal virtual DataGridViewTextBoxColumn Column_Quest_Info
		{
			[CompilerGenerated]
			get
			{
				return z8;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				z8 = value;
			}
		}

		internal virtual ComboBox ComboBox_ShopType
		{
			[CompilerGenerated]
			get
			{
				return z9;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				z9 = value;
			}
		}

		internal virtual Label Label38
		{
			[CompilerGenerated]
			get
			{
				return aaa;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				aaa = value;
			}
		}

		internal virtual Label Label_ShopName
		{
			[CompilerGenerated]
			get
			{
				return aab;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				aab = value;
			}
		}

		internal virtual TextBox TextBox_ShopName
		{
			[CompilerGenerated]
			get
			{
				return aac;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				aac = value;
			}
		}

		internal virtual Label Label40
		{
			[CompilerGenerated]
			get
			{
				return aad;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				aad = value;
			}
		}

		internal virtual Label Label39
		{
			[CompilerGenerated]
			get
			{
				return aae;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				aae = value;
			}
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
			get
			{
				return aaj;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				aaj = value;
			}
		}

		internal virtual ColumnHeader ColumnHeader16
		{
			[CompilerGenerated]
			get
			{
				return aak;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				aak = value;
			}
		}

		internal virtual ColumnHeader ColumnHeader17
		{
			[CompilerGenerated]
			get
			{
				return aal;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				aal = value;
			}
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
			get
			{
				return aao;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				aao = value;
			}
		}

		internal virtual NumericUpDown NumericUpDown_sendpacket
		{
			[CompilerGenerated]
			get
			{
				return aap;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				aap = value;
			}
		}

		internal virtual Label Label41
		{
			[CompilerGenerated]
			get
			{
				return aaq;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				aaq = value;
			}
		}

		internal virtual TextBox TextBox_idQC
		{
			[CompilerGenerated]
			get
			{
				return aar;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				aar = value;
			}
		}

		internal virtual CheckBox CheckBox_QC
		{
			[CompilerGenerated]
			get
			{
				return aas;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				aas = value;
			}
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
			get
			{
				return aav;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				aav = value;
			}
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
			get
			{
				return aaz;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				aaz = value;
			}
		}

		internal virtual ColumnHeader ColumnHeader19
		{
			[CompilerGenerated]
			get
			{
				return aa0;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				aa0 = value;
			}
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
			get
			{
				return aa3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				aa3 = value;
			}
		}

		internal virtual Label Lb_tuido24
		{
			[CompilerGenerated]
			get
			{
				return aa4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				aa4 = value;
			}
		}

		internal virtual Label Lb_tuido23
		{
			[CompilerGenerated]
			get
			{
				return aa5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				aa5 = value;
			}
		}

		internal virtual Label Lb_tuido22
		{
			[CompilerGenerated]
			get
			{
				return aa6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				aa6 = value;
			}
		}

		internal virtual Label Lb_tuido21
		{
			[CompilerGenerated]
			get
			{
				return aa7;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				aa7 = value;
			}
		}

		internal virtual Label Lb_tuido20
		{
			[CompilerGenerated]
			get
			{
				return aa8;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				aa8 = value;
			}
		}

		internal virtual Label Lb_tuido19
		{
			[CompilerGenerated]
			get
			{
				return aa9;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				aa9 = value;
			}
		}

		internal virtual Label Lb_tuido18
		{
			[CompilerGenerated]
			get
			{
				return aba;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				aba = value;
			}
		}

		internal virtual Label Lb_tuido17
		{
			[CompilerGenerated]
			get
			{
				return abb;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				abb = value;
			}
		}

		internal virtual Label Lb_tuido16
		{
			[CompilerGenerated]
			get
			{
				return abc;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				abc = value;
			}
		}

		internal virtual Label Lb_tuido15
		{
			[CompilerGenerated]
			get
			{
				return abd;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				abd = value;
			}
		}

		internal virtual Label Lb_tuido14
		{
			[CompilerGenerated]
			get
			{
				return abe;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				abe = value;
			}
		}

		internal virtual Label Lb_tuido13
		{
			[CompilerGenerated]
			get
			{
				return abf;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				abf = value;
			}
		}

		internal virtual Label Lb_tuido12
		{
			[CompilerGenerated]
			get
			{
				return abg;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				abg = value;
			}
		}

		internal virtual Label Lb_tuido11
		{
			[CompilerGenerated]
			get
			{
				return abh;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				abh = value;
			}
		}

		internal virtual Label Lb_tuido10
		{
			[CompilerGenerated]
			get
			{
				return abi;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				abi = value;
			}
		}

		internal virtual Label Lb_tuido9
		{
			[CompilerGenerated]
			get
			{
				return abj;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				abj = value;
			}
		}

		internal virtual Label Lb_tuido8
		{
			[CompilerGenerated]
			get
			{
				return abk;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				abk = value;
			}
		}

		internal virtual Label Lb_tuido7
		{
			[CompilerGenerated]
			get
			{
				return abl;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				abl = value;
			}
		}

		internal virtual Label Lb_tuido6
		{
			[CompilerGenerated]
			get
			{
				return abm;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				abm = value;
			}
		}

		internal virtual Label Lb_tuido5
		{
			[CompilerGenerated]
			get
			{
				return abn;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				abn = value;
			}
		}

		internal virtual Label Lb_tuido4
		{
			[CompilerGenerated]
			get
			{
				return abo;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				abo = value;
			}
		}

		internal virtual Label Lb_tuido3
		{
			[CompilerGenerated]
			get
			{
				return abp;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				abp = value;
			}
		}

		internal virtual Label Lb_tuido2
		{
			[CompilerGenerated]
			get
			{
				return abq;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				abq = value;
			}
		}

		internal virtual Label Lb_tuido1
		{
			[CompilerGenerated]
			get
			{
				return abr;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				abr = value;
			}
		}

		internal virtual Label Lb_tuideo25
		{
			[CompilerGenerated]
			get
			{
				return abs;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				abs = value;
			}
		}

		internal virtual Label Lb_tuideo24
		{
			[CompilerGenerated]
			get
			{
				return abt;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				abt = value;
			}
		}

		internal virtual Label Lb_tuideo23
		{
			[CompilerGenerated]
			get
			{
				return abu;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				abu = value;
			}
		}

		internal virtual Label Lb_tuideo22
		{
			[CompilerGenerated]
			get
			{
				return abv;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				abv = value;
			}
		}

		internal virtual Label Lb_tuideo21
		{
			[CompilerGenerated]
			get
			{
				return abw;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				abw = value;
			}
		}

		internal virtual Label Lb_tuideo20
		{
			[CompilerGenerated]
			get
			{
				return abx;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				abx = value;
			}
		}

		internal virtual Label Lb_tuideo19
		{
			[CompilerGenerated]
			get
			{
				return aby;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				aby = value;
			}
		}

		internal virtual Label Lb_tuideo18
		{
			[CompilerGenerated]
			get
			{
				return abz;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				abz = value;
			}
		}

		internal virtual Label Lb_tuideo17
		{
			[CompilerGenerated]
			get
			{
				return ab0;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ab0 = value;
			}
		}

		internal virtual Label Lb_tuideo16
		{
			[CompilerGenerated]
			get
			{
				return ab1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ab1 = value;
			}
		}

		internal virtual Label Lb_tuideo15
		{
			[CompilerGenerated]
			get
			{
				return ab2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ab2 = value;
			}
		}

		internal virtual Label Lb_tuideo14
		{
			[CompilerGenerated]
			get
			{
				return ab3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ab3 = value;
			}
		}

		internal virtual Label Lb_tuideo13
		{
			[CompilerGenerated]
			get
			{
				return ab4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ab4 = value;
			}
		}

		internal virtual Label Lb_tuideo12
		{
			[CompilerGenerated]
			get
			{
				return ab5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ab5 = value;
			}
		}

		internal virtual Label Lb_tuideo11
		{
			[CompilerGenerated]
			get
			{
				return ab6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ab6 = value;
			}
		}

		internal virtual Label Lb_tuideo10
		{
			[CompilerGenerated]
			get
			{
				return ab7;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ab7 = value;
			}
		}

		internal virtual Label Lb_tuideo9
		{
			[CompilerGenerated]
			get
			{
				return ab8;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ab8 = value;
			}
		}

		internal virtual Label Lb_tuideo8
		{
			[CompilerGenerated]
			get
			{
				return ab9;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ab9 = value;
			}
		}

		internal virtual Label Lb_tuideo7
		{
			[CompilerGenerated]
			get
			{
				return aca;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				aca = value;
			}
		}

		internal virtual Label Lb_tuideo6
		{
			[CompilerGenerated]
			get
			{
				return acb;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				acb = value;
			}
		}

		internal virtual Label Lb_tuideo5
		{
			[CompilerGenerated]
			get
			{
				return acc;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				acc = value;
			}
		}

		internal virtual Label Lb_tuideo4
		{
			[CompilerGenerated]
			get
			{
				return acd;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				acd = value;
			}
		}

		internal virtual Label Lb_tuideo3
		{
			[CompilerGenerated]
			get
			{
				return ace;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ace = value;
			}
		}

		internal virtual Label Lb_tuideo2
		{
			[CompilerGenerated]
			get
			{
				return acf;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				acf = value;
			}
		}

		internal virtual Label Lb_tuideo1
		{
			[CompilerGenerated]
			get
			{
				return acg;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				acg = value;
			}
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
			get
			{
				return aci;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				aci = value;
			}
		}

		internal virtual TabPage TabPage_Attack
		{
			[CompilerGenerated]
			get
			{
				return acj;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				acj = value;
			}
		}

		internal virtual Vs2010ToolStrip miniToolStrip
		{
			[CompilerGenerated]
			get
			{
				return ack;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ack = value;
			}
		}

		internal virtual Vs2010ToolStrip ToolStrip1
		{
			[CompilerGenerated]
			get
			{
				return acl;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				acl = value;
			}
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
			get
			{
				return acn;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				acn = value;
			}
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
			get
			{
				return acp;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				acp = value;
			}
		}

		internal virtual Panel Panel10
		{
			[CompilerGenerated]
			get
			{
				return acq;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				acq = value;
			}
		}

		internal virtual Panel Panel9
		{
			[CompilerGenerated]
			get
			{
				return acr;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				acr = value;
			}
		}

		internal virtual PictureBox PictureBox_Pet_photo
		{
			[CompilerGenerated]
			get
			{
				return acs;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				acs = value;
			}
		}

		internal virtual PictureBox PictureBox_char5
		{
			[CompilerGenerated]
			get
			{
				return act;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				act = value;
			}
		}

		internal virtual PictureBox PictureBox_char6
		{
			[CompilerGenerated]
			get
			{
				return acu;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				acu = value;
			}
		}

		internal virtual PictureBox PictureBox_char3
		{
			[CompilerGenerated]
			get
			{
				return acv;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				acv = value;
			}
		}

		internal virtual PictureBox PictureBox_char2
		{
			[CompilerGenerated]
			get
			{
				return acw;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				acw = value;
			}
		}

		internal virtual PictureBox PictureBox_char4
		{
			[CompilerGenerated]
			get
			{
				return acx;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				acx = value;
			}
		}

		internal virtual PictureBox PictureBox_char1
		{
			[CompilerGenerated]
			get
			{
				return acy;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				acy = value;
			}
		}

		internal virtual PictureBox PictureBox_Pet5
		{
			[CompilerGenerated]
			get
			{
				return acz;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				acz = value;
			}
		}

		internal virtual PictureBox PictureBox_Pet6
		{
			[CompilerGenerated]
			get
			{
				return ac0;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ac0 = value;
			}
		}

		internal virtual PictureBox PictureBox_Pet3
		{
			[CompilerGenerated]
			get
			{
				return ac1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ac1 = value;
			}
		}

		internal virtual PictureBox PictureBox_Pet2
		{
			[CompilerGenerated]
			get
			{
				return ac2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ac2 = value;
			}
		}

		internal virtual PictureBox PictureBox_Pet4
		{
			[CompilerGenerated]
			get
			{
				return ac3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ac3 = value;
			}
		}

		internal virtual PictureBox PictureBox_Pet1
		{
			[CompilerGenerated]
			get
			{
				return ac4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ac4 = value;
			}
		}

		internal virtual PictureBox PictureBox_Pet_Thuoctinh
		{
			[CompilerGenerated]
			get
			{
				return ac5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ac5 = value;
			}
		}

		internal virtual PictureBox PictureBox_Char_Thuoctinh
		{
			[CompilerGenerated]
			get
			{
				return ac6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ac6 = value;
			}
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
			get
			{
				return ac8;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ac8 = value;
			}
		}

		internal virtual Label Label_Char_agi
		{
			[CompilerGenerated]
			get
			{
				return ac9;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ac9 = value;
			}
		}

		internal virtual Label Label_Char_spx
		{
			[CompilerGenerated]
			get
			{
				return ada;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ada = value;
			}
		}

		internal virtual Label Label_Char_hpx
		{
			[CompilerGenerated]
			get
			{
				return adb;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				adb = value;
			}
		}

		internal virtual Label Label_Char_def
		{
			[CompilerGenerated]
			get
			{
				return adc;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				adc = value;
			}
		}

		internal virtual Label Label_Char_atk
		{
			[CompilerGenerated]
			get
			{
				return add;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				add = value;
			}
		}

		internal virtual Label Label_Char_int
		{
			[CompilerGenerated]
			get
			{
				return ade;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ade = value;
			}
		}

		internal virtual Label Label_Pet_fai
		{
			[CompilerGenerated]
			get
			{
				return adf;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				adf = value;
			}
		}

		internal virtual Label Label_Pet_agi
		{
			[CompilerGenerated]
			get
			{
				return adg;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				adg = value;
			}
		}

		internal virtual Label Label_Pet_spx
		{
			[CompilerGenerated]
			get
			{
				return adh;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				adh = value;
			}
		}

		internal virtual Label Label_Pet_hpx
		{
			[CompilerGenerated]
			get
			{
				return adi;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				adi = value;
			}
		}

		internal virtual Label Label_Pet_def
		{
			[CompilerGenerated]
			get
			{
				return adj;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				adj = value;
			}
		}

		internal virtual Label Label_Pet_atk
		{
			[CompilerGenerated]
			get
			{
				return adk;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				adk = value;
			}
		}

		internal virtual Label Label_Pet_int
		{
			[CompilerGenerated]
			get
			{
				return adl;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				adl = value;
			}
		}

		internal virtual TabPage TabPage_Quest
		{
			[CompilerGenerated]
			get
			{
				return adm;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				adm = value;
			}
		}

		internal virtual TabPage TabPage_Warp
		{
			[CompilerGenerated]
			get
			{
				return adn;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				adn = value;
			}
		}

		internal virtual TabPage TabPage_Players
		{
			[CompilerGenerated]
			get
			{
				return ado;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ado = value;
			}
		}

		internal virtual TabPage TabPage_Setting
		{
			[CompilerGenerated]
			get
			{
				return adp;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				adp = value;
			}
		}

		internal virtual TabPage TabPage_Shop
		{
			[CompilerGenerated]
			get
			{
				return adq;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				adq = value;
			}
		}

		internal virtual TabPage TabPage4
		{
			[CompilerGenerated]
			get
			{
				return adr;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				adr = value;
			}
		}

		internal virtual TabPage TabPage_Map
		{
			[CompilerGenerated]
			get
			{
				return ads;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ads = value;
			}
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
			get
			{
				return adw;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				adw = value;
			}
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
			get
			{
				return ady;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ady = value;
			}
		}

		internal virtual ToolStripMenuItem ToolStripMenuItem_ContributeItem
		{
			[CompilerGenerated]
			get
			{
				return adz;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				adz = value;
			}
		}

		internal virtual ToolStripSeparator ToolStripSeparator4
		{
			[CompilerGenerated]
			get
			{
				return ad0;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ad0 = value;
			}
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
			get
			{
				return ad3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ad3 = value;
			}
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
			get
			{
				return aea;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				aea = value;
			}
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
			get
			{
				return aef;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				aef = value;
			}
		}

		internal virtual ToolStripSeparator ToolStripSeparator6
		{
			[CompilerGenerated]
			get
			{
				return aeg;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				aeg = value;
			}
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
			get
			{
				return aei;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				aei = value;
			}
		}


		[DebuggerNonUserCode]
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

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmClient));
			Vs2010TabControlRenderer vs2010TabControlRenderer = new Vs2010TabControlRenderer();
			Vs2010DefaultTabControlColorTable colorTable = new Vs2010DefaultTabControlColorTable();
			Vs2010ToolStripRenderer vs2010ToolStripRenderer = new Vs2010ToolStripRenderer();
			Vs2010DefaultToolStripColorTable colorTable2 = new Vs2010DefaultToolStripColorTable();
			Vs2010TabControlRenderer vs2010TabControlRenderer2 = new Vs2010TabControlRenderer();
			Vs2010DefaultTabControlColorTable colorTable3 = new Vs2010DefaultTabControlColorTable();
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			Vs2010ToolStripRenderer vs2010ToolStripRenderer2 = new Vs2010ToolStripRenderer();
			Vs2010DefaultToolStripColorTable colorTable4 = new Vs2010DefaultToolStripColorTable();
			DataSet1 = new DataSet();
			DataTable1 = new DataTable();
			DataColumn1 = new DataColumn();
			DataColumn2 = new DataColumn();
			DataColumn3 = new DataColumn();
			DataColumn4 = new DataColumn();
			DataColumn5 = new DataColumn();
			DataColumn6 = new DataColumn();
			DataColumn7 = new DataColumn();
			DataColumn8 = new DataColumn();
			DataColumn243 = new DataColumn();
			DataTable2 = new DataTable();
			DataColumn9 = new DataColumn();
			DataColumn10 = new DataColumn();
			DataColumn11 = new DataColumn();
			DataColumn12 = new DataColumn();
			DataColumn13 = new DataColumn();
			DataColumn14 = new DataColumn();
			DataColumn15 = new DataColumn();
			DataColumn16 = new DataColumn();
			DataColumn17 = new DataColumn();
			DataColumn18 = new DataColumn();
			DataColumn19 = new DataColumn();
			DataColumn20 = new DataColumn();
			DataColumn21 = new DataColumn();
			DataColumn22 = new DataColumn();
			DataColumn34 = new DataColumn();
			DataColumn117 = new DataColumn();
			DataColumn118 = new DataColumn();
			DataColumn119 = new DataColumn();
			DataColumn120 = new DataColumn();
			DataColumn121 = new DataColumn();
			DataColumn122 = new DataColumn();
			DataColumn123 = new DataColumn();
			DataColumn124 = new DataColumn();
			DataColumn125 = new DataColumn();
			DataColumn126 = new DataColumn();
			DataColumn127 = new DataColumn();
			DataColumn128 = new DataColumn();
			DataColumn240 = new DataColumn();
			DataColumn241 = new DataColumn();
			DataColumn242 = new DataColumn();
			DataColumn244 = new DataColumn();
			DataColumn245 = new DataColumn();
			DataColumn246 = new DataColumn();
			DataColumn247 = new DataColumn();
			DataColumn456 = new DataColumn();
			DataColumn457 = new DataColumn();
			DataColumn458 = new DataColumn();
			DataColumn459 = new DataColumn();
			DataColumn460 = new DataColumn();
			DataColumn461 = new DataColumn();
			DataColumn498 = new DataColumn();
			DataColumn514 = new DataColumn();
			DataColumn557 = new DataColumn();
			DataTable3 = new DataTable();
			DataColumn23 = new DataColumn();
			DataColumn24 = new DataColumn();
			DataColumn25 = new DataColumn();
			DataColumn26 = new DataColumn();
			DataColumn27 = new DataColumn();
			DataColumn28 = new DataColumn();
			DataColumn29 = new DataColumn();
			DataColumn30 = new DataColumn();
			DataColumn31 = new DataColumn();
			DataColumn32 = new DataColumn();
			DataColumn33 = new DataColumn();
			DataColumn129 = new DataColumn();
			DataColumn130 = new DataColumn();
			DataColumn131 = new DataColumn();
			DataColumn132 = new DataColumn();
			DataColumn133 = new DataColumn();
			DataColumn134 = new DataColumn();
			DataColumn135 = new DataColumn();
			DataColumn136 = new DataColumn();
			DataColumn137 = new DataColumn();
			DataColumn138 = new DataColumn();
			DataColumn139 = new DataColumn();
			DataColumn140 = new DataColumn();
			DataColumn231 = new DataColumn();
			DataColumn239 = new DataColumn();
			DataColumn492 = new DataColumn();
			DataColumn493 = new DataColumn();
			DataColumn494 = new DataColumn();
			DataColumn495 = new DataColumn();
			DataColumn496 = new DataColumn();
			DataColumn497 = new DataColumn();
			DataColumn499 = new DataColumn();
			DataTable4 = new DataTable();
			DataColumn35 = new DataColumn();
			DataColumn36 = new DataColumn();
			DataColumn37 = new DataColumn();
			DataColumn38 = new DataColumn();
			DataColumn39 = new DataColumn();
			DataTable5 = new DataTable();
			DataColumn40 = new DataColumn();
			DataColumn41 = new DataColumn();
			DataColumn42 = new DataColumn();
			DataColumn43 = new DataColumn();
			DataColumn44 = new DataColumn();
			DataTable6 = new DataTable();
			DataColumn45 = new DataColumn();
			DataColumn46 = new DataColumn();
			DataColumn47 = new DataColumn();
			DataColumn48 = new DataColumn();
			DataColumn49 = new DataColumn();
			DataColumn50 = new DataColumn();
			DataColumn51 = new DataColumn();
			DataColumn52 = new DataColumn();
			DataColumn53 = new DataColumn();
			DataColumn54 = new DataColumn();
			DataColumn55 = new DataColumn();
			DataColumn56 = new DataColumn();
			DataColumn93 = new DataColumn();
			DataColumn141 = new DataColumn();
			DataColumn142 = new DataColumn();
			DataColumn143 = new DataColumn();
			DataColumn144 = new DataColumn();
			DataColumn145 = new DataColumn();
			DataColumn146 = new DataColumn();
			DataColumn147 = new DataColumn();
			DataColumn148 = new DataColumn();
			DataColumn149 = new DataColumn();
			DataColumn150 = new DataColumn();
			DataColumn151 = new DataColumn();
			DataColumn152 = new DataColumn();
			DataColumn114 = new DataColumn();
			DataColumn115 = new DataColumn();
			DataColumn116 = new DataColumn();
			DataColumn189 = new DataColumn();
			DataColumn190 = new DataColumn();
			DataColumn191 = new DataColumn();
			DataColumn462 = new DataColumn();
			DataColumn463 = new DataColumn();
			DataColumn464 = new DataColumn();
			DataColumn465 = new DataColumn();
			DataColumn466 = new DataColumn();
			DataColumn467 = new DataColumn();
			DataColumn501 = new DataColumn();
			DataTable7 = new DataTable();
			DataColumn57 = new DataColumn();
			DataColumn58 = new DataColumn();
			DataColumn59 = new DataColumn();
			DataColumn60 = new DataColumn();
			DataColumn61 = new DataColumn();
			DataColumn62 = new DataColumn();
			DataColumn63 = new DataColumn();
			DataColumn64 = new DataColumn();
			DataColumn65 = new DataColumn();
			DataColumn66 = new DataColumn();
			DataColumn67 = new DataColumn();
			DataColumn68 = new DataColumn();
			DataColumn94 = new DataColumn();
			DataColumn153 = new DataColumn();
			DataColumn154 = new DataColumn();
			DataColumn155 = new DataColumn();
			DataColumn156 = new DataColumn();
			DataColumn157 = new DataColumn();
			DataColumn158 = new DataColumn();
			DataColumn159 = new DataColumn();
			DataColumn160 = new DataColumn();
			DataColumn161 = new DataColumn();
			DataColumn162 = new DataColumn();
			DataColumn163 = new DataColumn();
			DataColumn164 = new DataColumn();
			DataColumn192 = new DataColumn();
			DataColumn193 = new DataColumn();
			DataColumn194 = new DataColumn();
			DataColumn195 = new DataColumn();
			DataColumn196 = new DataColumn();
			DataColumn197 = new DataColumn();
			DataColumn468 = new DataColumn();
			DataColumn469 = new DataColumn();
			DataColumn470 = new DataColumn();
			DataColumn471 = new DataColumn();
			DataColumn472 = new DataColumn();
			DataColumn473 = new DataColumn();
			DataColumn502 = new DataColumn();
			DataTable8 = new DataTable();
			DataColumn69 = new DataColumn();
			DataColumn70 = new DataColumn();
			DataColumn71 = new DataColumn();
			DataColumn72 = new DataColumn();
			DataColumn73 = new DataColumn();
			DataColumn74 = new DataColumn();
			DataColumn75 = new DataColumn();
			DataColumn76 = new DataColumn();
			DataColumn77 = new DataColumn();
			DataColumn78 = new DataColumn();
			DataColumn79 = new DataColumn();
			DataColumn80 = new DataColumn();
			DataColumn95 = new DataColumn();
			DataColumn165 = new DataColumn();
			DataColumn166 = new DataColumn();
			DataColumn167 = new DataColumn();
			DataColumn168 = new DataColumn();
			DataColumn169 = new DataColumn();
			DataColumn170 = new DataColumn();
			DataColumn171 = new DataColumn();
			DataColumn172 = new DataColumn();
			DataColumn173 = new DataColumn();
			DataColumn174 = new DataColumn();
			DataColumn175 = new DataColumn();
			DataColumn176 = new DataColumn();
			DataColumn198 = new DataColumn();
			DataColumn199 = new DataColumn();
			DataColumn200 = new DataColumn();
			DataColumn201 = new DataColumn();
			DataColumn202 = new DataColumn();
			DataColumn203 = new DataColumn();
			DataColumn474 = new DataColumn();
			DataColumn475 = new DataColumn();
			DataColumn476 = new DataColumn();
			DataColumn477 = new DataColumn();
			DataColumn478 = new DataColumn();
			DataColumn479 = new DataColumn();
			DataColumn503 = new DataColumn();
			DataTable9 = new DataTable();
			DataColumn81 = new DataColumn();
			DataColumn82 = new DataColumn();
			DataColumn83 = new DataColumn();
			DataColumn84 = new DataColumn();
			DataColumn85 = new DataColumn();
			DataColumn86 = new DataColumn();
			DataColumn87 = new DataColumn();
			DataColumn88 = new DataColumn();
			DataColumn89 = new DataColumn();
			DataColumn90 = new DataColumn();
			DataColumn91 = new DataColumn();
			DataColumn92 = new DataColumn();
			DataColumn96 = new DataColumn();
			DataColumn177 = new DataColumn();
			DataColumn178 = new DataColumn();
			DataColumn179 = new DataColumn();
			DataColumn180 = new DataColumn();
			DataColumn181 = new DataColumn();
			DataColumn182 = new DataColumn();
			DataColumn183 = new DataColumn();
			DataColumn184 = new DataColumn();
			DataColumn185 = new DataColumn();
			DataColumn186 = new DataColumn();
			DataColumn187 = new DataColumn();
			DataColumn188 = new DataColumn();
			DataColumn204 = new DataColumn();
			DataColumn205 = new DataColumn();
			DataColumn206 = new DataColumn();
			DataColumn207 = new DataColumn();
			DataColumn208 = new DataColumn();
			DataColumn209 = new DataColumn();
			DataColumn480 = new DataColumn();
			DataColumn481 = new DataColumn();
			DataColumn482 = new DataColumn();
			DataColumn483 = new DataColumn();
			DataColumn484 = new DataColumn();
			DataColumn485 = new DataColumn();
			DataColumn504 = new DataColumn();
			DataTable10 = new DataTable();
			DataColumn97 = new DataColumn();
			DataColumn98 = new DataColumn();
			DataColumn99 = new DataColumn();
			DataColumn100 = new DataColumn();
			DataColumn101 = new DataColumn();
			DataColumn102 = new DataColumn();
			DataColumn103 = new DataColumn();
			DataColumn104 = new DataColumn();
			DataColumn105 = new DataColumn();
			DataColumn106 = new DataColumn();
			DataColumn107 = new DataColumn();
			DataColumn108 = new DataColumn();
			DataColumn109 = new DataColumn();
			DataColumn210 = new DataColumn();
			DataColumn211 = new DataColumn();
			DataColumn212 = new DataColumn();
			DataColumn213 = new DataColumn();
			DataColumn214 = new DataColumn();
			DataColumn215 = new DataColumn();
			DataColumn216 = new DataColumn();
			DataColumn217 = new DataColumn();
			DataColumn218 = new DataColumn();
			DataColumn219 = new DataColumn();
			DataColumn220 = new DataColumn();
			DataColumn221 = new DataColumn();
			DataColumn222 = new DataColumn();
			DataColumn223 = new DataColumn();
			DataColumn224 = new DataColumn();
			DataColumn225 = new DataColumn();
			DataColumn226 = new DataColumn();
			DataColumn227 = new DataColumn();
			DataColumn486 = new DataColumn();
			DataColumn487 = new DataColumn();
			DataColumn488 = new DataColumn();
			DataColumn489 = new DataColumn();
			DataColumn490 = new DataColumn();
			DataColumn491 = new DataColumn();
			DataColumn500 = new DataColumn();
			DataTable11 = new DataTable();
			DataColumn111 = new DataColumn();
			DataColumn112 = new DataColumn();
			DataColumn113 = new DataColumn();
			DataTable12 = new DataTable();
			DataColumn228 = new DataColumn();
			DataColumn229 = new DataColumn();
			DataColumn230 = new DataColumn();
			DataTable13 = new DataTable();
			DataColumn110 = new DataColumn();
			DataColumn232 = new DataColumn();
			DataColumn233 = new DataColumn();
			DataColumn234 = new DataColumn();
			DataColumn515 = new DataColumn();
			DataTable14 = new DataTable();
			DataColumn235 = new DataColumn();
			DataColumn236 = new DataColumn();
			DataColumn237 = new DataColumn();
			DataColumn238 = new DataColumn();
			DataColumn516 = new DataColumn();
			DataTable15 = new DataTable();
			DataColumn248 = new DataColumn();
			DataColumn249 = new DataColumn();
			DataColumn250 = new DataColumn();
			DataColumn251 = new DataColumn();
			DataColumn252 = new DataColumn();
			DataColumn253 = new DataColumn();
			DataColumn254 = new DataColumn();
			DataColumn255 = new DataColumn();
			DataColumn256 = new DataColumn();
			DataColumn257 = new DataColumn();
			DataColumn258 = new DataColumn();
			DataColumn259 = new DataColumn();
			DataColumn260 = new DataColumn();
			DataColumn261 = new DataColumn();
			DataColumn262 = new DataColumn();
			DataColumn263 = new DataColumn();
			DataColumn264 = new DataColumn();
			DataColumn265 = new DataColumn();
			DataColumn266 = new DataColumn();
			DataColumn267 = new DataColumn();
			DataColumn268 = new DataColumn();
			DataColumn269 = new DataColumn();
			DataColumn270 = new DataColumn();
			DataColumn271 = new DataColumn();
			DataColumn272 = new DataColumn();
			DataColumn273 = new DataColumn();
			DataColumn274 = new DataColumn();
			DataColumn275 = new DataColumn();
			DataColumn276 = new DataColumn();
			DataColumn277 = new DataColumn();
			DataColumn278 = new DataColumn();
			DataColumn279 = new DataColumn();
			DataColumn280 = new DataColumn();
			DataColumn281 = new DataColumn();
			DataColumn282 = new DataColumn();
			DataColumn283 = new DataColumn();
			DataColumn284 = new DataColumn();
			DataColumn285 = new DataColumn();
			DataColumn286 = new DataColumn();
			DataColumn287 = new DataColumn();
			DataColumn288 = new DataColumn();
			DataColumn289 = new DataColumn();
			DataTable16 = new DataTable();
			DataColumn290 = new DataColumn();
			DataColumn291 = new DataColumn();
			DataTable17 = new DataTable();
			DataColumn292 = new DataColumn();
			DataColumn293 = new DataColumn();
			DataTable18 = new DataTable();
			DataColumn294 = new DataColumn();
			DataColumn295 = new DataColumn();
			DataTable19 = new DataTable();
			DataColumn296 = new DataColumn();
			DataColumn297 = new DataColumn();
			DataColumn298 = new DataColumn();
			DataColumn299 = new DataColumn();
			DataColumn300 = new DataColumn();
			DataColumn301 = new DataColumn();
			DataColumn302 = new DataColumn();
			DataColumn436 = new DataColumn();
			DataColumn517 = new DataColumn();
			DataColumn537 = new DataColumn();
			DataColumn559 = new DataColumn();
			DataTable21 = new DataTable();
			DataColumn303 = new DataColumn();
			DataColumn304 = new DataColumn();
			DataColumn305 = new DataColumn();
			DataColumn306 = new DataColumn();
			DataColumn307 = new DataColumn();
			DataColumn308 = new DataColumn();
			DataColumn309 = new DataColumn();
			DataColumn437 = new DataColumn();
			DataColumn518 = new DataColumn();
			DataColumn538 = new DataColumn();
			DataColumn560 = new DataColumn();
			DataTable22 = new DataTable();
			DataColumn310 = new DataColumn();
			DataColumn311 = new DataColumn();
			DataColumn312 = new DataColumn();
			DataColumn313 = new DataColumn();
			DataColumn314 = new DataColumn();
			DataColumn315 = new DataColumn();
			DataColumn316 = new DataColumn();
			DataColumn438 = new DataColumn();
			DataColumn519 = new DataColumn();
			DataColumn539 = new DataColumn();
			DataColumn561 = new DataColumn();
			DataTable23 = new DataTable();
			DataColumn317 = new DataColumn();
			DataColumn318 = new DataColumn();
			DataColumn319 = new DataColumn();
			DataColumn320 = new DataColumn();
			DataColumn321 = new DataColumn();
			DataColumn322 = new DataColumn();
			DataColumn323 = new DataColumn();
			DataColumn439 = new DataColumn();
			DataColumn520 = new DataColumn();
			DataColumn540 = new DataColumn();
			DataColumn562 = new DataColumn();
			DataTable24 = new DataTable();
			DataColumn324 = new DataColumn();
			DataColumn325 = new DataColumn();
			DataColumn326 = new DataColumn();
			DataColumn327 = new DataColumn();
			DataColumn328 = new DataColumn();
			DataColumn329 = new DataColumn();
			DataColumn330 = new DataColumn();
			DataColumn440 = new DataColumn();
			DataColumn521 = new DataColumn();
			DataColumn541 = new DataColumn();
			DataColumn558 = new DataColumn();
			DataTable25 = new DataTable();
			DataColumn331 = new DataColumn();
			DataColumn332 = new DataColumn();
			DataColumn333 = new DataColumn();
			DataColumn334 = new DataColumn();
			DataColumn335 = new DataColumn();
			DataColumn336 = new DataColumn();
			DataColumn337 = new DataColumn();
			DataColumn441 = new DataColumn();
			DataColumn522 = new DataColumn();
			DataColumn542 = new DataColumn();
			DataColumn563 = new DataColumn();
			DataTable26 = new DataTable();
			DataColumn338 = new DataColumn();
			DataColumn339 = new DataColumn();
			DataColumn340 = new DataColumn();
			DataColumn341 = new DataColumn();
			DataColumn342 = new DataColumn();
			DataColumn343 = new DataColumn();
			DataColumn344 = new DataColumn();
			DataColumn442 = new DataColumn();
			DataColumn523 = new DataColumn();
			DataColumn543 = new DataColumn();
			DataColumn564 = new DataColumn();
			DataTable27 = new DataTable();
			DataColumn345 = new DataColumn();
			DataColumn346 = new DataColumn();
			DataColumn347 = new DataColumn();
			DataColumn348 = new DataColumn();
			DataColumn349 = new DataColumn();
			DataColumn350 = new DataColumn();
			DataColumn351 = new DataColumn();
			DataColumn443 = new DataColumn();
			DataColumn524 = new DataColumn();
			DataColumn544 = new DataColumn();
			DataColumn565 = new DataColumn();
			DataTable28 = new DataTable();
			DataColumn352 = new DataColumn();
			DataColumn353 = new DataColumn();
			DataColumn354 = new DataColumn();
			DataColumn355 = new DataColumn();
			DataColumn356 = new DataColumn();
			DataColumn357 = new DataColumn();
			DataColumn358 = new DataColumn();
			DataColumn444 = new DataColumn();
			DataColumn525 = new DataColumn();
			DataColumn545 = new DataColumn();
			DataColumn566 = new DataColumn();
			DataTable29 = new DataTable();
			DataColumn359 = new DataColumn();
			DataColumn360 = new DataColumn();
			DataColumn361 = new DataColumn();
			DataColumn362 = new DataColumn();
			DataColumn363 = new DataColumn();
			DataColumn364 = new DataColumn();
			DataColumn365 = new DataColumn();
			DataColumn445 = new DataColumn();
			DataColumn526 = new DataColumn();
			DataColumn546 = new DataColumn();
			DataColumn567 = new DataColumn();
			DataTable30 = new DataTable();
			DataColumn366 = new DataColumn();
			DataColumn367 = new DataColumn();
			DataColumn368 = new DataColumn();
			DataColumn369 = new DataColumn();
			DataColumn370 = new DataColumn();
			DataColumn371 = new DataColumn();
			DataColumn372 = new DataColumn();
			DataColumn446 = new DataColumn();
			DataColumn527 = new DataColumn();
			DataColumn547 = new DataColumn();
			DataColumn568 = new DataColumn();
			DataTable31 = new DataTable();
			DataColumn373 = new DataColumn();
			DataColumn374 = new DataColumn();
			DataColumn375 = new DataColumn();
			DataColumn376 = new DataColumn();
			DataColumn377 = new DataColumn();
			DataColumn378 = new DataColumn();
			DataColumn379 = new DataColumn();
			DataColumn447 = new DataColumn();
			DataColumn528 = new DataColumn();
			DataColumn548 = new DataColumn();
			DataColumn569 = new DataColumn();
			DataTable32 = new DataTable();
			DataColumn380 = new DataColumn();
			DataColumn381 = new DataColumn();
			DataColumn382 = new DataColumn();
			DataColumn383 = new DataColumn();
			DataColumn384 = new DataColumn();
			DataColumn385 = new DataColumn();
			DataColumn386 = new DataColumn();
			DataColumn448 = new DataColumn();
			DataColumn529 = new DataColumn();
			DataColumn549 = new DataColumn();
			DataColumn570 = new DataColumn();
			DataTable33 = new DataTable();
			DataColumn387 = new DataColumn();
			DataColumn388 = new DataColumn();
			DataColumn389 = new DataColumn();
			DataColumn390 = new DataColumn();
			DataColumn391 = new DataColumn();
			DataColumn392 = new DataColumn();
			DataColumn393 = new DataColumn();
			DataColumn449 = new DataColumn();
			DataColumn530 = new DataColumn();
			DataColumn550 = new DataColumn();
			DataColumn571 = new DataColumn();
			DataTable34 = new DataTable();
			DataColumn394 = new DataColumn();
			DataColumn395 = new DataColumn();
			DataColumn396 = new DataColumn();
			DataColumn397 = new DataColumn();
			DataColumn398 = new DataColumn();
			DataColumn399 = new DataColumn();
			DataColumn400 = new DataColumn();
			DataColumn450 = new DataColumn();
			DataColumn531 = new DataColumn();
			DataColumn551 = new DataColumn();
			DataColumn572 = new DataColumn();
			DataTable35 = new DataTable();
			DataColumn401 = new DataColumn();
			DataColumn402 = new DataColumn();
			DataColumn403 = new DataColumn();
			DataColumn404 = new DataColumn();
			DataColumn405 = new DataColumn();
			DataColumn406 = new DataColumn();
			DataColumn407 = new DataColumn();
			DataColumn451 = new DataColumn();
			DataColumn532 = new DataColumn();
			DataColumn552 = new DataColumn();
			DataColumn573 = new DataColumn();
			DataTable36 = new DataTable();
			DataColumn408 = new DataColumn();
			DataColumn409 = new DataColumn();
			DataColumn410 = new DataColumn();
			DataColumn411 = new DataColumn();
			DataColumn412 = new DataColumn();
			DataColumn413 = new DataColumn();
			DataColumn414 = new DataColumn();
			DataColumn452 = new DataColumn();
			DataColumn533 = new DataColumn();
			DataColumn553 = new DataColumn();
			DataColumn574 = new DataColumn();
			DataTable37 = new DataTable();
			DataColumn415 = new DataColumn();
			DataColumn416 = new DataColumn();
			DataColumn417 = new DataColumn();
			DataColumn418 = new DataColumn();
			DataColumn419 = new DataColumn();
			DataColumn420 = new DataColumn();
			DataColumn421 = new DataColumn();
			DataColumn453 = new DataColumn();
			DataColumn534 = new DataColumn();
			DataColumn554 = new DataColumn();
			DataColumn575 = new DataColumn();
			DataTable38 = new DataTable();
			DataColumn422 = new DataColumn();
			DataColumn423 = new DataColumn();
			DataColumn424 = new DataColumn();
			DataColumn425 = new DataColumn();
			DataColumn426 = new DataColumn();
			DataColumn427 = new DataColumn();
			DataColumn428 = new DataColumn();
			DataColumn454 = new DataColumn();
			DataColumn535 = new DataColumn();
			DataColumn555 = new DataColumn();
			DataColumn576 = new DataColumn();
			DataTable39 = new DataTable();
			DataColumn429 = new DataColumn();
			DataColumn430 = new DataColumn();
			DataColumn431 = new DataColumn();
			DataColumn432 = new DataColumn();
			DataColumn433 = new DataColumn();
			DataColumn434 = new DataColumn();
			DataColumn435 = new DataColumn();
			DataColumn455 = new DataColumn();
			DataColumn536 = new DataColumn();
			DataColumn556 = new DataColumn();
			DataColumn577 = new DataColumn();
			DataTable20 = new DataTable();
			DataColumn505 = new DataColumn();
			DataColumn506 = new DataColumn();
			DataColumn509 = new DataColumn();
			DataColumn507 = new DataColumn();
			DataColumn508 = new DataColumn();
			DataTable40 = new DataTable();
			DataColumn510 = new DataColumn();
			DataColumn511 = new DataColumn();
			DataTable41 = new DataTable();
			DataColumn512 = new DataColumn();
			DataColumn513 = new DataColumn();
			ContextMenuStrip_saveas = new ContextMenuStrip(this.components);
			ToolStripSplitButton_save = new ToolStripSplitButton();
			ContextMenuStrip_ToTuideo = new ContextMenuStrip(this.components);
			ToolStripMenuItem_ToTuiDo = new ToolStripMenuItem();
			ToolStripSeparator2 = new ToolStripSeparator();
			ToolStripMenuItem_TuideoAddtoDrop = new ToolStripMenuItem();
			ToolStripMenuItem_TuideoAddtoContribute = new ToolStripMenuItem();
			ToolStripMenuItem_TuideoAddtoSend = new ToolStripMenuItem();
			ToolStripMenuItem_TuideoAddtoSell = new ToolStripMenuItem();
			ContextMenuStrip_ToTuido = new ContextMenuStrip(this.components);
			ToolStripMenuItem_ToTuiDeo = new ToolStripMenuItem();
			ToolStripSeparator1 = new ToolStripSeparator();
			ToolStripMenuItem_CharUse = new ToolStripMenuItem();
			ToolStripMenuItem_Petuse = new ToolStripMenuItem();
			ToolStripSeparator3 = new ToolStripSeparator();
			ToolStripMenuItem_dropitem = new ToolStripMenuItem();
			DongYVutDoToolStripMenuItem = new ToolStripMenuItem();
			ToolStripMenuItem_ContributeItem = new ToolStripMenuItem();
			DongYDongGopToolStripMenuItem = new ToolStripMenuItem();
			ToolStripSeparator4 = new ToolStripSeparator();
			ToolStripMenuItem_SendBDY = new ToolStripMenuItem();
			ToolStripTextBox_SendBDY_Id = new ToolStripTextBox();
			ToolStripSeparator5 = new ToolStripSeparator();
			ToolStripMenuItem_TuidoAddtoDrop = new ToolStripMenuItem();
			ToolStripMenuItem_TuidoAddtoContribute = new ToolStripMenuItem();
			ToolStripMenuItem_TuidoAddtoSend = new ToolStripMenuItem();
			ToolStripMenuItem_TuidoAddtoSell = new ToolStripMenuItem();
			ToolStripMenuItem_AddToShop = new ToolStripMenuItem();
			ToolStripSeparator6 = new ToolStripSeparator();
			ToolStripMenuItem_Tuido_Sort = new ToolStripMenuItem();
			ContextMenuStrip_Warp = new ContextMenuStrip(this.components);
			ToolStripMenuItem_Warp = new ToolStripMenuItem();
			Timer_100 = new System.Windows.Forms.Timer(this.components);
			Timer_autoquest = new System.Windows.Forms.Timer(this.components);
			Timer_delay = new System.Windows.Forms.Timer(this.components);
			ToolTip_info = new ToolTip(this.components);
			TextBox_ClickMOD = new TextBox();
			ListView_Quest = new ListView();
			ColumnHeader19 = new ColumnHeader();
			ListView_AutoDrop = new ListView();
			ColumnHeader_Id = new ColumnHeader();
			ColumnHeader_Name = new ColumnHeader();
			ListView_AutoContribute = new ListView();
			ColumnHeader1 = new ColumnHeader();
			ColumnHeader2 = new ColumnHeader();
			ListView_AutoSend = new ListView();
			ColumnHeader3 = new ColumnHeader();
			ColumnHeader4 = new ColumnHeader();
			ListView_AutoSell = new ListView();
			ColumnHeader10 = new ColumnHeader();
			ColumnHeader11 = new ColumnHeader();
			DataGridView_Pickup = new DataGridView();
			DataGridViewTextBoxColumn14 = new DataGridViewTextBoxColumn();
			DataGridViewTextBoxColumn15 = new DataGridViewTextBoxColumn();
			ListView_Shop = new ListView();
			ColumnHeader15 = new ColumnHeader();
			ColumnHeader16 = new ColumnHeader();
			ColumnHeader17 = new ColumnHeader();
			PictureBox1 = new PictureBox();
			OpenFileDialog_setting = new OpenFileDialog();
			SaveFileDialog_setting = new SaveFileDialog();
			Timer_QC = new System.Windows.Forms.Timer(this.components);
			ImageList1 = new ImageList(this.components);
			Vs2010TabControl_Main = new Vs2010TabControl();
			TabPage_Main = new TabPage();
			PictureBox_mini = new PictureBox();
			PictureBox_char_add_agi = new PictureBox();
			PictureBox_char_add_spx = new PictureBox();
			PictureBox_char_add_hpx = new PictureBox();
			PictureBox_char_add_def = new PictureBox();
			PictureBox_char_add_atk = new PictureBox();
			PictureBox_char_add_int = new PictureBox();
			PictureBox_pet_next = new PictureBox();
			PictureBox_Pet_back = new PictureBox();
			Label_Pet_fai = new Label();
			Label_Pet_agi = new Label();
			Label_Pet_spx = new Label();
			Label_Pet_hpx = new Label();
			Label_Petname = new Label();
			Label_Pet_def = new Label();
			Label_Pet_atk = new Label();
			Label_Pet_int = new Label();
			Label94 = new Label();
			Label_Char_agi = new Label();
			Label_Char_spx = new Label();
			Label_Char_hpx = new Label();
			Label_Char_def = new Label();
			Label_Char_atk = new Label();
			Label_Char_int = new Label();
			PictureBox_Pet_XuatChien = new PictureBox();
			PictureBox_Pet_Thuoctinh = new PictureBox();
			PictureBox_Char_Thuoctinh = new PictureBox();
			PictureBox_Pet5 = new PictureBox();
			PictureBox_Pet6 = new PictureBox();
			PictureBox_Pet3 = new PictureBox();
			PictureBox_Pet2 = new PictureBox();
			PictureBox_Pet4 = new PictureBox();
			PictureBox_Pet1 = new PictureBox();
			PictureBox_char5 = new PictureBox();
			PictureBox_char6 = new PictureBox();
			PictureBox_char3 = new PictureBox();
			PictureBox_char2 = new PictureBox();
			PictureBox_char4 = new PictureBox();
			PictureBox_char1 = new PictureBox();
			Panel10 = new Panel();
			RtbChat = new RichTextBox();
			rtbsystem = new RichTextBox();
			Panel_Chat = new Panel();
			ComboBox_chat = new ComboBox();
			ComboBox_nameprivate = new ComboBox();
			ComboBox_kenh = new ComboBox();
			Panel9 = new Panel();
			Panel7 = new Panel();
			CheckBox_Bee = new CheckBox();
			Button_warp2 = new Button();
			Label_mapy = new Label();
			Label_mapid = new Label();
			Button_walk = new Button();
			Label_mapx = new Label();
			TextBox_walkX = new TextBox();
			TextBox_idWarp2 = new TextBox();
			TextBox_walkY = new TextBox();
			GroupBox12 = new GroupBox();
			Button_Mini_Warp = new Button();
			ComboBox_Mini_Warp = new ComboBox();
			StatusBar1 = new StatusBar();
			StatusBarPanel_status = new StatusBarPanel();
			StatusBarPanel_MapName = new StatusBarPanel();
			StatusBarPanel_online = new StatusBarPanel();
			Label_Mini = new Label();
			Label83 = new Label();
			Lb_tuideo25 = new Label();
			Panel_Login = new Panel();
			CheckBox_Reconnect = new CheckBox();
			btnLogin = new Button();
			TBPassword = new TextBox();
			TBId = new TextBox();
			TextBox_Country = new TextBox();
			ComboBox_Port = new ComboBox();
			ComboBox_Server = new ComboBox();
			ToolStrip1 = new Vs2010ToolStrip();
			ToolStripLabel1 = new ToolStripLabel();
			ToolStripTextBox_KenhPassword = new ToolStripTextBox();
			Panel6 = new Panel();
			ProgressBarEx_BDY = new ProgressBarEx();
			Label_BDY = new Label();
			Lb_tuideo24 = new Label();
			Label_Lv = new Label();
			Lb_tuideo23 = new Label();
			GroupBox_Bot = new GroupBox();
			ComboBox_botname = new ComboBox();
			TextBox_DelayBot = new TextBox();
			Label51 = new Label();
			Button_bot = new Button();
			CheckBox_QuestProtect = new CheckBox();
			CheckBox_autosell = new CheckBox();
			CheckBox_TuLenNgua = new CheckBox();
			GroupBox_team = new GroupBox();
			Label55 = new Label();
			Button_OutParty = new Button();
			Label_IdLeader = new Label();
			Button_InviteParty = new Button();
			Button_RequestParty = new Button();
			Panel5 = new Panel();
			TextBox_IDmem4 = new TextBox();
			TextBox_IDmem3 = new TextBox();
			TextBox_IDmem2 = new TextBox();
			TextBox_IDmem1 = new TextBox();
			RadioButton_QS1 = new RadioButton();
			RadioButton_QS2 = new RadioButton();
			RadioButton_QS3 = new RadioButton();
			RadioButton_QS4 = new RadioButton();
			TextBox_IdLeader = new TextBox();
			Label_CharName = new Label();
			Lb_tuideo22 = new Label();
			Label_petlv = new Label();
			Lb_tuideo21 = new Label();
			Label_Lv_Plus = new Label();
			Lb_tuideo20 = new Label();
			Label_Lv2 = new Label();
			Lb_tuideo19 = new Label();
			Label_PetExpMin = new Label();
			Lb_tuideo18 = new Label();
			Label8 = new Label();
			Lb_tuideo17 = new Label();
			Lb_tuideo16 = new Label();
			ProgressBarEx_PetExp = new ProgressBarEx();
			Lb_tuideo15 = new Label();
			Lb_tuideo14 = new Label();
			Lb_tuideo13 = new Label();
			Lb_tuideo12 = new Label();
			Label4 = new Label();
			Lb_tuideo11 = new Label();
			Lb_tuideo10 = new Label();
			Label_CharExpMin = new Label();
			Lb_tuideo9 = new Label();
			ProgressBarEx_PetSp = new ProgressBarEx();
			Lb_tuideo8 = new Label();
			Lb_tuideo7 = new Label();
			Lb_tuideo6 = new Label();
			Lb_tuideo5 = new Label();
			Label_gold = new Label();
			Lb_tuideo4 = new Label();
			ProgressBarEx_PetHp = new ProgressBarEx();
			Lb_tuideo3 = new Label();
			Lb_tuideo2 = new Label();
			ProgressBarEx_CharHp = new ProgressBarEx();
			Lb_tuideo1 = new Label();
			Lb_tuido25 = new Label();
			Lb_tuido24 = new Label();
			Lb_tuido23 = new Label();
			Lb_tuido22 = new Label();
			Lb_tuido21 = new Label();
			Lb_tuido20 = new Label();
			Lb_tuido19 = new Label();
			Lb_tuido18 = new Label();
			ProgressBarEx_CharExp = new ProgressBarEx();
			Lb_tuido17 = new Label();
			Lb_tuido16 = new Label();
			ProgressBarEx_CharSp = new ProgressBarEx();
			Lb_tuido15 = new Label();
			Lb_tuido14 = new Label();
			Lb_tuido1 = new Label();
			Lb_tuido13 = new Label();
			Lb_tuido2 = new Label();
			Lb_tuido12 = new Label();
			Lb_tuido3 = new Label();
			Lb_tuido11 = new Label();
			Lb_tuido4 = new Label();
			Lb_tuido10 = new Label();
			Lb_tuido5 = new Label();
			Lb_tuido9 = new Label();
			Lb_tuido6 = new Label();
			Lb_tuido8 = new Label();
			Lb_tuido7 = new Label();
			PictureBox_Pet_photo = new PictureBox();
			PictureBox_avatar = new PictureBox();
			TabPage_Attack = new TabPage();
			Button_BattleInfo = new Button();
			TabControl2 = new TabControl();
			TabPage3 = new TabPage();
			CheckBox_Pet_ChangeTG = new CheckBox();
			CheckBox_Char_ChangeTG = new CheckBox();
			CheckBox_LeaderDissNotEnough = new CheckBox();
			GroupBox8 = new GroupBox();
			Label56 = new Label();
			TextBox_ClickMOD_Delay = new TextBox();
			ListView_monster = new ListView();
			ColumnHeader5 = new ColumnHeader();
			ColumnHeader12 = new ColumnHeader();
			ColumnHeader13 = new ColumnHeader();
			ColumnHeader14 = new ColumnHeader();
			ColumnHeader6 = new ColumnHeader();
			ColumnHeader7 = new ColumnHeader();
			ColumnHeader8 = new ColumnHeader();
			ColumnHeader9 = new ColumnHeader();
			CheckBox_AutoClickNPC = new CheckBox();
			Panel_CharSkillTurn = new Panel();
			ComboBox_CharTurnSetting = new ComboBox();
			ComboBox_CharLocation = new ComboBox();
			Label_CharTurnCount = new Label();
			Label53 = new Label();
			Button_CharTurnRemove = new Button();
			Button_CharTurnAdd = new Button();
			Label52 = new Label();
			ComboBox_CharSkill = new ComboBoxIcon();
			Label47 = new Label();
			Label48 = new Label();
			CheckBox_AutoRevival = new CheckBox();
			CheckBox_AutoFlee_Party = new CheckBox();
			CheckBox_AutoFlee_Sp = new CheckBox();
			Panel_PetSkillTurn = new Panel();
			Label_PetTurnCount = new Label();
			Label62 = new Label();
			Button_PetTurnRemove = new Button();
			Button_PetTurnAdd = new Button();
			ComboBox_PetTurnSetting = new ComboBox();
			Label54 = new Label();
			ComboBox_PetSkill = new ComboBoxIcon();
			ComboBox_PetLocation = new ComboBox();
			Label49 = new Label();
			Label50 = new Label();
			Label74 = new Label();
			TextBox_ValueSPFlee = new TextBox();
			TabPage_Quest = new TabPage();
			Button2 = new Button();
			Button_Func = new Button();
			Button_Quest_Refresh = new Button();
			Button_StartAutoQuest = new Button();
			ComboBox_Quest = new ComboBox();
			RichTextBox_hienthiquest = new RichTextBox();
			DataGridView1 = new DataGridView();
			Column_Quest_check = new DataGridViewCheckBoxColumn();
			Column_Quest_Func = new DataGridViewTextBoxColumn();
			Column_Quest_Id = new DataGridViewTextBoxColumn();
			Column_Quest_Info = new DataGridViewTextBoxColumn();
			RtbQuest = new RichTextBox();
			TabPage_Warp = new TabPage();
			TextBox_idWarp = new TextBox();
			TreeView1 = new TreeView();
			Button_warp = new Button();
			TabPage_Players = new TabPage();
			Label_PlayerCount = new Label();
			TabPage_Setting = new TabPage();
			TabControl1 = new Vs2010TabControl();
			TabPage7 = new TabPage();
			GroupBox_disconnect = new GroupBox();
			CheckBox_DCFullHomDo = new CheckBox();
			CheckBox_DisExp = new CheckBox();
			RadioButton_DC_no = new RadioButton();
			RadioButton_DCmemout = new RadioButton();
			RadioButton_DCLeaderOut = new RadioButton();
			CheckBox_DCAfter1MinNoBattle = new CheckBox();
			GroupBox_Basic = new GroupBox();
			Label42 = new Label();
			NumericUpDown_sendpacket = new NumericUpDown();
			Label41 = new Label();
			TextBox_idQC = new TextBox();
			CheckBox_QC = new CheckBox();
			CheckBox_Autosort = new CheckBox();
			CheckBox_AutoUsePT = new CheckBox();
			CheckBox_AutoEquitExp = new CheckBox();
			CheckBox_CatPet = new CheckBox();
			RadioButton_PT_no = new RadioButton();
			RadioButton_MemberRequestParty = new RadioButton();
			RadioButton_LeaderRequestParty = new RadioButton();
			CheckBox_ClearGhost = new CheckBox();
			GroupBox9 = new GroupBox();
			Label79 = new Label();
			Label13 = new Label();
			TextBox_RemoteDis = new TextBox();
			Label77 = new Label();
			TabPage8 = new TabPage();
			GroupBox3 = new GroupBox();
			Label25 = new Label();
			Label33 = new Label();
			TextBox_TL_char_hp_value = new TextBox();
			CheckBox_TL_mem1 = new CheckBox();
			Label34 = new Label();
			Label32 = new Label();
			TextBox_TL_pet_sp_value = new TextBox();
			Label22 = new Label();
			Label35 = new Label();
			CheckBox_TL_mem2 = new CheckBox();
			Label36 = new Label();
			TextBox_TL_char_sp_value = new TextBox();
			TextBox_TL_pet_hp_value = new TextBox();
			CheckBox_TL_mem3 = new CheckBox();
			CheckBox_TL_pet2 = new CheckBox();
			Label23 = new Label();
			CheckBox_TL_pet1 = new CheckBox();
			CheckBox_TL_mem4 = new CheckBox();
			GroupBox2 = new GroupBox();
			CheckBox_AutoEat = new CheckBox();
			Label43 = new Label();
			TextBox_Eat_pet_sp_value = new TextBox();
			Label44 = new Label();
			TextBox_Eat_pet_hp_value = new TextBox();
			Label45 = new Label();
			Label46 = new Label();
			Label21 = new Label();
			TextBox_Eat_char_sp_value = new TextBox();
			Label20 = new Label();
			TextBox_Eat_char_hp_value = new TextBox();
			Label7 = new Label();
			Label5 = new Label();
			TabPage9 = new TabPage();
			CheckBox_AutoCreatCharacter = new CheckBox();
			RadioButton_dia = new RadioButton();
			Label17 = new Label();
			Label14 = new Label();
			RadioButton_thuy = new RadioButton();
			NumericUpDown_createSp = new NumericUpDown();
			Label_point = new Label();
			Label15 = new Label();
			Label10 = new Label();
			NumericUpDown_createHp = new NumericUpDown();
			ComboBox_sex = new ComboBox();
			NumericUpDown_createAgi = new NumericUpDown();
			RadioButton_phong = new RadioButton();
			NumericUpDown_createInt = new NumericUpDown();
			TextBox_createName = new TextBox();
			Label16 = new Label();
			RadioButton_hoa = new RadioButton();
			TextBox_Pass = new TextBox();
			Label11 = new Label();
			TextBox_amma = new TextBox();
			Label19 = new Label();
			NumericUpDown_createAtk = new NumericUpDown();
			Label1 = new Label();
			Label18 = new Label();
			Label2 = new Label();
			NumericUpDown_createDef = new NumericUpDown();
			TabPage2 = new TabPage();
			TabControl_ItemSetting = new TabControl();
			TabPage11 = new TabPage();
			GroupBox5 = new GroupBox();
			CheckBox_DropMineWood = new CheckBox();
			Button_AddIdDrop = new Button();
			TextBox_AddIdDrop = new TextBox();
			CheckBox_DropHpSp = new CheckBox();
			CheckBox_DropSp = new CheckBox();
			CheckBox_DropHp = new CheckBox();
			Label63 = new Label();
			TextBox_Drop_SpValue = new TextBox();
			Label61 = new Label();
			TextBox_Drop_HpValue = new TextBox();
			TabPage12 = new TabPage();
			GroupBox6 = new GroupBox();
			CheckBox_ContributeMineWood = new CheckBox();
			Button_AddIdContribute = new Button();
			TextBox_AddIdContribute = new TextBox();
			CheckBox_ContributeHpSp = new CheckBox();
			CheckBox_ContributeSp = new CheckBox();
			CheckBox_ContributeHp = new CheckBox();
			Label64 = new Label();
			TextBox_Contribute_SpValue = new TextBox();
			Label65 = new Label();
			TextBox_Contribute_HpValue = new TextBox();
			TabPage1 = new TabPage();
			GroupBox7 = new GroupBox();
			Label75 = new Label();
			TextBox_AutoSend = new TextBox();
			CheckBox_SendMineWood = new CheckBox();
			Button_AddIdSend = new Button();
			TextBox_AddIdSend = new TextBox();
			CheckBox_SendHpSp = new CheckBox();
			CheckBox_SendSp = new CheckBox();
			CheckBox_SendHp = new CheckBox();
			Label72 = new Label();
			TextBox_Send_SpValue = new TextBox();
			Label73 = new Label();
			TextBox_Send_HpValue = new TextBox();
			TabPage5 = new TabPage();
			GroupBox10 = new GroupBox();
			CheckBox_SellMineWood = new CheckBox();
			Button_AddIdSell = new Button();
			TextBox_AddIdSell = new TextBox();
			CheckBox_SellHpSp = new CheckBox();
			CheckBox_SellSP = new CheckBox();
			CheckBox_SellHp = new CheckBox();
			Label12 = new Label();
			TextBox_Sell_SpValue = new TextBox();
			Label80 = new Label();
			TextBox_Sell_HpValue = new TextBox();
			GroupBox4 = new GroupBox();
			CheckBox_AutoPickup = new CheckBox();
			NumericUpDown_ItemCountPickup = new NumericUpDown();
			TabPage6 = new TabPage();
			GroupBox11 = new GroupBox();
			Label84 = new Label();
			TextBox_OpenMachine_PetSp = new TextBox();
			Label85 = new Label();
			TextBox_OpenMachine_PetHp = new TextBox();
			Label86 = new Label();
			Label87 = new Label();
			Label88 = new Label();
			TextBox_OpenMachine_CharSp = new TextBox();
			Label89 = new Label();
			TextBox_OpenMachine_CharHp = new TextBox();
			Label90 = new Label();
			Label91 = new Label();
			CheckBox_OpenMachine = new CheckBox();
			TabPage4 = new TabPage();
			Button_IdAdd = new Button();
			TextBox_IdAdd = new TextBox();
			Panel4 = new Panel();
			DataGridView_ItemOnMap = new DataGridView();
			GoldDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			IdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			ItemNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			MapXDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			MapYDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			Label3 = new Label();
			CheckBox_Pickup = new CheckBox();
			TabPage_Shop = new TabPage();
			Button_ShopAdd = new Button();
			Button_Shop_Start = new Button();
			Label40 = new Label();
			TextBox_ShopName = new TextBox();
			Label39 = new Label();
			Label_ShopName = new Label();
			TextBox_ShopAddPrice = new TextBox();
			Label38 = new Label();
			TextBox_ShopAddId = new TextBox();
			ComboBox_ShopType = new ComboBox();
			TabPage_Map = new TabPage();
			miniToolStrip = new Vs2010ToolStrip();
			((ISupportInitialize)DataSet1).BeginInit();
			((ISupportInitialize)DataTable1).BeginInit();
			((ISupportInitialize)DataTable2).BeginInit();
			((ISupportInitialize)DataTable3).BeginInit();
			((ISupportInitialize)DataTable4).BeginInit();
			((ISupportInitialize)DataTable5).BeginInit();
			((ISupportInitialize)DataTable6).BeginInit();
			((ISupportInitialize)DataTable7).BeginInit();
			((ISupportInitialize)DataTable8).BeginInit();
			((ISupportInitialize)DataTable9).BeginInit();
			((ISupportInitialize)DataTable10).BeginInit();
			((ISupportInitialize)DataTable11).BeginInit();
			((ISupportInitialize)DataTable12).BeginInit();
			((ISupportInitialize)DataTable13).BeginInit();
			((ISupportInitialize)DataTable14).BeginInit();
			((ISupportInitialize)DataTable15).BeginInit();
			((ISupportInitialize)DataTable16).BeginInit();
			((ISupportInitialize)DataTable17).BeginInit();
			((ISupportInitialize)DataTable18).BeginInit();
			((ISupportInitialize)DataTable19).BeginInit();
			((ISupportInitialize)DataTable21).BeginInit();
			((ISupportInitialize)DataTable22).BeginInit();
			((ISupportInitialize)DataTable23).BeginInit();
			((ISupportInitialize)DataTable24).BeginInit();
			((ISupportInitialize)DataTable25).BeginInit();
			((ISupportInitialize)DataTable26).BeginInit();
			((ISupportInitialize)DataTable27).BeginInit();
			((ISupportInitialize)DataTable28).BeginInit();
			((ISupportInitialize)DataTable29).BeginInit();
			((ISupportInitialize)DataTable30).BeginInit();
			((ISupportInitialize)DataTable31).BeginInit();
			((ISupportInitialize)DataTable32).BeginInit();
			((ISupportInitialize)DataTable33).BeginInit();
			((ISupportInitialize)DataTable34).BeginInit();
			((ISupportInitialize)DataTable35).BeginInit();
			((ISupportInitialize)DataTable36).BeginInit();
			((ISupportInitialize)DataTable37).BeginInit();
			((ISupportInitialize)DataTable38).BeginInit();
			((ISupportInitialize)DataTable39).BeginInit();
			((ISupportInitialize)DataTable20).BeginInit();
			((ISupportInitialize)DataTable40).BeginInit();
			((ISupportInitialize)DataTable41).BeginInit();
			ContextMenuStrip_ToTuideo.SuspendLayout();
			ContextMenuStrip_ToTuido.SuspendLayout();
			ContextMenuStrip_Warp.SuspendLayout();
			((ISupportInitialize)DataGridView_Pickup).BeginInit();
			((ISupportInitialize)PictureBox1).BeginInit();
			Vs2010TabControl_Main.SuspendLayout();
			TabPage_Main.SuspendLayout();
			((ISupportInitialize)PictureBox_mini).BeginInit();
			((ISupportInitialize)PictureBox_char_add_agi).BeginInit();
			((ISupportInitialize)PictureBox_char_add_spx).BeginInit();
			((ISupportInitialize)PictureBox_char_add_hpx).BeginInit();
			((ISupportInitialize)PictureBox_char_add_def).BeginInit();
			((ISupportInitialize)PictureBox_char_add_atk).BeginInit();
			((ISupportInitialize)PictureBox_char_add_int).BeginInit();
			((ISupportInitialize)PictureBox_pet_next).BeginInit();
			((ISupportInitialize)PictureBox_Pet_back).BeginInit();
			((ISupportInitialize)PictureBox_Pet_XuatChien).BeginInit();
			((ISupportInitialize)PictureBox_Pet_Thuoctinh).BeginInit();
			((ISupportInitialize)PictureBox_Char_Thuoctinh).BeginInit();
			((ISupportInitialize)PictureBox_Pet5).BeginInit();
			((ISupportInitialize)PictureBox_Pet6).BeginInit();
			((ISupportInitialize)PictureBox_Pet3).BeginInit();
			((ISupportInitialize)PictureBox_Pet2).BeginInit();
			((ISupportInitialize)PictureBox_Pet4).BeginInit();
			((ISupportInitialize)PictureBox_Pet1).BeginInit();
			((ISupportInitialize)PictureBox_char5).BeginInit();
			((ISupportInitialize)PictureBox_char6).BeginInit();
			((ISupportInitialize)PictureBox_char3).BeginInit();
			((ISupportInitialize)PictureBox_char2).BeginInit();
			((ISupportInitialize)PictureBox_char4).BeginInit();
			((ISupportInitialize)PictureBox_char1).BeginInit();
			Panel10.SuspendLayout();
			Panel_Chat.SuspendLayout();
			Panel9.SuspendLayout();
			Panel7.SuspendLayout();
			GroupBox12.SuspendLayout();
			((ISupportInitialize)StatusBarPanel_status).BeginInit();
			((ISupportInitialize)StatusBarPanel_MapName).BeginInit();
			((ISupportInitialize)StatusBarPanel_online).BeginInit();
			Panel_Login.SuspendLayout();
			ToolStrip1.SuspendLayout();
			Panel6.SuspendLayout();
			GroupBox_Bot.SuspendLayout();
			GroupBox_team.SuspendLayout();
			Panel5.SuspendLayout();
			((ISupportInitialize)PictureBox_Pet_photo).BeginInit();
			((ISupportInitialize)PictureBox_avatar).BeginInit();
			TabPage_Attack.SuspendLayout();
			TabControl2.SuspendLayout();
			TabPage3.SuspendLayout();
			GroupBox8.SuspendLayout();
			Panel_CharSkillTurn.SuspendLayout();
			Panel_PetSkillTurn.SuspendLayout();
			TabPage_Quest.SuspendLayout();
			((ISupportInitialize)DataGridView1).BeginInit();
			TabPage_Warp.SuspendLayout();
			TabPage_Players.SuspendLayout();
			TabPage_Setting.SuspendLayout();
			TabControl1.SuspendLayout();
			TabPage7.SuspendLayout();
			GroupBox_disconnect.SuspendLayout();
			GroupBox_Basic.SuspendLayout();
			((ISupportInitialize)NumericUpDown_sendpacket).BeginInit();
			GroupBox9.SuspendLayout();
			TabPage8.SuspendLayout();
			GroupBox3.SuspendLayout();
			GroupBox2.SuspendLayout();
			TabPage9.SuspendLayout();
			((ISupportInitialize)NumericUpDown_createSp).BeginInit();
			((ISupportInitialize)NumericUpDown_createHp).BeginInit();
			((ISupportInitialize)NumericUpDown_createAgi).BeginInit();
			((ISupportInitialize)NumericUpDown_createInt).BeginInit();
			((ISupportInitialize)NumericUpDown_createAtk).BeginInit();
			((ISupportInitialize)NumericUpDown_createDef).BeginInit();
			TabPage2.SuspendLayout();
			TabControl_ItemSetting.SuspendLayout();
			TabPage11.SuspendLayout();
			GroupBox5.SuspendLayout();
			TabPage12.SuspendLayout();
			GroupBox6.SuspendLayout();
			TabPage1.SuspendLayout();
			GroupBox7.SuspendLayout();
			TabPage5.SuspendLayout();
			GroupBox10.SuspendLayout();
			GroupBox4.SuspendLayout();
			((ISupportInitialize)NumericUpDown_ItemCountPickup).BeginInit();
			TabPage6.SuspendLayout();
			GroupBox11.SuspendLayout();
			TabPage4.SuspendLayout();
			Panel4.SuspendLayout();
			((ISupportInitialize)DataGridView_ItemOnMap).BeginInit();
			TabPage_Shop.SuspendLayout();
			TabPage_Map.SuspendLayout();
			SuspendLayout();
			DataSet1.DataSetName = "NewDataSet";
			DataSet1.Tables.AddRange(new DataTable[41]
			{
				DataTable1, DataTable2, DataTable3, DataTable4, DataTable5, DataTable6, DataTable7, DataTable8, DataTable9, DataTable10,
				DataTable11, DataTable12, DataTable13, DataTable14, DataTable15, DataTable16, DataTable17, DataTable18, DataTable19, DataTable21,
				DataTable22, DataTable23, DataTable24, DataTable25, DataTable26, DataTable27, DataTable28, DataTable29, DataTable30, DataTable31,
				DataTable32, DataTable33, DataTable34, DataTable35, DataTable36, DataTable37, DataTable38, DataTable39, DataTable20, DataTable40,
				DataTable41
			});
			DataTable1.Columns.AddRange(new DataColumn[9] { DataColumn1, DataColumn2, DataColumn3, DataColumn4, DataColumn5, DataColumn6, DataColumn7, DataColumn8, DataColumn243 });
			DataTable1.TableName = "Table_ListPlayer";
			DataColumn1.AllowDBNull = false;
			DataColumn1.ColumnName = "ID";
			DataColumn1.DataType = typeof(int);
			DataColumn2.ColumnName = "Tên";
			DataColumn3.ColumnName = "Cấp";
			DataColumn3.DataType = typeof(int);
			DataColumn4.ColumnName = "Bản đồ";
			DataColumn4.DataType = typeof(int);
			DataColumn5.ColumnName = "X";
			DataColumn5.DataType = typeof(int);
			DataColumn6.ColumnName = "Y";
			DataColumn6.DataType = typeof(int);
			DataColumn7.ColumnName = "CS";
			DataColumn7.DataType = typeof(int);
			DataColumn8.ColumnName = "proto";
			DataColumn8.DataType = typeof(int);
			DataColumn243.ColumnName = "Online";
			DataColumn243.DefaultValue = "ON";
			DataTable2.Columns.AddRange(new DataColumn[43]
			{
				DataColumn9, DataColumn10, DataColumn11, DataColumn12, DataColumn13, DataColumn14, DataColumn15, DataColumn16, DataColumn17, DataColumn18,
				DataColumn19, DataColumn20, DataColumn21, DataColumn22, DataColumn34, DataColumn117, DataColumn118, DataColumn119, DataColumn120, DataColumn121,
				DataColumn122, DataColumn123, DataColumn124, DataColumn125, DataColumn126, DataColumn127, DataColumn128, DataColumn240, DataColumn241, DataColumn242,
				DataColumn244, DataColumn245, DataColumn246, DataColumn247, DataColumn456, DataColumn457, DataColumn458, DataColumn459, DataColumn460, DataColumn461,
				DataColumn498, DataColumn514, DataColumn557
			});
			DataTable2.TableName = "Table_database";
			DataColumn9.AllowDBNull = false;
			DataColumn9.ColumnName = "ID";
			DataColumn9.DataType = typeof(int);
			DataColumn9.DefaultValue = 0;
			DataColumn10.ColumnName = "Name";
			DataColumn10.DefaultValue = "Chưa kết nối!";
			DataColumn11.ColumnName = "Lv";
			DataColumn11.DataType = typeof(int);
			DataColumn11.DefaultValue = 0;
			DataColumn12.ColumnName = "Hp";
			DataColumn12.DataType = typeof(int);
			DataColumn12.DefaultValue = 0;
			DataColumn13.ColumnName = "MaxHp";
			DataColumn13.DataType = typeof(int);
			DataColumn13.DefaultValue = 0;
			DataColumn14.ColumnName = "Sp";
			DataColumn14.DataType = typeof(int);
			DataColumn14.DefaultValue = 0;
			DataColumn15.ColumnName = "MaxSp";
			DataColumn15.DataType = typeof(int);
			DataColumn15.DefaultValue = 0;
			DataColumn16.ColumnName = "MapId";
			DataColumn16.DataType = typeof(int);
			DataColumn16.DefaultValue = 0;
			DataColumn17.ColumnName = "MapX";
			DataColumn17.DataType = typeof(int);
			DataColumn17.DefaultValue = 0;
			DataColumn18.ColumnName = "MapY";
			DataColumn18.DataType = typeof(int);
			DataColumn18.DefaultValue = 0;
			DataColumn19.ColumnName = "Gold";
			DataColumn19.DataType = typeof(int);
			DataColumn19.DefaultValue = 0;
			DataColumn20.ColumnName = "TotalExp";
			DataColumn20.DataType = typeof(int);
			DataColumn20.DefaultValue = 0;
			DataColumn21.ColumnName = "Exp";
			DataColumn21.DataType = typeof(int);
			DataColumn21.DefaultValue = 0;
			DataColumn22.ColumnName = "MaxExp";
			DataColumn22.DataType = typeof(int);
			DataColumn22.DefaultValue = 0;
			DataColumn34.ColumnName = "ExpMin";
			DataColumn34.DataType = typeof(int);
			DataColumn34.DefaultValue = 0;
			DataColumn117.ColumnName = "Int";
			DataColumn117.DataType = typeof(int);
			DataColumn117.DefaultValue = 0;
			DataColumn118.ColumnName = "Atk";
			DataColumn118.DataType = typeof(int);
			DataColumn118.DefaultValue = 0;
			DataColumn119.ColumnName = "Def";
			DataColumn119.DataType = typeof(int);
			DataColumn119.DefaultValue = 0;
			DataColumn120.ColumnName = "Hpx";
			DataColumn120.DataType = typeof(int);
			DataColumn120.DefaultValue = 0;
			DataColumn121.ColumnName = "Spx";
			DataColumn121.DataType = typeof(int);
			DataColumn121.DefaultValue = 0;
			DataColumn122.ColumnName = "Agi";
			DataColumn122.DataType = typeof(int);
			DataColumn122.DefaultValue = 0;
			DataColumn123.ColumnName = "+Int";
			DataColumn123.DataType = typeof(int);
			DataColumn123.DefaultValue = 0;
			DataColumn124.ColumnName = "+Atk";
			DataColumn124.DataType = typeof(int);
			DataColumn124.DefaultValue = 0;
			DataColumn125.ColumnName = "+Def";
			DataColumn125.DataType = typeof(int);
			DataColumn125.DefaultValue = 0;
			DataColumn126.ColumnName = "+Hpx";
			DataColumn126.DataType = typeof(int);
			DataColumn126.DefaultValue = 0;
			DataColumn127.ColumnName = "+Spx";
			DataColumn127.DataType = typeof(int);
			DataColumn127.DefaultValue = 0;
			DataColumn128.ColumnName = "+Agi";
			DataColumn128.DataType = typeof(int);
			DataColumn128.DefaultValue = 0;
			DataColumn240.ColumnName = "TExp";
			DataColumn240.DataType = typeof(int);
			DataColumn240.DefaultValue = 0;
			DataColumn241.ColumnName = "God";
			DataColumn241.DataType = typeof(int);
			DataColumn241.DefaultValue = 0;
			DataColumn242.ColumnName = "Ghost";
			DataColumn242.DataType = typeof(int);
			DataColumn242.DefaultValue = 0;
			DataColumn244.ColumnName = "Reborn";
			DataColumn244.DataType = typeof(int);
			DataColumn244.DefaultValue = 0;
			DataColumn245.ColumnName = "proto";
			DataColumn245.DataType = typeof(int);
			DataColumn245.DefaultValue = 1;
			DataColumn246.ColumnName = "PlayerOnline";
			DataColumn246.DataType = typeof(int);
			DataColumn246.DefaultValue = 0;
			DataColumn247.ColumnName = "LeaderId";
			DataColumn247.DataType = typeof(int);
			DataColumn247.DefaultValue = 0;
			DataColumn456.ColumnName = "+-Int";
			DataColumn456.DefaultValue = "+";
			DataColumn457.ColumnName = "+-Atk";
			DataColumn457.DefaultValue = "+";
			DataColumn458.ColumnName = "+-Def";
			DataColumn458.DefaultValue = "+";
			DataColumn459.ColumnName = "+-Hpx";
			DataColumn459.DefaultValue = "+";
			DataColumn460.ColumnName = "+-Spx";
			DataColumn460.DefaultValue = "+";
			DataColumn461.ColumnName = "+-Agi";
			DataColumn461.DefaultValue = "+";
			DataColumn498.ColumnName = "PartyFull";
			DataColumn498.DataType = typeof(bool);
			DataColumn498.DefaultValue = false;
			DataColumn514.ColumnName = "Point";
			DataColumn514.DataType = typeof(int);
			DataColumn514.DefaultValue = 0;
			DataColumn557.ColumnName = "MapName";
			DataColumn557.DefaultValue = "Trac Quan";
			DataTable3.Columns.AddRange(new DataColumn[32]
			{
				DataColumn23, DataColumn24, DataColumn25, DataColumn26, DataColumn27, DataColumn28, DataColumn29, DataColumn30, DataColumn31, DataColumn32,
				DataColumn33, DataColumn129, DataColumn130, DataColumn131, DataColumn132, DataColumn133, DataColumn134, DataColumn135, DataColumn136, DataColumn137,
				DataColumn138, DataColumn139, DataColumn140, DataColumn231, DataColumn239, DataColumn492, DataColumn493, DataColumn494, DataColumn495, DataColumn496,
				DataColumn497, DataColumn499
			});
			DataTable3.TableName = "Table_databasepet";
			DataColumn23.ColumnName = "ID";
			DataColumn23.DataType = typeof(int);
			DataColumn23.DefaultValue = 0;
			DataColumn24.ColumnName = "Name";
			DataColumn24.DefaultValue = "";
			DataColumn25.ColumnName = "Lv";
			DataColumn25.DataType = typeof(int);
			DataColumn25.DefaultValue = 0;
			DataColumn26.ColumnName = "Hp";
			DataColumn26.DataType = typeof(int);
			DataColumn26.DefaultValue = 0;
			DataColumn27.ColumnName = "MaxHp";
			DataColumn27.DataType = typeof(int);
			DataColumn27.DefaultValue = 0;
			DataColumn28.ColumnName = "Sp";
			DataColumn28.DataType = typeof(int);
			DataColumn28.DefaultValue = 0;
			DataColumn29.ColumnName = "MaxSp";
			DataColumn29.DataType = typeof(int);
			DataColumn29.DefaultValue = 0;
			DataColumn30.ColumnName = "Exp";
			DataColumn30.DataType = typeof(int);
			DataColumn30.DefaultValue = 0;
			DataColumn31.ColumnName = "MaxExp";
			DataColumn31.DataType = typeof(int);
			DataColumn31.DefaultValue = 0;
			DataColumn32.ColumnName = "TotalExp";
			DataColumn32.DataType = typeof(long);
			DataColumn32.DefaultValue = 0L;
			DataColumn33.ColumnName = "Fai";
			DataColumn33.DataType = typeof(int);
			DataColumn33.DefaultValue = 0;
			DataColumn129.ColumnName = "Int";
			DataColumn129.DataType = typeof(int);
			DataColumn129.DefaultValue = 0;
			DataColumn130.ColumnName = "Atk";
			DataColumn130.DataType = typeof(int);
			DataColumn130.DefaultValue = 0;
			DataColumn131.ColumnName = "Def";
			DataColumn131.DataType = typeof(int);
			DataColumn131.DefaultValue = 0;
			DataColumn132.ColumnName = "Hpx";
			DataColumn132.DataType = typeof(int);
			DataColumn132.DefaultValue = 0;
			DataColumn133.ColumnName = "Spx";
			DataColumn133.DataType = typeof(int);
			DataColumn133.DefaultValue = 0;
			DataColumn134.ColumnName = "Agi";
			DataColumn134.DataType = typeof(int);
			DataColumn134.DefaultValue = 0;
			DataColumn135.ColumnName = "+Int";
			DataColumn135.DataType = typeof(int);
			DataColumn135.DefaultValue = 0;
			DataColumn136.ColumnName = "+Atk";
			DataColumn136.DataType = typeof(int);
			DataColumn136.DefaultValue = 0;
			DataColumn137.ColumnName = "+Def";
			DataColumn137.DataType = typeof(int);
			DataColumn137.DefaultValue = 0;
			DataColumn138.ColumnName = "+Hpx";
			DataColumn138.DataType = typeof(int);
			DataColumn138.DefaultValue = 0;
			DataColumn139.ColumnName = "+Spx";
			DataColumn139.DataType = typeof(int);
			DataColumn139.DefaultValue = 0;
			DataColumn140.ColumnName = "+Agi";
			DataColumn140.DataType = typeof(int);
			DataColumn140.DefaultValue = 0;
			DataColumn231.ColumnName = "ExpMin";
			DataColumn231.DataType = typeof(int);
			DataColumn231.DefaultValue = 0;
			DataColumn239.ColumnName = "TExp";
			DataColumn239.DataType = typeof(int);
			DataColumn239.DefaultValue = 0;
			DataColumn492.ColumnName = "+-Int";
			DataColumn492.DefaultValue = "+";
			DataColumn493.ColumnName = "+-Atk";
			DataColumn493.DefaultValue = "+";
			DataColumn494.ColumnName = "+-Def";
			DataColumn494.DefaultValue = "+";
			DataColumn495.ColumnName = "+-Hpx";
			DataColumn495.DefaultValue = "+";
			DataColumn496.ColumnName = "+-Spx";
			DataColumn496.DefaultValue = "+";
			DataColumn497.ColumnName = "+-Agi";
			DataColumn497.DefaultValue = "+";
			DataColumn499.ColumnName = "proto";
			DataColumn499.DataType = typeof(int);
			DataColumn499.DefaultValue = 0;
			DataTable4.Columns.AddRange(new DataColumn[5] { DataColumn35, DataColumn36, DataColumn37, DataColumn38, DataColumn39 });
			DataTable4.TableName = "Table_homdo";
			DataColumn35.ColumnName = "slot";
			DataColumn36.ColumnName = "id";
			DataColumn37.ColumnName = "name";
			DataColumn38.ColumnName = "count";
			DataColumn39.ColumnName = "dmg";
			DataTable5.Columns.AddRange(new DataColumn[5] { DataColumn40, DataColumn41, DataColumn42, DataColumn43, DataColumn44 });
			DataTable5.TableName = "Table_bdytuideo";
			DataColumn40.ColumnName = "slot";
			DataColumn41.ColumnName = "id";
			DataColumn42.ColumnName = "name";
			DataColumn43.ColumnName = "count";
			DataColumn44.ColumnName = "dmg";
			DataTable6.Columns.AddRange(new DataColumn[38]
			{
				DataColumn45, DataColumn46, DataColumn47, DataColumn48, DataColumn49, DataColumn50, DataColumn51, DataColumn52, DataColumn53, DataColumn54,
				DataColumn55, DataColumn56, DataColumn93, DataColumn141, DataColumn142, DataColumn143, DataColumn144, DataColumn145, DataColumn146, DataColumn147,
				DataColumn148, DataColumn149, DataColumn150, DataColumn151, DataColumn152, DataColumn114, DataColumn115, DataColumn116, DataColumn189, DataColumn190,
				DataColumn191, DataColumn462, DataColumn463, DataColumn464, DataColumn465, DataColumn466, DataColumn467, DataColumn501
			});
			DataTable6.TableName = "Table_pet1";
			DataColumn45.ColumnName = "id";
			DataColumn45.DataType = typeof(int);
			DataColumn45.DefaultValue = 0;
			DataColumn46.ColumnName = "name";
			DataColumn47.ColumnName = "lv";
			DataColumn47.DataType = typeof(int);
			DataColumn47.DefaultValue = 0;
			DataColumn48.ColumnName = "tt";
			DataColumn48.DataType = typeof(int);
			DataColumn48.DefaultValue = 0;
			DataColumn49.ColumnName = "hp";
			DataColumn49.DataType = typeof(int);
			DataColumn49.DefaultValue = 0;
			DataColumn50.ColumnName = "maxhp";
			DataColumn50.DataType = typeof(int);
			DataColumn50.DefaultValue = 0;
			DataColumn51.ColumnName = "sp";
			DataColumn51.DataType = typeof(int);
			DataColumn51.DefaultValue = 0;
			DataColumn52.ColumnName = "maxsp";
			DataColumn52.DataType = typeof(int);
			DataColumn52.DefaultValue = 0;
			DataColumn53.ColumnName = "fai";
			DataColumn53.DataType = typeof(int);
			DataColumn53.DefaultValue = 0;
			DataColumn54.ColumnName = "exp";
			DataColumn54.DataType = typeof(int);
			DataColumn54.DefaultValue = 0;
			DataColumn55.ColumnName = "maxexp";
			DataColumn55.DataType = typeof(int);
			DataColumn55.DefaultValue = 0;
			DataColumn56.ColumnName = "totalexp";
			DataColumn56.DataType = typeof(int);
			DataColumn56.DefaultValue = 0;
			DataColumn93.ColumnName = "reborn";
			DataColumn93.DataType = typeof(int);
			DataColumn93.DefaultValue = 0;
			DataColumn141.ColumnName = "Int";
			DataColumn141.DataType = typeof(int);
			DataColumn141.DefaultValue = 0;
			DataColumn142.ColumnName = "Atk";
			DataColumn142.DataType = typeof(int);
			DataColumn142.DefaultValue = 0;
			DataColumn143.ColumnName = "Def";
			DataColumn143.DataType = typeof(int);
			DataColumn143.DefaultValue = 0;
			DataColumn144.ColumnName = "Hpx";
			DataColumn144.DataType = typeof(int);
			DataColumn144.DefaultValue = 0;
			DataColumn145.ColumnName = "Spx";
			DataColumn145.DataType = typeof(int);
			DataColumn145.DefaultValue = 0;
			DataColumn146.ColumnName = "Agi";
			DataColumn146.DataType = typeof(int);
			DataColumn146.DefaultValue = 0;
			DataColumn147.ColumnName = "+Int";
			DataColumn147.DataType = typeof(int);
			DataColumn147.DefaultValue = 0;
			DataColumn148.ColumnName = "+Atk";
			DataColumn148.DataType = typeof(int);
			DataColumn148.DefaultValue = 0;
			DataColumn149.ColumnName = "+Def";
			DataColumn149.DataType = typeof(int);
			DataColumn149.DefaultValue = 0;
			DataColumn150.ColumnName = "+Hpx";
			DataColumn150.DataType = typeof(int);
			DataColumn150.DefaultValue = 0;
			DataColumn151.ColumnName = "+Spx";
			DataColumn151.DataType = typeof(int);
			DataColumn151.DefaultValue = 0;
			DataColumn152.ColumnName = "+Agi";
			DataColumn152.DataType = typeof(int);
			DataColumn152.DefaultValue = 0;
			DataColumn114.ColumnName = "mu";
			DataColumn114.DataType = typeof(int);
			DataColumn114.DefaultValue = 0;
			DataColumn115.ColumnName = "ao";
			DataColumn115.DataType = typeof(int);
			DataColumn115.DefaultValue = 0;
			DataColumn116.ColumnName = "vukhi";
			DataColumn116.DataType = typeof(int);
			DataColumn116.DefaultValue = 0;
			DataColumn189.ColumnName = "tay";
			DataColumn189.DataType = typeof(int);
			DataColumn189.DefaultValue = 0;
			DataColumn190.ColumnName = "chan";
			DataColumn190.DataType = typeof(int);
			DataColumn190.DefaultValue = 0;
			DataColumn191.ColumnName = "dacthu";
			DataColumn191.DataType = typeof(int);
			DataColumn191.DefaultValue = 0;
			DataColumn462.ColumnName = "+-Int";
			DataColumn462.DefaultValue = "+";
			DataColumn463.ColumnName = "+-Atk";
			DataColumn463.DefaultValue = "+";
			DataColumn464.ColumnName = "+-Def";
			DataColumn464.DefaultValue = "+";
			DataColumn465.ColumnName = "+-Hpx";
			DataColumn465.DefaultValue = "+";
			DataColumn466.ColumnName = "+-Spx";
			DataColumn466.DefaultValue = "+";
			DataColumn467.ColumnName = "+-Agi";
			DataColumn467.DefaultValue = "+";
			DataColumn501.ColumnName = "proto";
			DataColumn501.DataType = typeof(int);
			DataColumn501.DefaultValue = 0;
			DataTable7.Columns.AddRange(new DataColumn[38]
			{
				DataColumn57, DataColumn58, DataColumn59, DataColumn60, DataColumn61, DataColumn62, DataColumn63, DataColumn64, DataColumn65, DataColumn66,
				DataColumn67, DataColumn68, DataColumn94, DataColumn153, DataColumn154, DataColumn155, DataColumn156, DataColumn157, DataColumn158, DataColumn159,
				DataColumn160, DataColumn161, DataColumn162, DataColumn163, DataColumn164, DataColumn192, DataColumn193, DataColumn194, DataColumn195, DataColumn196,
				DataColumn197, DataColumn468, DataColumn469, DataColumn470, DataColumn471, DataColumn472, DataColumn473, DataColumn502
			});
			DataTable7.TableName = "Table_pet2";
			DataColumn57.ColumnName = "id";
			DataColumn57.DataType = typeof(int);
			DataColumn57.DefaultValue = 0;
			DataColumn58.ColumnName = "name";
			DataColumn59.ColumnName = "lv";
			DataColumn59.DataType = typeof(int);
			DataColumn59.DefaultValue = 0;
			DataColumn60.ColumnName = "tt";
			DataColumn60.DataType = typeof(int);
			DataColumn60.DefaultValue = 0;
			DataColumn61.ColumnName = "hp";
			DataColumn61.DataType = typeof(int);
			DataColumn61.DefaultValue = 0;
			DataColumn62.ColumnName = "maxhp";
			DataColumn62.DataType = typeof(int);
			DataColumn62.DefaultValue = 0;
			DataColumn63.ColumnName = "sp";
			DataColumn63.DataType = typeof(int);
			DataColumn63.DefaultValue = 0;
			DataColumn64.ColumnName = "maxsp";
			DataColumn64.DataType = typeof(int);
			DataColumn64.DefaultValue = 0;
			DataColumn65.ColumnName = "fai";
			DataColumn65.DataType = typeof(int);
			DataColumn65.DefaultValue = 0;
			DataColumn66.ColumnName = "exp";
			DataColumn66.DataType = typeof(int);
			DataColumn66.DefaultValue = 0;
			DataColumn67.ColumnName = "maxexp";
			DataColumn67.DataType = typeof(int);
			DataColumn67.DefaultValue = 0;
			DataColumn68.ColumnName = "totalexp";
			DataColumn68.DataType = typeof(int);
			DataColumn68.DefaultValue = 0;
			DataColumn94.ColumnName = "reborn";
			DataColumn94.DataType = typeof(int);
			DataColumn94.DefaultValue = 0;
			DataColumn153.ColumnName = "Int";
			DataColumn153.DataType = typeof(int);
			DataColumn153.DefaultValue = 0;
			DataColumn154.ColumnName = "Atk";
			DataColumn154.DataType = typeof(int);
			DataColumn154.DefaultValue = 0;
			DataColumn155.ColumnName = "Def";
			DataColumn155.DataType = typeof(int);
			DataColumn155.DefaultValue = 0;
			DataColumn156.ColumnName = "Hpx";
			DataColumn156.DataType = typeof(int);
			DataColumn156.DefaultValue = 0;
			DataColumn157.ColumnName = "Spx";
			DataColumn157.DataType = typeof(int);
			DataColumn157.DefaultValue = 0;
			DataColumn158.ColumnName = "Agi";
			DataColumn158.DataType = typeof(int);
			DataColumn158.DefaultValue = 0;
			DataColumn159.ColumnName = "+Int";
			DataColumn159.DataType = typeof(int);
			DataColumn159.DefaultValue = 0;
			DataColumn160.ColumnName = "+Atk";
			DataColumn160.DataType = typeof(int);
			DataColumn160.DefaultValue = 0;
			DataColumn161.ColumnName = "+Def";
			DataColumn161.DataType = typeof(int);
			DataColumn161.DefaultValue = 0;
			DataColumn162.ColumnName = "+Hpx";
			DataColumn162.DataType = typeof(int);
			DataColumn162.DefaultValue = 0;
			DataColumn163.ColumnName = "+Spx";
			DataColumn163.DataType = typeof(int);
			DataColumn163.DefaultValue = 0;
			DataColumn164.ColumnName = "+Agi";
			DataColumn164.DataType = typeof(int);
			DataColumn164.DefaultValue = 0;
			DataColumn192.ColumnName = "mu";
			DataColumn192.DataType = typeof(int);
			DataColumn192.DefaultValue = 0;
			DataColumn193.ColumnName = "ao";
			DataColumn193.DataType = typeof(int);
			DataColumn193.DefaultValue = 0;
			DataColumn194.ColumnName = "vukhi";
			DataColumn194.DataType = typeof(int);
			DataColumn194.DefaultValue = 0;
			DataColumn195.ColumnName = "tay";
			DataColumn195.DataType = typeof(int);
			DataColumn195.DefaultValue = 0;
			DataColumn196.ColumnName = "chan";
			DataColumn196.DataType = typeof(int);
			DataColumn196.DefaultValue = 0;
			DataColumn197.ColumnName = "dacthu";
			DataColumn197.DataType = typeof(int);
			DataColumn197.DefaultValue = 0;
			DataColumn468.ColumnName = "+-Int";
			DataColumn468.DefaultValue = "+";
			DataColumn469.ColumnName = "+-Atk";
			DataColumn469.DefaultValue = "+";
			DataColumn470.ColumnName = "+-Def";
			DataColumn470.DefaultValue = "+";
			DataColumn471.ColumnName = "+-Hpx";
			DataColumn471.DefaultValue = "+";
			DataColumn472.ColumnName = "+-Spx";
			DataColumn472.DefaultValue = "+";
			DataColumn473.ColumnName = "+-Agi";
			DataColumn473.DefaultValue = "+";
			DataColumn502.ColumnName = "proto";
			DataColumn502.DataType = typeof(int);
			DataColumn502.DefaultValue = 0;
			DataTable8.Columns.AddRange(new DataColumn[38]
			{
				DataColumn69, DataColumn70, DataColumn71, DataColumn72, DataColumn73, DataColumn74, DataColumn75, DataColumn76, DataColumn77, DataColumn78,
				DataColumn79, DataColumn80, DataColumn95, DataColumn165, DataColumn166, DataColumn167, DataColumn168, DataColumn169, DataColumn170, DataColumn171,
				DataColumn172, DataColumn173, DataColumn174, DataColumn175, DataColumn176, DataColumn198, DataColumn199, DataColumn200, DataColumn201, DataColumn202,
				DataColumn203, DataColumn474, DataColumn475, DataColumn476, DataColumn477, DataColumn478, DataColumn479, DataColumn503
			});
			DataTable8.TableName = "Table_pet3";
			DataColumn69.ColumnName = "id";
			DataColumn69.DataType = typeof(int);
			DataColumn69.DefaultValue = 0;
			DataColumn70.ColumnName = "name";
			DataColumn71.ColumnName = "lv";
			DataColumn71.DataType = typeof(int);
			DataColumn71.DefaultValue = 0;
			DataColumn72.ColumnName = "tt";
			DataColumn72.DataType = typeof(int);
			DataColumn72.DefaultValue = 0;
			DataColumn73.ColumnName = "hp";
			DataColumn73.DataType = typeof(int);
			DataColumn73.DefaultValue = 0;
			DataColumn74.ColumnName = "maxhp";
			DataColumn74.DataType = typeof(int);
			DataColumn74.DefaultValue = 0;
			DataColumn75.ColumnName = "sp";
			DataColumn75.DataType = typeof(int);
			DataColumn75.DefaultValue = 0;
			DataColumn76.ColumnName = "maxsp";
			DataColumn76.DataType = typeof(int);
			DataColumn76.DefaultValue = 0;
			DataColumn77.ColumnName = "fai";
			DataColumn77.DataType = typeof(int);
			DataColumn77.DefaultValue = 0;
			DataColumn78.ColumnName = "exp";
			DataColumn78.DataType = typeof(int);
			DataColumn78.DefaultValue = 0;
			DataColumn79.ColumnName = "maxexp";
			DataColumn79.DataType = typeof(int);
			DataColumn79.DefaultValue = 0;
			DataColumn80.ColumnName = "totalexp";
			DataColumn80.DataType = typeof(int);
			DataColumn80.DefaultValue = 0;
			DataColumn95.ColumnName = "reborn";
			DataColumn95.DataType = typeof(int);
			DataColumn95.DefaultValue = 0;
			DataColumn165.ColumnName = "Int";
			DataColumn165.DataType = typeof(int);
			DataColumn165.DefaultValue = 0;
			DataColumn166.ColumnName = "Atk";
			DataColumn166.DataType = typeof(int);
			DataColumn166.DefaultValue = 0;
			DataColumn167.ColumnName = "Def";
			DataColumn167.DefaultValue = "0";
			DataColumn168.ColumnName = "Hpx";
			DataColumn168.DataType = typeof(int);
			DataColumn168.DefaultValue = 0;
			DataColumn169.ColumnName = "Spx";
			DataColumn169.DataType = typeof(int);
			DataColumn169.DefaultValue = 0;
			DataColumn170.ColumnName = "Agi";
			DataColumn170.DataType = typeof(int);
			DataColumn170.DefaultValue = 0;
			DataColumn171.ColumnName = "+Int";
			DataColumn171.DataType = typeof(int);
			DataColumn171.DefaultValue = 0;
			DataColumn172.ColumnName = "+Atk";
			DataColumn172.DataType = typeof(int);
			DataColumn172.DefaultValue = 0;
			DataColumn173.ColumnName = "+Def";
			DataColumn173.DataType = typeof(int);
			DataColumn173.DefaultValue = 0;
			DataColumn174.ColumnName = "+Hpx";
			DataColumn174.DataType = typeof(int);
			DataColumn174.DefaultValue = 0;
			DataColumn175.ColumnName = "+Spx";
			DataColumn175.DataType = typeof(int);
			DataColumn175.DefaultValue = 0;
			DataColumn176.ColumnName = "+Agi";
			DataColumn176.DataType = typeof(int);
			DataColumn176.DefaultValue = 0;
			DataColumn198.ColumnName = "mu";
			DataColumn198.DataType = typeof(int);
			DataColumn198.DefaultValue = 0;
			DataColumn199.ColumnName = "ao";
			DataColumn199.DataType = typeof(int);
			DataColumn199.DefaultValue = 0;
			DataColumn200.ColumnName = "vukhi";
			DataColumn200.DataType = typeof(int);
			DataColumn200.DefaultValue = 0;
			DataColumn201.ColumnName = "tay";
			DataColumn201.DataType = typeof(int);
			DataColumn201.DefaultValue = 0;
			DataColumn202.ColumnName = "chan";
			DataColumn202.DataType = typeof(int);
			DataColumn202.DefaultValue = 0;
			DataColumn203.ColumnName = "dacthu";
			DataColumn203.DataType = typeof(int);
			DataColumn203.DefaultValue = 0;
			DataColumn474.ColumnName = "+-Int";
			DataColumn474.DefaultValue = "+";
			DataColumn475.ColumnName = "+-Atk";
			DataColumn475.DefaultValue = "+";
			DataColumn476.ColumnName = "+-Def";
			DataColumn476.DefaultValue = "+";
			DataColumn477.ColumnName = "+-Hpx";
			DataColumn477.DefaultValue = "+";
			DataColumn478.ColumnName = "+-Spx";
			DataColumn478.DefaultValue = "+";
			DataColumn479.ColumnName = "+-Agi";
			DataColumn479.DefaultValue = "+";
			DataColumn503.ColumnName = "proto";
			DataColumn503.DataType = typeof(int);
			DataColumn503.DefaultValue = 0;
			DataTable9.Columns.AddRange(new DataColumn[38]
			{
				DataColumn81, DataColumn82, DataColumn83, DataColumn84, DataColumn85, DataColumn86, DataColumn87, DataColumn88, DataColumn89, DataColumn90,
				DataColumn91, DataColumn92, DataColumn96, DataColumn177, DataColumn178, DataColumn179, DataColumn180, DataColumn181, DataColumn182, DataColumn183,
				DataColumn184, DataColumn185, DataColumn186, DataColumn187, DataColumn188, DataColumn204, DataColumn205, DataColumn206, DataColumn207, DataColumn208,
				DataColumn209, DataColumn480, DataColumn481, DataColumn482, DataColumn483, DataColumn484, DataColumn485, DataColumn504
			});
			DataTable9.TableName = "Table_pet4";
			DataColumn81.ColumnName = "id";
			DataColumn81.DataType = typeof(int);
			DataColumn81.DefaultValue = 0;
			DataColumn82.ColumnName = "name";
			DataColumn83.ColumnName = "lv";
			DataColumn83.DataType = typeof(int);
			DataColumn83.DefaultValue = 0;
			DataColumn84.ColumnName = "tt";
			DataColumn84.DataType = typeof(int);
			DataColumn84.DefaultValue = 0;
			DataColumn85.ColumnName = "hp";
			DataColumn85.DataType = typeof(int);
			DataColumn85.DefaultValue = 0;
			DataColumn86.ColumnName = "maxhp";
			DataColumn86.DataType = typeof(int);
			DataColumn86.DefaultValue = 0;
			DataColumn87.ColumnName = "sp";
			DataColumn87.DataType = typeof(int);
			DataColumn87.DefaultValue = 0;
			DataColumn88.ColumnName = "maxsp";
			DataColumn88.DataType = typeof(int);
			DataColumn88.DefaultValue = 0;
			DataColumn89.ColumnName = "fai";
			DataColumn89.DataType = typeof(int);
			DataColumn89.DefaultValue = 0;
			DataColumn90.ColumnName = "exp";
			DataColumn90.DataType = typeof(int);
			DataColumn90.DefaultValue = 0;
			DataColumn91.ColumnName = "maxexp";
			DataColumn91.DataType = typeof(int);
			DataColumn91.DefaultValue = 0;
			DataColumn92.ColumnName = "totalexp";
			DataColumn92.DataType = typeof(int);
			DataColumn92.DefaultValue = 0;
			DataColumn96.ColumnName = "reborn";
			DataColumn96.DataType = typeof(int);
			DataColumn96.DefaultValue = 0;
			DataColumn177.ColumnName = "Int";
			DataColumn177.DataType = typeof(int);
			DataColumn177.DefaultValue = 0;
			DataColumn178.ColumnName = "Atk";
			DataColumn178.DataType = typeof(int);
			DataColumn178.DefaultValue = 0;
			DataColumn179.ColumnName = "Def";
			DataColumn179.DataType = typeof(int);
			DataColumn179.DefaultValue = 0;
			DataColumn180.ColumnName = "Hpx";
			DataColumn180.DataType = typeof(int);
			DataColumn180.DefaultValue = 0;
			DataColumn181.ColumnName = "Spx";
			DataColumn181.DataType = typeof(int);
			DataColumn181.DefaultValue = 0;
			DataColumn182.ColumnName = "Agi";
			DataColumn182.DataType = typeof(int);
			DataColumn182.DefaultValue = 0;
			DataColumn183.ColumnName = "+Int";
			DataColumn183.DataType = typeof(int);
			DataColumn183.DefaultValue = 0;
			DataColumn184.ColumnName = "+Atk";
			DataColumn184.DataType = typeof(int);
			DataColumn184.DefaultValue = 0;
			DataColumn185.ColumnName = "+Def";
			DataColumn185.DataType = typeof(int);
			DataColumn185.DefaultValue = 0;
			DataColumn186.ColumnName = "+Hpx";
			DataColumn186.DataType = typeof(int);
			DataColumn186.DefaultValue = 0;
			DataColumn187.ColumnName = "+Spx";
			DataColumn187.DataType = typeof(int);
			DataColumn187.DefaultValue = 0;
			DataColumn188.ColumnName = "+Agi";
			DataColumn188.DataType = typeof(int);
			DataColumn188.DefaultValue = 0;
			DataColumn204.ColumnName = "mu";
			DataColumn204.DataType = typeof(int);
			DataColumn204.DefaultValue = 0;
			DataColumn205.ColumnName = "ao";
			DataColumn205.DataType = typeof(int);
			DataColumn205.DefaultValue = 0;
			DataColumn206.ColumnName = "vukhi";
			DataColumn206.DataType = typeof(int);
			DataColumn206.DefaultValue = 0;
			DataColumn207.ColumnName = "tay";
			DataColumn207.DataType = typeof(int);
			DataColumn207.DefaultValue = 0;
			DataColumn208.ColumnName = "chan";
			DataColumn208.DataType = typeof(int);
			DataColumn208.DefaultValue = 0;
			DataColumn209.ColumnName = "dacthu";
			DataColumn209.DataType = typeof(int);
			DataColumn209.DefaultValue = 0;
			DataColumn480.ColumnName = "+-Int";
			DataColumn480.DefaultValue = "+";
			DataColumn481.ColumnName = "+-Atk";
			DataColumn481.DefaultValue = "+";
			DataColumn482.ColumnName = "+-Def";
			DataColumn482.DefaultValue = "+";
			DataColumn483.ColumnName = "+-Hpx";
			DataColumn483.DefaultValue = "+";
			DataColumn484.ColumnName = "+-Spx";
			DataColumn484.DefaultValue = "+";
			DataColumn485.ColumnName = "+-Agi";
			DataColumn485.DefaultValue = "+";
			DataColumn504.ColumnName = "proto";
			DataColumn504.DataType = typeof(int);
			DataColumn504.DefaultValue = 0;
			DataTable10.Columns.AddRange(new DataColumn[38]
			{
				DataColumn97, DataColumn98, DataColumn99, DataColumn100, DataColumn101, DataColumn102, DataColumn103, DataColumn104, DataColumn105, DataColumn106,
				DataColumn107, DataColumn108, DataColumn109, DataColumn210, DataColumn211, DataColumn212, DataColumn213, DataColumn214, DataColumn215, DataColumn216,
				DataColumn217, DataColumn218, DataColumn219, DataColumn220, DataColumn221, DataColumn222, DataColumn223, DataColumn224, DataColumn225, DataColumn226,
				DataColumn227, DataColumn486, DataColumn487, DataColumn488, DataColumn489, DataColumn490, DataColumn491, DataColumn500
			});
			DataTable10.TableName = "Table_petbattle";
			DataColumn97.ColumnName = "id";
			DataColumn97.DataType = typeof(int);
			DataColumn97.DefaultValue = 0;
			DataColumn98.ColumnName = "name";
			DataColumn99.ColumnName = "lv";
			DataColumn99.DataType = typeof(int);
			DataColumn99.DefaultValue = 0;
			DataColumn100.ColumnName = "tt";
			DataColumn100.DataType = typeof(int);
			DataColumn100.DefaultValue = 0;
			DataColumn101.ColumnName = "hp";
			DataColumn101.DataType = typeof(int);
			DataColumn101.DefaultValue = 0;
			DataColumn102.ColumnName = "maxhp";
			DataColumn102.DataType = typeof(int);
			DataColumn102.DefaultValue = 0;
			DataColumn103.ColumnName = "sp";
			DataColumn103.DataType = typeof(int);
			DataColumn103.DefaultValue = 0;
			DataColumn104.ColumnName = "maxsp";
			DataColumn104.DataType = typeof(int);
			DataColumn104.DefaultValue = 0;
			DataColumn105.ColumnName = "fai";
			DataColumn105.DataType = typeof(int);
			DataColumn105.DefaultValue = 0;
			DataColumn106.ColumnName = "exp";
			DataColumn106.DataType = typeof(int);
			DataColumn106.DefaultValue = 0;
			DataColumn107.ColumnName = "maxexp";
			DataColumn107.DataType = typeof(int);
			DataColumn107.DefaultValue = 0;
			DataColumn108.ColumnName = "totalexp";
			DataColumn108.DataType = typeof(int);
			DataColumn108.DefaultValue = 0;
			DataColumn109.ColumnName = "reborn";
			DataColumn109.DataType = typeof(int);
			DataColumn109.DefaultValue = 0;
			DataColumn210.ColumnName = "Int";
			DataColumn210.DataType = typeof(int);
			DataColumn210.DefaultValue = 0;
			DataColumn211.ColumnName = "Atk";
			DataColumn211.DataType = typeof(int);
			DataColumn211.DefaultValue = 0;
			DataColumn212.ColumnName = "Def";
			DataColumn212.DataType = typeof(int);
			DataColumn212.DefaultValue = 0;
			DataColumn213.ColumnName = "Hpx";
			DataColumn213.DataType = typeof(int);
			DataColumn213.DefaultValue = 0;
			DataColumn214.ColumnName = "Spx";
			DataColumn214.DataType = typeof(int);
			DataColumn214.DefaultValue = 0;
			DataColumn215.ColumnName = "Agi";
			DataColumn215.DataType = typeof(int);
			DataColumn215.DefaultValue = 0;
			DataColumn216.ColumnName = "+Int";
			DataColumn216.DataType = typeof(int);
			DataColumn216.DefaultValue = 0;
			DataColumn217.ColumnName = "+Atk";
			DataColumn217.DataType = typeof(int);
			DataColumn217.DefaultValue = 0;
			DataColumn218.ColumnName = "+Def";
			DataColumn218.DataType = typeof(int);
			DataColumn218.DefaultValue = 0;
			DataColumn219.ColumnName = "+Hpx";
			DataColumn219.DataType = typeof(int);
			DataColumn219.DefaultValue = 0;
			DataColumn220.ColumnName = "+Spx";
			DataColumn220.DataType = typeof(int);
			DataColumn220.DefaultValue = 0;
			DataColumn221.ColumnName = "+Agi";
			DataColumn221.DataType = typeof(int);
			DataColumn221.DefaultValue = 0;
			DataColumn222.ColumnName = "mu";
			DataColumn222.DataType = typeof(int);
			DataColumn222.DefaultValue = 0;
			DataColumn223.ColumnName = "ao";
			DataColumn223.DataType = typeof(int);
			DataColumn223.DefaultValue = 0;
			DataColumn224.ColumnName = "vukhi";
			DataColumn224.DataType = typeof(int);
			DataColumn224.DefaultValue = 0;
			DataColumn225.ColumnName = "tay";
			DataColumn225.DataType = typeof(int);
			DataColumn225.DefaultValue = 0;
			DataColumn226.ColumnName = "chan";
			DataColumn226.DataType = typeof(int);
			DataColumn226.DefaultValue = 0;
			DataColumn227.ColumnName = "dacthu";
			DataColumn227.DataType = typeof(int);
			DataColumn227.DefaultValue = 0;
			DataColumn486.ColumnName = "+-Int";
			DataColumn486.DefaultValue = "+";
			DataColumn487.ColumnName = "+-Atk";
			DataColumn487.DefaultValue = "+";
			DataColumn488.ColumnName = "+-Def";
			DataColumn488.DefaultValue = "+";
			DataColumn489.ColumnName = "+-Hpx";
			DataColumn489.DefaultValue = "+";
			DataColumn490.ColumnName = "+-Spx";
			DataColumn490.DefaultValue = "+";
			DataColumn491.ColumnName = "+-Agi";
			DataColumn491.DefaultValue = "+";
			DataColumn500.ColumnName = "proto";
			DataColumn500.DataType = typeof(int);
			DataColumn500.DefaultValue = 0;
			DataTable11.Columns.AddRange(new DataColumn[3] { DataColumn111, DataColumn112, DataColumn113 });
			DataTable11.TableName = "Table_CharEquit";
			DataColumn111.AllowDBNull = false;
			DataColumn111.ColumnName = "Id";
			DataColumn111.DataType = typeof(int);
			DataColumn111.DefaultValue = 0;
			DataColumn112.ColumnName = "Name";
			DataColumn112.DefaultValue = "";
			DataColumn113.ColumnName = "Doben";
			DataColumn113.DataType = typeof(int);
			DataColumn113.DefaultValue = 0;
			DataTable12.Columns.AddRange(new DataColumn[3] { DataColumn228, DataColumn229, DataColumn230 });
			DataTable12.TableName = "Table_PetEquit";
			DataColumn228.AllowDBNull = false;
			DataColumn228.ColumnName = "id";
			DataColumn228.DataType = typeof(int);
			DataColumn228.DefaultValue = 0;
			DataColumn229.ColumnName = "Name";
			DataColumn229.DefaultValue = "";
			DataColumn230.ColumnName = "Doben";
			DataColumn230.DataType = typeof(int);
			DataColumn230.DefaultValue = 0;
			DataTable13.Columns.AddRange(new DataColumn[5] { DataColumn110, DataColumn232, DataColumn233, DataColumn234, DataColumn515 });
			DataTable13.TableName = "Table_Tuido";
			DataColumn110.AllowDBNull = false;
			DataColumn110.ColumnName = "Stt";
			DataColumn110.DataType = typeof(int);
			DataColumn110.DefaultValue = 0;
			DataColumn232.ColumnName = "Id";
			DataColumn232.DataType = typeof(int);
			DataColumn232.DefaultValue = 0;
			DataColumn233.ColumnName = "Name";
			DataColumn233.DefaultValue = "";
			DataColumn234.ColumnName = "SL";
			DataColumn234.DataType = typeof(int);
			DataColumn234.DefaultValue = 0;
			DataColumn515.ColumnName = "Doben";
			DataColumn515.DefaultValue = "0";
			DataTable14.Columns.AddRange(new DataColumn[5] { DataColumn235, DataColumn236, DataColumn237, DataColumn238, DataColumn516 });
			DataTable14.TableName = "Table_Tuideo";
			DataColumn235.AllowDBNull = false;
			DataColumn235.ColumnName = "Stt";
			DataColumn235.DataType = typeof(int);
			DataColumn235.DefaultValue = 0;
			DataColumn236.ColumnName = "Id";
			DataColumn236.DataType = typeof(int);
			DataColumn236.DefaultValue = 0;
			DataColumn237.ColumnName = "Name";
			DataColumn237.DefaultValue = "";
			DataColumn238.ColumnName = "SL";
			DataColumn238.DataType = typeof(int);
			DataColumn238.DefaultValue = 0;
			DataColumn516.ColumnName = "Doben";
			DataColumn516.DefaultValue = "0";
			DataTable15.Columns.AddRange(new DataColumn[42]
			{
				DataColumn248, DataColumn249, DataColumn250, DataColumn251, DataColumn252, DataColumn253, DataColumn254, DataColumn255, DataColumn256, DataColumn257,
				DataColumn258, DataColumn259, DataColumn260, DataColumn261, DataColumn262, DataColumn263, DataColumn264, DataColumn265, DataColumn266, DataColumn267,
				DataColumn268, DataColumn269, DataColumn270, DataColumn271, DataColumn272, DataColumn273, DataColumn274, DataColumn275, DataColumn276, DataColumn277,
				DataColumn278, DataColumn279, DataColumn280, DataColumn281, DataColumn282, DataColumn283, DataColumn284, DataColumn285, DataColumn286, DataColumn287,
				DataColumn288, DataColumn289
			});
			DataTable15.TableName = "Table_Setting";
			DataColumn248.ColumnName = "CharTurnCount";
			DataColumn248.DataType = typeof(int);
			DataColumn248.DefaultValue = 1;
			DataColumn249.ColumnName = "CharSkill1";
			DataColumn249.DataType = typeof(int);
			DataColumn249.DefaultValue = 10000;
			DataColumn250.ColumnName = "CharSkill2";
			DataColumn250.DataType = typeof(int);
			DataColumn250.DefaultValue = 10000;
			DataColumn251.ColumnName = "CharSkill3";
			DataColumn251.DataType = typeof(int);
			DataColumn251.DefaultValue = 10000;
			DataColumn252.ColumnName = "CharSkill4";
			DataColumn252.DataType = typeof(int);
			DataColumn252.DefaultValue = 10000;
			DataColumn253.ColumnName = "CharSkill5";
			DataColumn253.DataType = typeof(int);
			DataColumn253.DefaultValue = 10000;
			DataColumn254.ColumnName = "CharSkill6";
			DataColumn254.DataType = typeof(int);
			DataColumn254.DefaultValue = 10000;
			DataColumn255.ColumnName = "CharSkill7";
			DataColumn255.DataType = typeof(int);
			DataColumn255.DefaultValue = 10000;
			DataColumn256.ColumnName = "CharSkill8";
			DataColumn256.DataType = typeof(int);
			DataColumn256.DefaultValue = 10000;
			DataColumn257.ColumnName = "CharSkill9";
			DataColumn257.DataType = typeof(int);
			DataColumn257.DefaultValue = 10000;
			DataColumn258.ColumnName = "CharSkill10";
			DataColumn258.DataType = typeof(int);
			DataColumn258.DefaultValue = 10000;
			DataColumn259.ColumnName = "CharLocation1";
			DataColumn259.DefaultValue = "3";
			DataColumn260.ColumnName = "CharLocation2";
			DataColumn260.DefaultValue = "3";
			DataColumn261.ColumnName = "CharLocation3";
			DataColumn261.DefaultValue = "3";
			DataColumn262.ColumnName = "CharLocation4";
			DataColumn262.DefaultValue = "3";
			DataColumn263.ColumnName = "CharLocation5";
			DataColumn263.DefaultValue = "3";
			DataColumn264.ColumnName = "CharLocation6";
			DataColumn264.DefaultValue = "3";
			DataColumn265.ColumnName = "CharLocation7";
			DataColumn265.DefaultValue = "3";
			DataColumn266.ColumnName = "CharLocation8";
			DataColumn266.DefaultValue = "3";
			DataColumn267.ColumnName = "CharLocation9";
			DataColumn267.DefaultValue = "3";
			DataColumn268.ColumnName = "CharLocation10";
			DataColumn268.DefaultValue = "3";
			DataColumn269.ColumnName = "PetTurnCount";
			DataColumn269.DataType = typeof(int);
			DataColumn269.DefaultValue = 1;
			DataColumn270.ColumnName = "PetSkill1";
			DataColumn270.DataType = typeof(int);
			DataColumn270.DefaultValue = 10000;
			DataColumn271.ColumnName = "PetSkill2";
			DataColumn271.DataType = typeof(int);
			DataColumn271.DefaultValue = 10000;
			DataColumn272.ColumnName = "PetSkill3";
			DataColumn272.DataType = typeof(int);
			DataColumn272.DefaultValue = 10000;
			DataColumn273.ColumnName = "PetSkill4";
			DataColumn273.DataType = typeof(int);
			DataColumn273.DefaultValue = 10000;
			DataColumn274.ColumnName = "PetSkill5";
			DataColumn274.DataType = typeof(int);
			DataColumn274.DefaultValue = 10000;
			DataColumn275.ColumnName = "PetSkill6";
			DataColumn275.DataType = typeof(int);
			DataColumn275.DefaultValue = 10000;
			DataColumn276.ColumnName = "PetSkill7";
			DataColumn276.DataType = typeof(int);
			DataColumn276.DefaultValue = 10000;
			DataColumn277.ColumnName = "PetSkill8";
			DataColumn277.DataType = typeof(int);
			DataColumn277.DefaultValue = 10000;
			DataColumn278.ColumnName = "PetSkill9";
			DataColumn278.DataType = typeof(int);
			DataColumn278.DefaultValue = 10000;
			DataColumn279.ColumnName = "PetSkill10";
			DataColumn279.DataType = typeof(int);
			DataColumn279.DefaultValue = 10000;
			DataColumn280.ColumnName = "PetLocation1";
			DataColumn280.DefaultValue = "3";
			DataColumn281.ColumnName = "PetLocation2";
			DataColumn281.DefaultValue = "3";
			DataColumn282.ColumnName = "PetLocation3";
			DataColumn282.DefaultValue = "3";
			DataColumn283.ColumnName = "PetLocation4";
			DataColumn283.DefaultValue = "3";
			DataColumn284.ColumnName = "PetLocation5";
			DataColumn284.DefaultValue = "3";
			DataColumn285.ColumnName = "PetLocation6";
			DataColumn285.DefaultValue = "3";
			DataColumn286.ColumnName = "PetLocation7";
			DataColumn286.DefaultValue = "3";
			DataColumn287.ColumnName = "PetLocation8";
			DataColumn287.DefaultValue = "3";
			DataColumn288.ColumnName = "PetLocation9";
			DataColumn288.DefaultValue = "3";
			DataColumn289.ColumnName = "PetLocation10";
			DataColumn289.DefaultValue = "3";
			DataTable16.Columns.AddRange(new DataColumn[2] { DataColumn290, DataColumn291 });
			DataTable16.TableName = "Table_ListDrop";
			DataColumn290.AllowDBNull = false;
			DataColumn290.ColumnName = "Id";
			DataColumn290.DataType = typeof(int);
			DataColumn290.DefaultValue = 0;
			DataColumn291.ColumnName = "Name";
			DataColumn291.DefaultValue = "";
			DataTable17.Columns.AddRange(new DataColumn[2] { DataColumn292, DataColumn293 });
			DataTable17.TableName = "Table_ListContribute";
			DataColumn292.AllowDBNull = false;
			DataColumn292.ColumnName = "Id";
			DataColumn292.DataType = typeof(int);
			DataColumn292.DefaultValue = 0;
			DataColumn293.ColumnName = "Name";
			DataColumn293.DefaultValue = "";
			DataTable18.Columns.AddRange(new DataColumn[2] { DataColumn294, DataColumn295 });
			DataTable18.TableName = "Table_ListSend";
			DataColumn294.AllowDBNull = false;
			DataColumn294.ColumnName = "Id";
			DataColumn294.DataType = typeof(int);
			DataColumn294.DefaultValue = 0;
			DataColumn295.ColumnName = "Name";
			DataColumn295.DefaultValue = "";
			DataTable19.Columns.AddRange(new DataColumn[11]
			{
				DataColumn296, DataColumn297, DataColumn298, DataColumn299, DataColumn300, DataColumn301, DataColumn302, DataColumn436, DataColumn517, DataColumn537,
				DataColumn559
			});
			DataTable19.TableName = "Table_Battle1";
			DataColumn296.ColumnName = "ID";
			DataColumn296.DataType = typeof(int);
			DataColumn296.DefaultValue = 0;
			DataColumn297.ColumnName = "Name";
			DataColumn297.DefaultValue = "";
			DataColumn298.ColumnName = "Lv";
			DataColumn298.DataType = typeof(int);
			DataColumn298.DefaultValue = 0;
			DataColumn299.ColumnName = "Hp";
			DataColumn299.DataType = typeof(int);
			DataColumn299.DefaultValue = 0;
			DataColumn300.ColumnName = "MaxHp";
			DataColumn300.DataType = typeof(int);
			DataColumn300.DefaultValue = 0;
			DataColumn301.ColumnName = "Sp";
			DataColumn301.DataType = typeof(int);
			DataColumn301.DefaultValue = 0;
			DataColumn302.ColumnName = "MaxSp";
			DataColumn302.DataType = typeof(int);
			DataColumn302.DefaultValue = 0;
			DataColumn436.ColumnName = "TT";
			DataColumn436.DefaultValue = "";
			DataColumn517.ColumnName = "Type";
			DataColumn517.DataType = typeof(int);
			DataColumn517.DefaultValue = 0;
			DataColumn537.ColumnName = "IdChar";
			DataColumn537.DataType = typeof(int);
			DataColumn537.DefaultValue = 0;
			DataColumn559.ColumnName = "Color";
			DataColumn559.DataType = typeof(object);
			DataTable21.Columns.AddRange(new DataColumn[11]
			{
				DataColumn303, DataColumn304, DataColumn305, DataColumn306, DataColumn307, DataColumn308, DataColumn309, DataColumn437, DataColumn518, DataColumn538,
				DataColumn560
			});
			DataTable21.TableName = "Table_Battle2";
			DataColumn303.ColumnName = "Id";
			DataColumn303.DataType = typeof(int);
			DataColumn303.DefaultValue = 0;
			DataColumn304.ColumnName = "Name";
			DataColumn304.DefaultValue = "";
			DataColumn305.ColumnName = "Lv";
			DataColumn305.DataType = typeof(int);
			DataColumn305.DefaultValue = 0;
			DataColumn306.ColumnName = "Hp";
			DataColumn306.DataType = typeof(int);
			DataColumn306.DefaultValue = 0;
			DataColumn307.ColumnName = "MaxHp";
			DataColumn307.DataType = typeof(int);
			DataColumn307.DefaultValue = 0;
			DataColumn308.ColumnName = "Sp";
			DataColumn308.DataType = typeof(int);
			DataColumn308.DefaultValue = 0;
			DataColumn309.ColumnName = "MaxSp";
			DataColumn309.DataType = typeof(int);
			DataColumn309.DefaultValue = 0;
			DataColumn437.ColumnName = "TT";
			DataColumn437.DefaultValue = "";
			DataColumn518.ColumnName = "Type";
			DataColumn518.DataType = typeof(int);
			DataColumn518.DefaultValue = 0;
			DataColumn538.ColumnName = "IdChar";
			DataColumn538.DataType = typeof(int);
			DataColumn538.DefaultValue = 0;
			DataColumn560.ColumnName = "Color";
			DataColumn560.DataType = typeof(object);
			DataTable22.Columns.AddRange(new DataColumn[11]
			{
				DataColumn310, DataColumn311, DataColumn312, DataColumn313, DataColumn314, DataColumn315, DataColumn316, DataColumn438, DataColumn519, DataColumn539,
				DataColumn561
			});
			DataTable22.TableName = "Table_Battle3";
			DataColumn310.ColumnName = "Id";
			DataColumn310.DataType = typeof(int);
			DataColumn310.DefaultValue = 0;
			DataColumn311.ColumnName = "Name";
			DataColumn311.DefaultValue = "";
			DataColumn312.ColumnName = "Lv";
			DataColumn312.DataType = typeof(int);
			DataColumn312.DefaultValue = 0;
			DataColumn313.ColumnName = "Hp";
			DataColumn313.DataType = typeof(int);
			DataColumn313.DefaultValue = 0;
			DataColumn314.ColumnName = "MaxHp";
			DataColumn314.DataType = typeof(int);
			DataColumn314.DefaultValue = 0;
			DataColumn315.ColumnName = "Sp";
			DataColumn315.DataType = typeof(int);
			DataColumn315.DefaultValue = 0;
			DataColumn316.ColumnName = "MaxSp";
			DataColumn316.DataType = typeof(int);
			DataColumn316.DefaultValue = 0;
			DataColumn438.ColumnName = "TT";
			DataColumn438.DefaultValue = "";
			DataColumn519.ColumnName = "Type";
			DataColumn519.DataType = typeof(int);
			DataColumn519.DefaultValue = 0;
			DataColumn539.ColumnName = "IdChar";
			DataColumn539.DataType = typeof(int);
			DataColumn539.DefaultValue = 0;
			DataColumn561.ColumnName = "Color";
			DataColumn561.DataType = typeof(object);
			DataTable23.Columns.AddRange(new DataColumn[11]
			{
				DataColumn317, DataColumn318, DataColumn319, DataColumn320, DataColumn321, DataColumn322, DataColumn323, DataColumn439, DataColumn520, DataColumn540,
				DataColumn562
			});
			DataTable23.TableName = "Table_Battle4";
			DataColumn317.ColumnName = "Id";
			DataColumn317.DataType = typeof(int);
			DataColumn317.DefaultValue = 0;
			DataColumn318.ColumnName = "Name";
			DataColumn318.DefaultValue = "";
			DataColumn319.ColumnName = "Lv";
			DataColumn319.DataType = typeof(int);
			DataColumn319.DefaultValue = 0;
			DataColumn320.ColumnName = "Hp";
			DataColumn320.DataType = typeof(int);
			DataColumn320.DefaultValue = 0;
			DataColumn321.ColumnName = "MaxHp";
			DataColumn321.DataType = typeof(int);
			DataColumn321.DefaultValue = 0;
			DataColumn322.ColumnName = "Sp";
			DataColumn322.DataType = typeof(int);
			DataColumn322.DefaultValue = 0;
			DataColumn323.ColumnName = "MaxSp";
			DataColumn323.DataType = typeof(int);
			DataColumn323.DefaultValue = 0;
			DataColumn439.ColumnName = "TT";
			DataColumn439.DefaultValue = "";
			DataColumn520.ColumnName = "Type";
			DataColumn520.DataType = typeof(int);
			DataColumn520.DefaultValue = 0;
			DataColumn540.ColumnName = "IdChar";
			DataColumn540.DataType = typeof(int);
			DataColumn540.DefaultValue = 0;
			DataColumn562.ColumnName = "Color";
			DataColumn562.DataType = typeof(object);
			DataTable24.Columns.AddRange(new DataColumn[11]
			{
				DataColumn324, DataColumn325, DataColumn326, DataColumn327, DataColumn328, DataColumn329, DataColumn330, DataColumn440, DataColumn521, DataColumn541,
				DataColumn558
			});
			DataTable24.TableName = "Table_Battle5";
			DataColumn324.ColumnName = "Id";
			DataColumn324.DataType = typeof(int);
			DataColumn324.DefaultValue = 0;
			DataColumn325.ColumnName = "Name";
			DataColumn325.DefaultValue = "";
			DataColumn326.ColumnName = "Lv";
			DataColumn326.DataType = typeof(int);
			DataColumn326.DefaultValue = 0;
			DataColumn327.ColumnName = "Hp";
			DataColumn327.DataType = typeof(int);
			DataColumn327.DefaultValue = 0;
			DataColumn328.ColumnName = "MaxHp";
			DataColumn328.DataType = typeof(int);
			DataColumn328.DefaultValue = 0;
			DataColumn329.ColumnName = "Sp";
			DataColumn329.DataType = typeof(int);
			DataColumn329.DefaultValue = 0;
			DataColumn330.ColumnName = "MaxSp";
			DataColumn330.DataType = typeof(int);
			DataColumn330.DefaultValue = 0;
			DataColumn440.ColumnName = "TT";
			DataColumn440.DefaultValue = "";
			DataColumn521.ColumnName = "Type";
			DataColumn521.DataType = typeof(int);
			DataColumn521.DefaultValue = 0;
			DataColumn541.ColumnName = "IdChar";
			DataColumn541.DataType = typeof(int);
			DataColumn541.DefaultValue = 0;
			DataColumn558.ColumnName = "Color";
			DataColumn558.DataType = typeof(object);
			DataTable25.Columns.AddRange(new DataColumn[11]
			{
				DataColumn331, DataColumn332, DataColumn333, DataColumn334, DataColumn335, DataColumn336, DataColumn337, DataColumn441, DataColumn522, DataColumn542,
				DataColumn563
			});
			DataTable25.TableName = "Table_Battle6";
			DataColumn331.ColumnName = "Id";
			DataColumn331.DataType = typeof(int);
			DataColumn331.DefaultValue = 0;
			DataColumn332.ColumnName = "Name";
			DataColumn332.DefaultValue = "";
			DataColumn333.ColumnName = "Lv";
			DataColumn333.DataType = typeof(int);
			DataColumn333.DefaultValue = 0;
			DataColumn334.ColumnName = "Hp";
			DataColumn334.DataType = typeof(int);
			DataColumn334.DefaultValue = 0;
			DataColumn335.ColumnName = "MaxHp";
			DataColumn335.DataType = typeof(int);
			DataColumn335.DefaultValue = 0;
			DataColumn336.ColumnName = "Sp";
			DataColumn336.DataType = typeof(int);
			DataColumn336.DefaultValue = 0;
			DataColumn337.ColumnName = "MaxSp";
			DataColumn337.DataType = typeof(int);
			DataColumn337.DefaultValue = 0;
			DataColumn441.ColumnName = "TT";
			DataColumn441.DefaultValue = "";
			DataColumn522.ColumnName = "Type";
			DataColumn522.DataType = typeof(int);
			DataColumn522.DefaultValue = 0;
			DataColumn542.ColumnName = "IdChar";
			DataColumn542.DataType = typeof(int);
			DataColumn542.DefaultValue = 0;
			DataColumn563.ColumnName = "Color";
			DataColumn563.DataType = typeof(object);
			DataTable26.Columns.AddRange(new DataColumn[11]
			{
				DataColumn338, DataColumn339, DataColumn340, DataColumn341, DataColumn342, DataColumn343, DataColumn344, DataColumn442, DataColumn523, DataColumn543,
				DataColumn564
			});
			DataTable26.TableName = "Table_Battle7";
			DataColumn338.ColumnName = "Id";
			DataColumn338.DataType = typeof(int);
			DataColumn338.DefaultValue = 0;
			DataColumn339.ColumnName = "Name";
			DataColumn339.DefaultValue = "";
			DataColumn340.ColumnName = "Lv";
			DataColumn340.DataType = typeof(int);
			DataColumn340.DefaultValue = 0;
			DataColumn341.ColumnName = "Hp";
			DataColumn341.DataType = typeof(int);
			DataColumn341.DefaultValue = 0;
			DataColumn342.ColumnName = "MaxHp";
			DataColumn342.DataType = typeof(int);
			DataColumn342.DefaultValue = 0;
			DataColumn343.ColumnName = "Sp";
			DataColumn343.DataType = typeof(int);
			DataColumn343.DefaultValue = 0;
			DataColumn344.ColumnName = "MaxSp";
			DataColumn344.DataType = typeof(int);
			DataColumn344.DefaultValue = 0;
			DataColumn442.ColumnName = "TT";
			DataColumn442.DefaultValue = "";
			DataColumn523.ColumnName = "Type";
			DataColumn523.DataType = typeof(int);
			DataColumn523.DefaultValue = 0;
			DataColumn543.ColumnName = "IdChar";
			DataColumn543.DataType = typeof(int);
			DataColumn543.DefaultValue = 0;
			DataColumn564.ColumnName = "Color";
			DataColumn564.DataType = typeof(object);
			DataTable27.Columns.AddRange(new DataColumn[11]
			{
				DataColumn345, DataColumn346, DataColumn347, DataColumn348, DataColumn349, DataColumn350, DataColumn351, DataColumn443, DataColumn524, DataColumn544,
				DataColumn565
			});
			DataTable27.TableName = "Table_Battle8";
			DataColumn345.ColumnName = "Id";
			DataColumn345.DataType = typeof(int);
			DataColumn345.DefaultValue = 0;
			DataColumn346.ColumnName = "Name";
			DataColumn346.DefaultValue = "";
			DataColumn347.ColumnName = "Lv";
			DataColumn347.DataType = typeof(int);
			DataColumn347.DefaultValue = 0;
			DataColumn348.ColumnName = "Hp";
			DataColumn348.DataType = typeof(int);
			DataColumn348.DefaultValue = 0;
			DataColumn349.ColumnName = "MaxHp";
			DataColumn349.DataType = typeof(int);
			DataColumn349.DefaultValue = 0;
			DataColumn350.ColumnName = "Sp";
			DataColumn350.DataType = typeof(int);
			DataColumn350.DefaultValue = 0;
			DataColumn351.ColumnName = "MaxSp";
			DataColumn351.DataType = typeof(int);
			DataColumn351.DefaultValue = 0;
			DataColumn443.ColumnName = "TT";
			DataColumn443.DefaultValue = "";
			DataColumn524.ColumnName = "Type";
			DataColumn524.DataType = typeof(int);
			DataColumn524.DefaultValue = 0;
			DataColumn544.ColumnName = "IdChar";
			DataColumn544.DataType = typeof(int);
			DataColumn544.DefaultValue = 0;
			DataColumn565.ColumnName = "Color";
			DataColumn565.DataType = typeof(object);
			DataTable28.Columns.AddRange(new DataColumn[11]
			{
				DataColumn352, DataColumn353, DataColumn354, DataColumn355, DataColumn356, DataColumn357, DataColumn358, DataColumn444, DataColumn525, DataColumn545,
				DataColumn566
			});
			DataTable28.TableName = "Table_Battle9";
			DataColumn352.ColumnName = "Id";
			DataColumn352.DataType = typeof(int);
			DataColumn352.DefaultValue = 0;
			DataColumn353.ColumnName = "Name";
			DataColumn353.DefaultValue = "";
			DataColumn354.ColumnName = "Lv";
			DataColumn354.DataType = typeof(int);
			DataColumn354.DefaultValue = 0;
			DataColumn355.ColumnName = "Hp";
			DataColumn355.DataType = typeof(int);
			DataColumn355.DefaultValue = 0;
			DataColumn356.ColumnName = "MaxHp";
			DataColumn356.DataType = typeof(int);
			DataColumn356.DefaultValue = 0;
			DataColumn357.ColumnName = "Sp";
			DataColumn357.DataType = typeof(int);
			DataColumn357.DefaultValue = 0;
			DataColumn358.ColumnName = "MaxSp";
			DataColumn358.DataType = typeof(int);
			DataColumn358.DefaultValue = 0;
			DataColumn444.ColumnName = "TT";
			DataColumn444.DefaultValue = "";
			DataColumn525.ColumnName = "Type";
			DataColumn525.DataType = typeof(int);
			DataColumn525.DefaultValue = 0;
			DataColumn545.ColumnName = "IdChar";
			DataColumn545.DataType = typeof(int);
			DataColumn545.DefaultValue = 0;
			DataColumn566.ColumnName = "Color";
			DataColumn566.DataType = typeof(object);
			DataTable29.Columns.AddRange(new DataColumn[11]
			{
				DataColumn359, DataColumn360, DataColumn361, DataColumn362, DataColumn363, DataColumn364, DataColumn365, DataColumn445, DataColumn526, DataColumn546,
				DataColumn567
			});
			DataTable29.TableName = "Table_Battle10";
			DataColumn359.ColumnName = "Id";
			DataColumn359.DataType = typeof(int);
			DataColumn359.DefaultValue = 0;
			DataColumn360.ColumnName = "Name";
			DataColumn360.DefaultValue = "";
			DataColumn361.ColumnName = "Lv";
			DataColumn361.DataType = typeof(int);
			DataColumn361.DefaultValue = 0;
			DataColumn362.ColumnName = "Hp";
			DataColumn362.DataType = typeof(int);
			DataColumn362.DefaultValue = 0;
			DataColumn363.ColumnName = "MaxHp";
			DataColumn363.DataType = typeof(int);
			DataColumn363.DefaultValue = 0;
			DataColumn364.ColumnName = "Sp";
			DataColumn364.DataType = typeof(int);
			DataColumn364.DefaultValue = 0;
			DataColumn365.ColumnName = "MaxSp";
			DataColumn365.DataType = typeof(int);
			DataColumn365.DefaultValue = 0;
			DataColumn445.ColumnName = "TT";
			DataColumn445.DefaultValue = "";
			DataColumn526.ColumnName = "Type";
			DataColumn526.DataType = typeof(int);
			DataColumn526.DefaultValue = 0;
			DataColumn546.ColumnName = "IdChar";
			DataColumn546.DataType = typeof(int);
			DataColumn546.DefaultValue = 0;
			DataColumn567.ColumnName = "Color";
			DataColumn567.DataType = typeof(object);
			DataTable30.Columns.AddRange(new DataColumn[11]
			{
				DataColumn366, DataColumn367, DataColumn368, DataColumn369, DataColumn370, DataColumn371, DataColumn372, DataColumn446, DataColumn527, DataColumn547,
				DataColumn568
			});
			DataTable30.TableName = "Table_Battle11";
			DataColumn366.ColumnName = "Id";
			DataColumn366.DataType = typeof(int);
			DataColumn366.DefaultValue = 0;
			DataColumn367.ColumnName = "Name";
			DataColumn367.DefaultValue = "";
			DataColumn368.ColumnName = "Lv";
			DataColumn368.DataType = typeof(int);
			DataColumn368.DefaultValue = 0;
			DataColumn369.ColumnName = "Hp";
			DataColumn369.DataType = typeof(int);
			DataColumn369.DefaultValue = 0;
			DataColumn370.ColumnName = "MaxHp";
			DataColumn370.DataType = typeof(int);
			DataColumn370.DefaultValue = 0;
			DataColumn371.ColumnName = "Sp";
			DataColumn371.DataType = typeof(int);
			DataColumn371.DefaultValue = 0;
			DataColumn372.ColumnName = "MaxSp";
			DataColumn372.DataType = typeof(int);
			DataColumn372.DefaultValue = 0;
			DataColumn446.ColumnName = "TT";
			DataColumn446.DefaultValue = "";
			DataColumn527.ColumnName = "Type";
			DataColumn527.DataType = typeof(int);
			DataColumn527.DefaultValue = 0;
			DataColumn547.ColumnName = "IdChar";
			DataColumn547.DataType = typeof(int);
			DataColumn547.DefaultValue = 0;
			DataColumn568.ColumnName = "Color";
			DataColumn568.DataType = typeof(object);
			DataTable31.Columns.AddRange(new DataColumn[11]
			{
				DataColumn373, DataColumn374, DataColumn375, DataColumn376, DataColumn377, DataColumn378, DataColumn379, DataColumn447, DataColumn528, DataColumn548,
				DataColumn569
			});
			DataTable31.TableName = "Table_Battle12";
			DataColumn373.ColumnName = "Id";
			DataColumn373.DataType = typeof(int);
			DataColumn373.DefaultValue = 0;
			DataColumn374.ColumnName = "Name";
			DataColumn374.DefaultValue = "";
			DataColumn375.ColumnName = "Lv";
			DataColumn375.DataType = typeof(int);
			DataColumn375.DefaultValue = 0;
			DataColumn376.ColumnName = "Hp";
			DataColumn376.DataType = typeof(int);
			DataColumn376.DefaultValue = 0;
			DataColumn377.ColumnName = "MaxHp";
			DataColumn377.DataType = typeof(int);
			DataColumn377.DefaultValue = 0;
			DataColumn378.ColumnName = "Sp";
			DataColumn378.DataType = typeof(int);
			DataColumn378.DefaultValue = 0;
			DataColumn379.ColumnName = "MaxSp";
			DataColumn379.DataType = typeof(int);
			DataColumn379.DefaultValue = 0;
			DataColumn447.ColumnName = "TT";
			DataColumn447.DefaultValue = "";
			DataColumn528.ColumnName = "Type";
			DataColumn528.DataType = typeof(int);
			DataColumn528.DefaultValue = 0;
			DataColumn548.ColumnName = "IdChar";
			DataColumn548.DataType = typeof(int);
			DataColumn548.DefaultValue = 0;
			DataColumn569.ColumnName = "Color";
			DataColumn569.DataType = typeof(object);
			DataTable32.Columns.AddRange(new DataColumn[11]
			{
				DataColumn380, DataColumn381, DataColumn382, DataColumn383, DataColumn384, DataColumn385, DataColumn386, DataColumn448, DataColumn529, DataColumn549,
				DataColumn570
			});
			DataTable32.TableName = "Table_Battle13";
			DataColumn380.ColumnName = "Id";
			DataColumn380.DataType = typeof(int);
			DataColumn380.DefaultValue = 0;
			DataColumn381.ColumnName = "Name";
			DataColumn381.DefaultValue = "";
			DataColumn382.ColumnName = "Lv";
			DataColumn382.DataType = typeof(int);
			DataColumn382.DefaultValue = 0;
			DataColumn383.ColumnName = "Hp";
			DataColumn383.DataType = typeof(int);
			DataColumn383.DefaultValue = 0;
			DataColumn384.ColumnName = "MaxHp";
			DataColumn384.DataType = typeof(int);
			DataColumn384.DefaultValue = 0;
			DataColumn385.ColumnName = "Sp";
			DataColumn385.DataType = typeof(int);
			DataColumn385.DefaultValue = 0;
			DataColumn386.ColumnName = "MaxSp";
			DataColumn386.DataType = typeof(int);
			DataColumn386.DefaultValue = 0;
			DataColumn448.ColumnName = "TT";
			DataColumn448.DefaultValue = "";
			DataColumn529.ColumnName = "Type";
			DataColumn529.DataType = typeof(int);
			DataColumn529.DefaultValue = 0;
			DataColumn549.ColumnName = "IdChar";
			DataColumn549.DataType = typeof(int);
			DataColumn549.DefaultValue = 0;
			DataColumn570.ColumnName = "Color";
			DataColumn570.DataType = typeof(object);
			DataTable33.Columns.AddRange(new DataColumn[11]
			{
				DataColumn387, DataColumn388, DataColumn389, DataColumn390, DataColumn391, DataColumn392, DataColumn393, DataColumn449, DataColumn530, DataColumn550,
				DataColumn571
			});
			DataTable33.TableName = "Table_Battle14";
			DataColumn387.ColumnName = "Id";
			DataColumn387.DataType = typeof(int);
			DataColumn387.DefaultValue = 0;
			DataColumn388.ColumnName = "Name";
			DataColumn388.DefaultValue = "";
			DataColumn389.ColumnName = "Lv";
			DataColumn389.DataType = typeof(int);
			DataColumn389.DefaultValue = 0;
			DataColumn390.ColumnName = "Hp";
			DataColumn390.DataType = typeof(int);
			DataColumn390.DefaultValue = 0;
			DataColumn391.ColumnName = "MaxHp";
			DataColumn391.DataType = typeof(int);
			DataColumn391.DefaultValue = 0;
			DataColumn392.ColumnName = "Sp";
			DataColumn392.DataType = typeof(int);
			DataColumn392.DefaultValue = 0;
			DataColumn393.ColumnName = "MaxSp";
			DataColumn393.DataType = typeof(int);
			DataColumn393.DefaultValue = 0;
			DataColumn449.ColumnName = "TT";
			DataColumn449.DefaultValue = "";
			DataColumn530.ColumnName = "Type";
			DataColumn530.DataType = typeof(int);
			DataColumn530.DefaultValue = 0;
			DataColumn550.ColumnName = "IdChar";
			DataColumn550.DataType = typeof(int);
			DataColumn550.DefaultValue = 0;
			DataColumn571.ColumnName = "Color";
			DataColumn571.DataType = typeof(object);
			DataTable34.Columns.AddRange(new DataColumn[11]
			{
				DataColumn394, DataColumn395, DataColumn396, DataColumn397, DataColumn398, DataColumn399, DataColumn400, DataColumn450, DataColumn531, DataColumn551,
				DataColumn572
			});
			DataTable34.TableName = "Table_Battle15";
			DataColumn394.ColumnName = "Id";
			DataColumn394.DataType = typeof(int);
			DataColumn394.DefaultValue = 0;
			DataColumn395.ColumnName = "Name";
			DataColumn395.DefaultValue = "";
			DataColumn396.ColumnName = "Lv";
			DataColumn396.DataType = typeof(int);
			DataColumn396.DefaultValue = 0;
			DataColumn397.ColumnName = "Hp";
			DataColumn397.DataType = typeof(int);
			DataColumn397.DefaultValue = 0;
			DataColumn398.ColumnName = "MaxHp";
			DataColumn398.DataType = typeof(int);
			DataColumn398.DefaultValue = 0;
			DataColumn399.ColumnName = "Sp";
			DataColumn399.DataType = typeof(int);
			DataColumn399.DefaultValue = 0;
			DataColumn400.ColumnName = "MaxSp";
			DataColumn400.DataType = typeof(int);
			DataColumn400.DefaultValue = 0;
			DataColumn450.ColumnName = "TT";
			DataColumn450.DefaultValue = "";
			DataColumn531.ColumnName = "Type";
			DataColumn531.DataType = typeof(int);
			DataColumn531.DefaultValue = 0;
			DataColumn551.ColumnName = "IdChar";
			DataColumn551.DataType = typeof(int);
			DataColumn551.DefaultValue = 0;
			DataColumn572.ColumnName = "Color";
			DataColumn572.DataType = typeof(object);
			DataTable35.Columns.AddRange(new DataColumn[11]
			{
				DataColumn401, DataColumn402, DataColumn403, DataColumn404, DataColumn405, DataColumn406, DataColumn407, DataColumn451, DataColumn532, DataColumn552,
				DataColumn573
			});
			DataTable35.TableName = "Table_Battle16";
			DataColumn401.ColumnName = "Id";
			DataColumn401.DataType = typeof(int);
			DataColumn401.DefaultValue = 0;
			DataColumn402.ColumnName = "Name";
			DataColumn402.DefaultValue = "";
			DataColumn403.ColumnName = "Lv";
			DataColumn403.DataType = typeof(int);
			DataColumn403.DefaultValue = 0;
			DataColumn404.ColumnName = "Hp";
			DataColumn404.DataType = typeof(int);
			DataColumn404.DefaultValue = 0;
			DataColumn405.ColumnName = "MaxHp";
			DataColumn405.DataType = typeof(int);
			DataColumn405.DefaultValue = 0;
			DataColumn406.ColumnName = "Sp";
			DataColumn406.DataType = typeof(int);
			DataColumn406.DefaultValue = 0;
			DataColumn407.ColumnName = "MaxSp";
			DataColumn407.DataType = typeof(int);
			DataColumn407.DefaultValue = 0;
			DataColumn451.ColumnName = "TT";
			DataColumn451.DefaultValue = "";
			DataColumn532.ColumnName = "Type";
			DataColumn532.DataType = typeof(int);
			DataColumn532.DefaultValue = 0;
			DataColumn552.ColumnName = "IdChar";
			DataColumn552.DataType = typeof(int);
			DataColumn552.DefaultValue = 0;
			DataColumn573.ColumnName = "Color";
			DataColumn573.DataType = typeof(object);
			DataTable36.Columns.AddRange(new DataColumn[11]
			{
				DataColumn408, DataColumn409, DataColumn410, DataColumn411, DataColumn412, DataColumn413, DataColumn414, DataColumn452, DataColumn533, DataColumn553,
				DataColumn574
			});
			DataTable36.TableName = "Table_Battle17";
			DataColumn408.ColumnName = "Id";
			DataColumn408.DataType = typeof(int);
			DataColumn408.DefaultValue = 0;
			DataColumn409.ColumnName = "Name";
			DataColumn409.DefaultValue = "";
			DataColumn410.ColumnName = "Lv";
			DataColumn410.DataType = typeof(int);
			DataColumn410.DefaultValue = 0;
			DataColumn411.ColumnName = "Hp";
			DataColumn411.DataType = typeof(int);
			DataColumn411.DefaultValue = 0;
			DataColumn412.ColumnName = "MaxHp";
			DataColumn412.DataType = typeof(int);
			DataColumn412.DefaultValue = 0;
			DataColumn413.ColumnName = "Sp";
			DataColumn413.DataType = typeof(int);
			DataColumn413.DefaultValue = 0;
			DataColumn414.ColumnName = "MaxSp";
			DataColumn414.DataType = typeof(int);
			DataColumn414.DefaultValue = 0;
			DataColumn452.ColumnName = "TT";
			DataColumn452.DefaultValue = "";
			DataColumn533.ColumnName = "Type";
			DataColumn533.DataType = typeof(int);
			DataColumn533.DefaultValue = 0;
			DataColumn553.ColumnName = "IdChar";
			DataColumn553.DataType = typeof(int);
			DataColumn553.DefaultValue = 0;
			DataColumn574.ColumnName = "Color";
			DataColumn574.DataType = typeof(object);
			DataTable37.Columns.AddRange(new DataColumn[11]
			{
				DataColumn415, DataColumn416, DataColumn417, DataColumn418, DataColumn419, DataColumn420, DataColumn421, DataColumn453, DataColumn534, DataColumn554,
				DataColumn575
			});
			DataTable37.TableName = "Table_Battle18";
			DataColumn415.ColumnName = "Id";
			DataColumn415.DataType = typeof(int);
			DataColumn415.DefaultValue = 0;
			DataColumn416.ColumnName = "Name";
			DataColumn416.DefaultValue = "";
			DataColumn417.ColumnName = "Lv";
			DataColumn417.DataType = typeof(int);
			DataColumn417.DefaultValue = 0;
			DataColumn418.ColumnName = "Hp";
			DataColumn418.DataType = typeof(int);
			DataColumn418.DefaultValue = 0;
			DataColumn419.ColumnName = "MaxHp";
			DataColumn419.DataType = typeof(int);
			DataColumn419.DefaultValue = 0;
			DataColumn420.ColumnName = "Sp";
			DataColumn420.DataType = typeof(int);
			DataColumn420.DefaultValue = 0;
			DataColumn421.ColumnName = "MaxSp";
			DataColumn421.DataType = typeof(int);
			DataColumn421.DefaultValue = 0;
			DataColumn453.ColumnName = "TT";
			DataColumn453.DefaultValue = "";
			DataColumn534.ColumnName = "Type";
			DataColumn534.DataType = typeof(int);
			DataColumn534.DefaultValue = 0;
			DataColumn554.ColumnName = "IdChar";
			DataColumn554.DataType = typeof(int);
			DataColumn554.DefaultValue = 0;
			DataColumn575.ColumnName = "Color";
			DataColumn575.DataType = typeof(object);
			DataTable38.Columns.AddRange(new DataColumn[11]
			{
				DataColumn422, DataColumn423, DataColumn424, DataColumn425, DataColumn426, DataColumn427, DataColumn428, DataColumn454, DataColumn535, DataColumn555,
				DataColumn576
			});
			DataTable38.TableName = "Table_Battle19";
			DataColumn422.ColumnName = "Id";
			DataColumn422.DataType = typeof(int);
			DataColumn422.DefaultValue = 0;
			DataColumn423.ColumnName = "Name";
			DataColumn423.DefaultValue = "";
			DataColumn424.ColumnName = "Lv";
			DataColumn424.DataType = typeof(int);
			DataColumn424.DefaultValue = 0;
			DataColumn425.ColumnName = "Hp";
			DataColumn425.DataType = typeof(int);
			DataColumn425.DefaultValue = 0;
			DataColumn426.ColumnName = "MaxHp";
			DataColumn426.DataType = typeof(int);
			DataColumn426.DefaultValue = 0;
			DataColumn427.ColumnName = "Sp";
			DataColumn427.DataType = typeof(int);
			DataColumn427.DefaultValue = 0;
			DataColumn428.ColumnName = "MaxSp";
			DataColumn428.DataType = typeof(int);
			DataColumn428.DefaultValue = 0;
			DataColumn454.ColumnName = "TT";
			DataColumn454.DefaultValue = "";
			DataColumn535.ColumnName = "Type";
			DataColumn535.DataType = typeof(int);
			DataColumn535.DefaultValue = 0;
			DataColumn555.ColumnName = "IdChar";
			DataColumn555.DataType = typeof(int);
			DataColumn555.DefaultValue = 0;
			DataColumn576.ColumnName = "Color";
			DataColumn576.DataType = typeof(object);
			DataTable39.Columns.AddRange(new DataColumn[11]
			{
				DataColumn429, DataColumn430, DataColumn431, DataColumn432, DataColumn433, DataColumn434, DataColumn435, DataColumn455, DataColumn536, DataColumn556,
				DataColumn577
			});
			DataTable39.TableName = "Table_Battle20";
			DataColumn429.ColumnName = "Id";
			DataColumn429.DataType = typeof(int);
			DataColumn429.DefaultValue = 0;
			DataColumn430.ColumnName = "Name";
			DataColumn430.DefaultValue = "";
			DataColumn431.ColumnName = "Lv";
			DataColumn431.DataType = typeof(int);
			DataColumn431.DefaultValue = 0;
			DataColumn432.ColumnName = "Hp";
			DataColumn432.DataType = typeof(int);
			DataColumn432.DefaultValue = 0;
			DataColumn433.ColumnName = "MaxHp";
			DataColumn433.DataType = typeof(int);
			DataColumn433.DefaultValue = 0;
			DataColumn434.ColumnName = "Sp";
			DataColumn434.DataType = typeof(int);
			DataColumn434.DefaultValue = 0;
			DataColumn435.ColumnName = "MaxSp";
			DataColumn435.DataType = typeof(int);
			DataColumn435.DefaultValue = 0;
			DataColumn455.ColumnName = "TT";
			DataColumn455.DefaultValue = "";
			DataColumn536.ColumnName = "Type";
			DataColumn536.DataType = typeof(int);
			DataColumn536.DefaultValue = 0;
			DataColumn556.ColumnName = "IdChar";
			DataColumn556.DataType = typeof(int);
			DataColumn556.DefaultValue = 0;
			DataColumn577.ColumnName = "Color";
			DataColumn577.DataType = typeof(object);
			DataTable20.Columns.AddRange(new DataColumn[5] { DataColumn505, DataColumn506, DataColumn509, DataColumn507, DataColumn508 });
			DataTable20.TableName = "Table_ItemOnMap";
			DataColumn505.ColumnName = "Gold";
			DataColumn505.DefaultValue = "";
			DataColumn506.ColumnName = "Id";
			DataColumn506.DefaultValue = "";
			DataColumn509.ColumnName = "ItemName";
			DataColumn509.DefaultValue = "";
			DataColumn507.ColumnName = "MapX";
			DataColumn507.DefaultValue = "";
			DataColumn508.ColumnName = "MapY";
			DataColumn508.DefaultValue = "";
			DataTable40.Columns.AddRange(new DataColumn[2] { DataColumn510, DataColumn511 });
			DataTable40.TableName = "Table_PickUp";
			DataColumn510.AllowDBNull = false;
			DataColumn510.ColumnName = "Id";
			DataColumn510.DataType = typeof(int);
			DataColumn510.DefaultValue = 0;
			DataColumn511.ColumnName = "Name";
			DataColumn511.DefaultValue = "";
			DataTable41.Columns.AddRange(new DataColumn[2] { DataColumn512, DataColumn513 });
			DataTable41.TableName = "Table_ListSell";
			DataColumn512.AllowDBNull = false;
			DataColumn512.ColumnName = "Id";
			DataColumn512.DataType = typeof(int);
			DataColumn512.DefaultValue = 0;
			DataColumn513.Caption = "Name";
			DataColumn513.ColumnName = "Name";
			DataColumn513.DefaultValue = "";
			ContextMenuStrip_saveas.ImageScalingSize = new Size(20, 20);
			ContextMenuStrip_saveas.Name = "ContextMenuStrip_Warp";
			ContextMenuStrip_saveas.OwnerItem = ToolStripSplitButton_save;
			ContextMenuStrip_saveas.RenderMode = ToolStripRenderMode.System;
			ContextMenuStrip_saveas.Size = new Size(61, 4);
			ToolStripSplitButton_save.DisplayStyle = ToolStripItemDisplayStyle.Image;
			ToolStripSplitButton_save.DropDown = ContextMenuStrip_saveas;
			ToolStripSplitButton_save.Image = (Image)componentResourceManager.GetObject("ToolStripSplitButton_save.Image");
			ToolStripSplitButton_save.ImageTransparentColor = Color.Magenta;
			ToolStripSplitButton_save.Name = "ToolStripSplitButton_save";
			ToolStripSplitButton_save.Overflow = ToolStripItemOverflow.Never;
			ToolStripSplitButton_save.RightToLeft = RightToLeft.No;
			ToolStripSplitButton_save.Size = new Size(40, 18);
			ToolStripSplitButton_save.Text = "Lưu thiết lập mặc định";
			ContextMenuStrip_ToTuideo.ImageScalingSize = new Size(20, 20);
			ContextMenuStrip_ToTuideo.Items.AddRange(new ToolStripItem[6] { ToolStripMenuItem_ToTuiDo, ToolStripSeparator2, ToolStripMenuItem_TuideoAddtoDrop, ToolStripMenuItem_TuideoAddtoContribute, ToolStripMenuItem_TuideoAddtoSend, ToolStripMenuItem_TuideoAddtoSell });
			ContextMenuStrip_ToTuideo.Name = "ContextMenuStrip_Warp";
			ContextMenuStrip_ToTuideo.RenderMode = ToolStripRenderMode.System;
			ContextMenuStrip_ToTuideo.Size = new Size(229, 120);
			ToolStripMenuItem_ToTuiDo.Name = "ToolStripMenuItem_ToTuiDo";
			ToolStripMenuItem_ToTuiDo.Size = new Size(228, 22);
			ToolStripMenuItem_ToTuiDo.Text = "Lấy xuống túi đồ";
			ToolStripSeparator2.Name = "ToolStripSeparator2";
			ToolStripSeparator2.Size = new Size(225, 6);
			ToolStripMenuItem_TuideoAddtoDrop.Name = "ToolStripMenuItem_TuideoAddtoDrop";
			ToolStripMenuItem_TuideoAddtoDrop.Size = new Size(228, 22);
			ToolStripMenuItem_TuideoAddtoDrop.Text = "Thêm vào tự động vứt đồ";
			ToolStripMenuItem_TuideoAddtoContribute.Name = "ToolStripMenuItem_TuideoAddtoContribute";
			ToolStripMenuItem_TuideoAddtoContribute.Size = new Size(228, 22);
			ToolStripMenuItem_TuideoAddtoContribute.Text = "Thêm vào Tự động đóng góp";
			ToolStripMenuItem_TuideoAddtoSend.Name = "ToolStripMenuItem_TuideoAddtoSend";
			ToolStripMenuItem_TuideoAddtoSend.Size = new Size(228, 22);
			ToolStripMenuItem_TuideoAddtoSend.Text = "Thêm vào tự động gửi đồ";
			ToolStripMenuItem_TuideoAddtoSell.Name = "ToolStripMenuItem_TuideoAddtoSell";
			ToolStripMenuItem_TuideoAddtoSell.Size = new Size(228, 22);
			ToolStripMenuItem_TuideoAddtoSell.Text = "Thêm vào tự động bán đồ";
			ContextMenuStrip_ToTuido.ImageScalingSize = new Size(20, 20);
			ContextMenuStrip_ToTuido.Items.AddRange(new ToolStripItem[18]
			{
				ToolStripMenuItem_ToTuiDeo, ToolStripSeparator1, ToolStripMenuItem_CharUse, ToolStripMenuItem_Petuse, ToolStripSeparator3, ToolStripMenuItem_dropitem, ToolStripMenuItem_ContributeItem, ToolStripSeparator4, ToolStripMenuItem_SendBDY, ToolStripTextBox_SendBDY_Id,
				ToolStripSeparator5, ToolStripMenuItem_TuidoAddtoDrop, ToolStripMenuItem_TuidoAddtoContribute, ToolStripMenuItem_TuidoAddtoSend, ToolStripMenuItem_TuidoAddtoSell, ToolStripMenuItem_AddToShop, ToolStripSeparator6, ToolStripMenuItem_Tuido_Sort
			});
			ContextMenuStrip_ToTuido.Name = "ContextMenuStrip_Warp";
			ContextMenuStrip_ToTuido.RenderMode = ToolStripRenderMode.System;
			ContextMenuStrip_ToTuido.Size = new Size(240, 323);
			ToolStripMenuItem_ToTuiDeo.Name = "ToolStripMenuItem_ToTuiDeo";
			ToolStripMenuItem_ToTuiDeo.Size = new Size(239, 22);
			ToolStripMenuItem_ToTuiDeo.Text = "Cất vào Túi đeo";
			ToolStripSeparator1.Name = "ToolStripSeparator1";
			ToolStripSeparator1.Size = new Size(236, 6);
			ToolStripMenuItem_CharUse.Name = "ToolStripMenuItem_CharUse";
			ToolStripMenuItem_CharUse.Size = new Size(239, 22);
			ToolStripMenuItem_CharUse.Text = "Sử dụng";
			ToolStripMenuItem_Petuse.Name = "ToolStripMenuItem_Petuse";
			ToolStripMenuItem_Petuse.Size = new Size(239, 22);
			ToolStripMenuItem_Petuse.Text = "Võ tướng bên phải sử dụng";
			ToolStripSeparator3.Name = "ToolStripSeparator3";
			ToolStripSeparator3.Size = new Size(236, 6);
			ToolStripMenuItem_dropitem.DropDownItems.AddRange(new ToolStripItem[1] { DongYVutDoToolStripMenuItem });
			ToolStripMenuItem_dropitem.Name = "ToolStripMenuItem_dropitem";
			ToolStripMenuItem_dropitem.Size = new Size(239, 22);
			ToolStripMenuItem_dropitem.Text = "Vứt bỏ";
			DongYVutDoToolStripMenuItem.Name = "DongYVutDoToolStripMenuItem";
			DongYVutDoToolStripMenuItem.Size = new Size(149, 22);
			DongYVutDoToolStripMenuItem.Text = "Đồng ý vứt bỏ";
			ToolStripMenuItem_ContributeItem.DropDownItems.AddRange(new ToolStripItem[1] { DongYDongGopToolStripMenuItem });
			ToolStripMenuItem_ContributeItem.Name = "ToolStripMenuItem_ContributeItem";
			ToolStripMenuItem_ContributeItem.Size = new Size(239, 22);
			ToolStripMenuItem_ContributeItem.Text = "Đóng góp";
			DongYDongGopToolStripMenuItem.Name = "DongYDongGopToolStripMenuItem";
			DongYDongGopToolStripMenuItem.Size = new Size(167, 22);
			DongYDongGopToolStripMenuItem.Text = "Đồng ý đóng góp";
			ToolStripSeparator4.Name = "ToolStripSeparator4";
			ToolStripSeparator4.Size = new Size(236, 6);
			ToolStripMenuItem_SendBDY.Name = "ToolStripMenuItem_SendBDY";
			ToolStripMenuItem_SendBDY.Size = new Size(239, 22);
			ToolStripMenuItem_SendBDY.Text = "Gửi Ba đậu yêu cho id bên dưới";
			ToolStripTextBox_SendBDY_Id.Font = new Font("Segoe UI", 9f);
			ToolStripTextBox_SendBDY_Id.Name = "ToolStripTextBox_SendBDY_Id";
			ToolStripTextBox_SendBDY_Id.Size = new Size(150, 23);
			ToolStripTextBox_SendBDY_Id.Text = "0";
			ToolStripSeparator5.Name = "ToolStripSeparator5";
			ToolStripSeparator5.Size = new Size(236, 6);
			ToolStripMenuItem_TuidoAddtoDrop.Name = "ToolStripMenuItem_TuidoAddtoDrop";
			ToolStripMenuItem_TuidoAddtoDrop.Size = new Size(239, 22);
			ToolStripMenuItem_TuidoAddtoDrop.Text = "Thêm vào tự động vứt đồ";
			ToolStripMenuItem_TuidoAddtoContribute.Name = "ToolStripMenuItem_TuidoAddtoContribute";
			ToolStripMenuItem_TuidoAddtoContribute.Size = new Size(239, 22);
			ToolStripMenuItem_TuidoAddtoContribute.Text = "Thêm vào Tự động đóng góp";
			ToolStripMenuItem_TuidoAddtoSend.Name = "ToolStripMenuItem_TuidoAddtoSend";
			ToolStripMenuItem_TuidoAddtoSend.Size = new Size(239, 22);
			ToolStripMenuItem_TuidoAddtoSend.Text = "Thêm vào tự động gửi đồ";
			ToolStripMenuItem_TuidoAddtoSell.Name = "ToolStripMenuItem_TuidoAddtoSell";
			ToolStripMenuItem_TuidoAddtoSell.Size = new Size(239, 22);
			ToolStripMenuItem_TuidoAddtoSell.Text = "Thêm vào tự động bán đồ";
			ToolStripMenuItem_AddToShop.Name = "ToolStripMenuItem_AddToShop";
			ToolStripMenuItem_AddToShop.Size = new Size(239, 22);
			ToolStripMenuItem_AddToShop.Text = "Thêm vào bày bán";
			ToolStripSeparator6.Name = "ToolStripSeparator6";
			ToolStripSeparator6.Size = new Size(236, 6);
			ToolStripMenuItem_Tuido_Sort.Name = "ToolStripMenuItem_Tuido_Sort";
			ToolStripMenuItem_Tuido_Sort.Size = new Size(239, 22);
			ToolStripMenuItem_Tuido_Sort.Text = "Xắp xếp hòm đồ";
			ContextMenuStrip_Warp.ImageScalingSize = new Size(20, 20);
			ContextMenuStrip_Warp.Items.AddRange(new ToolStripItem[1] { ToolStripMenuItem_Warp });
			ContextMenuStrip_Warp.Name = "ContextMenuStrip_Warp";
			ContextMenuStrip_Warp.RenderMode = ToolStripRenderMode.System;
			ContextMenuStrip_Warp.Size = new Size(141, 26);
			ToolStripMenuItem_Warp.Name = "ToolStripMenuItem_Warp";
			ToolStripMenuItem_Warp.Size = new Size(140, 22);
			ToolStripMenuItem_Warp.Text = "Dịch chuyển";
			Timer_100.Enabled = true;
			Timer_autoquest.Enabled = true;
			Timer_autoquest.Interval = 1000;
			Timer_delay.Enabled = true;
			Timer_delay.Interval = 1000;
			ToolTip_info.AutoPopDelay = 5000;
			ToolTip_info.BackColor = SystemColors.GradientActiveCaption;
			ToolTip_info.InitialDelay = 500;
			ToolTip_info.ReshowDelay = 100;
			TextBox_ClickMOD.Location = new Point(143, 291);
			TextBox_ClickMOD.Name = "TextBox_ClickMOD";
			TextBox_ClickMOD.Size = new Size(102, 19);
			TextBox_ClickMOD.TabIndex = 57;
			ToolTip_info.SetToolTip(TextBox_ClickMOD, "Mỗi id cách nhau bởi dấu \";\" và kết thúc là dấu \";\" ví dụ : 1;2;3;");
			ListView_Quest.Activation = ItemActivation.OneClick;
			ListView_Quest.Columns.AddRange(new ColumnHeader[1] { ColumnHeader19 });
			ListView_Quest.FullRowSelect = true;
			ListView_Quest.GridLines = true;
			ListView_Quest.HideSelection = false;
			ListView_Quest.Location = new Point(254, 29);
			ListView_Quest.MultiSelect = false;
			ListView_Quest.Name = "ListView_Quest";
			ListView_Quest.Size = new Size(400, 296);
			ListView_Quest.TabIndex = 120;
			ToolTip_info.SetToolTip(ListView_Quest, "Nháy đúp chuột trái để xoá");
			ListView_Quest.UseCompatibleStateImageBehavior = false;
			ListView_Quest.View = View.Details;
			ColumnHeader19.Text = "Tên";
			ColumnHeader19.Width = 178;
			ListView_AutoDrop.Activation = ItemActivation.OneClick;
			ListView_AutoDrop.Columns.AddRange(new ColumnHeader[2] { ColumnHeader_Id, ColumnHeader_Name });
			ListView_AutoDrop.FullRowSelect = true;
			ListView_AutoDrop.GridLines = true;
			ListView_AutoDrop.HideSelection = false;
			ListView_AutoDrop.Location = new Point(200, 17);
			ListView_AutoDrop.MultiSelect = false;
			ListView_AutoDrop.Name = "ListView_AutoDrop";
			ListView_AutoDrop.Size = new Size(197, 261);
			ListView_AutoDrop.TabIndex = 119;
			ToolTip_info.SetToolTip(ListView_AutoDrop, "Nháy đúp chuột trái để xoá");
			ListView_AutoDrop.UseCompatibleStateImageBehavior = false;
			ListView_AutoDrop.View = View.Details;
			ColumnHeader_Id.Text = "Id";
			ColumnHeader_Id.Width = 50;
			ColumnHeader_Name.Text = "Tên";
			ColumnHeader_Name.Width = 120;
			ListView_AutoContribute.Activation = ItemActivation.OneClick;
			ListView_AutoContribute.Columns.AddRange(new ColumnHeader[2] { ColumnHeader1, ColumnHeader2 });
			ListView_AutoContribute.FullRowSelect = true;
			ListView_AutoContribute.GridLines = true;
			ListView_AutoContribute.HideSelection = false;
			ListView_AutoContribute.Location = new Point(200, 17);
			ListView_AutoContribute.MultiSelect = false;
			ListView_AutoContribute.Name = "ListView_AutoContribute";
			ListView_AutoContribute.Size = new Size(197, 261);
			ListView_AutoContribute.TabIndex = 133;
			ToolTip_info.SetToolTip(ListView_AutoContribute, "Nháy đúp chuột trái để xoá");
			ListView_AutoContribute.UseCompatibleStateImageBehavior = false;
			ListView_AutoContribute.View = View.Details;
			ColumnHeader1.Text = "Id";
			ColumnHeader1.Width = 50;
			ColumnHeader2.Text = "Tên";
			ColumnHeader2.Width = 120;
			ListView_AutoSend.Activation = ItemActivation.OneClick;
			ListView_AutoSend.Columns.AddRange(new ColumnHeader[2] { ColumnHeader3, ColumnHeader4 });
			ListView_AutoSend.FullRowSelect = true;
			ListView_AutoSend.GridLines = true;
			ListView_AutoSend.HideSelection = false;
			ListView_AutoSend.Location = new Point(200, 17);
			ListView_AutoSend.MultiSelect = false;
			ListView_AutoSend.Name = "ListView_AutoSend";
			ListView_AutoSend.Size = new Size(197, 261);
			ListView_AutoSend.TabIndex = 137;
			ToolTip_info.SetToolTip(ListView_AutoSend, "Nháy đúp chuột trái để xoá");
			ListView_AutoSend.UseCompatibleStateImageBehavior = false;
			ListView_AutoSend.View = View.Details;
			ColumnHeader3.Text = "Id";
			ColumnHeader3.Width = 50;
			ColumnHeader4.Text = "Tên";
			ColumnHeader4.Width = 120;
			ListView_AutoSell.Activation = ItemActivation.OneClick;
			ListView_AutoSell.Columns.AddRange(new ColumnHeader[2] { ColumnHeader10, ColumnHeader11 });
			ListView_AutoSell.FullRowSelect = true;
			ListView_AutoSell.GridLines = true;
			ListView_AutoSell.HideSelection = false;
			ListView_AutoSell.Location = new Point(200, 17);
			ListView_AutoSell.MultiSelect = false;
			ListView_AutoSell.Name = "ListView_AutoSell";
			ListView_AutoSell.Size = new Size(197, 261);
			ListView_AutoSell.TabIndex = 134;
			ToolTip_info.SetToolTip(ListView_AutoSell, "Nháy đúp chuột trái để xoá");
			ListView_AutoSell.UseCompatibleStateImageBehavior = false;
			ListView_AutoSell.View = View.Details;
			ColumnHeader10.Text = "Id";
			ColumnHeader10.Width = 50;
			ColumnHeader11.Text = "Tên";
			ColumnHeader11.Width = 120;
			DataGridView_Pickup.AllowUserToAddRows = false;
			DataGridView_Pickup.AllowUserToDeleteRows = false;
			DataGridView_Pickup.AllowUserToResizeColumns = false;
			DataGridView_Pickup.AllowUserToResizeRows = false;
			DataGridView_Pickup.AutoGenerateColumns = false;
			DataGridView_Pickup.BackgroundColor = SystemColors.ControlLightLight;
			DataGridView_Pickup.BorderStyle = BorderStyle.Fixed3D;
			DataGridView_Pickup.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			DataGridView_Pickup.Columns.AddRange(DataGridViewTextBoxColumn14, DataGridViewTextBoxColumn15);
			DataGridView_Pickup.DataMember = "Table_PickUp";
			DataGridView_Pickup.DataSource = DataSet1;
			DataGridView_Pickup.Dock = DockStyle.Bottom;
			DataGridView_Pickup.Location = new Point(3, 168);
			DataGridView_Pickup.Margin = new Padding(2);
			DataGridView_Pickup.MultiSelect = false;
			DataGridView_Pickup.Name = "DataGridView_Pickup";
			DataGridView_Pickup.ReadOnly = true;
			DataGridView_Pickup.RowHeadersVisible = false;
			DataGridView_Pickup.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			DataGridView_Pickup.RowTemplate.Height = 17;
			DataGridView_Pickup.RowTemplate.Resizable = DataGridViewTriState.False;
			DataGridView_Pickup.ScrollBars = ScrollBars.None;
			DataGridView_Pickup.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			DataGridView_Pickup.Size = new Size(367, 402);
			DataGridView_Pickup.TabIndex = 110;
			ToolTip_info.SetToolTip(DataGridView_Pickup, "Nháy đúp chuột trái để xoá");
			DataGridView_Pickup.Visible = false;
			DataGridViewTextBoxColumn14.DataPropertyName = "Id";
			DataGridViewTextBoxColumn14.HeaderText = "Id";
			DataGridViewTextBoxColumn14.MinimumWidth = 40;
			DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14";
			DataGridViewTextBoxColumn14.ReadOnly = true;
			DataGridViewTextBoxColumn14.SortMode = DataGridViewColumnSortMode.NotSortable;
			DataGridViewTextBoxColumn14.Width = 40;
			DataGridViewTextBoxColumn15.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			DataGridViewTextBoxColumn15.DataPropertyName = "Name";
			DataGridViewTextBoxColumn15.HeaderText = "Tên";
			DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15";
			DataGridViewTextBoxColumn15.ReadOnly = true;
			DataGridViewTextBoxColumn15.SortMode = DataGridViewColumnSortMode.NotSortable;
			ListView_Shop.Activation = ItemActivation.OneClick;
			ListView_Shop.Columns.AddRange(new ColumnHeader[3] { ColumnHeader15, ColumnHeader16, ColumnHeader17 });
			ListView_Shop.FullRowSelect = true;
			ListView_Shop.GridLines = true;
			ListView_Shop.HideSelection = false;
			ListView_Shop.Location = new Point(97, 46);
			ListView_Shop.MultiSelect = false;
			ListView_Shop.Name = "ListView_Shop";
			ListView_Shop.Size = new Size(424, 198);
			ListView_Shop.TabIndex = 120;
			ToolTip_info.SetToolTip(ListView_Shop, "Nháy đúp chuột trái để xoá");
			ListView_Shop.UseCompatibleStateImageBehavior = false;
			ListView_Shop.View = View.Details;
			ColumnHeader15.Text = "Id";
			ColumnHeader16.Text = "Tên";
			ColumnHeader16.Width = 200;
			ColumnHeader17.Text = "Giá cho 1 món";
			ColumnHeader17.Width = 120;
			PictureBox1.Location = new Point(3, 3);
			PictureBox1.Name = "PictureBox1";
			PictureBox1.Size = new Size(430, 475);
			PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			PictureBox1.TabIndex = 0;
			PictureBox1.TabStop = false;
			ToolTip_info.SetToolTip(PictureBox1, "test");
			OpenFileDialog_setting.FileName = "default";
			OpenFileDialog_setting.Filter = "Setting files (*.lx)|*.lx";
			OpenFileDialog_setting.RestoreDirectory = true;
			SaveFileDialog_setting.Filter = "Setting files (*.Ini)|*.Ini";
			SaveFileDialog_setting.RestoreDirectory = true;
			Timer_QC.Enabled = true;
			ImageList1.ColorDepth = ColorDepth.Depth16Bit;
			ImageList1.ImageSize = new Size(32, 32);
			ImageList1.TransparentColor = Color.Transparent;
			Vs2010TabControl_Main.Controls.Add(TabPage_Main);
			Vs2010TabControl_Main.Controls.Add(TabPage_Attack);
			Vs2010TabControl_Main.Controls.Add(TabPage_Quest);
			Vs2010TabControl_Main.Controls.Add(TabPage_Warp);
			Vs2010TabControl_Main.Controls.Add(TabPage_Players);
			Vs2010TabControl_Main.Controls.Add(TabPage_Setting);
			Vs2010TabControl_Main.Controls.Add(TabPage_Shop);
			Vs2010TabControl_Main.Controls.Add(TabPage_Map);
			Vs2010TabControl_Main.Dock = DockStyle.Left;
			Vs2010TabControl_Main.DrawMode = TabDrawMode.OwnerDrawFixed;
			Vs2010TabControl_Main.HotTrack = true;
			Vs2010TabControl_Main.ItemSize = new Size(0, 26);
			Vs2010TabControl_Main.Location = new Point(0, 0);
			Vs2010TabControl_Main.Name = "Vs2010TabControl_Main";
			vs2010TabControlRenderer.ColorTable = colorTable;
			Vs2010TabControl_Main.Renderer = vs2010TabControlRenderer;
			Vs2010TabControl_Main.SelectedIndex = 0;
			Vs2010TabControl_Main.Size = new Size(671, 647);
			Vs2010TabControl_Main.TabIndex = 35;
			TabPage_Main.BackgroundImage = Resources.background;
			TabPage_Main.BackgroundImageLayout = ImageLayout.None;
			TabPage_Main.Controls.Add(PictureBox_mini);
			TabPage_Main.Controls.Add(PictureBox_char_add_agi);
			TabPage_Main.Controls.Add(PictureBox_char_add_spx);
			TabPage_Main.Controls.Add(PictureBox_char_add_hpx);
			TabPage_Main.Controls.Add(PictureBox_char_add_def);
			TabPage_Main.Controls.Add(PictureBox_char_add_atk);
			TabPage_Main.Controls.Add(PictureBox_char_add_int);
			TabPage_Main.Controls.Add(PictureBox_pet_next);
			TabPage_Main.Controls.Add(PictureBox_Pet_back);
			TabPage_Main.Controls.Add(Label_Pet_fai);
			TabPage_Main.Controls.Add(Label_Pet_agi);
			TabPage_Main.Controls.Add(Label_Pet_spx);
			TabPage_Main.Controls.Add(Label_Pet_hpx);
			TabPage_Main.Controls.Add(Label_Petname);
			TabPage_Main.Controls.Add(Label_Pet_def);
			TabPage_Main.Controls.Add(Label_Pet_atk);
			TabPage_Main.Controls.Add(Label_Pet_int);
			TabPage_Main.Controls.Add(Label94);
			TabPage_Main.Controls.Add(Label_Char_agi);
			TabPage_Main.Controls.Add(Label_Char_spx);
			TabPage_Main.Controls.Add(Label_Char_hpx);
			TabPage_Main.Controls.Add(Label_Char_def);
			TabPage_Main.Controls.Add(Label_Char_atk);
			TabPage_Main.Controls.Add(Label_Char_int);
			TabPage_Main.Controls.Add(PictureBox_Pet_XuatChien);
			TabPage_Main.Controls.Add(PictureBox_Pet_Thuoctinh);
			TabPage_Main.Controls.Add(PictureBox_Char_Thuoctinh);
			TabPage_Main.Controls.Add(PictureBox_Pet5);
			TabPage_Main.Controls.Add(PictureBox_Pet6);
			TabPage_Main.Controls.Add(PictureBox_Pet3);
			TabPage_Main.Controls.Add(PictureBox_Pet2);
			TabPage_Main.Controls.Add(PictureBox_Pet4);
			TabPage_Main.Controls.Add(PictureBox_Pet1);
			TabPage_Main.Controls.Add(PictureBox_char5);
			TabPage_Main.Controls.Add(PictureBox_char6);
			TabPage_Main.Controls.Add(PictureBox_char3);
			TabPage_Main.Controls.Add(PictureBox_char2);
			TabPage_Main.Controls.Add(PictureBox_char4);
			TabPage_Main.Controls.Add(PictureBox_char1);
			TabPage_Main.Controls.Add(Panel10);
			TabPage_Main.Controls.Add(Panel9);
			TabPage_Main.Controls.Add(Label_Mini);
			TabPage_Main.Controls.Add(Label83);
			TabPage_Main.Controls.Add(Lb_tuideo25);
			TabPage_Main.Controls.Add(Panel_Login);
			TabPage_Main.Controls.Add(Panel6);
			TabPage_Main.Controls.Add(Lb_tuideo24);
			TabPage_Main.Controls.Add(Label_Lv);
			TabPage_Main.Controls.Add(Lb_tuideo23);
			TabPage_Main.Controls.Add(GroupBox_Bot);
			TabPage_Main.Controls.Add(GroupBox_team);
			TabPage_Main.Controls.Add(Label_CharName);
			TabPage_Main.Controls.Add(Lb_tuideo22);
			TabPage_Main.Controls.Add(Label_petlv);
			TabPage_Main.Controls.Add(Lb_tuideo21);
			TabPage_Main.Controls.Add(Label_Lv_Plus);
			TabPage_Main.Controls.Add(Lb_tuideo20);
			TabPage_Main.Controls.Add(Label_Lv2);
			TabPage_Main.Controls.Add(Lb_tuideo19);
			TabPage_Main.Controls.Add(Label_PetExpMin);
			TabPage_Main.Controls.Add(Lb_tuideo18);
			TabPage_Main.Controls.Add(Label8);
			TabPage_Main.Controls.Add(Lb_tuideo17);
			TabPage_Main.Controls.Add(Lb_tuideo16);
			TabPage_Main.Controls.Add(ProgressBarEx_PetExp);
			TabPage_Main.Controls.Add(Lb_tuideo15);
			TabPage_Main.Controls.Add(Lb_tuideo14);
			TabPage_Main.Controls.Add(Lb_tuideo13);
			TabPage_Main.Controls.Add(Lb_tuideo12);
			TabPage_Main.Controls.Add(Label4);
			TabPage_Main.Controls.Add(Lb_tuideo11);
			TabPage_Main.Controls.Add(Lb_tuideo10);
			TabPage_Main.Controls.Add(Label_CharExpMin);
			TabPage_Main.Controls.Add(Lb_tuideo9);
			TabPage_Main.Controls.Add(ProgressBarEx_PetSp);
			TabPage_Main.Controls.Add(Lb_tuideo8);
			TabPage_Main.Controls.Add(Lb_tuideo7);
			TabPage_Main.Controls.Add(Lb_tuideo6);
			TabPage_Main.Controls.Add(Lb_tuideo5);
			TabPage_Main.Controls.Add(Label_gold);
			TabPage_Main.Controls.Add(Lb_tuideo4);
			TabPage_Main.Controls.Add(ProgressBarEx_PetHp);
			TabPage_Main.Controls.Add(Lb_tuideo3);
			TabPage_Main.Controls.Add(Lb_tuideo2);
			TabPage_Main.Controls.Add(ProgressBarEx_CharHp);
			TabPage_Main.Controls.Add(Lb_tuideo1);
			TabPage_Main.Controls.Add(Lb_tuido25);
			TabPage_Main.Controls.Add(Lb_tuido24);
			TabPage_Main.Controls.Add(Lb_tuido23);
			TabPage_Main.Controls.Add(Lb_tuido22);
			TabPage_Main.Controls.Add(Lb_tuido21);
			TabPage_Main.Controls.Add(Lb_tuido20);
			TabPage_Main.Controls.Add(Lb_tuido19);
			TabPage_Main.Controls.Add(Lb_tuido18);
			TabPage_Main.Controls.Add(ProgressBarEx_CharExp);
			TabPage_Main.Controls.Add(Lb_tuido17);
			TabPage_Main.Controls.Add(Lb_tuido16);
			TabPage_Main.Controls.Add(ProgressBarEx_CharSp);
			TabPage_Main.Controls.Add(Lb_tuido15);
			TabPage_Main.Controls.Add(Lb_tuido14);
			TabPage_Main.Controls.Add(Lb_tuido1);
			TabPage_Main.Controls.Add(Lb_tuido13);
			TabPage_Main.Controls.Add(Lb_tuido2);
			TabPage_Main.Controls.Add(Lb_tuido12);
			TabPage_Main.Controls.Add(Lb_tuido3);
			TabPage_Main.Controls.Add(Lb_tuido11);
			TabPage_Main.Controls.Add(Lb_tuido4);
			TabPage_Main.Controls.Add(Lb_tuido10);
			TabPage_Main.Controls.Add(Lb_tuido5);
			TabPage_Main.Controls.Add(Lb_tuido9);
			TabPage_Main.Controls.Add(Lb_tuido6);
			TabPage_Main.Controls.Add(Lb_tuido8);
			TabPage_Main.Controls.Add(Lb_tuido7);
			TabPage_Main.Controls.Add(PictureBox_Pet_photo);
			TabPage_Main.Controls.Add(PictureBox_avatar);
			TabPage_Main.Location = new Point(4, 30);
			TabPage_Main.Name = "TabPage_Main";
			TabPage_Main.Padding = new Padding(3);
			TabPage_Main.Size = new Size(663, 613);
			TabPage_Main.TabIndex = 0;
			TabPage_Main.Text = "Cơ bản";
			TabPage_Main.UseVisualStyleBackColor = true;
			PictureBox_mini.BackgroundImageLayout = ImageLayout.Center;
			PictureBox_mini.Location = new Point(162, 220);
			PictureBox_mini.Name = "PictureBox_mini";
			PictureBox_mini.Size = new Size(50, 50);
			PictureBox_mini.TabIndex = 190;
			PictureBox_mini.TabStop = false;
			PictureBox_char_add_agi.Location = new Point(197, 362);
			PictureBox_char_add_agi.Name = "PictureBox_char_add_agi";
			PictureBox_char_add_agi.Size = new Size(17, 12);
			PictureBox_char_add_agi.TabIndex = 189;
			PictureBox_char_add_agi.TabStop = false;
			PictureBox_char_add_agi.Visible = false;
			PictureBox_char_add_spx.Location = new Point(197, 349);
			PictureBox_char_add_spx.Name = "PictureBox_char_add_spx";
			PictureBox_char_add_spx.Size = new Size(17, 12);
			PictureBox_char_add_spx.TabIndex = 188;
			PictureBox_char_add_spx.TabStop = false;
			PictureBox_char_add_spx.Visible = false;
			PictureBox_char_add_hpx.Location = new Point(197, 336);
			PictureBox_char_add_hpx.Name = "PictureBox_char_add_hpx";
			PictureBox_char_add_hpx.Size = new Size(17, 12);
			PictureBox_char_add_hpx.TabIndex = 187;
			PictureBox_char_add_hpx.TabStop = false;
			PictureBox_char_add_hpx.Visible = false;
			PictureBox_char_add_def.Location = new Point(197, 323);
			PictureBox_char_add_def.Name = "PictureBox_char_add_def";
			PictureBox_char_add_def.Size = new Size(17, 12);
			PictureBox_char_add_def.TabIndex = 186;
			PictureBox_char_add_def.TabStop = false;
			PictureBox_char_add_def.Visible = false;
			PictureBox_char_add_atk.Location = new Point(197, 310);
			PictureBox_char_add_atk.Name = "PictureBox_char_add_atk";
			PictureBox_char_add_atk.Size = new Size(17, 12);
			PictureBox_char_add_atk.TabIndex = 185;
			PictureBox_char_add_atk.TabStop = false;
			PictureBox_char_add_atk.Visible = false;
			PictureBox_char_add_int.Location = new Point(197, 297);
			PictureBox_char_add_int.Name = "PictureBox_char_add_int";
			PictureBox_char_add_int.Size = new Size(17, 12);
			PictureBox_char_add_int.TabIndex = 184;
			PictureBox_char_add_int.TabStop = false;
			PictureBox_char_add_int.Visible = false;
			PictureBox_pet_next.Location = new Point(621, 183);
			PictureBox_pet_next.Name = "PictureBox_pet_next";
			PictureBox_pet_next.Size = new Size(27, 19);
			PictureBox_pet_next.TabIndex = 183;
			PictureBox_pet_next.TabStop = false;
			PictureBox_Pet_back.Location = new Point(448, 183);
			PictureBox_Pet_back.Name = "PictureBox_Pet_back";
			PictureBox_Pet_back.Size = new Size(27, 19);
			PictureBox_Pet_back.TabIndex = 182;
			PictureBox_Pet_back.TabStop = false;
			Label_Pet_fai.BackColor = Color.Transparent;
			Label_Pet_fai.Location = new Point(575, 374);
			Label_Pet_fai.Margin = new Padding(0, 1, 0, 1);
			Label_Pet_fai.Name = "Label_Pet_fai";
			Label_Pet_fai.Size = new Size(60, 14);
			Label_Pet_fai.TabIndex = 181;
			Label_Pet_fai.Text = "100";
			Label_Pet_agi.BackColor = Color.Transparent;
			Label_Pet_agi.Location = new Point(575, 361);
			Label_Pet_agi.Margin = new Padding(0, 1, 0, 1);
			Label_Pet_agi.Name = "Label_Pet_agi";
			Label_Pet_agi.Size = new Size(60, 14);
			Label_Pet_agi.TabIndex = 180;
			Label_Pet_agi.Text = "400";
			Label_Pet_spx.BackColor = Color.Transparent;
			Label_Pet_spx.Location = new Point(575, 348);
			Label_Pet_spx.Margin = new Padding(0, 1, 0, 1);
			Label_Pet_spx.Name = "Label_Pet_spx";
			Label_Pet_spx.Size = new Size(60, 14);
			Label_Pet_spx.TabIndex = 179;
			Label_Pet_spx.Text = "400";
			Label_Pet_hpx.BackColor = Color.Transparent;
			Label_Pet_hpx.Location = new Point(575, 335);
			Label_Pet_hpx.Margin = new Padding(0, 1, 0, 1);
			Label_Pet_hpx.Name = "Label_Pet_hpx";
			Label_Pet_hpx.Size = new Size(60, 14);
			Label_Pet_hpx.TabIndex = 178;
			Label_Pet_hpx.Text = "400";
			Label_Petname.BackColor = Color.Transparent;
			Label_Petname.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label_Petname.Location = new Point(538, 46);
			Label_Petname.Margin = new Padding(2);
			Label_Petname.Name = "Label_Petname";
			Label_Petname.Size = new Size(105, 15);
			Label_Petname.TabIndex = 26;
			Label_Petname.Text = "&name";
			Label_Petname.TextAlign = ContentAlignment.TopRight;
			Label_Pet_def.BackColor = Color.Transparent;
			Label_Pet_def.Location = new Point(575, 322);
			Label_Pet_def.Margin = new Padding(0, 1, 0, 1);
			Label_Pet_def.Name = "Label_Pet_def";
			Label_Pet_def.Size = new Size(60, 14);
			Label_Pet_def.TabIndex = 177;
			Label_Pet_def.Text = "400";
			Label_Pet_atk.BackColor = Color.Transparent;
			Label_Pet_atk.Location = new Point(575, 309);
			Label_Pet_atk.Margin = new Padding(0, 1, 0, 1);
			Label_Pet_atk.Name = "Label_Pet_atk";
			Label_Pet_atk.Size = new Size(60, 14);
			Label_Pet_atk.TabIndex = 176;
			Label_Pet_atk.Text = "400";
			Label_Pet_int.BackColor = Color.Transparent;
			Label_Pet_int.Location = new Point(575, 296);
			Label_Pet_int.Margin = new Padding(0, 1, 0, 1);
			Label_Pet_int.Name = "Label_Pet_int";
			Label_Pet_int.Size = new Size(60, 14);
			Label_Pet_int.TabIndex = 175;
			Label_Pet_int.Text = "400+400";
			Label94.BackColor = Color.Transparent;
			Label94.Location = new Point(141, 374);
			Label94.Margin = new Padding(0, 1, 0, 1);
			Label94.Name = "Label94";
			Label94.Size = new Size(73, 14);
			Label94.TabIndex = 174;
			Label94.Text = "100";
			Label_Char_agi.BackColor = Color.Transparent;
			Label_Char_agi.Location = new Point(141, 361);
			Label_Char_agi.Margin = new Padding(0, 1, 0, 1);
			Label_Char_agi.Name = "Label_Char_agi";
			Label_Char_agi.Size = new Size(73, 14);
			Label_Char_agi.TabIndex = 173;
			Label_Char_agi.Text = "400";
			Label_Char_spx.BackColor = Color.Transparent;
			Label_Char_spx.Location = new Point(141, 348);
			Label_Char_spx.Margin = new Padding(0, 1, 0, 1);
			Label_Char_spx.Name = "Label_Char_spx";
			Label_Char_spx.Size = new Size(73, 14);
			Label_Char_spx.TabIndex = 172;
			Label_Char_spx.Text = "400";
			Label_Char_hpx.BackColor = Color.Transparent;
			Label_Char_hpx.Location = new Point(141, 335);
			Label_Char_hpx.Margin = new Padding(0, 1, 0, 1);
			Label_Char_hpx.Name = "Label_Char_hpx";
			Label_Char_hpx.Size = new Size(73, 14);
			Label_Char_hpx.TabIndex = 171;
			Label_Char_hpx.Text = "400";
			Label_Char_def.BackColor = Color.Transparent;
			Label_Char_def.Location = new Point(141, 322);
			Label_Char_def.Margin = new Padding(0, 1, 0, 1);
			Label_Char_def.Name = "Label_Char_def";
			Label_Char_def.Size = new Size(73, 14);
			Label_Char_def.TabIndex = 170;
			Label_Char_def.Text = "400";
			Label_Char_atk.BackColor = Color.Transparent;
			Label_Char_atk.Location = new Point(141, 309);
			Label_Char_atk.Margin = new Padding(0, 1, 0, 1);
			Label_Char_atk.Name = "Label_Char_atk";
			Label_Char_atk.Size = new Size(73, 14);
			Label_Char_atk.TabIndex = 169;
			Label_Char_atk.Text = "400";
			Label_Char_int.BackColor = Color.Transparent;
			Label_Char_int.Location = new Point(141, 296);
			Label_Char_int.Margin = new Padding(0, 1, 0, 1);
			Label_Char_int.Name = "Label_Char_int";
			Label_Char_int.Size = new Size(73, 14);
			Label_Char_int.TabIndex = 168;
			Label_Char_int.Text = "400+400+400";
			PictureBox_Pet_XuatChien.Location = new Point(460, 263);
			PictureBox_Pet_XuatChien.Name = "PictureBox_Pet_XuatChien";
			PictureBox_Pet_XuatChien.Size = new Size(44, 25);
			PictureBox_Pet_XuatChien.TabIndex = 167;
			PictureBox_Pet_XuatChien.TabStop = false;
			PictureBox_Pet_Thuoctinh.Location = new Point(460, 83);
			PictureBox_Pet_Thuoctinh.Name = "PictureBox_Pet_Thuoctinh";
			PictureBox_Pet_Thuoctinh.Size = new Size(28, 28);
			PictureBox_Pet_Thuoctinh.TabIndex = 166;
			PictureBox_Pet_Thuoctinh.TabStop = false;
			PictureBox_Char_Thuoctinh.Location = new Point(26, 83);
			PictureBox_Char_Thuoctinh.Name = "PictureBox_Char_Thuoctinh";
			PictureBox_Char_Thuoctinh.Size = new Size(28, 28);
			PictureBox_Char_Thuoctinh.TabIndex = 165;
			PictureBox_Char_Thuoctinh.TabStop = false;
			PictureBox_Pet5.Location = new Point(532, 256);
			PictureBox_Pet5.Name = "PictureBox_Pet5";
			PictureBox_Pet5.Size = new Size(32, 32);
			PictureBox_Pet5.TabIndex = 164;
			PictureBox_Pet5.TabStop = false;
			PictureBox_Pet6.Location = new Point(460, 225);
			PictureBox_Pet6.Name = "PictureBox_Pet6";
			PictureBox_Pet6.Size = new Size(32, 32);
			PictureBox_Pet6.TabIndex = 163;
			PictureBox_Pet6.TabStop = false;
			PictureBox_Pet3.Location = new Point(604, 145);
			PictureBox_Pet3.Name = "PictureBox_Pet3";
			PictureBox_Pet3.Size = new Size(32, 32);
			PictureBox_Pet3.TabIndex = 162;
			PictureBox_Pet3.TabStop = false;
			PictureBox_Pet2.Location = new Point(460, 141);
			PictureBox_Pet2.Name = "PictureBox_Pet2";
			PictureBox_Pet2.Size = new Size(32, 32);
			PictureBox_Pet2.TabIndex = 161;
			PictureBox_Pet2.TabStop = false;
			PictureBox_Pet4.Location = new Point(604, 84);
			PictureBox_Pet4.Name = "PictureBox_Pet4";
			PictureBox_Pet4.Size = new Size(32, 32);
			PictureBox_Pet4.TabIndex = 160;
			PictureBox_Pet4.TabStop = false;
			PictureBox_Pet1.Location = new Point(532, 83);
			PictureBox_Pet1.Name = "PictureBox_Pet1";
			PictureBox_Pet1.Size = new Size(32, 32);
			PictureBox_Pet1.TabIndex = 159;
			PictureBox_Pet1.TabStop = false;
			PictureBox_char5.Location = new Point(98, 256);
			PictureBox_char5.Name = "PictureBox_char5";
			PictureBox_char5.Size = new Size(32, 32);
			PictureBox_char5.TabIndex = 157;
			PictureBox_char5.TabStop = false;
			PictureBox_char6.Location = new Point(26, 225);
			PictureBox_char6.Name = "PictureBox_char6";
			PictureBox_char6.Size = new Size(32, 32);
			PictureBox_char6.TabIndex = 156;
			PictureBox_char6.TabStop = false;
			PictureBox_char3.Location = new Point(170, 146);
			PictureBox_char3.Name = "PictureBox_char3";
			PictureBox_char3.Size = new Size(32, 32);
			PictureBox_char3.TabIndex = 155;
			PictureBox_char3.TabStop = false;
			PictureBox_char2.Location = new Point(26, 141);
			PictureBox_char2.Name = "PictureBox_char2";
			PictureBox_char2.Size = new Size(32, 32);
			PictureBox_char2.TabIndex = 154;
			PictureBox_char2.TabStop = false;
			PictureBox_char4.Location = new Point(170, 85);
			PictureBox_char4.Name = "PictureBox_char4";
			PictureBox_char4.Size = new Size(32, 32);
			PictureBox_char4.TabIndex = 153;
			PictureBox_char4.TabStop = false;
			PictureBox_char1.Location = new Point(98, 84);
			PictureBox_char1.Name = "PictureBox_char1";
			PictureBox_char1.Size = new Size(32, 32);
			PictureBox_char1.TabIndex = 152;
			PictureBox_char1.TabStop = false;
			Panel10.Controls.Add(RtbChat);
			Panel10.Controls.Add(rtbsystem);
			Panel10.Controls.Add(Panel_Chat);
			Panel10.Location = new Point(448, 404);
			Panel10.Name = "Panel10";
			Panel10.Size = new Size(200, 196);
			Panel10.TabIndex = 151;
			RtbChat.BackColor = SystemColors.WindowText;
			RtbChat.Dock = DockStyle.Fill;
			RtbChat.Font = new Font("Microsoft Sans Serif", 7.5f);
			RtbChat.ForeColor = SystemColors.HighlightText;
			RtbChat.Location = new Point(0, 75);
			RtbChat.Margin = new Padding(2);
			RtbChat.Name = "RtbChat";
			RtbChat.ReadOnly = true;
			RtbChat.ScrollBars = RichTextBoxScrollBars.Vertical;
			RtbChat.Size = new Size(200, 78);
			RtbChat.TabIndex = 4;
			RtbChat.Text = "";
			rtbsystem.BackColor = Color.WhiteSmoke;
			rtbsystem.Dock = DockStyle.Top;
			rtbsystem.Font = new Font("Microsoft Sans Serif", 7.5f);
			rtbsystem.ForeColor = SystemColors.ControlText;
			rtbsystem.Location = new Point(0, 0);
			rtbsystem.Margin = new Padding(2);
			rtbsystem.Name = "rtbsystem";
			rtbsystem.ReadOnly = true;
			rtbsystem.ScrollBars = RichTextBoxScrollBars.Vertical;
			rtbsystem.Size = new Size(200, 75);
			rtbsystem.TabIndex = 3;
			rtbsystem.Text = "Phát triển bởi Dương Văn Trường.\nHỗ trợ game TS Online\nHttp://tsonline.xyz\n";
			Panel_Chat.Controls.Add(ComboBox_chat);
			Panel_Chat.Controls.Add(ComboBox_nameprivate);
			Panel_Chat.Controls.Add(ComboBox_kenh);
			Panel_Chat.Dock = DockStyle.Bottom;
			Panel_Chat.Location = new Point(0, 153);
			Panel_Chat.Margin = new Padding(2);
			Panel_Chat.Name = "Panel_Chat";
			Panel_Chat.Size = new Size(200, 43);
			Panel_Chat.TabIndex = 18;
			ComboBox_chat.FlatStyle = FlatStyle.System;
			ComboBox_chat.FormattingEnabled = true;
			ComboBox_chat.Location = new Point(0, 21);
			ComboBox_chat.Margin = new Padding(0);
			ComboBox_chat.MaxLength = 60;
			ComboBox_chat.Name = "ComboBox_chat";
			ComboBox_chat.Size = new Size(200, 21);
			ComboBox_chat.TabIndex = 8;
			ComboBox_nameprivate.Dock = DockStyle.Fill;
			ComboBox_nameprivate.DropDownStyle = ComboBoxStyle.DropDownList;
			ComboBox_nameprivate.FlatStyle = FlatStyle.System;
			ComboBox_nameprivate.FormattingEnabled = true;
			ComboBox_nameprivate.Location = new Point(80, 0);
			ComboBox_nameprivate.Margin = new Padding(0);
			ComboBox_nameprivate.Name = "ComboBox_nameprivate";
			ComboBox_nameprivate.Size = new Size(120, 21);
			ComboBox_nameprivate.TabIndex = 10;
			ComboBox_kenh.Dock = DockStyle.Left;
			ComboBox_kenh.DropDownStyle = ComboBoxStyle.DropDownList;
			ComboBox_kenh.DropDownWidth = 120;
			ComboBox_kenh.FlatStyle = FlatStyle.System;
			ComboBox_kenh.FormattingEnabled = true;
			ComboBox_kenh.Items.AddRange(new object[7] { "Toàn", "Gần", "Thì thầm", "GM", "Đội", "Đoàn", "Liên Minh" });
			ComboBox_kenh.Location = new Point(0, 0);
			ComboBox_kenh.Margin = new Padding(0);
			ComboBox_kenh.Name = "ComboBox_kenh";
			ComboBox_kenh.Size = new Size(80, 21);
			ComboBox_kenh.TabIndex = 9;
			Panel9.Controls.Add(Panel7);
			Panel9.Controls.Add(GroupBox12);
			Panel9.Controls.Add(StatusBar1);
			Panel9.Location = new Point(230, 494);
			Panel9.Name = "Panel9";
			Panel9.Size = new Size(202, 105);
			Panel9.TabIndex = 150;
			Panel7.BackColor = Color.Transparent;
			Panel7.Controls.Add(CheckBox_Bee);
			Panel7.Controls.Add(Button_warp2);
			Panel7.Controls.Add(Label_mapy);
			Panel7.Controls.Add(Label_mapid);
			Panel7.Controls.Add(Button_walk);
			Panel7.Controls.Add(Label_mapx);
			Panel7.Controls.Add(TextBox_walkX);
			Panel7.Controls.Add(TextBox_idWarp2);
			Panel7.Controls.Add(TextBox_walkY);
			Panel7.Dock = DockStyle.Fill;
			Panel7.Location = new Point(0, 40);
			Panel7.Margin = new Padding(0);
			Panel7.Name = "Panel7";
			Panel7.Size = new Size(202, 47);
			Panel7.TabIndex = 31;
			CheckBox_Bee.BackColor = Color.FromArgb(240, 240, 240);
			CheckBox_Bee.FlatStyle = FlatStyle.System;
			CheckBox_Bee.Location = new Point(85, 4);
			CheckBox_Bee.Margin = new Padding(2);
			CheckBox_Bee.Name = "CheckBox_Bee";
			CheckBox_Bee.Size = new Size(60, 19);
			CheckBox_Bee.TabIndex = 31;
			CheckBox_Bee.Text = "Ong mật";
			CheckBox_Bee.TextAlign = ContentAlignment.TopLeft;
			CheckBox_Bee.UseVisualStyleBackColor = false;
			Button_warp2.FlatStyle = FlatStyle.System;
			Button_warp2.Location = new Point(163, 23);
			Button_warp2.Margin = new Padding(2);
			Button_warp2.Name = "Button_warp2";
			Button_warp2.Size = new Size(35, 20);
			Button_warp2.TabIndex = 23;
			Button_warp2.Text = "Đến";
			Button_warp2.UseVisualStyleBackColor = true;
			Label_mapy.BackColor = Color.White;
			Label_mapy.DataBindings.Add(new Binding("Text", DataSet1, "Table_database.MapY", true));
			Label_mapy.Location = new Point(41, 5);
			Label_mapy.Margin = new Padding(0, 1, 0, 1);
			Label_mapy.Name = "Label_mapy";
			Label_mapy.Size = new Size(36, 13);
			Label_mapy.TabIndex = 30;
			Label_mapy.Text = "0000";
			Label_mapid.BackColor = Color.White;
			Label_mapid.DataBindings.Add(new Binding("Text", DataSet1, "Table_database.MapId", true));
			Label_mapid.Location = new Point(147, 5);
			Label_mapid.Margin = new Padding(0, 1, 0, 1);
			Label_mapid.Name = "Label_mapid";
			Label_mapid.Size = new Size(40, 13);
			Label_mapid.TabIndex = 27;
			Label_mapid.Text = "12001";
			Button_walk.FlatStyle = FlatStyle.System;
			Button_walk.Location = new Point(73, 23);
			Button_walk.Margin = new Padding(2);
			Button_walk.Name = "Button_walk";
			Button_walk.Size = new Size(30, 20);
			Button_walk.TabIndex = 21;
			Button_walk.Text = "Đi";
			Button_walk.UseVisualStyleBackColor = true;
			Label_mapx.BackColor = Color.White;
			Label_mapx.DataBindings.Add(new Binding("Text", DataSet1, "Table_database.MapX", true));
			Label_mapx.Location = new Point(5, 4);
			Label_mapx.Margin = new Padding(0, 1, 0, 1);
			Label_mapx.Name = "Label_mapx";
			Label_mapx.Size = new Size(36, 13);
			Label_mapx.TabIndex = 29;
			Label_mapx.Text = "0000";
			TextBox_walkX.Location = new Point(5, 24);
			TextBox_walkX.Margin = new Padding(2);
			TextBox_walkX.Name = "TextBox_walkX";
			TextBox_walkX.Size = new Size(30, 19);
			TextBox_walkX.TabIndex = 18;
			TextBox_walkX.Text = "2000";
			TextBox_idWarp2.Location = new Point(119, 24);
			TextBox_idWarp2.Margin = new Padding(2);
			TextBox_idWarp2.Name = "TextBox_idWarp2";
			TextBox_idWarp2.Size = new Size(40, 19);
			TextBox_idWarp2.TabIndex = 22;
			TextBox_idWarp2.Text = "12001";
			TextBox_walkY.Location = new Point(39, 24);
			TextBox_walkY.Margin = new Padding(2);
			TextBox_walkY.Name = "TextBox_walkY";
			TextBox_walkY.Size = new Size(30, 19);
			TextBox_walkY.TabIndex = 19;
			TextBox_walkY.Text = "2000";
			GroupBox12.Controls.Add(Button_Mini_Warp);
			GroupBox12.Controls.Add(ComboBox_Mini_Warp);
			GroupBox12.Dock = DockStyle.Top;
			GroupBox12.Location = new Point(0, 0);
			GroupBox12.Name = "GroupBox12";
			GroupBox12.Size = new Size(202, 40);
			GroupBox12.TabIndex = 96;
			GroupBox12.TabStop = false;
			GroupBox12.Text = "Mini - Dịch chuyển";
			Button_Mini_Warp.Dock = DockStyle.Fill;
			Button_Mini_Warp.FlatStyle = FlatStyle.System;
			Button_Mini_Warp.Location = new Point(123, 15);
			Button_Mini_Warp.Margin = new Padding(2);
			Button_Mini_Warp.Name = "Button_Mini_Warp";
			Button_Mini_Warp.Size = new Size(76, 22);
			Button_Mini_Warp.TabIndex = 24;
			Button_Mini_Warp.Text = "Di Chuyển";
			Button_Mini_Warp.UseVisualStyleBackColor = true;
			ComboBox_Mini_Warp.Dock = DockStyle.Left;
			ComboBox_Mini_Warp.DropDownStyle = ComboBoxStyle.DropDownList;
			ComboBox_Mini_Warp.DropDownWidth = 230;
			ComboBox_Mini_Warp.FlatStyle = FlatStyle.System;
			ComboBox_Mini_Warp.FormattingEnabled = true;
			ComboBox_Mini_Warp.Location = new Point(3, 15);
			ComboBox_Mini_Warp.Margin = new Padding(2);
			ComboBox_Mini_Warp.MaxDropDownItems = 50;
			ComboBox_Mini_Warp.Name = "ComboBox_Mini_Warp";
			ComboBox_Mini_Warp.Size = new Size(120, 21);
			ComboBox_Mini_Warp.TabIndex = 18;
			StatusBar1.Location = new Point(0, 87);
			StatusBar1.Margin = new Padding(2);
			StatusBar1.Name = "StatusBar1";
			StatusBar1.Panels.AddRange(new StatusBarPanel[3] { StatusBarPanel_status, StatusBarPanel_MapName, StatusBarPanel_online });
			StatusBar1.ShowPanels = true;
			StatusBar1.Size = new Size(202, 18);
			StatusBar1.SizingGrip = false;
			StatusBar1.TabIndex = 29;
			StatusBar1.Text = "StatusBar1";
			StatusBarPanel_status.Name = "StatusBarPanel_status";
			StatusBarPanel_status.Text = "0";
			StatusBarPanel_status.Width = 40;
			StatusBarPanel_MapName.AutoSize = StatusBarPanelAutoSize.Spring;
			StatusBarPanel_MapName.Name = "StatusBarPanel_MapName";
			StatusBarPanel_MapName.Text = "Trác Quận";
			StatusBarPanel_MapName.Width = 95;
			StatusBarPanel_online.Alignment = HorizontalAlignment.Center;
			StatusBarPanel_online.AutoSize = StatusBarPanelAutoSize.Contents;
			StatusBarPanel_online.MinWidth = 67;
			StatusBarPanel_online.Name = "StatusBarPanel_online";
			StatusBarPanel_online.Text = "00:00:00";
			StatusBarPanel_online.Width = 67;
			Label_Mini.BackColor = Color.White;
			Label_Mini.FlatStyle = FlatStyle.System;
			Label_Mini.Location = new Point(23, 263);
			Label_Mini.Margin = new Padding(2);
			Label_Mini.Name = "Label_Mini";
			Label_Mini.Size = new Size(49, 15);
			Label_Mini.TabIndex = 29;
			Label_Mini.Text = "Mini";
			Label_Mini.TextAlign = ContentAlignment.TopRight;
			Label_Mini.Visible = false;
			Label83.BackColor = Color.Transparent;
			Label83.DataBindings.Add(new Binding("Text", DataSet1, "Table_database.Point", true));
			Label83.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label83.Location = new Point(176, 277);
			Label83.Margin = new Padding(0, 1, 0, 1);
			Label83.Name = "Label83";
			Label83.Size = new Size(31, 16);
			Label83.TabIndex = 116;
			Label83.Text = "400";
			Lb_tuideo25.BackColor = Color.Transparent;
			Lb_tuideo25.ContextMenuStrip = ContextMenuStrip_ToTuideo;
			Lb_tuideo25.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Lb_tuideo25.Location = new Point(386, 228);
			Lb_tuideo25.Margin = new Padding(2);
			Lb_tuideo25.Name = "Lb_tuideo25";
			Lb_tuideo25.Size = new Size(32, 32);
			Lb_tuideo25.TabIndex = 149;
			Lb_tuideo25.Text = "50";
			Lb_tuideo25.TextAlign = ContentAlignment.BottomLeft;
			Panel_Login.BackColor = Color.Transparent;
			Panel_Login.Controls.Add(CheckBox_Reconnect);
			Panel_Login.Controls.Add(btnLogin);
			Panel_Login.Controls.Add(TBPassword);
			Panel_Login.Controls.Add(TBId);
			Panel_Login.Controls.Add(TextBox_Country);
			Panel_Login.Controls.Add(ComboBox_Port);
			Panel_Login.Controls.Add(ComboBox_Server);
			Panel_Login.Controls.Add(ToolStrip1);
			Panel_Login.Location = new Point(13, 13);
			Panel_Login.Margin = new Padding(2);
			Panel_Login.Name = "Panel_Login";
			Panel_Login.Size = new Size(635, 21);
			Panel_Login.TabIndex = 33;
			CheckBox_Reconnect.BackColor = Color.FromArgb(240, 240, 240);
			CheckBox_Reconnect.Checked = true;
			CheckBox_Reconnect.CheckState = CheckState.Checked;
			CheckBox_Reconnect.Dock = DockStyle.Left;
			CheckBox_Reconnect.FlatStyle = FlatStyle.System;
			CheckBox_Reconnect.Location = new Point(351, 0);
			CheckBox_Reconnect.Margin = new Padding(2, 0, 2, 2);
			CheckBox_Reconnect.Name = "CheckBox_Reconnect";
			CheckBox_Reconnect.Size = new Size(78, 21);
			CheckBox_Reconnect.TabIndex = 4;
			CheckBox_Reconnect.Text = "Tự kết nối lại";
			CheckBox_Reconnect.TextAlign = ContentAlignment.MiddleCenter;
			CheckBox_Reconnect.UseVisualStyleBackColor = false;
			btnLogin.Dock = DockStyle.Left;
			btnLogin.FlatStyle = FlatStyle.System;
			btnLogin.Location = new Point(286, 0);
			btnLogin.Margin = new Padding(0);
			btnLogin.Name = "btnLogin";
			btnLogin.Size = new Size(65, 21);
			btnLogin.TabIndex = 3;
			btnLogin.Text = "Đăng nhập";
			btnLogin.UseVisualStyleBackColor = true;
			TBPassword.Dock = DockStyle.Left;
			TBPassword.Location = new Point(230, 0);
			TBPassword.Margin = new Padding(2);
			TBPassword.MaxLength = 10;
			TBPassword.Name = "TBPassword";
			TBPassword.PasswordChar = '*';
			TBPassword.Size = new Size(56, 19);
			TBPassword.TabIndex = 2;
			TBId.Dock = DockStyle.Left;
			TBId.Location = new Point(174, 0);
			TBId.Margin = new Padding(0);
			TBId.Name = "TBId";
			TBId.Size = new Size(56, 19);
			TBId.TabIndex = 1;
			TBId.Text = "0";
			TextBox_Country.BackColor = Color.White;
			TextBox_Country.Dock = DockStyle.Left;
			TextBox_Country.Location = new Point(148, 0);
			TextBox_Country.Margin = new Padding(2, 2, 2, 0);
			TextBox_Country.MaxLength = 2;
			TextBox_Country.Multiline = true;
			TextBox_Country.Name = "TextBox_Country";
			TextBox_Country.ReadOnly = true;
			TextBox_Country.Size = new Size(26, 21);
			TextBox_Country.TabIndex = 5;
			TextBox_Country.Text = "VN";
			ComboBox_Port.BackColor = Color.White;
			ComboBox_Port.Dock = DockStyle.Left;
			ComboBox_Port.DropDownStyle = ComboBoxStyle.DropDownList;
			ComboBox_Port.DropDownWidth = 132;
			ComboBox_Port.FlatStyle = FlatStyle.System;
			ComboBox_Port.FormattingEnabled = true;
			ComboBox_Port.Items.AddRange(new object[102]
			{
				"Kênh 0", "Kênh 101", "Kênh 102", "Kênh 1", "Kênh 2", "Kênh 3", "Kênh 4", "Kênh 5", "Kênh 6", "Kênh 7",
				"Kênh 8", "Kênh 9", "Kênh 10", "Kênh 11", "Kênh 12", "Kênh 13", "Kênh 14", "Kênh 15", "Kênh 16", "Kênh 17",
				"Kênh 18", "Kênh 19", "Kênh 20", "Kênh 21", "Kênh 22", "Kênh 23", "Kênh 24", "Kênh 25", "Kênh 26", "Kênh 27",
				"Kênh 28", "Kênh 29", "Kênh 30", "Kênh 31", "Kênh 32", "Kênh 33", "Kênh 34", "Kênh 35", "Kênh 36", "Kênh 37",
				"Kênh 38", "Kênh 39", "Kênh 40", "Kênh 41", "Kênh 42", "Kênh 43", "Kênh 44", "Kênh 45", "Kênh 46", "Kênh 47",
				"Kênh 48", "Kênh 49", "Kênh 50", "Kênh 51", "Kênh 52", "Kênh 53", "Kênh 54", "Kênh 55", "Kênh 56", "Kênh 57",
				"Kênh 58", "Kênh 59", "Kênh 60", "Kênh 61", "Kênh 62", "Kênh 63", "Kênh 64", "Kênh 65", "Kênh 66", "Kênh 67",
				"Kênh 68", "Kênh 69", "Kênh 70", "Kênh 71", "Kênh 72", "Kênh 73", "Kênh 74", "Kênh 75", "Kênh 76", "Kênh 77",
				"Kênh 78", "Kênh 79", "Kênh 80", "Kênh 81", "Kênh 82", "Kênh 83", "Kênh 84", "Kênh 85", "Kênh 86", "Kênh 87",
				"Kênh 88", "Kênh 89", "Kênh 90", "Kênh 91", "Kênh 92", "Kênh 93", "Kênh 94", "Kênh 95", "Kênh 96", "Kênh 97",
				"Kênh 98", "Kênh 99"
			});
			ComboBox_Port.Location = new Point(88, 0);
			ComboBox_Port.Margin = new Padding(6, 2, 2, 2);
			ComboBox_Port.Name = "ComboBox_Port";
			ComboBox_Port.Size = new Size(60, 21);
			ComboBox_Port.TabIndex = 7;
			ComboBox_Server.BackColor = Color.White;
			ComboBox_Server.Dock = DockStyle.Left;
			ComboBox_Server.DropDownStyle = ComboBoxStyle.DropDownList;
			ComboBox_Server.DropDownWidth = 132;
			ComboBox_Server.FlatStyle = FlatStyle.System;
			ComboBox_Server.FormattingEnabled = true;
			ComboBox_Server.Location = new Point(0, 0);
			ComboBox_Server.Margin = new Padding(0);
			ComboBox_Server.Name = "ComboBox_Server";
			ComboBox_Server.Size = new Size(88, 21);
			ComboBox_Server.TabIndex = 0;
			ToolStrip1.AutoParentBackColor = false;
			ToolStrip1.AutoSize = false;
			ToolStrip1.BackColor = Color.FromArgb(156, 170, 193);
			ToolStrip1.CanOverflow = false;
			ToolStrip1.Dock = DockStyle.None;
			ToolStrip1.GripStyle = ToolStripGripStyle.Hidden;
			ToolStrip1.ImageScalingSize = new Size(24, 24);
			ToolStrip1.Items.AddRange(new ToolStripItem[3] { ToolStripSplitButton_save, ToolStripLabel1, ToolStripTextBox_KenhPassword });
			ToolStrip1.Location = new Point(429, 0);
			ToolStrip1.Name = "ToolStrip1";
			ToolStrip1.Padding = new Padding(2, 0, 2, 0);
			vs2010ToolStripRenderer.ColorTable = colorTable2;
			vs2010ToolStripRenderer.RoundedEdges = true;
			ToolStrip1.Renderer = vs2010ToolStripRenderer;
			ToolStrip1.Size = new Size(207, 21);
			ToolStrip1.TabIndex = 0;
			ToolStrip1.Text = "ToolStrip1";
			ToolStripLabel1.Name = "ToolStripLabel1";
			ToolStripLabel1.Size = new Size(92, 18);
			ToolStripLabel1.Text = "Mật khẩu kênh: ";
			ToolStripLabel1.Visible = false;
			ToolStripTextBox_KenhPassword.Font = new Font("Segoe UI", 9f);
			ToolStripTextBox_KenhPassword.Name = "ToolStripTextBox_KenhPassword";
			ToolStripTextBox_KenhPassword.Size = new Size(70, 21);
			ToolStripTextBox_KenhPassword.Visible = false;
			Panel6.Controls.Add(ProgressBarEx_BDY);
			Panel6.Controls.Add(Label_BDY);
			Panel6.Location = new Point(13, 568);
			Panel6.Name = "Panel6";
			Panel6.Size = new Size(202, 32);
			Panel6.TabIndex = 29;
			ProgressBarEx_BDY.BackColorStyle = ProgressBarEx.ColorStyle.Gradient;
			ProgressBarEx_BDY.BackGradientMode = LinearGradientMode.Vertical;
			ProgressBarEx_BDY.BackSigmaFocus = 30;
			ProgressBarEx_BDY.BackSigmaMode = ProgressBarEx.SigmaMode.SigmaBell;
			ProgressBarEx_BDY.BackSigmaScale = 70;
			ProgressBarEx_BDY.BarColor1 = Color.LimeGreen;
			ProgressBarEx_BDY.BarColorStyle = ProgressBarEx.ColorStyle.Gradient;
			ProgressBarEx_BDY.BarGradientMode = LinearGradientMode.Vertical;
			ProgressBarEx_BDY.BarSigmaFocus = 30;
			ProgressBarEx_BDY.BarSigmaMode = ProgressBarEx.SigmaMode.SigmaBell;
			ProgressBarEx_BDY.BarSigmaScale = 70;
			ProgressBarEx_BDY.BarTextPercen = ProgressBarEx.TextPercen.None;
			ProgressBarEx_BDY.Dock = DockStyle.Bottom;
			ProgressBarEx_BDY.Location = new Point(0, 17);
			ProgressBarEx_BDY.Margin = new Padding(5, 2, 5, 2);
			ProgressBarEx_BDY.Maximum = 31;
			ProgressBarEx_BDY.Name = "ProgressBarEx_BDY";
			ProgressBarEx_BDY.Size = new Size(202, 15);
			ProgressBarEx_BDY.TabIndex = 21;
			ProgressBarEx_BDY.Text = "ProgressBarEx4";
			Label_BDY.BackColor = Color.White;
			Label_BDY.Dock = DockStyle.Top;
			Label_BDY.FlatStyle = FlatStyle.System;
			Label_BDY.Location = new Point(0, 0);
			Label_BDY.Margin = new Padding(2);
			Label_BDY.Name = "Label_BDY";
			Label_BDY.Size = new Size(202, 15);
			Label_BDY.TabIndex = 20;
			Label_BDY.Text = "Gửi Ba Đậu Yêu";
			Label_BDY.TextAlign = ContentAlignment.MiddleCenter;
			Lb_tuideo24.BackColor = Color.Transparent;
			Lb_tuideo24.ContextMenuStrip = ContextMenuStrip_ToTuideo;
			Lb_tuideo24.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Lb_tuideo24.Location = new Point(350, 228);
			Lb_tuideo24.Margin = new Padding(2);
			Lb_tuideo24.Name = "Lb_tuideo24";
			Lb_tuideo24.Size = new Size(32, 32);
			Lb_tuideo24.TabIndex = 148;
			Lb_tuideo24.Text = "50";
			Lb_tuideo24.TextAlign = ContentAlignment.BottomLeft;
			Label_Lv.BackColor = Color.White;
			Label_Lv.DataBindings.Add(new Binding("Text", DataSet1, "Table_database.Lv", true));
			Label_Lv.FlatStyle = FlatStyle.System;
			Label_Lv.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label_Lv.Location = new Point(35, 48);
			Label_Lv.Margin = new Padding(2);
			Label_Lv.Name = "Label_Lv";
			Label_Lv.Size = new Size(26, 16);
			Label_Lv.TabIndex = 24;
			Label_Lv.Text = "200";
			Lb_tuideo23.BackColor = Color.Transparent;
			Lb_tuideo23.ContextMenuStrip = ContextMenuStrip_ToTuideo;
			Lb_tuideo23.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Lb_tuideo23.Location = new Point(314, 228);
			Lb_tuideo23.Margin = new Padding(2);
			Lb_tuideo23.Name = "Lb_tuideo23";
			Lb_tuideo23.Size = new Size(32, 32);
			Lb_tuideo23.TabIndex = 147;
			Lb_tuideo23.Text = "50";
			Lb_tuideo23.TextAlign = ContentAlignment.BottomLeft;
			GroupBox_Bot.BackColor = Color.White;
			GroupBox_Bot.Controls.Add(ComboBox_botname);
			GroupBox_Bot.Controls.Add(TextBox_DelayBot);
			GroupBox_Bot.Controls.Add(Label51);
			GroupBox_Bot.Controls.Add(Button_bot);
			GroupBox_Bot.Controls.Add(CheckBox_QuestProtect);
			GroupBox_Bot.Controls.Add(CheckBox_autosell);
			GroupBox_Bot.Controls.Add(CheckBox_TuLenNgua);
			GroupBox_Bot.FlatStyle = FlatStyle.System;
			GroupBox_Bot.Location = new Point(13, 404);
			GroupBox_Bot.Margin = new Padding(0);
			GroupBox_Bot.Name = "GroupBox_Bot";
			GroupBox_Bot.Padding = new Padding(2);
			GroupBox_Bot.Size = new Size(100, 161);
			GroupBox_Bot.TabIndex = 31;
			GroupBox_Bot.TabStop = false;
			GroupBox_Bot.Text = "Bot";
			ComboBox_botname.DropDownStyle = ComboBoxStyle.DropDownList;
			ComboBox_botname.DropDownWidth = 230;
			ComboBox_botname.FlatStyle = FlatStyle.System;
			ComboBox_botname.FormattingEnabled = true;
			ComboBox_botname.Location = new Point(4, 16);
			ComboBox_botname.Margin = new Padding(2);
			ComboBox_botname.MaxDropDownItems = 20;
			ComboBox_botname.Name = "ComboBox_botname";
			ComboBox_botname.Size = new Size(92, 21);
			ComboBox_botname.TabIndex = 17;
			TextBox_DelayBot.Location = new Point(61, 41);
			TextBox_DelayBot.Margin = new Padding(2);
			TextBox_DelayBot.MaxLength = 4;
			TextBox_DelayBot.Name = "TextBox_DelayBot";
			TextBox_DelayBot.Size = new Size(35, 19);
			TextBox_DelayBot.TabIndex = 27;
			TextBox_DelayBot.Text = "0.2";
			TextBox_DelayBot.TextAlign = HorizontalAlignment.Right;
			Label51.BackColor = Color.White;
			Label51.FlatStyle = FlatStyle.System;
			Label51.Location = new Point(5, 44);
			Label51.Margin = new Padding(0, 2, 0, 2);
			Label51.Name = "Label51";
			Label51.Size = new Size(54, 15);
			Label51.TabIndex = 26;
			Label51.Text = "Delay(giây)";
			Button_bot.Enabled = false;
			Button_bot.FlatStyle = FlatStyle.System;
			Button_bot.Location = new Point(4, 64);
			Button_bot.Margin = new Padding(2);
			Button_bot.Name = "Button_bot";
			Button_bot.Size = new Size(92, 20);
			Button_bot.TabIndex = 16;
			Button_bot.Text = "Bắt đầu";
			Button_bot.UseVisualStyleBackColor = true;
			CheckBox_QuestProtect.BackColor = Color.FromArgb(240, 240, 240);
			CheckBox_QuestProtect.FlatStyle = FlatStyle.System;
			CheckBox_QuestProtect.Location = new Point(4, 88);
			CheckBox_QuestProtect.Margin = new Padding(2);
			CheckBox_QuestProtect.Name = "CheckBox_QuestProtect";
			CheckBox_QuestProtect.Size = new Size(92, 29);
			CheckBox_QuestProtect.TabIndex = 30;
			CheckBox_QuestProtect.Text = "Chống mất Quest";
			CheckBox_QuestProtect.TextAlign = ContentAlignment.TopLeft;
			CheckBox_QuestProtect.UseVisualStyleBackColor = false;
			CheckBox_autosell.BackColor = Color.FromArgb(240, 240, 240);
			CheckBox_autosell.FlatStyle = FlatStyle.System;
			CheckBox_autosell.Location = new Point(4, 118);
			CheckBox_autosell.Margin = new Padding(2);
			CheckBox_autosell.Name = "CheckBox_autosell";
			CheckBox_autosell.Size = new Size(92, 19);
			CheckBox_autosell.TabIndex = 29;
			CheckBox_autosell.Text = "Tự bán đồ";
			CheckBox_autosell.TextAlign = ContentAlignment.TopLeft;
			CheckBox_autosell.UseVisualStyleBackColor = false;
			CheckBox_TuLenNgua.BackColor = Color.FromArgb(240, 240, 240);
			CheckBox_TuLenNgua.FlatStyle = FlatStyle.System;
			CheckBox_TuLenNgua.Location = new Point(4, 139);
			CheckBox_TuLenNgua.Margin = new Padding(2);
			CheckBox_TuLenNgua.Name = "CheckBox_TuLenNgua";
			CheckBox_TuLenNgua.Size = new Size(92, 19);
			CheckBox_TuLenNgua.TabIndex = 28;
			CheckBox_TuLenNgua.Text = "Tự lên ngựa";
			CheckBox_TuLenNgua.TextAlign = ContentAlignment.TopLeft;
			CheckBox_TuLenNgua.UseVisualStyleBackColor = false;
			GroupBox_team.BackColor = Color.White;
			GroupBox_team.Controls.Add(Label55);
			GroupBox_team.Controls.Add(Button_OutParty);
			GroupBox_team.Controls.Add(Label_IdLeader);
			GroupBox_team.Controls.Add(Button_InviteParty);
			GroupBox_team.Controls.Add(Button_RequestParty);
			GroupBox_team.Controls.Add(Panel5);
			GroupBox_team.Controls.Add(TextBox_IdLeader);
			GroupBox_team.FlatStyle = FlatStyle.System;
			GroupBox_team.Location = new Point(114, 404);
			GroupBox_team.Margin = new Padding(0);
			GroupBox_team.Name = "GroupBox_team";
			GroupBox_team.Padding = new Padding(2);
			GroupBox_team.Size = new Size(100, 161);
			GroupBox_team.TabIndex = 16;
			GroupBox_team.TabStop = false;
			GroupBox_team.Text = "Tổ đội";
			Label55.BackColor = Color.White;
			Label55.FlatStyle = FlatStyle.System;
			Label55.Location = new Point(4, 117);
			Label55.Margin = new Padding(2);
			Label55.Name = "Label55";
			Label55.Size = new Size(43, 15);
			Label55.TabIndex = 30;
			Label55.Text = "Id Chupt";
			Button_OutParty.FlatStyle = FlatStyle.System;
			Button_OutParty.Location = new Point(60, 137);
			Button_OutParty.Margin = new Padding(2);
			Button_OutParty.Name = "Button_OutParty";
			Button_OutParty.Size = new Size(38, 20);
			Button_OutParty.TabIndex = 43;
			Button_OutParty.Text = "Thoát";
			Button_OutParty.UseVisualStyleBackColor = true;
			Label_IdLeader.BackColor = Color.White;
			Label_IdLeader.DataBindings.Add(new Binding("Text", DataSet1, "Table_database.LeaderId", true));
			Label_IdLeader.FlatStyle = FlatStyle.System;
			Label_IdLeader.Location = new Point(44, 0);
			Label_IdLeader.Margin = new Padding(2);
			Label_IdLeader.Name = "Label_IdLeader";
			Label_IdLeader.Size = new Size(65, 15);
			Label_IdLeader.TabIndex = 29;
			Label_IdLeader.Text = "200";
			Button_InviteParty.FlatStyle = FlatStyle.System;
			Button_InviteParty.Location = new Point(4, 137);
			Button_InviteParty.Margin = new Padding(2);
			Button_InviteParty.Name = "Button_InviteParty";
			Button_InviteParty.Size = new Size(26, 20);
			Button_InviteParty.TabIndex = 42;
			Button_InviteParty.Text = "Xin";
			Button_InviteParty.UseVisualStyleBackColor = true;
			Button_RequestParty.FlatStyle = FlatStyle.System;
			Button_RequestParty.Location = new Point(32, 137);
			Button_RequestParty.Margin = new Padding(2);
			Button_RequestParty.Name = "Button_RequestParty";
			Button_RequestParty.Size = new Size(26, 20);
			Button_RequestParty.TabIndex = 41;
			Button_RequestParty.Text = "Mời";
			Button_RequestParty.UseVisualStyleBackColor = true;
			Panel5.BackColor = Color.White;
			Panel5.Controls.Add(TextBox_IDmem4);
			Panel5.Controls.Add(TextBox_IDmem3);
			Panel5.Controls.Add(TextBox_IDmem2);
			Panel5.Controls.Add(TextBox_IDmem1);
			Panel5.Controls.Add(RadioButton_QS1);
			Panel5.Controls.Add(RadioButton_QS2);
			Panel5.Controls.Add(RadioButton_QS3);
			Panel5.Controls.Add(RadioButton_QS4);
			Panel5.Dock = DockStyle.Top;
			Panel5.Location = new Point(2, 14);
			Panel5.Margin = new Padding(4);
			Panel5.Name = "Panel5";
			Panel5.Size = new Size(96, 94);
			Panel5.TabIndex = 19;
			TextBox_IDmem4.Location = new Point(44, 71);
			TextBox_IDmem4.Margin = new Padding(0, 2, 2, 2);
			TextBox_IDmem4.MaxLength = 10;
			TextBox_IDmem4.Name = "TextBox_IDmem4";
			TextBox_IDmem4.Size = new Size(50, 19);
			TextBox_IDmem4.TabIndex = 7;
			TextBox_IDmem4.Text = "0";
			TextBox_IDmem3.Location = new Point(44, 48);
			TextBox_IDmem3.Margin = new Padding(0, 2, 2, 2);
			TextBox_IDmem3.MaxLength = 10;
			TextBox_IDmem3.Name = "TextBox_IDmem3";
			TextBox_IDmem3.Size = new Size(50, 19);
			TextBox_IDmem3.TabIndex = 6;
			TextBox_IDmem3.Text = "0";
			TextBox_IDmem2.Location = new Point(44, 25);
			TextBox_IDmem2.Margin = new Padding(0, 2, 2, 2);
			TextBox_IDmem2.MaxLength = 10;
			TextBox_IDmem2.Name = "TextBox_IDmem2";
			TextBox_IDmem2.Size = new Size(50, 19);
			TextBox_IDmem2.TabIndex = 5;
			TextBox_IDmem2.Text = "0";
			TextBox_IDmem1.Location = new Point(44, 2);
			TextBox_IDmem1.Margin = new Padding(0, 2, 2, 2);
			TextBox_IDmem1.MaxLength = 10;
			TextBox_IDmem1.Name = "TextBox_IDmem1";
			TextBox_IDmem1.Size = new Size(50, 19);
			TextBox_IDmem1.TabIndex = 4;
			TextBox_IDmem1.Text = "0";
			RadioButton_QS1.BackColor = Color.FromArgb(240, 240, 240);
			RadioButton_QS1.Checked = true;
			RadioButton_QS1.FlatStyle = FlatStyle.System;
			RadioButton_QS1.Location = new Point(4, 4);
			RadioButton_QS1.Margin = new Padding(2, 2, 0, 2);
			RadioButton_QS1.Name = "RadioButton_QS1";
			RadioButton_QS1.Size = new Size(40, 17);
			RadioButton_QS1.TabIndex = 0;
			RadioButton_QS1.TabStop = true;
			RadioButton_QS1.Text = "VN";
			RadioButton_QS1.UseVisualStyleBackColor = false;
			RadioButton_QS2.BackColor = Color.FromArgb(240, 240, 240);
			RadioButton_QS2.FlatStyle = FlatStyle.System;
			RadioButton_QS2.Location = new Point(4, 27);
			RadioButton_QS2.Margin = new Padding(2, 2, 0, 2);
			RadioButton_QS2.Name = "RadioButton_QS2";
			RadioButton_QS2.Size = new Size(40, 17);
			RadioButton_QS2.TabIndex = 1;
			RadioButton_QS2.Text = "VN";
			RadioButton_QS2.UseVisualStyleBackColor = false;
			RadioButton_QS3.BackColor = Color.FromArgb(240, 240, 240);
			RadioButton_QS3.FlatStyle = FlatStyle.System;
			RadioButton_QS3.Location = new Point(4, 50);
			RadioButton_QS3.Margin = new Padding(2, 2, 0, 2);
			RadioButton_QS3.Name = "RadioButton_QS3";
			RadioButton_QS3.Size = new Size(40, 17);
			RadioButton_QS3.TabIndex = 2;
			RadioButton_QS3.Text = "VN";
			RadioButton_QS3.UseVisualStyleBackColor = false;
			RadioButton_QS4.BackColor = Color.FromArgb(240, 240, 240);
			RadioButton_QS4.FlatStyle = FlatStyle.System;
			RadioButton_QS4.Location = new Point(4, 73);
			RadioButton_QS4.Margin = new Padding(2, 2, 0, 2);
			RadioButton_QS4.Name = "RadioButton_QS4";
			RadioButton_QS4.Size = new Size(40, 17);
			RadioButton_QS4.TabIndex = 3;
			RadioButton_QS4.Text = "VN";
			RadioButton_QS4.UseVisualStyleBackColor = false;
			TextBox_IdLeader.Location = new Point(47, 114);
			TextBox_IdLeader.Margin = new Padding(2);
			TextBox_IdLeader.MaxLength = 20;
			TextBox_IdLeader.Name = "TextBox_IdLeader";
			TextBox_IdLeader.Size = new Size(50, 19);
			TextBox_IdLeader.TabIndex = 8;
			Label_CharName.BackColor = Color.Transparent;
			Label_CharName.DataBindings.Add(new Binding("Text", DataSet1, "Table_database.Name", true));
			Label_CharName.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label_CharName.Location = new Point(105, 46);
			Label_CharName.Margin = new Padding(2);
			Label_CharName.Name = "Label_CharName";
			Label_CharName.Size = new Size(105, 15);
			Label_CharName.TabIndex = 28;
			Label_CharName.Text = "&name";
			Label_CharName.TextAlign = ContentAlignment.TopRight;
			Lb_tuideo22.BackColor = Color.Transparent;
			Lb_tuideo22.ContextMenuStrip = ContextMenuStrip_ToTuideo;
			Lb_tuideo22.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Lb_tuideo22.Location = new Point(278, 228);
			Lb_tuideo22.Margin = new Padding(2);
			Lb_tuideo22.Name = "Lb_tuideo22";
			Lb_tuideo22.Size = new Size(32, 32);
			Lb_tuideo22.TabIndex = 146;
			Lb_tuideo22.Text = "50";
			Lb_tuideo22.TextAlign = ContentAlignment.BottomLeft;
			Label_petlv.BackColor = Color.White;
			Label_petlv.FlatStyle = FlatStyle.System;
			Label_petlv.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label_petlv.Location = new Point(470, 48);
			Label_petlv.Margin = new Padding(2);
			Label_petlv.Name = "Label_petlv";
			Label_petlv.Size = new Size(25, 15);
			Label_petlv.TabIndex = 25;
			Label_petlv.Text = "200";
			Lb_tuideo21.BackColor = Color.Transparent;
			Lb_tuideo21.ContextMenuStrip = ContextMenuStrip_ToTuideo;
			Lb_tuideo21.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Lb_tuideo21.Location = new Point(242, 228);
			Lb_tuideo21.Margin = new Padding(2);
			Lb_tuideo21.Name = "Lb_tuideo21";
			Lb_tuideo21.Size = new Size(32, 32);
			Lb_tuideo21.TabIndex = 145;
			Lb_tuideo21.Text = "50";
			Lb_tuideo21.TextAlign = ContentAlignment.BottomLeft;
			Label_Lv_Plus.BackColor = Color.Transparent;
			Label_Lv_Plus.DataBindings.Add(new Binding("Text", DataSet1, "Table_database.+-Int", true));
			Label_Lv_Plus.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label_Lv_Plus.ForeColor = Color.DarkViolet;
			Label_Lv_Plus.Location = new Point(58, 48);
			Label_Lv_Plus.Margin = new Padding(0, 1, 0, 1);
			Label_Lv_Plus.Name = "Label_Lv_Plus";
			Label_Lv_Plus.Size = new Size(12, 16);
			Label_Lv_Plus.TabIndex = 106;
			Label_Lv_Plus.Text = "+";
			Label_Lv_Plus.Visible = false;
			Lb_tuideo20.BackColor = Color.Transparent;
			Lb_tuideo20.ContextMenuStrip = ContextMenuStrip_ToTuideo;
			Lb_tuideo20.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Lb_tuideo20.Location = new Point(386, 192);
			Lb_tuideo20.Margin = new Padding(2);
			Lb_tuideo20.Name = "Lb_tuideo20";
			Lb_tuideo20.Size = new Size(32, 32);
			Lb_tuideo20.TabIndex = 144;
			Lb_tuideo20.Text = "50";
			Lb_tuideo20.TextAlign = ContentAlignment.BottomLeft;
			Label_Lv2.BackColor = Color.Transparent;
			Label_Lv2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label_Lv2.ForeColor = Color.DarkViolet;
			Label_Lv2.Location = new Point(69, 48);
			Label_Lv2.Margin = new Padding(0, 1, 0, 1);
			Label_Lv2.Name = "Label_Lv2";
			Label_Lv2.Size = new Size(32, 16);
			Label_Lv2.TabIndex = 107;
			Label_Lv2.Text = "200";
			Label_Lv2.Visible = false;
			Lb_tuideo19.BackColor = Color.Transparent;
			Lb_tuideo19.ContextMenuStrip = ContextMenuStrip_ToTuideo;
			Lb_tuideo19.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Lb_tuideo19.Location = new Point(350, 192);
			Lb_tuideo19.Margin = new Padding(2);
			Lb_tuideo19.Name = "Lb_tuideo19";
			Lb_tuideo19.Size = new Size(32, 32);
			Lb_tuideo19.TabIndex = 143;
			Lb_tuideo19.Text = "50";
			Lb_tuideo19.TextAlign = ContentAlignment.BottomLeft;
			Label_PetExpMin.BackColor = Color.White;
			Label_PetExpMin.FlatStyle = FlatStyle.System;
			Label_PetExpMin.Location = new Point(500, 377);
			Label_PetExpMin.Margin = new Padding(2);
			Label_PetExpMin.Name = "Label_PetExpMin";
			Label_PetExpMin.Size = new Size(45, 15);
			Label_PetExpMin.TabIndex = 20;
			Label_PetExpMin.Text = "0";
			Label_PetExpMin.TextAlign = ContentAlignment.TopRight;
			Lb_tuideo18.BackColor = Color.Transparent;
			Lb_tuideo18.ContextMenuStrip = ContextMenuStrip_ToTuideo;
			Lb_tuideo18.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Lb_tuideo18.Location = new Point(314, 192);
			Lb_tuideo18.Margin = new Padding(2);
			Lb_tuideo18.Name = "Lb_tuideo18";
			Lb_tuideo18.Size = new Size(32, 32);
			Lb_tuideo18.TabIndex = 142;
			Lb_tuideo18.Text = "50";
			Lb_tuideo18.TextAlign = ContentAlignment.BottomLeft;
			Label8.BackColor = Color.White;
			Label8.FlatStyle = FlatStyle.System;
			Label8.Location = new Point(448, 377);
			Label8.Margin = new Padding(2);
			Label8.Name = "Label8";
			Label8.Size = new Size(51, 15);
			Label8.TabIndex = 19;
			Label8.Text = "Exp/Phút :";
			Label8.TextAlign = ContentAlignment.TopRight;
			Label8.Visible = false;
			Lb_tuideo17.BackColor = Color.Transparent;
			Lb_tuideo17.ContextMenuStrip = ContextMenuStrip_ToTuideo;
			Lb_tuideo17.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Lb_tuideo17.Location = new Point(278, 192);
			Lb_tuideo17.Margin = new Padding(2);
			Lb_tuideo17.Name = "Lb_tuideo17";
			Lb_tuideo17.Size = new Size(32, 32);
			Lb_tuideo17.TabIndex = 141;
			Lb_tuideo17.Text = "50";
			Lb_tuideo17.TextAlign = ContentAlignment.BottomLeft;
			Lb_tuideo16.BackColor = Color.Transparent;
			Lb_tuideo16.ContextMenuStrip = ContextMenuStrip_ToTuideo;
			Lb_tuideo16.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Lb_tuideo16.Location = new Point(242, 192);
			Lb_tuideo16.Margin = new Padding(2);
			Lb_tuideo16.Name = "Lb_tuideo16";
			Lb_tuideo16.Size = new Size(32, 32);
			Lb_tuideo16.TabIndex = 140;
			Lb_tuideo16.Text = "50";
			Lb_tuideo16.TextAlign = ContentAlignment.BottomLeft;
			ProgressBarEx_PetExp.BackColorStyle = ProgressBarEx.ColorStyle.Gradient;
			ProgressBarEx_PetExp.BackGradientMode = LinearGradientMode.Vertical;
			ProgressBarEx_PetExp.BackSigmaFocus = 30;
			ProgressBarEx_PetExp.BackSigmaMode = ProgressBarEx.SigmaMode.SigmaBell;
			ProgressBarEx_PetExp.BackSigmaScale = 70;
			ProgressBarEx_PetExp.BarColor1 = Color.LimeGreen;
			ProgressBarEx_PetExp.BarColorStyle = ProgressBarEx.ColorStyle.Gradient;
			ProgressBarEx_PetExp.BarGradientMode = LinearGradientMode.Vertical;
			ProgressBarEx_PetExp.BarSigmaFocus = 30;
			ProgressBarEx_PetExp.BarSigmaMode = ProgressBarEx.SigmaMode.SigmaBell;
			ProgressBarEx_PetExp.BarSigmaScale = 70;
			ProgressBarEx_PetExp.BarTextPercen = ProgressBarEx.TextPercen.Percen;
			ProgressBarEx_PetExp.Location = new Point(475, 328);
			ProgressBarEx_PetExp.Margin = new Padding(5, 2, 5, 2);
			ProgressBarEx_PetExp.Name = "ProgressBarEx_PetExp";
			ProgressBarEx_PetExp.Size = new Size(70, 15);
			ProgressBarEx_PetExp.TabIndex = 15;
			ProgressBarEx_PetExp.Text = "ProgressBarEx4";
			ProgressBarEx_PetExp.Value = 50;
			Lb_tuideo15.BackColor = Color.Transparent;
			Lb_tuideo15.ContextMenuStrip = ContextMenuStrip_ToTuideo;
			Lb_tuideo15.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Lb_tuideo15.Location = new Point(386, 156);
			Lb_tuideo15.Margin = new Padding(2);
			Lb_tuideo15.Name = "Lb_tuideo15";
			Lb_tuideo15.Size = new Size(32, 32);
			Lb_tuideo15.TabIndex = 139;
			Lb_tuideo15.Text = "50";
			Lb_tuideo15.TextAlign = ContentAlignment.BottomLeft;
			Lb_tuideo14.BackColor = Color.Transparent;
			Lb_tuideo14.ContextMenuStrip = ContextMenuStrip_ToTuideo;
			Lb_tuideo14.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Lb_tuideo14.Location = new Point(350, 156);
			Lb_tuideo14.Margin = new Padding(2);
			Lb_tuideo14.Name = "Lb_tuideo14";
			Lb_tuideo14.Size = new Size(32, 32);
			Lb_tuideo14.TabIndex = 138;
			Lb_tuideo14.Text = "50";
			Lb_tuideo14.TextAlign = ContentAlignment.BottomLeft;
			Lb_tuideo13.BackColor = Color.Transparent;
			Lb_tuideo13.ContextMenuStrip = ContextMenuStrip_ToTuideo;
			Lb_tuideo13.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Lb_tuideo13.Location = new Point(314, 156);
			Lb_tuideo13.Margin = new Padding(2);
			Lb_tuideo13.Name = "Lb_tuideo13";
			Lb_tuideo13.Size = new Size(32, 32);
			Lb_tuideo13.TabIndex = 137;
			Lb_tuideo13.Text = "50";
			Lb_tuideo13.TextAlign = ContentAlignment.BottomLeft;
			Lb_tuideo12.BackColor = Color.Transparent;
			Lb_tuideo12.ContextMenuStrip = ContextMenuStrip_ToTuideo;
			Lb_tuideo12.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Lb_tuideo12.Location = new Point(278, 156);
			Lb_tuideo12.Margin = new Padding(2);
			Lb_tuideo12.Name = "Lb_tuideo12";
			Lb_tuideo12.Size = new Size(32, 32);
			Lb_tuideo12.TabIndex = 136;
			Lb_tuideo12.Text = "50";
			Lb_tuideo12.TextAlign = ContentAlignment.BottomLeft;
			Label4.BackColor = Color.White;
			Label4.FlatStyle = FlatStyle.System;
			Label4.Location = new Point(15, 377);
			Label4.Margin = new Padding(2);
			Label4.Name = "Label4";
			Label4.Size = new Size(51, 15);
			Label4.TabIndex = 11;
			Label4.Text = "Exp/Phút :";
			Lb_tuideo11.BackColor = Color.Transparent;
			Lb_tuideo11.ContextMenuStrip = ContextMenuStrip_ToTuideo;
			Lb_tuideo11.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Lb_tuideo11.Location = new Point(242, 156);
			Lb_tuideo11.Margin = new Padding(2);
			Lb_tuideo11.Name = "Lb_tuideo11";
			Lb_tuideo11.Size = new Size(32, 32);
			Lb_tuideo11.TabIndex = 135;
			Lb_tuideo11.Text = "50";
			Lb_tuideo11.TextAlign = ContentAlignment.BottomLeft;
			Lb_tuideo10.BackColor = Color.Transparent;
			Lb_tuideo10.ContextMenuStrip = ContextMenuStrip_ToTuideo;
			Lb_tuideo10.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Lb_tuideo10.Location = new Point(386, 120);
			Lb_tuideo10.Margin = new Padding(2);
			Lb_tuideo10.Name = "Lb_tuideo10";
			Lb_tuideo10.Size = new Size(32, 32);
			Lb_tuideo10.TabIndex = 134;
			Lb_tuideo10.Text = "50";
			Lb_tuideo10.TextAlign = ContentAlignment.BottomLeft;
			Label_CharExpMin.BackColor = Color.White;
			Label_CharExpMin.DataBindings.Add(new Binding("Text", DataSet1, "Table_database.ExpMin", true));
			Label_CharExpMin.FlatStyle = FlatStyle.System;
			Label_CharExpMin.Location = new Point(69, 377);
			Label_CharExpMin.Margin = new Padding(2);
			Label_CharExpMin.Name = "Label_CharExpMin";
			Label_CharExpMin.Size = new Size(42, 15);
			Label_CharExpMin.TabIndex = 12;
			Label_CharExpMin.Text = "0";
			Label_CharExpMin.TextAlign = ContentAlignment.TopRight;
			Lb_tuideo9.BackColor = Color.Transparent;
			Lb_tuideo9.ContextMenuStrip = ContextMenuStrip_ToTuideo;
			Lb_tuideo9.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Lb_tuideo9.Location = new Point(350, 120);
			Lb_tuideo9.Margin = new Padding(2);
			Lb_tuideo9.Name = "Lb_tuideo9";
			Lb_tuideo9.Size = new Size(32, 32);
			Lb_tuideo9.TabIndex = 133;
			Lb_tuideo9.Text = "50";
			Lb_tuideo9.TextAlign = ContentAlignment.BottomLeft;
			ProgressBarEx_PetSp.BackColorStyle = ProgressBarEx.ColorStyle.Gradient;
			ProgressBarEx_PetSp.BackGradientMode = LinearGradientMode.Vertical;
			ProgressBarEx_PetSp.BackSigmaFocus = 30;
			ProgressBarEx_PetSp.BackSigmaMode = ProgressBarEx.SigmaMode.SigmaBell;
			ProgressBarEx_PetSp.BackSigmaScale = 70;
			ProgressBarEx_PetSp.BarColor1 = SystemColors.MenuHighlight;
			ProgressBarEx_PetSp.BarColorStyle = ProgressBarEx.ColorStyle.Gradient;
			ProgressBarEx_PetSp.BarGradientMode = LinearGradientMode.Vertical;
			ProgressBarEx_PetSp.BarSigmaFocus = 30;
			ProgressBarEx_PetSp.BarSigmaMode = ProgressBarEx.SigmaMode.SigmaBell;
			ProgressBarEx_PetSp.BarSigmaScale = 70;
			ProgressBarEx_PetSp.Location = new Point(475, 312);
			ProgressBarEx_PetSp.Margin = new Padding(5, 2, 5, 2);
			ProgressBarEx_PetSp.Name = "ProgressBarEx_PetSp";
			ProgressBarEx_PetSp.Size = new Size(70, 15);
			ProgressBarEx_PetSp.TabIndex = 14;
			ProgressBarEx_PetSp.Text = "ProgressBarEx5";
			ProgressBarEx_PetSp.Value = 50;
			Lb_tuideo8.BackColor = Color.Transparent;
			Lb_tuideo8.ContextMenuStrip = ContextMenuStrip_ToTuideo;
			Lb_tuideo8.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Lb_tuideo8.Location = new Point(314, 120);
			Lb_tuideo8.Margin = new Padding(2);
			Lb_tuideo8.Name = "Lb_tuideo8";
			Lb_tuideo8.Size = new Size(32, 32);
			Lb_tuideo8.TabIndex = 132;
			Lb_tuideo8.Text = "50";
			Lb_tuideo8.TextAlign = ContentAlignment.BottomLeft;
			Lb_tuideo7.BackColor = Color.Transparent;
			Lb_tuideo7.ContextMenuStrip = ContextMenuStrip_ToTuideo;
			Lb_tuideo7.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Lb_tuideo7.Location = new Point(278, 120);
			Lb_tuideo7.Margin = new Padding(2);
			Lb_tuideo7.Name = "Lb_tuideo7";
			Lb_tuideo7.Size = new Size(32, 32);
			Lb_tuideo7.TabIndex = 131;
			Lb_tuideo7.Text = "50";
			Lb_tuideo7.TextAlign = ContentAlignment.BottomLeft;
			Lb_tuideo6.BackColor = Color.Transparent;
			Lb_tuideo6.ContextMenuStrip = ContextMenuStrip_ToTuideo;
			Lb_tuideo6.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Lb_tuideo6.Location = new Point(242, 120);
			Lb_tuideo6.Margin = new Padding(2);
			Lb_tuideo6.Name = "Lb_tuideo6";
			Lb_tuideo6.Size = new Size(32, 32);
			Lb_tuideo6.TabIndex = 130;
			Lb_tuideo6.Text = "50";
			Lb_tuideo6.TextAlign = ContentAlignment.BottomLeft;
			Lb_tuideo5.BackColor = Color.Transparent;
			Lb_tuideo5.ContextMenuStrip = ContextMenuStrip_ToTuideo;
			Lb_tuideo5.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Lb_tuideo5.Location = new Point(386, 84);
			Lb_tuideo5.Margin = new Padding(2);
			Lb_tuideo5.Name = "Lb_tuideo5";
			Lb_tuideo5.Size = new Size(32, 32);
			Lb_tuideo5.TabIndex = 129;
			Lb_tuideo5.Text = "50";
			Lb_tuideo5.TextAlign = ContentAlignment.BottomLeft;
			Label_gold.BackColor = Color.FromArgb(255, 255, 192);
			Label_gold.DataBindings.Add(new Binding("Text", DataSet1, "Table_database.Gold", true));
			Label_gold.FlatStyle = FlatStyle.System;
			Label_gold.ForeColor = SystemColors.ControlText;
			Label_gold.Location = new Point(41, 344);
			Label_gold.Margin = new Padding(2);
			Label_gold.Name = "Label_gold";
			Label_gold.Size = new Size(70, 15);
			Label_gold.TabIndex = 8;
			Label_gold.Text = "0";
			Label_gold.TextAlign = ContentAlignment.TopRight;
			Lb_tuideo4.BackColor = Color.Transparent;
			Lb_tuideo4.ContextMenuStrip = ContextMenuStrip_ToTuideo;
			Lb_tuideo4.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Lb_tuideo4.Location = new Point(350, 84);
			Lb_tuideo4.Margin = new Padding(2);
			Lb_tuideo4.Name = "Lb_tuideo4";
			Lb_tuideo4.Size = new Size(32, 32);
			Lb_tuideo4.TabIndex = 128;
			Lb_tuideo4.Text = "50";
			Lb_tuideo4.TextAlign = ContentAlignment.BottomLeft;
			ProgressBarEx_PetHp.BackColorStyle = ProgressBarEx.ColorStyle.Gradient;
			ProgressBarEx_PetHp.BackGradientMode = LinearGradientMode.Vertical;
			ProgressBarEx_PetHp.BackSigmaFocus = 30;
			ProgressBarEx_PetHp.BackSigmaMode = ProgressBarEx.SigmaMode.SigmaBell;
			ProgressBarEx_PetHp.BackSigmaScale = 70;
			ProgressBarEx_PetHp.BarColor1 = Color.Red;
			ProgressBarEx_PetHp.BarColorStyle = ProgressBarEx.ColorStyle.Gradient;
			ProgressBarEx_PetHp.BarGradientMode = LinearGradientMode.Vertical;
			ProgressBarEx_PetHp.BarSigmaFocus = 30;
			ProgressBarEx_PetHp.BarSigmaMode = ProgressBarEx.SigmaMode.SigmaBell;
			ProgressBarEx_PetHp.BarSigmaScale = 70;
			ProgressBarEx_PetHp.Location = new Point(475, 295);
			ProgressBarEx_PetHp.Margin = new Padding(5, 2, 5, 2);
			ProgressBarEx_PetHp.Name = "ProgressBarEx_PetHp";
			ProgressBarEx_PetHp.Size = new Size(70, 15);
			ProgressBarEx_PetHp.TabIndex = 13;
			ProgressBarEx_PetHp.Text = "ProgressBarEx6";
			ProgressBarEx_PetHp.Value = 50;
			Lb_tuideo3.BackColor = Color.Transparent;
			Lb_tuideo3.ContextMenuStrip = ContextMenuStrip_ToTuideo;
			Lb_tuideo3.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Lb_tuideo3.Location = new Point(314, 84);
			Lb_tuideo3.Margin = new Padding(2);
			Lb_tuideo3.Name = "Lb_tuideo3";
			Lb_tuideo3.Size = new Size(32, 32);
			Lb_tuideo3.TabIndex = 127;
			Lb_tuideo3.Text = "50";
			Lb_tuideo3.TextAlign = ContentAlignment.BottomLeft;
			Lb_tuideo2.BackColor = Color.Transparent;
			Lb_tuideo2.ContextMenuStrip = ContextMenuStrip_ToTuideo;
			Lb_tuideo2.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Lb_tuideo2.Location = new Point(278, 84);
			Lb_tuideo2.Margin = new Padding(2);
			Lb_tuideo2.Name = "Lb_tuideo2";
			Lb_tuideo2.Size = new Size(32, 32);
			Lb_tuideo2.TabIndex = 126;
			Lb_tuideo2.Text = "50";
			Lb_tuideo2.TextAlign = ContentAlignment.BottomLeft;
			ProgressBarEx_CharHp.BackColor = SystemColors.Control;
			ProgressBarEx_CharHp.BackColorStyle = ProgressBarEx.ColorStyle.Gradient;
			ProgressBarEx_CharHp.BackGradientMode = LinearGradientMode.Vertical;
			ProgressBarEx_CharHp.BackSigmaFocus = 30;
			ProgressBarEx_CharHp.BackSigmaMode = ProgressBarEx.SigmaMode.SigmaBell;
			ProgressBarEx_CharHp.BackSigmaScale = 70;
			ProgressBarEx_CharHp.BarColor1 = Color.Red;
			ProgressBarEx_CharHp.BarColorStyle = ProgressBarEx.ColorStyle.Gradient;
			ProgressBarEx_CharHp.BarGradientMode = LinearGradientMode.Vertical;
			ProgressBarEx_CharHp.BarSigmaFocus = 30;
			ProgressBarEx_CharHp.BarSigmaMode = ProgressBarEx.SigmaMode.SigmaBell;
			ProgressBarEx_CharHp.BarSigmaScale = 70;
			ProgressBarEx_CharHp.DataBindings.Add(new Binding("Maximum", DataSet1, "Table_database.MaxHp", true));
			ProgressBarEx_CharHp.DataBindings.Add(new Binding("Value", DataSet1, "Table_database.Hp", true));
			ProgressBarEx_CharHp.Location = new Point(41, 295);
			ProgressBarEx_CharHp.Margin = new Padding(5, 2, 5, 2);
			ProgressBarEx_CharHp.Name = "ProgressBarEx_CharHp";
			ProgressBarEx_CharHp.Size = new Size(70, 15);
			ProgressBarEx_CharHp.TabIndex = 0;
			ProgressBarEx_CharHp.Text = "ProgressBarEx1";
			ProgressBarEx_CharHp.Value = 50;
			Lb_tuideo1.BackColor = Color.Transparent;
			Lb_tuideo1.ContextMenuStrip = ContextMenuStrip_ToTuideo;
			Lb_tuideo1.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Lb_tuideo1.Location = new Point(242, 84);
			Lb_tuideo1.Margin = new Padding(2);
			Lb_tuideo1.Name = "Lb_tuideo1";
			Lb_tuideo1.Size = new Size(32, 32);
			Lb_tuideo1.TabIndex = 125;
			Lb_tuideo1.Text = "50";
			Lb_tuideo1.TextAlign = ContentAlignment.BottomLeft;
			Lb_tuido25.AllowDrop = true;
			Lb_tuido25.BackColor = Color.Transparent;
			Lb_tuido25.ContextMenuStrip = ContextMenuStrip_ToTuido;
			Lb_tuido25.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Lb_tuido25.Location = new Point(386, 440);
			Lb_tuido25.Margin = new Padding(2);
			Lb_tuido25.Name = "Lb_tuido25";
			Lb_tuido25.Size = new Size(32, 32);
			Lb_tuido25.TabIndex = 124;
			Lb_tuido25.Text = "50";
			Lb_tuido25.TextAlign = ContentAlignment.BottomLeft;
			Lb_tuido24.AllowDrop = true;
			Lb_tuido24.BackColor = Color.Transparent;
			Lb_tuido24.ContextMenuStrip = ContextMenuStrip_ToTuido;
			Lb_tuido24.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Lb_tuido24.Location = new Point(350, 440);
			Lb_tuido24.Margin = new Padding(2);
			Lb_tuido24.Name = "Lb_tuido24";
			Lb_tuido24.Size = new Size(32, 32);
			Lb_tuido24.TabIndex = 123;
			Lb_tuido24.Text = "50";
			Lb_tuido24.TextAlign = ContentAlignment.BottomLeft;
			Lb_tuido23.AllowDrop = true;
			Lb_tuido23.BackColor = Color.Transparent;
			Lb_tuido23.ContextMenuStrip = ContextMenuStrip_ToTuido;
			Lb_tuido23.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Lb_tuido23.Location = new Point(314, 440);
			Lb_tuido23.Margin = new Padding(2);
			Lb_tuido23.Name = "Lb_tuido23";
			Lb_tuido23.Size = new Size(32, 32);
			Lb_tuido23.TabIndex = 122;
			Lb_tuido23.Text = "50";
			Lb_tuido23.TextAlign = ContentAlignment.BottomLeft;
			Lb_tuido22.AllowDrop = true;
			Lb_tuido22.BackColor = Color.Transparent;
			Lb_tuido22.ContextMenuStrip = ContextMenuStrip_ToTuido;
			Lb_tuido22.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Lb_tuido22.Location = new Point(278, 440);
			Lb_tuido22.Margin = new Padding(2);
			Lb_tuido22.Name = "Lb_tuido22";
			Lb_tuido22.Size = new Size(32, 32);
			Lb_tuido22.TabIndex = 121;
			Lb_tuido22.Text = "50";
			Lb_tuido22.TextAlign = ContentAlignment.BottomLeft;
			Lb_tuido21.AllowDrop = true;
			Lb_tuido21.BackColor = Color.Transparent;
			Lb_tuido21.ContextMenuStrip = ContextMenuStrip_ToTuido;
			Lb_tuido21.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Lb_tuido21.Location = new Point(242, 440);
			Lb_tuido21.Margin = new Padding(2);
			Lb_tuido21.Name = "Lb_tuido21";
			Lb_tuido21.Size = new Size(32, 32);
			Lb_tuido21.TabIndex = 120;
			Lb_tuido21.Text = "50";
			Lb_tuido21.TextAlign = ContentAlignment.BottomLeft;
			Lb_tuido20.AllowDrop = true;
			Lb_tuido20.BackColor = Color.Transparent;
			Lb_tuido20.ContextMenuStrip = ContextMenuStrip_ToTuido;
			Lb_tuido20.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Lb_tuido20.Location = new Point(386, 404);
			Lb_tuido20.Margin = new Padding(2);
			Lb_tuido20.Name = "Lb_tuido20";
			Lb_tuido20.Size = new Size(32, 32);
			Lb_tuido20.TabIndex = 119;
			Lb_tuido20.Text = "50";
			Lb_tuido20.TextAlign = ContentAlignment.BottomLeft;
			Lb_tuido19.AllowDrop = true;
			Lb_tuido19.BackColor = Color.Transparent;
			Lb_tuido19.ContextMenuStrip = ContextMenuStrip_ToTuido;
			Lb_tuido19.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Lb_tuido19.Location = new Point(350, 404);
			Lb_tuido19.Margin = new Padding(2);
			Lb_tuido19.Name = "Lb_tuido19";
			Lb_tuido19.Size = new Size(32, 32);
			Lb_tuido19.TabIndex = 118;
			Lb_tuido19.Text = "50";
			Lb_tuido19.TextAlign = ContentAlignment.BottomLeft;
			Lb_tuido18.AllowDrop = true;
			Lb_tuido18.BackColor = Color.Transparent;
			Lb_tuido18.ContextMenuStrip = ContextMenuStrip_ToTuido;
			Lb_tuido18.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Lb_tuido18.Location = new Point(314, 404);
			Lb_tuido18.Margin = new Padding(2);
			Lb_tuido18.Name = "Lb_tuido18";
			Lb_tuido18.Size = new Size(32, 32);
			Lb_tuido18.TabIndex = 117;
			Lb_tuido18.Text = "50";
			Lb_tuido18.TextAlign = ContentAlignment.BottomLeft;
			ProgressBarEx_CharExp.BackColorStyle = ProgressBarEx.ColorStyle.Gradient;
			ProgressBarEx_CharExp.BackGradientMode = LinearGradientMode.Vertical;
			ProgressBarEx_CharExp.BackSigmaFocus = 30;
			ProgressBarEx_CharExp.BackSigmaMode = ProgressBarEx.SigmaMode.SigmaBell;
			ProgressBarEx_CharExp.BackSigmaScale = 70;
			ProgressBarEx_CharExp.BarColor1 = Color.LimeGreen;
			ProgressBarEx_CharExp.BarColorStyle = ProgressBarEx.ColorStyle.Gradient;
			ProgressBarEx_CharExp.BarGradientMode = LinearGradientMode.Vertical;
			ProgressBarEx_CharExp.BarSigmaFocus = 30;
			ProgressBarEx_CharExp.BarSigmaMode = ProgressBarEx.SigmaMode.SigmaBell;
			ProgressBarEx_CharExp.BarSigmaScale = 70;
			ProgressBarEx_CharExp.BarTextPercen = ProgressBarEx.TextPercen.Percen;
			ProgressBarEx_CharExp.DataBindings.Add(new Binding("Maximum", DataSet1, "Table_database.MaxExp", true));
			ProgressBarEx_CharExp.DataBindings.Add(new Binding("Value", DataSet1, "Table_database.Exp", true));
			ProgressBarEx_CharExp.Location = new Point(41, 328);
			ProgressBarEx_CharExp.Margin = new Padding(5, 2, 5, 2);
			ProgressBarEx_CharExp.Maximum = 683500375;
			ProgressBarEx_CharExp.Name = "ProgressBarEx_CharExp";
			ProgressBarEx_CharExp.Size = new Size(70, 15);
			ProgressBarEx_CharExp.TabIndex = 2;
			ProgressBarEx_CharExp.Text = "ProgressBarEx3";
			ProgressBarEx_CharExp.Value = 683500375;
			Lb_tuido17.AllowDrop = true;
			Lb_tuido17.BackColor = Color.Transparent;
			Lb_tuido17.ContextMenuStrip = ContextMenuStrip_ToTuido;
			Lb_tuido17.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Lb_tuido17.Location = new Point(278, 404);
			Lb_tuido17.Margin = new Padding(2);
			Lb_tuido17.Name = "Lb_tuido17";
			Lb_tuido17.Size = new Size(32, 32);
			Lb_tuido17.TabIndex = 116;
			Lb_tuido17.Text = "50";
			Lb_tuido17.TextAlign = ContentAlignment.BottomLeft;
			Lb_tuido16.AllowDrop = true;
			Lb_tuido16.BackColor = Color.Transparent;
			Lb_tuido16.ContextMenuStrip = ContextMenuStrip_ToTuido;
			Lb_tuido16.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Lb_tuido16.Location = new Point(242, 404);
			Lb_tuido16.Margin = new Padding(2);
			Lb_tuido16.Name = "Lb_tuido16";
			Lb_tuido16.Size = new Size(32, 32);
			Lb_tuido16.TabIndex = 115;
			Lb_tuido16.Text = "50";
			Lb_tuido16.TextAlign = ContentAlignment.BottomLeft;
			ProgressBarEx_CharSp.BackColorStyle = ProgressBarEx.ColorStyle.Gradient;
			ProgressBarEx_CharSp.BackGradientMode = LinearGradientMode.Vertical;
			ProgressBarEx_CharSp.BackSigmaFocus = 30;
			ProgressBarEx_CharSp.BackSigmaMode = ProgressBarEx.SigmaMode.SigmaBell;
			ProgressBarEx_CharSp.BackSigmaScale = 70;
			ProgressBarEx_CharSp.BarColor1 = SystemColors.MenuHighlight;
			ProgressBarEx_CharSp.BarColorStyle = ProgressBarEx.ColorStyle.Gradient;
			ProgressBarEx_CharSp.BarGradientMode = LinearGradientMode.Vertical;
			ProgressBarEx_CharSp.BarSigmaFocus = 30;
			ProgressBarEx_CharSp.BarSigmaMode = ProgressBarEx.SigmaMode.SigmaBell;
			ProgressBarEx_CharSp.BarSigmaScale = 70;
			ProgressBarEx_CharSp.DataBindings.Add(new Binding("Value", DataSet1, "Table_database.Sp", true));
			ProgressBarEx_CharSp.DataBindings.Add(new Binding("Maximum", DataSet1, "Table_database.MaxSp", true));
			ProgressBarEx_CharSp.Location = new Point(41, 312);
			ProgressBarEx_CharSp.Margin = new Padding(5, 2, 5, 2);
			ProgressBarEx_CharSp.Name = "ProgressBarEx_CharSp";
			ProgressBarEx_CharSp.Size = new Size(70, 15);
			ProgressBarEx_CharSp.TabIndex = 1;
			ProgressBarEx_CharSp.Text = "ProgressBarEx2";
			ProgressBarEx_CharSp.Value = 50;
			Lb_tuido15.AllowDrop = true;
			Lb_tuido15.BackColor = Color.Transparent;
			Lb_tuido15.ContextMenuStrip = ContextMenuStrip_ToTuido;
			Lb_tuido15.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Lb_tuido15.Location = new Point(386, 368);
			Lb_tuido15.Margin = new Padding(2);
			Lb_tuido15.Name = "Lb_tuido15";
			Lb_tuido15.Size = new Size(32, 32);
			Lb_tuido15.TabIndex = 114;
			Lb_tuido15.Text = "50";
			Lb_tuido15.TextAlign = ContentAlignment.BottomLeft;
			Lb_tuido14.AllowDrop = true;
			Lb_tuido14.BackColor = Color.Transparent;
			Lb_tuido14.ContextMenuStrip = ContextMenuStrip_ToTuido;
			Lb_tuido14.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Lb_tuido14.Location = new Point(350, 368);
			Lb_tuido14.Margin = new Padding(2);
			Lb_tuido14.Name = "Lb_tuido14";
			Lb_tuido14.Size = new Size(32, 32);
			Lb_tuido14.TabIndex = 113;
			Lb_tuido14.Text = "50";
			Lb_tuido14.TextAlign = ContentAlignment.BottomLeft;
			Lb_tuido1.AllowDrop = true;
			Lb_tuido1.BackColor = Color.Transparent;
			Lb_tuido1.ContextMenuStrip = ContextMenuStrip_ToTuido;
			Lb_tuido1.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Lb_tuido1.Location = new Point(242, 296);
			Lb_tuido1.Margin = new Padding(2);
			Lb_tuido1.Name = "Lb_tuido1";
			Lb_tuido1.Size = new Size(32, 32);
			Lb_tuido1.TabIndex = 100;
			Lb_tuido1.Text = "50";
			Lb_tuido1.TextAlign = ContentAlignment.BottomLeft;
			Lb_tuido13.AllowDrop = true;
			Lb_tuido13.BackColor = Color.Transparent;
			Lb_tuido13.ContextMenuStrip = ContextMenuStrip_ToTuido;
			Lb_tuido13.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Lb_tuido13.Location = new Point(314, 368);
			Lb_tuido13.Margin = new Padding(2);
			Lb_tuido13.Name = "Lb_tuido13";
			Lb_tuido13.Size = new Size(32, 32);
			Lb_tuido13.TabIndex = 112;
			Lb_tuido13.Text = "50";
			Lb_tuido13.TextAlign = ContentAlignment.BottomLeft;
			Lb_tuido2.AllowDrop = true;
			Lb_tuido2.BackColor = Color.Transparent;
			Lb_tuido2.ContextMenuStrip = ContextMenuStrip_ToTuido;
			Lb_tuido2.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Lb_tuido2.Location = new Point(278, 296);
			Lb_tuido2.Margin = new Padding(2);
			Lb_tuido2.Name = "Lb_tuido2";
			Lb_tuido2.Size = new Size(32, 32);
			Lb_tuido2.TabIndex = 101;
			Lb_tuido2.Text = "50";
			Lb_tuido2.TextAlign = ContentAlignment.BottomLeft;
			Lb_tuido12.AllowDrop = true;
			Lb_tuido12.BackColor = Color.Transparent;
			Lb_tuido12.ContextMenuStrip = ContextMenuStrip_ToTuido;
			Lb_tuido12.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Lb_tuido12.Location = new Point(278, 368);
			Lb_tuido12.Margin = new Padding(2);
			Lb_tuido12.Name = "Lb_tuido12";
			Lb_tuido12.Size = new Size(32, 32);
			Lb_tuido12.TabIndex = 111;
			Lb_tuido12.Text = "50";
			Lb_tuido12.TextAlign = ContentAlignment.BottomLeft;
			Lb_tuido3.AllowDrop = true;
			Lb_tuido3.BackColor = Color.Transparent;
			Lb_tuido3.ContextMenuStrip = ContextMenuStrip_ToTuido;
			Lb_tuido3.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Lb_tuido3.Location = new Point(314, 296);
			Lb_tuido3.Margin = new Padding(2);
			Lb_tuido3.Name = "Lb_tuido3";
			Lb_tuido3.Size = new Size(32, 32);
			Lb_tuido3.TabIndex = 102;
			Lb_tuido3.Text = "50";
			Lb_tuido3.TextAlign = ContentAlignment.BottomLeft;
			Lb_tuido11.AllowDrop = true;
			Lb_tuido11.BackColor = Color.Transparent;
			Lb_tuido11.ContextMenuStrip = ContextMenuStrip_ToTuido;
			Lb_tuido11.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Lb_tuido11.Location = new Point(242, 368);
			Lb_tuido11.Margin = new Padding(2);
			Lb_tuido11.Name = "Lb_tuido11";
			Lb_tuido11.Size = new Size(32, 32);
			Lb_tuido11.TabIndex = 110;
			Lb_tuido11.Text = "50";
			Lb_tuido11.TextAlign = ContentAlignment.BottomLeft;
			Lb_tuido4.AllowDrop = true;
			Lb_tuido4.BackColor = Color.Transparent;
			Lb_tuido4.ContextMenuStrip = ContextMenuStrip_ToTuido;
			Lb_tuido4.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Lb_tuido4.Location = new Point(350, 296);
			Lb_tuido4.Margin = new Padding(2);
			Lb_tuido4.Name = "Lb_tuido4";
			Lb_tuido4.Size = new Size(32, 32);
			Lb_tuido4.TabIndex = 103;
			Lb_tuido4.Text = "50";
			Lb_tuido4.TextAlign = ContentAlignment.BottomLeft;
			Lb_tuido10.AllowDrop = true;
			Lb_tuido10.BackColor = Color.Transparent;
			Lb_tuido10.ContextMenuStrip = ContextMenuStrip_ToTuido;
			Lb_tuido10.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Lb_tuido10.Location = new Point(386, 332);
			Lb_tuido10.Margin = new Padding(2);
			Lb_tuido10.Name = "Lb_tuido10";
			Lb_tuido10.Size = new Size(32, 32);
			Lb_tuido10.TabIndex = 109;
			Lb_tuido10.Text = "50";
			Lb_tuido10.TextAlign = ContentAlignment.BottomLeft;
			Lb_tuido5.AllowDrop = true;
			Lb_tuido5.BackColor = Color.Transparent;
			Lb_tuido5.ContextMenuStrip = ContextMenuStrip_ToTuido;
			Lb_tuido5.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Lb_tuido5.Location = new Point(386, 296);
			Lb_tuido5.Margin = new Padding(2);
			Lb_tuido5.Name = "Lb_tuido5";
			Lb_tuido5.Size = new Size(32, 32);
			Lb_tuido5.TabIndex = 104;
			Lb_tuido5.Text = "50";
			Lb_tuido5.TextAlign = ContentAlignment.BottomLeft;
			Lb_tuido9.AllowDrop = true;
			Lb_tuido9.BackColor = Color.Transparent;
			Lb_tuido9.ContextMenuStrip = ContextMenuStrip_ToTuido;
			Lb_tuido9.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Lb_tuido9.Location = new Point(350, 332);
			Lb_tuido9.Margin = new Padding(2);
			Lb_tuido9.Name = "Lb_tuido9";
			Lb_tuido9.Size = new Size(32, 32);
			Lb_tuido9.TabIndex = 108;
			Lb_tuido9.Text = "50";
			Lb_tuido9.TextAlign = ContentAlignment.BottomLeft;
			Lb_tuido6.AllowDrop = true;
			Lb_tuido6.BackColor = Color.Transparent;
			Lb_tuido6.ContextMenuStrip = ContextMenuStrip_ToTuido;
			Lb_tuido6.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Lb_tuido6.Location = new Point(242, 332);
			Lb_tuido6.Margin = new Padding(2);
			Lb_tuido6.Name = "Lb_tuido6";
			Lb_tuido6.Size = new Size(32, 32);
			Lb_tuido6.TabIndex = 105;
			Lb_tuido6.Text = "50";
			Lb_tuido6.TextAlign = ContentAlignment.BottomLeft;
			Lb_tuido8.AllowDrop = true;
			Lb_tuido8.BackColor = Color.Transparent;
			Lb_tuido8.ContextMenuStrip = ContextMenuStrip_ToTuido;
			Lb_tuido8.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Lb_tuido8.Location = new Point(314, 332);
			Lb_tuido8.Margin = new Padding(2);
			Lb_tuido8.Name = "Lb_tuido8";
			Lb_tuido8.Size = new Size(32, 32);
			Lb_tuido8.TabIndex = 107;
			Lb_tuido8.Text = "50";
			Lb_tuido8.TextAlign = ContentAlignment.BottomLeft;
			Lb_tuido7.AllowDrop = true;
			Lb_tuido7.BackColor = Color.Transparent;
			Lb_tuido7.ContextMenuStrip = ContextMenuStrip_ToTuido;
			Lb_tuido7.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Lb_tuido7.Location = new Point(278, 332);
			Lb_tuido7.Margin = new Padding(2);
			Lb_tuido7.Name = "Lb_tuido7";
			Lb_tuido7.Size = new Size(32, 32);
			Lb_tuido7.TabIndex = 106;
			Lb_tuido7.Text = "50";
			Lb_tuido7.TextAlign = ContentAlignment.BottomLeft;
			PictureBox_Pet_photo.Location = new Point(481, 109);
			PictureBox_Pet_photo.Name = "PictureBox_Pet_photo";
			PictureBox_Pet_photo.Size = new Size(134, 148);
			PictureBox_Pet_photo.SizeMode = PictureBoxSizeMode.CenterImage;
			PictureBox_Pet_photo.TabIndex = 158;
			PictureBox_Pet_photo.TabStop = false;
			PictureBox_avatar.BackgroundImageLayout = ImageLayout.Center;
			PictureBox_avatar.Location = new Point(60, 119);
			PictureBox_avatar.Name = "PictureBox_avatar";
			PictureBox_avatar.Size = new Size(110, 120);
			PictureBox_avatar.TabIndex = 191;
			PictureBox_avatar.TabStop = false;
			TabPage_Attack.Controls.Add(Button_BattleInfo);
			TabPage_Attack.Controls.Add(TabControl2);
			TabPage_Attack.Location = new Point(4, 30);
			TabPage_Attack.Name = "TabPage_Attack";
			TabPage_Attack.Padding = new Padding(3);
			TabPage_Attack.Size = new Size(663, 613);
			TabPage_Attack.TabIndex = 1;
			TabPage_Attack.Text = "Chiến đấu";
			TabPage_Attack.UseVisualStyleBackColor = true;
			Button_BattleInfo.Dock = DockStyle.Top;
			Button_BattleInfo.Location = new Point(3, 3);
			Button_BattleInfo.Name = "Button_BattleInfo";
			Button_BattleInfo.Size = new Size(657, 30);
			Button_BattleInfo.TabIndex = 129;
			Button_BattleInfo.Text = "Xem thông tin trận đấu";
			Button_BattleInfo.UseVisualStyleBackColor = true;
			TabControl2.Appearance = TabAppearance.FlatButtons;
			TabControl2.Controls.Add(TabPage3);
			TabControl2.Dock = DockStyle.Fill;
			TabControl2.Location = new Point(3, 3);
			TabControl2.Name = "TabControl2";
			TabControl2.SelectedIndex = 0;
			TabControl2.Size = new Size(657, 607);
			TabControl2.SizeMode = TabSizeMode.FillToRight;
			TabControl2.TabIndex = 33;
			TabPage3.Controls.Add(CheckBox_Pet_ChangeTG);
			TabPage3.Controls.Add(CheckBox_Char_ChangeTG);
			TabPage3.Controls.Add(CheckBox_LeaderDissNotEnough);
			TabPage3.Controls.Add(GroupBox8);
			TabPage3.Controls.Add(Panel_CharSkillTurn);
			TabPage3.Controls.Add(CheckBox_AutoRevival);
			TabPage3.Controls.Add(CheckBox_AutoFlee_Party);
			TabPage3.Controls.Add(CheckBox_AutoFlee_Sp);
			TabPage3.Controls.Add(Panel_PetSkillTurn);
			TabPage3.Controls.Add(Label74);
			TabPage3.Controls.Add(TextBox_ValueSPFlee);
			TabPage3.Location = new Point(4, 25);
			TabPage3.Name = "TabPage3";
			TabPage3.Padding = new Padding(3);
			TabPage3.Size = new Size(649, 578);
			TabPage3.TabIndex = 0;
			TabPage3.Text = "Thiết lập chiến đấu";
			TabPage3.UseVisualStyleBackColor = true;
			CheckBox_Pet_ChangeTG.FlatStyle = FlatStyle.System;
			CheckBox_Pet_ChangeTG.Location = new Point(328, 208);
			CheckBox_Pet_ChangeTG.Margin = new Padding(10, 2, 2, 2);
			CheckBox_Pet_ChangeTG.Name = "CheckBox_Pet_ChangeTG";
			CheckBox_Pet_ChangeTG.Size = new Size(169, 21);
			CheckBox_Pet_ChangeTG.TabIndex = 128;
			CheckBox_Pet_ChangeTG.Text = "Tự thay Ngọc TG cho võ tướng";
			CheckBox_Pet_ChangeTG.UseVisualStyleBackColor = true;
			CheckBox_Char_ChangeTG.FlatStyle = FlatStyle.System;
			CheckBox_Char_ChangeTG.Location = new Point(7, 208);
			CheckBox_Char_ChangeTG.Margin = new Padding(10, 2, 2, 2);
			CheckBox_Char_ChangeTG.Name = "CheckBox_Char_ChangeTG";
			CheckBox_Char_ChangeTG.Size = new Size(169, 21);
			CheckBox_Char_ChangeTG.TabIndex = 127;
			CheckBox_Char_ChangeTG.Text = "Tự thay Ngọc TG cho nhân vật";
			CheckBox_Char_ChangeTG.UseVisualStyleBackColor = true;
			CheckBox_LeaderDissNotEnough.FlatStyle = FlatStyle.System;
			CheckBox_LeaderDissNotEnough.Location = new Point(9, 160);
			CheckBox_LeaderDissNotEnough.Margin = new Padding(9, 2, 2, 2);
			CheckBox_LeaderDissNotEnough.Name = "CheckBox_LeaderDissNotEnough";
			CheckBox_LeaderDissNotEnough.Size = new Size(172, 36);
			CheckBox_LeaderDissNotEnough.TabIndex = 126;
			CheckBox_LeaderDissNotEnough.Text = "Chủ nhóm ngắt kết nỗi khi vào trận không đủ thành viên";
			CheckBox_LeaderDissNotEnough.UseVisualStyleBackColor = true;
			GroupBox8.Controls.Add(Label56);
			GroupBox8.Controls.Add(TextBox_ClickMOD_Delay);
			GroupBox8.Controls.Add(TextBox_ClickMOD);
			GroupBox8.Controls.Add(ListView_monster);
			GroupBox8.Controls.Add(CheckBox_AutoClickNPC);
			GroupBox8.Dock = DockStyle.Bottom;
			GroupBox8.Location = new Point(3, 257);
			GroupBox8.Name = "GroupBox8";
			GroupBox8.Size = new Size(643, 318);
			GroupBox8.TabIndex = 125;
			GroupBox8.TabStop = false;
			GroupBox8.Text = "NPC trong bản đồ";
			Label56.BackColor = Color.FromArgb(240, 240, 240);
			Label56.FlatStyle = FlatStyle.System;
			Label56.Location = new Point(248, 294);
			Label56.Margin = new Padding(0, 2, 0, 2);
			Label56.Name = "Label56";
			Label56.Size = new Size(63, 15);
			Label56.TabIndex = 59;
			Label56.Text = "Delay(giây)";
			TextBox_ClickMOD_Delay.Location = new Point(313, 291);
			TextBox_ClickMOD_Delay.Margin = new Padding(2);
			TextBox_ClickMOD_Delay.Multiline = true;
			TextBox_ClickMOD_Delay.Name = "TextBox_ClickMOD_Delay";
			TextBox_ClickMOD_Delay.RightToLeft = RightToLeft.Yes;
			TextBox_ClickMOD_Delay.Size = new Size(59, 19);
			TextBox_ClickMOD_Delay.TabIndex = 58;
			TextBox_ClickMOD_Delay.Text = "2";
			ListView_monster.Columns.AddRange(new ColumnHeader[8] { ColumnHeader5, ColumnHeader12, ColumnHeader13, ColumnHeader14, ColumnHeader6, ColumnHeader7, ColumnHeader8, ColumnHeader9 });
			ListView_monster.Dock = DockStyle.Top;
			ListView_monster.FullRowSelect = true;
			ListView_monster.GridLines = true;
			ListView_monster.HideSelection = false;
			ListView_monster.Location = new Point(3, 15);
			ListView_monster.MultiSelect = false;
			ListView_monster.Name = "ListView_monster";
			ListView_monster.Size = new Size(637, 270);
			ListView_monster.TabIndex = 55;
			ListView_monster.UseCompatibleStateImageBehavior = false;
			ListView_monster.View = View.Details;
			ColumnHeader5.Text = "ID";
			ColumnHeader5.Width = 30;
			ColumnHeader12.Text = "Tên";
			ColumnHeader12.Width = 120;
			ColumnHeader13.Text = "Cấp";
			ColumnHeader13.Width = 32;
			ColumnHeader14.Text = "Agi";
			ColumnHeader14.Width = 30;
			ColumnHeader6.Text = "X";
			ColumnHeader6.Width = 40;
			ColumnHeader7.Text = "Y";
			ColumnHeader7.Width = 40;
			ColumnHeader8.Text = "Delay";
			ColumnHeader8.Width = 40;
			ColumnHeader9.Text = "kc";
			ColumnHeader9.Width = 40;
			CheckBox_AutoClickNPC.BackColor = Color.FromArgb(240, 240, 240);
			CheckBox_AutoClickNPC.FlatStyle = FlatStyle.System;
			CheckBox_AutoClickNPC.Location = new Point(2, 294);
			CheckBox_AutoClickNPC.Margin = new Padding(2);
			CheckBox_AutoClickNPC.Name = "CheckBox_AutoClickNPC";
			CheckBox_AutoClickNPC.Size = new Size(136, 19);
			CheckBox_AutoClickNPC.TabIndex = 56;
			CheckBox_AutoClickNPC.Text = "Tự tìm quái để đánh";
			CheckBox_AutoClickNPC.TextAlign = ContentAlignment.TopLeft;
			CheckBox_AutoClickNPC.UseVisualStyleBackColor = false;
			Panel_CharSkillTurn.BorderStyle = BorderStyle.FixedSingle;
			Panel_CharSkillTurn.Controls.Add(ComboBox_CharTurnSetting);
			Panel_CharSkillTurn.Controls.Add(ComboBox_CharLocation);
			Panel_CharSkillTurn.Controls.Add(Label_CharTurnCount);
			Panel_CharSkillTurn.Controls.Add(Label53);
			Panel_CharSkillTurn.Controls.Add(Button_CharTurnRemove);
			Panel_CharSkillTurn.Controls.Add(Button_CharTurnAdd);
			Panel_CharSkillTurn.Controls.Add(Label52);
			Panel_CharSkillTurn.Controls.Add(ComboBox_CharSkill);
			Panel_CharSkillTurn.Controls.Add(Label47);
			Panel_CharSkillTurn.Controls.Add(Label48);
			Panel_CharSkillTurn.Location = new Point(7, 7);
			Panel_CharSkillTurn.Margin = new Padding(3, 30, 3, 3);
			Panel_CharSkillTurn.Name = "Panel_CharSkillTurn";
			Panel_CharSkillTurn.Size = new Size(315, 124);
			Panel_CharSkillTurn.TabIndex = 111;
			ComboBox_CharTurnSetting.DropDownStyle = ComboBoxStyle.DropDownList;
			ComboBox_CharTurnSetting.DropDownWidth = 55;
			ComboBox_CharTurnSetting.FormattingEnabled = true;
			ComboBox_CharTurnSetting.Location = new Point(75, 26);
			ComboBox_CharTurnSetting.Margin = new Padding(4, 2, 4, 2);
			ComboBox_CharTurnSetting.Name = "ComboBox_CharTurnSetting";
			ComboBox_CharTurnSetting.Size = new Size(55, 21);
			ComboBox_CharTurnSetting.TabIndex = 117;
			ComboBox_CharLocation.DropDownStyle = ComboBoxStyle.DropDownList;
			ComboBox_CharLocation.FormattingEnabled = true;
			ComboBox_CharLocation.Items.AddRange(new object[22]
			{
				"Lan luot", "F1", "1", "2", "3", "4", "5", "6", "7", "8",
				"9", "10", "11", "12", "13", "14", "15", "16", "17", "18",
				"19", "20"
			});
			ComboBox_CharLocation.Location = new Point(75, 95);
			ComboBox_CharLocation.Margin = new Padding(4, 2, 4, 2);
			ComboBox_CharLocation.Name = "ComboBox_CharLocation";
			ComboBox_CharLocation.Size = new Size(233, 21);
			ComboBox_CharLocation.TabIndex = 48;
			Label_CharTurnCount.AutoSize = true;
			Label_CharTurnCount.DataBindings.Add(new Binding("Text", DataSet1, "Table_Setting.CharTurnCount", true));
			Label_CharTurnCount.Location = new Point(179, 7);
			Label_CharTurnCount.Margin = new Padding(0, 1, 0, 1);
			Label_CharTurnCount.Name = "Label_CharTurnCount";
			Label_CharTurnCount.Size = new Size(13, 13);
			Label_CharTurnCount.TabIndex = 116;
			Label_CharTurnCount.Text = "1";
			Label53.AutoSize = true;
			Label53.Location = new Point(73, 7);
			Label53.Margin = new Padding(0, 1, 0, 1);
			Label53.Name = "Label53";
			Label53.Size = new Size(80, 13);
			Label53.TabIndex = 115;
			Label53.Text = "Số lượt thiết lập";
			Button_CharTurnRemove.Location = new Point(37, 3);
			Button_CharTurnRemove.Margin = new Padding(2);
			Button_CharTurnRemove.Name = "Button_CharTurnRemove";
			Button_CharTurnRemove.Size = new Size(20, 20);
			Button_CharTurnRemove.TabIndex = 114;
			Button_CharTurnRemove.Text = "-";
			Button_CharTurnRemove.UseVisualStyleBackColor = true;
			Button_CharTurnAdd.Location = new Point(10, 3);
			Button_CharTurnAdd.Margin = new Padding(2);
			Button_CharTurnAdd.Name = "Button_CharTurnAdd";
			Button_CharTurnAdd.Size = new Size(20, 20);
			Button_CharTurnAdd.TabIndex = 113;
			Button_CharTurnAdd.Text = "+";
			Button_CharTurnAdd.UseVisualStyleBackColor = true;
			Label52.AutoSize = true;
			Label52.Location = new Point(7, 29);
			Label52.Margin = new Padding(0, 1, 0, 1);
			Label52.Name = "Label52";
			Label52.Size = new Size(28, 13);
			Label52.TabIndex = 70;
			Label52.Text = "Lượt";
			ComboBox_CharSkill.DrawMode = DrawMode.OwnerDrawFixed;
			ComboBox_CharSkill.DropDownHeight = 320;
			ComboBox_CharSkill.DropDownStyle = ComboBoxStyle.DropDownList;
			ComboBox_CharSkill.DropDownWidth = 150;
			ComboBox_CharSkill.FormattingEnabled = true;
			ComboBox_CharSkill.ImageList = ImageList1;
			ComboBox_CharSkill.IntegralHeight = false;
			ComboBox_CharSkill.ItemHeight = 32;
			ComboBox_CharSkill.Items.AddRange(new object[324]
			{
				" Địa diệt kinh đào t", " Đuổi địch", " kết nghĩa vườn đào", "Ám Đao Trảm", "Ám Độc Tiễn", "Ẳnh khí hộ thân", "Bá khí", "Bá ý", "Bạch Hổ", "Bạch Hổ đầu",
				"Bạch Hổ Pháo", "Bạch hồng quán nhật", "Bách Xuyên", "Băng đá", "Băng kiếm", "Băng Lôi", "Băng nha nhẫn", "Băng Phách", "Băng phong", "Băng Phong ",
				"Băng tan", "Băng Trảm", "Băng tường", "BăngThương", "Bão Phong", "Bạo Phong ", "Bắt cóc", "Bát diện hỏa luân", "Bỏ độc", "Bộc Cầm ",
				"Bùa trú", "Cạm bẫy", "Cam Lâm", "CànKhônThiênLôi", "Cát Phổ Trại áp đỉnh", "Cát Phổ Trại bắn đạn", "Cây tinh", "Cây tinh hút máu", "Chân Ám Độc Tiễn", "Chân Ám Nhẫn Trảm",
				"Chấn Ba", "Chấn địa chùy", "Chấn Điện", "Chân Độc Phi Luân", "Chân Đông Quang Chi Bán", "Chấn Hề", "Chân Huyền quang", "Chân Liệt Diễm Chi Quang", "Chân Mê Hoặc Độc Trâm", "Chân Phật Quang Chưởng",
				"Chân Vu Độc", "Chạy trốn", "Chạy trốn thất bại", "Chiếm đọat", "Chính diệm nộ", "Chống địch", "Chung Trạo", "Chuyển Thể", "Cổ Vũ", "Cung tên trúc",
				"Cưỡi ngựa", "Cuồng diêm trảm", "Cuồng Long", "Cuồng Nộ", "Cuồng phong", "Cuồng xà đoạt thủ", "Cửu Kiếm", "Đá lăn", "Đá lớn", "Đại chu thiên",
				"Đại hô", "Đạo sư", "Đẩu Chuyển ", "Đấu vật", "Địa Động", "Địa Khí", "Địa Liệt ", "Địa nha", "Diễm Vô Nhị", "Đình Thủy",
				"Đoàn kết", "Độc Phi Luân", "Động Ngân ", "Đông Quang Chi Bán", "Đồng tâm", "Dùng kế", "Dũng tuyền", "Dương Viêm", "Giải độc", "Giải hộ chủ",
				"Giải hôn", "Giải hỗn loạn", "Giải kết giới", "Giải thoát", "Giải Thuật", "Giải trừ kính", "Giếng Cường Cung", "Giếng/tháp tên", "Gió độc", "Gọi Đại Bạch Hổ",
				"Goi Đại Huyền Vũ", "Gọi đại long", "Gọi đại nham", "Gọi đại phụng", "Gọi đại thủy", "Gọi Tiểu Bạch Hổ", "Goi Tiểu Huyền Vũ", "Gọi tiểu trung long", "Gọi tiểu trung nham", "Gọi tiểu trung phụng",
				"Gọi tiểu trung thủy", "Gọi Trung Bạch Hổ", "Goi Trung Huyền Vũ", "Gọi trung long", "Gọi trung nham", "Gọi trung phụng", "Gọi trung thủy", "Hắc Ám Liên Trảm", "Hắc Toàn Trảm", "Hàn băng quán",
				"Hào Hoả", "Hộ chủ", "Hỏa cầu", "Hỏa Hộ Thân ", "Hỏa Khí", "Hỏa kiếm", "Hỏa Long", "Hỏa luân", "Hỏa phụng thiên", "Hỏa tiễn",
				"Hoạch lí phản", "HóaHuyếtHòanHồn", "Hoàn Phong ", "Hoàng Thổ", "Hồi mã thương", "Hồi Quang Phản Chiếu", "Hội tâm nhất kích", "Hỗn loạn", "Hôn mê", "Hồn Phủ",
				"Hồng liên hỏa", "Hồng thủy", "Hút Hồn", "Hữu long trảo", "HữuBạch Hổ trảo", "Huyễn Ảnh", "Huyền Kích", "Huyễn quang", "Huyền Vũ", "kết giới",
				"Khô Lâu Đầu Trích", "Khu Tượng", "Kiếm tuyệt vọng", "Kim Tệ Công Kích", "Kính", "Kỵ Binh", "Lẫn tránh", "Lầu tên", "Liềm Trảm", "Liên kích",
				"Liệt Diễm Chi Quang", "Liệt hỏa", "Liệt Phong", "Liệt Trảm ", "LiêuNguyênHỏa", "Linh Kính", "Linh quang ẩn hiện", "Loạn kích", "Loạn Nha", "Lôi Minh",
				"Lôi mộc", "Long đầu", "Long trời lỡ đất", "Lục Băng Vũ", "Lực bạt sơn hề", "Ma Thuật", "Mãnh ngưu kích", "Mê Hoặc Độc Trâm", "Miêu Thủy", "Ném đá",
				"Ngũ Lôi ", "NgưngKhí HộThân", "Người làm", "Nguyên khí", "Nham diệp phiêu kiếm", "Nham quái", "Nhân giả vô địch", "Nhân giả vô địch", "Nhẫn Trảm", "Nhân vong tống táng ",
				"Nhất Kích", "Nhất Thiểm", "Nhị Đoạn Thức", "Nước Lạc kết tụ", "Phá hủy ", "Phá không thiểm", "Phần Dã", "Phãn đoàn bộ võng", "Phật Quang Chưởng", "Phi Kiếm",
				"Phi sa tẩu thạch", "Phiêu Diêu Lưu Phong", "Phong Chi", "Phong cuốn tàn vân", "Phong hỏa luân", "Phong Khí", "Phòng ngự", "Phong Thần", "Phúc thần", "Phụng hoàng",
				"Quang Chi kính", "Quang Dư Thuật", "Quang Mâu Thuật", "Quang toc dau trich", "Quang Tuyền Quán Chú", "Quy Thúc", "Quyen khuynh van ly", "Sách động", "Siêu Quang Bá", "Sơn Cương",
				"Sóng cuồng", "Sư Phệ", "Sương Quyền", "Tả Bạch Hổ trảo", "Tạ long trảo", "Tâm nhãn", "Tam sát", "Tam vị chân hỏa", "Tạp Thúc Quang Đạn", "Thả lưới",
				"Thả lưới thành công", "Thác đao pháp áo ngh", "Thái Sơn áp đỉnh", "Thâm Uyên", "Thần Ly", "Thần nộ thiên tru", "Thân Thuật", "Thần xui xẻo", "Thành công Phãn đoàn", "Thanh long",
				"Thanh lưu", "Thành Môn ", "ThánhLinh thuật", "Thập Khí", "Tháp Thần Tiễn", "Thiên Băng Vũ", "Thiên tru thái bình ", "ThiênThần thuẫn", "Thiết Pháo", "Thiệu Lâm",
				"Thổ Băng", "Thụ Tinh ", "Thuật ẩn mình", "Thuật chế tạo", "Thuật đào khoáng", "Thuật đào sâu", "Thuật đào tẩu", "Thuật dò xét", "Thuật đúc luyện ", "Thuật giao dịch",
				"Thuật hồi ma", "Thuật hồi sinh", "Thuật luyện đơn", "Thuật mua bán", "Thuật mưa đá", "Thuật ngự phong", "Thuật nước ngập", "Thuật phân thân", "Thuật phóng đại", "Thuật phóng hỏa",
				"Thuật thu nhỏ", "Thuật trị liệu", "Thuật trinh thám", "Thuốc nổ", "Thương hại phản đàn", "Thương thiên đã chết", "Thủy Khí", "Thủy thần", "Tiên khí hộ thân", "Tiên khiếu",
				"Tiễn thầnỎĐịnh quân", "Tiễn Vũ ", "Tiếp chiêu", "Tinh luyện", "Tinh Pháo", "Tịnh toạ", "Toàn hồi ma thuật", "Toàn trị liệu thuật", "Tổn huyết", "Trạng Giải",
				"Trạng thái giải trừ", "Trí thủ", "Triệu gọi", "Trúng độc mất máu", "Trùng quyền", "Từ Ẩn Kiếm", "Tứ độc thủ", "Tứ nhân hỗn lọan", "Tứ nhân trạng giải", "Tường Đinh",
				"Tuyền Phong", "Vạn Độc Xuyên Tâm", "Vạn mã phi đằng", "Vẫn tinh lạc", "Vật phẩm", "Vô Hình ", "Vô Tưởng", "Vũ điệu nóng bỏng", "Vu Độc", "Vu Độc Oa Oa",
				"Vung tram", "Vương Sát", "Xạ Tiễn", "Xe dao", "Xe đầu trâu", "Xe lớn chở đá", "Xe ném đá", "Xe nô", "Xe Vận Cung", "Xe xung phong",
				"Xeđao tinhluyện gang", "Xích Long Cự", "Xung Phong", "Yêu Thuật Kích Hoa"
			});
			ComboBox_CharSkill.Location = new Point(75, 53);
			ComboBox_CharSkill.Margin = new Padding(4, 2, 4, 2);
			ComboBox_CharSkill.Name = "ComboBox_CharSkill";
			ComboBox_CharSkill.Size = new Size(234, 38);
			ComboBox_CharSkill.TabIndex = 47;
			Label47.AutoSize = true;
			Label47.Location = new Point(7, 57);
			Label47.Margin = new Padding(4, 0, 4, 0);
			Label47.Name = "Label47";
			Label47.Size = new Size(46, 13);
			Label47.TabIndex = 49;
			Label47.Text = "Kỹ năng";
			Label48.AutoSize = true;
			Label48.Location = new Point(7, 98);
			Label48.Margin = new Padding(4, 0, 4, 0);
			Label48.Name = "Label48";
			Label48.Size = new Size(27, 13);
			Label48.TabIndex = 50;
			Label48.Text = "Vị trí";
			CheckBox_AutoRevival.FlatStyle = FlatStyle.System;
			CheckBox_AutoRevival.Location = new Point(7, 136);
			CheckBox_AutoRevival.Margin = new Padding(9, 2, 2, 2);
			CheckBox_AutoRevival.Name = "CheckBox_AutoRevival";
			CheckBox_AutoRevival.Size = new Size(172, 20);
			CheckBox_AutoRevival.TabIndex = 124;
			CheckBox_AutoRevival.Text = "Tự động hồi sinh";
			CheckBox_AutoRevival.UseVisualStyleBackColor = true;
			CheckBox_AutoFlee_Party.FlatStyle = FlatStyle.System;
			CheckBox_AutoFlee_Party.Location = new Point(328, 160);
			CheckBox_AutoFlee_Party.Margin = new Padding(9, 2, 2, 2);
			CheckBox_AutoFlee_Party.Name = "CheckBox_AutoFlee_Party";
			CheckBox_AutoFlee_Party.Size = new Size(172, 36);
			CheckBox_AutoFlee_Party.TabIndex = 120;
			CheckBox_AutoFlee_Party.Text = "Chạy trốn khi 1 mình hoặc không đủ đội";
			CheckBox_AutoFlee_Party.UseVisualStyleBackColor = true;
			CheckBox_AutoFlee_Sp.FlatStyle = FlatStyle.System;
			CheckBox_AutoFlee_Sp.Location = new Point(328, 136);
			CheckBox_AutoFlee_Sp.Margin = new Padding(9, 2, 2, 2);
			CheckBox_AutoFlee_Sp.Name = "CheckBox_AutoFlee_Sp";
			CheckBox_AutoFlee_Sp.Size = new Size(158, 20);
			CheckBox_AutoFlee_Sp.TabIndex = 121;
			CheckBox_AutoFlee_Sp.Text = "Chạy trốn khi SP ai đó <";
			CheckBox_AutoFlee_Sp.UseVisualStyleBackColor = true;
			Panel_PetSkillTurn.BorderStyle = BorderStyle.FixedSingle;
			Panel_PetSkillTurn.Controls.Add(Label_PetTurnCount);
			Panel_PetSkillTurn.Controls.Add(Label62);
			Panel_PetSkillTurn.Controls.Add(Button_PetTurnRemove);
			Panel_PetSkillTurn.Controls.Add(Button_PetTurnAdd);
			Panel_PetSkillTurn.Controls.Add(ComboBox_PetTurnSetting);
			Panel_PetSkillTurn.Controls.Add(Label54);
			Panel_PetSkillTurn.Controls.Add(ComboBox_PetSkill);
			Panel_PetSkillTurn.Controls.Add(ComboBox_PetLocation);
			Panel_PetSkillTurn.Controls.Add(Label49);
			Panel_PetSkillTurn.Controls.Add(Label50);
			Panel_PetSkillTurn.Location = new Point(328, 7);
			Panel_PetSkillTurn.Margin = new Padding(3, 30, 3, 3);
			Panel_PetSkillTurn.Name = "Panel_PetSkillTurn";
			Panel_PetSkillTurn.Size = new Size(315, 124);
			Panel_PetSkillTurn.TabIndex = 112;
			Label_PetTurnCount.AutoSize = true;
			Label_PetTurnCount.DataBindings.Add(new Binding("Text", DataSet1, "Table_Setting.PetTurnCount", true));
			Label_PetTurnCount.Location = new Point(177, 6);
			Label_PetTurnCount.Margin = new Padding(0, 1, 0, 1);
			Label_PetTurnCount.Name = "Label_PetTurnCount";
			Label_PetTurnCount.Size = new Size(13, 13);
			Label_PetTurnCount.TabIndex = 123;
			Label_PetTurnCount.Text = "1";
			Label62.AutoSize = true;
			Label62.Location = new Point(71, 6);
			Label62.Margin = new Padding(0, 1, 0, 1);
			Label62.Name = "Label62";
			Label62.Size = new Size(80, 13);
			Label62.TabIndex = 122;
			Label62.Text = "Số lượt thiết lập";
			Button_PetTurnRemove.Location = new Point(35, 2);
			Button_PetTurnRemove.Margin = new Padding(2);
			Button_PetTurnRemove.Name = "Button_PetTurnRemove";
			Button_PetTurnRemove.Size = new Size(20, 20);
			Button_PetTurnRemove.TabIndex = 121;
			Button_PetTurnRemove.Text = "-";
			Button_PetTurnRemove.UseVisualStyleBackColor = true;
			Button_PetTurnAdd.Location = new Point(8, 2);
			Button_PetTurnAdd.Margin = new Padding(2);
			Button_PetTurnAdd.Name = "Button_PetTurnAdd";
			Button_PetTurnAdd.Size = new Size(20, 20);
			Button_PetTurnAdd.TabIndex = 120;
			Button_PetTurnAdd.Text = "+";
			Button_PetTurnAdd.UseVisualStyleBackColor = true;
			ComboBox_PetTurnSetting.DropDownStyle = ComboBoxStyle.DropDownList;
			ComboBox_PetTurnSetting.DropDownWidth = 55;
			ComboBox_PetTurnSetting.FormattingEnabled = true;
			ComboBox_PetTurnSetting.Location = new Point(73, 25);
			ComboBox_PetTurnSetting.Margin = new Padding(4, 2, 4, 2);
			ComboBox_PetTurnSetting.Name = "ComboBox_PetTurnSetting";
			ComboBox_PetTurnSetting.Size = new Size(55, 21);
			ComboBox_PetTurnSetting.TabIndex = 119;
			Label54.AutoSize = true;
			Label54.Location = new Point(5, 28);
			Label54.Margin = new Padding(0, 1, 0, 1);
			Label54.Name = "Label54";
			Label54.Size = new Size(28, 13);
			Label54.TabIndex = 118;
			Label54.Text = "Lượt";
			ComboBox_PetSkill.DrawMode = DrawMode.OwnerDrawFixed;
			ComboBox_PetSkill.DropDownHeight = 320;
			ComboBox_PetSkill.DropDownStyle = ComboBoxStyle.DropDownList;
			ComboBox_PetSkill.DropDownWidth = 150;
			ComboBox_PetSkill.FormattingEnabled = true;
			ComboBox_PetSkill.ImageList = ImageList1;
			ComboBox_PetSkill.IntegralHeight = false;
			ComboBox_PetSkill.ItemHeight = 32;
			ComboBox_PetSkill.Items.AddRange(new object[324]
			{
				" Địa diệt kinh đào t", " Đuổi địch", " kết nghĩa vườn đào", "Ám Đao Trảm", "Ám Độc Tiễn", "Ẳnh khí hộ thân", "Bá khí", "Bá ý", "Bạch Hổ", "Bạch Hổ đầu",
				"Bạch Hổ Pháo", "Bạch hồng quán nhật", "Bách Xuyên", "Băng đá", "Băng kiếm", "Băng Lôi", "Băng nha nhẫn", "Băng Phách", "Băng phong", "Băng Phong ",
				"Băng tan", "Băng Trảm", "Băng tường", "BăngThương", "Bão Phong", "Bạo Phong ", "Bắt cóc", "Bát diện hỏa luân", "Bỏ độc", "Bộc Cầm ",
				"Bùa trú", "Cạm bẫy", "Cam Lâm", "CànKhônThiênLôi", "Cát Phổ Trại áp đỉnh", "Cát Phổ Trại bắn đạn", "Cây tinh", "Cây tinh hút máu", "Chân Ám Độc Tiễn", "Chân Ám Nhẫn Trảm",
				"Chấn Ba", "Chấn địa chùy", "Chấn Điện", "Chân Độc Phi Luân", "Chân Đông Quang Chi Bán", "Chấn Hề", "Chân Huyền quang", "Chân Liệt Diễm Chi Quang", "Chân Mê Hoặc Độc Trâm", "Chân Phật Quang Chưởng",
				"Chân Vu Độc", "Chạy trốn", "Chạy trốn thất bại", "Chiếm đọat", "Chính diệm nộ", "Chống địch", "Chung Trạo", "Chuyển Thể", "Cổ Vũ", "Cung tên trúc",
				"Cưỡi ngựa", "Cuồng diêm trảm", "Cuồng Long", "Cuồng Nộ", "Cuồng phong", "Cuồng xà đoạt thủ", "Cửu Kiếm", "Đá lăn", "Đá lớn", "Đại chu thiên",
				"Đại hô", "Đạo sư", "Đẩu Chuyển ", "Đấu vật", "Địa Động", "Địa Khí", "Địa Liệt ", "Địa nha", "Diễm Vô Nhị", "Đình Thủy",
				"Đoàn kết", "Độc Phi Luân", "Động Ngân ", "Đông Quang Chi Bán", "Đồng tâm", "Dùng kế", "Dũng tuyền", "Dương Viêm", "Giải độc", "Giải hộ chủ",
				"Giải hôn", "Giải hỗn loạn", "Giải kết giới", "Giải thoát", "Giải Thuật", "Giải trừ kính", "Giếng Cường Cung", "Giếng/tháp tên", "Gió độc", "Gọi Đại Bạch Hổ",
				"Goi Đại Huyền Vũ", "Gọi đại long", "Gọi đại nham", "Gọi đại phụng", "Gọi đại thủy", "Gọi Tiểu Bạch Hổ", "Goi Tiểu Huyền Vũ", "Gọi tiểu trung long", "Gọi tiểu trung nham", "Gọi tiểu trung phụng",
				"Gọi tiểu trung thủy", "Gọi Trung Bạch Hổ", "Goi Trung Huyền Vũ", "Gọi trung long", "Gọi trung nham", "Gọi trung phụng", "Gọi trung thủy", "Hắc Ám Liên Trảm", "Hắc Toàn Trảm", "Hàn băng quán",
				"Hào Hoả", "Hộ chủ", "Hỏa cầu", "Hỏa Hộ Thân ", "Hỏa Khí", "Hỏa kiếm", "Hỏa Long", "Hỏa luân", "Hỏa phụng thiên", "Hỏa tiễn",
				"Hoạch lí phản", "HóaHuyếtHòanHồn", "Hoàn Phong ", "Hoàng Thổ", "Hồi mã thương", "Hồi Quang Phản Chiếu", "Hội tâm nhất kích", "Hỗn loạn", "Hôn mê", "Hồn Phủ",
				"Hồng liên hỏa", "Hồng thủy", "Hút Hồn", "Hữu long trảo", "HữuBạch Hổ trảo", "Huyễn Ảnh", "Huyền Kích", "Huyễn quang", "Huyền Vũ", "kết giới",
				"Khô Lâu Đầu Trích", "Khu Tượng", "Kiếm tuyệt vọng", "Kim Tệ Công Kích", "Kính", "Kỵ Binh", "Lẫn tránh", "Lầu tên", "Liềm Trảm", "Liên kích",
				"Liệt Diễm Chi Quang", "Liệt hỏa", "Liệt Phong", "Liệt Trảm ", "LiêuNguyênHỏa", "Linh Kính", "Linh quang ẩn hiện", "Loạn kích", "Loạn Nha", "Lôi Minh",
				"Lôi mộc", "Long đầu", "Long trời lỡ đất", "Lục Băng Vũ", "Lực bạt sơn hề", "Ma Thuật", "Mãnh ngưu kích", "Mê Hoặc Độc Trâm", "Miêu Thủy", "Ném đá",
				"Ngũ Lôi ", "NgưngKhí HộThân", "Người làm", "Nguyên khí", "Nham diệp phiêu kiếm", "Nham quái", "Nhân giả vô địch", "Nhân giả vô địch", "Nhẫn Trảm", "Nhân vong tống táng ",
				"Nhất Kích", "Nhất Thiểm", "Nhị Đoạn Thức", "Nước Lạc kết tụ", "Phá hủy ", "Phá không thiểm", "Phần Dã", "Phãn đoàn bộ võng", "Phật Quang Chưởng", "Phi Kiếm",
				"Phi sa tẩu thạch", "Phiêu Diêu Lưu Phong", "Phong Chi", "Phong cuốn tàn vân", "Phong hỏa luân", "Phong Khí", "Phòng ngự", "Phong Thần", "Phúc thần", "Phụng hoàng",
				"Quang Chi kính", "Quang Dư Thuật", "Quang Mâu Thuật", "Quang toc dau trich", "Quang Tuyền Quán Chú", "Quy Thúc", "Quyen khuynh van ly", "Sách động", "Siêu Quang Bá", "Sơn Cương",
				"Sóng cuồng", "Sư Phệ", "Sương Quyền", "Tả Bạch Hổ trảo", "Tạ long trảo", "Tâm nhãn", "Tam sát", "Tam vị chân hỏa", "Tạp Thúc Quang Đạn", "Thả lưới",
				"Thả lưới thành công", "Thác đao pháp áo ngh", "Thái Sơn áp đỉnh", "Thâm Uyên", "Thần Ly", "Thần nộ thiên tru", "Thân Thuật", "Thần xui xẻo", "Thành công Phãn đoàn", "Thanh long",
				"Thanh lưu", "Thành Môn ", "ThánhLinh thuật", "Thập Khí", "Tháp Thần Tiễn", "Thiên Băng Vũ", "Thiên tru thái bình ", "ThiênThần thuẫn", "Thiết Pháo", "Thiệu Lâm",
				"Thổ Băng", "Thụ Tinh ", "Thuật ẩn mình", "Thuật chế tạo", "Thuật đào khoáng", "Thuật đào sâu", "Thuật đào tẩu", "Thuật dò xét", "Thuật đúc luyện ", "Thuật giao dịch",
				"Thuật hồi ma", "Thuật hồi sinh", "Thuật luyện đơn", "Thuật mua bán", "Thuật mưa đá", "Thuật ngự phong", "Thuật nước ngập", "Thuật phân thân", "Thuật phóng đại", "Thuật phóng hỏa",
				"Thuật thu nhỏ", "Thuật trị liệu", "Thuật trinh thám", "Thuốc nổ", "Thương hại phản đàn", "Thương thiên đã chết", "Thủy Khí", "Thủy thần", "Tiên khí hộ thân", "Tiên khiếu",
				"Tiễn thầnỎĐịnh quân", "Tiễn Vũ ", "Tiếp chiêu", "Tinh luyện", "Tinh Pháo", "Tịnh toạ", "Toàn hồi ma thuật", "Toàn trị liệu thuật", "Tổn huyết", "Trạng Giải",
				"Trạng thái giải trừ", "Trí thủ", "Triệu gọi", "Trúng độc mất máu", "Trùng quyền", "Từ Ẩn Kiếm", "Tứ độc thủ", "Tứ nhân hỗn lọan", "Tứ nhân trạng giải", "Tường Đinh",
				"Tuyền Phong", "Vạn Độc Xuyên Tâm", "Vạn mã phi đằng", "Vẫn tinh lạc", "Vật phẩm", "Vô Hình ", "Vô Tưởng", "Vũ điệu nóng bỏng", "Vu Độc", "Vu Độc Oa Oa",
				"Vung tram", "Vương Sát", "Xạ Tiễn", "Xe dao", "Xe đầu trâu", "Xe lớn chở đá", "Xe ném đá", "Xe nô", "Xe Vận Cung", "Xe xung phong",
				"Xeđao tinhluyện gang", "Xích Long Cự", "Xung Phong", "Yêu Thuật Kích Hoa"
			});
			ComboBox_PetSkill.Location = new Point(73, 52);
			ComboBox_PetSkill.Margin = new Padding(4, 2, 4, 2);
			ComboBox_PetSkill.Name = "ComboBox_PetSkill";
			ComboBox_PetSkill.Size = new Size(236, 38);
			ComboBox_PetSkill.TabIndex = 47;
			ComboBox_PetLocation.DropDownStyle = ComboBoxStyle.DropDownList;
			ComboBox_PetLocation.FormattingEnabled = true;
			ComboBox_PetLocation.Items.AddRange(new object[22]
			{
				"Lan luot", "F1", "1", "2", "3", "4", "5", "6", "7", "8",
				"9", "10", "11", "12", "13", "14", "15", "16", "17", "18",
				"19", "20"
			});
			ComboBox_PetLocation.Location = new Point(73, 95);
			ComboBox_PetLocation.Margin = new Padding(4, 2, 4, 2);
			ComboBox_PetLocation.Name = "ComboBox_PetLocation";
			ComboBox_PetLocation.Size = new Size(236, 21);
			ComboBox_PetLocation.TabIndex = 48;
			Label49.AutoSize = true;
			Label49.Location = new Point(5, 56);
			Label49.Margin = new Padding(4, 0, 4, 0);
			Label49.Name = "Label49";
			Label49.Size = new Size(46, 13);
			Label49.TabIndex = 49;
			Label49.Text = "Kỹ năng";
			Label50.AutoSize = true;
			Label50.Location = new Point(5, 98);
			Label50.Margin = new Padding(4, 0, 4, 0);
			Label50.Name = "Label50";
			Label50.Size = new Size(27, 13);
			Label50.TabIndex = 50;
			Label50.Text = "Vị trí";
			Label74.AutoSize = true;
			Label74.Location = new Point(511, 138);
			Label74.Margin = new Padding(0, 1, 0, 1);
			Label74.Name = "Label74";
			Label74.Size = new Size(16, 13);
			Label74.TabIndex = 123;
			Label74.Text = "%";
			TextBox_ValueSPFlee.Location = new Point(490, 135);
			TextBox_ValueSPFlee.Margin = new Padding(2);
			TextBox_ValueSPFlee.MaxLength = 2;
			TextBox_ValueSPFlee.Name = "TextBox_ValueSPFlee";
			TextBox_ValueSPFlee.Size = new Size(20, 19);
			TextBox_ValueSPFlee.TabIndex = 122;
			TextBox_ValueSPFlee.Text = "30";
			TextBox_ValueSPFlee.TextAlign = HorizontalAlignment.Right;
			TabPage_Quest.Controls.Add(Button2);
			TabPage_Quest.Controls.Add(Button_Func);
			TabPage_Quest.Controls.Add(Button_Quest_Refresh);
			TabPage_Quest.Controls.Add(Button_StartAutoQuest);
			TabPage_Quest.Controls.Add(ListView_Quest);
			TabPage_Quest.Controls.Add(ComboBox_Quest);
			TabPage_Quest.Controls.Add(RichTextBox_hienthiquest);
			TabPage_Quest.Controls.Add(DataGridView1);
			TabPage_Quest.Controls.Add(RtbQuest);
			TabPage_Quest.Location = new Point(4, 30);
			TabPage_Quest.Name = "TabPage_Quest";
			TabPage_Quest.Padding = new Padding(3);
			TabPage_Quest.Size = new Size(663, 613);
			TabPage_Quest.TabIndex = 2;
			TabPage_Quest.Text = "Nhiệm vụ";
			TabPage_Quest.UseVisualStyleBackColor = true;
			Button2.FlatStyle = FlatStyle.System;
			Button2.Location = new Point(254, 5);
			Button2.Margin = new Padding(2);
			Button2.Name = "Button2";
			Button2.Size = new Size(179, 20);
			Button2.TabIndex = 122;
			Button2.Text = "Check 8 Q Cự Thú";
			Button2.UseVisualStyleBackColor = true;
			Button_Func.FlatStyle = FlatStyle.System;
			Button_Func.Location = new Point(7, 5);
			Button_Func.Margin = new Padding(2);
			Button_Func.Name = "Button_Func";
			Button_Func.Size = new Size(242, 20);
			Button_Func.TabIndex = 66;
			Button_Func.Text = "Các hàm có thể sử dụng";
			Button_Func.UseVisualStyleBackColor = true;
			Button_Quest_Refresh.FlatStyle = FlatStyle.System;
			Button_Quest_Refresh.Location = new Point(437, 5);
			Button_Quest_Refresh.Margin = new Padding(2);
			Button_Quest_Refresh.Name = "Button_Quest_Refresh";
			Button_Quest_Refresh.Size = new Size(217, 20);
			Button_Quest_Refresh.TabIndex = 121;
			Button_Quest_Refresh.Text = "Làm mới nhật ký nhiệm vụ";
			Button_Quest_Refresh.UseVisualStyleBackColor = true;
			Button_StartAutoQuest.FlatStyle = FlatStyle.System;
			Button_StartAutoQuest.Location = new Point(254, 330);
			Button_StartAutoQuest.Margin = new Padding(2);
			Button_StartAutoQuest.Name = "Button_StartAutoQuest";
			Button_StartAutoQuest.Size = new Size(404, 20);
			Button_StartAutoQuest.TabIndex = 61;
			Button_StartAutoQuest.Text = "Bắt đầu";
			Button_StartAutoQuest.UseVisualStyleBackColor = true;
			ComboBox_Quest.FlatStyle = FlatStyle.System;
			ComboBox_Quest.FormattingEnabled = true;
			ComboBox_Quest.Location = new Point(7, 330);
			ComboBox_Quest.Margin = new Padding(2, 8, 2, 2);
			ComboBox_Quest.Name = "ComboBox_Quest";
			ComboBox_Quest.Size = new Size(242, 21);
			ComboBox_Quest.TabIndex = 1;
			RichTextBox_hienthiquest.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			RichTextBox_hienthiquest.Location = new Point(7, 355);
			RichTextBox_hienthiquest.Margin = new Padding(2);
			RichTextBox_hienthiquest.Name = "RichTextBox_hienthiquest";
			RichTextBox_hienthiquest.ReadOnly = true;
			RichTextBox_hienthiquest.Size = new Size(242, 253);
			RichTextBox_hienthiquest.TabIndex = 62;
			RichTextBox_hienthiquest.Text = "";
			DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			DataGridView1.Columns.AddRange(Column_Quest_check, Column_Quest_Func, Column_Quest_Id, Column_Quest_Info);
			DataGridView1.Location = new Point(254, 355);
			DataGridView1.Name = "DataGridView1";
			DataGridView1.RowHeadersWidth = 25;
			DataGridView1.Size = new Size(403, 253);
			DataGridView1.TabIndex = 65;
			Column_Quest_check.HeaderText = "";
			Column_Quest_check.MinimumWidth = 20;
			Column_Quest_check.Name = "Column_Quest_check";
			Column_Quest_check.Width = 20;
			Column_Quest_Func.HeaderText = "Hàm";
			Column_Quest_Func.Name = "Column_Quest_Func";
			Column_Quest_Func.Width = 50;
			Column_Quest_Id.HeaderText = "Id";
			Column_Quest_Id.Name = "Column_Quest_Id";
			Column_Quest_Id.Width = 50;
			Column_Quest_Info.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			Column_Quest_Info.HeaderText = "Thông tin";
			Column_Quest_Info.Name = "Column_Quest_Info";
			RtbQuest.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			RtbQuest.Location = new Point(7, 29);
			RtbQuest.Margin = new Padding(2);
			RtbQuest.Name = "RtbQuest";
			RtbQuest.Size = new Size(242, 296);
			RtbQuest.TabIndex = 63;
			RtbQuest.Text = "";
			TabPage_Warp.Controls.Add(TextBox_idWarp);
			TabPage_Warp.Controls.Add(TreeView1);
			TabPage_Warp.Controls.Add(Button_warp);
			TabPage_Warp.Location = new Point(4, 30);
			TabPage_Warp.Name = "TabPage_Warp";
			TabPage_Warp.Padding = new Padding(3);
			TabPage_Warp.Size = new Size(663, 613);
			TabPage_Warp.TabIndex = 3;
			TabPage_Warp.Text = "Dịch chuyển";
			TabPage_Warp.UseVisualStyleBackColor = true;
			TextBox_idWarp.Location = new Point(489, 587);
			TextBox_idWarp.Margin = new Padding(2);
			TextBox_idWarp.MaxLength = 5;
			TextBox_idWarp.Multiline = true;
			TextBox_idWarp.Name = "TextBox_idWarp";
			TextBox_idWarp.Size = new Size(55, 19);
			TextBox_idWarp.TabIndex = 23;
			TextBox_idWarp.Text = "0";
			TreeView1.ContextMenuStrip = ContextMenuStrip_Warp;
			TreeView1.Dock = DockStyle.Top;
			TreeView1.Location = new Point(3, 3);
			TreeView1.Margin = new Padding(2);
			TreeView1.Name = "TreeView1";
			TreeView1.Size = new Size(657, 579);
			TreeView1.TabIndex = 12;
			Button_warp.FlatStyle = FlatStyle.System;
			Button_warp.Location = new Point(548, 586);
			Button_warp.Margin = new Padding(2);
			Button_warp.Name = "Button_warp";
			Button_warp.Size = new Size(110, 20);
			Button_warp.TabIndex = 13;
			Button_warp.Text = "Dịch chuyển";
			Button_warp.UseVisualStyleBackColor = true;
			TabPage_Players.Controls.Add(Label_PlayerCount);
			TabPage_Players.Location = new Point(4, 30);
			TabPage_Players.Name = "TabPage_Players";
			TabPage_Players.Padding = new Padding(3);
			TabPage_Players.Size = new Size(663, 613);
			TabPage_Players.TabIndex = 4;
			TabPage_Players.Text = "Người chơi";
			TabPage_Players.UseVisualStyleBackColor = true;
			Label_PlayerCount.DataBindings.Add(new Binding("Text", DataSet1, "Table_database.PlayerOnline", true));
			Label_PlayerCount.Location = new Point(464, 594);
			Label_PlayerCount.Margin = new Padding(0, 1, 0, 1);
			Label_PlayerCount.Name = "Label_PlayerCount";
			Label_PlayerCount.Size = new Size(196, 13);
			Label_PlayerCount.TabIndex = 55;
			Label_PlayerCount.Text = "0";
			Label_PlayerCount.TextAlign = ContentAlignment.MiddleRight;
			Label_PlayerCount.Visible = false;
			TabPage_Setting.Controls.Add(TabControl1);
			TabPage_Setting.Location = new Point(4, 30);
			TabPage_Setting.Name = "TabPage_Setting";
			TabPage_Setting.Padding = new Padding(3);
			TabPage_Setting.Size = new Size(663, 613);
			TabPage_Setting.TabIndex = 5;
			TabPage_Setting.Text = "Cài đặt";
			TabPage_Setting.UseVisualStyleBackColor = true;
			TabControl1.Controls.Add(TabPage7);
			TabControl1.Controls.Add(TabPage8);
			TabControl1.Controls.Add(TabPage9);
			TabControl1.Controls.Add(TabPage2);
			TabControl1.Controls.Add(TabPage6);
			TabControl1.Controls.Add(TabPage4);
			TabControl1.Dock = DockStyle.Fill;
			TabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
			TabControl1.HotTrack = true;
			TabControl1.ItemSize = new Size(0, 26);
			TabControl1.Location = new Point(3, 3);
			TabControl1.Multiline = true;
			TabControl1.Name = "TabControl1";
			vs2010TabControlRenderer2.ColorTable = colorTable3;
			TabControl1.Renderer = vs2010TabControlRenderer2;
			TabControl1.SelectedIndex = 0;
			TabControl1.Size = new Size(657, 607);
			TabControl1.TabIndex = 96;
			TabPage7.Controls.Add(GroupBox_disconnect);
			TabPage7.Controls.Add(GroupBox_Basic);
			TabPage7.Controls.Add(GroupBox9);
			TabPage7.Location = new Point(4, 30);
			TabPage7.Name = "TabPage7";
			TabPage7.Padding = new Padding(3);
			TabPage7.Size = new Size(649, 573);
			TabPage7.TabIndex = 0;
			TabPage7.Text = "Hệ thống";
			TabPage7.UseVisualStyleBackColor = true;
			GroupBox_disconnect.Controls.Add(CheckBox_DCFullHomDo);
			GroupBox_disconnect.Controls.Add(CheckBox_DisExp);
			GroupBox_disconnect.Controls.Add(RadioButton_DC_no);
			GroupBox_disconnect.Controls.Add(RadioButton_DCmemout);
			GroupBox_disconnect.Controls.Add(RadioButton_DCLeaderOut);
			GroupBox_disconnect.Controls.Add(CheckBox_DCAfter1MinNoBattle);
			GroupBox_disconnect.Dock = DockStyle.Fill;
			GroupBox_disconnect.Location = new Point(331, 3);
			GroupBox_disconnect.Margin = new Padding(2);
			GroupBox_disconnect.Name = "GroupBox_disconnect";
			GroupBox_disconnect.Size = new Size(315, 448);
			GroupBox_disconnect.TabIndex = 93;
			GroupBox_disconnect.TabStop = false;
			GroupBox_disconnect.Text = "Ngắt kết nối";
			CheckBox_DCFullHomDo.FlatStyle = FlatStyle.System;
			CheckBox_DCFullHomDo.Location = new Point(13, 67);
			CheckBox_DCFullHomDo.Margin = new Padding(10, 2, 2, 2);
			CheckBox_DCFullHomDo.Name = "CheckBox_DCFullHomDo";
			CheckBox_DCFullHomDo.Size = new Size(178, 21);
			CheckBox_DCFullHomDo.TabIndex = 8;
			CheckBox_DCFullHomDo.Text = "Sau 5 phút hòm đồ vẫn đầy";
			CheckBox_DCFullHomDo.UseVisualStyleBackColor = true;
			CheckBox_DisExp.FlatStyle = FlatStyle.System;
			CheckBox_DisExp.Location = new Point(13, 42);
			CheckBox_DisExp.Margin = new Padding(10, 2, 2, 2);
			CheckBox_DisExp.Name = "CheckBox_DisExp";
			CheckBox_DisExp.Size = new Size(178, 21);
			CheckBox_DisExp.TabIndex = 7;
			CheckBox_DisExp.Text = "Sau 30s không nhận được exp";
			CheckBox_DisExp.UseVisualStyleBackColor = true;
			RadioButton_DC_no.FlatStyle = FlatStyle.System;
			RadioButton_DC_no.Location = new Point(13, 192);
			RadioButton_DC_no.Margin = new Padding(10, 2, 2, 2);
			RadioButton_DC_no.Name = "RadioButton_DC_no";
			RadioButton_DC_no.Size = new Size(17, 16);
			RadioButton_DC_no.TabIndex = 6;
			RadioButton_DC_no.UseVisualStyleBackColor = true;
			RadioButton_DCmemout.FlatStyle = FlatStyle.System;
			RadioButton_DCmemout.Location = new Point(13, 167);
			RadioButton_DCmemout.Margin = new Padding(10, 2, 2, 2);
			RadioButton_DCmemout.Name = "RadioButton_DCmemout";
			RadioButton_DCmemout.Size = new Size(194, 21);
			RadioButton_DCmemout.TabIndex = 5;
			RadioButton_DCmemout.Text = "Khi thành viên nhóm thoát";
			RadioButton_DCmemout.UseVisualStyleBackColor = true;
			RadioButton_DCLeaderOut.CheckAlign = ContentAlignment.BottomLeft;
			RadioButton_DCLeaderOut.Checked = true;
			RadioButton_DCLeaderOut.FlatStyle = FlatStyle.System;
			RadioButton_DCLeaderOut.Location = new Point(13, 142);
			RadioButton_DCLeaderOut.Margin = new Padding(10, 2, 2, 2);
			RadioButton_DCLeaderOut.Name = "RadioButton_DCLeaderOut";
			RadioButton_DCLeaderOut.Size = new Size(151, 21);
			RadioButton_DCLeaderOut.TabIndex = 4;
			RadioButton_DCLeaderOut.TabStop = true;
			RadioButton_DCLeaderOut.Text = "Khi chủ nhóm thoát";
			RadioButton_DCLeaderOut.UseVisualStyleBackColor = true;
			CheckBox_DCAfter1MinNoBattle.FlatStyle = FlatStyle.System;
			CheckBox_DCAfter1MinNoBattle.Location = new Point(13, 17);
			CheckBox_DCAfter1MinNoBattle.Margin = new Padding(10, 2, 2, 2);
			CheckBox_DCAfter1MinNoBattle.Name = "CheckBox_DCAfter1MinNoBattle";
			CheckBox_DCAfter1MinNoBattle.Size = new Size(178, 21);
			CheckBox_DCAfter1MinNoBattle.TabIndex = 0;
			CheckBox_DCAfter1MinNoBattle.Text = "Sau 1 phút không đánh";
			CheckBox_DCAfter1MinNoBattle.UseVisualStyleBackColor = true;
			GroupBox_Basic.Controls.Add(Label42);
			GroupBox_Basic.Controls.Add(NumericUpDown_sendpacket);
			GroupBox_Basic.Controls.Add(Label41);
			GroupBox_Basic.Controls.Add(TextBox_idQC);
			GroupBox_Basic.Controls.Add(CheckBox_QC);
			GroupBox_Basic.Controls.Add(CheckBox_Autosort);
			GroupBox_Basic.Controls.Add(CheckBox_AutoUsePT);
			GroupBox_Basic.Controls.Add(CheckBox_AutoEquitExp);
			GroupBox_Basic.Controls.Add(CheckBox_CatPet);
			GroupBox_Basic.Controls.Add(RadioButton_PT_no);
			GroupBox_Basic.Controls.Add(RadioButton_MemberRequestParty);
			GroupBox_Basic.Controls.Add(RadioButton_LeaderRequestParty);
			GroupBox_Basic.Controls.Add(CheckBox_ClearGhost);
			GroupBox_Basic.Dock = DockStyle.Left;
			GroupBox_Basic.Location = new Point(3, 3);
			GroupBox_Basic.Margin = new Padding(2);
			GroupBox_Basic.Name = "GroupBox_Basic";
			GroupBox_Basic.Size = new Size(328, 448);
			GroupBox_Basic.TabIndex = 92;
			GroupBox_Basic.TabStop = false;
			GroupBox_Basic.Text = "Cơ bản";
			Label42.AutoSize = true;
			Label42.Location = new Point(112, 368);
			Label42.Name = "Label42";
			Label42.Size = new Size(57, 13);
			Label42.TabIndex = 31;
			Label42.Text = "millisecond";
			NumericUpDown_sendpacket.Increment = new decimal(new int[4] { 100, 0, 0, 0 });
			NumericUpDown_sendpacket.Location = new Point(36, 366);
			NumericUpDown_sendpacket.Maximum = new decimal(new int[4] { 10000, 0, 0, 0 });
			NumericUpDown_sendpacket.Minimum = new decimal(new int[4] { 100, 0, 0, 0 });
			NumericUpDown_sendpacket.Name = "NumericUpDown_sendpacket";
			NumericUpDown_sendpacket.Size = new Size(70, 19);
			NumericUpDown_sendpacket.TabIndex = 30;
			NumericUpDown_sendpacket.Value = new decimal(new int[4] { 100, 0, 0, 0 });
			Label41.AutoSize = true;
			Label41.Location = new Point(9, 347);
			Label41.Name = "Label41";
			Label41.Size = new Size(18, 13);
			Label41.TabIndex = 29;
			Label41.Text = "ID";
			TextBox_idQC.Location = new Point(36, 344);
			TextBox_idQC.Name = "TextBox_idQC";
			TextBox_idQC.Size = new Size(70, 19);
			TextBox_idQC.TabIndex = 27;
			CheckBox_QC.AutoSize = true;
			CheckBox_QC.Location = new Point(112, 346);
			CheckBox_QC.Name = "CheckBox_QC";
			CheckBox_QC.Size = new Size(80, 17);
			CheckBox_QC.TabIndex = 28;
			CheckBox_QC.Text = "Quan chiến";
			CheckBox_QC.UseVisualStyleBackColor = true;
			CheckBox_Autosort.FlatStyle = FlatStyle.System;
			CheckBox_Autosort.Location = new Point(13, 111);
			CheckBox_Autosort.Margin = new Padding(10, 2, 2, 2);
			CheckBox_Autosort.Name = "CheckBox_Autosort";
			CheckBox_Autosort.Size = new Size(169, 21);
			CheckBox_Autosort.TabIndex = 12;
			CheckBox_Autosort.Text = "Tự động gộp ngọc TG";
			CheckBox_Autosort.UseVisualStyleBackColor = true;
			CheckBox_AutoUsePT.FlatStyle = FlatStyle.System;
			CheckBox_AutoUsePT.Location = new Point(13, 92);
			CheckBox_AutoUsePT.Margin = new Padding(10, 2, 2, 2);
			CheckBox_AutoUsePT.Name = "CheckBox_AutoUsePT";
			CheckBox_AutoUsePT.Size = new Size(169, 21);
			CheckBox_AutoUsePT.TabIndex = 11;
			CheckBox_AutoUsePT.Text = "Tự sử dụng PT hoặc DPT";
			CheckBox_AutoUsePT.UseVisualStyleBackColor = true;
			CheckBox_AutoEquitExp.FlatStyle = FlatStyle.System;
			CheckBox_AutoEquitExp.Location = new Point(13, 67);
			CheckBox_AutoEquitExp.Margin = new Padding(10, 2, 2, 2);
			CheckBox_AutoEquitExp.Name = "CheckBox_AutoEquitExp";
			CheckBox_AutoEquitExp.Size = new Size(169, 21);
			CheckBox_AutoEquitExp.TabIndex = 10;
			CheckBox_AutoEquitExp.Text = "Tự đeo ngọc nhân exp";
			CheckBox_AutoEquitExp.UseVisualStyleBackColor = true;
			CheckBox_CatPet.FlatStyle = FlatStyle.System;
			CheckBox_CatPet.Location = new Point(13, 17);
			CheckBox_CatPet.Margin = new Padding(10, 2, 2, 2);
			CheckBox_CatPet.Name = "CheckBox_CatPet";
			CheckBox_CatPet.Size = new Size(169, 21);
			CheckBox_CatPet.TabIndex = 9;
			CheckBox_CatPet.Text = "Cất pet khi còn quá ít máu";
			CheckBox_CatPet.UseVisualStyleBackColor = true;
			RadioButton_PT_no.AutoSize = true;
			RadioButton_PT_no.Location = new Point(13, 195);
			RadioButton_PT_no.Margin = new Padding(10, 2, 2, 2);
			RadioButton_PT_no.Name = "RadioButton_PT_no";
			RadioButton_PT_no.Size = new Size(14, 13);
			RadioButton_PT_no.TabIndex = 8;
			RadioButton_PT_no.UseVisualStyleBackColor = true;
			RadioButton_MemberRequestParty.FlatStyle = FlatStyle.System;
			RadioButton_MemberRequestParty.Location = new Point(13, 170);
			RadioButton_MemberRequestParty.Margin = new Padding(10, 2, 2, 2);
			RadioButton_MemberRequestParty.Name = "RadioButton_MemberRequestParty";
			RadioButton_MemberRequestParty.Size = new Size(169, 21);
			RadioButton_MemberRequestParty.TabIndex = 7;
			RadioButton_MemberRequestParty.Text = "Tự động xin vào nhóm";
			RadioButton_MemberRequestParty.UseVisualStyleBackColor = true;
			RadioButton_LeaderRequestParty.Checked = true;
			RadioButton_LeaderRequestParty.FlatStyle = FlatStyle.System;
			RadioButton_LeaderRequestParty.Location = new Point(13, 145);
			RadioButton_LeaderRequestParty.Margin = new Padding(10, 2, 2, 2);
			RadioButton_LeaderRequestParty.Name = "RadioButton_LeaderRequestParty";
			RadioButton_LeaderRequestParty.Size = new Size(174, 21);
			RadioButton_LeaderRequestParty.TabIndex = 6;
			RadioButton_LeaderRequestParty.TabStop = true;
			RadioButton_LeaderRequestParty.Text = "Tự động mời vào nhóm";
			RadioButton_LeaderRequestParty.UseVisualStyleBackColor = true;
			CheckBox_ClearGhost.FlatStyle = FlatStyle.System;
			CheckBox_ClearGhost.Location = new Point(13, 42);
			CheckBox_ClearGhost.Margin = new Padding(10, 2, 2, 2);
			CheckBox_ClearGhost.Name = "CheckBox_ClearGhost";
			CheckBox_ClearGhost.Size = new Size(132, 21);
			CheckBox_ClearGhost.TabIndex = 1;
			CheckBox_ClearGhost.Text = "Tự động giải ma";
			CheckBox_ClearGhost.UseVisualStyleBackColor = true;
			GroupBox9.Controls.Add(Label79);
			GroupBox9.Controls.Add(Label13);
			GroupBox9.Controls.Add(TextBox_RemoteDis);
			GroupBox9.Controls.Add(Label77);
			GroupBox9.Dock = DockStyle.Bottom;
			GroupBox9.Location = new Point(3, 451);
			GroupBox9.Margin = new Padding(2);
			GroupBox9.Name = "GroupBox9";
			GroupBox9.Size = new Size(643, 119);
			GroupBox9.TabIndex = 94;
			GroupBox9.TabStop = false;
			GroupBox9.Text = "Điều khiển ngắt kết nối từ xa";
			Label79.BackColor = SystemColors.Window;
			Label79.FlatStyle = FlatStyle.System;
			Label79.ForeColor = Color.Blue;
			Label79.Location = new Point(10, 84);
			Label79.Margin = new Padding(2);
			Label79.Name = "Label79";
			Label79.Size = new Size(187, 30);
			Label79.TabIndex = 29;
			Label79.Text = "!dis-r [mật khẩu] : ngắt kết nối và kết nối lại sau 10 phút";
			Label13.BackColor = SystemColors.Window;
			Label13.FlatStyle = FlatStyle.System;
			Label13.Location = new Point(10, 23);
			Label13.Margin = new Padding(2);
			Label13.Name = "Label13";
			Label13.Size = new Size(51, 15);
			Label13.TabIndex = 27;
			Label13.Text = "Mật khẩu";
			TextBox_RemoteDis.Location = new Point(65, 20);
			TextBox_RemoteDis.Margin = new Padding(2);
			TextBox_RemoteDis.MaxLength = 20;
			TextBox_RemoteDis.Multiline = true;
			TextBox_RemoteDis.Name = "TextBox_RemoteDis";
			TextBox_RemoteDis.Size = new Size(137, 19);
			TextBox_RemoteDis.TabIndex = 9;
			Label77.BackColor = SystemColors.Window;
			Label77.FlatStyle = FlatStyle.System;
			Label77.ForeColor = Color.Red;
			Label77.Location = new Point(10, 65);
			Label77.Margin = new Padding(2);
			Label77.Name = "Label77";
			Label77.Size = new Size(187, 15);
			Label77.TabIndex = 28;
			Label77.Text = "!dis [mật khẩu] : ngắt kết nối";
			TabPage8.Controls.Add(GroupBox3);
			TabPage8.Controls.Add(GroupBox2);
			TabPage8.Location = new Point(4, 30);
			TabPage8.Name = "TabPage8";
			TabPage8.Padding = new Padding(3);
			TabPage8.Size = new Size(649, 573);
			TabPage8.TabIndex = 1;
			TabPage8.Text = "Hồi phục";
			TabPage8.UseVisualStyleBackColor = true;
			GroupBox3.Controls.Add(Label25);
			GroupBox3.Controls.Add(Label33);
			GroupBox3.Controls.Add(TextBox_TL_char_hp_value);
			GroupBox3.Controls.Add(CheckBox_TL_mem1);
			GroupBox3.Controls.Add(Label34);
			GroupBox3.Controls.Add(Label32);
			GroupBox3.Controls.Add(TextBox_TL_pet_sp_value);
			GroupBox3.Controls.Add(Label22);
			GroupBox3.Controls.Add(Label35);
			GroupBox3.Controls.Add(CheckBox_TL_mem2);
			GroupBox3.Controls.Add(Label36);
			GroupBox3.Controls.Add(TextBox_TL_char_sp_value);
			GroupBox3.Controls.Add(TextBox_TL_pet_hp_value);
			GroupBox3.Controls.Add(CheckBox_TL_mem3);
			GroupBox3.Controls.Add(CheckBox_TL_pet2);
			GroupBox3.Controls.Add(Label23);
			GroupBox3.Controls.Add(CheckBox_TL_pet1);
			GroupBox3.Controls.Add(CheckBox_TL_mem4);
			GroupBox3.Dock = DockStyle.Fill;
			GroupBox3.Location = new Point(3, 159);
			GroupBox3.Margin = new Padding(2);
			GroupBox3.Name = "GroupBox3";
			GroupBox3.Size = new Size(643, 411);
			GroupBox3.TabIndex = 95;
			GroupBox3.TabStop = false;
			GroupBox3.Text = "Thanh lưu";
			Label25.Location = new Point(229, 22);
			Label25.Margin = new Padding(0, 1, 0, 1);
			Label25.Name = "Label25";
			Label25.Size = new Size(134, 16);
			Label25.TabIndex = 13;
			Label25.Text = "Khi HP nhân vật ít hơn";
			Label25.TextAlign = ContentAlignment.TopRight;
			Label25.Visible = false;
			Label33.Location = new Point(229, 121);
			Label33.Margin = new Padding(0, 1, 0, 1);
			Label33.Name = "Label33";
			Label33.Size = new Size(134, 16);
			Label33.TabIndex = 71;
			Label33.Text = "Khi HP võ tướng ít hơn";
			Label33.TextAlign = ContentAlignment.TopRight;
			TextBox_TL_char_hp_value.Location = new Point(365, 19);
			TextBox_TL_char_hp_value.Margin = new Padding(2);
			TextBox_TL_char_hp_value.MaxLength = 2;
			TextBox_TL_char_hp_value.Name = "TextBox_TL_char_hp_value";
			TextBox_TL_char_hp_value.Size = new Size(22, 19);
			TextBox_TL_char_hp_value.TabIndex = 9;
			TextBox_TL_char_hp_value.Text = "80";
			TextBox_TL_char_hp_value.TextAlign = HorizontalAlignment.Right;
			TextBox_TL_char_hp_value.Visible = false;
			CheckBox_TL_mem1.FlatStyle = FlatStyle.System;
			CheckBox_TL_mem1.Location = new Point(13, 20);
			CheckBox_TL_mem1.Margin = new Padding(10, 2, 2, 2);
			CheckBox_TL_mem1.Name = "CheckBox_TL_mem1";
			CheckBox_TL_mem1.Size = new Size(106, 20);
			CheckBox_TL_mem1.TabIndex = 15;
			CheckBox_TL_mem1.Text = "Thành viên 1";
			CheckBox_TL_mem1.UseVisualStyleBackColor = true;
			Label34.AutoSize = true;
			Label34.Location = new Point(389, 146);
			Label34.Margin = new Padding(0, 1, 0, 1);
			Label34.Name = "Label34";
			Label34.Size = new Size(16, 13);
			Label34.TabIndex = 70;
			Label34.Text = "%";
			Label32.Location = new Point(229, 48);
			Label32.Margin = new Padding(0, 1, 0, 1);
			Label32.Name = "Label32";
			Label32.Size = new Size(134, 16);
			Label32.TabIndex = 14;
			Label32.Text = "Khi SP nhân vật ít hơn";
			Label32.TextAlign = ContentAlignment.TopRight;
			Label32.Visible = false;
			TextBox_TL_pet_sp_value.Location = new Point(365, 143);
			TextBox_TL_pet_sp_value.Margin = new Padding(2);
			TextBox_TL_pet_sp_value.MaxLength = 2;
			TextBox_TL_pet_sp_value.Name = "TextBox_TL_pet_sp_value";
			TextBox_TL_pet_sp_value.Size = new Size(22, 19);
			TextBox_TL_pet_sp_value.TabIndex = 69;
			TextBox_TL_pet_sp_value.Text = "50";
			TextBox_TL_pet_sp_value.TextAlign = HorizontalAlignment.Right;
			Label22.AutoSize = true;
			Label22.Location = new Point(389, 22);
			Label22.Margin = new Padding(0, 1, 0, 1);
			Label22.Name = "Label22";
			Label22.Size = new Size(16, 13);
			Label22.TabIndex = 10;
			Label22.Text = "%";
			Label22.Visible = false;
			Label35.AutoSize = true;
			Label35.Location = new Point(389, 121);
			Label35.Margin = new Padding(0, 1, 0, 1);
			Label35.Name = "Label35";
			Label35.Size = new Size(16, 13);
			Label35.TabIndex = 68;
			Label35.Text = "%";
			CheckBox_TL_mem2.FlatStyle = FlatStyle.System;
			CheckBox_TL_mem2.Location = new Point(13, 44);
			CheckBox_TL_mem2.Margin = new Padding(10, 2, 2, 2);
			CheckBox_TL_mem2.Name = "CheckBox_TL_mem2";
			CheckBox_TL_mem2.Size = new Size(106, 20);
			CheckBox_TL_mem2.TabIndex = 16;
			CheckBox_TL_mem2.Text = "Thành viên 2";
			CheckBox_TL_mem2.UseVisualStyleBackColor = true;
			Label36.Location = new Point(229, 146);
			Label36.Margin = new Padding(0, 1, 0, 1);
			Label36.Name = "Label36";
			Label36.Size = new Size(134, 16);
			Label36.TabIndex = 72;
			Label36.Text = "Khi SP võ tướng ít hơn";
			Label36.TextAlign = ContentAlignment.TopRight;
			TextBox_TL_char_sp_value.Location = new Point(365, 45);
			TextBox_TL_char_sp_value.Margin = new Padding(2);
			TextBox_TL_char_sp_value.MaxLength = 2;
			TextBox_TL_char_sp_value.Name = "TextBox_TL_char_sp_value";
			TextBox_TL_char_sp_value.Size = new Size(22, 19);
			TextBox_TL_char_sp_value.TabIndex = 11;
			TextBox_TL_char_sp_value.Text = "80";
			TextBox_TL_char_sp_value.TextAlign = HorizontalAlignment.Right;
			TextBox_TL_char_sp_value.Visible = false;
			TextBox_TL_pet_hp_value.Location = new Point(365, 118);
			TextBox_TL_pet_hp_value.Margin = new Padding(2);
			TextBox_TL_pet_hp_value.MaxLength = 2;
			TextBox_TL_pet_hp_value.Name = "TextBox_TL_pet_hp_value";
			TextBox_TL_pet_hp_value.Size = new Size(22, 19);
			TextBox_TL_pet_hp_value.TabIndex = 67;
			TextBox_TL_pet_hp_value.Text = "80";
			TextBox_TL_pet_hp_value.TextAlign = HorizontalAlignment.Right;
			CheckBox_TL_mem3.FlatStyle = FlatStyle.System;
			CheckBox_TL_mem3.Location = new Point(13, 69);
			CheckBox_TL_mem3.Margin = new Padding(10, 2, 2, 2);
			CheckBox_TL_mem3.Name = "CheckBox_TL_mem3";
			CheckBox_TL_mem3.Size = new Size(106, 20);
			CheckBox_TL_mem3.TabIndex = 17;
			CheckBox_TL_mem3.Text = "Thành viên 3";
			CheckBox_TL_mem3.UseVisualStyleBackColor = true;
			CheckBox_TL_pet2.FlatStyle = FlatStyle.System;
			CheckBox_TL_pet2.Location = new Point(13, 144);
			CheckBox_TL_pet2.Margin = new Padding(10, 2, 2, 2);
			CheckBox_TL_pet2.Name = "CheckBox_TL_pet2";
			CheckBox_TL_pet2.Size = new Size(114, 20);
			CheckBox_TL_pet2.TabIndex = 66;
			CheckBox_TL_pet2.Text = "Võ tướng 2 lần";
			CheckBox_TL_pet2.UseVisualStyleBackColor = true;
			Label23.AutoSize = true;
			Label23.Location = new Point(389, 48);
			Label23.Margin = new Padding(0, 1, 0, 1);
			Label23.Name = "Label23";
			Label23.Size = new Size(16, 13);
			Label23.TabIndex = 12;
			Label23.Text = "%";
			Label23.Visible = false;
			CheckBox_TL_pet1.FlatStyle = FlatStyle.System;
			CheckBox_TL_pet1.Location = new Point(13, 119);
			CheckBox_TL_pet1.Margin = new Padding(10, 2, 2, 2);
			CheckBox_TL_pet1.Name = "CheckBox_TL_pet1";
			CheckBox_TL_pet1.Size = new Size(114, 20);
			CheckBox_TL_pet1.TabIndex = 65;
			CheckBox_TL_pet1.Text = "Võ tướng 1 lần";
			CheckBox_TL_pet1.UseVisualStyleBackColor = true;
			CheckBox_TL_mem4.FlatStyle = FlatStyle.System;
			CheckBox_TL_mem4.Location = new Point(13, 94);
			CheckBox_TL_mem4.Margin = new Padding(10, 2, 2, 2);
			CheckBox_TL_mem4.Name = "CheckBox_TL_mem4";
			CheckBox_TL_mem4.Size = new Size(106, 20);
			CheckBox_TL_mem4.TabIndex = 18;
			CheckBox_TL_mem4.Text = "Thành viên 4";
			CheckBox_TL_mem4.UseVisualStyleBackColor = true;
			GroupBox2.Controls.Add(CheckBox_AutoEat);
			GroupBox2.Controls.Add(Label43);
			GroupBox2.Controls.Add(TextBox_Eat_pet_sp_value);
			GroupBox2.Controls.Add(Label44);
			GroupBox2.Controls.Add(TextBox_Eat_pet_hp_value);
			GroupBox2.Controls.Add(Label45);
			GroupBox2.Controls.Add(Label46);
			GroupBox2.Controls.Add(Label21);
			GroupBox2.Controls.Add(TextBox_Eat_char_sp_value);
			GroupBox2.Controls.Add(Label20);
			GroupBox2.Controls.Add(TextBox_Eat_char_hp_value);
			GroupBox2.Controls.Add(Label7);
			GroupBox2.Controls.Add(Label5);
			GroupBox2.Dock = DockStyle.Top;
			GroupBox2.Location = new Point(3, 3);
			GroupBox2.Margin = new Padding(2);
			GroupBox2.Name = "GroupBox2";
			GroupBox2.Size = new Size(643, 156);
			GroupBox2.TabIndex = 94;
			GroupBox2.TabStop = false;
			GroupBox2.Text = "Dùng thuốc";
			CheckBox_AutoEat.FlatStyle = FlatStyle.System;
			CheckBox_AutoEat.Location = new Point(13, 20);
			CheckBox_AutoEat.Margin = new Padding(10, 2, 2, 2);
			CheckBox_AutoEat.Name = "CheckBox_AutoEat";
			CheckBox_AutoEat.Size = new Size(148, 20);
			CheckBox_AutoEat.TabIndex = 16;
			CheckBox_AutoEat.Text = "Tự động dùng thuốc";
			CheckBox_AutoEat.UseVisualStyleBackColor = true;
			Label43.AutoSize = true;
			Label43.Location = new Point(389, 126);
			Label43.Margin = new Padding(0, 1, 0, 1);
			Label43.Name = "Label43";
			Label43.Size = new Size(16, 13);
			Label43.TabIndex = 14;
			Label43.Text = "%";
			TextBox_Eat_pet_sp_value.Location = new Point(365, 123);
			TextBox_Eat_pet_sp_value.Margin = new Padding(2);
			TextBox_Eat_pet_sp_value.MaxLength = 2;
			TextBox_Eat_pet_sp_value.Name = "TextBox_Eat_pet_sp_value";
			TextBox_Eat_pet_sp_value.Size = new Size(22, 19);
			TextBox_Eat_pet_sp_value.TabIndex = 13;
			TextBox_Eat_pet_sp_value.Text = "30";
			TextBox_Eat_pet_sp_value.TextAlign = HorizontalAlignment.Right;
			Label44.AutoSize = true;
			Label44.Location = new Point(389, 100);
			Label44.Margin = new Padding(0, 1, 0, 1);
			Label44.Name = "Label44";
			Label44.Size = new Size(16, 13);
			Label44.TabIndex = 12;
			Label44.Text = "%";
			TextBox_Eat_pet_hp_value.Location = new Point(365, 97);
			TextBox_Eat_pet_hp_value.Margin = new Padding(2);
			TextBox_Eat_pet_hp_value.MaxLength = 2;
			TextBox_Eat_pet_hp_value.Name = "TextBox_Eat_pet_hp_value";
			TextBox_Eat_pet_hp_value.Size = new Size(22, 19);
			TextBox_Eat_pet_hp_value.TabIndex = 11;
			TextBox_Eat_pet_hp_value.Text = "80";
			TextBox_Eat_pet_hp_value.TextAlign = HorizontalAlignment.Right;
			Label45.Location = new Point(193, 126);
			Label45.Margin = new Padding(0, 1, 0, 1);
			Label45.Name = "Label45";
			Label45.Size = new Size(170, 16);
			Label45.TabIndex = 10;
			Label45.Text = "Dùng khi SP võ tướng khi ít hơn";
			Label45.TextAlign = ContentAlignment.TopRight;
			Label46.Location = new Point(193, 100);
			Label46.Margin = new Padding(0, 1, 0, 1);
			Label46.Name = "Label46";
			Label46.Size = new Size(170, 16);
			Label46.TabIndex = 9;
			Label46.Text = "Dùng khi HP võ tướng khi ít hơn";
			Label46.TextAlign = ContentAlignment.TopRight;
			Label21.AutoSize = true;
			Label21.Location = new Point(389, 74);
			Label21.Margin = new Padding(0, 1, 0, 1);
			Label21.Name = "Label21";
			Label21.Size = new Size(16, 13);
			Label21.TabIndex = 8;
			Label21.Text = "%";
			TextBox_Eat_char_sp_value.Location = new Point(365, 71);
			TextBox_Eat_char_sp_value.Margin = new Padding(2);
			TextBox_Eat_char_sp_value.MaxLength = 2;
			TextBox_Eat_char_sp_value.Name = "TextBox_Eat_char_sp_value";
			TextBox_Eat_char_sp_value.Size = new Size(22, 19);
			TextBox_Eat_char_sp_value.TabIndex = 7;
			TextBox_Eat_char_sp_value.Text = "30";
			TextBox_Eat_char_sp_value.TextAlign = HorizontalAlignment.Right;
			Label20.AutoSize = true;
			Label20.Location = new Point(389, 48);
			Label20.Margin = new Padding(0, 1, 0, 1);
			Label20.Name = "Label20";
			Label20.Size = new Size(16, 13);
			Label20.TabIndex = 6;
			Label20.Text = "%";
			TextBox_Eat_char_hp_value.Location = new Point(365, 45);
			TextBox_Eat_char_hp_value.Margin = new Padding(2);
			TextBox_Eat_char_hp_value.MaxLength = 2;
			TextBox_Eat_char_hp_value.Name = "TextBox_Eat_char_hp_value";
			TextBox_Eat_char_hp_value.Size = new Size(22, 19);
			TextBox_Eat_char_hp_value.TabIndex = 5;
			TextBox_Eat_char_hp_value.Text = "80";
			TextBox_Eat_char_hp_value.TextAlign = HorizontalAlignment.Right;
			Label7.Location = new Point(193, 74);
			Label7.Margin = new Padding(0, 1, 0, 1);
			Label7.Name = "Label7";
			Label7.Size = new Size(170, 16);
			Label7.TabIndex = 1;
			Label7.Text = "Dùng khi SP nhân vật khi ít hơn";
			Label7.TextAlign = ContentAlignment.TopRight;
			Label5.Location = new Point(193, 48);
			Label5.Margin = new Padding(0, 1, 0, 1);
			Label5.Name = "Label5";
			Label5.Size = new Size(170, 16);
			Label5.TabIndex = 0;
			Label5.Text = "Dùng khi HP nhân vật khi ít hơn";
			Label5.TextAlign = ContentAlignment.TopRight;
			TabPage9.Controls.Add(CheckBox_AutoCreatCharacter);
			TabPage9.Controls.Add(RadioButton_dia);
			TabPage9.Controls.Add(Label17);
			TabPage9.Controls.Add(Label14);
			TabPage9.Controls.Add(RadioButton_thuy);
			TabPage9.Controls.Add(NumericUpDown_createSp);
			TabPage9.Controls.Add(Label_point);
			TabPage9.Controls.Add(Label15);
			TabPage9.Controls.Add(Label10);
			TabPage9.Controls.Add(NumericUpDown_createHp);
			TabPage9.Controls.Add(ComboBox_sex);
			TabPage9.Controls.Add(NumericUpDown_createAgi);
			TabPage9.Controls.Add(RadioButton_phong);
			TabPage9.Controls.Add(NumericUpDown_createInt);
			TabPage9.Controls.Add(TextBox_createName);
			TabPage9.Controls.Add(Label16);
			TabPage9.Controls.Add(RadioButton_hoa);
			TabPage9.Controls.Add(TextBox_Pass);
			TabPage9.Controls.Add(Label11);
			TabPage9.Controls.Add(TextBox_amma);
			TabPage9.Controls.Add(Label19);
			TabPage9.Controls.Add(NumericUpDown_createAtk);
			TabPage9.Controls.Add(Label1);
			TabPage9.Controls.Add(Label18);
			TabPage9.Controls.Add(Label2);
			TabPage9.Controls.Add(NumericUpDown_createDef);
			TabPage9.Location = new Point(4, 30);
			TabPage9.Name = "TabPage9";
			TabPage9.Padding = new Padding(3);
			TabPage9.Size = new Size(649, 573);
			TabPage9.TabIndex = 2;
			TabPage9.Text = "Tạo nhân vật";
			TabPage9.UseVisualStyleBackColor = true;
			CheckBox_AutoCreatCharacter.FlatStyle = FlatStyle.System;
			CheckBox_AutoCreatCharacter.Location = new Point(37, 5);
			CheckBox_AutoCreatCharacter.Margin = new Padding(2);
			CheckBox_AutoCreatCharacter.Name = "CheckBox_AutoCreatCharacter";
			CheckBox_AutoCreatCharacter.Size = new Size(155, 20);
			CheckBox_AutoCreatCharacter.TabIndex = 91;
			CheckBox_AutoCreatCharacter.Text = "Tự động tạo nhân vật";
			CheckBox_AutoCreatCharacter.UseVisualStyleBackColor = true;
			RadioButton_dia.Checked = true;
			RadioButton_dia.ForeColor = Color.Peru;
			RadioButton_dia.Location = new Point(37, 56);
			RadioButton_dia.Margin = new Padding(2);
			RadioButton_dia.Name = "RadioButton_dia";
			RadioButton_dia.Size = new Size(49, 20);
			RadioButton_dia.TabIndex = 87;
			RadioButton_dia.TabStop = true;
			RadioButton_dia.Text = "Địa";
			RadioButton_dia.UseVisualStyleBackColor = true;
			Label17.Location = new Point(34, 33);
			Label17.Margin = new Padding(0, 1, 0, 1);
			Label17.Name = "Label17";
			Label17.Size = new Size(32, 16);
			Label17.TabIndex = 83;
			Label17.Text = "Tên";
			Label14.Location = new Point(34, 161);
			Label14.Margin = new Padding(0, 1, 0, 1);
			Label14.Name = "Label14";
			Label14.Size = new Size(63, 16);
			Label14.TabIndex = 80;
			Label14.Text = "Thể chức";
			RadioButton_thuy.ForeColor = Color.DodgerBlue;
			RadioButton_thuy.Location = new Point(91, 56);
			RadioButton_thuy.Margin = new Padding(2);
			RadioButton_thuy.Name = "RadioButton_thuy";
			RadioButton_thuy.Size = new Size(59, 20);
			RadioButton_thuy.TabIndex = 88;
			RadioButton_thuy.Text = "Thuỷ";
			RadioButton_thuy.UseVisualStyleBackColor = true;
			NumericUpDown_createSp.Location = new Point(142, 185);
			NumericUpDown_createSp.Margin = new Padding(2);
			NumericUpDown_createSp.Maximum = new decimal(new int[4] { 6, 0, 0, 0 });
			NumericUpDown_createSp.Name = "NumericUpDown_createSp";
			NumericUpDown_createSp.Size = new Size(36, 19);
			NumericUpDown_createSp.TabIndex = 72;
			Label_point.Location = new Point(256, 83);
			Label_point.Margin = new Padding(0, 1, 0, 1);
			Label_point.Name = "Label_point";
			Label_point.Size = new Size(15, 16);
			Label_point.TabIndex = 76;
			Label_point.Text = "0";
			Label15.Location = new Point(34, 187);
			Label15.Margin = new Padding(0, 1, 0, 1);
			Label15.Name = "Label15";
			Label15.Size = new Size(77, 16);
			Label15.TabIndex = 81;
			Label15.Text = "Năng lượng";
			Label10.Location = new Point(212, 83);
			Label10.Margin = new Padding(0, 1, 0, 1);
			Label10.Name = "Label10";
			Label10.Size = new Size(42, 16);
			Label10.TabIndex = 75;
			Label10.Text = "Điểm:";
			NumericUpDown_createHp.Location = new Point(142, 159);
			NumericUpDown_createHp.Margin = new Padding(2);
			NumericUpDown_createHp.Maximum = new decimal(new int[4] { 6, 0, 0, 0 });
			NumericUpDown_createHp.Name = "NumericUpDown_createHp";
			NumericUpDown_createHp.Size = new Size(36, 19);
			NumericUpDown_createHp.TabIndex = 71;
			ComboBox_sex.DropDownStyle = ComboBoxStyle.DropDownList;
			ComboBox_sex.FormattingEnabled = true;
			ComboBox_sex.Items.AddRange(new object[2] { "Nam", "Nữ" });
			ComboBox_sex.Location = new Point(289, 30);
			ComboBox_sex.Margin = new Padding(2);
			ComboBox_sex.Name = "ComboBox_sex";
			ComboBox_sex.Size = new Size(58, 21);
			ComboBox_sex.TabIndex = 86;
			NumericUpDown_createAgi.Location = new Point(142, 211);
			NumericUpDown_createAgi.Margin = new Padding(2);
			NumericUpDown_createAgi.Maximum = new decimal(new int[4] { 6, 0, 0, 0 });
			NumericUpDown_createAgi.Name = "NumericUpDown_createAgi";
			NumericUpDown_createAgi.Size = new Size(36, 19);
			NumericUpDown_createAgi.TabIndex = 68;
			RadioButton_phong.ForeColor = Color.LimeGreen;
			RadioButton_phong.Location = new Point(215, 56);
			RadioButton_phong.Margin = new Padding(2);
			RadioButton_phong.Name = "RadioButton_phong";
			RadioButton_phong.Size = new Size(68, 20);
			RadioButton_phong.TabIndex = 90;
			RadioButton_phong.Text = "Phong";
			RadioButton_phong.UseVisualStyleBackColor = true;
			NumericUpDown_createInt.Location = new Point(142, 81);
			NumericUpDown_createInt.Margin = new Padding(2);
			NumericUpDown_createInt.Maximum = new decimal(new int[4] { 6, 0, 0, 0 });
			NumericUpDown_createInt.Name = "NumericUpDown_createInt";
			NumericUpDown_createInt.Size = new Size(36, 19);
			NumericUpDown_createInt.TabIndex = 67;
			NumericUpDown_createInt.Value = new decimal(new int[4] { 6, 0, 0, 0 });
			TextBox_createName.Location = new Point(69, 30);
			TextBox_createName.Margin = new Padding(2);
			TextBox_createName.MaxLength = 14;
			TextBox_createName.Name = "TextBox_createName";
			TextBox_createName.Size = new Size(216, 19);
			TextBox_createName.TabIndex = 65;
			Label16.Location = new Point(34, 213);
			Label16.Margin = new Padding(0, 1, 0, 1);
			Label16.Name = "Label16";
			Label16.Size = new Size(96, 16);
			Label16.TabIndex = 82;
			Label16.Text = "Độ nhanh nhẹn";
			RadioButton_hoa.ForeColor = Color.LightCoral;
			RadioButton_hoa.Location = new Point(156, 56);
			RadioButton_hoa.Margin = new Padding(2);
			RadioButton_hoa.Name = "RadioButton_hoa";
			RadioButton_hoa.Size = new Size(55, 20);
			RadioButton_hoa.TabIndex = 89;
			RadioButton_hoa.Text = "Hoả";
			RadioButton_hoa.UseVisualStyleBackColor = true;
			TextBox_Pass.Location = new Point(104, 239);
			TextBox_Pass.Margin = new Padding(2);
			TextBox_Pass.MaxLength = 10;
			TextBox_Pass.Name = "TextBox_Pass";
			TextBox_Pass.Size = new Size(137, 19);
			TextBox_Pass.TabIndex = 73;
			Label11.Location = new Point(34, 83);
			Label11.Margin = new Padding(0, 1, 0, 1);
			Label11.Name = "Label11";
			Label11.Size = new Size(44, 16);
			Label11.TabIndex = 77;
			Label11.Text = "Trí lực";
			TextBox_amma.Location = new Point(104, 265);
			TextBox_amma.Margin = new Padding(2);
			TextBox_amma.MaxLength = 10;
			TextBox_amma.Name = "TextBox_amma";
			TextBox_amma.Size = new Size(137, 19);
			TextBox_amma.TabIndex = 74;
			Label19.Location = new Point(34, 268);
			Label19.Margin = new Padding(0, 1, 0, 1);
			Label19.Name = "Label19";
			Label19.Size = new Size(50, 16);
			Label19.TabIndex = 85;
			Label19.Text = "Ám mã";
			NumericUpDown_createAtk.Location = new Point(142, 107);
			NumericUpDown_createAtk.Margin = new Padding(2);
			NumericUpDown_createAtk.Maximum = new decimal(new int[4] { 6, 0, 0, 0 });
			NumericUpDown_createAtk.Name = "NumericUpDown_createAtk";
			NumericUpDown_createAtk.Size = new Size(36, 19);
			NumericUpDown_createAtk.TabIndex = 69;
			Label1.Location = new Point(34, 109);
			Label1.Margin = new Padding(0, 1, 0, 1);
			Label1.Name = "Label1";
			Label1.Size = new Size(90, 16);
			Label1.TabIndex = 78;
			Label1.Text = "Sức công phá";
			Label18.Location = new Point(34, 240);
			Label18.Margin = new Padding(0, 1, 0, 1);
			Label18.Name = "Label18";
			Label18.Size = new Size(63, 16);
			Label18.TabIndex = 84;
			Label18.Text = "Mật Khẩu";
			Label2.Location = new Point(34, 135);
			Label2.Margin = new Padding(0, 1, 0, 1);
			Label2.Name = "Label2";
			Label2.Size = new Size(92, 16);
			Label2.TabIndex = 79;
			Label2.Text = "Sức phòng thủ";
			NumericUpDown_createDef.Location = new Point(142, 133);
			NumericUpDown_createDef.Margin = new Padding(2);
			NumericUpDown_createDef.Maximum = new decimal(new int[4] { 6, 0, 0, 0 });
			NumericUpDown_createDef.Name = "NumericUpDown_createDef";
			NumericUpDown_createDef.Size = new Size(36, 19);
			NumericUpDown_createDef.TabIndex = 70;
			TabPage2.Controls.Add(TabControl_ItemSetting);
			TabPage2.Controls.Add(GroupBox4);
			TabPage2.Location = new Point(4, 30);
			TabPage2.Name = "TabPage2";
			TabPage2.Padding = new Padding(3);
			TabPage2.Size = new Size(649, 573);
			TabPage2.TabIndex = 3;
			TabPage2.Text = "Vật phẩm";
			TabPage2.UseVisualStyleBackColor = true;
			TabControl_ItemSetting.Controls.Add(TabPage11);
			TabControl_ItemSetting.Controls.Add(TabPage12);
			TabControl_ItemSetting.Controls.Add(TabPage1);
			TabControl_ItemSetting.Controls.Add(TabPage5);
			TabControl_ItemSetting.Dock = DockStyle.Fill;
			TabControl_ItemSetting.HotTrack = true;
			TabControl_ItemSetting.ItemSize = new Size(0, 20);
			TabControl_ItemSetting.Location = new Point(3, 42);
			TabControl_ItemSetting.Margin = new Padding(2);
			TabControl_ItemSetting.Multiline = true;
			TabControl_ItemSetting.Name = "TabControl_ItemSetting";
			TabControl_ItemSetting.SelectedIndex = 0;
			TabControl_ItemSetting.Size = new Size(643, 528);
			TabControl_ItemSetting.TabIndex = 73;
			TabPage11.Controls.Add(GroupBox5);
			TabPage11.Location = new Point(4, 24);
			TabPage11.Name = "TabPage11";
			TabPage11.Padding = new Padding(3);
			TabPage11.Size = new Size(635, 500);
			TabPage11.TabIndex = 0;
			TabPage11.Text = "Vứt đồ";
			TabPage11.UseVisualStyleBackColor = true;
			GroupBox5.BackColor = Color.Transparent;
			GroupBox5.Controls.Add(ListView_AutoDrop);
			GroupBox5.Controls.Add(CheckBox_DropMineWood);
			GroupBox5.Controls.Add(Button_AddIdDrop);
			GroupBox5.Controls.Add(TextBox_AddIdDrop);
			GroupBox5.Controls.Add(CheckBox_DropHpSp);
			GroupBox5.Controls.Add(CheckBox_DropSp);
			GroupBox5.Controls.Add(CheckBox_DropHp);
			GroupBox5.Controls.Add(Label63);
			GroupBox5.Controls.Add(TextBox_Drop_SpValue);
			GroupBox5.Controls.Add(Label61);
			GroupBox5.Controls.Add(TextBox_Drop_HpValue);
			GroupBox5.Dock = DockStyle.Fill;
			GroupBox5.Location = new Point(3, 3);
			GroupBox5.Margin = new Padding(2);
			GroupBox5.Name = "GroupBox5";
			GroupBox5.Padding = new Padding(2);
			GroupBox5.Size = new Size(629, 494);
			GroupBox5.TabIndex = 72;
			GroupBox5.TabStop = false;
			GroupBox5.Text = "Tự động vứt đồ";
			CheckBox_DropMineWood.FlatStyle = FlatStyle.System;
			CheckBox_DropMineWood.Location = new Point(12, 117);
			CheckBox_DropMineWood.Margin = new Padding(10, 2, 2, 2);
			CheckBox_DropMineWood.Name = "CheckBox_DropMineWood";
			CheckBox_DropMineWood.Size = new Size(109, 20);
			CheckBox_DropMineWood.TabIndex = 118;
			CheckBox_DropMineWood.Text = "Khoáng && Gỗ";
			CheckBox_DropMineWood.UseVisualStyleBackColor = true;
			Button_AddIdDrop.FlatStyle = FlatStyle.System;
			Button_AddIdDrop.Location = new Point(264, 283);
			Button_AddIdDrop.Margin = new Padding(2);
			Button_AddIdDrop.Name = "Button_AddIdDrop";
			Button_AddIdDrop.Size = new Size(60, 20);
			Button_AddIdDrop.TabIndex = 117;
			Button_AddIdDrop.Text = "Thêm";
			Button_AddIdDrop.UseVisualStyleBackColor = true;
			TextBox_AddIdDrop.Location = new Point(200, 283);
			TextBox_AddIdDrop.Margin = new Padding(2);
			TextBox_AddIdDrop.Multiline = true;
			TextBox_AddIdDrop.Name = "TextBox_AddIdDrop";
			TextBox_AddIdDrop.Size = new Size(60, 19);
			TextBox_AddIdDrop.TabIndex = 116;
			TextBox_AddIdDrop.Text = "0";
			CheckBox_DropHpSp.FlatStyle = FlatStyle.System;
			CheckBox_DropHpSp.Location = new Point(12, 93);
			CheckBox_DropHpSp.Margin = new Padding(10, 2, 2, 2);
			CheckBox_DropHpSp.Name = "CheckBox_DropHpSp";
			CheckBox_DropHpSp.Size = new Size(80, 20);
			CheckBox_DropHpSp.TabIndex = 115;
			CheckBox_DropHpSp.Text = "Hp && Sp";
			CheckBox_DropHpSp.UseVisualStyleBackColor = true;
			CheckBox_DropSp.FlatStyle = FlatStyle.System;
			CheckBox_DropSp.Location = new Point(12, 69);
			CheckBox_DropSp.Margin = new Padding(10, 2, 2, 2);
			CheckBox_DropSp.Name = "CheckBox_DropSp";
			CheckBox_DropSp.Size = new Size(47, 20);
			CheckBox_DropSp.TabIndex = 114;
			CheckBox_DropSp.Text = "Sp";
			CheckBox_DropSp.UseVisualStyleBackColor = true;
			CheckBox_DropHp.FlatStyle = FlatStyle.System;
			CheckBox_DropHp.Location = new Point(12, 45);
			CheckBox_DropHp.Margin = new Padding(10, 2, 2, 2);
			CheckBox_DropHp.Name = "CheckBox_DropHp";
			CheckBox_DropHp.Size = new Size(48, 20);
			CheckBox_DropHp.TabIndex = 113;
			CheckBox_DropHp.Text = "Hp";
			CheckBox_DropHp.UseVisualStyleBackColor = true;
			Label63.Location = new Point(97, 22);
			Label63.Margin = new Padding(0, 1, 0, 1);
			Label63.Name = "Label63";
			Label63.Size = new Size(35, 16);
			Label63.TabIndex = 112;
			Label63.Text = "Sp <";
			Label63.TextAlign = ContentAlignment.TopRight;
			TextBox_Drop_SpValue.Location = new Point(136, 19);
			TextBox_Drop_SpValue.Margin = new Padding(2);
			TextBox_Drop_SpValue.Name = "TextBox_Drop_SpValue";
			TextBox_Drop_SpValue.Size = new Size(40, 19);
			TextBox_Drop_SpValue.TabIndex = 111;
			TextBox_Drop_SpValue.Text = "40";
			Label61.Location = new Point(8, 22);
			Label61.Margin = new Padding(0, 1, 0, 1);
			Label61.Name = "Label61";
			Label61.Size = new Size(36, 16);
			Label61.TabIndex = 110;
			Label61.Text = "Hp <";
			Label61.TextAlign = ContentAlignment.TopRight;
			TextBox_Drop_HpValue.Location = new Point(48, 19);
			TextBox_Drop_HpValue.Margin = new Padding(2);
			TextBox_Drop_HpValue.Name = "TextBox_Drop_HpValue";
			TextBox_Drop_HpValue.Size = new Size(40, 19);
			TextBox_Drop_HpValue.TabIndex = 108;
			TextBox_Drop_HpValue.Text = "40";
			TabPage12.Controls.Add(GroupBox6);
			TabPage12.Location = new Point(4, 24);
			TabPage12.Name = "TabPage12";
			TabPage12.Padding = new Padding(3);
			TabPage12.Size = new Size(635, 500);
			TabPage12.TabIndex = 1;
			TabPage12.Text = "Đóng góp";
			TabPage12.UseVisualStyleBackColor = true;
			GroupBox6.BackColor = Color.Transparent;
			GroupBox6.Controls.Add(ListView_AutoContribute);
			GroupBox6.Controls.Add(CheckBox_ContributeMineWood);
			GroupBox6.Controls.Add(Button_AddIdContribute);
			GroupBox6.Controls.Add(TextBox_AddIdContribute);
			GroupBox6.Controls.Add(CheckBox_ContributeHpSp);
			GroupBox6.Controls.Add(CheckBox_ContributeSp);
			GroupBox6.Controls.Add(CheckBox_ContributeHp);
			GroupBox6.Controls.Add(Label64);
			GroupBox6.Controls.Add(TextBox_Contribute_SpValue);
			GroupBox6.Controls.Add(Label65);
			GroupBox6.Controls.Add(TextBox_Contribute_HpValue);
			GroupBox6.Dock = DockStyle.Fill;
			GroupBox6.Location = new Point(3, 3);
			GroupBox6.Margin = new Padding(2);
			GroupBox6.Name = "GroupBox6";
			GroupBox6.Padding = new Padding(2);
			GroupBox6.Size = new Size(629, 494);
			GroupBox6.TabIndex = 73;
			GroupBox6.TabStop = false;
			GroupBox6.Text = "Tự động đóng góp";
			CheckBox_ContributeMineWood.FlatStyle = FlatStyle.System;
			CheckBox_ContributeMineWood.Location = new Point(12, 117);
			CheckBox_ContributeMineWood.Margin = new Padding(10, 2, 2, 2);
			CheckBox_ContributeMineWood.Name = "CheckBox_ContributeMineWood";
			CheckBox_ContributeMineWood.Size = new Size(109, 20);
			CheckBox_ContributeMineWood.TabIndex = 132;
			CheckBox_ContributeMineWood.Text = "Khoáng && Gỗ";
			CheckBox_ContributeMineWood.UseVisualStyleBackColor = true;
			Button_AddIdContribute.FlatStyle = FlatStyle.System;
			Button_AddIdContribute.Location = new Point(264, 283);
			Button_AddIdContribute.Margin = new Padding(2);
			Button_AddIdContribute.Name = "Button_AddIdContribute";
			Button_AddIdContribute.Size = new Size(60, 20);
			Button_AddIdContribute.TabIndex = 131;
			Button_AddIdContribute.Text = "Thêm";
			Button_AddIdContribute.UseVisualStyleBackColor = true;
			TextBox_AddIdContribute.Location = new Point(200, 283);
			TextBox_AddIdContribute.Margin = new Padding(2);
			TextBox_AddIdContribute.Multiline = true;
			TextBox_AddIdContribute.Name = "TextBox_AddIdContribute";
			TextBox_AddIdContribute.Size = new Size(60, 19);
			TextBox_AddIdContribute.TabIndex = 130;
			TextBox_AddIdContribute.Text = "0";
			CheckBox_ContributeHpSp.FlatStyle = FlatStyle.System;
			CheckBox_ContributeHpSp.Location = new Point(12, 93);
			CheckBox_ContributeHpSp.Margin = new Padding(10, 2, 2, 2);
			CheckBox_ContributeHpSp.Name = "CheckBox_ContributeHpSp";
			CheckBox_ContributeHpSp.Size = new Size(80, 20);
			CheckBox_ContributeHpSp.TabIndex = 129;
			CheckBox_ContributeHpSp.Text = "Hp && Sp";
			CheckBox_ContributeHpSp.UseVisualStyleBackColor = true;
			CheckBox_ContributeSp.FlatStyle = FlatStyle.System;
			CheckBox_ContributeSp.Location = new Point(12, 69);
			CheckBox_ContributeSp.Margin = new Padding(10, 2, 2, 2);
			CheckBox_ContributeSp.Name = "CheckBox_ContributeSp";
			CheckBox_ContributeSp.Size = new Size(47, 20);
			CheckBox_ContributeSp.TabIndex = 128;
			CheckBox_ContributeSp.Text = "Sp";
			CheckBox_ContributeSp.UseVisualStyleBackColor = true;
			CheckBox_ContributeHp.FlatStyle = FlatStyle.System;
			CheckBox_ContributeHp.Location = new Point(12, 45);
			CheckBox_ContributeHp.Margin = new Padding(10, 2, 2, 2);
			CheckBox_ContributeHp.Name = "CheckBox_ContributeHp";
			CheckBox_ContributeHp.Size = new Size(48, 20);
			CheckBox_ContributeHp.TabIndex = 127;
			CheckBox_ContributeHp.Text = "Hp";
			CheckBox_ContributeHp.UseVisualStyleBackColor = true;
			Label64.Location = new Point(97, 22);
			Label64.Margin = new Padding(0, 1, 0, 1);
			Label64.Name = "Label64";
			Label64.Size = new Size(35, 16);
			Label64.TabIndex = 126;
			Label64.Text = "Sp <";
			Label64.TextAlign = ContentAlignment.TopRight;
			TextBox_Contribute_SpValue.Location = new Point(136, 19);
			TextBox_Contribute_SpValue.Margin = new Padding(2);
			TextBox_Contribute_SpValue.Name = "TextBox_Contribute_SpValue";
			TextBox_Contribute_SpValue.Size = new Size(40, 19);
			TextBox_Contribute_SpValue.TabIndex = 125;
			TextBox_Contribute_SpValue.Text = "40";
			Label65.Location = new Point(8, 22);
			Label65.Margin = new Padding(0, 1, 0, 1);
			Label65.Name = "Label65";
			Label65.Size = new Size(36, 16);
			Label65.TabIndex = 124;
			Label65.Text = "Hp <";
			Label65.TextAlign = ContentAlignment.TopRight;
			TextBox_Contribute_HpValue.Location = new Point(48, 19);
			TextBox_Contribute_HpValue.Margin = new Padding(2);
			TextBox_Contribute_HpValue.Name = "TextBox_Contribute_HpValue";
			TextBox_Contribute_HpValue.Size = new Size(40, 19);
			TextBox_Contribute_HpValue.TabIndex = 123;
			TextBox_Contribute_HpValue.Text = "40";
			TabPage1.Controls.Add(GroupBox7);
			TabPage1.Location = new Point(4, 24);
			TabPage1.Name = "TabPage1";
			TabPage1.Padding = new Padding(3);
			TabPage1.Size = new Size(635, 500);
			TabPage1.TabIndex = 2;
			TabPage1.Text = "Gửi đồ";
			TabPage1.UseVisualStyleBackColor = true;
			GroupBox7.BackColor = Color.Transparent;
			GroupBox7.Controls.Add(ListView_AutoSend);
			GroupBox7.Controls.Add(Label75);
			GroupBox7.Controls.Add(TextBox_AutoSend);
			GroupBox7.Controls.Add(CheckBox_SendMineWood);
			GroupBox7.Controls.Add(Button_AddIdSend);
			GroupBox7.Controls.Add(TextBox_AddIdSend);
			GroupBox7.Controls.Add(CheckBox_SendHpSp);
			GroupBox7.Controls.Add(CheckBox_SendSp);
			GroupBox7.Controls.Add(CheckBox_SendHp);
			GroupBox7.Controls.Add(Label72);
			GroupBox7.Controls.Add(TextBox_Send_SpValue);
			GroupBox7.Controls.Add(Label73);
			GroupBox7.Controls.Add(TextBox_Send_HpValue);
			GroupBox7.Dock = DockStyle.Fill;
			GroupBox7.Location = new Point(3, 3);
			GroupBox7.Margin = new Padding(2);
			GroupBox7.Name = "GroupBox7";
			GroupBox7.Padding = new Padding(2);
			GroupBox7.Size = new Size(629, 494);
			GroupBox7.TabIndex = 74;
			GroupBox7.TabStop = false;
			GroupBox7.Text = "Tự động gửi đồ";
			Label75.FlatStyle = FlatStyle.System;
			Label75.Location = new Point(9, 181);
			Label75.Margin = new Padding(2);
			Label75.Name = "Label75";
			Label75.Size = new Size(83, 15);
			Label75.TabIndex = 136;
			Label75.Text = "ID Nguoi nhan :";
			Label75.TextAlign = ContentAlignment.TopRight;
			TextBox_AutoSend.Location = new Point(96, 181);
			TextBox_AutoSend.Margin = new Padding(2);
			TextBox_AutoSend.MaxLength = 20;
			TextBox_AutoSend.Multiline = true;
			TextBox_AutoSend.Name = "TextBox_AutoSend";
			TextBox_AutoSend.Size = new Size(100, 19);
			TextBox_AutoSend.TabIndex = 135;
			CheckBox_SendMineWood.FlatStyle = FlatStyle.System;
			CheckBox_SendMineWood.Location = new Point(12, 117);
			CheckBox_SendMineWood.Margin = new Padding(10, 2, 2, 2);
			CheckBox_SendMineWood.Name = "CheckBox_SendMineWood";
			CheckBox_SendMineWood.Size = new Size(109, 20);
			CheckBox_SendMineWood.TabIndex = 134;
			CheckBox_SendMineWood.Text = "Khoáng && Gỗ";
			CheckBox_SendMineWood.UseVisualStyleBackColor = true;
			Button_AddIdSend.FlatStyle = FlatStyle.System;
			Button_AddIdSend.Location = new Point(264, 283);
			Button_AddIdSend.Margin = new Padding(2);
			Button_AddIdSend.Name = "Button_AddIdSend";
			Button_AddIdSend.Size = new Size(60, 20);
			Button_AddIdSend.TabIndex = 133;
			Button_AddIdSend.Text = "Thêm";
			Button_AddIdSend.UseVisualStyleBackColor = true;
			TextBox_AddIdSend.Location = new Point(200, 283);
			TextBox_AddIdSend.Margin = new Padding(2);
			TextBox_AddIdSend.Multiline = true;
			TextBox_AddIdSend.Name = "TextBox_AddIdSend";
			TextBox_AddIdSend.Size = new Size(60, 19);
			TextBox_AddIdSend.TabIndex = 132;
			TextBox_AddIdSend.Text = "0";
			CheckBox_SendHpSp.FlatStyle = FlatStyle.System;
			CheckBox_SendHpSp.Location = new Point(12, 93);
			CheckBox_SendHpSp.Margin = new Padding(10, 2, 2, 2);
			CheckBox_SendHpSp.Name = "CheckBox_SendHpSp";
			CheckBox_SendHpSp.Size = new Size(80, 20);
			CheckBox_SendHpSp.TabIndex = 131;
			CheckBox_SendHpSp.Text = "Hp && Sp";
			CheckBox_SendHpSp.UseVisualStyleBackColor = true;
			CheckBox_SendSp.FlatStyle = FlatStyle.System;
			CheckBox_SendSp.Location = new Point(12, 69);
			CheckBox_SendSp.Margin = new Padding(10, 2, 2, 2);
			CheckBox_SendSp.Name = "CheckBox_SendSp";
			CheckBox_SendSp.Size = new Size(47, 20);
			CheckBox_SendSp.TabIndex = 130;
			CheckBox_SendSp.Text = "Sp";
			CheckBox_SendSp.UseVisualStyleBackColor = true;
			CheckBox_SendHp.FlatStyle = FlatStyle.System;
			CheckBox_SendHp.Location = new Point(12, 45);
			CheckBox_SendHp.Margin = new Padding(10, 2, 2, 2);
			CheckBox_SendHp.Name = "CheckBox_SendHp";
			CheckBox_SendHp.Size = new Size(48, 20);
			CheckBox_SendHp.TabIndex = 129;
			CheckBox_SendHp.Text = "Hp";
			CheckBox_SendHp.UseVisualStyleBackColor = true;
			Label72.Location = new Point(97, 22);
			Label72.Margin = new Padding(0, 1, 0, 1);
			Label72.Name = "Label72";
			Label72.Size = new Size(35, 16);
			Label72.TabIndex = 128;
			Label72.Text = "Sp <";
			Label72.TextAlign = ContentAlignment.TopRight;
			TextBox_Send_SpValue.Location = new Point(136, 19);
			TextBox_Send_SpValue.Margin = new Padding(2);
			TextBox_Send_SpValue.Name = "TextBox_Send_SpValue";
			TextBox_Send_SpValue.Size = new Size(40, 19);
			TextBox_Send_SpValue.TabIndex = 127;
			TextBox_Send_SpValue.Text = "40";
			Label73.Location = new Point(8, 22);
			Label73.Margin = new Padding(0, 1, 0, 1);
			Label73.Name = "Label73";
			Label73.Size = new Size(36, 16);
			Label73.TabIndex = 126;
			Label73.Text = "Hp <";
			Label73.TextAlign = ContentAlignment.TopRight;
			TextBox_Send_HpValue.Location = new Point(48, 19);
			TextBox_Send_HpValue.Margin = new Padding(2);
			TextBox_Send_HpValue.Name = "TextBox_Send_HpValue";
			TextBox_Send_HpValue.Size = new Size(40, 19);
			TextBox_Send_HpValue.TabIndex = 125;
			TextBox_Send_HpValue.Text = "40";
			TabPage5.Controls.Add(GroupBox10);
			TabPage5.Location = new Point(4, 24);
			TabPage5.Name = "TabPage5";
			TabPage5.Padding = new Padding(3);
			TabPage5.Size = new Size(635, 500);
			TabPage5.TabIndex = 3;
			TabPage5.Text = "Bán Đồ";
			TabPage5.UseVisualStyleBackColor = true;
			GroupBox10.BackColor = Color.Transparent;
			GroupBox10.Controls.Add(ListView_AutoSell);
			GroupBox10.Controls.Add(CheckBox_SellMineWood);
			GroupBox10.Controls.Add(Button_AddIdSell);
			GroupBox10.Controls.Add(TextBox_AddIdSell);
			GroupBox10.Controls.Add(CheckBox_SellHpSp);
			GroupBox10.Controls.Add(CheckBox_SellSP);
			GroupBox10.Controls.Add(CheckBox_SellHp);
			GroupBox10.Controls.Add(Label12);
			GroupBox10.Controls.Add(TextBox_Sell_SpValue);
			GroupBox10.Controls.Add(Label80);
			GroupBox10.Controls.Add(TextBox_Sell_HpValue);
			GroupBox10.Dock = DockStyle.Fill;
			GroupBox10.Location = new Point(3, 3);
			GroupBox10.Margin = new Padding(2);
			GroupBox10.Name = "GroupBox10";
			GroupBox10.Padding = new Padding(2);
			GroupBox10.Size = new Size(629, 494);
			GroupBox10.TabIndex = 73;
			GroupBox10.TabStop = false;
			GroupBox10.Text = "Tự động bán đồ";
			CheckBox_SellMineWood.FlatStyle = FlatStyle.System;
			CheckBox_SellMineWood.Location = new Point(12, 117);
			CheckBox_SellMineWood.Margin = new Padding(10, 2, 2, 2);
			CheckBox_SellMineWood.Name = "CheckBox_SellMineWood";
			CheckBox_SellMineWood.Size = new Size(109, 20);
			CheckBox_SellMineWood.TabIndex = 118;
			CheckBox_SellMineWood.Text = "Khoáng && Gỗ";
			CheckBox_SellMineWood.UseVisualStyleBackColor = true;
			Button_AddIdSell.FlatStyle = FlatStyle.System;
			Button_AddIdSell.Location = new Point(264, 283);
			Button_AddIdSell.Margin = new Padding(2);
			Button_AddIdSell.Name = "Button_AddIdSell";
			Button_AddIdSell.Size = new Size(60, 20);
			Button_AddIdSell.TabIndex = 117;
			Button_AddIdSell.Text = "Thêm";
			Button_AddIdSell.UseVisualStyleBackColor = true;
			TextBox_AddIdSell.Location = new Point(200, 283);
			TextBox_AddIdSell.Margin = new Padding(2);
			TextBox_AddIdSell.Multiline = true;
			TextBox_AddIdSell.Name = "TextBox_AddIdSell";
			TextBox_AddIdSell.Size = new Size(60, 19);
			TextBox_AddIdSell.TabIndex = 116;
			TextBox_AddIdSell.Text = "0";
			CheckBox_SellHpSp.FlatStyle = FlatStyle.System;
			CheckBox_SellHpSp.Location = new Point(12, 93);
			CheckBox_SellHpSp.Margin = new Padding(10, 2, 2, 2);
			CheckBox_SellHpSp.Name = "CheckBox_SellHpSp";
			CheckBox_SellHpSp.Size = new Size(80, 20);
			CheckBox_SellHpSp.TabIndex = 115;
			CheckBox_SellHpSp.Text = "Hp && Sp";
			CheckBox_SellHpSp.UseVisualStyleBackColor = true;
			CheckBox_SellSP.FlatStyle = FlatStyle.System;
			CheckBox_SellSP.Location = new Point(12, 69);
			CheckBox_SellSP.Margin = new Padding(10, 2, 2, 2);
			CheckBox_SellSP.Name = "CheckBox_SellSP";
			CheckBox_SellSP.Size = new Size(47, 20);
			CheckBox_SellSP.TabIndex = 114;
			CheckBox_SellSP.Text = "Sp";
			CheckBox_SellSP.UseVisualStyleBackColor = true;
			CheckBox_SellHp.FlatStyle = FlatStyle.System;
			CheckBox_SellHp.Location = new Point(12, 45);
			CheckBox_SellHp.Margin = new Padding(10, 2, 2, 2);
			CheckBox_SellHp.Name = "CheckBox_SellHp";
			CheckBox_SellHp.Size = new Size(48, 20);
			CheckBox_SellHp.TabIndex = 113;
			CheckBox_SellHp.Text = "Hp";
			CheckBox_SellHp.UseVisualStyleBackColor = true;
			Label12.Location = new Point(97, 22);
			Label12.Margin = new Padding(0, 1, 0, 1);
			Label12.Name = "Label12";
			Label12.Size = new Size(35, 16);
			Label12.TabIndex = 112;
			Label12.Text = "May chu: TS Online";
			Label12.TextAlign = ContentAlignment.TopRight;
			TextBox_Sell_SpValue.Location = new Point(136, 19);
			TextBox_Sell_SpValue.Margin = new Padding(2);
			TextBox_Sell_SpValue.Name = "TextBox_Sell_SpValue";
			TextBox_Sell_SpValue.Size = new Size(40, 19);
			TextBox_Sell_SpValue.TabIndex = 111;
			TextBox_Sell_SpValue.Text = "40";
			Label80.Location = new Point(8, 22);
			Label80.Margin = new Padding(0, 1, 0, 1);
			Label80.Name = "Label80";
			Label80.Size = new Size(36, 16);
			Label80.TabIndex = 110;
			Label80.Text = "Hp <";
			Label80.TextAlign = ContentAlignment.TopRight;
			TextBox_Sell_HpValue.Location = new Point(48, 19);
			TextBox_Sell_HpValue.Margin = new Padding(2);
			TextBox_Sell_HpValue.Name = "TextBox_Sell_HpValue";
			TextBox_Sell_HpValue.Size = new Size(40, 19);
			TextBox_Sell_HpValue.TabIndex = 108;
			TextBox_Sell_HpValue.Text = "40";
			GroupBox4.Controls.Add(CheckBox_AutoPickup);
			GroupBox4.Controls.Add(NumericUpDown_ItemCountPickup);
			GroupBox4.Dock = DockStyle.Top;
			GroupBox4.Location = new Point(3, 3);
			GroupBox4.Margin = new Padding(2);
			GroupBox4.Name = "GroupBox4";
			GroupBox4.Padding = new Padding(2);
			GroupBox4.Size = new Size(643, 39);
			GroupBox4.TabIndex = 71;
			GroupBox4.TabStop = false;
			GroupBox4.Text = "Nhặt đồ";
			CheckBox_AutoPickup.Location = new Point(10, 16);
			CheckBox_AutoPickup.Margin = new Padding(10, 2, 2, 2);
			CheckBox_AutoPickup.Name = "CheckBox_AutoPickup";
			CheckBox_AutoPickup.Size = new Size(249, 20);
			CheckBox_AutoPickup.TabIndex = 70;
			CheckBox_AutoPickup.Text = "Tự động nhặt đồ, số đồ nhặt mỗi giây";
			CheckBox_AutoPickup.UseVisualStyleBackColor = true;
			NumericUpDown_ItemCountPickup.Location = new Point(263, 13);
			NumericUpDown_ItemCountPickup.Margin = new Padding(2);
			NumericUpDown_ItemCountPickup.Maximum = new decimal(new int[4] { 255, 0, 0, 0 });
			NumericUpDown_ItemCountPickup.Minimum = new decimal(new int[4] { 5, 0, 0, 0 });
			NumericUpDown_ItemCountPickup.Name = "NumericUpDown_ItemCountPickup";
			NumericUpDown_ItemCountPickup.Size = new Size(61, 19);
			NumericUpDown_ItemCountPickup.TabIndex = 69;
			NumericUpDown_ItemCountPickup.Value = new decimal(new int[4] { 5, 0, 0, 0 });
			TabPage6.Controls.Add(GroupBox11);
			TabPage6.Controls.Add(CheckBox_OpenMachine);
			TabPage6.Location = new Point(4, 30);
			TabPage6.Name = "TabPage6";
			TabPage6.Padding = new Padding(3);
			TabPage6.Size = new Size(649, 573);
			TabPage6.TabIndex = 4;
			TabPage6.Text = "Mini";
			TabPage6.UseVisualStyleBackColor = true;
			GroupBox11.Controls.Add(Label84);
			GroupBox11.Controls.Add(TextBox_OpenMachine_PetSp);
			GroupBox11.Controls.Add(Label85);
			GroupBox11.Controls.Add(TextBox_OpenMachine_PetHp);
			GroupBox11.Controls.Add(Label86);
			GroupBox11.Controls.Add(Label87);
			GroupBox11.Controls.Add(Label88);
			GroupBox11.Controls.Add(TextBox_OpenMachine_CharSp);
			GroupBox11.Controls.Add(Label89);
			GroupBox11.Controls.Add(TextBox_OpenMachine_CharHp);
			GroupBox11.Controls.Add(Label90);
			GroupBox11.Controls.Add(Label91);
			GroupBox11.Dock = DockStyle.Top;
			GroupBox11.Location = new Point(3, 24);
			GroupBox11.Margin = new Padding(2);
			GroupBox11.Name = "GroupBox11";
			GroupBox11.Size = new Size(643, 124);
			GroupBox11.TabIndex = 95;
			GroupBox11.TabStop = false;
			GroupBox11.Text = "Dùng thuốc";
			Label84.AutoSize = true;
			Label84.Location = new Point(159, 94);
			Label84.Margin = new Padding(0, 1, 0, 1);
			Label84.Name = "Label84";
			Label84.Size = new Size(16, 13);
			Label84.TabIndex = 14;
			Label84.Text = "%";
			TextBox_OpenMachine_PetSp.Location = new Point(135, 91);
			TextBox_OpenMachine_PetSp.Margin = new Padding(2);
			TextBox_OpenMachine_PetSp.MaxLength = 2;
			TextBox_OpenMachine_PetSp.Name = "TextBox_OpenMachine_PetSp";
			TextBox_OpenMachine_PetSp.Size = new Size(22, 19);
			TextBox_OpenMachine_PetSp.TabIndex = 13;
			TextBox_OpenMachine_PetSp.Text = "30";
			TextBox_OpenMachine_PetSp.TextAlign = HorizontalAlignment.Right;
			Label85.AutoSize = true;
			Label85.Location = new Point(159, 68);
			Label85.Margin = new Padding(0, 1, 0, 1);
			Label85.Name = "Label85";
			Label85.Size = new Size(16, 13);
			Label85.TabIndex = 12;
			Label85.Text = "%";
			TextBox_OpenMachine_PetHp.Location = new Point(135, 65);
			TextBox_OpenMachine_PetHp.Margin = new Padding(2);
			TextBox_OpenMachine_PetHp.MaxLength = 2;
			TextBox_OpenMachine_PetHp.Name = "TextBox_OpenMachine_PetHp";
			TextBox_OpenMachine_PetHp.Size = new Size(22, 19);
			TextBox_OpenMachine_PetHp.TabIndex = 11;
			TextBox_OpenMachine_PetHp.Text = "80";
			TextBox_OpenMachine_PetHp.TextAlign = HorizontalAlignment.Right;
			Label86.Location = new Point(3, 94);
			Label86.Margin = new Padding(0, 1, 0, 1);
			Label86.Name = "Label86";
			Label86.Size = new Size(130, 16);
			Label86.TabIndex = 10;
			Label86.Text = "Khi SP võ tướng khi ít hơn";
			Label86.TextAlign = ContentAlignment.TopRight;
			Label87.Location = new Point(3, 68);
			Label87.Margin = new Padding(0, 1, 0, 1);
			Label87.Name = "Label87";
			Label87.Size = new Size(130, 16);
			Label87.TabIndex = 9;
			Label87.Text = "Khi HP võ tướng khi ít hơn";
			Label87.TextAlign = ContentAlignment.TopRight;
			Label88.AutoSize = true;
			Label88.Location = new Point(159, 42);
			Label88.Margin = new Padding(0, 1, 0, 1);
			Label88.Name = "Label88";
			Label88.Size = new Size(16, 13);
			Label88.TabIndex = 8;
			Label88.Text = "%";
			TextBox_OpenMachine_CharSp.Location = new Point(135, 39);
			TextBox_OpenMachine_CharSp.Margin = new Padding(2);
			TextBox_OpenMachine_CharSp.MaxLength = 2;
			TextBox_OpenMachine_CharSp.Name = "TextBox_OpenMachine_CharSp";
			TextBox_OpenMachine_CharSp.Size = new Size(22, 19);
			TextBox_OpenMachine_CharSp.TabIndex = 7;
			TextBox_OpenMachine_CharSp.Text = "30";
			TextBox_OpenMachine_CharSp.TextAlign = HorizontalAlignment.Right;
			Label89.AutoSize = true;
			Label89.Location = new Point(159, 16);
			Label89.Margin = new Padding(0, 1, 0, 1);
			Label89.Name = "Label89";
			Label89.Size = new Size(16, 13);
			Label89.TabIndex = 6;
			Label89.Text = "%";
			TextBox_OpenMachine_CharHp.Location = new Point(135, 13);
			TextBox_OpenMachine_CharHp.Margin = new Padding(2);
			TextBox_OpenMachine_CharHp.MaxLength = 2;
			TextBox_OpenMachine_CharHp.Name = "TextBox_OpenMachine_CharHp";
			TextBox_OpenMachine_CharHp.Size = new Size(22, 19);
			TextBox_OpenMachine_CharHp.TabIndex = 5;
			TextBox_OpenMachine_CharHp.Text = "80";
			TextBox_OpenMachine_CharHp.TextAlign = HorizontalAlignment.Right;
			Label90.Location = new Point(3, 42);
			Label90.Margin = new Padding(0, 1, 0, 1);
			Label90.Name = "Label90";
			Label90.Size = new Size(130, 16);
			Label90.TabIndex = 1;
			Label90.Text = "Khi SP nhân vật khi ít hơn";
			Label90.TextAlign = ContentAlignment.TopRight;
			Label91.Location = new Point(3, 16);
			Label91.Margin = new Padding(0, 1, 0, 1);
			Label91.Name = "Label91";
			Label91.Size = new Size(130, 16);
			Label91.TabIndex = 0;
			Label91.Text = "Khi HP nhân vật khi ít hơn";
			Label91.TextAlign = ContentAlignment.TopRight;
			CheckBox_OpenMachine.Checked = true;
			CheckBox_OpenMachine.CheckState = CheckState.Checked;
			CheckBox_OpenMachine.Dock = DockStyle.Top;
			CheckBox_OpenMachine.FlatStyle = FlatStyle.System;
			CheckBox_OpenMachine.Location = new Point(3, 3);
			CheckBox_OpenMachine.Margin = new Padding(10, 2, 2, 2);
			CheckBox_OpenMachine.Name = "CheckBox_OpenMachine";
			CheckBox_OpenMachine.Size = new Size(643, 21);
			CheckBox_OpenMachine.TabIndex = 2;
			CheckBox_OpenMachine.Text = "Tự động mở hộp mật thất";
			CheckBox_OpenMachine.UseVisualStyleBackColor = true;
			TabPage4.Controls.Add(Button_IdAdd);
			TabPage4.Controls.Add(DataGridView_Pickup);
			TabPage4.Controls.Add(TextBox_IdAdd);
			TabPage4.Controls.Add(Panel4);
			TabPage4.Controls.Add(CheckBox_Pickup);
			TabPage4.Location = new Point(4, 30);
			TabPage4.Name = "TabPage4";
			TabPage4.Padding = new Padding(3);
			TabPage4.Size = new Size(649, 573);
			TabPage4.TabIndex = 5;
			TabPage4.Text = "Nhặt đồ";
			TabPage4.UseVisualStyleBackColor = true;
			Button_IdAdd.Location = new Point(72, 29);
			Button_IdAdd.Name = "Button_IdAdd";
			Button_IdAdd.Size = new Size(75, 21);
			Button_IdAdd.TabIndex = 113;
			Button_IdAdd.Text = "Thêm";
			Button_IdAdd.UseVisualStyleBackColor = true;
			Button_IdAdd.Visible = false;
			TextBox_IdAdd.Location = new Point(6, 29);
			TextBox_IdAdd.Margin = new Padding(0, 2, 2, 2);
			TextBox_IdAdd.MaxLength = 5;
			TextBox_IdAdd.Multiline = true;
			TextBox_IdAdd.Name = "TextBox_IdAdd";
			TextBox_IdAdd.Size = new Size(61, 19);
			TextBox_IdAdd.TabIndex = 112;
			TextBox_IdAdd.Text = "0";
			TextBox_IdAdd.Visible = false;
			Panel4.Controls.Add(DataGridView_ItemOnMap);
			Panel4.Controls.Add(Label3);
			Panel4.Dock = DockStyle.Right;
			Panel4.Location = new Point(370, 3);
			Panel4.Name = "Panel4";
			Panel4.Padding = new Padding(10, 0, 0, 0);
			Panel4.Size = new Size(276, 567);
			Panel4.TabIndex = 111;
			Panel4.Visible = false;
			DataGridView_ItemOnMap.AllowUserToAddRows = false;
			DataGridView_ItemOnMap.AllowUserToDeleteRows = false;
			DataGridView_ItemOnMap.AllowUserToResizeColumns = false;
			DataGridView_ItemOnMap.AllowUserToResizeRows = false;
			dataGridViewCellStyle.BackColor = SystemColors.Control;
			DataGridView_ItemOnMap.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
			DataGridView_ItemOnMap.AutoGenerateColumns = false;
			DataGridView_ItemOnMap.BackgroundColor = SystemColors.ControlLightLight;
			DataGridView_ItemOnMap.BorderStyle = BorderStyle.Fixed3D;
			DataGridView_ItemOnMap.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			DataGridView_ItemOnMap.ColumnHeadersHeight = 20;
			DataGridView_ItemOnMap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			DataGridView_ItemOnMap.Columns.AddRange(GoldDataGridViewTextBoxColumn, IdDataGridViewTextBoxColumn, ItemNameDataGridViewTextBoxColumn, MapXDataGridViewTextBoxColumn, MapYDataGridViewTextBoxColumn);
			DataGridView_ItemOnMap.DataMember = "Table_ItemOnMap";
			DataGridView_ItemOnMap.DataSource = DataSet1;
			DataGridView_ItemOnMap.Dock = DockStyle.Fill;
			DataGridView_ItemOnMap.Location = new Point(10, 13);
			DataGridView_ItemOnMap.Margin = new Padding(2);
			DataGridView_ItemOnMap.MultiSelect = false;
			DataGridView_ItemOnMap.Name = "DataGridView_ItemOnMap";
			DataGridView_ItemOnMap.ReadOnly = true;
			DataGridView_ItemOnMap.RowHeadersVisible = false;
			DataGridView_ItemOnMap.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			DataGridView_ItemOnMap.RowTemplate.Height = 14;
			DataGridView_ItemOnMap.RowTemplate.Resizable = DataGridViewTriState.False;
			DataGridView_ItemOnMap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			DataGridView_ItemOnMap.Size = new Size(266, 554);
			DataGridView_ItemOnMap.TabIndex = 108;
			GoldDataGridViewTextBoxColumn.DataPropertyName = "Gold";
			GoldDataGridViewTextBoxColumn.FillWeight = 40f;
			GoldDataGridViewTextBoxColumn.HeaderText = "Gold";
			GoldDataGridViewTextBoxColumn.Name = "GoldDataGridViewTextBoxColumn";
			GoldDataGridViewTextBoxColumn.ReadOnly = true;
			GoldDataGridViewTextBoxColumn.Width = 40;
			IdDataGridViewTextBoxColumn.DataPropertyName = "Id";
			IdDataGridViewTextBoxColumn.FillWeight = 40f;
			IdDataGridViewTextBoxColumn.HeaderText = "Id";
			IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn";
			IdDataGridViewTextBoxColumn.ReadOnly = true;
			IdDataGridViewTextBoxColumn.Width = 40;
			ItemNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			ItemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
			ItemNameDataGridViewTextBoxColumn.HeaderText = "Tên";
			ItemNameDataGridViewTextBoxColumn.Name = "ItemNameDataGridViewTextBoxColumn";
			ItemNameDataGridViewTextBoxColumn.ReadOnly = true;
			MapXDataGridViewTextBoxColumn.DataPropertyName = "MapX";
			MapXDataGridViewTextBoxColumn.FillWeight = 35f;
			MapXDataGridViewTextBoxColumn.HeaderText = "X";
			MapXDataGridViewTextBoxColumn.Name = "MapXDataGridViewTextBoxColumn";
			MapXDataGridViewTextBoxColumn.ReadOnly = true;
			MapXDataGridViewTextBoxColumn.Width = 35;
			MapYDataGridViewTextBoxColumn.DataPropertyName = "MapY";
			MapYDataGridViewTextBoxColumn.FillWeight = 35f;
			MapYDataGridViewTextBoxColumn.HeaderText = "Y";
			MapYDataGridViewTextBoxColumn.Name = "MapYDataGridViewTextBoxColumn";
			MapYDataGridViewTextBoxColumn.ReadOnly = true;
			MapYDataGridViewTextBoxColumn.Width = 35;
			Label3.AutoSize = true;
			Label3.Dock = DockStyle.Top;
			Label3.Location = new Point(10, 0);
			Label3.Name = "Label3";
			Label3.Size = new Size(115, 13);
			Label3.TabIndex = 109;
			Label3.Text = "Vật phẩm trong bản đồ";
			CheckBox_Pickup.AutoSize = true;
			CheckBox_Pickup.Location = new Point(6, 6);
			CheckBox_Pickup.Name = "CheckBox_Pickup";
			CheckBox_Pickup.Size = new Size(103, 17);
			CheckBox_Pickup.TabIndex = 109;
			CheckBox_Pickup.Text = "Tự động nhặt đồ";
			CheckBox_Pickup.UseVisualStyleBackColor = true;
			CheckBox_Pickup.Visible = false;
			TabPage_Shop.Controls.Add(Button_ShopAdd);
			TabPage_Shop.Controls.Add(Button_Shop_Start);
			TabPage_Shop.Controls.Add(Label40);
			TabPage_Shop.Controls.Add(TextBox_ShopName);
			TabPage_Shop.Controls.Add(Label39);
			TabPage_Shop.Controls.Add(Label_ShopName);
			TabPage_Shop.Controls.Add(TextBox_ShopAddPrice);
			TabPage_Shop.Controls.Add(Label38);
			TabPage_Shop.Controls.Add(TextBox_ShopAddId);
			TabPage_Shop.Controls.Add(ComboBox_ShopType);
			TabPage_Shop.Controls.Add(ListView_Shop);
			TabPage_Shop.Location = new Point(4, 30);
			TabPage_Shop.Name = "TabPage_Shop";
			TabPage_Shop.Padding = new Padding(3);
			TabPage_Shop.Size = new Size(663, 613);
			TabPage_Shop.TabIndex = 6;
			TabPage_Shop.Text = "Bày bán";
			TabPage_Shop.UseVisualStyleBackColor = true;
			Button_ShopAdd.Location = new Point(446, 247);
			Button_ShopAdd.Name = "Button_ShopAdd";
			Button_ShopAdd.Size = new Size(75, 23);
			Button_ShopAdd.TabIndex = 126;
			Button_ShopAdd.Text = "Thêm";
			Button_ShopAdd.UseVisualStyleBackColor = true;
			Button_Shop_Start.Location = new Point(446, 20);
			Button_Shop_Start.Name = "Button_Shop_Start";
			Button_Shop_Start.Size = new Size(75, 23);
			Button_Shop_Start.TabIndex = 121;
			Button_Shop_Start.Text = "Bày bán";
			Button_Shop_Start.UseVisualStyleBackColor = true;
			Label40.AutoSize = true;
			Label40.BackColor = Color.FromArgb(240, 240, 240);
			Label40.FlatStyle = FlatStyle.System;
			Label40.Location = new Point(238, 252);
			Label40.Margin = new Padding(2);
			Label40.Name = "Label40";
			Label40.Size = new Size(75, 13);
			Label40.TabIndex = 125;
			Label40.Text = "Giá cho 1 món";
			TextBox_ShopName.Location = new Point(171, 22);
			TextBox_ShopName.Margin = new Padding(2);
			TextBox_ShopName.MaxLength = 14;
			TextBox_ShopName.Name = "TextBox_ShopName";
			TextBox_ShopName.Size = new Size(136, 19);
			TextBox_ShopName.TabIndex = 31;
			Label39.AutoSize = true;
			Label39.BackColor = Color.FromArgb(240, 240, 240);
			Label39.FlatStyle = FlatStyle.System;
			Label39.Location = new Point(96, 252);
			Label39.Margin = new Padding(2);
			Label39.Name = "Label39";
			Label39.Size = new Size(63, 13);
			Label39.TabIndex = 124;
			Label39.Text = "Id vật phẩm";
			Label_ShopName.AutoSize = true;
			Label_ShopName.BackColor = Color.FromArgb(240, 240, 240);
			Label_ShopName.FlatStyle = FlatStyle.System;
			Label_ShopName.Location = new Point(96, 25);
			Label_ShopName.Margin = new Padding(2);
			Label_ShopName.Name = "Label_ShopName";
			Label_ShopName.Size = new Size(71, 13);
			Label_ShopName.TabIndex = 32;
			Label_ShopName.Text = "Tên cửa hàng";
			TextBox_ShopAddPrice.Location = new Point(317, 249);
			TextBox_ShopAddPrice.Margin = new Padding(2);
			TextBox_ShopAddPrice.MaxLength = 20;
			TextBox_ShopAddPrice.Name = "TextBox_ShopAddPrice";
			TextBox_ShopAddPrice.Size = new Size(104, 19);
			TextBox_ShopAddPrice.TabIndex = 123;
			TextBox_ShopAddPrice.Text = "0";
			Label38.AutoSize = true;
			Label38.BackColor = Color.FromArgb(240, 240, 240);
			Label38.FlatStyle = FlatStyle.System;
			Label38.Location = new Point(311, 25);
			Label38.Margin = new Padding(2);
			Label38.Name = "Label38";
			Label38.Size = new Size(27, 13);
			Label38.TabIndex = 33;
			Label38.Text = "Loại";
			TextBox_ShopAddId.Location = new Point(163, 249);
			TextBox_ShopAddId.Margin = new Padding(2);
			TextBox_ShopAddId.MaxLength = 20;
			TextBox_ShopAddId.Name = "TextBox_ShopAddId";
			TextBox_ShopAddId.Size = new Size(71, 19);
			TextBox_ShopAddId.TabIndex = 122;
			TextBox_ShopAddId.Text = "0";
			ComboBox_ShopType.DropDownStyle = ComboBoxStyle.DropDownList;
			ComboBox_ShopType.FormattingEnabled = true;
			ComboBox_ShopType.Items.AddRange(new object[6] { "Dược Phẩm", "Lương Thực", "Tạp Hóa", "Trái Cây", "Trang Phục", "Vũ Khí" });
			ComboBox_ShopType.Location = new Point(343, 22);
			ComboBox_ShopType.Name = "ComboBox_ShopType";
			ComboBox_ShopType.Size = new Size(97, 21);
			ComboBox_ShopType.TabIndex = 34;
			TabPage_Map.Controls.Add(PictureBox1);
			TabPage_Map.Location = new Point(4, 30);
			TabPage_Map.Name = "TabPage_Map";
			TabPage_Map.Padding = new Padding(3);
			TabPage_Map.Size = new Size(663, 613);
			TabPage_Map.TabIndex = 7;
			TabPage_Map.Text = "Bản đồ";
			TabPage_Map.UseVisualStyleBackColor = true;
			miniToolStrip.AccessibleName = "New item selection";
			miniToolStrip.AccessibleRole = AccessibleRole.ButtonDropDown;
			miniToolStrip.AutoParentBackColor = false;
			miniToolStrip.AutoSize = false;
			miniToolStrip.BackColor = Color.FromArgb(156, 170, 193);
			miniToolStrip.CanOverflow = false;
			miniToolStrip.Dock = DockStyle.None;
			miniToolStrip.GripStyle = ToolStripGripStyle.Hidden;
			miniToolStrip.ImageScalingSize = new Size(24, 24);
			miniToolStrip.Location = new Point(0, 0);
			miniToolStrip.Name = "miniToolStrip";
			miniToolStrip.Padding = new Padding(2, 0, 2, 0);
			vs2010ToolStripRenderer2.ColorTable = colorTable4;
			vs2010ToolStripRenderer2.RoundedEdges = true;
			miniToolStrip.Renderer = vs2010ToolStripRenderer2;
			miniToolStrip.Size = new Size(248, 26);
			miniToolStrip.TabIndex = 0;
			base.AutoScaleMode = AutoScaleMode.Inherit;
			BackColor = Color.FromArgb(240, 240, 240);
			base.ClientSize = new Size(670, 647);
			base.Controls.Add(Vs2010TabControl_Main);
			DoubleBuffered = true;
			Font = new Font("Microsoft Sans Serif", 7.5f, FontStyle.Regular, GraphicsUnit.Point, 0);
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.KeyPreview = true;
			base.Margin = new Padding(2);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "frmClient";
			Text = "frmClient";
			((ISupportInitialize)DataSet1).EndInit();
			((ISupportInitialize)DataTable1).EndInit();
			((ISupportInitialize)DataTable2).EndInit();
			((ISupportInitialize)DataTable3).EndInit();
			((ISupportInitialize)DataTable4).EndInit();
			((ISupportInitialize)DataTable5).EndInit();
			((ISupportInitialize)DataTable6).EndInit();
			((ISupportInitialize)DataTable7).EndInit();
			((ISupportInitialize)DataTable8).EndInit();
			((ISupportInitialize)DataTable9).EndInit();
			((ISupportInitialize)DataTable10).EndInit();
			((ISupportInitialize)DataTable11).EndInit();
			((ISupportInitialize)DataTable12).EndInit();
			((ISupportInitialize)DataTable13).EndInit();
			((ISupportInitialize)DataTable14).EndInit();
			((ISupportInitialize)DataTable15).EndInit();
			((ISupportInitialize)DataTable16).EndInit();
			((ISupportInitialize)DataTable17).EndInit();
			((ISupportInitialize)DataTable18).EndInit();
			((ISupportInitialize)DataTable19).EndInit();
			((ISupportInitialize)DataTable21).EndInit();
			((ISupportInitialize)DataTable22).EndInit();
			((ISupportInitialize)DataTable23).EndInit();
			((ISupportInitialize)DataTable24).EndInit();
			((ISupportInitialize)DataTable25).EndInit();
			((ISupportInitialize)DataTable26).EndInit();
			((ISupportInitialize)DataTable27).EndInit();
			((ISupportInitialize)DataTable28).EndInit();
			((ISupportInitialize)DataTable29).EndInit();
			((ISupportInitialize)DataTable30).EndInit();
			((ISupportInitialize)DataTable31).EndInit();
			((ISupportInitialize)DataTable32).EndInit();
			((ISupportInitialize)DataTable33).EndInit();
			((ISupportInitialize)DataTable34).EndInit();
			((ISupportInitialize)DataTable35).EndInit();
			((ISupportInitialize)DataTable36).EndInit();
			((ISupportInitialize)DataTable37).EndInit();
			((ISupportInitialize)DataTable38).EndInit();
			((ISupportInitialize)DataTable39).EndInit();
			((ISupportInitialize)DataTable20).EndInit();
			((ISupportInitialize)DataTable40).EndInit();
			((ISupportInitialize)DataTable41).EndInit();
			ContextMenuStrip_ToTuideo.ResumeLayout(false);
			ContextMenuStrip_ToTuido.ResumeLayout(false);
			ContextMenuStrip_ToTuido.PerformLayout();
			ContextMenuStrip_Warp.ResumeLayout(false);
			((ISupportInitialize)DataGridView_Pickup).EndInit();
			((ISupportInitialize)PictureBox1).EndInit();
			Vs2010TabControl_Main.ResumeLayout(false);
			TabPage_Main.ResumeLayout(false);
			((ISupportInitialize)PictureBox_mini).EndInit();
			((ISupportInitialize)PictureBox_char_add_agi).EndInit();
			((ISupportInitialize)PictureBox_char_add_spx).EndInit();
			((ISupportInitialize)PictureBox_char_add_hpx).EndInit();
			((ISupportInitialize)PictureBox_char_add_def).EndInit();
			((ISupportInitialize)PictureBox_char_add_atk).EndInit();
			((ISupportInitialize)PictureBox_char_add_int).EndInit();
			((ISupportInitialize)PictureBox_pet_next).EndInit();
			((ISupportInitialize)PictureBox_Pet_back).EndInit();
			((ISupportInitialize)PictureBox_Pet_XuatChien).EndInit();
			((ISupportInitialize)PictureBox_Pet_Thuoctinh).EndInit();
			((ISupportInitialize)PictureBox_Char_Thuoctinh).EndInit();
			((ISupportInitialize)PictureBox_Pet5).EndInit();
			((ISupportInitialize)PictureBox_Pet6).EndInit();
			((ISupportInitialize)PictureBox_Pet3).EndInit();
			((ISupportInitialize)PictureBox_Pet2).EndInit();
			((ISupportInitialize)PictureBox_Pet4).EndInit();
			((ISupportInitialize)PictureBox_Pet1).EndInit();
			((ISupportInitialize)PictureBox_char5).EndInit();
			((ISupportInitialize)PictureBox_char6).EndInit();
			((ISupportInitialize)PictureBox_char3).EndInit();
			((ISupportInitialize)PictureBox_char2).EndInit();
			((ISupportInitialize)PictureBox_char4).EndInit();
			((ISupportInitialize)PictureBox_char1).EndInit();
			Panel10.ResumeLayout(false);
			Panel_Chat.ResumeLayout(false);
			Panel9.ResumeLayout(false);
			Panel7.ResumeLayout(false);
			Panel7.PerformLayout();
			GroupBox12.ResumeLayout(false);
			((ISupportInitialize)StatusBarPanel_status).EndInit();
			((ISupportInitialize)StatusBarPanel_MapName).EndInit();
			((ISupportInitialize)StatusBarPanel_online).EndInit();
			Panel_Login.ResumeLayout(false);
			Panel_Login.PerformLayout();
			ToolStrip1.ResumeLayout(false);
			ToolStrip1.PerformLayout();
			Panel6.ResumeLayout(false);
			GroupBox_Bot.ResumeLayout(false);
			GroupBox_Bot.PerformLayout();
			GroupBox_team.ResumeLayout(false);
			GroupBox_team.PerformLayout();
			Panel5.ResumeLayout(false);
			Panel5.PerformLayout();
			((ISupportInitialize)PictureBox_Pet_photo).EndInit();
			((ISupportInitialize)PictureBox_avatar).EndInit();
			TabPage_Attack.ResumeLayout(false);
			TabControl2.ResumeLayout(false);
			TabPage3.ResumeLayout(false);
			TabPage3.PerformLayout();
			GroupBox8.ResumeLayout(false);
			GroupBox8.PerformLayout();
			Panel_CharSkillTurn.ResumeLayout(false);
			Panel_CharSkillTurn.PerformLayout();
			Panel_PetSkillTurn.ResumeLayout(false);
			Panel_PetSkillTurn.PerformLayout();
			TabPage_Quest.ResumeLayout(false);
			((ISupportInitialize)DataGridView1).EndInit();
			TabPage_Warp.ResumeLayout(false);
			TabPage_Warp.PerformLayout();
			TabPage_Players.ResumeLayout(false);
			TabPage_Setting.ResumeLayout(false);
			TabControl1.ResumeLayout(false);
			TabPage7.ResumeLayout(false);
			GroupBox_disconnect.ResumeLayout(false);
			GroupBox_Basic.ResumeLayout(false);
			GroupBox_Basic.PerformLayout();
			((ISupportInitialize)NumericUpDown_sendpacket).EndInit();
			GroupBox9.ResumeLayout(false);
			GroupBox9.PerformLayout();
			TabPage8.ResumeLayout(false);
			GroupBox3.ResumeLayout(false);
			GroupBox3.PerformLayout();
			GroupBox2.ResumeLayout(false);
			GroupBox2.PerformLayout();
			TabPage9.ResumeLayout(false);
			TabPage9.PerformLayout();
			((ISupportInitialize)NumericUpDown_createSp).EndInit();
			((ISupportInitialize)NumericUpDown_createHp).EndInit();
			((ISupportInitialize)NumericUpDown_createAgi).EndInit();
			((ISupportInitialize)NumericUpDown_createInt).EndInit();
			((ISupportInitialize)NumericUpDown_createAtk).EndInit();
			((ISupportInitialize)NumericUpDown_createDef).EndInit();
			TabPage2.ResumeLayout(false);
			TabControl_ItemSetting.ResumeLayout(false);
			TabPage11.ResumeLayout(false);
			GroupBox5.ResumeLayout(false);
			GroupBox5.PerformLayout();
			TabPage12.ResumeLayout(false);
			GroupBox6.ResumeLayout(false);
			GroupBox6.PerformLayout();
			TabPage1.ResumeLayout(false);
			GroupBox7.ResumeLayout(false);
			GroupBox7.PerformLayout();
			TabPage5.ResumeLayout(false);
			GroupBox10.ResumeLayout(false);
			GroupBox10.PerformLayout();
			GroupBox4.ResumeLayout(false);
			((ISupportInitialize)NumericUpDown_ItemCountPickup).EndInit();
			TabPage6.ResumeLayout(false);
			GroupBox11.ResumeLayout(false);
			GroupBox11.PerformLayout();
			TabPage4.ResumeLayout(false);
			TabPage4.PerformLayout();
			Panel4.ResumeLayout(false);
			Panel4.PerformLayout();
			((ISupportInitialize)DataGridView_ItemOnMap).EndInit();
			TabPage_Shop.ResumeLayout(false);
			TabPage_Shop.PerformLayout();
			TabPage_Map.ResumeLayout(false);
			ResumeLayout(false);
		}
	}
}
