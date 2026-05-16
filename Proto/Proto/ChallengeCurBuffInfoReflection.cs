using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChallengeCurBuffInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChallengeCurBuffInfoReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChpDaGFsbGVuZ2VDdXJCdWZmSW5mby5wcm90bxobQ2hhbGxlbmdlQm9zc0J1";
		buffer[1] = "ZmZMaXN0LnByb3RvGhxDaGFsbGVuZ2VTdG9yeUJ1ZmZMaXN0LnByb3RvIosB";
		buffer[2] = "ChRDaGFsbGVuZ2VDdXJCdWZmSW5mbxIyCg9jdXJfc3RvcnlfYnVmZnMYAyAB";
		buffer[3] = "KAsyFy5DaGFsbGVuZ2VTdG9yeUJ1ZmZMaXN0SAASMAoOY3VyX2Jvc3NfYnVm";
		buffer[4] = "ZnMYDyABKAsyFi5DaGFsbGVuZ2VCb3NzQnVmZkxpc3RIAEINCgtCUElIRkFK";
		buffer[5] = "Q0xPQ0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			ChallengeBossBuffListReflection.Descriptor,
			ChallengeStoryBuffListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChallengeCurBuffInfo), ChallengeCurBuffInfo.Parser, new string[2] { "CurStoryBuffs", "CurBossBuffs" }, new string[1] { "BPIHFAJCLOC" }, null, null, null)
		}));
	}
}
