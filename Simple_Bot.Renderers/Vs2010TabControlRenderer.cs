using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Simple_Bot.ColorTables;

namespace Simple_Bot.Renderers
{
	public class Vs2010TabControlRenderer
	{
		public class PaintHeaderEventArgs : PaintEventArgs
		{
			public enum TabHeaderState
			{
				Normal,
				HotTracking,
				Active,
				Inactive
			}

			private TabHeaderState a;

			private TabPage b;

			public TabHeaderState State
			{
				get
				{
					return a;
				}
			}

			public TabPage TabPage
			{
				get
				{
					return b;
				}
			}

			public PaintHeaderEventArgs(Graphics g, Rectangle clipRect, TabPage tabPage, TabHeaderState state)
				: base(g, clipRect)
			{
				b = tabPage;
				a = state;
			}
		}

		public class PaintBordersEventArgs : PaintEventArgs
		{
			public enum BorderSide
			{
				Top,
				Bottom
			}

			private BorderSide a;

			public BorderSide Side
			{
				get
				{
					return a;
				}
			}

			public PaintBordersEventArgs(Graphics g, Rectangle clipRect, BorderSide side)
				: base(g, clipRect)
			{
				a = side;
			}
		}

		private Vs2010TabControlColorTable m_a;

		public Vs2010TabControlColorTable ColorTable
		{
			get
			{
				if (this.m_a == null)
				{
					this.m_a = new Vs2010DefaultTabControlColorTable();
				}
				return this.m_a;
			}
			set
			{
				this.m_a = value;
			}
		}

		public Vs2010TabControlRenderer()
			: this(new Vs2010DefaultTabControlColorTable())
		{
		}

		public Vs2010TabControlRenderer(Vs2010TabControlColorTable colorTable)
		{
			ColorTable = colorTable;
		}

		private void a(Graphics A_0, RectangleF A_1)
		{
			float num = 2f;
			using (LinearGradientBrush linearGradientBrush = new LinearGradientBrush(A_1, ColorTable.SelectedHeaderGradientTop, ColorTable.SelectedHeaderGradientMiddle, LinearGradientMode.Vertical))
			{
				ColorBlend colorBlend = new ColorBlend(4);
				colorBlend.Colors = new Color[4] { ColorTable.SelectedHeaderGradientTop, ColorTable.SelectedHeaderGradientMiddle, ColorTable.SelectedHeaderGradientBottom, ColorTable.SelectedHeaderGradientBottom };
				colorBlend.Positions = new float[4] { 0f, 0.5f, 0.5f, 1f };
				linearGradientBrush.InterpolationColors = colorBlend;
				using (GraphicsPath graphicsPath = new GraphicsPath())
				{
					graphicsPath.AddLine(A_1.X + num, A_1.Y, A_1.Right - 2f * num, A_1.Y);
					graphicsPath.AddArc(A_1.Right - 2f * num, A_1.Y, 2f * num, 2f * num, 270f, 90f);
					graphicsPath.AddLine(A_1.Right, A_1.Y + num, A_1.Right, A_1.Bottom);
					graphicsPath.AddLine(A_1.Right, A_1.Bottom, A_1.X, A_1.Bottom);
					graphicsPath.AddLine(A_1.X, A_1.Bottom, A_1.X, A_1.Y);
					graphicsPath.AddArc(A_1.X, A_1.Y, num * 2f, num * 2f, 180f, 90f);
					graphicsPath.CloseFigure();
					A_0.SmoothingMode = SmoothingMode.HighQuality;
					A_0.FillPath(linearGradientBrush, graphicsPath);
					A_0.SmoothingMode = SmoothingMode.Default;
				}
			}
		}

		private void a(Graphics A_0, Rectangle A_1)
		{
			checked
			{
				A_1 = new Rectangle(A_1.X, A_1.Y + 1, A_1.Width - 2, A_1.Height + 1);
				Rectangle rect = new Rectangle(A_1.X + 1, A_1.Y, A_1.Width - 1, A_1.Height - 3);
				using (LinearGradientBrush brush = new LinearGradientBrush(rect, ColorTable.HoveringHeaderGradientTop, ColorTable.HoveringHeaderGradientBottom, LinearGradientMode.Vertical))
				{
					A_0.FillRectangle(brush, rect);
				}
				using (Pen p = new Pen(ColorTable.HoveringHeaderBorder))
				{
					CommonDrawing.DrawRoundedRectangle(A_0, p, A_1.X, A_1.Y, A_1.Width, A_1.Height, 2f);
				}
			}
		}

		public virtual void OnPaintTabHeader(PaintHeaderEventArgs e)
		{
			Color color;
			if (e.State == PaintHeaderEventArgs.TabHeaderState.Active)
			{
				a(e.Graphics, (RectangleF)e.ClipRectangle);
				color = Color.Black;
			}
			else if (e.State == PaintHeaderEventArgs.TabHeaderState.HotTracking)
			{
				a(e.Graphics, e.ClipRectangle);
				color = Color.White;
			}
			else
			{
				color = Color.White;
			}
			StringFormat stringFormat = new StringFormat();
			stringFormat.Alignment = StringAlignment.Center;
			stringFormat.LineAlignment = StringAlignment.Center;
			e.Graphics.DrawString(e.TabPage.Text, e.TabPage.Font, new SolidBrush(color), e.ClipRectangle, stringFormat);
		}

		public virtual void OnPaintTabHeadersBackground(PaintEventArgs e)
		{
			using (SolidBrush brush = new SolidBrush(ColorTable.Background))
			{
				e.Graphics.FillRectangle(brush, e.ClipRectangle);
			}
		}

		public virtual void OnPaintBorders(PaintBordersEventArgs e)
		{
			using (SolidBrush brush = new SolidBrush(ColorTable.Border))
			{
				if (e.Side == PaintBordersEventArgs.BorderSide.Top)
				{
					e.Graphics.FillRectangle(brush, e.ClipRectangle);
				}
			}
		}
	}
}
