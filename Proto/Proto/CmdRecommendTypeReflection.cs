using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdRecommendTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdRecommendTypeReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChZDbWRSZWNvbW1lbmRUeXBlLnByb3RvKr0BChBDbWRSZWNvbW1lbmRUeXBl";
		buffer[1] = "EhsKF0tFSEpNT09NQkJBX1BDUERIRUxQS0VNEAASIAobQ21kR2V0QmlnRGF0";
		buffer[2] = "YVJlY29tbWVuZENzUmVxEOUSEiMKHkNtZEdldEJpZ0RhdGFBbGxSZWNvbW1l";
		buffer[3] = "bmRTY1JzcBDzEhIgChtDbWRHZXRCaWdEYXRhUmVjb21tZW5kU2NSc3AQ4RIS";
		buffer[4] = "IwoeQ21kR2V0QmlnRGF0YUFsbFJlY29tbWVuZENzUmVxEI8TQhaqAhNNYXJj";
		buffer[5] = "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdRecommendType) }, null, null));
	}
}
