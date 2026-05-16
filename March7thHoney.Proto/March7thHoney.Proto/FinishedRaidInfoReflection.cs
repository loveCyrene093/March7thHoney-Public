using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FinishedRaidInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FinishedRaidInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZGaW5pc2hlZFJhaWRJbmZvLnByb3RvIk0KEEZpbmlzaGVkUmFpZEluZm8S" + "DwoHcmFpZF9pZBgDIAEoDRITCgtMRkJGSkFFS0dPRhgHIAMoDRITCgt3b3Js" + "ZF9sZXZlbBgIIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FinishedRaidInfo), FinishedRaidInfo.Parser, new string[3] { "RaidId", "LFBFJAEKGOF", "WorldLevel" }, null, null, null, null)
		}));
	}
}
