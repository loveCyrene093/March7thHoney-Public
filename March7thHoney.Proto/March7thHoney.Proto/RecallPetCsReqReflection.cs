using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RecallPetCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RecallPetCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRSZWNhbGxQZXRDc1JlcS5wcm90byIpCg5SZWNhbGxQZXRDc1JlcRIXCg9z" + "dW1tb25lZF9wZXRfaWQYBSABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i" + "BnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RecallPetCsReq), RecallPetCsReq.Parser, new string[1] { "SummonedPetId" }, null, null, null, null)
		}));
	}
}
