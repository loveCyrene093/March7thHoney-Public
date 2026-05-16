using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FinishPveStageScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FinishPveStageScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlGaW5pc2hQdmVTdGFnZVNjUnNwLnByb3RvGg5JdGVtTGlzdC5wcm90byJm" + "ChNGaW5pc2hQdmVTdGFnZVNjUnNwEhkKBnJld2FyZBgCIAEoCzIJLkl0ZW1M" + "aXN0Eg8KB3JldGNvZGUYBSABKA0SDgoGaXNfd2luGAogASgIEhMKC01NTEtG" + "SklBS0tIGA8gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FinishPveStageScRsp), FinishPveStageScRsp.Parser, new string[4] { "Reward", "Retcode", "IsWin", "MMLKFJIAKKH" }, null, null, null, null)
		}));
	}
}
