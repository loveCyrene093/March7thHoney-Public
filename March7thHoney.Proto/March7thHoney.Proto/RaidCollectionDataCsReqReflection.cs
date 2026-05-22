using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RaidCollectionDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RaidCollectionDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1SYWlkQ29sbGVjdGlvbkRhdGFDc1JlcS5wcm90byIZChdSYWlkQ29sbGVj" + "dGlvbkRhdGFDc1JlcUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RaidCollectionDataCsReq), RaidCollectionDataCsReq.Parser, null, null, null, null, null)
		}));
	}
}
