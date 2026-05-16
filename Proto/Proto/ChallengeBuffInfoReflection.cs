using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChallengeBuffInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChallengeBuffInfoReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChdDaGFsbGVuZ2VCdWZmSW5mby5wcm90bxobQ2hhbGxlbmdlQm9zc0J1ZmZJ";
		buffer[1] = "bmZvLnByb3RvGhxDaGFsbGVuZ2VTdG9yeUJ1ZmZJbmZvLnByb3RvIn4KEUNo";
		buffer[2] = "YWxsZW5nZUJ1ZmZJbmZvEi0KCnN0b3J5X2luZm8YAiABKAsyFy5DaGFsbGVu";
		buffer[3] = "Z2VTdG9yeUJ1ZmZJbmZvSAASKwoJYm9zc19pbmZvGAggASgLMhYuQ2hhbGxl";
		buffer[4] = "bmdlQm9zc0J1ZmZJbmZvSABCDQoLQlBJSEZBSkNMT0NCFqoCE01hcmNoN3Ro";
		buffer[5] = "SG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			ChallengeBossBuffInfoReflection.Descriptor,
			ChallengeStoryBuffInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChallengeBuffInfo), ChallengeBuffInfo.Parser, new string[2] { "StoryInfo", "BossInfo" }, new string[1] { "BPIHFAJCLOC" }, null, null, null)
		}));
	}
}
