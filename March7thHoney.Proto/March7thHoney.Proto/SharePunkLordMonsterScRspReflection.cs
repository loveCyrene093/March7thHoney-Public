using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SharePunkLordMonsterScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SharePunkLordMonsterScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "Ch9TaGFyZVB1bmtMb3JkTW9uc3RlclNjUnNwLnByb3RvGhdQdW5rTG9yZFNo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "YXJlVHlwZS5wcm90byJ1ChlTaGFyZVB1bmtMb3JkTW9uc3RlclNjUnNwEhIK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "Cm1vbnN0ZXJfaWQYBCABKA0SJgoKc2hhcmVfdHlwZRgGIAEoDjISLlB1bmtM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "b3JkU2hhcmVUeXBlEg8KB3JldGNvZGUYCSABKA0SCwoDdWlkGA0gASgNQhaq";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { PunkLordShareTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SharePunkLordMonsterScRsp), SharePunkLordMonsterScRsp.Parser, new string[4] { "MonsterId", "ShareType", "Retcode", "Uid" }, null, null, null, null)
		}));
	}
}
