using System.Windows.Forms;
using Simple_Bot.Renderers;

namespace Simple_Bot.Controls
{
	public class Vs2010MenuStrip : MenuStrip
	{
		public new Vs2010MenuStripRenderer Renderer
		{
			get
			{
				return (Vs2010MenuStripRenderer)base.Renderer;
			}
			set
			{
				base.Renderer = value;
			}
		}

		public Vs2010MenuStrip()
		{
			Renderer = new Vs2010MenuStripRenderer();
		}
	}
}
