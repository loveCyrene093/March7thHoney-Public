using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChessRogueLeaveScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChessRogueLeaveScRspReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		buffer[0] = "ChpDaGVzc1JvZ3VlTGVhdmVTY1JzcC5wcm90bxoRQkFCQUdFRENDQkcucHJv";
		buffer[1] = "dG8aEUVKQ0NISEFBR05ILnByb3RvGhFKTU9HUE1DSkdMRS5wcm90bxoRUERB";
		buffer[2] = "TUJDRkZQREkucHJvdG8itQEKFENoZXNzUm9ndWVMZWF2ZVNjUnNwEiQKDnJv";
		buffer[3] = "Z3VlX2dldF9pbmZvGAIgASgLMgwuQkFCQUdFRENDQkcSIQoLSU1QQkVMSkdE";
		buffer[4] = "SkgYBCABKAsyDC5KTU9HUE1DSkdMRRIPCgdyZXRjb2RlGAcgASgNEiAKCnN0";
		buffer[5] = "YWdlX2luZm8YCyABKAsyDC5FSkNDSEhBQUdOSBIhCgtPQ0xMQURCRktIUBgM";
		buffer[6] = "IAEoCzIMLlBEQU1CQ0ZGUERJQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw";
		buffer[7] = "cm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[4]
		{
			BABAGEDCCBGReflection.Descriptor,
			EJCCHHAAGNHReflection.Descriptor,
			JMOGPMCJGLEReflection.Descriptor,
			PDAMBCFFPDIReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueLeaveScRsp), ChessRogueLeaveScRsp.Parser, new string[5] { "RogueGetInfo", "IMPBELJGDJH", "Retcode", "StageInfo", "OCLLADBFKHP" }, null, null, null, null)
		}));
	}
}
