using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetRogueAdventureRoomInfoCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetRogueAdventureRoomInfoCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRHZXRSb2d1ZUFkdmVudHVyZVJvb21JbmZvQ3NSZXEucHJvdG8iIAoeR2V0" + "Um9ndWVBZHZlbnR1cmVSb29tSW5mb0NzUmVxQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetRogueAdventureRoomInfoCsReq), GetRogueAdventureRoomInfoCsReq.Parser, null, null, null, null, null)
		}));
	}
}
