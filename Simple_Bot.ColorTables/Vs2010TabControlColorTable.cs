using System.Drawing;

namespace Simple_Bot.ColorTables
{
	public abstract class Vs2010TabControlColorTable
	{
		public abstract Color Background { get; }

		public abstract Color SelectedHeaderGradientTop { get; }

		public abstract Color SelectedHeaderGradientBottom { get; }

		public abstract Color SelectedHeaderGradientMiddle { get; }

		public abstract Color HoveringHeaderGradientTop { get; }

		public abstract Color HoveringHeaderGradientBottom { get; }

		public abstract Color HoveringHeaderBorder { get; }

		public abstract Color Border { get; }
	}
}
