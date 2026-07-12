using System;
using System.Collections;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Simple_Bot
{
	public class clsListviewSorter : IComparer
	{
		private int a;

		private SortOrder b;

		public clsListviewSorter(int column_number, SortOrder sort_order)
		{
			a = column_number;
			b = sort_order;
		}

		public int Compare(object x, object y)
		{
			ListViewItem listViewItem = (ListViewItem)x;
			ListViewItem listViewItem2 = (ListViewItem)y;
			string text = ((listViewItem.SubItems.Count > a) ? listViewItem.SubItems[a].Text : "");
			string text2 = ((listViewItem2.SubItems.Count > a) ? listViewItem2.SubItems[a].Text : "");
			if (b == SortOrder.Ascending)
			{
				if (Versioned.IsNumeric(text) & Versioned.IsNumeric(text2))
				{
					return Conversion.Val(text).CompareTo(Conversion.Val(text2));
				}
				if (Information.IsDate(text) & Information.IsDate(text2))
				{
					return DateTime.Parse(text).CompareTo(DateTime.Parse(text2));
				}
				return string.Compare(text, text2);
			}
			if (Versioned.IsNumeric(text) & Versioned.IsNumeric(text2))
			{
				return Conversion.Val(text2).CompareTo(Conversion.Val(text));
			}
			if (Information.IsDate(text) & Information.IsDate(text2))
			{
				return DateTime.Parse(text2).CompareTo(DateTime.Parse(text));
			}
			return string.Compare(text2, text);
		}

		int IComparer.Compare(object x, object y)
		{
			//ILSpy generated this explicit interface implementation from .override directive in Compare
			return this.Compare(x, y);
		}
	}
}
