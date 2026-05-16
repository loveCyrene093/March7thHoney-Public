using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetSaveRaidCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetSaveRaidCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZHZXRTYXZlUmFpZENzUmVxLnByb3RvIjgKEEdldFNhdmVSYWlkQ3NSZXES" + "DwoHcmFpZF9pZBgGIAEoDRITCgt3b3JsZF9sZXZlbBgOIAEoDUIWqgITTWFy" + "Y2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetSaveRaidCsReq), GetSaveRaidCsReq.Parser, new string[2] { "RaidId", "WorldLevel" }, null, null, null, null)
		}));
	}
}
