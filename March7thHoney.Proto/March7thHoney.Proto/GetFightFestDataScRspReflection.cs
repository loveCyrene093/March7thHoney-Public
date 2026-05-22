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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChtHZXRGaWdodEZlc3REYXRhU2NSc3AucHJvdG8aEU5QR0dET0xNTklFLnBy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "b3RvIokBChVHZXRGaWdodEZlc3REYXRhU2NSc3ASEgoKaXRlbV92YWx1ZRgD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "IAEoDRITCgtHSUdQSEpFQkRGTBgIIAMoDRIPCgdyZXRjb2RlGAogASgNEhAK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "CHNjb3JlX2lkGA0gASgNEiQKDmNoYWxsZW5nZV9saXN0GA4gAygLMgwuTlBH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "R0RPTE1OSUVCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { NPGGDOLMNIEReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetFightFestDataScRsp), GetFightFestDataScRsp.Parser, new string[5] { "ItemValue", "GIGPHJEBDFL", "Retcode", "ScoreId", "ChallengeList" }, null, null, null, null)
		}));
	}
}
