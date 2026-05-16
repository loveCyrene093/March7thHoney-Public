using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class UpdateMarkChestCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static UpdateMarkChestCsReqReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChpVcGRhdGVNYXJrQ2hlc3RDc1JlcS5wcm90bxoTTWFya0NoZXN0SW5mby5w";
		buffer[1] = "cm90byJvChRVcGRhdGVNYXJrQ2hlc3RDc1JlcRIYChB0cmlnZ2VyX3BhcmFt";
		buffer[2] = "X2lkGAEgASgNEg8KB2Z1bmNfaWQYAiABKA0SLAoUbWFya19jaGVzdF9pbmZv";
		buffer[3] = "X2xpc3QYCiADKAsyDi5NYXJrQ2hlc3RJbmZvQhaqAhNNYXJjaDd0aEhvbmV5";
		buffer[4] = "LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { MarkChestInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(UpdateMarkChestCsReq), UpdateMarkChestCsReq.Parser, new string[3] { "TriggerParamId", "FuncId", "MarkChestInfoList" }, null, null, null, null)
		}));
	}
}
