using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MDNNGCGIAKOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MDNNGCGIAKOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNRE5OR0NHSUFLTy5wcm90byJXCgtNRE5OR0NHSUFLTxINCgVsZXZlbBgD" + "IAEoDRIMCgRyYW5rGAQgASgNEgsKA3RpZBgGIAEoDRILCgNleHAYDCABKA0S" + "EQoJcHJvbW90aW9uGA4gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw" + "cm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MDNNGCGIAKO), MDNNGCGIAKO.Parser, new string[5] { "Level", "Rank", "Tid", "Exp", "Promotion" }, null, null, null, null)
		}));
	}
}
