using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChimeraDoFinalRoundCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChimeraDoFinalRoundCsReqReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "Ch5DaGltZXJhRG9GaW5hbFJvdW5kQ3NSZXEucHJvdG8aEUZIQ0NDSEpISEtM";
		buffer[1] = "LnByb3RvGhFIQU1FSlBHQ0lKSS5wcm90bxoRUENBT0xKTEZQQkEucHJvdG8i";
		buffer[2] = "tQEKGENoaW1lcmFEb0ZpbmFsUm91bmRDc1JlcRIhCgtLTUFGREZCSkNKSRgB";
		buffer[3] = "IAMoCzIMLlBDQU9MSkxGUEJBEhwKBmxpbmV1cBgDIAEoCzIMLkZIQ0NDSEpI";
		buffer[4] = "SEtMEhkKA3N0dBgGIAEoCzIMLkhBTUVKUEdDSUpJEhMKC0xOQU9IREJHRU5P";
		buffer[5] = "GAkgAygNEhMKC09JUExKSklPRElMGAsgASgIEhMKC05LQkRESURGUE5FGAwg";
		buffer[6] = "ASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
		{
			FHCCCHJHHKLReflection.Descriptor,
			HAMEJPGCIJIReflection.Descriptor,
			PCAOLJLFPBAReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChimeraDoFinalRoundCsReq), ChimeraDoFinalRoundCsReq.Parser, new string[6] { "KMAFDFBJCJI", "Lineup", "Stt", "LNAOHDBGENO", "OIPLJJIODIL", "NKBDDIDFPNE" }, null, null, null, null)
		}));
	}
}
