using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using Simple_Bot.ColorTables;

namespace Simple_Bot.Renderers
{
	public class CommonDrawing
	{
		public static void DrawSelection(Graphics g, Vs2010CommonColorTable colorTable, Rectangle rect, bool rounded)
		{
			DrawSelection(g, colorTable.SelectedGradientTop, colorTable.SelectedGradientMiddle, colorTable.SelectedGradientBottom, colorTable.SelectedBorder, rect, rounded);
		}

		public static void DrawSelection(Graphics g, Color gradientTop, Color gradientBottom, Color bottom, Color border, Rectangle rect, bool rounded)
		{
			checked
			{
				Rectangle rect2;
				Rectangle rect3;
				if (rounded)
				{
					Rectangle rectangle = new Rectangle(rect.X + 1, rect.Y + 1, rect.Width - 1, rect.Height - 1);
					rect2 = rectangle;
					rect2.Height -= (int)Math.Round((double)rect2.Height / 2.0);
					rect3 = new Rectangle(rect2.X, rect2.Bottom, rect2.Width, rectangle.Height - rect2.Height);
				}
				else
				{
					rect2 = rect;
					rect2.Height -= (int)Math.Round((double)rect2.Height / 2.0);
					rect3 = new Rectangle(rect2.X, rect2.Bottom, rect2.Width, rect.Height - rect2.Height);
				}
				using (LinearGradientBrush brush = new LinearGradientBrush(rect2, gradientTop, gradientBottom, LinearGradientMode.Vertical))
				{
					g.FillRectangle(brush, rect2);
				}
				using (SolidBrush brush2 = new SolidBrush(bottom))
				{
					g.FillRectangle(brush2, rect3);
				}
				using (Pen pen = new Pen(border))
				{
					if (rounded)
					{
						DrawRoundedRectangle(g, pen, rect.X, rect.Y, rect.Width, rect.Height, 2f);
					}
					else
					{
						g.DrawRectangle(pen, rect);
					}
				}
			}
		}

		public static void DrawRoundedRectangle(Graphics g, Pen p, float x, float y, float width, float height, float radius)
		{
			using (GraphicsPath graphicsPath = new GraphicsPath())
			{
				graphicsPath.AddLine(x + radius, y, x + width - radius * 2f, y);
				graphicsPath.AddArc(x + width - radius * 2f, y, radius * 2f, radius * 2f, 270f, 90f);
				graphicsPath.AddLine(x + width, y + radius, x + width, y + height - radius * 2f);
				graphicsPath.AddArc(x + width - radius * 2f, y + height - radius * 2f, radius * 2f, radius * 2f, 0f, 90f);
				graphicsPath.AddLine(x + width - radius * 2f, y + height, x + radius, y + height);
				graphicsPath.AddArc(x, y + height - radius * 2f, radius * 2f, radius * 2f, 90f, 90f);
				graphicsPath.AddLine(x, y + height - radius * 2f, x, y + radius);
				graphicsPath.AddArc(x, y, radius * 2f, radius * 2f, 180f, 90f);
				graphicsPath.CloseFigure();
				g.SmoothingMode = SmoothingMode.AntiAlias;
				g.DrawPath(p, graphicsPath);
				g.SmoothingMode = SmoothingMode.Default;
			}
		}

		public static void FillRoundedRectangle(Graphics g, Brush b, float x, float y, float width, float height, float radius)
		{
			using (GraphicsPath graphicsPath = new GraphicsPath())
			{
				graphicsPath.AddLine(x + radius, y, x + width - radius * 2f, y);
				graphicsPath.AddArc(x + width - radius * 2f, y, radius * 2f, radius * 2f, 270f, 90f);
				graphicsPath.AddLine(x + width, y + radius, x + width, y + height - radius * 2f);
				graphicsPath.AddArc(x + width - radius * 2f, y + height - radius * 2f, radius * 2f, radius * 2f, 0f, 90f);
				graphicsPath.AddLine(x + width - radius * 2f, y + height, x + radius, y + height);
				graphicsPath.AddArc(x, y + height - radius * 2f, radius * 2f, radius * 2f, 90f, 90f);
				graphicsPath.AddLine(x, y + height - radius * 2f, x, y + radius);
				graphicsPath.AddArc(x, y, radius * 2f, radius * 2f, 180f, 90f);
				graphicsPath.CloseFigure();
				g.SmoothingMode = SmoothingMode.AntiAlias;
				g.FillPath(b, graphicsPath);
				g.SmoothingMode = SmoothingMode.Default;
			}
		}
	}
}
