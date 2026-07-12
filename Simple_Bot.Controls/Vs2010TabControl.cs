using System;
using System.Drawing;
using System.Windows.Forms;
using Simple_Bot.Renderers;

namespace Simple_Bot.Controls
{
	public class Vs2010TabControl : TabControl
	{
		private const int a = 26;

		private int b;

		private Vs2010TabControlRenderer c;

		public Vs2010TabControlRenderer Renderer
		{
			get
			{
				if (c == null)
				{
					c = new Vs2010TabControlRenderer();
				}
				return c;
			}
			set
			{
				c = value;
			}
		}

		public Vs2010TabControl()
		{
			b = -1;
			base.DrawMode = TabDrawMode.OwnerDrawFixed;
			SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			SetStyle(ControlStyles.DoubleBuffer, true);
			SetStyle(ControlStyles.ResizeRedraw, true);
			SetStyle(ControlStyles.UserPaint, true);
			base.ItemSize = new Size(base.ItemSize.Width, 26);
			base.HotTrack = true;
		}

		protected override void OnMouseMove(MouseEventArgs e)
		{
			base.OnMouseMove(e);
			if (!base.HotTrack)
			{
				return;
			}
			checked
			{
				int num = base.TabCount - 1;
				for (int i = 0; i <= num; i++)
				{
					Rectangle tabRect = GetTabRect(i);
					if (i != b && tabRect.Contains(e.Location))
					{
						if (b != -1)
						{
							Invalidate(GetTabRect(b));
						}
						b = i;
						Invalidate(tabRect);
						break;
					}
				}
			}
		}

		protected override void OnMouseLeave(EventArgs e)
		{
			base.OnMouseLeave(e);
			if (base.HotTrack && b != -1)
			{
				Invalidate(GetTabRect(b));
				b = -1;
			}
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			checked
			{
				int num = base.TabPages.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					Rectangle tabRect = GetTabRect(i);
					Vs2010TabControlRenderer.PaintHeaderEventArgs e2 = new Vs2010TabControlRenderer.PaintHeaderEventArgs(clipRect: new Rectangle(tabRect.X + 1, tabRect.Y + 3, tabRect.Width, tabRect.Height - 5), state: (base.SelectedTab != base.TabPages[i]) ? ((i == b) ? Vs2010TabControlRenderer.PaintHeaderEventArgs.TabHeaderState.HotTracking : Vs2010TabControlRenderer.PaintHeaderEventArgs.TabHeaderState.Normal) : Vs2010TabControlRenderer.PaintHeaderEventArgs.TabHeaderState.Active, g: e.Graphics, tabPage: base.TabPages[i]);
					Renderer.OnPaintTabHeader(e2);
				}
				Rectangle clipRect = new Rectangle(4, base.ItemSize.Height, base.Width - 8, 4);
				Rectangle clipRect2 = new Rectangle(4, base.Height - 4, base.Width - 8, 4);
				Vs2010TabControlRenderer.PaintBordersEventArgs e3 = new Vs2010TabControlRenderer.PaintBordersEventArgs(e.Graphics, clipRect, Vs2010TabControlRenderer.PaintBordersEventArgs.BorderSide.Top);
				Renderer.OnPaintBorders(e3);
				e3 = new Vs2010TabControlRenderer.PaintBordersEventArgs(e.Graphics, clipRect2, Vs2010TabControlRenderer.PaintBordersEventArgs.BorderSide.Bottom);
				Renderer.OnPaintBorders(e3);
			}
		}

		protected override void OnPaintBackground(PaintEventArgs pevent)
		{
			base.OnPaintBackground(pevent);
			PaintEventArgs e = new PaintEventArgs(clipRect: new Rectangle(0, 0, base.Width, base.Height), graphics: pevent.Graphics);
			Renderer.OnPaintTabHeadersBackground(e);
		}
	}
}
