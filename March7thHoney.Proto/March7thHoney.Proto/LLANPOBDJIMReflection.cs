using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LLANPOBDJIMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LLANPOBDJIMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFMTEFOUE9CREpJTS5wcm90byJkCgtMTEFOUE9CREpJTRIUCgxmaXJzdF9s" + "aW5ldXAYASADKA0SFQoNc2Vjb25kX2xpbmV1cBgCIAMoDRITCgtGRk1CQ0VF" + "R09MTxgDIAEoDRITCgtKQkZNSERMTUJGQRgEIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LLANPOBDJIM), LLANPOBDJIM.Parser, new string[4] { "FirstLineup", "SecondLineup", "FFMBCEEGOLO", "JBFMHDLMBFA" }, null, null, null, null)
		}));
	}
}
