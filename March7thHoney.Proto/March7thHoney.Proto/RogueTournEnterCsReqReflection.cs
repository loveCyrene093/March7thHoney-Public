using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueTournEnterCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueTournEnterCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpSb2d1ZVRvdXJuRW50ZXJDc1JlcS5wcm90byIWChRSb2d1ZVRvdXJuRW50" + "ZXJDc1JlcUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournEnterCsReq), RogueTournEnterCsReq.Parser, null, null, null, null, null)
		}));
	}
}
