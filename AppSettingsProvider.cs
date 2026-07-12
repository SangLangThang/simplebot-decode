using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Simple_Bot.My;

[HideModuleName]
[DebuggerNonUserCode]
[CompilerGenerated]
[StandardModule]
internal sealed class AppSettingsProvider
{
	[SpecialName]
	internal static MySettings Settings()
	{
		return MySettings.Default;
	}
}
