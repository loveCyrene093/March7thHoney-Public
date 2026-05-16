using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MatchThreeV2SetBirdPosCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MatchThreeV2SetBirdPosCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFNYXRjaFRocmVlVjJTZXRCaXJkUG9zQ3NSZXEucHJvdG8iPwobTWF0Y2hU" + "aHJlZVYyU2V0QmlyZFBvc0NzUmVxEgsKA3BvcxgBIAEoDRITCgtOTE9DREhN" + "TEdKSBgJIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MatchThreeV2SetBirdPosCsReq), MatchThreeV2SetBirdPosCsReq.Parser, new string[2] { "Pos", "NLOCDHMLGJH" }, null, null, null, null)
		}));
	}
}
