namespace Simple_Bot
{
	public class ComboBoxItem
	{
		public string Text;

		public int Value;

		public bool Selectable;

		public string ImageKey;

		public ComboBoxItem()
		{
			Selectable = true;
			ImageKey = "";
		}

		public override string ToString()
		{
			return Text;
		}
	}
}
