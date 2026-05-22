using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SummonPetCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SummonPetCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRTdW1tb25QZXRDc1JlcS5wcm90byIpCg5TdW1tb25QZXRDc1JlcRIXCg9z" + "dW1tb25lZF9wZXRfaWQYCyABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i" + "BnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SummonPetCsReq), SummonPetCsReq.Parser, new string[1] { "SummonedPetId" }, null, null, null, null)
		}));
	}
}
