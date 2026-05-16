using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MarkItemCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MarkItemCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChNNYXJrSXRlbUNzUmVxLnByb3RvIjUKDU1hcmtJdGVtQ3NSZXESEwoLRUtM" + "Q0ZCSVBHR08YCSABKAgSDwoHaXRlbV9pZBgNIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MarkItemCsReq), MarkItemCsReq.Parser, new string[2] { "EKLCFBIPGGO", "ItemId" }, null, null, null, null)
		}));
	}
}
