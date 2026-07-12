using System;
using System.Drawing;
using System.Windows.Forms;
using Simple_Bot.ColorTables;

namespace Simple_Bot.Renderers
{
	public class Vs2010ToolStripRenderer : Vs2010MenuStripRenderer
	{
		private Vs2010ToolStripColorTable m_a;

		public new Vs2010ToolStripColorTable ColorTable
		{
			get
			{
				if (this.m_a == null)
				{
					this.m_a = new Vs2010DefaultToolStripColorTable();
				}
				return this.m_a;
			}
			set
			{
				this.m_a = value;
			}
		}

		public Vs2010ToolStripRenderer()
			: this(new Vs2010DefaultToolStripColorTable())
		{
		}

		public Vs2010ToolStripRenderer(Vs2010ToolStripColorTable colorTable)
		{
			ColorTable = colorTable;
		}

		protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
		{
			base.OnRenderToolStripBackground(e);
			Rectangle rect = checked(new Rectangle(e.AffectedBounds.X, e.AffectedBounds.Y + 1, e.AffectedBounds.Width, e.AffectedBounds.Height - 3));
			using (SolidBrush brush = new SolidBrush(ColorTable.Background))
			{
				e.Graphics.FillRectangle(brush, rect);
			}
		}

		protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
		{
			if (e.ToolStrip.Parent != null)
			{
				Rectangle rectangle = new Rectangle(e.AffectedBounds.X, e.AffectedBounds.Y, e.AffectedBounds.Width, checked(e.AffectedBounds.Height - 2));
				using (Pen p = new Pen(ColorTable.Border))
				{
					CommonDrawing.DrawRoundedRectangle(e.Graphics, p, rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height, 2f);
					return;
				}
			}
			base.OnRenderToolStripBorder(e);
			using (Pen pen = new Pen(ColorTable.CommonColorTable.DropdownBorder))
			{
				e.Graphics.DrawLine(pen, e.AffectedBounds.X, e.AffectedBounds.Y, e.AffectedBounds.Right, e.AffectedBounds.Y);
			}
		}

		protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
		{
			e.TextColor = ColorTable.CommonColorTable.TextColor;
			base.OnRenderItemText(e);
		}

		protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
		{
			Rectangle rect = checked(new Rectangle(0, 0, e.Item.Width - 1, e.Item.Height - 1));
			bool flag = ((ToolStripButton)e.Item).Checked;
			bool flag2 = false;
			if (flag)
			{
				flag2 = true;
				if (e.Item.Selected && !e.Item.Pressed)
				{
					using (SolidBrush brush = new SolidBrush(ColorTable.CommonColorTable.CheckedSelectedBackground))
					{
						e.Graphics.FillRectangle(brush, rect);
					}
				}
				else
				{
					using (SolidBrush brush2 = new SolidBrush(ColorTable.CommonColorTable.CheckedBackground))
					{
						e.Graphics.FillRectangle(brush2, rect);
					}
				}
			}
			else if (e.Item.Pressed)
			{
				flag2 = true;
				using (SolidBrush brush3 = new SolidBrush(ColorTable.CommonColorTable.PressedBackground))
				{
					e.Graphics.FillRectangle(brush3, rect);
				}
			}
			else if (e.Item.Selected)
			{
				flag2 = true;
				CommonDrawing.DrawSelection(e.Graphics, ColorTable.CommonColorTable, rect, false);
			}
			if (flag2)
			{
				using (Pen pen = new Pen(ColorTable.CommonColorTable.SelectedBorder))
				{
					e.Graphics.DrawRectangle(pen, rect);
				}
			}
		}

		protected override void OnRenderDropDownButtonBackground(ToolStripItemRenderEventArgs e)
		{
			Rectangle rect = checked(new Rectangle(0, 0, e.Item.Width - 1, e.Item.Height - 1));
			bool flag = false;
			if (e.Item.Pressed)
			{
				flag = true;
				using (SolidBrush brush = new SolidBrush(ColorTable.CommonColorTable.PressedBackground))
				{
					e.Graphics.FillRectangle(brush, rect);
				}
			}
			else if (e.Item.Selected)
			{
				flag = true;
				CommonDrawing.DrawSelection(e.Graphics, ColorTable.CommonColorTable, rect, false);
			}
			if (flag)
			{
				using (Pen pen = new Pen(ColorTable.CommonColorTable.SelectedBorder))
				{
					e.Graphics.DrawRectangle(pen, rect);
				}
			}
		}

