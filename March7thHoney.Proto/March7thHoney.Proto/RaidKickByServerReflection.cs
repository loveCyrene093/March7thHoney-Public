using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RaidKickByServerReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RaidKickByServerReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChZSYWlkS2lja0J5U2VydmVyLnByb3RvGhFBQU5DR09GQ0pKTC5wcm90bxoQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "TGluZXVwSW5mby5wcm90bxoPU2NlbmVJbmZvLnByb3RvIo4BChBSYWlkS2lj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "a0J5U2VydmVyEhkKBXNjZW5lGAIgASgLMgouU2NlbmVJbmZvEg8KB3JhaWRf";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "aWQYAyABKA0SGwoGbGluZXVwGAQgASgLMgsuTGluZXVwSW5mbxIcCgZyZWFz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "b24YCyABKA4yDC5BQU5DR09GQ0pKTBITCgt3b3JsZF9sZXZlbBgOIAEoDUIW";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[3]
		{
			AANCGOFCJJLReflection.Descriptor,
			LineupInfoReflection.Descriptor,
			SceneInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RaidKickByServer), RaidKickByServer.Parser, new string[5] { "Scene", "RaidId", "Lineup", "Reason", "WorldLevel" }, null, null, null, null)
		}));
	}
}
