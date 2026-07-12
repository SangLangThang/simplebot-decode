using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using Microsoft.VisualBasic.CompilerServices;

namespace Simple_Bot
{
	[Designer(typeof(b))]
	[DefaultEvent("SelectedTabChanged")]
	[Docking(DockingBehavior.AutoDock)]
	[ToolboxBitmap(typeof(TabControl))]
	public class VisualStudioTabControl : Panel
	{
		[ToolboxItem(false)]
		[Designer(typeof(a))]
		public class VisualStudioTabPage : ScrollableControl
		{
			internal sealed class a : ScrollableControlDesigner
			{
				private DesignerVerbCollection m_a;

				private ISelectionService b;

				private DesignerActionUIService c;

				[SpecialName]
				public VisualStudioTabPage h()
				{
					return (VisualStudioTabPage)Control;
				}

				[SpecialName]
				public DesignerVerbCollection get_Verbs()
				{
					return m_a;
				}

				[SpecialName]
				public ISelectionService g()
				{
					if (b == null)
					{
						b = (ISelectionService)GetService(typeof(ISelectionService));
					}
					return b;
				}

				[SpecialName]
				public DesignerActionUIService f()
				{
					if (c == null)
					{
						c = (DesignerActionUIService)GetService(typeof(DesignerActionUIService));
					}
					return c;
				}

				public a()
				{
					m_a = new DesignerVerbCollection(new DesignerVerb[1]
					{
						new DesignerVerb("Select VisualStudioTabControl", f)
					});
					b = null;
				}

				private void f(object A_0, EventArgs A_1)
				{
					if (h().Parent != null)
					{
						g().SetSelectedComponents(new IComponent[1] { h().Parent });
						f().HideUI(h());
					}
				}

				[SpecialName]
				public SelectionRules get_SelectionRules()
				{
					return SelectionRules.Visible;
				}

				protected override void PostFilterProperties(IDictionary properties)
				{
					properties.Remove("Anchor");
					properties.Remove("TabStop");
					properties.Remove("TabIndex");
					properties.Remove("Dock");
					properties.Remove("BackColor");
					base.PostFilterProperties(properties);
				}

				public override void InitializeNewComponent(IDictionary defaultValues)
				{
					base.InitializeNewComponent(defaultValues);
					Control.Visible = true;
				}
			}

			private string m_a;

			[Browsable(false)]
			public int Index
			{
				get
				{
					VisualStudioTabControl owner = Owner;
					if (owner != null)
					{
						return owner.TabPages.IndexOf(this);
					}
					return -1;
				}
			}

			[EditorBrowsable(EditorBrowsableState.Never)]
			[Browsable(false)]
			public override AnchorStyles Anchor
			{
				get
				{
					return base.Anchor;
				}
				set
				{
					base.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
				}
			}

			[Browsable(false)]
			public bool Selected
			{
				get
				{
					VisualStudioTabControl owner = Owner;
					if (owner != null)
					{
						return owner.SelectedTabPage == this;
					}
					return false;
				}
			}

			[Browsable(false)]
			public Rectangle SideTabClientRectangle
			{
				get
				{
					VisualStudioTabControl owner = Owner;
					if (owner != null)
					{
						Rectangle result = checked(new Rectangle(2, 6 + Index * (32 + owner.Inflation.Height), 99 + owner.Inflation.Width, 31 + owner.Inflation.Height));
						return result;
					}
					return Rectangle.Empty;
				}
			}

			[Browsable(false)]
			public bool SideTabVisible
			{
				get
				{
					VisualStudioTabControl owner = Owner;
					if (owner != null)
					{
						return Index < owner.MinimumTabDraw;
					}
					return false;
				}
			}

			[Browsable(false)]
			public VisualStudioTabControl Owner
			{
				get
				{
					VisualStudioTabControl visualStudioTabControl = base.Parent as VisualStudioTabControl;
					if (visualStudioTabControl != null)
					{
						return visualStudioTabControl;
					}
					return null;
				}
			}

			[EditorBrowsable(EditorBrowsableState.Never)]
			[Browsable(false)]
			public override Color BackColor
			{
				get
				{
					VisualStudioTabControl owner = Owner;
					if (owner != null)
					{
						return owner.Skin.TabControl.InnerBackColor;
					}
					return base.BackColor;
				}
				set
				{
					base.BackColor = value;
				}
			}

