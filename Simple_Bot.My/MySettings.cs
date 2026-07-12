using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace Simple_Bot.My
{
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.3.0.0")]
	internal sealed class MySettings : ApplicationSettingsBase
	{
		private static MySettings m_a = (MySettings)SettingsBase.Synchronized(new MySettings());

		private static bool b;

		private static object c = RuntimeHelpers.GetObjectValue(new object());

		public static MySettings Default
		{
			get
			{
				if (!b)
				{
					object obj = c;
					ObjectFlowControl.CheckForSyncLockOnValueType(obj);
					bool lockTaken = false;
					try
					{
						Monitor.Enter(obj, ref lockTaken);
						if (!b)
						{
							MyProject.Application.Shutdown += a;
							b = true;
						}
					}
					finally
					{
						if (lockTaken)
						{
							Monitor.Exit(obj);
						}
					}
				}
				return MySettings.m_a;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[DebuggerNonUserCode]
		private static void a(object A_0, EventArgs A_1)
		{
			if (MyProject.Application.SaveMySettingsOnExit)
			{
				AppSettingsProvider.Settings().Save();
			}
		}
	}
}
