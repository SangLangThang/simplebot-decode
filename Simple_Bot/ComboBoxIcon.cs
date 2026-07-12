using System.Drawing;
using System.Windows.Forms;

namespace Simple_Bot
{
	public class ComboBoxIcon : ComboBox
	{
		private ImageList a;

		private bool b;

		public ImageList ImageList
		{
			get
			{
				return a;
			}
			set
			{
				a = value;
			}
		}

		public ComboBoxIcon()
		{
			a = new ImageList();
			b = false;
			base.DrawMode = DrawMode.OwnerDrawFixed;
		}

		protected override void OnDrawItem(DrawItemEventArgs e)
		{
			e.DrawBackground();
			e.DrawFocusRectangle();
			checked
			{
				if (e.Index < 0)
				{
					e.Graphics.DrawString(Text, e.Font, new SolidBrush(e.ForeColor), e.Bounds.Left + ImageList.ImageSize.Width, e.Bounds.Top);
				}
				else
				{
					ComboBoxItem comboBoxItem = base.Items[e.Index] as ComboBoxItem;
					if (comboBoxItem != null)
					{
						if (comboBoxItem.ImageKey.Length > 0)
						{
							int index = ImageList.Images.IndexOfKey(comboBoxItem.ImageKey);
							ImageList.Draw(e.Graphics, e.Bounds.Left, e.Bounds.Top, index);
						}
						if (!comboBoxItem.Selectable)
						{
							e.Graphics.DrawImage(ImageList.Images[comboBoxItem.ImageKey], e.Bounds.X, e.Bounds.Y, base.ItemHeight, base.ItemHeight);
							e.Graphics.DrawString(comboBoxItem.Text, Font, Brushes.LightSlateGray, e.Bounds.Left + ImageList.ImageSize.Width, e.Bounds.Top);
						}
						else
						{
							e.Graphics.DrawImage(ImageList.Images[comboBoxItem.ImageKey], e.Bounds.X, e.Bounds.Y, base.ItemHeight, base.ItemHeight);
							e.Graphics.DrawString(comboBoxItem.Text, Font, Brushes.Black, e.Bounds.Left + ImageList.ImageSize.Width, e.Bounds.Top);
						}
					}
					else
					{
						e.Graphics.DrawString(base.Items[e.Index].ToString(), Font, new SolidBrush(e.ForeColor), e.Bounds.Left + ImageList.ImageSize.Width, e.Bounds.Top);
					}
				}
				base.OnDrawItem(e);
			}
		}
	}
}
