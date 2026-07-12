using System;
using System.Collections;
using System.Diagnostics;
using System.Net.Sockets;
using Microsoft.VisualBasic.CompilerServices;

namespace Simple_Bot
{
	public class Client
	{
		public int packetcount;

		public int packetcheck;

		public ArrayList packetsss1;

		public ArrayList packetsss2;

		public bool CheckDisconnect;

		public int DelayCheckDisconnect;

		public bool CheckDisconnect1;

		public int DelayCheckDisconnect1;

		public int Disconnected;

		public int Disconnected_checklogin;

		public byte[] _buffer;

		private string a;

		public Client(TcpClient clientSocket, string host, int port)
		{
			packetcount = 0;
			packetcheck = 1;
			packetsss1 = new ArrayList();
			packetsss2 = new ArrayList();
			CheckDisconnect = false;
			DelayCheckDisconnect = 0;
			CheckDisconnect1 = true;
			DelayCheckDisconnect1 = 0;
			Disconnected = 0;
			Disconnected_checklogin = 0;
			_buffer = new byte[8192];
			a = "";
			try
			{
				clientSocket.Connect(host, port);
				if (clientSocket.GetStream().CanRead)
				{
					byte[] array = API.hexstringtobyte("59E9ACADAD");
					clientSocket.GetStream().Write(array, 0, array.Length);
					clientSocket.GetStream().BeginRead(_buffer, 0, _buffer.Length, OnRecieve, clientSocket.GetStream());
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				clientSocket.Close();
				Disconnected = 1;
				ProjectData.ClearProjectError();
			}
		}

		public void OnRecieve(IAsyncResult ar)
		{
			checked
			{
				try
				{
					NetworkStream networkStream = (NetworkStream)ar.AsyncState;
					int num = networkStream.EndRead(ar);
					if (num > 0)
					{
						packetcount++;
						Array.Resize(ref _buffer, num);
						OnRecievepacket(_buffer);
						Array.Resize(ref _buffer, 8192);
					}
					else
					{
						networkStream.Close();
						Disconnected = 1;
					}
					try
					{
						networkStream.BeginRead(_buffer, 0, _buffer.Length, OnRecieve, networkStream);
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						networkStream.Close();
						Disconnected = 1;
						ProjectData.ClearProjectError();
					}
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					Disconnected = 1;
					StackTrace stackTrace = new StackTrace(true);
					stackTrace = new StackTrace(ex4, true);
					API.SaveToLog("[" + MyProject.Computer.Clock.LocalTime.ToString("hh:mm:ss") + " - OnRecieve] :" + ex4.Message + stackTrace.GetFrame(0).GetFileLineNumber() + "\r\n");
					ProjectData.ClearProjectError();
				}
			}
		}

		public void OnRecievepacket(byte[] packet)
		{
			string text = API.bytestohexstring(API.EncDec_byte(packet));
			if (a.Length > 0)
			{
				text = a + text;
				a = "";
			}
			text = text.Replace("F444", "#F444");
			string[] array = text.Split(new string[1] { "#" }, StringSplitOptions.None);
			checked
			{
				foreach (string text2 in array)
				{
					if (!text2.StartsWith("F444"))
					{
						continue;
					}
					if (text2.Length >= 8)
					{
						int num = API.HexToInt32(text2.Substring(4, 4));
						if (text2.Length >= 8 + num * 2)
						{
							switch (packetcheck)
							{
							case 1:
								packetsss1.Add(text2);
								break;
							case 2:
								packetsss2.Add(text2);
								break;
							}
						}
						else if (text2.Length < 8 + num * 2)
						{
							a = text2;
						}
					}
					else
					{
						a = text2;
					}
				}
			}
		}
	}
}
