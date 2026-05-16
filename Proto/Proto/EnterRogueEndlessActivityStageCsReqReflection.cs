using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EnterRogueEndlessActivityStageCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EnterRogueEndlessActivityStageCsReqReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CilFbnRlclJvZ3VlRW5kbGVzc0FjdGl2aXR5U3RhZ2VDc1JlcS5wcm90bxoR";
		buffer[1] = "RkNJTUNIREVQUEoucHJvdG8iXQojRW50ZXJSb2d1ZUVuZGxlc3NBY3Rpdml0";
		buffer[2] = "eVN0YWdlQ3NSZXESEwoLUEpNQkpCTUJLQ0UYAyABKA0SIQoLYXZhdGFyX2xp";
		buffer[3] = "c3QYDyADKAsyDC5GQ0lNQ0hERVBQSkIWqgITTWFyY2g3dGhIb25leS5Qcm90";
		buffer[4] = "b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { FCIMCHDEPPJReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EnterRogueEndlessActivityStageCsReq), EnterRogueEndlessActivityStageCsReq.Parser, new string[2] { "PJMBJBMBKCE", "AvatarList" }, null, null, null, null)
		}));
	}
}
