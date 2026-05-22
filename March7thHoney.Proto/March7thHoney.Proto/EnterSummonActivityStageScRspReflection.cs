using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EnterSummonActivityStageScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EnterSummonActivityStageScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CiNFbnRlclN1bW1vbkFjdGl2aXR5U3RhZ2VTY1JzcC5wcm90bxoVU2NlbmVC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "YXR0bGVJbmZvLnByb3RvIn4KHUVudGVyU3VtbW9uQWN0aXZpdHlTdGFnZVNj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "UnNwEhMKC0lOT01GRkFJRU9BGAIgASgNEiUKC2JhdHRsZV9pbmZvGAQgASgL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "MhAuU2NlbmVCYXR0bGVJbmZvEg8KB3JldGNvZGUYCCABKA0SEAoIZ3JvdXBf";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "aWQYDSABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { SceneBattleInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EnterSummonActivityStageScRsp), EnterSummonActivityStageScRsp.Parser, new string[4] { "INOMFFAIEOA", "BattleInfo", "Retcode", "GroupId" }, null, null, null, null)
		}));
	}
}
