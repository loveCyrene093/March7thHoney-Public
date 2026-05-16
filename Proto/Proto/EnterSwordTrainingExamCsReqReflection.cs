using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EnterSwordTrainingExamCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EnterSwordTrainingExamCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFFbnRlclN3b3JkVHJhaW5pbmdFeGFtQ3NSZXEucHJvdG8iHQobRW50ZXJT" + "d29yZFRyYWluaW5nRXhhbUNzUmVxQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv" + "YgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EnterSwordTrainingExamCsReq), EnterSwordTrainingExamCsReq.Parser, null, null, null, null, null)
		}));
	}
}
