using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Simple_Bot;

[StandardModule]
[HideModuleName]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal sealed class MyProject
{
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class FormCollection
	{
		[ThreadStatic]
		private static Hashtable m_a;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public About b;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public AboutBox1 c;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public frmMain d;

		[DebuggerHidden]
		private static TForm CreateInstance<TForm>(TForm instance) where TForm : Form, new()
		{
			if (instance == null || instance.IsDisposed)
			{
				if (FormCollection.m_a != null)
				{
					if (FormCollection.m_a.ContainsKey(typeof(TForm)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate"));
					}
				}
				else
				{
					FormCollection.m_a = new Hashtable();
				}
				FormCollection.m_a.Add(typeof(TForm), null);
				try
				{
					return new TForm();
				}
				catch (TargetInvocationException ex) when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					ProjectData.SetProjectError(ex);
					return ex.InnerException != null;
				}).Invoke())
				{
					string resourceString = Utils.GetResourceString("WinForms_SeeInnerException", ex.InnerException.Message);
					throw new InvalidOperationException(resourceString, ex.InnerException);
				}
				finally
				{
					FormCollection.m_a.Remove(typeof(TForm));
				}
			}
			return instance;
		}

		[DebuggerHidden]
		private void DisposeInstance<TForm>(ref TForm instance) where TForm : Form
		{
			instance.Dispose();
			instance = null;
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public FormCollection()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object o)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(o));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type j()
		{
			return typeof(FormCollection);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		[SpecialName]
		[DebuggerHidden]
		public About About
		{
			get
			{
				b = CreateInstance<About>(b);
				return b;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		public AboutBox1 AboutBox
		{
			get
			{
				c = CreateInstance<AboutBox1>(c);
				return c;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		public frmMain MainForm
		{
			get
			{
				d = CreateInstance<frmMain>(d);
				return d;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		public void g(About A_0)
		{
			if (A_0 != b)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				DisposeInstance(ref b);
			}
		}

		[SpecialName]
		[DebuggerHidden]
		public void g(AboutBox1 A_0)
		{
			if (A_0 != c)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				DisposeInstance(ref c);
			}
		}

		[SpecialName]
		[DebuggerHidden]
		public void g(frmMain A_0)
		{
			if (A_0 != d)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				DisposeInstance(ref d);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class WebServiceCollection
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object o)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(o));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type Type()
		{
			return typeof(WebServiceCollection);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static TService CreateInstance<TService>(TService instance) where TService : new()
		{
			if (instance == null)
			{
				return new TService();
			}
			return instance;
		}

		[DebuggerHidden]
		private void DisposeInstance<TService>(ref TService instance)
		{
			instance = default(TService);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public WebServiceCollection()
		{
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class ThreadSafeObjectProvider<T> where T : new()
	{
		[ThreadStatic]
		[CompilerGenerated]
		private static T m_a;

		[SpecialName]
		[DebuggerHidden]
		internal T GetInstance()
		{
			if (ThreadSafeObjectProvider<T>.m_a == null)
			{
				ThreadSafeObjectProvider<T>.m_a = new T();
			}
			return ThreadSafeObjectProvider<T>.m_a;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public ThreadSafeObjectProvider()
		{
		}
	}

	private static readonly ThreadSafeObjectProvider<AppComputer> m_a = new ThreadSafeObjectProvider<AppComputer>();

	private static readonly ThreadSafeObjectProvider<AppApplication> m_b = new ThreadSafeObjectProvider<AppApplication>();

	private static readonly ThreadSafeObjectProvider<User> m_c = new ThreadSafeObjectProvider<User>();

	private static ThreadSafeObjectProvider<FormCollection> m_d = new ThreadSafeObjectProvider<FormCollection>();

	private static readonly ThreadSafeObjectProvider<WebServiceCollection> m_e = new ThreadSafeObjectProvider<WebServiceCollection>();

	[SpecialName]
	[DebuggerHidden]
	internal static AppComputer Computer
	{
		get { return MyProject.m_a.GetInstance(); }
	}

	[SpecialName]
	[DebuggerHidden]
	internal static AppApplication Application
	{
		get { return MyProject.m_b.GetInstance(); }
	}

	[SpecialName]
	[DebuggerHidden]
	internal static User User
	{
		get { return MyProject.m_c.GetInstance(); }
	}

	[SpecialName]
	[DebuggerHidden]
	internal static FormCollection Forms
	{
		get { return MyProject.m_d.GetInstance(); }
	}

	[SpecialName]
	[DebuggerHidden]
	internal static WebServiceCollection WebServices
	{
		get { return MyProject.m_e.GetInstance(); }
	}
}
