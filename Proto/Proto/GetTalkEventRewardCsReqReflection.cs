using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetTalkEventRewardCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetTalkEventRewardCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1HZXRUYWxrRXZlbnRSZXdhcmRDc1JlcS5wcm90bxoMVmVjdG9yLnByb3Rv" + "IkwKF0dldFRhbGtFdmVudFJld2FyZENzUmVxEhMKC0pIT0FNSUxIQUlDGAEg" + "ASgNEhwKC0lMS0VGTERCTUxGGAkgASgLMgcuVmVjdG9yQhaqAhNNYXJjaDd0" + "aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { VectorReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetTalkEventRewardCsReq), GetTalkEventRewardCsReq.Parser, new string[2] { "JHOAMILHAIC", "ILKEFLDBMLF" }, null, null, null, null)
		}));
	}
}
