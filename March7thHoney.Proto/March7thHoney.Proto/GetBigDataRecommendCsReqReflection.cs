using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetBigDataRecommendCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetBigDataRecommendCsReqReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "Ch5HZXRCaWdEYXRhUmVjb21tZW5kQ3NSZXEucHJvdG8aGkJpZ0RhdGFSZWNv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "bW1lbmRUeXBlLnByb3RvImgKGEdldEJpZ0RhdGFSZWNvbW1lbmRDc1JlcRI2";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "ChdiaWdfZGF0YV9yZWNvbW1lbmRfdHlwZRgCIAEoDjIVLkJpZ0RhdGFSZWNv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "bW1lbmRUeXBlEhQKDGVxdWlwX2F2YXRhchgJIAEoDUIWqgITTWFyY2g3dGhI";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "b25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { BigDataRecommendTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetBigDataRecommendCsReq), GetBigDataRecommendCsReq.Parser, new string[2] { "BigDataRecommendType", "EquipAvatar" }, null, null, null, null)
		}));
	}
}
