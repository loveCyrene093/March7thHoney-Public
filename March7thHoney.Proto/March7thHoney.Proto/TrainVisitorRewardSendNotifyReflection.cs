using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TrainVisitorRewardSendNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TrainVisitorRewardSendNotifyReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CiJUcmFpblZpc2l0b3JSZXdhcmRTZW5kTm90aWZ5LnByb3RvGg5JdGVtTGlz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "dC5wcm90bxoRUExIQkJNRU1EQkcucHJvdG8iaQocVHJhaW5WaXNpdG9yUmV3";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "YXJkU2VuZE5vdGlmeRISCgp2aXNpdG9yX2lkGAYgASgNEhoKBHR5cGUYCiAB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "KA4yDC5QTEhCQk1FTURCRxIZCgZyZXdhcmQYDSABKAsyCS5JdGVtTGlzdEIW";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			ItemListReflection.Descriptor,
			PLHBBMEMDBGReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TrainVisitorRewardSendNotify), TrainVisitorRewardSendNotify.Parser, new string[3] { "VisitorId", "Type", "Reward" }, null, null, null, null)
		}));
	}
}
