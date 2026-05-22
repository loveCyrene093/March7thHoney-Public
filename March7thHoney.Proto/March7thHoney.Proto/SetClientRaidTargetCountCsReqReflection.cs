using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SetClientRaidTargetCountCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SetClientRaidTargetCountCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNTZXRDbGllbnRSYWlkVGFyZ2V0Q291bnRDc1JlcS5wcm90byJGCh1TZXRD" + "bGllbnRSYWlkVGFyZ2V0Q291bnRDc1JlcRIQCghwcm9ncmVzcxgDIAEoDRIT" + "CgtISkpNT09ISEtNSBgOIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetClientRaidTargetCountCsReq), SetClientRaidTargetCountCsReq.Parser, new string[2] { "Progress", "HJJMOOHHKMH" }, null, null, null, null)
		}));
	}
}
