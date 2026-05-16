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
		buffer[0] = "Ch9TaGFyZVB1bmtMb3JkTW9uc3RlclNjUnNwLnByb3RvGhdQdW5rTG9yZFNo";
		buffer[1] = "YXJlVHlwZS5wcm90byJ1ChlTaGFyZVB1bmtMb3JkTW9uc3RlclNjUnNwEhIK";
		buffer[2] = "Cm1vbnN0ZXJfaWQYBCABKA0SJgoKc2hhcmVfdHlwZRgGIAEoDjISLlB1bmtM";
		buffer[3] = "b3JkU2hhcmVUeXBlEg8KB3JldGNvZGUYCSABKA0SCwoDdWlkGA0gASgNQhaq";
		buffer[4] = "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { PunkLordShareTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SharePunkLordMonsterScRsp), SharePunkLordMonsterScRsp.Parser, new string[4] { "MonsterId", "ShareType", "Retcode", "Uid" }, null, null, null, null)
		}));
	}
}
