using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EPLIGJEGEMJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EPLIGJEGEMJReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFUExJR0pFR0VNSi5wcm90byIqCgtFUExJR0pFR0VNShILCgNrZXkYCiAB" + "KA0SDgoGZGFtYWdlGA4gASgBQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw" + "cm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EPLIGJEGEMJ), EPLIGJEGEMJ.Parser, new string[2] { "Key", "Damage" }, null, null, null, null)
		}));
	}
}
