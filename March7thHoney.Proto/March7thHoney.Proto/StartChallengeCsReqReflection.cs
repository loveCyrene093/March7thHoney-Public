using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class StartChallengeCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static StartChallengeCsReqReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "ChlTdGFydENoYWxsZW5nZUNzUmVxLnByb3RvGhdDaGFsbGVuZ2VCdWZmSW5m";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "by5wcm90bxoRRUVCUEhKQ05CRk8ucHJvdG8ixgEKE1N0YXJ0Q2hhbGxlbmdl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "Q3NSZXESIQoLQUJOREZLRklLQ0kYAiADKAsyDC5FRUJQSEpDTkJGTxIUCgxj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "aGFsbGVuZ2VfaWQYBSABKA0SJgoKc3RhZ2VfaW5mbxgIIAEoCzISLkNoYWxs";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "ZW5nZUJ1ZmZJbmZvEhUKDXNlY29uZF9saW5ldXAYCiADKA0SFAoMZmlyc3Rf";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "bGluZXVwGAsgAygNEiEKC0JLTktMRU9DSk5PGA0gAygLMgwuRUVCUEhKQ05C";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "Rk9CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[2]
		{
			ChallengeBuffInfoReflection.Descriptor,
			EEBPHJCNBFOReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(StartChallengeCsReq), StartChallengeCsReq.Parser, new string[6] { "ABNDFKFIKCI", "ChallengeId", "StageInfo", "SecondLineup", "FirstLineup", "BKNKLEOCJNO" }, null, null, null, null)
		}));
	}
}
