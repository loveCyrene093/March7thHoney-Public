using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SwordTrainingExamResultConfirmScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SwordTrainingExamResultConfirmScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CilTd29yZFRyYWluaW5nRXhhbVJlc3VsdENvbmZpcm1TY1JzcC5wcm90byI2" + "CiNTd29yZFRyYWluaW5nRXhhbVJlc3VsdENvbmZpcm1TY1JzcBIPCgdyZXRj" + "b2RlGAsgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SwordTrainingExamResultConfirmScRsp), SwordTrainingExamResultConfirmScRsp.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
