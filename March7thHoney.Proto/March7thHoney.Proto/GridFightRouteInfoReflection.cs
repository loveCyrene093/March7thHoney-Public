using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightRouteInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightRouteInfoReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChhHcmlkRmlnaHRSb3V0ZUluZm8ucHJvdG8aHEdyaWRGaWdodEVuY291bnRl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "ckluZm8ucHJvdG8iewoSR3JpZEZpZ2h0Um91dGVJbmZvEhUKDWZpZ2h0X2Nh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "bXBfaWQYAiABKA0SFwoPZWxpdGVfYnJhbmNoX2lkGAcgASgNEjUKFHJvdXRl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "X2VuY291bnRlcl9saXN0GAwgAygLMhcuR3JpZEZpZ2h0RW5jb3VudGVySW5m";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "b0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { GridFightEncounterInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightRouteInfo), GridFightRouteInfo.Parser, new string[3] { "FightCampId", "EliteBranchId", "RouteEncounterList" }, null, null, null, null)
		}));
	}
}
