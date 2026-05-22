using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JLAEDKMBGEKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JLAEDKMBGEKReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKTEFFREtNQkdFSy5wcm90byI8CgtKTEFFREtNQkdFSxILCgN0aWQYBCAB" + "KA0SCwoDbnVtGAsgASgNEhMKC2V4cGlyZV90aW1lGAwgASgEQhaqAhNNYXJj" + "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JLAEDKMBGEK), JLAEDKMBGEK.Parser, new string[3] { "Tid", "Num", "ExpireTime" }, null, null, null, null)
		}));
	}
}
