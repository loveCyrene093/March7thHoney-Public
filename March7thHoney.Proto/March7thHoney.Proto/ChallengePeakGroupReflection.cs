using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChallengePeakGroupReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChallengePeakGroupReflection()
	{
		InlineArray10<string> buffer = default(InlineArray10<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 0) = "ChhDaGFsbGVuZ2VQZWFrR3JvdXAucHJvdG8aE0NoYWxsZW5nZVBlYWsucHJv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 1) = "dG8aF0NoYWxsZW5nZVBlYWtCb3NzLnByb3RvGhFGQ1BFS0tFRUtGSS5wcm90";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 2) = "bxoVV2FpdENvbmZpcm1EYXRhLnByb3RvIqgCChJDaGFsbGVuZ2VQZWFrR3Jv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 3) = "dXASFQoNcGVha19ncm91cF9pZBgCIAEoDRIWCg5jb3VudF9vZl9wZWFrcxgD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 4) = "IAEoDRIrChF3YWl0X2NvbmZpcm1fZGF0YRgEIAEoCzIQLldhaXRDb25maXJt";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 5) = "RGF0YRIlCglwZWFrX2Jvc3MYBSABKAsyEi5DaGFsbGVuZ2VQZWFrQm9zcxId";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 6) = "CgVwZWFrcxgGIAMoCzIOLkNoYWxsZW5nZVBlYWsSGQoRZGlzYWJsZV9oYXJk";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 7) = "X21vZGUYCiABKAgSIQoLUExKTFBPSEpIRUUYCyABKAsyDC5GQ1BFS0tFRUtG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 8) = "SRIaChJ0YWtlbl9zdGFyX3Jld2FyZHMYDSADKA0SFgoOb2J0YWluZWRfc3Rh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 9) = "cnMYDiABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray10<string>, string>(in buffer, 10))), new FileDescriptor[4]
		{
			ChallengePeakReflection.Descriptor,
			ChallengePeakBossReflection.Descriptor,
			FCPEKKEEKFIReflection.Descriptor,
			WaitConfirmDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChallengePeakGroup), ChallengePeakGroup.Parser, new string[9] { "PeakGroupId", "CountOfPeaks", "WaitConfirmData", "PeakBoss", "Peaks", "DisableHardMode", "PLJLPOHJHEE", "TakenStarRewards", "ObtainedStars" }, null, null, null, null)
		}));
	}
}
