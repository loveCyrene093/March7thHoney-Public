using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TarotBookUnlockInteractionScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TarotBookUnlockInteractionScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVUYXJvdEJvb2tVbmxvY2tJbnRlcmFjdGlvblNjUnNwLnByb3RvIkcKH1Rh" + "cm90Qm9va1VubG9ja0ludGVyYWN0aW9uU2NSc3ASEwoLTEVQSkZITUNCR0oY" + "AyADKA0SDwoHcmV0Y29kZRgPIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90" + "b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TarotBookUnlockInteractionScRsp), TarotBookUnlockInteractionScRsp.Parser, new string[2] { "LEPJFHMCBGJ", "Retcode" }, null, null, null, null)
		}));
	}
}
