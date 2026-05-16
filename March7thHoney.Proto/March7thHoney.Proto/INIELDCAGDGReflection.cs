using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class INIELDCAGDGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static INIELDCAGDGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJTklFTERDQUdERy5wcm90byIeCgtJTklFTERDQUdERxIPCgdyZXRjb2Rl" + "GAUgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(INIELDCAGDG), INIELDCAGDG.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
