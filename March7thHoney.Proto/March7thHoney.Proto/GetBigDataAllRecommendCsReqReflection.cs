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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CiFHZXRCaWdEYXRhQWxsUmVjb21tZW5kQ3NSZXEucHJvdG8aGkJpZ0RhdGFS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "ZWNvbW1lbmRUeXBlLnByb3RvIlUKG0dldEJpZ0RhdGFBbGxSZWNvbW1lbmRD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "c1JlcRI2ChdiaWdfZGF0YV9yZWNvbW1lbmRfdHlwZRgBIAEoDjIVLkJpZ0Rh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "dGFSZWNvbW1lbmRUeXBlQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { BigDataRecommendTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetBigDataAllRecommendCsReq), GetBigDataAllRecommendCsReq.Parser, new string[1] { "BigDataRecommendType" }, null, null, null, null)
		}));
	}
}
