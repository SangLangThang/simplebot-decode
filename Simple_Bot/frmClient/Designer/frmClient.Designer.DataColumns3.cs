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
		internal virtual DataColumn DataColumn381
		{
			[CompilerGenerated]
			get => q3;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => q3 = value;
		}

		internal virtual DataColumn DataColumn382
		{
			[CompilerGenerated]
			get => q4;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => q4 = value;
		}

		internal virtual DataColumn DataColumn383
		{
			[CompilerGenerated]
			get => q5;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => q5 = value;
		}

		internal virtual DataColumn DataColumn384
		{
			[CompilerGenerated]
			get => q6;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => q6 = value;
		}

		internal virtual DataColumn DataColumn385
		{
			[CompilerGenerated]
			get => q7;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => q7 = value;
		}

		internal virtual DataColumn DataColumn386
		{
			[CompilerGenerated]
			get => q8;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => q8 = value;
		}

		internal virtual DataTable DataTable33
		{
			[CompilerGenerated]
			get => q9;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => q9 = value;
		}

		internal virtual DataColumn DataColumn387
		{
			[CompilerGenerated]
			get => ra;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ra = value;
		}

		internal virtual DataColumn DataColumn388
		{
			[CompilerGenerated]
			get => rb;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => rb = value;
		}

		internal virtual DataColumn DataColumn389
		{
			[CompilerGenerated]
			get => rc;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => rc = value;
		}

		internal virtual DataColumn DataColumn390
		{
			[CompilerGenerated]
			get => rd;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => rd = value;
		}

		internal virtual DataColumn DataColumn391
		{
			[CompilerGenerated]
			get => re;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => re = value;
		}

		internal virtual DataColumn DataColumn392
		{
			[CompilerGenerated]
			get => rf;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => rf = value;
		}

		internal virtual DataColumn DataColumn393
		{
			[CompilerGenerated]
			get => rg;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => rg = value;
		}

		internal virtual DataTable DataTable34
		{
			[CompilerGenerated]
			get => rh;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => rh = value;
		}

		internal virtual DataColumn DataColumn394
		{
			[CompilerGenerated]
			get => ri;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ri = value;
		}

		internal virtual DataColumn DataColumn395
		{
			[CompilerGenerated]
			get => rj;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => rj = value;
		}

		internal virtual DataColumn DataColumn396
		{
			[CompilerGenerated]
			get => rk;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => rk = value;
		}

		internal virtual DataColumn DataColumn397
		{
			[CompilerGenerated]
			get => rl;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => rl = value;
		}

		internal virtual DataColumn DataColumn398
		{
			[CompilerGenerated]
			get => rm;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => rm = value;
		}

		internal virtual DataColumn DataColumn399
		{
			[CompilerGenerated]
			get => rn;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => rn = value;
		}

		internal virtual DataColumn DataColumn400
		{
			[CompilerGenerated]
			get => ro;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ro = value;
		}

		internal virtual DataTable DataTable35
		{
			[CompilerGenerated]
			get => rp;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => rp = value;
		}

		internal virtual DataColumn DataColumn401
		{
			[CompilerGenerated]
			get => rq;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => rq = value;
		}

		internal virtual DataColumn DataColumn402
		{
			[CompilerGenerated]
			get => rr;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => rr = value;
		}

		internal virtual DataColumn DataColumn403
		{
			[CompilerGenerated]
			get => rs;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => rs = value;
		}

		internal virtual DataColumn DataColumn404
		{
			[CompilerGenerated]
			get => rt;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => rt = value;
		}

		internal virtual DataColumn DataColumn405
		{
			[CompilerGenerated]
			get => ru;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ru = value;
		}

		internal virtual DataColumn DataColumn406
		{
			[CompilerGenerated]
			get => rv;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => rv = value;
		}

		internal virtual DataColumn DataColumn407
		{
			[CompilerGenerated]
			get => rw;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => rw = value;
		}

		internal virtual DataTable DataTable36
		{
			[CompilerGenerated]
			get => rx;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => rx = value;
		}

		internal virtual DataColumn DataColumn408
		{
			[CompilerGenerated]
			get => ry;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ry = value;
		}

		internal virtual DataColumn DataColumn409
		{
			[CompilerGenerated]
			get => rz;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => rz = value;
		}

		internal virtual DataColumn DataColumn410
		{
			[CompilerGenerated]
			get => r0;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => r0 = value;
		}

		internal virtual DataColumn DataColumn411
		{
			[CompilerGenerated]
			get => r1;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => r1 = value;
		}

		internal virtual DataColumn DataColumn412
		{
			[CompilerGenerated]
			get => r2;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => r2 = value;
		}

		internal virtual DataColumn DataColumn413
		{
			[CompilerGenerated]
			get => r3;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => r3 = value;
		}

		internal virtual DataColumn DataColumn414
		{
			[CompilerGenerated]
			get => r4;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => r4 = value;
		}

		internal virtual DataTable DataTable37
		{
			[CompilerGenerated]
			get => r5;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => r5 = value;
		}

		internal virtual DataColumn DataColumn415
		{
			[CompilerGenerated]
			get => r6;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => r6 = value;
		}

		internal virtual DataColumn DataColumn416
		{
			[CompilerGenerated]
			get => r7;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => r7 = value;
		}

		internal virtual DataColumn DataColumn417
		{
			[CompilerGenerated]
			get => r8;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => r8 = value;
		}

		internal virtual DataColumn DataColumn418
		{
			[CompilerGenerated]
			get => r9;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => r9 = value;
		}

		internal virtual DataColumn DataColumn419
		{
			[CompilerGenerated]
			get => sa;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => sa = value;
		}

		internal virtual DataColumn DataColumn420
		{
			[CompilerGenerated]
			get => sb;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => sb = value;
		}

		internal virtual DataColumn DataColumn421
		{
			[CompilerGenerated]
			get => sc;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => sc = value;
		}

		internal virtual DataTable DataTable38
		{
			[CompilerGenerated]
			get => sd;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => sd = value;
		}

		internal virtual DataColumn DataColumn422
		{
			[CompilerGenerated]
			get => se;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => se = value;
		}

		internal virtual DataColumn DataColumn423
		{
			[CompilerGenerated]
			get => sf;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => sf = value;
		}

		internal virtual DataColumn DataColumn424
		{
			[CompilerGenerated]
			get => sg;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => sg = value;
		}

		internal virtual DataColumn DataColumn425
		{
			[CompilerGenerated]
			get => sh;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => sh = value;
		}

		internal virtual DataColumn DataColumn426
		{
			[CompilerGenerated]
			get => si;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => si = value;
		}

		internal virtual DataColumn DataColumn427
		{
			[CompilerGenerated]
			get => sj;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => sj = value;
		}

		internal virtual DataColumn DataColumn428
		{
			[CompilerGenerated]
			get => sk;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => sk = value;
		}

		internal virtual DataTable DataTable39
		{
			[CompilerGenerated]
			get => sl;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => sl = value;
		}

		internal virtual DataColumn DataColumn429
		{
			[CompilerGenerated]
			get => sm;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => sm = value;
		}

		internal virtual DataColumn DataColumn430
		{
			[CompilerGenerated]
			get => sn;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => sn = value;
		}

		internal virtual DataColumn DataColumn431
		{
			[CompilerGenerated]
			get => so;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => so = value;
		}

		internal virtual DataColumn DataColumn432
		{
			[CompilerGenerated]
			get => sp;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => sp = value;
		}

		internal virtual DataColumn DataColumn433
		{
			[CompilerGenerated]
			get => sq;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => sq = value;
		}

		internal virtual DataColumn DataColumn434
		{
			[CompilerGenerated]
			get => sr;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => sr = value;
		}

		internal virtual DataColumn DataColumn435
		{
			[CompilerGenerated]
			get => ss;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ss = value;
		}

		internal virtual DataColumn DataColumn436
		{
			[CompilerGenerated]
			get => st;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => st = value;
		}

		internal virtual DataColumn DataColumn437
		{
			[CompilerGenerated]
			get => su;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => su = value;
		}

		internal virtual DataColumn DataColumn438
		{
			[CompilerGenerated]
			get => sv;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => sv = value;
		}

		internal virtual DataColumn DataColumn439
		{
			[CompilerGenerated]
			get => sw;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => sw = value;
		}

		internal virtual DataColumn DataColumn440
		{
			[CompilerGenerated]
			get => sx;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => sx = value;
		}

		internal virtual DataColumn DataColumn441
		{
			[CompilerGenerated]
			get => sy;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => sy = value;
		}

		internal virtual DataColumn DataColumn442
		{
			[CompilerGenerated]
			get => sz;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => sz = value;
		}

		internal virtual DataColumn DataColumn443
		{
			[CompilerGenerated]
			get => s0;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => s0 = value;
		}

		internal virtual DataColumn DataColumn444
		{
			[CompilerGenerated]
			get => s1;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => s1 = value;
		}

		internal virtual DataColumn DataColumn445
		{
			[CompilerGenerated]
			get => s2;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => s2 = value;
		}

		internal virtual DataColumn DataColumn446
		{
			[CompilerGenerated]
			get => s3;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => s3 = value;
		}

		internal virtual DataColumn DataColumn447
		{
			[CompilerGenerated]
			get => s4;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => s4 = value;
		}

		internal virtual DataColumn DataColumn448
		{
			[CompilerGenerated]
			get => s5;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => s5 = value;
		}

		internal virtual DataColumn DataColumn449
		{
			[CompilerGenerated]
			get => s6;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => s6 = value;
		}

		internal virtual DataColumn DataColumn450
		{
			[CompilerGenerated]
			get => s7;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => s7 = value;
		}

		internal virtual DataColumn DataColumn451
		{
			[CompilerGenerated]
			get => s8;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => s8 = value;
		}

		internal virtual DataColumn DataColumn452
		{
			[CompilerGenerated]
			get => s9;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => s9 = value;
		}

		internal virtual DataColumn DataColumn453
		{
			[CompilerGenerated]
			get => ta;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ta = value;
		}

		internal virtual DataColumn DataColumn454
		{
			[CompilerGenerated]
			get => tb;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => tb = value;
		}

		internal virtual DataColumn DataColumn455
		{
			[CompilerGenerated]
			get => tc;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => tc = value;
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
			get => th;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => th = value;
		}

		internal virtual DataColumn DataColumn457
		{
			[CompilerGenerated]
			get => ti;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ti = value;
		}

		internal virtual DataColumn DataColumn458
		{
			[CompilerGenerated]
			get => tj;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => tj = value;
		}

		internal virtual DataColumn DataColumn459
		{
			[CompilerGenerated]
			get => tk;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => tk = value;
		}

		internal virtual DataColumn DataColumn460
		{
			[CompilerGenerated]
			get => tl;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => tl = value;
		}

		internal virtual DataColumn DataColumn461
		{
			[CompilerGenerated]
			get => tm;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => tm = value;
		}

		internal virtual DataColumn DataColumn462
		{
			[CompilerGenerated]
			get => tn;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => tn = value;
		}

		internal virtual DataColumn DataColumn463
		{
			[CompilerGenerated]
			get => to;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => to = value;
		}

		internal virtual DataColumn DataColumn464
		{
			[CompilerGenerated]
			get => tp;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => tp = value;
		}

		internal virtual DataColumn DataColumn465
		{
			[CompilerGenerated]
			get => tq;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => tq = value;
		}

		internal virtual DataColumn DataColumn466
		{
			[CompilerGenerated]
			get => tr;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => tr = value;
		}

		internal virtual DataColumn DataColumn467
		{
			[CompilerGenerated]
			get => ts;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ts = value;
		}

		internal virtual DataColumn DataColumn468
		{
			[CompilerGenerated]
			get => tt;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => tt = value;
		}

		internal virtual DataColumn DataColumn469
		{
			[CompilerGenerated]
			get => tu;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => tu = value;
		}

		internal virtual DataColumn DataColumn470
		{
			[CompilerGenerated]
			get => tv;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => tv = value;
		}

		internal virtual DataColumn DataColumn471
		{
			[CompilerGenerated]
			get => tw;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => tw = value;
		}

		internal virtual DataColumn DataColumn472
		{
			[CompilerGenerated]
			get => tx;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => tx = value;
		}

		internal virtual DataColumn DataColumn473
		{
			[CompilerGenerated]
			get => ty;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ty = value;
		}

		internal virtual DataColumn DataColumn474
		{
			[CompilerGenerated]
			get => tz;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => tz = value;
		}

		internal virtual DataColumn DataColumn475
		{
			[CompilerGenerated]
			get => t0;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => t0 = value;
		}

		internal virtual DataColumn DataColumn476
		{
			[CompilerGenerated]
			get => t1;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => t1 = value;
		}

		internal virtual DataColumn DataColumn477
		{
			[CompilerGenerated]
			get => t2;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => t2 = value;
		}

		internal virtual DataColumn DataColumn478
		{
			[CompilerGenerated]
			get => t3;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => t3 = value;
		}

		internal virtual DataColumn DataColumn479
		{
			[CompilerGenerated]
			get => t4;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => t4 = value;
		}

		internal virtual DataColumn DataColumn480
		{
			[CompilerGenerated]
			get => t5;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => t5 = value;
		}

		internal virtual DataColumn DataColumn481
		{
			[CompilerGenerated]
			get => t6;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => t6 = value;
		}

		internal virtual DataColumn DataColumn482
		{
			[CompilerGenerated]
			get => t7;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => t7 = value;
		}

		internal virtual DataColumn DataColumn483
		{
			[CompilerGenerated]
			get => t8;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => t8 = value;
		}

		internal virtual DataColumn DataColumn484
		{
			[CompilerGenerated]
			get => t9;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => t9 = value;
		}

		internal virtual DataColumn DataColumn485
		{
			[CompilerGenerated]
			get => ua;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ua = value;
		}

		internal virtual DataColumn DataColumn486
		{
			[CompilerGenerated]
			get => ub;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ub = value;
		}

		internal virtual DataColumn DataColumn487
		{
			[CompilerGenerated]
			get => uc;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => uc = value;
		}

		internal virtual DataColumn DataColumn488
		{
			[CompilerGenerated]
			get => ud;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ud = value;
		}

		internal virtual DataColumn DataColumn489
		{
			[CompilerGenerated]
			get => ue;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ue = value;
		}

		internal virtual DataColumn DataColumn490
		{
			[CompilerGenerated]
			get => uf;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => uf = value;
		}

		internal virtual DataColumn DataColumn491
		{
			[CompilerGenerated]
			get => ug;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ug = value;
		}

		internal virtual DataColumn DataColumn492
		{
			[CompilerGenerated]
			get => uh;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => uh = value;
		}

		internal virtual DataColumn DataColumn493
		{
			[CompilerGenerated]
			get => ui;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ui = value;
		}

		internal virtual DataColumn DataColumn494
		{
			[CompilerGenerated]
			get => uj;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => uj = value;
		}

		internal virtual DataColumn DataColumn495
		{
			[CompilerGenerated]
			get => uk;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => uk = value;
		}

		internal virtual DataColumn DataColumn496
		{
			[CompilerGenerated]
			get => ul;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ul = value;
		}

		internal virtual DataColumn DataColumn497
		{
			[CompilerGenerated]
			get => um;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => um = value;
		}

		internal virtual Label Label_Petname
		{
			[CompilerGenerated]
			get => un;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => un = value;
		}

		internal virtual Label Label_CharName
		{
			[CompilerGenerated]
			get => uo;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => uo = value;
		}

		internal virtual Label Label74
		{
			[CompilerGenerated]
			get => up;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => up = value;
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
			get => ut;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ut = value;
		}

		internal virtual Label Label75
		{
			[CompilerGenerated]
			get => uu;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => uu = value;
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
			get => uw;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => uw = value;
		}

		internal virtual DataColumn DataColumn501
		{
			[CompilerGenerated]
			get => ux;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ux = value;
		}

		internal virtual DataColumn DataColumn502
		{
			[CompilerGenerated]
			get => uy;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => uy = value;
		}

		internal virtual DataColumn DataColumn503
		{
			[CompilerGenerated]
			get => uz;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => uz = value;
		}

		internal virtual DataColumn DataColumn504
		{
			[CompilerGenerated]
			get => u0;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => u0 = value;
		}

		internal virtual DataColumn DataColumn500
		{
			[CompilerGenerated]
			get => u1;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => u1 = value;
		}

		internal virtual TabPage TabPage2
		{
			[CompilerGenerated]
			get => u2;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => u2 = value;
		}

		internal virtual TabPage TabPage1
		{
			[CompilerGenerated]
			get => u3;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => u3 = value;
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
			get => u5;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => u5 = value;
		}

		internal virtual TabPage TabPage3
		{
			[CompilerGenerated]
			get => u6;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => u6 = value;
		}

		internal virtual ListView ListView_monster
		{
			[CompilerGenerated]
			get => u7;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => u7 = value;
		}

		internal virtual ColumnHeader ColumnHeader5
		{
			[CompilerGenerated]
			get => u8;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => u8 = value;
		}

		internal virtual ColumnHeader ColumnHeader6
		{
			[CompilerGenerated]
			get => u9;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => u9 = value;
		}

		internal virtual ColumnHeader ColumnHeader7
		{
			[CompilerGenerated]
			get => va;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => va = value;
		}

		internal virtual ColumnHeader ColumnHeader8
		{
			[CompilerGenerated]
			get => vb;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => vb = value;
		}

		internal virtual ColumnHeader ColumnHeader9
		{
			[CompilerGenerated]
			get => vc;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => vc = value;
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
			get => vg;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => vg = value;
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
			get => vi;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => vi = value;
		}

		internal virtual Label Label77
		{
			[CompilerGenerated]
			get => vj;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => vj = value;
		}

		internal virtual Label Label13
		{
			[CompilerGenerated]
			get => vk;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => vk = value;
		}

		internal virtual TextBox TextBox_RemoteDis
		{
			[CompilerGenerated]
			get => vl;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => vl = value;
		}

		internal virtual GroupBox GroupBox9
		{
			[CompilerGenerated]
			get => vm;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => vm = value;
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
			get => vp;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => vp = value;
		}

		internal virtual DataTable DataTable20
		{
			[CompilerGenerated]
			get => vq;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => vq = value;
		}

		internal virtual DataColumn DataColumn505
		{
			[CompilerGenerated]
			get => vr;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => vr = value;
		}

		internal virtual DataColumn DataColumn506
		{
			[CompilerGenerated]
			get => vs;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => vs = value;
		}

		internal virtual DataGridView DataGridView_ItemOnMap
		{
			[CompilerGenerated]
			get => vt;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => vt = value;
		}

		internal virtual DataColumn DataColumn509
		{
			[CompilerGenerated]
			get => vu;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => vu = value;
		}

		internal virtual DataColumn DataColumn507
		{
			[CompilerGenerated]
			get => vv;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => vv = value;
		}

		internal virtual DataColumn DataColumn508
		{
			[CompilerGenerated]
			get => vw;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => vw = value;
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
			get => vy;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => vy = value;
		}

		internal virtual DataGridViewTextBoxColumn GoldDataGridViewTextBoxColumn
		{
			[CompilerGenerated]
			get => vz;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => vz = value;
		}

		internal virtual DataGridViewTextBoxColumn IdDataGridViewTextBoxColumn
		{
			[CompilerGenerated]
			get => v0;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => v0 = value;
		}

		internal virtual DataGridViewTextBoxColumn ItemNameDataGridViewTextBoxColumn
		{
			[CompilerGenerated]
			get => v1;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => v1 = value;
		}

		internal virtual DataGridViewTextBoxColumn MapXDataGridViewTextBoxColumn
		{
			[CompilerGenerated]
			get => v2;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => v2 = value;
		}

		internal virtual DataGridViewTextBoxColumn MapYDataGridViewTextBoxColumn
		{
			[CompilerGenerated]
			get => v3;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => v3 = value;
		}

		internal virtual Label Label3
		{
			[CompilerGenerated]
			get => v4;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => v4 = value;
		}

		internal virtual Button Button_IdAdd
		{
			[CompilerGenerated]
			get => v5;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => v5 = value;
		}

		internal virtual TextBox TextBox_IdAdd
		{
			[CompilerGenerated]
			get => v6;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => v6 = value;
		}

		internal virtual DataGridView DataGridView_Pickup
		{
			[CompilerGenerated]
			get => v7;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => v7 = value;
		}

		internal virtual DataTable DataTable40
		{
			[CompilerGenerated]
			get => v8;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => v8 = value;
		}

		internal virtual DataColumn DataColumn510
		{
			[CompilerGenerated]
			get => v9;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => v9 = value;
		}

		internal virtual DataColumn DataColumn511
		{
			[CompilerGenerated]
			get => wa;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => wa = value;
		}

		internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn14
		{
			[CompilerGenerated]
			get => wb;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => wb = value;
		}

		internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn15
		{
			[CompilerGenerated]
			get => wc;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => wc = value;
		}

		internal virtual TabPage TabPage5
		{
			[CompilerGenerated]
			get => wd;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => wd = value;
		}

		internal virtual GroupBox GroupBox10
		{
			[CompilerGenerated]
			get => we;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => we = value;
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
			get => wh;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => wh = value;
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
			get => wl;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => wl = value;
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
			get => wn;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => wn = value;
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
			get => wr;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => wr = value;
		}

		internal virtual DataColumn DataColumn512
		{
			[CompilerGenerated]
			get => ws;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ws = value;
		}

		internal virtual DataColumn DataColumn513
		{
			[CompilerGenerated]
			get => wt;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => wt = value;
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
			get => ww;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ww = value;
		}

		internal virtual Label Label83
		{
			[CompilerGenerated]
			get => wx;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => wx = value;
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
			get => wz;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => wz = value;
		}

		internal virtual ProgressBarEx ProgressBarEx_BDY
		{
			[CompilerGenerated]
			get => w0;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => w0 = value;
		}

		internal virtual Label Label_BDY
		{
			[CompilerGenerated]
			get => w1;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => w1 = value;
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
			get => w4;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => w4 = value;
		}

		internal virtual DataColumn DataColumn515
		{
			[CompilerGenerated]
			get => w5;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => w5 = value;
		}

		internal virtual DataColumn DataColumn516
		{
			[CompilerGenerated]
			get => w6;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => w6 = value;
		}

		internal virtual TabPage TabPage6
		{
			[CompilerGenerated]
			get => w7;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => w7 = value;
		}

		internal virtual GroupBox GroupBox11
		{
			[CompilerGenerated]
			get => w8;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => w8 = value;
		}

		internal virtual Label Label84
		{
			[CompilerGenerated]
			get => w9;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => w9 = value;
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
			get => xb;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => xb = value;
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
			get => xd;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => xd = value;
		}

		internal virtual Label Label87
		{
			[CompilerGenerated]
			get => xe;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => xe = value;
		}

		internal virtual Label Label88
		{
			[CompilerGenerated]
			get => xf;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => xf = value;
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
			get => xh;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => xh = value;
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
			get => xj;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => xj = value;
		}

		internal virtual Label Label91
		{
			[CompilerGenerated]
			get => xk;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => xk = value;
		}

		internal virtual DataColumn DataColumn517
		{
			[CompilerGenerated]
			get => xl;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => xl = value;
		}

		internal virtual DataColumn DataColumn518
		{
			[CompilerGenerated]
			get => xm;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => xm = value;
		}

		internal virtual DataColumn DataColumn519
		{
			[CompilerGenerated]
			get => xn;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => xn = value;
		}

		internal virtual DataColumn DataColumn520
		{
			[CompilerGenerated]
			get => xo;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => xo = value;
		}

		internal virtual DataColumn DataColumn521
		{
			[CompilerGenerated]
			get => xp;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => xp = value;
		}

		internal virtual DataColumn DataColumn522
		{
			[CompilerGenerated]
			get => xq;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => xq = value;
		}

		internal virtual DataColumn DataColumn523
		{
			[CompilerGenerated]
			get => xr;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => xr = value;
		}

		internal virtual DataColumn DataColumn524
		{
			[CompilerGenerated]
			get => xs;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => xs = value;
		}

		internal virtual DataColumn DataColumn525
		{
			[CompilerGenerated]
			get => xt;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => xt = value;
		}

		internal virtual DataColumn DataColumn526
		{
			[CompilerGenerated]
			get => xu;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => xu = value;
		}

		internal virtual DataColumn DataColumn527
		{
			[CompilerGenerated]
			get => xv;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => xv = value;
		}

		internal virtual DataColumn DataColumn528
		{
			[CompilerGenerated]
			get => xw;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => xw = value;
		}

		internal virtual DataColumn DataColumn529
		{
			[CompilerGenerated]
			get => xx;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => xx = value;
		}

		internal virtual DataColumn DataColumn530
		{
			[CompilerGenerated]
			get => xy;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => xy = value;
		}

		internal virtual DataColumn DataColumn531
		{
			[CompilerGenerated]
			get => xz;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => xz = value;
		}

		internal virtual DataColumn DataColumn532
		{
			[CompilerGenerated]
			get => x0;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => x0 = value;
		}

		internal virtual DataColumn DataColumn533
		{
			[CompilerGenerated]
			get => x1;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => x1 = value;
		}

		internal virtual DataColumn DataColumn534
		{
			[CompilerGenerated]
			get => x2;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => x2 = value;
		}

		internal virtual DataColumn DataColumn535
		{
			[CompilerGenerated]
			get => x3;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => x3 = value;
		}

		internal virtual DataColumn DataColumn536
		{
			[CompilerGenerated]
			get => x4;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => x4 = value;
		}

		internal virtual DataColumn DataColumn537
		{
			[CompilerGenerated]
			get => x5;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => x5 = value;
		}

		internal virtual DataColumn DataColumn538
		{
			[CompilerGenerated]
			get => x6;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => x6 = value;
		}

		internal virtual DataColumn DataColumn539
		{
			[CompilerGenerated]
			get => x7;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => x7 = value;
		}

		internal virtual DataColumn DataColumn540
		{
			[CompilerGenerated]
			get => x8;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => x8 = value;
		}

		internal virtual DataColumn DataColumn541
		{
			[CompilerGenerated]
			get => x9;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => x9 = value;
		}

		internal virtual DataColumn DataColumn542
		{
			[CompilerGenerated]
			get => ya;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ya = value;
		}

		internal virtual DataColumn DataColumn543
		{
			[CompilerGenerated]
			get => yb;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => yb = value;
		}

		internal virtual DataColumn DataColumn544
		{
			[CompilerGenerated]
			get => yc;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => yc = value;
		}

		internal virtual DataColumn DataColumn545
		{
			[CompilerGenerated]
			get => yd;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => yd = value;
		}

		internal virtual DataColumn DataColumn546
		{
			[CompilerGenerated]
			get => ye;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ye = value;
		}

		internal virtual DataColumn DataColumn547
		{
			[CompilerGenerated]
			get => yf;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => yf = value;
		}

		internal virtual DataColumn DataColumn548
		{
			[CompilerGenerated]
			get => yg;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => yg = value;
		}

		internal virtual DataColumn DataColumn549
		{
			[CompilerGenerated]
			get => yh;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => yh = value;
		}

		internal virtual DataColumn DataColumn550
		{
			[CompilerGenerated]
			get => yi;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => yi = value;
		}

		internal virtual DataColumn DataColumn551
		{
			[CompilerGenerated]
			get => yj;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => yj = value;
		}

		internal virtual DataColumn DataColumn552
		{
			[CompilerGenerated]
			get => yk;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => yk = value;
		}

		internal virtual DataColumn DataColumn553
		{
			[CompilerGenerated]
			get => yl;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => yl = value;
		}

		internal virtual DataColumn DataColumn554
		{
			[CompilerGenerated]
			get => ym;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ym = value;
		}

		internal virtual DataColumn DataColumn555
		{
			[CompilerGenerated]
			get => yn;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => yn = value;
		}

		internal virtual DataColumn DataColumn556
		{
			[CompilerGenerated]
			get => yo;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => yo = value;
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
			get => yr;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => yr = value;
		}

		internal virtual DataColumn DataColumn557
		{
			[CompilerGenerated]
			get => ys;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ys = value;
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
			get => yu;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => yu = value;
		}

		internal virtual DataColumn DataColumn558
		{
			[CompilerGenerated]
			get => yv;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => yv = value;
		}

		internal virtual DataColumn DataColumn559
		{
			[CompilerGenerated]
			get => yw;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => yw = value;
		}

		internal virtual DataColumn DataColumn560
		{
			[CompilerGenerated]
			get => yx;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => yx = value;
		}

		internal virtual DataColumn DataColumn561
		{
			[CompilerGenerated]
			get => yy;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => yy = value;
		}

		internal virtual DataColumn DataColumn562
		{
			[CompilerGenerated]
			get => yz;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => yz = value;
		}

		internal virtual DataColumn DataColumn563
		{
			[CompilerGenerated]
			get => y0;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => y0 = value;
		}

		internal virtual DataColumn DataColumn564
		{
			[CompilerGenerated]
			get => y1;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => y1 = value;
		}

		internal virtual DataColumn DataColumn565
		{
			[CompilerGenerated]
			get => y2;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => y2 = value;
		}

		internal virtual DataColumn DataColumn566
		{
			[CompilerGenerated]
			get => y3;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => y3 = value;
		}

		internal virtual DataColumn DataColumn567
		{
			[CompilerGenerated]
			get => y4;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => y4 = value;
		}

		internal virtual DataColumn DataColumn568
		{
			[CompilerGenerated]
			get => y5;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => y5 = value;
		}

		internal virtual DataColumn DataColumn569
		{
			[CompilerGenerated]
			get => y6;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => y6 = value;
		}

		internal virtual DataColumn DataColumn570
		{
			[CompilerGenerated]
			get => y7;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => y7 = value;
		}

		internal virtual DataColumn DataColumn571
		{
			[CompilerGenerated]
			get => y8;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => y8 = value;
		}

		internal virtual DataColumn DataColumn572
		{
			[CompilerGenerated]
			get => y9;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => y9 = value;
		}

		internal virtual DataColumn DataColumn573
		{
			[CompilerGenerated]
			get => za;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => za = value;
		}

		internal virtual DataColumn DataColumn574
		{
			[CompilerGenerated]
			get => zb;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => zb = value;
		}

		internal virtual DataColumn DataColumn575
		{
			[CompilerGenerated]
			get => zc;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => zc = value;
		}

		internal virtual DataColumn DataColumn576
		{
			[CompilerGenerated]
			get => zd;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => zd = value;
		}

		internal virtual DataColumn DataColumn577
		{
			[CompilerGenerated]
			get => ze;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ze = value;
		}
	}
}
