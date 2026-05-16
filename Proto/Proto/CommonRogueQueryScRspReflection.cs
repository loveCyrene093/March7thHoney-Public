using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CommonRogueQueryScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CommonRogueQueryScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChtDb21tb25Sb2d1ZVF1ZXJ5U2NSc3AucHJvdG8aEUdPRkZJRE5JQ0tKLnBy";
		buffer[1] = "b3RvImMKFUNvbW1vblJvZ3VlUXVlcnlTY1JzcBIPCgdyZXRjb2RlGAIgASgN";
		buffer[2] = "EhMKC05DQ0xDSERES0RGGAQgASgNEiQKDnJvZ3VlX2dldF9pbmZvGAwgAygL";
		buffer[3] = "MgwuR09GRklETklDS0pCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv";
		buffer[4] = "Mw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { GOFFIDNICKJReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CommonRogueQueryScRsp), CommonRogueQueryScRsp.Parser, new string[3] { "Retcode", "NCCLCHDDKDF", "RogueGetInfo" }, null, null, null, null)
		}));
	}
}
