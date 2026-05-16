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
		buffer[0] = "ChFLSEJFQ0VHSU5PQy5wcm90bxoSSXRlbUNvc3REYXRhLnByb3RvIoMBCgtL";
		buffer[1] = "SEJFQ0VHSU5PQxITCgtQSUdESUZBS0lHTRgDIAEoBRIgCgljb3N0X2RhdGEY";
		buffer[2] = "BSABKAsyDS5JdGVtQ29zdERhdGESEwoLRElETEtFTEtFUEcYCSABKAgSEwoL";
		buffer[3] = "TUNLQUdGR0xBQ00YDiABKA0SEwoLSktJTUxJUE1LRkgYDyABKA1CFqoCE01h";
		buffer[4] = "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ItemCostDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KHBECEGINOC), KHBECEGINOC.Parser, new string[5] { "PIGDIFAKIGM", "CostData", "DIDLKELKEPG", "MCKAGFGLACM", "JKIMLIPMKFH" }, null, null, null, null)
		}));
	}
}
