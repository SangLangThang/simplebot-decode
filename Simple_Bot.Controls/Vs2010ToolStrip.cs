using System;
using System.Windows.Forms;
using Simple_Bot.Renderers;

namespace Simple_Bot.Controls
{
	public class Vs2010ToolStrip : ToolStrip
	{
		private bool m_a;

		public bool AutoParentBackColor
		{
			get
			{
				return this.m_a;
			}
			set
			{
				this.m_a = value;
			}
		}

		public new Vs2010ToolStripRenderer Renderer
		{
			get
			{
				return (Vs2010ToolStripRenderer)base.Renderer;
			}
			set
			{
				base.Renderer = value;
				a();
			}
		}

		public Vs2010ToolStrip()
		{
			Renderer = new Vs2010ToolStripRenderer();
			base.BackColor = Renderer.ColorTable.ParentBackground;
		}

		protected override void OnParentChanged(EventArgs e)
		{
			base.OnParentChanged(e);
			a();
		}

		private void a()
		{
			if (base.Parent != null && base.Parent is ToolStripPanel)
			{
				if (AutoParentBackColor)
				{
					base.Parent.BackColor = Renderer.ColorTable.ParentBackground;
				}
				else
				{
					base.Parent.BackColor = Control.DefaultBackColor;
				}
				base.Parent.Invalidate();
			}
		}
	}
}
