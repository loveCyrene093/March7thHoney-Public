using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetNpcTakenRewardCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetNpcTakenRewardCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxHZXROcGNUYWtlblJld2FyZENzUmVxLnByb3RvIigKFkdldE5wY1Rha2Vu" + "UmV3YXJkQ3NSZXESDgoGbnBjX2lkGAwgASgNQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetNpcTakenRewardCsReq), GetNpcTakenRewardCsReq.Parser, new string[1] { "NpcId" }, null, null, null, null)
		}));
	}
}
