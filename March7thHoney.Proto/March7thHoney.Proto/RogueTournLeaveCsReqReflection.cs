using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueTournLeaveCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueTournLeaveCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpSb2d1ZVRvdXJuTGVhdmVDc1JlcS5wcm90byIWChRSb2d1ZVRvdXJuTGVh" + "dmVDc1JlcUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournLeaveCsReq), RogueTournLeaveCsReq.Parser, null, null, null, null, null)
		}));
	}
}
