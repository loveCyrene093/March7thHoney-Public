using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LogisticsGameScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LogisticsGameScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChhMb2dpc3RpY3NHYW1lU2NSc3AucHJvdG8aEUpDQ01HT09QSEJPLnByb3Rv";
		buffer[1] = "Im8KEkxvZ2lzdGljc0dhbWVTY1JzcBIQCghldmVudF9pZBgBIAEoDRIPCgdy";
		buffer[2] = "ZXRjb2RlGAMgASgNEiEKC09BSUtJRkVLRkxHGAcgAygLMgwuSkNDTUdPT1BI";
		buffer[3] = "Qk8SEwoLQ0xQTkJGT0tKTEoYDCABKAhCFqoCE01hcmNoN3RoSG9uZXkuUHJv";
		buffer[4] = "dG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { JCCMGOOPHBOReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LogisticsGameScRsp), LogisticsGameScRsp.Parser, new string[4] { "EventId", "Retcode", "OAIKIFEKFLG", "CLPNBFOKJLJ" }, null, null, null, null)
		}));
	}
}
