using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChessRogueCheatRollCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChessRogueCheatRollCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5DaGVzc1JvZ3VlQ2hlYXRSb2xsQ3NSZXEucHJvdG8iRAoYQ2hlc3NSb2d1" + "ZUNoZWF0Um9sbENzUmVxEhMKC0JHUEJJTURDQkJMGAMgASgNEhMKC0NDT0dG" + "S0xPRktMGAogASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueCheatRollCsReq), ChessRogueCheatRollCsReq.Parser, new string[2] { "BGPBIMDCBBL", "CCOGFKLOFKL" }, null, null, null, null)
		}));
	}
}
