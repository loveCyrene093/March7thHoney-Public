using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BattleRogueMagicInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BattleRogueMagicInfoReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChpCYXR0bGVSb2d1ZU1hZ2ljSW5mby5wcm90bxoRRklITUVIS0NEQUwucHJv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "dG8aEU5HSlBKQU5MREhJLnByb3RvIlwKFEJhdHRsZVJvZ3VlTWFnaWNJbmZv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "EiEKC0lNUE9FSElPQ0JDGAEgASgLMgwuTkdKUEpBTkxESEkSIQoLZGV0YWls";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "X2luZm8YAiABKAsyDC5GSUhNRUhLQ0RBTEIWqgITTWFyY2g3dGhIb25leS5Q";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "cm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			FIHMEHKCDALReflection.Descriptor,
			NGJPJANLDHIReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BattleRogueMagicInfo), BattleRogueMagicInfo.Parser, new string[2] { "IMPOEHIOCBC", "DetailInfo" }, null, null, null, null)
		}));
	}
}
