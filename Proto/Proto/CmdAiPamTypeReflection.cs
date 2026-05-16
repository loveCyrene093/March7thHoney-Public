using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdAiPamTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdAiPamTypeReflection()
	{
		_003C_003Ey__InlineArray18<string> buffer = default(_003C_003Ey__InlineArray18<string>);
		buffer[0] = "ChJDbWRBaVBhbVR5cGUucHJvdG8q5AUKDENtZEFpUGFtVHlwZRIbChdKQ0lP";
		buffer[1] = "R0xNR09QTV9GRUFPTEZPQ1BQShAAEiIKHUNtZEFpUGFtUmVzcG9uc2VGZWVk";
		buffer[2] = "YmFja1NjUnNwEK5KEh0KGENtZEdldEFpUGFtQ2hhdEluZm9TY1JzcBCeShIg";
		buffer[3] = "ChtDbWRVcGRhdGVBaVBhbVNldHRpbmdzU2NSc3AQu0oSIQocQ21kR2V0QWlQ";
		buffer[4] = "YW1OZXh0UXVlc3Rpb25TY1JzcBChShIeChlDbWRUcmlnZ2VyQWlQYW1TcGVh";
		buffer[5] = "a0NzUmVxEJ9KEh4KGUNtZFRyaWdnZXJBaVBhbVNwZWFrU2NSc3AQzkoSEwoO";
		buffer[6] = "Q21kSVBQQUNPT0dMUEsQokoSIAobQ21kR2V0QWlQYW1DaGF0SGlzdG9yeVNj";
		buffer[7] = "UnNwEL9KEiAKG0NtZEdldEFpUGFtQ2hhdEhpc3RvcnlDc1JlcRC3ShIpCiRD";
		buffer[8] = "bWRBaVBhbVJlc3BvbnNlRmVlZGJhY2tDb21tZW50Q3NSZXEQyUoSIAobQ21k";
		buffer[9] = "VXBkYXRlQWlQYW1TZXR0aW5nc0NzUmVxEKxKEhsKFkNtZEFpUGFtTW90aW9u";
		buffer[10] = "U2NOb3RpZnkQsUoSIgodQ21kUmVjdkFpUGFtQ2hhdEV2ZW50U2NOb3RpZnkQ";
		buffer[11] = "ukoSEwoOQ21kQUlLSE1JQU1CSUYQtkoSHQoYQ21kR2V0QWlQYW1DaGF0SW5m";
		buffer[12] = "b0NzUmVxEK9KEiIKHUNtZEFpUGFtUmVzcG9uc2VGZWVkYmFja0NzUmVxEMhK";
		buffer[13] = "EhMKDkNtZENHUEZOQ05BTU9QEM1KEhkKFENtZEFpUGFtU2VuZE1zZ1NjUnNw";
		buffer[14] = "EKNKEhMKDkNtZElNSExJSEFPQ1BFEKtKEikKJENtZEFpUGFtUmVzcG9uc2VG";
		buffer[15] = "ZWVkYmFja0NvbW1lbnRTY1JzcBDAShIhChxDbWRHZXRBaVBhbU5leHRRdWVz";
		buffer[16] = "dGlvbkNzUmVxEMJKEh0KGENtZEFpUGFtVGVhbUV4cGxhaW5Dc1JlcRCpSkIW";
		buffer[17] = "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdAiPamType) }, null, null));
	}
}
