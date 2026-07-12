using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Simple_Bot.ColorTables;

namespace Simple_Bot.Renderers
{
	public class Vs2010MenuStripRenderer : ToolStripProfessionalRenderer
	{
		private Vs2010MenuStripColorTable a;

		public new Vs2010MenuStripColorTable ColorTable
		{
			get
			{
				if (a == null)
				{
					a = new Vs2010DefaultMenuStripColorTable();
				}
				return a;
			}
			set
			{
				a = value;
			}
		}

		public Vs2010MenuStripRenderer()
			: this(new Vs2010DefaultMenuStripColorTable())
		{
		}

		public Vs2010MenuStripRenderer(Vs2010MenuStripColorTable colorTable)
		{
			ColorTable = colorTable;
		}

		protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
		{
			base.OnRenderToolStripBackground(e);
			using (LinearGradientBrush brush = new LinearGradientBrush(e.AffectedBounds, ColorTable.BackgroundGradientTop, ColorTable.BackgroundGradientBottom, LinearGradientMode.Vertical))
			{
				e.Graphics.FillRectangle(brush, e.AffectedBounds);
			}
		}

		protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
		{
			checked
			{
				if (e.ToolStrip.Parent == null)
				{
					Rectangle rect = new Rectangle(0, 0, e.ToolStrip.Width - 1, e.ToolStrip.Height - 1);
					using (Pen pen = new Pen(ColorTable.CommonColorTable.DropdownBorder))
					{
						e.Graphics.DrawRectangle(pen, rect);
					}
					using (SolidBrush brush = new SolidBrush(ColorTable.DroppedDownItemBackground))
					{
						e.Graphics.FillRectangle(brush, e.ConnectedArea);
						return;
					}
				}
				using (Pen pen2 = new Pen(ColorTable.BottomBorder))
				{
					e.Graphics.DrawLine(pen2, e.AffectedBounds.X, e.AffectedBounds.Bottom - 1, e.AffectedBounds.Right, e.AffectedBounds.Bottom - 1);
				}
			}
		}

		protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
		{
			if (!e.Item.Enabled)
			{
				return;
			}
			checked
			{
				if (e.Item.Selected)
				{
					if (e.Item.IsOnDropDown)
					{
						CommonDrawing.DrawSelection(rect: new Rectangle(2, 0, e.Item.Width - 4, e.Item.Height - 1), g: e.Graphics, colorTable: ColorTable.CommonColorTable, rounded: true);
					}
					else
					{
						CommonDrawing.DrawSelection(rect: new Rectangle(0, 0, e.Item.Width - 1, e.Item.Height - 1), g: e.Graphics, colorTable: ColorTable.CommonColorTable, rounded: true);
					}
				}
				if (((ToolStripMenuItem)e.Item).DropDown.Visible && !e.Item.IsOnDropDown)
				{
					Rectangle rectangle = new Rectangle(0, 0, e.Item.Width - 1, e.Item.Height);
					Rectangle rect = new Rectangle(1, 1, e.Item.Width - 2, e.Item.Height + 2);
					using (SolidBrush brush = new SolidBrush(ColorTable.DroppedDownItemBackground))
					{
						e.Graphics.FillRectangle(brush, rect);
					}
					using (Pen p = new Pen(ColorTable.CommonColorTable.DropdownBorder))
					{
						CommonDrawing.DrawRoundedRectangle(e.Graphics, p, rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height, 2f);
					}
				}
				e.Item.ForeColor = ColorTable.CommonColorTable.TextColor;
			}
		}

		protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
		{
			e.TextColor = ColorTable.CommonColorTable.TextColor;
			base.OnRenderItemText(e);
		}

		protected override void OnRenderItemCheck(ToolStripItemImageRenderEventArgs e)
		{
			base.OnRenderItemCheck(e);
			Rectangle rect = checked(new Rectangle(3, 1, e.Item.Height - 3, e.Item.Height - 3));
			Color color = ((!e.Item.Selected) ? ColorTable.CommonColorTable.CheckedBackground : ColorTable.CommonColorTable.CheckedSelectedBackground);
			using (SolidBrush brush = new SolidBrush(color))
			{
				e.Graphics.FillRectangle(brush, rect);
			}
			using (Pen pen = new Pen(ColorTable.CommonColorTable.SelectedBorder))
			{
				e.Graphics.DrawRectangle(pen, rect);
			}
			e.Graphics.DrawImage(e.Image, new Point(5, 3));
		}

		protected override void OnRenderImageMargin(ToolStripRenderEventArgs e)
		{
			base.OnRenderImageMargin(e);
			Rectangle rect = new Rectangle(0, -1, e.ToolStrip.Width, checked(e.ToolStrip.Height + 1));
			using (LinearGradientBrush brush = new LinearGradientBrush(rect, ColorTable.DropdownGradientTop, ColorTable.DropdownGradientBottom, LinearGradientMode.Vertical))
			{
				e.Graphics.FillRectangle(brush, rect);
			}
			using (SolidBrush brush2 = new SolidBrush(ColorTable.ImageMargin))
			{
				e.Graphics.FillRectangle(brush2, e.AffectedBounds);
			}
		}

		protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e)
		{
			base.OnRenderSeparator(e);
			int x = 28;
			int width = e.Item.Width;
			int num = 3;
			using (Pen pen = new Pen(ColorTable.Separator))
			{
				e.Graphics.DrawLine(pen, x, num, width, num);
			}
		}

		protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e)
		{
			e.ArrowColor = ColorTable.CommonColorTable.Arrow;
			base.OnRenderArrow(e);
		}
	}
}
