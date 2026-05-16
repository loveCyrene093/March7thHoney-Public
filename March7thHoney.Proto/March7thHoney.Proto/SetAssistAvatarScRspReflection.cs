using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SetAssistAvatarScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SetAssistAvatarScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpTZXRBc3Npc3RBdmF0YXJTY1JzcC5wcm90byJSChRTZXRBc3Npc3RBdmF0" + "YXJTY1JzcBIWCg5hdmF0YXJfaWRfbGlzdBgGIAMoDRIPCgdyZXRjb2RlGAcg" + "ASgNEhEKCWF2YXRhcl9pZBgJIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90" + "b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetAssistAvatarScRsp), SetAssistAvatarScRsp.Parser, new string[3] { "AvatarIdList", "Retcode", "AvatarId" }, null, null, null, null)
		}));
	}
}
