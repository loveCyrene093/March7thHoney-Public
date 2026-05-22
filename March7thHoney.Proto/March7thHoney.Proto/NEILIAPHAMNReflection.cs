using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NEILIAPHAMNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NEILIAPHAMNReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChFORUlMSUFQSEFNTi5wcm90bxoVUm9ndWVBcmVhU3RhdHVzLnByb3RvGhFS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "b2d1ZVN0YXR1cy5wcm90byKiAQoLTkVJTElBUEhBTU4SJQoLRUNKUEVCREpL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "S0UYAyABKA4yEC5Sb2d1ZUFyZWFTdGF0dXMSDgoGbWFwX2lkGAQgASgNEiEK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "C0ZJTUFNRUROTklMGAUgASgOMgwuUm9ndWVTdGF0dXMSDwoHYXJlYV9pZBgH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "IAEoDRITCgtQR0lOTE9GS0NNRBgMIAEoDRITCgtDTkRLQVBPSUVPShgNIAEo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "CEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[2]
		{
			RogueAreaStatusReflection.Descriptor,
			RogueStatusReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NEILIAPHAMN), NEILIAPHAMN.Parser, new string[6] { "ECJPEBDJKKE", "MapId", "FIMAMEDNNIL", "AreaId", "PGINLOFKCMD", "CNDKAPOIEOJ" }, null, null, null, null)
		}));
	}
}
