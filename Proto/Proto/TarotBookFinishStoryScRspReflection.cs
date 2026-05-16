using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TarotBookFinishStoryScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TarotBookFinishStoryScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "Ch9UYXJvdEJvb2tGaW5pc2hTdG9yeVNjUnNwLnByb3RvGhFDREhPS01BQU1G";
		buffer[1] = "RC5wcm90byJkChlUYXJvdEJvb2tGaW5pc2hTdG9yeVNjUnNwEiEKC0NQRU1M";
		buffer[2] = "SUFHQktCGAsgASgLMgwuQ0RIT0tNQUFNRkQSEwoLTUFGTUNJUEFJS0sYDCAB";
		buffer[3] = "KA0SDwoHcmV0Y29kZRgPIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG";
		buffer[4] = "cHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { CDHOKMAAMFDReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TarotBookFinishStoryScRsp), TarotBookFinishStoryScRsp.Parser, new string[3] { "CPEMLIAGBKB", "MAFMCIPAIKK", "Retcode" }, null, null, null, null)
		}));
	}
}
