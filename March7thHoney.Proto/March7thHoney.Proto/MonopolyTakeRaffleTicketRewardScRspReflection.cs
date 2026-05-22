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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CilNb25vcG9seVRha2VSYWZmbGVUaWNrZXRSZXdhcmRTY1JzcC5wcm90bxoO";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "SXRlbUxpc3QucHJvdG8igAEKI01vbm9wb2x5VGFrZVJhZmZsZVRpY2tldFJl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "d2FyZFNjUnNwEh4KC3Jld2FyZF9saXN0GAMgASgLMgkuSXRlbUxpc3QSDwoH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "cmV0Y29kZRgMIAEoDRITCgtNQk1JQ0NKRUJKQhgNIAEoDRITCgtDQk9NSENE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "TkVERxgOIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyTakeRaffleTicketRewardScRsp), MonopolyTakeRaffleTicketRewardScRsp.Parser, new string[4] { "RewardList", "Retcode", "MBMICCJEBJB", "CBOMHCDNEDG" }, null, null, null, null)
		}));
	}
}
