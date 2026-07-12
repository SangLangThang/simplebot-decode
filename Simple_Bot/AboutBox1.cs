using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Simple_Bot
{
	[DesignerGenerated]
	public class AboutBox1 : Form
	{
		private IContainer m_a;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("PictureBox1")]
		[CompilerGenerated]
		private PictureBox m_b;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[AccessedThroughProperty("Timer1")]
		private Timer m_c;

		internal virtual PictureBox PictureBox1
		{
			[CompilerGenerated]
			get
			{
				return this.m_b;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				this.m_b = value;
			}
		}

		internal virtual Timer Timer1
		{
			[CompilerGenerated]
			get
			{
				return this.m_c;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = a;
				Timer timer = this.m_c;
				if (timer != null)
				{
					timer.Tick -= value2;
				}
				this.m_c = value;
				timer = this.m_c;
				if (timer != null)
				{
					timer.Tick += value2;
				}
			}
		}

		public AboutBox1()
		{
			base.Load += c;
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
			this.m_a = new Container();
			PictureBox1 = new PictureBox();
			Timer1 = new Timer(this.m_a);
			((ISupportInitialize)PictureBox1).BeginInit();
			SuspendLayout();
			PictureBox1.Dock = DockStyle.Fill;
			PictureBox1.Location = new Point(9, 9);
			PictureBox1.Name = "PictureBox1";
			PictureBox1.Size = new Size(432, 332);
			PictureBox1.TabIndex = 0;
			PictureBox1.TabStop = false;
			Timer1.Enabled = true;
			Timer1.Interval = 10000;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(450, 350);
			base.Controls.Add(PictureBox1);
			base.FormBorderStyle = FormBorderStyle.None;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "AboutBox1";
			base.Padding = new Padding(9);
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterParent;
			Text = "AboutBox1";
			((ISupportInitialize)PictureBox1).EndInit();
			ResumeLayout(false);
		}

		private void c(object A_0, EventArgs A_1)
		{
			try
			{
				using (WebClient webClient = new WebClient())
				{
					PictureBox1.Image = Image.FromStream(webClient.OpenRead("http://tsonline.xyz/donate.jpg"));
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

		private void b(object A_0, EventArgs A_1)
		{
		}

		private void a(object A_0, EventArgs A_1)
		{
			Close();
		}
	}
}
