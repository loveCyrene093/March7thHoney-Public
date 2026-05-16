using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChallengePeakLineupReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChallengePeakLineupReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChlDaGFsbGVuZ2VQZWFrTGluZXVwLnByb3RvGhFFRUJQSEpDTkJGTy5wcm90";
		buffer[1] = "byJmChNDaGFsbGVuZ2VQZWFrTGluZXVwEiEKC0ZNRkdPSkhDQ05MGAEgAygL";
		buffer[2] = "MgwuRUVCUEhKQ05CRk8SDwoHcGVha19pZBgDIAEoDRIbChNwZWFrX2F2YXRh";
		buffer[3] = "cl9pZF9saXN0GAwgAygNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90";
		buffer[4] = "bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { EEBPHJCNBFOReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChallengePeakLineup), ChallengePeakLineup.Parser, new string[3] { "FMFGOJHCCNL", "PeakId", "PeakAvatarIdList" }, null, null, null, null)
		}));
	}
}
