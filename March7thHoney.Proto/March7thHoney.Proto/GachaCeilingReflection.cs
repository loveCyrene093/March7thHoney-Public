using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GachaCeilingReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GachaCeilingReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChJHYWNoYUNlaWxpbmcucHJvdG8aGEdhY2hhQ2VpbGluZ0F2YXRhci5wcm90" + "byJhCgxHYWNoYUNlaWxpbmcSKAoLYXZhdGFyX2xpc3QYCCADKAsyEy5HYWNo" + "YUNlaWxpbmdBdmF0YXISEwoLY2VpbGluZ19udW0YCyABKA0SEgoKaXNfY2xh" + "aW1lZBgPIAEoCEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { GachaCeilingAvatarReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GachaCeiling), GachaCeiling.Parser, new string[3] { "AvatarList", "CeilingNum", "IsClaimed" }, null, null, null, null)
		}));
	}
}
