using System.Drawing;

namespace Simple_Bot.ColorTables
{
	public class Vs2010DefaultTabControlColorTable : Vs2010TabControlColorTable
	{
		public override Color Background
		{
			get
			{
				return Color.FromArgb(53, 73, 106);
			}
		}

		public override Color Border
		{
			get
			{
				return Color.FromArgb(255, 236, 181);
			}
		}

		public override Color HoveringHeaderGradientBottom
		{
			get
			{
				return Color.FromArgb(53, 73, 106);
			}
		}

		public override Color HoveringHeaderGradientTop
		{
			get
			{
				return Color.FromArgb(111, 119, 118);
			}
		}

		public override Color SelectedHeaderGradientBottom
		{
			get
			{
				return Color.FromArgb(255, 236, 181);
			}
		}

		public override Color SelectedHeaderGradientMiddle
		{
			get
			{
				return Color.FromArgb(255, 244, 208);
			}
		}

		public override Color SelectedHeaderGradientTop
		{
			get
			{
				return Color.FromArgb(255, 252, 242);
			}
		}

		public override Color HoveringHeaderBorder
		{
			get
			{
				return Color.FromArgb(155, 167, 183);
			}
		}
	}
}
