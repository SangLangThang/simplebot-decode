using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;

namespace System.Windows.Forms
{
	public enum StatusBarPanelAutoSize
	{
		None,
		Contents,
		Spring
	}

	public enum StatusBarPanelBorderStyle
	{
		None,
		Raised,
		Sunken
	}

	public class StatusBarPanel : Component, ISupportInitialize
	{
		public HorizontalAlignment Alignment { get; set; }
		public StatusBarPanelAutoSize AutoSize { get; set; }
		public StatusBarPanelBorderStyle BorderStyle { get; set; }
		public string Name { get; set; }
		public string Text { get; set; }
		public int MinWidth { get; set; }
		public int Width { get; set; }

		public void BeginInit()
		{
		}

		public void EndInit()
		{
		}
	}

	public class StatusBarPanelCollection : Collection<StatusBarPanel>
	{
		public void AddRange(StatusBarPanel[] panels)
		{
			if (panels == null)
			{
				return;
			}
			foreach (StatusBarPanel panel in panels)
			{
				Add(panel);
			}
		}
	}

	public class StatusBar : Control
	{
		public StatusBar()
		{
			Panels = new StatusBarPanelCollection();
			Height = 18;
		}

		public StatusBarPanelCollection Panels { get; }
		public bool ShowPanels { get; set; }
		public bool SizingGrip { get; set; }
	}

	public enum ToolBarButtonStyle
	{
		PushButton,
		ToggleButton,
		Separator,
		DropDownButton
	}

	public class ToolBarButton : Component
	{
		public bool Enabled { get; set; } = true;
		public int ImageIndex { get; set; }
		public string Name { get; set; }
		public bool PartialPush { get; set; }
		public bool Pushed { get; set; }
		public Rectangle Rectangle { get; set; }
		public ToolBarButtonStyle Style { get; set; }
		public object Tag { get; set; }
		public string Text { get; set; }
		public string ToolTipText { get; set; }
		public bool Visible { get; set; } = true;
	}

	public class ContextMenu : Component
	{
	}
}
