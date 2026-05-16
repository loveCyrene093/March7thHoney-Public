using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetRechargeBenefitInfoCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetRechargeBenefitInfoCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFHZXRSZWNoYXJnZUJlbmVmaXRJbmZvQ3NSZXEucHJvdG8iHQobR2V0UmVj" + "aGFyZ2VCZW5lZml0SW5mb0NzUmVxQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv" + "YgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetRechargeBenefitInfoCsReq), GetRechargeBenefitInfoCsReq.Parser, null, null, null, null, null)
		}));
	}
}
