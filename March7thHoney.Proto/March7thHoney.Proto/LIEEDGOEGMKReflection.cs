using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LIEEDGOEGMKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LIEEDGOEGMKReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFMSUVFREdPRUdNSy5wcm90byIwCgtMSUVFREdPRUdNSxIMCgRnb2xkGAgg" + "ASgNEhMKC0NQTU9PS0ZLQkVHGA4gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlBy" + "b3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LIEEDGOEGMK), LIEEDGOEGMK.Parser, new string[2] { "Gold", "CPMOOKFKBEG" }, null, null, null, null)
		}));
	}
}
