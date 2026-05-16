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
		buffer[0] = "Ch5HZXRCaWdEYXRhUmVjb21tZW5kQ3NSZXEucHJvdG8aGkJpZ0RhdGFSZWNv";
		buffer[1] = "bW1lbmRUeXBlLnByb3RvImgKGEdldEJpZ0RhdGFSZWNvbW1lbmRDc1JlcRI2";
		buffer[2] = "ChdiaWdfZGF0YV9yZWNvbW1lbmRfdHlwZRgCIAEoDjIVLkJpZ0RhdGFSZWNv";
		buffer[3] = "bW1lbmRUeXBlEhQKDGVxdWlwX2F2YXRhchgJIAEoDUIWqgITTWFyY2g3dGhI";
		buffer[4] = "b25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { BigDataRecommendTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetBigDataRecommendCsReq), GetBigDataRecommendCsReq.Parser, new string[2] { "BigDataRecommendType", "EquipAvatar" }, null, null, null, null)
		}));
	}
}
