using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeKilledPunkLordMonsterScoreScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeKilledPunkLordMonsterScoreScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CilUYWtlS2lsbGVkUHVua0xvcmRNb25zdGVyU2NvcmVTY1JzcC5wcm90bxoR";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "SkxMSURESUJPSEkucHJvdG8igAEKI1Rha2VLaWxsZWRQdW5rTG9yZE1vbnN0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "ZXJTY29yZVNjUnNwEhMKC01ETkZMSE1PTE5CGAEgASgIEiEKC0RHTEhGUElQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "RkRKGAQgAygLMgwuSkxMSURESUJPSEkSDwoHcmV0Y29kZRgIIAEoDRIQCghz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "Y29yZV9pZBgMIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { JLLIDDIBOHIReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeKilledPunkLordMonsterScoreScRsp), TakeKilledPunkLordMonsterScoreScRsp.Parser, new string[4] { "MDNFLHMOLNB", "DGLHFPIPFDJ", "Retcode", "ScoreId" }, null, null, null, null)
		}));
	}
}
