using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OOCOMIOPINMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OOCOMIOPINMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPT0NPTUlPUElOTS5wcm90byJFCgtPT0NPTUlPUElOTRIhChlpbnRlcmFj" + "dGVkX3Byb3BfZW50aXR5X2lkGAYgASgNEhMKC0RDQkpOSUxGQkFHGA0gAygN" + "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OOCOMIOPINM), OOCOMIOPINM.Parser, new string[2] { "InteractedPropEntityId", "DCBJNILFBAG" }, null, null, null, null)
		}));
	}
}
