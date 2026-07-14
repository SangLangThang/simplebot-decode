using System;
using System.Diagnostics;
using Microsoft.VisualBasic.CompilerServices;

namespace Simple_Bot
{
	public partial class _ClientBot
	{
		// opcode 6: server sends this but the client never acted on it.
		private void HandleUnusedOpcode6(byte[] packet)
		{
		}

		// opcode 65
		private void HandleMiniGameToggle(byte[] packet)
		{
			try
			{
				switch (packet[5])
				{
				case 1:
					_MiniRuning = 1;
					_Mini_Status = "Bật";
					break;
				case 2:
					_MiniRuning = 0;
					_Mini_Status = "Tắt";
					break;
				case 3:
					break;
				case 7:
					if (packet[6] != 2)
					{
					}
					break;
				case 4:
				case 5:
				case 6:
					break;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				StackTrace stackTrace = new StackTrace(true);
				stackTrace = new StackTrace(ex2, true);
				API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - Update_H41] :" + ex2.Message + stackTrace.GetFrame(0).GetFileLineNumber() + "\r\n");
				ProjectData.ClearProjectError();
			}
		}
	}
}
