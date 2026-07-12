using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Simple_Bot.SPB
{
	[ToolboxBitmap(typeof(ProgressBarEx), "ProgressBarEx.ico")]
	[DefaultProperty("Value")]
	public class ProgressBarEx : Control
	{
		public enum TextPercen
		{
			Text,
			Percen,
			None
		}

		public enum ColorStyle
		{
			Gradient = 1,
			Solid = 0
		}

		public enum Direct
		{
			Normal,
			Reverse
		}

		public enum Orient
		{
			Horizontal,
			Vertical
		}

		public enum SigmaMode
		{
			None,
			SigmaBell
		}

		public enum StretchMode
		{
			Normal,
			Stretch
		}

		private SolidBrush m_a;

		private Font b;

		private ToolTip c;

		private TextPercen d;

		private IContainer e;

		private bool f;

		private bool g;

		private int h;

		private Color i;

		private Color j;

		private ColorStyle k;

		private LinearGradientMode l;

		private float m;

		private SigmaMode n;

		private float o;

		private Color p;

		private Color q;

		private ColorStyle r;

		private LinearGradientMode s;

		private StretchMode t;

		private float u;

		private SigmaMode v;

		private float w;

		private BorderStyle x;

		private decimal y;

		private int z;

		private int aa;

		private decimal ab;

		private int ac;

		[DefaultValue(typeof(TextPercen), "Text")]
		[Category("Behavior")]
		[Description("Specify how to display the Percentage value")]
		public TextPercen BarTextPercen
		{
			get
			{
				return d;
			}
			set
			{
				d = value;
				Refresh();
			}
		}

		[Browsable(false)]
		public Color BackColorBar
		{
			get
			{
				return base.BackColor;
			}
		}

		[Category("Appearance")]
		[DefaultValue(typeof(Color), "ControlDark")]
		[Description("The background color of the ProgressBar.")]
		public Color BackColor1
		{
			get
			{
				return i;
			}
			set
			{
				i = value;
				Invalidate();
			}
		}

		[Description("The background end color of the ProgressBar in Gradient mode.")]
		[DefaultValue(typeof(Color), "ControlLight")]
		[Category("Appearance")]
		public Color BackColor2
		{
			get
			{
				return j;
			}
			set
			{
				j = value;
				Invalidate();
			}
		}

		[Description("The background color style of the ProgressBar.")]
		[Category("Appearance")]
		[DefaultValue(typeof(ColorStyle), "Solid")]
		public ColorStyle BackColorStyle
		{
			get
			{
				return k;
			}
			set
			{
				k = value;
				Invalidate();
			}
		}

		[Category("Appearance")]
		[Description("The direction of the background gradient fill in Gradient mode.")]
		[DefaultValue(typeof(LinearGradientMode), "Horizontal")]
		public LinearGradientMode BackGradientMode
		{
			get
			{
				return l;
			}
			set
			{
				l = value;
				Invalidate();
			}
		}

		[DefaultValue(50)]
		[Category("Appearance")]
		[Description("A value from 0 through 100 that specifies the center of the background gradient in SigmaBell mode.")]
		public int BackSigmaFocus
		{
			get
			{
				return checked((int)Math.Round(m * 100f));
			}
			set
			{
				if (value < 0)
				{
					m = 0f;
				}
				else if (value > 100)
				{
					m = 1f;
				}
				else
				{
					m = (float)value / 100f;
				}
				Invalidate();
			}
		}

		[Category("Appearance")]
		[DefaultValue(typeof(SigmaMode), "None")]
		[Description("When set to SigmaBell, creates a background gradient falloff based on a bell-shaped curve using the BackSigmaFocus and BackSigmaScale values.")]
		public SigmaMode BackSigmaMode
		{
			get
			{
				return n;
			}
			set
			{
				n = value;
				Invalidate();
			}
		}

		[Description("A value from 0 through 100 that specifies how fast the background color falls off from the focus in SigmaBell mode.")]
		[Category("Appearance")]
		[DefaultValue(100)]
		public int BackSigmaScale
		{
			get
			{
				return checked((int)Math.Round(o * 100f));
			}
			set
			{
				if (value < 0)
				{
					o = 0f;
				}
				else if (value > 100)
				{
					o = 1f;
				}
				else
				{
					o = (float)value / 100f;
				}
				Invalidate();
			}
		}

		[DefaultValue(typeof(Color), "Highlight")]
		[Category("Appearance")]
		[Description("The foreground color used to display the current progress value of the ProgressBar.")]
		public Color BarColor1
		{
			get
			{
				return p;
			}
			set
			{
				p = value;
				Invalidate();
			}
		}

		[Category("Appearance")]
		[Description("The foreground end color used to display the current progress value of the ProgressBar in Gradient mode.")]
		[DefaultValue(typeof(Color), "HighlightText")]
		public Color BarColor2
		{
			get
			{
				return q;
			}
			set
			{
				q = value;
				Invalidate();
			}
		}

		[Category("Appearance")]
		[Description("The foreground color style of the ProgressBar.")]
		[DefaultValue(typeof(ColorStyle), "Solid")]
		public ColorStyle BarColorStyle
		{
			get
			{
				return r;
			}
			set
			{
				r = value;
				Invalidate();
			}
		}

		[Category("Appearance")]
		[DefaultValue(typeof(LinearGradientMode), "Horizontal")]
		[Description("The direction of the foreground gradient fill in Gradient mode.")]
		public LinearGradientMode BarGradientMode
		{
			get
			{
				return s;
			}
			set
			{
				s = value;
				Invalidate();
			}
		}

		[Description("Determines if the bar gradient stretches as the bar progresses.")]
		[Category("Appearance")]
		[DefaultValue(typeof(StretchMode), "Normal")]
		public StretchMode BarGradientStretch
		{
			get
			{
				return t;
			}
			set
			{
				t = value;
				Invalidate();
			}
		}

		[DefaultValue(50)]
		[Description("A value from 0 through 100 that specifies the center of the foreground gradient in SigmaBell mode.")]
		[Category("Appearance")]
		public int BarSigmaFocus
		{
			get
			{
				return checked((int)Math.Round(u * 100f));
			}
			set
			{
				if (value < 0)
				{
					u = 0f;
				}
				else if (value > 100)
				{
					u = 1f;
				}
				else
				{
					u = (float)value / 100f;
				}
				Invalidate();
			}
		}

		[DefaultValue(typeof(SigmaMode), "None")]
		[Category("Appearance")]
		[Description("When set to SigmaBell, creates a foreground gradient falloff based on a bell-shaped curve using the BarSigmaFocus and BarSigmaScale values.")]
		public SigmaMode BarSigmaMode
		{
			get
			{
				return v;
			}
			set
			{
				v = value;
				Invalidate();
			}
		}

		[Description("A value from 0 through 100 that specifies how fast the foreground color falls off from the focus in SigmaBell mode.")]
		[Category("Appearance")]
		[DefaultValue(100)]
		public int BarSigmaScale
		{
			get
			{
				return checked((int)Math.Round(w * 100f));
			}
			set
			{
				if (value < 0)
				{
					w = 0f;
				}
				else if (value > 100)
				{
					w = 1f;
				}
				else
				{
					w = (float)value / 100f;
				}
				Invalidate();
			}
		}

		[DefaultValue(typeof(BorderStyle), "Fixed3D")]
		[Category("Appearance")]
		[Description("Indicates whether or not the ProgressBar should have a border.")]
		public BorderStyle BorderStyle
		{
			get
			{
				return x;
			}
			set
			{
				x = value;
				Invalidate();
			}
		}

		[Description("Direction of fill progression.")]
		[Category("Behavior")]
		[DefaultValue(typeof(Direct), "Normal")]
		public Direct Direction
		{
			get
			{
				if (g)
				{
					return Direct.Reverse;
				}
				return Direct.Normal;
			}
			set
			{
				if (value != Direction)
				{
					g = value == Direct.Reverse;
					Invalidate();
				}
			}
		}

		[Browsable(false)]
		public Font FontBar
		{
			get
			{
				return base.Font;
			}
		}

		[Browsable(false)]
		public Color ForeColorBar
		{
			get
			{
				return base.ForeColor;
			}
		}

		[Description("The upper bound of the range this ProgressBar is working with.")]
		[Category("Behavior")]
		[RefreshProperties(RefreshProperties.All)]
		[DefaultValue(100)]
		public int Maximum
		{
			get
			{
				return h;
			}
			set
			{
				if (value <= z)
				{
					h = checked(z + 1);
				}
				else
				{
					h = value;
				}
				if (ac > h)
				{
					ac = h;
				}
				Invalidate();
			}
		}

		[RefreshProperties(RefreshProperties.All)]
		[Description("The lower bound of the range this ProgressBar is working with.")]
		[Category("Behavior")]
		[DefaultValue(0)]
		public int Minimum
		{
			get
			{
				return z;
			}
			set
			{
				if (value < 0)
				{
					value = 0;
				}
				z = value;
				if (z >= h)
				{
					h = checked(z + 1);
				}
				if (ac < z)
				{
					ac = z;
				}
				Invalidate();
			}
		}

		[DefaultValue(typeof(Orient), "Horizontal")]
		[Description("Orientation of the ProgressBar.")]
		[Category("Behavior")]
		public Orient Orientation
		{
			get
			{
				if (f)
				{
					return Orient.Horizontal;
				}
				return Orient.Vertical;
			}
			set
			{
				if (value != Orientation)
				{
					int num = base.Width;
					base.Width = base.Height;
					base.Height = num;
					f = value == Orient.Horizontal;
				}
			}
		}

		[Description("The amount to increment the current value of the control by when the PerformStep() method is called.")]
		[DefaultValue(1)]
		[Category("Behavior")]
		public int Step
		{
			get
			{
				return aa;
			}
			set
			{
				aa = value;
			}
		}

		[Browsable(false)]
		public string TextBar
		{
			get
			{
				return base.Text;
			}
		}

		[DefaultValue(0)]
		[Description("The current value for the ProgressBar, in the range specified by the Minimum and Maximum properties.")]
		[RefreshProperties(RefreshProperties.All)]
		[Category("Behavior")]
		public int Value
		{
			get
			{
				return ac;
			}
			set
			{
				if (value < z)
				{
					ac = z;
				}
				else if (value > h)
				{
					ac = h;
				}
				else
				{
					ac = value;
				}
				Invalidate();
			}
		}

		public ProgressBarEx()
		{
			c = new ToolTip();
			f = true;
			g = false;
			h = 100;
			i = SystemColors.ControlDark;
			j = SystemColors.ControlLight;
			k = ColorStyle.Solid;
			l = LinearGradientMode.Horizontal;
			m = 0.5f;
			n = SigmaMode.None;
			o = 1f;
			p = SystemColors.Highlight;
			q = SystemColors.HighlightText;
			r = ColorStyle.Solid;
			s = LinearGradientMode.Horizontal;
			t = StretchMode.Normal;
			u = 0.5f;
			v = SigmaMode.None;
			w = 1f;
			x = BorderStyle.Fixed3D;
			z = 0;
			aa = 1;
			ac = 0;
			a();
			SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer, true);
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && e != null)
			{
				e.Dispose();
			}
			base.Dispose(disposing);
		}

		private void a(Graphics A_0)
		{
			checked
			{
				int num = (int)Math.Round(Pens.White.Width);
				Pen pen;
				Pen pen2;
				if (BorderStyle == BorderStyle.Fixed3D)
				{
					pen = new Pen(SystemColors.ControlDark, 1f);
					pen2 = new Pen(SystemColors.ControlLightLight, 1f);
				}
				else
				{
					pen = Pens.Black;
					pen2 = Pens.Black;
				}
				Rectangle clientRectangle = base.ClientRectangle;
				Point pt = new Point(clientRectangle.Left, clientRectangle.Top);
				Point pt2 = new Point(clientRectangle.Width - num, clientRectangle.Top);
				A_0.DrawLine(pen, pt, pt2);
				pt2 = new Point(clientRectangle.Left, clientRectangle.Top);
				pt = new Point(clientRectangle.Left, clientRectangle.Height - num);
				A_0.DrawLine(pen, pt2, pt);
				pt2 = new Point(clientRectangle.Left, clientRectangle.Height - num);
				pt = new Point(clientRectangle.Width - num, clientRectangle.Height - num);
				A_0.DrawLine(pen2, pt2, pt);
				pt2 = new Point(clientRectangle.Width - num, clientRectangle.Top);
				pt = new Point(clientRectangle.Width - num, clientRectangle.Height - num);
				A_0.DrawLine(pen2, pt2, pt);
			}
		}

		[DebuggerStepThrough]
		private void a()
		{
			base.Name = "ProgresBarEx";
			Size size = new Size(100, 16);
			base.Size = size;
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			object obj = null;
			decimal value = checked(decimal.Divide(new decimal(ac - z), new decimal(h - z)));
			RectangleF rect = base.ClientRectangle;
			if (k == ColorStyle.Gradient)
			{
				obj = new LinearGradientBrush(rect, i, j, l);
				if (n == SigmaMode.SigmaBell)
				{
					object[] array = new object[2] { m, o };
					bool[] array2 = new bool[2] { true, true };
					NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(obj), null, "SetSigmaBellShape", array, null, null, array2, true);
					if (array2[0])
					{
						m = Conversions.ToSingle(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0])), typeof(float)));
					}
					if (array2[1])
					{
						o = Conversions.ToSingle(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[1])), typeof(float)));
					}
				}
				e.Graphics.FillRectangle((Brush)obj, rect);
			}
			if (f)
			{
				rect.Width *= Convert.ToSingle(value);
				if (g)
				{
					rect.X = Convert.ToSingle(ab) - rect.Width;
				}
			}
			else
			{
				rect.Height *= Convert.ToSingle(value);
				if (!g)
				{
					rect.Y = Convert.ToSingle(y) - rect.Height;
				}
			}
			if (rect.Width > 0f && rect.Height > 0f)
			{
				if (r == ColorStyle.Solid)
				{
					obj = new SolidBrush(p);
				}
				else
				{
					obj = ((t != StretchMode.Normal) ? new LinearGradientBrush(rect, p, q, s) : new LinearGradientBrush(base.ClientRectangle, p, q, s));
					if (v == SigmaMode.SigmaBell)
					{
						object[] array3 = new object[2] { u, w };
						bool[] array2 = new bool[2] { true, true };
						NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(obj), null, "SetSigmaBellShape", array3, null, null, array2, true);
						if (array2[0])
						{
							u = Conversions.ToSingle(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array3[0])), typeof(float)));
						}
						if (array2[1])
						{
							w = Conversions.ToSingle(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array3[1])), typeof(float)));
						}
					}
				}
				e.Graphics.FillRectangle((Brush)obj, rect);
			}
			if (obj != null)
			{
				NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(obj), null, "Dispose", new object[0], null, null, null, true);
			}
			if (BorderStyle != BorderStyle.None)
			{
				a(e.Graphics);
			}
			if (d == TextPercen.Text)
			{
				string text = Conversions.ToString(ac) + "/" + Conversions.ToString(h);
				SizeF sizeF = e.Graphics.MeasureString(text, Font);
				e.Graphics.DrawString(text, Font, new SolidBrush(Color.Black), new PointF((float)base.Width - sizeF.Width - 1f, (float)(base.Height / 2) - sizeF.Height / 2f));
			}
			else if (d == TextPercen.Percen)
			{
				string text2 = Strings.FormatPercent((double)ac / (double)h);
				SizeF sizeF2 = e.Graphics.MeasureString(text2, Font);
				e.Graphics.DrawString(text2, Font, new SolidBrush(Color.Black), new PointF((float)base.Width - sizeF2.Width - 1f, (float)(base.Height / 2) - sizeF2.Height / 2f));
				c.SetToolTip(this, Conversions.ToString(ac) + "/" + Conversions.ToString(h));
			}
			else
			{
				c.SetToolTip(this, Conversions.ToString(ac) + "/" + Conversions.ToString(h));
			}
		}

		protected override void OnResize(EventArgs e)
		{
			ab = new decimal(base.ClientRectangle.Width);
			y = new decimal(base.ClientRectangle.Height);
			Invalidate();
		}

		public void PerformStep()
		{
			checked
			{
				Value += aa;
			}
		}
	}
}
