using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Simple_Bot
{
	public partial class frmClient : Form
	{
		private void Label_Tuideo_MouseDoubleClick_Unequip(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				int key = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Tag", new object[0], null, null, null));
				if (_bot.Data_Tuideo[key]._Id > 0)
				{
					_bot.SendPacket(API.hexstringtobyte("F44403001725" + key.ToString("X2")));
				}
			}
		}

		private void Label_Tuideo_MouseDown_Select(object sender, MouseEventArgs e)
		{
			if (Conversions.ToBoolean(Operators.AndObject(e.Button == MouseButtons.Right, Operators.CompareObjectNotEqual(NewLateBinding.LateGet(sender, null, "Text", new object[0], null, null, null), "", false))))
			{
				label_selected.BackColor = Color.Transparent;
				label_selected.ForeColor = Color.Black;
				label_selected = (Label)sender;
				NewLateBinding.LateSet(sender, null, "ForeColor", new object[1] { Color.Red }, null, null);
				NewLateBinding.LateSet(sender, null, "BackColor", new object[1] { Color.FromArgb(169, 251, 170) }, null, null);
				_Tuideo_slot_select = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Tag", new object[0], null, null, null));
			}
			else
			{
				label_selected.ForeColor = Color.Black;
				label_selected.BackColor = Color.Transparent;
				label_selected = new Label();
				_Tuideo_slot_select = 0;
				_Homdo_slot_select = 0;
			}
		}

		private void Label_Tuideo_MouseMove(object sender, MouseEventArgs e)
		{
		}

		private void Label_Tuido_MouseClick(object sender, MouseEventArgs e)
		{
			switch (e.Button)
			{
			}
		}

		private void Label_Tuido_MouseDown_SelectOrDrag(object sender, MouseEventArgs e)
		{
			if (Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(sender, null, "Text", new object[0], null, null, null), "", false))
			{
				switch (e.Button)
				{
				case MouseButtons.Left:
				{
					label_selected.ForeColor = Color.Black;
					label_selected.BackColor = Color.Transparent;
					label_selected = (Label)sender;
					NewLateBinding.LateSet(sender, null, "ForeColor", new object[1] { Color.Red }, null, null);
					NewLateBinding.LateSet(sender, null, "BackColor", new object[1] { Color.FromArgb(169, 251, 170) }, null, null);
					int key = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Tag", new object[0], null, null, null));
					if (_bot.Data_Tuido[key]._Id > 0)
					{
						DataObject dataObject = new DataObject();
						dataObject.SetImage((Image)NewLateBinding.LateGet(NewLateBinding.LateGet(sender, null, "Image", new object[0], null, null, null), null, "Clone", new object[0], null, null, null));
						_draggedTuidoLabel = (Label)sender;
						object[] obj = new object[2]
						{
							dataObject,
							DragDropEffects.Copy
						};
						object[] array = obj;
						bool[] obj2 = new bool[2] { true, false };
						bool[] array2 = obj2;
						NewLateBinding.LateCall(sender, null, "DoDragDrop", obj, null, null, obj2, true);
						if (array2[0])
						{
							dataObject = (DataObject)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(DataObject));
						}
					}
					break;
				}
				case MouseButtons.Right:
					label_selected.ForeColor = Color.Black;
					label_selected.BackColor = Color.Transparent;
					label_selected = (Label)sender;
					NewLateBinding.LateSet(sender, null, "ForeColor", new object[1] { Color.Red }, null, null);
					NewLateBinding.LateSet(sender, null, "BackColor", new object[1] { Color.FromArgb(169, 251, 170) }, null, null);
					_Homdo_slot_select = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Tag", new object[0], null, null, null));
					break;
				}
			}
			else
			{
				label_selected.ForeColor = Color.Black;
				label_selected.BackColor = Color.Transparent;
				label_selected = new Label();
				_Tuideo_slot_select = 0;
				_Homdo_slot_select = 0;
			}
		}

		private void Label_Tuido_GiveFeedback_DragCursor(object sender, GiveFeedbackEventArgs e)
		{
			e.UseDefaultCursors = false;
			Bitmap bitmap = (Bitmap)_draggedTuidoLabel.Image;
			IntPtr hicon = bitmap.GetHicon();
			Cursor current = new Cursor(hicon);
			Cursor.Current = current;
		}

		private void Label_Item_MouseUp_ResetCursor(object sender, MouseEventArgs e)
		{
			Cursor.Current = DefaultCursor;
			switch (e.Button)
			{
			case MouseButtons.Left:
				label_selected.BackColor = Color.Transparent;
				break;
			}
		}

		public void Label_MouseLeave(object sender, EventArgs e)
		{
		}

		private void Label_Tuido_MouseMove(object sender, MouseEventArgs e)
		{
		}

		private void Label_Tuido_DragDrop_MoveItem(object sender, DragEventArgs e)
		{
			int num = Conversions.ToInteger(_draggedTuidoLabel.Tag);
			int num2 = 1;
			int num3 = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Tag", new object[0], null, null, null));
			try
			{
				if (_bot.Data_Tuido[num]._Sl > 1)
				{
					try
					{
						num2 = Conversions.ToInteger(Interaction.InputBox("Nhập số lượng."));
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ProjectData.ClearProjectError();
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			if (Operators.ConditionalCompareObjectLess(_bot.get_DataTuido(num, _Data.Type_Tui._Sl), num2, false))
			{
				num2 = Conversions.ToInteger(_bot.get_DataTuido(num, _Data.Type_Tui._Sl));
			}
			if (Operators.ConditionalCompareObjectGreaterEqual(Operators.AddObject(num2, _bot.get_DataTuido(num3, _Data.Type_Tui._Sl)), 50, false))
			{
				num2 = Conversions.ToInteger(Operators.SubtractObject(50, _bot.get_DataTuido(num3, _Data.Type_Tui._Sl)));
			}
			_bot.Moveitem(num, num2, num3);
			_draggedTuidoLabel.BackColor = Color.Transparent;
			NewLateBinding.LateSet(sender, null, "BackColor", new object[1] { Color.Transparent }, null, null);
			Cursor.Current = DefaultCursor;
		}

		private void Label_Tuido_DragEnter_AllowCopy(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.Copy;
		}

	}
}
