using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueTournUseSuperRewardKeyCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueTournUseSuperRewardKeyCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiZSb2d1ZVRvdXJuVXNlU3VwZXJSZXdhcmRLZXlDc1JlcS5wcm90byJeCiBS" + "b2d1ZVRvdXJuVXNlU3VwZXJSZXdhcmRLZXlDc1JlcRIYChBkaWZmaWN1bHR5" + "X2xldmVsGAEgASgNEg0KBWNvdW50GAwgASgNEhEKCWNvY29vbl9pZBgOIAEo" + "DUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournUseSuperRewardKeyCsReq), RogueTournUseSuperRewardKeyCsReq.Parser, new string[3] { "DifficultyLevel", "Count", "CocoonId" }, null, null, null, null)
		}));
	}
}
