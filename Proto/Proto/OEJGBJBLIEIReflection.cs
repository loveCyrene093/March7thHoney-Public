using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OEJGBJBLIEIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OEJGBJBLIEIReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		buffer[0] = "ChFPRUpHQkpCTElFSS5wcm90bxoSRmF0ZUJ1ZmZEYXRhLnByb3RvGhFKREtB";
		buffer[1] = "Sk1FUEVDRi5wcm90byL5AQoLT0VKR0JKQkxJRUkSEwoLREVJRktNUEFGSEsY";
		buffer[2] = "ASADKA0SEwoLQkZESkpBUERKT0gYBCADKA0SIAoJYnVmZl9saXN0GAcgAygL";
		buffer[3] = "Mg0uRmF0ZUJ1ZmZEYXRhEjIKC0FBRUxQQkxQRkxKGAsgAygLMh0uT0VKR0JK";
		buffer[4] = "QkxJRUkuQUFFTFBCTFBGTEpFbnRyeRITCgtMUEdBS0pKRkxKThgMIAEoDRIh";
		buffer[5] = "CgtJTlBLRURFSUJKThgPIAMoCzIMLkpES0FKTUVQRUNGGjIKEEFBRUxQQkxQ";
		buffer[6] = "RkxKRW50cnkSCwoDa2V5GAEgASgNEg0KBXZhbHVlGAIgASgNOgI4AUIWqgIT";
		buffer[7] = "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			FateBuffDataReflection.Descriptor,
			JDKAJMEPECFReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OEJGBJBLIEI), OEJGBJBLIEI.Parser, new string[6] { "DEIFKMPAFHK", "BFDJJAPDJOH", "BuffList", "AAELPBLPFLJ", "LPGAKJJFLJN", "INPKEDEIBJN" }, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
