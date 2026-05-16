using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DressSpecialEquipScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DressSpecialEquipScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxEcmVzc1NwZWNpYWxFcXVpcFNjUnNwLnByb3RvGhFHS0RFS0pLT0lKTi5w" + "cm90byJMChZEcmVzc1NwZWNpYWxFcXVpcFNjUnNwEg8KB3JldGNvZGUYByAB" + "KA0SIQoLQ1BPTU5HSkRCQ0wYDiADKAsyDC5HS0RFS0pLT0lKTkIWqgITTWFy" + "Y2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { GKDEKJKOIJNReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DressSpecialEquipScRsp), DressSpecialEquipScRsp.Parser, new string[2] { "Retcode", "CPOMNGJDBCL" }, null, null, null, null)
		}));
	}
}
