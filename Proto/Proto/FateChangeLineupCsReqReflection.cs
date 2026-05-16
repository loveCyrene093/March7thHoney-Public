using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FateChangeLineupCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FateChangeLineupCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtGYXRlQ2hhbmdlTGluZXVwQ3NSZXEucHJvdG8aEUhBSkFPR0dQQ0pDLnBy" + "b3RvIjoKFUZhdGVDaGFuZ2VMaW5ldXBDc1JlcRIhCgthdmF0YXJfbGlzdBgK" + "IAMoCzIMLkhBSkFPR0dQQ0pDQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw" + "cm90bzM="), new FileDescriptor[1] { HAJAOGGPCJCReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FateChangeLineupCsReq), FateChangeLineupCsReq.Parser, new string[1] { "AvatarList" }, null, null, null, null)
		}));
	}
}
