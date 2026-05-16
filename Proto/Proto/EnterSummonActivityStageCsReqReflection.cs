using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EnterSummonActivityStageCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EnterSummonActivityStageCsReqReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "CiNFbnRlclN1bW1vbkFjdGl2aXR5U3RhZ2VDc1JlcS5wcm90bxoRT0xQRE5M";
		buffer[1] = "SkxGREwucHJvdG8ijAEKHUVudGVyU3VtbW9uQWN0aXZpdHlTdGFnZUNzUmVx";
		buffer[2] = "EhMKC0lOT01GRkFJRU9BGAEgASgNEiEKC0FCSkZKQkVDQ0RKGAMgASgLMgwu";
		buffer[3] = "T0xQRE5MSkxGREwSEAoIZ3JvdXBfaWQYCCABKA0SIQoLYXZhdGFyX2xpc3QY";
		buffer[4] = "CyADKAsyDC5PTFBETkxKTEZETEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG";
		buffer[5] = "cHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { OLPDNLJLFDLReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EnterSummonActivityStageCsReq), EnterSummonActivityStageCsReq.Parser, new string[4] { "INOMFFAIEOA", "ABJFJBECCDJ", "GroupId", "AvatarList" }, null, null, null, null)
		}));
	}
}
