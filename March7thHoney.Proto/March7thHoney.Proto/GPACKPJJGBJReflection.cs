using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GPACKPJJGBJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GPACKPJJGBJReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHUEFDS1BKSkdCSi5wcm90byIeCgtHUEFDS1BKSkdCShIPCgdyZXRjb2Rl" + "GAkgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GPACKPJJGBJ), GPACKPJJGBJ.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
