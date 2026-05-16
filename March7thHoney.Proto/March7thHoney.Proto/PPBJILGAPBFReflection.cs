using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PPBJILGAPBFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PPBJILGAPBFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQUEJKSUxHQVBCRi5wcm90bxoMVmVjdG9yLnByb3RvIlIKC1BQQkpJTEdB" + "UEJGEiUKHWFzc2lzdF9tb25zdGVyX2VudGl0eV9pZF9saXN0GAYgAygNEhwK" + "C0dHRFBBQUpGTUpCGA8gASgLMgcuVmVjdG9yQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { VectorReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PPBJILGAPBF), PPBJILGAPBF.Parser, new string[2] { "AssistMonsterEntityIdList", "GGDPAAJFMJB" }, null, null, null, null)
		}));
	}
}
