using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KEBHKHCALBOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KEBHKHCALBOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLRUJIS0hDQUxCTy5wcm90bxoRS0ZLRElFQUpQQ0oucHJvdG8iRAoLS0VC" + "SEtIQ0FMQk8SIAoKYmxhY2tfbGlzdBgHIAEoCzIMLktGS0RJRUFKUENKEhMK" + "C0dOREpQTkJFQ0pQGAogASgIQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw" + "cm90bzM="), new FileDescriptor[1] { KFKDIEAJPCJReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KEBHKHCALBO), KEBHKHCALBO.Parser, new string[2] { "BlackList", "GNDJPNBECJP" }, null, null, null, null)
		}));
	}
}
