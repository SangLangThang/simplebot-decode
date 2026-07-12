internal static class FnvHash
{
	public static uint Compute(string value)
	{
		uint hash = 2166136261u;
		if (value != null)
		{
			for (int i = 0; i < value.Length; i++)
			{
				hash = (value[i] ^ hash) * 16777619;
			}
		}
		return hash;
	}
}
