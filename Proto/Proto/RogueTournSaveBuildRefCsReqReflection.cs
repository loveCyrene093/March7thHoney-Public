using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueTournSaveBuildRefCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueTournSaveBuildRefCsReqReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiFSb2d1ZVRvdXJuU2F2ZUJ1aWxkUmVmQ3NSZXEucHJvdG8aEUFLQ0ZMUEVB";
		buffer[1] = "TkpCLnByb3RvImMKG1JvZ3VlVG91cm5TYXZlQnVpbGRSZWZDc1JlcRITCgtL";
		buffer[2] = "S0dJRUVOQ09JQxgJIAEoDRIMCgRuYW1lGA0gASgJEiEKC0VPR0FDSUxMRUJP";
		buffer[3] = "GA4gASgLMgwuQUtDRkxQRUFOSkJCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i";
		buffer[4] = "BnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { AKCFLPEANJBReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournSaveBuildRefCsReq), RogueTournSaveBuildRefCsReq.Parser, new string[3] { "KKGIEENCOIC", "Name", "EOGACILLEBO" }, null, null, null, null)
		}));
	}
}
