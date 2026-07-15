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
	}
}
