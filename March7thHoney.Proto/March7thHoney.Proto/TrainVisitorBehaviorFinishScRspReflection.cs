using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TrainVisitorBehaviorFinishScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TrainVisitorBehaviorFinishScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CiVUcmFpblZpc2l0b3JCZWhhdmlvckZpbmlzaFNjUnNwLnByb3RvGg5JdGVt";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "TGlzdC5wcm90byJhCh9UcmFpblZpc2l0b3JCZWhhdmlvckZpbmlzaFNjUnNw";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "EhkKBnJld2FyZBgIIAEoCzIJLkl0ZW1MaXN0Eg8KB3JldGNvZGUYCSABKA0S";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "EgoKdmlzaXRvcl9pZBgPIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "cHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TrainVisitorBehaviorFinishScRsp), TrainVisitorBehaviorFinishScRsp.Parser, new string[3] { "Reward", "Retcode", "VisitorId" }, null, null, null, null)
		}));
	}
}
