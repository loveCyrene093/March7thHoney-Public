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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChxHZXRNaXNzaW9uTWVzc2FnZVNjUnNwLnByb3RvIpwBChZHZXRNaXNzaW9u";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "TWVzc2FnZVNjUnNwEg8KB3JldGNvZGUYAiABKA0SPQoLSkxPQU1LR0lJREsY";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "BCADKAsyKC5HZXRNaXNzaW9uTWVzc2FnZVNjUnNwLkpMT0FNS0dJSURLRW50";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "cnkaMgoQSkxPQU1LR0lJREtFbnRyeRILCgNrZXkYASABKA0SDQoFdmFsdWUY";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "AiABKA06AjgBQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetMissionMessageScRsp), GetMissionMessageScRsp.Parser, new string[2] { "Retcode", "JLOAMKGIIDK" }, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
