using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetPlayerDetailInfoCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetPlayerDetailInfoCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5HZXRQbGF5ZXJEZXRhaWxJbmZvQ3NSZXEucHJvdG8iJwoYR2V0UGxheWVy" + "RGV0YWlsSW5mb0NzUmVxEgsKA3VpZBgPIAEoDUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetPlayerDetailInfoCsReq), GetPlayerDetailInfoCsReq.Parser, new string[1] { "Uid" }, null, null, null, null)
		}));
	}
}
