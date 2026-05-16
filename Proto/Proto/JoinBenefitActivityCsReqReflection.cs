using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JoinBenefitActivityCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JoinBenefitActivityCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5Kb2luQmVuZWZpdEFjdGl2aXR5Q3NSZXEucHJvdG8iLwoYSm9pbkJlbmVm" + "aXRBY3Rpdml0eUNzUmVxEhMKC0NPT09GRktJRE1DGAYgASgNQhaqAhNNYXJj" + "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JoinBenefitActivityCsReq), JoinBenefitActivityCsReq.Parser, new string[1] { "COOOFFKIDMC" }, null, null, null, null)
		}));
	}
}
