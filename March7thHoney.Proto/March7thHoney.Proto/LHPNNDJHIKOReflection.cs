using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LHPNNDJHIKOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LHPNNDJHIKOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFMSFBOTkRKSElLTy5wcm90byIzCgtMSFBOTkRKSElLTxIMCgR0aW1lGAYg" + "ASgDEhYKDmRpeV9keW5hbWljX2lkGA4gASgNQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LHPNNDJHIKO), LHPNNDJHIKO.Parser, new string[2] { "Time", "DiyDynamicId" }, null, null, null, null)
		}));
	}
}
