using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChessRogueCheatRollScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChessRogueCheatRollScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "Ch5DaGVzc1JvZ3VlQ2hlYXRSb2xsU2NSc3AucHJvdG8aEURGQU9JQUxFQk9I";
		buffer[1] = "LnByb3RvIngKGENoZXNzUm9ndWVDaGVhdFJvbGxTY1JzcBIPCgdyZXRjb2Rl";
		buffer[2] = "GAEgASgNEiEKC1BKQUJLREJGUElNGAMgASgLMgwuREZBT0lBTEVCT0gSEwoL";
		buffer[3] = "Q0NPR0ZLTE9GS0wYCCABKA0SEwoLT0VGRkZEQ0ZBRkMYDSABKA1CFqoCE01h";
		buffer[4] = "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { DFAOIALEBOHReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueCheatRollScRsp), ChessRogueCheatRollScRsp.Parser, new string[4] { "Retcode", "PJABKDBFPIM", "CCOGFKLOFKL", "OEFFFDCFAFC" }, null, null, null, null)
		}));
	}
}
