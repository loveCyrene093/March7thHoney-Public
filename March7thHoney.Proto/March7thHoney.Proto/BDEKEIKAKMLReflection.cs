using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BDEKEIKAKMLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BDEKEIKAKMLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCREVLRUlLQUtNTC5wcm90bxoRTkhGT0dEUEJPSE4ucHJvdG8iVgoLQkRF" + "S0VJS0FLTUwSEQoJcmVsaWNfaWRzGAEgAygNEiEKC0RGSUVIUElIRUVFGAgg" + "ASgLMgwuTkhGT0dEUEJPSE4SEQoJYXZhdGFyX2lkGA8gASgNQhaqAhNNYXJj" + "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { NHFOGDPBOHNReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BDEKEIKAKML), BDEKEIKAKML.Parser, new string[3] { "RelicIds", "DFIEHPIHEEE", "AvatarId" }, null, null, null, null)
		}));
	}
}
