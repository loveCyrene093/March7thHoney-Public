using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SetAssistAvatarCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SetAssistAvatarCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpTZXRBc3Npc3RBdmF0YXJDc1JlcS5wcm90byJBChRTZXRBc3Npc3RBdmF0" + "YXJDc1JlcRIWCg5hdmF0YXJfaWRfbGlzdBgCIAMoDRIRCglhdmF0YXJfaWQY" + "CyABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetAssistAvatarCsReq), SetAssistAvatarCsReq.Parser, new string[2] { "AvatarIdList", "AvatarId" }, null, null, null, null)
		}));
	}
}
