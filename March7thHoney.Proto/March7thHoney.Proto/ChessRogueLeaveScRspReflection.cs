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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 0) = "ChpDaGVzc1JvZ3VlTGVhdmVTY1JzcC5wcm90bxoRQkFCQUdFRENDQkcucHJv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 1) = "dG8aEUVKQ0NISEFBR05ILnByb3RvGhFKTU9HUE1DSkdMRS5wcm90bxoRUERB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 2) = "TUJDRkZQREkucHJvdG8itQEKFENoZXNzUm9ndWVMZWF2ZVNjUnNwEiQKDnJv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 3) = "Z3VlX2dldF9pbmZvGAIgASgLMgwuQkFCQUdFRENDQkcSIQoLSU1QQkVMSkdE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 4) = "SkgYBCABKAsyDC5KTU9HUE1DSkdMRRIPCgdyZXRjb2RlGAcgASgNEiAKCnN0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 5) = "YWdlX2luZm8YCyABKAsyDC5FSkNDSEhBQUdOSBIhCgtPQ0xMQURCRktIUBgM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 6) = "IAEoCzIMLlBEQU1CQ0ZGUERJQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 7) = "cm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray8<string>, string>(in buffer, 8))), new FileDescriptor[4]
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
