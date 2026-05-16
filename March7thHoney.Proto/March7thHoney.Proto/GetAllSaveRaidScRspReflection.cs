using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetAllSaveRaidScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetAllSaveRaidScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlHZXRBbGxTYXZlUmFpZFNjUnNwLnByb3RvGg5SYWlkRGF0YS5wcm90byJJ" + "ChNHZXRBbGxTYXZlUmFpZFNjUnNwEiEKDnJhaWRfZGF0YV9saXN0GAYgAygL" + "MgkuUmFpZERhdGESDwoHcmV0Y29kZRgHIAEoDUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { RaidDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetAllSaveRaidScRsp), GetAllSaveRaidScRsp.Parser, new string[2] { "RaidDataList", "Retcode" }, null, null, null, null)
		}));
	}
}
