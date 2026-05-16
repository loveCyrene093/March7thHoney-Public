using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeRogueMiracleHandbookRewardScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeRogueMiracleHandbookRewardScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CilUYWtlUm9ndWVNaXJhY2xlSGFuZGJvb2tSZXdhcmRTY1JzcC5wcm90bxoO";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "SXRlbUxpc3QucHJvdG8iZgojVGFrZVJvZ3VlTWlyYWNsZUhhbmRib29rUmV3";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "YXJkU2NSc3ASEwoLQUdGT01LT0lBRUIYASADKA0SDwoHcmV0Y29kZRgIIAEo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "DRIZCgZyZXdhcmQYDCABKAsyCS5JdGVtTGlzdEIWqgITTWFyY2g3dGhIb25l";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "eS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeRogueMiracleHandbookRewardScRsp), TakeRogueMiracleHandbookRewardScRsp.Parser, new string[3] { "AGFOMKOIAEB", "Retcode", "Reward" }, null, null, null, null)
		}));
	}
}
