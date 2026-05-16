using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LKJMLPJEPGGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LKJMLPJEPGGReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFMS0pNTFBKRVBHRy5wcm90byKHAQoLTEtKTUxQSkVQR0cSEwoLSUxFTU1L";
		buffer[1] = "UEdQTkQYAyABKA0SEwoLSEVJSEdGQU9GTksYBiABKA0SEQoJaXRlbV9saXN0";
		buffer[2] = "GAggAygNEhEKCXVuaXF1ZV9pZBgMIAEoDRITCgtNTkJQR01CTE1KUBgNIAMo";
		buffer[3] = "DRITCgtGRkJNTUhBT0hDQRgOIAEoCEIWqgITTWFyY2g3dGhIb25leS5Qcm90";
		buffer[4] = "b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LKJMLPJEPGG), LKJMLPJEPGG.Parser, new string[6] { "ILEMMKPGPND", "HEIHGFAOFNK", "ItemList", "UniqueId", "MNBPGMBLMJP", "FFBMMHAOHCA" }, null, null, null, null)
		}));
	}
}
