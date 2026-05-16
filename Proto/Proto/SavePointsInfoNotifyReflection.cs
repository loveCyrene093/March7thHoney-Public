using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SavePointsInfoNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SavePointsInfoNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpTYXZlUG9pbnRzSW5mb05vdGlmeS5wcm90byJBChRTYXZlUG9pbnRzSW5m" + "b05vdGlmeRIUCgxyZWZyZXNoX3RpbWUYBCABKAMSEwoLdmFsaWRfdGltZXMY" + "DiABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SavePointsInfoNotify), SavePointsInfoNotify.Parser, new string[2] { "RefreshTime", "ValidTimes" }, null, null, null, null)
		}));
	}
}
