using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueCommonBuffSelectSourceTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueCommonBuffSelectSourceTypeReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "CiVSb2d1ZUNvbW1vbkJ1ZmZTZWxlY3RTb3VyY2VUeXBlLnByb3RvKrIBCh9S";
		buffer[1] = "b2d1ZUNvbW1vbkJ1ZmZTZWxlY3RTb3VyY2VUeXBlEhsKF01BRlBPTklETUxE";
		buffer[2] = "X1BDUERIRUxQS0VNEAASGwoXTUFGUE9OSURNTERfSExJREdETE5GSE0QARIb";
		buffer[3] = "ChdNQUZQT05JRE1MRF9FR0ZCR0pHSUVLTRACEhsKF01BRlBPTklETUxEX05Q";
		buffer[4] = "RENPSkNBSFBFEAMSGwoXTUFGUE9OSURNTERfR0FMR0ZJT01PSU8QBEIWqgIT";
		buffer[5] = "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(RogueCommonBuffSelectSourceType) }, null, null));
	}
}
