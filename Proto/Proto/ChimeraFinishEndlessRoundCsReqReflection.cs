using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChimeraFinishEndlessRoundCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChimeraFinishEndlessRoundCsReqReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		buffer[0] = "CiRDaGltZXJhRmluaXNoRW5kbGVzc1JvdW5kQ3NSZXEucHJvdG8aEUZIQ0ND";
		buffer[1] = "SEpISEtMLnByb3RvGhFIQU1FSlBHQ0lKSS5wcm90bxoRUENBT0xKTEZQQkEu";
		buffer[2] = "cHJvdG8iuwEKHkNoaW1lcmFGaW5pc2hFbmRsZXNzUm91bmRDc1JlcRIZCgNz";
		buffer[3] = "dHQYBSABKAsyDC5IQU1FSlBHQ0lKSRITCgtPSVBMSkpJT0RJTBgGIAEoCBIc";
		buffer[4] = "CgZsaW5ldXAYCiABKAsyDC5GSENDQ0hKSEhLTBITCgtOS0JERElERlBORRgL";
		buffer[5] = "IAEoDRIhCgtLTUFGREZCSkNKSRgOIAMoCzIMLlBDQU9MSkxGUEJBEhMKC0xO";
		buffer[6] = "QU9IREJHRU5PGA8gAygNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90";
		buffer[7] = "bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
		{
			FHCCCHJHHKLReflection.Descriptor,
			HAMEJPGCIJIReflection.Descriptor,
			PCAOLJLFPBAReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChimeraFinishEndlessRoundCsReq), ChimeraFinishEndlessRoundCsReq.Parser, new string[6] { "Stt", "OIPLJJIODIL", "Lineup", "NKBDDIDFPNE", "KMAFDFBJCJI", "LNAOHDBGENO" }, null, null, null, null)
		}));
	}
}
