using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Simple_Bot
{
	public class TabPageEx : TabPage
	{
		private TabControl m_a;

		public TabPageEx(TabControl _tbc, Form _form)
		{
			this.m_a = _tbc;
			Text = _form.Text;
			_form.TopLevel = false;
			_form.FormBorderStyle = FormBorderStyle.None;
			_form.Dock = DockStyle.Fill;
			_form.Show();
			base.Controls.Add(_form);
			BackColor = Color.FromArgb(53, 73, 106);
			_form.FormClosed += a;
			_form.TextChanged += a;
		}

		private void a(object A_0, FormClosedEventArgs A_1)
		{
			this.m_a.TabPages.Remove(this);
		}

		private void a(object A_0, EventArgs A_1)
		{
			Text = Conversions.ToString(NewLateBinding.LateGet(A_0, null, "Text", new object[0], null, null, null));
		}
	}
}
