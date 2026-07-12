using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Simple_Bot
{
	[DesignerGenerated]
	public class Form1 : Form
	{
		private IContainer m_a;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("Label1")]
		private Label m_b;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button1")]
		private Button c;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label57")]
		[CompilerGenerated]
		private Label d;

		[AccessedThroughProperty("TextBox1")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private TextBox e;

		public _ClientBot _bot;

		internal virtual Label Label1
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

		internal virtual Button Button1
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
				EventHandler value2 = a;
				Button button = c;
				if (button != null)
				{
					button.Click -= value2;
				}
				c = value;
				button = c;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual Label Label57
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

		internal virtual TextBox TextBox1
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
				KeyEventHandler value2 = a;
				TextBox textBox = e;
				if (textBox != null)
				{
					textBox.KeyDown -= value2;
				}
				e = value;
				textBox = e;
				if (textBox != null)
				{
					textBox.KeyDown += value2;
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
			Label1 = new Label();
			Button1 = new Button();
			Label57 = new Label();
			TextBox1 = new TextBox();
			SuspendLayout();
			Label1.BackColor = Color.White;
			Label1.Dock = DockStyle.Top;
			Label1.Font = new Font("Consolas", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label1.Location = new Point(0, 0);
			Label1.Name = "Label1";
			Label1.Size = new Size(349, 263);
			Label1.TabIndex = 0;
			Label1.Text = "Label1";
			Button1.FlatStyle = FlatStyle.System;
			Button1.Location = new Point(241, 265);
			Button1.Margin = new Padding(2);
			Button1.Name = "Button1";
			Button1.Size = new Size(97, 20);
			Button1.TabIndex = 45;
			Button1.Text = "Trả lời";
			Button1.UseVisualStyleBackColor = true;
			Label57.AutoSize = true;
			Label57.BackColor = Color.FromArgb(240, 240, 240);
			Label57.FlatStyle = FlatStyle.System;
			Label57.Location = new Point(13, 269);
			Label57.Margin = new Padding(2);
			Label57.Name = "Label57";
			Label57.Size = new Size(122, 13);
			Label57.TabIndex = 46;
			Label57.Text = "Nhập dãy số đăng nhập";
			TextBox1.Location = new Point(137, 266);
			TextBox1.Margin = new Padding(2);
			TextBox1.MaxLength = 20;
			TextBox1.Name = "TextBox1";
			TextBox1.Size = new Size(100, 20);
			TextBox1.TabIndex = 47;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(349, 292);
			base.Controls.Add(Button1);
			base.Controls.Add(Label57);
			base.Controls.Add(TextBox1);
			base.Controls.Add(Label1);
			base.Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		public Form1(_ClientBot _b, Point _p)
		{
			base.Load += b;
			a();
			_bot = _b;
			Label1.Text = _bot._Antibot_str;
			base.Location = _p;
		}

		private void b(object A_0, EventArgs A_1)
		{
		}

		private void a(object A_0, EventArgs A_1)
		{
			try
			{
				if (_bot != null)
				{
					if (TextBox1.TextLength == 4)
					{
						int num = Conversions.ToInteger(TextBox1.Text.Substring(0, 1));
						int num2 = Conversions.ToInteger(TextBox1.Text.Substring(1, 1));
						int num3 = Conversions.ToInteger(TextBox1.Text.Substring(2, 1));
						int num4 = Conversions.ToInteger(TextBox1.Text.Substring(3, 1));
						_bot.SendPacket(API.hexstringtobyte("F44406003701" + Strings.Asc(num.ToString()).ToString("X2") + Strings.Asc(num2.ToString()).ToString("X2") + Strings.Asc(num3.ToString()).ToString("X2") + Strings.Asc(num4.ToString()).ToString("X2")));
					}
					else
					{
						_bot._Disconnect();
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			Close();
		}

		private void a(object A_0, KeyEventArgs A_1)
		{
			if (A_1.KeyCode != Keys.Return)
			{
				return;
			}
			if (_bot != null)
			{
				if (TextBox1.TextLength == 4)
				{
					int num = Conversions.ToInteger(TextBox1.Text.Substring(0, 1));
					int num2 = Conversions.ToInteger(TextBox1.Text.Substring(1, 1));
					int num3 = Conversions.ToInteger(TextBox1.Text.Substring(2, 1));
					int num4 = Conversions.ToInteger(TextBox1.Text.Substring(3, 1));
					_bot.SendPacket(API.hexstringtobyte("F44406003701" + Strings.Asc(num.ToString()).ToString("X2") + Strings.Asc(num2.ToString()).ToString("X2") + Strings.Asc(num3.ToString()).ToString("X2") + Strings.Asc(num4.ToString()).ToString("X2")));
				}
			}
			else
			{
				_bot._Disconnect();
			}
			Close();
		}
	}
}
