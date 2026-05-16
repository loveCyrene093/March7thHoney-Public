using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChallengeStoryStatisticsReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChallengeStoryStatisticsReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5DaGFsbGVuZ2VTdG9yeVN0YXRpc3RpY3MucHJvdG8aEVBMSkpFQ1BDTUpE" + "LnByb3RvIlAKGENoYWxsZW5nZVN0b3J5U3RhdGlzdGljcxIhCgtOQ0VHRUtO" + "TEpDRRgFIAEoCzIMLlBMSkpFQ1BDTUpEEhEKCXJlY29yZF9pZBgPIAEoDUIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { PLJJECPCMJDReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChallengeStoryStatistics), ChallengeStoryStatistics.Parser, new string[2] { "NCEGEKNLJCE", "RecordId" }, null, null, null, null)
		}));
	}
}
