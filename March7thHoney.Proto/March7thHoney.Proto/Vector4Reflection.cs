using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class Vector4Reflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static Vector4Reflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cg1WZWN0b3I0LnByb3RvIjUKB1ZlY3RvcjQSCQoBeBgCIAEoAhIJCgF5GAcg" + "ASgCEgkKAXcYDCABKAISCQoBehgNIAEoAkIWqgITTWFyY2g3dGhIb25leS5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(Vector4), Vector4.Parser, new string[4] { "X", "Y", "W", "Z" }, null, null, null, null)
		}));
	}
}
