using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class VideoKeyInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static VideoKeyInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChJWaWRlb0tleUluZm8ucHJvdG8iLQoMVmlkZW9LZXlJbmZvEhEKCXZpZGVv" + "X2tleRgDIAEoBBIKCgJpZBgGIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90" + "b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(VideoKeyInfo), VideoKeyInfo.Parser, new string[2] { "VideoKey", "Id" }, null, null, null, null)
		}));
	}
}
