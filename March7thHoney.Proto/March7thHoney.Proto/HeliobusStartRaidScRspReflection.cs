using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HeliobusStartRaidScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HeliobusStartRaidScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxIZWxpb2J1c1N0YXJ0UmFpZFNjUnNwLnByb3RvGhFGTkpKQ0lHSklLQy5w" + "cm90byJGChZIZWxpb2J1c1N0YXJ0UmFpZFNjUnNwEg8KB3JldGNvZGUYAyAB" + "KA0SGwoFc2NlbmUYCSABKAsyDC5GTkpKQ0lHSklLQ0IWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { FNJJCIGJIKCReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HeliobusStartRaidScRsp), HeliobusStartRaidScRsp.Parser, new string[2] { "Retcode", "Scene" }, null, null, null, null)
		}));
	}
}
