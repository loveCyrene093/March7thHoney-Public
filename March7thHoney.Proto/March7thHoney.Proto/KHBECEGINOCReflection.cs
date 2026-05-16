using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KHBECEGINOCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KHBECEGINOCReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChFLSEJFQ0VHSU5PQy5wcm90bxoSSXRlbUNvc3REYXRhLnByb3RvIoMBCgtL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "SEJFQ0VHSU5PQxITCgtQSUdESUZBS0lHTRgDIAEoBRIgCgljb3N0X2RhdGEY";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "BSABKAsyDS5JdGVtQ29zdERhdGESEwoLRElETEtFTEtFUEcYCSABKAgSEwoL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "TUNLQUdGR0xBQ00YDiABKA0SEwoLSktJTUxJUE1LRkgYDyABKA1CFqoCE01h";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { ItemCostDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KHBECEGINOC), KHBECEGINOC.Parser, new string[5] { "PIGDIFAKIGM", "CostData", "DIDLKELKEPG", "MCKAGFGLACM", "JKIMLIPMKFH" }, null, null, null, null)
		}));
	}
}
