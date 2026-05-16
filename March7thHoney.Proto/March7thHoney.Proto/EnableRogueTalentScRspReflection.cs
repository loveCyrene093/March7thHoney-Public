using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EnableRogueTalentScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EnableRogueTalentScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxFbmFibGVSb2d1ZVRhbGVudFNjUnNwLnByb3RvGhFNQ0FDREZIQ1BJRS5w" + "cm90byJMChZFbmFibGVSb2d1ZVRhbGVudFNjUnNwEg8KB3JldGNvZGUYByAB" + "KA0SIQoLdGFsZW50X2luZm8YCiABKAsyDC5NQ0FDREZIQ1BJRUIWqgITTWFy" + "Y2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { MCACDFHCPIEReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EnableRogueTalentScRsp), EnableRogueTalentScRsp.Parser, new string[2] { "Retcode", "TalentInfo" }, null, null, null, null)
		}));
	}
}
