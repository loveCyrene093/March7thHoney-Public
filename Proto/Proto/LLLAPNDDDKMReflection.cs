using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LLLAPNDDDKMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LLLAPNDDDKMReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFMTExBUE5ERERLTS5wcm90bxoRQ1BJT0NISFBJQ0QucHJvdG8ibQoLTExM";
		buffer[1] = "QVBORERES00SEwoLT0dIQ01ERk5HTUYYAyABKA0SEwoLTlBCS0xDSExKTUcY";
		buffer[2] = "BCABKA0SEQoJYXZhdGFyX2lkGAYgASgNEiEKC05CQUtIQ0xMRUtKGA0gASgL";
		buffer[3] = "MgwuQ1BJT0NISFBJQ0RCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv";
		buffer[4] = "Mw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { CPIOCHHPICDReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LLLAPNDDDKM), LLLAPNDDDKM.Parser, new string[4] { "OGHCMDFNGMF", "NPBKLCHLJMG", "AvatarId", "NBAKHCLLEKJ" }, null, null, null, null)
		}));
	}
}
