using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeHipplenEndingRewardScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeHipplenEndingRewardScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CiJUYWtlSGlwcGxlbkVuZGluZ1Jld2FyZFNjUnNwLnByb3RvGg5JdGVtTGlz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "dC5wcm90byJkChxUYWtlSGlwcGxlbkVuZGluZ1Jld2FyZFNjUnNwEh4KC3Jl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "d2FyZF9saXN0GAIgASgLMgkuSXRlbUxpc3QSEwoLREtQQ0RMRERPTkcYDSAB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "KA0SDwoHcmV0Y29kZRgOIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "cHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeHipplenEndingRewardScRsp), TakeHipplenEndingRewardScRsp.Parser, new string[3] { "RewardList", "DKPCDLDDONG", "Retcode" }, null, null, null, null)
		}));
	}
}
