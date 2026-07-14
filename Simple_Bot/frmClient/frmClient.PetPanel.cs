using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Simple_Bot
{
	public partial class frmClient : Form
	{
		private void Button_TogglePetBattle_Click(object sender, EventArgs e)
		{
			if (_bot != null)
			{
				if (_petSelect != _bot.PetBattle)
				{
					_bot.SendPacket(API.hexstringtobyte("F44406001301" + API.Int32ToHex2(_bot.Data_PetsInfo[_petSelect]._Id) + "0000"));
				}
				else
				{
					_bot.SendPacket(API.hexstringtobyte("F44402001302"));
				}
			}
		}

		private void PictureBox_MouseMove_ShowCropPreview(object sender, MouseEventArgs e)
		{
			try
			{
				Bitmap bitmap = (Bitmap)NewLateBinding.LateGet(sender, null, "BackgroundImage", new object[0], null, null, null);
				int num = 0;
				int num2 = bitmap.Height / 3;
				int num3 = bitmap.Width;
				int num4 = bitmap.Height / 3;
				Rectangle srcRect = new Rectangle(num, num2, num3, num4);
				Bitmap image = bitmap;
				Bitmap bitmap2 = new Bitmap(srcRect.Width, srcRect.Height);
				using (Graphics graphics = Graphics.FromImage(bitmap2))
				{
					graphics.DrawImage(image, new Rectangle(0, 0, srcRect.Width, srcRect.Height), srcRect, GraphicsUnit.Pixel);
				}
				NewLateBinding.LateSet(sender, null, "Image", new object[1] { bitmap2 }, null, null);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

		private void PictureBox_MouseDown_ShowCropPreview(object sender, MouseEventArgs e)
		{
			try
			{
				Bitmap bitmap = (Bitmap)NewLateBinding.LateGet(sender, null, "BackgroundImage", new object[0], null, null, null);
				int num = 0;
				int num2;
				int num3;
				checked
				{
					num2 = unchecked(bitmap.Height / 3) * 2;
					num3 = bitmap.Width;
				}
				int num4 = bitmap.Height / 3;
				Rectangle srcRect = new Rectangle(num, num2, num3, num4);
				Bitmap image = bitmap;
				Bitmap bitmap2 = new Bitmap(srcRect.Width, srcRect.Height);
				using (Graphics graphics = Graphics.FromImage(bitmap2))
				{
					graphics.DrawImage(image, new Rectangle(0, 0, srcRect.Width, srcRect.Height), srcRect, GraphicsUnit.Pixel);
				}
				NewLateBinding.LateSet(sender, null, "Image", new object[1] { bitmap2 }, null, null);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

		private void PictureBox_MouseLeave_ClearImage(object sender, EventArgs e)
		{
			try
			{
				NewLateBinding.LateSet(sender, null, "Image", new object[1], null, null);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

		private void PictureBox_MouseUp_ClearImage(object sender, MouseEventArgs e)
		{
			try
			{
				NewLateBinding.LateSet(sender, null, "Image", new object[1], null, null);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

		private void Button_PetSelectPrev_Click(object sender, EventArgs e)
		{
			int num = 0;
			int num2;
			do
			{
				num = checked(num + 1);
				switch (_petSelect)
				{
				case 1:
					_petSelect = 4;
					break;
				case 2:
					_petSelect = 1;
					break;
				case 3:
					_petSelect = 2;
					break;
				case 4:
					_petSelect = 3;
					break;
				}
				num2 = Conversions.ToInteger(_bot.get_DataPets(_petSelect, _Data.Type_Pets._Id));
			}
			while (num2 == 0 && num < 5);
		}

		private void Button_PetSelectNext_Click(object sender, EventArgs e)
		{
			int num = 0;
			int num2;
			do
			{
				num = checked(num + 1);
				switch (_petSelect)
				{
				case 1:
					_petSelect = 2;
					break;
				case 2:
					_petSelect = 3;
					break;
				case 3:
					_petSelect = 4;
					break;
				case 4:
					_petSelect = 1;
					break;
				}
				num2 = Conversions.ToInteger(_bot.get_DataPets(_petSelect, _Data.Type_Pets._Id));
			}
			while (num2 == 0 && num < 5);
		}

	}
}
