using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SetDisplayAvatarScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SetDisplayAvatarScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtTZXREaXNwbGF5QXZhdGFyU2NSc3AucHJvdG8aF0Rpc3BsYXlBdmF0YXJE" + "YXRhLnByb3RvIlkKFVNldERpc3BsYXlBdmF0YXJTY1JzcBIPCgdyZXRjb2Rl" + "GAEgASgNEi8KE2Rpc3BsYXlfYXZhdGFyX2xpc3QYByADKAsyEi5EaXNwbGF5" + "QXZhdGFyRGF0YUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { DisplayAvatarDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetDisplayAvatarScRsp), SetDisplayAvatarScRsp.Parser, new string[2] { "Retcode", "DisplayAvatarList" }, null, null, null, null)
		}));
	}
}
