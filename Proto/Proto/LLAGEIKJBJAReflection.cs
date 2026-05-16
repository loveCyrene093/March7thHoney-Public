using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LLAGEIKJBJAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LLAGEIKJBJAReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFMTEFHRUlLSkJKQS5wcm90bxoRRUZFR0tESEVNRk4ucHJvdG8aEUZCQk1E";
		buffer[1] = "RkRPRUVGLnByb3RvInMKC0xMQUdFSUtKQkpBEiAKCml0ZW1fdmFsdWUYAiAB";
		buffer[2] = "KAsyDC5FRkVHS0RIRU1GThIhCgtNRUJETEVEQ0dESRgNIAEoCzIMLkVGRUdL";
		buffer[3] = "REhFTUZOEh8KCWl0ZW1fbGlzdBgOIAMoCzIMLkZCQk1ERkRPRUVGQhaqAhNN";
		buffer[4] = "YXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			EFEGKDHEMFNReflection.Descriptor,
			FBBMDFDOEEFReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LLAGEIKJBJA), LLAGEIKJBJA.Parser, new string[3] { "ItemValue", "MEBDLEDCGDI", "ItemList" }, null, null, null, null)
		}));
	}
}
