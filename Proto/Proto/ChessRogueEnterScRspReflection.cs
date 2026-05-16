using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChessRogueEnterScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChessRogueEnterScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChpDaGVzc1JvZ3VlRW50ZXJTY1JzcC5wcm90bxoRRUpDQ0hIQUFHTkgucHJv";
		buffer[1] = "dG8aEUlMRUpHRURCRUtGLnByb3RvIngKFENoZXNzUm9ndWVFbnRlclNjUnNw";
		buffer[2] = "Eg8KB3JldGNvZGUYASABKA0SCgoCaWQYBCABKA0SIAoKc3RhZ2VfaW5mbxgF";
		buffer[3] = "IAEoCzIMLkVKQ0NISEFBR05IEiEKC0xKTUZHREZCTENLGAYgASgLMgwuSUxF";
		buffer[4] = "SkdFREJFS0ZCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			EJCCHHAAGNHReflection.Descriptor,
			ILEJGEDBEKFReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueEnterScRsp), ChessRogueEnterScRsp.Parser, new string[4] { "Retcode", "Id", "StageInfo", "LJMFGDFBLCK" }, null, null, null, null)
		}));
	}
}
