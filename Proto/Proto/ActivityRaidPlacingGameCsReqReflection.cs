using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ActivityRaidPlacingGameCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ActivityRaidPlacingGameCsReqReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "CiJBY3Rpdml0eVJhaWRQbGFjaW5nR2FtZUNzUmVxLnByb3RvGhZBbGxleVBs";
		buffer[1] = "YWNpbmdTaGlwLnByb3RvIoMBChxBY3Rpdml0eVJhaWRQbGFjaW5nR2FtZUNz";
		buffer[2] = "UmVxEiYKC0ZDRENGQU1PSEFFGAsgASgLMhEuQWxsZXlQbGFjaW5nU2hpcBIV";
		buffer[3] = "CgtNRk1ISEFQUFBKShgBIAEoDUgAEhUKC09CUE5ES1BQRkdHGAwgASgNSABC";
		buffer[4] = "DQoLRExPTUtGTEVFSUNCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv";
		buffer[5] = "Mw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { AlleyPlacingShipReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ActivityRaidPlacingGameCsReq), ActivityRaidPlacingGameCsReq.Parser, new string[3] { "FCDCFAMOHAE", "MFMHHAPPPJJ", "OBPNDKPPFGG" }, new string[1] { "DLOMKFLEEIC" }, null, null, null)
		}));
	}
}
