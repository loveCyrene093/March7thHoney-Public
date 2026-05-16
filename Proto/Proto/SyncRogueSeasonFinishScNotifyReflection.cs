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
		buffer[0] = "CiNTeW5jUm9ndWVTZWFzb25GaW5pc2hTY05vdGlmeS5wcm90bxoRQkdLSU5D";
		buffer[1] = "RkdLR0kucHJvdG8aEUpNSUlGT01GT0dPLnByb3RvGhBMaW5ldXBJbmZvLnBy";
		buffer[2] = "b3RvGg9TY2VuZUluZm8ucHJvdG8isgEKHVN5bmNSb2d1ZVNlYXNvbkZpbmlz";
		buffer[3] = "aFNjTm90aWZ5EiEKC2ZpbmlzaF9pbmZvGAIgASgLMgwuSk1JSUZPTUZPR08S";
		buffer[4] = "EwoLT0lGS05KQUZHREMYBSABKAgSIQoLQUhCRkFBTU5LTk8YBiABKAsyDC5C";
		buffer[5] = "R0tJTkNGR0tHSRIbCgZsaW5ldXAYCiABKAsyCy5MaW5ldXBJbmZvEhkKBXNj";
		buffer[6] = "ZW5lGA0gASgLMgouU2NlbmVJbmZvQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv";
		buffer[7] = "YgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[4]
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
