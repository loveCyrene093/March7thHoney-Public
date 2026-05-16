using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetNpcTakenRewardScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetNpcTakenRewardScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxHZXROcGNUYWtlblJld2FyZFNjUnNwLnByb3RvIlIKFkdldE5wY1Rha2Vu" + "UmV3YXJkU2NSc3ASDwoHcmV0Y29kZRgDIAEoDRIXCg90YWxrX2V2ZW50X2xp" + "c3QYBCADKA0SDgoGbnBjX2lkGA8gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlBy" + "b3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetNpcTakenRewardScRsp), GetNpcTakenRewardScRsp.Parser, new string[3] { "Retcode", "TalkEventList", "NpcId" }, null, null, null, null)
		}));
	}
}
