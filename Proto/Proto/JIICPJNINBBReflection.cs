using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JIICPJNINBBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JIICPJNINBBReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFKSUlDUEpOSU5CQi5wcm90bxoRTUhHQ05ERE1JSUoucHJvdG8igwEKC0pJ";
		buffer[1] = "SUNQSk5JTkJCEjIKC0pIRURJTkRDT0RFGAwgAygLMh0uSklJQ1BKTklOQkIu";
		buffer[2] = "SkhFRElORENPREVFbnRyeRpAChBKSEVESU5EQ09ERUVudHJ5EgsKA2tleRgB";
		buffer[3] = "IAEoDRIbCgV2YWx1ZRgCIAEoCzIMLk1IR0NORERNSUlKOgI4AUIWqgITTWFy";
		buffer[4] = "Y2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { MHGCNDDMIIJReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JIICPJNINBB), JIICPJNINBB.Parser, new string[1] { "JHEDINDCODE" }, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
