using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class IniFile
{
	[DllImport("kernel32", CharSet = CharSet.Unicode, EntryPoint = "WritePrivateProfileStringW", ExactSpelling = true, SetLastError = true)]
	private static extern int WritePrivateProfileString([MarshalAs(UnmanagedType.VBByRefStr)] ref string A_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string A_1, [MarshalAs(UnmanagedType.VBByRefStr)] ref string A_2, [MarshalAs(UnmanagedType.VBByRefStr)] ref string A_3);

	[DllImport("kernel32", CharSet = CharSet.Unicode, EntryPoint = "GetPrivateProfileStringW", ExactSpelling = true, SetLastError = true)]
	private static extern int GetPrivateProfileString([MarshalAs(UnmanagedType.VBByRefStr)] ref string A_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string A_1, [MarshalAs(UnmanagedType.VBByRefStr)] ref string A_2, [MarshalAs(UnmanagedType.VBByRefStr)] ref string A_3, int A_4, [MarshalAs(UnmanagedType.VBByRefStr)] ref string A_5);

	public static void WriteString(string filePath, string section, string key, string value)
	{
		int num = WritePrivateProfileString(ref section, ref key, ref value, ref filePath);
	}

	public static string ReadString(string filePath, string section, string key, string defaultValue)
	{
		string A_4 = Strings.Space(1024);
		long num = GetPrivateProfileString(ref section, ref key, ref defaultValue, ref A_4, Strings.Len(A_4), ref filePath);
		if (num > 0)
		{
			return Strings.Left(A_4, checked((int)num));
		}
		return "";
	}

	public static string ReadStringOrEmpty(string filePath, string section, string key, string defaultValue)
	{
		return ReadString(filePath, section, key, defaultValue);
	}

	public static string ReadNumberString(string filePath, string section, string key, string defaultValue)
	{
		string A_4 = Strings.Space(1024);
		long num = GetPrivateProfileString(ref section, ref key, ref defaultValue, ref A_4, Strings.Len(A_4), ref filePath);
		if (num > 0)
		{
			return Strings.Left(A_4, checked((int)num));
		}
		return "0";
	}

	public static bool ReadBool(string filePath, string section, string key, string defaultValue)
	{
		string A_4 = Strings.Space(1024);
		long num = GetPrivateProfileString(ref section, ref key, ref defaultValue, ref A_4, Strings.Len(A_4), ref filePath);
		if (num > 0)
		{
			return Conversions.ToBoolean(Strings.Left(A_4, checked((int)num)));
		}
		return Conversions.ToBoolean("False");
	}
}
