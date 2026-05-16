using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ODOFBIJJNJGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ODOFBIJJNJGReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFPRE9GQklKSk5KRy5wcm90byLEAQoLT0RPRkJJSkpOSkcSEwoLQU9LREJE";
		buffer[1] = "R0RDSEIYASABKA0SDQoFbGV2ZWwYAiABKA0SEwoLSExLQUZQQ0xNRU8YAyAB";
		buffer[2] = "KAgSFAoMZGljZV9zbG90X2lkGAQgASgNEjIKC0pLQkxNUEVISUhNGAUgAygL";
		buffer[3] = "Mh0uT0RPRkJJSkpOSkcuSktCTE1QRUhJSE1FbnRyeRoyChBKS0JMTVBFSElI";
		buffer[4] = "TUVudHJ5EgsKA2tleRgBIAEoDRINCgV2YWx1ZRgCIAEoDToCOAFCFqoCE01h";
		buffer[5] = "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ODOFBIJJNJG), ODOFBIJJNJG.Parser, new string[5] { "AOKDBDGDCHB", "Level", "HLKAFPCLMEO", "DiceSlotId", "JKBLMPEHIHM" }, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
