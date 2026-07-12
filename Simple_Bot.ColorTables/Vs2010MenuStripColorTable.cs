using System.Drawing;

namespace Simple_Bot.ColorTables
{
	public abstract class Vs2010MenuStripColorTable
	{
		public abstract Vs2010CommonColorTable CommonColorTable { get; }

		public abstract Color BottomBorder { get; }

		public abstract Color BackgroundGradientTop { get; }

		public abstract Color BackgroundGradientBottom { get; }

		public abstract Color DroppedDownItemBackground { get; }

		public abstract Color DropdownGradientTop { get; }

		public abstract Color DropdownGradientBottom { get; }

		public abstract Color ImageMargin { get; }

		public abstract Color Separator { get; }
	}
}
