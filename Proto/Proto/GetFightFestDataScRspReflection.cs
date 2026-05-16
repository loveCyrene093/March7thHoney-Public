using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetFightFestDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetFightFestDataScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChtHZXRGaWdodEZlc3REYXRhU2NSc3AucHJvdG8aEU5QR0dET0xNTklFLnBy";
		buffer[1] = "b3RvIokBChVHZXRGaWdodEZlc3REYXRhU2NSc3ASEgoKaXRlbV92YWx1ZRgD";
		buffer[2] = "IAEoDRITCgtHSUdQSEpFQkRGTBgIIAMoDRIPCgdyZXRjb2RlGAogASgNEhAK";
		buffer[3] = "CHNjb3JlX2lkGA0gASgNEiQKDmNoYWxsZW5nZV9saXN0GA4gAygLMgwuTlBH";
		buffer[4] = "R0RPTE1OSUVCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { NPGGDOLMNIEReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetFightFestDataScRsp), GetFightFestDataScRsp.Parser, new string[5] { "ItemValue", "GIGPHJEBDFL", "Retcode", "ScoreId", "ChallengeList" }, null, null, null, null)
		}));
	}
}
