using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetMissionMessageScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetMissionMessageScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChxHZXRNaXNzaW9uTWVzc2FnZVNjUnNwLnByb3RvIpwBChZHZXRNaXNzaW9u";
		buffer[1] = "TWVzc2FnZVNjUnNwEg8KB3JldGNvZGUYAiABKA0SPQoLSkxPQU1LR0lJREsY";
		buffer[2] = "BCADKAsyKC5HZXRNaXNzaW9uTWVzc2FnZVNjUnNwLkpMT0FNS0dJSURLRW50";
		buffer[3] = "cnkaMgoQSkxPQU1LR0lJREtFbnRyeRILCgNrZXkYASABKA0SDQoFdmFsdWUY";
		buffer[4] = "AiABKA06AjgBQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetMissionMessageScRsp), GetMissionMessageScRsp.Parser, new string[2] { "Retcode", "JLOAMKGIIDK" }, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
