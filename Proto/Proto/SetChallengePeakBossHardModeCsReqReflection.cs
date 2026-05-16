using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SetChallengePeakBossHardModeCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SetChallengePeakBossHardModeCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CidTZXRDaGFsbGVuZ2VQZWFrQm9zc0hhcmRNb2RlQ3NSZXEucHJvdG8iUAoh" + "U2V0Q2hhbGxlbmdlUGVha0Jvc3NIYXJkTW9kZUNzUmVxEhUKDXBlYWtfZ3Jv" + "dXBfaWQYBCABKA0SFAoMaXNfaGFyZF9tb2RlGAYgASgIQhaqAhNNYXJjaDd0" + "aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetChallengePeakBossHardModeCsReq), SetChallengePeakBossHardModeCsReq.Parser, new string[2] { "PeakGroupId", "IsHardMode" }, null, null, null, null)
		}));
	}
}
