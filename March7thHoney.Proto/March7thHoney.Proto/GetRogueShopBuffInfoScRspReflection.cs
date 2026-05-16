using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetRogueShopBuffInfoScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetRogueShopBuffInfoScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "Ch9HZXRSb2d1ZVNob3BCdWZmSW5mb1NjUnNwLnByb3RvGhJJdGVtQ29zdERh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "dGEucHJvdG8aEVBITUJKS01LTURLLnByb3RvIp0BChlHZXRSb2d1ZVNob3BC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "dWZmSW5mb1NjUnNwEhMKC0NBRkJBS0ZCTklOGAMgASgFEiIKC0FLT0NPQUxE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "RUhDGAQgASgLMg0uSXRlbUNvc3REYXRhEg8KB3JldGNvZGUYBiABKA0SEwoL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "TkVEUE5GREhJR0YYCyABKAUSIQoLSEtHS05FS0tKSEIYDiABKAsyDC5QSE1C";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "SktNS01ES0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[2]
		{
			ItemCostDataReflection.Descriptor,
			PHMBJKMKMDKReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetRogueShopBuffInfoScRsp), GetRogueShopBuffInfoScRsp.Parser, new string[5] { "CAFBAKFBNIN", "AKOCOALDEHC", "Retcode", "NEDPNFDHIGF", "HKGKNEKKJHB" }, null, null, null, null)
		}));
	}
}
