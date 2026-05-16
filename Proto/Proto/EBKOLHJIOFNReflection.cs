using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EBKOLHJIOFNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EBKOLHJIOFNReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFFQktPTEhKSU9GTi5wcm90byqBAQoLRUJLT0xISklPRk4SGwoXRUJLT0xI";
		buffer[1] = "SklPRk5fQkZMQUFKUEpJRUEQABIbChdFQktPTEhKSU9GTl9KQUNHTEVERkxF";
		buffer[2] = "QxABEhsKF0VCS09MSEpJT0ZOX0hLQUZIRlBQQkhBEAISGwoXRUJLT0xISklP";
		buffer[3] = "Rk5fSkJCQ0lFSkJQRkwQA0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv";
		buffer[4] = "dG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(EBKOLHJIOFN) }, null, null));
	}
}
