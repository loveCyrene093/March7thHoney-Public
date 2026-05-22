using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueMagicUnitComposeCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueMagicUnitComposeCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBSb2d1ZU1hZ2ljVW5pdENvbXBvc2VDc1JlcS5wcm90byIxChpSb2d1ZU1h" + "Z2ljVW5pdENvbXBvc2VDc1JlcRITCgtJR0VBQk1GTENHQxgHIAMoDUIWqgIT" + "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueMagicUnitComposeCsReq), RogueMagicUnitComposeCsReq.Parser, new string[1] { "IGEABMFLCGC" }, null, null, null, null)
		}));
	}
}
