using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class VectorSnapshotReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static VectorSnapshotReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRWZWN0b3JTbmFwc2hvdC5wcm90byIxCg5WZWN0b3JTbmFwc2hvdBIJCgF4" + "GAEgASgREgkKAXkYAiABKBESCQoBehgDIAEoEUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(VectorSnapshot), VectorSnapshot.Parser, new string[3] { "X", "Y", "Z" }, null, null, null, null)
		}));
	}
}
