using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetBigDataRecommendScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetBigDataRecommendScRspReflection()
	{
		InlineArray11<string> buffer = default(InlineArray11<string>);
		buffer[0] = "Ch5HZXRCaWdEYXRhUmVjb21tZW5kU2NSc3AucHJvdG8aGkJpZ0RhdGFSZWNv";
		buffer[1] = "bW1lbmRUeXBlLnByb3RvGhFFQkpETUtQRENOSy5wcm90bxoYRXF1aXBtZW50";
		buffer[2] = "UmVjb21tZW5kLnByb3RvGhRSZWxpY1JlY29tbWVuZC5wcm90byKnAgoYR2V0";
		buffer[3] = "QmlnRGF0YVJlY29tbWVuZFNjUnNwEhQKDGVxdWlwX2F2YXRhchgEIAEoDRIV";
		buffer[4] = "Cg1oYXNfcmVjb21tYW5kGAYgASgIEg8KB3JldGNvZGUYByABKA0SNgoXYmln";
		buffer[5] = "X2RhdGFfcmVjb21tZW5kX3R5cGUYDyABKA4yFS5CaWdEYXRhUmVjb21tZW5k";
		buffer[6] = "VHlwZRIqCg9yZWxpY19yZWNvbW1lbmQYAiABKAsyDy5SZWxpY1JlY29tbWVu";
		buffer[7] = "ZEgAEjIKE2VxdWlwbWVudF9yZWNvbW1lbmQYDCABKAsyEy5FcXVpcG1lbnRS";
		buffer[8] = "ZWNvbW1lbmRIABIjCgtHSUpPR0tCTURJUBgOIAEoCzIMLkVCSkRNS1BEQ05L";
		buffer[9] = "SABCEAoOcmVjb21tZW5kX3R5cGVCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i";
		buffer[10] = "BnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[4]
		{
			BigDataRecommendTypeReflection.Descriptor,
			EBJDMKPDCNKReflection.Descriptor,
			EquipmentRecommendReflection.Descriptor,
			RelicRecommendReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetBigDataRecommendScRsp), GetBigDataRecommendScRsp.Parser, new string[7] { "EquipAvatar", "HasRecommand", "Retcode", "BigDataRecommendType", "RelicRecommend", "EquipmentRecommend", "GIJOGKBMDIP" }, new string[1] { "RecommendType" }, null, null, null)
		}));
	}
}
