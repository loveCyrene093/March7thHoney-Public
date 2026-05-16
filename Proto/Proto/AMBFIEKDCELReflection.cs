using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AMBFIEKDCELReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AMBFIEKDCELReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFBTUJGSUVLRENFTC5wcm90byKIAQoLQU1CRklFS0RDRUwSDgoGbWF4X2hw";
		buffer[1] = "GAEgASgBEg4KBmF0dGFjaxgCIAEoARIPCgdkZWZlbmNlGAMgASgBEhMKC01B";
		buffer[2] = "QUhFTElBQ09KGAQgASgBEg0KBXNwZWVkGAUgASgBEg8KB2xlZnRfaHAYBiAB";
		buffer[3] = "KAESEwoLS0VKQ0JPQVBEREIYByABKAFCFqoCE01hcmNoN3RoSG9uZXkuUHJv";
		buffer[4] = "dG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AMBFIEKDCEL), AMBFIEKDCEL.Parser, new string[7] { "MaxHp", "Attack", "Defence", "MAAHELIACOJ", "Speed", "LeftHp", "KEJCBOAPDDB" }, null, null, null, null)
		}));
	}
}
