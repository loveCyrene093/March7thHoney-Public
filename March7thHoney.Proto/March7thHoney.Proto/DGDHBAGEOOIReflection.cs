using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DGDHBAGEOOIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DGDHBAGEOOIReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChFER0RIQkFHRU9PSS5wcm90byKzAQoLREdESEJBR0VPT0kSEwoLQU9MRkZP";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "TEVKTEIYAyABKAgSEwoLREtMSU9OUEtJSUoYBCABKA0SEwoLRlBNQ0ZKRE9N";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "RE0YBSABKA0SEwoLTE9HUEtDS05KRUwYBiABKA0SEQoJYmF0dGxlX2lkGAgg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "ASgNEhMKC0pMRUxCQ0ZPQktOGAsgASgNEhMKC0pBTkRCQkdMSkVPGA4gASgN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "EhMKC0tHS0ZBRERFR05KGA8gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "YgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DGDHBAGEOOI), DGDHBAGEOOI.Parser, new string[8] { "AOLFFOLEJLB", "DKLIONPKIIJ", "FPMCFJDOMDM", "LOGPKCKNJEL", "BattleId", "JLELBCFOBKN", "JANDBBGLJEO", "KGKFADDEGNJ" }, null, null, null, null)
		}));
	}
}