		protected override void OnRenderSplitButtonBackground(ToolStripItemRenderEventArgs e)
		{
			base.OnRenderSplitButtonBackground(e);
			bool flag = false;
			bool flag2 = true;
			ToolStripSplitButton toolStripSplitButton = (ToolStripSplitButton)e.Item;
			checked
			{
				Rectangle rect = new Rectangle(0, 0, toolStripSplitButton.ButtonBounds.Width - 1, toolStripSplitButton.ButtonBounds.Height - 1);
				Rectangle rect2 = new Rectangle(0, 0, toolStripSplitButton.Bounds.Width - 1, toolStripSplitButton.Bounds.Height - 1);
				if (toolStripSplitButton.DropDownButtonPressed)
				{
					flag = true;
					flag2 = false;
					using (SolidBrush brush = new SolidBrush(ColorTable.CommonColorTable.PressedBackground))
					{
						e.Graphics.FillRectangle(brush, rect2);
					}
				}
				else if (toolStripSplitButton.DropDownButtonSelected)
				{
					flag = true;
					CommonDrawing.DrawSelection(e.Graphics, ColorTable.CommonColorTable, rect2, false);
				}
				if (toolStripSplitButton.ButtonPressed)
				{
					using (SolidBrush brush2 = new SolidBrush(ColorTable.CommonColorTable.PressedBackground))
					{
						e.Graphics.FillRectangle(brush2, rect);
					}
				}
				if (!flag)
				{
					return;
				}
				using (Pen pen = new Pen(ColorTable.CommonColorTable.SelectedBorder))
				{
					e.Graphics.DrawRectangle(pen, rect2);
					if (flag2)
					{
						e.Graphics.DrawRectangle(pen, rect);
					}
				}
				a(e.Graphics, toolStripSplitButton);
			}
		}

		private void a(Graphics A_0, ToolStripSplitButton A_1)
		{
			checked
			{
				int num = A_1.DropDownButtonBounds.Width - 1;
				int num2 = A_1.DropDownButtonBounds.Height - 1;
				float num3 = (float)num / 2f + 1f;
				float x = (float)A_1.DropDownButtonBounds.Left + ((float)num - num3) / 2f;
				float num4 = num3 / 2f;
				float y = (float)A_1.DropDownButtonBounds.Top + ((float)num2 - num4) / 2f + 1f;
				RectangleF value = new RectangleF(x, y, num3, num4);
				a(A_0, A_1, Rectangle.Round(value));
			}
		}

		private void a(Graphics A_0, ToolStripItem A_1, Rectangle A_2)
		{
			ToolStripArrowRenderEventArgs e = new ToolStripArrowRenderEventArgs(A_0, A_1, A_2, ColorTable.CommonColorTable.Arrow, ArrowDirection.Down);
			OnRenderArrow(e);
		}

		protected override void OnRenderOverflowButtonBackground(ToolStripItemRenderEventArgs e)
		{
			checked
			{
				Rectangle rect = new Rectangle(0, 0, e.Item.Width - 1, e.Item.Height - 2);
				Rectangle rectangle = new Rectangle(rect.X - 5, rect.Y, rect.Width - 5, rect.Height);
				if (e.Item.Pressed)
				{
					using (SolidBrush brush = new SolidBrush(ColorTable.CommonColorTable.PressedBackground))
					{
						e.Graphics.FillRectangle(brush, rect);
					}
				}
				else if (e.Item.Selected)
				{
					CommonDrawing.DrawSelection(e.Graphics, ColorTable.CommonColorTable, rect, false);
				}
				else
				{
					using (SolidBrush brush2 = new SolidBrush(ColorTable.OverflowBackground))
					{
						e.Graphics.FillRectangle(brush2, rect);
					}
				}
				using (SolidBrush b = new SolidBrush(ColorTable.Background))
				{
					CommonDrawing.FillRoundedRectangle(e.Graphics, b, rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height, 3f);
				}
				int num = rect.Width - 1;
				int num2 = rect.Height - 1;
				float num3 = (float)num / 2f + 1f;
				float num4 = (float)rect.Left + ((float)num - num3) / 2f + 3f;
				float num5 = num3 / 2f;
				float num6 = (float)rect.Top + ((float)num2 - num5) / 2f + 7f;
				a(A_2: Rectangle.Round(new RectangleF(num4, num6, num3, num5)), A_0: e.Graphics, A_1: e.Item);
				using (Pen pen = new Pen(ColorTable.CommonColorTable.Arrow))
				{
					e.Graphics.DrawLine(pen, num4 + 2f, num6 - 2f, num4 + num3 - 2f, num6 - 2f);
				}
			}
		}

		protected override void OnRenderGrip(ToolStripGripRenderEventArgs e)
		{
			if (e.GripDisplayStyle != ToolStripGripDisplayStyle.Vertical)
			{
				return;
			}
			checked
			{
				int num = e.GripBounds.Height - 3;
				float num2 = 0.6363636f;
				int num3 = (int)Math.Round((float)num * num2);
				int num4 = (int)Math.Round((float)num3 / 7f);
				int y = (int)Math.Round((float)(num - num3) / 2f) + 1;
				using (SolidBrush brush = new SolidBrush(ColorTable.Grip))
				{
					Rectangle rect = new Rectangle(e.GripBounds.X, y, num4, num4);
					int num5 = 0;
					do
					{
						e.Graphics.FillRectangle(brush, rect);
						rect.Offset(0, 2 * num4);
						num5++;
					}
					while (num5 <= 3);
				}
			}
		}

		protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e)
		{
			Rectangle rect = new Rectangle(3, 3, 1, checked(e.Item.Height - 6));
			using (SolidBrush brush = new SolidBrush(ColorTable.Separator))
			{
				e.Graphics.FillRectangle(brush, rect);
			}
		}
	}
}
