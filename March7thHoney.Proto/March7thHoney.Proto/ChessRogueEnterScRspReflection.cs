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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChpDaGVzc1JvZ3VlRW50ZXJTY1JzcC5wcm90bxoRRUpDQ0hIQUFHTkgucHJv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "dG8aEUlMRUpHRURCRUtGLnByb3RvIngKFENoZXNzUm9ndWVFbnRlclNjUnNw";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "Eg8KB3JldGNvZGUYASABKA0SCgoCaWQYBCABKA0SIAoKc3RhZ2VfaW5mbxgF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "IAEoCzIMLkVKQ0NISEFBR05IEiEKC0xKTUZHREZCTENLGAYgASgLMgwuSUxF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "SkdFREJFS0ZCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			EJCCHHAAGNHReflection.Descriptor,
			ILEJGEDBEKFReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueEnterScRsp), ChessRogueEnterScRsp.Parser, new string[4] { "Retcode", "Id", "StageInfo", "LJMFGDFBLCK" }, null, null, null, null)
		}));
	}
}
