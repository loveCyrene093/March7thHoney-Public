using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class StopRogueAdventureRoomCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static StopRogueAdventureRoomCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFTdG9wUm9ndWVBZHZlbnR1cmVSb29tQ3NSZXEucHJvdG8iRwobU3RvcFJv" + "Z3VlQWR2ZW50dXJlUm9vbUNzUmVxEhMKC0tHRVBHTktJSUlFGAEgASgNEhMK" + "C09BQ0xJSEtDTktHGA8gAygNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw" + "cm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(StopRogueAdventureRoomCsReq), StopRogueAdventureRoomCsReq.Parser, new string[2] { "KGEPGNKIIIE", "OACLIHKCNKG" }, null, null, null, null)
		}));
	}
}
