using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SwapLineupCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SwapLineupCsReqReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChVTd2FwTGluZXVwQ3NSZXEucHJvdG8aFUV4dHJhTGluZXVwVHlwZS5wcm90";
		buffer[1] = "byKdAQoPU3dhcExpbmV1cENzUmVxEhIKCmlzX3ZpcnR1YWwYASABKAgSEwoL";
		buffer[2] = "TkhOSEVKRUxDTU0YAiABKA0SDQoFaW5kZXgYCiABKA0SEAoIcGxhbmVfaWQY";
		buffer[3] = "CyABKA0SKwoRZXh0cmFfbGluZXVwX3R5cGUYDSABKA4yEC5FeHRyYUxpbmV1";
		buffer[4] = "cFR5cGUSEwoLSUlGTkFCS0hBRUcYDyABKA1CFqoCE01hcmNoN3RoSG9uZXku";
		buffer[5] = "UHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ExtraLineupTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SwapLineupCsReq), SwapLineupCsReq.Parser, new string[6] { "IsVirtual", "NHNHEJELCMM", "Index", "PlaneId", "ExtraLineupType", "IIFNABKHAEG" }, null, null, null, null)
		}));
	}
}
