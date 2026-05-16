using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TarotBookUnlockInteractionCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TarotBookUnlockInteractionCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVUYXJvdEJvb2tVbmxvY2tJbnRlcmFjdGlvbkNzUmVxLnByb3RvIjYKH1Rh" + "cm90Qm9va1VubG9ja0ludGVyYWN0aW9uQ3NSZXESEwoLTEVQSkZITUNCR0oY" + "CyADKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TarotBookUnlockInteractionCsReq), TarotBookUnlockInteractionCsReq.Parser, new string[1] { "LEPJFHMCBGJ" }, null, null, null, null)
		}));
	}
}
