using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MonopolyTakeRaffleTicketRewardScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MonopolyTakeRaffleTicketRewardScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CilNb25vcG9seVRha2VSYWZmbGVUaWNrZXRSZXdhcmRTY1JzcC5wcm90bxoO";
		buffer[1] = "SXRlbUxpc3QucHJvdG8igAEKI01vbm9wb2x5VGFrZVJhZmZsZVRpY2tldFJl";
		buffer[2] = "d2FyZFNjUnNwEh4KC3Jld2FyZF9saXN0GAMgASgLMgkuSXRlbUxpc3QSDwoH";
		buffer[3] = "cmV0Y29kZRgMIAEoDRITCgtNQk1JQ0NKRUJKQhgNIAEoDRITCgtDQk9NSENE";
		buffer[4] = "TkVERxgOIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyTakeRaffleTicketRewardScRsp), MonopolyTakeRaffleTicketRewardScRsp.Parser, new string[4] { "RewardList", "Retcode", "MBMICCJEBJB", "CBOMHCDNEDG" }, null, null, null, null)
		}));
	}
}
