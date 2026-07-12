using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Simple_Bot.My.Resources
{
	[HideModuleName]
	[StandardModule]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
	[CompilerGenerated]
	internal sealed class Resources
	{
		private static ResourceManager a;

		private static CultureInfo b;

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (object.ReferenceEquals(a, null))
				{
					ResourceManager resourceManager = new ResourceManager("Simple_Bot.Resources", typeof(Resources).Assembly);
					a = resourceManager;
				}
				return a;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
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

		internal static Bitmap _1000
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("_1000", b));
				return (Bitmap)objectValue;
			}
		}

		internal static Bitmap _exit
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("_exit", b));
				return (Bitmap)objectValue;
			}
		}

		internal static Bitmap Arrow_L2
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("Arrow_L2", b));
				return (Bitmap)objectValue;
			}
		}

		internal static Bitmap Arrow_R2
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("Arrow_R2", b));
				return (Bitmap)objectValue;
			}
		}

		internal static Bitmap arrow_upBig1
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("arrow_upBig1", b));
				return (Bitmap)objectValue;
			}
		}

		internal static string Astrolabe
		{
			get
			{
				return ResourceManager.GetString("Astrolabe", b);
			}
		}

		internal static Bitmap background
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("background", b));
				return (Bitmap)objectValue;
			}
		}

		internal static Bitmap btn_AssignFight
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("btn_AssignFight", b));
				return (Bitmap)objectValue;
			}
		}

		internal static Bitmap btn_AssignRest
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("btn_AssignRest", b));
				return (Bitmap)objectValue;
			}
		}

		internal static Bitmap btnBack
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("btnBack", b));
				return (Bitmap)objectValue;
			}
		}

		internal static Bitmap Close
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("Close", b));
				return (Bitmap)objectValue;
			}
		}

		internal static Bitmap CloseDisabled
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("CloseDisabled", b));
				return (Bitmap)objectValue;
			}
		}

		internal static Bitmap CloseHot
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("CloseHot", b));
				return (Bitmap)objectValue;
			}
		}

		internal static Bitmap form_backpack
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("form_backpack", b));
				return (Bitmap)objectValue;
			}
		}

		internal static Bitmap icon_01
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("icon_01", b));
				return (Bitmap)objectValue;
			}
		}

		internal static Bitmap icon_02
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("icon_02", b));
				return (Bitmap)objectValue;
			}
		}

		internal static Bitmap icon_03
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("icon_03", b));
				return (Bitmap)objectValue;
			}
		}

		internal static Bitmap icon_04
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("icon_04", b));
				return (Bitmap)objectValue;
			}
		}

		internal static Bitmap icon_05
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("icon_05", b));
				return (Bitmap)objectValue;
			}
		}

		internal static Bitmap icon_07
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("icon_07", b));
				return (Bitmap)objectValue;
			}
		}

		internal static Bitmap icon_08
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("icon_08", b));
				return (Bitmap)objectValue;
			}
		}

		internal static Bitmap icon_open
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("icon_open", b));
				return (Bitmap)objectValue;
			}
		}

		internal static Bitmap icon_save
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("icon_save", b));
				return (Bitmap)objectValue;
			}
		}

		internal static string itemvnkoco
		{
			get
			{
				return ResourceManager.GetString("itemvnkoco", b);
			}
		}

		internal static string NpcOnMap
		{
			get
			{
				return ResourceManager.GetString("NpcOnMap", b);
			}
		}

		internal static string npcvnkoco
		{
			get
			{
				return ResourceManager.GetString("npcvnkoco", b);
			}
		}

		internal static string skillvn
		{
			get
			{
				return ResourceManager.GetString("skillvn", b);
			}
		}

		internal static string skillvnkoco
		{
			get
			{
				return ResourceManager.GetString("skillvnkoco", b);
			}
		}

		internal static string talkmenu
		{
			get
			{
				return ResourceManager.GetString("talkmenu", b);
			}
		}

		internal static string Texps
		{
			get
			{
				return ResourceManager.GetString("Texps", b);
			}
		}
	}
}
