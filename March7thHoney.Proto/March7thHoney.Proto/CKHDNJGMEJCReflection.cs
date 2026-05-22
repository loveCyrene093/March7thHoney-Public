using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CKHDNJGMEJCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CKHDNJGMEJCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDS0hETkpHTUVKQy5wcm90byIwCgtDS0hETkpHTUVKQxILCgNudW0YBCAB" + "KA0SFAoMcGFzc2VuZ2VyX2lkGAkgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlBy" + "b3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CKHDNJGMEJC), CKHDNJGMEJC.Parser, new string[2] { "Num", "PassengerId" }, null, null, null, null)
		}));
	}
}
