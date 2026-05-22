using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetBenefitActivityInfoCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetBenefitActivityInfoCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFHZXRCZW5lZml0QWN0aXZpdHlJbmZvQ3NSZXEucHJvdG8iHQobR2V0QmVu" + "ZWZpdEFjdGl2aXR5SW5mb0NzUmVxQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv" + "YgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetBenefitActivityInfoCsReq), GetBenefitActivityInfoCsReq.Parser, null, null, null, null, null)
		}));
	}
}
