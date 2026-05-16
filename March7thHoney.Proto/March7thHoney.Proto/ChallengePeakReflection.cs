using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChallengePeakReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChallengePeakReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "ChNDaGFsbGVuZ2VQZWFrLnByb3RvGhhDaGFsbGVuZ2VQZWFrQnVpbGQucHJv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "dG8aEUVFQlBISkNOQkZPLnByb3RvItUBCg1DaGFsbGVuZ2VQZWFrEiEKC0ZN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "RkdPSkhDQ05MGAEgAygLMgwuRUVCUEhKQ05CRk8SDwoHcGVha19pZBgDIAEo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "DRIsCg9wZWFrX2J1aWxkX2xpc3QYBSADKAsyEy5DaGFsbGVuZ2VQZWFrQnVp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "bGQSHAoUZmluaXNoZWRfdGFyZ2V0X2xpc3QYBiADKA0SEgoKaGFzX3Bhc3Nl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "ZBgHIAEoCBITCgtjeWNsZXNfdXNlZBgLIAEoDRIbChNwZWFrX2F2YXRhcl9p";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "ZF9saXN0GAwgAygNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[2]
		{
			ChallengePeakBuildReflection.Descriptor,
			EEBPHJCNBFOReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChallengePeak), ChallengePeak.Parser, new string[7] { "FMFGOJHCCNL", "PeakId", "PeakBuildList", "FinishedTargetList", "HasPassed", "CyclesUsed", "PeakAvatarIdList" }, null, null, null, null)
		}));
	}
}
