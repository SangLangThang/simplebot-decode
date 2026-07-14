using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Simple_Bot
{
	public partial class frmClient : Form
	{
		private void Button_warp2_Click(object sender, EventArgs e)
		{
			if (_bot != null && _bot.logined == 1)
			{
				_bot.atw = 1;
				_bot.AutoWarptoMap = TextBox_idWarp2.Text;
				CheckBox_QuestProtect.Checked = false;
				_bot.ClickNPCId(99);
				_bot.AutoWarp(_bot.AutoWarptoMap);
			}
		}


		private void Button_walk_Click(object sender, EventArgs e)
		{
			if ((Conversions.ToInteger(TextBox_walkX.Text) > 0) & (Conversions.ToInteger(TextBox_walkY.Text) > 0))
			{
				_bot.Walk(Conversions.ToInteger(TextBox_walkX.Text), Conversions.ToInteger(TextBox_walkY.Text));
			}
			try
			{
				Bitmap bmp = (Bitmap)_map.Clone();
				int num = _bot.Data_Player._MapX / 20;
				int num2 = _bot.Data_Player._MapY / 20;
				bmp = API.ResizeImage(bmp, num, num2, Color.Red);
				PictureBox1.Width = bmp.Width;
				PictureBox1.Height = bmp.Height;
				PictureBox1.Image = bmp;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

		private void Button_warp_Click(object sender, EventArgs e)
		{
			if (_bot != null && _bot.logined == 1)
			{
				_bot.atw = 1;
				_bot.AutoWarptoMap = TextBox_idWarp.Text;
				CheckBox_QuestProtect.Checked = false;
				_bot.ClickNPCId(99);
				_bot.AutoWarp(_bot.AutoWarptoMap);
			}
		}

		private void TreeView1_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				TreeNode nodeAt = TreeView1.GetNodeAt(e.X, e.Y);
				if (nodeAt != null)
				{
					TreeView1.SelectedNode = nodeAt;
				}
			}
		}

		private void Button_WarpFromTree_Click(object sender, EventArgs e)
		{
			if (_bot != null && _bot.logined == 1)
			{
				_bot.atw = 1;
				TextBox_idWarp.Text = TreeView1.SelectedNode.Name;
				TextBox_idWarp.Text = TreeView1.SelectedNode.Name;
				_bot.AutoWarptoMap = TextBox_idWarp.Text;
				CheckBox_QuestProtect.Checked = false;
				_bot.AutoWarp(_bot.AutoWarptoMap);
			}
		}


		private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				try
				{
					Bitmap bmp;
					checked
					{
						if ((e.X > 0) & (e.Y > 0))
						{
							_bot.Walk((int)Math.Round((double)e.X * 6.666666), (int)Math.Round((double)e.Y * 6.6666666));
						}
						bmp = (Bitmap)_map.Clone();
					}
					int num = _bot.Data_Player._MapX / 20;
					int num2 = _bot.Data_Player._MapY / 20;
					bmp = API.ResizeImage(bmp, num, num2, Color.Red);
					PictureBox1.Width = bmp.Width;
					PictureBox1.Height = bmp.Height;
					PictureBox1.Image = bmp;
					return;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
					return;
				}
			}
			if (e.Button != MouseButtons.Right)
			{
			}
		}

		private void ComboBox_Mini_Warp_Populate(object sender, EventArgs e)
		{
			if (_bot == null || _bot.logined != 1)
			{
				return;
			}
			if (ComboBox_Mini_Warp.Items.Count > 0)
			{
				ComboBox_Mini_Warp.Items.Clear();
			}
			if (_bot.listquest_Done.Count <= 0)
			{
				return;
			}
			checked
			{
				int num = _bot.listquest_Done.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					int key = Conversions.ToInteger(_bot.listquest_Done[i]);
					if (Ground.Data_Warps_QuestID.ContainsKey(key))
					{
						int key2 = Ground.Data_Warps_QuestID[key];
						if (Ground.Data_Warps.ContainsKey(key2))
						{
							int num2 = Ground.Data_Warps[key2];
							ComboBox_Mini_Warp.Items.Add(Conversions.ToString(num2) + "  " + MapNames.Data_MapNames[num2]);
						}
					}
				}
			}
		}

		private void ComboBox_Mini_Warp_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (_bot == null || _bot.logined != 1)
			{
				return;
			}
			try
			{
				string[] array = (string[])NewLateBinding.LateGet(ComboBox_Mini_Warp.SelectedItem, null, "Split", new object[1] { "  " }, null, null, null);
				int num = Conversions.ToInteger(array[0]);
				if (Ground.Data_Warps_MapID.ContainsKey(num))
				{
					int num2 = Ground.Data_Warps_MapID[num];
					string packet = "4401" + API.Int32ToHex2(num) + num2.ToString("X2");
					_bot.SendPacket(API.hexstringtobyte(API.Packet_Maker(packet)));
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

	}
}