			[Browsable(false)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public new Size Size
			{
				get
				{
					return base.Size;
				}
				set
				{
					base.Size = value;
				}
			}

			[DefaultValue(null)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
			[Editor(typeof(e), typeof(UITypeEditor))]
			[TypeConverter(typeof(d))]
			public string ImageKey
			{
				get
				{
					return this.m_a;
				}
				set
				{
					VisualStudioTabControl owner = Owner;
					this.m_a = value;
					if (owner != null)
					{
						owner.Invalidate();
					}
				}
			}

			public VisualStudioTabPage()
			{
				this.m_a = null;
				base.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
				base.Padding = new Padding(6);
				base.AutoScroll = true;
				SetStyle(ControlStyles.ResizeRedraw, true);
				SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
				SetStyle(ControlStyles.UserPaint, true);
				SetStyle(ControlStyles.AllPaintingInWmPaint, true);
				VisualStudioTabControl owner = Owner;
				if (owner != null)
				{
					Size = owner.DefaultChildSize;
				}
			}

			protected override void InitLayout()
			{
				base.InitLayout();
				base.Location = new Point(101, 6);
			}

			protected override void OnLocationChanged(EventArgs e)
			{
				base.OnLocationChanged(e);
				VisualStudioTabControl owner = Owner;
				if (owner == null)
				{
					base.Location = new Point(101, 6);
				}
				else
				{
					base.Location = new Point(checked(101 + owner.Inflation.Width), 6);
				}
			}

			protected override void OnSizeChanged(EventArgs e)
			{
				base.OnSizeChanged(e);
				if (base.Parent != null && base.Parent is VisualStudioTabControl)
				{
					Size = ((VisualStudioTabControl)base.Parent).DefaultChildSize;
				}
			}

			protected override void OnParentChanged(EventArgs e)
			{
				if (!(base.Parent is VisualStudioTabControl) && base.Parent != null)
				{
					throw new ArgumentException("Only a VisualStudioTabPage can be added to a VisualStudioTabControl");
				}
				if (base.Parent != null)
				{
					Size = ((VisualStudioTabControl)base.Parent).DefaultChildSize;
				}
				base.OnParentChanged(e);
			}

			protected override void OnTextChanged(EventArgs e)
			{
				base.OnTextChanged(e);
				VisualStudioTabControl visualStudioTabControl = base.Parent as VisualStudioTabControl;
				if (visualStudioTabControl != null)
				{
					visualStudioTabControl.Invalidate();
				}
			}

			protected override void OnPaint(PaintEventArgs e)
			{
				e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
				base.OnPaint(e);
				VisualStudioTabControl owner = Owner;
				if (owner == null)
				{
					return;
				}
				checked
				{
					int num = 32 + owner.Inflation.Height;
					using (Pen pen = new Pen(owner.Skin.TabControl.InnerBorderColor))
					{
						e.Graphics.DrawRectangle(pen, new Rectangle(base.ClientRectangle.Location, new Size(base.ClientRectangle.Width - 1, base.ClientRectangle.Height - 1)));
					}
					if (base.Enabled && Selected && SideTabVisible)
					{
						using (Pen pen2 = new Pen(owner.Skin.TabPage.SelectedTabPage.TabRightBorderColor))
						{
							e.Graphics.DrawLine(pen2, 0, Index * num + 1, 0, Index * num + 30 + owner.Inflation.Height);
						}
					}
					int i = 0;
					bool flag = false;
					VisualStudioTabPage visualStudioTabPage = null;
					for (; i != owner.MinimumTabDraw; i++)
					{
						visualStudioTabPage = (VisualStudioTabPage)owner.TabPages[i];
						if (visualStudioTabPage.SideTabClientRectangle.Contains(owner.ClientCursorPosition) && !visualStudioTabPage.Selected && !base.DesignMode)
						{
							using (Pen pen3 = new Pen(owner.Skin.TabPage.MouseHoverTabPage.TabRightBorderColor))
							{
								e.Graphics.DrawLine(pen3, 0, i * num + 1, 0, i * num + 30 + owner.Inflation.Height);
							}
						}
					}
				}
			}

			protected override void OnMouseEnter(EventArgs e)
			{
				base.OnMouseEnter(e);
				Owner.Invalidate();
			}

			protected override void OnMouseLeave(EventArgs e)
			{
				base.OnMouseLeave(e);
				Owner.Invalidate();
			}

			protected override void OnMouseMove(MouseEventArgs e)
			{
				base.OnMouseMove(e);
				Owner.Invalidate();
			}

			protected override void OnScroll(ScrollEventArgs se)
			{
				base.OnScroll(se);
				Invalidate();
			}

			public override string ToString()
			{
				return GetType().Name;
			}
		}

		[Serializable]
		[TypeConverter(typeof(ExpandableObjectConverter))]
		public class VisualStudioTabControlSkin : IDisposable
		{
			[Serializable]
			[EditorBrowsable(EditorBrowsableState.Never)]
			[TypeConverter(typeof(ExpandableObjectConverter))]
			public class TabControlSkin
			{
				[EditorBrowsable(EditorBrowsableState.Never)]
				[TypeConverter(typeof(ExpandableObjectConverter))]
				public class TabControlGlyphSkin
				{
					private Color a;

					private Color b;

					private Color c;

					[DefaultValue(typeof(Color), "Black")]
					public Color GlyphColor
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

					[DefaultValue(typeof(Color), "75, 75, 111")]
					public Color GlyphBorderColor
					{
						get
						{
							return b;
						}
						set
						{
							b = value;
						}
					}

					[DefaultValue(typeof(Color), "255, 238, 194")]
					public Color GlyphHighlightColor
					{
						get
						{
							return c;
						}
						set
						{
							c = value;
						}
					}

					public TabControlGlyphSkin()
					{
						a = Color.Black;
						b = Color.FromArgb(75, 75, 111);
						c = Color.FromArgb(255, 238, 194);
					}

					public override bool Equals(object obj)
					{
						if (obj == this)
						{
							return true;
						}
						TabControlGlyphSkin tabControlGlyphSkin = obj as TabControlGlyphSkin;
						if (tabControlGlyphSkin == null)
						{
							return false;
						}
						if (!object.Equals(GlyphBorderColor, tabControlGlyphSkin.GlyphBorderColor))
						{
							return false;
						}
						if (!object.Equals(GlyphColor, tabControlGlyphSkin.GlyphColor))
						{
							return false;
						}
						if (!object.Equals(GlyphHighlightColor, tabControlGlyphSkin.GlyphHighlightColor))
						{
							return false;
						}
						return true;
					}

					public override int GetHashCode()
					{
						return GlyphBorderColor.GetHashCode() ^ GlyphColor.GetHashCode() ^ GlyphHighlightColor.GetHashCode();
					}

					public override string ToString()
					{
						return GetType().Name;
					}
				}

				[EditorBrowsable(EditorBrowsableState.Never)]
				[TypeConverter(typeof(ExpandableObjectConverter))]
				public class TabControlDividerSkin
				{
					private Color a;

					private Color b;

					private bool c;

					[DefaultValue(typeof(Color), "White")]
					public Color TopColor
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

					[DefaultValue(typeof(Color), "222, 222, 229")]
					public Color BottomColor
					{
						get
						{
							return b;
						}
						set
						{
							b = value;
						}
					}

					[DefaultValue(true)]
					public bool DrawDividers
					{
						get
						{
							return c;
						}
						set
						{
							c = value;
						}
					}

					public TabControlDividerSkin()
					{
						a = Color.White;
						b = Color.FromArgb(222, 222, 229);
						c = true;
					}

					public override bool Equals(object obj)
					{
						if (obj == this)
						{
							return true;
						}
						TabControlDividerSkin tabControlDividerSkin = obj as TabControlDividerSkin;
						if (tabControlDividerSkin == null)
						{
							return false;
						}
						if (!object.Equals(BottomColor, tabControlDividerSkin.BottomColor))
						{
							return false;
						}
						if (!object.Equals(DrawDividers, tabControlDividerSkin.DrawDividers))
						{
							return false;
						}
						if (!object.Equals(TopColor, tabControlDividerSkin.TopColor))
						{
							return false;
						}
						return true;
					}

					public override int GetHashCode()
					{
						return TopColor.GetHashCode() ^ BottomColor.GetHashCode() ^ DrawDividers.GetHashCode();
					}

					public override string ToString()
					{
						return GetType().Name;
					}
				}

				private TabControlGlyphSkin _GlyphSkin;

				private TabControlDividerSkin _DividerSkin;

				private Color _OuterBorderColor;

				private Color _InnerBorderColor;

				private Color _OuterBackColor;

				private Color _InnerBackColor;

				[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
				public TabControlGlyphSkin GlyphSkin
				{
					get
					{
						return _GlyphSkin;
					}
				}

				[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
				public TabControlDividerSkin DividerSkin
				{
					get
					{
						return _DividerSkin;
					}
				}

				[DefaultValue(typeof(Color), "145, 167, 180")]
				public Color OuterBorderColor
				{
					get
					{
						return _OuterBorderColor;
					}
					set
					{
						_OuterBorderColor = value;
					}
				}

				[DefaultValue(typeof(Color), "131, 151, 162")]
				public Color InnerBorderColor
				{
					get
					{
						return _InnerBorderColor;
					}
					set
					{
						_InnerBorderColor = value;
					}
				}

				[DefaultValue(typeof(Color), "214, 214, 222")]
				public Color OuterBackColor
				{
					get
					{
						return _OuterBackColor;
					}
					set
					{
						_OuterBackColor = value;
					}
				}

				[DefaultValue(typeof(Color), "240, 240, 240")]
				public Color InnerBackColor
				{
					get
					{
						return _InnerBackColor;
					}
					set
					{
						_InnerBackColor = value;
					}
				}

				public TabControlSkin()
				{
					_GlyphSkin = new TabControlGlyphSkin();
					_DividerSkin = new TabControlDividerSkin();
					_OuterBorderColor = Color.FromArgb(145, 167, 180);
					_InnerBorderColor = Color.FromArgb(131, 151, 162);
					_OuterBackColor = Color.FromArgb(214, 214, 222);
					_InnerBackColor = Color.FromArgb(240, 240, 240);
				}

				public override bool Equals(object obj)
				{
					if (obj == this)
					{
						return true;
					}
					TabControlSkin tabControlSkin = obj as TabControlSkin;
					if (tabControlSkin == null)
					{
						return false;
					}
					if (!object.Equals(DividerSkin, tabControlSkin.DividerSkin))
					{
						return false;
					}
					if (!object.Equals(GlyphSkin, tabControlSkin.GlyphSkin))
					{
						return false;
					}
					if (!object.Equals(InnerBackColor, InnerBackColor))
					{
						return false;
					}
					if (!object.Equals(InnerBorderColor, InnerBorderColor))
					{
						return false;
					}
					if (!object.Equals(OuterBackColor, OuterBackColor))
					{
						return false;
					}
					if (!object.Equals(OuterBorderColor, OuterBorderColor))
					{
						return false;
					}
					return true;
				}

				public override int GetHashCode()
				{
					return DividerSkin.GetHashCode() ^ GlyphSkin.GetHashCode() ^ InnerBackColor.GetHashCode() ^ InnerBorderColor.GetHashCode() ^ (OuterBackColor.GetHashCode() | OuterBorderColor.GetHashCode());
				}

				public override string ToString()
				{
					return GetType().Name;
				}
			}

			[Serializable]
			[EditorBrowsable(EditorBrowsableState.Never)]
			[TypeConverter(typeof(ExpandableObjectConverter))]
			public class TabPageSkin : IDisposable
			{
				[TypeConverter(typeof(ExpandableObjectConverter))]
				[EditorBrowsable(EditorBrowsableState.Never)]
				public class ExtendedTabPageSkin : DefaultTabPageSkin
				{
					private Color a;

					private Color b;

					private Color c;

					private Color d;

					[DefaultValue(typeof(Color), "230, 139, 44")]
					public Color TabTipColor
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

					[DefaultValue(typeof(Color), "255, 199, 60")]
					public Color TabTipInnerColor
					{
						get
						{
							return b;
						}
						set
						{
							b = value;
						}
					}

					[DefaultValue(typeof(Color), "145, 155, 156")]
					public Color TabBorderColor
					{
						get
						{
							return c;
						}
						set
						{
							c = value;
						}
					}

					[DefaultValue(typeof(Color), "240, 240, 240")]
					public Color TabRightBorderColor
					{
						get
						{
							return d;
						}
						set
						{
							d = value;
						}
					}

					public ExtendedTabPageSkin()
					{
						a = Color.FromArgb(230, 139, 44);
						b = Color.FromArgb(255, 199, 60);
						c = Color.FromArgb(145, 155, 156);
						d = Color.FromArgb(240, 240, 240);
					}

					public override bool Equals(object obj)
					{
						if (obj == this)
						{
							return true;
						}
						ExtendedTabPageSkin extendedTabPageSkin = obj as ExtendedTabPageSkin;
						if (extendedTabPageSkin == null)
						{
							return false;
						}
						if (!object.Equals(TabBorderColor, extendedTabPageSkin.TabBorderColor))
						{
							return false;
						}
						if (!object.Equals(TabRightBorderColor, TabRightBorderColor))
						{
							return false;
						}
						if (!object.Equals(TabTipColor, TabTipColor))
						{
							return false;
						}
						if (!object.Equals(TabTipInnerColor, TabTipInnerColor))
						{
							return false;
						}
						return base.Equals(RuntimeHelpers.GetObjectValue(obj));
					}

					public override int GetHashCode()
					{
						return TabBorderColor.GetHashCode() ^ TabTipInnerColor.GetHashCode() ^ TabBorderColor.GetHashCode() ^ TabRightBorderColor.GetHashCode() ^ base.GetHashCode();
					}

					public override string ToString()
					{
						return GetType().Name;
					}
				}

				[EditorBrowsable(EditorBrowsableState.Never)]
				[TypeConverter(typeof(ExpandableObjectConverter))]
				public class DefaultTabPageSkin : IDisposable
				{
					private VisualStudioTabControlFontSettings a;

					private TabPageGradientSettings b;

					[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
					public VisualStudioTabControlFontSettings FontSettings
					{
						get
						{
							return a;
						}
					}

					[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
					public TabPageGradientSettings GradientSettings
					{
						get
						{
							return b;
						}
					}

					public DefaultTabPageSkin()
					{
						a = new VisualStudioTabControlFontSettings();
						b = new TabPageGradientSettings();
					}

					public override bool Equals(object obj)
					{
						if (obj == this)
						{
							return true;
						}
						DefaultTabPageSkin defaultTabPageSkin = obj as DefaultTabPageSkin;
						if (defaultTabPageSkin == null)
						{
							return false;
						}
						if (!object.Equals(FontSettings, defaultTabPageSkin.FontSettings))
						{
							return false;
						}
						if (!object.Equals(GradientSettings, defaultTabPageSkin.GradientSettings))
						{
							return false;
						}
						return true;
					}

					public override int GetHashCode()
					{
						return FontSettings.GetHashCode() ^ GradientSettings.GetHashCode();
					}

					public override string ToString()
					{
						return GetType().Name;
					}

					public void Dispose()
					{
						FontSettings.Dispose();
					}

					void IDisposable.Dispose()
					{
						//ILSpy generated this explicit interface implementation from .override directive in Dispose
						this.Dispose();
					}
				}

				[EditorBrowsable(EditorBrowsableState.Never)]
				[TypeConverter(typeof(ExpandableObjectConverter))]
				public class TabPageGradientSettings
				{
					private LinearGradientMode a;

					private Color b;

					private Color c;

					[DefaultValue(typeof(LinearGradientMode), "Horizontal")]
					public LinearGradientMode LinearGradientMode
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

					[DefaultValue(typeof(Color), "240, 240, 240")]
					public Color StartColor
					{
						get
						{
							return b;
						}
						set
						{
							b = value;
						}
					}

					[DefaultValue(typeof(Color), "214, 214, 222")]
					public Color EndColor
					{
						get
						{
							return c;
						}
						set
						{
							c = value;
						}
					}

					public TabPageGradientSettings()
					{
						a = LinearGradientMode.Horizontal;
						b = Color.FromArgb(240, 240, 240);
						c = Color.FromArgb(214, 214, 222);
					}

					public override string ToString()
					{
						return GetType().Name;
					}

					public override bool Equals(object obj)
					{
						if (obj == this)
						{
							return true;
						}
						TabPageGradientSettings tabPageGradientSettings = obj as TabPageGradientSettings;
						if (tabPageGradientSettings == null)
						{
							return false;
						}
						if (!object.Equals(EndColor, tabPageGradientSettings.EndColor))
						{
							return false;
						}
						if (!object.Equals(LinearGradientMode, tabPageGradientSettings.LinearGradientMode))
						{
							return false;
						}
						if (!object.Equals(StartColor, tabPageGradientSettings.StartColor))
						{
							return false;
						}
						return true;
					}

					public override int GetHashCode()
					{
						return EndColor.GetHashCode() ^ LinearGradientMode.GetHashCode() ^ StartColor.GetHashCode();
					}
				}

				private ExtendedTabPageSkin _SelectedTabPage;

				private ExtendedTabPageSkin _MouseHoverTabPage;

				private DefaultTabPageSkin _UnselectedTabPage;

				[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
				public ExtendedTabPageSkin SelectedTabPage
				{
					get
					{
						return _SelectedTabPage;
					}
				}

				[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
				public ExtendedTabPageSkin MouseHoverTabPage
				{
					get
					{
						return _MouseHoverTabPage;
					}
				}

				[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
				public DefaultTabPageSkin UnselectedTabPage
				{
					get
					{
						return _UnselectedTabPage;
					}
				}

				public TabPageSkin()
				{
					_SelectedTabPage = new ExtendedTabPageSkin();
					_MouseHoverTabPage = new ExtendedTabPageSkin();
					_UnselectedTabPage = new DefaultTabPageSkin();
				}

				public override bool Equals(object obj)
				{
					if (obj == this)
					{
						return false;
					}
					TabPageSkin tabPageSkin = obj as TabPageSkin;
					if (tabPageSkin == null)
					{
						return false;
					}
					if (!object.Equals(MouseHoverTabPage, tabPageSkin.MouseHoverTabPage))
					{
						return false;
					}
					if (!object.Equals(SelectedTabPage, tabPageSkin.SelectedTabPage))
					{
						return false;
					}
					if (!object.Equals(UnselectedTabPage, tabPageSkin.UnselectedTabPage))
					{
						return false;
					}
					return true;
				}

				public override int GetHashCode()
				{
					return SelectedTabPage.GetHashCode() ^ MouseHoverTabPage.GetHashCode() ^ UnselectedTabPage.GetHashCode();
				}

				public override string ToString()
				{
					return GetType().Name;
				}

				public void Dispose()
				{
					SelectedTabPage.Dispose();
					MouseHoverTabPage.Dispose();
					UnselectedTabPage.Dispose();
				}

				void IDisposable.Dispose()
				{
					//ILSpy generated this explicit interface implementation from .override directive in Dispose
					this.Dispose();
				}
			}

			[TypeConverter(typeof(ExpandableObjectConverter))]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public class VisualStudioTabControlFontSettings : IDisposable
			{
				private Font a;

				private Color b;

				[DefaultValue(typeof(Font), "Tahoma, 7.5pt")]
				public Font Font
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

				[DefaultValue(typeof(Color), "ControlText")]
				public Color FontColor
				{
					get
					{
						return b;
					}
					set
					{
						b = value;
					}
				}

				public VisualStudioTabControlFontSettings()
				{
					a = new Font("Tahoma", 7.5f);
					b = SystemColors.ControlText;
				}

				public override bool Equals(object obj)
				{
					if (obj == this)
					{
						return true;
					}
					VisualStudioTabControlFontSettings visualStudioTabControlFontSettings = obj as VisualStudioTabControlFontSettings;
					if (visualStudioTabControlFontSettings == null)
					{
						return false;
					}
					if (!object.Equals(Font, visualStudioTabControlFontSettings.Font))
					{
						return false;
					}
					if (!object.Equals(FontColor, visualStudioTabControlFontSettings.FontColor))
					{
						return false;
					}
					return true;
				}

				public override int GetHashCode()
				{
					int num = FontColor.GetHashCode();
					if (Font == null)
					{
						num ^= FontColor.GetHashCode();
					}
					return num;
				}

				public override string ToString()
				{
					return GetType().Name;
				}

				public void Dispose()
				{
					if (Font != null)
					{
						Font.Dispose();
						Font = null;
					}
				}

				void IDisposable.Dispose()
				{
					//ILSpy generated this explicit interface implementation from .override directive in Dispose
					this.Dispose();
				}
			}

			private VisualStudioTabControl _Owner;

			private TabControlSkin _TabControl;

			private TabPageSkin _TabPage;

			private IPropertyValueUIService _PropertyValueUIService;

			protected VisualStudioTabControl Owner
			{
				get
				{
					return _Owner;
				}
			}

			[Category("VisualStudioTabControlSkinSettings")]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
			public TabControlSkin TabControl
			{
				get
				{
					return _TabControl;
				}
			}

			[Category("VisualStudioTabControlSkinSettings")]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
			public TabPageSkin TabPage
			{
				get
				{
					return _TabPage;
				}
			}

			protected IPropertyValueUIService PropertyValueUIService
			{
				get
				{
					if (_PropertyValueUIService == null && _Owner != null)
					{
						_PropertyValueUIService = _Owner.GetService(typeof(IPropertyValueUIService)) as IPropertyValueUIService;
					}
					return _PropertyValueUIService;
				}
			}

			public VisualStudioTabControlSkin(VisualStudioTabControl owner)
			{
				_TabControl = new TabControlSkin();
				_TabPage = new TabPageSkin();
				if (owner == null)
				{
					throw new ArgumentNullException("owner");
				}
				_Owner = owner;
				if (PropertyValueUIService != null)
				{
					PropertyValueUIService.PropertyUIValueItemsChanged += OnPropertyValueUIItemsChanged;
				}
			}

			public override bool Equals(object obj)
			{
				if (obj == this)
				{
					return true;
				}
				VisualStudioTabControlSkin visualStudioTabControlSkin = obj as VisualStudioTabControlSkin;
				if (visualStudioTabControlSkin == null)
				{
					return false;
				}
				if (!object.Equals(TabControl, visualStudioTabControlSkin.TabControl))
				{
					return false;
				}
				if (!object.Equals(TabPage, visualStudioTabControlSkin.TabPage))
				{
					return false;
				}
				return true;
			}

			public override int GetHashCode()
			{
				return TabControl.GetHashCode() ^ TabPage.GetHashCode();
			}

			public override string ToString()
			{
				return GetType().Name;
			}

			public void Dispose()
			{
				TabPage.Dispose();
			}

			void IDisposable.Dispose()
			{
				//ILSpy generated this explicit interface implementation from .override directive in Dispose
				this.Dispose();
			}

			protected virtual void OnPropertyValueUIItemsChanged(object sender, EventArgs e)
			{
				_Owner.Invalidate();
			}

			~VisualStudioTabControlSkin()
			{
				if (PropertyValueUIService != null)
				{
					PropertyValueUIService.PropertyUIValueItemsChanged -= OnPropertyValueUIItemsChanged;
				}
			}

			public VisualStudioTabControlSkin Clone()
			{
				return Clone(this);
			}

			public static VisualStudioTabControlSkin Clone(VisualStudioTabControlSkin prototype)
			{
				VisualStudioTabControlSkin visualStudioTabControlSkin = new VisualStudioTabControlSkin(prototype.Owner);
				VisualStudioTabControlSkin visualStudioTabControlSkin2 = visualStudioTabControlSkin;
				TabControlSkin tabControl = visualStudioTabControlSkin2.TabControl;
				tabControl.DividerSkin.BottomColor = prototype.TabControl.DividerSkin.BottomColor;
				tabControl.DividerSkin.DrawDividers = prototype.TabControl.DividerSkin.DrawDividers;
				tabControl.DividerSkin.TopColor = prototype.TabControl.DividerSkin.TopColor;
				tabControl.GlyphSkin.GlyphBorderColor = prototype.TabControl.GlyphSkin.GlyphBorderColor;
				tabControl.GlyphSkin.GlyphColor = prototype.TabControl.GlyphSkin.GlyphColor;
				tabControl.GlyphSkin.GlyphHighlightColor = prototype.TabControl.GlyphSkin.GlyphHighlightColor;
				tabControl.InnerBackColor = prototype.TabControl.InnerBackColor;
				tabControl.InnerBorderColor = prototype.TabControl.InnerBorderColor;
				tabControl.OuterBackColor = prototype.TabControl.OuterBackColor;
				tabControl.OuterBorderColor = prototype.TabControl.OuterBorderColor;
				tabControl = null;
				TabPageSkin tabPage = visualStudioTabControlSkin2.TabPage;
				tabPage.MouseHoverTabPage.FontSettings.Font = (Font)prototype.TabPage.MouseHoverTabPage.FontSettings.Font.Clone();
				tabPage.MouseHoverTabPage.FontSettings.FontColor = prototype.TabPage.MouseHoverTabPage.FontSettings.FontColor;
				tabPage.MouseHoverTabPage.GradientSettings.EndColor = prototype.TabPage.MouseHoverTabPage.GradientSettings.EndColor;
				tabPage.MouseHoverTabPage.GradientSettings.LinearGradientMode = prototype.TabPage.MouseHoverTabPage.GradientSettings.LinearGradientMode;
				tabPage.MouseHoverTabPage.GradientSettings.StartColor = prototype.TabPage.MouseHoverTabPage.GradientSettings.StartColor;
				tabPage.MouseHoverTabPage.TabBorderColor = prototype.TabPage.MouseHoverTabPage.TabBorderColor;
				tabPage.MouseHoverTabPage.TabRightBorderColor = prototype.TabPage.MouseHoverTabPage.TabRightBorderColor;
				tabPage.MouseHoverTabPage.TabTipColor = prototype.TabPage.MouseHoverTabPage.TabTipColor;
				tabPage.MouseHoverTabPage.TabTipInnerColor = prototype.TabPage.MouseHoverTabPage.TabTipInnerColor;
				tabPage.SelectedTabPage.FontSettings.Font = (Font)prototype.TabPage.SelectedTabPage.FontSettings.Font.Clone();
				tabPage.SelectedTabPage.FontSettings.FontColor = prototype.TabPage.SelectedTabPage.FontSettings.FontColor;
				tabPage.SelectedTabPage.GradientSettings.EndColor = prototype.TabPage.SelectedTabPage.GradientSettings.EndColor;
				tabPage.SelectedTabPage.GradientSettings.LinearGradientMode = prototype.TabPage.SelectedTabPage.GradientSettings.LinearGradientMode;
				tabPage.SelectedTabPage.GradientSettings.StartColor = prototype.TabPage.SelectedTabPage.GradientSettings.StartColor;
				tabPage.SelectedTabPage.TabBorderColor = prototype.TabPage.SelectedTabPage.TabBorderColor;
				tabPage.SelectedTabPage.TabRightBorderColor = prototype.TabPage.SelectedTabPage.TabRightBorderColor;
				tabPage.SelectedTabPage.TabTipColor = prototype.TabPage.SelectedTabPage.TabTipColor;
				tabPage.SelectedTabPage.TabTipInnerColor = prototype.TabPage.SelectedTabPage.TabTipInnerColor;
				tabPage.UnselectedTabPage.FontSettings.Font = (Font)prototype.TabPage.UnselectedTabPage.FontSettings.Font.Clone();
				tabPage.UnselectedTabPage.FontSettings.FontColor = prototype.TabPage.UnselectedTabPage.FontSettings.FontColor;
				tabPage.UnselectedTabPage.GradientSettings.EndColor = prototype.TabPage.UnselectedTabPage.GradientSettings.EndColor;
				tabPage.UnselectedTabPage.GradientSettings.LinearGradientMode = prototype.TabPage.UnselectedTabPage.GradientSettings.LinearGradientMode;
				tabPage.UnselectedTabPage.GradientSettings.StartColor = prototype.TabPage.UnselectedTabPage.GradientSettings.StartColor;
				tabPage = null;
				visualStudioTabControlSkin2 = null;
				return visualStudioTabControlSkin;
			}
		}

		internal class TabControlResources
		{
			internal const string a = "(none)";

			internal const string b = "ImageList";

			internal const string c = "The VisualStudioTabPages in the VisualStudioTabControl.";

			internal const string d = "Gets or sets the selected VisualStudioTabPage.";

			internal const string e = "Gets the amount of VisualStudioTabPages.";

			internal const string f = "Indicates the ImageList object that this control's tabs will take its images from.";

			internal const string g = "Indicates the amount in pixels that the tab's width should increase.";

			internal const string h = "Defines the inflation of both the tab width and tab height.";

			internal const string i = "Value must be greater than or equal to 0 and less than or equal to 100.";

			internal const string j = "Indicates the visual skin to be applied to the control.";

			internal const string k = "Only a VisualStudioTabPage can be added to a VisualStudioTabControl";

			internal const string l = "(Unselected)";

			internal const string m = "Add Tab";

			internal const string n = "Remove Tab";

			internal const string o = "TabPages";

			internal const string p = "SelectedTabChanged";

			internal const string q = "Behavior";

			internal const string r = "Appearance";

			[SpecialName]
			internal static Icon GetIcon()
			{
				byte[] buffer = new byte[1150]
				{
					0, 0, 1, 0, 1, 0, 16, 16, 0, 0,
					1, 0, 32, 0, 104, 4, 0, 0, 22, 0,
					0, 0, 40, 0, 0, 0, 16, 0, 0, 0,
					32, 0, 0, 0, 1, 0, 32, 0, 0, 0,
					0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
					0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
					0, 0, 255, 255, 255, 0, 255, 255, 255, 0,
					255, 255, 255, 0, 255, 255, 255, 0, 255, 255,
					255, 0, 255, 255, 255, 0, 255, 255, 255, 0,
					255, 255, 255, 0, 255, 255, 255, 0, 255, 255,
					255, 0, 255, 255, 255, 0, 255, 255, 255, 0,
					255, 255, 255, 0, 255, 255, 255, 0, 255, 255,
					255, 0, 255, 255, 255, 0, 255, 255, 255, 0,
					255, 255, 255, 0, 255, 255, 255, 0, 255, 255,
					255, 0, 255, 255, 255, 0, 255, 255, 255, 0,
					255, 255, 255, 0, 255, 255, 255, 0, 255, 255,
					255, 0, 255, 255, 255, 0, 255, 255, 255, 0,
					255, 255, 255, 0, 255, 255, 255, 0, 255, 255,
					255, 0, 255, 255, 255, 0, 255, 255, 255, 0,
					169, 113, 81, 169, 195, 142, 104, 255, 192, 139,
					102, 255, 190, 136, 100, 255, 187, 133, 97, 255,
					185, 131, 95, 255, 180, 126, 92, 255, 178, 124,
					90, 255, 177, 123, 88, 255, 174, 121, 87, 255,
					173, 118, 86, 255, 171, 117, 84, 255, 169, 115,
					83, 255, 169, 113, 81, 255, 169, 113, 81, 169,
					255, 255, 255, 0, 200, 146, 108, 255, 255, 255,
					255, 255, 255, 255, 255, 255, 255, 255, 255, 255,
					255, 255, 255, 255, 255, 255, 255, 255, 220, 167,
					123, 255, 255, 255, 255, 255, 255, 255, 255, 255,
					255, 255, 255, 255, 255, 255, 255, 255, 255, 255,
					255, 255, 255, 255, 255, 255, 255, 255, 255, 255,
					169, 114, 81, 255, 255, 255, 255, 0, 202, 148,
					110, 255, 255, 255, 255, 255, 255, 142, 43, 255,
					149, 149, 149, 255, 135, 135, 135, 255, 255, 255,
					255, 255, 220, 167, 123, 255, 255, 255, 255, 255,
					254, 254, 252, 255, 254, 254, 252, 255, 254, 254,
					250, 255, 254, 254, 250, 255, 252, 252, 249, 255,
					255, 255, 255, 255, 170, 115, 83, 255, 255, 255,
					255, 0, 204, 151, 111, 255, 255, 255, 255, 255,
					255, 255, 255, 255, 255, 255, 255, 255, 255, 255,
					255, 255, 255, 255, 255, 255, 220, 167, 123, 255,
					255, 255, 255, 255, 253, 253, 250, 255, 253, 253,
					250, 255, 253, 253, 250, 255, 252, 252, 247, 255,
					251, 251, 246, 255, 255, 255, 255, 255, 172, 117,
					84, 255, 255, 255, 255, 0, 209, 156, 115, 255,
					255, 255, 255, 255, 255, 158, 58, 255, 159, 159,
					159, 255, 153, 153, 153, 255, 255, 255, 255, 255,
					220, 167, 123, 255, 255, 255, 255, 255, 253, 253,
					248, 255, 251, 251, 249, 255, 251, 250, 247, 255,
					251, 250, 246, 255, 251, 248, 244, 255, 255, 255,
					255, 255, 176, 122, 88, 255, 255, 255, 255, 0,
					212, 158, 117, 255, 255, 255, 255, 255, 255, 255,
					255, 255, 255, 255, 255, 255, 255, 255, 255, 255,
					255, 255, 255, 255, 220, 167, 123, 255, 255, 255,
					255, 255, 251, 249, 247, 255, 251, 249, 245, 255,
					251, 248, 244, 255, 251, 247, 242, 255, 251, 245,
					242, 255, 255, 255, 255, 255, 178, 124, 90, 255,
					255, 255, 255, 0, 213, 160, 118, 255, 255, 255,
					255, 255, 255, 191, 104, 255, 175, 175, 175, 255,
					170, 170, 170, 255, 255, 255, 255, 255, 220, 167,
					123, 255, 255, 255, 255, 255, 251, 248, 244, 255,
					251, 247, 243, 255, 251, 245, 242, 255, 250, 243,
					239, 255, 248, 242, 236, 255, 255, 255, 255, 255,
					181, 126, 92, 255, 255, 255, 255, 0, 216, 162,
					121, 255, 255, 255, 255, 255, 255, 255, 255, 255,
					255, 255, 255, 255, 255, 255, 255, 255, 255, 255,
					255, 255, 220, 167, 123, 255, 255, 255, 255, 255,
					251, 246, 241, 255, 248, 244, 238, 255, 247, 242,
					235, 255, 247, 240, 234, 255, 246, 236, 232, 255,
					255, 255, 255, 255, 183, 129, 94, 255, 255, 255,
					255, 0, 217, 163, 121, 255, 255, 255, 255, 255,
					255, 191, 104, 255, 189, 189, 189, 255, 183, 183,
					183, 255, 255, 255, 255, 255, 220, 167, 123, 255,
					255, 255, 255, 255, 247, 243, 237, 255, 246, 239,
					234, 255, 245, 235, 231, 255, 243, 234, 228, 255,
					242, 231, 222, 255, 255, 255, 255, 255, 186, 133,
					96, 255, 255, 255, 255, 0, 219, 164, 122, 255,
					255, 255, 255, 255, 255, 255, 255, 255, 255, 255,
					255, 255, 255, 255, 255, 255, 255, 255, 255, 255,
					220, 167, 123, 255, 255, 255, 255, 255, 255, 255,
					255, 255, 255, 255, 255, 255, 255, 255, 255, 255,
					255, 255, 255, 255, 255, 255, 255, 255, 255, 255,
					255, 255, 189, 135, 99, 255, 255, 255, 255, 0,
					220, 167, 123, 255, 220, 167, 123, 255, 220, 167,
					123, 255, 220, 167, 123, 255, 220, 167, 123, 255,
					220, 167, 123, 255, 220, 167, 123, 255, 220, 167,
					123, 255, 220, 167, 123, 255, 220, 167, 123, 255,
					220, 167, 123, 255, 220, 167, 123, 255, 220, 167,
					123, 255, 220, 167, 123, 255, 192, 139, 102, 255,
					255, 255, 255, 0, 221, 172, 133, 253, 232, 185,
					146, 255, 232, 185, 146, 255, 232, 185, 146, 255,
					232, 185, 146, 255, 232, 185, 146, 255, 232, 185,
					146, 255, 232, 185, 146, 255, 232, 185, 146, 255,
					232, 185, 146, 255, 232, 185, 146, 255, 232, 185,
					146, 255, 232, 185, 146, 255, 232, 185, 146, 255,
					193, 144, 111, 253, 255, 255, 255, 0, 169, 113,
					81, 107, 221, 177, 141, 244, 220, 167, 123, 255,
					220, 166, 122, 255, 218, 164, 122, 255, 216, 162,
					121, 255, 213, 160, 118, 255, 212, 158, 117, 255,
					210, 157, 115, 255, 207, 154, 114, 255, 206, 153,
					112, 255, 203, 150, 111, 255, 201, 148, 108, 255,
					196, 154, 122, 244, 169, 113, 81, 107, 255, 255,
					255, 0, 255, 255, 255, 0, 255, 255, 255, 0,
					255, 255, 255, 0, 255, 255, 255, 0, 255, 255,
					255, 0, 255, 255, 255, 0, 255, 255, 255, 0,
					255, 255, 255, 0, 255, 255, 255, 0, 255, 255,
					255, 0, 255, 255, 255, 0, 255, 255, 255, 0,
					255, 255, 255, 0, 255, 255, 255, 0, 255, 255,
					255, 0, 255, 255, 255, 0, 255, 255, 0, 0,
					255, 255, 0, 0, 0, 1, 0, 0, 0, 1,
					0, 0, 0, 1, 0, 0, 0, 1, 0, 0,
					0, 1, 0, 0, 0, 1, 0, 0, 0, 1,
					0, 0, 0, 1, 0, 0, 0, 1, 0, 0,
					0, 1, 0, 0, 0, 1, 0, 0, 0, 1,
					0, 0, 128, 3, 0, 0, 255, 255, 0, 0
				};
				using (MemoryStream stream = new MemoryStream(buffer))
				{
					return new Icon(stream);
				}
			}
		}

		internal sealed class b : ParentControlDesigner
		{
			private IDesignerHost a;

			private ISelectionService m_b;

			private DesignerActionUIService c;

			private DesignerVerbCollection d;

			[SpecialName]
			public VisualStudioTabControl k()
			{
				return (VisualStudioTabControl)Control;
			}

			[SpecialName]
			public IDesignerHost j()
			{
				if (a == null)
				{
					a = (IDesignerHost)GetService(typeof(IDesignerHost));
				}
				return a;
			}

			[SpecialName]
			public ISelectionService i()
			{
				if (m_b == null)
				{
					m_b = (ISelectionService)GetService(typeof(ISelectionService));
				}
				return m_b;
			}

			[SpecialName]
			public DesignerActionUIService h()
			{
				if (c == null)
				{
					c = (DesignerActionUIService)GetService(typeof(DesignerActionUIService));
				}
				return c;
			}

			[SpecialName]
			public DesignerVerbCollection get_Verbs()
			{
				if (d.Count == 3)
				{
					if (k().TabPages.Count <= 0)
					{
						foreach (DesignerVerb item in d)
						{
							if (Operators.CompareString(item.Text, "Remove Tab", false) == 0)
							{
								item.Enabled = false;
								return d;
							}
						}
					}
					else
					{
						foreach (DesignerVerb item2 in d)
						{
							if (Operators.CompareString(item2.Text, "Remove Tab", false) == 0)
							{
								item2.Enabled = true;
								return d;
							}
						}
					}
				}
				return d;
			}

			public b()
			{
				a = null;
				m_b = null;
				d = new DesignerVerbCollection();
				d.AddRange(new DesignerVerb[2]
				{
					new DesignerVerb("Add Tab", g),
					new DesignerVerb("Remove Tab", f)
				});
			}

			private void g()
			{
				ControlCollection oldValue = k().Controls;
				RaiseComponentChanging(TypeDescriptor.GetProperties(k())["TabPages"]);
				VisualStudioTabPage visualStudioTabPage = (VisualStudioTabPage)j().CreateComponent(typeof(VisualStudioTabPage));
				visualStudioTabPage.Text = visualStudioTabPage.Name.Replace(typeof(VisualStudioTabPage).Name, "TabPage");
				visualStudioTabPage.Size = k().DefaultChildSize;
				k().TabPages.Add(visualStudioTabPage);
				RaiseComponentChanged(TypeDescriptor.GetProperties(k())["TabPages"], oldValue, k().TabPages);
				k().SelectedTabPage = visualStudioTabPage;
				f();
				i().SetSelectedComponents(new IComponent[1] { base.Component });
			}

			private void g(object A_0, EventArgs A_1)
			{
				g();
			}

			private void f(object A_0, EventArgs A_1)
			{
				if (k().SelectedTabPage != null)
				{
					ControlCollection oldValue = k().Controls;
					RaiseComponentChanging(TypeDescriptor.GetProperties(k())["TabPages"]);
					j().DestroyComponent(k().SelectedTabPage);
					i().SetSelectedComponents(new IComponent[1] { k() }, SelectionTypes.Auto);
					RaiseComponentChanged(TypeDescriptor.GetProperties(k())["TabPages"], oldValue, k().TabPages);
					f();
				}
			}

			private void f()
			{
				switch (k().TabPages.Count)
				{
				case 0:
				{
					foreach (DesignerVerb item in d)
					{
						if (Operators.CompareString(item.Text, "Remove Tab", false) == 0)
						{
							item.Enabled = false;
							break;
						}
					}
					break;
				}
				case 1:
				{
					foreach (DesignerVerb item2 in d)
					{
						if (Operators.CompareString(item2.Text, "Remove Tab", false) == 0)
						{
							item2.Enabled = true;
							break;
						}
					}
					break;
				}
				}
			}

			protected override bool GetHitTest(Point point)
			{
				Point clientCursorPosition = k().ClientCursorPosition;
				foreach (VisualStudioTabPage tabPage in k().TabPages)
				{
					if (!tabPage.Selected && tabPage.SideTabVisible && tabPage.SideTabClientRectangle.Contains(clientCursorPosition))
					{
						return true;
					}
				}
				return false;
			}

			protected override void PostFilterProperties(IDictionary properties)
			{
				properties.Remove("AutoScroll");
				properties.Remove("AutoScrollMargin");
				properties.Remove("AutoScrollMinSize");
				properties.Remove("Text");
				properties.Remove("BackColor");
				properties.Remove("BorderStyle");
				properties.Remove("RightToLeft");
				base.PostFilterProperties(properties);
			}

			public override void OnSetComponentDefaults()
			{
				int num = 0;
				do
				{
					g();
					num = checked(num + 1);
				}
				while (num <= 1);
				k().SelectedTabPage = (VisualStudioTabPage)k().TabPages[0];
			}
		}

		private class c : ReferenceConverter
		{
			public c()
				: base(typeof(VisualStudioTabPage))
			{
			}

			protected override bool IsValueAllowed(ITypeDescriptorContext context, object value)
			{
				if (context != null && value != null)
				{
					VisualStudioTabControl visualStudioTabControl = (VisualStudioTabControl)context.Instance;
					return visualStudioTabControl.TabPages.Contains((VisualStudioTabPage)value);
				}
				return base.IsValueAllowed(context, RuntimeHelpers.GetObjectValue(value));
			}
		}

		private class d : StringConverter
		{
			public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
			{
				VisualStudioTabPage visualStudioTabPage = context.Instance as VisualStudioTabPage;
				if (visualStudioTabPage != null)
				{
					VisualStudioTabControl owner = visualStudioTabPage.Owner;
					if (owner != null)
					{
						if (owner.ImageList != null)
						{
							List<string> list = new List<string>(checked(owner.ImageList.Images.Keys.Count + 1));
							StringEnumerator enumerator = owner.ImageList.Images.Keys.GetEnumerator();
							while (enumerator.MoveNext())
							{
								string current = enumerator.Current;
								list.Add(current);
							}
							list.Add(string.Empty);
							return new StandardValuesCollection(list);
						}
						return new StandardValuesCollection(new string[1] { string.Empty });
					}
				}
				return base.GetStandardValues(context);
			}

			public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
			{
				return (object)sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
			}

			public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
			{
				if (value is string)
				{
					return value.ToString();
				}
				if (value == null)
				{
					return string.Empty;
				}
				return base.ConvertFrom(context, culture, RuntimeHelpers.GetObjectValue(value));
			}

			public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
			{
				if ((object)destinationType == null)
				{
					throw new ArgumentNullException("destinationType");
				}
				if (value is string && Operators.CompareString(value.ToString(), string.Empty, false) == 0)
				{
					return "(none)";
				}
				if ((object)destinationType == typeof(string) && value == null)
				{
					return "(none)";
				}
				return base.ConvertTo(context, culture, RuntimeHelpers.GetObjectValue(value), destinationType);
			}

			public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
			{
				return true;
			}

			public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
			{
				return true;
			}
		}

		private class e : UITypeEditor
		{
			private UITypeEditor m_a;

			public e()
			{
				this.m_a = (UITypeEditor)TypeDescriptor.GetEditor(typeof(Image), typeof(UITypeEditor));
			}

			[SpecialName]
			protected UITypeEditor a()
			{
				return this.m_a;
			}

			public override bool GetPaintValueSupported(ITypeDescriptorContext context)
			{
				return this.m_a != null && this.m_a.GetPaintValueSupported(context);
			}

			public override void PaintValue(PaintValueEventArgs e)
			{
				if (this.m_a != null)
				{
					Image image = null;
					if (e.Value is string)
					{
						image = a(e.Context, e.Value.ToString());
					}
					if (image != null)
					{
						this.m_a.PaintValue(new PaintValueEventArgs(e.Context, image, e.Graphics, e.Bounds));
					}
				}
			}

			protected virtual Image a(ITypeDescriptorContext A_0, string A_1)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(A_0.Instance);
				ImageList imageList = null;
				if (objectValue != null && objectValue is VisualStudioTabPage)
				{
					objectValue = ((VisualStudioTabPage)objectValue).Owner;
					if (objectValue != null)
					{
						imageList = (ImageList)TypeDescriptor.GetProperties(RuntimeHelpers.GetObjectValue(objectValue))["ImageList"].GetValue(RuntimeHelpers.GetObjectValue(objectValue));
						if (imageList != null)
						{
							return imageList.Images[A_1];
						}
					}
				}
				return null;
			}
		}

		private class f : CollectionEditor
		{
			[SpecialName]
			public virtual bool get_IsDropDownResizable()
			{
				return true;
			}

			public f(Type A_0)
				: base(A_0)
			{
			}

			protected override Type CreateCollectionItemType()
			{
				return typeof(VisualStudioTabPage);
			}

			protected override object CreateInstance(Type itemType)
			{
				if ((object)itemType == typeof(VisualStudioTabPage))
				{
					IDesignerHost designerHost = GetService(typeof(IDesignerHost)) as IDesignerHost;
					if (designerHost != null)
					{
						VisualStudioTabPage visualStudioTabPage = (VisualStudioTabPage)designerHost.CreateComponent(typeof(VisualStudioTabPage));
						VisualStudioTabControl visualStudioTabControl = base.Context.Instance as VisualStudioTabControl;
						visualStudioTabPage.Text = visualStudioTabPage.Name.Replace(typeof(VisualStudioTabPage).Name, "TabPage");
						if (visualStudioTabControl != null)
						{
							visualStudioTabPage.Size = visualStudioTabControl.DefaultChildSize;
						}
						return visualStudioTabPage;
					}
				}
				return base.CreateInstance(itemType);
			}
		}

		private sealed class g : UITypeEditor
		{
			private class EditorForm : Form
			{
				private IContainer m_a;

				[CompilerGenerated]
				[DebuggerBrowsable(DebuggerBrowsableState.Never)]
				private PropertyGrid m_b;

				[CompilerGenerated]
				[DebuggerBrowsable(DebuggerBrowsableState.Never)]
				private Panel m_c;

				[CompilerGenerated]
				[DebuggerBrowsable(DebuggerBrowsableState.Never)]
				private Button m_d;

				[CompilerGenerated]
				[DebuggerBrowsable(DebuggerBrowsableState.Never)]
				private Button m_e;

				[CompilerGenerated]
				[DebuggerBrowsable(DebuggerBrowsableState.Never)]
				private SplitContainer f;

				private VisualStudioTabControlSkin m_g;

				[SpecialName]
				[CompilerGenerated]
				internal virtual PropertyGrid c()
				{
					return this.m_b;
				}

				[MethodImpl(MethodImplOptions.Synchronized)]
				[SpecialName]
				[CompilerGenerated]
				internal virtual void a(PropertyGrid A_0)
				{
					PropertyValueChangedEventHandler value = a;
					PropertyGrid propertyGrid = this.m_b;
					if (propertyGrid != null)
					{
						propertyGrid.PropertyValueChanged -= value;
					}
					this.m_b = A_0;
					propertyGrid = this.m_b;
					if (propertyGrid != null)
					{
						propertyGrid.PropertyValueChanged += value;
					}
				}

				[SpecialName]
				[CompilerGenerated]
				internal virtual Panel d()
				{
					return this.m_c;
				}

				[MethodImpl(MethodImplOptions.Synchronized)]
				[SpecialName]
				[CompilerGenerated]
				internal virtual void a(Panel A_0)
				{
					EventHandler value = a;
					PaintEventHandler value2 = a;
					Panel panel = this.m_c;
					if (panel != null)
					{
						panel.SizeChanged -= value;
						panel.Paint -= value2;
					}
					this.m_c = A_0;
					panel = this.m_c;
					if (panel != null)
					{
						panel.SizeChanged += value;
						panel.Paint += value2;
					}
				}

				[SpecialName]
				[CompilerGenerated]
				internal virtual Button e()
				{
					return this.m_d;
				}

				[MethodImpl(MethodImplOptions.Synchronized)]
				[SpecialName]
				[CompilerGenerated]
				internal virtual void a(Button A_0)
				{
					this.m_d = A_0;
				}

				[SpecialName]
				[CompilerGenerated]
				internal virtual Button g()
				{
					return this.m_e;
				}

				[MethodImpl(MethodImplOptions.Synchronized)]
				[SpecialName]
				[CompilerGenerated]
				internal virtual void b(Button A_0)
				{
					this.m_e = A_0;
				}

				[SpecialName]
				[CompilerGenerated]
				internal virtual SplitContainer h()
				{
					return f;
				}

				[MethodImpl(MethodImplOptions.Synchronized)]
				[SpecialName]
				[CompilerGenerated]
				internal virtual void a(SplitContainer A_0)
				{
					SplitterEventHandler value = a;
					SplitContainer splitContainer = f;
					if (splitContainer != null)
					{
						splitContainer.SplitterMoved -= value;
					}
					f = A_0;
					splitContainer = f;
					if (splitContainer != null)
					{
						splitContainer.SplitterMoved += value;
					}
				}

				[SpecialName]
				public VisualStudioTabControlSkin b()
				{
					return this.m_g;
				}

				[SpecialName]
				public void a(VisualStudioTabControlSkin A_0)
				{
					this.m_g = A_0;
				}

				public EditorForm(VisualStudioTabControl A_0)
				{
					this.m_g = A_0.Skin.Clone();
					a();
					c().SelectedObject = this.m_g;
					c().Select();
					SetStyle(ControlStyles.AllPaintingInWmPaint, true);
					SetStyle(ControlStyles.ResizeRedraw, true);
					SetStyle(ControlStyles.UserPaint, true);
					SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
				}

				private void a(object A_0, EventArgs A_1)
				{
					d().Invalidate();
				}

				private void a(object A_0, PaintEventArgs A_1)
				{
					a(A_1);
					e(A_1);
					d(A_1);
					c(A_1);
					b(A_1);
				}

				protected override void OnSizeChanged(EventArgs e)
				{
					base.OnSizeChanged(e);
					Invalidate();
				}

				protected void e(PaintEventArgs A_0)
				{
					Graphics graphics = A_0.Graphics;
					graphics.SmoothingMode = SmoothingMode.HighQuality;
					Rectangle clientRectangle = d().ClientRectangle;
					checked
					{
						using (Pen pen = new Pen(this.m_g.TabControl.OuterBorderColor))
						{
							graphics.DrawArc(pen, 1, 0, 10, 10, 180, 90);
							graphics.DrawLine(pen, 6, 0, clientRectangle.Width - 1, 0);
							graphics.DrawLine(pen, clientRectangle.Width - 1, 0, clientRectangle.Width - 1, clientRectangle.Height - 1);
							graphics.DrawArc(pen, 1, 96, 9, 10, 90, 90);
							graphics.DrawArc(pen, 85, 128, 10, 10, -90, 90);
							graphics.DrawLine(pen, 95, clientRectangle.Height - 1, clientRectangle.Width - 1, clientRectangle.Height - 1);
							graphics.DrawLine(pen, 95, 134, 95, clientRectangle.Height - 1);
							graphics.DrawLine(pen, 1, 6, 1, 100);
							graphics.DrawLine(pen, 6, 107, 90, 128);
						}
						clientRectangle = new Rectangle(101, 6, clientRectangle.Width - 107, clientRectangle.Height - 12);
						using (Pen pen2 = new Pen(this.m_g.TabControl.InnerBorderColor))
						{
							A_0.Graphics.DrawRectangle(pen2, clientRectangle);
						}
						graphics = null;
					}
				}

				protected void d(PaintEventArgs A_0)
				{
					A_0.Graphics.SmoothingMode = SmoothingMode.None;
					int num = 0;
					int num2 = 6;
					bool flag = true;
					bool flag2 = false;
					bool flag3 = false;
					checked
					{
						while (true)
						{
							switch (num)
							{
							case 0:
								flag3 = true;
								break;
							case 1:
								flag2 = true;
								break;
							case 2:
								flag3 = false;
								flag2 = false;
								break;
							case 3:
								return;
							}
							if (this.m_g.TabControl.DividerSkin.DrawDividers)
							{
								switch (num)
								{
								case 0:
								{
									using (Pen pen2 = new Pen(this.m_g.TabControl.DividerSkin.BottomColor))
									{
										A_0.Graphics.DrawLine(pen2, 6, 5, 93, 5);
									}
									break;
								}
								case 2:
								{
									using (Pen pen = new Pen(this.m_g.TabControl.DividerSkin.TopColor))
									{
										A_0.Graphics.DrawLine(pen, 6, num2 + 32, 93, num2 + 32);
									}
									break;
								}
								}
								using (Pen pen3 = new Pen(this.m_g.TabControl.DividerSkin.TopColor))
								{
									A_0.Graphics.DrawLine(pen3, 6, num2, 93, num2);
								}
								using (Pen pen4 = new Pen(this.m_g.TabControl.DividerSkin.BottomColor))
								{
									A_0.Graphics.DrawLine(pen4, 6, num2 + 31, 93, num2 + 31);
								}
							}
							bool flag4 = true;
							if (flag4 == flag2)
							{
								using (Pen pen5 = new Pen(this.m_g.TabPage.MouseHoverTabPage.TabTipColor))
								{
									A_0.Graphics.DrawLine(pen5, 0, num2 + 2, 2, num2);
									A_0.Graphics.DrawLine(pen5, 0, num2 + 2, 0, num2 + 29);
									A_0.Graphics.DrawLine(pen5, 0, num2 + 29, 2, num2 + 31);
								}
								using (Pen pen6 = new Pen(this.m_g.TabPage.MouseHoverTabPage.TabBorderColor))
								{
									A_0.Graphics.DrawLine(pen6, 3, num2, 100, num2);
									A_0.Graphics.DrawLine(pen6, 3, num2 + 31, 100, num2 + 31);
								}
								using (Pen pen7 = new Pen(this.m_g.TabPage.MouseHoverTabPage.TabTipInnerColor))
								{
									A_0.Graphics.DrawLine(pen7, 1, num2 + 2, 1, num2 + 29);
									A_0.Graphics.DrawLine(pen7, 2, num2 + 1, 2, num2 + 30);
								}
								using (Pen pen8 = new Pen(this.m_g.TabPage.MouseHoverTabPage.TabRightBorderColor))
								{
									A_0.Graphics.DrawLine(pen8, 101, num2 + 1, 101, num2 + 30);
								}
								using (LinearGradientBrush linearGradientBrush = new LinearGradientBrush(new Rectangle(3, num2 + 1, 98, 30), this.m_g.TabPage.MouseHoverTabPage.GradientSettings.StartColor, this.m_g.TabPage.MouseHoverTabPage.GradientSettings.EndColor, this.m_g.TabPage.MouseHoverTabPage.GradientSettings.LinearGradientMode))
								{
									A_0.Graphics.FillRectangle(linearGradientBrush, linearGradientBrush.Rectangle);
								}
							}
							else if (flag4 == flag3)
							{
								using (Pen pen9 = new Pen(this.m_g.TabPage.SelectedTabPage.TabTipColor))
								{
									A_0.Graphics.DrawLine(pen9, 0, num2 + 2, 2, num2);
									A_0.Graphics.DrawLine(pen9, 0, num2 + 2, 0, num2 + 29);
									A_0.Graphics.DrawLine(pen9, 0, num2 + 29, 2, num2 + 31);
								}
								using (Pen pen10 = new Pen(this.m_g.TabPage.SelectedTabPage.TabBorderColor))
								{
									A_0.Graphics.DrawLine(pen10, 3, num2, 100, num2);
									A_0.Graphics.DrawLine(pen10, 3, num2 + 31, 100, num2 + 31);
								}
								using (Pen pen11 = new Pen(this.m_g.TabPage.SelectedTabPage.TabRightBorderColor))
								{
									A_0.Graphics.DrawLine(pen11, 101, num2 + 1, 101, num2 + 30);
								}
								using (Pen pen12 = new Pen(this.m_g.TabPage.SelectedTabPage.TabTipInnerColor))
								{
									A_0.Graphics.DrawLine(pen12, 1, num2 + 2, 1, num2 + 29);
									A_0.Graphics.DrawLine(pen12, 2, num2 + 1, 2, num2 + 30);
								}
								using (LinearGradientBrush linearGradientBrush2 = new LinearGradientBrush(new Rectangle(3, num2 + 1, 98, 30), this.m_g.TabPage.SelectedTabPage.GradientSettings.StartColor, this.m_g.TabPage.SelectedTabPage.GradientSettings.EndColor, this.m_g.TabPage.SelectedTabPage.GradientSettings.LinearGradientMode))
								{
									A_0.Graphics.FillRectangle(linearGradientBrush2, linearGradientBrush2.Rectangle);
								}
							}
							num2 += 32;
							num++;
						}
					}
				}

				protected void c(PaintEventArgs A_0)
				{
					Size size = default(Size);
					int i = 0;
					string text = null;
					int num = 6;
					checked
					{
						for (; i != 3; i++)
						{
							bool flag = true;
							if (flag == (i == 0))
							{
								text = "Selected";
								size = TextRenderer.MeasureText(text, this.m_g.TabPage.SelectedTabPage.FontSettings.Font);
								using (SolidBrush brush = new SolidBrush(this.m_g.TabPage.SelectedTabPage.FontSettings.FontColor))
								{
									A_0.Graphics.DrawString(text, this.m_g.TabPage.SelectedTabPage.FontSettings.Font, brush, 12f, (float)((double)num + (15.0 - (double)size.Height / 2.0)));
								}
							}
							else if (flag == (i == 1))
							{
								text = "Mouse Hover";
								size = TextRenderer.MeasureText(text, this.m_g.TabPage.MouseHoverTabPage.FontSettings.Font);
								using (SolidBrush brush2 = new SolidBrush(this.m_g.TabPage.MouseHoverTabPage.FontSettings.FontColor))
								{
									A_0.Graphics.DrawString(text, this.m_g.TabPage.MouseHoverTabPage.FontSettings.Font, brush2, 12f, (float)((double)num + (15.0 - (double)size.Height / 2.0)));
								}
							}
							else
							{
								text = "Unselected";
								size = TextRenderer.MeasureText(text, this.m_g.TabPage.UnselectedTabPage.FontSettings.Font);
								using (SolidBrush brush3 = new SolidBrush(this.m_g.TabPage.UnselectedTabPage.FontSettings.FontColor))
								{
									A_0.Graphics.DrawString(text, this.m_g.TabPage.UnselectedTabPage.FontSettings.Font, brush3, 12f, (float)((double)num + (15.0 - (double)size.Height / 2.0)));
								}
							}
							num += 32;
						}
					}
				}

				protected void b(PaintEventArgs A_0)
				{
					A_0.Graphics.SmoothingMode = SmoothingMode.None;
					Rectangle rect = new Rectangle(81, 108, 14, 14);
					Point[] points = new Point[3]
					{
						new Point(85, 115),
						new Point(88, 119),
						new Point(92, 115)
					};
					using (Pen pen = new Pen(this.m_g.TabControl.GlyphSkin.GlyphBorderColor))
					{
						A_0.Graphics.DrawRectangle(pen, rect);
					}
					using (SolidBrush brush = new SolidBrush(this.m_g.TabControl.GlyphSkin.GlyphHighlightColor))
					{
						A_0.Graphics.FillRectangle(brush, checked(new Rectangle(rect.X + 1, rect.Y + 1, 13, 13)));
					}
					using (SolidBrush brush2 = new SolidBrush(this.m_g.TabControl.GlyphSkin.GlyphColor))
					{
						A_0.Graphics.SmoothingMode = SmoothingMode.None;
						A_0.Graphics.FillRectangle(brush2, 85, 112, 7, 2);
						A_0.Graphics.FillPolygon(brush2, points);
						A_0.Graphics.SmoothingMode = SmoothingMode.HighQuality;
					}
				}

				protected void a(PaintEventArgs A_0)
				{
					A_0.Graphics.SmoothingMode = SmoothingMode.HighQuality;
					using (GraphicsPath graphicsPath = new GraphicsPath())
					{
						graphicsPath.AddLine(new PointF(4f, 0f), new PointF(base.Width, 0f));
						graphicsPath.AddLine(graphicsPath.GetLastPoint(), new PointF(base.Width, base.Height));
						graphicsPath.AddLine(graphicsPath.GetLastPoint(), new PointF(95f, base.Height));
						graphicsPath.AddLine(graphicsPath.GetLastPoint(), new PointF(95f, 129f));
						graphicsPath.AddLine(graphicsPath.GetLastPoint(), new PointF(93f, 129f));
						graphicsPath.AddLine(graphicsPath.GetLastPoint(), new PointF(6f, 107f));
						graphicsPath.AddLine(graphicsPath.GetLastPoint(), new PointF(4f, 107f));
						graphicsPath.AddLine(graphicsPath.GetLastPoint(), new PointF(1f, 103f));
						graphicsPath.AddLine(graphicsPath.GetLastPoint(), new PointF(0f, 4f));
						graphicsPath.CloseFigure();
						A_0.Graphics.SetClip(graphicsPath);
					}
					using (LinearGradientBrush linearGradientBrush = new LinearGradientBrush(new Rectangle(1, 0, 95, base.Height), this.m_g.TabPage.UnselectedTabPage.GradientSettings.StartColor, this.m_g.TabPage.UnselectedTabPage.GradientSettings.EndColor, this.m_g.TabPage.UnselectedTabPage.GradientSettings.LinearGradientMode))
					{
						A_0.Graphics.FillRectangle(linearGradientBrush, linearGradientBrush.Rectangle);
					}
					checked
					{
						using (SolidBrush brush = new SolidBrush(this.m_g.TabControl.OuterBackColor))
						{
							A_0.Graphics.FillRectangle(brush, new Rectangle(95, 0, base.Width - 96, base.Height - 1));
						}
						using (SolidBrush brush2 = new SolidBrush(this.m_g.TabControl.InnerBackColor))
						{
							A_0.Graphics.FillRectangle(brush2, new Rectangle(101, 6, d().ClientRectangle.Width - 107, d().ClientRectangle.Height - 12));
						}
						A_0.Graphics.ResetClip();
					}
				}

				private void a(object A_0, PropertyValueChangedEventArgs A_1)
				{
					d().Invalidate();
				}

				private void a(object A_0, SplitterEventArgs A_1)
				{
					d().Invalidate();
				}

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

				private void a()
				{
					a(new PropertyGrid());
					a(new Panel());
					a(new Button());
					b(new Button());
					a(new SplitContainer());
					h().Panel1.SuspendLayout();
					h().Panel2.SuspendLayout();
					h().SuspendLayout();
					SuspendLayout();
					c().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
					c().HelpVisible = false;
					c().Location = new Point(0, 0);
					c().Name = "PropertyGridSkin";
					c().Size = new Size(264, 171);
					c().TabIndex = 0;
					c().ToolbarVisible = false;
					d().Dock = DockStyle.Fill;
					d().Location = new Point(0, 0);
					d().Name = "PanelVisualStudioTabControlHost";
					d().Size = new Size(200, 200);
					d().TabIndex = 1;
					e().Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
					e().DialogResult = DialogResult.Cancel;
					e().Location = new Point(190, 177);
					e().Name = "ButtonCancel";
					e().Size = new Size(75, 23);
					e().TabIndex = 2;
					e().Text = "&Cancel";
					e().UseVisualStyleBackColor = true;
					g().Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
					g().DialogResult = DialogResult.OK;
					g().Location = new Point(109, 177);
					g().Name = "ButtonOK";
					g().Size = new Size(75, 23);
					g().TabIndex = 3;
					g().Text = "&OK";
					g().UseVisualStyleBackColor = true;
					h().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
					h().Location = new Point(12, 12);
					h().Name = "SplitContainerMain";
					h().Panel1.Controls.Add(d());
					h().Panel1MinSize = 200;
					h().Panel2.Controls.Add(c());
					h().Panel2.Controls.Add(g());
					h().Panel2.Controls.Add(e());
					h().Size = new Size(468, 200);
					h().Panel2MinSize = 200;
					h().SplitterDistance = 200;
					h().TabIndex = 4;
					base.AutoScaleDimensions = new SizeF(6f, 13f);
					base.AutoScaleMode = AutoScaleMode.Inherit;
					BackColor = SystemColors.Window;
					base.ClientSize = new Size(492, 224);
					base.Controls.Add(h());
					DoubleBuffered = true;
					base.Icon = VisualStudioTabControl.TabControlResources.GetIcon();
					base.MinimizeBox = false;
					base.MaximizeBox = false;
					Font = new Font("Tahoma", 7.5f);
					base.FormBorderStyle = FormBorderStyle.Sizable;
					MinimumSize = new Size(500, 250);
					base.Name = "VisualStudioTabControlSkinDesigner";
					base.SizeGripStyle = SizeGripStyle.Show;
					base.StartPosition = FormStartPosition.CenterScreen;
					Text = "VisualStudioTabControlSkinDesigner";
					h().Panel1.ResumeLayout(false);
					h().Panel2.ResumeLayout(false);
					h().ResumeLayout(false);
					ResumeLayout(false);
				}
			}

			public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
			{
				if (provider != null)
				{
					VisualStudioTabControl visualStudioTabControl = context.Instance as VisualStudioTabControl;
					IWindowsFormsEditorService windowsFormsEditorService = provider.GetService(typeof(IWindowsFormsEditorService)) as IWindowsFormsEditorService;
					if (windowsFormsEditorService == null)
					{
						return value;
					}
					if (visualStudioTabControl != null)
					{
						using (EditorForm editorForm = new EditorForm(visualStudioTabControl))
						{
							if (windowsFormsEditorService.ShowDialog(editorForm) != DialogResult.OK)
							{
								return visualStudioTabControl.Skin;
							}
							value = editorForm.b();
							context.OnComponentChanging();
							visualStudioTabControl.k = editorForm.b();
							visualStudioTabControl.Invalidate();
							context.OnComponentChanged();
						}
					}
				}
				return base.EditValue(context, provider, RuntimeHelpers.GetObjectValue(value));
			}

			public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
			{
				return UITypeEditorEditStyle.Modal;
			}
		}

		private IContainer m_a;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private EventHandler m_b;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private EventHandler m_c;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private EventHandler m_d;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private EventHandler m_e;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private EventHandler m_f;

		private ContextMenuStrip m_g;

		private VisualStudioTabPage h;

		private Size i;

		private ImageList j;

		private VisualStudioTabControlSkin k;

		[Editor(typeof(f), typeof(UITypeEditor))]
		[Category("Behavior")]
		[Description("The VisualStudioTabPages in the VisualStudioTabControl.")]
		public ControlCollection TabPages
		{
			get
			{
				return base.Controls;
			}
		}

		protected ContextMenuStrip TabDropDownMenuStrip
		{
			get
			{
				return this.m_g;
			}
		}

		protected Point ClientCursorPosition
		{
			get
			{
				return PointToClient(Cursor.Position);
			}
		}

		[Description("Gets or sets the selected VisualStudioTabPage.")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[TypeConverter(typeof(c))]
		[Category("Behavior")]
		public VisualStudioTabPage SelectedTabPage
		{
			get
			{
				return h;
			}
			set
			{
				if (value != null && !value.Enabled)
				{
					throw new ArgumentException();
				}
				bool flag = !object.Equals(value, h);
				Dictionary<string, int> dictionary = new Dictionary<string, int>();
				foreach (Control tabPage in TabPages)
				{
					VisualStudioTabPage visualStudioTabPage = tabPage as VisualStudioTabPage;
					if (visualStudioTabPage != null && Operators.CompareString(visualStudioTabPage.Name, string.Empty, false) != 0 && !dictionary.ContainsKey(visualStudioTabPage.Name))
					{
						dictionary.Add(visualStudioTabPage.Name, visualStudioTabPage.Index);
					}
				}
				foreach (VisualStudioTabPage tabPage2 in TabPages)
				{
					tabPage2.Visible = false;
				}
				h = value;
				if (h != null)
				{
					h.Visible = true;
				}
				foreach (KeyValuePair<string, int> item in dictionary)
				{
					if (Operators.CompareString(item.Key, string.Empty, false) != 0)
					{
						base.Controls.SetChildIndex(TabPages[item.Key], item.Value);
					}
				}
				if (flag)
				{
					OnSelectedTabChanged(EventArgs.Empty);
				}
				Invalidate();
			}
		}

		[Browsable(false)]
		[Description("Gets the amount of VisualStudioTabPages.")]
		public int TabCount
		{
			get
			{
				return TabPages.Count;
			}
		}

		[Browsable(false)]
		public int SelectedIndex
		{
			get
			{
				if (SelectedTabPage != null)
				{
					return SelectedTabPage.Index;
				}
				return -1;
			}
		}

		[Browsable(false)]
		public Size DefaultChildSize
		{
			get
			{
				Size result = checked(new Size(base.Width - 107 - Inflation.Width, base.Height - 12));
				return result;
			}
		}

		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override Color BackColor
		{
			get
			{
				return Color.Transparent;
			}
			set
			{
				base.BackColor = value;
			}
		}

		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new BorderStyle BorderStyle
		{
			get
			{
				return BorderStyle.None;
			}
			set
			{
				base.BorderStyle = value;
			}
		}

		[Description("Defines the inflation of both the tab width and tab height.")]
		[DefaultValue(typeof(Size), "0, 0")]
		[Category("Appearance")]
		public Size Inflation
		{
			get
			{
				return i;
			}
			set
			{
				if (value.Width < 0 || value.Width > 100)
				{
					throw new ArgumentException("Value must be greater than or equal to 0 and less than or equal to 100.");
				}
				if (value.Height < 0 || value.Height > 100)
				{
					throw new ArgumentException("Value must be greater than or equal to 0 and less than or equal to 100.");
				}
				bool flag = !object.Equals(value, i);
				i = value;
				if (flag)
				{
					OnInflationChanged(EventArgs.Empty);
				}
			}
		}

		[Category("Appearance")]
		[Description("Indicates the ImageList object that this control's tabs will take its images from.")]
		[DefaultValue(typeof(ImageList), null)]
		public ImageList ImageList
		{
			get
			{
				return j;
			}
			set
			{
				j = value;
				if (j != null)
				{
					return;
				}
				foreach (VisualStudioTabPage tabPage in TabPages)
				{
					tabPage.ImageKey = null;
				}
			}
		}

		protected bool TabDropDownIsShown
		{
			get
			{
				return MaxShowableTabIndex < TabPages.Count;
			}
		}

		protected int MinimumTabDraw
		{
			get
			{
				if (MaxShowableTabIndex > TabCount)
				{
					return TabCount;
				}
				return MaxShowableTabIndex;
			}
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Bindable(false)]
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override RightToLeft RightToLeft
		{
			get
			{
				return base.RightToLeft;
			}
			set
			{
				base.RightToLeft = value;
			}
		}

		protected int MaxShowableTabIndex
		{
			get
			{
				return checked((int)Math.Floor((double)(base.Height - 38) / (double)(36 + Inflation.Height)));
			}
		}

		[Browsable(false)]
		[DefaultValue(typeof(Size), "300, 150")]
		public sealed override Size MinimumSize
		{
			get
			{
				return base.MinimumSize;
			}
			set
			{
				if (value.Height >= 150 && value.Width >= 300)
				{
					base.MinimumSize = value;
				}
			}
		}

		protected sealed override Size DefaultSize
		{
			get
			{
				return new Size(300, 300);
			}
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Description("Indicates the visual skin to be applied to the control.")]
		[Editor(typeof(g), typeof(UITypeEditor))]
		[Category("Appearance")]
		public virtual VisualStudioTabControlSkin Skin
		{
			get
			{
				return k;
			}
		}

		public event EventHandler SelectedTabChanged
		{
			[CompilerGenerated]
			add
			{
				EventHandler eventHandler = this.m_b;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange(ref this.m_b, value2, eventHandler2);
				}
				while ((object)eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler eventHandler = this.m_b;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange(ref this.m_b, value2, eventHandler2);
				}
				while ((object)eventHandler != eventHandler2);
			}
		}

		public event EventHandler SelectedIndexChanged
		{
			[CompilerGenerated]
			add
			{
				EventHandler eventHandler = this.m_c;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange(ref this.m_c, value2, eventHandler2);
				}
				while ((object)eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler eventHandler = this.m_c;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange(ref this.m_c, value2, eventHandler2);
				}
				while ((object)eventHandler != eventHandler2);
			}
		}

		public event EventHandler TabGlyphClicked
		{
			[CompilerGenerated]
			add
			{
				EventHandler eventHandler = this.m_d;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange(ref this.m_d, value2, eventHandler2);
				}
				while ((object)eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler eventHandler = this.m_d;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange(ref this.m_d, value2, eventHandler2);
				}
				while ((object)eventHandler != eventHandler2);
			}
		}

		public event EventHandler TabDropDownItemClicked
		{
			[CompilerGenerated]
			add
			{
				EventHandler eventHandler = this.m_e;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange(ref this.m_e, value2, eventHandler2);
				}
				while ((object)eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler eventHandler = this.m_e;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange(ref this.m_e, value2, eventHandler2);
				}
				while ((object)eventHandler != eventHandler2);
			}
		}

		public event EventHandler InflationChanged
		{
			[CompilerGenerated]
			add
			{
				EventHandler eventHandler = this.m_f;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange(ref this.m_f, value2, eventHandler2);
				}
				while ((object)eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler eventHandler = this.m_f;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange(ref this.m_f, value2, eventHandler2);
				}
				while ((object)eventHandler != eventHandler2);
			}
		}

		public VisualStudioTabControl()
		{
			this.m_a = null;
			this.m_g = null;
			h = null;
			i = Size.Empty;
			j = null;
			k = new VisualStudioTabControlSkin(this);
			a();
		}

		private void a()
		{
			this.m_a = new Container();
			MinimumSize = new Size(300, 150);
			SetStyle(ControlStyles.ResizeRedraw, true);
			SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
			SetStyle(ControlStyles.UserPaint, true);
			SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			k.TabPage.SelectedTabPage.GradientSettings.StartColor = Color.White;
			k.TabPage.SelectedTabPage.GradientSettings.EndColor = Color.FromArgb(240, 240, 240);
			k.TabPage.MouseHoverTabPage.TabRightBorderColor = Color.FromArgb(131, 151, 162);
		}

		private void a(VisualStudioTabPage A_0)
		{
			if (!base.DesignMode)
			{
				return;
			}
			IComponentChangeService componentChangeService = GetService(typeof(IComponentChangeService)) as IComponentChangeService;
			if (componentChangeService != null)
			{
				componentChangeService.OnComponentChanging(this, TypeDescriptor.GetProperties(this)["SelectedTab"]);
				ISelectionService selectionService = Site.GetService(typeof(ISelectionService)) as ISelectionService;
				if (selectionService != null)
				{
					selectionService.SetSelectedComponents(new IComponent[1] { A_0 });
				}
				componentChangeService.OnComponentChanged(this, TypeDescriptor.GetProperties(this)["SelectedTab"], null, null);
			}
		}

		private void a(object A_0, EventArgs A_1)
		{
			if (!base.DesignMode)
			{
				return;
			}
			ISelectionService selectionService = GetService(typeof(ISelectionService)) as ISelectionService;
			if (selectionService != null)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(selectionService.PrimarySelection);
				if (objectValue is VisualStudioTabPage)
				{
					SelectedTabPage = (VisualStudioTabPage)objectValue;
				}
			}
		}

		protected override void InitLayout()
		{
			base.InitLayout();
			if (base.DesignMode)
			{
				ISelectionService selectionService = GetService(typeof(ISelectionService)) as ISelectionService;
				if (selectionService != null)
				{
					selectionService.SelectionChanged += a;
				}
				return;
			}
			int num = -1;
			if (TabPages.Count > 0)
			{
				num = 0;
				int num2 = num;
				while (!TabPages[num].Enabled)
				{
					num = checked(num + 1);
					if (num >= TabPages.Count)
					{
						num = 0;
					}
					if (num == num2)
					{
						num = -1;
						break;
					}
				}
			}
			if (num == -1)
			{
				SelectedTabPage = null;
			}
			else
			{
				SelectedTabPage = (VisualStudioTabPage)TabPages[num];
			}
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (this.m_a != null)
				{
					this.m_a.Dispose();
				}
				if (k != null)
				{
					k.Dispose();
					k = null;
				}
			}
			base.Dispose(disposing);
		}

		protected virtual void OnSelectedTabChanged(EventArgs e)
		{
			EventHandler eventHandler = this.m_b;
			if (eventHandler != null)
			{
				eventHandler(this, e);
			}
			OnSelectedIndexChanged(EventArgs.Empty);
		}

		protected virtual void OnSelectedIndexChanged(EventArgs e)
		{
			EventHandler eventHandler = this.m_c;
			if (eventHandler != null)
			{
				eventHandler(this, e);
			}
		}

		protected override void OnSizeChanged(EventArgs e)
		{
			base.OnSizeChanged(e);
			if (TabCount <= 0)
			{
				return;
			}
			foreach (VisualStudioTabPage tabPage in TabPages)
			{
				if (Inflation.Width == 0)
				{
					tabPage.Location = new Point(101, 6);
				}
				else
				{
					tabPage.Location = new Point(checked(101 + Inflation.Width), 6);
				}
				tabPage.Size = DefaultChildSize;
			}
		}

		protected virtual void OnTabGlyphClicked(EventArgs e)
		{
			EventHandler eventHandler = this.m_d;
			if (eventHandler != null)
			{
				eventHandler(this, e);
			}
		}

		protected override void OnControlAdded(ControlEventArgs e)
		{
			if (!(e.Control is VisualStudioTabPage))
			{
				throw new ArgumentException("Only a VisualStudioTabPage can be added to a VisualStudioTabControl");
			}
			if (h != null)
			{
				h.Visible = false;
			}
			h = (VisualStudioTabPage)e.Control;
			h.Visible = true;
			a(h);
			base.OnControlAdded(e);
			Invalidate();
		}

		protected override void OnControlRemoved(ControlEventArgs e)
		{
			if (e.Control is VisualStudioTabPage)
			{
				if (TabPages.Count > 0)
				{
					SelectedTabPage = (VisualStudioTabPage)TabPages[0];
				}
				else
				{
					SelectedTabPage = null;
				}
				base.OnControlRemoved(e);
				Invalidate();
			}
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			OnDrawFillGradient(e);
			OnDrawBorder(e);
			OnDrawTabs(e);
			OnDrawTabContent(e);
			OnDrawTabDropDown(e);
		}

		protected virtual void OnInflationChanged(EventArgs e)
		{
			if (TabCount > 0)
			{
				foreach (VisualStudioTabPage tabPage in TabPages)
				{
					if (Inflation.Width == 0)
					{
						tabPage.Location = new Point(101, 6);
					}
					else
					{
						tabPage.Location = new Point(checked(101 + Inflation.Width), 6);
					}
					tabPage.Size = DefaultChildSize;
				}
			}
			Invalidate();
			EventHandler eventHandler = this.m_f;
			if (eventHandler != null)
			{
				eventHandler(this, e);
			}
		}

		protected virtual void OnDrawBorder(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			int minimumTabDraw = MinimumTabDraw;
			checked
			{
				int num = 32 + Inflation.Height;
				graphics.SmoothingMode = SmoothingMode.HighQuality;
				using (Pen pen = new Pen(Skin.TabControl.OuterBorderColor))
				{
					graphics.DrawArc(pen, 1, 0, 10, 10, 180, 90);
					graphics.DrawLine(pen, 6, 0, base.ClientRectangle.Width - 1, 0);
					graphics.DrawLine(pen, base.ClientRectangle.Width - 1, 0, base.ClientRectangle.Width - 1, base.ClientRectangle.Height - 1);
					graphics.DrawArc(pen, 1, num * minimumTabDraw, 9, 10, 90, 90);
					graphics.DrawLine(pen, 1, 6, 1, num * minimumTabDraw + 4);
					graphics.DrawArc(pen, 85 + Inflation.Width, num * minimumTabDraw + 35, 10, 10, -90, 90);
					graphics.DrawLine(pen, 95 + Inflation.Width, base.ClientRectangle.Height - 1, base.ClientRectangle.Width - 1, base.ClientRectangle.Height - 1);
					graphics.DrawLine(pen, 95 + Inflation.Width, num * minimumTabDraw + 41, 95 + Inflation.Width, base.ClientRectangle.Height - 1);
					graphics.DrawLine(pen, 6, num * minimumTabDraw + 11, 90 + Inflation.Width, num * minimumTabDraw + 35);
				}
				if (SelectedTabPage == null && base.DesignMode)
				{
					using (Pen pen2 = new Pen(Skin.TabControl.InnerBorderColor))
					{
						graphics.SmoothingMode = SmoothingMode.None;
						pen2.DashStyle = DashStyle.Dot;
						graphics.DrawRectangle(pen2, new Rectangle(101 + Inflation.Width, 6, base.Width - 108 - Inflation.Width, base.Height - 13));
						graphics.SmoothingMode = SmoothingMode.HighQuality;
					}
					using (SolidBrush brush = new SolidBrush(ForeColor))
					{
						using (Font font = new Font("Tahoma", 7.5f, FontStyle.Italic))
						{
							graphics.DrawString("(Unselected)", font, brush, (float)((double)base.Width / 2.0) + 35f, (float)((double)base.Height / 2.0) - 3f);
						}
					}
				}
				else if (SelectedTabPage == null && !base.DesignMode)
				{
					using (Pen pen3 = new Pen(Skin.TabControl.InnerBorderColor))
					{
						graphics.SmoothingMode = SmoothingMode.None;
						graphics.DrawRectangle(pen3, new Rectangle(101 + Inflation.Width, 6, base.Width - 108 - Inflation.Width, base.Height - 13));
						graphics.SmoothingMode = SmoothingMode.HighQuality;
					}
				}
				graphics = null;
			}
		}

		protected virtual void OnDrawFillGradient(PaintEventArgs e)
		{
			e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
			int minimumTabDraw = MinimumTabDraw;
			checked
			{
				int num = 32 + Inflation.Height;
				using (GraphicsPath graphicsPath = new GraphicsPath())
				{
					graphicsPath.AddLine(new PointF(4f, 0f), new PointF(base.Width, 0f));
					graphicsPath.AddLine(graphicsPath.GetLastPoint(), new PointF(base.Width, base.Height));
					graphicsPath.AddLine(graphicsPath.GetLastPoint(), new PointF(95 + Inflation.Width, base.Height));
					graphicsPath.AddLine(graphicsPath.GetLastPoint(), new PointF(95 + Inflation.Width, num * minimumTabDraw + 38));
					graphicsPath.AddLine(graphicsPath.GetLastPoint(), new PointF(93 + Inflation.Width, num * minimumTabDraw + 36));
					graphicsPath.AddLine(graphicsPath.GetLastPoint(), new PointF(6f, num * minimumTabDraw + 11));
					graphicsPath.AddLine(graphicsPath.GetLastPoint(), new PointF(4f, minimumTabDraw * num + 11));
					graphicsPath.AddLine(graphicsPath.GetLastPoint(), new PointF(1f, 7 + minimumTabDraw * num));
					graphicsPath.AddLine(graphicsPath.GetLastPoint(), new PointF(0f, 4f));
					graphicsPath.CloseFigure();
					e.Graphics.SetClip(graphicsPath);
				}
				using (LinearGradientBrush linearGradientBrush = new LinearGradientBrush(new Rectangle(1, 0, 95 + Inflation.Width, base.Height), Skin.TabPage.UnselectedTabPage.GradientSettings.StartColor, Skin.TabPage.UnselectedTabPage.GradientSettings.EndColor, Skin.TabPage.UnselectedTabPage.GradientSettings.LinearGradientMode))
				{
					e.Graphics.FillRectangle(linearGradientBrush, linearGradientBrush.Rectangle);
				}
				using (SolidBrush brush = new SolidBrush(Skin.TabControl.OuterBackColor))
				{
					e.Graphics.FillRectangle(brush, new Rectangle(95 + Inflation.Width, 0, base.Width - 96, base.Height - 1));
				}
				e.Graphics.ResetClip();
			}
		}

		protected virtual void OnDrawTabs(PaintEventArgs e)
		{
			e.Graphics.SmoothingMode = SmoothingMode.None;
			int i = 0;
			int minimumTabDraw = MinimumTabDraw;
			int num = 0;
			bool flag = true;
			VisualStudioTabPage visualStudioTabPage = null;
			bool flag2 = false;
			checked
			{
				int num2 = 32 + Inflation.Height;
				int num3 = 31 + Inflation.Height;
				for (; i != minimumTabDraw; i++)
				{
					visualStudioTabPage = (VisualStudioTabPage)TabPages[i];
					num = visualStudioTabPage.SideTabClientRectangle.Y;
					flag2 = visualStudioTabPage.SideTabClientRectangle.Contains(ClientCursorPosition);
					if (Skin.TabControl.DividerSkin.DrawDividers)
					{
						if (i == 0)
						{
							using (Pen pen = new Pen(Skin.TabControl.DividerSkin.BottomColor))
							{
								e.Graphics.DrawLine(pen, 6, 5, 93 + Inflation.Width, 5);
							}
						}
						else if (i == minimumTabDraw - 1)
						{
							using (Pen pen2 = new Pen(Skin.TabControl.DividerSkin.TopColor))
							{
								e.Graphics.DrawLine(pen2, 6, num + num2, 93 + Inflation.Width, num + num2);
							}
						}
						using (Pen pen3 = new Pen(Skin.TabControl.DividerSkin.TopColor))
						{
							e.Graphics.DrawLine(pen3, 6, num, 93 + Inflation.Width, num);
						}
						using (Pen pen4 = new Pen(Skin.TabControl.DividerSkin.BottomColor))
						{
							e.Graphics.DrawLine(pen4, 6, num + num2 - 1, 93 + Inflation.Width, num + num2 - 1);
						}
					}
					if (visualStudioTabPage.Enabled)
					{
						bool flag3 = true;
						if (flag3 == (flag2 && !base.DesignMode && SelectedTabPage != TabPages[i]))
						{
							using (Pen pen5 = new Pen(Skin.TabPage.MouseHoverTabPage.TabTipColor))
							{
								e.Graphics.DrawLine(pen5, 0, num + 2, 2, num);
								e.Graphics.DrawLine(pen5, 0, num + 2, 0, num + 29 + Inflation.Height);
								e.Graphics.DrawLine(pen5, 0, num + 29 + Inflation.Height, 2, num + 31 + Inflation.Height);
							}
							using (Pen pen6 = new Pen(Skin.TabPage.MouseHoverTabPage.TabBorderColor))
							{
								e.Graphics.DrawLine(pen6, 3, num, 100 + Inflation.Width, num);
								e.Graphics.DrawLine(pen6, 3, num + num3, 100 + Inflation.Width, num + num3);
							}
							using (Pen pen7 = new Pen(Skin.TabPage.MouseHoverTabPage.TabTipInnerColor))
							{
								e.Graphics.DrawLine(pen7, 1, num + 2, 1, num + 29 + Inflation.Height);
								e.Graphics.DrawLine(pen7, 2, num + 1, 2, num + 30 + Inflation.Height);
							}
							using (Pen pen8 = new Pen(Skin.TabPage.MouseHoverTabPage.TabRightBorderColor))
							{
								e.Graphics.DrawLine(pen8, 101 + Inflation.Width, num + 1, 101 + Inflation.Width, num + 30);
							}
							using (LinearGradientBrush linearGradientBrush = new LinearGradientBrush(new Rectangle(3, num + 1, 98 + Inflation.Width, 30 + Inflation.Height), Skin.TabPage.MouseHoverTabPage.GradientSettings.StartColor, Skin.TabPage.MouseHoverTabPage.GradientSettings.EndColor, Skin.TabPage.MouseHoverTabPage.GradientSettings.LinearGradientMode))
							{
								e.Graphics.FillRectangle(linearGradientBrush, linearGradientBrush.Rectangle);
							}
						}
						else if (flag3 == (SelectedTabPage == TabPages[i]))
						{
							using (Pen pen9 = new Pen(Skin.TabPage.SelectedTabPage.TabTipColor))
							{
								e.Graphics.DrawLine(pen9, 0, num + 2, 2, num);
								e.Graphics.DrawLine(pen9, 0, num + 2, 0, num + 29 + Inflation.Height);
								e.Graphics.DrawLine(pen9, 0, num + 29 + Inflation.Height, 2, num + num3);
							}
							using (Pen pen10 = new Pen(Skin.TabPage.SelectedTabPage.TabBorderColor))
							{
								e.Graphics.DrawLine(pen10, 3, num, 100 + Inflation.Width, num);
								e.Graphics.DrawLine(pen10, 3, num + num3, 100 + Inflation.Width, num + num3);
							}
							using (Pen pen11 = new Pen(Skin.TabPage.SelectedTabPage.TabRightBorderColor))
							{
								e.Graphics.DrawLine(pen11, 101 + Inflation.Width, num + 1, 101 + Inflation.Width, num + 30 + Inflation.Height);
							}
							using (LinearGradientBrush linearGradientBrush2 = new LinearGradientBrush(new Rectangle(2, num + 1, 99 + Inflation.Width, 30 + Inflation.Height), Skin.TabPage.SelectedTabPage.GradientSettings.StartColor, Skin.TabPage.SelectedTabPage.GradientSettings.EndColor, Skin.TabPage.SelectedTabPage.GradientSettings.LinearGradientMode))
							{
								e.Graphics.FillRectangle(linearGradientBrush2, linearGradientBrush2.Rectangle);
							}
							using (Pen pen12 = new Pen(Skin.TabPage.SelectedTabPage.TabTipInnerColor))
							{
								e.Graphics.DrawLine(pen12, 1, num + 2, 1, num + 29 + Inflation.Height);
								e.Graphics.DrawLine(pen12, 2, num + 1, 2, num + 30 + Inflation.Height);
							}
						}
					}
					visualStudioTabPage.Invalidate();
				}
			}
		}

		protected virtual void OnDrawTabContent(PaintEventArgs e)
		{
			Size size = default(Size);
			int i = 0;
			int minimumTabDraw = MinimumTabDraw;
			string text = null;
			PointF pointF = new PointF(12f, 0f);
			VisualStudioTabPage visualStudioTabPage = null;
			int num = 0;
			checked
			{
				for (; i != minimumTabDraw; i++)
				{
					num = 0;
					pointF.Y = ((VisualStudioTabPage)TabPages[i]).SideTabClientRectangle.Y + unchecked(Inflation.Height / 2);
					text = TabPages[i].Text;
					visualStudioTabPage = (VisualStudioTabPage)TabPages[i];
					if (!string.IsNullOrEmpty(visualStudioTabPage.ImageKey) && Operators.CompareString(visualStudioTabPage.ImageKey, "(none)", false) != 0 && j != null && j.Images.Keys.Contains(visualStudioTabPage.ImageKey))
					{
						Image image = j.Images[visualStudioTabPage.ImageKey];
						if (image != null)
						{
							num = image.Width - 4;
							Rectangle rectangle = new Rectangle(6, (int)Math.Round((double)pointF.Y + (double)image.Height / 2.0), 16, 16);
							if (visualStudioTabPage.Enabled)
							{
								e.Graphics.DrawImage(image, rectangle);
							}
							else
							{
								ImageAttributes imageAttributes = new ImageAttributes();
								ColorMatrix colorMatrix = new ColorMatrix(new float[5][]
								{
									new float[5] { 0.2125f, 0.2125f, 0.2125f, 0f, 0f },
									new float[5] { 0.2577f, 0.2577f, 0.2577f, 0f, 0f },
									new float[5] { 0.0361f, 0.0361f, 0.0361f, 0f, 0f },
									new float[5] { 0f, 0f, 0f, 1f, 0f },
									new float[5] { 0.38f, 0.38f, 0.38f, 0f, 1f }
								});
								imageAttributes.ClearColorKey();
								imageAttributes.SetColorMatrix(colorMatrix);
								e.Graphics.DrawImage(image, rectangle, 0, 0, rectangle.Width, rectangle.Height, GraphicsUnit.Pixel, imageAttributes);
							}
						}
					}
					VisualStudioTabControlSkin.VisualStudioTabControlFontSettings visualStudioTabControlFontSettings = null;
					VisualStudioTabControlSkin.TabPageSkin tabPage = Skin.TabPage;
					bool flag = true;
					if (flag == !visualStudioTabPage.Enabled)
					{
						visualStudioTabControlFontSettings = tabPage.UnselectedTabPage.FontSettings;
						size = TextRenderer.MeasureText(text, visualStudioTabControlFontSettings.Font);
						ControlPaint.DrawStringDisabled(layoutRectangle: new RectangleF(pointF.X + (float)num, (float)((double)pointF.Y + (15.0 - (double)size.Height / 2.0)), size.Width, size.Height), graphics: e.Graphics, s: text, font: visualStudioTabControlFontSettings.Font, color: Color.Transparent, format: StringFormat.GenericDefault);
					}
					else
					{
						bool flag2 = true;
						visualStudioTabControlFontSettings = ((flag2 == (SelectedTabPage == (VisualStudioTabPage)TabPages[i])) ? tabPage.SelectedTabPage.FontSettings : ((flag2 != (visualStudioTabPage.SideTabClientRectangle.Contains(ClientCursorPosition) && !base.DesignMode)) ? tabPage.UnselectedTabPage.FontSettings : tabPage.MouseHoverTabPage.FontSettings));
						size = TextRenderer.MeasureText(text, visualStudioTabControlFontSettings.Font);
						PointF pointF2 = new PointF(pointF.X + (float)num, (float)((double)pointF.Y + (15.0 - (double)size.Height / 2.0)));
						using (SolidBrush brush = new SolidBrush(visualStudioTabControlFontSettings.FontColor))
						{
							e.Graphics.DrawString(text, visualStudioTabControlFontSettings.Font, brush, pointF2.X, pointF2.Y);
						}
					}
					tabPage = null;
				}
			}
		}

		protected virtual void OnDrawTabDropDown(PaintEventArgs e)
		{
			e.Graphics.SmoothingMode = SmoothingMode.None;
			int minimumTabDraw = MinimumTabDraw;
			checked
			{
				int num = 32 + Inflation.Height;
				if (MaxShowableTabIndex >= TabPages.Count)
				{
					return;
				}
				Rectangle rect = new Rectangle(81 + Inflation.Width, num * minimumTabDraw + 12, 14, 14);
				Point[] points = new Point[3]
				{
					new Point(85 + Inflation.Width, num * minimumTabDraw + 19),
					new Point(88 + Inflation.Width, num * minimumTabDraw + 23),
					new Point(92 + Inflation.Width, num * minimumTabDraw + 19)
				};
				if (rect.Contains(ClientCursorPosition) && !base.DesignMode)
				{
					using (Pen pen = new Pen(Skin.TabControl.GlyphSkin.GlyphBorderColor))
					{
						e.Graphics.DrawRectangle(pen, rect);
					}
					using (SolidBrush brush = new SolidBrush(Skin.TabControl.GlyphSkin.GlyphHighlightColor))
					{
						e.Graphics.FillRectangle(brush, new Rectangle(rect.X + 1, rect.Y + 1, 13, 13));
					}
				}
				using (SolidBrush brush2 = new SolidBrush(Skin.TabControl.GlyphSkin.GlyphColor))
				{
					e.Graphics.SmoothingMode = SmoothingMode.None;
					e.Graphics.FillRectangle(brush2, 85 + Inflation.Width, num * minimumTabDraw + 16, 7, 2);
					e.Graphics.FillPolygon(brush2, points);
					e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
				}
			}
		}

		protected override void OnMouseMove(MouseEventArgs e)
		{
			base.OnMouseMove(e);
			Invalidate();
		}

		protected override void OnMouseEnter(EventArgs e)
		{
			base.OnMouseEnter(e);
			Invalidate();
		}

		protected override void OnMouseLeave(EventArgs e)
		{
			base.OnMouseLeave(e);
			Invalidate();
		}

		protected override void OnMouseClick(MouseEventArgs e)
		{
			base.OnMouseClick(e);
			Point clientCursorPosition = ClientCursorPosition;
			Rectangle rectangle = default(Rectangle);
			checked
			{
				int num = 32 + Inflation.Height;
				int minimumTabDraw = MinimumTabDraw;
				Rectangle rectangle2 = new Rectangle(81 + Inflation.Width, num * minimumTabDraw + 12, 14, 14);
				if (!rectangle2.Contains(clientCursorPosition) || !TabDropDownIsShown || base.DesignMode)
				{
					foreach (VisualStudioTabPage tabPage in TabPages)
					{
						if (tabPage.Enabled && tabPage.SideTabVisible && tabPage.SideTabClientRectangle.Contains(clientCursorPosition) && e.Button == MouseButtons.Left)
						{
							SelectedTabPage = (VisualStudioTabPage)TabPages[tabPage.Index];
							a(SelectedTabPage);
						}
					}
					return;
				}
				if (e.Button != MouseButtons.Left)
				{
					return;
				}
				if (this.m_g != null)
				{
					this.m_g.Dispose();
				}
				this.m_g = new ContextMenuStrip();
				ContextMenuStrip contextMenuStrip = this.m_g;
				foreach (VisualStudioTabPage tabPage2 in TabPages)
				{
					if (!tabPage2.SideTabVisible)
					{
						ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(tabPage2.Text, null, OnTabDropDownItemClicked);
						toolStripMenuItem.Tag = tabPage2.Index;
						contextMenuStrip.Items.Add(toolStripMenuItem);
					}
				}
				contextMenuStrip = null;
				OnTabGlyphClicked(EventArgs.Empty);
				this.m_g.Show(this, new Point(81 + Inflation.Width, num * minimumTabDraw + 27));
			}
		}

		protected virtual void OnTabDropDownItemClicked(object sender, EventArgs e)
		{
			int num = Conversions.ToInteger(((ToolStripMenuItem)sender).Tag);
			int index = ((VisualStudioTabPage)TabPages[checked(MinimumTabDraw - 1)]).Index;
			VisualStudioTabPage child = (VisualStudioTabPage)TabPages[num];
			base.Controls.SetChildIndex(TabPages[index], num);
			base.Controls.SetChildIndex(child, index);
			SelectedTabPage = (VisualStudioTabPage)TabPages[index];
			Invalidate();
			EventHandler eventHandler = this.m_e;
			if (eventHandler != null)
			{
				eventHandler(this, e);
			}
		}
	}
}
