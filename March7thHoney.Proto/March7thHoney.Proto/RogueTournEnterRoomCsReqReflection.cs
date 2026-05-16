using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueTournEnterRoomCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueTournEnterRoomCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5Sb2d1ZVRvdXJuRW50ZXJSb29tQ3NSZXEucHJvdG8iRAoYUm9ndWVUb3Vy" + "bkVudGVyUm9vbUNzUmVxEhMKC01OTUFGS0xPSkNDGAggASgNEhMKC0xOT0RP" + "Sk9PUEJLGAwgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournEnterRoomCsReq), RogueTournEnterRoomCsReq.Parser, new string[2] { "MNMAFKLOJCC", "LNODOJOOPBK" }, null, null, null, null)
		}));
	}
}
