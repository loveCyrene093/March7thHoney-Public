using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SwordTrainingResumeGameCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SwordTrainingResumeGameCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJTd29yZFRyYWluaW5nUmVzdW1lR2FtZUNzUmVxLnByb3RvIjoKHFN3b3Jk" + "VHJhaW5pbmdSZXN1bWVHYW1lQ3NSZXESGgoSZ2FtZV9zdG9yeV9saW5lX2lk" + "GA0gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SwordTrainingResumeGameCsReq), SwordTrainingResumeGameCsReq.Parser, new string[1] { "GameStoryLineId" }, null, null, null, null)
		}));
	}
}
