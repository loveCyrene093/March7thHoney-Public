using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TrainPartyBuildingUpdateNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TrainPartyBuildingUpdateNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRUcmFpblBhcnR5QnVpbGRpbmdVcGRhdGVOb3RpZnkucHJvdG8aEUVKSENK" + "Q0xITEZMLnByb3RvIkMKHlRyYWluUGFydHlCdWlsZGluZ1VwZGF0ZU5vdGlm" + "eRIhCgtERkFMSEJCTU5GShgCIAMoCzIMLkVKSENKQ0xITEZMQhaqAhNNYXJj" + "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { EJHCJCLHLFLReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TrainPartyBuildingUpdateNotify), TrainPartyBuildingUpdateNotify.Parser, new string[1] { "DFALHBBMNFJ" }, null, null, null, null)
		}));
	}
}
