using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Simple_Bot
{
	[DesignerGenerated]
	public class About : Form
	{
		private IContainer m_a;

		[AccessedThroughProperty("RichTextBox1")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private RichTextBox b;

		[CompilerGenerated]
		[AccessedThroughProperty("Label1")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Label c;

		internal virtual RichTextBox RichTextBox1
		{
			[CompilerGenerated]
			get
			{
				return b;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				b = value;
			}
		}

		internal virtual Label Label1
		{
			[CompilerGenerated]
			get
			{
				return c;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				c = value;
			}
		}

		public About()
		{
			base.Load += a;
			a();
		}

		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.m_a != null)
				{
					this.m_a.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		[DebuggerStepThrough]
		private void a()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(About));
			RichTextBox1 = new RichTextBox();
			Label1 = new Label();
			SuspendLayout();
			RichTextBox1.BackColor = SystemColors.Info;
			RichTextBox1.Dock = DockStyle.Fill;
			RichTextBox1.Location = new Point(0, 0);
			RichTextBox1.Margin = new Padding(4);
			RichTextBox1.Name = "RichTextBox1";
			RichTextBox1.ReadOnly = true;
			RichTextBox1.Size = new Size(312, 308);
			RichTextBox1.TabIndex = 0;
			RichTextBox1.Text = componentResourceManager.GetString("RichTextBox1.Text");
			Label1.AutoSize = true;
			Label1.BackColor = Color.Transparent;
			Label1.ForeColor = Color.White;
			Label1.Location = new Point(359, 353);
			Label1.Name = "Label1";
			Label1.Size = new Size(53, 20);
			Label1.TabIndex = 2;
			Label1.Text = "Label1";
			base.AutoScaleMode = AutoScaleMode.Inherit;
			base.ClientSize = new Size(312, 308);
			base.Controls.Add(RichTextBox1);
			ForeColor = Color.FromArgb(12, 12, 12);
			base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
			base.Margin = new Padding(4);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			MinimumSize = new Size(80, 55);
			base.Name = "About";
			Text = "Thông tin";
			base.TransparencyKey = Color.Fuchsia;
			ResumeLayout(false);
		}

		private void a(object A_0, EventArgs A_1)
		{
			try
			{
				base.Icon = new Icon("icon.ico");
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
