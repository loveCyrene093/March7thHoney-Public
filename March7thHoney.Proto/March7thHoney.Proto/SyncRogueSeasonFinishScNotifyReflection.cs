using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SyncRogueSeasonFinishScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SyncRogueSeasonFinishScNotifyReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 0) = "CiNTeW5jUm9ndWVTZWFzb25GaW5pc2hTY05vdGlmeS5wcm90bxoRQkdLSU5D";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 1) = "RkdLR0kucHJvdG8aEUpNSUlGT01GT0dPLnByb3RvGhBMaW5ldXBJbmZvLnBy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 2) = "b3RvGg9TY2VuZUluZm8ucHJvdG8isgEKHVN5bmNSb2d1ZVNlYXNvbkZpbmlz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 3) = "aFNjTm90aWZ5EiEKC2ZpbmlzaF9pbmZvGAIgASgLMgwuSk1JSUZPTUZPR08S";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 4) = "EwoLT0lGS05KQUZHREMYBSABKAgSIQoLQUhCRkFBTU5LTk8YBiABKAsyDC5C";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 5) = "R0tJTkNGR0tHSRIbCgZsaW5ldXAYCiABKAsyCy5MaW5ldXBJbmZvEhkKBXNj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 6) = "ZW5lGA0gASgLMgouU2NlbmVJbmZvQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 7) = "YgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray8<string>, string>(in buffer, 8))), new FileDescriptor[4]
		{
			BGKINCFGKGIReflection.Descriptor,
			JMIIFOMFOGOReflection.Descriptor,
			LineupInfoReflection.Descriptor,
			SceneInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SyncRogueSeasonFinishScNotify), SyncRogueSeasonFinishScNotify.Parser, new string[5] { "FinishInfo", "OIFKNJAFGDC", "AHBFAAMNKNO", "Lineup", "Scene" }, null, null, null, null)
		}));
	}
}
