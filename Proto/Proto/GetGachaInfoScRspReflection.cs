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
		buffer[0] = "ChdHZXRHYWNoYUluZm9TY1JzcC5wcm90bxoPR2FjaGFJbmZvLnByb3RvGhFP";
		buffer[1] = "RUlFSkhCQ09PTS5wcm90byLBAQoRR2V0R2FjaGFJbmZvU2NSc3ASDwoHcmV0";
		buffer[2] = "Y29kZRgBIAEoDRITCgtFSEtGUE1KQ0VNSRgCIAEoDRIjCg9nYWNoYV9pbmZv";
		buffer[3] = "X2xpc3QYAyADKAsyCi5HYWNoYUluZm8SFAoMZ2FjaGFfcmFuZG9tGAYgASgN";
		buffer[4] = "EhMKC0dMRFBLS0hPRExKGAsgASgNEiEKC05NQkFBT0JCSk1JGAwgAygLMgwu";
		buffer[5] = "T0VJRUpIQkNPT00SEwoLQ0VMRkNFTEZNSkQYDyABKA1CFqoCE01hcmNoN3Ro";
		buffer[6] = "SG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			GachaInfoReflection.Descriptor,
			OEIEJHBCOOMReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetGachaInfoScRsp), GetGachaInfoScRsp.Parser, new string[7] { "Retcode", "EHKFPMJCEMI", "GachaInfoList", "GachaRandom", "GLDPKKHODLJ", "NMBAAOBBJMI", "CELFCELFMJD" }, null, null, null, null)
		}));
	}
}
