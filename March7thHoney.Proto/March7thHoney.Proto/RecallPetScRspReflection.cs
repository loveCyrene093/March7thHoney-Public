using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RecallPetScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RecallPetScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRSZWNhbGxQZXRTY1JzcC5wcm90byJMCg5SZWNhbGxQZXRTY1JzcBISCgpj" + "dXJfcGV0X2lkGAQgASgNEg8KB3JldGNvZGUYCSABKA0SFQoNc2VsZWN0X3Bl" + "dF9pZBgKIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RecallPetScRsp), RecallPetScRsp.Parser, new string[3] { "CurPetId", "Retcode", "SelectPetId" }, null, null, null, null)
		}));
	}
}
