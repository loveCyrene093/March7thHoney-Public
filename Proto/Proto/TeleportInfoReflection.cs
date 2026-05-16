using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TeleportInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TeleportInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChJUZWxlcG9ydEluZm8ucHJvdG8iMwoMVGVsZXBvcnRJbmZvEhMKC3RlbGVw" + "b3J0X2lkGAggASgNEg4KBnJlYXNvbhgJIAEoDUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TeleportInfo), TeleportInfo.Parser, new string[2] { "TeleportId", "Reason" }, null, null, null, null)
		}));
	}
}
