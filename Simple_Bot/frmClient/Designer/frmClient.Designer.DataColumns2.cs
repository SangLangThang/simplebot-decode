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
		internal virtual DataColumn DataColumn191
		{
			[CompilerGenerated]
			get => ho;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ho = value;
		}

		internal virtual DataColumn DataColumn192
		{
			[CompilerGenerated]
			get => hp;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => hp = value;
		}

		internal virtual DataColumn DataColumn193
		{
			[CompilerGenerated]
			get => hq;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => hq = value;
		}

		internal virtual DataColumn DataColumn194
		{
			[CompilerGenerated]
			get => hr;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => hr = value;
		}

		internal virtual DataColumn DataColumn195
		{
			[CompilerGenerated]
			get => hs;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => hs = value;
		}

		internal virtual DataColumn DataColumn196
		{
			[CompilerGenerated]
			get => ht;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ht = value;
		}

		internal virtual DataColumn DataColumn197
		{
			[CompilerGenerated]
			get => hu;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => hu = value;
		}

		internal virtual DataColumn DataColumn198
		{
			[CompilerGenerated]
			get => hv;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => hv = value;
		}

		internal virtual DataColumn DataColumn199
		{
			[CompilerGenerated]
			get => hw;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => hw = value;
		}

		internal virtual DataColumn DataColumn200
		{
			[CompilerGenerated]
			get => hx;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => hx = value;
		}

		internal virtual DataColumn DataColumn201
		{
			[CompilerGenerated]
			get => hy;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => hy = value;
		}

		internal virtual DataColumn DataColumn202
		{
			[CompilerGenerated]
			get => hz;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => hz = value;
		}

		internal virtual DataColumn DataColumn203
		{
			[CompilerGenerated]
			get => h0;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => h0 = value;
		}

		internal virtual DataColumn DataColumn204
		{
			[CompilerGenerated]
			get => h1;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => h1 = value;
		}

		internal virtual DataColumn DataColumn205
		{
			[CompilerGenerated]
			get => h2;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => h2 = value;
		}

		internal virtual DataColumn DataColumn206
		{
			[CompilerGenerated]
			get => h3;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => h3 = value;
		}

		internal virtual DataColumn DataColumn207
		{
			[CompilerGenerated]
			get => h4;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => h4 = value;
		}

		internal virtual DataColumn DataColumn208
		{
			[CompilerGenerated]
			get => h5;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => h5 = value;
		}

		internal virtual DataColumn DataColumn209
		{
			[CompilerGenerated]
			get => h6;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => h6 = value;
		}

		internal virtual DataColumn DataColumn210
		{
			[CompilerGenerated]
			get => h7;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => h7 = value;
		}

		internal virtual DataColumn DataColumn211
		{
			[CompilerGenerated]
			get => h8;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => h8 = value;
		}

		internal virtual DataColumn DataColumn212
		{
			[CompilerGenerated]
			get => h9;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => h9 = value;
		}

		internal virtual DataColumn DataColumn213
		{
			[CompilerGenerated]
			get => ia;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ia = value;
		}

		internal virtual DataColumn DataColumn214
		{
			[CompilerGenerated]
			get => ib;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ib = value;
		}

		internal virtual DataColumn DataColumn215
		{
			[CompilerGenerated]
			get => ic;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ic = value;
		}

		internal virtual DataColumn DataColumn216
		{
			[CompilerGenerated]
			get => id;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => id = value;
		}

		internal virtual DataColumn DataColumn217
		{
			[CompilerGenerated]
			get => ie;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ie = value;
		}

		internal virtual DataColumn DataColumn218
		{
			[CompilerGenerated]
			get => ig;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ig = value;
		}

		internal virtual DataColumn DataColumn219
		{
			[CompilerGenerated]
			get => ih;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ih = value;
		}

		internal virtual DataColumn DataColumn220
		{
			[CompilerGenerated]
			get => ii;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ii = value;
		}

		internal virtual DataColumn DataColumn221
		{
			[CompilerGenerated]
			get => ij;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ij = value;
		}

		internal virtual DataColumn DataColumn222
		{
			[CompilerGenerated]
			get => ik;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ik = value;
		}

		internal virtual DataColumn DataColumn223
		{
			[CompilerGenerated]
			get => il;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => il = value;
		}

		internal virtual DataColumn DataColumn224
		{
			[CompilerGenerated]
			get => im;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => im = value;
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
			get => io;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => io = value;
		}

		internal virtual DataColumn DataColumn227
		{
			[CompilerGenerated]
			get => ip;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ip = value;
		}

		internal virtual DataTable DataTable12
		{
			[CompilerGenerated]
			get => iq;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => iq = value;
		}

		internal virtual DataColumn DataColumn228
		{
			[CompilerGenerated]
			get => ir;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ir = value;
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
			get => it;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => it = value;
		}

		internal virtual ToolTip ToolTip_info
		{
			[CompilerGenerated]
			get => iu;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => iu = value;
		}

		internal virtual Panel Panel_PetSkillTurn
		{
			[CompilerGenerated]
			get => iv;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => iv = value;
		}

		internal virtual Panel Panel_CharSkillTurn
		{
			[CompilerGenerated]
			get => iw;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => iw = value;
		}

		internal virtual DataColumn DataColumn231
		{
			[CompilerGenerated]
			get => ix;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ix = value;
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
			get => i2;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => i2 = value;
		}

		internal virtual DataColumn DataColumn110
		{
			[CompilerGenerated]
			get => i3;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => i3 = value;
		}

		internal virtual DataColumn DataColumn232
		{
			[CompilerGenerated]
			get => i4;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => i4 = value;
		}

		internal virtual DataColumn DataColumn233
		{
			[CompilerGenerated]
			get => i5;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => i5 = value;
		}

		internal virtual DataColumn DataColumn234
		{
			[CompilerGenerated]
			get => i6;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => i6 = value;
		}

		internal virtual DataTable DataTable14
		{
			[CompilerGenerated]
			get => i7;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => i7 = value;
		}

		internal virtual DataColumn DataColumn235
		{
			[CompilerGenerated]
			get => i8;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => i8 = value;
		}

		internal virtual DataColumn DataColumn236
		{
			[CompilerGenerated]
			get => i9;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => i9 = value;
		}

		internal virtual DataColumn DataColumn237
		{
			[CompilerGenerated]
			get => ja;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ja = value;
		}

		internal virtual DataColumn DataColumn238
		{
			[CompilerGenerated]
			get => jb;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => jb = value;
		}

		internal virtual OpenFileDialog OpenFileDialog_setting
		{
			[CompilerGenerated]
			get => jc;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => jc = value;
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
			get => je;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => je = value;
		}

		internal virtual DataColumn DataColumn240
		{
			[CompilerGenerated]
			get => jf;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => jf = value;
		}

		internal virtual GroupBox GroupBox_Basic
		{
			[CompilerGenerated]
			get => jg;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => jg = value;
		}

		internal virtual GroupBox GroupBox_disconnect
		{
			[CompilerGenerated]
			get => jh;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => jh = value;
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
			get => jq;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => jq = value;
		}

		internal virtual Label Label32
		{
			[CompilerGenerated]
			get => jr;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => jr = value;
		}

		internal virtual Label Label25
		{
			[CompilerGenerated]
			get => js;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => js = value;
		}

		internal virtual Label Label23
		{
			[CompilerGenerated]
			get => jt;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => jt = value;
		}

		internal virtual TextBox TextBox_TL_char_sp_value
		{
			[CompilerGenerated]
			get => ju;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ju = value;
		}

		internal virtual Label Label22
		{
			[CompilerGenerated]
			get => jv;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => jv = value;
		}

		internal virtual TextBox TextBox_TL_char_hp_value
		{
			[CompilerGenerated]
			get => jw;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => jw = value;
		}

		internal virtual Label Label21
		{
			[CompilerGenerated]
			get => jx;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => jx = value;
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
			get => jz;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => jz = value;
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
			get => j1;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => j1 = value;
		}

		internal virtual Label Label5
		{
			[CompilerGenerated]
			get => j2;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => j2 = value;
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
			get => j8;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => j8 = value;
		}

		internal virtual DataColumn DataColumn242
		{
			[CompilerGenerated]
			get => j9;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => j9 = value;
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
			get => kc;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => kc = value;
		}

		internal virtual TabPage TabPage7
		{
			[CompilerGenerated]
			get => kd;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => kd = value;
		}

		internal virtual TabPage TabPage8
		{
			[CompilerGenerated]
			get => ke;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ke = value;
		}

		internal virtual TabPage TabPage9
		{
			[CompilerGenerated]
			get => kf;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => kf = value;
		}

		internal virtual Label Label33
		{
			[CompilerGenerated]
			get => kg;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => kg = value;
		}

		internal virtual Label Label34
		{
			[CompilerGenerated]
			get => kh;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => kh = value;
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
			get => kj;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => kj = value;
		}

		internal virtual Label Label36
		{
			[CompilerGenerated]
			get => kk;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => kk = value;
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
			get => km;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => km = value;
		}

		internal virtual Label Label43
		{
			[CompilerGenerated]
			get => kn;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => kn = value;
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
			get => kp;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => kp = value;
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
			get => kr;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => kr = value;
		}

		internal virtual Label Label46
		{
			[CompilerGenerated]
			get => ks;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ks = value;
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
			get => kw;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => kw = value;
		}

		internal virtual Label Label48
		{
			[CompilerGenerated]
			get => kx;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => kx = value;
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
			get => kz;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => kz = value;
		}

		internal virtual Label Label50
		{
			[CompilerGenerated]
			get => k0;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => k0 = value;
		}

		internal virtual DataColumn DataColumn243
		{
			[CompilerGenerated]
			get => k1;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => k1 = value;
		}

		internal virtual DataColumn DataColumn244
		{
			[CompilerGenerated]
			get => k2;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => k2 = value;
		}

		internal virtual DataColumn DataColumn245
		{
			[CompilerGenerated]
			get => k3;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => k3 = value;
		}

		internal virtual DataColumn DataColumn246
		{
			[CompilerGenerated]
			get => k4;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => k4 = value;
		}

		internal virtual DataColumn DataColumn247
		{
			[CompilerGenerated]
			get => k5;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => k5 = value;
		}

		internal virtual ContextMenuStrip ContextMenuStrip_ToTuido
		{
			[CompilerGenerated]
			get => k6;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => k6 = value;
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
			get => k8;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => k8 = value;
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
			get => lc;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => lc = value;
		}

		internal virtual DataColumn DataColumn248
		{
			[CompilerGenerated]
			get => ld;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ld = value;
		}

		internal virtual Label Label52
		{
			[CompilerGenerated]
			get => le;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => le = value;
		}

		internal virtual Label Label_CharTurnCount
		{
			[CompilerGenerated]
			get => lf;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => lf = value;
		}

		internal virtual Label Label53
		{
			[CompilerGenerated]
			get => lg;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => lg = value;
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
			get => lj;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => lj = value;
		}

		internal virtual DataColumn DataColumn250
		{
			[CompilerGenerated]
			get => lk;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => lk = value;
		}

		internal virtual DataColumn DataColumn251
		{
			[CompilerGenerated]
			get => ll;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ll = value;
		}

		internal virtual DataColumn DataColumn252
		{
			[CompilerGenerated]
			get => lm;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => lm = value;
		}

		internal virtual DataColumn DataColumn253
		{
			[CompilerGenerated]
			get => ln;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ln = value;
		}

		internal virtual DataColumn DataColumn254
		{
			[CompilerGenerated]
			get => lo;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => lo = value;
		}

		internal virtual DataColumn DataColumn255
		{
			[CompilerGenerated]
			get => lp;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => lp = value;
		}

		internal virtual DataColumn DataColumn256
		{
			[CompilerGenerated]
			get => lq;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => lq = value;
		}

		internal virtual DataColumn DataColumn257
		{
			[CompilerGenerated]
			get => lr;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => lr = value;
		}

		internal virtual DataColumn DataColumn258
		{
			[CompilerGenerated]
			get => ls;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ls = value;
		}

		internal virtual DataColumn DataColumn259
		{
			[CompilerGenerated]
			get => lt;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => lt = value;
		}

		internal virtual DataColumn DataColumn260
		{
			[CompilerGenerated]
			get => lu;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => lu = value;
		}

		internal virtual DataColumn DataColumn261
		{
			[CompilerGenerated]
			get => lv;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => lv = value;
		}

		internal virtual DataColumn DataColumn262
		{
			[CompilerGenerated]
			get => lw;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => lw = value;
		}

		internal virtual DataColumn DataColumn263
		{
			[CompilerGenerated]
			get => lx;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => lx = value;
		}

		internal virtual DataColumn DataColumn264
		{
			[CompilerGenerated]
			get => ly;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ly = value;
		}

		internal virtual DataColumn DataColumn265
		{
			[CompilerGenerated]
			get => lz;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => lz = value;
		}

		internal virtual DataColumn DataColumn266
		{
			[CompilerGenerated]
			get => l0;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => l0 = value;
		}

		internal virtual DataColumn DataColumn267
		{
			[CompilerGenerated]
			get => l1;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => l1 = value;
		}

		internal virtual DataColumn DataColumn268
		{
			[CompilerGenerated]
			get => l2;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => l2 = value;
		}

		internal virtual DataColumn DataColumn269
		{
			[CompilerGenerated]
			get => l3;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => l3 = value;
		}

		internal virtual DataColumn DataColumn270
		{
			[CompilerGenerated]
			get => l4;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => l4 = value;
		}

		internal virtual DataColumn DataColumn271
		{
			[CompilerGenerated]
			get => l5;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => l5 = value;
		}

		internal virtual DataColumn DataColumn272
		{
			[CompilerGenerated]
			get => l6;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => l6 = value;
		}

		internal virtual DataColumn DataColumn273
		{
			[CompilerGenerated]
			get => l7;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => l7 = value;
		}

		internal virtual DataColumn DataColumn274
		{
			[CompilerGenerated]
			get => l8;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => l8 = value;
		}

		internal virtual DataColumn DataColumn275
		{
			[CompilerGenerated]
			get => l9;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => l9 = value;
		}

		internal virtual DataColumn DataColumn276
		{
			[CompilerGenerated]
			get => ma;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ma = value;
		}

		internal virtual DataColumn DataColumn277
		{
			[CompilerGenerated]
			get => mb;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => mb = value;
		}

		internal virtual DataColumn DataColumn278
		{
			[CompilerGenerated]
			get => mc;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => mc = value;
		}

		internal virtual DataColumn DataColumn279
		{
			[CompilerGenerated]
			get => md;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => md = value;
		}

		internal virtual DataColumn DataColumn280
		{
			[CompilerGenerated]
			get => me;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => me = value;
		}

		internal virtual DataColumn DataColumn281
		{
			[CompilerGenerated]
			get => mf;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => mf = value;
		}

		internal virtual DataColumn DataColumn282
		{
			[CompilerGenerated]
			get => mg;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => mg = value;
		}

		internal virtual DataColumn DataColumn283
		{
			[CompilerGenerated]
			get => mh;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => mh = value;
		}

		internal virtual DataColumn DataColumn284
		{
			[CompilerGenerated]
			get => mi;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => mi = value;
		}

		internal virtual DataColumn DataColumn285
		{
			[CompilerGenerated]
			get => mj;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => mj = value;
		}

		internal virtual DataColumn DataColumn286
		{
			[CompilerGenerated]
			get => mk;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => mk = value;
		}

		internal virtual DataColumn DataColumn287
		{
			[CompilerGenerated]
			get => ml;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ml = value;
		}

		internal virtual DataColumn DataColumn288
		{
			[CompilerGenerated]
			get => mm;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => mm = value;
		}

		internal virtual DataColumn DataColumn289
		{
			[CompilerGenerated]
			get => mn;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => mn = value;
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
			get => mq;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => mq = value;
		}

		internal virtual Label Label_PetTurnCount
		{
			[CompilerGenerated]
			get => mr;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => mr = value;
		}

		internal virtual Label Label62
		{
			[CompilerGenerated]
			get => ms;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ms = value;
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
			get => mv;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => mv = value;
		}

		internal virtual GroupBox GroupBox7
		{
			[CompilerGenerated]
			get => mw;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => mw = value;
		}

		internal virtual GroupBox GroupBox6
		{
			[CompilerGenerated]
			get => mx;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => mx = value;
		}

		internal virtual GroupBox GroupBox5
		{
			[CompilerGenerated]
			get => my;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => my = value;
		}

		internal virtual GroupBox GroupBox4
		{
			[CompilerGenerated]
			get => mz;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => mz = value;
		}

		internal virtual DataTable DataTable16
		{
			[CompilerGenerated]
			get => m0;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => m0 = value;
		}

		internal virtual DataColumn DataColumn290
		{
			[CompilerGenerated]
			get => m1;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => m1 = value;
		}

		internal virtual DataColumn DataColumn291
		{
			[CompilerGenerated]
			get => m2;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => m2 = value;
		}

		internal virtual DataTable DataTable17
		{
			[CompilerGenerated]
			get => m3;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => m3 = value;
		}

		internal virtual DataColumn DataColumn292
		{
			[CompilerGenerated]
			get => m4;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => m4 = value;
		}

		internal virtual DataColumn DataColumn293
		{
			[CompilerGenerated]
			get => m5;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => m5 = value;
		}

		internal virtual DataTable DataTable18
		{
			[CompilerGenerated]
			get => m6;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => m6 = value;
		}

		internal virtual DataColumn DataColumn294
		{
			[CompilerGenerated]
			get => m7;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => m7 = value;
		}

		internal virtual DataColumn DataColumn295
		{
			[CompilerGenerated]
			get => m8;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => m8 = value;
		}

		internal virtual TabControl TabControl_ItemSetting
		{
			[CompilerGenerated]
			get => m9;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => m9 = value;
		}

		internal virtual TabPage TabPage11
		{
			[CompilerGenerated]
			get => na;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => na = value;
		}

		internal virtual TabPage TabPage12
		{
			[CompilerGenerated]
			get => nb;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => nb = value;
		}

		internal virtual Label Label63
		{
			[CompilerGenerated]
			get => nc;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => nc = value;
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
			get => ne;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ne = value;
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
			get => no;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => no = value;
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
			get => nq;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => nq = value;
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
			get => nz;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => nz = value;
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
			get => n1;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => n1 = value;
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
			get => n3;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => n3 = value;
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
			get => n7;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => n7 = value;
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
			get => oc;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => oc = value;
		}

		internal virtual DataTable DataTable19
		{
			[CompilerGenerated]
			get => od;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => od = value;
		}

		internal virtual DataColumn DataColumn296
		{
			[CompilerGenerated]
			get => oe;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => oe = value;
		}

		internal virtual DataColumn DataColumn297
		{
			[CompilerGenerated]
			get => of;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => of = value;
		}

		internal virtual DataColumn DataColumn298
		{
			[CompilerGenerated]
			get => og;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => og = value;
		}

		internal virtual DataColumn DataColumn299
		{
			[CompilerGenerated]
			get => oh;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => oh = value;
		}

		internal virtual DataColumn DataColumn300
		{
			[CompilerGenerated]
			get => oi;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => oi = value;
		}

		internal virtual DataColumn DataColumn301
		{
			[CompilerGenerated]
			get => oj;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => oj = value;
		}

		internal virtual DataColumn DataColumn302
		{
			[CompilerGenerated]
			get => ok;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ok = value;
		}

		internal virtual DataTable DataTable21
		{
			[CompilerGenerated]
			get => ol;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ol = value;
		}

		internal virtual DataColumn DataColumn303
		{
			[CompilerGenerated]
			get => om;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => om = value;
		}

		internal virtual DataColumn DataColumn304
		{
			[CompilerGenerated]
			get => on;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => on = value;
		}

		internal virtual DataColumn DataColumn305
		{
			[CompilerGenerated]
			get => oo;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => oo = value;
		}

		internal virtual DataColumn DataColumn306
		{
			[CompilerGenerated]
			get => op;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => op = value;
		}

		internal virtual DataColumn DataColumn307
		{
			[CompilerGenerated]
			get => oq;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => oq = value;
		}

		internal virtual DataColumn DataColumn308
		{
			[CompilerGenerated]
			get => or;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => or = value;
		}

		internal virtual DataColumn DataColumn309
		{
			[CompilerGenerated]
			get => os;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => os = value;
		}

		internal virtual DataTable DataTable22
		{
			[CompilerGenerated]
			get => ot;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ot = value;
		}

		internal virtual DataColumn DataColumn310
		{
			[CompilerGenerated]
			get => ou;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ou = value;
		}

		internal virtual DataColumn DataColumn311
		{
			[CompilerGenerated]
			get => ov;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ov = value;
		}

		internal virtual DataColumn DataColumn312
		{
			[CompilerGenerated]
			get => ow;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ow = value;
		}

		internal virtual DataColumn DataColumn313
		{
			[CompilerGenerated]
			get => ox;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ox = value;
		}

		internal virtual DataColumn DataColumn314
		{
			[CompilerGenerated]
			get => oy;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => oy = value;
		}

		internal virtual DataColumn DataColumn315
		{
			[CompilerGenerated]
			get => oz;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => oz = value;
		}

		internal virtual DataColumn DataColumn316
		{
			[CompilerGenerated]
			get => o0;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => o0 = value;
		}

		internal virtual DataTable DataTable23
		{
			[CompilerGenerated]
			get => o1;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => o1 = value;
		}

		internal virtual DataColumn DataColumn317
		{
			[CompilerGenerated]
			get => o2;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => o2 = value;
		}

		internal virtual DataColumn DataColumn318
		{
			[CompilerGenerated]
			get => o3;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => o3 = value;
		}

		internal virtual DataColumn DataColumn319
		{
			[CompilerGenerated]
			get => o4;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => o4 = value;
		}

		internal virtual DataColumn DataColumn320
		{
			[CompilerGenerated]
			get => o5;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => o5 = value;
		}

		internal virtual DataColumn DataColumn321
		{
			[CompilerGenerated]
			get => o6;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => o6 = value;
		}

		internal virtual DataColumn DataColumn322
		{
			[CompilerGenerated]
			get => o7;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => o7 = value;
		}

		internal virtual DataColumn DataColumn323
		{
			[CompilerGenerated]
			get => o8;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => o8 = value;
		}

		internal virtual DataTable DataTable24
		{
			[CompilerGenerated]
			get => o9;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => o9 = value;
		}

		internal virtual DataColumn DataColumn324
		{
			[CompilerGenerated]
			get => pa;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => pa = value;
		}

		internal virtual DataColumn DataColumn325
		{
			[CompilerGenerated]
			get => pb;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => pb = value;
		}

		internal virtual DataColumn DataColumn326
		{
			[CompilerGenerated]
			get => pc;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => pc = value;
		}

		internal virtual DataColumn DataColumn327
		{
			[CompilerGenerated]
			get => pd;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => pd = value;
		}

		internal virtual DataColumn DataColumn328
		{
			[CompilerGenerated]
			get => pe;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => pe = value;
		}

		internal virtual DataColumn DataColumn329
		{
			[CompilerGenerated]
			get => pf;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => pf = value;
		}

		internal virtual DataColumn DataColumn330
		{
			[CompilerGenerated]
			get => pg;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => pg = value;
		}

		internal virtual DataTable DataTable25
		{
			[CompilerGenerated]
			get => ph;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ph = value;
		}

		internal virtual DataColumn DataColumn331
		{
			[CompilerGenerated]
			get => pi;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => pi = value;
		}

		internal virtual DataColumn DataColumn332
		{
			[CompilerGenerated]
			get => pj;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => pj = value;
		}

		internal virtual DataColumn DataColumn333
		{
			[CompilerGenerated]
			get => pk;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => pk = value;
		}

		internal virtual DataColumn DataColumn334
		{
			[CompilerGenerated]
			get => pl;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => pl = value;
		}

		internal virtual DataColumn DataColumn335
		{
			[CompilerGenerated]
			get => pm;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => pm = value;
		}

		internal virtual DataColumn DataColumn336
		{
			[CompilerGenerated]
			get => pn;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => pn = value;
		}

		internal virtual DataColumn DataColumn337
		{
			[CompilerGenerated]
			get => po;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => po = value;
		}

		internal virtual DataTable DataTable26
		{
			[CompilerGenerated]
			get => pp;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => pp = value;
		}

		internal virtual DataColumn DataColumn338
		{
			[CompilerGenerated]
			get => pq;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => pq = value;
		}

		internal virtual DataColumn DataColumn339
		{
			[CompilerGenerated]
			get => pr;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => pr = value;
		}

		internal virtual DataColumn DataColumn340
		{
			[CompilerGenerated]
			get => ps;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ps = value;
		}

		internal virtual DataColumn DataColumn341
		{
			[CompilerGenerated]
			get => pt;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => pt = value;
		}

		internal virtual DataColumn DataColumn342
		{
			[CompilerGenerated]
			get => pu;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => pu = value;
		}

		internal virtual DataColumn DataColumn343
		{
			[CompilerGenerated]
			get => pv;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => pv = value;
		}

		internal virtual DataColumn DataColumn344
		{
			[CompilerGenerated]
			get => pw;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => pw = value;
		}

		internal virtual DataTable DataTable27
		{
			[CompilerGenerated]
			get => px;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => px = value;
		}

		internal virtual DataColumn DataColumn345
		{
			[CompilerGenerated]
			get => py;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => py = value;
		}

		internal virtual DataColumn DataColumn346
		{
			[CompilerGenerated]
			get => pz;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => pz = value;
		}

		internal virtual DataColumn DataColumn347
		{
			[CompilerGenerated]
			get => p0;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => p0 = value;
		}

		internal virtual DataColumn DataColumn348
		{
			[CompilerGenerated]
			get => p1;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => p1 = value;
		}

		internal virtual DataColumn DataColumn349
		{
			[CompilerGenerated]
			get => p2;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => p2 = value;
		}

		internal virtual DataColumn DataColumn350
		{
			[CompilerGenerated]
			get => p3;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => p3 = value;
		}

		internal virtual DataColumn DataColumn351
		{
			[CompilerGenerated]
			get => p4;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => p4 = value;
		}

		internal virtual DataTable DataTable28
		{
			[CompilerGenerated]
			get => p5;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => p5 = value;
		}

		internal virtual DataColumn DataColumn352
		{
			[CompilerGenerated]
			get => p6;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => p6 = value;
		}

		internal virtual DataColumn DataColumn353
		{
			[CompilerGenerated]
			get => p7;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => p7 = value;
		}

		internal virtual DataColumn DataColumn354
		{
			[CompilerGenerated]
			get => p8;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => p8 = value;
		}

		internal virtual DataColumn DataColumn355
		{
			[CompilerGenerated]
			get => p9;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => p9 = value;
		}

		internal virtual DataColumn DataColumn356
		{
			[CompilerGenerated]
			get => qa;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => qa = value;
		}

		internal virtual DataColumn DataColumn357
		{
			[CompilerGenerated]
			get => qb;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => qb = value;
		}

		internal virtual DataColumn DataColumn358
		{
			[CompilerGenerated]
			get => qc;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => qc = value;
		}

		internal virtual DataTable DataTable29
		{
			[CompilerGenerated]
			get => qd;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => qd = value;
		}

		internal virtual DataColumn DataColumn359
		{
			[CompilerGenerated]
			get => qe;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => qe = value;
		}

		internal virtual DataColumn DataColumn360
		{
			[CompilerGenerated]
			get => qf;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => qf = value;
		}

		internal virtual DataColumn DataColumn361
		{
			[CompilerGenerated]
			get => qg;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => qg = value;
		}

		internal virtual DataColumn DataColumn362
		{
			[CompilerGenerated]
			get => qh;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => qh = value;
		}

		internal virtual DataColumn DataColumn363
		{
			[CompilerGenerated]
			get => qi;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => qi = value;
		}

		internal virtual DataColumn DataColumn364
		{
			[CompilerGenerated]
			get => qj;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => qj = value;
		}

		internal virtual DataColumn DataColumn365
		{
			[CompilerGenerated]
			get => qk;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => qk = value;
		}

		internal virtual DataTable DataTable30
		{
			[CompilerGenerated]
			get => ql;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => ql = value;
		}

		internal virtual DataColumn DataColumn366
		{
			[CompilerGenerated]
			get => qm;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => qm = value;
		}

		internal virtual DataColumn DataColumn367
		{
			[CompilerGenerated]
			get => qn;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => qn = value;
		}

		internal virtual DataColumn DataColumn368
		{
			[CompilerGenerated]
			get => qo;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => qo = value;
		}

		internal virtual DataColumn DataColumn369
		{
			[CompilerGenerated]
			get => qp;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => qp = value;
		}

		internal virtual DataColumn DataColumn370
		{
			[CompilerGenerated]
			get => qq;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => qq = value;
		}

		internal virtual DataColumn DataColumn371
		{
			[CompilerGenerated]
			get => qr;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => qr = value;
		}

		internal virtual DataColumn DataColumn372
		{
			[CompilerGenerated]
			get => qs;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => qs = value;
		}

		internal virtual DataTable DataTable31
		{
			[CompilerGenerated]
			get => qt;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => qt = value;
		}

		internal virtual DataColumn DataColumn373
		{
			[CompilerGenerated]
			get => qu;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => qu = value;
		}

		internal virtual DataColumn DataColumn374
		{
			[CompilerGenerated]
			get => qv;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => qv = value;
		}

		internal virtual DataColumn DataColumn375
		{
			[CompilerGenerated]
			get => qw;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => qw = value;
		}

		internal virtual DataColumn DataColumn376
		{
			[CompilerGenerated]
			get => qx;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => qx = value;
		}

		internal virtual DataColumn DataColumn377
		{
			[CompilerGenerated]
			get => qy;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => qy = value;
		}

		internal virtual DataColumn DataColumn378
		{
			[CompilerGenerated]
			get => qz;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => qz = value;
		}

		internal virtual DataColumn DataColumn379
		{
			[CompilerGenerated]
			get => q0;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => q0 = value;
		}

		internal virtual DataTable DataTable32
		{
			[CompilerGenerated]
			get => q1;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => q1 = value;
		}

		internal virtual DataColumn DataColumn380
		{
			[CompilerGenerated]
			get => q2;
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set => q2 = value;
		}

	}
}
