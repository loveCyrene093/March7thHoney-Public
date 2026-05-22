using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JHNGCNHEOCBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JHNGCNHEOCBReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChFKSE5HQ05IRU9DQi5wcm90bxoSSXRlbUNvc3REYXRhLnByb3RvIoMBCgtK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "SE5HQ05IRU9DQhITCgtNQ0tBR0ZHTEFDTRgBIAEoDRIgCgljb3N0X2RhdGEY";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "AyABKAsyDS5JdGVtQ29zdERhdGESEwoLRElETEtFTEtFUEcYCSABKAgSEwoL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "SktJTUxJUE1LRkgYCiABKA0SEwoLUElHRElGQUtJR00YDSABKAVCFqoCE01h";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { ItemCostDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JHNGCNHEOCB), JHNGCNHEOCB.Parser, new string[5] { "MCKAGFGLACM", "CostData", "DIDLKELKEPG", "JKIMLIPMKFH", "PIGDIFAKIGM" }, null, null, null, null)
		}));
	}
}
