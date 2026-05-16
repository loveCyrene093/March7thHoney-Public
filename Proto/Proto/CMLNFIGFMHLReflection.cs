using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CMLNFIGFMHLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CMLNFIGFMHLReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFDTUxORklHRk1ITC5wcm90byK0AQoLQ01MTkZJR0ZNSEwSGgoSY2xpZW50";
		buffer[1] = "X3Jlc192ZXJzaW9uGAIgASgNEgsKA3VpZBgDIAEoDRISCgphY2NvdW50X2lw";
		buffer[2] = "GAQgASgNEhMKC09ES0ZDQ09IQUZNGAUgASgEEhAKCHBsYXRmb3JtGAcgASgN";
		buffer[3] = "EhcKD2FjY291bnRfaXBfcG9ydBgLIAEoDRITCgtLRk1BRUdOTkpETBgMIAEo";
		buffer[4] = "DRITCgtJSEpHTEdDTEFOTRgNIAEoCUIWqgITTWFyY2g3dGhIb25leS5Qcm90";
		buffer[5] = "b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CMLNFIGFMHL), CMLNFIGFMHL.Parser, new string[8] { "ClientResVersion", "Uid", "AccountIp", "ODKFCCOHAFM", "Platform", "AccountIpPort", "KFMAEGNNJDL", "IHJGLGCLANM" }, null, null, null, null)
		}));
	}
}
