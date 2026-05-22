using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ContentPackageGetDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ContentPackageGetDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBDb250ZW50UGFja2FnZUdldERhdGFDc1JlcS5wcm90byIcChpDb250ZW50" + "UGFja2FnZUdldERhdGFDc1JlcUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ContentPackageGetDataCsReq), ContentPackageGetDataCsReq.Parser, null, null, null, null, null)
		}));
	}
}
