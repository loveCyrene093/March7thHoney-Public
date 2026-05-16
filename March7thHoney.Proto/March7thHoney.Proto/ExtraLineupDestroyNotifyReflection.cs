using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ExtraLineupDestroyNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ExtraLineupDestroyNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5FeHRyYUxpbmV1cERlc3Ryb3lOb3RpZnkucHJvdG8aFUV4dHJhTGluZXVw" + "VHlwZS5wcm90byJHChhFeHRyYUxpbmV1cERlc3Ryb3lOb3RpZnkSKwoRZXh0" + "cmFfbGluZXVwX3R5cGUYBSABKA4yEC5FeHRyYUxpbmV1cFR5cGVCFqoCE01h" + "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { ExtraLineupTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ExtraLineupDestroyNotify), ExtraLineupDestroyNotify.Parser, new string[1] { "ExtraLineupType" }, null, null, null, null)
		}));
	}
}
