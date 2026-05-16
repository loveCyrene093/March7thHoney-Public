using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChooseAvatarScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChooseAvatarScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdDaG9vc2VBdmF0YXJTY1JzcC5wcm90byI3ChFDaG9vc2VBdmF0YXJTY1Jz" + "cBIPCgdyZXRjb2RlGAEgASgNEhEKCWF2YXRhcl9pZBgFIAEoDUIWqgITTWFy" + "Y2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChooseAvatarScRsp), ChooseAvatarScRsp.Parser, new string[2] { "Retcode", "AvatarId" }, null, null, null, null)
		}));
	}
}
