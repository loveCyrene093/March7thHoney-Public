using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TrainPartyBuildDiyScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TrainPartyBuildDiyScRspReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "Ch1UcmFpblBhcnR5QnVpbGREaXlTY1JzcC5wcm90bxoVQXJlYUR5bmFtaWNJ";
		buffer[1] = "bmZvLnByb3RvGhFQUEVDTU9NTkFNRy5wcm90byKjAQoXVHJhaW5QYXJ0eUJ1";
		buffer[2] = "aWxkRGl5U2NSc3ASDwoHYXJlYV9pZBgEIAEoDRIpChN1cGRhdGVfZHluYW1p";
		buffer[3] = "Y19saXN0GAcgAygLMgwuUFBFQ01PTU5BTUcSDwoHcmV0Y29kZRgIIAEoDRIT";
		buffer[4] = "CgtBRkdOTERJTUJHQhgJIAEoCBImCgxkeW5hbWljX2luZm8YDSADKAsyEC5B";
		buffer[5] = "cmVhRHluYW1pY0luZm9CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv";
		buffer[6] = "Mw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			AreaDynamicInfoReflection.Descriptor,
			PPECMOMNAMGReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TrainPartyBuildDiyScRsp), TrainPartyBuildDiyScRsp.Parser, new string[5] { "AreaId", "UpdateDynamicList", "Retcode", "AFGNLDIMBGB", "DynamicInfo" }, null, null, null, null)
		}));
	}
}
