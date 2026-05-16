using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetMarkItemListCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetMarkItemListCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpHZXRNYXJrSXRlbUxpc3RDc1JlcS5wcm90byIWChRHZXRNYXJrSXRlbUxp" + "c3RDc1JlcUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetMarkItemListCsReq), GetMarkItemListCsReq.Parser, null, null, null, null, null)
		}));
	}
}
