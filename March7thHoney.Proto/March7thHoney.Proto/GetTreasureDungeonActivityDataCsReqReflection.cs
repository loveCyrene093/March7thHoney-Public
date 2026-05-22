using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetTreasureDungeonActivityDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetTreasureDungeonActivityDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CilHZXRUcmVhc3VyZUR1bmdlb25BY3Rpdml0eURhdGFDc1JlcS5wcm90byIl" + "CiNHZXRUcmVhc3VyZUR1bmdlb25BY3Rpdml0eURhdGFDc1JlcUIWqgITTWFy" + "Y2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetTreasureDungeonActivityDataCsReq), GetTreasureDungeonActivityDataCsReq.Parser, null, null, null, null, null)
		}));
	}
}
