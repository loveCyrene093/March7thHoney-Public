using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SubmitOfferingItemCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SubmitOfferingItemCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1TdWJtaXRPZmZlcmluZ0l0ZW1Dc1JlcS5wcm90byJRChdTdWJtaXRPZmZl" + "cmluZ0l0ZW1Dc1JlcRIhChlpbnRlcmFjdGVkX3Byb3BfZW50aXR5X2lkGAog" + "ASgNEhMKC29mZmVyaW5nX2lkGA0gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlBy" + "b3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SubmitOfferingItemCsReq), SubmitOfferingItemCsReq.Parser, new string[2] { "InteractedPropEntityId", "OfferingId" }, null, null, null, null)
		}));
	}
}
