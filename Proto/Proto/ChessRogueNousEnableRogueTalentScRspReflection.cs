using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChessRogueNousEnableRogueTalentScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChessRogueNousEnableRogueTalentScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CipDaGVzc1JvZ3VlTm91c0VuYWJsZVJvZ3VlVGFsZW50U2NSc3AucHJvdG8a";
		buffer[1] = "EU1DQUNERkhDUElFLnByb3RvIm8KJENoZXNzUm9ndWVOb3VzRW5hYmxlUm9n";
		buffer[2] = "dWVUYWxlbnRTY1JzcBITCgtNUEdESk9HSEtCSBgJIAEoDRIhCgt0YWxlbnRf";
		buffer[3] = "aW5mbxgNIAEoCzIMLk1DQUNERkhDUElFEg8KB3JldGNvZGUYDiABKA1CFqoC";
		buffer[4] = "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { MCACDFHCPIEReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueNousEnableRogueTalentScRsp), ChessRogueNousEnableRogueTalentScRsp.Parser, new string[3] { "MPGDJOGHKBH", "TalentInfo", "Retcode" }, null, null, null, null)
		}));
	}
}
