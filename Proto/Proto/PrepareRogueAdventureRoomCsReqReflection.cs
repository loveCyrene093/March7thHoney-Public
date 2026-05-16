using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PrepareRogueAdventureRoomCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PrepareRogueAdventureRoomCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRQcmVwYXJlUm9ndWVBZHZlbnR1cmVSb29tQ3NSZXEucHJvdG8iIAoeUHJl" + "cGFyZVJvZ3VlQWR2ZW50dXJlUm9vbUNzUmVxQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PrepareRogueAdventureRoomCsReq), PrepareRogueAdventureRoomCsReq.Parser, null, null, null, null, null)
		}));
	}
}
