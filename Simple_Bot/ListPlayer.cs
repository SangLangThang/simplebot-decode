using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Simple_Bot
{
	[DesignerGenerated]
	public class ListPlayer : Form
	{
		private IContainer m_a;

		[AccessedThroughProperty("TextBox_FindID")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private TextBox m_b;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("ListView1")]
		private ListView c;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ColumnHeader_Online")]
		private ColumnHeader d;

		[AccessedThroughProperty("ColumnHeader_Id")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ColumnHeader e;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ColumnHeader_Name")]
		private ColumnHeader f;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ColumnHeader_Lv")]
		[CompilerGenerated]
		private ColumnHeader g;

		[AccessedThroughProperty("ColumnHeader_Mapid")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ColumnHeader h;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("ColumnHeader_MapX")]
		private ColumnHeader i;

		[AccessedThroughProperty("ColumnHeader_MapY")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private ColumnHeader j;

		[AccessedThroughProperty("ColumnHeader_Reborn")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private ColumnHeader k;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("Label_PlayerCount")]
		private Label l;

		[AccessedThroughProperty("Timer1")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Timer m;

		public _ClientBot _bot;

		internal virtual TextBox TextBox_FindID
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
				EventHandler value2 = b;
				TextBox textBox = this.m_b;
				if (textBox != null)
				{
					textBox.TextChanged -= value2;
				}
				this.m_b = value;
				textBox = this.m_b;
				if (textBox != null)
				{
					textBox.TextChanged += value2;
				}
			}
		}

		internal virtual ListView ListView1
		{
			[CompilerGenerated]
			get
			{
				return c;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				c = value;
			}
		}

		internal virtual ColumnHeader ColumnHeader_Online
		{
			[CompilerGenerated]
			get
			{
				return d;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				d = value;
			}
		}

		internal virtual ColumnHeader ColumnHeader_Id
		{
			[CompilerGenerated]
			get
			{
				return e;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				e = value;
			}
		}

		internal virtual ColumnHeader ColumnHeader_Name
		{
			[CompilerGenerated]
			get
			{
				return f;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				f = value;
			}
		}

		internal virtual ColumnHeader ColumnHeader_Lv
		{
			[CompilerGenerated]
			get
			{
				return g;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				g = value;
			}
		}

		internal virtual ColumnHeader ColumnHeader_Mapid
		{
			[CompilerGenerated]
			get
			{
				return h;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				h = value;
			}
		}

		internal virtual ColumnHeader ColumnHeader_MapX
		{
			[CompilerGenerated]
			get
			{
				return i;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				i = value;
			}
		}

		internal virtual ColumnHeader ColumnHeader_MapY
		{
			[CompilerGenerated]
			get
			{
				return j;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				j = value;
			}
		}

		internal virtual ColumnHeader ColumnHeader_Reborn
		{
			[CompilerGenerated]
			get
			{
				return k;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				k = value;
			}
		}

		internal virtual Label Label_PlayerCount
		{
			[CompilerGenerated]
			get
			{
				return l;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				l = value;
			}
		}

		internal virtual Timer Timer1
		{
			[CompilerGenerated]
			get
			{
				return m;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = a;
				Timer timer = m;
				if (timer != null)
				{
					timer.Tick -= value2;
				}
				m = value;
				timer = m;
				if (timer != null)
				{
					timer.Tick += value2;
				}
			}
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
		private void a()
		{
			this.m_a = new Container();
			TextBox_FindID = new TextBox();
			ListView1 = new ListView();
			ColumnHeader_Online = new ColumnHeader();
			ColumnHeader_Id = new ColumnHeader();
			ColumnHeader_Name = new ColumnHeader();
			ColumnHeader_Lv = new ColumnHeader();
			ColumnHeader_Mapid = new ColumnHeader();
			ColumnHeader_MapX = new ColumnHeader();
			ColumnHeader_MapY = new ColumnHeader();
			ColumnHeader_Reborn = new ColumnHeader();
			Label_PlayerCount = new Label();
			Timer1 = new Timer(this.m_a);
			SuspendLayout();
			TextBox_FindID.Location = new Point(11, 583);
			TextBox_FindID.Margin = new Padding(2);
			TextBox_FindID.MaxLength = 20;
			TextBox_FindID.Multiline = true;
			TextBox_FindID.Name = "TextBox_FindID";
			TextBox_FindID.Size = new Size(124, 19);
			TextBox_FindID.TabIndex = 57;
			ListView1.Activation = ItemActivation.OneClick;
			ListView1.Columns.AddRange(new ColumnHeader[8] { ColumnHeader_Online, ColumnHeader_Id, ColumnHeader_Name, ColumnHeader_Lv, ColumnHeader_Mapid, ColumnHeader_MapX, ColumnHeader_MapY, ColumnHeader_Reborn });
			ListView1.Dock = DockStyle.Top;
			ListView1.FullRowSelect = true;
			ListView1.GridLines = true;
			ListView1.HideSelection = false;
			ListView1.Location = new Point(0, 0);
			ListView1.MultiSelect = false;
			ListView1.Name = "ListView1";
			ListView1.Size = new Size(663, 578);
			ListView1.TabIndex = 110;
			ListView1.UseCompatibleStateImageBehavior = false;
			ListView1.View = View.Details;
			ColumnHeader_Online.Text = "";
			ColumnHeader_Online.Width = 30;
			ColumnHeader_Id.Text = "Id";
			ColumnHeader_Id.Width = 45;
			ColumnHeader_Name.Text = "Tên";
			ColumnHeader_Name.Width = 80;
			ColumnHeader_Lv.Text = "Lv";
			ColumnHeader_Lv.Width = 30;
			ColumnHeader_Mapid.Text = "Mapid";
			ColumnHeader_Mapid.Width = 45;
			ColumnHeader_MapX.Text = "X";
			ColumnHeader_MapX.Width = 45;
			ColumnHeader_MapY.Text = "Y";
			ColumnHeader_MapY.Width = 45;
			ColumnHeader_Reborn.Text = "CS";
			ColumnHeader_Reborn.Width = 30;
			Label_PlayerCount.Location = new Point(458, 590);
			Label_PlayerCount.Margin = new Padding(0, 1, 0, 1);
			Label_PlayerCount.Name = "Label_PlayerCount";
			Label_PlayerCount.Size = new Size(196, 13);
			Label_PlayerCount.TabIndex = 111;
			Label_PlayerCount.Text = "0";
			Label_PlayerCount.TextAlign = ContentAlignment.MiddleRight;
			Timer1.Enabled = true;
			Timer1.Interval = 1000;
			base.AutoScaleMode = AutoScaleMode.Inherit;
			base.ClientSize = new Size(663, 613);
			base.Controls.Add(Label_PlayerCount);
			base.Controls.Add(ListView1);
			base.Controls.Add(TextBox_FindID);
			base.FormBorderStyle = FormBorderStyle.None;
			base.Name = "ListPlayer";
			Text = "ListPlayer";
			ResumeLayout(false);
			PerformLayout();
		}

		public ListPlayer(_ClientBot _b)
		{
			a();
			_bot = _b;
			foreach (Listplayers._Player value in _bot.Data_Players.Values)
			{
				ListViewItem listViewItem = ListView1.Items.Add(Conversions.ToString(value._Id));
				listViewItem.SubItems.Add(value._Online);
				listViewItem.SubItems.Add(value._Name);
				listViewItem.SubItems.Add(Conversions.ToString(value._Lv));
				listViewItem.SubItems.Add(Conversions.ToString(value._MapId));
				listViewItem.SubItems.Add(Conversions.ToString(value._MapX));
				listViewItem.SubItems.Add(Conversions.ToString(value._MapY));
				listViewItem.SubItems.Add(Conversions.ToString(value._Reborn));
				listViewItem.SubItems.Add(Conversions.ToString(value._ThuocTinh));
				switch (value._ThuocTinh)
				{
				case 1:
					listViewItem.BackColor = Color.Peru;
					break;
				case 2:
					listViewItem.BackColor = Color.LightBlue;
					break;
				case 3:
					listViewItem.BackColor = Color.LightCoral;
					break;
				case 4:
					listViewItem.BackColor = Color.LightGreen;
					break;
				}
			}
		}

		private void b(object A_0, EventArgs A_1)
		{
			try
			{
				ListView1.TopItem = ListView1.FindItemWithText(TextBox_FindID.Text, false, 0);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

		private void a(object A_0, EventArgs A_1)
		{
			Label_PlayerCount.Text = Conversions.ToString(_bot.PlayerCount);
		}
	}
}
