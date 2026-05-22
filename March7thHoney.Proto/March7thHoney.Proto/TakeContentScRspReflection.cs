using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeContentScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeContentScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChZUYWtlQ29udGVudFNjUnNwLnByb3RvGg5JdGVtTGlzdC5wcm90bxoRTUhH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "REpQTUVGRk4ucHJvdG8idQoQVGFrZUNvbnRlbnRTY1JzcBISCgpjb250ZW50";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "X2lkGAEgASgNEg8KB3JldGNvZGUYBCABKA0SGQoGcmV3YXJkGAogASgLMgku";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "SXRlbUxpc3QSIQoLTUtIRElOREdITUQYDyABKA4yDC5NSEdESlBNRUZGTkIW";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			ItemListReflection.Descriptor,
			MHGDJPMEFFNReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeContentScRsp), TakeContentScRsp.Parser, new string[4] { "ContentId", "Retcode", "Reward", "MKHDINDGHMD" }, null, null, null, null)
		}));
	}
}
