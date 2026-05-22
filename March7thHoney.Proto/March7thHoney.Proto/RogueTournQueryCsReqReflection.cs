using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueTournQueryCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueTournQueryCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpSb2d1ZVRvdXJuUXVlcnlDc1JlcS5wcm90byIWChRSb2d1ZVRvdXJuUXVl" + "cnlDc1JlcUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournQueryCsReq), RogueTournQueryCsReq.Parser, null, null, null, null, null)
		}));
	}
}
