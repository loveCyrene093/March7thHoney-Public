using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SpAddSourceReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SpAddSourceReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFTcEFkZFNvdXJjZS5wcm90byItCgtTcEFkZFNvdXJjZRIOCgZzb3VyY2UY" + "ASABKAkSDgoGc3BfYWRkGAIgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv" + "YgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SpAddSource), SpAddSource.Parser, new string[2] { "Source", "SpAdd" }, null, null, null, null)
		}));
	}
}
