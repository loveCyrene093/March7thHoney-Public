using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SelfRankChangeNtfReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SelfRankChangeNtfReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChdTZWxmUmFua0NoYW5nZU50Zi5wcm90bxoRRUZCSUhKSE1JQ0IucHJvdG8a";
		buffer[1] = "E0ZpZ2h0R2FtZU1vZGUucHJvdG8iWwoRU2VsZlJhbmtDaGFuZ2VOdGYSIwoL";
		buffer[2] = "UExPQk1CRlBORksYASABKA4yDi5GaWdodEdhbWVNb2RlEiEKC0NQQkdMTkdP";
		buffer[3] = "Q0JBGA4gAygLMgwuRUZCSUhKSE1JQ0JCFqoCE01hcmNoN3RoSG9uZXkuUHJv";
		buffer[4] = "dG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			EFBIHJHMICBReflection.Descriptor,
			FightGameModeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SelfRankChangeNtf), SelfRankChangeNtf.Parser, new string[2] { "PLOBMBFPNFK", "CPBGLNGOCBA" }, null, null, null, null)
		}));
	}
}
