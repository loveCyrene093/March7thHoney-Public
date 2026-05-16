using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AetherDivideSpiritInfoScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AetherDivideSpiritInfoScNotifyReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiRBZXRoZXJEaXZpZGVTcGlyaXRJbmZvU2NOb3RpZnkucHJvdG8aEUtOSEtC";
		buffer[1] = "SEFESkdFLnByb3RvInsKHkFldGhlckRpdmlkZVNwaXJpdEluZm9TY05vdGlm";
		buffer[2] = "eRIhCgtIS09ISUhDQkdBQRgHIAEoCzIMLktOSEtCSEFESkdFEhMKC0ZJS0xM";
		buffer[3] = "T0NKQkdOGAkgASgNEiEKC1BCRUVKTlBNSE9GGAwgAygLMgwuS05IS0JIQURK";
		buffer[4] = "R0VCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { KNHKBHADJGEReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AetherDivideSpiritInfoScNotify), AetherDivideSpiritInfoScNotify.Parser, new string[3] { "HKOHIHCBGAA", "FIKLLOCJBGN", "PBEEJNPMHOF" }, null, null, null, null)
		}));
	}
}
