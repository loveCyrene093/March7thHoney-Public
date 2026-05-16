using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetAssistHistoryScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetAssistHistoryScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChtHZXRBc3Npc3RIaXN0b3J5U2NSc3AucHJvdG8ifAoVR2V0QXNzaXN0SGlz";
		buffer[1] = "dG9yeVNjUnNwEhMKC1BMUERBQUNFS0pCGAEgAygNEg8KB3JldGNvZGUYByAB";
		buffer[2] = "KA0SEwoLT0tQQk5JSURDRUoYCSABKA0SEwoLS0xFTUdHTkdFSEcYDSABKA0S";
		buffer[3] = "EwoLS0pJREhEQ1BDSEgYDyABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i";
		buffer[4] = "BnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetAssistHistoryScRsp), GetAssistHistoryScRsp.Parser, new string[5] { "PLPDAACEKJB", "Retcode", "OKPBNIIDCEJ", "KLEMGGNGEHG", "KJIDHDCPCHH" }, null, null, null, null)
		}));
	}
}
