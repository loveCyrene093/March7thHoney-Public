using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChessRogueStartScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChessRogueStartScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChpDaGVzc1JvZ3VlU3RhcnRTY1JzcC5wcm90bxoRRUJHSktQSk5QQkwucHJv";
		buffer[1] = "dG8aEUVKQ0NISEFBR05ILnByb3RvGhFJTEVKR0VEQkVLRi5wcm90byKPAQoU";
		buffer[2] = "Q2hlc3NSb2d1ZVN0YXJ0U2NSc3ASIQoLTEpNRkdERkJMQ0sYCCABKAsyDC5J";
		buffer[3] = "TEVKR0VEQkVLRhIhCgtFT0hPSkVDS09EShgLIAEoCzIMLkVCR0pLUEpOUEJM";
		buffer[4] = "EiAKCnN0YWdlX2luZm8YDCABKAsyDC5FSkNDSEhBQUdOSBIPCgdyZXRjb2Rl";
		buffer[5] = "GA8gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
		{
			EBGJKPJNPBLReflection.Descriptor,
			EJCCHHAAGNHReflection.Descriptor,
			ILEJGEDBEKFReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueStartScRsp), ChessRogueStartScRsp.Parser, new string[4] { "LJMFGDFBLCK", "EOHOJECKODJ", "StageInfo", "Retcode" }, null, null, null, null)
		}));
	}
}
