using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChessRogueGiveUpCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChessRogueGiveUpCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtDaGVzc1JvZ3VlR2l2ZVVwQ3NSZXEucHJvdG8iFwoVQ2hlc3NSb2d1ZUdp" + "dmVVcENzUmVxQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueGiveUpCsReq), ChessRogueGiveUpCsReq.Parser, null, null, null, null, null)
		}));
	}
}
