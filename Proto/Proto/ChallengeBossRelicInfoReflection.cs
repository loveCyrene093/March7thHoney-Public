using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChallengeBossRelicInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChallengeBossRelicInfoReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChxDaGFsbGVuZ2VCb3NzUmVsaWNJbmZvLnByb3RvGhBSZWxpY0FmZml4LnBy";
		buffer[1] = "b3RvIoMBChZDaGFsbGVuZ2VCb3NzUmVsaWNJbmZvEiMKDnN1Yl9hZmZpeF9s";
		buffer[2] = "aXN0GAIgAygLMgsuUmVsaWNBZmZpeBIRCgl1bmlxdWVfaWQYAyABKA0SFQoN";
		buffer[3] = "bWFpbl9hZmZpeF9pZBgEIAEoDRILCgN0aWQYDCABKA0SDQoFbGV2ZWwYDSAB";
		buffer[4] = "KA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { RelicAffixReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChallengeBossRelicInfo), ChallengeBossRelicInfo.Parser, new string[5] { "SubAffixList", "UniqueId", "MainAffixId", "Tid", "Level" }, null, null, null, null)
		}));
	}
}
