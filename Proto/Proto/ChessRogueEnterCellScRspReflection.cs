using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChessRogueEnterCellScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChessRogueEnterCellScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "Ch5DaGVzc1JvZ3VlRW50ZXJDZWxsU2NSc3AucHJvdG8aEUVKQ0NISEFBR05I";
		buffer[1] = "LnByb3RvGhFJTEVKR0VEQkVLRi5wcm90byKFAQoYQ2hlc3NSb2d1ZUVudGVy";
		buffer[2] = "Q2VsbFNjUnNwEhMKC0VJSUFHQUJBRkVDGAQgASgNEiEKC0xKTUZHREZCTENL";
		buffer[3] = "GAcgASgLMgwuSUxFSkdFREJFS0YSDwoHcmV0Y29kZRgIIAEoDRIgCgpzdGFn";
		buffer[4] = "ZV9pbmZvGA0gASgLMgwuRUpDQ0hIQUFHTkhCFqoCE01hcmNoN3RoSG9uZXku";
		buffer[5] = "UHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			EJCCHHAAGNHReflection.Descriptor,
			ILEJGEDBEKFReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueEnterCellScRsp), ChessRogueEnterCellScRsp.Parser, new string[4] { "EIIAGABAFEC", "LJMFGDFBLCK", "Retcode", "StageInfo" }, null, null, null, null)
		}));
	}
}
