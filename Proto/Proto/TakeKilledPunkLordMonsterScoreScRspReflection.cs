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
		buffer[0] = "CilUYWtlS2lsbGVkUHVua0xvcmRNb25zdGVyU2NvcmVTY1JzcC5wcm90bxoR";
		buffer[1] = "SkxMSURESUJPSEkucHJvdG8igAEKI1Rha2VLaWxsZWRQdW5rTG9yZE1vbnN0";
		buffer[2] = "ZXJTY29yZVNjUnNwEhMKC01ETkZMSE1PTE5CGAEgASgIEiEKC0RHTEhGUElQ";
		buffer[3] = "RkRKGAQgAygLMgwuSkxMSURESUJPSEkSDwoHcmV0Y29kZRgIIAEoDRIQCghz";
		buffer[4] = "Y29yZV9pZBgMIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { JLLIDDIBOHIReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeKilledPunkLordMonsterScoreScRsp), TakeKilledPunkLordMonsterScoreScRsp.Parser, new string[4] { "MDNFLHMOLNB", "DGLHFPIPFDJ", "Retcode", "ScoreId" }, null, null, null, null)
		}));
	}
}
