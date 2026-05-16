using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SwitchHandResetTransformCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SwitchHandResetTransformCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNTd2l0Y2hIYW5kUmVzZXRUcmFuc2Zvcm1Dc1JlcS5wcm90bxoQTW90aW9u" + "SW5mby5wcm90byJUCh1Td2l0Y2hIYW5kUmVzZXRUcmFuc2Zvcm1Dc1JlcRIg" + "CgtQTEZBT0NQQkJDUBgJIAEoCzILLk1vdGlvbkluZm8SEQoJY29uZmlnX2lk" + "GA0gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { MotionInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SwitchHandResetTransformCsReq), SwitchHandResetTransformCsReq.Parser, new string[2] { "PLFAOCPBBCP", "ConfigId" }, null, null, null, null)
		}));
	}
}
