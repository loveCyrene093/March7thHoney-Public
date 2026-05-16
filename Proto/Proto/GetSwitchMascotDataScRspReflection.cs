using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetSwitchMascotDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetSwitchMascotDataScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "Ch5HZXRTd2l0Y2hNYXNjb3REYXRhU2NSc3AucHJvdG8aEUxJRUVER09FR01L";
		buffer[1] = "LnByb3RvImMKGEdldFN3aXRjaE1hc2NvdERhdGFTY1JzcBIPCgdyZXRjb2Rl";
		buffer[2] = "GAQgASgNEiEKC09IRkJNRkdQTUpPGAsgAygLMgwuTElFRURHT0VHTUsSEwoL";
		buffer[3] = "Q1BNT09LRktCRUcYDSABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy";
		buffer[4] = "b3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { LIEEDGOEGMKReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetSwitchMascotDataScRsp), GetSwitchMascotDataScRsp.Parser, new string[3] { "Retcode", "OHFBMFGPMJO", "CPMOOKFKBEG" }, null, null, null, null)
		}));
	}
}
