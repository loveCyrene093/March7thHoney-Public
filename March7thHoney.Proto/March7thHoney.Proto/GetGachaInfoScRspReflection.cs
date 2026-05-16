using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetGachaInfoScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetGachaInfoScRspReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "ChdHZXRHYWNoYUluZm9TY1JzcC5wcm90bxoPR2FjaGFJbmZvLnByb3RvGhFP";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "RUlFSkhCQ09PTS5wcm90byLBAQoRR2V0R2FjaGFJbmZvU2NSc3ASDwoHcmV0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "Y29kZRgBIAEoDRITCgtFSEtGUE1KQ0VNSRgCIAEoDRIjCg9nYWNoYV9pbmZv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "X2xpc3QYAyADKAsyCi5HYWNoYUluZm8SFAoMZ2FjaGFfcmFuZG9tGAYgASgN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "EhMKC0dMRFBLS0hPRExKGAsgASgNEiEKC05NQkFBT0JCSk1JGAwgAygLMgwu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "T0VJRUpIQkNPT00SEwoLQ0VMRkNFTEZNSkQYDyABKA1CFqoCE01hcmNoN3Ro";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "SG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[2]
		{
			GachaInfoReflection.Descriptor,
			OEIEJHBCOOMReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetGachaInfoScRsp), GetGachaInfoScRsp.Parser, new string[7] { "Retcode", "EHKFPMJCEMI", "GachaInfoList", "GachaRandom", "GLDPKKHODLJ", "NMBAAOBBJMI", "CELFCELFMJD" }, null, null, null, null)
		}));
	}
}
