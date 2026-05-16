using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AcceptMultipleExpeditionCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AcceptMultipleExpeditionCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNBY2NlcHRNdWx0aXBsZUV4cGVkaXRpb25Dc1JlcS5wcm90bxoURXhwZWRp" + "dGlvbkluZm8ucHJvdG8iRAodQWNjZXB0TXVsdGlwbGVFeHBlZGl0aW9uQ3NS" + "ZXESIwoKZXhwZWRpdGlvbhgNIAMoCzIPLkV4cGVkaXRpb25JbmZvQhaqAhNN" + "YXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { ExpeditionInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AcceptMultipleExpeditionCsReq), AcceptMultipleExpeditionCsReq.Parser, new string[1] { "Expedition" }, null, null, null, null)
		}));
	}
}
