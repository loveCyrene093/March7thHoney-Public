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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "CiJBY3Rpdml0eVJhaWRQbGFjaW5nR2FtZUNzUmVxLnByb3RvGhZBbGxleVBs";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "YWNpbmdTaGlwLnByb3RvIoMBChxBY3Rpdml0eVJhaWRQbGFjaW5nR2FtZUNz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "UmVxEiYKC0ZDRENGQU1PSEFFGAsgASgLMhEuQWxsZXlQbGFjaW5nU2hpcBIV";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "CgtNRk1ISEFQUFBKShgBIAEoDUgAEhUKC09CUE5ES1BQRkdHGAwgASgNSABC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "DQoLRExPTUtGTEVFSUNCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "Mw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[1] { AlleyPlacingShipReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ActivityRaidPlacingGameCsReq), ActivityRaidPlacingGameCsReq.Parser, new string[3] { "FCDCFAMOHAE", "MFMHHAPPPJJ", "OBPNDKPPFGG" }, new string[1] { "DLOMKFLEEIC" }, null, null, null)
		}));
	}
}
