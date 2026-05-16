using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SyncLineupReasonReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SyncLineupReasonReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChZTeW5jTGluZXVwUmVhc29uLnByb3RvKvABChBTeW5jTGluZXVwUmVhc29u";
		buffer[1] = "EhQKEFNZTkNfUkVBU09OX05PTkUQABIWChJTWU5DX1JFQVNPTl9NUF9BREQQ";
		buffer[2] = "ARIfChtTWU5DX1JFQVNPTl9NUF9BRERfUFJPUF9ISVQQAhIWChJTWU5DX1JF";
		buffer[3] = "QVNPTl9IUF9BREQQAxIfChtTWU5DX1JFQVNPTl9IUF9BRERfUFJPUF9ISVQQ";
		buffer[4] = "BBIoCiRTWU5DX1JFQVNPTl9NUF9NQVhfQ0hBTkdFRF9QRVJNQU5FTlQQBRIq";
		buffer[5] = "CiZTWU5DX1JFQVNPTl9NUF9NQVhfQ0hBTkdFRF9CWV9NT0RJRklFUhAGQhaq";
		buffer[6] = "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(SyncLineupReason) }, null, null));
	}
}
