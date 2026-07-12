using System.Drawing;

namespace Simple_Bot.ColorTables
{
	public abstract class Vs2010ToolStripColorTable
	{
		public abstract Vs2010CommonColorTable CommonColorTable { get; }

		public abstract Color Background { get; }

		public abstract Color Border { get; }

		public abstract Color ParentBackground { get; }

		public abstract Color Grip { get; }

		public abstract Color Separator { get; }

		public abstract Color OverflowBackground { get; }
	}
}
