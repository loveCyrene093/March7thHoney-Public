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
		buffer[0] = "ChZUYWtlQ29udGVudFNjUnNwLnByb3RvGg5JdGVtTGlzdC5wcm90bxoRTUhH";
		buffer[1] = "REpQTUVGRk4ucHJvdG8idQoQVGFrZUNvbnRlbnRTY1JzcBISCgpjb250ZW50";
		buffer[2] = "X2lkGAEgASgNEg8KB3JldGNvZGUYBCABKA0SGQoGcmV3YXJkGAogASgLMgku";
		buffer[3] = "SXRlbUxpc3QSIQoLTUtIRElOREdITUQYDyABKA4yDC5NSEdESlBNRUZGTkIW";
		buffer[4] = "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			ItemListReflection.Descriptor,
			MHGDJPMEFFNReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeContentScRsp), TakeContentScRsp.Parser, new string[4] { "ContentId", "Retcode", "Reward", "MKHDINDGHMD" }, null, null, null, null)
		}));
	}
}
