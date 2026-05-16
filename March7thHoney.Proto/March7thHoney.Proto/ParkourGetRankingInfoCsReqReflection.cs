using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ParkourGetRankingInfoCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ParkourGetRankingInfoCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBQYXJrb3VyR2V0UmFua2luZ0luZm9Dc1JlcS5wcm90byIcChpQYXJrb3Vy" + "R2V0UmFua2luZ0luZm9Dc1JlcUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ParkourGetRankingInfoCsReq), ParkourGetRankingInfoCsReq.Parser, null, null, null, null, null)
		}));
	}
}
