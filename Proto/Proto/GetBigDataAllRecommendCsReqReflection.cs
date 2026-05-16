using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetBigDataAllRecommendCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetBigDataAllRecommendCsReqReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiFHZXRCaWdEYXRhQWxsUmVjb21tZW5kQ3NSZXEucHJvdG8aGkJpZ0RhdGFS";
		buffer[1] = "ZWNvbW1lbmRUeXBlLnByb3RvIlUKG0dldEJpZ0RhdGFBbGxSZWNvbW1lbmRD";
		buffer[2] = "c1JlcRI2ChdiaWdfZGF0YV9yZWNvbW1lbmRfdHlwZRgBIAEoDjIVLkJpZ0Rh";
		buffer[3] = "dGFSZWNvbW1lbmRUeXBlQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90";
		buffer[4] = "bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { BigDataRecommendTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetBigDataAllRecommendCsReq), GetBigDataAllRecommendCsReq.Parser, new string[1] { "BigDataRecommendType" }, null, null, null, null)
		}));
	}
}
