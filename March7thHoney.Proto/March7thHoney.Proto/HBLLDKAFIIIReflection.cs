using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HBLLDKAFIIIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HBLLDKAFIIIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFIQkxMREtBRklJSS5wcm90bxoRTEtERk9PSk1ISUUucHJvdG8iUwoLSEJM" + "TERLQUZJSUkSIQoLRUVLR0dCTEhOSFAYBCABKAsyDC5MS0RGT09KTUhJRRIh" + "CgtCT0tNQ0JIT0NJSxgIIAEoCzIMLkxLREZPT0pNSElFQhaqAhNNYXJjaDd0" + "aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { LKDFOOJMHIEReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HBLLDKAFIII), HBLLDKAFIII.Parser, new string[2] { "EEKGGBLHNHP", "BOKMCBHOCIK" }, null, null, null, null)
		}));
	}
}
