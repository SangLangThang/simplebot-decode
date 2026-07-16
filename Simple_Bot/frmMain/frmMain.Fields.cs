using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Simple_Bot
{
	public partial class frmMain : Form
	{
		public delegate void load1FileDelegate(string[] FileNames);

		public delegate void load1File_botDelegate(string FileName, string _Name);

		[CompilerGenerated]
		internal sealed class LoadConfigClosure
		{
			public _ClientBot Bot;

			public LoadConfigClosure(LoadConfigClosure other)
			{
				if (other != null)
				{
					Bot = other.Bot;
				}
			}

			[SpecialName]
			[DebuggerHidden]
			internal void Run(object path)
			{
				Bot.LoadConfig(Conversions.ToString(path));
			}
		}

		[CompilerGenerated]
		internal sealed class LoadConfigThreadClosure
		{
			public _ClientBot Bot;

			public LoadConfigThreadClosure(LoadConfigThreadClosure other)
			{
				if (other != null)
				{
					Bot = other.Bot;
				}
			}

			[SpecialName]
			[DebuggerHidden]
			internal void Run(object typeArg)
			{
				Bot.LoadConfig_Thread((typeArg != null) ? ((API._Type_LoadConfig)typeArg) : default(API._Type_LoadConfig));
			}
		}

		public TreeView treeview1;

		public string[] SkillIni;

		public string[] PriestIni;

		public string[] Priest_XIni;

		public string[] DoorIni;

		public string[] MapIni;

		public string status;

		public int loaded;

		public const int MOD_ALT = 1;

		public const int MOD_SHIFT = 4;

		public const int MOD_CTRL = 2;

		public const int MOD_WIN = 8;

		public const int WM_HOTKEY = 786;

		public int team;
	}
}
